using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Core.Util;
using NKC;
using NKM.Templet;
using NKM.Templet.Base;

namespace NKM
{
    // Token: 0x02000446 RID: 1094
    public class NKMMissionTabTemplet : INKMTemplet, INKMTempletEx
	{
		// Token: 0x04001F05 RID: 7941
		private NKMIntervalTemplet intervalTemplet = NKMIntervalTemplet.Invalid;

		// Token: 0x04001F06 RID: 7942
		public int m_tabID;

		// Token: 0x04001F07 RID: 7943
		public NKM_MISSION_TYPE m_MissionType;

		// Token: 0x04001F08 RID: 7944
		private string m_OpenTag;

		// Token: 0x04001F09 RID: 7945
		public string m_MissionTabDesc = string.Empty;

		// Token: 0x04001F0A RID: 7946
		public string m_MissionTabIconName = string.Empty;

		// Token: 0x04001F0B RID: 7947
		public string m_MainUnitStrID = string.Empty;

		// Token: 0x04001F0C RID: 7948
		public string m_SlotBannerName = string.Empty;

		// Token: 0x04001F0D RID: 7949
		public bool m_LobbyIconDisplayBool;

		// Token: 0x04001F0E RID: 7950
		public string m_LobbyIconName = string.Empty;

		// Token: 0x04001F0F RID: 7951
		public string m_LobbyIconDesc = string.Empty;

		// Token: 0x04001F10 RID: 7952
		public bool m_MissionTotalPointBool;

		// Token: 0x04001F11 RID: 7953
		public int m_MissionTotalPointID;

		// Token: 0x04001F12 RID: 7954
		public int m_NewbieDate;

		// Token: 0x04001F13 RID: 7955
		public ReturningUserType m_ReturningUserType;

		// Token: 0x04001F14 RID: 7956
		public int m_MissionPoolID;

		// Token: 0x04001F15 RID: 7957
		public int m_MissionDisplayCount;

		// Token: 0x04001F16 RID: 7958
		public int m_MissionRefreshFreeCount;

		// Token: 0x04001F17 RID: 7959
		public int m_MissionRefreshReqItemID;

		// Token: 0x04001F18 RID: 7960
		public int m_MissionRefreshReqItemValue;

		// Token: 0x04001F19 RID: 7961
		public string intervalId;

		// Token: 0x04001F1A RID: 7962
		public string m_MissionBannerImage;

		// Token: 0x04001F1B RID: 7963
		public int m_OrderList;

		// Token: 0x04001F1C RID: 7964
		public bool m_Visible = true;

		// Token: 0x04001F1D RID: 7965
		public bool m_VisibleWhenLocked;

		// Token: 0x04001F1E RID: 7966
		public List<UnlockInfo> m_UnlockInfo = new List<UnlockInfo>();

		// Token: 0x04001F1F RID: 7967
		public int m_firstMissionID;

		// Token: 0x04001F20 RID: 7968
		public int m_completeMissionID;

        public int Key => throw new NotImplementedException();

        public void Join()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }

        public void PostJoin()
        {
            throw new NotImplementedException();
        }
    }
}
