using Cs.Protocol;
using Protocol;

namespace ClientPacket.Service
{
	// Token: 0x02000E21 RID: 3617
	[PacketId(ClientPacketId.kNKMPacket_SERVER_TIME_REQ)]
	public sealed class NKMPacket_SERVER_TIME_REQ : ISerializable
	{
		// Token: 0x0600A29E RID: 41630 RVA: 0x0037B127 File Offset: 0x00379327
		void ISerializable.Serialize(IPacketStream stream)
		{
		}
	}
}
