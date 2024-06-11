using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000426 RID: 1062
	public sealed class NKMGameRecord : ISerializable
	{
		// Token: 0x06001C6D RID: 7277 RVA: 0x000828BD File Offset: 0x00080ABD
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMGameRecordUnitData>(ref this.unitRecords);
			stream.PutOrGet(ref this.totalDamageA);
			stream.PutOrGet(ref this.totalDamageB);
			stream.PutOrGet(ref this.totalFiercePoint);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000828EF File Offset: 0x00080AEF
		public float GetShipTakeDamage(short shipIndex)
		{
			return this.unitRecords[shipIndex].recordTakeDamage;
		}

		// Token: 0x04001CCF RID: 7375
		private Dictionary<short, NKMGameRecordUnitData> unitRecords = new Dictionary<short, NKMGameRecordUnitData>();

		// Token: 0x04001CD0 RID: 7376
		private float totalDamageA;

		// Token: 0x04001CD1 RID: 7377
		private float totalDamageB;

		// Token: 0x04001CD2 RID: 7378
		private int totalDieCountA;

		// Token: 0x04001CD3 RID: 7379
		private int totalDieCountB;

		// Token: 0x04001CD4 RID: 7380
		private float totalFiercePoint;

		// Token: 0x04001CD5 RID: 7381
		private float fiercePenaltyPoint;

		// Token: 0x04001CD6 RID: 7382
		private float totalTrimPoint;
	}
}
