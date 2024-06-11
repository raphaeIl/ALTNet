using System;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x0200043B RID: 1083
	public class NKMMiscCollectionData : ISerializable
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0008DAE1 File Offset: 0x0008BCE1
		public int MiscId
		{
			get
			{
				return this.miscId;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0008DAE9 File Offset: 0x0008BCE9
		public bool Reward
		{
			get
			{
				return this.reward;
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0008DAF1 File Offset: 0x0008BCF1
		public NKMMiscCollectionData()
		{
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0008DAF9 File Offset: 0x0008BCF9
		public NKMMiscCollectionData(int teamId, bool reward)
		{
			this.miscId = teamId;
			this.reward = reward;
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0008DB0F File Offset: 0x0008BD0F
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.miscId);
			stream.PutOrGet(ref this.reward);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0008DB29 File Offset: 0x0008BD29
		public void GiveReward()
		{
			this.reward = true;
		}

		// Token: 0x04001DD5 RID: 7637
		private int miscId;

		// Token: 0x04001DD6 RID: 7638
		private bool reward;
	}
}
