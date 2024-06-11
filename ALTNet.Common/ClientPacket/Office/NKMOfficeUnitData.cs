using System;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EE2 RID: 3810
	public sealed class NKMOfficeUnitData : ISerializable
	{
		// Token: 0x0600A417 RID: 42007 RVA: 0x0037D0ED File Offset: 0x0037B2ED
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitUid);
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.skinId);
		}

		// Token: 0x04009565 RID: 38245
		public long unitUid;

		// Token: 0x04009566 RID: 38246
		public int unitId;

		// Token: 0x04009567 RID: 38247
		public int skinId;
	}
}
