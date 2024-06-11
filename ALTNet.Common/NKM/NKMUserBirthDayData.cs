using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000372 RID: 882
	public class NKMUserBirthDayData : ISerializable
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x000594D9 File Offset: 0x000576D9
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<BirthDayDate>(ref this.BirthDay);
			stream.PutOrGet(ref this.Years);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000594F3 File Offset: 0x000576F3
		public bool IsLeapDay()
		{
			return this.BirthDay.Month == 2 && this.BirthDay.Day == 29;
		}

		// Token: 0x04000ECF RID: 3791
		public BirthDayDate BirthDay;

		// Token: 0x04000ED0 RID: 3792
		public int Years;

		// Token: 0x04000ED1 RID: 3793
		public DateTime NextRewardResetDate;
	}
}
