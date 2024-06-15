using ALTNet.GameServer.Core;
using Cs.Protocol;
using Protocol;
using Serilog;
using System.Reflection;

namespace ALTNet.GameServer.Protocol
{
    public struct Packet
    {
        public ushort PacketId
        {
            get
            {
                return this.packetId;
            }
        }

        public static Packet? Pack(ISerializable data, long sequence)
        {
            Packet packet = new Packet
            {
                sequence = sequence,
                packetId = Packet.GetPacketId(data)
            };
            if (packet.packetId == 65535)
            {
                Log.Error(MethodBase.GetCurrentMethod().Name + " invalid data", "/Users/buildman/buildAgent_ca18-1/work/e0bfb30763b53cef/CounterSide/CODE/CSClient/Assets/ASSET_STATIC/AS_SCRIPT/COMMON/Cs.Protocol/Packet.cs", 36);
                return null;
            }
            packet.buffer = PacketWriter.ToBufferWithoutNullBit(data);
            if (packet.buffer.CalcTotalSize() > 1024)
            {
                packet.buffer.Lz4Compress();
                packet.compressed = true;
            } else
            {
                packet.buffer.Encrypt();
            }
            packet.totalLength = packet.CalcTotalLength();
            return new Packet?(packet);
        }

        public void WriteTo(SendBuffer sendBuffer)
        {
            using (BinaryWriter writer = sendBuffer.GetWriter())
            {
                PacketWriter packetWriter = new PacketWriter(writer);
                packetWriter.PutRawUint(2864434397U);
                packetWriter.PutRawInt(this.totalLength);
                packetWriter.PutOrGet(ref this.sequence);
                packetWriter.PutOrGet(ref this.packetId);
                packetWriter.PutOrGet(ref this.compressed);
                packetWriter.PutInt(this.buffer.CalcTotalSize());
                sendBuffer.Absorb(this.buffer);
                packetWriter.PutRawUint(287454020U);
            }
        }

        private int CalcTotalLength()
        {
            PacketSizeChecker packetSizeChecker = new PacketSizeChecker();
            packetSizeChecker.CheckRawUint32(2864434397U);
            packetSizeChecker.CheckRawInt32(this.totalLength);
            packetSizeChecker.PutOrGet(ref this.sequence);
            packetSizeChecker.PutOrGet(ref this.packetId);
            packetSizeChecker.PutOrGet(ref this.compressed);
            packetSizeChecker.PutOrGet(this.buffer);
            packetSizeChecker.CheckRawUint32(287454020U);
            return packetSizeChecker.Size;
        }

        public static uint HeadFence = 2864434397U;

        public static uint TailFence = 287454020U;

        private const int CompressThreshold = 1024;

        private const ushort MinHeaderSize = 12;

        private long sequence;

        private ushort packetId;

        private bool compressed;

        private ZeroCopyBuffer buffer;

        private int totalLength;

        public static ushort GetPacketId(ISerializable packet)
        {
            var packetAtr = packet.GetType().GetCustomAttribute(typeof(PacketIdAttribute)) as PacketIdAttribute;

            return packetAtr.PacketId;
        }

        // TODO: add support for multi request packet (pipes)
        public static ISerializable DecodeFromStream(BinaryReader reader)
        {
            PacketReader packetReader = new PacketReader(reader);

            int totalLength = reader.ReadInt32();
            long sequence = packetReader.GetLong();
            ushort packetId = packetReader.GetUshort();
            bool compressed = packetReader.GetBool();

            Log.Information("Decoding Packet from Stream...");

            Log.Information($"Total Length: {totalLength}");
            Log.Information($"sequence: {sequence}");
            Log.Information($"packetId: {packetId}");
            Log.Information($"compressed: {compressed}");

            ISerializable decodedPacket = Packet.Extract(packetReader, packetId, compressed);
            return decodedPacket;
        }

        private static ISerializable Extract(PacketReader reader, ushort packetId, bool compressed)
        {
            Log.Information("packetId received: " + (ClientPacketId)packetId);

            ISerializable resultPacket = Packet.CreatePacket(packetId);

            byte[] array = null;
            reader.PutOrGet(ref array);

            if (compressed) // no encryption if compressed
            {
                Console.WriteLine("Packet.Extract: compressed");
                ZeroCopyBuffer zeroCopyBuffer = Lz4Util.Decompress(array);
                using (zeroCopyBuffer.Hold())
                {
                    using (PacketReader packetReader = new PacketReader(zeroCopyBuffer.GetReader()))
                    {
                        packetReader.GetWithoutNullBit(resultPacket);
                    }

                    goto on_compressed;
                }
            }

            Crypto.Encrypt(array, array.Length);

            using (PacketReader packetReader2 = new PacketReader(array))
            {
                packetReader2.GetWithoutNullBit(resultPacket);
                Console.WriteLine("Packet.Extract: reading packet using PacketReader");
            }

            on_compressed:
            return resultPacket;
        }

        private static ISerializable CreatePacket(ushort packetId)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type packetAttribute = typeof(PacketIdAttribute);

            var allPacketsTypes = assembly.GetTypes().Where(x => x.GetCustomAttributes(packetAttribute, true).Length > 0).ToList();
            ISerializable result = default;

            foreach (var type in allPacketsTypes)
            {
                var attributeInstance = type.GetCustomAttributes(packetAttribute, true).FirstOrDefault() as PacketIdAttribute;

                if (attributeInstance != null && attributeInstance.PacketId == packetId)
                {
                    result = Activator.CreateInstance(type) as ISerializable;
                    break;
                }
            }

            return result;
        }
    }
}
