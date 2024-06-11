using System;
using ClientPacket.Common;
using Cs.Protocol;

namespace ClientPacket.Community
{
	// Token: 0x0200111B RID: 4379
	public sealed class MenteeInfo : ISerializable
	{
		// Token: 0x0600A861 RID: 43105 RVA: 0x00383989 File Offset: 0x00381B89
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<MentoringState>(ref this.state);
			stream.PutOrGet<FriendListData>(ref this.data);
			stream.PutOrGet(ref this.missionCount);
		}

		// Token: 0x04009B5E RID: 39774
		public MentoringState state;

		// Token: 0x04009B5F RID: 39775
		public FriendListData data;

		// Token: 0x04009B60 RID: 39776
		public long missionCount;
	}
}
