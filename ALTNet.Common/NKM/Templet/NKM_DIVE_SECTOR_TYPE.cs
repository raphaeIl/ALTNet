using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x020005D6 RID: 1494
	public enum NKM_DIVE_SECTOR_TYPE
	{
		// Token: 0x04002D09 RID: 11529
		[CountryDescription("알수없음", CountryCode.KOR)]
		NDST_SECTOR_NONE,
		// Token: 0x04002D0A RID: 11530
		[CountryDescription("시작섹터", CountryCode.KOR)]
		NDST_SECTOR_START,
		// Token: 0x04002D0B RID: 11531
		[CountryDescription("침식코어", CountryCode.KOR)]
		NDST_SECTOR_BOSS,
		// Token: 0x04002D0C RID: 11532
		[CountryDescription("침식코어(어려움)", CountryCode.KOR)]
		NDST_SECTOR_BOSS_HARD,
		// Token: 0x04002D0D RID: 11533
		[CountryDescription("푸엥카레", CountryCode.KOR)]
		NDST_SECTOR_POINCARE,
		// Token: 0x04002D0E RID: 11534
		[CountryDescription("푸엥카레(어려움)", CountryCode.KOR)]
		NDST_SECTOR_POINCARE_HARD,
		// Token: 0x04002D0F RID: 11535
		[CountryDescription("리만", CountryCode.KOR)]
		NDST_SECTOR_REIMANN,
		// Token: 0x04002D10 RID: 11536
		[CountryDescription("리만(어려움)", CountryCode.KOR)]
		NDST_SECTOR_REIMANN_HARD,
		// Token: 0x04002D11 RID: 11537
		[CountryDescription("건틀렛", CountryCode.KOR)]
		NDST_SECTOR_GAUNTLET,
		// Token: 0x04002D12 RID: 11538
		[CountryDescription("건틀렛(어려움)", CountryCode.KOR)]
		NDST_SECTOR_GAUNTLET_HARD,
		// Token: 0x04002D13 RID: 11539
		[CountryDescription("유클리드", CountryCode.KOR)]
		NDST_SECTOR_EUCLID,
		// Token: 0x04002D14 RID: 11540
		[CountryDescription("유클리드(어려움)", CountryCode.KOR)]
		NDST_SECTOR_EUCLID_HARD
	}
}
