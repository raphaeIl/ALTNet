using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Warfare
{
	// Token: 0x02000D66 RID: 3430
	public sealed class WarfareTeamData : ISerializable
	{
		// Token: 0x0600A128 RID: 41256 RVA: 0x00378DCD File Offset: 0x00376FCD
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.flagShipWarfareUnitUID);
			stream.PutOrGet<WarfareUnitData>(ref this.warfareUnitDataByUIDMap);
		}

		// Token: 0x040091A9 RID: 37289
		public int flagShipWarfareUnitUID;

		// Token: 0x040091AA RID: 37290
		public Dictionary<int, WarfareUnitData> warfareUnitDataByUIDMap = new Dictionary<int, WarfareUnitData>();
	}
}
