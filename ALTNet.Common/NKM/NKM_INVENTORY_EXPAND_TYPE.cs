using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x0200042A RID: 1066
	public enum NKM_INVENTORY_EXPAND_TYPE
	{
		// Token: 0x04001CF1 RID: 7409
		[CountryDescription("일반인벤", CountryCode.KOR)]
		NIET_NONE,
		// Token: 0x04001CF2 RID: 7410
		[CountryDescription("장비인벤", CountryCode.KOR)]
		NIET_EQUIP,
		// Token: 0x04001CF3 RID: 7411
		[CountryDescription("유닛인벤", CountryCode.KOR)]
		NIET_UNIT,
		// Token: 0x04001CF4 RID: 7412
		[CountryDescription("함선인벤", CountryCode.KOR)]
		NIET_SHIP,
		// Token: 0x04001CF5 RID: 7413
		[CountryDescription("오퍼레이터인벤", CountryCode.KOR)]
		NIET_OPERATOR,
		// Token: 0x04001CF6 RID: 7414
		[CountryDescription("트로피인벤", CountryCode.KOR)]
		NIET_TROPHY,
		// Token: 0x04001CF7 RID: 7415
		[CountryDescription("알수없음", CountryCode.KOR)]
		NEIT_MAX
	}
}
