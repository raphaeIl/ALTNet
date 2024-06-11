using System;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x02001187 RID: 4487
	public sealed class NKMEquipTuningCandidate : ISerializable
	{
		// Token: 0x0600A939 RID: 43321 RVA: 0x003849E2 File Offset: 0x00382BE2
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.equipUid);
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.option1);
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.option2);
			stream.PutOrGet(ref this.setOptionId);
		}

		// Token: 0x04009C3B RID: 39995
		public long equipUid;

		// Token: 0x04009C3C RID: 39996
		public NKM_STAT_TYPE option1;

		// Token: 0x04009C3D RID: 39997
		public NKM_STAT_TYPE option2;

		// Token: 0x04009C3E RID: 39998
		public int setOptionId;
	}
}
