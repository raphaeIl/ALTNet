using System;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x0200119F RID: 4511
	public sealed class EquipProfileInfo : ISerializable
	{
		// Token: 0x0600A959 RID: 43353 RVA: 0x003850E4 File Offset: 0x003832E4
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.itemUid);
			stream.PutOrGet(ref this.ItemId);
			stream.PutOrGet(ref this.enchantLevel);
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.statType);
			stream.PutOrGet(ref this.statValue);
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.statType2);
			stream.PutOrGet(ref this.statValue2);
			stream.PutOrGet(ref this.setOptionId);
		}

		// Token: 0x04009CBF RID: 40127
		public long itemUid;

		// Token: 0x04009CC0 RID: 40128
		public int ItemId;

		// Token: 0x04009CC1 RID: 40129
		public int enchantLevel;

		// Token: 0x04009CC2 RID: 40130
		public NKM_STAT_TYPE statType;

		// Token: 0x04009CC3 RID: 40131
		public float statValue;

		// Token: 0x04009CC4 RID: 40132
		public NKM_STAT_TYPE statType2;

		// Token: 0x04009CC5 RID: 40133
		public float statValue2;

		// Token: 0x04009CC6 RID: 40134
		public int setOptionId;
	}
}
