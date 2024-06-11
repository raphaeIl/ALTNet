using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x0200109D RID: 4253
	public sealed class BingoInfo : ISerializable
	{
		// Token: 0x0600A773 RID: 42867 RVA: 0x0038224B File Offset: 0x0038044B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventId);
			stream.PutOrGet(ref this.tileValueList);
			stream.PutOrGet(ref this.markTileIndexList);
			stream.PutOrGet(ref this.rewardList);
			stream.PutOrGet(ref this.mileage);
		}

		// Token: 0x040099FC RID: 39420
		public int eventId;

		// Token: 0x040099FD RID: 39421
		public List<int> tileValueList = new List<int>();

		// Token: 0x040099FE RID: 39422
		public List<int> markTileIndexList = new List<int>();

		// Token: 0x040099FF RID: 39423
		public List<int> rewardList = new List<int>();

		// Token: 0x04009A00 RID: 39424
		public int mileage;
	}
}
