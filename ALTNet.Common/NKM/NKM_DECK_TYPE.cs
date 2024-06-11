using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x020003DE RID: 990
	public enum NKM_DECK_TYPE : byte
	{
		// Token: 0x04001334 RID: 4916
		[CountryDescription("소대타입 없음", CountryCode.KOR)]
		NDT_NONE,
		// Token: 0x04001335 RID: 4917
		[CountryDescription("전역 소대", CountryCode.KOR)]
		NDT_NORMAL,
		// Token: 0x04001336 RID: 4918
		[CountryDescription("경쟁전 소대", CountryCode.KOR)]
		NDT_PVP,
		// Token: 0x04001337 RID: 4919
		[CountryDescription("전투 소대", CountryCode.KOR)]
		NDT_DAILY,
		// Token: 0x04001338 RID: 4920
		[CountryDescription("레이드 소대", CountryCode.KOR)]
		NDT_RAID,
		// Token: 0x04001339 RID: 4921
		[CountryDescription("친구 소대", CountryCode.KOR)]
		NDT_FRIEND,
		// Token: 0x0400133A RID: 4922
		[CountryDescription("전략전 방어소대", CountryCode.KOR)]
		NDT_PVP_DEFENCE,
		// Token: 0x0400133B RID: 4923
		[CountryDescription("트리밍 던전 소대", CountryCode.KOR)]
		NDT_TRIM,
		// Token: 0x0400133C RID: 4924
		[CountryDescription("다이브 소대", CountryCode.KOR)]
		NDT_DIVE,
		// Token: 0x0400133D RID: 4925
		[CountryDescription("토너먼트 소대", CountryCode.KOR)]
		NDT_TOURNAMENT
	}
}
