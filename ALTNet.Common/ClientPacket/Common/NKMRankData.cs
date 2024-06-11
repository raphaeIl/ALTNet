using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001186 RID: 4486
	public sealed class NKMRankData : ISerializable
	{
		// Token: 0x0600A937 RID: 43319 RVA: 0x003849C0 File Offset: 0x00382BC0
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.rank);
			stream.PutOrGet(ref this.score);
		}

		// Token: 0x04009C39 RID: 39993
		public int rank;

		// Token: 0x04009C3A RID: 39994
		public long score;
	}
}
