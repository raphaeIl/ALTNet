using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Pvp
{
	// Token: 0x02000E4F RID: 3663
	public sealed class DraftPvpRoomData : ISerializable
	{
		// Token: 0x0600A2F8 RID: 41720 RVA: 0x0037BAD8 File Offset: 0x00379CD8
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_GAME_TYPE>(ref this.gameType);
			stream.PutOrGetEnum<DRAFT_PVP_ROOM_STATE>(ref this.roomState);
			stream.PutOrGet(ref this.stateEndTime);
			stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.currentStateTeamType);
			stream.PutOrGet<NKMAsyncUnitData>(ref this.selectedUnit);
			stream.PutOrGet<DraftPvpRoomData.DraftTeamData>(ref this.draftTeamDataA);
			stream.PutOrGet<DraftPvpRoomData.DraftTeamData>(ref this.draftTeamDataB);
		}

		// Token: 0x04009437 RID: 37943
		public NKM_GAME_TYPE gameType;

		// Token: 0x04009438 RID: 37944
		public DRAFT_PVP_ROOM_STATE roomState;

		// Token: 0x04009439 RID: 37945
		public DateTime stateEndTime;

		// Token: 0x0400943A RID: 37946
		public NKM_TEAM_TYPE currentStateTeamType;

		// Token: 0x0400943B RID: 37947
		public NKMAsyncUnitData selectedUnit = new NKMAsyncUnitData();

		// Token: 0x0400943C RID: 37948
		public DraftPvpRoomData.DraftTeamData draftTeamDataA = new DraftPvpRoomData.DraftTeamData();

		// Token: 0x0400943D RID: 37949
		public DraftPvpRoomData.DraftTeamData draftTeamDataB = new DraftPvpRoomData.DraftTeamData();

		// Token: 0x02001C64 RID: 7268
		public sealed class DraftTeamData : ISerializable
		{
			// Token: 0x0600CBB3 RID: 52147 RVA: 0x003C3D44 File Offset: 0x003C1F44
			void ISerializable.Serialize(IPacketStream stream)
			{
				stream.PutOrGetEnum<NKM_TEAM_TYPE>(ref this.teamType);
				stream.PutOrGet<NKMUserProfileData>(ref this.userProfileData);
				stream.PutOrGet(ref this.globalBanUnitIdList);
				stream.PutOrGet(ref this.globalBanShipIdList);
				stream.PutOrGet<NKMAsyncUnitData>(ref this.pickUnitList);
				stream.PutOrGet(ref this.banishedUnitIndex);
				stream.PutOrGet<NKMAsyncUnitData>(ref this.mainShip);
				stream.PutOrGet<NKMOperator>(ref this.operatorUnit);
				stream.PutOrGet(ref this.leaderIndex);
			}

			// Token: 0x0400BDA8 RID: 48552
			public NKM_TEAM_TYPE teamType;

			// Token: 0x0400BDA9 RID: 48553
			public NKMUserProfileData userProfileData = new NKMUserProfileData();

			// Token: 0x0400BDAA RID: 48554
			public List<int> globalBanUnitIdList = new List<int>();

			// Token: 0x0400BDAB RID: 48555
			public List<int> globalBanShipIdList = new List<int>();

			// Token: 0x0400BDAC RID: 48556
			public List<NKMAsyncUnitData> pickUnitList = new List<NKMAsyncUnitData>();

			// Token: 0x0400BDAD RID: 48557
			public int banishedUnitIndex;

			// Token: 0x0400BDAE RID: 48558
			public NKMAsyncUnitData mainShip = new NKMAsyncUnitData();

			// Token: 0x0400BDAF RID: 48559
			public NKMOperator operatorUnit;

			// Token: 0x0400BDB0 RID: 48560
			public int leaderIndex;
		}
	}
}
