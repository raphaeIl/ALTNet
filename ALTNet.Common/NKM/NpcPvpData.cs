using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200045E RID: 1118
	public class NpcPvpData : ISerializable
	{
		// Token: 0x06001E82 RID: 7810 RVA: 0x000931FC File Offset: 0x000913FC
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.MaxTierCount);
			stream.PutOrGet(ref this.MaxOpenedTier);
		}

		// Token: 0x0400203E RID: 8254
		public int MaxTierCount;

		// Token: 0x0400203F RID: 8255
		public int MaxOpenedTier;
	}
}
