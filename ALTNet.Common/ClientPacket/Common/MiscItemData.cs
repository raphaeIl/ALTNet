using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001193 RID: 4499
	public sealed class MiscItemData : ISerializable
	{
		// Token: 0x0600A943 RID: 43331 RVA: 0x00384BFC File Offset: 0x00382DFC
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.itemId);
			stream.PutOrGet(ref this.count);
		}

		// Token: 0x04009C75 RID: 40053
		public int itemId;

		// Token: 0x04009C76 RID: 40054
		public int count;
	}
}
