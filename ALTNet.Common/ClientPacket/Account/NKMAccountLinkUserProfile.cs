using System;
using ClientPacket.Common;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Account
{
	// Token: 0x020011CA RID: 4554
	public sealed class NKMAccountLinkUserProfile : ISerializable
	{
		// Token: 0x0600A9A8 RID: 43432 RVA: 0x00385B10 File Offset: 0x00383D10
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGetEnum<NKM_PUBLISHER_TYPE>(ref this.publisherType);
			stream.PutOrGet(ref this.creditCount);
			stream.PutOrGet(ref this.eterniumCount);
			stream.PutOrGet(ref this.cashCount);
			stream.PutOrGet(ref this.medalCount);
		}

		// Token: 0x04009D6D RID: 40301
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009D6E RID: 40302
		public NKM_PUBLISHER_TYPE publisherType;

		// Token: 0x04009D6F RID: 40303
		public long creditCount;

		// Token: 0x04009D70 RID: 40304
		public long eterniumCount;

		// Token: 0x04009D71 RID: 40305
		public long cashCount;

		// Token: 0x04009D72 RID: 40306
		public long medalCount;
	}
}
