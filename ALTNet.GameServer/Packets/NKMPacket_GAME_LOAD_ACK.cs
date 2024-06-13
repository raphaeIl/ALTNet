using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Game
{
	// Token: 0x02001048 RID: 4168
	[PacketId(ClientPacketId.kNKMPacket_GAME_LOAD_ACK)]
	public sealed class NKMPacket_GAME_LOAD_ACK : ISerializable
	{
		// Token: 0x0600A6CD RID: 42701 RVA: 0x0038128C File Offset: 0x0037F48C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet<NKMGameData>(ref this.gameData);
			stream.PutOrGet<NKMItemMiscData>(ref this.costItemDataList);
		}

		// Token: 0x04009920 RID: 39200
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009921 RID: 39201
		public NKMGameData gameData;

		// Token: 0x04009922 RID: 39202
		public List<NKMItemMiscData> costItemDataList = new List<NKMItemMiscData>();
	}
}
