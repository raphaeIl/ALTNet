using System;
using Cs.Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F5D RID: 3933
	public sealed class NKMShortCutInfo : ISerializable
	{
		// Token: 0x0600A509 RID: 42249 RVA: 0x0037E697 File Offset: 0x0037C897
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.gameType);
			stream.PutOrGet(ref this.stageId);
		}

		// Token: 0x04009684 RID: 38532
		public int gameType;

		// Token: 0x04009685 RID: 38533
		public int stageId;
	}
}
