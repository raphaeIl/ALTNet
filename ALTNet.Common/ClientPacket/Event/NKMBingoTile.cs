using System;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x0200109F RID: 4255
	public sealed class NKMBingoTile : ISerializable
	{
		// Token: 0x0600A777 RID: 42871 RVA: 0x003822D3 File Offset: 0x003804D3
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventId);
			stream.PutOrGet(ref this.tileIndex);
		}

		// Token: 0x04009A02 RID: 39426
		public int eventId;

		// Token: 0x04009A03 RID: 39427
		public int tileIndex;
	}
}
