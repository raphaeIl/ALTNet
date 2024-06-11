using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ClientPacket.Contract;
using ClientPacket.Event;
using ClientPacket.Office;
using Cs.Protocol;

namespace NKM.Templet
{
	// Token: 0x02000606 RID: 1542
	[DataContract]
	public sealed class NKMRewardData : Cs.Protocol.ISerializable
	{
		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000E7EBB File Offset: 0x000E60BB
		public List<NKMRewardUnitExpData> UnitExpDataList
		{
			get
			{
				return this.unitExpDataList;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x000E7EC3 File Offset: 0x000E60C3
		[DataMember]
		public List<NKMUnitData> UnitDataList
		{
			get
			{
				return this.unitDataList;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000E7ECB File Offset: 0x000E60CB
		[DataMember]
		public List<NKMOperator> OperatorList
		{
			get
			{
				return this.operatorList;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x000E7ED3 File Offset: 0x000E60D3
		[DataMember]
		public List<NKMItemMiscData> MiscItemDataList
		{
			get
			{
				return this.miscItemDataList;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000E7EDB File Offset: 0x000E60DB
		[DataMember]
		public List<NKMEquipItemData> EquipItemDataList
		{
			get
			{
				return this.equipItemDataList;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x000E7EE3 File Offset: 0x000E60E3
		[DataMember]
		public HashSet<int> SkinIdList
		{
			get
			{
				return this.skinIdList;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000E7EEB File Offset: 0x000E60EB
		[DataMember]
		public List<NKMMoldItemData> MoldItemDataList
		{
			get
			{
				return this.moldItemDataList;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x000E7EF3 File Offset: 0x000E60F3
		[DataMember]
		public List<NKMCompanyBuffData> CompanyBuffDataList
		{
			get
			{
				return this.companyBuffDataList;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000E7EFB File Offset: 0x000E60FB
		[DataMember]
		public HashSet<int> EmoticonList
		{
			get
			{
				return this.emoticonList;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x000E7F03 File Offset: 0x000E6103
		[DataMember]
		public List<NKMBingoTile> BingoTileList
		{
			get
			{
				return this.bingoTileList;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000E7F0B File Offset: 0x000E610B
		[DataMember]
		public List<NKMInteriorData> Interiors
		{
			get
			{
				return this.interiors;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x000E7F13 File Offset: 0x000E6113
		public List<MiscContractResult> ContractList
		{
			get
			{
				return this.contractList;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000E7F1B File Offset: 0x000E611B
		public int UserExp
		{
			get
			{
				return this.userExp;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x000E7F23 File Offset: 0x000E6123
		public int BonusRatioOfUserExp
		{
			get
			{
				return this.bonusRatioOfUserExp;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x000E7F2B File Offset: 0x000E612B
		public int DailyMissionPoint
		{
			get
			{
				return this.dailyMissionPoint;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x000E7F33 File Offset: 0x000E6133
		public int WeeklyMissionPoint
		{
			get
			{
				return this.weeklyMissionPoint;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000E7F3B File Offset: 0x000E613B
		public long AchievePoint
		{
			get
			{
				return this.achievePoint;
			}
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000E7F44 File Offset: 0x000E6144
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.userExp);
			stream.PutOrGet(ref this.bonusRatioOfUserExp);
			stream.PutOrGet<NKMUnitData>(ref this.unitDataList);
			stream.PutOrGet<NKMItemMiscData>(ref this.miscItemDataList);
			stream.PutOrGet<NKMEquipItemData>(ref this.equipItemDataList);
			stream.PutOrGet<NKMRewardUnitExpData>(ref this.unitExpDataList);
			stream.PutOrGet(ref this.skinIdList);
			stream.PutOrGet<NKMMoldItemData>(ref this.moldItemDataList);
			stream.PutOrGet<NKMCompanyBuffData>(ref this.companyBuffDataList);
			stream.PutOrGet<NKMCompanyBuffData>(ref this.companyBuffDataList);
			stream.PutOrGet(ref this.emoticonList);
			stream.PutOrGet(ref this.dailyMissionPoint);
			stream.PutOrGet(ref this.weeklyMissionPoint);
			stream.PutOrGet<NKMBingoTile>(ref this.bingoTileList);
			stream.PutOrGet(ref this.achievePoint);
			stream.PutOrGet<NKMOperator>(ref this.operatorList);
			stream.PutOrGet<MiscContractResult>(ref this.contractList);
			stream.PutOrGet<NKMInteriorData>(ref this.interiors);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000E8029 File Offset: 0x000E6229
		public void SetMiscItemData(List<NKMItemMiscData> miscItemDataList)
		{
			this.miscItemDataList = miscItemDataList;
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000E8032 File Offset: 0x000E6232
		public void SetUnitData(List<NKMUnitData> unitDataList)
		{
			this.unitDataList = unitDataList;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000E803B File Offset: 0x000E623B
		public void SetUserExp(int userExp)
		{
			this.userExp = userExp;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000E8044 File Offset: 0x000E6244
		public void SetBonusRatioOfUserExp(int bonusRatio)
		{
			this.bonusRatioOfUserExp = bonusRatio;
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000E804D File Offset: 0x000E624D
		public void SetDailyMissionPoint(int missionPoint)
		{
			this.dailyMissionPoint = missionPoint;
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000E8056 File Offset: 0x000E6256
		public void SetWeeklyMissionPoint(int missionPoint)
		{
			this.weeklyMissionPoint = missionPoint;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000E805F File Offset: 0x000E625F
		public void AddAchievePoint(long achievePointCount)
		{
			this.achievePoint += achievePointCount;
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000E806F File Offset: 0x000E626F
		public void SetOperatorList(List<NKMOperator> lstOper)
		{
			this.operatorList = lstOper;
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000E8078 File Offset: 0x000E6278
		public void Upsert(NKMItemMiscData newData)
		{
			NKMItemMiscData nkmitemMiscData = this.miscItemDataList.Find((NKMItemMiscData e) => e.ItemID == newData.ItemID);
			if (nkmitemMiscData == null)
			{
				return;
			}
			nkmitemMiscData.CountFree += newData.CountFree;
			nkmitemMiscData.CountPaid += newData.CountPaid;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000E80F4 File Offset: 0x000E62F4
		public void Upsert(in NKMInteriorData newData)
		{
			int itemId = newData.itemId;
			NKMInteriorData nkminteriorData = this.interiors.Find((NKMInteriorData e) => e.itemId == itemId);
			if (nkminteriorData == null)
			{
				return;
			}
			nkminteriorData.count += newData.count;
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000E8158 File Offset: 0x000E6358
		public void Upsert(NKMMoldItemData newData)
		{
			NKMMoldItemData nkmmoldItemData = this.moldItemDataList.Find((NKMMoldItemData e) => e.m_MoldID == newData.m_MoldID);
			if (nkmmoldItemData == null)
			{
				return;
			}
			nkmmoldItemData.m_Count += newData.m_Count;
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000E81BC File Offset: 0x000E63BC
		public void AddUnitExp(long unitUID, int unitExp, int unitBonusExp, int unitBonusRatio)
		{
			NKMRewardUnitExpData nkmrewardUnitExpData = this.unitExpDataList.Find((NKMRewardUnitExpData e) => e.m_UnitUid == unitUID);
			if (nkmrewardUnitExpData == null)
			{
				nkmrewardUnitExpData = new NKMRewardUnitExpData
				{
					m_UnitUid = unitUID,
					m_Exp = 0,
					m_BonusExp = 0
				};
				this.unitExpDataList.Add(nkmrewardUnitExpData);
			}
			nkmrewardUnitExpData.m_Exp += unitExp;
			nkmrewardUnitExpData.m_BonusExp += unitBonusExp;
			nkmrewardUnitExpData.m_BonusRatio = unitBonusRatio;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000E8241 File Offset: 0x000E6441
		public int GetUnitCount()
		{
			return this.unitDataList.Count + this.operatorList.Count;
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000E825C File Offset: 0x000E645C
		public void AddRewardDataForRepeatOperation(NKMRewardData newNKMRewardData)
		{
			if (newNKMRewardData == null)
			{
				return;
			}
			this.SetUserExp(this.UserExp + newNKMRewardData.UserExp);
			this.unitDataList.AddRange(newNKMRewardData.unitDataList);
			this.EquipItemDataList.AddRange(newNKMRewardData.equipItemDataList);
			this.OperatorList.AddRange(newNKMRewardData.operatorList);
			this.emoticonList.UnionWith(newNKMRewardData.emoticonList);
			foreach (int item in newNKMRewardData.skinIdList)
			{
				this.skinIdList.Add(item);
			}
			for (int i = 0; i < newNKMRewardData.miscItemDataList.Count; i++)
			{
				this.Upsert(newNKMRewardData.miscItemDataList[i]);
			}
			for (int j = 0; j < newNKMRewardData.moldItemDataList.Count; j++)
			{
				this.Upsert(newNKMRewardData.moldItemDataList[j]);
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000E8360 File Offset: 0x000E6560
		public bool HasAnyReward()
		{
			return this.unitDataList.Count > 0 || this.operatorList.Count > 0 || this.miscItemDataList.Count > 0 || this.equipItemDataList.Count > 0 || this.skinIdList.Count > 0 || this.moldItemDataList.Count > 0 || this.companyBuffDataList.Count > 0 || this.unitExpDataList.Count > 0 || this.bingoTileList.Count > 0 || this.emoticonList.Count > 0 || this.interiors.Count > 0 || this.dailyMissionPoint > 0 || this.weeklyMissionPoint > 0 || this.userExp > 0 || this.bonusRatioOfUserExp > 0 || this.achievePoint > 0L || this.contractList.Count > 0;
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000E8468 File Offset: 0x000E6668
		public static NKMRewardData operator +(NKMRewardData a, NKMRewardData b)
		{
			NKMRewardData nkmrewardData = new NKMRewardData();
			nkmrewardData.unitDataList = a.unitDataList;
			nkmrewardData.unitDataList.AddRange(b.unitDataList);
			nkmrewardData.operatorList = a.operatorList;
			nkmrewardData.operatorList.AddRange(b.operatorList);
			nkmrewardData.miscItemDataList = a.miscItemDataList;
			nkmrewardData.miscItemDataList.AddRange(b.miscItemDataList);
			nkmrewardData.equipItemDataList = a.equipItemDataList;
			nkmrewardData.equipItemDataList.AddRange(b.equipItemDataList);
			nkmrewardData.skinIdList = a.skinIdList;
			foreach (int item in b.skinIdList)
			{
				nkmrewardData.skinIdList.Add(item);
			}
			nkmrewardData.moldItemDataList = a.moldItemDataList;
			nkmrewardData.moldItemDataList.AddRange(b.moldItemDataList);
			nkmrewardData.companyBuffDataList = a.companyBuffDataList;
			nkmrewardData.companyBuffDataList.AddRange(b.companyBuffDataList);
			nkmrewardData.unitExpDataList = a.unitExpDataList;
			nkmrewardData.unitExpDataList.AddRange(b.unitExpDataList);
			nkmrewardData.unitDataList = a.unitDataList;
			nkmrewardData.unitDataList.AddRange(b.unitDataList);
			nkmrewardData.bingoTileList = a.bingoTileList;
			nkmrewardData.bingoTileList.AddRange(b.bingoTileList);
			nkmrewardData.emoticonList = a.emoticonList;
			foreach (int item2 in b.emoticonList)
			{
				nkmrewardData.emoticonList.Add(item2);
			}
			nkmrewardData.interiors = a.interiors;
			nkmrewardData.interiors.AddRange(b.interiors);
			nkmrewardData.dailyMissionPoint = a.dailyMissionPoint + b.dailyMissionPoint;
			nkmrewardData.weeklyMissionPoint = a.weeklyMissionPoint + b.weeklyMissionPoint;
			nkmrewardData.userExp = a.userExp + b.userExp;
			nkmrewardData.bonusRatioOfUserExp = a.bonusRatioOfUserExp + b.bonusRatioOfUserExp;
			nkmrewardData.achievePoint = a.achievePoint + b.achievePoint;
			nkmrewardData.contractList = a.contractList;
			nkmrewardData.contractList.AddRange(b.contractList);
			return nkmrewardData;
		}

		// Token: 0x04002EE6 RID: 12006
		private List<NKMUnitData> unitDataList = new List<NKMUnitData>();

		// Token: 0x04002EE7 RID: 12007
		private List<NKMOperator> operatorList = new List<NKMOperator>();

		// Token: 0x04002EE8 RID: 12008
		private List<NKMItemMiscData> miscItemDataList = new List<NKMItemMiscData>();

		// Token: 0x04002EE9 RID: 12009
		private List<NKMEquipItemData> equipItemDataList = new List<NKMEquipItemData>();

		// Token: 0x04002EEA RID: 12010
		private HashSet<int> skinIdList = new HashSet<int>();

		// Token: 0x04002EEB RID: 12011
		private List<NKMMoldItemData> moldItemDataList = new List<NKMMoldItemData>();

		// Token: 0x04002EEC RID: 12012
		private List<NKMCompanyBuffData> companyBuffDataList = new List<NKMCompanyBuffData>();

		// Token: 0x04002EED RID: 12013
		private List<NKMRewardUnitExpData> unitExpDataList = new List<NKMRewardUnitExpData>();

		// Token: 0x04002EEE RID: 12014
		private List<NKMBingoTile> bingoTileList = new List<NKMBingoTile>();

		// Token: 0x04002EEF RID: 12015
		private HashSet<int> emoticonList = new HashSet<int>();

		// Token: 0x04002EF0 RID: 12016
		private List<NKMInteriorData> interiors = new List<NKMInteriorData>();

		// Token: 0x04002EF1 RID: 12017
		private int dailyMissionPoint;

		// Token: 0x04002EF2 RID: 12018
		private int weeklyMissionPoint;

		// Token: 0x04002EF3 RID: 12019
		private int userExp;

		// Token: 0x04002EF4 RID: 12020
		private int bonusRatioOfUserExp;

		// Token: 0x04002EF5 RID: 12021
		private long achievePoint;

		// Token: 0x04002EF6 RID: 12022
		public List<MiscContractResult> contractList = new List<MiscContractResult>();
	}
}
