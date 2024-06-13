using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011CE RID: 4558
	[PacketId(ClientPacketId.kNKMPacket_LOGIN_ACK)]
	public sealed class NKMPacket_LOGIN_ACK : ISerializable
	{
		// Token: 0x0600A9B0 RID: 43440 RVA: 0x00385C7C File Offset: 0x00383E7C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.accessToken);
			stream.PutOrGet(ref this.gameServerIP);
			stream.PutOrGet(ref this.gameServerPort);
			stream.PutOrGet(ref this.contentsVersion);
			stream.PutOrGet(ref this.contentsTag);
			stream.PutOrGet(ref this.openTag);
		}

		// Token: 0x04009D85 RID: 40325
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009D86 RID: 40326
		public string accessToken;

		// Token: 0x04009D87 RID: 40327
		public string gameServerIP;

		// Token: 0x04009D88 RID: 40328
		public int gameServerPort;

		// Token: 0x04009D89 RID: 40329
		public string contentsVersion;

		// Token: 0x04009D8A RID: 40330
		public List<string> contentsTag = new List<string>();

		// Token: 0x04009D8B RID: 40331
		public List<string> openTag = new List<string>();
	}
}
