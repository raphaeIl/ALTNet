using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003E2 RID: 994
	public sealed class NKMDeckSet : ISerializable
	{
		// Token: 0x06001A15 RID: 6677 RVA: 0x000714EA File Offset: 0x0006F6EA
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_DECK_TYPE>(ref this.type);
			stream.PutOrGet<NKMDeckData>(ref this.decks);
		}
		
		// Token: 0x0400134E RID: 4942
		private NKM_DECK_TYPE type;

		// Token: 0x0400134F RID: 4943
		private List<NKMDeckData> decks = new List<NKMDeckData>();
	}
}
