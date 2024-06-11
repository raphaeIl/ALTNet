using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020004A7 RID: 1191
	public class NKMShipCmdModule : ISerializable
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x000ACCE1 File Offset: 0x000AAEE1
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMShipCmdSlot>(ref this.slots);
		}

		// Token: 0x040022EE RID: 8942
		public NKMShipCmdSlot[] slots = new NKMShipCmdSlot[2];
	}
}
