using System;
using ClientPacket.Common;
using Cs.Protocol;

namespace ClientPacket.LeaderBoard
{
	// Token: 0x02000F6F RID: 3951
	public sealed class NKMDefenceRankData : ISerializable
	{
		// Token: 0x0600A52B RID: 42283 RVA: 0x0037E9F3 File Offset: 0x0037CBF3
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet(ref this.bestScore);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildData);
		}

		// Token: 0x040096AE RID: 38574
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x040096AF RID: 38575
		public int bestScore;

		// Token: 0x040096B0 RID: 38576
		public NKMGuildSimpleData guildData = new NKMGuildSimpleData();
	}
}
