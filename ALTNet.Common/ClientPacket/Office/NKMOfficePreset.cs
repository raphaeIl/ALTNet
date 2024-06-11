using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EE0 RID: 3808
	public sealed class NKMOfficePreset : ISerializable
	{
		// Token: 0x0600A413 RID: 42003 RVA: 0x0037D008 File Offset: 0x0037B208
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.presetId);
			stream.PutOrGet(ref this.name);
			stream.PutOrGet<NKMOfficeFurniture>(ref this.furnitures);
			stream.PutOrGet(ref this.floorInteriorId);
			stream.PutOrGet(ref this.wallInteriorId);
			stream.PutOrGet(ref this.backgroundId);
		}

		// Token: 0x0400955A RID: 38234
		public int presetId;

		// Token: 0x0400955B RID: 38235
		public string name;

		// Token: 0x0400955C RID: 38236
		public List<NKMOfficeFurniture> furnitures = new List<NKMOfficeFurniture>();

		// Token: 0x0400955D RID: 38237
		public int floorInteriorId;

		// Token: 0x0400955E RID: 38238
		public int wallInteriorId;

		// Token: 0x0400955F RID: 38239
		public int backgroundId;
	}
}
