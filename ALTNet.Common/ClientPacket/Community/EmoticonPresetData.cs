using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Community
{
	// Token: 0x0200111E RID: 4382
	public sealed class EmoticonPresetData : ISerializable
	{
		// Token: 0x0600A867 RID: 43111 RVA: 0x00383A4D File Offset: 0x00381C4D
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.animationList);
			stream.PutOrGet(ref this.textList);
		}

		// Token: 0x04009B69 RID: 39785
		public List<int> animationList = new List<int>();

		// Token: 0x04009B6A RID: 39786
		public List<int> textList = new List<int>();
	}
}
