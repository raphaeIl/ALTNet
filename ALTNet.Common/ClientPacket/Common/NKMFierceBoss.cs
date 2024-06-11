using System;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x0200119C RID: 4508
	public sealed class NKMFierceBoss : ISerializable
	{
		// Token: 0x0600A953 RID: 43347 RVA: 0x00385028 File Offset: 0x00383228
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.bossId);
			stream.PutOrGet(ref this.point);
			stream.PutOrGet(ref this.rankNumber);
			stream.PutOrGet(ref this.rankPercent);
			stream.PutOrGet<NKMEventDeckData>(ref this.deckData);
			stream.PutOrGet(ref this.isCleared);
		}

		// Token: 0x04009CB3 RID: 40115
		public int bossId;

		// Token: 0x04009CB4 RID: 40116
		public int point;

		// Token: 0x04009CB5 RID: 40117
		public int rankNumber;

		// Token: 0x04009CB6 RID: 40118
		public int rankPercent;

		// Token: 0x04009CB7 RID: 40119
		public NKMEventDeckData deckData;

		// Token: 0x04009CB8 RID: 40120
		public bool isCleared;
	}
}
