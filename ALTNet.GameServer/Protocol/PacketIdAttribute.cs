namespace Cs.Protocol
{
    // Token: 0x02001CAC RID: 7340
    [AttributeUsage(AttributeTargets.Class)]
    public class PacketIdAttribute : Attribute
    {
        // Token: 0x0600CB9C RID: 52124 RVA: 0x003B25A0 File Offset: 0x003B07A0
        public PacketIdAttribute(object packetId)
        {
            string text = packetId.ToString();
            this.PacketId = (ushort)Enum.Parse(packetId.GetType(), text);
            this.PacketIdStr = string.Format("[{0}] {1}", this.PacketId, text);
        }

        // Token: 0x17001BED RID: 7149
        // (get) Token: 0x0600CB9D RID: 52125 RVA: 0x00089BB6 File Offset: 0x00087DB6
        public ushort PacketId { get; }

        // Token: 0x17001BEE RID: 7150
        // (get) Token: 0x0600CB9E RID: 52126 RVA: 0x00089BBE File Offset: 0x00087DBE
        public string PacketIdStr { get; }

        // Token: 0x0400BE50 RID: 48720
        public const ushort InvalidPacketId = 65535;
    }
}

