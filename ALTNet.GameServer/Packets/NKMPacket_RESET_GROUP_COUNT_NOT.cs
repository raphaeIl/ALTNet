using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;
using Protocol;

namespace ClientPacket.Item
{
	// Token: 0x02000FC1 RID: 4033
	[PacketId(ClientPacketId.kNKMPacket_RESET_GROUP_COUNT_NOT)]
	public sealed class NKMPacket_RESET_GROUP_COUNT_NOT : ISerializable
	{
		// Token: 0x0600A5CD RID: 42445 RVA: 0x0037F93C File Offset: 0x0037DB3C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMResetCount>(ref this.resetCountList);
		}

		// Token: 0x04009785 RID: 38789
		public List<NKMResetCount> resetCountList = new List<NKMResetCount>();
	}
}
