using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.WorldMap
{
	// Token: 0x02000D45 RID: 3397
	public sealed class NKMWorldMapData : ISerializable
	{
		// Token: 0x0600A0E8 RID: 41192 RVA: 0x003786AE File Offset: 0x003768AE
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMWorldMapCityData>(ref this.worldMapCityDataMap);
			stream.PutOrGet(ref this.collectLastResetDate);
		}

		// Token: 0x04009139 RID: 37177
		public Dictionary<int, NKMWorldMapCityData> worldMapCityDataMap = new Dictionary<int, NKMWorldMapCityData>();

		// Token: 0x0400913A RID: 37178
		public DateTime collectLastResetDate;
	}
}
