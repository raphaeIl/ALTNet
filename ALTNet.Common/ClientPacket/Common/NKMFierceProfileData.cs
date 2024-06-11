using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x02001198 RID: 4504
	public sealed class NKMFierceProfileData : ISerializable
	{
		// Token: 0x0600A94B RID: 43339 RVA: 0x00384EC8 File Offset: 0x003830C8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.fierceBossGroupId);
			stream.PutOrGet<NKMDummyDeckData>(ref this.profileDeck);
			stream.PutOrGet(ref this.operationPower);
			stream.PutOrGet(ref this.totalPoint);
			stream.PutOrGet(ref this.penaltyPoint);
			stream.PutOrGet(ref this.penaltyIds);
			stream.PutOrGet<NKMEmblemData>(ref this.emblems);
		}

		// Token: 0x04009C9D RID: 40093
		public int fierceBossGroupId;

		// Token: 0x04009C9E RID: 40094
		public NKMDummyDeckData profileDeck;

		// Token: 0x04009C9F RID: 40095
		public int operationPower;

		// Token: 0x04009CA0 RID: 40096
		public int totalPoint;

		// Token: 0x04009CA1 RID: 40097
		public int penaltyPoint;

		// Token: 0x04009CA2 RID: 40098
		public List<int> penaltyIds = new List<int>();

		// Token: 0x04009CA3 RID: 40099
		public List<NKMEmblemData> emblems = new List<NKMEmblemData>();
	}
}
