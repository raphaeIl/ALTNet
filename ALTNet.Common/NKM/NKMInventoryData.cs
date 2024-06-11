using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using ClientPacket.Common;
using Cs.Protocol;
using NKC;

namespace NKM
{
	// Token: 0x0200050A RID: 1290
	[DataContract]
	public class NKMInventoryData : Cs.Protocol.ISerializable
	{
		// Token: 0x06002478 RID: 9336 RVA: 0x000BF6EB File Offset: 0x000BD8EB
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_MaxItemEqipCount);
			stream.PutOrGet<NKMItemMiscData>(ref this.m_ItemMiscData);
			stream.PutOrGet<NKMEquipItemData>(ref this.m_ItemEquipData);
			stream.PutOrGet(ref this.m_ItemSkinData);
			stream.PutOrGet<NKMMiscCollectionData>(ref this.m_dicMiscCollectionData);
		}

		// Token: 0x040026E6 RID: 9958
		public int m_MaxItemEqipCount = 100;

		// Token: 0x040026E7 RID: 9959
		[DataMember]
		private Dictionary<int, NKMItemMiscData> m_ItemMiscData = new Dictionary<int, NKMItemMiscData>();

		// Token: 0x040026E8 RID: 9960
		[DataMember]
		private Dictionary<long, NKMEquipItemData> m_ItemEquipData = new Dictionary<long, NKMEquipItemData>();

		// Token: 0x040026E9 RID: 9961
		[DataMember]
		private HashSet<int> m_ItemSkinData = new HashSet<int>();

		// Token: 0x040026EA RID: 9962
		[DataMember]
		private Dictionary<int, NKMMiscCollectionData> m_dicMiscCollectionData = new Dictionary<int, NKMMiscCollectionData>();

		// Token: 0x040026EE RID: 9966
		private Dictionary<int, long> m_dicItemUpdateCheck = new Dictionary<int, long>();

		// Token: 0x0200139F RID: 5023
		// (Invoke) Token: 0x0600B085 RID: 45189
		public delegate void OnMiscInventoryUpdate(NKMItemMiscData itemData);

		// Token: 0x020013A0 RID: 5024
		// (Invoke) Token: 0x0600B089 RID: 45193
		public delegate void OnEquipUpdate(NKMUserData.eChangeNotifyType eType, long equipUID, NKMEquipItemData equipData);

		// Token: 0x020013A1 RID: 5025
		// (Invoke) Token: 0x0600B08D RID: 45197
		public delegate void OnRefreshDailyContents();
	}
}
