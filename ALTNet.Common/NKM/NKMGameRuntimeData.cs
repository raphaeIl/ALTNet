using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000420 RID: 1056
	public class NKMGameRuntimeData : ISerializable
	{
		// Token: 0x06001B8F RID: 7055 RVA: 0x0007B088 File Offset: 0x00079288
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_GameTime);
			stream.PutOrGetEnum<NKM_GAME_SPEED_TYPE>(ref this.m_NKM_GAME_SPEED_TYPE);
			stream.PutOrGet(ref this.m_PrevWaveEndTime);
			stream.PutOrGetEnum<NKM_GAME_STATE>(ref this.m_NKM_GAME_STATE);
			stream.PutOrGet(ref this.m_WaveID);
			stream.PutOrGet(ref this.m_fRemainGameTime);
			stream.PutOrGet(ref this.m_fShipDamage);
			stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.m_WinTeam);
			stream.PutOrGet(ref this.m_bGameEnded);
			stream.PutOrGet(ref this.m_bPause);
			stream.PutOrGet(ref this.m_bGiveUp);
			stream.PutOrGet(ref this.m_bRestart);
			stream.PutOrGet<NKMGameRuntimeTeamData>(ref this.m_NKMGameRuntimeTeamDataA);
			stream.PutOrGet<NKMGameRuntimeTeamData>(ref this.m_NKMGameRuntimeTeamDataB);
			stream.PutOrGet<NKMGameSyncData_DungeonEvent>(ref this.m_lstPermanentDungeonEvent);
		}

		// Token: 0x04001C4C RID: 7244
		public float m_GameTime;

		// Token: 0x04001C4D RID: 7245
		public NKM_GAME_SPEED_TYPE m_NKM_GAME_SPEED_TYPE;

		// Token: 0x04001C4E RID: 7246
		public float m_PrevWaveEndTime;

		// Token: 0x04001C4F RID: 7247
		public NKM_GAME_STATE m_NKM_GAME_STATE = NKM_GAME_STATE.NGS_STOP;

		// Token: 0x04001C50 RID: 7248
		public int m_WaveID;

		// Token: 0x04001C51 RID: 7249
		public float m_fRemainGameTime = 180f;

		// Token: 0x04001C52 RID: 7250
		public float m_fShipDamage;

		// Token: 0x04001C53 RID: 7251
		public NKM_TEAM_TYPE m_WinTeam;

		// Token: 0x04001C54 RID: 7252
		public bool m_bGameEnded;

		// Token: 0x04001C55 RID: 7253
		public bool m_bPause;

		// Token: 0x04001C56 RID: 7254
		public bool m_bGiveUp;

		// Token: 0x04001C57 RID: 7255
		public bool m_bRestart;

		// Token: 0x04001C58 RID: 7256
		public NKMGameRuntimeTeamData m_NKMGameRuntimeTeamDataA = new NKMGameRuntimeTeamData();

		// Token: 0x04001C59 RID: 7257
		public NKMGameRuntimeTeamData m_NKMGameRuntimeTeamDataB = new NKMGameRuntimeTeamData();

		// Token: 0x04001C5A RID: 7258
		public bool m_bPracticeHeal = true;

		// Token: 0x04001C5B RID: 7259
		public bool m_bPracticeFixedDamage;

		// Token: 0x04001C5C RID: 7260
		public List<NKMGameSyncData_DungeonEvent> m_lstPermanentDungeonEvent;
	}
}
