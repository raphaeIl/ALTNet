using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003C9 RID: 969
	public class NKMMoldItemData : ISerializable
	{
		// Token: 0x06001939 RID: 6457 RVA: 0x000697FA File Offset: 0x000679FA
		public NKMMoldItemData()
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00069802 File Offset: 0x00067A02
		public NKMMoldItemData(int moldID, long Count)
		{
			this.m_MoldID = moldID;
			this.m_Count = Count;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00069818 File Offset: 0x00067A18
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_MoldID);
			stream.PutOrGet(ref this.m_Count);
		}

		// Token: 0x040011EB RID: 4587
		public int m_MoldID;

		// Token: 0x040011EC RID: 4588
		public long m_Count;
	}
}
