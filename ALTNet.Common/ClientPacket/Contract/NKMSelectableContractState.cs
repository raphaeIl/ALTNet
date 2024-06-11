using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Contract
{
	// Token: 0x02001102 RID: 4354
	public sealed class NKMSelectableContractState : ISerializable
	{
		// Token: 0x0600A833 RID: 43059 RVA: 0x00383412 File Offset: 0x00381612
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.contractId);
			stream.PutOrGet(ref this.unitIdList);
			stream.PutOrGet(ref this.unitPoolChangeCount);
			stream.PutOrGet(ref this.isActive);
		}

		// Token: 0x04009B0C RID: 39692
		public int contractId;

		// Token: 0x04009B0D RID: 39693
		public List<int> unitIdList = new List<int>();

		// Token: 0x04009B0E RID: 39694
		public int unitPoolChangeCount;

		// Token: 0x04009B0F RID: 39695
		public bool isActive;
	}
}
