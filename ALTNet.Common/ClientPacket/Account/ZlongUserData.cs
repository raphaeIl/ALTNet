using System;
using Cs.Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011C9 RID: 4553
	public sealed class ZlongUserData : ISerializable
	{
		// Token: 0x0600A9A6 RID: 43430 RVA: 0x00385AF8 File Offset: 0x00383CF8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.userId);
		}

		// Token: 0x04009D6C RID: 40300
		public string userId;
	}
}
