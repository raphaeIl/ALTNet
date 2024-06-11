using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Item
{
	// Token: 0x02000F83 RID: 3971
	public sealed class NKMEquipPresetData : ISerializable
	{
		// Token: 0x0600A551 RID: 42321 RVA: 0x0037EDBA File Offset: 0x0037CFBA
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.presetIndex);
			stream.PutOrGetEnum<NKM_EQUIP_PRESET_TYPE>(ref this.presetType);
			stream.PutOrGet(ref this.presetName);
			stream.PutOrGet(ref this.equipUids);
		}

		// Token: 0x040096E7 RID: 38631
		public int presetIndex;

		// Token: 0x040096E8 RID: 38632
		public NKM_EQUIP_PRESET_TYPE presetType;

		// Token: 0x040096E9 RID: 38633
		public string presetName;

		// Token: 0x040096EA RID: 38634
		public List<long> equipUids = new List<long>();
	}
}
