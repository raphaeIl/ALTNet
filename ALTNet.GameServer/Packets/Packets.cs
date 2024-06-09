using Serilog;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace ALTNet.GameServer.Packets
{
    public struct PacketStream
    {
        public const uint HeadFence = 2864434397U;

        public const uint TailFence = 287454020U;

        public const int CompressThreshold = 1024;

        public const ushort MinHeaderSize = 12;

        public long Sequence { get; set; }

        public ushort PacketId { get; set; }

        public bool Compressed { get; set; }

        public byte[] Buffer { get; set; }

        public int TotalLength { get; set; }

        public Packet Packet { get; set; }

        public static PacketStream DecodeFromStream(BinaryReader reader)
        {
            int sequenceBytesRead = 0;
            int packetIdBytesRead = 0;

            // head 4
            PacketStream packetStream = new PacketStream()
            {
                TotalLength = reader.ReadInt32(), // 4
                Sequence = Decoder.Decode64(Decoder.ReadRawVarInt64(reader, out sequenceBytesRead)),
                PacketId = (ushort)Decoder.ReadRawVarInt32(reader, out packetIdBytesRead), // packetid: 216
                Compressed = reader.ReadBoolean(), // 1
            };

            Log.Information($"sequenceBytesRead: {sequenceBytesRead}");
            Log.Information($"packetIdBytesRead: {packetIdBytesRead}");

            packetStream.Packet = PacketStream.DecodePacket(reader, packetStream.PacketId, packetStream.Compressed);

            Log.Information(packetStream.ToString());

            Log.Information("Decoded Packet:");
            Log.Information(packetStream.Packet.ToString());


            return packetStream;
        }

        public static byte[] EncodeToBuffer(ushort packetId, byte[] packetBuffer)
        {
            byte[] encodedBuffer = null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                {
                    PacketWriter packetWriter = new PacketWriter(binaryWriter);

                    int totalLength = 20;
                    long sequence = 1;
                    bool compressed = false;
                    int bufferSize = packetBuffer.Length;

                    packetWriter.PutRawUint(2864434397U);
                    packetWriter.PutRawInt(totalLength);
                    packetWriter.PutOrGet(ref sequence);
                    packetWriter.PutOrGet(ref packetId);
                    packetWriter.PutOrGet(ref compressed);
                    packetWriter.PutInt(bufferSize);
                    binaryWriter.Write(packetBuffer);
                    packetWriter.PutRawUint(287454020U);

                }
                encodedBuffer = memoryStream.ToArray();
            }

            return encodedBuffer;
        }

        public static byte[] EncodePacket(Packet packet)
        {
            return new byte[23];
        }

        public static Packet DecodePacket(BinaryReader reader, ushort packetId, bool compressed)
        {
            byte[] packetBuffer = GetPacketBuffer(reader);

            Log.Information("packetBuffer: " + BitConverter.ToString(packetBuffer));

            if (compressed)
            {
                // idk
            }

            Crypto.Encrypt(packetBuffer, packetBuffer.Length);

            PacketReader packetReader = new PacketReader(packetBuffer);

            ISerializable packet = PacketStream.CreatePacket(packetId);

            packetReader.DeserializePacket(packet); // this is modifying the packet passed in

            return packet as Packet;
        }

        private static ISerializable CreatePacket(ushort packetId)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type packetAttribute = typeof(PacketIdAttribute);

            var allPacketsTypes = assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(Packet)) && x.GetCustomAttributes(packetAttribute, true).Length > 0).ToList();
            ISerializable result = default;

            foreach (var type in allPacketsTypes)
            {
                var attributeInstance = type.GetCustomAttributes(packetAttribute, true).FirstOrDefault() as PacketIdAttribute;

                Log.Information(type.ToString());

                if (attributeInstance != null && attributeInstance.PacketId == packetId)
                {
                    result = Activator.CreateInstance(type) as ISerializable;
                    break;
                }
            }

            return result;
        }

        private static byte[] GetPacketBuffer(BinaryReader reader)
        {
            int bufferLength = Decoder.Decode32(Decoder.ReadRawVarInt32(reader));

            Log.Information($"GetPacketBuffer bufferLength: {bufferLength}");

            return reader.ReadBytes(bufferLength);
        }

        public override string ToString()
        {
            return $"PacketStream:\n" +
                   $"  TotalLength: {TotalLength}\n" +
                   $"  Sequence: {Sequence}\n" +
                   $"  PacketId: {PacketId}\n" +
                   $"  Compressed: {Compressed}\n";
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class PacketIdAttribute : Attribute
    {
        public PacketIdAttribute(object packetId)
        {
            string text = packetId.ToString();
            this.PacketId = (ushort)Enum.Parse(packetId.GetType(), text);
            this.PacketIdStr = string.Format("[{0}] {1}", this.PacketId, text);
        }

        public ushort PacketId { get; }

        public string PacketIdStr { get; }

        public const ushort InvalidPacketId = 65535;
    }

    public interface ISerializable
    {
        void Serialize(PacketSerializer serializer);
    }

    public class Packet : ISerializable
    {
        public virtual void Serialize(PacketSerializer serializer) { }

        public override string ToString()
        {
            if (this == null)
                return "null";

            Type type = this.GetType();
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(type.Name + " {");

            foreach (FieldInfo field in fields)
            {
                object value = field.GetValue(this);
                sb.AppendLine($"  {field.Name}: {value}");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    [PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_REQ)]
    public sealed class NKMPacket_CONTENTS_VERSION_REQ : Packet
    {
    }

    [PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_ACK)]
    public sealed class NKMPacket_CONTENTS_VERSION_ACK : Packet
    {
        public NKM_ERROR_CODE errorCode;

        public string contentsVersion;

        public List<string> contentsTag = new List<string>();

        public DateTime utcTime;
        
        public TimeSpan utcOffset;

        public override void Serialize(PacketSerializer serializer)
        {
            base.Serialize(serializer);
        }
    }
}
