using System;
using System.Collections.Generic;
using ClientPacket.Common;
using ClientPacket.Shop;
using Cs.Protocol;
using NKC;
using NKM.Shop;

namespace NKM
{
	// Token: 0x0200047F RID: 1151
	public class NKMShopData : ISerializable
	{
		// Token: 0x06001F78 RID: 8056 RVA: 0x000978D2 File Offset: 0x00095AD2
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMShopPurchaseHistory>(ref this.histories);
			stream.PutOrGet<NKMShopRandomData>(ref this.randomShop);
			stream.PutOrGet<NKMShopSubscriptionData>(ref this.subscriptions);
		}

		// Token: 0x040020E2 RID: 8418
		public Dictionary<int, NKMShopPurchaseHistory> histories = new Dictionary<int, NKMShopPurchaseHistory>();

		// Token: 0x040020E3 RID: 8419
		public NKMShopRandomData randomShop;

		// Token: 0x040020E4 RID: 8420
		public Dictionary<int, NKMShopSubscriptionData> subscriptions;

		// Token: 0x040020E5 RID: 8421
		private double totalPaidAmount;

		// Token: 0x040020E6 RID: 8422
		private List<ShopChainTabNextResetData> m_lstChainTabResetData = new List<ShopChainTabNextResetData>();
	}
}
