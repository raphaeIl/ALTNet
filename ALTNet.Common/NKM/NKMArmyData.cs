using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using ClientPacket.Common;
using Cs.Core.Util;
using Cs.Protocol;
using NKC;
using NKM.Templet;

namespace NKM
{
	[DataContract]
	public class NKMArmyData : Cs.Protocol.ISerializable
	{
		public NKMArmyData()
		{

		}
	
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_MaxUnitCount);
			stream.PutOrGet(ref this.m_MaxShipCount);
			stream.PutOrGet(ref this.m_MaxOperatorCount);
			stream.PutOrGet(ref this.m_MaxTrophyCount);
			stream.PutOrGet<NKMDeckSet>(ref this.deckSets);
			stream.PutOrGet<NKMUnitData>(ref this.m_dicMyShip);
			stream.PutOrGet<NKMUnitData>(ref this.m_dicMyUnit);
			stream.PutOrGet<NKMOperator>(ref this.m_dicMyOperator);
			stream.PutOrGet<NKMUnitData>(ref this.m_dicMyTrophy);
			stream.PutOrGet(ref this.m_illustrateUnit);
			stream.PutOrGet<NKMTeamCollectionData>(ref this.m_dicTeamCollectionData);
		}

		[DataMember]
		private NKMDeckSet[] deckSets = new NKMDeckSet[EnumUtil<NKM_DECK_TYPE>.Count];

		[DataMember]
		private Dictionary<int, NKMTeamCollectionData> m_dicTeamCollectionData = new Dictionary<int, NKMTeamCollectionData>();

		// Token: 0x04001019 RID: 4121
		private NKMUserData owner;

		// Token: 0x0400101A RID: 4122
		public int m_MaxUnitCount = 200;

		// Token: 0x0400101B RID: 4123
		public int m_MaxShipCount = 10;

		// Token: 0x0400101C RID: 4124
		public int m_MaxOperatorCount = 10;

		// Token: 0x0400101D RID: 4125
		public int m_MaxTrophyCount = 2000;

		// Token: 0x0400101E RID: 4126
		[DataMember]
		public Dictionary<long, NKMUnitData> m_dicMyShip = new Dictionary<long, NKMUnitData>();

		// Token: 0x0400101F RID: 4127
		[DataMember]
		public Dictionary<long, NKMUnitData> m_dicMyUnit = new Dictionary<long, NKMUnitData>();

		// Token: 0x04001020 RID: 4128
		[DataMember]
		public Dictionary<long, NKMOperator> m_dicMyOperator = new Dictionary<long, NKMOperator>();

		// Token: 0x04001021 RID: 4129
		[DataMember]
		public Dictionary<long, NKMUnitData> m_dicMyTrophy = new Dictionary<long, NKMUnitData>();

		// Token: 0x04001022 RID: 4130
		[DataMember]
		public HashSet<int> m_illustrateUnit = new HashSet<int>();

		// Token: 0x04001023 RID: 4131
		public NKMArmyData.OnUnitUpdate dOnUnitUpdate;

		// Token: 0x04001024 RID: 4132
		public NKMArmyData.OnDeckUpdate dOnDeckUpdate;

		// Token: 0x04001025 RID: 4133
		public NKMArmyData.OnOperatorUpdate dOnOperatorUpdate;

		// Token: 0x04001026 RID: 4134
		private List<long> listUnitDelete = new List<long>();

		// Token: 0x04001027 RID: 4135
		private List<NKMItemMiscData> listUnitDeleteReward = new List<NKMItemMiscData>();

		// Token: 0x04001028 RID: 4136
		private const int UNIT_DELETE_COUNT = 100;

		// Token: 0x020012FF RID: 4863
		public enum UNIT_SEARCH_OPTION
		{
			// Token: 0x0400A0B0 RID: 41136
			None,
			// Token: 0x0400A0B1 RID: 41137
			Level,
			// Token: 0x0400A0B2 RID: 41138
			LimitLevel,
			// Token: 0x0400A0B3 RID: 41139
			Devotion,
			// Token: 0x0400A0B4 RID: 41140
			StarGrade
		}

		// Token: 0x02001300 RID: 4864
		// (Invoke) Token: 0x0600AE44 RID: 44612
		public delegate void OnUnitUpdate(NKMUserData.eChangeNotifyType eEventType, NKM_UNIT_TYPE eUnitType, long uid, NKMUnitData unitData);

		// Token: 0x02001301 RID: 4865
		// (Invoke) Token: 0x0600AE48 RID: 44616
		public delegate void OnDeckUpdate(NKMDeckIndex deckIndex, NKMDeckData deckData);

		// Token: 0x02001302 RID: 4866
		// (Invoke) Token: 0x0600AE4C RID: 44620
		public delegate void OnOperatorUpdate(NKMUserData.eChangeNotifyType eEventType, long uid, NKMOperator operatorData);

		// Token: 0x02001303 RID: 4867
		private class DeckIndexWithAvgOperationPower : IComparable<NKMArmyData.DeckIndexWithAvgOperationPower>
		{
			// Token: 0x0600AE4F RID: 44623 RVA: 0x003903DB File Offset: 0x0038E5DB
			public int CompareTo(NKMArmyData.DeckIndexWithAvgOperationPower other)
			{
				if (this.m_AvgOperationPower > other.m_AvgOperationPower)
				{
					return -1;
				}
				if (other.m_AvgOperationPower > this.m_AvgOperationPower)
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x0400A0B5 RID: 41141
			public byte m_Index;

			// Token: 0x0400A0B6 RID: 41142
			public int m_AvgOperationPower;
		}
	}
}
