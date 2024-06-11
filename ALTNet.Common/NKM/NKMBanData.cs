using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000511 RID: 1297
	public class NKMBanData : ISerializable
	{
		// Token: 0x06002499 RID: 9369 RVA: 0x000BFE83 File Offset: 0x000BE083
		public void DeepCopyFromSource(NKMBanData source)
		{
			this.m_UnitID = source.m_UnitID;
			this.m_BanLevel = source.m_BanLevel;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x000BFE9D File Offset: 0x000BE09D
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_UnitID);
			stream.PutOrGet(ref this.m_BanLevel);
		}

		// Token: 0x0400270A RID: 9994
		public int m_UnitID;

		// Token: 0x0400270B RID: 9995
		public byte m_BanLevel;
	}
}
