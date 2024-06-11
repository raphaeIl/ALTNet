using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A9 RID: 4521
	public sealed class NKMKillCountData : ISerializable
	{
		// Token: 0x0600A96D RID: 43373 RVA: 0x003852DC File Offset: 0x003834DC
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.killCountId);
			stream.PutOrGet(ref this.killCount);
			stream.PutOrGet(ref this.userCompleteStep);
			stream.PutOrGet(ref this.serverCompleteStep);
		}

		// Token: 0x04009CDD RID: 40157
		public int killCountId;

		// Token: 0x04009CDE RID: 40158
		public long killCount;

		// Token: 0x04009CDF RID: 40159
		public int userCompleteStep;

		// Token: 0x04009CE0 RID: 40160
		public int serverCompleteStep;
	}
}
