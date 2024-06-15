namespace Cs.Protocol
{
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
}

