using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000421 RID: 1057
	public class NKMGameRuntimeTeamData : ISerializable
	{
		// Token: 0x06001B91 RID: 7057 RVA: 0x0007B180 File Offset: 0x00079380
		public virtual void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_UserUID);
			stream.PutOrGet(ref this.m_bAutoRespawn);
			stream.PutOrGet(ref this.m_bAIDisable);
			stream.PutOrGet(ref this.m_bGodMode);
			stream.PutOrGet(ref this.m_fRespawnCost);
			stream.PutOrGet(ref this.m_fRespawnCostAssist);
			stream.PutOrGet(ref this.m_fUsedRespawnCost);
			stream.PutOrGet(ref this.m_respawn_count);
			stream.PutOrGetEnum<NKM_GAME_AUTO_SKILL_TYPE>(ref this.m_NKM_GAME_AUTO_SKILL_TYPE);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0007B1FC File Offset: 0x000793FC
		public void DeepCopyFromSource(NKMGameRuntimeTeamData source)
		{
			this.m_bAutoRespawn = source.m_bAutoRespawn;
			this.m_bAIDisable = source.m_bAIDisable;
			this.m_bGodMode = source.m_bGodMode;
			this.m_fRespawnCost = source.m_fRespawnCost;
			this.m_fRespawnCostAssist = source.m_fRespawnCostAssist;
			this.m_fUsedRespawnCost = source.m_fUsedRespawnCost;
			this.m_respawn_count = source.m_respawn_count;
			this.m_NKM_GAME_AUTO_SKILL_TYPE = source.m_NKM_GAME_AUTO_SKILL_TYPE;
		}

		// Token: 0x04001C5D RID: 7261
		public long m_UserUID;

		// Token: 0x04001C5E RID: 7262
		public bool m_bAutoRespawn = true;

		// Token: 0x04001C5F RID: 7263
		public bool m_bAIDisable;

		// Token: 0x04001C60 RID: 7264
		public bool m_bGodMode;

		// Token: 0x04001C61 RID: 7265
		public float m_fRespawnCost = 3f;

		// Token: 0x04001C62 RID: 7266
		public float m_fRespawnCostAssist;

		// Token: 0x04001C63 RID: 7267
		public float m_fUsedRespawnCost;

		// Token: 0x04001C64 RID: 7268
		public int m_respawn_count;

		// Token: 0x04001C65 RID: 7269
		public NKM_GAME_AUTO_SKILL_TYPE m_NKM_GAME_AUTO_SKILL_TYPE = NKM_GAME_AUTO_SKILL_TYPE.NGST_OFF_HYPER;
	}
}
