using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x02000386 RID: 902
	public enum NKM_ITEM_PAYMENT_TYPE : byte
	{
		// Token: 0x04000F62 RID: 3938
		[CountryDescription("무료", CountryCode.KOR)]
		NIPT_FREE,
		// Token: 0x04000F63 RID: 3939
		[CountryDescription("유료", CountryCode.KOR)]
		NIPT_PAID,
		// Token: 0x04000F64 RID: 3940
		[CountryDescription("무료,유료", CountryCode.KOR)]
		NIPT_BOTH
	}
}
