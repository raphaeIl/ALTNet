using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Community
{
	// Token: 0x0200111F RID: 4383
	[PacketId(ClientPacketId.kNKMPacket_FRIEND_LIST_REQ)]
	public sealed class NKMPacket_FRIEND_LIST_REQ : ISerializable
	{
		// Token: 0x0600A869 RID: 43113 RVA: 0x00383A85 File Offset: 0x00381C85
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_FRIEND_LIST_TYPE>(ref this.friendListType);
		}

		// Token: 0x04009B6B RID: 39787
		public NKM_FRIEND_LIST_TYPE friendListType;
	}
}
