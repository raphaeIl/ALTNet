using System;
using System.Collections.Generic;
using System.Linq;
using Cs.Core.Util;
using NKC;
using NKM.Templet;
using NKM.Templet.Base;

namespace NKM
{
	// Token: 0x02000445 RID: 1093
	public class NKMMissionTemplet : INKMTemplet
	{
		// Token: 0x04001EE9 RID: 7913
		private string m_DateStrID = string.Empty;

		// Token: 0x04001EEA RID: 7914
		public int m_MissionTabId;

		// Token: 0x04001EEB RID: 7915
		public int m_GroupId;

		// Token: 0x04001EEC RID: 7916
		public int m_MissionID;

		// Token: 0x04001EED RID: 7917
		public long m_Times;

		// Token: 0x04001EEE RID: 7918
		public int m_MissionRequire;

		// Token: 0x04001EEF RID: 7919
		public string m_MissionIcon = string.Empty;

		// Token: 0x04001EF0 RID: 7920
		public string m_MissionTitle = string.Empty;

		// Token: 0x04001EF1 RID: 7921
		public string m_MissionDesc = string.Empty;

		// Token: 0x04001EF2 RID: 7922
		public string m_MissionTip = string.Empty;

		// Token: 0x04001EF3 RID: 7923
		public string m_ShortCut = string.Empty;

		// Token: 0x04001EF4 RID: 7924
		public int m_ForceClearStage;

		// Token: 0x04001EF5 RID: 7925
		public NKM_SHORTCUT_TYPE m_ShortCutType;

		// Token: 0x04001EF6 RID: 7926
		public NKM_MISSION_RESET_INTERVAL m_ResetInterval = NKM_MISSION_RESET_INTERVAL.NONE;

		// Token: 0x04001EF7 RID: 7927
		public int m_MissionPoolID;

		// Token: 0x04001EF8 RID: 7928
		public bool m_bResetCounterGroup;

		// Token: 0x04001EF9 RID: 7929
		private bool m_ResetCounterGroupId = true;

		// Token: 0x04001EFA RID: 7930
		public string m_TrackingEvent = string.Empty;

		// Token: 0x04001EFB RID: 7931
		public string m_AdjustEvent = string.Empty;

		// Token: 0x04001EFC RID: 7932
		public long m_RewardTimes;

		// Token: 0x04001EFD RID: 7933
		public long m_MinRewardTimes;

		// Token: 0x04001EFE RID: 7934
		private string m_OpenTag;

		// Token: 0x04001EFF RID: 7935
		public NKMIntervalTemplet intervalTemplet = NKMIntervalTemplet.Invalid;

		// Token: 0x04001F00 RID: 7936
		public MissionCond m_MissionCond = new MissionCond();

		// Token: 0x04001F01 RID: 7937
		public List<MissionChange> m_MissionChange = new List<MissionChange>();

		// Token: 0x04001F02 RID: 7938
		public List<MissionReward> m_MissionRewardOpened = new List<MissionReward>();

		// Token: 0x04001F03 RID: 7939
		public List<MissionReward> m_MissionRewardOriginal = new List<MissionReward>();

		// Token: 0x04001F04 RID: 7940
		public NKMMissionTabTemplet m_TabTemplet;

        public int Key => throw new NotImplementedException();

        public void Join()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
