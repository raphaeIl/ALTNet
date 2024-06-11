using System;
using Cs.Protocol;

namespace ClientPacket.Shop
{
	// Token: 0x02000DFC RID: 3580
	public sealed class NKMShopPurchaseHistory : ISerializable
	{
		// Token: 0x0600A254 RID: 41556 RVA: 0x0037A9F0 File Offset: 0x00378BF0
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.shopId);
			stream.PutOrGet(ref this.purchaseCount);
			stream.PutOrGet(ref this.nextResetDate);
		}

		// Token: 0x0400933F RID: 37695
		public int shopId;

		// Token: 0x04009340 RID: 37696
		public int purchaseCount;

		// Token: 0x04009341 RID: 37697
		public long nextResetDate;
	}
}
