using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000483 RID: 1155
	public class NKMTacticalCommandData : ISerializable
	{
		// Token: 0x06001F9B RID: 8091 RVA: 0x00098124 File Offset: 0x00096324
		public virtual void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_TCID);
			stream.PutOrGet(ref this.m_Level);
			stream.PutOrGet(ref this.m_fCoolTimeNow);
			stream.PutOrGet(ref this.m_UseCount);
			stream.PutOrGet(ref this.m_ComboCount);
			stream.PutOrGet(ref this.m_fComboResetCoolTimeNow);
			stream.PutOrGet(ref this.m_bCoolTimeOn);
		}

		// Token: 0x0400210F RID: 8463
		public int m_TCID;

		// Token: 0x04002110 RID: 8464
		public byte m_Level = 1;

		// Token: 0x04002111 RID: 8465
		public float m_fCoolTimeNow;

		// Token: 0x04002112 RID: 8466
		public byte m_UseCount;

		// Token: 0x04002113 RID: 8467
		public byte m_ComboCount;

		// Token: 0x04002114 RID: 8468
		public float m_fComboResetCoolTimeNow;

		// Token: 0x04002115 RID: 8469
		public bool m_bCoolTimeOn = true;
	}
}
