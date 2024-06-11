using System;
using ClientPacket.Common;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EFE RID: 3838
	public sealed class NKMOfficePost : ISerializable
	{
		// Token: 0x0600A44F RID: 42063 RVA: 0x0037D726 File Offset: 0x0037B926
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.postUid);
			stream.PutOrGet<NKMCommonProfile>(ref this.senderProfile);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.senderGuildData);
			stream.PutOrGet(ref this.expirationDate);
		}

		// Token: 0x040095B4 RID: 38324
		public long postUid;

		// Token: 0x040095B5 RID: 38325
		public NKMCommonProfile senderProfile = new NKMCommonProfile();

		// Token: 0x040095B6 RID: 38326
		public NKMGuildSimpleData senderGuildData = new NKMGuildSimpleData();

		// Token: 0x040095B7 RID: 38327
		public DateTime expirationDate;
	}
}
