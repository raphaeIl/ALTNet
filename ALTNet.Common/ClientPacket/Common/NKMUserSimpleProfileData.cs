using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001185 RID: 4485
	public sealed class NKMUserSimpleProfileData : ISerializable
	{
		// Token: 0x0600A935 RID: 43317 RVA: 0x00384904 File Offset: 0x00382B04
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.userUid);
			stream.PutOrGet(ref this.friendCode);
			stream.PutOrGet(ref this.nickname);
			stream.PutOrGet(ref this.level);
			stream.PutOrGet(ref this.mainUnitId);
			stream.PutOrGet(ref this.mainUnitSkinId);
			stream.PutOrGet(ref this.frameId);
			stream.PutOrGet(ref this.mainUnitTacticLevel);
			stream.PutOrGet(ref this.titleId);
			stream.PutOrGet(ref this.pvpScore);
			stream.PutOrGet(ref this.pvpTier);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildData);
			stream.PutOrGet(ref this.lastLoginDate);
		}

		// Token: 0x04009C2C RID: 39980
		public long userUid;

		// Token: 0x04009C2D RID: 39981
		public long friendCode;

		// Token: 0x04009C2E RID: 39982
		public string nickname;

		// Token: 0x04009C2F RID: 39983
		public int level;

		// Token: 0x04009C30 RID: 39984
		public int mainUnitId;

		// Token: 0x04009C31 RID: 39985
		public int mainUnitSkinId;

		// Token: 0x04009C32 RID: 39986
		public int frameId;

		// Token: 0x04009C33 RID: 39987
		public int mainUnitTacticLevel;

		// Token: 0x04009C34 RID: 39988
		public int titleId;

		// Token: 0x04009C35 RID: 39989
		public int pvpScore;

		// Token: 0x04009C36 RID: 39990
		public int pvpTier;

		// Token: 0x04009C37 RID: 39991
		public NKMGuildSimpleData guildData = new NKMGuildSimpleData();

		// Token: 0x04009C38 RID: 39992
		public DateTime lastLoginDate;
	}
}
