﻿using System;

namespace NKM
{
	// Token: 0x02000440 RID: 1088
	public enum NKM_MISSION_COND
	{
		// Token: 0x04001E38 RID: 7736
		ACCOUNT_LEVEL,
		// Token: 0x04001E39 RID: 7737
		LOGIN_DAYS,
		// Token: 0x04001E3A RID: 7738
		USE_RESOURCE,
		// Token: 0x04001E3B RID: 7739
		COLLECT_RESOURCE,
		// Token: 0x04001E3C RID: 7740
		COLLECT_UNIT,
		// Token: 0x04001E3D RID: 7741
		COLLECT_UNIT_GRADE,
		// Token: 0x04001E3E RID: 7742
		COLLECT_UNIT_LEVEL,
		// Token: 0x04001E3F RID: 7743
		COLLECT_EQUIP,
		// Token: 0x04001E40 RID: 7744
		COLLECT_EQUIP_GRADE,
		// Token: 0x04001E41 RID: 7745
		COLLECT_EQUIP_ENCHANT_LEVEL,
		// Token: 0x04001E42 RID: 7746
		COLLECT_SHIP,
		// Token: 0x04001E43 RID: 7747
		COLLECT_SHIP_LEVEL,
		// Token: 0x04001E44 RID: 7748
		COLLECT_SHIP_GRADE,
		// Token: 0x04001E45 RID: 7749
		COLLECT_MEDAL_GOLD_MAINSTREAM,
		// Token: 0x04001E46 RID: 7750
		COLLECT_MEDAL_SILVER_MAINSTREAM,
		// Token: 0x04001E47 RID: 7751
		COLLECT_MEDAL_BRONZE_MAINSTREAM,
		// Token: 0x04001E48 RID: 7752
		UNIT_CONTRACT,
		// Token: 0x04001E49 RID: 7753
		UNIT_DISMISS,
		// Token: 0x04001E4A RID: 7754
		UNIT_ENCHANT,
		// Token: 0x04001E4B RID: 7755
		UNIT_TRAINING,
		// Token: 0x04001E4C RID: 7756
		UNIT_LIMITBREAK,
		// Token: 0x04001E4D RID: 7757
		UNIT_LIMITBREAK_CONFLUENCE,
		// Token: 0x04001E4E RID: 7758
		EQUIP_ENCHANT,
		// Token: 0x04001E4F RID: 7759
		SHIP_MAKE,
		// Token: 0x04001E50 RID: 7760
		SHIP_UPGRADE,
		// Token: 0x04001E51 RID: 7761
		SHIP_LEVELUP,
		// Token: 0x04001E52 RID: 7762
		SHIP_LIMITBREAK,
		// Token: 0x04001E53 RID: 7763
		WARFARE_CLEAR,
		// Token: 0x04001E54 RID: 7764
		WARFARE_CLEARED,
		// Token: 0x04001E55 RID: 7765
		WARFARE_DEFEATED,
		// Token: 0x04001E56 RID: 7766
		DUNGEON_CLEAR,
		// Token: 0x04001E57 RID: 7767
		DUNGEON_CLEARED,
		// Token: 0x04001E58 RID: 7768
		DUNGEON_DEFEATED,
		// Token: 0x04001E59 RID: 7769
		DAILY_DUNGEON_PLAY,
		// Token: 0x04001E5A RID: 7770
		DIVE_CLEAR,
		// Token: 0x04001E5B RID: 7771
		DIVE_PLAY_RECORD,
		// Token: 0x04001E5C RID: 7772
		PHASE_CLEAR,
		// Token: 0x04001E5D RID: 7773
		RAID_FIND,
		// Token: 0x04001E5E RID: 7774
		RAID_PLAY,
		// Token: 0x04001E5F RID: 7775
		RAID_HIGH_SCORE,
		// Token: 0x04001E60 RID: 7776
		PVP_PLAY_RANK,
		// Token: 0x04001E61 RID: 7777
		PVP_CLEAR_RANK,
		// Token: 0x04001E62 RID: 7778
		PVP_CLEAR_FRIENDLY,
		// Token: 0x04001E63 RID: 7779
		PVP_DEFEATED_RANK,
		// Token: 0x04001E64 RID: 7780
		PVP_DEFEATED_FRIENDLY,
		// Token: 0x04001E65 RID: 7781
		PVP_HIGHEST_TIER,
		// Token: 0x04001E66 RID: 7782
		WORLDMAP_BRANCH_NUMBER,
		// Token: 0x04001E67 RID: 7783
		WORLDMAP_BRANCH_TOTAL_LEVEL,
		// Token: 0x04001E68 RID: 7784
		WORLDMAP_MISSION_TOTAL_LEVEL,
		// Token: 0x04001E69 RID: 7785
		WORLDMAP_MISSION_TOTAL_TIME,
		// Token: 0x04001E6A RID: 7786
		WORLDMAP_MISSION_CLEAR,
		// Token: 0x04001E6B RID: 7787
		SHOP_BUY,
		// Token: 0x04001E6C RID: 7788
		HAVE_FRIEND,
		// Token: 0x04001E6D RID: 7789
		TUTORIAL,
		// Token: 0x04001E6E RID: 7790
		MISSION_CLEAR_DAILY,
		// Token: 0x04001E6F RID: 7791
		MISSION_CLEAR_WEEKLY,
		// Token: 0x04001E70 RID: 7792
		MISSION_CLEAR_MONTHLY,
		// Token: 0x04001E71 RID: 7793
		COUNTER_CASE_OPEN,
		// Token: 0x04001E72 RID: 7794
		NEGOTIATION_TRY,
		// Token: 0x04001E73 RID: 7795
		NEGOTIATION_SUCCESS,
		// Token: 0x04001E74 RID: 7796
		NEGOTIATION_FAIL,
		// Token: 0x04001E75 RID: 7797
		EQUIP_MAKE,
		// Token: 0x04001E76 RID: 7798
		EQUIP_TUNING,
		// Token: 0x04001E77 RID: 7799
		ACHIEVEMENT_CLEAR,
		// Token: 0x04001E78 RID: 7800
		JUST_OPEN,
		// Token: 0x04001E79 RID: 7801
		COLLECT_SHIP_GET,
		// Token: 0x04001E7A RID: 7802
		COLLECT_SHIP_GET_LEVEL,
		// Token: 0x04001E7B RID: 7803
		COLLECT_SHIP_UPGRADE,
		// Token: 0x04001E7C RID: 7804
		COUNTER_CASE_OPENED,
		// Token: 0x04001E7D RID: 7805
		HAVE_DAILY_POINT,
		// Token: 0x04001E7E RID: 7806
		HAVE_WEEKLY_POINT,
		// Token: 0x04001E7F RID: 7807
		PVP_PLAY_ASYNC,
		// Token: 0x04001E80 RID: 7808
		PVP_CLEAR_ASYNC,
		// Token: 0x04001E81 RID: 7809
		PVP_DEFEATED_ASYNC,
		// Token: 0x04001E82 RID: 7810
		PVP_HIGHEST_TIER_ASYNC,
		// Token: 0x04001E83 RID: 7811
		EPISODE_PLAY_COUNT,
		// Token: 0x04001E84 RID: 7812
		EPISODE_PLAY_COUNT_HARD,
		// Token: 0x04001E85 RID: 7813
		DUNGEON_CLEAR_PERFECT,
		// Token: 0x04001E86 RID: 7814
		DUNGEON_CLEARED_PERFECT,
		// Token: 0x04001E87 RID: 7815
		WARFARE_CLEAR_PERFECT,
		// Token: 0x04001E88 RID: 7816
		WARFARE_CLEARED_PERFECT,
		// Token: 0x04001E89 RID: 7817
		PHASE_CLEAR_PERFECT,
		// Token: 0x04001E8A RID: 7818
		PVP_LEAGUE_POINT_RANK,
		// Token: 0x04001E8B RID: 7819
		PVP_LEAGUE_POINT_ASYNC,
		// Token: 0x04001E8C RID: 7820
		UNIT_LEVEL_CHECK,
		// Token: 0x04001E8D RID: 7821
		SHIP_LEVEL_CHECK,
		// Token: 0x04001E8E RID: 7822
		ACHIEVEMENT_CLEARED,
		// Token: 0x04001E8F RID: 7823
		PALACE_CLEAR,
		// Token: 0x04001E90 RID: 7824
		DIVE_HIGHEST_CLEARED,
		// Token: 0x04001E91 RID: 7825
		PVP_HIGHEST_TIER_CLEARED,
		// Token: 0x04001E92 RID: 7826
		SUPPORT_PLATOON_USED,
		// Token: 0x04001E93 RID: 7827
		MISSION_EVENT_TAB_CLEAR,
		// Token: 0x04001E94 RID: 7828
		MENTORING_MISSION_CLEARED,
		// Token: 0x04001E95 RID: 7829
		GUILD_DONATE,
		// Token: 0x04001E96 RID: 7830
		GUILD_ATTENDANCE,
		// Token: 0x04001E97 RID: 7831
		FIERCE_RANK_TOP,
		// Token: 0x04001E98 RID: 7832
		EC_SUPPLY_CLEAR,
		// Token: 0x04001E99 RID: 7833
		DONATE_MISSION_ITEM,
		// Token: 0x04001E9A RID: 7834
		UNIT_GROWTH_GET,
		// Token: 0x04001E9B RID: 7835
		UNIT_GROWTH_LEVEL,
		// Token: 0x04001E9C RID: 7836
		UNIT_GROWTH_LIMIT,
		// Token: 0x04001E9D RID: 7837
		UNIT_GROWTH_SKILL_LEVEL_3,
		// Token: 0x04001E9E RID: 7838
		UNIT_GROWTH_SKILL_LEVEL_MAX,
		// Token: 0x04001E9F RID: 7839
		UNIT_GROWTH_LOYALTY,
		// Token: 0x04001EA0 RID: 7840
		UNIT_GROWTH_PERMANENT,
		// Token: 0x04001EA1 RID: 7841
		UNIT_GROWTH_TACTICAL,
		// Token: 0x04001EA2 RID: 7842
		UNIT_USE_CLEAR_DUNGEON,
		// Token: 0x04001EA3 RID: 7843
		UNIT_USE_CLEAR_DAILY,
		// Token: 0x04001EA4 RID: 7844
		UNIT_USE_CLEAR_SUPPLY,
		// Token: 0x04001EA5 RID: 7845
		UNIT_USE_CLEAR_PHASE,
		// Token: 0x04001EA6 RID: 7846
		UNIT_USE_PLAY_PVP_ASYNC,
		// Token: 0x04001EA7 RID: 7847
		UNIT_USE_PLAY_PVP_RANK,
		// Token: 0x04001EA8 RID: 7848
		UNIT_USE_GO,
		// Token: 0x04001EA9 RID: 7849
		UNIT_USE_TIMEATK_SUCCESS,
		// Token: 0x04001EAA RID: 7850
		UNIT_USE_GO_SUCCESS,
		// Token: 0x04001EAB RID: 7851
		UNIT_USE_LIFE_SUCCESS,
		// Token: 0x04001EAC RID: 7852
		UNIT_USE_LOBBY,
		// Token: 0x04001EAD RID: 7853
		UNIT_USE_WORLDMAP,
		// Token: 0x04001EAE RID: 7854
		UNIT_USE_GO_UNIT_ID,
		// Token: 0x04001EAF RID: 7855
		LOGIN_TIMES,
		// Token: 0x04001EB0 RID: 7856
		RAID_HELP_PUSH,
		// Token: 0x04001EB1 RID: 7857
		RAID_FIND_LEVEL_HIGH,
		// Token: 0x04001EB2 RID: 7858
		RAID_PLAY_LEVEL_HIGH,
		// Token: 0x04001EB3 RID: 7859
		RAID_REWARD_FRIEND,
		// Token: 0x04001EB4 RID: 7860
		RAID_STAGE_CLEARED,
		// Token: 0x04001EB5 RID: 7861
		RAID_CLEAR_MVP,
		// Token: 0x04001EB6 RID: 7862
		RAID_ASSIST_COUNT,
		// Token: 0x04001EB7 RID: 7863
		WORLDMAP_REWARD_SUCCESS,
		// Token: 0x04001EB8 RID: 7864
		COLLECT_EQUIP_TIER,
		// Token: 0x04001EB9 RID: 7865
		PVP_PLAY_LEAGUE,
		// Token: 0x04001EBA RID: 7866
		COLLECT_ITEM_INTERIOR,
		// Token: 0x04001EBB RID: 7867
		COLLECT_OFFICE_ROOM,
		// Token: 0x04001EBC RID: 7868
		GET_OFFICE_HEART,
		// Token: 0x04001EBD RID: 7869
		GIVE_NAME_CARD,
		// Token: 0x04001EBE RID: 7870
		GIVE_NAME_CARD_ALL,
		// Token: 0x04001EBF RID: 7871
		TRY_EXTRACT_UNIT,
		// Token: 0x04001EC0 RID: 7872
		USE_ETERNIUM,
		// Token: 0x04001EC1 RID: 7873
		PVP_NPC_CLEAR_ASYNC,
		// Token: 0x04001EC2 RID: 7874
		PVP_NPC_PLAY_ASYNC,
		// Token: 0x04001EC3 RID: 7875
		PVP_NPC_CLEAR,
		// Token: 0x04001EC4 RID: 7876
		PVP_NPC_PLAY,
		// Token: 0x04001EC5 RID: 7877
		UNIT_POWER_HIGHEST,
		// Token: 0x04001EC6 RID: 7878
		DUNGEON_SQUAD_UNIT_POWER_HIGHEST,
		// Token: 0x04001EC7 RID: 7879
		WARFARE_SQUAD_UNIT_POWER_HIGHEST,
		// Token: 0x04001EC8 RID: 7880
		EVENT_COLLECT_UNIT_COLLECT,
		// Token: 0x04001EC9 RID: 7881
		EVENT_COLLECT_UNIT_COUNT,
		// Token: 0x04001ECA RID: 7882
		PVP_TOTAL_CLEAR_BOTH,
		// Token: 0x04001ECB RID: 7883
		PVP_TOTAL_CLEAR_ASYNC,
		// Token: 0x04001ECC RID: 7884
		PVP_TOTAL_CLEAR_RANK,
		// Token: 0x04001ECD RID: 7885
		PVP_CLEAR_BOTH,
		// Token: 0x04001ECE RID: 7886
		PVP_PLAY_BOTH,
		// Token: 0x04001ECF RID: 7887
		MAKE_COUNT_MOLD,
		// Token: 0x04001ED0 RID: 7888
		COLLECT_UNIT_TACTICS_LEVEL,
		// Token: 0x04001ED1 RID: 7889
		MISSION_CLEAR,
		// Token: 0x04001ED2 RID: 7890
		PVP_ALLVICTORIES_RANK,
		// Token: 0x04001ED3 RID: 7891
		PVP_ALLVICTORIES_ASYNC,
		// Token: 0x04001ED4 RID: 7892
		RAID_STAGE_MVP_CLEARED,
		// Token: 0x04001ED5 RID: 7893
		TRIM_DUNGEON_CLEARED,
		// Token: 0x04001ED6 RID: 7894
		SHOP_BOUGHT,
		// Token: 0x04001ED7 RID: 7895
		GET_SKIN,
		// Token: 0x04001ED8 RID: 7896
		PALACE_CLEARED,
		// Token: 0x04001ED9 RID: 7897
		UNLOCKED_UNIT_REACTOR,
		// Token: 0x04001EDA RID: 7898
		COLLECT_OPR_LEVEL,
		// Token: 0x04001EDB RID: 7899
		NONE
	}
}
