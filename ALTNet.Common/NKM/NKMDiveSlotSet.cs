using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200037B RID: 891
	public sealed class NKMDiveSlotSet : ISerializable
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x0005A011 File Offset: 0x00058211
		public List<NKMDiveSlot> Slots
		{
			get
			{
				return this.slots;
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0005A02C File Offset: 0x0005822C
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMDiveSlot>(ref this.slots);
		}

		// Token: 0x04000EF8 RID: 3832
		private List<NKMDiveSlot> slots = new List<NKMDiveSlot>();
	}
}
