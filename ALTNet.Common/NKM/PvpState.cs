using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000364 RID: 868
	public class PvpState : ISerializable
	{
		// Token: 0x0600147E RID: 5246 RVA: 0x0004E35F File Offset: 0x0004C55F
		public bool IsBanPossibleScore()
		{
			return false;
			//return PvpState.IsBanPossibleScore(this.Score);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0004E36C File Offset: 0x0004C56C
		public static void SetPrevScore(int score)
		{
			PvpState.m_sPrevScore = score;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0004E374 File Offset: 0x0004C574
		public static int GetPrevScore()
		{
			return PvpState.m_sPrevScore;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0004E37C File Offset: 0x0004C57C
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.SeasonID);
			stream.PutOrGet(ref this.WeekID);
			stream.PutOrGet(ref this.WinCount);
			stream.PutOrGet(ref this.LoseCount);
			stream.PutOrGet(ref this.LeagueTierID);
			stream.PutOrGet(ref this.MaxLeagueTierID);
			stream.PutOrGet(ref this.Score);
			stream.PutOrGet(ref this.MaxScore);
			stream.PutOrGet(ref this.WinStreak);
			stream.PutOrGet(ref this.MaxWinStreak);
			stream.PutOrGet(ref this.Rank);
			stream.PutOrGet(ref this.SeasonPlayCount);
			stream.PutOrGet(ref this.SeasonWinCount);
		}

		// Token: 0x04000E5C RID: 3676
		private static int m_sPrevScore;

		// Token: 0x04000E5D RID: 3677
		public int SeasonID;

		// Token: 0x04000E5E RID: 3678
		public int WeekID;

		// Token: 0x04000E5F RID: 3679
		public int WinCount;

		// Token: 0x04000E60 RID: 3680
		public int LoseCount;

		// Token: 0x04000E61 RID: 3681
		public int LeagueTierID;

		// Token: 0x04000E62 RID: 3682
		public int MaxLeagueTierID;

		// Token: 0x04000E63 RID: 3683
		public int Score;

		// Token: 0x04000E64 RID: 3684
		public int MaxScore;

		// Token: 0x04000E65 RID: 3685
		public int WinStreak;

		// Token: 0x04000E66 RID: 3686
		public int MaxWinStreak;

		// Token: 0x04000E67 RID: 3687
		public int Rank;

		// Token: 0x04000E68 RID: 3688
		public int SeasonPlayCount;

		// Token: 0x04000E69 RID: 3689
		public int SeasonWinCount;
	}
}
