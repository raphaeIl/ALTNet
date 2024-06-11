using System;
using Cs.Protocol;

namespace ClientPacket.Pvp
{
	// Token: 0x02000E6F RID: 3695
	public sealed class NKMPrivateGameConfig : ISerializable
	{
		// Token: 0x0600A338 RID: 41784 RVA: 0x0037C16F File Offset: 0x0037A36F
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.applyEquipStat);
			stream.PutOrGet(ref this.applyAllUnitMaxLevel);
			stream.PutOrGet(ref this.applyBanUpSystem);
			stream.PutOrGet(ref this.draftBanMode);
		}

		// Token: 0x04009496 RID: 38038
		public bool applyEquipStat;

		// Token: 0x04009497 RID: 38039
		public bool applyAllUnitMaxLevel;

		// Token: 0x04009498 RID: 38040
		public bool applyBanUpSystem;

		// Token: 0x04009499 RID: 38041
		public bool draftBanMode;
	}
}
