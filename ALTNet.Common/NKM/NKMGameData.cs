using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000423 RID: 1059
	public sealed class NKMGameData : ISerializable
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x0007B31C File Offset: 0x0007951C
		public NKMGameData()
		{
			this.m_NKMGameTeamDataA.Init();
			this.m_NKMGameTeamDataB.Init();
			this.m_NKMGameTeamDataA.m_eNKM_TEAM_TYPE = NKM_TEAM_TYPE.NTT_A1;
			this.m_NKMGameTeamDataB.m_eNKM_TEAM_TYPE = NKM_TEAM_TYPE.NTT_B1;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0007B3D8 File Offset: 0x000795D8
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_GameUID);
			stream.PutOrGet(ref this.m_GameUnitUIDIndex);
			stream.PutOrGet(ref this.m_bLocal);
			stream.PutOrGetEnum<NKM_GAME_TYPE>(ref this.m_NKM_GAME_TYPE);
			stream.PutOrGet(ref this.m_DungeonID);
			stream.PutOrGet(ref this.m_bBossDungeon);
			stream.PutOrGet(ref this.m_WarfareID);
			stream.PutOrGet(ref this.m_RaidUID);
			stream.PutOrGet(ref this.m_fRespawnCostMinusPercentForTeamA);
			stream.PutOrGet(ref this.m_TeamASupply);
			stream.PutOrGet(ref this.m_fTeamAAttackPowerIncRateForWarfare);
			stream.PutOrGet(ref this.m_lstTeamABuffStrIDListForRaid);
			stream.PutOrGet(ref this.fExtraRespawnCostAddForA);
			stream.PutOrGet(ref this.fExtraRespawnCostAddForB);
			stream.PutOrGet(ref this.m_TeamBLevelAdd);
			stream.PutOrGet(ref this.m_TeamBLevelFix);
			stream.PutOrGet(ref this.m_fDoubleCostTime);
			stream.PutOrGet(ref this.m_MapID);
			stream.PutOrGet(ref this.m_BattleConditionIDs);
			stream.PutOrGet<NKMGameTeamData>(ref this.m_NKMGameTeamDataA);
			stream.PutOrGet<NKMGameTeamData>(ref this.m_NKMGameTeamDataB);
			stream.PutOrGet(ref this.m_listUnitDeckTemp);
			stream.PutOrGet(ref this.m_replay);
			stream.PutOrGet<NKMBanData>(ref this.m_dicNKMBanData);
			stream.PutOrGet<NKMBanShipData>(ref this.m_dicNKMBanShipData);
			stream.PutOrGet<NKMBanOperatorData>(ref this.m_dicNKMBanOperatorData);
			stream.PutOrGet<NKMUnitUpData>(ref this.m_dicNKMUpData);
			stream.PutOrGet(ref this.m_NKMGameStatRateID);
			stream.PutOrGet(ref this.m_bForcedAuto);
		}

		// Token: 0x04001C68 RID: 7272
		public long m_GameUID;

		// Token: 0x04001C69 RID: 7273
		public short m_GameUnitUIDIndex;

		// Token: 0x04001C6A RID: 7274
		public bool m_bLocal;

		// Token: 0x04001C6B RID: 7275
		public NKM_GAME_TYPE m_NKM_GAME_TYPE;

		// Token: 0x04001C6C RID: 7276
		public int m_DungeonID;

		// Token: 0x04001C6D RID: 7277
		public bool m_bBossDungeon;

		// Token: 0x04001C6E RID: 7278
		public int m_WarfareID;

		// Token: 0x04001C6F RID: 7279
		public long m_RaidUID;

		// Token: 0x04001C70 RID: 7280
		public float m_fRespawnCostMinusPercentForTeamA;

		// Token: 0x04001C71 RID: 7281
		public int m_TeamASupply;

		// Token: 0x04001C72 RID: 7282
		public float m_fTeamAAttackPowerIncRateForWarfare;

		// Token: 0x04001C73 RID: 7283
		public List<string> m_lstTeamABuffStrIDListForRaid = new List<string>();

		// Token: 0x04001C74 RID: 7284
		public float fExtraRespawnCostAddForA;

		// Token: 0x04001C75 RID: 7285
		public float fExtraRespawnCostAddForB;

		// Token: 0x04001C76 RID: 7286
		public int m_TeamBLevelAdd;

		// Token: 0x04001C77 RID: 7287
		public int m_TeamBLevelFix;

		// Token: 0x04001C78 RID: 7288
		public List<string> m_BanUnitBuffStrIDs = new List<string>();

		// Token: 0x04001C79 RID: 7289
		public bool m_bForcedAuto;

		// Token: 0x04001C7A RID: 7290
		public float m_fDoubleCostTime = 60f;

		// Token: 0x04001C7B RID: 7291
		public int m_MapID;

		// Token: 0x04001C7C RID: 7292
		public Dictionary<int, int> m_BattleConditionIDs = new Dictionary<int, int>();

		// Token: 0x04001C7D RID: 7293
		public NKMGameTeamData m_NKMGameTeamDataA = new NKMGameTeamData();

		// Token: 0x04001C7E RID: 7294
		public NKMGameTeamData m_NKMGameTeamDataB = new NKMGameTeamData();

		// Token: 0x04001C7F RID: 7295
		private List<long> m_listUnitDeckTemp = new List<long>();

		// Token: 0x04001C80 RID: 7296
		public bool m_replay;

		// Token: 0x04001C81 RID: 7297
		public Dictionary<int, NKMBanData> m_dicNKMBanData = new Dictionary<int, NKMBanData>();

		// Token: 0x04001C82 RID: 7298
		public Dictionary<int, NKMBanShipData> m_dicNKMBanShipData = new Dictionary<int, NKMBanShipData>();

		// Token: 0x04001C83 RID: 7299
		public Dictionary<int, NKMBanOperatorData> m_dicNKMBanOperatorData = new Dictionary<int, NKMBanOperatorData>();

		// Token: 0x04001C84 RID: 7300
		public Dictionary<int, NKMUnitUpData> m_dicNKMUpData = new Dictionary<int, NKMUnitUpData>();

		// Token: 0x04001C85 RID: 7301
		public string m_NKMGameStatRateID;

		// Token: 0x04001C86 RID: 7302
		private NKMGameStatRate m_GameStatRateCache;

		// Token: 0x04001C87 RID: 7303
		private bool m_bGameStatCacheSet;

		// Token: 0x04001C88 RID: 7304
		public bool isSurrenderGame;
	}
}
