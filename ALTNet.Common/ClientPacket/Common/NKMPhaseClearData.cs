using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM.Templet;

namespace ClientPacket.Common
{
	// Token: 0x02001192 RID: 4498
	public sealed class NKMPhaseClearData : ISerializable
	{
		// Token: 0x0600A941 RID: 43329 RVA: 0x00384B7C File Offset: 0x00382D7C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.stageId);
			stream.PutOrGet(ref this.missionResult1);
			stream.PutOrGet(ref this.missionResult2);
			stream.PutOrGet<NKMRewardData>(ref this.missionReward);
			stream.PutOrGet(ref this.missionRewardResult);
			stream.PutOrGet<NKMRewardData>(ref this.oneTimeRewards);
			stream.PutOrGet(ref this.onetimeRewardResults);
			stream.PutOrGet<NKMRewardData>(ref this.rewardData);
		}

		// Token: 0x04009C6D RID: 40045
		public int stageId;

		// Token: 0x04009C6E RID: 40046
		public bool missionResult1;

		// Token: 0x04009C6F RID: 40047
		public bool missionResult2;

		// Token: 0x04009C70 RID: 40048
		public NKMRewardData missionReward;

		// Token: 0x04009C71 RID: 40049
		public bool missionRewardResult;

		// Token: 0x04009C72 RID: 40050
		public NKMRewardData oneTimeRewards;

		// Token: 0x04009C73 RID: 40051
		public List<bool> onetimeRewardResults = new List<bool>();

		// Token: 0x04009C74 RID: 40052
		public NKMRewardData rewardData;
	}
}
