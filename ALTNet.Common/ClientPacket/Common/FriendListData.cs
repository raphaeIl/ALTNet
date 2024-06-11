using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001190 RID: 4496
	public sealed class FriendListData : ISerializable
	{
		// Token: 0x0600A93D RID: 43325 RVA: 0x00384A9D File Offset: 0x00382C9D
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet(ref this.lastLoginDate);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildData);
			stream.PutOrGet(ref this.hasOffice);
		}

		// Token: 0x04009C60 RID: 40032
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009C61 RID: 40033
		public DateTime lastLoginDate;

		// Token: 0x04009C62 RID: 40034
		public NKMGuildSimpleData guildData = new NKMGuildSimpleData();

		// Token: 0x04009C63 RID: 40035
		public bool hasOffice;
	}
}
