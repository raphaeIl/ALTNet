using System;
using ClientPacket.LeaderBoard;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Defence
{
	// Token: 0x020010FA RID: 4346
	[PacketId(ClientPacketId.kNKMPacket_DEFENCE_INFO_ACK)]
	public sealed class NKMPacket_DEFENCE_INFO_ACK : ISerializable
	{
		// Token: 0x0600A823 RID: 43043 RVA: 0x003831D0 File Offset: 0x003813D0
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.defenceTempletId);
			stream.PutOrGet(ref this.bestScore);
			stream.PutOrGet(ref this.missionResult1);
			stream.PutOrGet(ref this.missionResult2);
			stream.PutOrGet(ref this.rank);
			stream.PutOrGet(ref this.rankPercent);
			stream.PutOrGet(ref this.canReceiveRankReward);
			stream.PutOrGet<NKMDefenceRankData>(ref this.topRankProfile);
		}

		// Token: 0x04009AEC RID: 39660
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009AED RID: 39661
		public int defenceTempletId;

		// Token: 0x04009AEE RID: 39662
		public int bestScore;

		// Token: 0x04009AEF RID: 39663
		public bool missionResult1;

		// Token: 0x04009AF0 RID: 39664
		public bool missionResult2;

		// Token: 0x04009AF1 RID: 39665
		public int rank;

		// Token: 0x04009AF2 RID: 39666
		public int rankPercent;

		// Token: 0x04009AF3 RID: 39667
		public bool canReceiveRankReward;

		// Token: 0x04009AF4 RID: 39668
		public NKMDefenceRankData topRankProfile = new NKMDefenceRankData();
	}
}
