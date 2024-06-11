using System;
using Cs.Protocol;
using NKM.Templet;

namespace ClientPacket.Common
{
	// Token: 0x020011B2 RID: 4530
	public sealed class NKMTrimClearData : ISerializable
	{
		// Token: 0x0600A97D RID: 43389 RVA: 0x00385656 File Offset: 0x00383856
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.isWin);
			stream.PutOrGet(ref this.trimId);
			stream.PutOrGet(ref this.trimLevel);
			stream.PutOrGet(ref this.score);
			stream.PutOrGet<NKMRewardData>(ref this.rewardData);
		}

		// Token: 0x04009D1B RID: 40219
		public bool isWin;

		// Token: 0x04009D1C RID: 40220
		public int trimId;

		// Token: 0x04009D1D RID: 40221
		public int trimLevel;

		// Token: 0x04009D1E RID: 40222
		public int score;

		// Token: 0x04009D1F RID: 40223
		public NKMRewardData rewardData;
	}
}
