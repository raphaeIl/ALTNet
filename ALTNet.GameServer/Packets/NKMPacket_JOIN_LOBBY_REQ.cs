using System;
using Cs.Protocol;
using Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011CF RID: 4559
	[PacketId(ClientPacketId.kNKMPacket_JOIN_LOBBY_REQ)]
	public sealed class NKMPacket_JOIN_LOBBY_REQ : ISerializable
	{
		// Token: 0x0600A9B2 RID: 43442 RVA: 0x00385CFB File Offset: 0x00383EFB
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.protocolVersion);
			stream.PutOrGet(ref this.accessToken);
		}

		// Token: 0x04009D8C RID: 40332
		public int protocolVersion;

		// Token: 0x04009D8D RID: 40333
		public string accessToken;
	}
}
