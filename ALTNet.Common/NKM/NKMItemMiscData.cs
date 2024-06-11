using System;
using System.Runtime.Serialization;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000507 RID: 1287
	[DataContract]
	public class NKMItemMiscData : Cs.Protocol.ISerializable
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000BEE57 File Offset: 0x000BD057
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x000BEE5F File Offset: 0x000BD05F
		[DataMember]
		public int ItemID
		{
			get
			{
				return this.m_ItemMiscID;
			}
			set
			{
				this.m_ItemMiscID = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000BEE68 File Offset: 0x000BD068
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x000BEE70 File Offset: 0x000BD070
		[DataMember]
		public long CountFree
		{
			get
			{
				return this.m_CountFree;
			}
			set
			{
				this.m_CountFree = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000BEE79 File Offset: 0x000BD079
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x000BEE81 File Offset: 0x000BD081
		[DataMember]
		public long CountPaid
		{
			get
			{
				return this.m_CountPaid;
			}
			set
			{
				this.m_CountPaid = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000BEE8A File Offset: 0x000BD08A
		[DataMember]
		public long TotalCount
		{
			get
			{
				return this.CountFree + this.CountPaid;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000BEE99 File Offset: 0x000BD099
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x000BEEA1 File Offset: 0x000BD0A1
		[DataMember]
		public DateTime RegDate
		{
			get
			{
				return this.m_RegDate;
			}
			set
			{
				this.m_RegDate = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000BEEAA File Offset: 0x000BD0AA
		public NKM_ITEM_PAYMENT_TYPE PaymentType
		{
			get
			{
				if (this.m_CountFree > 0L && this.m_CountPaid > 0L)
				{
					return NKM_ITEM_PAYMENT_TYPE.NIPT_BOTH;
				}
				if (this.m_CountPaid <= 0L)
				{
					return NKM_ITEM_PAYMENT_TYPE.NIPT_FREE;
				}
				return NKM_ITEM_PAYMENT_TYPE.NIPT_PAID;
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x000BEECF File Offset: 0x000BD0CF
		public NKMItemMiscData()
		{
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x000BEED7 File Offset: 0x000BD0D7
		public NKMItemMiscData(int ItemID, long CountFree, long CountPaid = 0L, int bonusRatio = 0, DateTime regDate = default(DateTime))
		{
			this.m_ItemMiscID = ItemID;
			this.m_CountFree = CountFree;
			this.m_CountPaid = CountPaid;
			this.BonusRatio = bonusRatio;
			this.m_RegDate = regDate;
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x000BEF04 File Offset: 0x000BD104
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_ItemMiscID);
			stream.PutOrGet(ref this.m_CountFree);
			stream.PutOrGet(ref this.m_CountPaid);
			stream.PutOrGet(ref this.BonusRatio);
			stream.PutOrGet(ref this.m_RegDate);
		}

		// Token: 0x040026DA RID: 9946
		public int BonusRatio;

		// Token: 0x040026DB RID: 9947
		private int m_ItemMiscID;

		// Token: 0x040026DC RID: 9948
		private long m_CountFree;

		// Token: 0x040026DD RID: 9949
		private long m_CountPaid;

		// Token: 0x040026DE RID: 9950
		private DateTime m_RegDate;
	}
}
