using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM.Templet.Office;

namespace ClientPacket.Office
{
	// Token: 0x02000EDD RID: 3805
	public sealed class NKMOfficeRoom : ISerializable
	{
		// Token: 0x0600A40D RID: 41997 RVA: 0x0037CF14 File Offset: 0x0037B114
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.id);
			stream.PutOrGet(ref this.name);
			stream.PutOrGetEnum<OfficeGrade>(ref this.grade);
			stream.PutOrGet(ref this.interiorScore);
			stream.PutOrGet<NKMOfficeFurniture>(ref this.furnitures);
			stream.PutOrGet(ref this.unitUids);
			stream.PutOrGet(ref this.floorInteriorId);
			stream.PutOrGet(ref this.wallInteriorId);
			stream.PutOrGet(ref this.backgroundId);
		}

		// Token: 0x0400954B RID: 38219
		public int id;

		// Token: 0x0400954C RID: 38220
		public string name;

		// Token: 0x0400954D RID: 38221
		public OfficeGrade grade;

		// Token: 0x0400954E RID: 38222
		public int interiorScore;

		// Token: 0x0400954F RID: 38223
		public List<NKMOfficeFurniture> furnitures = new List<NKMOfficeFurniture>();

		// Token: 0x04009550 RID: 38224
		public List<long> unitUids = new List<long>();

		// Token: 0x04009551 RID: 38225
		public int floorInteriorId;

		// Token: 0x04009552 RID: 38226
		public int wallInteriorId;

		// Token: 0x04009553 RID: 38227
		public int backgroundId;
	}
}
