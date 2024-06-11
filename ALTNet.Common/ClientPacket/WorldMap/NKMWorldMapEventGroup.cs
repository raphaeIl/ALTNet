using System;
using Cs.Protocol;

namespace ClientPacket.WorldMap
{
	// Token: 0x02000D42 RID: 3394
	public sealed class NKMWorldMapEventGroup : ISerializable
	{
		// Token: 0x0600A0E2 RID: 41186 RVA: 0x003785C5 File Offset: 0x003767C5
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.worldmapEventID);
			stream.PutOrGet(ref this.eventGroupEndDate);
			stream.PutOrGet(ref this.eventUid);
		}

		// Token: 0x0400912C RID: 37164
		public int worldmapEventID;

		// Token: 0x0400912D RID: 37165
		public DateTime eventGroupEndDate;

		// Token: 0x0400912E RID: 37166
		public long eventUid;
	}
}
