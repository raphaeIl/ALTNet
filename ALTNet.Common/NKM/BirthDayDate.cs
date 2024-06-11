using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000371 RID: 881
	public struct BirthDayDate : ISerializable
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x000594AF File Offset: 0x000576AF
		public BirthDayDate(int month, int day)
		{
			this.Month = month;
			this.Day = day;
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000594BF File Offset: 0x000576BF
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.Month);
			stream.PutOrGet(ref this.Day);
		}

		// Token: 0x04000ECD RID: 3789
		public int Month;

		// Token: 0x04000ECE RID: 3790
		public int Day;
	}
}
