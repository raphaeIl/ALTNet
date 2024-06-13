using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Account
{
	// Token: 0x020011DC RID: 4572
	[PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_ACK)]
	public sealed class NKMPacket_CONTENTS_VERSION_ACK : ISerializable
	{
		// Token: 0x0600A9CC RID: 43468 RVA: 0x003862EF File Offset: 0x003844EF
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.contentsVersion);
			stream.PutOrGet(ref this.contentsTag);
			stream.PutOrGet(ref this.utcTime);
			stream.PutOrGet(ref this.utcOffset);
		}

		// Token: 0x04009DDB RID: 40411
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009DDC RID: 40412
		public string contentsVersion;

		// Token: 0x04009DDD RID: 40413
		public List<string> contentsTag = new List<string>();

		// Token: 0x04009DDE RID: 40414
		public DateTime utcTime;

		// Token: 0x04009DDF RID: 40415
		public TimeSpan utcOffset;
	}
}
