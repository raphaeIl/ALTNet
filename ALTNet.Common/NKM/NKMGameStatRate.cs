using System;

namespace NKM
{
	// Token: 0x020004CA RID: 1226
	public class NKMGameStatRate
	{
		// Token: 0x06002292 RID: 8850 RVA: 0x000B2578 File Offset: 0x000B0778
		public float GetStatValueRate(NKM_STAT_TYPE eStat)
		{
			switch (eStat)
			{
			case NKM_STAT_TYPE.NST_HP:
				return this.m_HPRate;
			case NKM_STAT_TYPE.NST_ATK:
				return this.m_ATKRate;
			case NKM_STAT_TYPE.NST_DEF:
				return this.m_DEFRate;
			case NKM_STAT_TYPE.NST_CRITICAL:
				return this.m_CRITRate;
			case NKM_STAT_TYPE.NST_HIT:
				return this.m_HITRate;
			case NKM_STAT_TYPE.NST_EVADE:
				return this.m_EvadeRate;
			default:
				return this.m_SubStatValueRate;
			}
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000B25D5 File Offset: 0x000B07D5
		public float GetStatFactorRate(NKM_STAT_TYPE eStat)
		{
			//if (NKMUnitStatManager.IsMainStat(eStat))
			//{
			//	return this.m_MainStatFactorRate;
			//}
			return 1f;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000B25EB File Offset: 0x000B07EB
		public float GetEquipStatRate()
		{
			return this.m_EquipStatRate;
		}

		// Token: 0x0400245C RID: 9308
		public float m_MainStatFactorRate = 1f;

		// Token: 0x0400245D RID: 9309
		public float m_SubStatValueRate = 1f;

		// Token: 0x0400245E RID: 9310
		public float m_EquipStatRate = 1f;

		// Token: 0x0400245F RID: 9311
		public float m_HPRate = 1f;

		// Token: 0x04002460 RID: 9312
		public float m_ATKRate = 1f;

		// Token: 0x04002461 RID: 9313
		public float m_DEFRate = 1f;

		// Token: 0x04002462 RID: 9314
		public float m_CRITRate = 1f;

		// Token: 0x04002463 RID: 9315
		public float m_HITRate = 1f;

		// Token: 0x04002464 RID: 9316
		public float m_EvadeRate = 1f;
	}
}
