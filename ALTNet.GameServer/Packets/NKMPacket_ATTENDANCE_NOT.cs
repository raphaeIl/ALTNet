using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000DA5 RID: 3493
	[PacketId(ClientPacketId.kNKMPacket_ATTENDANCE_NOT)]
	public sealed class NKMPacket_ATTENDANCE_NOT : ISerializable
	{
		// Token: 0x0600A1A6 RID: 41382 RVA: 0x00379B08 File Offset: 0x00377D08
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.lastUpdateDate);
			stream.PutOrGet<NKMAttendance>(ref this.attendanceData);
		}

		// Token: 0x04009270 RID: 37488
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009271 RID: 37489
		public long lastUpdateDate;

		// Token: 0x04009272 RID: 37490
		public List<NKMAttendance> attendanceData = new List<NKMAttendance>();
	}
}
