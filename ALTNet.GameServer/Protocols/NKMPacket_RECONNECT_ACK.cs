using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Account
{
    // Token: 0x020011D9 RID: 4569
    [PacketId(ClientPacketId.kNKMPacket_RECONNECT_ACK)]
	public sealed class NKMPacket_RECONNECT_ACK : ISerializable
	{
		// Token: 0x0600A9C6 RID: 43462 RVA: 0x00386250 File Offset: 0x00384450
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.accessToken);
			stream.PutOrGet(ref this.gameServerIp);
			stream.PutOrGet(ref this.gameServerPort);
			stream.PutOrGet(ref this.contentsVersion);
			stream.PutOrGet(ref this.contentsTag);
			stream.PutOrGet(ref this.openTag);
		}

		// Token: 0x04009DD3 RID: 40403
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009DD4 RID: 40404
		public string accessToken;

		// Token: 0x04009DD5 RID: 40405
		public string gameServerIp;

		// Token: 0x04009DD6 RID: 40406
		public int gameServerPort;

		// Token: 0x04009DD7 RID: 40407
		public string contentsVersion;

		// Token: 0x04009DD8 RID: 40408
		public List<string> contentsTag = new List<string>();

		// Token: 0x04009DD9 RID: 40409
		public List<string> openTag = new List<string>();
	}
}
