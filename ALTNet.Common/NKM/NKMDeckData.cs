using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003E0 RID: 992
	public sealed class NKMDeckData : ISerializable
	{
		// Token: 0x060019F5 RID: 6645 RVA: 0x00070F74 File Offset: 0x0006F174
		public NKMDeckData()
		{
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00070F9C File Offset: 0x0006F19C
		public NKMDeckData(NKM_DECK_TYPE deckType)
		{
			int i = (deckType == NKM_DECK_TYPE.NDT_RAID) ? 16 : 8;
			while (i > this.m_listDeckUnitUID.Count)
			{
				this.m_listDeckUnitUID.Add(0L);
			}
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00070FF4 File Offset: 0x0006F1F4
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_DeckName);
			stream.PutOrGet(ref this.m_ShipUID);
			stream.PutOrGet(ref this.m_OperatorUID);
			stream.PutOrGet(ref this.m_listDeckUnitUID);
			stream.PutOrGet(ref this.m_LeaderIndex);
			stream.PutOrGetEnum<NKM_DECK_STATE>(ref this.m_DeckState);
		}

		// Token: 0x04001343 RID: 4931
		public const int InvalidIndex = -1;

		// Token: 0x04001344 RID: 4932
		public string m_DeckName = string.Empty;

		// Token: 0x04001345 RID: 4933
		public long m_ShipUID;

		// Token: 0x04001346 RID: 4934
		public long m_OperatorUID;

		// Token: 0x04001347 RID: 4935
		public List<long> m_listDeckUnitUID = new List<long>();

		// Token: 0x04001348 RID: 4936
		public sbyte m_LeaderIndex = -1;

		// Token: 0x04001349 RID: 4937
		public NKM_DECK_STATE m_DeckState;

		// Token: 0x0400134A RID: 4938
		public int power;
	}
}
