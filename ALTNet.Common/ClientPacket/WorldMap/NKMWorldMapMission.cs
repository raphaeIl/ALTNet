using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.WorldMap
{
	// Token: 0x02000D41 RID: 3393
	public sealed class NKMWorldMapMission : ISerializable
	{
		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00378580 File Offset: 0x00376780
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.currentMissionID);
			stream.PutOrGet(ref this.completeTime);
			stream.PutOrGet(ref this.startDate);
			stream.PutOrGet(ref this.stMissionIDList);
		}

		// Token: 0x04009128 RID: 37160
		public int currentMissionID;

		// Token: 0x04009129 RID: 37161
		public long completeTime;

		// Token: 0x0400912A RID: 37162
		public DateTime startDate;

		// Token: 0x0400912B RID: 37163
		public List<int> stMissionIDList = new List<int>();
	}
}
