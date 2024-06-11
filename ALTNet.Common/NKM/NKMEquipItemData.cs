using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003FA RID: 1018
	public class NKMEquipItemData : ISerializable
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x00078355 File Offset: 0x00076555
		public NKMEquipItemData()
		{
			this.m_Stat.Add(new EQUIP_ITEM_STAT());
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0007849C File Offset: 0x0007669C
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_ItemUid);
			stream.PutOrGet(ref this.m_ItemEquipID);
			stream.PutOrGet(ref this.m_EnchantLevel);
			stream.PutOrGet(ref this.m_EnchantExp);
			stream.PutOrGet<EQUIP_ITEM_STAT>(ref this.m_Stat);
			stream.PutOrGet(ref this.m_OwnerUnitUID);
			stream.PutOrGet(ref this.m_bLock);
			stream.PutOrGet(ref this.m_Precision);
			stream.PutOrGet(ref this.m_Precision2);
			stream.PutOrGet(ref this.m_SetOptionId);
			stream.PutOrGet(ref this.m_ImprintUnitId);
			stream.PutOrGet<NKMPotentialOption>(ref this.potentialOption);
		}

		// Token: 0x04001420 RID: 5152
		public long m_ItemUid;

		// Token: 0x04001421 RID: 5153
		public int m_ItemEquipID;

		// Token: 0x04001422 RID: 5154
		public int m_EnchantLevel;

		// Token: 0x04001423 RID: 5155
		public int m_EnchantExp;

		// Token: 0x04001424 RID: 5156
		public List<EQUIP_ITEM_STAT> m_Stat = new List<EQUIP_ITEM_STAT>();

		// Token: 0x04001425 RID: 5157
		public long m_OwnerUnitUID = -1L;

		// Token: 0x04001426 RID: 5158
		public bool m_bLock;

		// Token: 0x04001427 RID: 5159
		public int m_Precision;

		// Token: 0x04001428 RID: 5160
		public int m_Precision2;

		// Token: 0x04001429 RID: 5161
		public int m_SetOptionId;

		// Token: 0x0400142A RID: 5162
		public int m_ImprintUnitId;

		// Token: 0x0400142B RID: 5163
		public NKMPotentialOption potentialOption;

		// Token: 0x0200134D RID: 4941
		public enum NKM_EQUIP_STAT_TYPE
		{
			// Token: 0x0400A1D1 RID: 41425
			NESI_DEFAULT,
			// Token: 0x0400A1D2 RID: 41426
			NESI_RANDOM,
			// Token: 0x0400A1D3 RID: 41427
			NESI_RANDOM2,
			// Token: 0x0400A1D4 RID: 41428
			NESI_MAX
		}
	}
}
