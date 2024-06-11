using System;
using Cs.Protocol;

namespace NKM.Templet
{
	// Token: 0x0200060C RID: 1548
	public class NKMRewardInfo : ISerializable
	{

		// Token: 0x06002F54 RID: 12116 RVA: 0x000E88D5 File Offset: 0x000E6AD5
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_REWARD_TYPE>(ref this.rewardType);
			stream.PutOrGetEnum<NKM_ITEM_PAYMENT_TYPE>(ref this.paymentType);
			stream.PutOrGet(ref this.ID);
			stream.PutOrGet(ref this.Count);
		}

		// Token: 0x04002F13 RID: 12051
		public NKM_REWARD_TYPE rewardType;

		// Token: 0x04002F14 RID: 12052
		public NKM_ITEM_PAYMENT_TYPE paymentType;

		// Token: 0x04002F15 RID: 12053
		public int ID;

		// Token: 0x04002F16 RID: 12054
		public int Count;
	}
}
