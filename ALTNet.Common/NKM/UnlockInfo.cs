using System;
using System.Collections.Generic;

namespace NKM
{
	// Token: 0x020003C1 RID: 961
	public readonly struct UnlockInfo
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x00067EA4 File Offset: 0x000660A4
		public UnlockInfo(STAGE_UNLOCK_REQ_TYPE reqType, int reqValue)
		{
			this.eReqType = reqType;
			this.reqValue = reqValue;
			this.reqValueStr = string.Empty;
			this.reqDateTime = DateTime.MinValue;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00067ECA File Offset: 0x000660CA
		public UnlockInfo(STAGE_UNLOCK_REQ_TYPE reqType, int reqValue, string reqValueStr)
		{
			this.eReqType = reqType;
			this.reqValue = reqValue;
			this.reqValueStr = reqValueStr;
			this.reqDateTime = DateTime.MinValue;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00067EEC File Offset: 0x000660EC
		public UnlockInfo(STAGE_UNLOCK_REQ_TYPE reqType, int reqValue, DateTime reqDateTime)
		{
			this.eReqType = reqType;
			this.reqValue = reqValue;
			this.reqValueStr = string.Empty;
			this.reqDateTime = reqDateTime;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00067F0E File Offset: 0x0006610E
		public UnlockInfo(STAGE_UNLOCK_REQ_TYPE reqType, int reqValue, string reqValueStr, DateTime reqDateTime)
		{
			this.eReqType = reqType;
			this.reqValue = reqValue;
			this.reqValueStr = reqValueStr;
			this.reqDateTime = reqDateTime;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00068092 File Offset: 0x00066292
		public static bool IsDateTimeData(STAGE_UNLOCK_REQ_TYPE type)
		{
			return type - STAGE_UNLOCK_REQ_TYPE.SURT_START_DATETIME <= 2 || type == STAGE_UNLOCK_REQ_TYPE.SURT_REGISTER_DATE;
		}

		// Token: 0x040011C1 RID: 4545
		public readonly STAGE_UNLOCK_REQ_TYPE eReqType;

		// Token: 0x040011C2 RID: 4546
		public readonly int reqValue;

		// Token: 0x040011C3 RID: 4547
		public readonly string reqValueStr;

		// Token: 0x040011C4 RID: 4548
		public readonly DateTime reqDateTime;
	}
}
