using Cs.Protocol;
using Protocol;

namespace ClientPacket.Service
{
    // Token: 0x02000E1D RID: 3613
    [PacketId(ClientPacketId.kNKMPacket_HEART_BIT_REQ)]
	public sealed class NKMPacket_HEART_BIT_REQ : ISerializable
	{
		// Token: 0x0600A296 RID: 41622 RVA: 0x0037B0E7 File Offset: 0x003792E7
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.time);
		}

		// Token: 0x0400939F RID: 37791
		public long time;
	}
}
