using ALTNet.Common;
using Cs.Protocol;
using System.Collections;
using System.Text;

namespace ALTNet.GameServer.Core
{
    public class PacketReader : IPacketStream
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
    }

    public class PacketWriter : IPacketStream
    {
        private readonly BinaryWriter writer;

        public static ZeroCopyBuffer ToBufferWithoutNullBit(ISerializable data)
        {
            ZeroCopyBuffer zeroCopyBuffer = new ZeroCopyBuffer();
            PacketWriter packetWriter = new PacketWriter(zeroCopyBuffer.GetWriter());
            {
                packetWriter.PutWithoutNullBit(data);
            }
            return zeroCopyBuffer;
        }

        public PacketWriter(BinaryWriter writer)
        {
            this.writer = writer;
        }

        public void SerializePacket(ISerializable packet)
        {
            packet.Serialize(this);
        }

        public void PutOrGet(ref bool data)
        {
            this.writer.Write(data);
        }

         
        public void PutOrGet(ref sbyte data)
        {
            this.writer.Write(data);
        }

         
        public void PutOrGet(ref byte data)
        {
            this.writer.Write(data);
        }

         
        public void PutOrGet(ref short data)
        {
            this.WriteRawVarint32(Decoder.Encode32((int)data));
        }

         
        public void PutOrGet(ref ushort data)
        {
            this.WriteRawVarint32((uint)data);
        }

         
        public void PutOrGet(ref int data)
        {
            this.WriteRawVarint32(Decoder.Encode32(data));
        }

         
        public void PutOrGet(ref uint data)
        {
            this.WriteRawVarint32(data);
        }

         
        public void PutOrGet(ref long data)
        {
            this.WriteRawVarint64(Decoder.Encode64(data));
        }

         
        public void PutOrGet(ref ulong data)
        {
            this.WriteRawVarint64(data);
        }

         
        public void PutOrGet(ref float data)
        {
            this.writer.Write(data);
        }

         
        public void PutOrGet(ref double data)
        {
            this.writer.Write(data);
        }

         
        public void PutOrGet(ref string data)
        {
            this.PutString(data);
        }

         
        public void AsHalf(ref float data)
        {
             
             
        }

         
        public void PutOrGet(ref byte[] data)
        {
            if (data == null)
            {
                this.PutInt(0);
                return;
            }
            this.PutInt(data.Length);
            this.writer.Write(data);
        }

         
        public void PutOrGet(ref BitArray data)
        {
             
             
             
        }

         
        public void PutOrGet(ref DateTime data)
        {
            this.PutRawLong(data.ToBinary());
        }

         
        public void PutOrGet(ref TimeSpan data)
        {
            this.PutRawLong(data.Ticks);
        }

         
        public void PutOrGet(ref bool[] data)
        {
            this.PutUshort((ushort)data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                this.PutBool(data[i]);
            }
        }

         
        public void PutOrGet(ref int[] data)
        {
            this.PutUshort((ushort)data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                this.PutInt(data[i]);
            }
        }

         
        public void PutOrGet(ref long[] data)
        {
            this.PutUshort((ushort)data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                this.PutLong(data[i]);
            }
        }

         
        public void PutOrGet<T>(ref T[] data) where T : ISerializable
        {
            this.PutUshort((ushort)data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                this.PutMessage(data[i]);
            }
        }

         
        public void PutOrGet(ref List<bool> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (bool data2 in data)
            {
                this.PutBool(data2);
            }
        }

         
        public void PutOrGet(ref List<byte> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (byte data2 in data)
            {
                this.PutByte(data2);
            }
        }

         
        public void PutOrGet(ref List<short> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (short data2 in data)
            {
                this.PutShort(data2);
            }
        }

         
        public void PutOrGet(ref List<int> data)
        {
            if (data == null)
            {
                this.PutUshort(0);
                return;
            }
            this.PutUshort((ushort)data.Count);
            foreach (int data2 in data)
            {
                this.PutInt(data2);
            }
        }

         
        public void PutOrGet(ref List<float> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (float data2 in data)
            {
                this.PutFloat(data2);
            }
        }

         
        public void PutOrGet(ref List<long> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (long data2 in data)
            {
                this.PutLong(data2);
            }
        }

         
        public void PutOrGet(ref List<string> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (string data2 in data)
            {
                this.PutString(data2);
            }
        }

         
        public void PutOrGet<T>(ref List<T> data) where T : ISerializable
        {
            if (data == null)
            {
                this.PutUshort(0);
                return;
            }
            this.PutUshort((ushort)data.Count);
            foreach (T t in data)
            {
                this.PutMessage(t);
            }
        }

         
        public void PutOrGet(ref HashSet<short> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (short data2 in data)
            {
                this.PutShort(data2);
            }
        }

         
        public void PutOrGet(ref HashSet<int> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (int data2 in data)
            {
                this.PutInt(data2);
            }
        }

         
        public void PutOrGet(ref HashSet<string> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (string data2 in data)
            {
                this.PutString(data2);
            }
        }

         
        public void PutOrGet(ref HashSet<long> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (long data2 in data)
            {
                this.PutLong(data2);
            }
        }

         
        public void PutOrGet<T>(ref HashSet<T> data) where T : ISerializable
        {
            if (data == null)
            {
                this.PutUshort(0);
                return;
            }
            this.PutUshort((ushort)data.Count);
            foreach (T t in data)
            {
                this.PutMessage(t);
            }
        }

         
        public void PutOrGetEnum<T>(ref HashSet<T> data) where T : Enum
        {
            this.PutUshort((ushort)data.Count);
            foreach (T t in data)
            {
                this.PutInt((int)Convert.ChangeType(t, typeof(int)));
            }
        }

         
        public void PutOrGet(ref Dictionary<int, int> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<int, int> keyValuePair in data)
            {
                this.PutInt(keyValuePair.Key);
                this.PutInt(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<int, float> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<int, float> keyValuePair in data)
            {
                this.PutInt(keyValuePair.Key);
                this.PutFloat(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<long, int> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<long, int> keyValuePair in data)
            {
                this.PutLong(keyValuePair.Key);
                this.PutInt(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<long, long> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<long, long> keyValuePair in data)
            {
                this.PutLong(keyValuePair.Key);
                this.PutLong(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<long, float> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<long, float> keyValuePair in data)
            {
                this.PutLong(keyValuePair.Key);
                this.PutFloat(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<int, long> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<int, long> keyValuePair in data)
            {
                this.PutInt(keyValuePair.Key);
                this.PutLong(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<byte, byte> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<byte, byte> keyValuePair in data)
            {
                this.PutByte(keyValuePair.Key);
                this.PutByte(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<byte, long> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<byte, long> keyValuePair in data)
            {
                this.PutByte(keyValuePair.Key);
                this.PutLong(keyValuePair.Value);
            }
        }

         
        public void PutOrGet(ref Dictionary<string, int> data)
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<string, int> keyValuePair in data)
            {
                this.PutString(keyValuePair.Key);
                this.PutInt(keyValuePair.Value);
            }
        }

         
        public void PutOrGet<T>(ref Dictionary<byte, T> data) where T : ISerializable
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<byte, T> keyValuePair in data)
            {
                this.PutByte(keyValuePair.Key);
                this.PutMessage(keyValuePair.Value);
            }
        }

         
        public void PutOrGet<T>(ref Dictionary<short, T> data) where T : ISerializable
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<short, T> keyValuePair in data)
            {
                this.PutShort(keyValuePair.Key);
                this.PutMessage(keyValuePair.Value);
            }
        }

         
        public void PutOrGet<T>(ref Dictionary<int, T> data) where T : ISerializable
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<int, T> keyValuePair in data)
            {
                this.PutInt(keyValuePair.Key);
                this.PutMessage(keyValuePair.Value);
            }
        }

         
        public void PutOrGet<T>(ref Dictionary<long, T> data) where T : ISerializable
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<long, T> keyValuePair in data)
            {
                this.PutLong(keyValuePair.Key);
                this.PutMessage(keyValuePair.Value);
            }
        }

         
        public void PutOrGet<T>(ref Dictionary<string, T> data) where T : ISerializable
        {
            this.PutUshort((ushort)data.Count);
            foreach (KeyValuePair<string, T> keyValuePair in data)
            {
                this.PutString(keyValuePair.Key);
                this.PutMessage(keyValuePair.Value);
            }
        }

         
        public void PutOrGetEnum<T>(ref T data) where T : Enum
        {
            this.PutInt((int)Convert.ChangeType(data, typeof(int)));
        }

         
        public void PutOrGetEnum<T>(ref List<T> data) where T : Enum
        {
            this.PutUshort((ushort)data.Count);
            for (int i = 0; i < data.Count; i++)
            {
                this.PutInt((int)Convert.ChangeType(data[i], typeof(int)));
            }
        }

         
        public void PutOrGet<T>(ref T data) where T : ISerializable
        {
            this.PutMessage(data);
        }

         
        public void PutBool(bool data)
        {
            this.writer.Write(data);
        }

         
        public void PutSByte(sbyte data)
        {
            this.writer.Write(data);
        }

         
        public void PutByte(byte data)
        {
            this.writer.Write(data);
        }

         
        public void PutShort(short data)
        {
            this.WriteRawVarint32(Decoder.Encode32((int)data));
        }

         
        public void PutUshort(ushort data)
        {
            this.WriteRawVarint32((uint)data);
        }

         
        public void PutInt(int data)
        {
            this.WriteRawVarint32(Decoder.Encode32(data));
        }

         
        public void PutUint(uint data)
        {
            this.WriteRawVarint32(data);
        }

         
        public void PutLong(long data)
        {
            this.WriteRawVarint64(Decoder.Encode64(data));
        }

         
        public void PutUlong(ulong data)
        {
            this.WriteRawVarint64(data);
        }

         
        public void PutFloat(float data)
        {
            this.writer.Write(data);
        }

         
        public void PutDouble(double data)
        {
            this.writer.Write(data);
        }

        public void PutRawInt(int data)
        {
            this.writer.Write(data);
        }

         
        public void PutRawUint(uint data)
        {
            this.writer.Write(data);
        }

         
        public void PutRawLong(long data)
        {
            this.writer.Write(data);
        }

         
        public void PutString(string data)
        {
            if (data == null)
            {
                this.PutShort(-1);
                return;
            }
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            this.PutShort((short)bytes.Length);
            this.writer.Write(bytes);
        }

         
        public void PutWithoutNullBit(ISerializable message)
        {
            message.Serialize(this);
        }

         
        public void PutMessage(ISerializable message)
        {
            if (message == null)
            {
                this.PutBool(false);
                return;
            }
            this.PutBool(true);
            message.Serialize(this);
        }

         
        private void WriteRawVarint32(uint value)
        {
            while (value > 127U)
            {
                this.writer.Write((byte)((value & 127U) | 128U));
                value >>= 7;
            }
            this.writer.Write((byte)value);
        }

         
        private void WriteRawVarint64(ulong value)
        {
            while (value > 127UL)
            {
                this.writer.Write((byte)((value & 127UL) | 128UL));
                value >>= 7;
            }
            this.writer.Write((byte)value);
        }

    }

    public class PacketSizeChecker
    {
        private int size;

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void PutOrGet(ZeroCopyBuffer data)
        {
            int num = data.CalcTotalSize();
            this.CheckInt32(num);
            this.size += num;
        }

        public void PutOrGet(byte[] data)
        {
            int num = data.Length;
            this.CheckInt32(num);
            this.size += num;
        }

        private void CheckInt32(int data)
        {
            this.size += PacketSizeChecker.ComputeRawVarint32Size(Decoder.Encode32(data));
        }

        public void PutOrGet(ref long data)
        {
            this.CheckInt64(data);
        }

        public void PutOrGet(ref ushort data)
        {
            this.CheckUint32((uint)data);
        }

        public void PutOrGet(ref bool data)
        {
            this.size++;
        }

        private void CheckUint32(uint data)
        {
            this.size += PacketSizeChecker.ComputeRawVarint32Size(data);
        }

        public void CheckRawUint32(uint data)
        {
            this.size += 4;
        }

        public void CheckRawInt32(int data)
        {
            this.size += 4;
        }

        private void CheckInt64(long data)
        {
            this.size += PacketSizeChecker.ComputeRawVarint64Size(Decoder.Encode64(data));
        }

        private static int ComputeRawVarint32Size(uint value)
        {
            if ((value & 4294967168U) == 0U)
            {
                return 1;
            }
            if ((value & 4294950912U) == 0U)
            {
                return 2;
            }
            if ((value & 4292870144U) == 0U)
            {
                return 3;
            }
            if ((value & 4026531840U) == 0U)
            {
                return 4;
            }
            return 5;
        }

        private static int ComputeRawVarint64Size(ulong value)
        {
            if ((value & 18446744073709551488UL) == 0UL)
            {
                return 1;
            }
            if ((value & 18446744073709535232UL) == 0UL)
            {
                return 2;
            }
            if ((value & 18446744073707454464UL) == 0UL)
            {
                return 3;
            }
            if ((value & 18446744073441116160UL) == 0UL)
            {
                return 4;
            }
            if ((value & 18446744039349813248UL) == 0UL)
            {
                return 5;
            }
            if ((value & 18446739675663040512UL) == 0UL)
            {
                return 6;
            }
            if ((value & 18446181123756130304UL) == 0UL)
            {
                return 7;
            }
            if ((value & 18374686479671623680UL) == 0UL)
            {
                return 8;
            }
            if ((value & 9223372036854775808UL) == 0UL)
            {
                return 9;
            }
            return 10;
        }


    }
}
