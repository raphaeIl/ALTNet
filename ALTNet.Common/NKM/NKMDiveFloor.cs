using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x02000377 RID: 887
	public class NKMDiveFloor : ISerializable
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x000599CC File Offset: 0x00057BCC
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.stageID);
			stream.PutOrGet<NKMDiveSlotSet>(ref this.slotSets);
			stream.PutOrGet(ref this.expireDate);
			//if (stream is PacketReader)
			//{
			//	this.OnPacketRead();
			//}
		}

		// Token: 0x04000EE0 RID: 3808
		protected int stageID;

		// Token: 0x04000EE1 RID: 3809
		protected NKMDiveTemplet templet;

		// Token: 0x04000EE2 RID: 3810
		protected List<NKMDiveSlotSet> slotSets = new List<NKMDiveSlotSet>();

		// Token: 0x04000EE3 RID: 3811
		protected long expireDate;

		// Token: 0x04000EE4 RID: 3812
		public const int MAX_DISCOVERED_SLOT_SET_COUNT = 2;
	}
}
