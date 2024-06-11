using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x02001194 RID: 4500
	public sealed class NKMAsyncUnitData : ISerializable
	{
		// Token: 0x0600A945 RID: 43333 RVA: 0x00384C20 File Offset: 0x00382E20
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitUid);
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.unitLevel);
			stream.PutOrGet(ref this.skinId);
			stream.PutOrGet(ref this.limitBreakLevel);
			stream.PutOrGet(ref this.skillLevel);
			stream.PutOrGet(ref this.statExp);
			stream.PutOrGet(ref this.equipUids);
			stream.PutOrGet<NKMShipCmdModule>(ref this.shipModules);
			stream.PutOrGet(ref this.tacticLevel);
			stream.PutOrGet(ref this.reactorLevel);
		}

		// Token: 0x04009C77 RID: 40055
		public long unitUid;

		// Token: 0x04009C78 RID: 40056
		public int unitId;

		// Token: 0x04009C79 RID: 40057
		public int unitLevel;

		// Token: 0x04009C7A RID: 40058
		public int skinId;

		// Token: 0x04009C7B RID: 40059
		public int limitBreakLevel;

		// Token: 0x04009C7C RID: 40060
		public List<int> skillLevel = new List<int>();

		// Token: 0x04009C7D RID: 40061
		public List<int> statExp = new List<int>();

		// Token: 0x04009C7E RID: 40062
		public List<long> equipUids = new List<long>();

		// Token: 0x04009C7F RID: 40063
		public List<NKMShipCmdModule> shipModules = new List<NKMShipCmdModule>();

		// Token: 0x04009C80 RID: 40064
		public int tacticLevel;

		// Token: 0x04009C81 RID: 40065
		public int reactorLevel;
	}
}
