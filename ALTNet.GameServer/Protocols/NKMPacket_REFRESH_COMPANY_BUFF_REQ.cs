using Cs.Protocol;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000DA8 RID: 3496
	[PacketId(ClientPacketId.kNKMPacket_REFRESH_COMPANY_BUFF_REQ)]
	public sealed class NKMPacket_REFRESH_COMPANY_BUFF_REQ : ISerializable
	{
		// Token: 0x0600A1AC RID: 41388 RVA: 0x00379B85 File Offset: 0x00377D85
		void ISerializable.Serialize(IPacketStream stream)
		{
		}
	}
}
