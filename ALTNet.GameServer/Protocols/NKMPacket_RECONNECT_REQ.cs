using Cs.Protocol;
using Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011D8 RID: 4568
	[PacketId(ClientPacketId.kNKMPacket_RECONNECT_REQ)]
	public sealed class NKMPacket_RECONNECT_REQ : ISerializable
	{
		// Token: 0x0600A9C4 RID: 43460 RVA: 0x0038623A File Offset: 0x0038443A
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.reconnectKey);
		}

		// Token: 0x04009DD2 RID: 40402
		public string reconnectKey;
	}
}
