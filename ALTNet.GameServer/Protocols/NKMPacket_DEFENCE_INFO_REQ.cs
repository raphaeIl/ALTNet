using System;
using Cs.Protocol;
using Protocol;

namespace ClientPacket.Defence
{
	// Token: 0x020010F9 RID: 4345
	[PacketId(ClientPacketId.kNKMPacket_DEFENCE_INFO_REQ)]
	public sealed class NKMPacket_DEFENCE_INFO_REQ : ISerializable
	{
		// Token: 0x0600A821 RID: 43041 RVA: 0x003831B8 File Offset: 0x003813B8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.defenceTempletId);
		}

		// Token: 0x04009AEB RID: 39659
		public int defenceTempletId;
	}
}
