using System;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x020010EA RID: 4330
	public sealed class NKMEventBetPrivate : ISerializable
	{
		// Token: 0x0600A803 RID: 43011 RVA: 0x00382F11 File Offset: 0x00381111
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventIndex);
			stream.PutOrGetEnum<EventBetTeam>(ref this.selectTeam);
			stream.PutOrGet(ref this.currentBetCount);
		}

		// Token: 0x04009AC9 RID: 39625
		public int eventIndex;

		// Token: 0x04009ACA RID: 39626
		public EventBetTeam selectTeam;

		// Token: 0x04009ACB RID: 39627
		public long currentBetCount;
	}
}
