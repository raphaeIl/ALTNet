using System;
using Cs.Protocol;

namespace ClientPacket.Contract
{
	// Token: 0x02001105 RID: 4357
	public sealed class NKMCustomPickupContract : ISerializable
	{
		// Token: 0x0600A839 RID: 43065 RVA: 0x003834A6 File Offset: 0x003816A6
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.customPickupId);
			stream.PutOrGet(ref this.totalUseCount);
			stream.PutOrGet(ref this.customPickupTargetUnitId);
			stream.PutOrGet(ref this.currentSelectCount);
		}

		// Token: 0x04009B14 RID: 39700
		public int customPickupId;

		// Token: 0x04009B15 RID: 39701
		public int totalUseCount;

		// Token: 0x04009B16 RID: 39702
		public int customPickupTargetUnitId;

		// Token: 0x04009B17 RID: 39703
		public int currentSelectCount;
	}
}
