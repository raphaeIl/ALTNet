using System;

namespace ClientPacket.Common
{
	// Token: 0x020011AF RID: 4527
	public enum ChatMessageType
	{
		// Token: 0x04009D05 RID: 40197
		Normal,
		// Token: 0x04009D06 RID: 40198
		System,
		// Token: 0x04009D07 RID: 40199
		SystemLevelUp,
		// Token: 0x04009D08 RID: 40200
		SystemJoin,
		// Token: 0x04009D09 RID: 40201
		SystemExit,
		// Token: 0x04009D0A RID: 40202
		SystemBan,
		// Token: 0x04009D0B RID: 40203
		SystemPromotion,
		// Token: 0x04009D0C RID: 40204
		SystemMasterMigration,
		// Token: 0x04009D0D RID: 40205
		SystemNotice,
		// Token: 0x04009D0E RID: 40206
		SystemNoticeDungeon,
		// Token: 0x04009D0F RID: 40207
		SystemRename
	}
}
