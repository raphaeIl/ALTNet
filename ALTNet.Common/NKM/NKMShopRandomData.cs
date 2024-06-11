using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200047E RID: 1150
	public class NKMShopRandomData : ISerializable
	{
		// Token: 0x06001F76 RID: 8054 RVA: 0x00097899 File Offset: 0x00095A99
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMShopRandomListData>(ref this.datas);
			stream.PutOrGet(ref this.nextRefreshDate);
			stream.PutOrGet(ref this.refreshCount);
		}

		// Token: 0x040020DF RID: 8415
		public Dictionary<int, NKMShopRandomListData> datas = new Dictionary<int, NKMShopRandomListData>();

		// Token: 0x040020E0 RID: 8416
		public long nextRefreshDate;

		// Token: 0x040020E1 RID: 8417
		public int refreshCount;
	}
}
