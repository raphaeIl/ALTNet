using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x0200118F RID: 4495
	public sealed class NKMCommonProfile : ISerializable
	{
		// Token: 0x0600A93B RID: 43323 RVA: 0x00384A1C File Offset: 0x00382C1C
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
		}

		// Token: 0x04009C57 RID: 40023
		public long userUid;

		// Token: 0x04009C58 RID: 40024
		public long friendCode;

		// Token: 0x04009C59 RID: 40025
		public string nickname;

		// Token: 0x04009C5A RID: 40026
		public int level;

		// Token: 0x04009C5B RID: 40027
		public int mainUnitId;

		// Token: 0x04009C5C RID: 40028
		public int mainUnitSkinId;

		// Token: 0x04009C5D RID: 40029
		public int frameId;

		// Token: 0x04009C5E RID: 40030
		public int mainUnitTacticLevel;

		// Token: 0x04009C5F RID: 40031
		public int titleId;
	}
}
