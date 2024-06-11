using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x0200119B RID: 4507
	public sealed class NKMSkillLevelData : ISerializable
	{
		// Token: 0x0600A951 RID: 43345 RVA: 0x00384FE1 File Offset: 0x003831E1
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.normalLv);
			stream.PutOrGet(ref this.passiveLv);
			stream.PutOrGet(ref this.specialLv);
			stream.PutOrGet(ref this.ultimateLv);
			stream.PutOrGet(ref this.leaderLv);
		}

		// Token: 0x04009CAE RID: 40110
		public int normalLv;

		// Token: 0x04009CAF RID: 40111
		public int passiveLv;

		// Token: 0x04009CB0 RID: 40112
		public int specialLv;

		// Token: 0x04009CB1 RID: 40113
		public int ultimateLv;

		// Token: 0x04009CB2 RID: 40114
		public int leaderLv;
	}
}
