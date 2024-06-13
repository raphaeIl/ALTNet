using System;
using Cs.Protocol;
using Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011DB RID: 4571
	[PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_REQ)]
	public sealed class NKMPacket_CONTENTS_VERSION_REQ : ISerializable
	{
		// Token: 0x0600A9CA RID: 43466 RVA: 0x003862E5 File Offset: 0x003844E5
		void ISerializable.Serialize(IPacketStream stream)
		{
		}
	}
}
