using System;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x02000510 RID: 1296
	public class NKMEpisodeCompleteData : ISerializable
	{
		// Token: 0x06002496 RID: 9366 RVA: 0x000BFDF0 File Offset: 0x000BDFF0
		public void DeepCopyFromSource(NKMEpisodeCompleteData source)
		{
			this.m_EpisodeID = source.m_EpisodeID;
			this.m_EpisodeDifficulty = source.m_EpisodeDifficulty;
			this.m_EpisodeCompleteCount = source.m_EpisodeCompleteCount;
			for (int i = 0; i < 3; i++)
			{
				this.m_bRewards[i] = source.m_bRewards[i];
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000BFE3D File Offset: 0x000BE03D
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_EpisodeID);
			stream.PutOrGetEnum<EPISODE_DIFFICULTY>(ref this.m_EpisodeDifficulty);
			stream.PutOrGet(ref this.m_EpisodeCompleteCount);
			stream.PutOrGet(ref this.m_bRewards);
		}

		// Token: 0x04002706 RID: 9990
		public int m_EpisodeID;

		// Token: 0x04002707 RID: 9991
		public EPISODE_DIFFICULTY m_EpisodeDifficulty;

		// Token: 0x04002708 RID: 9992
		public int m_EpisodeCompleteCount;

		// Token: 0x04002709 RID: 9993
		public bool[] m_bRewards = new bool[3];
	}
}
