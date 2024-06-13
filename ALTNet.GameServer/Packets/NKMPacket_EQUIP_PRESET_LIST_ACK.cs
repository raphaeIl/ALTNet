using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Item
{
	// Token: 0x02000FA7 RID: 4007
	[PacketId(ClientPacketId.kNKMPacket_EQUIP_PRESET_LIST_ACK)]
	public sealed class NKMPacket_EQUIP_PRESET_LIST_ACK : ISerializable
	{
		// Token: 0x0600A599 RID: 42393 RVA: 0x0037F4DC File Offset: 0x0037D6DC
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet<NKMEquipPresetData>(ref this.presetDatas);
		}

		// Token: 0x0400974C RID: 38732
		public NKM_ERROR_CODE errorCode;

		// Token: 0x0400974D RID: 38733
		public List<NKMEquipPresetData> presetDatas = new List<NKMEquipPresetData>();
	}
}
