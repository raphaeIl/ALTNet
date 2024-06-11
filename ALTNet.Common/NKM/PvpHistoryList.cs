using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000365 RID: 869
	public class PvpHistoryList : ISerializable
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x0004E56D File Offset: 0x0004C76D
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<PvpSingleHistory>(ref this.list);
		}

		// Token: 0x04000E6A RID: 3690
		private List<PvpSingleHistory> list = new List<PvpSingleHistory>();
	}
}
