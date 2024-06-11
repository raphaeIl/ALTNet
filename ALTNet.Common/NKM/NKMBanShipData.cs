using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000512 RID: 1298
	public class NKMBanShipData : ISerializable
	{
		// Token: 0x0600249C RID: 9372 RVA: 0x000BFEBF File Offset: 0x000BE0BF
		public void DeepCopyFromSource(NKMBanShipData source)
		{
			this.m_ShipGroupID = source.m_ShipGroupID;
			this.m_BanLevel = source.m_BanLevel;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x000BFED9 File Offset: 0x000BE0D9
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_ShipGroupID);
			stream.PutOrGet(ref this.m_BanLevel);
		}

		// Token: 0x0400270C RID: 9996
		public int m_ShipGroupID;

		// Token: 0x0400270D RID: 9997
		public byte m_BanLevel;
	}
}
