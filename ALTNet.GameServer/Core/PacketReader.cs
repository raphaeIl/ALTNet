using Cs.Protocol;
using System.Collections;
using System.Text;

namespace ALTNet.GameServer.Core
{
    public class PacketReader : IPacketStream, IDisposable
    {
        private readonly BinaryReader reader;

        public PacketReader(BinaryReader reader)
        {
            this.reader = reader;
        }

        public PacketReader(byte[] buffer)
        {
            this.reader = new BinaryReader(new MemoryStream(buffer));
        }

        public void DeserializePacket(ISerializable packet)
        {
            packet.Serialize(this);
        }

        public void PutOrGet(ref bool data)
        {
            data = this.reader.ReadBoolean();
        }


        public void PutOrGet(ref sbyte data)
        {
            data = this.reader.ReadSByte();
        }


        public void PutOrGet(ref byte data)
        {
            data = this.reader.ReadByte();
        }


        public void PutOrGet(ref short data)
        {
            data = (short)Decoder.Decode32(this.ReadRawVarInt32());
        }


        public void PutOrGet(ref ushort data)
        {
            data = (ushort)this.ReadRawVarInt32();
        }


        public void PutOrGet(ref int data)
        {
            data = Decoder.Decode32(this.ReadRawVarInt32());
        }


        public void PutOrGet(ref uint data)
        {
            data = this.ReadRawVarInt32();
        }


        public void PutOrGet(ref long data)
        {
            data = Decoder.Decode64(this.ReadRawVarInt64());
        }


        public void PutOrGet(ref ulong data)
        {
            data = this.ReadRawVarInt64();
        }


        public void PutOrGet(ref float data)
        {
            data = this.reader.ReadSingle();
        }


        public void PutOrGet(ref double data)
        {
            data = this.reader.ReadDouble();
        }


        public void PutOrGet(ref string data)
        {
            data = this.GetString();
        }


        public void AsHalf(ref float data)
        {


        }


        public void PutOrGet(ref byte[] data)
        {
            int @int = this.GetInt();
            data = this.reader.ReadBytes(@int);
        }


        public void PutOrGet(ref BitArray data)
        {
            ushort @ushort = this.GetUshort();
            data = new BitArray(this.reader.ReadBytes((int)@ushort));
        }


        public void PutOrGet(ref DateTime data)
        {
            data = this.GetDateTime();
        }


        public void PutOrGet(ref TimeSpan data)
        {
            data = this.GetTimeSpan();
        }


        public void PutOrGet(ref bool[] data)
        {
            ushort @ushort = this.GetUshort();
            data = new bool[(int)@ushort];
            for (int i = 0; i < (int)@ushort; i++)
            {
                data[i] = this.GetBool();
            }
        }


        public void PutOrGet(ref int[] data)
        {
            ushort @ushort = this.GetUshort();
            data = new int[(int)@ushort];
            for (int i = 0; i < (int)@ushort; i++)
            {
                data[i] = this.GetInt();
            }
        }


        public void PutOrGet(ref long[] data)
        {
            ushort @ushort = this.GetUshort();
            data = new long[(int)@ushort];
            for (int i = 0; i < (int)@ushort; i++)
            {
                data[i] = this.GetLong();
            }
        }


        public void PutOrGet<T>(ref T[] data) where T : ISerializable
        {
            ushort @ushort = this.GetUshort();
            data = new T[(int)@ushort];
            for (int i = 0; i < (int)@ushort; i++)
            {
                this.GetMessage<T>(out data[i]);
            }
        }


        public void PutOrGet(ref List<bool> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<bool>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetBool());
            }
        }


        public void PutOrGet(ref List<byte> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<byte>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetByte());
            }
        }


        public void PutOrGet(ref List<short> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<short>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetShort());
            }
        }


        public void PutOrGet(ref List<int> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<int>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetInt());
            }
        }


        public void PutOrGet(ref List<float> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<float>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetFloat());
            }
        }


        public void PutOrGet(ref List<long> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<long>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetLong());
            }
        }


        public void PutOrGet(ref List<string> data)
        {
            ushort @ushort = this.GetUshort();
            data = new List<string>((int)@ushort);
            for (int i = 0; i < (int)@ushort; i++)
            {
                data.Add(this.GetString());
            }
        }


        public void PutOrGet<T>(ref List<T> data) where T : ISerializable
        {













        }


        public void PutOrGet(ref HashSet<short> data)
        {
            ushort @ushort = this.GetUshort();
            data = new HashSet<short>();
            for (int i = 0; i < (int)@ushort; i++)
            {
                short @short = this.GetShort();
                data.Add(@short);
            }
        }


        public void PutOrGet(ref HashSet<int> data)
        {
            ushort @ushort = this.GetUshort();
            data = new HashSet<int>();
            for (int i = 0; i < (int)@ushort; i++)
            {
                int @int = this.GetInt();
                data.Add(@int);
            }
        }


        public void PutOrGet(ref HashSet<string> data)
        {
            ushort @ushort = this.GetUshort();
            data = new HashSet<string>();
            for (int i = 0; i < (int)@ushort; i++)
            {
                string @string = this.GetString();
                data.Add(@string);
            }
        }


        public void PutOrGet(ref HashSet<long> data)
        {
            ushort @ushort = this.GetUshort();
            data = new HashSet<long>();
            for (int i = 0; i < (int)@ushort; i++)
            {
                long @long = this.GetLong();
                data.Add(@long);
            }
        }


        public void PutOrGet<T>(ref HashSet<T> data) where T : ISerializable
        {













        }


        public void PutOrGetEnum<T>(ref HashSet<T> data) where T : Enum
        {
            data = new HashSet<T>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                int @int = this.GetInt();
                T item = (T)((object)Enum.ToObject(typeof(T), @int));
                data.Add(item);
            }
        }


        public void PutOrGet(ref Dictionary<int, int> data)
        {
            data = new Dictionary<int, int>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                int @int = this.GetInt();
                int int2 = this.GetInt();
                data.Add(@int, int2);
            }
        }


        public void PutOrGet(ref Dictionary<int, float> data)
        {
            data = new Dictionary<int, float>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                int @int = this.GetInt();
                float @float = this.GetFloat();
                data.Add(@int, @float);
            }
        }


        public void PutOrGet(ref Dictionary<long, int> data)
        {
            data = new Dictionary<long, int>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                long @long = this.GetLong();
                int @int = this.GetInt();
                data.Add(@long, @int);
            }
        }


        public void PutOrGet(ref Dictionary<long, long> data)
        {
            data = new Dictionary<long, long>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                long @long = this.GetLong();
                long long2 = this.GetLong();
                data.Add(@long, long2);
            }
        }


        public void PutOrGet(ref Dictionary<long, float> data)
        {
            data = new Dictionary<long, float>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                long @long = this.GetLong();
                float @float = this.GetFloat();
                data.Add(@long, @float);
            }
        }


        public void PutOrGet(ref Dictionary<int, long> data)
        {
            data = new Dictionary<int, long>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                int @int = this.GetInt();
                long @long = this.GetLong();
                data.Add(@int, @long);
            }
        }


        public void PutOrGet(ref Dictionary<byte, byte> data)
        {
            data = new Dictionary<byte, byte>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                byte @byte = this.GetByte();
                byte byte2 = this.GetByte();
                data.Add(@byte, byte2);
            }
        }


        public void PutOrGet(ref Dictionary<byte, long> data)
        {
            data = new Dictionary<byte, long>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                byte @byte = this.GetByte();
                long @long = this.GetLong();
                data.Add(@byte, @long);
            }
        }


        public void PutOrGet(ref Dictionary<string, int> data)
        {
            data = new Dictionary<string, int>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                string @string = this.GetString();
                int @int = this.GetInt();
                data.Add(@string, @int);
            }
        }


        public void PutOrGet<T>(ref Dictionary<byte, T> data) where T : ISerializable
        {


















        }


        public void PutOrGet<T>(ref Dictionary<short, T> data) where T : ISerializable
        {


















        }


        public void PutOrGet<T>(ref Dictionary<int, T> data) where T : ISerializable
        {


















        }


        public void PutOrGet<T>(ref Dictionary<long, T> data) where T : ISerializable
        {


















        }


        public void PutOrGet<T>(ref Dictionary<string, T> data) where T : ISerializable
        {


















        }


        public void PutOrGetEnum<T>(ref T data) where T : Enum
        {
            int @int = this.GetInt();
            data = (T)((object)Enum.ToObject(typeof(T), @int));
        }


        public void PutOrGetEnum<T>(ref List<T> data) where T : Enum
        {
            data = new List<T>();
            ushort @ushort = this.GetUshort();
            for (int i = 0; i < (int)@ushort; i++)
            {
                int @int = this.GetInt();
                T item = (T)((object)Enum.ToObject(typeof(T), @int));
                data.Add(item);
            }
        }


        public void PutOrGet<T>(ref T data) where T : ISerializable
        {
            this.GetMessage<T>(out data);
        }


        public bool GetBool()
        {
            return this.reader.ReadBoolean();
        }


        public sbyte GetSByte()
        {
            return this.reader.ReadSByte();
        }


        public byte GetByte()
        {
            return this.reader.ReadByte();
        }


        public short GetShort()
        {
            return (short)Decoder.Decode32(this.ReadRawVarInt32());
        }


        public ushort GetUshort()
        {
            return (ushort)this.ReadRawVarInt32();
        }


        public int GetInt()
        {
            return Decoder.Decode32(this.ReadRawVarInt32());
        }


        public uint GetUint()
        {
            return this.ReadRawVarInt32();
        }


        public long GetLong()
        {
            return Decoder.Decode64(this.ReadRawVarInt64());
        }


        public ulong GetUlong()
        {
            return this.ReadRawVarInt64();
        }


        public float GetFloat()
        {
            return this.reader.ReadSingle();
        }


        public double GetDouble()
        {
            return this.reader.ReadDouble();
        }


        public int GetRawInt()
        {
            return this.reader.ReadInt32();
        }


        public uint GetRawUint()
        {
            return this.reader.ReadUInt32();
        }


        public long GetRawLong()
        {
            return this.reader.ReadInt64();
        }


        public string GetString()
        {
            short @short = this.GetShort();
            if (@short == -1)
            {
                return null;
            }
            byte[] bytes = this.reader.ReadBytes((int)@short);
            return Encoding.UTF8.GetString(bytes);
        }


        public DateTime GetDateTime()
        {
            return DateTime.FromBinary(this.GetRawLong());
        }


        public TimeSpan GetTimeSpan()
        {
            return new TimeSpan(this.GetRawLong());
        }


        public void GetWithoutNullBit(ISerializable message)
        {
            message.Serialize(this);
        }


        private void GetCollection<T>(in ICollection<T> collection, int count) where T : ISerializable
        {












        }


        private void GetMessage<T>(out T message) where T : ISerializable
        {







            message = default;
        }


        private uint ReadRawVarInt32()
        {
            int i = 0;
            uint num = 0U;
            while (i < 32)
            {
                byte b = this.reader.ReadByte();
                num |= (uint)((uint)(b & 127) << i);
                if ((b & 128) == 0)
                {
                    return num;
                }
                i += 7;
            }
            throw new Exception("[PacketReader] Malformed Varint32");
        }


        private ulong ReadRawVarInt64()
        {
            int i = 0;
            ulong num = 0UL;
            while (i < 64)
            {
                byte b = this.reader.ReadByte();
                num |= (ulong)((ulong)((long)(b & 127)) << i);
                if ((b & 128) == 0)
                {
                    return num;
                }
                i += 7;
            }
            throw new Exception("[PacketReader] Malformed Varint64");
        }

        public void Dispose()
        {
            this.reader.Close();
        }
    }

}
