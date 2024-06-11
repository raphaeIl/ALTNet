using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003A6 RID: 934
	public class NKMAttendance : ISerializable
	{
		// Token: 0x0600182B RID: 6187 RVA: 0x00062FCE File Offset: 0x000611CE
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.IDX);
			stream.PutOrGet(ref this.Count);
			stream.PutOrGet(ref this.EventEndDate);
		}

		// Token: 0x04001031 RID: 4145
		public int IDX;

		// Token: 0x04001032 RID: 4146
		public int Count;

		// Token: 0x04001033 RID: 4147
		public DateTime EventEndDate;
	}
}
