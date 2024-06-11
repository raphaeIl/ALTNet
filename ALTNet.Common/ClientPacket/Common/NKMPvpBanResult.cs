using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x020011AC RID: 4524
	public sealed class NKMPvpBanResult : ISerializable
	{
		// Token: 0x0600A973 RID: 43379 RVA: 0x00385404 File Offset: 0x00383604
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMBanData>(ref this.unitBanList);
			stream.PutOrGet<NKMBanShipData>(ref this.shipBanList);
			stream.PutOrGet<NKMBanOperatorData>(ref this.operatorBanList);
			stream.PutOrGet<NKMUnitUpData>(ref this.unitUpList);
			stream.PutOrGet<NKMBanData>(ref this.unitCastingBanList);
			stream.PutOrGet<NKMBanShipData>(ref this.shipCastingBanList);
			stream.PutOrGet<NKMBanOperatorData>(ref this.operatorCastingBanList);
			stream.PutOrGet<NKMBanData>(ref this.unitFinalBanList);
			stream.PutOrGet<NKMBanShipData>(ref this.shipFinalBanList);
			stream.PutOrGet<NKMBanOperatorData>(ref this.operatorFinalBanList);
		}

		// Token: 0x04009CF2 RID: 40178
		public Dictionary<int, NKMBanData> unitBanList = new Dictionary<int, NKMBanData>();

		// Token: 0x04009CF3 RID: 40179
		public Dictionary<int, NKMBanShipData> shipBanList = new Dictionary<int, NKMBanShipData>();

		// Token: 0x04009CF4 RID: 40180
		public Dictionary<int, NKMBanOperatorData> operatorBanList = new Dictionary<int, NKMBanOperatorData>();

		// Token: 0x04009CF5 RID: 40181
		public Dictionary<int, NKMUnitUpData> unitUpList = new Dictionary<int, NKMUnitUpData>();

		// Token: 0x04009CF6 RID: 40182
		public Dictionary<int, NKMBanData> unitCastingBanList = new Dictionary<int, NKMBanData>();

		// Token: 0x04009CF7 RID: 40183
		public Dictionary<int, NKMBanShipData> shipCastingBanList = new Dictionary<int, NKMBanShipData>();

		// Token: 0x04009CF8 RID: 40184
		public Dictionary<int, NKMBanOperatorData> operatorCastingBanList = new Dictionary<int, NKMBanOperatorData>();

		// Token: 0x04009CF9 RID: 40185
		public Dictionary<int, NKMBanData> unitFinalBanList = new Dictionary<int, NKMBanData>();

		// Token: 0x04009CFA RID: 40186
		public Dictionary<int, NKMBanShipData> shipFinalBanList = new Dictionary<int, NKMBanShipData>();

		// Token: 0x04009CFB RID: 40187
		public Dictionary<int, NKMBanOperatorData> operatorFinalBanList = new Dictionary<int, NKMBanOperatorData>();
	}
}
