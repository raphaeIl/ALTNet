using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001184 RID: 4484
	public sealed class NKMGuildSimpleData : ISerializable
	{
		// Token: 0x0600A933 RID: 43315 RVA: 0x003848D6 File Offset: 0x00382AD6
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.guildUid);
			stream.PutOrGet(ref this.guildName);
			stream.PutOrGet(ref this.badgeId);
		}

		// Token: 0x04009C29 RID: 39977
		public long guildUid;

		// Token: 0x04009C2A RID: 39978
		public string guildName;

		// Token: 0x04009C2B RID: 39979
		public long badgeId;
	}
}
