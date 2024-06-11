using System;
using System.Collections.Generic;
using System.Linq;
using NKM.Templet;

namespace NKM
{
	// Token: 0x020004C9 RID: 1225
	[Serializable]
	public class NKMStatData
	{
		// Token: 0x04002452 RID: 9298
		private Dictionary<NKM_STAT_TYPE, float> m_StatBase = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x04002453 RID: 9299
		private Dictionary<NKM_STAT_TYPE, float> m_StatBonusBaseValue = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x04002454 RID: 9300
		private Dictionary<NKM_STAT_TYPE, float> m_StatBuffFinalValue = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x04002455 RID: 9301
		private Dictionary<NKM_STAT_TYPE, float> m_StatDebuffFinalValue = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x04002456 RID: 9302
		private Dictionary<NKM_STAT_TYPE, float> m_StatSystemValue = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x04002457 RID: 9303
		private Dictionary<NKM_STAT_TYPE, float> m_StatFinal = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x04002458 RID: 9304
		private List<NKMStatData.SecondaryBuffStatInfo> m_lstSecondaryBuff = new List<NKMStatData.SecondaryBuffStatInfo>();

		// Token: 0x04002459 RID: 9305
		private static readonly HashSet<NKM_STAT_TYPE> s_hsSecondaryBuffStat = new HashSet<NKM_STAT_TYPE>
		{
			NKM_STAT_TYPE.NST_HP_REGEN_RATE
		};

		// Token: 0x0400245A RID: 9306
		private Dictionary<NKM_STAT_TYPE, float> m_StatPerLevel = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x0400245B RID: 9307
		private Dictionary<NKM_STAT_TYPE, float> m_StatMaxPerLevel = new Dictionary<NKM_STAT_TYPE, float>();

		// Token: 0x0200138C RID: 5004
		private struct SecondaryBuffStatInfo
		{
			// Token: 0x0400A2C4 RID: 41668
			public NKM_STAT_TYPE statType;

			// Token: 0x0400A2C5 RID: 41669
			public float value;

			// Token: 0x0400A2C6 RID: 41670
			public bool isDebuff;

			// Token: 0x0400A2C7 RID: 41671
			public short casterUID;
		}
	}
}
