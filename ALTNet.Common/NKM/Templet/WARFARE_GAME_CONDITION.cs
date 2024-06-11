using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x0200062B RID: 1579
	public enum WARFARE_GAME_CONDITION
	{
		// Token: 0x0400304D RID: 12365
		[CountryDescription("알수없음", CountryCode.KOR)]
		WFC_NONE,
		// Token: 0x0400304E RID: 12366
		[CountryDescription("보스처치", CountryCode.KOR)]
		WFC_KILL_BOSS,
		// Token: 0x0400304F RID: 12367
		[CountryDescription("모두제거", CountryCode.KOR)]
		WFC_KILL_ALL,
		// Token: 0x04003050 RID: 12368
		[CountryDescription("타겟제거", CountryCode.KOR)]
		WFC_KILL_TARGET,
		// Token: 0x04003051 RID: 12369
		[CountryDescription("제거횟수", CountryCode.KOR)]
		WFC_KILL_COUNT,
		// Token: 0x04003052 RID: 12370
		[CountryDescription("타일도착", CountryCode.KOR)]
		WFC_TILE_ENTER,
		// Token: 0x04003053 RID: 12371
		[CountryDescription("페이즈제한", CountryCode.KOR)]
		WFC_PHASE,
		// Token: 0x04003054 RID: 12372
		[CountryDescription("타일점유", CountryCode.KOR)]
		WFC_PHASE_TILE_HOLD,
		// Token: 0x04003055 RID: 12373
		[CountryDescription("", CountryCode.KOR)]
		WFC_ON_DEATH
	}
}
