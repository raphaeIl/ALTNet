using System;
using Cs.Protocol;

namespace ClientPacket.Contract
{
	// Token: 0x02001104 RID: 4356
	public sealed class NKMInstantContract : ISerializable
	{
		// Token: 0x0600A837 RID: 43063 RVA: 0x00383484 File Offset: 0x00381684
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.contractId);
			stream.PutOrGet(ref this.endDate);
		}

		// Token: 0x04009B12 RID: 39698
		public int contractId;

		// Token: 0x04009B13 RID: 39699
		public DateTime endDate;
	}
}
