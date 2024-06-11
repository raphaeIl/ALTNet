using System;
using System.Collections.Generic;
using ClientPacket.Common;
using ClientPacket.Office;
using NKM;
using NKM.Templet;
using NKM.Templet.Office;

namespace NKC.Office
{
	// Token: 0x02000874 RID: 2164
	public class NKCOfficeData
	{
		// Token: 0x0400455A RID: 17754
		private List<int> m_lstOpenedSectionIds;

		// Token: 0x0400455B RID: 17755
		private List<NKMOfficeRoom> m_lstRooms;

		// Token: 0x0400455C RID: 17756
		private Dictionary<int, NKMInteriorData> m_dicInteriors = new Dictionary<int, NKMInteriorData>();

		// Token: 0x0400455D RID: 17757
		private Dictionary<int, NKMOfficeRoom> m_dicRooms = new Dictionary<int, NKMOfficeRoom>();

		// Token: 0x0400455F RID: 17759
		private List<NKMOfficePost> m_lstBizCard = new List<NKMOfficePost>();

		// Token: 0x04004560 RID: 17760
		private List<NKMUserProfileData> m_lstRandomVisitor;

		// Token: 0x04004561 RID: 17761
		private int m_randomVisitorIndex;

		// Token: 0x04004562 RID: 17762
		private List<NKMOfficePreset> m_lstOfficePreset;

		// Token: 0x04004564 RID: 17764
		private const float REFRESH_INTERVAL = 5f;

		// Token: 0x04004565 RID: 17765
		private DateTime m_dtNextRefreshTime;

		// Token: 0x04004566 RID: 17766
		private Dictionary<long, NKMOfficeState> m_dicFriendOfficeState = new Dictionary<long, NKMOfficeState>();

		// Token: 0x04004567 RID: 17767
		private long m_lCurrentFriendUId;

		// Token: 0x04004568 RID: 17768
		private NKMOfficeState m_currentFriendState;

		// Token: 0x02001678 RID: 5752
		// (Invoke) Token: 0x0600B8A7 RID: 47271
		public delegate void OnInteriorInventoryUpdate(NKMInteriorData interiorData, bool bAdded);
	}
}
