using System;
using Cs.Protocol;
using NKM;
using NKM.Templet;

namespace ClientPacket.Warfare
{
	// Token: 0x02000D64 RID: 3428
	public sealed class WarfareUnitData : ISerializable
	{
		// Token: 0x0600A124 RID: 41252 RVA: 0x00378C6C File Offset: 0x00376E6C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.warfareGameUnitUID);
			stream.PutOrGetEnum<WarfareUnitData.Type>(ref this.unitType);
			stream.PutOrGetEnum<NKM_WARFARE_ENEMY_ACTION_TYPE>(ref this.warfareEnemyActionType);
			stream.PutOrGet<NKMDeckIndex>(ref this.deckIndex);
			stream.PutOrGet(ref this.friendCode);
			stream.PutOrGet(ref this.dungeonID);
			stream.PutOrGet(ref this.hp);
			stream.PutOrGet(ref this.hpMax);
			stream.PutOrGet(ref this.isTurnEnd);
			stream.PutOrGet(ref this.supply);
			stream.PutOrGet(ref this.tileIndex);
			stream.PutOrGet(ref this.isTarget);
			stream.PutOrGet(ref this.isSummonee);
		}

		// Token: 0x04009196 RID: 37270
		public int warfareGameUnitUID;

		// Token: 0x04009197 RID: 37271
		public WarfareUnitData.Type unitType;

		// Token: 0x04009198 RID: 37272
		public NKM_WARFARE_ENEMY_ACTION_TYPE warfareEnemyActionType;

		// Token: 0x04009199 RID: 37273
		public NKMDeckIndex deckIndex;

		// Token: 0x0400919A RID: 37274
		public long friendCode;

		// Token: 0x0400919B RID: 37275
		public int dungeonID;

		// Token: 0x0400919C RID: 37276
		public float hp;

		// Token: 0x0400919D RID: 37277
		public float hpMax;

		// Token: 0x0400919E RID: 37278
		public bool isTurnEnd;

		// Token: 0x0400919F RID: 37279
		public int supply;

		// Token: 0x040091A0 RID: 37280
		public short tileIndex;

		// Token: 0x040091A1 RID: 37281
		public bool isTarget;

		// Token: 0x040091A2 RID: 37282
		public bool isSummonee;

		// Token: 0x02001C60 RID: 7264
		public enum Type : byte
		{
			// Token: 0x0400BD9F RID: 48543
			User,
			// Token: 0x0400BDA0 RID: 48544
			Dungeon
		}
	}
}
