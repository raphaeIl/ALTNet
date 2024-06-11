using System;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x020010E9 RID: 4329
	public sealed class NKMEventBetRecord : ISerializable
	{
		// Token: 0x0600A801 RID: 43009 RVA: 0x00382EB4 File Offset: 0x003810B4
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventIndex);
			stream.PutOrGet(ref this.updatedTime);
			stream.PutOrGet(ref this.winRateTeamA);
			stream.PutOrGet(ref this.winRateTeamB);
			stream.PutOrGet(ref this.dividentRateTeamA);
			stream.PutOrGet(ref this.dividentRateTeamB);
		}

		// Token: 0x04009AC3 RID: 39619
		public int eventIndex;

		// Token: 0x04009AC4 RID: 39620
		public DateTime updatedTime;

		// Token: 0x04009AC5 RID: 39621
		public int winRateTeamA;

		// Token: 0x04009AC6 RID: 39622
		public int winRateTeamB;

		// Token: 0x04009AC7 RID: 39623
		public float dividentRateTeamA;

		// Token: 0x04009AC8 RID: 39624
		public float dividentRateTeamB;
	}
}
