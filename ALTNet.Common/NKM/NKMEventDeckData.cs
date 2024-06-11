using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003E7 RID: 999
	public class NKMEventDeckData : ISerializable
	{
		// Token: 0x06001A4F RID: 6735 RVA: 0x00072D88 File Offset: 0x00070F88
		public long GetUnitUID(int index)
		{
			long result;
			if (this.m_dicUnit.TryGetValue(index, out result))
			{
				return result;
			}
			return 0L;
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00072DA9 File Offset: 0x00070FA9
		public NKMEventDeckData()
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00072DBC File Offset: 0x00070FBC
		public void DeepCopy(NKMEventDeckData src)
		{
			this.m_ShipUID = src.m_ShipUID;
			this.m_OperatorUID = src.m_OperatorUID;
			this.m_LeaderIndex = src.m_LeaderIndex;
			this.m_dicUnit.Clear();
			foreach (KeyValuePair<int, long> keyValuePair in src.m_dicUnit)
			{
				this.m_dicUnit.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00072E50 File Offset: 0x00071050
		public long CompareTo(NKMEventDeckData other)
		{
			long num = 0L;
			num = (long)this.m_ShipUID.CompareTo(other.m_ShipUID);
			num = (long)this.m_OperatorUID.CompareTo(other.m_OperatorUID);
			num = (long)this.m_LeaderIndex.CompareTo(other.m_LeaderIndex);
			if (num != 0L)
			{
				return -1L;
			}
			foreach (int key in other.m_dicUnit.Keys)
			{
				if (!this.m_dicUnit.ContainsKey(key))
				{
					num = 1L;
					break;
				}
				if (this.m_dicUnit[key] != other.m_dicUnit[key])
				{
					num = 1L;
					break;
				}
			}
			return num;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00072F18 File Offset: 0x00071118
		public NKMEventDeckData(Dictionary<int, long> dicUnit, long shipUID, long operatorUID, int leaderIndex)
		{
			this.m_dicUnit = dicUnit;
			this.m_ShipUID = shipUID;
			this.m_OperatorUID = operatorUID;
			this.m_LeaderIndex = leaderIndex;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00072F48 File Offset: 0x00071148
		public IEnumerable<NKMUnitData> GetUnits(NKMArmyData armyData)
		{
			foreach (long num in this.m_dicUnit.Values)
			{
				if (num != 0L)
				{
					//yield return armyData.GetUnitFromUID(num);
				}
			}
			Dictionary<int, long>.ValueCollection.Enumerator enumerator = default(Dictionary<int, long>.ValueCollection.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00072F60 File Offset: 0x00071160
		public long GetFirstUnitUID()
		{
			using (Dictionary<int, long>.Enumerator enumerator = this.m_dicUnit.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, long> keyValuePair = enumerator.Current;
					return keyValuePair.Value;
				}
			}
			return 0L;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00072FBC File Offset: 0x000711BC
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_ShipUID);
			stream.PutOrGet(ref this.m_dicUnit);
			stream.PutOrGet(ref this.m_OperatorUID);
			stream.PutOrGet(ref this.m_LeaderIndex);
		}

		// Token: 0x04001364 RID: 4964
		public Dictionary<int, long> m_dicUnit = new Dictionary<int, long>();

		// Token: 0x04001365 RID: 4965
		public long m_ShipUID;

		// Token: 0x04001366 RID: 4966
		public long m_OperatorUID;

		// Token: 0x04001367 RID: 4967
		public int m_LeaderIndex;

		// Token: 0x04001368 RID: 4968
		public int m_OperationPower;
	}
}
