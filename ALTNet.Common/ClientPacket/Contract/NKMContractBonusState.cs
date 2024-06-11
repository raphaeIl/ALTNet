using System;
using Cs.Protocol;

namespace ClientPacket.Contract
{
	// Token: 0x02001101 RID: 4353
	public sealed class NKMContractBonusState : ISerializable
	{
		// Token: 0x0600A831 RID: 43057 RVA: 0x003833E4 File Offset: 0x003815E4
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.bonusGroupId);
			stream.PutOrGet(ref this.useCount);
			stream.PutOrGet(ref this.resetCount);
		}

		// Token: 0x04009B09 RID: 39689
		public int bonusGroupId;

		// Token: 0x04009B0A RID: 39690
		public int useCount;

		// Token: 0x04009B0B RID: 39691
		public int resetCount;
	}
}
