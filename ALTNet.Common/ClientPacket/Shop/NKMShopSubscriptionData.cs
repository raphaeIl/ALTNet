using System;
using Cs.Protocol;

namespace ClientPacket.Shop
{
	// Token: 0x02000DFB RID: 3579
	public sealed class NKMShopSubscriptionData : ISerializable
	{
		// Token: 0x0600A252 RID: 41554 RVA: 0x0037A9AA File Offset: 0x00378BAA
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.productId);
			stream.PutOrGet(ref this.rewardCount);
			stream.PutOrGet(ref this.lastUpdateDate);
			stream.PutOrGet(ref this.startDate);
			stream.PutOrGet(ref this.endDate);
		}

		// Token: 0x0400933A RID: 37690
		public int productId;

		// Token: 0x0400933B RID: 37691
		public int rewardCount;

		// Token: 0x0400933C RID: 37692
		public DateTime lastUpdateDate;

		// Token: 0x0400933D RID: 37693
		public DateTime startDate;

		// Token: 0x0400933E RID: 37694
		public DateTime endDate;
	}
}
