using System;
using ClientPacket.Common;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Community
{
	// Token: 0x0200111C RID: 4380
	public sealed class WarfareSupporterListData : ISerializable
	{
		// Token: 0x0600A863 RID: 43107 RVA: 0x003839B8 File Offset: 0x00381BB8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet<NKMDummyDeckData>(ref this.deckData);
			stream.PutOrGet(ref this.lastLoginDate);
			stream.PutOrGet(ref this.lastUsedDate);
			stream.PutOrGet(ref this.message);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildData);
		}

		// Token: 0x04009B61 RID: 39777
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009B62 RID: 39778
		public NKMDummyDeckData deckData;

		// Token: 0x04009B63 RID: 39779
		public DateTime lastLoginDate;

		// Token: 0x04009B64 RID: 39780
		public DateTime lastUsedDate;

		// Token: 0x04009B65 RID: 39781
		public string message;

		// Token: 0x04009B66 RID: 39782
		public NKMGuildSimpleData guildData = new NKMGuildSimpleData();
	}
}
