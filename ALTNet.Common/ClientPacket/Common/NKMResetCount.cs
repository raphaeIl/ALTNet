using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011B5 RID: 4533
	public sealed class NKMResetCount : ISerializable
	{
		// Token: 0x0600A983 RID: 43395 RVA: 0x00385704 File Offset: 0x00383904
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.groupId);
			stream.PutOrGet(ref this.count);
		}

		// Token: 0x04009D27 RID: 40231
		public int groupId;

		// Token: 0x04009D28 RID: 40232
		public int count;
	}
}
