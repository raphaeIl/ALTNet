using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x0200061F RID: 1567
	public enum NKM_UNIT_STYLE_TYPE : short
	{
		// Token: 0x04002FAB RID: 12203
		[CountryDescription("알수없음", CountryCode.KOR)]
		NUST_INVALID,
		// Token: 0x04002FAC RID: 12204
		[CountryDescription("카운터", CountryCode.KOR)]
		NUST_COUNTER,
		// Token: 0x04002FAD RID: 12205
		[CountryDescription("솔져", CountryCode.KOR)]
		NUST_SOLDIER,
		// Token: 0x04002FAE RID: 12206
		[CountryDescription("메카닉", CountryCode.KOR)]
		NUST_MECHANIC,
		// Token: 0x04002FAF RID: 12207
		[CountryDescription("침식체", CountryCode.KOR)]
		NUST_CORRUPTED,
		// Token: 0x04002FB0 RID: 12208
		[CountryDescription("리플레이서", CountryCode.KOR)]
		NUST_REPLACER,
		// Token: 0x04002FB1 RID: 12209
		[CountryDescription("재료전용유닛", CountryCode.KOR)]
		NUST_TRAINER,
		// Token: 0x04002FB2 RID: 12210
		[CountryDescription("강습함", CountryCode.KOR)]
		NUST_SHIP_ASSAULT,
		// Token: 0x04002FB3 RID: 12211
		[CountryDescription("중장함", CountryCode.KOR)]
		NUST_SHIP_HEAVY,
		// Token: 0x04002FB4 RID: 12212
		[CountryDescription("순양함", CountryCode.KOR)]
		NUST_SHIP_CRUISER,
		// Token: 0x04002FB5 RID: 12213
		[CountryDescription("특무함", CountryCode.KOR)]
		NUST_SHIP_SPECIAL,
		// Token: 0x04002FB6 RID: 12214
		[CountryDescription("초계기", CountryCode.KOR)]
		NUST_SHIP_PATROL,
		// Token: 0x04002FB7 RID: 12215
		[CountryDescription("미분류", CountryCode.KOR)]
		NUST_SHIP_ETC,
		// Token: 0x04002FB8 RID: 12216
		[CountryDescription("환경유닛", CountryCode.KOR)]
		NUST_ENV,
		// Token: 0x04002FB9 RID: 12217
		[CountryDescription("기타", CountryCode.KOR)]
		NUST_ETC,
		// Token: 0x04002FBA RID: 12218
		[CountryDescription("강화 모듈", CountryCode.KOR)]
		NUST_ENCHANT,
		// Token: 0x04002FBB RID: 12219
		[CountryDescription("오퍼레이터", CountryCode.KOR)]
		NUST_OPERATOR
	}
}
