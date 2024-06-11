using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A5 RID: 4517
	public sealed class GuildDungeonRewardInfo : ISerializable
	{
		// Token: 0x0600A965 RID: 43365 RVA: 0x00385232 File Offset: 0x00383432
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.currentSeasonId);
			stream.PutOrGet<GuildDungeonSeasonRewardData>(ref this.lastSeasonRewardData);
			stream.PutOrGet(ref this.canReward);
		}

		// Token: 0x04009CD4 RID: 40148
		public int currentSeasonId;

		// Token: 0x04009CD5 RID: 40149
		public List<GuildDungeonSeasonRewardData> lastSeasonRewardData = new List<GuildDungeonSeasonRewardData>();

		// Token: 0x04009CD6 RID: 40150
		public bool canReward;
	}
}
