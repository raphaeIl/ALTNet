using Cs.Protocol;
using Protocol;

namespace ClientPacket.Service
{
	// Token: 0x02000E22 RID: 3618
	[PacketId(ClientPacketId.kNKMPacket_SERVER_TIME_ACK)]
	public sealed class NKMPacket_SERVER_TIME_ACK : ISerializable
	{
		// Token: 0x0600A2A0 RID: 41632 RVA: 0x0037B131 File Offset: 0x00379331
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.utcServerTimeTicks);
		}

		// Token: 0x040093A1 RID: 37793
		public long utcServerTimeTicks;
	}
}
