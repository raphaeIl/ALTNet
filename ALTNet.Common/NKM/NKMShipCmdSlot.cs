using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x020004A8 RID: 1192
	public class NKMShipCmdSlot : ISerializable
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x000ACD03 File Offset: 0x000AAF03
		public NKMShipCmdSlot()
		{
			this.targetStyleType = new HashSet<NKM_UNIT_STYLE_TYPE>();
			this.targetRoleType = new HashSet<NKM_UNIT_ROLE_TYPE>();
			this.statType = NKM_STAT_TYPE.NST_RANDOM;
			this.statValue = 0f;
			this.isLock = false;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x000ACD3A File Offset: 0x000AAF3A
		public NKMShipCmdSlot(HashSet<NKM_UNIT_STYLE_TYPE> styleType, HashSet<NKM_UNIT_ROLE_TYPE> roleType, NKM_STAT_TYPE statType, float value, bool isLock)
		{
			this.targetStyleType = styleType;
			this.targetRoleType = roleType;
			this.statType = statType;
			this.statValue = value;
			this.isLock = isLock;
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000ACDE0 File Offset: 0x000AAFE0
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_UNIT_STYLE_TYPE>(ref this.targetStyleType);
			stream.PutOrGetEnum<NKM_UNIT_ROLE_TYPE>(ref this.targetRoleType);
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.statType);
			stream.PutOrGet(ref this.statValue);
			stream.PutOrGet(ref this.isLock);
		}

		// Token: 0x040022EF RID: 8943
		public HashSet<NKM_UNIT_STYLE_TYPE> targetStyleType;

		// Token: 0x040022F0 RID: 8944
		public HashSet<NKM_UNIT_ROLE_TYPE> targetRoleType;

		// Token: 0x040022F1 RID: 8945
		public NKM_STAT_TYPE statType;

		// Token: 0x040022F2 RID: 8946
		public float statValue;

		// Token: 0x040022F3 RID: 8947
		public bool isLock;
	}
}
