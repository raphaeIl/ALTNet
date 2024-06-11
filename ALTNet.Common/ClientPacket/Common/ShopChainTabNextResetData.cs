using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001183 RID: 4483
	public sealed class ShopChainTabNextResetData : ISerializable
	{
		// Token: 0x0600A931 RID: 43313 RVA: 0x003848A8 File Offset: 0x00382AA8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.tabType);
			stream.PutOrGet(ref this.subIndex);
			stream.PutOrGet(ref this.nextResetUtc);
		}

		// Token: 0x04009C26 RID: 39974
		public string tabType;

		// Token: 0x04009C27 RID: 39975
		public int subIndex;

		// Token: 0x04009C28 RID: 39976
		public DateTime nextResetUtc;
	}
}
