using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x02001195 RID: 4501
	public sealed class NKMAsyncDeckData : ISerializable
	{
		// Token: 0x0600A947 RID: 43335 RVA: 0x00384CE8 File Offset: 0x00382EE8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.leaderIndex);
			stream.PutOrGet<NKMAsyncUnitData>(ref this.ship);
			stream.PutOrGet<NKMAsyncUnitData>(ref this.units);
			stream.PutOrGet<NKMEquipItemData>(ref this.equips);
			stream.PutOrGet(ref this.operationPower);
			stream.PutOrGet<NKMOperator>(ref this.operatorUnit);
			stream.PutOrGet<NKMAsyncUnitData>(ref this.banishedUnit);
			stream.PutOrGet<NKMUnitUpData>(ref this.unitUpData);
			stream.PutOrGet<NKMBanData>(ref this.unitBanData);
		}

		// Token: 0x04009C82 RID: 40066
		public short leaderIndex;

		// Token: 0x04009C83 RID: 40067
		public NKMAsyncUnitData ship = new NKMAsyncUnitData();

		// Token: 0x04009C84 RID: 40068
		public List<NKMAsyncUnitData> units = new List<NKMAsyncUnitData>();

		// Token: 0x04009C85 RID: 40069
		public List<NKMEquipItemData> equips = new List<NKMEquipItemData>();

		// Token: 0x04009C86 RID: 40070
		public int operationPower;

		// Token: 0x04009C87 RID: 40071
		public NKMOperator operatorUnit;

		// Token: 0x04009C88 RID: 40072
		public NKMAsyncUnitData banishedUnit = new NKMAsyncUnitData();

		// Token: 0x04009C89 RID: 40073
		public Dictionary<int, NKMUnitUpData> unitUpData = new Dictionary<int, NKMUnitUpData>();

		// Token: 0x04009C8A RID: 40074
		public Dictionary<int, NKMBanData> unitBanData = new Dictionary<int, NKMBanData>();
	}
}
