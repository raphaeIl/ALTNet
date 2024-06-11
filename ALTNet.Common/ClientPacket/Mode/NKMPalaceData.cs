using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F3C RID: 3900
	public sealed class NKMPalaceData : ISerializable
	{
		// Token: 0x0600A4C7 RID: 42183 RVA: 0x0037E097 File Offset: 0x0037C297
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.palaceId);
			stream.PutOrGet(ref this.currentDungeonId);
			stream.PutOrGet<NKMPalaceDungeonData>(ref this.dungeonDataList);
		}

		// Token: 0x04009636 RID: 38454
		public int palaceId;

		// Token: 0x04009637 RID: 38455
		public int currentDungeonId;

		// Token: 0x04009638 RID: 38456
		public List<NKMPalaceDungeonData> dungeonDataList = new List<NKMPalaceDungeonData>();
	}
}
