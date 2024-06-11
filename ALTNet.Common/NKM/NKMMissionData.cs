using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000448 RID: 1096
	public class NKMMissionData : ISerializable
	{
		// Token: 0x06001E03 RID: 7683 RVA: 0x000915E8 File Offset: 0x0008F7E8
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.tabId);
			stream.PutOrGet(ref this.mission_id);
			stream.PutOrGet(ref this.group_id);
			stream.PutOrGet(ref this.times);
			stream.PutOrGet(ref this.last_update_date);
			stream.PutOrGet(ref this.isComplete);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0009163D File Offset: 0x0008F83D
		public NKMMissionData()
		{
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0009164C File Offset: 0x0008F84C
		public NKMMissionData(NKMMissionTemplet missionTemplet, long lastUpdateDate)
		{

		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x000916A4 File Offset: 0x0008F8A4
		public NKMMissionData(NKMMissionTemplet missionTemplet, int dbGroupId, long dbTimes, bool isReward, DateTime dbEndDate, long lastUpdateDate)
		{
			this.tabId = missionTemplet.m_MissionTabId;
			this.mission_id = missionTemplet.m_MissionID;
			this.group_id = dbGroupId;
			this.endDate = dbEndDate;
			this.times = dbTimes;
			this.isComplete = isReward;
			this.last_update_date = lastUpdateDate;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x000916FC File Offset: 0x0008F8FC
		public void ProceedNextMission(int nextMissionId)
		{
			this.mission_id = nextMissionId;
			this.isComplete = false;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0009170C File Offset: 0x0008F90C
		public void UpdateMissionData(int missionId, long missionTimes, bool missionIsComplete, long lastUpdateDate)
		{
			this.mission_id = missionId;
			this.times = missionTimes;
			this.isComplete = missionIsComplete;
			this.last_update_date = lastUpdateDate;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0009172B File Offset: 0x0008F92B
		public void ResetMission(long lastUpdateDate)
		{
			this.times = 0L;
			this.isComplete = false;
			this.last_update_date = lastUpdateDate;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00091743 File Offset: 0x0008F943
		public bool IsComplete
		{
			get
			{
				return this.isComplete;
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0009174B File Offset: 0x0008F94B
		public void SetComplete()
		{
			this.isComplete = true;
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000917B3 File Offset: 0x0008F9B3
		public DateTime LastUpdateDate
		{
			get
			{
				return new DateTime(this.last_update_date);
			}
		}

		// Token: 0x04001F2B RID: 7979
		public int tabId;

		// Token: 0x04001F2C RID: 7980
		public int mission_id;

		// Token: 0x04001F2D RID: 7981
		public int group_id;

		// Token: 0x04001F2E RID: 7982
		public long times;

		// Token: 0x04001F2F RID: 7983
		public long last_update_date;

		// Token: 0x04001F30 RID: 7984
		private bool isComplete;

		// Token: 0x04001F31 RID: 7985
		public bool isEnable = true;

		// Token: 0x04001F32 RID: 7986
		public DateTime endDate;
	}
}
