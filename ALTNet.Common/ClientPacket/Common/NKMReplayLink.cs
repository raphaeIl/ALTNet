using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011BD RID: 4541
	public sealed class NKMReplayLink : ISerializable
	{
		// Token: 0x0600A98F RID: 43407 RVA: 0x003858F4 File Offset: 0x00383AF4
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.url);
			stream.PutOrGet(ref this.checksum);
		}

		// Token: 0x04009D54 RID: 40276
		public string url;

		// Token: 0x04009D55 RID: 40277
		public string checksum;
	}
}
