using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Contract
{
	// Token: 0x02001103 RID: 4355
	public sealed class MiscContractResult : ISerializable
	{
		// Token: 0x0600A835 RID: 43061 RVA: 0x00383457 File Offset: 0x00381657
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.miscItemId);
			stream.PutOrGet<NKMUnitData>(ref this.units);
		}

		// Token: 0x04009B10 RID: 39696
		public int miscItemId;

		// Token: 0x04009B11 RID: 39697
		public List<NKMUnitData> units = new List<NKMUnitData>();
	}
}
