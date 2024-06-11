using System;
using ClientPacket.Common;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000506 RID: 1286
	public class NKMUserOption : ISerializable
	{
		// Token: 0x0600243A RID: 9274 RVA: 0x000BED7C File Offset: 0x000BCF7C
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_bAutoRespawn);
			stream.PutOrGetEnum<ActionCameraType>(ref this.m_ActionCameraType);
			stream.PutOrGet(ref this.m_bTrackCamera);
			stream.PutOrGet(ref this.m_bViewSkillCutIn);
			stream.PutOrGet(ref this.m_bAutoWarfare);
			stream.PutOrGet(ref this.m_bAutoWarfareRepair);
			stream.PutOrGet(ref this.m_bPlayCutscene);
			stream.PutOrGet(ref this.m_bAutoDive);
			stream.PutOrGetEnum<NKM_GAME_SPEED_TYPE>(ref this.m_eSpeedType);
			stream.PutOrGetEnum<NKM_GAME_AUTO_SKILL_TYPE>(ref this.m_eAutoSkillType);
			stream.PutOrGet(ref this.m_bAutoSyncFriendDeck);
			stream.PutOrGetEnum<NKM_GAME_AUTO_RESPAWN_TYPE>(ref this.m_bDefaultPvpAutoRespawn);
			stream.PutOrGetEnum<PrivatePvpInvitation>(ref this.privatePvpInvitation);
		}

		// Token: 0x040026CD RID: 9933
		public bool m_bAutoRespawn;

		// Token: 0x040026CE RID: 9934
		public ActionCameraType m_ActionCameraType = ActionCameraType.All;

		// Token: 0x040026CF RID: 9935
		public bool m_bTrackCamera = true;

		// Token: 0x040026D0 RID: 9936
		public bool m_bViewSkillCutIn = true;

		// Token: 0x040026D1 RID: 9937
		public bool m_bAutoWarfare;

		// Token: 0x040026D2 RID: 9938
		public bool m_bAutoWarfareRepair = true;

		// Token: 0x040026D3 RID: 9939
		public bool m_bPlayCutscene;

		// Token: 0x040026D4 RID: 9940
		public bool m_bAutoDive;

		// Token: 0x040026D5 RID: 9941
		public NKM_GAME_SPEED_TYPE m_eSpeedType;

		// Token: 0x040026D6 RID: 9942
		public NKM_GAME_AUTO_SKILL_TYPE m_eAutoSkillType = NKM_GAME_AUTO_SKILL_TYPE.NGST_OFF_HYPER;

		// Token: 0x040026D7 RID: 9943
		public bool m_bAutoSyncFriendDeck = true;

		// Token: 0x040026D8 RID: 9944
		public NKM_GAME_AUTO_RESPAWN_TYPE m_bDefaultPvpAutoRespawn;

		// Token: 0x040026D9 RID: 9945
		public PrivatePvpInvitation privatePvpInvitation;
	}
}
