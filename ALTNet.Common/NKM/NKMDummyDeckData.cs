using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x020003E3 RID: 995
	public sealed class NKMDummyDeckData : ISerializable
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x000718D0 File Offset: 0x0006FAD0
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.LeaderIndex);
			stream.PutOrGet<NKMDummyUnitData>(ref this.Ship);
			stream.PutOrGet<NKMDummyUnitData>(ref this.operatorUnit);
			stream.PutOrGet<NKMDummyUnitData>(ref this.List);
		}

		// Token: 0x04001350 RID: 4944
		public sbyte LeaderIndex;

		// Token: 0x04001351 RID: 4945
		public NKMDummyUnitData Ship = new NKMDummyUnitData();

		// Token: 0x04001352 RID: 4946
		public NKMDummyUnitData operatorUnit = new NKMDummyUnitData();

		// Token: 0x04001353 RID: 4947
		public NKMDummyUnitData[] List = new NKMDummyUnitData[8];
	}
}
