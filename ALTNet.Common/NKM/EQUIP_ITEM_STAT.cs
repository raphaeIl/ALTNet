using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000508 RID: 1288
	public class EQUIP_ITEM_STAT : ISerializable
	{
		// Token: 0x0600244A RID: 9290 RVA: 0x000BEF4F File Offset: 0x000BD14F
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.type);
			stream.PutOrGet(ref this.stat_value);
			stream.PutOrGet(ref this.stat_level_value);
		}

		// Token: 0x040026DF RID: 9951
		public NKM_STAT_TYPE type = NKM_STAT_TYPE.NST_RANDOM;

		// Token: 0x040026E0 RID: 9952
		public float stat_value;

		// Token: 0x040026E1 RID: 9953
		public float stat_level_value;
	}
}
