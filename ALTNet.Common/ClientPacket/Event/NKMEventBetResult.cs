using System;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x020010E8 RID: 4328
	public sealed class NKMEventBetResult : ISerializable
	{
		// Token: 0x0600A7FF RID: 43007 RVA: 0x00382E24 File Offset: 0x00381024
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventIndex);
			stream.PutOrGetEnum<EventBetTeam>(ref this.winTeam);
			stream.PutOrGet(ref this.totalBetCountTeamA);
			stream.PutOrGet(ref this.totalBetCountTeamB);
			stream.PutOrGet(ref this.userCountTeamA);
			stream.PutOrGet(ref this.userCountTeamB);
			stream.PutOrGet(ref this.winRateTeamA);
			stream.PutOrGet(ref this.winRateTeamB);
			stream.PutOrGet(ref this.dividentRateTeamA);
			stream.PutOrGet(ref this.dividentRateTeamB);
		}

		// Token: 0x04009AB9 RID: 39609
		public int eventIndex;

		// Token: 0x04009ABA RID: 39610
		public EventBetTeam winTeam;

		// Token: 0x04009ABB RID: 39611
		public long totalBetCountTeamA;

		// Token: 0x04009ABC RID: 39612
		public long totalBetCountTeamB;

		// Token: 0x04009ABD RID: 39613
		public int userCountTeamA;

		// Token: 0x04009ABE RID: 39614
		public int userCountTeamB;

		// Token: 0x04009ABF RID: 39615
		public int winRateTeamA;

		// Token: 0x04009AC0 RID: 39616
		public int winRateTeamB;

		// Token: 0x04009AC1 RID: 39617
		public float dividentRateTeamA;

		// Token: 0x04009AC2 RID: 39618
		public float dividentRateTeamB;
	}
}
