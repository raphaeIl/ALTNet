using System;
using Cs.Protocol;
using NKM.Templet;

namespace ClientPacket.Mode
{
	// Token: 0x02000F3E RID: 3902
	public sealed class NKMShadowGameResult : ISerializable
	{
		// Token: 0x0600A4CB RID: 42187 RVA: 0x0037E11C File Offset: 0x0037C31C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.palaceId);
			stream.PutOrGet<NKMPalaceDungeonData>(ref this.dungeonData);
			stream.PutOrGet<NKMRewardData>(ref this.rewardData);
			stream.PutOrGet(ref this.newRecord);
			stream.PutOrGet(ref this.currentDungeonId);
			stream.PutOrGet(ref this.life);
		}

		// Token: 0x0400963D RID: 38461
		public int palaceId;

		// Token: 0x0400963E RID: 38462
		public NKMPalaceDungeonData dungeonData = new NKMPalaceDungeonData();

		// Token: 0x0400963F RID: 38463
		public NKMRewardData rewardData;

		// Token: 0x04009640 RID: 38464
		public bool newRecord;

		// Token: 0x04009641 RID: 38465
		public int currentDungeonId;

		// Token: 0x04009642 RID: 38466
		public int life;
	}
}
