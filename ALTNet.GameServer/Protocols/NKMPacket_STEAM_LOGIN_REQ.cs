using System;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011EA RID: 4586
	[PacketId(ClientPacketId.kNKMPacket_STEAM_LOGIN_REQ)]
	public sealed class NKMPacket_STEAM_LOGIN_REQ : ISerializable
	{
		// Token: 0x0600A9E8 RID: 43496 RVA: 0x003865DB File Offset: 0x003847DB
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.protocolVersion);
			stream.PutOrGet(ref this.deviceUid);
			stream.PutOrGet(ref this.accessToken);
			stream.PutOrGet(ref this.accountId);
			stream.PutOrGet<NKMUserMobileData>(ref this.userMobileData);
		}

		// Token: 0x04009E06 RID: 40454
		public int protocolVersion;

		// Token: 0x04009E07 RID: 40455
		public string deviceUid;

		// Token: 0x04009E08 RID: 40456
		public string accessToken;

		// Token: 0x04009E09 RID: 40457
		public string accountId;

		// Token: 0x04009E0A RID: 40458
		public NKMUserMobileData userMobileData;
	}
}
