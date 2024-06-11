using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000419 RID: 1049
	public class NKMDynamicRespawnUnitData : ISerializable
	{
		// Token: 0x06001B75 RID: 7029 RVA: 0x0007A889 File Offset: 0x00078A89
		public virtual void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMUnitData>(ref this.m_NKMUnitData);
			stream.PutOrGet(ref this.m_MasterGameUnitUID);
			stream.PutOrGet(ref this.m_bLoadedServer);
			stream.PutOrGet(ref this.m_bLoadedClient);
		}

		// Token: 0x04001C1C RID: 7196
		public NKMUnitData m_NKMUnitData = new NKMUnitData();

		// Token: 0x04001C1D RID: 7197
		public short m_MasterGameUnitUID;

		// Token: 0x04001C1E RID: 7198
		public bool m_bLoadedServer;

		// Token: 0x04001C1F RID: 7199
		public bool m_bLoadedClient;
	}
}
