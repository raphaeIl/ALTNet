using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EE1 RID: 3809
	public sealed class NKMMyOfficeState : ISerializable
	{
		// Token: 0x0600A415 RID: 42005 RVA: 0x0037D070 File Offset: 0x0037B270
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.openedSectionIds);
			stream.PutOrGet<NKMOfficeRoom>(ref this.rooms);
			stream.PutOrGet<NKMInteriorData>(ref this.interiors);
			stream.PutOrGet<NKMOfficePostState>(ref this.postState);
			stream.PutOrGet<NKMOfficePreset>(ref this.presets);
		}

		// Token: 0x04009560 RID: 38240
		public List<int> openedSectionIds = new List<int>();

		// Token: 0x04009561 RID: 38241
		public List<NKMOfficeRoom> rooms = new List<NKMOfficeRoom>();

		// Token: 0x04009562 RID: 38242
		public List<NKMInteriorData> interiors = new List<NKMInteriorData>();

		// Token: 0x04009563 RID: 38243
		public NKMOfficePostState postState = new NKMOfficePostState();

		// Token: 0x04009564 RID: 38244
		public List<NKMOfficePreset> presets = new List<NKMOfficePreset>();
	}
}
