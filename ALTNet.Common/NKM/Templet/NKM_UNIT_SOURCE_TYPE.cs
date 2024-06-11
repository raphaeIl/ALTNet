using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x02000622 RID: 1570
	public enum NKM_UNIT_SOURCE_TYPE : short
	{
		// Token: 0x04002FCC RID: 12236
		[CountryDescription("없음", CountryCode.KOR)]
		NUST_NONE,
		// Token: 0x04002FCD RID: 12237
		[CountryDescription("투쟁", CountryCode.KOR)]
		NUST_CONFLICT,
		// Token: 0x04002FCE RID: 12238
		[CountryDescription("안정", CountryCode.KOR)]
		NUST_STABLE,
		// Token: 0x04002FCF RID: 12239
		[CountryDescription("변화", CountryCode.KOR)]
		NUST_LIBERAL
	}
}
