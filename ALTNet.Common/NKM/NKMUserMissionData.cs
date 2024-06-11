using System;
using System.Collections.Generic;
using System.Linq;
using Cs.Core.Util;
using Cs.Protocol;
using NKC;

namespace NKM
{
	// Token: 0x02000515 RID: 1301
	public class NKMUserMissionData : ISerializable
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x000C2425 File Offset: 0x000C0625
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.dicRefreshInfo);
			stream.PutOrGet<NKMMissionData>(ref this.dicMissions);
			stream.PutOrGet(ref this.achievePoint);
		}

		// Token: 0x04002753 RID: 10067
		private long achievePoint;

		// Token: 0x04002754 RID: 10068
		private Dictionary<int, int> dicRefreshInfo = new Dictionary<int, int>();

		// Token: 0x04002755 RID: 10069
		private Dictionary<int, NKMMissionData> dicMissions = new Dictionary<int, NKMMissionData>();

		// Token: 0x04002756 RID: 10070
		private HashSet<int> completeFlag = new HashSet<int>();

		// Token: 0x04002757 RID: 10071
		private DateTime m_dLastRandomMissionRefreshTime;
	}
}
