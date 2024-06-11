using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011BF RID: 4543
	public sealed class PvpCastingVoteData : ISerializable
	{
		// Token: 0x0600A993 RID: 43411 RVA: 0x0038595B File Offset: 0x00383B5B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitIdList);
			stream.PutOrGet(ref this.shipIdList);
			stream.PutOrGet(ref this.operatorIdList);
		}

		// Token: 0x04009D5A RID: 40282
		public List<int> unitIdList = new List<int>();

		// Token: 0x04009D5B RID: 40283
		public List<int> shipIdList = new List<int>();

		// Token: 0x04009D5C RID: 40284
		public List<int> operatorIdList = new List<int>();
	}
}
