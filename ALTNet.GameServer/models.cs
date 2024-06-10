using ALTNet.GameServer.Packets;
using Serilog;

namespace ALTNet.GameServer
{
    public enum CountryCode
    {
        // Token: 0x0400BE67 RID: 48743
        KOR,
        // Token: 0x0400BE68 RID: 48744
        TWN,
        // Token: 0x0400BE69 RID: 48745
        CHINA,
        // Token: 0x0400BE6A RID: 48746
        JAPAN
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class CountryDescriptionAttribute : Attribute
    {
        // Token: 0x0600CCD2 RID: 52434 RVA: 0x0008A4D4 File Offset: 0x000886D4
        public CountryDescriptionAttribute(string desc, CountryCode code = CountryCode.KOR)
        {
            this.Description = desc;
            this.CountryCode = code;
        }

        // Token: 0x17001C06 RID: 7174
        // (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x0008A4EA File Offset: 0x000886EA
        public string Description { get; }

        // Token: 0x17001C07 RID: 7175
        // (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x0008A4F2 File Offset: 0x000886F2
        public CountryCode CountryCode { get; }
    }
    public enum NKM_GAME_TYPE : byte
    {
        // Token: 0x04001EE6 RID: 7910
        [CountryDescription("알수없음", CountryCode.KOR)]
        [CountryDescription("沒有內容", CountryCode.TWN)]
        NGT_INVALID,
        // Token: 0x04001EE7 RID: 7911
        [CountryDescription("개발용", CountryCode.KOR)]
        [CountryDescription("研發用", CountryCode.TWN)]
        NGT_DEV,
        // Token: 0x04001EE8 RID: 7912
        [CountryDescription("연습모드", CountryCode.KOR)]
        [CountryDescription("練習模式", CountryCode.TWN)]
        NGT_PRACTICE,
        // Token: 0x04001EE9 RID: 7913
        [CountryDescription("일반던전", CountryCode.KOR)]
        [CountryDescription("一般副本", CountryCode.TWN)]
        NGT_DUNGEON,
        // Token: 0x04001EEA RID: 7914
        [CountryDescription("전역", CountryCode.KOR)]
        [CountryDescription("戰役", CountryCode.TWN)]
        NGT_WARFARE,
        // Token: 0x04001EEB RID: 7915
        [CountryDescription("다이브", CountryCode.KOR)]
        [CountryDescription("躍入", CountryCode.TWN)]
        NGT_DIVE,
        // Token: 0x04001EEC RID: 7916
        [CountryDescription("랭크전", CountryCode.KOR)]
        [CountryDescription("排位賽", CountryCode.TWN)]
        NGT_PVP_RANK,
        // Token: 0x04001EED RID: 7917
        [CountryDescription("튜토리얼", CountryCode.KOR)]
        [CountryDescription("新手教學", CountryCode.TWN)]
        NGT_TUTORIAL,
        // Token: 0x04001EEE RID: 7918
        [CountryDescription("레이드", CountryCode.KOR)]
        [CountryDescription("團體副本", CountryCode.TWN)]
        NGT_RAID,
        // Token: 0x04001EEF RID: 7919
        [CountryDescription("컷신", CountryCode.KOR)]
        [CountryDescription("過場動畫", CountryCode.TWN)]
        NGT_CUTSCENE,
        // Token: 0x04001EF0 RID: 7920
        [CountryDescription("월드맵", CountryCode.KOR)]
        [CountryDescription("世界地圖", CountryCode.TWN)]
        NGT_WORLDMAP,
        // Token: 0x04001EF1 RID: 7921
        [CountryDescription("전략전", CountryCode.KOR)]
        [CountryDescription("戰略對抗戰", CountryCode.TWN)]
        NGT_ASYNC_PVP,
        // Token: 0x04001EF2 RID: 7922
        [CountryDescription("솔로 레이드", CountryCode.KOR)]
        [CountryDescription("單人團體副本", CountryCode.TWN)]
        NGT_RAID_SOLO,
        // Token: 0x04001EF3 RID: 7923
        [CountryDescription("그림자 전당", CountryCode.KOR)]
        [CountryDescription("暗影殿堂", CountryCode.TWN)]
        NGT_SHADOW_PALACE,
        // Token: 0x04001EF4 RID: 7924
        [CountryDescription("격전 지원", CountryCode.KOR)]
        [CountryDescription("激戰支援", CountryCode.TWN)]
        NGT_FIERCE,
        // Token: 0x04001EF5 RID: 7925
        [CountryDescription("페이즈", CountryCode.KOR)]
        [CountryDescription("階段", CountryCode.TWN)]
        NGT_PHASE,
        // Token: 0x04001EF6 RID: 7926
        [CountryDescription("길드 협력전 아레나", CountryCode.KOR)]
        [CountryDescription("(TWN)길드 협력전 아레나", CountryCode.TWN)]
        NGT_GUILD_DUNGEON_ARENA,
        // Token: 0x04001EF7 RID: 7927
        [CountryDescription("길드 협력전 보스", CountryCode.KOR)]
        [CountryDescription("(TWN)길드 협력전 보스", CountryCode.TWN)]
        NGT_GUILD_DUNGEON_BOSS,
        // Token: 0x04001EF8 RID: 7928
        [CountryDescription("친선전", CountryCode.KOR)]
        [CountryDescription("(TWN)친선전", CountryCode.TWN)]
        NGT_PVP_PRIVATE,
        // Token: 0x04001EF9 RID: 7929
        [CountryDescription("리그전", CountryCode.KOR)]
        [CountryDescription("(TWN)리그전", CountryCode.TWN)]
        NGT_PVP_LEAGUE,
        // Token: 0x04001EFA RID: 7930
        [CountryDescription("전략전 개편", CountryCode.KOR)]
        [CountryDescription("(TWN)전략전 개편", CountryCode.TWN)]
        NGT_PVP_STRATEGY,
        // Token: 0x04001EFB RID: 7931
        [CountryDescription("전략전 리벤지", CountryCode.KOR)]
        [CountryDescription("(TWN)전략전 리벤지", CountryCode.TWN)]
        NGT_PVP_STRATEGY_REVENGE,
        // Token: 0x04001EFC RID: 7932
        [CountryDescription("전략전 NPC", CountryCode.KOR)]
        [CountryDescription("(TWN)전략전 NPC", CountryCode.TWN)]
        NGT_PVP_STRATEGY_NPC,
        // Token: 0x04001EFD RID: 7933
        [CountryDescription("디멘션 트리밍", CountryCode.KOR)]
        [CountryDescription("(TWN)디멘션 트리밍", CountryCode.TWN)]
        NGT_TRIM,
        // Token: 0x04001EFE RID: 7934
        [CountryDescription("이벤트전", CountryCode.KOR)]
        [CountryDescription("(TWN)이벤트전", CountryCode.TWN)]
        NGT_PVP_EVENT,
        // Token: 0x04001EFF RID: 7935
        [CountryDescription("길드 협력전 보스 연습전", CountryCode.KOR)]
        [CountryDescription("(TWN)길드 협력전 보스 연습전", CountryCode.TWN)]
        NGT_GUILD_DUNGEON_BOSS_PRACTICE,
        // Token: 0x04001F00 RID: 7936
        [CountryDescription("무한 디펜스 던전", CountryCode.KOR)]
        [CountryDescription("(TWN)무한 디펜스 던전", CountryCode.TWN)]
        NGT_PVE_DEFENCE,
        // Token: 0x04001F01 RID: 7937
        [CountryDescription("시뮬레이션 게임", CountryCode.KOR)]
        [CountryDescription("(TWN)시뮬레이션 게임", CountryCode.TWN)]
        NGT_PVE_SIMULATED
    }
    public enum NKM_STAT_TYPE : short
    {
        // Token: 0x040027F6 RID: 10230
        [CountryDescription("없음", CountryCode.KOR)]
        NST_RANDOM = -1,
        // Token: 0x040027F7 RID: 10231
        [CountryDescription("체력", CountryCode.KOR)]
        NST_HP,
        // Token: 0x040027F8 RID: 10232
        [CountryDescription("공격력", CountryCode.KOR)]
        NST_ATK,
        // Token: 0x040027F9 RID: 10233
        [CountryDescription("방어력", CountryCode.KOR)]
        NST_DEF,
        // Token: 0x040027FA RID: 10234
        [CountryDescription("치명타율", CountryCode.KOR)]
        NST_CRITICAL,
        // Token: 0x040027FB RID: 10235
        [CountryDescription("명중율", CountryCode.KOR)]
        NST_HIT,
        // Token: 0x040027FC RID: 10236
        [CountryDescription("회피율", CountryCode.KOR)]
        NST_EVADE,
        // Token: 0x040027FD RID: 10237
        [CountryDescription("체력 회복율", CountryCode.KOR)]
        NST_HP_REGEN_RATE,
        // Token: 0x040027FE RID: 10238
        [CountryDescription("치명타 피해 증가율", CountryCode.KOR)]
        NST_CRITICAL_DAMAGE_RATE,
        // Token: 0x040027FF RID: 10239
        [CountryDescription("치명타 저항율", CountryCode.KOR)]
        NST_CRITICAL_RESIST,
        // Token: 0x04002800 RID: 10240
        [CountryDescription("치명타 피해 증가 저항율", CountryCode.KOR)]
        NST_CRITICAL_DAMAGE_RESIST_RATE,
        // Token: 0x04002801 RID: 10241
        [CountryDescription("피해 감소율", CountryCode.KOR)]
        NST_DAMAGE_REDUCE_RATE,
        // Token: 0x04002802 RID: 10242
        [CountryDescription("이동속도 증가율", CountryCode.KOR)]
        NST_MOVE_SPEED_RATE,
        // Token: 0x04002803 RID: 10243
        [CountryDescription("공격속도 증가율", CountryCode.KOR)]
        NST_ATTACK_SPEED_RATE,
        // Token: 0x04002804 RID: 10244
        [CountryDescription("스킬 쿨타임 감소율", CountryCode.KOR)]
        NST_SKILL_COOL_TIME_REDUCE_RATE,
        // Token: 0x04002805 RID: 10245
        [CountryDescription("상태이상 저항율", CountryCode.KOR)]
        NST_CC_RESIST_RATE,
        // Token: 0x04002806 RID: 10246
        [CountryDescription("vs카운터에게 주는 피해 증가", CountryCode.KOR)]
        NST_UNIT_TYPE_COUNTER_DAMAGE_RATE,
        // Token: 0x04002807 RID: 10247
        [CountryDescription("vs카운터에게 받는 피해 감소", CountryCode.KOR)]
        NST_UNIT_TYPE_COUNTER_DAMAGE_REDUCE_RATE,
        // Token: 0x04002808 RID: 10248
        [CountryDescription("vs솔저에게 주는 피해 증가", CountryCode.KOR)]
        NST_UNIT_TYPE_SOLDIER_DAMAGE_RATE,
        // Token: 0x04002809 RID: 10249
        [CountryDescription("vs솔저에게 받는 피해 감소", CountryCode.KOR)]
        NST_UNIT_TYPE_SOLDIER_DAMAGE_REDUCE_RATE,
        // Token: 0x0400280A RID: 10250
        [CountryDescription("vs메카닉에게 주는 피해 증가", CountryCode.KOR)]
        NST_UNIT_TYPE_MECHANIC_DAMAGE_RATE,
        // Token: 0x0400280B RID: 10251
        [CountryDescription("vs메카닉에게 받는 피해 감소", CountryCode.KOR)]
        NST_UNIT_TYPE_MECHANIC_DAMAGE_REDUCE_RATE,
        // Token: 0x0400280C RID: 10252
        [CountryDescription("vs스트라이커에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_STRIKER_DAMAGE_RATE,
        // Token: 0x0400280D RID: 10253
        [CountryDescription("vs스트라이커에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_STRIKER_DAMAGE_REDUCE_RATE,
        // Token: 0x0400280E RID: 10254
        [CountryDescription("vs레인저에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_RANGER_DAMAGE_RATE,
        // Token: 0x0400280F RID: 10255
        [CountryDescription("vs레인저에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_RANGER_DAMAGE_REDUCE_RATE,
        // Token: 0x04002810 RID: 10256
        [CountryDescription("vs스나이퍼에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_SNIPER_DAMAGE_RATE,
        // Token: 0x04002811 RID: 10257
        [CountryDescription("vs스나이퍼에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_SNIPER_DAMAGE_REDUCE_RATE,
        // Token: 0x04002812 RID: 10258
        [CountryDescription("vs디펜더에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_DEFFENDER_DAMAGE_RATE,
        // Token: 0x04002813 RID: 10259
        [CountryDescription("vs디펜더에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_DEFFENDER_DAMAGE_REDUCE_RATE,
        // Token: 0x04002814 RID: 10260
        [CountryDescription("vs서포터에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_SUPPOERTER_DAMAGE_RATE,
        // Token: 0x04002815 RID: 10261
        [CountryDescription("vs서포터에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_SUPPOERTER_DAMAGE_REDUCE_RATE,
        // Token: 0x04002816 RID: 10262
        [CountryDescription("vs시즈에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_SIEGE_DAMAGE_RATE,
        // Token: 0x04002817 RID: 10263
        [CountryDescription("vs시즈에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_SIEGE_DAMAGE_REDUCE_RATE,
        // Token: 0x04002818 RID: 10264
        [CountryDescription("vs타워에게 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_TOWER_DAMAGE_RATE,
        // Token: 0x04002819 RID: 10265
        [CountryDescription("vs타워에게 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_TOWER_DAMAGE_REDUCE_RATE,
        // Token: 0x0400281A RID: 10266
        [CountryDescription("vs지상유닛에게 주는 피해 증가", CountryCode.KOR)]
        NST_MOVE_TYPE_LAND_DAMAGE_RATE,
        // Token: 0x0400281B RID: 10267
        [CountryDescription("vs지상유닛에게 받는 피해 감소", CountryCode.KOR)]
        NST_MOVE_TYPE_LAND_DAMAGE_REDUCE_RATE,
        // Token: 0x0400281C RID: 10268
        [CountryDescription("vs공중유닛에게 주는 피해 증가", CountryCode.KOR)]
        NST_MOVE_TYPE_AIR_DAMAGE_RATE,
        // Token: 0x0400281D RID: 10269
        [CountryDescription("vs공중유닛에게 받는 피해 감소", CountryCode.KOR)]
        NST_MOVE_TYPE_AIR_DAMAGE_REDUCE_RATE,
        // Token: 0x0400281E RID: 10270
        [CountryDescription("장거리 공격으로 받는 피해 감소", CountryCode.KOR)]
        NST_LONG_RANGE_DAMAGE_REDUCE_RATE,
        // Token: 0x0400281F RID: 10271
        [CountryDescription("장거리 공격으로 주는 피해 추가", CountryCode.KOR)]
        NST_LONG_RANGE_DAMAGE_RATE,
        // Token: 0x04002820 RID: 10272
        [CountryDescription("단거리 공격으로 받는 피해 감소", CountryCode.KOR)]
        NST_SHORT_RANGE_DAMAGE_REDUCE_RATE,
        // Token: 0x04002821 RID: 10273
        [CountryDescription("단거리 공격으로 주는 피해 추가", CountryCode.KOR)]
        NST_SHORT_RANGE_DAMAGE_RATE,
        // Token: 0x04002822 RID: 10274
        [CountryDescription("힐 감소율", CountryCode.KOR)]
        NST_HEAL_REDUCE_RATE,
        // Token: 0x04002823 RID: 10275
        [CountryDescription("방어 관통율", CountryCode.KOR)]
        NST_DEF_PENETRATE_RATE,
        // Token: 0x04002824 RID: 10276
        [CountryDescription("방어막 강화율", CountryCode.KOR)]
        NST_BARRIER_REINFORCE_RATE,
        // Token: 0x04002825 RID: 10277
        [CountryDescription("스킬 데미지 강화율", CountryCode.KOR)]
        NST_SKILL_DAMAGE_RATE,
        // Token: 0x04002826 RID: 10278
        [CountryDescription("스킬 데미지 감소율", CountryCode.KOR)]
        NST_SKILL_DAMAGE_REDUCE_RATE,
        // Token: 0x04002827 RID: 10279
        [CountryDescription("궁극기 데미지 강화율", CountryCode.KOR)]
        NST_HYPER_SKILL_DAMAGE_RATE,
        // Token: 0x04002828 RID: 10280
        [CountryDescription("궁극기 데미지 감소율", CountryCode.KOR)]
        NST_HYPER_SKILL_DAMAGE_REDUCE_RATE,
        // Token: 0x04002829 RID: 10281
        [CountryDescription("침식체에게 주는 피해 증가", CountryCode.KOR)]
        NST_UNIT_TYPE_CORRUPTED_DAMAGE_RATE,
        // Token: 0x0400282A RID: 10282
        [CountryDescription("침식체에게 받는 피해 감소", CountryCode.KOR)]
        NST_UNIT_TYPE_CORRUPTED_DAMAGE_REDUCE_RATE,
        // Token: 0x0400282B RID: 10283
        [CountryDescription("리플레이서에게 주는 피해 증가", CountryCode.KOR)]
        NST_UNIT_TYPE_REPLACER_DAMAGE_RATE,
        // Token: 0x0400282C RID: 10284
        [CountryDescription("리플레이서에게 받는 피해 감소", CountryCode.KOR)]
        NST_UNIT_TYPE_REPLACER_DAMAGE_REDUCE_RATE,
        // Token: 0x0400282D RID: 10285
        [CountryDescription("상성으로 주는 피해 증가", CountryCode.KOR)]
        NST_ROLE_TYPE_DAMAGE_RATE,
        // Token: 0x0400282E RID: 10286
        [CountryDescription("상성으로 받는 피해 감소", CountryCode.KOR)]
        NST_ROLE_TYPE_DAMAGE_REDUCE_RATE,
        // Token: 0x0400282F RID: 10287
        [CountryDescription("성장형 공격력 증가율", CountryCode.KOR)]
        NST_HP_GROWN_ATK_RATE,
        // Token: 0x04002830 RID: 10288
        [CountryDescription("성장형 방어력 증가율", CountryCode.KOR)]
        NST_HP_GROWN_DEF_RATE,
        // Token: 0x04002831 RID: 10289
        [CountryDescription("성장형 회피 증가율", CountryCode.KOR)]
        NST_HP_GROWN_EVADE_RATE,
        // Token: 0x04002832 RID: 10290
        [CountryDescription("광역 피해 감소율", CountryCode.KOR)]
        NST_SPLASH_DAMAGE_REDUCE_RATE,
        // Token: 0x04002833 RID: 10291
        [CountryDescription("디펜더 프로텍트 증가", CountryCode.KOR)]
        NST_DEFENDER_PROTECT_RATE,
        // Token: 0x04002834 RID: 10292
        [CountryDescription("추가 피해 감소율", CountryCode.KOR)]
        NST_DAMAGE_INCREASE_DEFENCE,
        // Token: 0x04002835 RID: 10293
        [CountryDescription("피해 감소 관통율", CountryCode.KOR)]
        NST_DAMAGE_REDUCE_PENETRATE,
        // Token: 0x04002836 RID: 10294
        [CountryDescription("자기 추가 피해 감소율", CountryCode.KOR)]
        NST_DAMAGE_INCREASE_REDUCE,
        // Token: 0x04002837 RID: 10295
        [CountryDescription("자기 피해 감소 관통율", CountryCode.KOR)]
        NST_DAMAGE_REDUCE_REDUCE,
        // Token: 0x04002838 RID: 10296
        [CountryDescription("최대 피해 제한", CountryCode.KOR)]
        NST_DAMAGE_LIMIT_RATE_BY_HP,
        // Token: 0x04002839 RID: 10297
        [CountryDescription("유효 타격 감소", CountryCode.KOR)]
        NST_ATTACK_COUNT_REDUCE,
        // Token: 0x0400283A RID: 10298
        [CountryDescription("피해 내성", CountryCode.KOR)]
        NST_DAMAGE_RESIST,
        // Token: 0x0400283B RID: 10299
        [CountryDescription("배리어가 있는 적에게 공격 피해 감소", CountryCode.KOR)]
        NST_DAMAGE_REDUCE_RATE_AGAINST_BARRIER,
        // Token: 0x0400283C RID: 10300
        [CountryDescription("크리가 아닌 공격 데미지 비율", CountryCode.KOR)]
        NST_NON_CRITICAL_DAMAGE_TAKE_RATE,
        // Token: 0x0400283D RID: 10301
        [CountryDescription("주는 회복량 증가", CountryCode.KOR)]
        NST_HEAL_RATE,
        // Token: 0x0400283E RID: 10302
        [CountryDescription("넉백 저항", CountryCode.KOR)]
        NST_DAMAGE_BACK_RESIST,
        // Token: 0x0400283F RID: 10303
        [CountryDescription("전체 능력치 증가/감소", CountryCode.KOR)]
        NST_MAIN_STAT_RATE,
        // Token: 0x04002840 RID: 10304
        [CountryDescription("주는 피해 증감_Extra", CountryCode.KOR)]
        NST_EXTRA_ADJUST_DAMAGE_DEALT,
        // Token: 0x04002841 RID: 10305
        [CountryDescription("받는 피해 증감_Extra", CountryCode.KOR)]
        NST_EXTRA_ADJUST_DAMAGE_RECEIVE,
        // Token: 0x04002842 RID: 10306
        [CountryDescription("주는 피해 증감", CountryCode.KOR)]
        NST_ATTACK_DAMAGE_MODIFY_G2,
        // Token: 0x04002843 RID: 10307
        [CountryDescription("코스트 반환", CountryCode.KOR)]
        NST_COST_RETURN_RATE,
        // Token: 0x04002844 RID: 10308
        [CountryDescription("보스에게 주는 피해", CountryCode.KOR)]
        NST_ATTACK_VS_BOSS_DAMAGE_MODIFY_G1 = 1000,
        // Token: 0x04002845 RID: 10309
        [CountryDescription("보스에게 받는 피해 감소", CountryCode.KOR)]
        NST_DEFEND_VS_BOSS_DAMAGE_MODIFY_G1,
        // Token: 0x04002846 RID: 10310
        [CountryDescription("공격자 기본기 피해 증폭/감쇄", CountryCode.KOR)]
        NST_ATTACK_ATTACK_DAMAGE_MODIFY_G2 = 2000,
        // Token: 0x04002847 RID: 10311
        [CountryDescription("방어자 기본기 피해 증폭/감쇄", CountryCode.KOR)]
        NST_DEFEND_ATTACK_DAMAGE_MODIFY_G2,
        // Token: 0x04002848 RID: 10312
        [CountryDescription("투쟁 몬스터에게 주는 피해 증가", CountryCode.KOR)]
        NST_ATTACK_VS_SOURCE_CONFLICT_G4 = 4000,
        // Token: 0x04002849 RID: 10313
        [CountryDescription("투쟁 몬스터에게 받는 피해 감소", CountryCode.KOR)]
        NST_DEFEND_VS_SOURCE_CONFLICT_G4,
        // Token: 0x0400284A RID: 10314
        [CountryDescription("안정 몬스터에게 주는 피해 증가", CountryCode.KOR)]
        NST_ATTACK_VS_SOURCE_STABLE_G4,
        // Token: 0x0400284B RID: 10315
        [CountryDescription("안정 몬스터에게 받는 피해 감소", CountryCode.KOR)]
        NST_DEFEND_VS_SOURCE_STABLE_G4,
        // Token: 0x0400284C RID: 10316
        [CountryDescription("변화 몬스터에게 주는 피해 증가", CountryCode.KOR)]
        NST_ATTACK_VS_SOURCE_LIBERAL_G4,
        // Token: 0x0400284D RID: 10317
        [CountryDescription("변화 몬스터에게 받는 피해 감소", CountryCode.KOR)]
        NST_DEFEND_VS_SOURCE_LIBERAL_G4,
        // Token: 0x0400284E RID: 10318
        [CountryDescription("감응으로 인한 효과 증폭(곱연산)", CountryCode.KOR)]
        NST_SOURCE_ALL_RATE_G4 = 4100,
        // Token: 0x0400284F RID: 10319
        [CountryDescription("체력%", CountryCode.KOR)]
        NST_HP_FACTOR = 10000,
        // Token: 0x04002850 RID: 10320
        [CountryDescription("공격력%", CountryCode.KOR)]
        NST_ATK_FACTOR,
        // Token: 0x04002851 RID: 10321
        [CountryDescription("방어력%", CountryCode.KOR)]
        NST_DEF_FACTOR,
        // Token: 0x04002852 RID: 10322
        [CountryDescription("치명타율%", CountryCode.KOR)]
        NST_CRITICAL_FACTOR,
        // Token: 0x04002853 RID: 10323
        [CountryDescription("명중율%", CountryCode.KOR)]
        NST_HIT_FACTOR,
        // Token: 0x04002854 RID: 10324
        [CountryDescription("회피율%", CountryCode.KOR)]
        NST_EVADE_FACTOR,
        // Token: 0x04002855 RID: 10325
        NST_RESERVE01 = 30000,
        // Token: 0x04002856 RID: 10326
        NST_RESERVE02,
        // Token: 0x04002857 RID: 10327
        NST_RESERVE03,
        // Token: 0x04002858 RID: 10328
        NST_RESERVE04,
        // Token: 0x04002859 RID: 10329
        NST_RESERVE05,
        // Token: 0x0400285A RID: 10330
        NST_END
    }

    public class NKMGameStatRate
    {
        // Token: 0x06002652 RID: 9810 RVA: 0x0012343C File Offset: 0x0012163C
        public float GetStatValueRate(NKM_STAT_TYPE eStat)
        {
            switch (eStat)
            {
                case NKM_STAT_TYPE.NST_HP:
                    return this.m_HPRate;
                case NKM_STAT_TYPE.NST_ATK:
                    return this.m_ATKRate;
                case NKM_STAT_TYPE.NST_DEF:
                    return this.m_DEFRate;
                case NKM_STAT_TYPE.NST_CRITICAL:
                    return this.m_CRITRate;
                case NKM_STAT_TYPE.NST_HIT:
                    return this.m_HITRate;
                case NKM_STAT_TYPE.NST_EVADE:
                    return this.m_EvadeRate;
                default:
                    return this.m_SubStatValueRate;
            }
        }

        // Token: 0x04002895 RID: 10389
        public float m_MainStatFactorRate = 1f;

        // Token: 0x04002896 RID: 10390
        public float m_SubStatValueRate = 1f;

        // Token: 0x04002897 RID: 10391
        public float m_EquipStatRate = 1f;

        // Token: 0x04002898 RID: 10392
        public float m_HPRate = 1f;

        // Token: 0x04002899 RID: 10393
        public float m_ATKRate = 1f;

        // Token: 0x0400289A RID: 10394
        public float m_DEFRate = 1f;

        // Token: 0x0400289B RID: 10395
        public float m_CRITRate = 1f;

        // Token: 0x0400289C RID: 10396
        public float m_HITRate = 1f;

        // Token: 0x0400289D RID: 10397
        public float m_EvadeRate = 1f;
    }
    public enum NKM_TEAM_TYPE : byte
    {
        // Token: 0x04002722 RID: 10018
        NTT_INVALID,
        // Token: 0x04002723 RID: 10019
        NTT_A1,
        // Token: 0x04002724 RID: 10020
        NTT_A2,
        // Token: 0x04002725 RID: 10021
        NTT_B1,
        // Token: 0x04002726 RID: 10022
        NTT_B2,
        // Token: 0x04002727 RID: 10023
        NTT_C,
        // Token: 0x04002728 RID: 10024
        NTT_DRAW
    }

    //public class NKMGameTeamData : ISerializable
    //{
    //    // Token: 0x04001F74 RID: 8052
    //    public NKM_TEAM_TYPE m_eNKM_TEAM_TYPE;

    //    // Token: 0x04001F75 RID: 8053
    //    public long m_LeaderUnitUID;

    //    // Token: 0x04001F76 RID: 8054
    //    public int m_UserLevel;

    //    // Token: 0x04001F77 RID: 8055
    //    public string m_UserNickname;

    //    // Token: 0x04001F78 RID: 8056
    //    public int m_Tier;

    //    // Token: 0x04001F79 RID: 8057
    //    public int m_Score;

    //    // Token: 0x04001F7A RID: 8058
    //    public int m_WinStreak;

    //    // Token: 0x04001F7B RID: 8059
    //    public long m_FriendCode;

    //    // Token: 0x04001F7C RID: 8060
    //    public NKMCommonProfile m_userCommonProfile = new NKMCommonProfile();

    //    // Token: 0x04001F7D RID: 8061
    //    public NKMGuildSimpleData guildSimpleData = new NKMGuildSimpleData();

    //    // Token: 0x04001F7E RID: 8062
    //    public NKMUnitData m_MainShip;

    //    // Token: 0x04001F7F RID: 8063
    //    public NKMOperator m_Operator;

    //    // Token: 0x04001F80 RID: 8064
    //    public long m_user_uid;

    //    // Token: 0x04001F81 RID: 8065
    //    public List<NKMUnitData> m_listUnitData = new List<NKMUnitData>();

    //    // Token: 0x04001F82 RID: 8066
    //    public List<NKMUnitData> m_listAssistUnitData = new List<NKMUnitData>();

    //    // Token: 0x04001F83 RID: 8067
    //    public List<NKMUnitData> m_listEvevtUnitData = new List<NKMUnitData>();

    //    // Token: 0x04001F84 RID: 8068
    //    public List<NKMUnitData> m_listEnvUnitData = new List<NKMUnitData>();

    //    // Token: 0x04001F85 RID: 8069
    //    public List<NKMDynamicRespawnUnitData> m_listDynamicRespawnUnitData = new List<NKMDynamicRespawnUnitData>();

    //    // Token: 0x04001F86 RID: 8070
    //    public List<NKMTacticalCommandData> m_listTacticalCommandData = new List<NKMTacticalCommandData>();

    //    // Token: 0x04001F87 RID: 8071
    //    public NKMGameTeamDeckData m_DeckData = new NKMGameTeamDeckData();

    //    // Token: 0x04001F88 RID: 8072
    //    public float m_fInitHP;

    //    // Token: 0x04001F89 RID: 8073
    //    public Dictionary<long, NKMEquipItemData> m_ItemEquipData = new Dictionary<long, NKMEquipItemData>();

    //    // Token: 0x04001F8A RID: 8074
    //    public EmoticonPresetData m_emoticonPreset = new EmoticonPresetData();

    //    // Token: 0x06001E44 RID: 7748 RVA: 0x000EED94 File Offset: 0x000ECF94
    //    public void Init()
    //    {
    //        this.m_eNKM_TEAM_TYPE = NKM_TEAM_TYPE.NTT_INVALID;
    //        this.m_LeaderUnitUID = 0L;
    //        this.m_UserLevel = 0;
    //        this.m_UserNickname = "";
    //        this.m_Tier = 0;
    //        this.m_Score = 0;
    //        this.m_MainShip = null;
    //        this.m_user_uid = 0L;
    //        this.m_listUnitData.Clear();
    //        this.m_listAssistUnitData.Clear();
    //        this.m_listEvevtUnitData.Clear();
    //        this.m_listDynamicRespawnUnitData.Clear();
    //        this.m_DeckData.Init();
    //        this.m_fInitHP = 0f;
    //    }

    //    // Token: 0x06001E45 RID: 7749 RVA: 0x000EEE24 File Offset: 0x000ED024
    //    public virtual void Serialize(IPacketStream stream)
    //    {
    //        stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.m_eNKM_TEAM_TYPE);
    //        stream.PutOrGet(ref this.m_LeaderUnitUID);
    //        stream.PutOrGet(ref this.m_UserLevel);
    //        stream.PutOrGet(ref this.m_UserNickname);
    //        stream.PutOrGet(ref this.m_Tier);
    //        stream.PutOrGet(ref this.m_Score);
    //        stream.PutOrGet(ref this.m_WinStreak);
    //        stream.PutOrGet<NKMUnitData>(ref this.m_MainShip);
    //        stream.PutOrGet<NKMOperator>(ref this.m_Operator);
    //        stream.PutOrGet(ref this.m_user_uid);
    //        stream.PutOrGet<NKMUnitData>(ref this.m_listUnitData);
    //        stream.PutOrGet<NKMUnitData>(ref this.m_listAssistUnitData);
    //        stream.PutOrGet<NKMUnitData>(ref this.m_listEvevtUnitData);
    //        stream.PutOrGet<NKMUnitData>(ref this.m_listEnvUnitData);
    //        stream.PutOrGet<NKMDynamicRespawnUnitData>(ref this.m_listDynamicRespawnUnitData);
    //        stream.PutOrGet<NKMTacticalCommandData>(ref this.m_listTacticalCommandData);
    //        stream.PutOrGet<NKMGameTeamDeckData>(ref this.m_DeckData);
    //        stream.PutOrGet(ref this.m_fInitHP);
    //        stream.PutOrGet<NKMEquipItemData>(ref this.m_ItemEquipData);
    //        stream.PutOrGet(ref this.m_FriendCode);
    //        stream.PutOrGet<EmoticonPresetData>(ref this.m_emoticonPreset);
    //        stream.PutOrGet<NKMGuildSimpleData>(ref this.guildSimpleData);
    //        stream.PutOrGet<NKMCommonProfile>(ref this.m_userCommonProfile);
    //    }
    
    //}

    //    public sealed class NKMGameData : ISerializable
    //{
    //    // Token: 0x06001E63 RID: 7779 RVA: 0x000EF628 File Offset: 0x000ED828
    //    public NKMGameData()
    //    {
    //        this.m_NKMGameTeamDataA.Init();
    //        this.m_NKMGameTeamDataB.Init();
    //        this.m_NKMGameTeamDataA.m_eNKM_TEAM_TYPE = NKM_TEAM_TYPE.NTT_A1;
    //        this.m_NKMGameTeamDataB.m_eNKM_TEAM_TYPE = NKM_TEAM_TYPE.NTT_B1;
    //    }

    //    // Token: 0x06001E64 RID: 7780 RVA: 0x000EF6E4 File Offset: 0x000ED8E4
    //    public void Serialize(IPacketStream stream)
    //    {
    //        stream.PutOrGet(ref this.m_GameUID);
    //        stream.PutOrGet(ref this.m_GameUnitUIDIndex);
    //        stream.PutOrGet(ref this.m_bLocal);
    //        stream.PutOrGetEnum<NKM_GAME_TYPE>(ref this.m_NKM_GAME_TYPE);
    //        stream.PutOrGet(ref this.m_DungeonID);
    //        stream.PutOrGet(ref this.m_bBossDungeon);
    //        stream.PutOrGet(ref this.m_WarfareID);
    //        stream.PutOrGet(ref this.m_RaidUID);
    //        stream.PutOrGet(ref this.m_fRespawnCostMinusPercentForTeamA);
    //        stream.PutOrGet(ref this.m_TeamASupply);
    //        stream.PutOrGet(ref this.m_fTeamAAttackPowerIncRateForWarfare);
    //        stream.PutOrGet(ref this.m_lstTeamABuffStrIDListForRaid);
    //        stream.PutOrGet(ref this.fExtraRespawnCostAddForA);
    //        stream.PutOrGet(ref this.fExtraRespawnCostAddForB);
    //        stream.PutOrGet(ref this.m_TeamBLevelAdd);
    //        stream.PutOrGet(ref this.m_TeamBLevelFix);
    //        stream.PutOrGet(ref this.m_fDoubleCostTime);
    //        stream.PutOrGet(ref this.m_MapID);
    //        stream.PutOrGet(ref this.m_BattleConditionIDs);
    //        stream.PutOrGet<NKMGameTeamData>(ref this.m_NKMGameTeamDataA);
    //        stream.PutOrGet<NKMGameTeamData>(ref this.m_NKMGameTeamDataB);
    //        stream.PutOrGet(ref this.m_listUnitDeckTemp);
    //        stream.PutOrGet(ref this.m_replay);
    //        stream.PutOrGet<NKMBanData>(ref this.m_dicNKMBanData);
    //        stream.PutOrGet<NKMBanShipData>(ref this.m_dicNKMBanShipData);
    //        stream.PutOrGet<NKMBanOperatorData>(ref this.m_dicNKMBanOperatorData);
    //        stream.PutOrGet<NKMUnitUpData>(ref this.m_dicNKMUpData);
    //        stream.PutOrGet(ref this.m_NKMGameStatRateID);
    //        stream.PutOrGet(ref this.m_bForcedAuto);
    //    }

    //    public long m_GameUID;

    //    // Token: 0x04001FBD RID: 8125
    //    public short m_GameUnitUIDIndex;

    //    // Token: 0x04001FBE RID: 8126
    //    public bool m_bLocal;

    //    // Token: 0x04001FBF RID: 8127
    //    public NKM_GAME_TYPE m_NKM_GAME_TYPE;

    //    // Token: 0x04001FC0 RID: 8128
    //    public int m_DungeonID;

    //    // Token: 0x04001FC1 RID: 8129
    //    public bool m_bBossDungeon;

    //    // Token: 0x04001FC2 RID: 8130
    //    public int m_WarfareID;

    //    // Token: 0x04001FC3 RID: 8131
    //    public long m_RaidUID;

    //    // Token: 0x04001FC4 RID: 8132
    //    public float m_fRespawnCostMinusPercentForTeamA;

    //    // Token: 0x04001FC5 RID: 8133
    //    public int m_TeamASupply;

    //    // Token: 0x04001FC6 RID: 8134
    //    public float m_fTeamAAttackPowerIncRateForWarfare;

    //    // Token: 0x04001FC7 RID: 8135
    //    public List<string> m_lstTeamABuffStrIDListForRaid = new List<string>();

    //    // Token: 0x04001FC8 RID: 8136
    //    public float fExtraRespawnCostAddForA;

    //    // Token: 0x04001FC9 RID: 8137
    //    public float fExtraRespawnCostAddForB;

    //    // Token: 0x04001FCA RID: 8138
    //    public int m_TeamBLevelAdd;

    //    // Token: 0x04001FCB RID: 8139
    //    public int m_TeamBLevelFix;

    //    // Token: 0x04001FCC RID: 8140
    //    public List<string> m_BanUnitBuffStrIDs = new List<string>();

    //    // Token: 0x04001FCD RID: 8141
    //    public bool m_bForcedAuto;

    //    // Token: 0x04001FCE RID: 8142
    //    public float m_fDoubleCostTime = 60f;

    //    // Token: 0x04001FCF RID: 8143
    //    public int m_MapID;

    //    // Token: 0x04001FD0 RID: 8144
    //    public Dictionary<int, int> m_BattleConditionIDs = new Dictionary<int, int>();

    //    // Token: 0x04001FD1 RID: 8145
    //    public NKMGameTeamData m_NKMGameTeamDataA = new NKMGameTeamData();

    //    // Token: 0x04001FD2 RID: 8146
    //    public NKMGameTeamData m_NKMGameTeamDataB = new NKMGameTeamData();

    //    // Token: 0x04001FD3 RID: 8147
    //    private List<long> m_listUnitDeckTemp = new List<long>();

    //    // Token: 0x04001FD4 RID: 8148
    //    public bool m_replay;

    //    // Token: 0x04001FD5 RID: 8149
    //    public Dictionary<int, NKMBanData> m_dicNKMBanData = new Dictionary<int, NKMBanData>();

    //    // Token: 0x04001FD6 RID: 8150
    //    public Dictionary<int, NKMBanShipData> m_dicNKMBanShipData = new Dictionary<int, NKMBanShipData>();

    //    // Token: 0x04001FD7 RID: 8151
    //    public Dictionary<int, NKMBanOperatorData> m_dicNKMBanOperatorData = new Dictionary<int, NKMBanOperatorData>();

    //    // Token: 0x04001FD8 RID: 8152
    //    public Dictionary<int, NKMUnitUpData> m_dicNKMUpData = new Dictionary<int, NKMUnitUpData>();

    //    // Token: 0x04001FD9 RID: 8153
    //    public string m_NKMGameStatRateID;

    //    // Token: 0x04001FDA RID: 8154
    //    private NKMGameStatRate m_GameStatRateCache;

    //    // Token: 0x04001FDB RID: 8155
    //    private bool m_bGameStatCacheSet;

    //    // Token: 0x04001FDC RID: 8156
    //    public bool isSurrenderGame;
    
    //}


        public enum NKM_ERROR_CODE : short
    {
        NEC_OK,
        NEC_DB_FAIL_USER_DATA,
        NEC_DB_FAIL_MISC_ITEM_DATA,
        NEC_DB_FAIL_EQUIP_ITEM_DATA,
        NEC_DB_FAIL_UNIT_DATA,
        NEC_DB_FAIL_UNIT_ILLUSTRATE_DATA,
        NEC_DB_FAIL_DECK_DATA,
        NEC_DB_FAIL_RAID_DECK_DATA,
        NEC_DB_FAIL_CONTRACT_DATA,
        NEC_DB_FAIL_DUNGEON_WARFARE_CLEAR_DATA,
        NEC_DB_FAIL_WORLDMAP_CITY_DATA,
        NEC_DB_FAIL_WORLDMAP_CITY_BUILD_DATA,
        NEC_DB_FAIL_WARFARE_DATA,
        NEC_DB_FAIL_WARFARE_TEAM_DATA,
        NEC_DB_FAIL_WARFARE_TILE,
        NEC_DB_FAIL_SHOP_PURCHASE_HISTORY_DATA,
        NEC_DB_FAIL_SHOP_FIRST_CASH_PURCHASE_DATA,
        NEC_DB_FAIL_SHOP_RANDOM_LIST_DATA,
        NEC_DB_FAIL_MISSION_DATA,
        NEC_DB_FAIL_SKIN_DATA,
        NEC_DB_FAIL_COUNTER_CASE_DATA,
        NEC_DB_FAIL_MOLD_ITEM_DATA,
        NEC_DB_FAIL_CRAFT_DATA,
        NEC_DB_FAIL_EPISODE_COMPELTE_DATA,
        NEC_DB_FAIL_PVP_DATA,
        NEC_DB_FAIL_DIVE_DATA,
        NEC_DB_FAIL_ATTENDANCE_DATA,
        NEC_DB_FAIL_TEAM_COLLECTION_DATA,
        NEC_DB_FAIL_COMPANY_BUFF_DATA,
        NEC_DB_FAIL_SHOP_SUBSCRIPTION_DATA,
        NEC_DB_FAIL_CONTENTS_BLOCK_DATA,
        NEC_DB_FAIL_ON_TIME_EVENT_DATA,
        NEC_DB_FAIL_CREATE_MEMBER,
        NEC_DB_FAIL_SELECT_PVP_HISTORY,
        NEC_DB_FAIL_SELECT_REVIEW_BANISH_LIST,
        NEC_BRIDGE_USER_PRESENCE_NOT_FOUND,
        NEC_BRIDGE_USER_LOGIN_TIME_OUT,
        NEC_FAIL_LoginReq_PROTOCOL_VERSION_NOT_MATCH,
        NEC_FAIL_INVALID_RELEASE_VERSION,
        NEC_FAIL_INVALID_AUTH_TOKEN,
        NEC_FAIL_CANNOT_FOUND_LOBBY_SERVER,
        NEC_FAIL_CANNOT_FOUND_GAME_SERVER,
        NEC_FAIL_CANNOT_FOUND_BRIDGE_SERVER,
        kLoginFailure_LoggedInJustBefore,
        NEC_FAIL_CLIENT_VERSION_UPDATE,
        NEC_FAIL_INVALID_SERVER_INFO,
        NEC_FAIL_INVALID_CONTENT_UNLOCK,
        NEC_FAIL_ACCOUNT_INVALID,
        NEC_FAIL_ACCOUNT_INVALID_NICKNAME_LENGTH,
        NEC_FAIL_ACCOUNT_INVALID_NICKNAME_FILTER,
        NEC_FAIL_ACCOUNT_INVALID_ID,
        NEC_FAIL_ACCOUNT_INVALID_PASSWORD,
        NEC_FAIL_ACCOUNT_ALREADY_ID,
        NEC_FAIL_ACCOUNT_ALREADY_NICKNAME,
        NEC_FAIL_ARMY_DATA_INVALID,
        NEC_FAIL_SELECT_DECK_INDEX_INVALID,
        NEC_FAIL_DECK_DATA_INVALID,
        NEC_FAIL_DECK_NO_SHIP,
        NEC_FAIL_DECK_UNIT_INVALID,
        NEC_FAIL_DECK_DUPLICATE_UNIT,
        NEC_FAIL_DECK_ALREADY_USE,
        NEC_FAIL_DECK_NOT_ENOUGH_UNIT_COUNT,
        NEC_FAIL_DECK_INVALID_GAME_TYPE,
        NEC_FAIL_DECK_INVALID_TYPE,
        NEC_FAIL_INVALID_DUNGEON_ID,
        NEC_FAIL_INVALID_EPISODE_ID,
        NEC_FAIL_INVALID_STAGE_ID,
        NEC_FAIL_LOCKED_EPISODE,
        NEC_FAIL_REQUIRE_MORE_USER_LEVEL,
        NEC_FAIL_NKMPacket_GAME_LOAD_REQ_DECK_INVALID,
        NEC_FAIL_NKMPacket_GAME_LOAD_REQ_DECK_NOT_FULL,
        NEC_FAIL_NKMPacket_GAME_LOAD_REQ_DECK_UNIT_INVALID,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_UNIT_NULL,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_UNIT_TEMPLET_NULL,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_UNIT_LIVE,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_INVALID_POS,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_NO_RESPAWN_COST,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_NO_DECK,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_NO_GAME_STATE,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_NO_GAME,
        NEC_FAIL_NPT_GAME_RESPAWN_ACK_MAX_UNIT_COUNT_SAME_TIME,
        NEC_FAIL_NPT_GAME_RE_RESPAWN_UNIT_START,
        NEC_FAIL_NPT_GAME_RE_RESPAWN_UNIT_SKILL,
        NEC_FAIL_NPT_GAME_RE_RESPAWN_UNIT_DYING,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_UNIT,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_SHIP_SKILL,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_SHIP_ACTIVE_TYPE,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_RESPAWN_COST,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_GAME_STATE_COOL_TIME,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_ALREADY_USE_SKILL,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_GAME,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_SILENCE,
        NEC_FAIL_NPT_GAME_TACTICAL_COMMAND_INVALID_TC,
        NEC_FAIL_NPT_GAME_TACTICAL_COMMAND_NO_COST,
        NEC_FAIL_NPT_GAME_AUTO_CAN_NOT_USE,
        NEC_FAIL_GAME_LOAD_FAILED,
        NEC_FAIL_INSUFFICIENT_CASH,
        NEC_FAIL_INSUFFICIENT_ETERNIUM,
        NEC_FAIL_INSUFFICIENT_CREDIT,
        NEC_FAIL_INSUFFICIENT_INFORMATION,
        NEC_FAIL_INSUFFICIENT_DAILY_TICKET,
        NEC_FAIL_INSUFFICIENT_BUILD_POINT,
        NEC_FAIL_NPT_DECK_UNLOCK_ACK_ALREADY_MAX,
        NEC_FAIL_NPT_DECK_UNIT_SET_ACK_DUPLICATE_UNIT,
        NEC_FAIL_NPT_DECK_UNIT_NOALLOWED_TYPE,
        NEC_FAIL_NPT_DECK_SHIP_SET_ACK_NOT_SHIP,
        NEC_FAIL_NPT_MATCH_GAME_ALREADY_BEGIN,
        NEC_FAIL_MATCH_GAME_ALREADY_MATCHING,
        NEC_FAIL_MATCH_GAME_INVALID_MATCH_TYPE,
        NEC_FAIL_MATCH_GAME_CANCEL_FAIL,
        NEC_FAIL_INSUFFICIENT_RESOURCE,
        NEC_FAIL_INSUFFICIENT_ITEM,
        NEC_FAIL_ARMY_FULL,
        NEC_FAIL_SHIP_FULL,
        NEC_FAIL_EQUIP_ITEM_FULL,
        NEC_FAIL_OPERATOR_FULL,
        NEC_FAIL_CONTRACT_INVALID_CONTRACT_ID,
        NEC_FAIL_CONTRACT_INVALID_SALARY_LEVEL,
        NEC_FAIL_CONTRACT_INVALID_CONTRACT_COUNT,
        NEC_FAIL_PERMANENT_CONTRACT_INVALID_CONDITION,
        NEC_FAIL_CONTRACT_INVALID_SLOT_INDEX,
        NEC_FAIL_CONTRACT_SLOT_NOT_EMPTY,
        NEC_FAIL_CONTRACT_SLOT_ALREADY_COMPLETE,
        NEC_FAIL_CONTRACT_SLOT_NOT_COMPLETE,
        NEC_FAIL_CONTRACT_SLOT_NOT_ON_PROGRESS,
        NEC_FAIL_CONTRACT_SLOT_UNLOCK_ALREADY_MAX,
        NEC_FAIL_CONTRACT_NOT_ENOUGH_SLOT,
        NEC_FAIL_CONTRACT_INVALID_TIME,
        NEC_FAIL_CONTRACT_DB_UPDATE_SLOT,
        NEC_FAIL_CONTRACT_NO_SLOTS_ON_PROGRESS,
        NEC_FAIL_EMPTY_MAINUNIT_NOT_ALLOWED,
        NEC_FAIL_UNIT_INVALID_UNIT_ID,
        NEC_FAIL_UNIT_INVALID_UNIT_UID,
        NEC_FAIL_UNIT_NOT_EXIST,
        NEC_FAIL_UNIT_BAD_TYPE,
        NEC_FAIL_UNIT_LOCKED,
        NEC_FAIL_UNIT_IN_DECK,
        NEC_FAIL_UNIT_IS_LOBBYUNIT,
        NEC_FAIL_UNIT_ALREADY_USE,
        NEC_FAIL_UNIT_IS_WORLDMAP_LEADER,
        NEC_FAIL_UNIT_IS_WORLDMAP_DOING_MISSION,
        NEC_FAIL_UNIT_EQUIP_ITEM,
        NEC_FAIL_LIMITBREAK_DIFFRENT_UNIT,
        NEC_FAIL_LIMITBREAK_ALREADY_MAX_LEVEL,
        NEC_FAIL_LIMITBREAK_USING_TOO_MUCH,
        NEC_FAIL_LIMITBREAK_LOW_LEVEL,
        NEC_FAIL_LIMITBREAK_USING_SELF,
        NEC_FAIL_UNIT_SKILL_NOT_EXIST,
        NEC_FAIL_UNIT_SKILL_TEMPLET_NOT_EXIST,
        NEC_FAIL_UNIT_SKILL_ALREADY_MAX,
        NEC_FAIL_UNIT_SKILL_IS_UPGRADING,
        NEC_FAIL_UNIT_SKILL_NOT_ENOUGH_ITEM,
        NEC_FAIL_UNIT_SKILL_NEED_LIMIT_BREAK,
        NEC_FAIL_NPT_GAME_ACK_DUNGEON_ONLY_PAUSE,
        NEC_FAIL_WORLDMAP_INVALID_CITY_ID,
        NEC_FAIL_WORLDMAP_INVALID_AREA_ID,
        NEC_FAIL_WORLDMAP_FULL_AREA,
        NEC_FAIL_WORLDMAP_AREA_AREADY_OPENED,
        NEC_FAIL_WORLDMAP_CITY_ALREADY_OPENED,
        NEC_FAIL_WORLDMAP_CITY_LEVELUP_FAIL,
        NEC_FAIL_WORLDMAP_CITY_LEVELUP_FAIL_MISSION,
        NEC_FAIL_WORLDMAP_MISSION_DO_NOT_SET_LEADER,
        NEC_FAIL_WORLDMAP_MISSION_DOING,
        NEC_FAIL_WORLDMAP_MISSION_NOT_DOING,
        NEC_FAIL_WORLDMAP_MISSION_NOT_ENOUGH_MISSION_REFRESH_COUNT,
        NEC_FAIL_WORLDMAP_INVALID_MISSION_ID,
        NEC_FAIL_WORLDMAP_MISSION_DECK_POWER_LOW,
        NEC_FAIL_WORLDMAP_MISSION_DECK_HAS_UNIT_FROM_ANOTHER_CITY,
        NEC_FAIL_WORLDMAP_MISSION_INVALID_DECK,
        NEC_FAIL_WORLDMAP_INVALID_EVENT_GROUP_ID,
        NEC_FAIL_WORLDMAP_EXPIRE_EVENT,
        NEC_FAIL_WORLDMAP_MISSION_LEADER_LEVEL_LOW,
        NEC_FAIL_WORLDMAP_CANNOT_EXPIRE_COMMAND,
        NEC_FAIL_WORLDMAP_EVENT_IS_ALREADY_SET,
        NEC_FAIL_WORLDMAP_CANNOT_FOUND_EVENT,
        NEC_FAIL_WARFARE_GAME_INVALID_USER,
        NEC_FAIL_WARFARE_GAME_INVALID_START_GAME_DATA,
        NEC_FAIL_WARFARE_GAME_IS_NOT_STOP,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_WARFARE_TEMPLET,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_EPISODE_TEMPLET,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_EPISODE_SUB_TEMPLET,
        NEC_FAIL_WARFARE_GAME_NOT_EXIST_USER_FLAG_SHIP,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_WARFARE_MAP_TEMPLET,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_WARFARE_TILE,
        NEC_FAIL_WARFARE_GAME_CANNOT_SET_UNIT_ON_DISABLE_TILE,
        NEC_FAIL_WARFARE_GAME_CANNOT_POSITION_BY_DUNGEON,
        NEC_FAIL_WARFARE_SHIP_DATA_NOT_FOUND,
        NEC_FAIL_WARFARE_TRYING_SPAWN_TO_INVLID_TILE,
        NEC_FAIL_WARFARE_GAME_NOT_EXIST_FLAG_DUNGEON,
        NEC_FAIL_WARFARE_GAME_MOVE_INVALID_TILE_INDEX,
        NEC_FAIL_WARFARE_GAME_MOVE_DISABLE_TILE_INDEX,
        NEC_FAIL_WARFARE_GAME_MOVE_UNIT_NOT_EXIST_ON_FROMTILE,
        NEC_FAIL_WARFARE_GAME_MOVE_UNIT_TURN_ALREADY_END,
        NEC_FAIL_WARFARE_GAME_ALREADY_USER_TURN_FINISHED,
        NEC_FAIL_WARFARE_GAME_MOVE_NOT_EXIST_DUNGEON_UNIT_FOR_BATTLE,
        NEC_FAIL_WARFARE_GAME_MOVE_NOT_EXIST_USER_UNIT_FOR_BATTLE,
        NEC_FAIL_WARFARE_GAME_STATE_IS_NOT_NWGS_INGAME_PLAY_TRY,
        NEC_FAIL_WARFARE_GAME_DUNGEON_ID_OR_DECKINDEX_IS_NOT_MATCH,
        NEC_FAIL_WARFARE_GAME_CANNOT_START_BY_DUPLICATE_DECK_INDEX,
        NEC_FAIL_WARFARE_GAME_CANNOT_POSITION_UNDER_0_COLUMN,
        NEC_FAIL_WARFARE_GAME_CANNOT_POSITION,
        NEC_FAIL_WARFARE_GAME_CANNOT_ASSAULT_POSITION,
        NEC_FAIL_WARFARE_GAME_ALREADY_STOPPED,
        NEC_FAIL_WARFARE_GAME_MOVE_OVER_MOVING,
        NEC_FAIL_WARFARE_GAME_IS_NOT_PLAYING_STATE,
        NEC_FAIL_WARFARE_GAME_CANNOT_GET_NEXT_ORDER_AT_TURN_A,
        NEC_FAIL_WARFARE_GAME_CANNOT_START_BY_MAX_USER_UNIT_OVERFLOW,
        NEC_FAIL_WARFARE_GAME_AUTO_IS_ALREADY_SET,
        NEC_FAIL_WARFARE_GAME_CANNOT_USER_CONTROL_MOVE_ON_AUTO,
        NEC_FAIL_WARFARE_GAME_CANNOT_USER_CONTROL_TURN_FINISH_ON_AUTO,
        NEC_FAIL_WARFARE_GAME_INVALID_WARFARE_GAME_DATA,
        NEC_FAIL_WARFARE_GAME_INVALID_WARFARE_TEMPLET_ID,
        NEC_FAIL_WARFARE_GAME_REQUIRED_WF_IS_NOT_CLEARED,
        NEC_FAIL_WARFARE_DOING,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_GAME_UNIT_BY_GUUID_ON_TILE,
        NEC_FAIL_WARFARE_GAME_TILE_HAS_MULTIPLE_UNITS,
        NEC_FAIL_WARFARE_GAME_CANNOT_USE_THIS_ITEM_IN_WARFARE,
        NEC_FAIL_WARFARE_GAME_CANNOT_FIND_UNIT,
        NEC_FAIL_WARFARE_GAME_UNIT_HP_IS_ALREADY_FULL,
        NEC_FAIL_WARFARE_GAME_UNIT_SUPPLY_IS_ALREADY_FULL,
        NEC_FAIL_WARFARE_GAME_NOT_SERVICEABLE_TILE,
        NEC_FAIL_WARFARE_GAME_CANNOT_USE_THIS_ITEM_ON_AUTO,
        NEC_FAIL_WARFARE_GAME_CAN_ONLY_USE_THIS_ITEM_ON_TURN_A,
        NEC_FAIL_WARFARE_GAME_WIN_CONDITION_KILL_TARGET_COUNT,
        NEC_FAIL_WARFARE_GAME_WIN_CONDITION_ENTER_TILE_NOT,
        NEC_FAIL_WARFARE_GAME_WIN_CONDITION_HOLD_TILE_NOT,
        NEC_FAIL_WARFARE_GAME_EXPIRED,
        NEC_FAIL_WARFARE_GAME_NEXT_ORDER_WARFARE_STATE_STOP,
        NEC_FAIL_WARFARE_GAME_NEXT_ORDER_WARFARE_STATE_INGAME_PLAYING,
        NEC_FAIL_WARFARE_FRIEND_ON_COOLDOWN,
        NEC_FAIL_WARFARE_FRIEND_NOT_SUPPOTABLE_MAP,
        NEC_FAIL_WARFARE_FRIEND_INVLAID_TILE_INDEX,
        NEC_FAIL_WARFARE_FRIEND_CANNOT_USE_SERVICE,
        NEC_FAIL_POST_FULL,
        NEC_FAIL_POST_RECV_ITEM_FULL,
        NEC_FAIL_POST_INVALID_POST_INDEX,
        NEC_FAIL_POST_EXPIRED,
        NEC_FAIL_POST_SEND_FAIL,
        NEC_FAIL_SHIP_MAX_LEVEL,
        NEC_FAIL_SHIP_INVALID_SHIP_ID,
        NEC_FAIL_SHIP_INVALID_SHIP_UID,
        NEC_FAIL_SHIP_INSUFFICIENT_COUNT,
        NEC_FAIL_SHIP_REMODEL_NOT_ENOUGH_LEVEL,
        NEC_FAIL_SHIP_NOT_UNLOCKED,
        NEC_FAIL_INVALID_ITEM_ID,
        NEC_FAIL_INVALID_ITEM_UID,
        NEC_FAIL_INVALID_ITEM_REWARD_GROUP_ID,
        NEC_FAIL_INVALID_EQUIP_ITEM,
        NEX_FAIL_CANNOT_EQUIP_ITEM,
        NEX_FAIL_CANNOT_UNEQUIP_ITEM,
        NEC_FAIL_ITEM_LOCKED,
        NEC_FAIL_EQUIP_ITEM_ENCHANT_MAX,
        NEC_FAIL_INVALID_SHOP_ID,
        NEC_FAIL_SHOP_DISABLE_PRODUCT,
        NEC_FAIL_LIMITED_SHOP_COUNT_FAIL,
        NEC_FAIL_SHOP_BUNDLE_TAB_SOLDOUT,
        NEC_FAIL_CANNOT_REFRESH,
        NEC_FAIL_SHOP_NOT_ENOUGH_REFRESH_COUNT,
        NEC_FAIL_SHOP_INVALID_RECEIPT,
        NEC_FAIL_SHOP_RECEIPT_EXPIRED,
        NKE_FAIL_SHOP_NOT_EVENT_TIME,
        NKE_FAIL_SHOP_SKIN_ALREADY_OWNED,
        NKE_FAIL_SHOP_LIMIT_SALE_TIME_IS_OVER,
        NKE_FAIL_SHOP_MAKE_REWARD_DATA_NULL,
        NKE_FAIL_SHOP_INVALID_CHAIN_TAB,
        NEC_FAIL_SHOP_SUBSCRIPTION_INVALID_DATE,
        NEC_FAIL_SHOP_FRAME_ALREADY_OWNED,
        NEC_FAIL_SHOP_BACKGROUND_ALREADY_OWNED,
        NEC_FAIL_SHOP_ALREADY_OWNED,
        NEC_FAIL_MISSION_INVALID_MISSION_TAB,
        NEC_FAIL_MISSION_INVALID_MISSION_ID,
        NEC_FAIL_MISSION_NOT_ENOUGH_MISSION_COND_VALUE,
        NEC_FAIL_MISSION_ALREADY_COMPLETED,
        NEC_FAIL_INVALID_STAR_GRADE,
        NEC_FAIL_SKIN_NOT_OWNED,
        NEC_FAIL_SKIN_UNIT_NOT_MATCH,
        NEC_FAIL_EVENTDECK_NOT_EXIST,
        NEC_FAIL_EVENTDECK_SLOT_UNREQUIRED_DATA,
        NEC_FAIL_EVENTDECK_SLOT_DIFFRENT_UNIT,
        NEC_FAIL_EVENTDECK_SLOT_DIFFRENT_UNIT_TYPE,
        NEC_FAIL_EVENTDECK_CONDITION,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_STYLE,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_RARITY,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_LEVEL,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_COST,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_ROLE,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_COST_TOTAL,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_ID,
        NEC_FAIL_EVENTDECK_CONDITION_AWAKEN_COUNT,
        NEC_FAIL_EVENTDECK_CONDITION_UNIT_MOVE_TYPE,
        NEC_FAIL_EVENTDECK_CONDITION_SHIP_LEVEL,
        NEC_FAIL_EVENTDECK_CONDITION_SHIP_STYLE,
        NEC_FAIL_COUNTERCASE_ALREADY_UNLOCKED,
        NEC_FAIL_COUNTERCASE_NOT_UNLOCKED,
        NEC_FAIL_CUTSCENE_DUNGEON_ALREADY_CLEARED,
        NEC_FAIL_CRAFT_INVALID_SLOT_INDEX,
        NEC_FAIL_CRAFT_NOT_ENOUGH_MOLD,
        NEC_FAIL_CRAFT_NOT_EXIST_MOLD_TEMPLET,
        NEC_FAIL_CRAFT_SLOT_ALREADY_COMPLETED,
        NEC_FAIL_CRAFT_SLOT_ALREADY_UNLOCKED,
        NEC_FAIL_CRAFT_SLOT_ALREADY_UNLOCKED_MAX,
        NEC_FAIL_CRAFT_SLOT_NOT_COMPLETED,
        NEC_FAIL_CRAFT_SLOT_NOT_EMPTY,
        NEC_FAIL_CRAFT_SLOT_NOT_CREATING,
        NEC_FAIL_CRAFT_EXCEEDED_MAX_START_COUNT,
        NEC_FAIL_EQUIP_TUNING_ALREADY_MAX_PRECISION,
        NEC_FAIL_EQUIP_TUNING_RANDOM_STAT_EMPTY,
        NEC_FAIL_EQUIP_TUNING_RANDOM_STAT_GROUP_EMPTY,
        NEC_FAIL_EQUIP_TUNING_RESERVED_STAT_EMPTY,
        NEC_FAIL_EPISODE_COMPLETE_REWARD_NOT_ENOUGH_COUNT,
        NEC_FAIL_EPISODE_COMPLETE_REWARD_ALREADY_GIVEN,
        NEC_FAIL_EPISODE_COMPLETE_REWARD_INVALID_REWARD,
        NEC_FAIL_INVALID_NEGO_STATE,
        NEC_FAIL_UNIT_MAX_LEVEL,
        NEC_FAIL_DIVE_INVALID_STAGE_ID,
        NEC_FAIL_DIVE_ALREADY_CLEARED,
        NEC_FAIL_DIVE_ALREADY_STARTED,
        NEC_FAIL_DIVE_NOT_ENOUGH_SQUAD_COUNT,
        NEC_FAIL_DIVE_NOT_CLEARED,
        NEC_FAIL_DIVE_LOCKED_STAGE,
        NEC_FAIL_DIVE_EXPIRED,
        NEC_FAIL_DIVE_HAS_NOT_STARTED_YET,
        NEC_FAIL_DIVE_CANNOT_MOVE_FORWARD,
        NEC_FAIL_DIVE_CANNOT_FOUND_SLOT,
        NEC_FAIL_DIVE_CANNOT_GIVE_UP,
        NEC_FAIL_DIVE_IS_NOT_READY_FOR_BATTLE,
        NEC_FAIL_DIVE_CANNOT_FOUND_SQUAD,
        NEC_FAIL_DIVE_INVALID_DUNGEON_ID,
        NEC_FAIL_DIVE_INVALID_DECK_INDEX,
        NEC_FAIL_DIVE_BATTLE_HAS_NOT_STARTED_YET,
        NEC_FAIL_DIVE_DOING,
        NEC_FAIL_DIVE_CANNOT_EXPIRE_CITY_DIVE,
        NEC_FAIL_DIVE_FILL_RANDOM_SLOT,
        NEC_FAIL_DIVE_GAME_DATA_FLOOR_NULL,
        NEC_FAIL_DIVE_GAME_DATA_PLAYER_NULL,
        NEC_FAIL_DIVE_CHANGE_SQUAD_HP_SQUAD_NULL,
        NEC_FAIL_DIVE_CHANGE_SQUAD_HP_SQUAD_DEAD,
        NEC_FAIL_DIVE_FLOOR_GET_SLOT_NULL,
        NEC_FAIL_UNKNOWN_EXPAND_TYPE,
        NEC_FAIL_CANNOT_EXPAND_INVENTORY,
        NEC_FAIL_CANNOT_FOUND_GAME,
        NEC_FAIL_ATTENDANCE,
        NEC_FAIL_INVALID_PVP_RANK_POSITION,
        NEC_FAIL_INVALID_PVP_SEASON_DATA,
        NEC_FAIL_PVP_CHARGE_POINT_MAX,
        NEC_FAIL_PVP_INVALID_CHARGE_DATE,
        NEC_FAIL_PVP_SHORT_OF_TIME,
        NEC_FAIL_PVP_INVALID_MATCH_TYPE,
        NEC_FAIL_PVP_INVALID_USER_COUNT,
        NEC_FAIL_PVP_NOT_FOUND_PVP_CHARGE_POINT_ITEM,
        NEC_FAIL_PVP_RANK_TEMPLET_BY_SCORE_NULL,
        NEC_FAIL_PVP_RANK_TEMPLET_BY_TIER_NULL,
        NEC_FAIL_PVP_MATCH_INVALID_UNIT_DATA,
        NEC_FAIL_PVP_GAME_PLAYER_NOT_NULL,
        NEC_FAIL_END_SEASON,
        NEC_FAIL_END_WEEK,
        NEC_FAIL_ALREADY_REWARD_WEEK_DATA,
        NEC_FAIL_ALREADY_REWARD_SEASON_DATA,
        NEC_FAIL_HAVE_NOT_BEEN_REWARDED,
        NEC_FAIL_CAN_NOT_FOUND_ASYNC_PVP_POINT_ITEM,
        NEC_FAIL_PVP_LEAGUE_MISS_MATCH,
        NEC_FAIL_PVP_CAN_NOT_FOUND_FRIEND,
        NEC_FAIL_TEAM_COLLECTION_REWARD_INVALID_TEAM_ID,
        NEC_FAIL_TEAM_COLLECTION_REWARD_ALREADY_GIVEN,
        NEC_FAIL_TEAM_COLLECTION_REWARDE_NOT_ENOUGH_COUNT,
        NEC_FAIL_UNIT_REVIEW_COMMENT_INVALID_PAGE_NUMBER,
        NEC_FAIL_UNIT_REVIEW_COMMENT_EXCEEDED_MAX_CONTENT_LENGTH,
        NEC_FAIL_UNIT_REVIEW_COMMENT_ALREADY_WRITTEN,
        NEC_FAIL_UNIT_REVIEW_COMMENT_NOT_EXIST,
        NEC_FAIL_UNIT_REVIEW_COMMENT_CANNOT_VOTE_YOUR_COMMENT,
        NEC_FAIL_UNIT_REVIEW_COMMENT_ALREADY_VOTED,
        NEC_FAIL_UNIT_REVIEW_COMMENT_NOT_VOTED,
        NEC_FAIL_UNIT_REVIEW_COMMENT_STRING_FILTER,
        NEC_FAIL_UNIT_REVIEW_SCORE_INVALID_SCORE,
        NEC_FAIL_UNIT_REVIEW_SCORE_INTERVAL_HAS_NOT_ELAPSED,
        NEC_FAIL_UNIT_REVIEW_TAG_INVALID_TAG_TYPE,
        NEC_FAIL_UNIT_REVIEW_TAG_EXCEEDED_MAX_VOTE_COUNT,
        NEC_FAIL_UNIT_REVIEW_TAG_ALREADY_VOTED,
        NEC_FAIL_UNIT_REVIEW_TAG_NOT_EXIST,
        NEC_FAIL_UNIT_REVIEW_TAG_NOT_VOTED,
        NEC_FAIL_UNIT_REVIEW_BANISH_ALREADY_EXIST,
        NEC_FAIL_UNIT_REVIEW_BANISH_NOT_EXIST,
        NEC_FAIL_UNIT_REVIEW_BANISH_MAX_COUNT,
        NEC_FAIL_LOW_BALANCE,
        NEC_FAIL_WORLDMAP_COLLECT_SHORT_OF_TIME,
        NEC_FAIL_WORLDMAP_COLLECT_REWARD_DB_FAIL,
        NEC_FAIL_WORLDMAP_BUILD_MAX,
        NEC_FAIL_WORLDMAP_BUILD_AREADY_EXIST,
        NEC_FAIL_WORLDMAP_BUILD_NOT_EXIST,
        NEC_FAIL_WORLDMAP_BUILD_NOT_ENOUGH_LEVEL,
        NEC_FAIL_WORLDMAP_INVALID_BUILD_ID,
        NEC_FAIL_WORLDMAP_INVALID_BUILD_LEVEL,
        NEC_FAIL_WORLDMAP_CANNOT_FOUND_TRIGGER_INFO,
        NEC_FAIL_WORLDMAP_BUILD_NOT_EXIST_REQ_BUILDING,
        NEC_FAIL_WORLDMAP_BUILD_ALREADY_MAX_LEVEL,
        NEC_FAIL_WORLDMAP_EVENT_NOT_ENDED,
        NEC_FAIL_WORLDMAP_NOT_BUILDING_TOGETHER,
        NEC_FAIL_CREATE_MISSION_LIST,
        NEC_FAIL_NEGOTIATE_ALREADY_ON_NEGOTIATION,
        NEC_FAIL_NEGOTIATE_INVALID_ROUND,
        NEC_FAIL_NEGOTIATE_INVALID_EXP_DATA,
        NEC_FAIL_NEGOTIATE_NOT_ON_NEGOTIATION,
        NEC_FAIL_NEGOTIATE_INVALID_FINAL_BOSS_SELECTION,
        NEC_FAIL_NEGOTIATE_RESULT_STORE_TO_DB,
        NEC_FAIL_NEGOTIATE_UNDEFINED_BOSS_SELECTION,
        NEC_FAIL_NEGOTIATE_UNDEFINED_FINAL_RESULT,
        NEC_FAIL_RAID_NOT_EXIST,
        NEC_FAIL_RAID_HAS_BEEN_DEFEATED,
        NEC_FAIL_RAID_EXPIRED,
        NEC_FAIL_RAID_EXCEEDED_TRY_COUNT,
        NEC_FAIL_RAID_EXCEEDED_MAX_RAID_RESULT_COUNT,
        NEC_FAIL_RAID_NOT_JOINED,
        NEC_FAIL_RAID_NOT_ENDED,
        NEC_FAIL_RAID_NOT_OWNER,
        NEC_FAIL_RAID_INVALID_RAID_BUFF,
        NEC_FAIL_ALREADY_GET_RAID_POINT_REWARD,
        NEC_FAIL_NOT_ENOUGH_RAID_POINT,
        NEC_FAIL_NOT_EXIST_RAID_POINT_REWARD_TEMPLET,
        NEC_FAIL_NOT_EXIST_TRY_ASSIST_COUNT,
        NEC_FAIL_NOT_ASSIST_MY_RAID,
        NEC_FAIL_INVALID_MISC_ITEM_ID,
        NEC_FAIL_INVALID_EQUIP_ITEM_ID,
        NEC_FAIL_INVALID_SKIN_ITEM_ID,
        NEC_FAIL_INVALID_MOLD_ITEM_ID,
        NEC_FAIL_CANNOT_USE_THIS_FEATURE,
        NEC_FAIL_GET_EQUIP_ENCHANT_EXP_TEMPLET_NULL,
        NEC_FAIL_GET_EQUIP_TEMPLET_NULL,
        NEC_FAIL_GET_USER_EXP_TEMPLET_NULL,
        NEC_FAIL_GET_UNIT_EXP_TEMPLET_NULL,
        NEC_FAIL_GET_UNIT_BASE_TEMPLET_NULL,
        NEC_FAIL_GET_UNIT_TEMPLET_NULL,
        NEC_FAIL_GET_ITEM_MISC_TEMPLET_NULL,
        NEC_FAIL_GET_UNIT_LIMIT_BREAK_TEMPLET_NULL,
        NEC_FAIL_GET_ITEM_LIMIT_BREAK_TEMPLET_NULL,
        NEC_FAIL_USER_DATA_NULL,
        NEC_FAIL_WARFARE_GAME_DATA_NULL,
        NEC_FAIL_WARFARE_GAME_STATE_NWGS_STOP,
        NEC_FAIL_WARFARE_GAME_STATE_NWGS_INGAME_PLAYING,
        NEC_FAIL_CONTRACT_TEMPLET_NULL,
        NEC_FAIL_CONTRACT_TYPE_NOT_MATCH,
        NEC_FAIL_CONTRACT_REPEAT_COUNT_IS_ZERO,
        NEC_FAIL_EVENT_SLOT_UNIT_TYPE_INVALID,
        NEC_FAIL_EVENT_DECK_TEMPLET_NULL,
        NEC_FAIL_ENHANCE_UNIT_IN_ANY_DECK,
        NEC_FAIL_ENHANCE_UNIT_ENHANCE_MAX,
        NEC_FAIL_GAME_IS_PAUSE,
        NEC_FAIL_GAME_IS_NOT_LOCAL,
        NEC_FAIL_GET_EQUIP_ENCHANT_EXP_TEMPLET,
        NEC_FAIL_PVP_SEASON_ID_0,
        NEC_FAIL_PVP_WEEK_ID_0,
        NEC_FAIL_DECK_STATE_INVALID,
        NEC_FAIL_DUNGEON_GAME_TYPE_IS_NOT_PVE,
        NEC_FAIL_USER_PROFILE_INFO_DECK_TYPE_UNDEFINED,
        NEC_FAIL_RANDOM_ITEM_BOX_OPEN_COUNT_OVER_10,
        NEC_FAIL_RANDOM_BOX_GET_RANDOM_UNIT_INVALID,
        NEC_FAIL_GET_RANDOM_UNIT_BOX_NULL,
        NEC_FAIL_PICK_RANDOM_UNIT_NULL,
        NEC_FAIL_INTERVAL_JOIN_FAILED,
        NEC_DB_FAIL_UPDATE_DECK = 20000,
        NEC_DB_FAIL_UPDATE_DECK_UNLOCK,
        NEC_DB_FAIL_INSERT_DIVE,
        NEC_DB_FAIL_UPDATE_DIVE_PLAYER,
        NEC_DB_FAIL_UPDATE_DIVE,
        NEC_DB_FAIL_UPDATE_DIVE_CHEAT_EXPIRE,
        NEC_DB_FAIL_DELETE_DIVE,
        NEC_DB_FAIL_UPDATE_DUNGEON_CLEAR,
        NEC_DB_FAIL_UPDATE_PVPDATA_RESET_SCORE,
        NEC_DB_FAIL_UPDATE_PVP_WEEK_REWARD,
        NEC_DB_FAIL_UPDATE_PVP_SEASON_REWARD,
        NEC_DB_FAIL_UPDATE_PVPDATA,
        NEC_DB_FAIL_UPDATE_PVP_CHARGE_DATE,
        NEC_DB_FAIL_UPDATE_RAID_RESULT,
        NEC_DB_FAIL_UPDATE_RAID_COOP,
        NEC_DB_FAIL_UPDATE_RAID_START,
        NEC_DB_FAIL_UPDATE_RAID_END,
        NEC_DB_FAIL_SELECT_MY_INFO_CACHE,
        NEC_DB_FAIL_SELECT_RAID_DETAIL,
        NEC_DB_FAIL_SELECT_RAID_JOIN,
        NEC_DB_FAIL_SELECT_RAID_RESULT,
        NEC_DB_FAIL_SELECT_RAID_COOP,
        NEC_DB_FAIL_UPDATE_RAID_EXPIRE,
        NEC_DB_FAIL_SELECT_RAID_SEASON,
        NEC_DB_FAIL_RAID_SEASON_SELECT,
        NEC_DB_FAIL_RAID_SEASON_UPSERT,
        NEC_DB_FAIL_INSERT_SHOP_FIX_BUY,
        NEC_DB_FAIL_INSERT_SHOP_FIX_CASH_BUY,
        NEC_DB_FAIL_INSERT_SHOP_RANDOM_BUY,
        NEC_DB_FAIL_UPDATE_SHOP_RANDOM_LIST,
        NEC_DB_FAIL_INSERT_SHOP_SUBSCRIPTION,
        NEC_DB_FAIL_UPDATE_SHOP_SUBSCRIPTION_DATE,
        NEC_DB_FAIL_INSERT_WORLDMAP_CITY,
        NEC_DB_FAIL_UPDATE_WORLDMAP_LEADER,
        NEC_DB_FAIL_UPDATE_WORLDMAP_MISSION_START,
        NEC_DB_FAIL_UPDATE_WORLDMAP_MISSION_CANCEL,
        NEC_DB_FAIL_UPDATE_WORLDMAP_MISSION_REFRESH,
        NEC_DB_FAIL_INSERT_WORLDMAP_BUILD,
        NEC_DB_FAIL_UPDATE_WORLDMAP_BUILD_LEVELUP,
        NEC_DB_FAIL_DELETE_WORLDMAP_BUILD_EXPIRE,
        NEC_DB_FAIL_UPDATE_WORLDMAP_UPDATE_MISSION_COMPLETE,
        NEC_DB_FAIL_UPDATE_WORLDMAP_EVENT_EXPIRE,
        NEC_DB_FAIL_UPDATE_WORLDMAP_EVENT_REMOVE,
        NEC_DB_FAIL_UPDATE_NICKNAME,
        NEC_DB_FAIL_UPDATE_USER_EXP,
        NEC_DB_FAIL_UPDATE_OPTION,
        NEC_DB_FAIL_UPDATE_ACCOUNT_LINK_DATE,
        NEC_DB_FAIL_UPDATE_TEAM_COLLECTION,
        NEC_DB_FAIL_UPDATE_CONTRACT_COMPLETE,
        NEC_DB_FAIL_UPDATE_CONTRACT,
        NEC_DB_FAIL_UPDATE_CONTRACT_PERMANENTLY,
        NEC_DB_FAIL_UPDATE_CONTRACT_UNLOCK,
        NEC_DB_FAIL_UPDATE_ATTENDANCE,
        NEC_DB_FAIL_UPDATE_CONTENTS_DAILY_REFRESH,
        NEC_DB_FAIL_UPDATE_EPISODE_COMPLETE_REWARD,
        NEC_DB_FAIL_UPDATE_ENHANCE_EQUIP_ITEM,
        NEC_DB_FAIL_UPDATE_EQUIP_ITEM,
        NEC_DB_FAIL_UPDATE_EQUIP_ITEM_LOCK,
        NEC_DB_FAIL_DELETE_EQUIP_ITEM,
        NEC_DB_FAIL_UPDATE_CRAFT_COMPLETE,
        NEC_DB_FAIL_UPDATE_CRAFT_INSTANT_COMPLETE,
        NEC_DB_FAIL_UPDATE_CRAFT_UNLOCK_SLOT,
        NEC_DB_FAIL_UPDATE_CRAFT_START,
        NEC_DB_FAIL_UPDATE_EQUIP_TUNING_REFINE,
        NEC_DB_FAIL_UPDATE_EQUIP_TUNING_STAT_CHANGE_CONFIRM,
        NEC_DB_FAIL_UPDATE_EQUIP_TUNING_STAT_CHANGE,
        NEC_DB_FAIL_UPDATE_COUNTER_CASE,
        NEC_DB_FAIL_UPDATE_INVENTORY_COUNT,
        NEC_DB_FAIL_UPDATE_MISSION_COMPLETE,
        NEC_DB_FAIL_UPDATE_USER_DATA,
        NEC_DB_FAIL_UPDATE_SHIP_DIVISION,
        NEC_DB_FAIL_UPDATE_SHIP_LEVELUP,
        NEC_DB_FAIL_UPDATE_SHIP_UPGRADE,
        NEC_DB_FAIL_UPDATE_UNIT_SKIN,
        NEC_DB_FAIL_UPDATE_ENHANCE_UNIT,
        NEC_DB_FAIL_UPDATE_UNIT_LIMITBREAK,
        NEC_DB_FAIL_UPDATE_UNIT_UNLOCK,
        NEC_DB_FAIL_DELETE_UNIT,
        NEC_DB_FAIL_UPDATE_UNIT_SKILL,
        NEC_DB_FAIL_DELETE_UNIT_REVIEW_COMMENT,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_BEST_COMMENT,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_COMMENT,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_MY_COMMENT,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_COMMENT_VOTE_HISTORY,
        NEC_DB_FAIL_UPDATE_UNIT_REVIEW_COMMENT_VOTE_CANCEL,
        NEC_DB_FAIL_UPDATE_UNIT_REVIEW_COMMENT_VOTE,
        NEC_DB_FAIL_INSERT_UNIT_REVIEW_COMMENT,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_SCORE,
        NEC_DB_FAIL_UPDATE_UNIT_REVIEW_SCORE_VOTE,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_TAG,
        NEC_DB_FAIL_SELECT_UNIT_REVIEW_TAG_VOTE_HISTORY,
        NEC_DB_FAIL_UPDATE_UNIT_REVIEW_TAG_VOTE_CANCEL,
        NEC_DB_FAIL_UPDATE_UNIT_REVIEW_TAG_VOTE,
        NEC_DB_FAIL_INSERT_UNIT_REVIEW_BANISH,
        NEC_DB_FAIL_DELETE_UNIT_REVIEW_BANISH,
        NEC_DB_FAIL_UPDATE_RECEIVE_POST,
        NEC_DB_FAIL_INSERT_NEW_GAME,
        NEC_DB_FAIL_WARFARE_DELETE_DATA,
        NEC_DB_FAIL_WARFARE_UPDATE_CLEAR,
        NEC_DB_FAIL_WARFARE_UPDATE_STATE,
        NEC_DB_FAIL_WARFARE_UPDATE_A_TURN_OFF,
        NEC_DB_FAIL_WARFARE_UPDATE_B_TURN_OFF,
        NEC_DB_FAIL_WARFARE_UPDATE_EXPIRE_DATE,
        NEC_DB_FAIL_WARFARE_UPDATE_ITEM_USE,
        NEC_DB_FAIL_WARFARE_UPDATE_DUNGEON_CLOSE,
        NEC_DB_FAIL_WARFARE_UPDATE_TILE,
        NEC_DB_FAIL_SELECT_USER_PASSWORD,
        NEC_DB_FAIL_INSERT_USER_PASSWORD,
        NEC_DB_FAIL_INSERT_USER_MAPPING,
        NEC_DB_FAIL_REGISTER_GAME_SERVER_UPDATE,
        NEC_DB_FAIL_REGISTER_LOGIN_SERVER_UPDATE,
        NEC_DB_FAIL_UPSERT_MISC_ITEM,
        NEC_DB_FAIL_DECREASE_MISC_ITEM,
        NEC_DB_FAIL_DECREASE_MOLD_ITEM,
        NEC_DB_FAIL_UPDATE_REWARD,
        NEC_DB_FAIL_INSERT_UNIT,
        NEC_DB_FAIL_INSERT_SHIP,
        NEC_DB_FAIL_INSERT_NEW_EQUIP,
        NEC_FAIL_GAME_LOAD_INVALID_STATE,
        NEC_FAIL_NO_PERMISSION_FOR_CHEATING,
        NEC_DB_FAIL_UPDATE_WORLDMAP_MISSION_TIME,
        NEC_DB_FAIL_UPDATE_MISSION_COUNT,
        NEC_DB_FAIL_UPDATE_MISSION_RESET,
        NEC_DB_FAIL_UPDATE_MISC_ITEM,
        NEC_DB_FAIL_UPDATE_MOBILE_INFO,
        NEC_DB_FAIL_SELECT_USER_MAPPING,
        NEC_DB_FAIL_SELECT_USER_SERVER_CONFIG,
        NEC_DB_FAIL_INSERT_USER_SERVER_CONFIG,
        NEC_FAIL_GAME_NOT_IN_PLAY,
        NEC_FAIL_GAME_SPEED_2X_NOT_IN_PVP,
        NEC_DB_FAIL_UPSERT_PROFILE,
        NEC_DB_FAIL_SELECT_PVP_PROFILE,
        NEC_DB_FAIL_SELECT_POST,
        NEC_FAIL_USE_UNIT_SKILL_CANT_USE_SKILL,
        NEC_FAIL_USE_UNIT_SKILL_CANT_FIND_UNIT,
        NEC_DB_FAIL_SELECT_USER_OPTION_DATA,
        NEC_FAIL_UNKNOWN_REQUEST,
        NEC_FAIL_GAME_AUTO_SKILL_CHANGE_OFF_NOT_SUPPORT,
        NEC_FAIL_GAME_USE_UNIT_SKILL_REQ_TEAM_NOT_MATCH,
        NEC_FAIL_GAME_SPEED_2X_NOT_SUPPORT_IN_PVP,
        NEC_FAIL_GAME_SPEED_2X_NOT_SUPPORT_2,
        NEC_DB_FAIL_CREATE_USER_DATA,
        NEC_DB_FAIL_CREATE_DECK_DATA,
        NEC_DB_FAIL_CREATE_ITEM_DATA,
        NEC_FAIL_PRACTICE_GAME_LOAD_REQ_INVALID_UNIT_TEMPLET,
        NEC_DB_FAIL_DIVE_CLEAR_DATA,
        NEC_FAIL_INIT_FRIEND_DATA,
        NEC_DB_FAIL_FRIEND_ALL_LIST,
        NEC_FAIL_FRIEND_ADD_COUNT_MAX,
        NEC_FAIL_FRIEND_REQUEST_COUNT_MAX,
        NEC_FAIL_FRIEND_BLOCK_COUNT_MAX,
        NEC_FAIL_FRIEND_CANNOT_ADD_MYSELF,
        NEC_FAIL_FRIEND_CANNOT_BLOCK_MYSELF,
        NEC_FAIL_FRIEND_ADD_ALREADY_RELATED,
        NEC_FAIL_FRIEND_ALREADY_REQUESTED,
        NEC_FAIL_FRIEND_HAS_RECEIVED_REQUEST,
        NEC_FAIL_FRIEND_REQUEST_IS_BLOCKER,
        NEC_FAIL_FRIEND_REQUEST_DB_INSERT,
        NEC_FAIL_FRIEND_NOT_IN_REQUEST,
        NEC_FAIL_FRIEND_REQUEST_DB_DELETE,
        NEC_FAIL_FRIEND_NO_FRIENDSHIP_EXIST,
        NEC_FAIL_FRIEND_CANNOT_DELETE_IN_A_DAY,
        NEC_FAIL_FRIEND_DELETE_LIMIT_EXCEED,
        NEC_FAIL_FRIEND_DB_DELETE,
        NEC_FAIL_FRIEND_DB_UPDATE_DELETE_COUNT,
        NEC_FAIL_FRIEND_NOT_IN_BLOCK_LIST,
        NEC_FAIL_BLOCKER_DB_DELETE,
        NEC_FAIL_FRIEND_ACCEPT_NOT_IN_RECEIVE_LIST,
        NEC_FAIL_FRIEND_REQUEST_DB_ACCEPT,
        NEC_FAIL_FRIEND_DB_REJECT,
        _NOUSE_NEC_FAIL_FRIEND_WARFARE_LIST,
        NEC_FAIL_FRIEND_WARFARE_DATA,
        NEC_FAIL_FRIEND_UPDATE_WARFARE_DATA,
        NEC_FAIL_FRIEND_OTHER_AUTH_LEVEL_GROUP,
        NEC_FAIL_FRIEND_RESPONSE_COUNT_MAX,
        NEC_FAIL_INIT_PROFILE_DATA,
        NEC_FAIL_PROFILE_NOT_FOUND,
        NEC_FAIL_PROFILE_INVALID_UNIT_ID,
        NEC_FAIL_PROFILE_DB_UPDATE_UNIT_ID,
        NEC_FAIL_PROFILE_DB_UPDATE_MESSAGE,
        NEC_FAIL_PROFILE_DB_UPDATE_EMBLEM,
        NEC_FAIL_PROFILE_INVALID_DECK_INDEX,
        NEC_FAIL_PROFILE_DB_UPDATE_FRIEND_DECK,
        NEC_FAIL_PROFILE_DB_UPDATE_PVP_VALUES,
        NEC_FAIL_PROFILE_EMBLEM_INVALID_INDEX,
        NEC_FAIL_PROFILE_EMBLEM_INVALID_ITEM_ID,
        NEC_FAIL_PROFILE_EMBLEM_DUPLICATED_ITEM_ID,
        NEC_DB_FAIL_SELECT_REWARD_EVENT,
        NEC_DB_FAIL_SELECT_REWARD_EVENT_TARGET,
        NEC_FAIL_MAKE_POST_REWARD,
        NEC_FAIL_DEACTIVATED_EVENT_POST,
        NEC_FAIL_INVALID_REQUEST,
        NEC_DB_FAIL_UNIT_EXP_DATA,
        NEC_DB_FAIL_DUNGEON_DATA,
        NEC_FAIL_DIVE_CANNOT_SELECT_ARTIFACT,
        NEC_FAIL_DIVE_EXCEEDED_MAX_ARTIFACT_COUNT,
        NEC_FAIL_GAME_PLAYER_NOT_FOUND,
        NEC_FAIL_DIVE_INVALID_ARTIFACT_ID,
        NEC_FAIL_DIVE_ARTIFACT_ALREADY_GIVEN,
        NEC_DB_FAIL_UPDATE_DIVE_ARTIFACT,
        NEC_FAIL_SHIP_BUILD_DATA,
        NEC_FAIL_CREATE_SHIP,
        NEC_FAIL_SHIP_DATA,
        NEC_FAIL_CREATE_UNIT,
        NEC_FAIL_INVALID_LIMITED_ITEM_UNLOCK,
        NEC_FAIL_REFINE_EQUIP_ITEM_OPTION,
        NEC_DB_FAIL_SHOP_LEVELUP_PACKAGE_DATA,
        NEC_DB_FAIL_INSERT_SHOP_LEVELUP_PACKAGE,
        NEC_FAIL_SHOP_LEVELUP_PACKAGE_ALREADY_PURCHASED,
        NEC_FAIL_SHOP_LEVELUP_PACKAGE_NOT_PURCHASED,
        NEC_FAIL_SHOP_LEVELUP_EXCEEDED_MAX_LEVEL_REQUIRE,
        NEC_FAIL_PVP_ASYNC_MATCH_NEED_REFRESH,
        NEC_FAIL_EPISODE_EVENT_EXPIRED,
        NEC_FAIL_INVALID_GAME_TYPE,
        NEC_FAIL_RAID_COOP_ACTIVATED,
        NEC_DB_FAIL_DELETE_RAID,
        NEC_FAIL_INVALID_NGSM_TOKEN,
        NEC_FAIL_INVALID_EQUIP_ITEM_OPTION,
        NEC_FAIL_INVALID_EQUIP_OPTION_ID,
        NEC_FAIL_INVALID_EQUIP_OPTION_LOCATION,
        NEC_FAIL_GET_EQUIP_OPTION_LIST,
        NEC_FAIL_GET_EQUIP_OPTION_DATA,
        NEC_FAIL_FIND_EQUIP_OPTION_DATA,
        NEC_FAIL_INVALID_EQUIP_ITEM_DATA,
        NEC_FAIL_INVALID_EQUIP_OPTION_GROUP_ID,
        NEC_FAIL_INVALID_EQUIP_OPTION_PRECITION_VALUE,
        NEC_FAIL_DUPLICATE_EQUIP_OPTION,
        NEC_FAIL_UNIQUE_OPTION,
        NEC_FAIL_TEAM_COLLECTION_TEMPLET_DATA,
        NEC_FAIL_AUTO_SUPPLY_INSUFFICIENT_TIME,
        NEC_FAIL_AUTO_SUPPLY_INVALID_VALUE,
        NEC_FAIL_EPISODE_COMPLETE_DATA,
        NEC_FAIL_REQUEST_COOLDOWN_INVALID_TYPE,
        NEC_FAIL_REQUEST_COOLDOWN_TIME,
        NEC_FAIL_UPDATE_PURCHASE_DATA,
        NEC_FAIL_ACCOUNT_BLOCKED,
        NEC_DB_FAIL_NOTICE_DATA,
        NEC_FAIL_SHOP_NOT_ENOUGH_PAID_AMOUNT,
        NEC_FAIL_GAME_NOT_FOUND,
        NEC_FAIL_GET_SLOT_DATA,
        NEC_FAIL_SELECT_EQUIP_OPTION_DATA,
        NEC_FAIL_INVALID_CRAFT_SLOT_INDEX,
        NEC_DB_FAIL_IMMIGRATED_USER_NOT_FOUND,
        NEC_FAIL_GAME_PLAYING,
        NEC_DB_FAIL_REMOVE_COMPANY_BUFF,
        NEC_SHOP_FAIL_PURCHASE_COUNT,
        NEC_PVP_GAME_CREATE_FAILED,
        NEC_SHOP_FAIL_PRODUCT_COUNT,
        NEC_INVALID_FRIEND_CODE,
        NEC_POST_TITLE_IS_EMPTY,
        NEC_POST_CONTENTS_IS_EMPTY,
        NEC_FAIL_USER_NOT_EXIST,
        NEC_FAIL_DEV_USER_CANNOT_UNLINK,
        NEC_FAIL_INVALID_PRODUCT_ID,
        NEC_FAIL_RESET_PURSHASE_COUNT,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_WHILE_PLAYING_GAME,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_WHILE_MATCHING_PVP,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_WHILE_PLAYING_WARFARE,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_WHILE_PLAYING_DIVE,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_DURING_WORLDMAP_MISSION,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_WHILE_CHANGING_EQUIP_STAT,
        NEC_FAIL_CANNOT_CLEAR_WEALTH_WHILE_NEGOTIATIONING,
        NEC_DB_FAIL_DELETE_USER_WEALTH,
        NEC_DB_FAIL_UPDATE_LEAVE_DATA,
        NEC_FAIL_INACCESSIBLE_USER,
        NEC_FAIL_INACCESSIBLE_IP,
        NEC_FAIL_FRIEND_SEARCH_RESULT_EMPTY,
        NEC_DB_FAIL_COMPANY_BUFF_UPSERT,
        NEC_FAIL_SYSTEM_CONTENTS_BLOCK,
        NEC_FAIL_WARFARE_INVALID_DECK_INDEX,
        NEC_FAIL_WARFARE_RECOVER_DECK_IS_ALIVE,
        NEC_FAIL_WARFARE_GAME_CANNOT_START_BY_DUPLICATE_TILE_INDEX,
        NEC_DB_FAIL_WARFARE_RECOVER_UNIT,
        NEC_DB_FAIL_SELECT_RECEIPT,
        NEC_CHEAT_FAIL_CANNOT_SEND_INDEFINITE_POST,
        NEC_DB_FAIL_EMOTICON_COLLECTION_GET,
        NEC_DB_FAIL_EMOTICON_COLLECTION_SET,
        NEC_DB_FAIL_EMOTICON_PRESET_DATA_GET,
        NEC_DB_FAIL_EMOTICON_PRESET_DATA_SET,
        NEC_FAIL_EMOTICON_COLLECTION_GET,
        NEC_FAIL_EMOTICON_COLLECTION_SET,
        NEC_FAIL_EMOTICON_PRESET_DATA_GET,
        NEC_FAIL_EMOTICON_PRESET_DATA_SET,
        NEC_FAIL_INVALID_EMOTICON_PRESET_DATA,
        NEC_FALE_EMOTICON_PRESET_DATA_EXIST,
        NEC_FAIL_EMOTICON_CHANGE_INVALID_INDEX,
        NEC_FAIL_EMOTICON_INVALID_ID,
        NEC_FAIL_EMOTICON_INVALID_TYPE,
        NEC_FAIL_EMOTICON_PRESET_ALREADY_SET,
        NEC_FAIL_UPDATE_PRESET_DB,
        NEC_DB_FAIL_UPDATE_EMOTICON_COLLECTION,
        NEC_FAIL_EMOTICON_ALREADY_EXIST_ID,
        NEC_FAIL_EMOTICON_PRESET_DUPLECATE_SETTING,
        NEC_FAIL_EMOTICON_BUY_COUNT_INVALID,
        NEC_FAIL_NOT_EXIST_EMOTICON_PRESET_ID,
        NEC_DB_FAIL_WARFARE_GUEST_HISTORY_SELECT,
        NEC_DB_FAIL_WARFARE_GUEST_HISTORY_UPDATE,
        NEC_FAIL_DIVE_SYNC_DATA_NULL,
        NEC_FAIL_CITY_DATA_NULL,
        NEC_DB_FAIL_CONTRACT_COUNT_UPSERT,
        NEC_FAIL_CONTRACT_LIMIT_COUNT,
        NEC_DB_FAIL_WARFARE_CREATE_UNIT,
        NEC_FAIL_CONTRACT_INVALID_COND_COUNT,
        NEC_FAIL_CONTRACT_GRADE_CORRECTION,
        NEC_FAIL_GET_DUNGEON_HISTORY_FAILED,
        NEC_DB_FAIL_DIVE_RECORD_DATA,
        NEC_DB_FAIL_UPDATE_DIVE_RESET,
        NEC_FAIL_DIVE_NOT_EXIST_NEXT_RESET_TICKET_CHARGE_DATE,
        NEC_FAIL_NEGOTIATION_INVALID_BOSS_SELECTION,
        NEC_FAIL_NEGOTIATION_INVALID_MATERIAL,
        NEC_FAIL_NEGOTIATION_INVALID_MATERIAL_COUNT,
        NEC_FAIL_NEGOTIATION_NOT_ENOUGH_MATERIAL,
        NEC_FAIL_NEGOTIATION_INVALID_SYSTEM_SETTING,
        NEC_FAIL_NEGOTIATION_EARNING_EXP_IS_OVER,
        NEC_FAIL_NEGOTIATION_EXP_LOYALTY_FULL,
        NEC_FAIL_SHIP_IS_SEIZED,
        NEC_FAIL_UNIT_IS_SEIZED,
        NEC_FAIL_LEADER_UNIT_IS_SEIZED,
        NEC_FAIL_MATERIAL_UNIT_IS_SEIZED,
        NEC_FAIL_SEIZED_SHIP_IN_DECK,
        NEC_FAIL_SEIZED_UNIT_IN_DECK,
        NEC_FAIL_WARFARE_NOT_ENOUGH_SUPPLEMENT,
        NEC_FAIL_INACCESSIBLE_COUNTRY,
        NEC_FAIL_WARFARE_UPDATE_SUPPLY_USE_COUNT,
        NEC_FAIL_WARFARE_CREATE_RECOVER_UNIT,
        NEC_FAIL_WARFARE_MAPPING_STAGE_TEMPLET_NOT_EXIST,
        NEC_FAIL_ASYNC_PVP_DEFENCE_DECK_NOT_EXIST,
        NEC_FAIL_ASYNC_PVP_DEFENCE_DECK_NOT_MODIFIED,
        NEC_FAIL_DECK_HAS_EMPTY_SLOT,
        NEC_FAIL_UPDATE_DEFENCE_DECK,
        NEC_FAIL_ASYNC_PVP_LOAD_DB_DATA,
        NEC_FAIL_FRIEND_ACCEPT_ALREADY_RELATED,
        NEC_FAIL_ITEM_INSUFFICIENT_COUNT,
        NEC_DB_FAIL_ACCOUNT_CHANGE_NICKNAME,
        NEC_FAIL_ACCOUNT_INVALID_NICKNAME_SAME,
        NEC_FAIL_ASYNC_PVP_CANNOT_FOUND_TARGET,
        NEC_FAIL_ASYNC_PVP_TARGET_SCORE_CHANGED,
        NEC_FAIL_LEADER_BOARD_INVALID_REQUEST,
        NEC_FAIL_ASYNC_PVP_MANUAL_PLAY_DISABLE,
        NEC_FAIL_ASYNC_PVP_TARGET_NOT_FOUND,
        NEC_FAIL_ASYNC_PVP_TARGET_OPERATION_POWER_CHANGED,
        NEC_FAIL_PROFILE_DB_UPDATE_ASYNC_PVP_VALUES,
        NEC_FAIL_ASYNC_PVP_DB_UPDATE_DEFENCE_RESULT,
        NEC_DB_FAIL_ASYNC_PVP_CHEAT_SCORE,
        NEC_FAIL_CHEAT_STAGE_CLEAR_UPDATE_DB,
        NEC_FAIL_CREAFT_MOLD_DATE_EXPIRED,
        NEC_FAIL_INVALID_GAME_DATA,
        NEC_DB_FAIL_READ_RETURNING_USER_STATE,
        NEC_DB_FAIL_UPDATE_RETURNING_USER_STATE,
        NEC_FAIL_CREATE_STAGE_HISTORY,
        NEC_FAIL_FIND_STAGE_HISTORY,
        NEC_FAIL_INVALID_STAGE_PLAY_DATE,
        NEC_FAIL_OVER_STAGE_LIMIT,
        NEC_DB_FAIL_UPSERT_STAGE_HISTORY_PLAY,
        NEC_DB_FAIL_UPDATE_STAGE_HISTORY_RESTORE,
        NEC_FAIL_UPDATE_STAGE_HISTORY_PLAY,
        NEC_FAIL_UPDATE_STAGE_HISTORY_RESTORE,
        NEC_FAIL_IRRECOVERABLE_STAGE,
        NEC_FAIL_RESTORE_COUNT,
        NEC_FAIL_EXIST_PLAY_COUNT,
        NEC_FAIL_INVALID_DUNGEON_PLAY_TYPE,
        NEC_FAIL_RETURNING_STATE_NOT_EXIST,
        NEC_FAIL_INVALID_RETURNING_DURATION,
        NEC_FAIL_INVALID_ITEM_COUNT,
        NEC_DB_FAIL_READ_CONTRACT,
        NEC_DB_FAIL_READ_CONTRACT_BONUS_GROUP,
        NEC_FAIL_EVENT_INVALID_ID,
        NEC_FAIL_EVENT_INVALID_REWARD_ID,
        NEC_FAIL_EVENT_BINGO_CREATE,
        NEC_FAIL_EVENT_NOT_ALL_CLEARED,
        NEC_FAIL_EVENT_ALREADY_CLEARED,
        NEC_FAIL_EVENT_ALREADY_REWARD_INDEX,
        NEC_FAIL_EVENT_END,
        NEC_FAIL_EVENT_BINGO_ALREADY_MARKED,
        NEC_FAIL_EVENT_BINGO_ALREADY_REWARD,
        NEC_FAIL_EVENT_BINGO_NOT_ENOUGH_MILEAGE,
        NEC_FAIL_EVENT_BINGO_NOT_ENOUGH_ITEM,
        NEC_FAIL_EVENT_BINGO_INVALID_DATA,
        NEC_FAIL_EVENT_BINGO_NO_EXIST_UPDATABLE_REWARD,
        NEC_DB_FAIL_EVENT_BINGO_SELECT,
        NEC_DB_FAIL_EVENT_BINGO_INSERT,
        NEC_DB_FAIL_EVENT_BINGO_MARK_UPDATE,
        NEC_DB_FAIL_EVENT_BINGO_REWARD_UPDATE,
        NEC_FAIL_INVALID_PLAY_COUNT,
        NEC_FAIL_UNRESTORABLE_STAGE_ID,
        NEC_FAIL_MAKE_RETURN_MISC_ITEM_DATA,
        NEC_FAIL_CONTRACT_INVALID_REQUEST,
        NEC_FAIL_CONTRACT_WARFARE_NOT_CLEARED,
        NEC_FAIL_CONTRACT_CLOSED,
        NEC_FAIL_CONTRACT_FREE_CHANCE_DISABLE,
        NEC_FAIL_CONTRACT_FREE_CHANCE_NOT_EXIST,
        NEC_DB_FAIL_UPDATE_CONTRACT_BONUS_GROUP,
        NEC_FAIL_SELECTABLE_CONTRACT_POOL_CHANGE_COUNT_OVER,
        NEC_FAIL_SELECTABLE_CONTRACT_POOL_IS_EMPTY,
        NEC_FAIL_REWARD_MULITIPLY_OVER_MAX,
        NEC_FAIL_REWARD_MULTIPLY_OVER_DAILY_ENTER_LIMIT,
        NEC_FAIL_CANNOT_USE_TICKET_WHEN_FREE_CHANCE_REMAINED,
        NEC_FAIL_CANNOT_USE_MONEY_WHEN_FREE_CHANCE_REMAINED,
        NEC_FAIL_CANNOT_USE_MONEY_WHEN_TICKET_REMAINED,
        NEC_FAIL_INVALID_LOGIN_REQUEST_MOBILE_DATA_NOT_EXIST,
        NEC_FAIL_RECONNECT_INVALID_KEY,
        NEC_FAIL_RECONNECT_PRESENCE_NOT_FOUND,
        NEC_FAIL_UNIT_ENHANCE_INVALID_FEED_EXP,
        NEC_FAIL_REWARD_MULTIPLY_NOT_AVAILABLE,
        NEC_FAIL_FIND_SHARD_DATA,
        NEC_FAIL_CONTRACT_INVALID_COST_TYPE,
        NEC_DB_FAIL_CHANGE_BACKGROUND,
        NEC_DB_FAIL_BACKGROUND_SELECT,
        NEC_FAIL_INVALID_SET_OPTION_ID,
        NEC_DB_FAIL_SET_OPTION_UPDATE,
        NEC_FAIL_NOT_EXIST_SET_OPTION,
        NEC_FAIL_POST_READ_COUNT,
        NEC_FAIL_ALREADY_APPLY_SET_OPTION,
        NEC_FAIL_INSUFFICENT_LIMIT_BREAK,
        NEC_FAIL_BUY_SHOP_SUBSCRIPTION_REMAINDATE,
        NEC_FAIL_NPT_GAME_SHIP_SKILL_ACK_NO_SLEEP,
        NEC_FAIL_CHINA_EVALUATION_SERVER_ONLY,
        NEC_DB_FAIL_DELETE_MISC_ITEM_DATA,
        NEC_DB_FAIL_SELECT_ACHIEVE_POINT,
        NEC_DB_FAIL_UPDATE_TOTAL_PAYMENT,
        NEC_FAIL_CONTRACT_TOTAL_USE_COUNT_IS_OVER,
        NEC_FAIL_CONTRACT_DAILY_USE_COUNT_IS_OVER,
        NED_FAIL_SHADOW_PALACE_INVALID_MAIN_ID,
        NED_FAIL_SHADOW_PALACE_DOING,
        NED_FAIL_SHADOW_PALACE_DUNGEON_NOT_MATCHED,
        NED_FAIL_SHADOW_PALACE_CANNOT_FOUND_NEXT_DUNGEON,
        NED_DB_FAIL_SHADOW_PALACE_INITIALIZE,
        NED_DB_FAIL_SHADOW_PALACE_UPDATE,
        NED_FAIL_SHADOW_PALACE_NOT_ENOUGH_LIFE,
        NED_FAIL_SHADOW_PALACE_MULTIPLY_CLEAR_DUNGEON,
        NEC_FAIL_LEADERBOARD_INVALID_REQUEST,
        NEC_FAIL_GUILD_ALREADY_JOINED,
        NEC_FAIL_GUILD_INVALID_GUILD_UID,
        NEC_FAIL_GUILD_INVALID_MEMBER_UID,
        NEC_FAIL_GUILD_INVALID_GRADE,
        NEC_FAIL_GUILD_CREATION_INVALID_UID,
        NEC_FAIL_GUILD_CREATION_INVALID_NAME,
        NEC_FAIL_GUILD_CREATION_USER_LEVEL,
        NEC_FAIL_BACKEND_NETWORK,
        NEC_FAIL_GUILD_CREATION_CREATE_DB_DATA,
        NEC_FAIL_GUILD_UPDATE_USER_DATA,
        NEC_FAIL_GUILD_CREATION_UPDATE_STATE,
        NEC_FAIL_GUILD_CREATION_DUPLICATED_NAME,
        NEC_FAIL_GUILD_NOT_A_MEMBER,
        NEC_FAIL_GUILD_INVITE_DATA_NOT_FOUND,
        NEC_FAIL_GUILD_INVITE_USER_IN_OTHER_GUILD,
        NEC_FAIL_GUILD_CLOSING_DB_FAIL,
        NEC_FAIL_GUILD_REMOVE_MEMBER_DB_FAIL,
        NEC_FAIL_GUILD_SET_GRADE_INVALID_TARGET,
        NEC_FAIL_GUILD_SET_GRADE_INVALID_VALUE,
        NEC_FAIL_GUILD_SET_GRADE_MAX_STAFF_COUNT,
        NEC_FAIL_GUILD_BAN_INVALID_TARGET,
        NEC_FAIL_GUILD_MASTER_MIGRATION_INVALID_TARGET,
        NEC_FAIL_GUILD_MASTER_MIGRATION_INVALID_GUILD_STATE,
        NEC_FAIL_GUILD_MASTER_NOT_FOUND,
        NEC_FAIL_GUILD_MASTER_MIGRATION_DB_FAIL,
        NEC_FAIL_GUILD_MEMBER_GREETING_DB_FAILE,
        NEC_FAIL_GUILD_MASTER_MIGRATION_INVALID_TARGET_GRADE,
        NEC_FAIL_GUILD_ATTENDANCE_DB_FAIL,
        NEC_FAIL_MARQUEE_ADD_FAIL,
        NEC_FAIL_MARQUEE_ADD_FAIL_ALREADY_EXIST,
        NEC_FAIL_MARQUEE_CANCEL_FAIL_NOT_EXIST_INDEX,
        NEC_FAIL_MARQUEE_SELECT_FAIL,
        NED_FAIL_INVALID_TEAM_TYPE,
        NEC_DB_FAIL_SURVEY_INIT,
        NEC_FAIL_SURVEY_COMPLETE,
        NEC_FAIL_GUILD_MAX_REQUEST_COUNT,
        NEC_FAIL_GUILD_MAX_MEMBER_COUNT,
        NEC_FAIL_GUILD_MAX_REQUEST_RECEIVE_COUNT,
        NEC_FAIL_GUILD_MAX_INVITE_COUNT,
        NEC_FAIL_GUILD_ALREADY_JOIN_REQUESTED,
        NEC_FAIL_GUILD_ALREADY_INVITED,
        NEC_FAIL_GUILD_NOT_JOIN_REQUESTED,
        NEC_FAIL_GUILD_JOIN_DISABLED,
        NEC_FAIL_GUILD_JOIN_REQUEST_DB_FAIL,
        NEC_FAIL_GUILD_LOAD_JOIN_REQUEST_DB_FAIL,
        NEC_FAIL_GUILD_ACCEPT_NO_PERMISSION,
        NEC_FAIL_GUILD_CLOSE_INVALID_STATE,
        NEC_FAIL_GUILD_JOIN_REQUEST_EXIST,
        NEC_FAIL_GUILD_ATTENDANCE_DUPLICATE_REQUEST,
        NEC_FAIL_GUILD_NOT_ENOUGH_GRADE,
        NEC_FAIL_GUILD_NOT_ENOUGH_UNION_POINT,
        NEC_FAIL_GUILD_BUFF_STILL_ACTIVATING,
        NEC_FAIL_EVENT_DECK_ALREADY_USE_UNIT,
        NEC_FAIL_EVENT_DECK_ALREADY_USE_SHIP,
        NEC_FAIL_EVENT_DECK_ALREADY_USE_EQUIP,
        NEC_FAIL_EVENT_DECK_ALREADY_USE_OPERATOR,
        NEC_FAIL_FIERCE_SEASON_OUT,
        NEC_FAIL_FIERCE_GAME_PERIOD_OUT,
        NEC_FAIL_FIERCE_REWARD_PERIOD_OUT,
        NEC_FAIL_FIERCE_GOT_DAILY_REWARD,
        NEC_FAIL_FIERCE_ALREADY_GOT_REWARD,
        NEC_FAIL_FIERCE_DAILY_REWARD_UPDATE_FAILED,
        NEC_FAIL_FIERCE_ENTER_LIMIT,
        NEC_FAIL_FIERCE_INIT_FAIL,
        NEC_FAIL_FIERCE_INVALID_ID,
        NEC_FAIL_FIERCE_INVALID_POINT_REWARD_ID,
        NEC_FAIL_FIERCE_INVALID_POINT_REWARD_GROUP_ID,
        NEC_FAIL_FIERCE_BOSS_NOT_EXISTS,
        NEC_FAIL_FIERCE_BOSS_RESET_FAILED,
        NEC_FAIL_FIERCE_INVALID_BOSS_ID,
        NEC_FAIL_FIERCE_INVALID_BOSS_GROUP_ID,
        NEC_FAIL_FIERCE_SETUP_FAILED,
        NEC_FAIL_FIERCE_PROFILE_NOT_EXISTS,
        NEC_FAIL_FIERCE_UPDATE_BOSS,
        NEC_FAIL_FIERCE_INSUFFICIENT_RANK_REWARD_CONDITION,
        NEC_FAIL_FIERCE_INSUFFICIENT_POINT_REWARD_CONDITION,
        NEC_FAIL_FIERCE_IS_NOT_ACTIVATED,
        NEC_FAIL_FIERCE_NO_MORE_RANK_REWARD,
        NEC_DB_FAIL_FIERCE_UPDATE_RANK_REWARD_GOTTEN,
        NEC_DB_FAIL_FIERCE_UPDATE_POINT_REWARD_GOTTEN,
        NEC_DB_FAIL_FIERCE_UPDATE_PLAY_COUNT,
        NEC_DB_FAIL_FIERCE_INSERT_OBJECT_HISTORY,
        NEC_DB_FAIL_FIERCE_UPDATE_DAILY_REWARD,
        NEC_FAIL_GET_USER_PROFILE_FAILED,
        NEC_FAIL_PROFILE_DB_UPDATE_SELFIFRAME,
        NEC_FAIL_SELFIFRAME_NOT_EXIST_ID,
        NEC_FAIL_CHAT_INITIALIZE_DB,
        NEC_FAIL_CHAT_GET_DATA,
        NEC_FAIL_GUILD_INVALID_HEADER,
        NEC_FAIL_GUILD_INVALID_JOIN_TYPE,
        NEC_FAIL_GUILD_PENALTY_TIME_DB_UPDATE,
        NEC_FAIL_GUILD_JOIN_DISABLE_PENALTY,
        NEC_FAIL_GUILD_TARGET_MEMBER_LOGGED_OUT_SO_LONG,
        NEC_FAIL_EQUIP_PROFILE_CAN_NOT_FIND,
        NEC_FAIL_GUILD_NOTICE_UPDATE_COOLDOWN,
        NEC_FAIL_GUILD_PRIVATE_DB_LOADING_FAIL,
        NEC_FAIL_GUILD_PRIVATE_DB_UPDATE_FAIL,
        NEC_FAIL_GUILD_INVALID_DONATION_ID,
        NEC_FAIL_GUILD_INVALID_WELFARE_ID,
        NEC_FAIL_GUILD_DONATION_DAILY_LIMIT,
        NEC_FAIL_GUILD_DONATION_JOIN_DATE_LIMIT,
        NEC_FAIL_GUILD_INVALID_EXP_DELTA,
        NEC_FAIL_GUILD_EXP_UPDATE_FAIL,
        NEC_FAIL_GUILD_LEVEL_UPDATE_FAIL,
        NEC_FAIL_GUILD_PRIVATE_DB_FAIL,
        NEC_FAIL_GUILD_DATA_NOT_EXISTS,
        NEC_FAIL_GUILD_INVALID_CATEGORY,
        NEC_FAIL_MENTORING_MENTOR_ALREADY_BEING,
        NEC_FAIL_MENTORING_INVALID_CANDIDATE,
        NEC_FAIL_MENTORING_INVALID_REWARD_INVITE_COUNT,
        NEC_FAIL_MENTORING_SEASON_OUT,
        NEC_FAIL_MENTORING_CANNOT_FIND_REWARD_TEMPLET,
        NEC_FAIL_MENTORING_INSUFFICIENT_MISSION_COMPLETE_COUNT,
        NEC_FAIL_MENTORING_ALREADY_RECEIVED_MENTOR_REWARD,
        NEC_FAIL_MENTORING_OVER_INVITATION_LIMIT_COUNT,
        NEC_FAIL_MENTORING_OVER_MENTEE_BELONG_COUNT,
        NEC_FAIL_MENTORING_GET_RECOMMEND_LIST,
        NEC_FAIL_MENTORING_KEYWORD_EMPTY,
        NEC_FAIL_MENTORING_NO_MORE_INVITE_REWARD,
        NEC_FAIL_MENTORING_MENTEE_NOT_EXISTS,
        NEC_FAIL_MENTORING_MENTOR_NOT_EXISTS,
        NEC_FAIL_MENTORING_RESET_INTVERAL_TIME_REST,
        NEC_FAIL_MENTORING_MENTEE_CATNOT_DELETE,
        NEC_FAIL_MENTORING_INVALID_IDENTITY,
        NEC_FAIL_MENTORING_INVALID_MENTOR_QUALIFIED,
        NEC_FAIL_MENTORING_INVALID_MENTEE_QUALIFIED,
        NEC_FAIL_MENTORING_PROMOTE_GRADUATE_TO_MENTOR,
        NEC_FAIL_MENTORING_MENTEE_ONLY_POSSIBLE,
        NEC_FAIL_MENTORING_MENTOR_ONLY_POSSIBLE,
        NEC_FAIL_MENTORING_MENTOR_ALREADY_INVITE_MENTEE,
        NEC_DB_FAIL_MENTORING_INSERT,
        NEC_DB_FAIL_MENTORING_UPDATE_STATE,
        NEC_DB_FAIL_MENTORING_DELETE,
        NEC_DB_FAIL_MENTORING_MENTOR_SELECT_BY_MENTEE_COUNT,
        NEC_DB_FAIL_MENTORING_INITIALIZE,
        NEC_DB_FAIL_MENTORING_INSERT_REWARD_HISTORY,
        NEC_DB_FAIL_MENTORING_SELECT,
        NEC_DB_FAIL_MENTORING_MENTOR_SELECT,
        NEC_DB_FAIL_MENTORING_MENTEE_SELECT,
        NEC_DB_FAIL_MENTORING_UPDATE_MISSION_COUNT,
        NEC_DB_FAIL_MENTORING_MENTOR_SELECT_MENTEE_COUNT,
        NEC_DB_FAIL_GUILD_INVALID_REWARD_REQUEST,
        NEC_DB_FAIL_GUILD_BUFF_NOT_AVAILABLE,
        NEC_DB_FAIL_GUILD_BUFF_INSERT,
        NEC_DB_FAIL_GUILD_BUFF_SELECT,
        NEC_DB_FAIL_GUILD_UPDATE_GREETING,
        NEC_DB_FAIL_GUILD_MEMBER_DELETE_GREETING,
        NEC_FAIL_INVALID_SHOP_PRODUCT_PERIOD,
        NEC_FAIL_NOT_OPEN_SHOP_PRODUCT_PERIOD,
        NEC_FAIL_SHOP_PRODUCT_PERIOD_END,
        NEC_DB_FAIL_SHOP_PRODUCT_OPEN_SELECT,
        NEC_DB_FAIL_SHOP_PRODUCT_OPEN_UPSERT,
        NEC_FAIL_EMOTICON_NOT_OWNED,
        NEC_FAIL_CHAT_MESSAGE_UID_NOT_FOUND,
        NEC_FAIL_CHAT_COMPLAIN_DB_INSERT,
        NEC_FAIL_CHAT_COMPLAIN_DUPLICATED,
        NEC_FAIL_GUILD_WELFARE_POINT_LIMIT,
        NEC_FAIL_GUILD_CHAT_COMPLAIN_INVALID_TYPE,
        NEC_FAIL_GUILD_CHAT_COMPLAIN_ALREADY_BLOCKED,
        NEC_FAIL_CHAT_ROOM_UID_NOT_FOUND,
        NEC_FAIL_BLOCK_MUTE_DB_FAIL,
        NEC_FAIL_GUILD_CHAT_BLOCK_MUTE,
        NEC_FAIL_ZLONG_COUPON_INVALID_CODE,
        NEC_FAIL_ZLONG_COUPON_INVALID_CONTENTS_SET,
        NEC_FAIL_ZLONG_COUPON_API_RETURN_ERROR,
        NEC_FAIL_ZLONG_INVALID_ACCOUNT_TYPE,
        NEC_FAIL_ZLONG_COUPON_RESPONSE_FAILED,
        NEC_FAIL_GUILD_RESOURCE_CHANGE_DB_INSERT_FAIL,
        NEC_FAIL_BLOCK_MUTE_UNIT_REVIEW,
        NEC_FAIL_BLOCK_MUTE_USER_PROFILE,
        NEC_FAIL_ZLONG_LOGIN_INVALID_STATUS,
        NEC_FAIL_READERBOARD_FIERCE_INVALID_FIERCEID,
        NEC_FAIL_READERBOARD_FIERCE_INVALID_BOSSID,
        NEC_FAIL_MARKET_REVIEW_DB_LOAD_FAIL,
        NEC_FAIL_MARKET_REVIEW_DB_UPDATE_FAIL,
        NEC_FAIL_COMPANY_BUFF_INVALID_ID,
        NEC_FAIL_COMPANY_BUFF_INVALID_TIME,
        NEC_FAIL_COMPANY_BUFF_ALREADY_EXISTS,
        NEC_FAIL_COMPANY_BUFF_INVALID_CATEGORY,
        NEC_DB_FAIL_COMPANY_BUFF_INSERT,
        NEC_DB_FAIL_CHAT_BLOCK_LIST,
        NEC_DB_FAIL_WORLDMAP_INVALID_LEADER_UID,
        NEC_FAIL_INVALID_MUTE_TYPE,
        NEC_FAIL_GUILD_GREETING_MUTE,
        NEC_FAIL_GUILD_MEMBER_GREETING_MUTE,
        NEC_FAIL_GUILD_NOT_MASTER,
        NEC_FAIL_GUILD_UPDATE_NOTICE,
        NEC_FAIL_GUILD_NOTICE_MUTE,
        NEC_FAIL_NX_MISSION_UPSERT_HISTORY,
        NEC_FAIL_NX_MISSION_SELECT_HISTORY,
        NEC_FAIL_NX_MISSION_SEND_TO_API_SERVER,
        NEC_FAIL_NX_MISSION_UPDATE_TO_API_SERVER,
        NEC_FAIL_NX_MISSION_NO_MORE_REWARD,
        NEC_FAIL_NX_MISSION_CAN_NOT_PLAY,
        NEC_FAIL_CUSTOM_PACKAGE_INVALID_USAGE,
        NEC_FAIL_NX_MISSION_CAN_NOT_COMPLETE,
        NEC_FAIL_GUILD_DUNGEON_INVALID_GUILD_DATA,
        NEC_FAIL_GUILD_DUNGEON_INVALID_DATE_CONDITION,
        NEC_FAIL_GUILD_DUNGEON_DATA_ERROR,
        NEC_FAIL_GUILD_DUNGEON_INVALID_STATE,
        NEC_FAIL_GUILD_DUNGEON_INVALID_PLAYABLE_TIME,
        NEC_FAIL_GUILD_DUNGEON_SESSION_OUT,
        NEC_FAIL_GUILD_DUNGEON_INVALID_SEASON,
        NEC_FAIL_GUILD_DUNGEON_INVALID_SESSION,
        NEC_FAIL_GUILD_DUNGEON_SAESON_TEMPLET,
        NEC_FAIL_GUILD_DUNGEON_SEASON_REWRD_TEMPLE,
        NEC_FAIL_GUILD_DUNGEON_DUNGEON_INFO_TEMPLE,
        NEC_FAIL_GUILD_DUNGEON_SEASON_OUT,
        NEC_FAIL_GUILD_DUNGEON_SEASON_TEMPLET,
        NEC_FAIL_GUILD_DUNGEON_SEASON_ID,
        NEC_FAIL_GUILD_DUNGEON_INVALID_SESSION_DUNGEON_ID,
        NEC_FAIL_GUILD_DUNGEON_INVALID_SEASON_DUNGEON_ID,
        NEC_FAIL_GUILD_DUNGEON_INVALID_ARENA_INDEX,
        NEC_FAIL_GUILD_DUNGEON_ARENA_PLAYING,
        NEC_FAIL_GUILD_DUNGEON_ARENA_OVER_PLAY_COUNT,
        NEC_FAIL_GUILD_DUNGEON_ARENA_MAX_ARTIFACT,
        NEC_FAIL_GUILD_DUNGEON_TICKET_OVER,
        NEC_FAIL_GUILD_DUNGEON_TICKET_MAX,
        NEC_FAIL_GUILD_DUNGEON_TIME_OVER,
        NEC_FAIL_GUILD_DUNGEON_ARENA_INVALID_PLAYER,
        NEC_FAIL_GUILD_DUNGEON_BOSS_INVALID_INDEX,
        NEC_FAIL_GUILD_DUNGEON_BOSS_INVALID_STAGE_ID,
        NEC_FAIL_GUILD_DUNGEON_BOSS_ALL_CLEAR,
        NEC_FAIL_GUILD_DUNGEON_BOSS_INVALID_PLAYER,
        NEC_FAIL_GUILD_DUNGEON_BOSS_PLAYABLE,
        NEC_FAIL_GUILD_DUNGEON_BOSS_INVALID_PACKET,
        NEC_FAIL_GUILD_DUNGEON_BOSS_PLAYING,
        NEC_DB_FAIL_GUILD_DUNGEON_ARENA_START,
        NEC_DB_FAIL_GUILD_DUNGEON_ARENA_END,
        NEC_DB_FAIL_GUILD_DUNGEON_ARENA_END_INVALID_USER,
        NEC_DB_FAIL_GUILD_DUNGEON_BOSS_START,
        NEC_DB_FAIL_GUILD_DUNGEON_BOSS_END,
        NEC_DB_FAIL_GUILD_DUNGEON_BOSS_END_INVALID_USER,
        NEC_DB_FAIL_GUILD_DUNGEON_PLAY_COUNT_SELECT,
        NEC_DB_FAIL_GUILD_DUNGEON_POINT_SELECT,
        NEC_DB_FAIL_GUILD_DUNGEON_SEASON_REWARD_UPDATE,
        NEC_DB_FAIL_GUILD_DUNGEON_INFO_SELECT,
        NEC_FAIL_GUILD_DUNGEON_INVALID_SEASON_REWARD_REQUEST,
        NEC_FAIL_GUILD_DUNGEON_INSUFFICIENT_PLAY_COUNT,
        NEC_FAIL_GUILD_DUNGEON_INSUFFICIENT_POINT,
        NEC_FAIL_GUILD_DUNGEON_EXISTS_PREVIOUS_REWARD,
        NEC_FAIL_GUILD_DUNGEON_SESSION_ALREADY_REWARD,
        NEC_FAIL_GUILD_DUNGEON_INVALID_REWARD_REQ,
        NEC_FAIL_GUILD_DUNGEON_SESSION_REWARD_UPDATE,
        NEC_FAIL_GUILD_DUNGEON_GUILD_SESSION_HISTORY,
        NEC_FAIL_EVENT_PASS_INIT,
        NEC_FAIL_EVENT_PASS_SEASON_OUT,
        NEC_FAIL_EVENT_PASS_NOT_ENOUGH_DAILY_MISSION_QUOTA,
        NEC_FAIL_EVENT_PASS_CAN_NOT_REWARD_RECEIVE,
        NEC_FAIL_EVENT_PASS_UPDATE_REWARD_LEVEL,
        NEC_FAIL_EVENT_PASS_UPDATE_TOTAL_EXP,
        NEC_FAIL_EVENT_PASS_INSUFFICIENT_MISSION_COMPLETE_COUNT,
        NEC_FAIL_EVENT_PASS_COMPLETE_FINAL_DAILY_MISSION,
        NEC_FAIL_EVENT_PASS_COMPLETE_FINAL_WEEKLY_MISSION,
        NEC_FAIL_EVENT_PASS_MISSION_GET_LIST,
        NEC_FAIL_EVENT_PASS_MISSION_GET_GROUP_DATA,
        NEC_FAIL_EVENT_PASS_MISSION_RETRY_DISABLE,
        NEC_FAIL_EVENT_PASS_RETRY_MISSION,
        NEC_FAIL_EVENT_PASS_CAN_NOT_RESET_MISSION,
        NEC_FAIL_EVENT_PASS_INVALID_MISSION_ID,
        NEC_FAIL_EVENT_PASS_GET_RANDOM_MISSION,
        NEC_FAIL_EVENT_PASS_UPDATE_CORE_PASS_GOTTEN,
        NEC_FAIL_EVENT_PASS_ALREADY_PURCHASE_CORE_PASS,
        NEC_FAIL_EVENT_PASS_CAN_NOT_PROCESS_MISSION,
        NEC_FAIL_EVENT_PASS_RESET_MISSION,
        NEC_FAIL_EVENT_PASS_ADD_EXP,
        NEC_FAIL_OPERATOR_NOT_ENOUGH_MATERIAL,
        NEC_FAIL_OPERATOR_INVALID_SKILL_ID,
        NEC_FAIL_OPERATOR_INVALID_UNIT_ID,
        NEC_FAIL_OPERATOR_INVALID_UNIT_UID,
        NEC_DB_FAIL_OPERATOR_DATA,
        NEC_DB_FAIL_INSERT_OPERATOR,
        NEC_FAIL_CUSTOM_PACKAGE_INVALID_SELECTION_DATA,
        NEC_FAIL_MISSION_UPDATE,
        NEC_FAIL_MISSION_MAX_TIMES,
        NEC_FAIL_INVALID_GUILD_GROUP_ID,
        NEC_FAIL_GUILD_PERSONAL_BUFF_ALREADY_ACTIVATING,
        NEC_FAIL_NX_MISSION_NOT_REGISTED,
        NEC_FAIL_EVENT_PASS_MAX_RETRY_COUNT,
        NEC_FAIL_EVENT_PASS_NO_PRESENT_MISSION,
        NEC_FAIL_EVENT_PASS_NOT_DONATE_MISSION,
        NEC_FAIL_MISSION_EMPTY_COMPLETE_REWARD,
        NEC_DB_FAIL_SHADOW_PALACE_UPDATE_REWARD_MULTIPLY,
        NEC_FAIL_SHADOW_PALACE_ALREADY_USE_REWARD_MUTILPY,
        NEC_DB_FAIL_SHADOW_PALACE_UPSERT,
        NEC_FAIL_EVENT_PASS_IS_NOT_ENABLE,
        NEC_FAIL_GUILD_DUNGEON_CHEAT_INVALID_REQUEST,
        NEC_FAIL_GUILD_DUNGEON_ARTIFACT_TEMPLET,
        NEC_FAIL_GUILD_DUNGEON_CHEAT_INVALID_ARTIFACT_INDEX,
        NEC_FAIL_SHOP_TARGET_ITEM_IS_NOT_SOLD_OUT,
        NEC_FAIL_GUILD_TRANSLATE_MESSAGE_NOT_FOUND,
        NEC_FAIL_GUILD_TRANSLATE_MESSAGE_NOT_INITIALIZED,
        NEC_FAIL_GUILD_TRANSLATE_MESSAGE_API_EXCEPTION,
        NEC_FAIL_GUILD_DUNGEON_LOG_ROOM_UID_NOT_FOUND,
        NEC_FAIL_NEXON_PC_INVALID_AUTH_LEVEL,
        NEC_FAIL_NEXON_PC_INVALID_AGE,
        NEC_FAIL_NEXON_PC_FORCE_SHUTDOWN,
        NEC_FAIL_NEXON_PC_OPTIONAL_SHUTDOWN,
        NEC_FAIL_NEXON_PC_NGS_LOGIN_FAILED,
        NEC_FAIL_EQUIP_PRESET_MAX_COUNT,
        NEC_FAIL_EQUIP_PRESET_INVALID_NAME,
        NEC_FAIL_EQUIP_PRESET_INVALID_REQUEST_TYPE,
        NEC_FAIL_EQUIP_PRESET_INVALID_ADD_COUNT,
        NEC_FAIL_EQUIP_PRESET_INVALID_PRESET_INDEX,
        NEC_FAIL_EQUIP_PRESET_INVALID_PRESET_TYPE,
        NEC_FAIL_EQUIP_PRESET_INVALID_EQUIP_POSITION,
        NEC_FAIL_EQUIP_PRESET_INVALID_EQUIP_TYPE,
        NEC_FAIL_EQUIP_PRESET_INVALID_UNIT_DATA,
        NEC_FAIL_EQUIP_PRESET_INVALID_UNIT_TEMPLT,
        NEC_FAIL_EQUIP_PRESET_INVALID_UNIT_TYPE,
        NEC_FAIL_EQUIP_PRESET_INVALID_UNIT_EQUIP_UIDS,
        NEC_FAIL_EQUIP_PRESET_INVALID_EQUIP_COUNT,
        NEC_FAIL_EQUIP_PRESET_UPDATE_EQUIP_DATA,
        NEC_FAIL_EQUIP_PRESET_DUPLICATE_EQUIP_UID,
        NEC_DB_FAIL_CREATE_EQUIP_ITEM,
        NEC_FAIL_PLAYING_OTHER_GAME,
        NEC_FAIL_PRIVATE_PVP_SENDER_ALREADY_ON_MATCHING,
        NEC_FAIL_PRIVATE_PVP_TARGET_ALREADY_ON_MATCHING,
        NEC_FAIL_PRIVATE_PVP_TARGET_NOT_FOUND,
        NEC_FAIL_ROUTE_MESSAGE_TARGET_NOT_FOUND,
        NEC_DB_FAIL_EQUIP_PRESET_DATA_SELECT,
        NEC_DB_FAIL_EQUIP_PRESET_MAX_COUNT_UPDATE,
        NEC_DB_FAIL_EQUIP_PRESET_UPDATE,
        NEC_SHOP_DAY_OF_WEEK_MITMATCHED,
        NEC_FAIL_EQUIP_OPTION_INVALID,
        NEC_DB_FAIL_EQUIP_OPTION_SELECT,
        NEC_DB_FAIL_EQUIP_OPTION_UPSERT,
        NEC_FAIL_ACCESSING_UNOPENED_TAG,
        NEC_FAIL_NETWORK_INVALID_PACKET_ID,
        NEC_FAIL_SESSION_DISCONNECTED,
        NEC_FAIL_PRIVATE_PVP_WAITING_OTHER_INVITATION,
        NEC_FAIL_PRIVATE_PVP_INVALID_TARGET_USER_UID,
        NEC_FAIL_GUILD_INVALID_LEVEL,
        NEC_FAIL_GUILD_MAX_LEVEL,
        NEC_FAIL_NEXON_NGS_BANISHED,
        NEC_FAIL_UNDER_MAINTENANCE,
        NEC_FAIL_SHUTDOWN_PLAYTIME_DB_UPDATE_FAILED,
        NEC_FAIL_OPENTAG_CLOSED,
        NEC_FAIL_OPENTAG_SHOP_ITEM,
        NEC_FAIL_PRIVATE_PVP_NOT_IN_GAME_ROOM,
        NEC_FAIL_PRIVATE_PVP_STATE_NOT_JOINED,
        NEC_FAIL_PRIVATE_PVP_STATE_NOT_LOADING,
        NEC_FAIL_PRIVATE_PVP_OTHER_PLAYER_NOT_FOUND,
        NEC_FAIL_EVENT_RACE_TEMPLET_NULL,
        NEC_FAIL_EVENT_RACE_INVALID_RACEINDEX,
        NEC_FAIL_EVENT_RACE_INVALID_RACE_TIME,
        NEC_FAIL_EVENT_RACE_ALREADY_SELECT_TEAM,
        NEC_FAIL_EVENT_RACE_INVALID_DATA,
        NEC_FAIL_EVENT_RACE_INSUFFICIENT_TICKET,
        NEC_FAIL_EVENT_RACE_INVALID_LIEN,
        NEC_FAIL_EVENT_RACE_HISTORY_INVALID_ID,
        NKM_FAIL_EVENT_RACE_INVALID_TEAM_ID,
        NEC_DB_FAIL_EVENT_RACE_TEAM_SELECT,
        NEC_DB_FAIL_EVENT_RACE_TEAM_UPSERT,
        NEC_DB_FAIL_EVENT_RACE_SELECT,
        NEC_DB_FAIL_EVENT_RACE_UPSERT,
        NEC_FAIL_LEADER_BOARD_GET_DATA_FAILED,
        NEC_FAIL_OFFICE_FAIL,
        NEC_FAIL_OFFICE_ROOM_NOT_FOUND,
        NEC_FAIL_OFFICE_ROOM_INTERIOR_ID_NOT_FOUND,
        NEC_FAIL_OFFICE_ROOM_FURNITURE_OVERLAP,
        NEC_FAIL_OFFICE_ROOM_FURNITURE_OUT_OF_BOUND,
        NEC_FAIL_OFFICE_ROOM_FURNITURE_ROOM_FULL,
        NEC_FAIL_OFFICE_DUPLICATE_FURNITURE_UID,
        NEC_FAIL_OFFICE_ROOM_FURNITURE_TYPE_MISMATCH,
        NEC_FAIL_OFFICE_ROOM_FURNITURE_NOT_FOUND,
        NEC_FAIL_OFFICE_INTERIOR_NOT_DECO,
        NEC_FAIL_SKIP_NOT_SUPPORTED,
        NEC_FAIL_NEED_DUNGEON_CLEAR,
        NEC_FAIL_NEED_GOLD_MEDAL,
        NEC_FAIL_UPDATE_UNIT_LOYALTY,
        NEC_FAIL_PVP_INSUFFICIENT_OPEN_SCORE,
        NEC_FAIL_STAGE_TEMPLET_EMPTY,
        NEC_FAIL_RECHARGE_ETERNIUM_OFFLINE_AMOUNT,
        NEC_FAIL_INVALID_SKIP_COUNT,
        NEC_FAIL_ITEM_CHARGER_INVALID_COOLTIME,
        NEC_FAIL_LEAGUE_PVP_LOAD_DB_DATA,
        NEC_FAIL_LEAGUE_PVP_RANKING_INVALID_RANGE_REQUEST,
        NEC_FAIL_LEAGUE_PVP_RANKING_INVALID_TYPE_REQUEST,
        NEC_FAIL_ACCOUNT_BLOCK_NO_REASON,
        NEC_FAIL_ACCOUNT_BLOCK_ABUSING_BUG,
        NEC_FAIL_ACCOUNT_BLOCK_BAD_MANNERS,
        NEC_FAIL_ACCOUNT_BLOCK_CHEATING,
        NEC_FAIL_ACCOUNT_BLOCK_FRAUD,
        NEC_FAIL_ACCOUNT_BLOCK_HACKING,
        NEC_FAIL_ACCOUNT_BLOCK_PHISING,
        NEC_FAIL_ACCOUNT_BLOCK_PROMOTE,
        NEC_FAIL_ACCOUNT_BLOCK_TERM_SERVICE,
        NEC_DB_FAIL_ACCOUNT_BLOCK_SELECT,
        NEC_RANK_PVP_ALREADY_OPENED,
        NEC_RANK_PVP_DB_UPDATE_FAIL,
        NEC_LEAGUE_PVP_ALREADY_OPENED,
        NEC_LEAGUE_PVP_DB_UPDATE_FAIL,
        NEC_FAIL_DRAFT_PVP_INVALID_STATE,
        NEC_FAIL_DRAFT_PVP_GLOBAL_BAN_COMPLETED,
        NEC_FAIL_DRAFT_PVP_GLOBAL_BAN_DUPLICATED,
        NEC_FAIL_DRAFT_PVP_UNIT_FULL_ON_STEP,
        NEC_FAIL_DRAFT_PVP_BANISHED_UNIT_ID,
        NEC_FAIL_DRAFT_PVP_OTHER_PLAYER_PICKED_UNIT,
        NEC_FAIL_DRAFT_PVP_OPPONENT_BAN_DUPLICATED,
        NEC_FAIL_DRAFT_PVP_OPPONENT_BAN_INVALID_INDEX,
        NEC_FAIL_DRAFT_PVP_MAIN_SHIP_DUPLICATED,
        NEC_FAIL_DRAFT_PVP_OPERATOR_DUPLICATED,
        NEC_FAIL_DRAFT_PVP_LEADER_UNIT_DUPLICATED,
        NEC_FAIL_DRAFT_PVP_LEADER_INVALID_INDEX,
        NEC_FAIL_EQUIP_PRIVATE,
        NEC_FAIL_DRAFT_PVP_NOT_ENOUGH_UNIT_COUNT,
        NEC_FAIL_DRAFT_PVP_NOT_ENOUGH_SHIP_COUNT,
        NEC_FAIL_DRAFT_PVP_INVALID_TIME,
        NEC_LEAGUE_PVP_WEEKLY_REWARD_NOT_SUPPORTED,
        NEC_FAIL_PROFILE_DB_UPDATE_LEAGUE_PVP_VALUES,
        NEC_FAIL_OFFICE_INVALID_SECTION_ID,
        NEC_FAIL_OFFICE_INVALID_ROOM_ID,
        NEC_FAIL_OFFICE_ALREADY_OPEND_SECTION_ID,
        NEC_FAIL_OFFICE_ALREADY_OPEND_ROOM_ID,
        NEC_FAIL_OFFICE_NOT_OPEND_SECTION,
        NEC_FAIL_OFFICE_NOT_OPEND_ROOM,
        NEC_FAIL_OFFICE_INVALID_ROOM_NAME,
        NEC_DB_FAIL_OFFICE_SECTION_SELECT,
        NEC_DB_FAIL_OFFICE_ROOM_SELECT,
        NEC_DB_FAIL_OFFICE_SECTION_OPEN,
        NEC_DB_FAIL_OFFICE_ROOM_OPEN,
        NEC_DB_FAIL_DIVE_PLAYER_UPDATE_DIVE_STORM,
        NEC_DB_FAIL_DIVE_CLEAR_UPDATE,
        NEC_FAIL_DIVE_NOT_FOUND_COORDINATION,
        NEC_DB_FAIL_KAKAO_MISSION_DATA_READ,
        NEC_DB_FAIL_KAKAO_MISSION_DATA_UPDATE,
        NEC_FAIL_KAKAO_MISSION_OUT_OF_DATE,
        NEC_FAIL_KAKAO_MISSION_NETWORK_FAIL,
        NEC_FAIL_USER_BIRTH_DAY_UPDATE,
        NEC_DB_FAIL_USER_BIRTH_DAY_SELECT,
        NEC_FAIL_RECALL_NOT_AVAILABLE,
        NEC_FAIL_RECALL_ALREADY_USED,
        NEC_FAIL_RECALL_HISTORY_ADD,
        NEC_FAIL_RECALL_PERIOD_EXPIRED,
        NEC_FAIL_RECALL_INVALID_ACCQUIRE_TIME,
        NEC_FAIL_UNIT_UNEQUIP_ITEM,
        NEC_DB_FAIL_UNIT_SELECT_REG_DATE,
        NEC_DB_FAIL_RECALL_HISTORY_INIT,
        NEC_FAIL_RECALL_TEMPLET_EMPTY,
        NEC_FAIL_SHOP_DECORATION_ALREADY_OWNED,
        NEC_FAIL_SHOP_FURNITURE_OWNED_MAX,
        NEC_FAIL_OFFICE_SET_UNIT_NOT_CHANGED,
        NEC_FAIL_OFFICE_SET_UNIT_MAX_LIMIT,
        NEC_FAIL_OFFICE_SET_UNIT_UID_DUPLICATED,
        NEC_DB_FAIL_OFFICE_SET_UNIT,
        NEC_FAIL_OFFICE_FURNITURE_INVLID_ID,
        NEC_FAIL_OFFICE_FURNITURE_NOT_REMAINS,
        NEC_FAIL_OFFICE_INTERIOR_INVALID_ID,
        NEC_FAIL_OFFICE_INTERIOR_NOT_EXIST,
        NEC_FAIL_OFFICE_INTERIOR_INVALID_TYPE,
        NEC_DB_FAIL_OFFICE_FURNITURE_SELECT,
        NEC_DB_FAIL_OFFICE_FURNITURE_UPSERT,
        NEC_DB_FAIL_UPDATE_INTERIOR_ITEM,
        NEC_OFFICE_FURNITURE_INVALID_UID,
        NEC_DB_FAIL_DELTE_FURNITURE,
        NEC_DB_FAIL_OFFICE_SELECT_UNIT,
        NEC_DB_FAIL_OFFICE_DELETE_UNIT,
        NEC_DB_FAIL_OFFICE_UNIT_UPDATE,
        NEC_FAIL_OFFICE_UNIT_NOT_IN_ROOM,
        NEC_FAIL_OFFICE_UNIT_HEART_IS_NOT_FULL,
        NEC_FAIL_OFFICE_UNIT_LOYALTY_IS_FULL,
        NEC_FAIL_OFFICE_PROFILE_NOT_FOUND,
        NEC_FAIL_PROFILE_DB_UPDATE_OFFICE_OPEN,
        NEC_FAIL_OFFICE_POST_ALREADY_SEND_TARGET,
        NEC_FAIL_OFFICE_POST_DAILY_LIMIT_FULL,
        NEC_DB_FAIL_OFFICE_POST_UPDATE,
        NEC_FAIL_POST_INVALID_OFFICE_POST_UID,
        NEC_FAIL_OFFICE_POST_READ_COUNT,
        NEC_DB_FAIL_SELECT_OFFICE_POST,
        NEC_DB_FAIL_UPDATE_OFFICE_POST,
        NEC_FAIL_OFFICE_POST_RECV_DAILY_LIMIT,
        NEC_FAIL_OFFICE_POST_NOT_EXIST,
        NEC_FAIL_OFFICE_POST_INVALID_COUNT,
        NEC_FAIL_OFFICE_POST_SEND_DAILY_LIMIT,
        NEC_DB_FAIL_INSERT_OFFICE_POST,
        NEC_FAIL_OFFICE_POST_MYSELF,
        NEC_FAIL_OFFICE_NO_VISITOR_AVAILABLE,
        NEC_FAIL_OFFICE_POST_NO_FRIENDSHIP_EXIST,
        NEC_DB_FAIL_WECHAT_COUPON_DATA_READ,
        NEC_DB_FAIL_WECHAT_COUPON_DATA_UPDATE,
        NEC_FAIL_WECHAT_COUPON_NOT_IN_SERVICE,
        NEC_FAIL_WECHAT_COUPON_INVALID_TEMPLET_ID,
        NEC_FAIL_WECHAT_COUPON_OUT_OF_DATE,
        NEC_FAIL_WECHAT_COUPON_NETWORK_FAIL,
        NEC_FAIL_EVENT_BINGO_INVALID_TILE_INDEX,
        NEC_FAIL_ZLONG_COUPON_RESPONSE_ERROR,
        NEC_DB_FAIL_ZLONG_COUPON_RESPONSE,
        NEC_FAIL_ZLONG_COUPON_INVALID_STATE,
        NEC_FAIL_FIERCE_INVALID_DUNGEON_ID,
        NEC_FAIL_OFFICE_UNIT_DELETE_IN_ROOM,
        NEC_FAIL_PRIVATE_CHAT_INITIALIZE_DB,
        NEC_DB_FAIL_ZLONG_CBT_PAYMENT_SELECT,
        NEC_FAIL_ZLONG_CBT_PAYMENT_INVALID_STATE,
        NEC_FAIL_ZLONG_CBT_PAYMENT_NO_REWARD,
        NEC_FAIL_ZLONG_CBT_PAYMENT_OUT_OF_DATE,
        NEC_FAIL_ZLONG_CBT_PAYMENT_RECEIVED,
        NEC_FAIL_DECK_NAME_INVALID,
        NEC_DB_FAIL_DECK_NAME_UPDATE,
        NEC_FAIL_PHASE_MODE_REWARD_MULTIPLY_DISABLE,
        NEC_DB_FAIL_GUILD_DUNGEON_BOSS_SELECT_TOTAL_POINT,
        NEC_FAIL_GUILD_DUNGEON_BOSS_REMAIN_POINT,
        NEC_FAIL_TIME_CHEAT_INVALID_TIME,
        NEC_FAIL_TIME_CHEAT_BRIDGE_SERVER_RESPONSE,
        NEC_DB_FAIL_STAGE_HISTORY_SELECT,
        NEC_DB_FAIL_STAGE_UNLOCK_SELECT,
        NEC_DB_FAIL_STAGE_UNLOCK_INSERT,
        NEC_FAIL_STAGE_UNLOCK_ALREADY_UNLOCKED,
        NEC_FAIL_STAGE_UNLOCKED,
        NEC_DB_FAIL_PHASE_CLEAR_DATA_SELECT,
        NEC_DB_FAIL_PHASE_CLEAR_DATA_UPDATE,
        NEC_FAIL_INVALID_EVENT_DECK_DATA,
        NEC_FAIL_EXTRACT_UNIT_CONDITION,
        NEC_FAIL_CANNOT_EXTRACT_UNIT,
        NEC_DB_FAIL_KILL_COUNT_SELECT,
        NEC_FAIL_KILL_COUNT_INVALID_TEMPLET,
        NEC_FAIL_KILL_COUNT_REWARD_ALREADY_GIVEN,
        NEC_FAIL_KILL_COUNT_INVALID_STEP,
        NEC_FAIL_KILL_COUNT_NOT_ENOUGH_COUNT,
        NEC_DB_FAIL_KILL_COUNT_UPSERT,
        NEC_FAIL_KILL_COUNT_CHEAT_RESET,
        NEC_FAIL_BLOCK_MUTE_ROOM_NAME,
        NEC_FAIL_REARMAMENT_INVALID_ID,
        NEC_FAIL_REARMAMENT_CONDITION_LIMITBREAK,
        NEC_FAIL_REARMAMENT_CONDITION_LEVEL,
        NEC_FAIL_DELETE_EXCLUDE_UNIT,
        NEC_FAIL_KILLCOUNT_REWARD_LOCKED,
        NEC_FAIL_UNIT_MISSION_INVALID_MISSION_ID,
        ENC_DB_FAIL_UNIT_REARMAMENT,
        NEC_FAIL_UNIT_MISSION_NOT_FOUND_UNIT_HISTORY,
        NEC_FAIL_UNIT_MISSION_NOT_ENOUGH_VALUE,
        NEC_DB_FAIL_UNIT_MISSION_UPSERT,
        NEC_FAIL_UNIT_MISSION_INVALID_STEP_ID,
        NEC_DB_FAIL_UNIT_MISSION_SELECT,
        NEC_DB_FAIL_UNIT_ILLUSTRATE_UPSERT,
        NEC_FAIL_UNIT_MISSION_UNSUPPORTED_CONDITION,
        NEC_FAIL_EQUIP_IMPRINT_INVALID_ITEM_TIER,
        NEC_FAIL_EQUIP_IMPRINT_INVALID_ITEM_GRADE,
        NEC_FAIL_EQUIP_IMPRINT_ALREADY_IMPRINTED_UNIT,
        NEC_FAIL_EQUIP_IMPRINT_NOT_EXIST_UNIT,
        NEC_FAIL_EQUIP_IMPRINT_NOT_EQUIP,
        NEC_DB_FAIL_EQUIP_IMPRINT,
        NEC_DB_FAIL_CASTING_VOTE_UNIT_SELECT,
        NEC_DB_FAIL_CASTING_VOTE_SHIP_SELECT,
        NEC_DB_FAIL_CASTING_VOTE_UNIT_UPSERT,
        NEC_DB_FAIL_CASTING_VOTE_SHIP_UPSERT,
        NEC_FAIL_CASTING_VOTE_INVALID_VOTE_COUNT,
        NEC_FAIL_CASTING_VOTE_DUPLICATED_VOTE,
        NEC_FAIL_CASTING_VOTE_INVALID_UNIT_ID,
        NEC_FAIL_EQUIP_UPGRADE_TEMPLET,
        NEC_FAIL_EQUIP_UPGRADE_CONDITION,
        NEC_FAIL_EQUIP_UPGRADE_DATA,
        NEC_FAIL_EQUIP_UPGRADE_MATERIAL,
        NEC_FAIL_EQUIP_UPGRADE_EXP,
        NEC_DB_FAIL_EQUIP_UPGRADE,
        NEC_DB_FAIL_EQUIP_POTENTIAL_OPTION_SELECT,
        NEC_FAIL_EQUIP_NOT_RELIC,
        NEC_FAIL_EQUIP_INVALID_SOCKET_INDEX,
        NEC_FAIL_EQUIP_CREATE_POTENTIAL_OPTION,
        NEC_FAIL_EQUIP_INVALID_POTENTIAL_OPTION_KEY,
        NEC_FAIL_EQUIP_INVALID_WEIGHT_ID,
        NEC_FAIL_EQUIP_NOT_ENOUGH_CHCHANT_LEVEL,
        NEC_FAIL_EQUIP_POTENTIAL_OPTION_LOGICAL_ERROR,
        NEC_DB_FAIL_EQUIP_POTENTIAL_OPTION_UPSERT,
        NEC_FAIL_GAMEBASE_API_NOT_INITIALIZED,
        NEC_FAIL_GAMEBASE_PURCHASE_PARSING_FAIL,
        NEC_FAIL_GAMEBASE_PURCHASE_HEADER_FAIL,
        NEC_FAIL_GAMEBASE_PURCHASE_NOT_INAPP_PRODUCT,
        NEC_FAIL_GAMEBASE_PURCHASE_HISTORY_EXIST,
        NEC_DB_FAIL_GAMEBASE_PURCHASE_UPSERT,
        NEC_DB_FAIL_PURCHASE_HISTORY_UPSERT,
        NEC_FAIL_CUSTOM_PACKAGE_INVALIE_PRODUCT_ID,
        NEC_FAIL_REGISTER_GAME_SERVER_BAN_RESULT_NULL,
        NEC_FAIL_PRIVATE_PVP_INVITATION_DENIED,
        NEC_FAIL_CONSUMER_PACKAGE_ALREADY_PURCHASED,
        NEC_FAIL_CONSUMER_PACKAGE_BUY_CODITION,
        NEC_DB_FAIL_CONSUMER_PACKAGE_DATA,
        NEC_DB_FAIL_CONSUMER_PACKAGE_UPSERT,
        NEC_DB_FAIL_PRIVATE_PVP_HISTORY_SELECT,
        NEC_DB_FAIL_PRIVATE_PVP_HISTORY_UPSERT,
        NEC_FAIL_CONSUMER_PACKAGE_INVALID_REWARD_LEVEL,
        NEC_FAIL_PRIVATE_PVP_GUEST_PLAYING_OTHER_GAME,
        NEC_FAIL_PRIVATE_PVP_GUEST_UNLOCKED_CONTENTS,
        NEC_FAIL_INVALID_SKIP_CONDITION,
        NEC_FAIL_LEAGUE_PVP_SYSTEM_CLOSED,
        NEC_FAIL_PRIVATE_PVP_TARGET_USER_NOT_CONNECTED,
        NEC_FAIL_PRIVATE_PVP_INVALID_DECK_INDEX,
        NEC_FAIL_PRIVATE_PVP_GAME_ALREADY_JOINED,
        NEC_FAIL_OFFICE_PARTY_NO_UNIT_EXIST,
        NEC_FAIL_FRIEND_MY_COUNT_MAX,
        NEC_FAIL_FRIEND_OTHER_COUNT_MAX,
        NEC_FAIL_CONTRACT_REQUEST_COUNT_EXCEED_BONUS,
        NEC_FAIL_FIERCE_INVALID_RESET_COUNT,
        NEC_DB_FAIL_FIERCE_UPDATE_COUNT,
        NEC_DB_FAIL_UPDATE_UNIT_FAVORITE,
        NEC_DB_FAIL_EVENT_BAR_SELECT,
        NEC_DB_FAIL_EVENT_BAR_UPSERT,
        NEC_FAIL_EVENT_BAR_END,
        NEC_FAIL_EVENT_BAR_TEMPLET_NOT_EXIST,
        NEC_FAIL_EVENT_BAR_NO_DAILY_COCKTAIL,
        NEC_FAIL_EVENT_BAR_DAILY_REWARD_END,
        NEC_DB_FAIL_FIERCE_PENALTY_UPSERT,
        NEC_FAIL_FIERCE_PENALTY_BOSS_LEVEL,
        NEC_FAIL_FIERCE_PENALTY_BOSS_GROUP,
        NEC_FAIL_FIERCE_PENALTY_COUNT,
        NEC_FAIL_FIERCE_PENALTY_TYPE,
        NEC_FAIL_FIERCE_PENALTY_DUPLICATE_GROUP,
        NEC_DB_FAIL_CONSUMER_PACKAGE_CHEAT_DELETE,
        NEC_FAIL_ACCOUNT_INVALID_NICKNAME_LENGTH_GLOBAL,
        NEC_FAIL_CONTRACT_DUNGEON_NOT_CLEARED,
        NEC_FAIL_CONTRACT_PHASE_NOT_CLEARED,
        NEC_FAIL_EQUIP_PRESET_INVALID_INDEX_RANGE,
        NEC_FAIL_EQUIP_PRESET_INVALID_INDEX_DUPLICATE,
        NEC_DB_FAIL_EQUIP_PRESET_INDEX_CHANGE,
        NEC_DB_FAIL_OFFICE_PRESET_ROOM,
        NEC_DB_FAIL_OFFICE_PRESET_FURNITURE,
        NEC_DB_FAIL_OFFICE_PRESET_REGISTER,
        NEC_DB_FAIL_OFFICE_PRESET_APPLY,
        NEC_DB_FAIL_OFFICE_PRESET_CHANGE_NAME,
        NEC_DB_FAIL_OFFIFCE_PRESET_MAX_COUNT_UPDATE,
        NEC_DB_FAIL_OFFICE_PRESET_CLEAR,
        NEC_DB_FAIL_OFFICE_PRESET_APPLY_THEME,
        NEC_FAIL_OFFICE_PRESET_INVALID_INDEX,
        NEC_FAIL_OFFICE_PRESET_DATA,
        NEC_FAIL_OFFICE_PRESET_INVALID_NAME,
        NEC_FAIL_OFFICE_PRESET_INVALID_ADD_COUNT,
        NEC_FAIL_OFFICE_PRESET_THEME_TEMPLET,
        NEC_DB_FAIL_CASTING_VOTE_OPERATOR_SELECT,
        NEC_DB_FAIL_CASTING_VOTE_OPERATOR_UPSERT,
        NEC_FAIL_STAGE_NOT_ENTERABLE_DAY_OF_WEEK,
        NEC_FAIL_RAID_ENTERANCE_LIMIT_EXCEED,
        NEC_FAIL_RAID_INVALID_ENTERANCE_ORDER,
        NEC_DB_FAIL_DAILY_CHARGE_TIME_SELECT,
        NEC_FAIL_LIMIT_BREAK_INVALID_COST_ITEMS,
        NEC_DB_FAIL_AD_REWARD_ITEM_SELECT,
        NEC_DB_FAIL_AD_REWARD_ITEM_UPSERT,
        NEC_DB_FAIL_AD_REWARD_INVENTORY_SELECT,
        NEC_DB_FAIL_AD_REWARD_INVENTORY_UPSERT,
        NEC_FAIL_AD_REWARD_NOT_OPEN,
        NEC_FAIL_AD_REWARD_NOT_EXIST_TEMPLET,
        NEC_FAIL_AD_REWARD_NOT_EXIST_DAILY_LIMIT,
        NEC_FAIL_AD_REWARD_REMAIN_WATCH_TIME,
        NEC_FAIL_INVALID_BACKGROUND_INFO,
        NEC_FAIL_DRAFT_PVP_TARGET_NOT_ENOUGH_UNIT_COUNT,
        NEC_FAIL_DRAFT_PVP_TARGET_NOT_ENOUGH_SHIP_COUNT,
        NEC_FAIL_DRAFT_PVP_NOT_EXITS_CASTING_BAN,
        NEC_FAIL_DRAFT_PVP_BANISHED_SHIP,
        NEC_FAIL_DRAFT_PVP_NOT_IN_GAME_ROOM,
        NEC_FAIL_COUPON_ALREADY_USED = 22000,
        NEC_FAIL_COUPON_INVALID_CODE,
        NEC_FAIL_COUPON_EXPIRED,
        NEC_DB_FAIL_COUPON_USE_INSERT,
        NEC_FAIL_PRIVATE_CHAT_INVALID_USER_UID = 22100,
        NEC_FAIL_PRIVATE_CHAT_BLOCK_USER_UID,
        NEC_FAIL_MISSION_OUT_OF_DATE = 22200,
        NEC_FAIL_MISSION_NO_REQUIRE_MISSION_DATA,
        NEC_FAIL_MISSION_NO_REQUIRE_MISSION_TEMPLET,
        NEC_FAIL_MISSION_NOT_ENOUGH_FOR_REWARD,
        NEC_FAIL_MISSION_OPEN_TAG_CLOSED,
        NEC_FAIL_MISSION_NO_MISSION_DATA,
        NEC_FAIL_PVP_ROOM_INVALID_CONFIG = 22300,
        NEC_FAIL_PVP_ROOM_INVALID_USER_STATE,
        NEC_FAIL_PVP_ROOM_INVALID_GAME_STATE,
        NEC_FAIL_PVP_ROOM_INVALID_GAME_INSTANCE,
        NEC_FAIL_PVP_ROOM_NOT_IN_GAME_ROOM,
        NEC_FAIL_PVP_ROOM_INVITATION_ALREADY_SEND,
        NEC_FAIL_PVP_ROOM_NOT_EXIST,
        NEC_FAIL_PVP_ROOM_USER_ALREADY_EXIST,
        NEC_FAIL_PVP_ROOM_MAX_COUNT_EXCEED,
        NEC_FAIL_PVP_ROOM_NOT_HOST_USER,
        NEC_FAIL_PVP_ROOM_NOT_ENOUGH_PLAYER,
        NEC_FAIL_PVP_ROOM_WAITING_JOIN_OTHERS,
        NEC_FAIL_PVP_ROOM_CREATION_FAILED,
        NEC_FAIL_STEAM_HTTPCLIENT_NOT_INITIALZED = 22400,
        NEC_FAIL_STEAM_VERIFY_LOGIN_TOKEN,
        NEC_FAIL_STEAM_LINK_NO_PUBLISHER_CODE,
        NEC_FAIL_STEAM_LINK_INVALID_PUBLISHER_CODE,
        NEC_FAIL_STEAM_LINK_INVALID_PRIVATE_CODE,
        NEC_FAIL_STEAM_LINK_SELECT_USERPROFILE,
        NEC_FAIL_STEAM_LINK_PROCESS_CANCELED,
        NEC_FAIL_STEAM_LINK_NOT_EXIST_TARGET_INFO,
        NEC_FAIL_STEAM_LINK_NOT_CONNECTED_TARGET,
        NEC_FAIL_STEAM_LINK_SAME_PUBLISHER_TYPE,
        NEC_FAIL_STEAM_LINK_ALREADY_LINK_INFO,
        NEC_FAIL_STEAM_LINK_ALREADY_MAPPING_INFO,
        NEC_FAIL_STEAM_LINK_NOT_EXIST_LINK_INFO,
        NEC_DB_FAIL_STEAM_LINK_INSERT,
        NEC_FAIL_STEAM_LINK_TIME_OVER,
        NEC_FAIL_STEAM_LINK_NOT_REQUESTER,
        NEC_FAIL_STEAM_LINK_GUEST_ACCOUNT,
        NEC_DB_FAIL_STEAM_PURCHASE_UPSERT,
        NEC_FAIL_STEAM_VERIFY_PURCHASE,
        NEC_FAIL_STEAM_PURCHASE_HISTORY_EXIST,
        NEC_FAIL_STEAM_VERIFY_STEAM_ID,
        NEC_FAIL_STEAM_INITIALIZE,
        NEC_FAIL_STEAM_ENABLE_OVERLAY,
        NEC_FAIL_TROPHY_FULL = 22500,
        NEC_DB_FAIL_REVENGE_PVP_RESULT = 22600,
        NEC_FAIL_REVENGE_PVP_ALREADY,
        NEC_DB_FAIL_SHIP_MODULE_SELECT = 22700,
        NEC_FAIL_SHIP_LIMITBREAK_ALREADY_LEVEL_OVER,
        NEC_FAIL_SHIP_NOT_EXISTS,
        NEC_FAIL_SHIP_LIMITBREAK_TEMPLET,
        NEC_FAIL_SHIP_LIMITBREAK_LOCKED_CONSUMED_SHIP,
        NEC_FAIL_SHIP_LIMITBREAK_INVALID_CONSUMED_SHIP_ID,
        NEC_DB_FAIL_SHIP_LIMITBREAK,
        NEC_FAIL_SHIP_MODULE_UNLOCK,
        NEC_FAIL_SHIP_INVALID_MODULE_INDEX,
        NEC_FAIL_SHIP_INVALID_MODULE_SLOT_INDEX,
        NEC_FAIL_SHIP_MODULE_SLOT_NULL,
        NEC_FAIL_SHIP_COMMAND_MODULE_TEMPLET,
        NEC_DB_FAIL_MODULE_SLOT_LOCK,
        NEC_FAIL_SHIP_MODULE_SLOT_LOCK_ALL,
        NEC_FAIL_SHIP_MODULE_SLOT_PASSIVE_TARGET,
        NEC_FAIL_SHIP_MODULE_SLOT_STAT_TARGET,
        NEC_DB_FAIL_SHIP_MODULE_SLOT_CHANGE,
        NEC_DB_FAIL_SHIP_MODULE_CANDIDATE_SELECT,
        NEC_FAIL_SHIP_MODULE_CANDIDATE_INVALID_REQUEST,
        NEC_FAIL_SHIP_MODULE_SLOT_NOT_NULL,
        NEC_FAIL_INVALID_TRIM_INTERVAL = 22800,
        NEC_DB_FAIL_TRIM_CLEAR_HISTORY_SELECT,
        NEC_DB_FAIL_TRIM_INTERVAL_SELECT,
        NEC_DB_FAIL_TRIM_INTERVAL_UPDATE,
        NEC_FAIL_TRIM_EVENT_DECK_LIST_SETTING,
        NEC_FAIL_INVAILD_TRIM_ID,
        NEC_FAIL_INVAILD_TRIM_DUNGEON,
        NEC_FAIL_OUT_RANGE_TRIM_LEVEL,
        NEC_FAIL_INVAILD_TRIM_TRY_COUNT,
        NEC_FAIL_INVAILD_TRIM_RETRY_COUNT,
        NEC_FAIL_INVAILD_TRIM_RESTORE_COUNT,
        NEC_FAIL_TRIM_END_PROCESSING,
        NEC_DB_FAIL_UPDATE_TRIM_HISTORY,
        NEC_FAIL_OUT_RANGE_TRIM_INDEX,
        NEC_FAIL_BUG_REPORT_SEND_MAIL = 22900,
        NEC_FAIL_EVENT_COLLECTION_END = 23000,
        NEC_FAIL_EVENT_COLLECTION_INVALID_INDEX_TEMPLET,
        NEC_FAIL_EVENT_COLLECTION_INVALID_MERGE_TEMPLET,
        NEC_FAIL_EVENT_COLLECTION_INVALID_MERGE_GROUP_ID,
        NEC_FAIL_EVENT_COLLECTION_MERGE_RECIPE_TEMPLET,
        NEC_FAIL_EVENT_COLLECTION_MERGE_INVALID_INPUT_VALUE,
        NEC_FAIL_EVENT_COLLECTION_MERGE_NOT_IN_COLLECTION_TEMPLET,
        NEC_FAIL_EVENT_COLLECTION_MERGE_INVALID_INPUT_GROUP_ID,
        NEC_DB_FAIL_DELETE_TROPHY,
        NEC_FAIL_OFFICE_CANNOT_TROPHY_TAKE_HEART,
        NEC_FAIL_SERVICE_TRANSFER_GUEST_ACCOUNT = 23100,
        NEC_FAIL_SERVICE_TRANSFER_NOT_REGIST_CODE,
        NEC_FAIL_SERVICE_TRANSFER_REGIST_CODE_BLOCKED,
        NEC_FAIL_SERVICE_TRANSFER_USER_ALREADY_TRANSFERRED,
        NEC_FAIL_SERVICE_TRANSFER_USED_REGIST_CODE,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_ACCOUNT,
        NEC_FAIL_SERVICE_TRANSFER_ALREADY_RECEIVE_REWARD,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_LINK_STATE,
        NEC_FAIL_SERVICE_TRANSFER_USER_ID,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_USER_DATA,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_TRANSFER_USER_DATA,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_CODE,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_DATA,
        NEC_FAIL_SERVICE_TRANSFER_WRONG_FORMAT_REGIST_CODE,
        NEC_DB_FAIL_SERVICE_TRANSFER_UPDATE_REWARD,
        NEC_DB_FAIL_SERVICE_TRANSFER_UPDATE_REWARD_ACCOUNT,
        NEC_DB_FAIL_SERVICE_TRANSFER_SELECT_VALIDATE,
        NEC_DB_FAIL_SERVICE_TRANSFER_SELECT,
        NEC_DB_FAIL_SERVICE_TRANSFER_TRANSFER_USER_INFO,
        NEC_DB_FAIL_SERVICE_TRANSFER_UPDATE,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_LEVEL_CONDITION,
        NEC_FAIL_SERVICE_TRANSFER_INVALID_PAY_AMOUNT_CONDITION,
        NEC_FAIL_LEAVE_INVALID_PUBLISHER_TYPE = 23200,
        NEC_FAIL_UNIT_TACTIC_ALREADY_MAX_LEVEL = 23300,
        NEC_FAIL_UNIT_TACTIC_INAVLID_BASE_UNIT,
        NEC_DB_FAIL_UNIT_TACTIC_UPDATE,
        NEC_DB_FAIL_UNIT_TACTIC_RETURN_SELECT,
        NEC_FAIL_UNIT_TACTIC_NOT_AVAILABLE,
        NEC_FAIL_FIERCE_INSUFFICIENT_PLAY_COUNT = 23400,
        NEC_DB_FAIL_FAVORITES_STAGE_SELECT = 23500,
        NEC_DB_FAIL_FAVORITES_STAGE_INSERT,
        NEC_DB_FAIL_FAVORITES_STAGE_UPDATE,
        NEC_DB_FAIL_FAVORITES_STAGE_DELETE,
        NEC_FAIL_FAVORITES_STAGE_ID_DUPLICATE,
        NEC_FAIL_FAVORITES_STAGE_COUNT_MAX,
        NEC_FAIL_FAVORITES_STAGE_COUNT_DIFFRENT,
        NEC_FAIL_FAVORITES_STAGE_INVALID_STAGE_ID,
        NEC_DB_FAIL_LAST_PLAY_INFO_SELECT = 23600,
        NEC_DB_FAIL_LAST_PLAY_INFO_UPSERT,
        NEC_FAIL_BACKGROUND_LOCATED = 23800,
        NEC_DB_FAIL_DELETE_OPERATOR,
        NEC_DB_FAIL_UPDATE_OPERATOR_SKILL,
        NEC_DB_FAIL_GUILD_DUNGEON_ARENA_FLAG_UPSERT = 23900,
        NEC_DB_FAIL_GUILD_DUNGEON_ORDER_UPSERT,
        NEC_FAIL_GUILD_DUNGEON_FLAG_INVALID_INDEX,
        NEC_FAIL_GUILD_DUNGEON_ORDER_INVALID_INDEX,
        NEC_FAIL_EVENT_PVP_SEASON_NOT_OPEN = 24000,
        NEC_FAIL_EVENT_PVP_DAYOFWEEK_NOT_OPEN,
        NEC_FAIL_EVENT_PVP_TIME_NOT_OPEN,
        NEC_DB_FAIL_EVENT_PVP_SELECT,
        NEC_DB_FAIL_EVENT_PVP_UPSERT,
        NEC_DB_FAIL_EVENT_PVP_REWARD_SELECT,
        NEC_DB_FAIL_EVENT_PVP_REWARD_UPSERT,
        NEC_FAIL_INVALID_EVENT_PVP_REWARD_INFO,
        NEC_FAIL_EVENT_PVP_ALREADY_REWARDED,
        NEC_FAIL_EVENT_PVP_REWARD_BELOW_STANDARD,
        NEC_FAIL_EVENT_PVP_REWARD_EXPIRATION,
        NEC_FAIL_EVENT_PVP_NOT_MATCHED_REWARD_INFO_TEMPLET,
        NEC_FAIL_EVENT_PVP_MANUAL_PLAY_DISABLE,
        NEC_FAIL_EVENT_PVP_INVALID_REQUEST,
        NEC_FAIL_GUILD_INVALID_DONATION_COUNT = 24100,
        NEC_FAIL_DB_CUSTOM_PICKUP_SELECT = 24200,
        NEC_FAIL_CUSTOM_PICKUP_NEED_TARGET,
        NEC_FAIL_CUSTOM_PICKUP_TEMPLET,
        NEC_FAIL_CUSTOM_PICKUP_INALID_DATA,
        NEC_FAIL_CUSTOM_PICKUP_INALID_UNIT,
        NEC_FAIL_CUSTOM_PICKUP_MAX_COUNT,
        NEC_FAIL_CUSTOM_PICKUP_ALREADY_SELECTED,
        NEC_FAIL_CUSTOM_PICKUP_INVALID_UNIT,
        NEC_FAIL_CUSTOM_PICKUP_DISABLE_COLLECTION,
        NEC_FAIL_CUSTOM_PICKUP_NOT_TARGET,
        NEC_FAIL_CUSTOM_PICKUP_NOT_RETURNING_USER,
        NEC_FAIL_CUSTOM_PICKUP_RETURNING_PERIOD_FINISHED,
        NEC_FAIL_GAMEBASE_MEMBER_RESPONE = 24300,
        NEC_DB_FAIL_UPDATE_GAMEBASE_BLOCK,
        NEC_FAIL_DB_SELECT_RESET_COUNT = 24400,
        NEC_FAIL_DB_UPSERT_RESET_COUNT,
        NEC_FAIL_RESET_COUNT_INVAILD_TEMPLET,
        NEC_FAIL_RESET_COUNT_DECREASE,
        NEC_FAIL_RESET_COUNT_EXPIRED,
        NEC_FAIL_MOLD_NOT_ENOUGH_RESET_COUNT = 24500,
        NEC_FAIL_DIVE_GET_DIVETEMPLET_FAILED = 25600,
        NEC_FAIL_DIVE_INSUFFICIENT_RESOURCE,
        NEC_FAIL_CONTRACT_NOT_RETURNING_USER = 25700,
        NEC_FAIL_UNIT_REACTOR_INVALID_ID = 25800,
        NEC_FAIL_UNIT_REACTOR_OVER_MAX_LEVEL,
        NEC_FAIL_UNIT_REACTOR_INVALID_TEMPLET,
        NEC_FAIL_UNIT_REACTOR_INVALID_SKILL_TEMPLET,
        NEC_FAIL_UNIT_REACTOR_NOT_AVAILABLE,
        NEC_FAIL_UNIT_REACTOR_INVALID_SKILL_CONDITION,
        NEC_DB_FAIL_UNIT_REACTOR_INVALID_LEVEL,
        NEC_FAIL_DEFENCE_DUNGEON_INVALID_TEMPLET = 25900,
        NEC_FAIL_DEFENCE_DUNGEON_NOT_OPENED,
        NEC_FAIL_DEFENCE_DUNGEON_INVALID_DUNGEON_TEMPLET,
        NEC_FAIL_DEFENCE_DUNGEON_INVALID_INTERVAL,
        NEC_FAIL_DEFENCE_DUNGEON_NOT_ENOUGH_COST_ITEM,
        NEC_FAIL_DEFENCE_DUNGEON_NOT_TEAM_DATA,
        NEC_FAIL_DB_DEFENCE_DUNGEON_SELECT,
        NEC_FAIL_DB_DEFENCE_DUNGEON_UPSERT,
        NEC_FAIL_DEFENCE_DUNGEON_RANK_REWARD_INVALID_TEMPLET,
        NEC_FAIL_DEFENCE_PROFILE_NOT_EXISTS,
        NEC_FAIL_DB_DEFENCE_RANK_REWARD_HISTORY_SELECT,
        NEC_FAIL_DB_DEFENCE_RANK_REWARD_HISTORY_UPSERT,
        NEC_FAIL_DEFENCE_RANK_REWARD_NOT_OPENED,
        NEC_FAIL_DEFENCE_RANK_REWARD_ALREADY_GIVEN,
        NEC_FAIL_DEFENCE_DUNGEON_RANK_HAVE_NOT_REWARD_TEMPLET,
        NEC_DB_FAIL_MISC_COLLECTION_SELECT = 26000,
        NEC_DB_FAIL_MISC_COLLECTION_UPDATE,
        NEC_FAIL_MISC_COLLECTION_INVALID_MISC_ID,
        NEC_FAIL_MISC_COLLECTION_REWARD_ALREADY_GIVEN,
        NEC_FAIL_MISC_COLLECTION_NOT_EXISTS_ITEM_HISTORY,
        NEC_FAIL_MISC_COLLECTION_NOT_EXISTS_ITEM,
        NEC_FAIL_MISC_COLLECTION_INVALID_MISC_TYPE,
        NEC_FAIL_MISC_COLLECTION_DEFAULT_COLLECTION,
        NEC_FAIL_POTENTIAL_SOCKET_PRECISION_CHANGE_SYSTEM_NOT_OPEND = 26100,
        NEC_DB_FAIL_SELECT_POTENTIAL_OPTION_CANDIDATE,
        NEC_DB_FAIL_UPSERT_POTENTIAL_OPTION_CANDIDATE,
        NEC_FAIL_REQUEST_POTENTIAL_OPTION_SOCKET_NOT_MATCHED,
        NEC_FAIL_POTENTIAL_OPTION_SOCKET_CHANGE_PRECISION,
        NEC_FAIL_POTENTIAL_OPTION_SOCKET_CANDIDATE_IS_NOT,
        NEC_FAIL_POTENTIAL_OPTION_SOCKET_CANDIDATE_INVALID_CONDITION,
        NEC_FAIL_POTENTIAL_OPTION_SOCKET_CHANGE_LIMIT_COUNT,
        NEC_FAIL_POTENTIAL_OPTION_SOCKET_CHANGE_CREDIT_COST_IS_MAXIMUM,
        NEC_FAIL_TITLE_NO_MISC_ITEM_DATA = 26200,
        NEC_FAIL_TITLE_EXPIRED_TITLE_ITEM,
        NEC_FAIL_TITLE_TEMPLET_FIND_ERROR,
        NEC_DB_FAIL_UPDATE_TITLE_ID,
        NEC_FAIL_TITLE_SYSTEM_CLOSED,
        NEC_FAIL_TITLE_SAME_TITLE_ID,
        NEC_FAIL_POST_TEMPET_NOT_EXIST = 26300,
        NEC_FAIL_EVENT_BET_INVALID_DATA = 26400,
        NKM_FAIL_EVENT_BET_INVALID_TEAM_ID,
        NEC_FAIL_EVENT_BET_ALREADY_SELECT_TEAM,
        NEC_FAIL_EVENT_BET_INVALID_BETINDEX,
        NEC_FAIL_EVENT_BET_INVALID_BET_TIME,
        NEC_FAIL_EVENT_BET_INVALID_BET_COUNT,
        NEC_FAIL_EVENT_BET_OVER_BETTING,
        NEC_FAIL_EVENT_BET_INSUFFICIENT_BET_ITEM,
        NEC_FAIL_EVENT_BET_INVALID_BET_DATA,
        NEC_FAIL_EVENT_BET_MAKE_REWARD,
        NEC_FAIL_EVENT_BET_INVALID_RECORD_TIME,
        NEC_DB_FAIL_EVENT_BET_UPSERT,
        NEC_FAIL_EVENT_BET_CHEAT_INVALID_GRADE,
        NEC_FAIL_USER_ALREADY_HAS_BIRTH_DAY = 26500,
        NEC_DB_FAIL_JUKEBOX_SELECT = 26600,
        NEC_DB_FAIL_CHANGE_JUKEBOX_BGM,
        NEC_FAIL_CHANGE_JUKEBOX_BGM_BY_COOL_TIME,
        NEC_DB_FAIL_TOURNAMENT_DECK_SELECT = 26700,
        NEC_DB_FAIL_TOURNAMENT_DECK_UPSERT,
        NEC_DB_FAIL_PROFILE_UPDATE_TOURNAMENT_DECK,
        NEC_FAIL_TOURNAMENT_INVALID_STATE,
        NEC_FAIL_TOURNAMENT_INVALID_DECK,
        NEC_FAIL_TOURNAMENT_ALREADY_REGISTERD,
        NEC_FAIL_TOURNAMENT_DECK_NOT_EXIST,
        NEC_FAIL_TOURNAMENT_DECK_NOT_MODIFIED,
        NEC_FAIL_TOURNAMENT_INVALID_GROUP,
        NEC_FAIL_TOURNAMENT_INVALID_INDEX,
        NEC_FAIL_TOURNAMENT_INVALID_TEMPLET,
        NEC_FAIL_TOURNAMENT_INVALID_USER_UID,
        NEC_FAIL_TOURNAMENT_WRONG_SLOT_COUNT,
        NEC_DB_FAIL_TOURNAMENT_PREDICION_SELECT,
        NEC_DB_FAIL_TOURNAMENT_PREDICION_UPSERT,
        NEC_FAIL_TOURNAMENT_REPLAY_NOT_EXIST,
        NEC_FAIL_TOURNAMENT_INVALID_ID,
        NEC_FAIL_TOURNAMENT_ALREADY_RECEVED_REWARD,
        NEC_DB_FAIL_TOURNAMENT_REWARD_UPDATE,
        NEC_FAIL_TOURNAMENT_REWARD_RANK,
        NEC_FAIL_TOURNAMENT_REWARD_PREDICATION,
        NEC_FAIL_TOURNAMENT_INVALID_PREDICATION,
        NEC_FAIL_TOURNAMENT_OPERATION_POWER_CONDITION,
        NEC_FAIL_TOURNAMENT_NOT_PLAY,
        NEC_FAIL_TOURNAMENT_INVALID_SLOT_INDEX,
        NEC_FAIL_TOURNAMENT_VOTE_COUNT_IS_ZERO,
        NEC_FAIL_TOURNAMENT_OUT_OF_BETTING_TIME,
        NEC_FAIL_TOURNAMENT_ALREADY_PROCESSING,
        NEC_FAIL_TOURNAMENT_IS_NOT_ENABLE,
        NEC_FAIL_TOURNAMENT_CASTING_VOTE_INVALID_INTERVAL,
        NEC_FAIL_TOURNAMENT_DISABLE_CASTING_VOTE,
        NEC_FAIL_TOURNAMENT_DECK_CONTAIN_BAN_UNIT,
        NEC_FAIL_SURRANDER_INVALID_TIME_CONDITION = 26800,
        NEC_FAIL_PVP_RANK_REWARD_NOT_OPENED = 26900,
        NEC_FAIL_PVP_RANK_REWARD_NO_SEASON_TEMPLET,
        NEC_FAIL_PVP_RANK_REWARD_NO_TEMPLET,
        NEC_FAIL_GUILD_RENAME = 27000,
        NEC_FAIL_GUILD_INVALID_NEW_NAME,
        NEC_FAIL_GUILD_RENAME_SAME_NAME,
        NEC_FAIL_GUILD_RENAME_NO_PERMISSION,
        NEC_FAIL_GUILD_RENAME_CHANGE_COUNT,
        NEC_FAIL_GUILD_RENAME_LIMIT_DAY,
        NEC_FAIL_GUILD_RENAME_INSUFFICIENT_RESOURCE_VALUE,
        NEC_FAIL_GUILD_RENAME_ALREADY_EXISTS_NAME,
        NEC_DB_FAIL_GUILD_RENAME
    }

    public class NKMUserData : ISerializable
    {
        public void Serialize(IPacketStream stream)
        {
            stream.PutOrGetEnum(ref m_eAuthLevel);
            stream.PutOrGet(ref m_UserLevel);
        }
        public NKM_USER_AUTH_LEVEL m_eAuthLevel = NKM_USER_AUTH_LEVEL.NORMAL_USER;

        public int m_UserLevel;

    }
    public enum NKM_USER_AUTH_LEVEL : byte
    {
        // Token: 0x04001277 RID: 4727
        NORMAL_USER = 1,
        // Token: 0x04001278 RID: 4728
        NORMAL_ADMIN,
        // Token: 0x04001279 RID: 4729
        SUPER_USER,
        // Token: 0x0400127A RID: 4730
        SUPER_ADMIN
    }

    public sealed class NKMResetCount : ISerializable
    {
        // Token: 0x0600C9CA RID: 51658 RVA: 0x00088ADD File Offset: 0x00086CDD
        void ISerializable.Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref groupId);
            stream.PutOrGet(ref count);
        }

        // Token: 0x0400BCC6 RID: 48326
        public int groupId;

        // Token: 0x0400BCC7 RID: 48327
        public int count;
    }

    public sealed class NKMUserMobileData : ISerializable
    {
        // Token: 0x06001945 RID: 6469 RVA: 0x000D5E04 File Offset: 0x000D4004
        public void Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref m_MarketId);
            stream.PutOrGet(ref m_Country);
            stream.PutOrGet(ref m_Language);
            stream.PutOrGet(ref m_AuthPlatform);
            stream.PutOrGet(ref m_Platform);
            stream.PutOrGet(ref m_OsVersion);
            stream.PutOrGet(ref m_AdId);
            stream.PutOrGet(ref m_ClientVersion);
        }

        // Token: 0x06001946 RID: 6470 RVA: 0x000D5E74 File Offset: 0x000D4074
        public short GetMarketID()
        {
            string marketId = m_MarketId;
            if (marketId != null)
            {
                if (marketId == "Google Play Store")
                {
                    return 1;
                }
                if (marketId == "Apple App Store")
                {
                    return 2;
                }
                if (marketId == "One Store")
                {
                    return 3;
                }
                if (marketId == "WINDOWS")
                {
                    return 200;
                }
            }
            return 0;
        }

        // Token: 0x06001947 RID: 6471 RVA: 0x00015A23 File Offset: 0x00013C23
        public static string GetMarketStr(short index)
        {
            switch (index)
            {
                case 1:
                    return "Google Play Store";
                case 2:
                    return "Apple App Store";
                case 3:
                    return "One Store";
                default:
                    if (index != 200)
                    {
                        return "Unknown";
                    }
                    return "WINDOWS";
            }
        }

        // Token: 0x06001948 RID: 6472 RVA: 0x000D5ED0 File Offset: 0x000D40D0
        public ClientOsType GetOsType()
        {
            string marketId = m_MarketId;
            if (marketId != null)
            {
                if (marketId == "Google Play Store")
                {
                    return ClientOsType.Android;
                }
                if (marketId == "Apple App Store")
                {
                    return ClientOsType.iOS;
                }
                if (marketId == "One Store")
                {
                    return ClientOsType.Android;
                }
                if (marketId == "Steam" || marketId == "WINDOWS")
                {
                    return ClientOsType.Windows;
                }
            }
            return ClientOsType.Unknown;
        }

        // Token: 0x06001949 RID: 6473 RVA: 0x000D5F34 File Offset: 0x000D4134
        public ClientOsNxLogType GetNxLogOsType()
        {
            string marketId = m_MarketId;
            if (marketId != null)
            {
                if (marketId == "Google Play Store")
                {
                    return ClientOsNxLogType.Android;
                }
                if (marketId == "Apple App Store")
                {
                    return ClientOsNxLogType.iOS;
                }
                if (marketId == "One Store")
                {
                    return ClientOsNxLogType.Android;
                }
                if (marketId == "WINDOWS")
                {
                    return ClientOsNxLogType.Windows;
                }
            }
            return ClientOsNxLogType.Unknown;
        }

        // Token: 0x0600194A RID: 6474 RVA: 0x000D5F8C File Offset: 0x000D418C
        public string GetMarketStrID()
        {
            string marketId = m_MarketId;
            if (marketId != null)
            {
                if (marketId == "Google Play Store")
                {
                    return "GPS";
                }
                if (marketId == "Apple App Store")
                {
                    return "AAS";
                }
                if (marketId == "One Store")
                {
                    return "ONE";
                }
            }
            return string.Empty;
        }

        // Token: 0x0600194B RID: 6475 RVA: 0x000D5FE4 File Offset: 0x000D41E4
        public byte GetAuthPlatformID()
        {
            byte result = 0;
            string authPlatform = m_AuthPlatform;
            if (authPlatform != null)
            {
                if (!(authPlatform == "NexonPlay"))
                {
                    if (!(authPlatform == "KaKao"))
                    {
                        if (!(authPlatform == "NPA"))
                        {
                            if (!(authPlatform == "Nexon.com"))
                            {
                                if (authPlatform == "inner")
                                {
                                    result = 5;
                                }
                            } else
                            {
                                result = 4;
                            }
                        } else
                        {
                            result = 3;
                        }
                    } else
                    {
                        result = 2;
                    }
                } else
                {
                    result = 1;
                }
            }
            return result;
        }

        // Token: 0x0600194C RID: 6476 RVA: 0x000D6054 File Offset: 0x000D4254
        public string GetPlatformStrID()
        {
            string platform = m_Platform;
            if (platform != null)
            {
                if (platform == "Android")
                {
                    return "A";
                }
                if (platform == "IPhonePlayer")
                {
                    return "I";
                }
            }
            return string.Empty;
        }

        // Token: 0x0600194D RID: 6477 RVA: 0x000D6098 File Offset: 0x000D4298
        public string GetPlatformStrIDForNGSM()
        {
            string platform = m_Platform;
            if (platform != null)
            {
                if (platform == "Android")
                {
                    return "AOS";
                }
                if (platform == "IPhonePlayer")
                {
                    return "IOS";
                }
            }
            return string.Empty;
        }

        // Token: 0x0600194E RID: 6478 RVA: 0x000D60DC File Offset: 0x000D42DC
        public string GetCountryCode()
        {
            string country = m_Country;
            if (country != null && (country == "KO_KR" || country == "Korea"))
            {
                return "KR";
            }
            return m_Country;
        }

        // Token: 0x040011F0 RID: 4592
        public const string NxPcMarketId = "WINDOWS";

        // Token: 0x040011F1 RID: 4593
        public static readonly NKMUserMobileData DevDefault = new NKMUserMobileData
        {
            m_MarketId = "DevDefault",
            m_Country = "DevDefault",
            m_Language = "DevDefault",
            m_AuthPlatform = "DevDefault",
            m_Platform = "DevDefault",
            m_OsVersion = "DevDefault",
            m_AdId = "DevDefault",
            m_ClientVersion = "DevDefault"
        };

        // Token: 0x040011F2 RID: 4594
        public string m_MarketId;

        // Token: 0x040011F3 RID: 4595
        public string m_Country;

        // Token: 0x040011F4 RID: 4596
        public string m_Language;

        // Token: 0x040011F5 RID: 4597
        public string m_AuthPlatform;

        // Token: 0x040011F6 RID: 4598
        public string m_Platform;

        // Token: 0x040011F7 RID: 4599
        public string m_OsVersion;

        // Token: 0x040011F8 RID: 4600
        public string m_AdId;

        // Token: 0x040011F9 RID: 4601
        public string m_ClientVersion;
    }

    public enum ClientOsNxLogType
    {
        // Token: 0x040011E7 RID: 4583
        Unknown,
        // Token: 0x040011E8 RID: 4584
        iOS,
        // Token: 0x040011E9 RID: 4585
        Android,
        // Token: 0x040011EA RID: 4586
        Windows,
        // Token: 0x040011EB RID: 4587
        XBox,
        // Token: 0x040011EC RID: 4588
        PlayStation,
        // Token: 0x040011ED RID: 4589
        Nintendo,
        // Token: 0x040011EE RID: 4590
        MacOs,
        // Token: 0x040011EF RID: 4591
        Linux
    }

    public enum ClientOsType
    {
        // Token: 0x040011E2 RID: 4578
        Unknown,
        // Token: 0x040011E3 RID: 4579
        Android,
        // Token: 0x040011E4 RID: 4580
        iOS,
        // Token: 0x040011E5 RID: 4581
        Windows
    }
}
