using System;
using ClientPacket.Common;
using Cs.Core.Util;
using NKC;
using NKM.Templet.Base;

namespace NKM.Templet
{
	// Token: 0x020005EC RID: 1516
	public sealed class NKMIntervalTemplet : INKMTemplet, IIntervalTemplet
	{
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000E3480 File Offset: 0x000E1680
		public static NKMIntervalTemplet Invalid { get; } = new NKMIntervalTemplet();

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x000E3487 File Offset: 0x000E1687
		public static NKMIntervalTemplet Unuseable { get; } = new NKMIntervalTemplet
		{
			StartDate = DateTime.MinValue,
			EndDate = DateTime.MinValue
		};

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000E348E File Offset: 0x000E168E
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x000E3496 File Offset: 0x000E1696
		public int Key { get; internal set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x000E349F File Offset: 0x000E169F
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x000E34A7 File Offset: 0x000E16A7
		public string StrKey { get; internal set; }

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x000E34B0 File Offset: 0x000E16B0
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x000E34B8 File Offset: 0x000E16B8
		public DateTime StartDate { get; internal set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x000E34C1 File Offset: 0x000E16C1
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x000E34C9 File Offset: 0x000E16C9
		public DateTime EndDate { get; internal set; }

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000E34D2 File Offset: 0x000E16D2
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x000E34DA File Offset: 0x000E16DA
		public int RepeatStartDate { get; internal set; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x000E34E3 File Offset: 0x000E16E3
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x000E34EB File Offset: 0x000E16EB
		public int RepeatEndDate { get; internal set; }

        public bool IsValid => throw new NotImplementedException();

        public DateTime CalcEndDate(DateTime current)
        {
            throw new NotImplementedException();
        }

        public DateTime CalcStartDate(DateTime current)
        {
            throw new NotImplementedException();
        }

        public bool IsValidTime(DateTime serviceTime)
        {
            throw new NotImplementedException();
        }

        public void Join()
        {
            throw new NotImplementedException();
        }

        // Token: 0x06002DCF RID: 11727 RVA: 0x000E3A64 File Offset: 0x000E1C64
        public override string ToString()
		{
			return string.Format("{0} {1} ~ {2} repeated:{3} {4}", new object[]
			{
				this.StrKey,
				this.StartDate,
				this.EndDate,
				this.RepeatStartDate,
				this.RepeatEndDate
			});
		}

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
