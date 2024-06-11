using System;
using Cs.Protocol;

namespace ClientPacket.Shop
{
	// Token: 0x02000DFE RID: 3582
	public sealed class NKMConsumerPackageData : ISerializable
	{
		// Token: 0x0600A258 RID: 41560 RVA: 0x0037AA40 File Offset: 0x00378C40
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.productId);
			stream.PutOrGet(ref this.rewardedLevel);
			stream.PutOrGet(ref this.spendCount);
		}

		// Token: 0x04009344 RID: 37700
		public int productId;

		// Token: 0x04009345 RID: 37701
		public int rewardedLevel;

		// Token: 0x04009346 RID: 37702
		public long spendCount;
	}
}
