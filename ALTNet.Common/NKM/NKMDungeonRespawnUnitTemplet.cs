using System;
using System.Collections.Generic;
using NKM.Templet;

namespace NKM
{
	// Token: 0x020003F3 RID: 1011
	public class NKMDungeonRespawnUnitTemplet
	{
		// Token: 0x040013D2 RID: 5074
		public long m_TempletUID;

		// Token: 0x040013D3 RID: 5075
		public NKMDungeonEventTiming m_NKMDungeonEventTiming = new NKMDungeonEventTiming();

		// Token: 0x040013D4 RID: 5076
		public string m_EventRespawnUnitTag = "";

		// Token: 0x040013D5 RID: 5077
		public string m_UnitStrID = "";

		// Token: 0x040013D6 RID: 5078
		public int m_UnitLevel;

		// Token: 0x040013D7 RID: 5079
		public int m_SkinID;

		// Token: 0x040013D8 RID: 5080
		public short m_UnitLimitBreakLevel;

		// Token: 0x040013D9 RID: 5081
		public List<NKMStaticBuffData> m_listStaticBuffData = new List<NKMStaticBuffData>();

		// Token: 0x040013DA RID: 5082
		public int m_UnitLevelBonusPerWave;

		// Token: 0x040013DB RID: 5083
		public NKMDungeonRespawnUnitTemplet.ShowGageOverride m_eShowGage;

		// Token: 0x040013DC RID: 5084
		public NKMStatData m_AddStatData = new NKMStatData();

		// Token: 0x040013DD RID: 5085
		public float m_fRespawnCoolTime;

		// Token: 0x040013DE RID: 5086
		public int m_WaveID;

		// Token: 0x040013DF RID: 5087
		public string m_ChangeUnitName;

		// Token: 0x02001348 RID: 4936
		public enum ShowGageOverride
		{
			// Token: 0x0400A1C1 RID: 41409
			Default,
			// Token: 0x0400A1C2 RID: 41410
			Show,
			// Token: 0x0400A1C3 RID: 41411
			Hide
		}
	}
}
