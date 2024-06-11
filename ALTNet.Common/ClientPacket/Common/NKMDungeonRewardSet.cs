using System;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x020011A6 RID: 4518
	public sealed class NKMDungeonRewardSet : ISerializable
	{
		// Token: 0x0600A967 RID: 43367 RVA: 0x0038526B File Offset: 0x0038346B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMEpisodeCompleteData>(ref this.episodeCompleteData);
			stream.PutOrGet<NKMDungeonClearData>(ref this.dungeonClearData);
		}

		// Token: 0x04009CD7 RID: 40151
		public NKMEpisodeCompleteData episodeCompleteData;

		// Token: 0x04009CD8 RID: 40152
		public NKMDungeonClearData dungeonClearData = new NKMDungeonClearData();
	}
}
