using System;
using Cs.Protocol;
using Protocol;

namespace ClientPacket.Game
{
	// Token: 0x0200104B RID: 4171
	[PacketId(ClientPacketId.kNKMPacket_GAME_LOAD_COMPLETE_REQ)]
	public sealed class NKMPacket_GAME_LOAD_COMPLETE_REQ : ISerializable
	{
		// Token: 0x0600A6D3 RID: 42707 RVA: 0x003812FD File Offset: 0x0037F4FD
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.isIntrude);
		}

		// Token: 0x04009926 RID: 39206
		public bool isIntrude;
	}
}
