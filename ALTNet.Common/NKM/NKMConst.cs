using System;
using System.Collections.Generic;
using Cs.GameLog.CountryDescription;
using NKM.Templet;

namespace NKM
{
	// Token: 0x020003BE RID: 958
	public static class NKMConst
	{
		// Token: 0x0400118A RID: 4490
		public const int MAX_AUTO_SUPPLY_ACCUMULATE_MINUTES = 480;

		// Token: 0x02001317 RID: 4887
		public static class Deck
		{
			// Token: 0x0400A0EE RID: 41198
			public const int MaxUnitEnter = 8;
		}

		// Token: 0x02001318 RID: 4888
		public static class Post
		{
			// Token: 0x0400A0EF RID: 41199
			public static readonly DateTime MaxExpirationUtcDate = new DateTime(3000, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

			// Token: 0x0400A0F0 RID: 41200
			public static readonly DateTime UnlimitedExpirationUtcDate = new DateTime(2100, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
		}

		// Token: 0x02001319 RID: 4889
		public static class Negotiation
		{
			// Token: 0x0400A0F1 RID: 41201
			public const int MaxMaterialCount = 3;
		}

		// Token: 0x0200131A RID: 4890
		public static class Profile
		{
			// Token: 0x0400A0F2 RID: 41202
			public const int MaxEmblemCount = 3;
		}

		// Token: 0x0200131B RID: 4891
		public static class Equip
		{
			// Token: 0x0400A0F3 RID: 41203
			public const int MaxPotentialOptionSocketCount = 3;

			// Token: 0x0400A0F4 RID: 41204
			public const int MaxMaterialCount = 4;
		}

		// Token: 0x0200131C RID: 4892
		public static class Warfare
		{
			// Token: 0x0400A0F5 RID: 41205
			public const int DEFAULT_SUPPLY_COUNT = 2;

			// Token: 0x0400A0F6 RID: 41206
			public const int MAX_SUPPLY_COUNT = 2;

			// Token: 0x0400A0F7 RID: 41207
			public const int SERVICE_COST_ITEM_ID = 2;

			// Token: 0x0400A0F8 RID: 41208
			public const int EXPIRE_TIME = 12;

			// Token: 0x0400A0F9 RID: 41209
			public const int FriendshipPointItemId = 8;

			// Token: 0x0400A0FA RID: 41210
			public const int RECOVERY_COST_MULTIPLE = 2;

			// Token: 0x0400A0FB RID: 41211
			public const string MyFriendhipPointMailTitle = "SI_MAIL_ASSIST_ME_TITLE_V2";

			// Token: 0x0400A0FC RID: 41212
			public const string MyFriendhipPointMailText = "SI_MAIL_ASSIST_ME_DESC_V2";

			// Token: 0x0400A0FD RID: 41213
			public const string FriendFriendhipPointMailTitle = "SI_MAIL_ASSIST_OTHER_TITLE_V2";

			// Token: 0x0400A0FE RID: 41214
			public const string FriendFriendhipPointMailText = "SI_MAIL_ASSIST_OTHER_DESC_V2";

			// Token: 0x0400A0FF RID: 41215
			public const string MyGuestUsageMailTitle = "SI_MAIL_AST_GUEST_ME_TITLE";

			// Token: 0x0400A100 RID: 41216
			public const string MyGuestUsageMailText = "SI_MAIL_AST_GUEST_ME_DESC";

			// Token: 0x0400A101 RID: 41217
			public const string GuestUsageMailTitle = "SI_MAIL_AST_GUEST_OTHER_TITLE";

			// Token: 0x0400A102 RID: 41218
			public const string GuestUsageMailText = "SI_MAIL_AST_GUEST_OTHER_DESC";
		}

		// Token: 0x0200131D RID: 4893
		public static class Episode
		{
			// Token: 0x0400A103 RID: 41219
			public const int DAILYMISSION_ATTACK = 101;

			// Token: 0x0400A104 RID: 41220
			public const int DAILYMISSION_SEARCH = 102;

			// Token: 0x0400A105 RID: 41221
			public const int DAILYMISSION_DEFENCE = 103;

			// Token: 0x0400A106 RID: 41222
			public const int DAILYMISSION_TACTICAL = 104;

			// Token: 0x0400A107 RID: 41223
			public const int MAX_ONE_TIME_REWARD_COUNT = 3;
		}

		// Token: 0x0200131E RID: 4894
		public static class Raid
		{
			// Token: 0x0400A108 RID: 41224
			public const int MAX_RAID_RESULT_COUNT = 99;

			// Token: 0x0400A109 RID: 41225
			public const int MAX_RAID_BUFF_LEVEL = 5;
		}

		// Token: 0x0200131F RID: 4895
		public static class Craft
		{
			// Token: 0x0400A10A RID: 41226
			public const int CASH_COST_UNLOCK_SLOT = 300;

			// Token: 0x0400A10B RID: 41227
			public const int MAX_CRAFT_START_COUNT = 10;

			// Token: 0x0400A10C RID: 41228
			public const int MAX_CRAFT_MISC_START_COUNT = 999;
		}

		// Token: 0x02001320 RID: 4896
		public static class Dungeon
		{
			// Token: 0x0400A10D RID: 41229
			public const int DEFAULT_SUPPLY = 2;
		}

		// Token: 0x02001321 RID: 4897
		public static class Worldmap
		{
			// Token: 0x0400A10E RID: 41230
			public static readonly List<int> CITY_OPEN_CASH_COST = new List<int>
			{
				0,
				800,
				2400,
				4500,
				8000,
				12500
			};

			// Token: 0x0400A10F RID: 41231
			public static readonly List<int> CITY_OPEN_CREDIT_COST = new List<int>
			{
				0,
				100000,
				200000,
				400000,
				800000,
				1600000
			};

			// Token: 0x0400A110 RID: 41232
			public static readonly int RaidBuildingId = 21;

			// Token: 0x0400A111 RID: 41233
			public static readonly int DiveBuildingId = 22;
		}

		// Token: 0x02001322 RID: 4898
		public static class Unit
		{
			// Token: 0x0400A112 RID: 41234
			public const int LoyaltyMax = 10000;

			// Token: 0x0400A113 RID: 41235
			public const int PermanentContractDocumentId = 1024;

			// Token: 0x0400A114 RID: 41236
			public const int ContractDocumentId = 1001;

			// Token: 0x0400A115 RID: 41237
			public const int ContractInstantCouponId = 1002;

			// Token: 0x0400A116 RID: 41238
			public const int ContractMilesageItemId = 401;

			// Token: 0x0400A117 RID: 41239
			public const int ShipContractDoc = 1015;

			// Token: 0x0400A118 RID: 41240
			public const float BonusExpRateOfPermanentContract = 0.2f;

			// Token: 0x0400A119 RID: 41241
			public const int MaxLevel = 100;

			// Token: 0x0400A11A RID: 41242
			public const int MaxTranscendenceLevel = 110;
		}

		// Token: 0x02001323 RID: 4899
		public static class Contract
		{
			// Token: 0x0400A11B RID: 41243
			public const int SelectableContractSlotCount = 10;
		}

		// Token: 0x02001324 RID: 4900
		public static class Ship
		{
			// Token: 0x0400A11C RID: 41244
			public const int MaxUpgradeLevel = 6;

			// Token: 0x0400A11D RID: 41245
			public static readonly List<int> CoffinIds = new List<int>
			{
				21001,
				22001,
				23001,
				24001,
				25001,
				26001
			};

			// Token: 0x0400A11E RID: 41246
			public static readonly List<int> BaseShipGroupIds = new List<int>
			{
				20001,
				20022
			};
		}

		// Token: 0x02001325 RID: 4901
		public static class OperationPowerFactor
		{
			// Token: 0x0600AE9E RID: 44702 RVA: 0x00390994 File Offset: 0x0038EB94
			public static int GetClassValue(NKM_UNIT_ROLE_TYPE unitRoleType)
			{
				switch (unitRoleType)
				{
				case NKM_UNIT_ROLE_TYPE.NURT_STRIKER:
					return 850;
				case NKM_UNIT_ROLE_TYPE.NURT_RANGER:
					return 850;
				case NKM_UNIT_ROLE_TYPE.NURT_DEFENDER:
					return 900;
				case NKM_UNIT_ROLE_TYPE.NURT_SNIPER:
					return 900;
				case NKM_UNIT_ROLE_TYPE.NURT_SUPPORTER:
					return 800;
				case NKM_UNIT_ROLE_TYPE.NURT_SIEGE:
					return 700;
				case NKM_UNIT_ROLE_TYPE.NURT_TOWER:
					return 700;
				default:
					throw new InvalidOperationException("invalid unitRoleType");
				}
			}

			// Token: 0x0600AE9F RID: 44703 RVA: 0x003909FC File Offset: 0x0038EBFC
			public static int GetGradeValue(NKM_UNIT_GRADE unitGrade, bool bAwaken, bool bRearm)
			{
				if (bAwaken)
				{
					if (unitGrade == NKM_UNIT_GRADE.NUG_SSR)
					{
						return 10075;
					}
				}
				else if (bRearm)
				{
					if (unitGrade == NKM_UNIT_GRADE.NUG_SR)
					{
						return 9275;
					}
					if (unitGrade == NKM_UNIT_GRADE.NUG_SSR)
					{
						return 9675;
					}
				}
				else
				{
					switch (unitGrade)
					{
					case NKM_UNIT_GRADE.NUG_N:
						return 8600;
					case NKM_UNIT_GRADE.NUG_R:
						return 8850;
					case NKM_UNIT_GRADE.NUG_SR:
						return 9125;
					case NKM_UNIT_GRADE.NUG_SSR:
						return 9500;
					}
				}
				throw new InvalidOperationException("invalid unitGrade");
			}

			// Token: 0x0600AEA0 RID: 44704 RVA: 0x00390A68 File Offset: 0x0038EC68
			public static int GetTacticValue(NKM_UNIT_GRADE unitGrade, bool bAwaken, bool bRearm)
			{
				if (bAwaken)
				{
					if (unitGrade == NKM_UNIT_GRADE.NUG_SSR)
					{
						return 400;
					}
				}
				else if (bRearm)
				{
					if (unitGrade == NKM_UNIT_GRADE.NUG_SR)
					{
						return 340;
					}
					if (unitGrade == NKM_UNIT_GRADE.NUG_SSR)
					{
						return 380;
					}
				}
				else
				{
					switch (unitGrade)
					{
					case NKM_UNIT_GRADE.NUG_N:
						return 280;
					case NKM_UNIT_GRADE.NUG_R:
						return 300;
					case NKM_UNIT_GRADE.NUG_SR:
						return 320;
					case NKM_UNIT_GRADE.NUG_SSR:
						return 360;
					}
				}
				throw new InvalidOperationException("invalid unitGrade");
			}

			// Token: 0x0600AEA1 RID: 44705 RVA: 0x00390AD4 File Offset: 0x0038ECD4
			public static int GetReactorValue(NKM_UNIT_GRADE unitGrade, bool bAwaken, bool bRearm)
			{
				if (bAwaken)
				{
					if (unitGrade == NKM_UNIT_GRADE.NUG_SSR)
					{
						return 800;
					}
				}
				else if (bRearm)
				{
					if (unitGrade == NKM_UNIT_GRADE.NUG_SR)
					{
						return 650;
					}
					if (unitGrade == NKM_UNIT_GRADE.NUG_SSR)
					{
						return 750;
					}
				}
				else
				{
					switch (unitGrade)
					{
					case NKM_UNIT_GRADE.NUG_N:
						return 500;
					case NKM_UNIT_GRADE.NUG_R:
						return 550;
					case NKM_UNIT_GRADE.NUG_SR:
						return 600;
					case NKM_UNIT_GRADE.NUG_SSR:
						return 700;
					}
				}
				throw new InvalidOperationException("invalid unitGrade");
			}

			// Token: 0x0400A11F RID: 41247
			public const int ClassValueOfSniper = 900;

			// Token: 0x0400A120 RID: 41248
			public const int ClassValueOfDefender = 900;

			// Token: 0x0400A121 RID: 41249
			public const int ClassValueOfStriker = 850;

			// Token: 0x0400A122 RID: 41250
			public const int ClassValueOfRanger = 850;

			// Token: 0x0400A123 RID: 41251
			public const int ClassValueOfSuppoter = 800;

			// Token: 0x0400A124 RID: 41252
			public const int ClassValueOfTower = 700;

			// Token: 0x0400A125 RID: 41253
			public const int ClasValueOfSiege = 700;

			// Token: 0x0400A126 RID: 41254
			public const int GradeValueOfAwakenSSR = 10075;

			// Token: 0x0400A127 RID: 41255
			public const int GradeValueOfRearmSSR = 9675;

			// Token: 0x0400A128 RID: 41256
			public const int GradeValueOfSSR = 9500;

			// Token: 0x0400A129 RID: 41257
			public const int GradeValueOfRearmSR = 9275;

			// Token: 0x0400A12A RID: 41258
			public const int GradeValueOfSR = 9125;

			// Token: 0x0400A12B RID: 41259
			public const int GradeValueOfR = 8850;

			// Token: 0x0400A12C RID: 41260
			public const int GradeValueOfN = 8600;

			// Token: 0x0400A12D RID: 41261
			public const float AdjustmentFactorOfUnit = 0.6f;

			// Token: 0x0400A12E RID: 41262
			public const float AdjustmentFactorOfEquip = 0.5f;

			// Token: 0x0400A12F RID: 41263
			public const int TacticValueOfAwakenSSR = 400;

			// Token: 0x0400A130 RID: 41264
			public const int TacticValueOfRearmSSR = 380;

			// Token: 0x0400A131 RID: 41265
			public const int TacticValueOfSSR = 360;

			// Token: 0x0400A132 RID: 41266
			public const int TacticValueOfRearmSR = 340;

			// Token: 0x0400A133 RID: 41267
			public const int TacticValueOfSR = 320;

			// Token: 0x0400A134 RID: 41268
			public const int TacticValueOfR = 300;

			// Token: 0x0400A135 RID: 41269
			public const int TacticValueOfN = 280;

			// Token: 0x0400A136 RID: 41270
			public const int ReactorValueOfAwakenSSR = 800;

			// Token: 0x0400A137 RID: 41271
			public const int ReactorValueOfRearmSSR = 750;

			// Token: 0x0400A138 RID: 41272
			public const int ReactorValueOfSSR = 700;

			// Token: 0x0400A139 RID: 41273
			public const int ReactorValueOfRearmSR = 650;

			// Token: 0x0400A13A RID: 41274
			public const int ReactorValueOfSR = 600;

			// Token: 0x0400A13B RID: 41275
			public const int ReactorValueOfR = 550;

			// Token: 0x0400A13C RID: 41276
			public const int ReactorValueOfN = 500;
		}

		// Token: 0x02001326 RID: 4902
		public static class RandomShop
		{
			// Token: 0x0400A13D RID: 41277
			public const int MaxSlotCount = 9;

			// Token: 0x0400A13E RID: 41278
			public const int RefreshCost = 15;

			// Token: 0x0400A13F RID: 41279
			public const int RefreshMaxCountPerDay = 5;
		}

		// Token: 0x02001327 RID: 4903
		public static class Account
		{
			// Token: 0x0400A140 RID: 41280
			public const int NicknameChangeItemId = 510;
		}

		// Token: 0x02001328 RID: 4904
		public static class ServerString
		{
			// Token: 0x0600AEA2 RID: 44706 RVA: 0x00390B3F File Offset: 0x0038ED3F
			public static string BuildMiscId(int itemId)
			{
				return string.Format("{0}{1}", "<MiscId>", itemId);
			}

			// Token: 0x0600AEA3 RID: 44707 RVA: 0x00390B56 File Offset: 0x0038ED56
			public static string BuildMoldId(int itemId)
			{
				return string.Format("{0}{1}", "<MoldId>", itemId);
			}

			// Token: 0x0400A141 RID: 41281
			public const string Seperator = "@@";

			// Token: 0x0400A142 RID: 41282
			public const string GuildBanId = "<GuildBanId>";

			// Token: 0x0400A143 RID: 41283
			public const string MiscId = "<MiscId>";

			// Token: 0x0400A144 RID: 41284
			public const string EquipId = "<EquipId>";

			// Token: 0x0400A145 RID: 41285
			public const string MoldId = "<MoldId>";
		}

		// Token: 0x02001329 RID: 4905
		public static class UserLevelUp
		{
			// Token: 0x0400A146 RID: 41286
			public const string UserLevelUpPostTitle = "SI_MAIL_ACCOUNT_LEVEL_UP_REWARD_TITLE";

			// Token: 0x0400A147 RID: 41287
			public const string UserLevelUpPostDesc = "SI_MAIL_ACCOUNT_LEVEL_UP_REWARD_DESC";
		}

		// Token: 0x0200132A RID: 4906
		public static class Buff
		{
			// Token: 0x02001C87 RID: 7303
			public enum BuffType
			{
				// Token: 0x0400BDF8 RID: 48632
				[CountryDescription("", CountryCode.KOR)]
				NONE,
				// Token: 0x0400BDF9 RID: 48633
				[CountryDescription("전역, 던전 크레딧 보상 증가", CountryCode.KOR)]
				WARFARE_DUNGEON_REWARD_CREDIT,
				// Token: 0x0400BDFA RID: 48634
				[CountryDescription("전역, 던전 유닛 경험치 증가", CountryCode.KOR)]
				WARFARE_DUNGEON_REWARD_EXP_UNIT,
				// Token: 0x0400BDFB RID: 48635
				[CountryDescription("전역, 던전 회사 경험치 증가", CountryCode.KOR)]
				WARFARE_DUNGEON_REWARD_EXP_COMPANY,
				// Token: 0x0400BDFC RID: 48636
				[CountryDescription("전역 입장 이터니움 비용 감소", CountryCode.KOR)]
				WARFARE_ETERNIUM_DISCOUNT,
				// Token: 0x0400BDFD RID: 48637
				[CountryDescription("전역, 던전 입장 이터니움 비용 감소", CountryCode.KOR)]
				WARFARE_DUNGEON_ETERNIUM_DISCOUNT,
				// Token: 0x0400BDFE RID: 48638
				[CountryDescription("랭크전 건틀렛 시간당 포인트 획득량 증가", CountryCode.KOR)]
				PVP_POINT_CHARGE,
				// Token: 0x0400BDFF RID: 48639
				[CountryDescription("모든 건틀렛 포인트 보상 증가", CountryCode.KOR)]
				ALL_PVP_POINT_REWARD,
				// Token: 0x0400BE00 RID: 48640
				[CountryDescription("월드맵 미션 성공률 증가", CountryCode.KOR)]
				WORLDMAP_MISSION_COMPLETE_RATIO_BONUS,
				// Token: 0x0400BE01 RID: 48641
				[CountryDescription("연봉협상 시 크레딧 재화의 소모량 감소", CountryCode.KOR)]
				BASE_PERSONNAL_NEGOTIATION_CREDIT_DISCOUNT,
				// Token: 0x0400BE02 RID: 48642
				[CountryDescription("장비 제작 시 크레딧 재화의 소모량 감소", CountryCode.KOR)]
				BASE_FACTORY_CRAFT_CREDIT_DISCOUNT,
				// Token: 0x0400BE03 RID: 48643
				[CountryDescription("장비 강화, 튜닝 시 크레딧 재화의 소모량 감소", CountryCode.KOR)]
				BASE_FACTORY_ENCHANT_TUNING_CREDIT_DISCOUNT,
				// Token: 0x0400BE04 RID: 48644
				[CountryDescription("오퍼레이터 스킬전수 비용 감소", CountryCode.KOR)]
				OPERATOR_SKILL_ENHANCE_COST_DISCOUNT,
				// Token: 0x0400BE05 RID: 48645
				[CountryDescription("오퍼레이터 스킬전수 성공확률 증가 SSR", CountryCode.KOR)]
				OPERATOR_SKILL_ENHANCE_SUCCESS_RATE_BONUS_SSR,
				// Token: 0x0400BE06 RID: 48646
				[CountryDescription("오퍼레이터 스킬전수 성공확률 증가 SR", CountryCode.KOR)]
				OPERATOR_SKILL_ENHANCE_SUCCESS_RATE_BONUS_SR,
				// Token: 0x0400BE07 RID: 48647
				[CountryDescription("오퍼레이터 스킬전수 성공확률 증가 R", CountryCode.KOR)]
				OPERATOR_SKILL_ENHANCE_SUCCESS_RATE_BONUS_R,
				// Token: 0x0400BE08 RID: 48648
				[CountryDescription("오퍼레이터 스킬전수 성공확률 증가 N", CountryCode.KOR)]
				OPERATOR_SKILL_ENHANCE_SUCCESS_RATE_BONUS_N
			}
		}

		// Token: 0x0200132B RID: 4907
		public static class Background
		{
			// Token: 0x0400A148 RID: 41288
			public const int defaultID = 9001;

			// Token: 0x0400A149 RID: 41289
			public const string defaultPrefab = "AB_UI_BG_SPRITE_CITY_NIGHT";

			// Token: 0x0400A14A RID: 41290
			public const string FollowLobby = "FOLLOW_LOBBY";

			// Token: 0x0400A14B RID: 41291
			public const int MaxBackgroundUnitCount = 8;
		}

		// Token: 0x0200132C RID: 4908
		public static class ShadowPalace
		{
			// Token: 0x0400A14C RID: 41292
			public const int dummyUnitID = 999;

			// Token: 0x0400A14D RID: 41293
			public const int dummyShipID = 26001;

			// Token: 0x0400A14E RID: 41294
			public const string ShadowPlaceTag = "UNLOCK_SHADOW_PALACE_ON";
		}

		// Token: 0x0200132D RID: 4909
		public static class Operator
		{
			// Token: 0x0400A14F RID: 41295
			public const string OperatorTag = "OPERATOR";
		}

		// Token: 0x0200132E RID: 4910
		public static class Jukebox
		{
			// Token: 0x0400A150 RID: 41296
			public const float JukeboxBgmChangeCoolTime = 1f;
		}
	}
}
