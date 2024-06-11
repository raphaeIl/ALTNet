using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x02000405 RID: 1029
	public enum NKM_GAME_TYPE : byte
	{
		// Token: 0x04001B92 RID: 7058
		[CountryDescription("알수없음", CountryCode.KOR)]
		[CountryDescription("沒有內容", CountryCode.TWN)]
		NGT_INVALID,
		// Token: 0x04001B93 RID: 7059
		[CountryDescription("개발용", CountryCode.KOR)]
		[CountryDescription("研發用", CountryCode.TWN)]
		NGT_DEV,
		// Token: 0x04001B94 RID: 7060
		[CountryDescription("연습모드", CountryCode.KOR)]
		[CountryDescription("練習模式", CountryCode.TWN)]
		NGT_PRACTICE,
		// Token: 0x04001B95 RID: 7061
		[CountryDescription("일반던전", CountryCode.KOR)]
		[CountryDescription("一般副本", CountryCode.TWN)]
		NGT_DUNGEON,
		// Token: 0x04001B96 RID: 7062
		[CountryDescription("전역", CountryCode.KOR)]
		[CountryDescription("戰役", CountryCode.TWN)]
		NGT_WARFARE,
		// Token: 0x04001B97 RID: 7063
		[CountryDescription("다이브", CountryCode.KOR)]
		[CountryDescription("躍入", CountryCode.TWN)]
		NGT_DIVE,
		// Token: 0x04001B98 RID: 7064
		[CountryDescription("랭크전", CountryCode.KOR)]
		[CountryDescription("排位賽", CountryCode.TWN)]
		NGT_PVP_RANK,
		// Token: 0x04001B99 RID: 7065
		[CountryDescription("튜토리얼", CountryCode.KOR)]
		[CountryDescription("新手教學", CountryCode.TWN)]
		NGT_TUTORIAL,
		// Token: 0x04001B9A RID: 7066
		[CountryDescription("레이드", CountryCode.KOR)]
		[CountryDescription("團體副本", CountryCode.TWN)]
		NGT_RAID,
		// Token: 0x04001B9B RID: 7067
		[CountryDescription("컷신", CountryCode.KOR)]
		[CountryDescription("過場動畫", CountryCode.TWN)]
		NGT_CUTSCENE,
		// Token: 0x04001B9C RID: 7068
		[CountryDescription("월드맵", CountryCode.KOR)]
		[CountryDescription("世界地圖", CountryCode.TWN)]
		NGT_WORLDMAP,
		// Token: 0x04001B9D RID: 7069
		[CountryDescription("전략전", CountryCode.KOR)]
		[CountryDescription("戰略對抗戰", CountryCode.TWN)]
		NGT_ASYNC_PVP,
		// Token: 0x04001B9E RID: 7070
		[CountryDescription("솔로 레이드", CountryCode.KOR)]
		[CountryDescription("單人團體副本", CountryCode.TWN)]
		NGT_RAID_SOLO,
		// Token: 0x04001B9F RID: 7071
		[CountryDescription("그림자 전당", CountryCode.KOR)]
		[CountryDescription("暗影殿堂", CountryCode.TWN)]
		NGT_SHADOW_PALACE,
		// Token: 0x04001BA0 RID: 7072
		[CountryDescription("격전 지원", CountryCode.KOR)]
		[CountryDescription("激戰支援", CountryCode.TWN)]
		NGT_FIERCE,
		// Token: 0x04001BA1 RID: 7073
		[CountryDescription("페이즈", CountryCode.KOR)]
		[CountryDescription("階段", CountryCode.TWN)]
		NGT_PHASE,
		// Token: 0x04001BA2 RID: 7074
		[CountryDescription("길드 협력전 아레나", CountryCode.KOR)]
		[CountryDescription("(TWN)길드 협력전 아레나", CountryCode.TWN)]
		NGT_GUILD_DUNGEON_ARENA,
		// Token: 0x04001BA3 RID: 7075
		[CountryDescription("길드 협력전 보스", CountryCode.KOR)]
		[CountryDescription("(TWN)길드 협력전 보스", CountryCode.TWN)]
		NGT_GUILD_DUNGEON_BOSS,
		// Token: 0x04001BA4 RID: 7076
		[CountryDescription("친선전", CountryCode.KOR)]
		[CountryDescription("(TWN)친선전", CountryCode.TWN)]
		NGT_PVP_PRIVATE,
		// Token: 0x04001BA5 RID: 7077
		[CountryDescription("리그전", CountryCode.KOR)]
		[CountryDescription("(TWN)리그전", CountryCode.TWN)]
		NGT_PVP_LEAGUE,
		// Token: 0x04001BA6 RID: 7078
		[CountryDescription("전략전 개편", CountryCode.KOR)]
		[CountryDescription("(TWN)전략전 개편", CountryCode.TWN)]
		NGT_PVP_STRATEGY,
		// Token: 0x04001BA7 RID: 7079
		[CountryDescription("전략전 리벤지", CountryCode.KOR)]
		[CountryDescription("(TWN)전략전 리벤지", CountryCode.TWN)]
		NGT_PVP_STRATEGY_REVENGE,
		// Token: 0x04001BA8 RID: 7080
		[CountryDescription("전략전 NPC", CountryCode.KOR)]
		[CountryDescription("(TWN)전략전 NPC", CountryCode.TWN)]
		NGT_PVP_STRATEGY_NPC,
		// Token: 0x04001BA9 RID: 7081
		[CountryDescription("디멘션 트리밍", CountryCode.KOR)]
		[CountryDescription("(TWN)디멘션 트리밍", CountryCode.TWN)]
		NGT_TRIM,
		// Token: 0x04001BAA RID: 7082
		[CountryDescription("이벤트전", CountryCode.KOR)]
		[CountryDescription("(TWN)이벤트전", CountryCode.TWN)]
		NGT_PVP_EVENT,
		// Token: 0x04001BAB RID: 7083
		[CountryDescription("길드 협력전 보스 연습전", CountryCode.KOR)]
		[CountryDescription("(TWN)길드 협력전 보스 연습전", CountryCode.TWN)]
		NGT_GUILD_DUNGEON_BOSS_PRACTICE,
		// Token: 0x04001BAC RID: 7084
		[CountryDescription("무한 디펜스 던전", CountryCode.KOR)]
		[CountryDescription("(TWN)무한 디펜스 던전", CountryCode.TWN)]
		NGT_PVE_DEFENCE,
		// Token: 0x04001BAD RID: 7085
		[CountryDescription("시뮬레이션 게임", CountryCode.KOR)]
		[CountryDescription("(TWN)시뮬레이션 게임", CountryCode.TWN)]
		NGT_PVE_SIMULATED
	}
}
