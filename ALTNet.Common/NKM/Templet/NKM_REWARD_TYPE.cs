using System;
using Cs.GameLog.CountryDescription;

namespace NKM.Templet
{
	// Token: 0x02000608 RID: 1544
	public enum NKM_REWARD_TYPE
	{
		// Token: 0x04002EF9 RID: 12025
		[CountryDescription("알수없음", CountryCode.KOR)]
		RT_NONE,
		// Token: 0x04002EFA RID: 12026
		[CountryDescription("유닛", CountryCode.KOR)]
		[CountryDescription("ユニット", CountryCode.JAPAN)]
		RT_UNIT,
		// Token: 0x04002EFB RID: 12027
		[CountryDescription("함선", CountryCode.KOR)]
		[CountryDescription("艦船", CountryCode.JAPAN)]
		RT_SHIP,
		// Token: 0x04002EFC RID: 12028
		[CountryDescription("일반아이템", CountryCode.KOR)]
		[CountryDescription("一般アイテム", CountryCode.JAPAN)]
		RT_MISC,
		// Token: 0x04002EFD RID: 12029
		[CountryDescription("유저경험치", CountryCode.KOR)]
		RT_USER_EXP,
		// Token: 0x04002EFE RID: 12030
		[CountryDescription("장비", CountryCode.KOR)]
		[CountryDescription("装備", CountryCode.JAPAN)]
		RT_EQUIP,
		// Token: 0x04002EFF RID: 12031
		[CountryDescription("금형", CountryCode.KOR)]
		[CountryDescription("金型", CountryCode.JAPAN)]
		RT_MOLD,
		// Token: 0x04002F00 RID: 12032
		[CountryDescription("스킨", CountryCode.KOR)]
		[CountryDescription("スキン", CountryCode.JAPAN)]
		RT_SKIN,
		// Token: 0x04002F01 RID: 12033
		[CountryDescription("버프아이템", CountryCode.KOR)]
		[CountryDescription("バフアイテム", CountryCode.JAPAN)]
		RT_BUFF,
		// Token: 0x04002F02 RID: 12034
		[CountryDescription("이모티콘", CountryCode.KOR)]
		[CountryDescription("スタンプ", CountryCode.JAPAN)]
		RT_EMOTICON,
		// Token: 0x04002F03 RID: 12035
		[CountryDescription("미션 포인트", CountryCode.KOR)]
		[CountryDescription("ミッションポイント", CountryCode.JAPAN)]
		RT_MISSION_POINT,
		// Token: 0x04002F04 RID: 12036
		[CountryDescription("빙고 타일", CountryCode.KOR)]
		[CountryDescription("ビンゴタイル", CountryCode.JAPAN)]
		RT_BINGO_TILE,
		// Token: 0x04002F05 RID: 12037
		[CountryDescription("이벤트 패스 경험치", CountryCode.KOR)]
		[CountryDescription("イベントパス経験値", CountryCode.JAPAN)]
		RT_PASS_EXP,
		// Token: 0x04002F06 RID: 12038
		[CountryDescription("오퍼레이터", CountryCode.KOR)]
		[CountryDescription("オペレーター", CountryCode.JAPAN)]
		RT_OPERATOR
	}
}
