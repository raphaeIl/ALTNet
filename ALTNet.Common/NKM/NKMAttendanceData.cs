using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003A5 RID: 933
	public class NKMAttendanceData : ISerializable
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x00062FA1 File Offset: 0x000611A1
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.LastUpdateDate);
			stream.PutOrGet<NKMAttendance>(ref this.AttList);
		}

		// Token: 0x0400102F RID: 4143
		public DateTime LastUpdateDate;

		// Token: 0x04001030 RID: 4144
		public List<NKMAttendance> AttList = new List<NKMAttendance>();
	}
}
