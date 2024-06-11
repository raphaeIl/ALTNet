using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200037D RID: 893
	public sealed class NKMDiveSquad : ISerializable
	{
		// Token: 0x06001615 RID: 5653 RVA: 0x0005A147 File Offset: 0x00058347
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKMDiveSquadState>(ref this.state);
			stream.PutOrGet(ref this.deckIndex);
			stream.PutOrGet(ref this.curHp);
			stream.PutOrGet(ref this.maxHp);
			stream.PutOrGet(ref this.supply);
		}

		// Token: 0x04000EFC RID: 3836
		private const int DEFAULT_SQUAD_SUPPLY = 2;

		// Token: 0x04000EFD RID: 3837
		private NKMDiveSquadState state;

		// Token: 0x04000EFE RID: 3838
		private int deckIndex;

		// Token: 0x04000EFF RID: 3839
		private float curHp;

		// Token: 0x04000F00 RID: 3840
		private float maxHp;

		// Token: 0x04000F01 RID: 3841
		private int supply;
	}
}
