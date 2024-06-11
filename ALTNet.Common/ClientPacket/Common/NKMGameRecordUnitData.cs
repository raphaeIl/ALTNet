using System;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x020011AA RID: 4522
	public sealed class NKMGameRecordUnitData : ISerializable
	{
		// Token: 0x0600A96F RID: 43375 RVA: 0x00385318 File Offset: 0x00383518
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.unitId);
			stream.PutOrGet(ref this.changeUnitName);
			stream.PutOrGet(ref this.unitLevel);
			stream.PutOrGet(ref this.isSummonee);
			stream.PutOrGet(ref this.isAssistUnit);
			stream.PutOrGet(ref this.isLeader);
			stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.teamType);
			stream.PutOrGet(ref this.recordGiveDamage);
			stream.PutOrGet(ref this.recordTakeDamage);
			stream.PutOrGet(ref this.recordHeal);
			stream.PutOrGet(ref this.recordSummonCount);
			stream.PutOrGet(ref this.recordDieCount);
			stream.PutOrGet(ref this.recordKillCount);
			stream.PutOrGet(ref this.playtime);
		}

		// Token: 0x04009CE1 RID: 40161
		public int unitId;

		// Token: 0x04009CE2 RID: 40162
		public string changeUnitName;

		// Token: 0x04009CE3 RID: 40163
		public int unitLevel;

		// Token: 0x04009CE4 RID: 40164
		public bool isSummonee;

		// Token: 0x04009CE5 RID: 40165
		public bool isAssistUnit;

		// Token: 0x04009CE6 RID: 40166
		public bool isLeader;

		// Token: 0x04009CE7 RID: 40167
		public NKM_TEAM_TYPE teamType;

		// Token: 0x04009CE8 RID: 40168
		public float recordGiveDamage;

		// Token: 0x04009CE9 RID: 40169
		public float recordTakeDamage;

		// Token: 0x04009CEA RID: 40170
		public float recordHeal;

		// Token: 0x04009CEB RID: 40171
		public int recordSummonCount;

		// Token: 0x04009CEC RID: 40172
		public int recordDieCount;

		// Token: 0x04009CED RID: 40173
		public int recordKillCount;

		// Token: 0x04009CEE RID: 40174
		public int playtime;
	}
}
