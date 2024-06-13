using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000410 RID: 1040
	public class NKMGameSyncData_DungeonEvent : ISerializable
	{
		// Token: 0x06001B49 RID: 6985 RVA: 0x0007A170 File Offset: 0x00078370
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_EVENT_ACTION_TYPE>(ref this.m_eEventActionType);
			stream.PutOrGet(ref this.m_EventID);
			stream.PutOrGet(ref this.m_iEventActionValue);
			stream.PutOrGet(ref this.m_strEventActionValue);
			stream.PutOrGet(ref this.m_bPause);
			stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.m_eTeam);
		}

		// Token: 0x04001BE6 RID: 7142
		public NKM_EVENT_ACTION_TYPE m_eEventActionType;

		// Token: 0x04001BE7 RID: 7143
		public int m_EventID;

		// Token: 0x04001BE8 RID: 7144
		public int m_iEventActionValue;

		// Token: 0x04001BE9 RID: 7145
		public string m_strEventActionValue;

		// Token: 0x04001BEA RID: 7146
		public bool m_bPause;

		// Token: 0x04001BEB RID: 7147
		public NKM_TEAM_TYPE m_eTeam;
	}
}
