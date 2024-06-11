using System;
using Cs.Protocol;

namespace ClientPacket.Unit
{
	// Token: 0x02000DE1 RID: 3553
	public sealed class NKMUnitMissionData : ISerializable
	{
		// Token: 0x0600A21E RID: 41502 RVA: 0x0037A544 File Offset: 0x00378744
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.missionId);
			stream.PutOrGet(ref this.stepId);
		}

		// Token: 0x040092FB RID: 37627
		public int unitId;

		// Token: 0x040092FC RID: 37628
		public int missionId;

		// Token: 0x040092FD RID: 37629
		public int stepId;
	}
}
