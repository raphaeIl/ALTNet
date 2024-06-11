using Serilog;
using Cs.Protocol;
using System.Reflection;
using Protocol;

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

        //public byte[] Buffer { get; set; }
        public ZeroCopyBuffer Buffer { get; set; }

        public int TotalLength { get; set; }

        public ISerializable Packet { get; set; }

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

        public static SendBuffer EncodeToSendBuffer(ISerializable packet)
        {
            SendBuffer sendBuffer = new SendBuffer();

            PacketStream.WriteTo(sendBuffer, packet);

            return sendBuffer;
        }

        public static PacketStream EncodeToPacketStream(ISerializable packet)
        {
            SendBuffer sendBuffer = new SendBuffer();
            var ps = PacketStream.WriteTo(sendBuffer, packet);

            return ps;
        }


        public static PacketStream WriteTo(SendBuffer sendBuffer, ISerializable packet)
        {
            PacketStream packetStream = default;

            using (BinaryWriter writer = sendBuffer.GetWriter())
            {
                packetStream = EncodePacket(packet);

                PacketWriter packetWriter = new PacketWriter(writer);

                var sequence = packetStream.Sequence;
                var packetId = packetStream.PacketId;
                var compressed = packetStream.Compressed;

                packetWriter.PutRawUint(2864434397U);
                packetWriter.PutRawInt(packetStream.TotalLength);
                packetWriter.PutOrGet(ref sequence);
                packetWriter.PutOrGet(ref packetId);
                packetWriter.PutOrGet(ref compressed);
                packetWriter.PutInt(packetStream.Buffer.CalcTotalSize());
                sendBuffer.Absorb(packetStream.Buffer);
                packetWriter.PutRawUint(287454020U);
            }

            return packetStream;
        }

        private static int CalcTotalLength(PacketStream packetStream)
        {
            var sequence = packetStream.Sequence;
            var packetId = packetStream.PacketId;
            var compressed = packetStream.Compressed;

            PacketSizeChecker packetSizeChecker = new PacketSizeChecker();
            packetSizeChecker.CheckRawUint32(2864434397U);
            packetSizeChecker.CheckRawInt32(packetStream.TotalLength);
            packetSizeChecker.PutOrGet(ref sequence);
            packetSizeChecker.PutOrGet(ref packetId);
            packetSizeChecker.PutOrGet(ref compressed);
            packetSizeChecker.PutOrGet(packetStream.Buffer);
            packetSizeChecker.CheckRawUint32(287454020U);
            return packetSizeChecker.Size;
        }

        public static PacketStream EncodePacket(ISerializable packet)
        {
            var packetStream = new PacketStream()
            {
                Sequence = 1,
                PacketId = GetPacketId(packet),
            };

            packetStream.Buffer = PacketWriter.ToBufferWithoutNullBit(packet);

            Log.Information("packetStream.Buffer.CalcTotalSize(): " + packetStream.Buffer.CalcTotalSize());

            if (packetStream.Buffer.CalcTotalSize() > 1024)
            {
                // compress idk
                packetStream.Buffer.Lz4Compress();
                packetStream.Compressed = true;
            } 
            
            else
            {
                packetStream.Buffer.Encrypt();
            }

            packetStream.TotalLength = PacketStream.CalcTotalLength(packetStream);
            Log.Information("packetStream.TotalLength:" + packetStream.TotalLength);

            return packetStream;
        }

        public static ushort GetPacketId(ISerializable packet)
        {
            var packetAtr = packet.GetType().GetCustomAttribute(typeof(PacketIdAttribute)) as PacketIdAttribute;

            return packetAtr.PacketId;
        }

        public static ISerializable DecodePacket(BinaryReader reader, ushort packetId, bool compressed)
        {
            byte[] packetBuffer = GetPacketBuffer(reader);

            Log.Information("packetId received: " + (ClientPacketId)packetId);

            Log.Information("packetBuffer: " + BitConverter.ToString(packetBuffer));

            if (compressed)
            {
                // idk
                
            }

            Crypto.Encrypt(packetBuffer, packetBuffer.Length);

            PacketReader packetReader = new PacketReader(packetBuffer);

            ISerializable packet = PacketStream.CreatePacket(packetId);

            packetReader.DeserializePacket(packet); // this is modifying the packet passed in

            return packet;
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
}
