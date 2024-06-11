using System;
using System.Collections.Generic;

namespace NKM
{
	// Token: 0x020003B9 RID: 953
	public static class NKMCommonConst
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x000660D2 File Offset: 0x000642D2
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x000660D9 File Offset: 0x000642D9
		public static int WarfareRecoverItemCost { get; private set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x000660E1 File Offset: 0x000642E1
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x000660E8 File Offset: 0x000642E8
		public static int DiveArtifactReturnItemId { get; private set; }

		//// Token: 0x1700027B RID: 635
		//// (get) Token: 0x060018D4 RID: 6356 RVA: 0x000660F0 File Offset: 0x000642F0
		//// (set) Token: 0x060018D5 RID: 6357 RVA: 0x000660F7 File Offset: 0x000642F7
		//public static NegotiationTemplet Negotiation { get; private set; }

		//// Token: 0x1700027C RID: 636
		//// (get) Token: 0x060018D6 RID: 6358 RVA: 0x000660FF File Offset: 0x000642FF
		//// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00066106 File Offset: 0x00064306
		//public static GuildTemplet Guild { get; private set; }

		//// Token: 0x1700027D RID: 637
		//// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0006610E File Offset: 0x0006430E
		//// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00066115 File Offset: 0x00064315
		//public static int SubscriptionBuyCriteriaDate { get; private set; }

		//// Token: 0x1700027E RID: 638
		//// (get) Token: 0x060018DA RID: 6362 RVA: 0x0006611D File Offset: 0x0006431D
		//// (set) Token: 0x060018DB RID: 6363 RVA: 0x00066124 File Offset: 0x00064324
		//public static NKMOperatorConstTemplet OperatorConstTemplet { get; private set; }

		//// Token: 0x1700027F RID: 639
		//// (get) Token: 0x060018DC RID: 6364 RVA: 0x0006612C File Offset: 0x0006432C
		//// (set) Token: 0x060018DD RID: 6365 RVA: 0x00066133 File Offset: 0x00064333
		//public static GuildDungeonConstTemplet GuildDungeonConstTemplet { get; private set; }

		//// Token: 0x17000280 RID: 640
		//// (get) Token: 0x060018DE RID: 6366 RVA: 0x0006613B File Offset: 0x0006433B
		//public static NKMOfficeConst Office { get; } = new NKMOfficeConst();

		//// Token: 0x17000281 RID: 641
		//// (get) Token: 0x060018DF RID: 6367 RVA: 0x00066142 File Offset: 0x00064342
		//public static NKMDeckConst Deck { get; } = new NKMDeckConst();

		//// Token: 0x17000282 RID: 642
		//// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00066149 File Offset: 0x00064349
		//public static NKMBackgroundConst BackgroundInfo { get; } = new NKMBackgroundConst();

		//// Token: 0x17000283 RID: 643
		//// (get) Token: 0x060018E1 RID: 6369 RVA: 0x00066150 File Offset: 0x00064350
		//public static NKMEquipEnchantMiscConst EquipEnchantMiscConst { get; } = new NKMEquipEnchantMiscConst();

		// Token: 0x04001118 RID: 4376
		public const float m_fDELTA_TIME_FACTOR_1 = 1.1f;

		// Token: 0x04001119 RID: 4377
		public const float m_fDELTA_TIME_FACTOR_2 = 1.5f;

		// Token: 0x0400111A RID: 4378
		public const float m_fDELTA_TIME_FACTOR_05 = 0.6f;

		// Token: 0x0400111B RID: 4379
		public static bool USE_ROLLBACK = false;

		// Token: 0x0400111C RID: 4380
		public static float SUMMON_UNIT_NOEVENT_TIME = 0.5f;

		// Token: 0x0400111D RID: 4381
		public const string ReplayFormatVersion = "RV006";

		// Token: 0x0400111E RID: 4382
		public static int ENHANCE_CREDIT_COST_PER_UNIT = 300;

		// Token: 0x0400111F RID: 4383
		public static float ENHANCE_CREDIT_COST_FACTOR = 0.05f;

		// Token: 0x04001120 RID: 4384
		public static float ENHANCE_EXP_BONUS_FACTOR = 0.05f;

		// Token: 0x04001123 RID: 4387
		public static float DiveRepairHpRate;

		// Token: 0x04001124 RID: 4388
		public static float DiveStormHpRate;

		// Token: 0x0400112E RID: 4398
		public static float OPERATOR_SKILL_STOP_TIME = 1f;

		// Token: 0x0400112F RID: 4399
		public static float OPERATOR_SKILL_DELAY_START_TIME = 1f;

		// Token: 0x04001130 RID: 4400
		public static int EQUIP_PRESET_BASIC_COUNT = 20;

		// Token: 0x04001131 RID: 4401
		public static int EQUIP_PRESET_MAX_COUNT = 100;

		// Token: 0x04001132 RID: 4402
		public static int EQUIP_PRESET_EXPAND_COST_ITEM_ID = 101;

		// Token: 0x04001133 RID: 4403
		public static int EQUIP_PRESET_EXPAND_COST_VALUE = 50;

		// Token: 0x04001134 RID: 4404
		public static int EQUIP_PRESET_NAME_MAX_LENGTH = 15;

		// Token: 0x04001135 RID: 4405
		public static int FeaturedListExhibitCount = 4;

		// Token: 0x04001136 RID: 4406
		public static double FeaturedListTotalPaymentThreshold = 119000.0;

		// Token: 0x04001137 RID: 4407
		public static TimeSpan RECHARGE_TIME;

		// Token: 0x04001138 RID: 4408
		public static int EVENT_RACE_PLAY_COUNT = 3;

		// Token: 0x04001139 RID: 4409
		public static int SkipCostMiscItemId = 3;

		// Token: 0x0400113A RID: 4410
		public static int SkipCostMiscItemCount = 0;

		// Token: 0x0400113B RID: 4411
		public static int EVENT_BET_MAX_COUNT = 100;

		// Token: 0x0400113C RID: 4412
		public static int MaxExtractUnitSelect = 5;

		// Token: 0x0400113D RID: 4413
		public static int ExtractBonusRatePercent_Awaken = 80;

		// Token: 0x0400113E RID: 4414
		public static int ExtractBonusRatePercent_SSR = 20;

		// Token: 0x0400113F RID: 4415
		public static int ExtractBonusRatePercent_SR = 5;

		// Token: 0x04001140 RID: 4416
		public static int RearmamentCostItemCount = 5;

		// Token: 0x04001141 RID: 4417
		public static int RearmamentMaxGrade = 5;

		// Token: 0x04001142 RID: 4418
		public static NKMCommonConst.ImprintMainOptEffect ImprintMainOptEffectWeapon;

		// Token: 0x04001143 RID: 4419
		public static NKMCommonConst.ImprintMainOptEffect ImprintMainOptEffectDefence;

		// Token: 0x04001144 RID: 4420
		public static NKMCommonConst.ImprintMainOptEffect ImprintMainOptEffectAccessary;

		// Token: 0x04001145 RID: 4421
		public static int ImprintCostItemId = 1;

		// Token: 0x04001146 RID: 4422
		public static int ImprintCostItemCount = 300000;

		// Token: 0x04001147 RID: 4423
		public static int ReImprintCostItemId = 1;

		// Token: 0x04001148 RID: 4424
		public static int ReImprintCostItemCount = 500000;

		// Token: 0x04001149 RID: 4425
		public static string ImprintOpenTag = "EQUIP_IMPRINT";

		// Token: 0x0400114A RID: 4426
		public static string ConvertTitle;

		// Token: 0x0400114B RID: 4427
		public static string ConvertMessage;

		// Token: 0x0400114C RID: 4428
		public static string DeleteTitle;

		// Token: 0x0400114D RID: 4429
		public static string DeleteMessage;

		// Token: 0x0400114E RID: 4430
		public static int DropInfoShopLimit = 10;

		// Token: 0x0400114F RID: 4431
		public static int DropInfoWorldMapMissionLimit = 10;

		// Token: 0x04001150 RID: 4432
		public static int DropInfoRaidLimit = 10;

		// Token: 0x04001151 RID: 4433
		public static int DropInfoShadowPalace = 10;

		// Token: 0x04001152 RID: 4434
		public static int DropInfoDiveLimit = 10;

		// Token: 0x04001153 RID: 4435
		public static int DropInfoFiercePointReward = 10;

		// Token: 0x04001154 RID: 4436
		public static int DropInfoRandomMoldBox = 10;

		// Token: 0x04001155 RID: 4437
		public static int DropInfoUnitDismiss = 10;

		// Token: 0x04001156 RID: 4438
		public static int DropInfoUnitExtract = 10;

		// Token: 0x04001157 RID: 4439
		public static int DropInfoMainStreamLimit = 10;

		// Token: 0x04001158 RID: 4440
		public static int DropInfoSupplyLimit = 10;

		// Token: 0x04001159 RID: 4441
		public static int DropInfoDailyLimit = 10;

		// Token: 0x0400115A RID: 4442
		public static int DropInfoSideStoryLimit = 10;

		// Token: 0x0400115B RID: 4443
		public static int DropInfoChallengeLimit = 10;

		// Token: 0x0400115C RID: 4444
		public static int DropInfoCounterCase = 10;

		// Token: 0x0400115D RID: 4445
		public static int DropInfoFieldLimit = 10;

		// Token: 0x0400115E RID: 4446
		public static int DropInfoEventLimit = 10;

		// Token: 0x0400115F RID: 4447
		public static int DropInfoTrimDungeon = 10;

		// Token: 0x04001160 RID: 4448
		public static int DropInfoSubStreamShop = 50;

		// Token: 0x04001161 RID: 4449
		public static float DungeonPaybackRatio = 0.5f;

		// Token: 0x04001162 RID: 4450
		public static int INVENTORY_UNIT_EXPAND_COUNT = 0;

		// Token: 0x04001163 RID: 4451
		public static int INVENTORY_EQUIP_EXPAND_COUNT = 0;

		// Token: 0x04001164 RID: 4452
		public static int INVENTORY_SHIP_EXPAND_COUNT = 0;

		// Token: 0x04001165 RID: 4453
		public static int INVENTORY_OPERATOR_EXPAND_COUNT = 0;

		// Token: 0x04001166 RID: 4454
		public static float[] VALID_LAND_PVE = new float[]
		{
			0.4f,
			0.6f,
			0.8f
		};

		// Token: 0x04001167 RID: 4455
		public static float[] VALID_LAND_PVP = new float[]
		{
			0.4f,
			0.6f,
			0.8f
		};

		// Token: 0x04001168 RID: 4456
		public static float PVE_SUMMON_MIN_POS = 0f;

		// Token: 0x04001169 RID: 4457
		public static float PVP_SUMMON_MIN_POS = 250f;

		// Token: 0x0400116A RID: 4458
		public static float PVP_AFK_WARNING_TIME = 5f;

		// Token: 0x0400116B RID: 4459
		public static float PVP_AFK_AUTO_TIME = 10f;

		// Token: 0x0400116C RID: 4460
		public static HashSet<NKM_GAME_TYPE> PVP_AFK_APPLY_MODE = new HashSet<NKM_GAME_TYPE>();

		// Token: 0x0400116D RID: 4461
		public static int ShipLimitBreakItemCount = 3;

		// Token: 0x0400116E RID: 4462
		public static int ShipModuleReqItemCount = 4;

		// Token: 0x0400116F RID: 4463
		public static int ShipCmdModuleSlotCount = 2;

		// Token: 0x04001170 RID: 4464
		public static int ShipCmdModuleCount = 3;

		// Token: 0x04001171 RID: 4465
		public static float RecallRewardUnitPieceToPoint = 16.67f;

		// Token: 0x04001172 RID: 4466
		public static int MaxStageFavoriteCount = 30;

		// Token: 0x04001173 RID: 4467
		public static int TacticReturnMaxCount = 50;

		// Token: 0x04001174 RID: 4468
		public static string TacticReturnDateString = "DATE_TACTIC_UPDATE_RETURN";

		// Token: 0x04001175 RID: 4469
		public static int ReactorMaxLevel = 5;

		// Token: 0x04001176 RID: 4470
		public static int ReactorMaxReqItemCount = 3;

		// Token: 0x04001177 RID: 4471
		public static float RelicRerollCountFactor = 1.63f;

		// Token: 0x04001178 RID: 4472
		public static int RelicRerollLimitCount = 100;

		// Token: 0x04001179 RID: 4473
		public static int TournamentEmptyUserSlot = -1;

		// Token: 0x0400117A RID: 4474
		public static int TournamentUndecidedSlot = 0;

		// Token: 0x0400117B RID: 4475
		public static int TournamentGroupCount = 4;

		// Token: 0x0400117C RID: 4476
		public static int TournamentDefaultBotCount = 1024;

		// Token: 0x0400117D RID: 4477
		public static int TournamentPredictionCoolTime = 60;

		// Token: 0x0400117E RID: 4478
		public static int TournamentQualifyCoolTime = 60;

		// Token: 0x0400117F RID: 4479
		public static int TournamentPredictionJoinRewardItemID = 2;

		// Token: 0x04001180 RID: 4480
		public static int TournamentPredictionJoinRewardItemValue = 3000;

		// Token: 0x04001181 RID: 4481
		public static bool TournamentUseBot = true;

		// Token: 0x04001182 RID: 4482
		public static int TournamentMinimumDeckCP = 100000;

		// Token: 0x04001183 RID: 4483
		public static int TournamentBanHighUnitCount = 3;

		// Token: 0x04001184 RID: 4484
		public static int TournamentBanHighShipCount = 3;

		// Token: 0x02001315 RID: 4885
		public readonly struct ImprintMainOptEffect
		{
			// Token: 0x0600AE92 RID: 44690 RVA: 0x0039077E File Offset: 0x0038E97E
			public ImprintMainOptEffect(float mainStatMultiply, float subStatMultiply)
			{
				this.MainStatMultiply = mainStatMultiply;
				this.SubStatMultiply = subStatMultiply;
			}

			// Token: 0x17001968 RID: 6504
			// (get) Token: 0x0600AE93 RID: 44691 RVA: 0x0039078E File Offset: 0x0038E98E
			public float MainStatMultiply { get; }

			// Token: 0x17001969 RID: 6505
			// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x00390796 File Offset: 0x0038E996
			public float SubStatMultiply { get; }

		}
	}
}
