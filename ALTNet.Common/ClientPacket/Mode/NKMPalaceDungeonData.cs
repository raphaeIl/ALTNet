using System;
using Cs.Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F3B RID: 3899
	public sealed class NKMPalaceDungeonData : ISerializable
	{
		// Token: 0x0600A4C5 RID: 42181 RVA: 0x0037E069 File Offset: 0x0037C269
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.dungeonId);
			stream.PutOrGet(ref this.recentTime);
			stream.PutOrGet(ref this.bestTime);
		}

		// Token: 0x04009633 RID: 38451
		public int dungeonId;

		// Token: 0x04009634 RID: 38452
		public int recentTime;

		// Token: 0x04009635 RID: 38453
		public int bestTime;
	}
}
