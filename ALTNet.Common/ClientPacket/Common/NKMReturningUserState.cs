using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x02001199 RID: 4505
	public sealed class NKMReturningUserState : ISerializable
	{
		// Token: 0x0600A94D RID: 43341 RVA: 0x00384F47 File Offset: 0x00383147
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<ReturningUserType>(ref this.type);
			stream.PutOrGet(ref this.startDate);
			stream.PutOrGet(ref this.endDate);
		}

		// Token: 0x04009CA4 RID: 40100
		public ReturningUserType type;

		// Token: 0x04009CA5 RID: 40101
		public DateTime startDate;

		// Token: 0x04009CA6 RID: 40102
		public DateTime endDate;
	}
}
