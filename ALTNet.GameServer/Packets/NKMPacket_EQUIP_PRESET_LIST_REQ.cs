using Cs.Protocol;
using Protocol;

namespace ClientPacket.Item
{
	// Token: 0x02000FA6 RID: 4006
	[PacketId(ClientPacketId.kNKMPacket_EQUIP_PRESET_LIST_REQ)]
	public sealed class NKMPacket_EQUIP_PRESET_LIST_REQ : ISerializable
	{
		// Token: 0x0600A597 RID: 42391 RVA: 0x0037F4D2 File Offset: 0x0037D6D2
		void ISerializable.Serialize(IPacketStream stream)
		{
		}
	}
}
