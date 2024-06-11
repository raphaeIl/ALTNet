using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011BE RID: 4542
	public sealed class NKMTournamentReplayLink : ISerializable
	{
		// Token: 0x0600A991 RID: 43409 RVA: 0x00385916 File Offset: 0x00383B16
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.tournamentId);
			stream.PutOrGetEnum<NKMTournamentGroups>(ref this.groupIndex);
			stream.PutOrGet(ref this.slotIndex);
			stream.PutOrGet<NKMReplayLink>(ref this.replayLink);
		}

		// Token: 0x04009D56 RID: 40278
		public int tournamentId;

		// Token: 0x04009D57 RID: 40279
		public NKMTournamentGroups groupIndex;

		// Token: 0x04009D58 RID: 40280
		public int slotIndex;

		// Token: 0x04009D59 RID: 40281
		public NKMReplayLink replayLink = new NKMReplayLink();
	}
}
