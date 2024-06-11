using System;
using System.Collections.Generic;
using ClientPacket.Community;
using Cs.Protocol;

namespace ClientPacket.Warfare
{
	// Token: 0x02000D67 RID: 3431
	public sealed class WarfareGameData : ISerializable
	{
		// Token: 0x0600A12A RID: 41258 RVA: 0x00378DFC File Offset: 0x00376FFC
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_WARFARE_GAME_STATE>(ref this.warfareGameState);
			stream.PutOrGet(ref this.warfareTempletID);
			stream.PutOrGet<WarfareTileData>(ref this.warfareTileDataList);
			stream.PutOrGet<WarfareTeamData>(ref this.warfareTeamDataA);
			stream.PutOrGet<WarfareTeamData>(ref this.warfareTeamDataB);
			stream.PutOrGet(ref this.isTurnA);
			stream.PutOrGet(ref this.turnCount);
			stream.PutOrGet(ref this.firstAttackCount);
			stream.PutOrGet(ref this.battleAllyUid);
			stream.PutOrGet(ref this.battleMonsterUid);
			stream.PutOrGet(ref this.isWinTeamA);
			stream.PutOrGet(ref this.expireTimeTick);
			stream.PutOrGet(ref this.holdCount);
			stream.PutOrGet(ref this.containerCount);
			stream.PutOrGet(ref this.flagshipDeckIndex);
			stream.PutOrGet(ref this.alliesKillCount);
			stream.PutOrGet(ref this.enemiesKillCount);
			stream.PutOrGet(ref this.targetKillCount);
			stream.PutOrGet(ref this.assistCount);
			stream.PutOrGet(ref this.supplyUseCount);
			stream.PutOrGet<WarfareSupporterListData>(ref this.supportUnitData);
			stream.PutOrGet(ref this.rewardMultiply);
		}

		// Token: 0x040091AB RID: 37291
		public NKM_WARFARE_GAME_STATE warfareGameState;

		// Token: 0x040091AC RID: 37292
		public int warfareTempletID;

		// Token: 0x040091AD RID: 37293
		public List<WarfareTileData> warfareTileDataList = new List<WarfareTileData>();

		// Token: 0x040091AE RID: 37294
		public WarfareTeamData warfareTeamDataA = new WarfareTeamData();

		// Token: 0x040091AF RID: 37295
		public WarfareTeamData warfareTeamDataB = new WarfareTeamData();

		// Token: 0x040091B0 RID: 37296
		public bool isTurnA;

		// Token: 0x040091B1 RID: 37297
		public int turnCount;

		// Token: 0x040091B2 RID: 37298
		public int firstAttackCount;

		// Token: 0x040091B3 RID: 37299
		public int battleAllyUid;

		// Token: 0x040091B4 RID: 37300
		public int battleMonsterUid;

		// Token: 0x040091B5 RID: 37301
		public bool isWinTeamA;

		// Token: 0x040091B6 RID: 37302
		public long expireTimeTick;

		// Token: 0x040091B7 RID: 37303
		public int holdCount;

		// Token: 0x040091B8 RID: 37304
		public short containerCount;

		// Token: 0x040091B9 RID: 37305
		public byte flagshipDeckIndex;

		// Token: 0x040091BA RID: 37306
		public byte alliesKillCount;

		// Token: 0x040091BB RID: 37307
		public byte enemiesKillCount;

		// Token: 0x040091BC RID: 37308
		public byte targetKillCount;

		// Token: 0x040091BD RID: 37309
		public byte assistCount;

		// Token: 0x040091BE RID: 37310
		public byte supplyUseCount;

		// Token: 0x040091BF RID: 37311
		public WarfareSupporterListData supportUnitData = new WarfareSupporterListData();

		// Token: 0x040091C0 RID: 37312
		public int rewardMultiply;
	}
}
