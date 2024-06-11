using System;

namespace ClientPacket.Common
{
	// Token: 0x020011BA RID: 4538
	public enum NKMTournamentState
	{
		// Token: 0x04009D42 RID: 40258
		Ended,
		// Token: 0x04009D43 RID: 40259
		Progressing,
		// Token: 0x04009D44 RID: 40260
		BanVote,
		// Token: 0x04009D45 RID: 40261
		PreBooking = 10,
		// Token: 0x04009D46 RID: 40262
		Tryout = 20,
		// Token: 0x04009D47 RID: 40263
		Final32 = 30,
		// Token: 0x04009D48 RID: 40264
		Final4 = 40,
		// Token: 0x04009D49 RID: 40265
		Closing = 50
	}
}
