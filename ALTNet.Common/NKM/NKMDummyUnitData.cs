using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003E4 RID: 996
	public sealed class NKMDummyUnitData : ISerializable
	{
		// Token: 0x06001A2D RID: 6701 RVA: 0x00071C64 File Offset: 0x0006FE64
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.UnitId);
			stream.PutOrGet(ref this.UnitLevel);
			stream.PutOrGet(ref this.SkinId);
			stream.PutOrGet(ref this.LimitBreakLevel);
			stream.PutOrGet(ref this.TacticLevel);
			stream.PutOrGet(ref this.ReactorLevel);
		}

		// Token: 0x04001354 RID: 4948
		public int UnitId;

		// Token: 0x04001355 RID: 4949
		public int UnitLevel;

		// Token: 0x04001356 RID: 4950
		public int SkinId;

		// Token: 0x04001357 RID: 4951
		public short LimitBreakLevel;

		// Token: 0x04001358 RID: 4952
		public int TacticLevel;

		// Token: 0x04001359 RID: 4953
		public int ReactorLevel;
	}
}
