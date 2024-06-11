using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001182 RID: 4482
	public sealed class NKMEmblemData : ISerializable
	{
		// Token: 0x0600A92F RID: 43311 RVA: 0x00384886 File Offset: 0x00382A86
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.id);
			stream.PutOrGet(ref this.count);
		}

		// Token: 0x04009C24 RID: 39972
		public int id;

		// Token: 0x04009C25 RID: 39973
		public long count;
	}
}
