using System;
using Cs.Protocol;

namespace ClientPacket.Event
{
	// Token: 0x020010C6 RID: 4294
	public sealed class KakaoMissionData : ISerializable
	{
		// Token: 0x0600A7C1 RID: 42945 RVA: 0x00382914 File Offset: 0x00380B14
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.eventId);
			stream.PutOrGetEnum<KakaoMissionState>(ref this.state);
		}

		// Token: 0x04009A66 RID: 39526
		public int eventId;

		// Token: 0x04009A67 RID: 39527
		public KakaoMissionState state;
	}
}
