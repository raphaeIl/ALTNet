using System;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Game
{
	// Token: 0x0200104C RID: 4172
	[PacketId(ClientPacketId.kNKMPacket_GAME_LOAD_COMPLETE_ACK)]
	public sealed class NKMPacket_GAME_LOAD_COMPLETE_ACK : ISerializable
	{
		// Token: 0x0600A6D5 RID: 42709 RVA: 0x00381313 File Offset: 0x0037F513
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.isIntrude);
			stream.PutOrGet<NKMGameRuntimeData>(ref this.gameRuntimeData);
			stream.PutOrGet(ref this.rewardMultiply);
		}

		// Token: 0x04009927 RID: 39207
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009928 RID: 39208
		public bool isIntrude;

		// Token: 0x04009929 RID: 39209
		public NKMGameRuntimeData gameRuntimeData;

		// Token: 0x0400992A RID: 39210
		public int rewardMultiply;
	}
}
