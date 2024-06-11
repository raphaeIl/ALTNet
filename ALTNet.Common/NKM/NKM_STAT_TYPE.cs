using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x020004C7 RID: 1223
	public enum NKM_STAT_TYPE : short
	{
		// Token: 0x040023C3 RID: 9155
		[CountryDescription("없음", CountryCode.KOR)]
		NST_RANDOM = -1,
		// Token: 0x040023C4 RID: 9156
		[CountryDescription("체력", CountryCode.KOR)]
		NST_HP,
		// Token: 0x040023C5 RID: 9157
		[CountryDescription("공격력", CountryCode.KOR)]
		NST_ATK,
		// Token: 0x040023C6 RID: 9158
		[CountryDescription("방어력", CountryCode.KOR)]
		NST_DEF,
		// Token: 0x040023C7 RID: 9159
		[CountryDescription("치명타율", CountryCode.KOR)]
		NST_CRITICAL,
		// Token: 0x040023C8 RID: 9160
		[CountryDescription("명중율", CountryCode.KOR)]
		NST_HIT,
		// Token: 0x040023C9 RID: 9161
		[CountryDescription("회피율", CountryCode.KOR)]
		NST_EVADE,
		// Token: 0x040023CA RID: 9162
		[CountryDescription("체력 회복율", CountryCode.KOR)]
		NST_HP_REGEN_RATE,
		// Token: 0x040023CB RID: 9163
		[CountryDescription("치명타 피해 증가율", CountryCode.KOR)]
		NST_CRITICAL_DAMAGE_RATE,
		// Token: 0x040023CC RID: 9164
		[CountryDescription("치명타 저항율", CountryCode.KOR)]
		NST_CRITICAL_RESIST,
		// Token: 0x040023CD RID: 9165
		[CountryDescription("치명타 피해 증가 저항율", CountryCode.KOR)]
		NST_CRITICAL_DAMAGE_RESIST_RATE,
		// Token: 0x040023CE RID: 9166
		[CountryDescription("피해 감소율", CountryCode.KOR)]
		NST_DAMAGE_REDUCE_RATE,
		// Token: 0x040023CF RID: 9167
		[CountryDescription("이동속도 증가율", CountryCode.KOR)]
		NST_MOVE_SPEED_RATE,
		// Token: 0x040023D0 RID: 9168
		[CountryDescription("공격속도 증가율", CountryCode.KOR)]
		NST_ATTACK_SPEED_RATE,
		// Token: 0x040023D1 RID: 9169
		[CountryDescription("스킬 쿨타임 감소율", CountryCode.KOR)]
		NST_SKILL_COOL_TIME_REDUCE_RATE,
		// Token: 0x040023D2 RID: 9170
		[CountryDescription("상태이상 저항율", CountryCode.KOR)]
		NST_CC_RESIST_RATE,
		// Token: 0x040023D3 RID: 9171
		[CountryDescription("vs카운터에게 주는 피해 증가", CountryCode.KOR)]
		NST_UNIT_TYPE_COUNTER_DAMAGE_RATE,
		// Token: 0x040023D4 RID: 9172
		[CountryDescription("vs카운터에게 받는 피해 감소", CountryCode.KOR)]
		NST_UNIT_TYPE_COUNTER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023D5 RID: 9173
		[CountryDescription("vs솔저에게 주는 피해 증가", CountryCode.KOR)]
		NST_UNIT_TYPE_SOLDIER_DAMAGE_RATE,
		// Token: 0x040023D6 RID: 9174
		[CountryDescription("vs솔저에게 받는 피해 감소", CountryCode.KOR)]
		NST_UNIT_TYPE_SOLDIER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023D7 RID: 9175
		[CountryDescription("vs메카닉에게 주는 피해 증가", CountryCode.KOR)]
		NST_UNIT_TYPE_MECHANIC_DAMAGE_RATE,
		// Token: 0x040023D8 RID: 9176
		[CountryDescription("vs메카닉에게 받는 피해 감소", CountryCode.KOR)]
		NST_UNIT_TYPE_MECHANIC_DAMAGE_REDUCE_RATE,
		// Token: 0x040023D9 RID: 9177
		[CountryDescription("vs스트라이커에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_STRIKER_DAMAGE_RATE,
		// Token: 0x040023DA RID: 9178
		[CountryDescription("vs스트라이커에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_STRIKER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023DB RID: 9179
		[CountryDescription("vs레인저에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_RANGER_DAMAGE_RATE,
		// Token: 0x040023DC RID: 9180
		[CountryDescription("vs레인저에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_RANGER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023DD RID: 9181
		[CountryDescription("vs스나이퍼에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_SNIPER_DAMAGE_RATE,
		// Token: 0x040023DE RID: 9182
		[CountryDescription("vs스나이퍼에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_SNIPER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023DF RID: 9183
		[CountryDescription("vs디펜더에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_DEFFENDER_DAMAGE_RATE,
		// Token: 0x040023E0 RID: 9184
		[CountryDescription("vs디펜더에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_DEFFENDER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023E1 RID: 9185
		[CountryDescription("vs서포터에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_SUPPOERTER_DAMAGE_RATE,
		// Token: 0x040023E2 RID: 9186
		[CountryDescription("vs서포터에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_SUPPOERTER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023E3 RID: 9187
		[CountryDescription("vs시즈에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_SIEGE_DAMAGE_RATE,
		// Token: 0x040023E4 RID: 9188
		[CountryDescription("vs시즈에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_SIEGE_DAMAGE_REDUCE_RATE,
		// Token: 0x040023E5 RID: 9189
		[CountryDescription("vs타워에게 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_TOWER_DAMAGE_RATE,
		// Token: 0x040023E6 RID: 9190
		[CountryDescription("vs타워에게 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_TOWER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023E7 RID: 9191
		[CountryDescription("vs지상유닛에게 주는 피해 증가", CountryCode.KOR)]
		NST_MOVE_TYPE_LAND_DAMAGE_RATE,
		// Token: 0x040023E8 RID: 9192
		[CountryDescription("vs지상유닛에게 받는 피해 감소", CountryCode.KOR)]
		NST_MOVE_TYPE_LAND_DAMAGE_REDUCE_RATE,
		// Token: 0x040023E9 RID: 9193
		[CountryDescription("vs공중유닛에게 주는 피해 증가", CountryCode.KOR)]
		NST_MOVE_TYPE_AIR_DAMAGE_RATE,
		// Token: 0x040023EA RID: 9194
		[CountryDescription("vs공중유닛에게 받는 피해 감소", CountryCode.KOR)]
		NST_MOVE_TYPE_AIR_DAMAGE_REDUCE_RATE,
		// Token: 0x040023EB RID: 9195
		[CountryDescription("장거리 공격으로 받는 피해 감소", CountryCode.KOR)]
		NST_LONG_RANGE_DAMAGE_REDUCE_RATE,
		// Token: 0x040023EC RID: 9196
		[CountryDescription("장거리 공격으로 주는 피해 추가", CountryCode.KOR)]
		NST_LONG_RANGE_DAMAGE_RATE,
		// Token: 0x040023ED RID: 9197
		[CountryDescription("단거리 공격으로 받는 피해 감소", CountryCode.KOR)]
		NST_SHORT_RANGE_DAMAGE_REDUCE_RATE,
		// Token: 0x040023EE RID: 9198
		[CountryDescription("단거리 공격으로 주는 피해 추가", CountryCode.KOR)]
		NST_SHORT_RANGE_DAMAGE_RATE,
		// Token: 0x040023EF RID: 9199
		[CountryDescription("힐 감소율", CountryCode.KOR)]
		NST_HEAL_REDUCE_RATE,
		// Token: 0x040023F0 RID: 9200
		[CountryDescription("방어 관통율", CountryCode.KOR)]
		NST_DEF_PENETRATE_RATE,
		// Token: 0x040023F1 RID: 9201
		[CountryDescription("방어막 강화율", CountryCode.KOR)]
		NST_BARRIER_REINFORCE_RATE,
		// Token: 0x040023F2 RID: 9202
		[CountryDescription("스킬 데미지 강화율", CountryCode.KOR)]
		NST_SKILL_DAMAGE_RATE,
		// Token: 0x040023F3 RID: 9203
		[CountryDescription("스킬 데미지 감소율", CountryCode.KOR)]
		NST_SKILL_DAMAGE_REDUCE_RATE,
		// Token: 0x040023F4 RID: 9204
		[CountryDescription("궁극기 데미지 강화율", CountryCode.KOR)]
		NST_HYPER_SKILL_DAMAGE_RATE,
		// Token: 0x040023F5 RID: 9205
		[CountryDescription("궁극기 데미지 감소율", CountryCode.KOR)]
		NST_HYPER_SKILL_DAMAGE_REDUCE_RATE,
		// Token: 0x040023F6 RID: 9206
		[CountryDescription("침식체에게 주는 피해 증가", CountryCode.KOR)]
		NST_UNIT_TYPE_CORRUPTED_DAMAGE_RATE,
		// Token: 0x040023F7 RID: 9207
		[CountryDescription("침식체에게 받는 피해 감소", CountryCode.KOR)]
		NST_UNIT_TYPE_CORRUPTED_DAMAGE_REDUCE_RATE,
		// Token: 0x040023F8 RID: 9208
		[CountryDescription("리플레이서에게 주는 피해 증가", CountryCode.KOR)]
		NST_UNIT_TYPE_REPLACER_DAMAGE_RATE,
		// Token: 0x040023F9 RID: 9209
		[CountryDescription("리플레이서에게 받는 피해 감소", CountryCode.KOR)]
		NST_UNIT_TYPE_REPLACER_DAMAGE_REDUCE_RATE,
		// Token: 0x040023FA RID: 9210
		[CountryDescription("상성으로 주는 피해 증가", CountryCode.KOR)]
		NST_ROLE_TYPE_DAMAGE_RATE,
		// Token: 0x040023FB RID: 9211
		[CountryDescription("상성으로 받는 피해 감소", CountryCode.KOR)]
		NST_ROLE_TYPE_DAMAGE_REDUCE_RATE,
		// Token: 0x040023FC RID: 9212
		[CountryDescription("성장형 공격력 증가율", CountryCode.KOR)]
		NST_HP_GROWN_ATK_RATE,
		// Token: 0x040023FD RID: 9213
		[CountryDescription("성장형 방어력 증가율", CountryCode.KOR)]
		NST_HP_GROWN_DEF_RATE,
		// Token: 0x040023FE RID: 9214
		[CountryDescription("성장형 회피 증가율", CountryCode.KOR)]
		NST_HP_GROWN_EVADE_RATE,
		// Token: 0x040023FF RID: 9215
		[CountryDescription("광역 피해 감소율", CountryCode.KOR)]
		NST_SPLASH_DAMAGE_REDUCE_RATE,
		// Token: 0x04002400 RID: 9216
		[CountryDescription("디펜더 프로텍트 증가", CountryCode.KOR)]
		NST_DEFENDER_PROTECT_RATE,
		// Token: 0x04002401 RID: 9217
		[CountryDescription("추가 피해 감소율", CountryCode.KOR)]
		NST_DAMAGE_INCREASE_DEFENCE,
		// Token: 0x04002402 RID: 9218
		[CountryDescription("피해 감소 관통율", CountryCode.KOR)]
		NST_DAMAGE_REDUCE_PENETRATE,
		// Token: 0x04002403 RID: 9219
		[CountryDescription("자기 추가 피해 감소율", CountryCode.KOR)]
		NST_DAMAGE_INCREASE_REDUCE,
		// Token: 0x04002404 RID: 9220
		[CountryDescription("자기 피해 감소 관통율", CountryCode.KOR)]
		NST_DAMAGE_REDUCE_REDUCE,
		// Token: 0x04002405 RID: 9221
		[CountryDescription("최대 피해 제한", CountryCode.KOR)]
		NST_DAMAGE_LIMIT_RATE_BY_HP,
		// Token: 0x04002406 RID: 9222
		[CountryDescription("유효 타격 감소", CountryCode.KOR)]
		NST_ATTACK_COUNT_REDUCE,
		// Token: 0x04002407 RID: 9223
		[CountryDescription("피해 내성", CountryCode.KOR)]
		NST_DAMAGE_RESIST,
		// Token: 0x04002408 RID: 9224
		[CountryDescription("배리어가 있는 적에게 공격 피해 감소", CountryCode.KOR)]
		NST_DAMAGE_REDUCE_RATE_AGAINST_BARRIER,
		// Token: 0x04002409 RID: 9225
		[CountryDescription("크리가 아닌 공격 데미지 비율", CountryCode.KOR)]
		NST_NON_CRITICAL_DAMAGE_TAKE_RATE,
		// Token: 0x0400240A RID: 9226
		[CountryDescription("주는 회복량 증가", CountryCode.KOR)]
		NST_HEAL_RATE,
		// Token: 0x0400240B RID: 9227
		[CountryDescription("넉백 저항", CountryCode.KOR)]
		NST_DAMAGE_BACK_RESIST,
		// Token: 0x0400240C RID: 9228
		[CountryDescription("전체 능력치 증가/감소", CountryCode.KOR)]
		NST_MAIN_STAT_RATE,
		// Token: 0x0400240D RID: 9229
		[CountryDescription("주는 피해 증감_Extra", CountryCode.KOR)]
		NST_EXTRA_ADJUST_DAMAGE_DEALT,
		// Token: 0x0400240E RID: 9230
		[CountryDescription("받는 피해 증감_Extra", CountryCode.KOR)]
		NST_EXTRA_ADJUST_DAMAGE_RECEIVE,
		// Token: 0x0400240F RID: 9231
		[CountryDescription("주는 피해 증감", CountryCode.KOR)]
		NST_ATTACK_DAMAGE_MODIFY_G2,
		// Token: 0x04002410 RID: 9232
		[CountryDescription("코스트 반환", CountryCode.KOR)]
		NST_COST_RETURN_RATE,
		// Token: 0x04002411 RID: 9233
		[CountryDescription("보스에게 주는 피해", CountryCode.KOR)]
		NST_ATTACK_VS_BOSS_DAMAGE_MODIFY_G1 = 1000,
		// Token: 0x04002412 RID: 9234
		[CountryDescription("보스에게 받는 피해 감소", CountryCode.KOR)]
		NST_DEFEND_VS_BOSS_DAMAGE_MODIFY_G1,
		// Token: 0x04002413 RID: 9235
		[CountryDescription("공격자 기본기 피해 증폭/감쇄", CountryCode.KOR)]
		NST_ATTACK_ATTACK_DAMAGE_MODIFY_G2 = 2000,
		// Token: 0x04002414 RID: 9236
		[CountryDescription("방어자 기본기 피해 증폭/감쇄", CountryCode.KOR)]
		NST_DEFEND_ATTACK_DAMAGE_MODIFY_G2,
		// Token: 0x04002415 RID: 9237
		[CountryDescription("투쟁 몬스터에게 주는 피해 증가", CountryCode.KOR)]
		NST_ATTACK_VS_SOURCE_CONFLICT_G4 = 4000,
		// Token: 0x04002416 RID: 9238
		[CountryDescription("투쟁 몬스터에게 받는 피해 감소", CountryCode.KOR)]
		NST_DEFEND_VS_SOURCE_CONFLICT_G4,
		// Token: 0x04002417 RID: 9239
		[CountryDescription("안정 몬스터에게 주는 피해 증가", CountryCode.KOR)]
		NST_ATTACK_VS_SOURCE_STABLE_G4,
		// Token: 0x04002418 RID: 9240
		[CountryDescription("안정 몬스터에게 받는 피해 감소", CountryCode.KOR)]
		NST_DEFEND_VS_SOURCE_STABLE_G4,
		// Token: 0x04002419 RID: 9241
		[CountryDescription("변화 몬스터에게 주는 피해 증가", CountryCode.KOR)]
		NST_ATTACK_VS_SOURCE_LIBERAL_G4,
		// Token: 0x0400241A RID: 9242
		[CountryDescription("변화 몬스터에게 받는 피해 감소", CountryCode.KOR)]
		NST_DEFEND_VS_SOURCE_LIBERAL_G4,
		// Token: 0x0400241B RID: 9243
		[CountryDescription("감응으로 인한 효과 증폭(곱연산)", CountryCode.KOR)]
		NST_SOURCE_ALL_RATE_G4 = 4100,
		// Token: 0x0400241C RID: 9244
		[CountryDescription("체력%", CountryCode.KOR)]
		NST_HP_FACTOR = 10000,
		// Token: 0x0400241D RID: 9245
		[CountryDescription("공격력%", CountryCode.KOR)]
		NST_ATK_FACTOR,
		// Token: 0x0400241E RID: 9246
		[CountryDescription("방어력%", CountryCode.KOR)]
		NST_DEF_FACTOR,
		// Token: 0x0400241F RID: 9247
		[CountryDescription("치명타율%", CountryCode.KOR)]
		NST_CRITICAL_FACTOR,
		// Token: 0x04002420 RID: 9248
		[CountryDescription("명중율%", CountryCode.KOR)]
		NST_HIT_FACTOR,
		// Token: 0x04002421 RID: 9249
		[CountryDescription("회피율%", CountryCode.KOR)]
		NST_EVADE_FACTOR,
		// Token: 0x04002422 RID: 9250
		NST_RESERVE01 = 30000,
		// Token: 0x04002423 RID: 9251
		NST_RESERVE02,
		// Token: 0x04002424 RID: 9252
		NST_RESERVE03,
		// Token: 0x04002425 RID: 9253
		NST_RESERVE04,
		// Token: 0x04002426 RID: 9254
		NST_RESERVE05,
		// Token: 0x04002427 RID: 9255
		NST_END
	}
}
