using Cs.Protocol;
using Protocol;

namespace ClientPacket.Community
{
	// Token: 0x02001154 RID: 4436
	[PacketId(ClientPacketId.kNKMPacket_GREETING_MESSAGE_REQ)]
	public sealed class NKMPacket_GREETING_MESSAGE_REQ : ISerializable
	{
		// Token: 0x0600A8D3 RID: 43219 RVA: 0x003842A8 File Offset: 0x003824A8
		void ISerializable.Serialize(IPacketStream stream)
		{
		}
	}
}
