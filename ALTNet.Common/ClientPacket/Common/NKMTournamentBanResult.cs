using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011AD RID: 4525
	public sealed class NKMTournamentBanResult : ISerializable
	{
		// Token: 0x0600A975 RID: 43381 RVA: 0x0038550D File Offset: 0x0038370D
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitBanList);
			stream.PutOrGet(ref this.shipBanList);
		}

		// Token: 0x04009CFC RID: 40188
		public HashSet<int> unitBanList = new HashSet<int>();

		// Token: 0x04009CFD RID: 40189
		public HashSet<int> shipBanList = new HashSet<int>();
	}
}
