namespace NKM
{
	// Token: 0x020003EB RID: 1003
	public class NKMDungeonEventTiming
	{
		// Token: 0x0400137F RID: 4991
		public float m_fEventTimeStart;

		// Token: 0x04001380 RID: 4992
		public float m_fEventTimeEnd;

		// Token: 0x04001381 RID: 4993
		public float m_fEventBossHPLess;

		// Token: 0x04001382 RID: 4994
		public float m_fEventBossHPUpper;

		// Token: 0x04001383 RID: 4995
		public bool m_fEventIgnoreBossInitHPLess = true;

		// Token: 0x04001384 RID: 4996
		public float m_fEventTimeGap;

		// Token: 0x04001385 RID: 4997
		public string m_EventLiveDeckTag = "";

		// Token: 0x04001386 RID: 4998
		public string m_EventLiveWarfareDungeonTag = "";

		// Token: 0x04001387 RID: 4999
		public string m_EventDieWarfareDungeonTag = "";

		// Token: 0x04001388 RID: 5000
		public string m_EventDieUnitTag = "";

		// Token: 0x04001389 RID: 5001
		public int m_EventDieUnitTagCount;

		// Token: 0x0400138A RID: 5002
		public string m_EventDieDeckTag = "";

		// Token: 0x0400138B RID: 5003
		public int m_EventDieDeckTagCount;

		// Token: 0x0400138C RID: 5004
		public string m_EventTag = "";

		// Token: 0x0400138D RID: 5005
		public int m_EventTagCount;

		// Token: 0x0400138E RID: 5006
		public float m_fEventPos;

		// Token: 0x0400138F RID: 5007
		public NKM_DUNGEON_EVENT_TYPE m_NKM_DUNGEON_EVENT_TYPE = NKM_DUNGEON_EVENT_TYPE.NDET_DECK;
	}
}
