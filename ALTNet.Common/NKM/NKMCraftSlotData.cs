using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003C8 RID: 968
	public class NKMCraftSlotData : ISerializable
	{
		// Token: 0x06001936 RID: 6454 RVA: 0x0006978F File Offset: 0x0006798F
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.Index);
			stream.PutOrGet(ref this.MoldID);
			stream.PutOrGet(ref this.Count);
			stream.PutOrGet(ref this.CompleteDate);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000697C4 File Offset: 0x000679C4
		public NKM_CRAFT_SLOT_STATE GetState(DateTime curTimeUTC)
		{
			NKM_CRAFT_SLOT_STATE result = NKM_CRAFT_SLOT_STATE.NECSS_EMPTY;
			if (this.MoldID > 0)
			{
				if (curTimeUTC.Ticks >= this.CompleteDate)
				{
					result = NKM_CRAFT_SLOT_STATE.NECSS_COMPLETED;
				}
				else
				{
					result = NKM_CRAFT_SLOT_STATE.NECSS_CREATING_NOW;
				}
			}
			return result;
		}

		// Token: 0x040011E7 RID: 4583
		public byte Index;

		// Token: 0x040011E8 RID: 4584
		public int MoldID;

		// Token: 0x040011E9 RID: 4585
		public int Count;

		// Token: 0x040011EA RID: 4586
		public long CompleteDate;
	}
}
