using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011AE RID: 4526
	public sealed class NKMIntervalData : ISerializable
	{
		// Token: 0x0600A977 RID: 43383 RVA: 0x00385548 File Offset: 0x00383748
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.key);
			stream.PutOrGet(ref this.strKey);
			stream.PutOrGet(ref this.startDate);
			stream.PutOrGet(ref this.endDate);
			stream.PutOrGet(ref this.repeatStartDate);
			stream.PutOrGet(ref this.repeatEndDate);
		}

		// Token: 0x04009CFE RID: 40190
		public int key;

		// Token: 0x04009CFF RID: 40191
		public string strKey;

		// Token: 0x04009D00 RID: 40192
		public DateTime startDate;

		// Token: 0x04009D01 RID: 40193
		public DateTime endDate;

		// Token: 0x04009D02 RID: 40194
		public int repeatStartDate;

		// Token: 0x04009D03 RID: 40195
		public int repeatEndDate;
	}
}
