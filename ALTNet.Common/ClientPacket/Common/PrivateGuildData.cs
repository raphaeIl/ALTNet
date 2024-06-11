using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A2 RID: 4514
	public sealed class PrivateGuildData : ISerializable
	{
		// Token: 0x0600A95F RID: 43359 RVA: 0x003851A9 File Offset: 0x003833A9
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.guildUid);
			stream.PutOrGet(ref this.donationCount);
			stream.PutOrGet(ref this.lastDailyResetDate);
			stream.PutOrGet(ref this.guildJoinDisableTime);
		}

		// Token: 0x04009CCC RID: 40140
		public long guildUid;

		// Token: 0x04009CCD RID: 40141
		public int donationCount;

		// Token: 0x04009CCE RID: 40142
		public DateTime lastDailyResetDate;

		// Token: 0x04009CCF RID: 40143
		public DateTime guildJoinDisableTime;
	}
}
