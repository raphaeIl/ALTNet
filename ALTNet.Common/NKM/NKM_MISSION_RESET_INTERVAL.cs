using System;
using Cs.GameLog.CountryDescription;

namespace NKM
{
	// Token: 0x0200043E RID: 1086
	public enum NKM_MISSION_RESET_INTERVAL
	{
		// Token: 0x04001DF5 RID: 7669
		[CountryDescription("�Ϸ���� ����", CountryCode.KOR)]
		ALWAYS,
		// Token: 0x04001DF6 RID: 7670
		[CountryDescription("���� �ݺ��̼�", CountryCode.KOR)]
		DAILY,
		// Token: 0x04001DF7 RID: 7671
		[CountryDescription("�ְ� �ݺ��̼�", CountryCode.KOR)]
		WEEKLY,
		// Token: 0x04001DF8 RID: 7672
		[CountryDescription("���� �ݺ��̼�", CountryCode.KOR)]
		MONTHLY,
		// Token: 0x04001DF9 RID: 7673
		[CountryDescription("�Ϸ� üũ ��", CountryCode.KOR)]
		ON_COMPLETE,
		// Token: 0x04001DFA RID: 7674
		[CountryDescription("�ݺ��ֱ� ����", CountryCode.KOR)]
		NONE
	}
}
