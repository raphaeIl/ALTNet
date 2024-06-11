using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x0200119D RID: 4509
	public sealed class FierceRewardHistoryInfo : ISerializable
	{
		// Token: 0x0600A955 RID: 43349 RVA: 0x00385085 File Offset: 0x00383285
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<FierceRewardType>(ref this.fierceRewardType);
			stream.PutOrGet(ref this.fierceRewardId);
		}

		// Token: 0x04009CB9 RID: 40121
		public FierceRewardType fierceRewardType;

		// Token: 0x04009CBA RID: 40122
		public int fierceRewardId;
	}
}
