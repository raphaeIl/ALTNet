using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;

namespace ClientPacket.Office
{
	// Token: 0x02000EE3 RID: 3811
	public sealed class NKMOfficeState : ISerializable
	{
		// Token: 0x0600A419 RID: 42009 RVA: 0x0037D11B File Offset: 0x0037B31B
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet(ref this.openedSectionIds);
			stream.PutOrGet<NKMOfficeRoom>(ref this.rooms);
			stream.PutOrGet<NKMOfficeUnitData>(ref this.units);
		}

		// Token: 0x04009568 RID: 38248
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009569 RID: 38249
		public List<int> openedSectionIds = new List<int>();

		// Token: 0x0400956A RID: 38250
		public List<NKMOfficeRoom> rooms = new List<NKMOfficeRoom>();

		// Token: 0x0400956B RID: 38251
		public List<NKMOfficeUnitData> units = new List<NKMOfficeUnitData>();
	}
}
