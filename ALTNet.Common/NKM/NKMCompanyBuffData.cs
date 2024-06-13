using System;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	public class NKMCompanyBuffData : ISerializable
	{
		public int Id
		{
			get
			{
				return this.companyBuffId;
			}
		}

		public long ExpireTicks
		{
			get
			{
				return this.expireTicks;
			}
		}

		public DateTime ExpireDate
		{
			get
			{
				return new DateTime(this.expireTicks, DateTimeKind.Utc);
			}
		}

		public NKMCompanyBuffData()
		{
		}

		public NKMCompanyBuffData(NKMCompanyBuffTemplet templet, DateTime current)
		{
			this.companyBuffId = templet.m_CompanyBuffID;
			this.expireTicks = current.AddMinutes((double)templet.m_CompanyBuffTime).Ticks;
		}

		public NKMCompanyBuffData(int companyBuffId, long expireTicks)
		{
			this.companyBuffId = companyBuffId;
			this.expireTicks = expireTicks;
		}

		public void UpdateExpireTicksAsMinutes(int minutes)
		{
			DateTime dateTime = new DateTime(this.ExpireTicks, DateTimeKind.Utc);
			this.expireTicks = dateTime.AddMinutes((double)minutes).Ticks;
		}

		public void SetExpireTicks(long expireTicks)
		{
			this.expireTicks = expireTicks;
		}

		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.companyBuffId);
			stream.PutOrGet(ref this.expireTicks);
		}

		public void SetExpireTime(DateTime expireTime)
		{
			this.expireTicks = expireTime.Ticks;
		}

		private int companyBuffId;

		private long expireTicks;
	}
}
