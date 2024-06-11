using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x02000406 RID: 1030
	public enum NKM_GAME_STATE : byte
	{
		// Token: 0x04001BAF RID: 7087
		NGS_INVALID,
		// Token: 0x04001BB0 RID: 7088
		[CountryDescription("던전 미참여", CountryCode.KOR)]
		NGS_STOP,
		// Token: 0x04001BB1 RID: 7089
		[CountryDescription("던전 플레이 시작", CountryCode.KOR)]
		NGS_START,
		// Token: 0x04001BB2 RID: 7090
		[CountryDescription("던전 플레이 중", CountryCode.KOR)]
		NGS_PLAY,
		// Token: 0x04001BB3 RID: 7091
		[CountryDescription("던전 플레이 종료", CountryCode.KOR)]
		NGS_FINISH,
		// Token: 0x04001BB4 RID: 7092
		[CountryDescription("던전 종료", CountryCode.KOR)]
		NGS_END,
		// Token: 0x04001BB5 RID: 7093
		[CountryDescription("방생성-파티매칭", CountryCode.KOR)]
		NGS_LOBBY_MATCHING,
		// Token: 0x04001BB6 RID: 7094
		[CountryDescription("방생성-게임편성", CountryCode.KOR)]
		NGS_LOBBY_GAME_SETTING
	}
}
