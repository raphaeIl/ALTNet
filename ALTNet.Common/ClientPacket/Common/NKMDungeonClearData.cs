using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM.Templet;

namespace ClientPacket.Common
{
	// Token: 0x02001191 RID: 4497
	public sealed class NKMDungeonClearData : ISerializable
	{
		// Token: 0x0600A93F RID: 43327 RVA: 0x00384AF0 File Offset: 0x00382CF0
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.dungeonId);
			stream.PutOrGet(ref this.missionResult1);
			stream.PutOrGet(ref this.missionResult2);
			stream.PutOrGet<NKMRewardData>(ref this.missionReward);
			stream.PutOrGet(ref this.missionRewardResult);
			stream.PutOrGet<NKMRewardData>(ref this.oneTimeRewards);
			stream.PutOrGet(ref this.onetimeRewardResults);
			stream.PutOrGet<NKMRewardData>(ref this.rewardData);
			stream.PutOrGet(ref this.unitExp);
		}

		// Token: 0x04009C64 RID: 40036
		public int dungeonId;

		// Token: 0x04009C65 RID: 40037
		public bool missionResult1;

		// Token: 0x04009C66 RID: 40038
		public bool missionResult2;

		// Token: 0x04009C67 RID: 40039
		public NKMRewardData missionReward;

		// Token: 0x04009C68 RID: 40040
		public bool missionRewardResult;

		// Token: 0x04009C69 RID: 40041
		public NKMRewardData oneTimeRewards;

		// Token: 0x04009C6A RID: 40042
		public List<bool> onetimeRewardResults = new List<bool>();

		// Token: 0x04009C6B RID: 40043
		public NKMRewardData rewardData;

		// Token: 0x04009C6C RID: 40044
		public int unitExp;
	}
}
