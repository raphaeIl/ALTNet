using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000D8C RID: 3468
	[PacketId(ClientPacketId.kNKMPacket_POST_LIST_ACK)]
	public sealed class NKMPacket_POST_LIST_ACK : ISerializable
	{
		// Token: 0x0600A174 RID: 41332 RVA: 0x00379662 File Offset: 0x00377862
		void ISerializable.Serialize(IPacketStream stream)
		{
            stream.PutOrGet<NKMPostData>(ref this.postDataList);
			stream.PutOrGet(ref this.postCount);
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
		}

		// Token: 0x0400922B RID: 37419
		public List<NKMPostData> postDataList = new List<NKMPostData>();

		// Token: 0x0400922C RID: 37420
		public int postCount;

		// Token: 0x0400922D RID: 37421
		public NKM_ERROR_CODE errorCode;
	}
}
