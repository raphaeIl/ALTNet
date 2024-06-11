using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011B8 RID: 4536
	public sealed class NKMDefenceProfileData : ISerializable
	{
		// Token: 0x0600A989 RID: 43401 RVA: 0x0038581B File Offset: 0x00383A1B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.defenceId);
			stream.PutOrGet(ref this.bestPoint);
			stream.PutOrGet<NKMAsyncDeckData>(ref this.profileDeck);
			stream.PutOrGet<NKMEmblemData>(ref this.emblems);
		}

		// Token: 0x04009D39 RID: 40249
		public int defenceId;

		// Token: 0x04009D3A RID: 40250
		public int bestPoint;

		// Token: 0x04009D3B RID: 40251
		public NKMAsyncDeckData profileDeck = new NKMAsyncDeckData();

		// Token: 0x04009D3C RID: 40252
		public List<NKMEmblemData> emblems = new List<NKMEmblemData>();
	}
}
