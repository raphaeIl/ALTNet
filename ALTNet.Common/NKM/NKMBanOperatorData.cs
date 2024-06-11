using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000513 RID: 1299
	public class NKMBanOperatorData : ISerializable
	{
		// Token: 0x0600249F RID: 9375 RVA: 0x000BFEFB File Offset: 0x000BE0FB
		public void DeepCopyFromSource(NKMBanOperatorData source)
		{
			this.m_OperatorID = source.m_OperatorID;
			this.m_BanLevel = source.m_BanLevel;
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000BFF15 File Offset: 0x000BE115
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_OperatorID);
			stream.PutOrGet(ref this.m_BanLevel);
		}

		// Token: 0x0400270E RID: 9998
		public int m_OperatorID;

		// Token: 0x0400270F RID: 9999
		public byte m_BanLevel;
	}
}
