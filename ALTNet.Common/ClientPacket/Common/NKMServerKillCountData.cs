using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A8 RID: 4520
	public sealed class NKMServerKillCountData : ISerializable
	{
		// Token: 0x0600A96B RID: 43371 RVA: 0x003852BA File Offset: 0x003834BA
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.killCountId);
			stream.PutOrGet(ref this.killCount);
		}

		// Token: 0x04009CDB RID: 40155
		public int killCountId;

		// Token: 0x04009CDC RID: 40156
		public long killCount;
	}
}
