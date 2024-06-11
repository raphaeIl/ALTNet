using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000373 RID: 883
	public class NKMDiveGameData : ISerializable
	{
	
		// Token: 0x060015BC RID: 5564 RVA: 0x00059558 File Offset: 0x00057758
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.diveUid);
			stream.PutOrGet<NKMDiveFloor>(ref this.floor);
			stream.PutOrGet<NKMDivePlayer>(ref this.player);
		}

		// Token: 0x04000ED2 RID: 3794
		private long diveUid;

		// Token: 0x04000ED3 RID: 3795
		private NKMDiveFloor floor;

		// Token: 0x04000ED4 RID: 3796
		private NKMDivePlayer player;
	}
}
