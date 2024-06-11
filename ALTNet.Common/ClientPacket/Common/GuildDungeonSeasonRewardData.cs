using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A4 RID: 4516
	public sealed class GuildDungeonSeasonRewardData : ISerializable
	{
		// Token: 0x0600A963 RID: 43363 RVA: 0x00385204 File Offset: 0x00383404
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<GuildDungeonRewardCategory>(ref this.category);
			stream.PutOrGet(ref this.totalValue);
			stream.PutOrGet(ref this.receivedValue);
		}

		// Token: 0x04009CD1 RID: 40145
		public GuildDungeonRewardCategory category;

		// Token: 0x04009CD2 RID: 40146
		public int totalValue;

		// Token: 0x04009CD3 RID: 40147
		public int receivedValue;
	}
}
