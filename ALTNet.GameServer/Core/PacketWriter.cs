using Cs.Protocol;
using System.Collections;
using System.Text;

namespace ALTNet.GameServer.Core
{
    public class PacketWriter : IPacketStream, IDisposable
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

        public void Dispose()
        {
            this.writer.Dispose();
        }
    }

}
