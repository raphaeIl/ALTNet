using System;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x020010E7 RID: 4327
	public sealed class NKMEventBetPrivateResult : ISerializable
	{
		// Token: 0x0600A7FD RID: 43005 RVA: 0x00382DB8 File Offset: 0x00380FB8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventIndex);
			stream.PutOrGetEnum<EventBetTeam>(ref this.selectTeam);
			stream.PutOrGet(ref this.receiveReward);
			stream.PutOrGet(ref this.isWin);
			stream.PutOrGet(ref this.dividentRate);
			stream.PutOrGet(ref this.betCount);
			stream.PutOrGet(ref this.rewardCount);
		}

		// Token: 0x04009AB2 RID: 39602
		public int eventIndex;

		// Token: 0x04009AB3 RID: 39603
		public EventBetTeam selectTeam;

		// Token: 0x04009AB4 RID: 39604
		public bool receiveReward;

		// Token: 0x04009AB5 RID: 39605
		public bool isWin;

		// Token: 0x04009AB6 RID: 39606
		public float dividentRate;

		// Token: 0x04009AB7 RID: 39607
		public long betCount;

		// Token: 0x04009AB8 RID: 39608
		public long rewardCount;
	}
}
