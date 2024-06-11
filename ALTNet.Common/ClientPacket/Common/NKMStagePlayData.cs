using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x0200119A RID: 4506
	public sealed class NKMStagePlayData : ISerializable
	{
		// Token: 0x0600A94F RID: 43343 RVA: 0x00384F78 File Offset: 0x00383178
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.stageId);
			stream.PutOrGet(ref this.playCount);
			stream.PutOrGet(ref this.restoreCount);
			stream.PutOrGet(ref this.bestKillCount);
			stream.PutOrGet(ref this.nextResetDate);
			stream.PutOrGet(ref this.bestClearTimeSec);
			stream.PutOrGet(ref this.totalPlayCount);
		}

		// Token: 0x04009CA7 RID: 40103
		public int stageId;

		// Token: 0x04009CA8 RID: 40104
		public long playCount;

		// Token: 0x04009CA9 RID: 40105
		public long restoreCount;

		// Token: 0x04009CAA RID: 40106
		public long bestKillCount;

		// Token: 0x04009CAB RID: 40107
		public DateTime nextResetDate;

		// Token: 0x04009CAC RID: 40108
		public int bestClearTimeSec;

		// Token: 0x04009CAD RID: 40109
		public long totalPlayCount;
	}
}
