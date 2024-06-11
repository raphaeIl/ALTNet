using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011BC RID: 4540
	public sealed class NKMTournamentProfileData : ISerializable
	{
		// Token: 0x0600A98D RID: 43405 RVA: 0x003858A5 File Offset: 0x00383AA5
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildData);
			stream.PutOrGet<NKMAsyncDeckData>(ref this.deck);
		}

		// Token: 0x04009D51 RID: 40273
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009D52 RID: 40274
		public NKMGuildSimpleData guildData = new NKMGuildSimpleData();

		// Token: 0x04009D53 RID: 40275
		public NKMAsyncDeckData deck = new NKMAsyncDeckData();
	}
}
