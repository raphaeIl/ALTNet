using ClientPacket.Common;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Community
{
	// Token: 0x02001120 RID: 4384
	[PacketId(ClientPacketId.kNKMPacket_FRIEND_LIST_ACK)]
	public sealed class NKMPacket_FRIEND_LIST_ACK : ISerializable
	{
		// Token: 0x0600A86B RID: 43115 RVA: 0x00383A9B File Offset: 0x00381C9B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGetEnum<NKM_FRIEND_LIST_TYPE>(ref this.friendListType);
			stream.PutOrGet<FriendListData>(ref this.list);
		}

		// Token: 0x04009B6C RID: 39788
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009B6D RID: 39789
		public NKM_FRIEND_LIST_TYPE friendListType;

		// Token: 0x04009B6E RID: 39790
		public List<FriendListData> list = new List<FriendListData>();
	}
}
