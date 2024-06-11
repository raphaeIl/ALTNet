using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x02000620 RID: 1568
	public enum NKM_UNIT_ROLE_TYPE : short
	{
		// Token: 0x04002FBD RID: 12221
		[CountryDescription("미분류", CountryCode.KOR)]
		NURT_INVALID,
		// Token: 0x04002FBE RID: 12222
		[CountryDescription("스트라이커", CountryCode.KOR)]
		NURT_STRIKER,
		// Token: 0x04002FBF RID: 12223
		[CountryDescription("레인저", CountryCode.KOR)]
		NURT_RANGER,
		// Token: 0x04002FC0 RID: 12224
		[CountryDescription("디펜더", CountryCode.KOR)]
		NURT_DEFENDER,
		// Token: 0x04002FC1 RID: 12225
		[CountryDescription("스나이퍼", CountryCode.KOR)]
		NURT_SNIPER,
		// Token: 0x04002FC2 RID: 12226
		[CountryDescription("서포터", CountryCode.KOR)]
		NURT_SUPPORTER,
		// Token: 0x04002FC3 RID: 12227
		[CountryDescription("시즈", CountryCode.KOR)]
		NURT_SIEGE,
		// Token: 0x04002FC4 RID: 12228
		[CountryDescription("타워", CountryCode.KOR)]
		NURT_TOWER
	}
}
