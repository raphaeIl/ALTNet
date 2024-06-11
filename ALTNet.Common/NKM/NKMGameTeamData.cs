using System;
using System.Collections.Generic;
using ClientPacket.Common;
using ClientPacket.Community;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200041A RID: 1050
	public class NKMGameTeamData : ISerializable
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x0007A908 File Offset: 0x00078B08
		public void Init()
		{
			this.m_eNKM_TEAM_TYPE = NKM_TEAM_TYPE.NTT_INVALID;
			this.m_LeaderUnitUID = 0L;
			this.m_UserLevel = 0;
			this.m_UserNickname = "";
			this.m_Tier = 0;
			this.m_Score = 0;
			this.m_MainShip = null;
			this.m_user_uid = 0L;
			this.m_listUnitData.Clear();
			this.m_listAssistUnitData.Clear();
			this.m_listEvevtUnitData.Clear();
			this.m_listDynamicRespawnUnitData.Clear();
			//this.m_DeckData.Init();
			this.m_fInitHP = 0f;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0007A998 File Offset: 0x00078B98
		public virtual void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.m_eNKM_TEAM_TYPE);
			stream.PutOrGet(ref this.m_LeaderUnitUID);
			stream.PutOrGet(ref this.m_UserLevel);
			stream.PutOrGet(ref this.m_UserNickname);
			stream.PutOrGet(ref this.m_Tier);
			stream.PutOrGet(ref this.m_Score);
			stream.PutOrGet(ref this.m_WinStreak);
			stream.PutOrGet<NKMUnitData>(ref this.m_MainShip);
			stream.PutOrGet<NKMOperator>(ref this.m_Operator);
			stream.PutOrGet(ref this.m_user_uid);
			stream.PutOrGet<NKMUnitData>(ref this.m_listUnitData);
			stream.PutOrGet<NKMUnitData>(ref this.m_listAssistUnitData);
			stream.PutOrGet<NKMUnitData>(ref this.m_listEvevtUnitData);
			stream.PutOrGet<NKMUnitData>(ref this.m_listEnvUnitData);
			stream.PutOrGet<NKMDynamicRespawnUnitData>(ref this.m_listDynamicRespawnUnitData);
			stream.PutOrGet<NKMTacticalCommandData>(ref this.m_listTacticalCommandData);
			stream.PutOrGet<NKMGameTeamDeckData>(ref this.m_DeckData);
			stream.PutOrGet(ref this.m_fInitHP);
			stream.PutOrGet<NKMEquipItemData>(ref this.m_ItemEquipData);
			stream.PutOrGet(ref this.m_FriendCode);
			stream.PutOrGet<EmoticonPresetData>(ref this.m_emoticonPreset);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildSimpleData);
			stream.PutOrGet<NKMCommonProfile>(ref this.m_userCommonProfile);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0007ADED File Offset: 0x00078FED
		public void SetInfo(PvpState pvpData, NKMGuildSimpleData guildSimpleData)
		{
			this.m_Score = pvpData.Score;
			this.m_Tier = pvpData.LeagueTierID;
			this.m_WinStreak = pvpData.WinStreak;
			this.guildSimpleData = guildSimpleData;
		}

		// Token: 0x04001C20 RID: 7200
		public NKM_TEAM_TYPE m_eNKM_TEAM_TYPE;

		// Token: 0x04001C21 RID: 7201
		public long m_LeaderUnitUID;

		// Token: 0x04001C22 RID: 7202
		public int m_UserLevel;

		// Token: 0x04001C23 RID: 7203
		public string m_UserNickname;

		// Token: 0x04001C24 RID: 7204
		public int m_Tier;

		// Token: 0x04001C25 RID: 7205
		public int m_Score;

		// Token: 0x04001C26 RID: 7206
		public int m_WinStreak;

		// Token: 0x04001C27 RID: 7207
		public long m_FriendCode;

		// Token: 0x04001C28 RID: 7208
		public NKMCommonProfile m_userCommonProfile = new NKMCommonProfile();

		// Token: 0x04001C29 RID: 7209
		public NKMGuildSimpleData guildSimpleData = new NKMGuildSimpleData();

		// Token: 0x04001C2A RID: 7210
		public NKMUnitData m_MainShip;

		// Token: 0x04001C2B RID: 7211
		public NKMOperator m_Operator;

		// Token: 0x04001C2C RID: 7212
		public long m_user_uid;

		// Token: 0x04001C2D RID: 7213
		public List<NKMUnitData> m_listUnitData = new List<NKMUnitData>();

		// Token: 0x04001C2E RID: 7214
		public List<NKMUnitData> m_listAssistUnitData = new List<NKMUnitData>();

		// Token: 0x04001C2F RID: 7215
		public List<NKMUnitData> m_listEvevtUnitData = new List<NKMUnitData>();

		// Token: 0x04001C30 RID: 7216
		public List<NKMUnitData> m_listEnvUnitData = new List<NKMUnitData>();

		// Token: 0x04001C31 RID: 7217
		public List<NKMDynamicRespawnUnitData> m_listDynamicRespawnUnitData = new List<NKMDynamicRespawnUnitData>();

		// Token: 0x04001C32 RID: 7218
		public List<NKMTacticalCommandData> m_listTacticalCommandData = new List<NKMTacticalCommandData>();

		// Token: 0x04001C33 RID: 7219
		public NKMGameTeamDeckData m_DeckData = new NKMGameTeamDeckData();

		// Token: 0x04001C34 RID: 7220
		public float m_fInitHP;

		// Token: 0x04001C35 RID: 7221
		public Dictionary<long, NKMEquipItemData> m_ItemEquipData = new Dictionary<long, NKMEquipItemData>();

		// Token: 0x04001C36 RID: 7222
		public EmoticonPresetData m_emoticonPreset = new EmoticonPresetData();
	}
}
