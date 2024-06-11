using System;
using Cs.Protocol;

namespace NKM.Templet
{
	// Token: 0x0200060A RID: 1546
	public class NKMRewardUnitExpData : ISerializable
	{
		// Token: 0x06002F51 RID: 12113 RVA: 0x000E8845 File Offset: 0x000E6A45
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_UnitUid);
			stream.PutOrGet(ref this.m_Exp);
			stream.PutOrGet(ref this.m_BonusExp);
			stream.PutOrGet(ref this.m_BonusRatio);
		}

		// Token: 0x04002F0A RID: 12042
		public long m_UnitUid;

		// Token: 0x04002F0B RID: 12043
		public int m_Exp;

		// Token: 0x04002F0C RID: 12044
		public int m_BonusExp;

		// Token: 0x04002F0D RID: 12045
		public int m_BonusRatio;
	}
}
