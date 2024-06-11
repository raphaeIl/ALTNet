using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200050B RID: 1291
	public class NKMUserDateData : ISerializable
	{
		// Token: 0x0600248C RID: 9356 RVA: 0x000BFCA6 File Offset: 0x000BDEA6
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_RegisterTime);
			stream.PutOrGet(ref this.m_LastLogInTime);
			stream.PutOrGet(ref this.m_LastLogOutTime);
		}

		// Token: 0x040026EF RID: 9967
		public DateTime m_RegisterTime;

		// Token: 0x040026F0 RID: 9968
		public DateTime m_LastLogInTime;

		// Token: 0x040026F1 RID: 9969
		public DateTime m_LastLogOutTime;
	}
}
