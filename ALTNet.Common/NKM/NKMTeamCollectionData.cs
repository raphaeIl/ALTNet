using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000488 RID: 1160
	public class NKMTeamCollectionData : ISerializable
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00098BB7 File Offset: 0x00096DB7
		public int TeamID
		{
			get
			{
				return this.m_TeamID;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00098BBF File Offset: 0x00096DBF
		public bool Reward
		{
			get
			{
				return this.m_bReward;
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00098BC7 File Offset: 0x00096DC7
		public NKMTeamCollectionData()
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00098BCF File Offset: 0x00096DCF
		public NKMTeamCollectionData(int teamID, bool reward)
		{
			this.m_TeamID = teamID;
			this.m_bReward = reward;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00098BE5 File Offset: 0x00096DE5
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_TeamID);
			stream.PutOrGet(ref this.m_bReward);
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00098BFF File Offset: 0x00096DFF
		public void GiveReward()
		{
			this.m_bReward = true;
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00098C08 File Offset: 0x00096E08
		public bool IsRewardComplete()
		{
			return this.m_bReward;
		}

		// Token: 0x04002139 RID: 8505
		private int m_TeamID;

		// Token: 0x0400213A RID: 8506
		private bool m_bReward;
	}
}
