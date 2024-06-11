using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.WorldMap
{
	// Token: 0x02000D44 RID: 3396
	public sealed class NKMWorldMapCityData : ISerializable
	{
		// Token: 0x0600A0E6 RID: 41190 RVA: 0x00378624 File Offset: 0x00376824
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.cityID);
			stream.PutOrGet(ref this.leaderUnitUID);
			stream.PutOrGet(ref this.exp);
			stream.PutOrGet(ref this.level);
			stream.PutOrGet<NKMWorldMapMission>(ref this.worldMapMission);
			stream.PutOrGet<NKMWorldMapEventGroup>(ref this.worldMapEventGroup);
			stream.PutOrGet<NKMWorldmapCityBuildingData>(ref this.worldMapCityBuildingDataMap);
		}

		// Token: 0x04009132 RID: 37170
		public int cityID;

		// Token: 0x04009133 RID: 37171
		public long leaderUnitUID;

		// Token: 0x04009134 RID: 37172
		public int exp;

		// Token: 0x04009135 RID: 37173
		public int level;

		// Token: 0x04009136 RID: 37174
		public NKMWorldMapMission worldMapMission = new NKMWorldMapMission();

		// Token: 0x04009137 RID: 37175
		public NKMWorldMapEventGroup worldMapEventGroup = new NKMWorldMapEventGroup();

		// Token: 0x04009138 RID: 37176
		public Dictionary<int, NKMWorldmapCityBuildingData> worldMapCityBuildingDataMap = new Dictionary<int, NKMWorldmapCityBuildingData>();
	}
}
