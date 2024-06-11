using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x02000621 RID: 1569
	public enum NKM_UNIT_GRADE : short
	{
		// Token: 0x04002FC6 RID: 12230
		[CountryDescription("N등급", CountryCode.KOR)]
		NUG_N,
		// Token: 0x04002FC7 RID: 12231
		[CountryDescription("R등급", CountryCode.KOR)]
		NUG_R,
		// Token: 0x04002FC8 RID: 12232
		[CountryDescription("SR등급", CountryCode.KOR)]
		NUG_SR,
		// Token: 0x04002FC9 RID: 12233
		[CountryDescription("SSR등급", CountryCode.KOR)]
		NUG_SSR,
		// Token: 0x04002FCA RID: 12234
		NUG_COUNT
	}
}
