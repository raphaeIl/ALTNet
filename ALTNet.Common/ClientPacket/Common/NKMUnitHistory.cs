using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011AB RID: 4523
	public sealed class NKMUnitHistory : ISerializable
	{
		// Token: 0x0600A971 RID: 43377 RVA: 0x003853D5 File Offset: 0x003835D5
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.maxLevel);
			stream.PutOrGet(ref this.maxLoyalty);
		}

		// Token: 0x04009CEF RID: 40175
		public int unitId;

		// Token: 0x04009CF0 RID: 40176
		public int maxLevel;

		// Token: 0x04009CF1 RID: 40177
		public int maxLoyalty;
	}
}
