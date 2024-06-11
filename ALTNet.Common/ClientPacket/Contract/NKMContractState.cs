using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Contract
{
	// Token: 0x02001100 RID: 4352
	public sealed class NKMContractState : ISerializable
	{
		// Token: 0x0600A82F RID: 43055 RVA: 0x00383370 File Offset: 0x00381570
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.contractId);
			stream.PutOrGet(ref this.remainFreeChance);
			stream.PutOrGet(ref this.nextResetDate);
			stream.PutOrGet(ref this.isActive);
			stream.PutOrGet(ref this.totalUseCount);
			stream.PutOrGet(ref this.dailyUseCount);
			stream.PutOrGet(ref this.bonusCandidate);
		}

		// Token: 0x04009B02 RID: 39682
		public int contractId;

		// Token: 0x04009B03 RID: 39683
		public int remainFreeChance;

		// Token: 0x04009B04 RID: 39684
		public DateTime nextResetDate;

		// Token: 0x04009B05 RID: 39685
		public bool isActive;

		// Token: 0x04009B06 RID: 39686
		public int totalUseCount;

		// Token: 0x04009B07 RID: 39687
		public int dailyUseCount;

		// Token: 0x04009B08 RID: 39688
		public List<int> bonusCandidate = new List<int>();
	}
}
