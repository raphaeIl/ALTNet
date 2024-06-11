using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F3D RID: 3901
	public sealed class NKMShadowPalace : ISerializable
	{
		// Token: 0x0600A4C9 RID: 42185 RVA: 0x0037E0D0 File Offset: 0x0037C2D0
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.currentPalaceId);
			stream.PutOrGet(ref this.life);
			stream.PutOrGet<NKMPalaceData>(ref this.palaceDataList);
			stream.PutOrGet(ref this.rewardMultiply);
		}

		// Token: 0x04009639 RID: 38457
		public int currentPalaceId;

		// Token: 0x0400963A RID: 38458
		public int life;

		// Token: 0x0400963B RID: 38459
		public List<NKMPalaceData> palaceDataList = new List<NKMPalaceData>();

		// Token: 0x0400963C RID: 38460
		public int rewardMultiply = 1;
	}
}
