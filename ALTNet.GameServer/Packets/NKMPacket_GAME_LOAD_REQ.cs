using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Game
{
	// Token: 0x02001045 RID: 4165
	[PacketId(ClientPacketId.kNKMPacket_GAME_LOAD_REQ)]
	public sealed class NKMPacket_GAME_LOAD_REQ : ISerializable
	{
		// Token: 0x0600A6C7 RID: 42695 RVA: 0x003811B0 File Offset: 0x0037F3B0
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.isDev);
			stream.PutOrGet(ref this.selectDeckIndex);
			stream.PutOrGet(ref this.stageID);
			stream.PutOrGet(ref this.diveStageID);
			stream.PutOrGet(ref this.dungeonID);
			stream.PutOrGet(ref this.palaceID);
			stream.PutOrGet(ref this.fierceBossId);
			stream.PutOrGet<NKMEventDeckData>(ref this.eventDeckData);
			stream.PutOrGet(ref this.rewardMultiply);
		}

		// Token: 0x04009912 RID: 39186
		public bool isDev;

		// Token: 0x04009913 RID: 39187
		public byte selectDeckIndex;

		// Token: 0x04009914 RID: 39188
		public int stageID;

		// Token: 0x04009915 RID: 39189
		public int diveStageID;

		// Token: 0x04009916 RID: 39190
		public int dungeonID;

		// Token: 0x04009917 RID: 39191
		public int palaceID;

		// Token: 0x04009918 RID: 39192
		public int fierceBossId;

		// Token: 0x04009919 RID: 39193
		public NKMEventDeckData eventDeckData;

		// Token: 0x0400991A RID: 39194
		public int rewardMultiply;
	}
}
