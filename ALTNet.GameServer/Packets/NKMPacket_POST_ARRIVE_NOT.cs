using System;
using Cs.Protocol;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000D8F RID: 3471
	[PacketId(ClientPacketId.kNKMPacket_POST_ARRIVE_NOT)]
	public sealed class NKMPacket_POST_ARRIVE_NOT : ISerializable
	{
		// Token: 0x0600A17A RID: 41338 RVA: 0x003796EB File Offset: 0x003778EB
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.count);
		}

		// Token: 0x04009233 RID: 37427
		public int count;
	}
}
