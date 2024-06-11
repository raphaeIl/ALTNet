using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F4D RID: 3917
	public sealed class TrimModeState : ISerializable
	{
		// Token: 0x0600A4E9 RID: 42217 RVA: 0x0037E3D9 File Offset: 0x0037C5D9
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.trimId);
			stream.PutOrGet(ref this.trimLevel);
			stream.PutOrGet(ref this.nextDungeonId);
			stream.PutOrGet<NKMTrimStageData>(ref this.lastClearStage);
			stream.PutOrGet<NKMTrimStageData>(ref this.stageList);
		}

		// Token: 0x04009663 RID: 38499
		public int trimId;

		// Token: 0x04009664 RID: 38500
		public int trimLevel;

		// Token: 0x04009665 RID: 38501
		public int nextDungeonId;

		// Token: 0x04009666 RID: 38502
		public NKMTrimStageData lastClearStage = new NKMTrimStageData();

		// Token: 0x04009667 RID: 38503
		public List<NKMTrimStageData> stageList = new List<NKMTrimStageData>();
	}
}
