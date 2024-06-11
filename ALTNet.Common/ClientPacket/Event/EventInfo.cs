using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x0200109E RID: 4254
	public sealed class EventInfo : ISerializable
	{
		// Token: 0x0600A775 RID: 42869 RVA: 0x003822B2 File Offset: 0x003804B2
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<BingoInfo>(ref this.bingoInfo);
		}

		// Token: 0x04009A01 RID: 39425
		public List<BingoInfo> bingoInfo = new List<BingoInfo>();
	}
}
