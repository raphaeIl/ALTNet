using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	public class NKMGameTeamDeckData : ISerializable
	{

		// Token: 0x06001B74 RID: 7028 RVA: 0x0007A81C File Offset: 0x00078A1C
		public virtual void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_DataEncryptSeed);
			stream.PutOrGet(ref this.m_listUnitDeck);
			stream.PutOrGet(ref this.m_NextDeck);
			stream.PutOrGet(ref this.m_listUnitDeckUsed);
			stream.PutOrGet(ref this.m_listUnitDeckTomb);
			stream.PutOrGet(ref this.m_AutoRespawnIndex);
			stream.PutOrGet(ref this.m_AutoRespawnIndexAssist);
			stream.PutOrGet(ref this.m_dicRespawnLimitCount);
		}

		// Token: 0x04001C14 RID: 7188
		private byte m_DataEncryptSeed;

		// Token: 0x04001C15 RID: 7189
		private List<long> m_listUnitDeck = new List<long>();

		// Token: 0x04001C16 RID: 7190
		private long m_NextDeck;

		// Token: 0x04001C17 RID: 7191
		private List<long> m_listUnitDeckUsed = new List<long>();

		// Token: 0x04001C18 RID: 7192
		private List<long> m_listUnitDeckTomb = new List<long>();

		// Token: 0x04001C19 RID: 7193
		private int m_AutoRespawnIndex;

		// Token: 0x04001C1A RID: 7194
		private int m_AutoRespawnIndexAssist;

		// Token: 0x04001C1B RID: 7195
		private Dictionary<long, int> m_dicRespawnLimitCount = new Dictionary<long, int>();
	}
}
