using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000378 RID: 888
	public class NKMDivePlayer : ISerializable
	{
		// Token: 0x060015D3 RID: 5587 RVA: 0x00059B0E File Offset: 0x00057D0E
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMDivePlayerBase>(ref this.playerBase);
			stream.PutOrGet<NKMDiveSquad>(ref this.squads);
		}

		// Token: 0x04000EE5 RID: 3813
		private const int MaxArtifactCount = 50;

		// Token: 0x04000EE6 RID: 3814
		private NKMDivePlayerBase playerBase = new NKMDivePlayerBase();

		// Token: 0x04000EE7 RID: 3815
		private Dictionary<int, NKMDiveSquad> squads = new Dictionary<int, NKMDiveSquad>();
	}
}
