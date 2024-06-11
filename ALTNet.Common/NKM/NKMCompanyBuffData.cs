using System;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x020003BC RID: 956
	public class NKMCompanyBuffData : ISerializable
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00067C3A File Offset: 0x00065E3A
		public int Id
		{
			get
			{
				return this.companyBuffId;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00067C42 File Offset: 0x00065E42
		public long ExpireTicks
		{
			get
			{
				return this.expireTicks;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00067C4A File Offset: 0x00065E4A
		public DateTime ExpireDate
		{
			get
			{
				return new DateTime(this.expireTicks, DateTimeKind.Utc);
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00067C58 File Offset: 0x00065E58
		public NKMCompanyBuffData()
		{
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00067C60 File Offset: 0x00065E60
		public NKMCompanyBuffData(NKMCompanyBuffTemplet templet, DateTime current)
		{
			this.companyBuffId = templet.m_CompanyBuffID;
			this.expireTicks = current.AddMinutes((double)templet.m_CompanyBuffTime).Ticks;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00067C9B File Offset: 0x00065E9B
		public NKMCompanyBuffData(int companyBuffId, long expireTicks)
		{
			this.companyBuffId = companyBuffId;
			this.expireTicks = expireTicks;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00067CB4 File Offset: 0x00065EB4
		public void UpdateExpireTicksAsMinutes(int minutes)
		{
			DateTime dateTime = new DateTime(this.ExpireTicks, DateTimeKind.Utc);
			this.expireTicks = dateTime.AddMinutes((double)minutes).Ticks;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00067CE6 File Offset: 0x00065EE6
		public void SetExpireTicks(long expireTicks)
		{
			this.expireTicks = expireTicks;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00067CEF File Offset: 0x00065EEF
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.companyBuffId);
			stream.PutOrGet(ref this.expireTicks);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00067D09 File Offset: 0x00065F09
		public void SetExpireTime(DateTime expireTime)
		{
			this.expireTicks = expireTime.Ticks;
		}

		// Token: 0x04001188 RID: 4488
		private int companyBuffId;

		// Token: 0x04001189 RID: 4489
		private long expireTicks;
	}
}
