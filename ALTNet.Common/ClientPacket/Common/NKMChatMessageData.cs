using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011B0 RID: 4528
	public sealed class NKMChatMessageData : ISerializable
	{
		// Token: 0x0600A979 RID: 43385 RVA: 0x003855A8 File Offset: 0x003837A8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.messageUid);
			stream.PutOrGetEnum<ChatMessageType>(ref this.messageType);
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet(ref this.emotionId);
			stream.PutOrGet(ref this.message);
			stream.PutOrGet(ref this.createdAt);
			stream.PutOrGet(ref this.typeParam);
			stream.PutOrGet(ref this.blocked);
		}

		// Token: 0x04009D10 RID: 40208
		public long messageUid;

		// Token: 0x04009D11 RID: 40209
		public ChatMessageType messageType;

		// Token: 0x04009D12 RID: 40210
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009D13 RID: 40211
		public int emotionId;

		// Token: 0x04009D14 RID: 40212
		public string message;

		// Token: 0x04009D15 RID: 40213
		public DateTime createdAt;

		// Token: 0x04009D16 RID: 40214
		public long typeParam;

		// Token: 0x04009D17 RID: 40215
		public bool blocked;
	}
}
