using System;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x0200047D RID: 1149
	public class NKMShopRandomListData : ISerializable
	{
		// Token: 0x06001F73 RID: 8051 RVA: 0x00097808 File Offset: 0x00095A08
		public int GetPrice()
		{
			if (this.discountRatio > 0)
			{
				return this.price * (100 - this.discountRatio) / 100;
			}
			return this.price;
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00097830 File Offset: 0x00095A30
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.itemId);
			stream.PutOrGetEnum<NKM_REWARD_TYPE>(ref this.itemType);
			stream.PutOrGet(ref this.itemCount);
			stream.PutOrGet(ref this.priceItemId);
			stream.PutOrGet(ref this.price);
			stream.PutOrGet(ref this.isBuy);
			stream.PutOrGet(ref this.discountRatio);
		}

		// Token: 0x040020D8 RID: 8408
		public int itemId;

		// Token: 0x040020D9 RID: 8409
		public NKM_REWARD_TYPE itemType;

		// Token: 0x040020DA RID: 8410
		public int itemCount;

		// Token: 0x040020DB RID: 8411
		public int priceItemId;

		// Token: 0x040020DC RID: 8412
		public int price;

		// Token: 0x040020DD RID: 8413
		public bool isBuy;

		// Token: 0x040020DE RID: 8414
		public int discountRatio;
	}
}
