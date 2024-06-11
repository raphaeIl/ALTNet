using System;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EDE RID: 3806
	public sealed class NKMInteriorData : ISerializable
	{
		// Token: 0x0600A40F RID: 41999 RVA: 0x0037CFAB File Offset: 0x0037B1AB
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.itemId);
			stream.PutOrGet(ref this.count);
		}

		// Token: 0x04009554 RID: 38228
		public int itemId;

		// Token: 0x04009555 RID: 38229
		public long count;
	}
}
