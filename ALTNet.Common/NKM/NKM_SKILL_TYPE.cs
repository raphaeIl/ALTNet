using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x020004C2 RID: 1218
	public enum NKM_SKILL_TYPE : short
	{
		// Token: 0x040023A5 RID: 9125
		[CountryDescription("알수없음", CountryCode.KOR)]
		NST_INVALID,
		// Token: 0x040023A6 RID: 9126
		[CountryDescription("패시브", CountryCode.KOR)]
		NST_PASSIVE,
		// Token: 0x040023A7 RID: 9127
		[CountryDescription("공격스킬", CountryCode.KOR)]
		NST_ATTACK,
		// Token: 0x040023A8 RID: 9128
		[CountryDescription("액티브", CountryCode.KOR)]
		NST_SKILL,
		// Token: 0x040023A9 RID: 9129
		[CountryDescription("궁극기", CountryCode.KOR)]
		NST_HYPER,
		// Token: 0x040023AA RID: 9130
		[CountryDescription("함선스킬", CountryCode.KOR)]
		NST_SHIP_ACTIVE,
		// Token: 0x040023AB RID: 9131
		[CountryDescription("리더스킬", CountryCode.KOR)]
		NST_LEADER
	}
}
