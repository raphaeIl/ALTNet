using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011B9 RID: 4537
	public sealed class NKMPotentialOptionChangeCandidate : ISerializable
	{
		// Token: 0x0600A98B RID: 43403 RVA: 0x0038586B File Offset: 0x00383A6B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.equipUid);
			stream.PutOrGet(ref this.precision);
			stream.PutOrGet(ref this.socketIndex);
			stream.PutOrGet(ref this.accumulateCount);
		}

		// Token: 0x04009D3D RID: 40253
		public long equipUid;

		// Token: 0x04009D3E RID: 40254
		public int precision;

		// Token: 0x04009D3F RID: 40255
		public int socketIndex;

		// Token: 0x04009D40 RID: 40256
		public int accumulateCount;
	}
}
