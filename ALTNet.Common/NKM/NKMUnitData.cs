using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using ClientPacket.Common;
using Cs.Protocol;
using NKM.Templet;
using NKM.Templet.Office;

namespace NKM
{
	// Token: 0x020004A6 RID: 1190
	[DataContract]
	public sealed class NKMUnitData : Cs.Protocol.ISerializable
	{
        public void Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref this.m_UnitUID);
            stream.PutOrGet(ref this.m_UserUID);
            stream.PutOrGet(ref this.m_UnitID);
            stream.PutOrGet(ref this.m_UnitLevel);
            stream.PutOrGet(ref this.m_iUnitLevelEXP);
            stream.PutOrGet(ref this.m_SkinID);
            stream.PutOrGet(ref this.m_fInjury);
            stream.PutOrGet(ref this.m_LimitBreakLevel);
            stream.PutOrGet(ref this.m_bLock);
            stream.PutOrGet(ref this.m_listStatEXP);
            stream.PutOrGet(ref this.m_listGameUnitUID);
            stream.PutOrGet(ref this.m_listGameUnitUIDChange);
            stream.PutOrGet(ref this.m_listNearTargetRange);
            stream.PutOrGet(ref this.m_aUnitSkillLevel);
            stream.PutOrGet(ref this.m_EquipItemList);
            stream.PutOrGet(ref this.loyalty);
            stream.PutOrGet(ref this.isPermanentContract);
            stream.PutOrGet(ref this.isSeized);
            stream.PutOrGet(ref this.fromContract);
            stream.PutOrGet(ref this.officeRoomId);
            stream.PutOrGet(ref this.m_regDate);
            stream.PutOrGetEnum<OfficeGrade>(ref this.officeGrade);
            stream.PutOrGet(ref this.officeGaugeStartTime);
            stream.PutOrGet(ref this.m_DungeonRespawnUnitTempletUID);
            stream.PutOrGet(ref this.isFavorite);
            stream.PutOrGet<NKMShipCmdModule>(ref this.ShipCommandModule);
            stream.PutOrGet(ref this.tacticLevel);
            stream.PutOrGet(ref this.reactorLevel);
        }


        // Token: 0x040022CC RID: 8908
        private bool isPermanentContract;

		// Token: 0x040022CD RID: 8909
		private bool isSeized;

		// Token: 0x040022CE RID: 8910
		private bool fromContract;

		// Token: 0x040022CF RID: 8911
		private int officeRoomId;

		// Token: 0x040022D0 RID: 8912
		private OfficeGrade officeGrade;

		// Token: 0x040022D1 RID: 8913
		private DateTime officeGaugeStartTime;

		// Token: 0x040022D2 RID: 8914
		public long m_UnitUID;

		// Token: 0x040022D3 RID: 8915
		public long m_UserUID;

		// Token: 0x040022D4 RID: 8916
		[DataMember]
		public int m_UnitID;

		// Token: 0x040022D5 RID: 8917
		public int m_UnitLevel;

		// Token: 0x040022D6 RID: 8918
		public int m_iUnitLevelEXP;

		// Token: 0x040022D7 RID: 8919
		public int m_SkinID;

		// Token: 0x040022D8 RID: 8920
		public float m_fInjury;

		// Token: 0x040022D9 RID: 8921
		public int[] m_aUnitSkillLevel = new int[5];

		// Token: 0x040022DA RID: 8922
		public short m_LimitBreakLevel;

		// Token: 0x040022DB RID: 8923
		public bool m_bLock;

		// Token: 0x040022DC RID: 8924
		public List<int> m_listStatEXP = new List<int>();

		// Token: 0x040022DD RID: 8925
		public List<short> m_listGameUnitUID = new List<short>();

		// Token: 0x040022DE RID: 8926
		public List<short> m_listGameUnitUIDChange = new List<short>();

		// Token: 0x040022DF RID: 8927
		public List<float> m_listNearTargetRange = new List<float>();

		// Token: 0x040022E0 RID: 8928
		public long m_DungeonRespawnUnitTempletUID;

		// Token: 0x040022E1 RID: 8929
		public NKMDungeonRespawnUnitTemplet m_DungeonRespawnUnitTemplet;

		// Token: 0x040022E2 RID: 8930
		public float m_fLastRespawnTime = -1f;

		// Token: 0x040022E3 RID: 8931
		public float m_fLastDieTime = -1f;

		// Token: 0x040022E4 RID: 8932
		public bool m_bSummonUnit;

		// Token: 0x040022E5 RID: 8933
		public DateTime m_regDate = DateTime.MinValue;

		// Token: 0x040022E6 RID: 8934
		public int loyalty;

		// Token: 0x040022E7 RID: 8935
		public bool isFavorite;

		// Token: 0x040022E8 RID: 8936
		public int unitPower;

		// Token: 0x040022E9 RID: 8937
		public int tacticLevel;

		// Token: 0x040022EA RID: 8938
		public int reactorLevel;

		// Token: 0x040022EB RID: 8939
		private long[] m_EquipItemList = new long[4];

		// Token: 0x040022EC RID: 8940
		public List<NKMShipCmdModule> ShipCommandModule = new List<NKMShipCmdModule>();

		// Token: 0x040022ED RID: 8941
		public const int ACC_2_UNLOCK_LEVEL = 3;
	}
}
