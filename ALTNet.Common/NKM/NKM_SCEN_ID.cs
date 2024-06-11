using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x02000516 RID: 1302
	public enum NKM_SCEN_ID
	{
		// Token: 0x04002759 RID: 10073
		[CountryDescription("알수없음", CountryCode.KOR)]
		NSI_INVALID,
		// Token: 0x0400275A RID: 10074
		[CountryDescription("로그인", CountryCode.KOR)]
		NSI_LOGIN,
		// Token: 0x0400275B RID: 10075
		[CountryDescription("로비", CountryCode.KOR)]
		NSI_HOME,
		// Token: 0x0400275C RID: 10076
		[CountryDescription("게임", CountryCode.KOR)]
		NSI_GAME,
		// Token: 0x0400275D RID: 10077
		[CountryDescription("편성", CountryCode.KOR)]
		NSI_TEAM,
		// Token: 0x0400275E RID: 10078
		[CountryDescription("본부", CountryCode.KOR)]
		NSI_BASE,
		// Token: 0x0400275F RID: 10079
		[CountryDescription("채용", CountryCode.KOR)]
		NSI_CONTRACT,
		// Token: 0x04002760 RID: 10080
		[CountryDescription("관리부", CountryCode.KOR)]
		NSI_INVENTORY,
		// Token: 0x04002761 RID: 10081
		[CountryDescription("컷신 시뮬레이터", CountryCode.KOR)]
		NSI_CUTSCENE_SIM,
		// Token: 0x04002762 RID: 10082
		[CountryDescription("작전", CountryCode.KOR)]
		NSI_OPERATION,
		// Token: 0x04002763 RID: 10083
		[CountryDescription("에피소드", CountryCode.KOR)]
		NSI_EPISODE,
		// Token: 0x04002764 RID: 10084
		[CountryDescription("전투대기", CountryCode.KOR)]
		NSI_DUNGEON_ATK_READY,
		// Token: 0x04002765 RID: 10085
		[CountryDescription("유닛(함선) 리스트", CountryCode.KOR)]
		NSI_UNIT_LIST,
		// Token: 0x04002766 RID: 10086
		[CountryDescription("도감", CountryCode.KOR)]
		NSI_COLLECTION,
		// Token: 0x04002767 RID: 10087
		[CountryDescription("전역전투", CountryCode.KOR)]
		NSI_WARFARE_GAME,
		// Token: 0x04002768 RID: 10088
		[CountryDescription("상점", CountryCode.KOR)]
		NSI_SHOP,
		// Token: 0x04002769 RID: 10089
		[CountryDescription("친구", CountryCode.KOR)]
		NSI_FRIEND,
		// Token: 0x0400276A RID: 10090
		[CountryDescription("월드맵", CountryCode.KOR)]
		NSI_WORLDMAP,
		// Token: 0x0400276B RID: 10091
		[CountryDescription("컷신던전", CountryCode.KOR)]
		NSI_CUTSCENE_DUNGEON,
		// Token: 0x0400276C RID: 10092
		[CountryDescription("게임결과", CountryCode.KOR)]
		NSI_GAME_RESULT,
		// Token: 0x0400276D RID: 10093
		[CountryDescription("다이브준비", CountryCode.KOR)]
		NSI_DIVE_READY,
		// Token: 0x0400276E RID: 10094
		[CountryDescription("다이브", CountryCode.KOR)]
		NSI_DIVE,
		// Token: 0x0400276F RID: 10095
		[CountryDescription("다이브결과", CountryCode.KOR)]
		NSI_DIVE_RESULT,
		// Token: 0x04002770 RID: 10096
		[CountryDescription("PVP 인트로", CountryCode.KOR)]
		NSI_GAUNTLET_INTRO,
		// Token: 0x04002771 RID: 10097
		[CountryDescription("PVP 로비", CountryCode.KOR)]
		NSI_GAUNTLET_LOBBY,
		// Token: 0x04002772 RID: 10098
		[CountryDescription("PVP 매치대기", CountryCode.KOR)]
		NSI_GAUNTLET_MATCH_READY,
		// Token: 0x04002773 RID: 10099
		[CountryDescription("PVP 매치", CountryCode.KOR)]
		NSI_GAUNTLET_MATCH,
		// Token: 0x04002774 RID: 10100
		[CountryDescription("PVP 전략전 준비", CountryCode.KOR)]
		NSI_GAUNTLET_ASYNC_READY,
		// Token: 0x04002775 RID: 10101
		[CountryDescription("레이드", CountryCode.KOR)]
		NSI_RAID,
		// Token: 0x04002776 RID: 10102
		[CountryDescription("레이드 준비", CountryCode.KOR)]
		NSI_RAID_READY,
		// Token: 0x04002777 RID: 10103
		[CountryDescription("보이스리스트", CountryCode.KOR)]
		NSI_VOICE_LIST,
		// Token: 0x04002778 RID: 10104
		[CountryDescription("그림자 전당", CountryCode.KOR)]
		NSI_SHADOW_PALACE,
		// Token: 0x04002779 RID: 10105
		[CountryDescription("그림자 전당 미션", CountryCode.KOR)]
		NSI_SHADOW_BATTLE,
		// Token: 0x0400277A RID: 10106
		[CountryDescription("그림자 전당 결과", CountryCode.KOR)]
		NSI_SHADOW_RESULT,
		// Token: 0x0400277B RID: 10107
		[CountryDescription("컨소시움 인트로", CountryCode.KOR)]
		NSI_GUILD_INTRO,
		// Token: 0x0400277C RID: 10108
		[CountryDescription("컨소시움 로비", CountryCode.KOR)]
		NSI_GUILD_LOBBY,
		// Token: 0x0400277D RID: 10109
		[CountryDescription("격전 지원", CountryCode.KOR)]
		NSI_FIERCE_BATTLE_SUPPORT,
		// Token: 0x0400277E RID: 10110
		[CountryDescription("길드 협력전", CountryCode.KOR)]
		NSI_GUILD_COOP,
		// Token: 0x0400277F RID: 10111
		[CountryDescription("PVP 친선전 준비", CountryCode.KOR)]
		NSI_GAUNTLET_PRIVATE_READY,
		// Token: 0x04002780 RID: 10112
		[CountryDescription("사옥", CountryCode.KOR)]
		NSI_OFFICE,
		// Token: 0x04002781 RID: 10113
		[CountryDescription("PVP 리그전 룸", CountryCode.KOR)]
		NSI_GAUNTLET_LEAGUE_ROOM,
		// Token: 0x04002782 RID: 10114
		[CountryDescription("PVP 친선전 룸", CountryCode.KOR)]
		NSI_GAUNTLET_PRIVATE_ROOM,
		// Token: 0x04002783 RID: 10115
		[CountryDescription("PVP 친선전 룸 덱 구성", CountryCode.KOR)]
		NSI_GAUNTLET_PRIVATE_ROOM_DECK_SELECT,
		// Token: 0x04002784 RID: 10116
		[CountryDescription("디멘션 트리밍", CountryCode.KOR)]
		NSI_TRIM,
		// Token: 0x04002785 RID: 10117
		[CountryDescription("디멘션 트리밍 결과", CountryCode.KOR)]
		NSI_TRIM_RESULT,
		// Token: 0x04002786 RID: 10118
		[CountryDescription("던전 결과", CountryCode.KOR)]
		NSI_DUNGEON_RESULT,
		// Token: 0x04002787 RID: 10119
		[CountryDescription("PVP 이벤트전 준비", CountryCode.KOR)]
		NSI_GAUNTLET_EVENT_READY
	}
}
