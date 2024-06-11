using System;

namespace ClientPacket.Event
{
	// Token: 0x020010C5 RID: 4293
	public enum KakaoMissionState
	{
		// Token: 0x04009A5E RID: 39518
		Initialized,
		// Token: 0x04009A5F RID: 39519
		Registered,
		// Token: 0x04009A60 RID: 39520
		Sent,
		// Token: 0x04009A61 RID: 39521
		Confirmed,
		// Token: 0x04009A62 RID: 39522
		Failed,
		// Token: 0x04009A63 RID: 39523
		Flopped,
		// Token: 0x04009A64 RID: 39524
		NotEnoughBudget,
		// Token: 0x04009A65 RID: 39525
		OutOfDate
	}
}
