using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x0200050D RID: 1293
	public class NKMWarfareClearData : ISerializable
	{
		// Token: 0x0600248E RID: 9358 RVA: 0x000BFCD4 File Offset: 0x000BDED4
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_WarfareID);
			stream.PutOrGet(ref this.m_mission_result_1);
			stream.PutOrGet(ref this.m_mission_result_2);
			stream.PutOrGet<NKMRewardData>(ref this.m_RewardDataList);
			stream.PutOrGet<NKMRewardData>(ref this.m_ContainerRewards);
			stream.PutOrGet(ref this.m_enemiesKillCount);
			stream.PutOrGet<NKMRewardData>(ref this.m_MissionReward);
			stream.PutOrGet(ref this.m_MissionRewardResult);
			stream.PutOrGet<NKMRewardData>(ref this.m_OnetimeRewards);
			stream.PutOrGet(ref this.m_OnetimeRewardResults);
			stream.PutOrGet<NKMStagePlayData>(ref this.m_StagePlayData);
		}

		// Token: 0x040026F8 RID: 9976
		public int m_WarfareID;

		// Token: 0x040026F9 RID: 9977
		public bool m_mission_result_1;

		// Token: 0x040026FA RID: 9978
		public bool m_mission_result_2;

		// Token: 0x040026FB RID: 9979
		public NKMRewardData m_RewardDataList;

		// Token: 0x040026FC RID: 9980
		public NKMRewardData m_ContainerRewards;

		// Token: 0x040026FD RID: 9981
		public int m_enemiesKillCount;

		// Token: 0x040026FE RID: 9982
		public NKMRewardData m_MissionReward;

		// Token: 0x040026FF RID: 9983
		public bool m_MissionRewardResult;

		// Token: 0x04002700 RID: 9984
		public NKMRewardData m_OnetimeRewards;

		// Token: 0x04002701 RID: 9985
		public List<bool> m_OnetimeRewardResults = new List<bool>(3);

		// Token: 0x04002702 RID: 9986
		public NKMStagePlayData m_StagePlayData;
	}
}
