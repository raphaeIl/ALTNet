using Cs.Protocol;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000D8B RID: 3467
	[PacketId(ClientPacketId.kNKMPacket_POST_LIST_REQ)]
	public sealed class NKMPacket_POST_LIST_REQ : ISerializable
	{
		// Token: 0x0600A172 RID: 41330 RVA: 0x0037964C File Offset: 0x0037784C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.lastPostIndex);
		}

		// Token: 0x0400922A RID: 37418
		public long lastPostIndex;
	}
}
