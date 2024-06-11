using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x02000639 RID: 1593
	public enum EPISODE_CATEGORY
	{
		// Token: 0x040030ED RID: 12525
		[CountryDescription("메인스트림", CountryCode.KOR)]
		EC_MAINSTREAM,
		// Token: 0x040030EE RID: 12526
		[CountryDescription("모의작전", CountryCode.KOR)]
		EC_DAILY,
		// Token: 0x040030EF RID: 12527
		[CountryDescription("카운터케이스", CountryCode.KOR)]
		EC_COUNTERCASE,
		// Token: 0x040030F0 RID: 12528
		[CountryDescription("외전", CountryCode.KOR)]
		EC_SIDESTORY,
		// Token: 0x040030F1 RID: 12529
		[CountryDescription("자유 계약", CountryCode.KOR)]
		EC_FIELD,
		// Token: 0x040030F2 RID: 12530
		[CountryDescription("이벤트 에피소드", CountryCode.KOR)]
		EC_EVENT,
		// Token: 0x040030F3 RID: 12531
		[CountryDescription("보급작전", CountryCode.KOR)]
		EC_SUPPLY,
		// Token: 0x040030F4 RID: 12532
		[CountryDescription("챌린지", CountryCode.KOR)]
		EC_CHALLENGE,
		// Token: 0x040030F5 RID: 12533
		[CountryDescription("타임어택", CountryCode.KOR)]
		EC_TIMEATTACK,
		// Token: 0x040030F6 RID: 12534
		[CountryDescription("디멘션 트리밍(작전 구분용)", CountryCode.KOR)]
		EC_TRIM,
		// Token: 0x040030F7 RID: 12535
		[CountryDescription("격전지원(작전 구분용)", CountryCode.KOR)]
		EC_FIERCE,
		// Token: 0x040030F8 RID: 12536
		[CountryDescription("그림자전당(작전 구분용)", CountryCode.KOR)]
		EC_SHADOW,
		// Token: 0x040030F9 RID: 12537
		[CountryDescription("시즈널", CountryCode.KOR)]
		EC_SEASONAL,
		// Token: 0x040030FA RID: 12538
		[CountryDescription("EC_COUNT", CountryCode.KOR)]
		EC_COUNT
	}
}
