using Cs.Protocol;
using Protocol;

namespace ClientPacket.Service
{
	// Token: 0x02000E1E RID: 3614
	[PacketId(ClientPacketId.kNKMPacket_HEART_BIT_ACK)]
	public sealed class NKMPacket_HEART_BIT_ACK : ISerializable
	{
		// Token: 0x0600A298 RID: 41624 RVA: 0x0037B0FD File Offset: 0x003792FD
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.time);
		}

		// Token: 0x040093A0 RID: 37792
		public long time;
	}
}
