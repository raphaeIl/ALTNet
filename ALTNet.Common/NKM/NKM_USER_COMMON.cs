using System;

namespace NKM
{
	// Token: 0x02000505 RID: 1285
	public static class NKM_USER_COMMON
	{
		// Token: 0x06002436 RID: 9270 RVA: 0x000BECE0 File Offset: 0x000BCEE0
		public static bool CheckNickName(string nickName)
		{
			if (string.IsNullOrEmpty(nickName))
			{
				return false;
			}
			int nickNameLength = NKM_USER_COMMON.GetNickNameLength(nickName);
			return nickNameLength >= NKM_USER_COMMON.USER_NICK_MIN_LENGTH && nickNameLength <= NKM_USER_COMMON.USER_NICK_MAX_LENGTH;
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x000BED11 File Offset: 0x000BCF11
		public static bool CheckNickNameForServer(string nickName)
		{
			return !string.IsNullOrEmpty(nickName) && NKM_USER_COMMON.GetNickNameLength(nickName) >= NKM_USER_COMMON.USER_NICK_MIN_LENGTH;
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000BED30 File Offset: 0x000BCF30
		public static int GetNickNameLength(string str)
		{
			int num = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] <= 'ÿ')
				{
					num++;
				}
				else
				{
					num += 2;
				}
			}
			return num;
		}

		// Token: 0x040026CB RID: 9931
		public static int USER_NICK_MIN_LENGTH = 4;

		// Token: 0x040026CC RID: 9932
		public static int USER_NICK_MAX_LENGTH = 16;
	}
}
