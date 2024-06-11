using System;
using Cs.Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F45 RID: 3909
	public sealed class PhaseModeState : ISerializable
	{
		// Token: 0x0600A4D9 RID: 42201 RVA: 0x0037E26D File Offset: 0x0037C46D
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.stageId);
			stream.PutOrGet(ref this.phaseIndex);
			stream.PutOrGet(ref this.dungeonId);
			stream.PutOrGet(ref this.totalPlayTime);
		}

		// Token: 0x0400964F RID: 38479
		public int stageId;

		// Token: 0x04009650 RID: 38480
		public int phaseIndex;

		// Token: 0x04009651 RID: 38481
		public int dungeonId;

		// Token: 0x04009652 RID: 38482
		public float totalPlayTime;
	}
}
