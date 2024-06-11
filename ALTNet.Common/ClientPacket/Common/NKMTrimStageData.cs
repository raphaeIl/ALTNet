using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011B4 RID: 4532
	public sealed class NKMTrimStageData : ISerializable
	{
		// Token: 0x0600A981 RID: 43393 RVA: 0x003856CA File Offset: 0x003838CA
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.index);
			stream.PutOrGet(ref this.dungeonId);
			stream.PutOrGet(ref this.score);
			stream.PutOrGet(ref this.isWin);
		}

		// Token: 0x04009D23 RID: 40227
		public int index;

		// Token: 0x04009D24 RID: 40228
		public int dungeonId;

		// Token: 0x04009D25 RID: 40229
		public int score;

		// Token: 0x04009D26 RID: 40230
		public bool isWin;
	}
}
