using System;
using System.Collections.Generic;
using ClientPacket.Common;
using ClientPacket.Contract;
using ClientPacket.Event;
using ClientPacket.Mode;
using ClientPacket.Office;
using ClientPacket.Pvp;
using ClientPacket.Shop;
using ClientPacket.Unit;
using ClientPacket.User;
using ClientPacket.Warfare;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Account
{
	[PacketId(ClientPacketId.kNKMPacket_JOIN_LOBBY_ACK)]
	public sealed class NKMPacket_JOIN_LOBBY_ACK : ISerializable
	{
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.friendCode);
			stream.PutOrGet<NKMUserData>(ref this.userData);
			stream.PutOrGet<NKMGameData>(ref this.gameData);
			stream.PutOrGet<WarfareGameData>(ref this.warfareGameData);
			stream.PutOrGet(ref this.utcTime);
			stream.PutOrGet(ref this.utcOffset);
			stream.PutOrGet(ref this.lastCreditSupplyTakeTime);
			stream.PutOrGet(ref this.lastEterniumSupplyTakeTime);
			stream.PutOrGet(ref this.totalPaidAmount);
			stream.PutOrGet<ShopChainTabNextResetData>(ref this.shopChainTabNestResetList);
			stream.PutOrGet<NKMPvpBanResult>(ref this.pvpBanResult);
			stream.PutOrGet<PvpState>(ref this.asyncPvpState);
			stream.PutOrGet<PvpState>(ref this.leaguePvpState);
			stream.PutOrGet(ref this.pvpPointChargeTime);
			stream.PutOrGet(ref this.rankPvpOpen);
			stream.PutOrGet(ref this.leaguePvpOpen);
			stream.PutOrGet<NKMReturningUserState>(ref this.ReturningUserStates);
			stream.PutOrGet<NKMContractState>(ref this.contractState);
			stream.PutOrGet<NKMContractBonusState>(ref this.contractBonusState);
			stream.PutOrGet<NKMSelectableContractState>(ref this.selectableContractState);
			stream.PutOrGet<NKMStagePlayData>(ref this.stagePlayDataList);
			stream.PutOrGet<EventInfo>(ref this.eventInfo);
			stream.PutOrGet(ref this.reconnectKey);
			stream.PutOrGet<ZlongUserData>(ref this.zlongUserData);
			stream.PutOrGet<NKMBackgroundInfo>(ref this.backGroundInfo);
			stream.PutOrGet<PrivateGuildData>(ref this.privateGuildData);
			stream.PutOrGet(ref this.blockMuteEndDate);
			stream.PutOrGet(ref this.marketReviewCompletion);
			stream.PutOrGet(ref this.fierceDailyRewardReceived);
			stream.PutOrGet<GuildDungeonRewardInfo>(ref this.guildDungeonRewardInfo);
			stream.PutOrGet<NKMEquipTuningCandidate>(ref this.equipTuningCandidate);
			stream.PutOrGet<NKMPvpGameLobbyState>(ref this.pvpGameLobby);
			stream.PutOrGet<DraftPvpRoomData>(ref this.leaguePvpRoomData);
			stream.PutOrGet<PvpSingleHistory>(ref this.leaguePvpHistories);
			stream.PutOrGet<PvpSingleHistory>(ref this.privatePvpHistories);
			stream.PutOrGet<NKMMyOfficeState>(ref this.officeState);
			stream.PutOrGet<KakaoMissionData>(ref this.kakaoMissionData);
			stream.PutOrGet(ref this.unlockedStageIds);
			stream.PutOrGet<NKMPhaseClearData>(ref this.phaseClearDataList);
			stream.PutOrGet<PhaseModeState>(ref this.phaseModeState);
			stream.PutOrGet<NKMServerKillCountData>(ref this.serverKillCountDataList);
			stream.PutOrGet<NKMKillCountData>(ref this.killCountDataList);
			stream.PutOrGet<NKMUnitMissionData>(ref this.completedUnitMissions);
			stream.PutOrGet<NKMUnitMissionData>(ref this.rewardEnableUnitMissions);
			stream.PutOrGet<PvpCastingVoteData>(ref this.pvpCastingVoteData);
			stream.PutOrGet<NKMIntervalData>(ref this.intervalData);
			stream.PutOrGet<NKMConsumerPackageData>(ref this.consumerPackages);
			stream.PutOrGet<NpcPvpData>(ref this.npcPvpData);
			stream.PutOrGet<NKMTrimIntervalData>(ref this.trimIntervalData);
			stream.PutOrGet<NKMTrimClearData>(ref this.trimClearList);
			stream.PutOrGet<NKMShipModuleCandidate>(ref this.shipSlotCandidate);
			stream.PutOrGet<TrimModeState>(ref this.trimModeState);
			stream.PutOrGet(ref this.enableAccountLink);
			stream.PutOrGet<NKMEventCollectionInfo>(ref this.eventCollectionInfo);
			stream.PutOrGet<NKMUserProfileData>(ref this.userProfileData);
			stream.PutOrGet<NKMShortCutInfo>(ref this.lastPlayInfo);
			stream.PutOrGet<PvpState>(ref this.eventPvpState);
			stream.PutOrGet<NKMCustomPickupContract>(ref this.customPickupContracts);
			stream.PutOrGet<NKMPotentialOptionChangeCandidate>(ref this.potentialOptionCandidate);
			stream.PutOrGet<PvpCastingVoteData>(ref this.pvpDraftVoteData);
		}

		// Token: 0x04009D8E RID: 40334
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009D8F RID: 40335
		public long friendCode;

		// Token: 0x04009D90 RID: 40336
		public NKMUserData userData;

		// Token: 0x04009D91 RID: 40337
		public NKMGameData gameData;

		// Token: 0x04009D92 RID: 40338
		public WarfareGameData warfareGameData = new WarfareGameData();

		// Token: 0x04009D93 RID: 40339
		public DateTime utcTime;

		// Token: 0x04009D94 RID: 40340
		public TimeSpan utcOffset;

		// Token: 0x04009D95 RID: 40341
		public DateTime lastCreditSupplyTakeTime;

		// Token: 0x04009D96 RID: 40342
		public DateTime lastEterniumSupplyTakeTime;

		// Token: 0x04009D97 RID: 40343
		public double totalPaidAmount;

		// Token: 0x04009D98 RID: 40344
		public List<ShopChainTabNextResetData> shopChainTabNestResetList = new List<ShopChainTabNextResetData>();

		// Token: 0x04009D99 RID: 40345
		public NKMPvpBanResult pvpBanResult = new NKMPvpBanResult();

		// Token: 0x04009D9A RID: 40346
		public PvpState asyncPvpState;

		// Token: 0x04009D9B RID: 40347
		public PvpState leaguePvpState;

		// Token: 0x04009D9C RID: 40348
		public DateTime pvpPointChargeTime;

		// Token: 0x04009D9D RID: 40349
		public bool rankPvpOpen;

		// Token: 0x04009D9E RID: 40350
		public bool leaguePvpOpen;

		// Token: 0x04009D9F RID: 40351
		public List<NKMReturningUserState> ReturningUserStates = new List<NKMReturningUserState>();

		// Token: 0x04009DA0 RID: 40352
		public List<NKMContractState> contractState = new List<NKMContractState>();

		// Token: 0x04009DA1 RID: 40353
		public List<NKMContractBonusState> contractBonusState = new List<NKMContractBonusState>();

		// Token: 0x04009DA2 RID: 40354
		public NKMSelectableContractState selectableContractState = new NKMSelectableContractState();

		// Token: 0x04009DA3 RID: 40355
		public List<NKMStagePlayData> stagePlayDataList = new List<NKMStagePlayData>();

		// Token: 0x04009DA4 RID: 40356
		public EventInfo eventInfo = new EventInfo();

		// Token: 0x04009DA5 RID: 40357
		public string reconnectKey;

		// Token: 0x04009DA6 RID: 40358
		public ZlongUserData zlongUserData = new ZlongUserData();

		// Token: 0x04009DA7 RID: 40359
		public NKMBackgroundInfo backGroundInfo = new NKMBackgroundInfo();

		// Token: 0x04009DA8 RID: 40360
		public PrivateGuildData privateGuildData = new PrivateGuildData();

		// Token: 0x04009DA9 RID: 40361
		public DateTime blockMuteEndDate;

		// Token: 0x04009DAA RID: 40362
		public bool marketReviewCompletion;

		// Token: 0x04009DAB RID: 40363
		public bool fierceDailyRewardReceived;

		// Token: 0x04009DAC RID: 40364
		public GuildDungeonRewardInfo guildDungeonRewardInfo = new GuildDungeonRewardInfo();

		// Token: 0x04009DAD RID: 40365
		public NKMEquipTuningCandidate equipTuningCandidate = new NKMEquipTuningCandidate();

		// Token: 0x04009DAE RID: 40366
		public NKMPvpGameLobbyState pvpGameLobby = new NKMPvpGameLobbyState();

		// Token: 0x04009DAF RID: 40367
		public DraftPvpRoomData leaguePvpRoomData;

		// Token: 0x04009DB0 RID: 40368
		public List<PvpSingleHistory> leaguePvpHistories = new List<PvpSingleHistory>();

		// Token: 0x04009DB1 RID: 40369
		public List<PvpSingleHistory> privatePvpHistories = new List<PvpSingleHistory>();

		// Token: 0x04009DB2 RID: 40370
		public NKMMyOfficeState officeState;

		// Token: 0x04009DB3 RID: 40371
		public KakaoMissionData kakaoMissionData;

		// Token: 0x04009DB4 RID: 40372
		public List<int> unlockedStageIds = new List<int>();

		// Token: 0x04009DB5 RID: 40373
		public List<NKMPhaseClearData> phaseClearDataList = new List<NKMPhaseClearData>();

		// Token: 0x04009DB6 RID: 40374
		public PhaseModeState phaseModeState;

		// Token: 0x04009DB7 RID: 40375
		public List<NKMServerKillCountData> serverKillCountDataList = new List<NKMServerKillCountData>();

		// Token: 0x04009DB8 RID: 40376
		public List<NKMKillCountData> killCountDataList = new List<NKMKillCountData>();

		// Token: 0x04009DB9 RID: 40377
		public List<NKMUnitMissionData> completedUnitMissions = new List<NKMUnitMissionData>();

		// Token: 0x04009DBA RID: 40378
		public List<NKMUnitMissionData> rewardEnableUnitMissions = new List<NKMUnitMissionData>();

		// Token: 0x04009DBB RID: 40379
		public PvpCastingVoteData pvpCastingVoteData = new PvpCastingVoteData();

		// Token: 0x04009DBC RID: 40380
		public List<NKMIntervalData> intervalData = new List<NKMIntervalData>();

		// Token: 0x04009DBD RID: 40381
		public List<NKMConsumerPackageData> consumerPackages = new List<NKMConsumerPackageData>();

		// Token: 0x04009DBE RID: 40382
		public NpcPvpData npcPvpData;

		// Token: 0x04009DBF RID: 40383
		public NKMTrimIntervalData trimIntervalData = new NKMTrimIntervalData();

		// Token: 0x04009DC0 RID: 40384
		public List<NKMTrimClearData> trimClearList = new List<NKMTrimClearData>();

		// Token: 0x04009DC1 RID: 40385
		public NKMShipModuleCandidate shipSlotCandidate = new NKMShipModuleCandidate();

		// Token: 0x04009DC2 RID: 40386
		public TrimModeState trimModeState;

		// Token: 0x04009DC3 RID: 40387
		public bool enableAccountLink;

		// Token: 0x04009DC4 RID: 40388
		public NKMEventCollectionInfo eventCollectionInfo = new NKMEventCollectionInfo();

		// Token: 0x04009DC5 RID: 40389
		public NKMUserProfileData userProfileData = new NKMUserProfileData();

		// Token: 0x04009DC6 RID: 40390
		public NKMShortCutInfo lastPlayInfo = new NKMShortCutInfo();

		// Token: 0x04009DC7 RID: 40391
		public PvpState eventPvpState;

		// Token: 0x04009DC8 RID: 40392
		public List<NKMCustomPickupContract> customPickupContracts = new List<NKMCustomPickupContract>();

		// Token: 0x04009DC9 RID: 40393
		public NKMPotentialOptionChangeCandidate potentialOptionCandidate = new NKMPotentialOptionChangeCandidate();

		// Token: 0x04009DCA RID: 40394
		public PvpCastingVoteData pvpDraftVoteData = new PvpCastingVoteData();
	}
}
