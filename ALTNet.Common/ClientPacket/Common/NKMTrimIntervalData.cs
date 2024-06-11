using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011B1 RID: 4529
	public sealed class NKMTrimIntervalData : ISerializable
	{
		// Token: 0x0600A97B RID: 43387 RVA: 0x00385628 File Offset: 0x00383828
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.trimTryCount);
			stream.PutOrGet(ref this.trimRetryCount);
			stream.PutOrGet(ref this.trimRestoreCount);
		}

		// Token: 0x04009D18 RID: 40216
		public int trimTryCount;

		// Token: 0x04009D19 RID: 40217
		public int trimRetryCount;

		// Token: 0x04009D1A RID: 40218
		public int trimRestoreCount;
	}
}
