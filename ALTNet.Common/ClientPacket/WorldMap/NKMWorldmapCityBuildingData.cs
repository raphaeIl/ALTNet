using System;
using Cs.Protocol;

namespace ClientPacket.WorldMap
{
	// Token: 0x02000D43 RID: 3395
	public sealed class NKMWorldmapCityBuildingData : ISerializable
	{
		// Token: 0x0600A0E4 RID: 41188 RVA: 0x003785F3 File Offset: 0x003767F3
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.buildUID);
			stream.PutOrGet(ref this.id);
			stream.PutOrGet(ref this.level);
		}

		// Token: 0x0400912F RID: 37167
		public long buildUID;

		// Token: 0x04009130 RID: 37168
		public int id;

		// Token: 0x04009131 RID: 37169
		public int level;
	}
}
