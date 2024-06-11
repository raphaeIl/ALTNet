using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A7 RID: 4519
	public sealed class RecallHistoryInfo : ISerializable
	{
		// Token: 0x0600A969 RID: 43369 RVA: 0x00385298 File Offset: 0x00383498
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.lastUpdateDate);
		}

		// Token: 0x04009CD9 RID: 40153
		public int unitId;

		// Token: 0x04009CDA RID: 40154
		public DateTime lastUpdateDate;
	}
}
