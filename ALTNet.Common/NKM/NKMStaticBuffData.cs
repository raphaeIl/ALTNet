using System;
using NKM.Unit;

namespace NKM
{
	// Token: 0x020004BA RID: 1210
	public class NKMStaticBuffData : IEventConditionOwner
	{
		// Token: 0x04002373 RID: 9075
		public NKMEventCondition m_Condition = new NKMEventCondition();

		// Token: 0x04002374 RID: 9076
		public string m_BuffStrID = "";

		// Token: 0x04002375 RID: 9077
		public byte m_BuffStatLevel = 1;

		// Token: 0x04002376 RID: 9078
		public byte m_BuffTimeLevel = 1;

		// Token: 0x04002377 RID: 9079
		public float m_fRebuffTime = -1f;

		// Token: 0x04002378 RID: 9080
		public float m_fRange;

		// Token: 0x04002379 RID: 9081
		public bool m_bMyTeam;

		// Token: 0x0400237A RID: 9082
		public bool m_bEnemy;

		// Token: 0x0400237B RID: 9083
		public bool m_bApplyOnSummon = true;

		// Token: 0x0400237C RID: 9084
		public bool m_bApplyToNewUnits;

        public NKMEventCondition Condition => throw new NotImplementedException();
    }
}
