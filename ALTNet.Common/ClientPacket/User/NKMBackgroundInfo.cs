using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000D7C RID: 3452
	public sealed class NKMBackgroundInfo : ISerializable
	{
		// Token: 0x0600A154 RID: 41300 RVA: 0x00379305 File Offset: 0x00377505
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.backgroundItemId);
			stream.PutOrGet(ref this.backgroundBgmId);
			stream.PutOrGet<NKMBackgroundUnitInfo>(ref this.unitInfoList);
		}

		// Token: 0x040091F5 RID: 37365
		public int backgroundItemId;

		// Token: 0x040091F6 RID: 37366
		public int backgroundBgmId;

		// Token: 0x040091F7 RID: 37367
		public List<NKMBackgroundUnitInfo> unitInfoList = new List<NKMBackgroundUnitInfo>();
	}
}
