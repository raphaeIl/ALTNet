using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x020011B7 RID: 4535
	public sealed class NKMGameEndData : ISerializable
	{
		// Token: 0x0600A987 RID: 43399 RVA: 0x0038576C File Offset: 0x0038396C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.win);
			stream.PutOrGet(ref this.giveup);
			stream.PutOrGet(ref this.restart);
			stream.PutOrGet<NKMDungeonClearData>(ref this.dungeonClearData);
			stream.PutOrGet<NKMDeckIndex>(ref this.deckIndex);
			stream.PutOrGet<NKMGameRecord>(ref this.gameRecord);
			stream.PutOrGet<UnitLoyaltyUpdateData>(ref this.updatedUnits);
			stream.PutOrGet<NKMItemMiscData>(ref this.costItemDataList);
			stream.PutOrGet(ref this.killCountDelta);
			stream.PutOrGet<NKMKillCountData>(ref this.killCountData);
			stream.PutOrGet(ref this.totalPlayTime);
		}

		// Token: 0x04009D2E RID: 40238
		public bool win;

		// Token: 0x04009D2F RID: 40239
		public bool giveup;

		// Token: 0x04009D30 RID: 40240
		public bool restart;

		// Token: 0x04009D31 RID: 40241
		public NKMDungeonClearData dungeonClearData;

		// Token: 0x04009D32 RID: 40242
		public NKMDeckIndex deckIndex;

		// Token: 0x04009D33 RID: 40243
		public NKMGameRecord gameRecord;

		// Token: 0x04009D34 RID: 40244
		public List<UnitLoyaltyUpdateData> updatedUnits = new List<UnitLoyaltyUpdateData>();

		// Token: 0x04009D35 RID: 40245
		public List<NKMItemMiscData> costItemDataList = new List<NKMItemMiscData>();

		// Token: 0x04009D36 RID: 40246
		public long killCountDelta;

		// Token: 0x04009D37 RID: 40247
		public NKMKillCountData killCountData;

		// Token: 0x04009D38 RID: 40248
		public float totalPlayTime;
	}
}
