using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x02000383 RID: 899
	public enum NKM_ITEM_MISC_TYPE : short
	{
		// Token: 0x04000F3D RID: 3901
		[CountryDescription("일반아이템", CountryCode.KOR)]
		IMT_MISC,
		// Token: 0x04000F3E RID: 3902
		[CountryDescription("패키지아이템", CountryCode.KOR)]
		IMT_PACKAGE,
		// Token: 0x04000F3F RID: 3903
		[CountryDescription("랜덤박스아이템", CountryCode.KOR)]
		IMT_RANDOMBOX,
		// Token: 0x04000F40 RID: 3904
		[CountryDescription("자원아이템", CountryCode.KOR)]
		IMT_RESOURCE,
		// Token: 0x04000F41 RID: 3905
		[CountryDescription("엠블렘", CountryCode.KOR)]
		IMT_EMBLEM,
		// Token: 0x04000F42 RID: 3906
		[CountryDescription("랭킹엠블렘", CountryCode.KOR)]
		IMT_EMBLEM_RANK,
		// Token: 0x04000F43 RID: 3907
		[CountryDescription("뷰 전용 아이템", CountryCode.KOR)]
		IMT_VIEW,
		// Token: 0x04000F44 RID: 3908
		[CountryDescription("유닛 선택권", CountryCode.KOR)]
		IMT_CHOICE_UNIT,
		// Token: 0x04000F45 RID: 3909
		[CountryDescription("함선 선택권", CountryCode.KOR)]
		IMT_CHOICE_SHIP,
		// Token: 0x04000F46 RID: 3910
		[CountryDescription("장비 선택권", CountryCode.KOR)]
		IMT_CHOICE_EQUIP,
		// Token: 0x04000F47 RID: 3911
		[CountryDescription("비품 선택권", CountryCode.KOR)]
		IMT_CHOICE_MISC,
		// Token: 0x04000F48 RID: 3912
		[CountryDescription("장비 금형 선택권", CountryCode.KOR)]
		IMT_CHOICE_MOLD,
		// Token: 0x04000F49 RID: 3913
		[CountryDescription("오퍼레이터 선택권", CountryCode.KOR)]
		IMT_CHOICE_OPERATOR,
		// Token: 0x04000F4A RID: 3914
		[CountryDescription("유닛 조각", CountryCode.KOR)]
		IMT_PIECE,
		// Token: 0x04000F4B RID: 3915
		[CountryDescription("로비 배경화면", CountryCode.KOR)]
		IMT_BACKGROUND,
		// Token: 0x04000F4C RID: 3916
		[CountryDescription("프로필 테두리", CountryCode.KOR)]
		IMT_SELFIE_FRAME,
		// Token: 0x04000F4D RID: 3917
		[CountryDescription("커스텀 패키지", CountryCode.KOR)]
		IMT_CUSTOM_PACKAGE,
		// Token: 0x04000F4E RID: 3918
		[CountryDescription("채용 아이템", CountryCode.KOR)]
		IMT_CONTRACT,
		// Token: 0x04000F4F RID: 3919
		[CountryDescription("가구", CountryCode.KOR)]
		IMT_INTERIOR,
		// Token: 0x04000F50 RID: 3920
		[CountryDescription("가구 선택권", CountryCode.KOR)]
		IMT_CHOICE_FURNITURE,
		// Token: 0x04000F51 RID: 3921
		[CountryDescription("스킨 선택권", CountryCode.KOR)]
		IMT_CHOICE_SKIN,
		// Token: 0x04000F52 RID: 3922
		[CountryDescription("칭호", CountryCode.KOR)]
		IMT_TITLE
	}
}
