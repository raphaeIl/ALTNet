using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A0 RID: 4512
	public sealed class NKMAdditionalReward : ISerializable
	{
		// Token: 0x0600A95B RID: 43355 RVA: 0x00385159 File Offset: 0x00383359
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.guildExpDelta);
			stream.PutOrGet(ref this.unionPointDelta);
			stream.PutOrGet(ref this.eventPassExpDelta);
		}

		// Token: 0x04009CC7 RID: 40135
		public long guildExpDelta;

		// Token: 0x04009CC8 RID: 40136
		public long unionPointDelta;

		// Token: 0x04009CC9 RID: 40137
		public long eventPassExpDelta;
	}
}
