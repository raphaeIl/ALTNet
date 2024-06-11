using System;
using Cs.Protocol;
using NKM.Templet;

namespace ClientPacket.User
{
	// Token: 0x02000D7B RID: 3451
	public sealed class NKMBackgroundUnitInfo : ISerializable
	{
		// Token: 0x0600A152 RID: 41298 RVA: 0x0037926C File Offset: 0x0037746C
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitUid);
			stream.PutOrGetEnum<NKM_UNIT_TYPE>(ref this.unitType);
			stream.PutOrGet(ref this.unitSize);
			stream.PutOrGet(ref this.unitFace);
			stream.PutOrGet(ref this.unitPosX);
			stream.PutOrGet(ref this.unitPosY);
			stream.PutOrGet(ref this.backImage);
			stream.PutOrGet(ref this.skinOption);
			stream.PutOrGet(ref this.rotation);
			stream.PutOrGet(ref this.flip);
			stream.PutOrGet(ref this.animTime);
		}

		// Token: 0x040091EA RID: 37354
		public long unitUid;

		// Token: 0x040091EB RID: 37355
		public NKM_UNIT_TYPE unitType;

		// Token: 0x040091EC RID: 37356
		public float unitSize;

		// Token: 0x040091ED RID: 37357
		public int unitFace;

		// Token: 0x040091EE RID: 37358
		public float unitPosX;

		// Token: 0x040091EF RID: 37359
		public float unitPosY;

		// Token: 0x040091F0 RID: 37360
		public bool backImage;

		// Token: 0x040091F1 RID: 37361
		public int skinOption;

		// Token: 0x040091F2 RID: 37362
		public float rotation;

		// Token: 0x040091F3 RID: 37363
		public bool flip;

		// Token: 0x040091F4 RID: 37364
		public float animTime;
	}
}
