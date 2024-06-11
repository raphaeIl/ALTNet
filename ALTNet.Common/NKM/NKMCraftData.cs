using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003CA RID: 970
	public class NKMCraftData : ISerializable
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00069832 File Offset: 0x00067A32
		public Dictionary<byte, NKMCraftSlotData> SlotList
		{
			get
			{
				return this.m_dicSlot;
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0006983A File Offset: 0x00067A3A
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMMoldItemData>(ref this.m_dicMoldItem);
			stream.PutOrGet<NKMCraftSlotData>(ref this.m_dicSlot);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00069872 File Offset: 0x00067A72
		public Dictionary<int, NKMMoldItemData> GetDicMoldItemData()
		{
			return this.m_dicMoldItem;
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0006987C File Offset: 0x00067A7C
		public NKMMoldItemData GetMoldItemDataByID(int id)
		{
			NKMMoldItemData result = null;
			if (!this.m_dicMoldItem.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000698A0 File Offset: 0x00067AA0
		public NKMMoldItemData GetMoldItemDataByIndex(int index)
		{
			if (index < 0 || index >= this.GetTotalMoldCount())
			{
				return null;
			}
			int num = 0;
			foreach (KeyValuePair<int, NKMMoldItemData> keyValuePair in this.m_dicMoldItem)
			{
				if (num == index)
				{
					return keyValuePair.Value;
				}
				num++;
			}
			return null;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00069914 File Offset: 0x00067B14
		public void AddMoldItem(List<NKMMoldItemData> moldItemDataList)
		{
			foreach (NKMMoldItemData nkmmoldItemData in moldItemDataList)
			{
				this.AddMoldItem(nkmmoldItemData.m_MoldID, nkmmoldItemData.m_Count);
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00069970 File Offset: 0x00067B70
		public void AddMoldItem(NKMMoldItemData moldItemData)
		{
			this.AddMoldItem(moldItemData.m_MoldID, moldItemData.m_Count);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00069984 File Offset: 0x00067B84
		public void AddMoldItem(int moldID, long count)
		{
			NKMMoldItemData nkmmoldItemData;
			if (this.m_dicMoldItem.TryGetValue(moldID, out nkmmoldItemData))
			{
				nkmmoldItemData.m_Count = this.m_dicMoldItem[moldID].m_Count + count;
				return;
			}
			this.m_dicMoldItem.Add(moldID, new NKMMoldItemData(moldID, count));
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000699CE File Offset: 0x00067BCE
		public void DecMoldItem(NKMMoldItemData moldItemData)
		{
			this.DecMoldItem(moldItemData.m_MoldID, moldItemData.m_Count);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000699E4 File Offset: 0x00067BE4
		public void DecMoldItem(int moldID, long count)
		{
			NKMMoldItemData nkmmoldItemData;
			if (this.m_dicMoldItem.TryGetValue(moldID, out nkmmoldItemData))
			{
				nkmmoldItemData.m_Count = Math.Max(0L, this.m_dicMoldItem[moldID].m_Count - count);
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00069A24 File Offset: 0x00067C24
		public void UpdateMoldItem(List<NKMMoldItemData> moldItemDataList)
		{
			foreach (NKMMoldItemData nkmmoldItemData in moldItemDataList)
			{
				this.UpdateMoldItem(nkmmoldItemData.m_MoldID, nkmmoldItemData.m_Count);
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00069A80 File Offset: 0x00067C80
		public void UpdateMoldItem(int moldID, long count)
		{
			NKMMoldItemData nkmmoldItemData;
			if (this.m_dicMoldItem.TryGetValue(moldID, out nkmmoldItemData))
			{
				nkmmoldItemData.m_Count = count;
				return;
			}
			this.m_dicMoldItem.Add(moldID, new NKMMoldItemData(moldID, count));
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00069AB8 File Offset: 0x00067CB8
		public long GetMoldCount(int moldID)
		{
			long result = 0L;
			if (this.m_dicMoldItem.ContainsKey(moldID))
			{
				result = this.m_dicMoldItem[moldID].m_Count;
			}
			return result;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00069AE9 File Offset: 0x00067CE9
		public int GetTotalMoldCount()
		{
			return this.m_dicMoldItem.Count;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00069AF8 File Offset: 0x00067CF8
		public void AddSlotData(NKMCraftSlotData slotData)
		{
			if (this.m_dicSlot.ContainsKey(slotData.Index))
			{
				return;
			}
			this.m_dicSlot.Add(slotData.Index, slotData);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00069B50 File Offset: 0x00067D50
		public void AddSlotData(byte index, int moldID, int count, long completeDate)
		{
			if (this.m_dicSlot.ContainsKey(index))
			{
				return;
			}
			NKMCraftSlotData nkmcraftSlotData = new NKMCraftSlotData();
			nkmcraftSlotData.Index = index;
			nkmcraftSlotData.MoldID = moldID;
			nkmcraftSlotData.Count = count;
			nkmcraftSlotData.CompleteDate = completeDate;
			this.m_dicSlot.Add(nkmcraftSlotData.Index, nkmcraftSlotData);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00069BC0 File Offset: 0x00067DC0
		public NKM_ERROR_CODE UpdateSlotData(NKMCraftSlotData slotData)
		{
			return this.UpdateSlotData(slotData.Index, slotData.MoldID, slotData.Count, slotData.CompleteDate);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00069BE0 File Offset: 0x00067DE0
		public NKM_ERROR_CODE UpdateSlotData(byte index, int moldID, int count, long completeDate)
		{
			if (index <= 0 || NKMCraftData.MAX_CRAFT_SLOT_DATA < (int)index)
			{
				return NKM_ERROR_CODE.NEC_FAIL_CRAFT_INVALID_SLOT_INDEX;
			}
			NKMCraftSlotData nkmcraftSlotData;
			if (!this.m_dicSlot.TryGetValue(index, out nkmcraftSlotData))
			{
				return NKM_ERROR_CODE.NEC_FAIL_CRAFT_INVALID_SLOT_INDEX;
			}
			nkmcraftSlotData.Index = index;
			nkmcraftSlotData.MoldID = moldID;
			nkmcraftSlotData.Count = count;
			nkmcraftSlotData.CompleteDate = completeDate;
			return NKM_ERROR_CODE.NEC_OK;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00069C34 File Offset: 0x00067E34
		public NKMCraftSlotData GetSlotData(byte index)
		{
			NKMCraftSlotData result = null;
			if (!this.m_dicSlot.TryGetValue(index, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00069C58 File Offset: 0x00067E58
		public int GetReservedMoldCount()
		{
			int num = 0;
			foreach (NKMCraftSlotData nkmcraftSlotData in this.m_dicSlot.Values)
			{
				if (nkmcraftSlotData.MoldID > 0)
				{
					num += nkmcraftSlotData.Count;
				}
			}
			return num;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00069CC0 File Offset: 0x00067EC0
		public int GetEmptyMoldSlotCount()
		{
			int num = 0;
			using (Dictionary<byte, NKMCraftSlotData>.ValueCollection.Enumerator enumerator = this.m_dicSlot.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoldID == 0)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00069D20 File Offset: 0x00067F20
		public int GetFirstEmptySlotIndex()
		{
			foreach (NKMCraftSlotData nkmcraftSlotData in this.m_dicSlot.Values)
			{
				if (nkmcraftSlotData.MoldID == 0)
				{
					return (int)nkmcraftSlotData.Index;
				}
			}
			return -1;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00069D88 File Offset: 0x00067F88
		public int GetUsedMoldSlotCount()
		{
			int num = 0;
			using (Dictionary<byte, NKMCraftSlotData>.ValueCollection.Enumerator enumerator = this.m_dicSlot.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoldID != 0)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00069DE8 File Offset: 0x00067FE8
		public void ClearMoldItem()
		{
			this.m_dicMoldItem.Clear();
		}

		// Token: 0x040011ED RID: 4589
		public static int MAX_CRAFT_SLOT_DATA = 5;

		// Token: 0x040011EE RID: 4590
		private Dictionary<int, NKMMoldItemData> m_dicMoldItem = new Dictionary<int, NKMMoldItemData>();

		// Token: 0x040011EF RID: 4591
		private Dictionary<byte, NKMCraftSlotData> m_dicSlot = new Dictionary<byte, NKMCraftSlotData>();
	}
}
