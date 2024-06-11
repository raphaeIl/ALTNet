using System;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x020011B3 RID: 4531
	public sealed class NKMShipModuleCandidate : ISerializable
	{
		// Token: 0x0600A97F RID: 43391 RVA: 0x0038569C File Offset: 0x0038389C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.shipUid);
			stream.PutOrGet(ref this.moduleId);
			stream.PutOrGet<NKMShipCmdModule>(ref this.slotCandidate);
		}

		// Token: 0x04009D20 RID: 40224
		public long shipUid;

		// Token: 0x04009D21 RID: 40225
		public int moduleId;

		// Token: 0x04009D22 RID: 40226
		public NKMShipCmdModule slotCandidate;
	}
}
