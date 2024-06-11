using System;
using Cs.Protocol;
using NKM.Templet.Office;

namespace ClientPacket.Common
{
	// Token: 0x020011B6 RID: 4534
	public sealed class UnitLoyaltyUpdateData : ISerializable
	{
		// Token: 0x0600A985 RID: 43397 RVA: 0x00385726 File Offset: 0x00383926
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitUid);
			stream.PutOrGet(ref this.loyalty);
			stream.PutOrGet(ref this.officeRoomId);
			stream.PutOrGetEnum<OfficeGrade>(ref this.officeGrade);
			stream.PutOrGet(ref this.heartGaugeStartTime);
		}

		// Token: 0x04009D29 RID: 40233
		public long unitUid;

		// Token: 0x04009D2A RID: 40234
		public int loyalty;

		// Token: 0x04009D2B RID: 40235
		public int officeRoomId;

		// Token: 0x04009D2C RID: 40236
		public OfficeGrade officeGrade;

		// Token: 0x04009D2D RID: 40237
		public DateTime heartGaugeStartTime;
	}
}
