using System;

namespace NKM.Templet
{
	// Token: 0x020005EB RID: 1515
	public interface IIntervalTemplet
	{
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002DB0 RID: 11696
		bool IsValid { get; }

		// Token: 0x06002DB1 RID: 11697
		bool IsValidTime(DateTime serviceTime);

		// Token: 0x06002DB2 RID: 11698
		DateTime CalcStartDate(DateTime current);

		// Token: 0x06002DB3 RID: 11699
		DateTime CalcEndDate(DateTime current);
	}
}
