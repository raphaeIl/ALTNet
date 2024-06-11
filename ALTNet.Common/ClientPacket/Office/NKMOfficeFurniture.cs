using System;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EDC RID: 3804
	public sealed class NKMOfficeFurniture : ISerializable
	{
		// Token: 0x0600A40B RID: 41995 RVA: 0x0037CEB4 File Offset: 0x0037B0B4
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.uid);
			stream.PutOrGet(ref this.itemId);
			stream.PutOrGetEnum<OfficePlaneType>(ref this.planeType);
			stream.PutOrGet(ref this.positionX);
			stream.PutOrGet(ref this.positionY);
			stream.PutOrGet(ref this.inverted);
		}

		// Token: 0x04009545 RID: 38213
		public long uid;

		// Token: 0x04009546 RID: 38214
		public int itemId;

		// Token: 0x04009547 RID: 38215
		public OfficePlaneType planeType;

		// Token: 0x04009548 RID: 38216
		public int positionX;

		// Token: 0x04009549 RID: 38217
		public int positionY;

		// Token: 0x0400954A RID: 38218
		public bool inverted;
	}
}
