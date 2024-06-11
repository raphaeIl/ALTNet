using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x020010A1 RID: 4257
	public sealed class NKMEventCollectionInfo : ISerializable
	{
		// Token: 0x0600A77B RID: 42875 RVA: 0x00382323 File Offset: 0x00380523
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventId);
			stream.PutOrGet(ref this.goodsCollection);
		}

		// Token: 0x04009A07 RID: 39431
		public int eventId;

		// Token: 0x04009A08 RID: 39432
		public HashSet<int> goodsCollection = new HashSet<int>();
	}
}
