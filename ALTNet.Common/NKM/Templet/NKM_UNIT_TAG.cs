using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x02000623 RID: 1571
	public enum NKM_UNIT_TAG : short
	{
		// Token: 0x04002FD1 RID: 12241
		[CountryDescription("패트롤", CountryCode.KOR)]
		NUT_PATROL,
		// Token: 0x04002FD2 RID: 12242
		[CountryDescription("스윙바이", CountryCode.KOR)]
		NUT_SWINGBY,
		// Token: 0x04002FD3 RID: 12243
		[CountryDescription("전진출격", CountryCode.KOR)]
		NUT_RESPAWN_FREE_POS,
		// Token: 0x04002FD4 RID: 12244
		[CountryDescription("반격", CountryCode.KOR)]
		NUT_REVENGE,
		// Token: 0x04002FD5 RID: 12245
		[CountryDescription("퓨리", CountryCode.KOR)]
		NUT_FURY,
		// Token: 0x04002FD6 RID: 12246
		[CountryDescription("일회성", CountryCode.KOR)]
		NUT_LIMIT_1,
		// Token: 0x04002FD7 RID: 12247
		NUT_LIMIT_2,
		// Token: 0x04002FD8 RID: 12248
		NUT_LIMIT_3
	}
}
