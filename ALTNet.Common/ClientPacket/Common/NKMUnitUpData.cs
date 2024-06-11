using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A1 RID: 4513
	public sealed class NKMUnitUpData : ISerializable
	{
		// Token: 0x0600A95D RID: 43357 RVA: 0x00385187 File Offset: 0x00383387
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.upLevel);
		}

		// Token: 0x04009CCA RID: 40138
		public int unitId;

		// Token: 0x04009CCB RID: 40139
		public byte upLevel;
	}
}
