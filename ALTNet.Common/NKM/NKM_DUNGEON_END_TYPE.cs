using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x020003E9 RID: 1001
	public enum NKM_DUNGEON_END_TYPE
	{
		// Token: 0x04001374 RID: 4980
		[CountryDescription("정상종료", CountryCode.KOR)]
		NORMAL,
		// Token: 0x04001375 RID: 4981
		[CountryDescription("포기", CountryCode.KOR)]
		GIVE_UP,
		// Token: 0x04001376 RID: 4982
		[CountryDescription("타임아웃", CountryCode.KOR)]
		TIME_OUT,
		// Token: 0x04001377 RID: 4983
		[CountryDescription("연결종료", CountryCode.KOR)]
		DISCONNECT
	}
}
