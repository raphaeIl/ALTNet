using System.Collections;

namespace ALTNet.GameServer.Packets
{
    public class PacketReader : PacketSerializer
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
    }

    public class PacketWriter : PacketSerializer
    {
        private readonly BinaryWriter writer;

        public PacketWriter(BinaryWriter writer)
        {
            this.writer = writer;
        }

        public void SerializePacket(ISerializable packet)
        {
            packet.Serialize(this);
        }

        public void PutRawUint(uint data)
        {
            this.writer.Write(data);
        }

        public void PutRawInt(int data)
        {
            this.writer.Write(data);
        }

        public void PutInt(int data)
        {
            Decoder.WriteRawVarint32(this.writer, Decoder.Encode32(data));
        }
    }

    public class PacketSerializer
    {
        public virtual void PutOrGet(ref bool data) { }

        public virtual void PutOrGet(ref sbyte data) { }

        public virtual void PutOrGet(ref byte data) { }

        public virtual void PutOrGet(ref short data) { }

        public virtual void PutOrGet(ref ushort data) { }

        public virtual void PutOrGet(ref int data) { }

        public virtual void PutOrGet(ref uint data) { }

        public virtual void PutOrGet(ref long data) { }

        public virtual void PutOrGet(ref ulong data) { }

        public virtual void PutOrGet(ref float data) { }

        public virtual void AsHalf(ref float data) { }

        public virtual void PutOrGet(ref double data) { }

        public virtual void PutOrGet(ref string data) { }

        public virtual void PutOrGet(ref bool[] data) { }

        public virtual void PutOrGet(ref int[] data) { }

        public virtual void PutOrGet(ref long[] data) { }

        public virtual void PutOrGet<T>(ref T[] data) where T : ISerializable { }

        public virtual void PutOrGet(ref byte[] data) { }

        public virtual void PutOrGet(ref BitArray data) { }

        public virtual void PutOrGet(ref DateTime data) { }

        public virtual void PutOrGet(ref TimeSpan data) { }

        public virtual void PutOrGet<T>(ref T data) where T : ISerializable { }

        public virtual void PutOrGetEnum<T>(ref T data) where T : Enum { }

        public virtual void PutOrGetEnum<T>(ref List<T> data) where T : Enum { }

        public virtual void PutOrGet(ref List<bool> data) { }

        public virtual void PutOrGet(ref List<byte> data) { }

        public virtual void PutOrGet(ref List<short> data) { }

        public virtual void PutOrGet(ref List<int> data) { }

        public virtual void PutOrGet(ref List<float> data) { }

        public virtual void PutOrGet(ref List<long> data) { }

        public virtual void PutOrGet(ref List<string> data) { }

        public virtual void PutOrGet<T>(ref List<T> data) where T : ISerializable { }

        public virtual void PutOrGet(ref HashSet<short> data) { }

        public virtual void PutOrGet(ref HashSet<int> data) { }

        public virtual void PutOrGet(ref HashSet<string> data) { }

        public virtual void PutOrGet(ref HashSet<long> data) { }

        public virtual void PutOrGet<T>(ref HashSet<T> data) where T : ISerializable { }

        public virtual void PutOrGetEnum<T>(ref HashSet<T> data) where T : Enum { }

        public virtual void PutOrGet(ref Dictionary<int, int> data) { }

        public virtual void PutOrGet(ref Dictionary<int, float> data) { }

        public virtual void PutOrGet(ref Dictionary<int, long> data) { }

        public virtual void PutOrGet(ref Dictionary<long, int> data) { }

        public virtual void PutOrGet(ref Dictionary<byte, byte> data) { }

        public virtual void PutOrGet(ref Dictionary<byte, long> data) { }

        public virtual void PutOrGet(ref Dictionary<long, long> data) { }

        public virtual void PutOrGet(ref Dictionary<string, int> data) { }

        public virtual void PutOrGet(ref Dictionary<long, float> data) { }

        public virtual void PutOrGet<T>(ref Dictionary<byte, T> data) where T : ISerializable { }

        public virtual void PutOrGet<T>(ref Dictionary<short, T> data) where T : ISerializable { }

        public virtual void PutOrGet<T>(ref Dictionary<int, T> data) where T : ISerializable { }

        public virtual void PutOrGet<T>(ref Dictionary<long, T> data) where T : ISerializable { }

        public virtual void PutOrGet<T>(ref Dictionary<string, T> data) where T : ISerializable { }
    }

}
