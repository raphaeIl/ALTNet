using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000455 RID: 1109
	public class NKMOperatorSkill : ISerializable
	{
		// Token: 0x06001E49 RID: 7753 RVA: 0x000928A3 File Offset: 0x00090AA3
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.id);
			stream.PutOrGet(ref this.level);
			stream.PutOrGet(ref this.exp);
		}

		// Token: 0x04001FC1 RID: 8129
		public int id;

		// Token: 0x04001FC2 RID: 8130
		public byte level;

		// Token: 0x04001FC3 RID: 8131
		public int exp;
	}
}
