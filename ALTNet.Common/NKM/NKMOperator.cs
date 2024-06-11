using System;
using Cs.Protocol;
using NKM.Templet;
using NKM.Templet.Base;

namespace NKM
{
	// Token: 0x02000454 RID: 1108
	public sealed class NKMOperator : ISerializable
	{
		// Token: 0x06001E45 RID: 7749 RVA: 0x00092714 File Offset: 0x00090914
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.id);
			stream.PutOrGet(ref this.uid);
			stream.PutOrGet(ref this.level);
			stream.PutOrGet(ref this.exp);
			stream.PutOrGet(ref this.bLock);
			stream.PutOrGet<NKMOperatorSkill>(ref this.mainSkill);
			stream.PutOrGet<NKMOperatorSkill>(ref this.subSkill);
			stream.PutOrGet(ref this.fromContract);
		}

		// Token: 0x04001FB7 RID: 8119
		public long uid;

		// Token: 0x04001FB8 RID: 8120
		public int id;

		// Token: 0x04001FB9 RID: 8121
		public int level;

		// Token: 0x04001FBA RID: 8122
		public int exp;

		// Token: 0x04001FBB RID: 8123
		public NKMOperatorSkill mainSkill;

		// Token: 0x04001FBC RID: 8124
		public NKMOperatorSkill subSkill;

		// Token: 0x04001FBD RID: 8125
		public bool bLock;

		// Token: 0x04001FBE RID: 8126
		public bool fromContract;

		// Token: 0x04001FBF RID: 8127
		public int power;

		// Token: 0x04001FC0 RID: 8128
		public DateTime regDate;
	}
}
