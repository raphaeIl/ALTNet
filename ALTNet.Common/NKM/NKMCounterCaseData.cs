using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200050E RID: 1294
	public class NKMCounterCaseData : ISerializable
	{
		// Token: 0x06002490 RID: 9360 RVA: 0x000BFD79 File Offset: 0x000BDF79
		public NKMCounterCaseData()
		{
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000BFD81 File Offset: 0x000BDF81
		public NKMCounterCaseData(int dungeonID, bool unlocked)
		{
			this.m_DungeonID = dungeonID;
			this.m_Unlocked = unlocked;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000BFD97 File Offset: 0x000BDF97
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_DungeonID);
			stream.PutOrGet(ref this.m_Unlocked);
		}

		// Token: 0x04002703 RID: 9987
		public int m_DungeonID;

		// Token: 0x04002704 RID: 9988
		public bool m_Unlocked;
	}
}
