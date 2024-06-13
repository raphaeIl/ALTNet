using Cs.Protocol;
using Protocol;

namespace ClientPacket.Service
{
	// Token: 0x02000E24 RID: 3620
	[PacketId(ClientPacketId.kNKMPacket_INFORM_MY_LOADING_PROGRESS_REQ)]
	public sealed class NKMPacket_INFORM_MY_LOADING_PROGRESS_REQ : ISerializable
	{
		// Token: 0x0600A2A4 RID: 41636 RVA: 0x0037B15D File Offset: 0x0037935D
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.progress);
		}

		// Token: 0x040093A3 RID: 37795
		public byte progress;
	}
}
