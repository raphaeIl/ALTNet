using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LZ4;

namespace ALTNet.GameServer.Packets
{
    public sealed class SimpleObjectPool<T>
    {
        
        public SimpleObjectPool(Func<T> factoryMethod)
        {
            this.factoryMethod = factoryMethod;
        }
        
        public T CreateInstance()
        {
            T result;
            if (this.objects.TryDequeue(out result))
            {
                return result;
            }
            return this.factoryMethod();
        }

        
        public void ToRecycleBin(T item)
        {
            this.objects.Enqueue(item);
        }

        
        private readonly ConcurrentQueue<T> objects = new ConcurrentQueue<T>();

        
        private readonly Func<T> factoryMethod;
    }

    internal sealed class TailBuffer
    {
        
        private TailBuffer()
        {
        }

        
        
        public byte[] Data
        {
            get
            {
                return this.data;
            }
        }

        
        
        public int Offset
        {
            get
            {
                return this.size;
            }
        }

        
        
        public bool IsFull
        {
            get
            {
                return this.data.Length == this.size;
            }
        }

        
        public static TailBuffer Create()
        {
            return TailBuffer.pool.CreateInstance();
        }

        
        public static TailBuffer Create(byte[] data, int offset, int size)
        {
            TailBuffer tailBuffer = TailBuffer.pool.CreateInstance();
            tailBuffer.FillData(data, offset, size);
            return tailBuffer;
        }

        
        public int AddData(byte[] data, int offset, int size)
        {
            int num = Math.Min(this.data.Length - this.size, size);
            Buffer.BlockCopy(data, offset, this.data, this.size, num);
            this.size += num;
            return num;
        }

        
        public void ToRecycleBin()
        {
            this.size = 0;
            TailBuffer.pool.ToRecycleBin(this);
        }

        
        private void FillData(byte[] data, int offset, int size)
        {
            this.size = Math.Min(this.data.Length, size);
            Buffer.BlockCopy(data, offset, this.data, 0, this.size);
        }

        
        private const int BufferSize = 4096;

        
        private static SimpleObjectPool<TailBuffer> pool = new SimpleObjectPool<TailBuffer>(() => new TailBuffer());

        
        private readonly byte[] data = new byte[4096];

        
        private int size;
    }

    public sealed class ZeroCopyBuffer
    {
        public int SegmentCount
        {
            get
            {
                return this.tailBuffers.Count;
            }
        }
        
        public int CalcTotalSize()
        {
            int num = 0;
            foreach (TailBuffer tailBuffer in this.tailBuffers)
            {
                num += tailBuffer.Offset;
            }
            return num;
        }
        
        public BinaryWriter GetWriter()
        {
            return new BinaryWriter(new ZeroCopyOutputStream(this));
        }
        
        public BinaryReader GetReader()
        {
            return new BinaryReader(new ZeroCopyInputStream(this));
        }

        
        public Stream GetOutputStream()
        {
            return new ZeroCopyOutputStream(this);
        }

        
        public IDisposable Hold()
        {
            return new ZeroCopyBuffer.Cleaner(this);
        }


        public void Lz4Compress()
        {
            TailBuffer[] array = this.Move();
            using (ZeroCopyOutputStream zeroCopyOutputStream = new ZeroCopyOutputStream(this))
            {
                using (LZ4Stream lz4Stream = new LZ4Stream(zeroCopyOutputStream, LZ4StreamMode.Compress, LZ4StreamFlags.None, 1048576))
                {
                    foreach (TailBuffer tailBuffer in array)
                    {
                        lz4Stream.Write(tailBuffer.Data, 0, tailBuffer.Offset);
                        tailBuffer.ToRecycleBin();
                    }
                }
            }
        }

        public void Encrypt()
        {
            if (this.tailBuffers.Count > 1)
            {
                throw new Exception(string.Format("[ZeroCopyBuffer] encryption only support single tail. #tail:{0}", this.tailBuffers.Count));
            }
            if (this.tailBuffers.Count == 0)
            {
                return;
            }
            int num = 0;
            Crypto.Encrypt(this.last.Data, this.last.Offset, ref num);
        }
        
        internal TailBuffer Peek()
        {
            return this.tailBuffers.Peek();
        }
        
        internal void PopHeadSegment()
        {
            this.tailBuffers.Dequeue().ToRecycleBin();
            if (this.tailBuffers.Count == 0)
            {
                this.last = null;
            }
        }

        
        internal void Write(byte[] buffer, int offset, int count)
        {
            while (count > 0)
            {
                if (this.last == null || this.last.IsFull)
                {
                    this.last = TailBuffer.Create();
                    this.tailBuffers.Enqueue(this.last);
                }
                int num = this.last.AddData(buffer, offset, count);
                offset += num;
                count -= num;
            }
        }

        
        internal TailBuffer[] Move()
        {
            TailBuffer[] result = this.tailBuffers.ToArray();
            this.tailBuffers.Clear();
            this.last = null;
            return result;
        }

        
        internal TailBuffer[] GetView()
        {
            return this.tailBuffers.ToArray();
        }

        
        public string ToBase64()
        {
            if (this.tailBuffers.Count > 1)
            {
                throw new Exception(string.Format("[ZeroCopyBuffer] ToBase64 only support single tail. #tail:{0}", this.tailBuffers.Count));
            }
            return Convert.ToBase64String(this.last.Data, 0, this.last.Offset);
        }

        
        private readonly Queue<TailBuffer> tailBuffers = new Queue<TailBuffer>();
        
        private TailBuffer last;
        
        private sealed class Cleaner : IDisposable
        {
            
            public Cleaner(ZeroCopyBuffer buffer)
            {
                this.buffer = buffer;
            }

            
            public void Dispose()
            {
                foreach (TailBuffer tailBuffer in this.buffer.tailBuffers)
                {
                    tailBuffer.ToRecycleBin();
                }
                this.buffer.tailBuffers.Clear();
                this.buffer.last = null;
            }

            
            private readonly ZeroCopyBuffer buffer;
        }
    }

    internal sealed class ZeroCopyOutputStream : Stream
    {
        
        public ZeroCopyOutputStream(ZeroCopyBuffer buffer)
        {
            this.buffer = buffer;
        }

        
        
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }

        
        
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        
        
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        
        
        public override long Length
        {
            get
            {
                return (long)this.buffer.CalcTotalSize();
            }
        }

        
        
        
        public override long Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        
        public override void Flush()
        {
        }

        
        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        
        public override void Write(byte[] buffer, int offset, int count)
        {
            this.buffer.Write(buffer, offset, count);
        }

        
        private readonly ZeroCopyBuffer buffer;
    }

    public sealed class ZeroCopyInputStream : Stream
    {
        
        public ZeroCopyInputStream(ZeroCopyBuffer buffer)
        {
            this.tailBuffers = buffer.GetView();
            this.totalSize = buffer.CalcTotalSize();
            this.Length = (long)this.totalSize;
        }

        
        public ZeroCopyInputStream(ZeroCopyBuffer buffer, int fixedOffset)
        {
            this.tailBuffers = buffer.GetView();
            this.totalSize = buffer.CalcTotalSize();
            if (fixedOffset < 0 || fixedOffset > this.totalSize)
            {
                throw new Exception(string.Format("[ZeroCopyInputStream] invalid offset. fixed:{0} length:{1}", fixedOffset, this.Length));
            }
            this.fixedOffset = fixedOffset;
            this.Length = (long)(this.totalSize - this.fixedOffset);
            this.ResetOffset(this.fixedOffset);
        }

        
        
        public override bool CanRead
        {
            get
            {
                return this.IsReadable();
            }
        }

        
        
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        
        
        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        
        
        public override long Length { get; }

        
        
        
        public override long Position
        {
            get
            {
                return (long)(this.CalcCurrentFullOffset() - this.fixedOffset);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        
        public override void Flush()
        {
        }

        
        public override int Read(byte[] buffer, int offset, int count)
        {
            int num = 0;
            while (this.CanRead)
            {
                TailBuffer tailBuffer = this.tailBuffers[this.index];
                if (this.offset > tailBuffer.Offset)
                {
                    throw new Exception(string.Format("memory offset error. this.offset:{0} buffer offset:{1}", this.offset, tailBuffer.Offset));
                }
                if (this.offset == tailBuffer.Offset)
                {
                    this.index++;
                    this.offset = 0;
                } else
                {
                    int num2 = Math.Min(count - num, tailBuffer.Offset - this.offset);
                    Buffer.BlockCopy(tailBuffer.Data, this.offset, buffer, offset + num, num2);
                    this.offset += num2;
                    num += num2;
                    if (num > count)
                    {
                        throw new Exception(string.Format("memory offset error. transferred:{0} count:{1}", num, count));
                    }
                    if (num == count)
                    {
                        break;
                    }
                }
            }
            return num;
        }

        
        public override long Seek(long offset, SeekOrigin origin)
        {
            int num = 0;
            switch (origin)
            {
                case SeekOrigin.Begin:
                    num = this.fixedOffset + (int)offset;
                    break;
                case SeekOrigin.Current:
                    num = this.CalcCurrentFullOffset() + (int)offset;
                    break;
                case SeekOrigin.End:
                    num = (int)(this.Length - offset);
                    break;
            }
            this.ResetOffset(num);
            return (long)num;
        }

        
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        
        private void ResetOffset(int offset)
        {
            if (offset > this.totalSize)
            {
                throw new Exception(string.Format("[ZeroCopyInputStream] invalid offset:{0} length:{1}", offset, this.totalSize));
            }
            this.index = 0;
            this.offset = offset;
            for (int i = 0; i < this.tailBuffers.Length; i++)
            {
                TailBuffer tailBuffer = this.tailBuffers[i];
                if (this.offset < tailBuffer.Offset)
                {
                    break;
                }
                this.index++;
                this.offset -= tailBuffer.Offset;
            }
            if (this.index >= this.tailBuffers.Length && this.offset > 0)
            {
                throw new Exception(string.Format("index:{0} buffers:{1} offset:{2}", this.index, this.tailBuffers.Length, this.offset));
            }
        }

        
        private bool IsReadable()
        {
            if (this.tailBuffers.Length == 0)
            {
                return false;
            }
            if (this.index < this.tailBuffers.Length)
            {
                return this.index < this.tailBuffers.Length || this.offset < this.tailBuffers[this.index].Offset;
            }
            if (this.offset == 0)
            {
                return false;
            }
            throw new Exception(string.Format("invalid index:{0} #buffer:{1} offset:{2}", this.index, this.tailBuffers.Length, this.offset));
        }

        
        private int CalcCurrentFullOffset()
        {
            int num = this.offset;
            for (int i = 0; i < this.index; i++)
            {
                num += this.tailBuffers[i].Offset;
            }
            return num;
        }

        
        private readonly TailBuffer[] tailBuffers;

        
        private readonly int totalSize;

        
        private readonly int fixedOffset;

        
        private int index;

        
        private int offset;

        public static List<string> ContentsTag = [
        "GLOBAL",
        "LANGUAGE_ENG",
        "LANGUAGE_KOR",
        "LANGUAGE_FRA",
        "LANGUAGE_DEU",
        "LANGUAGE_JPN",
        "TAG_ALL_NOT_USED",
        "TAG_GLOBAL_NOT_USED",
        "OPEN_TAG_INTERVAL_SPLIT",
        "OPEN_TAG_CONTRACT",
        "OPEN_TAG_MISSION",
        "OPEN_TAG_PIECE",
        "OPEN_TAG_REWARD",
        "OPEN_TAG_EPISODE_TAB",
        "OPEN_TAG_ATTENDANCE",
        "OPEN_TAG_FIERCE",
        "OPEN_TAG_MOLD",
        "OPEN_TAG_DIFFICULTY",
        "OPEN_UNIT_SOURCE_TYPE",
        "CONTENTS_OPEN_USERTITLE",
        "LOGO_CLB_001_RENEWAL",
        "COPYRIGHT_CLB_001",
        "DEFAULT_VOICE_VKOR",
        "VOICE_KOR",
        "VOICE_JPN",
        "MONSTER_TAG_GLOBAL",
        "DIVE_30",
        "DIVE_35",
        "DIVE_40",
        "DIVE_45",
        "DIVE_50",
        "DIVE_55",
        "DIVE_60",
        "DIVE_SKIP",
        "SHADOW_PALACE_1",
        "SHADOW_PALACE_2",
        "SHADOW_PALACE_3",
        "SHADOW_PALACE_4",
        "SHADOW_PALACE_5",
        "UNLOCK_PROFILE_ON",
        "UNLOCK_LEADERBOARD_ON",
        "UNLOCK_GUILD_ON",
        "UNLOCK_SHADOW_PALACE_ON",
        "UNLOCK_OPERATION_MULTIPLY_ON",
        "UNLOCK_MARKET_REVIEW_OVERSEAS",
        "UNLOCK_SUBTITLE_ON",
        "UNLOCK_FIERCE_ON",
        "OPERATOR",
        "UNLOCK_GUILD_DUNGEON_ON",
        "UNLOCK_SUPPLY_ON",
        "UNLOCK_CHALLENGE",
        "UNLOCK_EQUIP_UPGRADE",
        "UNLOCK_EQUIP_HIDDEN_OPTION",
        "UNLOCK_SHIP_LIMITBREAK",
        "UNLOCK_SHIP_COMMANDMODULE",
        "UNLOCK_TACTIC_UPDATE",
        "UNLOCK_DIMENSION_TRIM",
        "UNLOCK_PVP_EVENTMATCH",
        "UNLOCK_SIDE_STORY_FAILURE",
        "OFFICE_ROOM",
        "OFFICE_ROOM_SHOP_HOME",
        "OFFICE_ROOM_SHOP_COMMON",
        "REARMAMENT_BASE",
        "REARMAMENT_GUIDE",
        "TAG_COMMON_DIVE_SCAVENGER",
        "TAG_EPISODE_SUPPLY_RESOURCE_NO_HARD",
        "TAG_COMMON_EPISODE_SUPPLY_CREDIT",
        "CONVERT_RELIC_MATERIAL",
        "CONVERT_AWAKEN_PIECE",
        "CONVERT_SERVICE_TRANSFER",
        "SYSTEM_OPERATOR",
        "SYSTEM_CLASSIFIED_DOC",
        "SYSTEM_TRANSCENDENCE",
        "SYSTEM_FIERCE",
        "SYSTEM_SHADOW",
        "SYSTEM_GUILD_DUNGEON",
        "SYSTEM_TIMEATTACK",
        "SYSTEM_DEFENCE",
        "SYSTEM_DIVE_SKIP",
        "GUILD_LEVEL_20",
        "GUILD_WELFARE",
        "UNIT_CC_GUIDE",
        "REACTOR_GUIDE",
        "EQUIP_HIDDEN_OPTION_COLOR",
        "TAG_GLOBAL_FIERCE_SEASON_S2_1",
        "TAG_GLOBAL_FIERCE_SEASON_S2_ISSUE",
        "DROP_A_EVENT_GLOBAL_HOLY_DAY_23",
        "GLOBAL_EVENT_PASS_UNIT_BARCODE_C_CHILDREN",
        "GLOBAL_EVENT_PASS_UNIT_REPLACER_CA_KING",
        "GLOBAL_EVENT_PASS_UNIT_C_ADMIN_ARTILLERY",
        "GLOBAL_EVENT_PASS_UNIT_CORRUPTED_C_SHADOW",
        "GLOBAL_EVENT_PASS_UNIT_C_ESPR_FROZEN",
        "GLOBAL_EVENT_PASS_UNIT_C_SCHOOL_CHAIR",
        "GLOBAL_EVENT_PASS_HORIZON_M_LOAN",
        "GLOBAL_EVENT_PASS_S_MILITIA_JIHUN",
        "GLOBAL_EVENT_PASS_UNIT_ALPHA_C_SPEAR",
        "GLOBAL_EVENT_PASS_V2_KNIGHT_C_FLAG",
        "GLOBAL_EVENT_PASS_V2_UNIT_CORRUPTED_M_ARMOR",
        "GLOBAL_EVENT_PASS_V2_UNIT_REPLACER_C_KNIGHT_AP",
        "GLOBAL_EVENT_PASS_V2_UNIT_KNIGHT_C_EMPEROR",
        "GLOBAL_EVENT_PASS_V2_UNIT_VATICAN_C_BOOK",
        "GLOBAL_EVENT_PASS_V2_UNIT_ESPR_C_SWORD",
        "GLOBAL_EVENT_PASS_V2_UNIT_OZ_M_PUPPET",
        "SHIP_A_COFFIN",
        "SHIP_PATROL_VEHCLE_ALT",
        "SHIP_A_GAMECHANGER",
        "SHIP_C_BALISADA",
        "SHIP_C_ARONDIGHT",
        "SHIP_H_NORMANDIE",
        "SHIP_H_ENTERPRISE",
        "SHIP_X_STELLA",
        "SHIP_X_ABRAHAM",
        "SHIP_A_RAZANGRIFF",
        "SHIP_H_BAYREN",
        "SHIP_A_GRAYSTATION",
        "SHIP_C_KAMI_ISUMI",
        "SHIP_A_GLEIPNIR",
        "SHIP_H_GLEIPNIR_ARMOR",
        "SHIP_X_GLEIPNIR_MISSILE",
        "SHIP_A_NEW_OHIO",
        "SHIP_C_NEW_OHIO_THERMAL",
        "SHIP_X_RAZANGRIFF_BIO",
        "SHIP_A_DOMINION",
        "SHIP_X_DOMINION_AIRCRAFT",
        "SHIP_ETC_RUBBER_DUCK",
        "SHIP_X_COFFIN_SIX",
        "SHIP_C_ALBION",
        "SHIP_PATROL_VEHCLE_ESPR",
        "SHIP_A_BRIDGE",
        "SHIP_A_SCAVENGER",
        "SHIP_ETC_PANDA",
        "SHIP_X_AHAB",
        "SHIP_H_LEVATEIN",
        "SHIP_A_DOMINION_QUAD",
        "SHIP_H_TEMPEST",
        "ATTEND_MONTHLY_2106",
        "ATTEND_MONTHLY_2107",
        "ATTEND_MONTHLY_2108",
        "ATTEND_MONTHLY_2109",
        "ATTEND_MONTHLY_2110",
        "ATTEND_MONTHLY_2111",
        "ATTEND_MONTHLY_2112",
        "ATTEND_MONTHLY_2206",
        "ATTEND_MONTHLY_2207",
        "ATTEND_MONTHLY_2208",
        "ATTEND_MONTHLY_2209",
        "ATTEND_MONTHLY_2210",
        "ATTEND_MONTHLY_2211",
        "ATTEND_MONTHLY_2212",
        "ATTEND_MONTHLY_2301",
        "ATTEND_MONTHLY_2302",
        "ATTEND_MONTHLY_2303",
        "ATTEND_MONTHLY_2304",
        "ATTEND_MONTHLY_2305",
        "ATTEND_MONTHLY_2306",
        "ATTEND_MONTHLY_2307",
        "ATTEND_MONTHLY_2308",
        "ATTEND_MONTHLY_2309",
        "ATTEND_MONTHLY_2310",
        "ATTEND_MONTHLY_2311",
        "ATTEND_MONTHLY_2312",
        "ATTEND_NEWBIE_ALWAYS",
        "ATTEND_EVENT_CBT",
        "TAG_ATTEND_EVENT_CBT_CASH",
        "ATTEND_EVENT_OBT",
        "ATTEND_RETURN_ALWAYS",
        "TAG_ATTEND_EVENT_ENCHANT_NEW_V2",
        "ATTEND_EVENT_50DAY",
        "ATTEND_EVENT_REPLACER",
        "ATTEND_EVENT_100DAY",
        "ATTEND_EVENT_30DAYS",
        "TAG_ATTEND_EVENT_EQUIP_ENCHANT",
        "TAG_ATTEND_EVENT_SPECIAL_SUMMER_2021",
        "TAG_ATTEND_EVENT_HORIZON",
        "TAG_ATTEND_EVENT_BLACK_11",
        "TAG_ATTEND_EVENT_7TIER_EQUIP",
        "TAG_ATTEND_EVENT_ADMIN",
        "TAG_ATTEND_EVENT_REARMAMENT_GLOBAL",
        "TAG_ATTEND_EVENT_BAM_10_V2",
        "TAG_ATTEND_EVENT_HARMONY",
        "TAG_ATTEND_EVENT_FAM_05",
        "TAG_ATTEND_EVENT_INTER_06",
        "TAG_ATTEND_EVENT_INTER_07",
        "TAG_ATTEND_EVENT_NIGHTMARE_ES",
        "TAG_ATTEND_EVENT_CASH_15DAY",
        "TAG_ATTEND_EVENT_ROYAL_SUP",
        "TAG_ATTEND_EVENT_INTER_08",
        "TAG_ATTEND_EVENT_ANNIVERSARY_1_G",
        "TAG_ATTEND_EVENT_HALLOWEEN_V3",
        "TAG_ATTEND_EVENT_ANNIVERSARY_1_5YEAR_G",
        "TAG_ATTEND_EVENT_ANNIVERSARY_2YEAR_G",
        "TAG_ATTEND_EVENT_CLB_003",
        "TAG_ATTEND_EVENT_XMAS_V3",
        "TAG_ATTEND_EVENT_SERVICE_TRANSFER",
        "TAG_ATTEND_EVENT_NEWYEAR_2023",
        "TAG_ATTEND_EVENT_EVE_3",
        "TAG_ATTNED_EVENT_GLOBAL_FIRST",
        "TAG_ATTEND_EVENT_VALEN_23",
        "TAG_ATTEND_EVENT_FOOLS_2023",
        "TAG_ATTEND_EVENT_SPRING_BLOSSOM_V2",
        "TAG_ATTEND_EVENT_BONUS",
        "TAG_ATTEND_EVENT_FAM_05_V2",
        "TAG_ATTEND_EVENT_CLB_001_V2",
        "MISSION_TAB_BINGO_JISOO",
        "MISSION_TAB_BINGO_NEWYEAR",
        "MISSION_TAB_BINGO_JAKE",
        "MISSION_TAB_EVENT_CROSSROAD",
        "MISSION_TAB_EVENT_NEWBIE",
        "MISSION_TAB_EVENT_NEWBIE_CBT",
        "MISSION_TAB_EVENT_STREGA",
        "MISSION_TAB_EVENT_MAID",
        "MISSION_TAB_PROJECT_XMAS",
        "MISSION_TAB_EVENT_KILLER",
        "MISSION_TAB_EVENT_ADMIN",
        "MISSION_TAB_EVENT_MILLITIA",
        "MISSION_TAB_VALENTINE_R",
        "MISSION_TAB_EVENT_ESPR",
        "MISSION_TAB_PROJECT_REPLACER_QUEEN",
        "MISSION_TAB_EVENT_SPRING_R",
        "MISSION_EVENT_PASS",
        "MISSION_FIERCE",
        "MISSION_BINGO_2020_CLASSIFIED",
        "MISSION_BINGO_2020_AUTUMN",
        "MISSION_BINGO_2020_NEWYEAR",
        "MISSION_BINGO_2021_JAKE",
        "MISSION_2020_ESPR",
        "MISSION_2020_SUMMER",
        "MISSION_2020_ADMIN",
        "MISSION_2020_CHUSEOK",
        "MISSION_2020_NEWBIE",
        "MISSION_2020_RETURN",
        "MISSION_2020_SIGMA",
        "MISSION_2020_CROSSROAD2",
        "MISSION_2020_HALLOWEEN",
        "MISSION_2020_STREGA",
        "MISSION_2020_MAID",
        "MISSION_PROJECT_NEWBIE",
        "MISSION_PROJECT_NEWBIE_92_5",
        "MISSION_PROJECT_NEWBIE_92_55",
        "MISSION_PROJECT_NEWBIE_95_1",
        "MISSION_PROJECT_NEWBIE_95_11",
        "MISSION_PROJECT_NEWBIE_97_66",
        "MISSION_PROJECT_NEWBIE_97_6",
        "MISSION_300DAYS",
        "MISSION_2020_XMAS",
        "MISSION_2020_KILLER",
        "MISSION_2021_MILITIA",
        "MISSION_2021_VALENTINE_R",
        "MISSION_REPLACER_QUEEN",
        "MISSION_2021_SPRING_R",
        "MISSION_TWN_CBT",
        "MISSION_TAB_2021_FOOLS",
        "MISSION_2021_FOOLS",
        "MISSION_TAB_SHADE",
        "MISSION_SHADE_1",
        "MISSION_SHADE_2",
        "MISSION_USER_LEVEL_20",
        "MISSION_USER_LEVEL_30",
        "MISSION_USER_LEVEL_40",
        "MISSION_USER_LEVEL_50",
        "MISSION_USER_LEVEL_60",
        "TAG_COMMON_MISSION_EVENT_DAILY_ONTIME",
        "OLD_RAID_OFF",
        "RAID_SEASON_V1",
        "LOGIN_CLB001_02",
        "TAG_COMMON_PVP_BASIC_DATA",
        "TAG_COMMON_PVP_BASIC_DATA_COURAGE",
        "TAG_COMMON_PVP_BASIC_DATA_SINCERE",
        "TAG_COMMON_PVP_BASIC_DATA_LOYAL_2022",
        "TAG_COMMON_PVP_BASIC_DATA_DEVOTION_2022",
        "PVP_FRIENDLY_GUIDE",
        "TAG_COMMON_SHOP_TAB_MAIN",
        "TAG_COMMON_SHOP_TAB_CASH",
        "TAG_COMMON_SHOP_TAB_CASH_6_0A",
        "TAG_COMMON_SHOP_TAB_CASH_6_0A_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_FIXED_CHARGE_30DAYS_6_0A_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_6_0A_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LIMIT",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_ONLY_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_ONLY_6_0A_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_COMEBACK_V2_GLOBAL",
        "TAG_COMMON_SHOP_TAB_CASH_GLOBAL",
        "TAG_COMMON_SHOP_TAB_CASH_2ND_ANNIVERSARY",
        "TAG_COMMON_SHOP_TAB_CASH_2ND_ANNIVERSARY_WEEKLY",
        "TAG_COMMON_SHOP_TAB_CASH_MONTHLY",
        "SHOP_CATEGORY_PACKAGE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_ONLY_VOL1_SUBSCRIBE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_ONLY_VOL1",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_STARTER_VOL1_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_STARTER_VOL2_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_STARTER_VOL3_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_NEWBIE_STARTER_VER_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_WELCOME_BACK_VOL1",
        "TAG_COMMON_SHOP_TAB_PACKAGE_WELCOME_BACK_VOL2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_WELCOME_BACK_VOL3",
        "TAG_COMMON_SHOP_TAB_PACKAGE_SKIN_FOOLS_DAY",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_160268",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_160557",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_LITE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_100DAYS_ANNIVERSARY",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_50DAYS_SEA",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ROTATION",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ROTATION_DAILY",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ROTATION_MONTHLY",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ROTATION_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CA_HILDE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CORRUPTED_CA_MINISTRA_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UPDATE_OPR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UPDATE_NEW_SHIP",
        "TAG_COMMON_SHOP_TAB_PACKAGE_T6_SUPERCONDUCTIVE_EQUIP",
        "TAG_COMMON_SHOP_TAB_PACKAGE_T6_POLYMER_EQUIP",
        "TAG_COMMON_SHOP_TAB_PACKAGE_POWER_UP_202108",
        "TAG_COMMON_SHOP_TAB_PACKAGE_POWER_UP_202108_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVEL_UP_202106",
        "TAG_COMMON_SHOP_TAB_PACKAGE_SPECIAL_TRAINING",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_FIRST_PURCHASE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_FIRST_PURCHASE_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_MONTHLY",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_MONTHLY_INAPP",
        "TAG_COMMON_SHOP_TAB_PACKAGE_FIXED_CHARGE_V2_HOME",
        "TAG_COMMON_SHOP_TAB_PACKAGE_FIXED_CHARGE_V2_30DAYS",
        "TAG_COMMON_SHOP_TAB_PACKAGE_FIXED_CHARGE_V2_18DAYS_COMMON",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CUSTOM_LAUNCHING",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CUSTOM_LAUNCHING_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CUSTOM_LAUNCHING_PIECE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CUSTOM",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CUSTOM_SSR_UNIT",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_CLASSIFIED",
        "TAG_COMMON_SHOP_TAB_PACKAGE_2022_NEWYEAR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_CLASSIFIED_PKG",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_CLASSIFIED_PKG_MEDAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_CLASSIFIED_PKG_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_INTERIOR",
        "TAB_COMMON_SHOP_TAB_PACKAGE_PLAY_TRANSCENDENCE",
        "TAB_COMMON_SHOP_TAB_PACKAGE_PLAY_ALL_COUNTRY",
        "TAG_COMMON_SHOP_TAB_SKIN_NEW",
        "TAG_COMMON_SHOP_TAB_SKIN_KOR",
        "TAG_COMMON_SHOP_TAB_SKIN_CHRISTMAS_home",
        "TAG_COMMON_SHOP_TAB_SKIN_WINTER_LAUNCHING",
        "TAG_COMMON_SHOP_TAB_SKIN_WINTER",
        "TAG_COMMON_SHOP_TAB_SKIN_SPRING_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_ALL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_QUERTZ_6_0A",
        "TAG_COMMON_SHOP_TAB_SEASON_GAUNTLET",
        "TAG_COMMON_SHOP_TAB_EVENT",
        "TAG_COMMON_SHOP_TAB_SUPPLY",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_RESOURCE",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_RESOURCE_SELL_ETERNIUM",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_COMBINI",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_COMBINI_ESPR",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_COMBINI_ADMIN",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_COMBINI_SIGMA",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_COMBINI_SPRING",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_COMBINI_STREGA",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_TASK_PLANET",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_TASK_PLANET_PIECE",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_TASK_PLANET_PIECE_JPN",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_DIVE_POINT",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_IMAGINARY_CORE",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_GOLDEN_BULLET",
        "TAG_COMMON_SHOP_TAB_CHALLENGE_PIECE",
        "TAG_COMMON_SHOP_TAB_CHALLENGE_PIECE_ACT_1",
        "TAG_COMMON_SHOP_TAB_CHALLENGE_PIECE_ACT_2",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_GUILD_COIN",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_REMOVE_CARD",
        "TAG_COMMON_SHOP_TAB_NO_USE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVELUP_SERIES_A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVELUP_SERIES_B",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVELUP_SEREIS_C",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVELUP_SERIES_A_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVELUP_SERIES_B_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVELUP_SERIES_C_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_SIXWING_NA_YUBIN",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CA_STREGA_YOO_NA_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CA_YOO_MI_NA_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_SIXWING_AMY_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CA_SEO_YOON_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_REPLACER_CA_V2",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_ALPHA_SOC",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_SCHOOL_NOTE",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_ALT_TOKEN",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_JAPAN_CHARM",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_YG_POTION",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_ADMIN_C_PASSCARD",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_SOF_DOC",
        "TAG_COMMON_SHOP_TAB_EXCHANGE_FALLEN",
        "TAG_COMMON_SHOP_TAB_PACKAGE_1_5YEAR_STEP_UP_KOR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_1_5YEAR_STEP_UP_KOR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_1_5YEAR_BUILD_SHIP_KOR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_SUMMER",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CA_JOO_SHI_YOON_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_CA_ADMIN_LEE_SUYEON",
        "TAG_COMMON_SHOP_TAB_SKIN_ALL_V2",
        "TAG_COMMON_SHOP_TAB_SKIN_ALL_V3",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_CAMPING",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_HORIZON",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_NANAHARA",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_HALLOWEEN_2021",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_PKG_MEDAL_V2_VOL1",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_PKG_MEDAL_V2_VOL2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_PKG_MEDAL_V2_VOL3",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CONTRACT_PKG_MEDAL_V2_HOME",
        "TAG_COMMON_SHOP_TAB_PACKAGE_EQUIP_MANY_UPGRADE_VOL2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_1YEAR_SPECIAL_SEA",
        "TAG_COMMON_SHOP_TAB_PACKAGE_BLACK_FRIDAY_2021",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_SCAVENGER_MA_EVOLVE_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_FUTURE_MA_LOAN_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_CHRISTMAS_2021",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ADMIN_LITE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_SPECIAL_QUERTZ",
        "TAG_COMMON_SHOP_LACK_EQUIP_MAZE2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_100DAYS_ANNIVERSARY_PREFAB",
        "TAG_COMMON_SHOP_TAB_PACKAGE_WELCOMING_NEWYEAR_HOME",
        "TAG_COMMON_SHOP_TAB_PACKAGE_WELCOMING_NEWYEAR_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_DAILY_ETERNIUM",
        "TAG_COMMON_SHOP_TAB_PACKAGE_DAILY_ETERNIUM_6_0A",
        "TAG_COMMON_SHOP_TAB_PACKAGE_FIXED_CHARGE_ETERNIUM",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_2YEAR_BASIC",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TALENT",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_MAINSTREAM_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_MAINSTREAM_V5",
        "TAG_COMMON_SHOP_TAB_PACKAGE_TIME_DEAL_MAINSTREAM_V6",
        "TAG_COMMON_SHOP_TAB_PACKAGE_UNIT_ALPHA_CA_JIA",
        "TAG_COMMON_SHOP_TAB_PACKAGE_A_UNIT_UPDATE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_RECRUITMENT",
        "TAG_COMMON_SHOP_TAB_SKIN_FOOLSDAY",
        "TAG_COMMON_SHOP_TAB_SKIN_FOOLSDAY_V1",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_RECITAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_G_BAR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ACTIVITY_CONTRACT",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ACTIVITY_CONTRACT_160466",
        "TAG_COMMON_SHOP_TAB_SKIN_FOOLSDAY_V2",
        "TAG_COMMON_SHOP_TAB_SKIN_FOOLSDAY_V3",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_LONELY_LAB",
        "TAG_COMMON_SHOP_TAB_SKIN_VALEN_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CHRISTMAS_LAUNCHING_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_RACING_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CHILD_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_LAUNCHING_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V1_WEEK1_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V1_WEEK2_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V2_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_WEDDING_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_HALLOWEEN_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CHRISTMAS_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_1ST_ANNIVERSARY_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_NEW_YEAR_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_SPORT_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_WEDDING_V2_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_WEDDING_V3_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_HALLOWEEN_V2_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_2ND_ANNIVERSARY_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_BUNNY_ALWAYS",
        "TAG_COMMON_SHOP_TAB_PACKAGE_RECOMMENDED_PACKAGE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ALWAYS",
        "TAG_COMMON_SHOP_TAB_PACKAGE_SPECIAL",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V3_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CHANGE_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_SCHOOL_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CHRISTMAS_ALWAYS_V2",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V4_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V4_ALWAYS_PART2",
        "TAG_COMMON_SHOP_TAB_SKIN_CHUSEOK_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_PAJAMAS_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_SPRING_BUNNY_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_SPRING_BUNNY_ALWAYS_V2",
        "TAG_COMMON_SHOP_TAB_SKIN_SPRING_BUNNY_V2_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V5_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_VACANCE_V6_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_MAID_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CONTEST_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_HALLOWEEN_V3_ALWAYS",
        "TAG_COMMON_SHOP_TAB_SKIN_CHRISTMAS_ALWAYS_V3",
        "TAG_COMMON_SHOP_TAB_SKIN_MEMORIAL_ALWAYS",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LAUNCHING_2_5YEAR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_GLOBAL_PC",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_001",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_001_ACTIVITY_CONTRACT",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_001_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_002",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_002_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_003",
        "TAG_COMMON_SHOP_TAB_PACKAGE_CLB_003_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_SHIP_LOCK",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ALWAYS_SHIP",
        "TAG_COMMON_SHOP_TAB_PACKAGE_SSR_UNIT_CHOICE_ALLINONE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_JUMPING",
        "TAG_COMMON_SHOP_TAB_PACKAGE_RELIC_REROLL",
        "TAG_COMMON_SHOP_TAB_PACAGE_2024_NEWYEAR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ANNIVERSARY_1YEAR",
        "TAG_COMMON_SHOP_TAB_PACKAGE_ANNIVERSARY_1YEAR_GLOBAL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LEVEL_UP_V2",
        "TAG_COMMON_SHOP_TAB_PACKAGE_2024_SPRING",
        "TAG_COMMON_SHOP_TAB_SKIN_FOOLSDAY_V4",
        "TAG_COMMON_SHOP_TAB_SKIN_CONTEST_ALWAYS_V2",
        "TAG_COMMON_SHOP_TAB_SKIN_CONTEST_ALWAYS_V3",
        "TAG_COMMON_SHOP_TAB_PACKAGE_2024_MAY",
        "TAG_COMMON_SHOP_TAB_PACKAGE_LIMITBREAK_AWAKEN",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_STORE",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_FALLEN",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_OLD_SCHOOL",
        "TAG_COMMON_SHOP_TAB_PACKAGE_OFFICE_ROOM_INTERIOR_WEDDING",
        "GUILD_DUNGEON_SEASON_DUMMY",
        "GUILD_DUNGEON_SEASON_V2_1",
        "GUILD_DUNGEON_SEASON_V2_2",
        "GUILD_DUNGEON_SEASON_V2_3",
        "GUILD_DUNGEON_SEASON_V2_4",
        "GUILD_DUNGEON_SEASON_V2_5",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_1",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_2",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_1",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_2",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_3",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_3",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_4",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_4",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_5",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_5",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_6",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_6",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_7",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_7",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_8",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_8",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_9",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_9",
        "GUILD_DUNGEON_SEASON_DEMOLTION_2023_10",
        "GUILD_DUNGEON_SEASON_GIGAS_2023_10",
        "MOLD_RIBBON",
        "ALT_PRIVATE_EQUIP_MOLD",
        "JAPAN_PRIVATE_EQUIP_MOLD",
        "TAG_BGM_CLB_003",
        "DROP_EVENT_NANAHARA",
        "DROP_EVENT_CARNIVAL",
        "DROP_EVENT_KINGDOM",
        "DROP_EVENT_ESPR2",
        "DROP_EVENT_NEVERLAND",
        "DROP_EVENT_GAMECIRCLE",
        "DROP_EVENT_CHARADE",
        "DROP_EVENT_EXILER",
        "DROP_EVENT_NANAHARA2",
        "DROP_EVENT_ACADEMY",
        "DROP_EVENT_NIGHTMARE",
        "DROP_EVENT_SPORTS",
        "DROP_EVENT_GREMORY",
        "DROP_EVENT_ALPHA",
        "DROP_EVENT_ORCA",
        "DROP_EVENT_SOF",
        "DROP_EVENT_POLICE",
        "DROP_EVENT_DELTA",
        "DROP_EVENT_FAILURE",
        "DROP_EVENT_CROSSROAD",
        "DROP_EVENT_ESPR",
        "DROP_EVENT_ADMIN",
        "DROP_EVENT_SIGMA",
        "DROP_EVENT_STREGA",
        "DROP_EVENT_SPRING",
        "DROP_EVENT_SHADE",
        "DROP_EVENT_WANTED",
        "DROP_EVENT_MILITIA",
        "DROP_EVENT_MAID",
        "DROP_EVENT_HORIZON",
        "DROP_EVENT_CHARADE2",
        "DROP_EVENT_CARNIVAL2",
        "DROP_EVENT_PRYDWEN",
        "LOADING_GUIDE_1",
        "LOADING_GUIDE_2",
        "LOADING_GUIDE_3",
        "LOADING_GUIDE_5",
        "LOADING_GUIDE_6",
        "LOADING_GUIDE_7",
        "LOADING_GUIDE_8",
        "LOADING_GUIDE_10",
        "LOADING_GUIDE_11",
        "TAG_GLOBAL_CONTRACT_CBT",
        "TAG_GLOBAL_CONTRACT_OBT",
        "TAG_GLOBAL_CONTRACT_SELECTABLE",
        "TAG_GLOBAL_CONTRACT_BASIC",
        "TAG_GLOBAL_CONTRACT_OPERATOR_TUTORIAL",
        "AIR_UNIT",
        "HP_RATE_PVP_FIX",
        "CHECK_MAINTENANCE"];
    }
}
