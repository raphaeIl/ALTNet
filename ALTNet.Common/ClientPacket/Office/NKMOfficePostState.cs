using System;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EDF RID: 3807
	public sealed class NKMOfficePostState : ISerializable
	{
		// Token: 0x0600A411 RID: 42001 RVA: 0x0037CFCD File Offset: 0x0037B1CD
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.broadcastExecution);
			stream.PutOrGet(ref this.sendCount);
			stream.PutOrGet(ref this.recvCount);
			stream.PutOrGet(ref this.nextResetDate);
		}

		// Token: 0x04009556 RID: 38230
		public bool broadcastExecution;

		// Token: 0x04009557 RID: 38231
		public int sendCount;

		// Token: 0x04009558 RID: 38232
		public int recvCount;

		// Token: 0x04009559 RID: 38233
		public DateTime nextResetDate;
	}
}
