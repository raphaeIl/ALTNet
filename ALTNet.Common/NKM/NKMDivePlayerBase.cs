using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000379 RID: 889
	public sealed class NKMDivePlayerBase : ISerializable
	{

		// Token: 0x060015F3 RID: 5619 RVA: 0x00059E14 File Offset: 0x00058014
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKMDivePlayerState>(ref this.state);
			stream.PutOrGet(ref this.prevSlotSetIndex);
			stream.PutOrGet(ref this.prevSlotIndex);
			stream.PutOrGet(ref this.slotSetIndex);
			stream.PutOrGet(ref this.slotIndex);
			stream.PutOrGet(ref this.distance);
			stream.PutOrGet(ref this.leaderDeckIndex);
			stream.PutOrGet(ref this.reservedDungeonID);
			stream.PutOrGet(ref this.reservedDeckIndex);
			stream.PutOrGet(ref this.artifacts);
			stream.PutOrGet(ref this.reservedArtifacts);
		}

		// Token: 0x04000EE8 RID: 3816
		private NKMDivePlayerState state;

		// Token: 0x04000EE9 RID: 3817
		private int prevSlotSetIndex;

		// Token: 0x04000EEA RID: 3818
		private int prevSlotIndex;

		// Token: 0x04000EEB RID: 3819
		private int slotSetIndex = -1;

		// Token: 0x04000EEC RID: 3820
		private int slotIndex;

		// Token: 0x04000EED RID: 3821
		private int distance;

		// Token: 0x04000EEE RID: 3822
		private int leaderDeckIndex;

		// Token: 0x04000EEF RID: 3823
		private int reservedDungeonID;

		// Token: 0x04000EF0 RID: 3824
		private int reservedDeckIndex = -1;

		// Token: 0x04000EF1 RID: 3825
		private List<int> artifacts = new List<int>();

		// Token: 0x04000EF2 RID: 3826
		private List<int> reservedArtifacts = new List<int>();
	}
}
