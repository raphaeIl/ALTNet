using NKM;

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
using NKM;
using Cs.Protocol;
using ALTNet.GameServer.Packets;
using ClientPacket.Account;
using Protocol;

namespace ALTNet.GameServer
{
    [PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_REQ)]
    public sealed class NKMPacket_CONTENTS_VERSION_REQ : ISerializable
    {
        void ISerializable.Serialize(IPacketStream stream)
        {
        }
    }

    [PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_ACK)]
    public sealed class NKMPacket_CONTENTS_VERSION_ACK : ISerializable
    {

        void ISerializable.Serialize(IPacketStream stream)
        {
            stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
            stream.PutOrGet(ref this.contentsVersion);
            stream.PutOrGet(ref this.contentsTag);
            stream.PutOrGet(ref this.utcTime);
            stream.PutOrGet(ref this.utcOffset);
        }

        public NKM_ERROR_CODE errorCode;

        public string contentsVersion;

        public List<string> contentsTag = new List<string>();

        public DateTime utcTime;

        public TimeSpan utcOffset;
    }

    [PacketId(ClientPacketId.kNKMPacket_STEAM_LOGIN_REQ)]
    public sealed class NKMPacket_STEAM_LOGIN_REQ : ISerializable
    {
        void ISerializable.Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref this.protocolVersion);
            stream.PutOrGet(ref this.deviceUid);
            stream.PutOrGet(ref this.accessToken);
            stream.PutOrGet(ref this.accountId);
            stream.PutOrGet<NKMUserMobileData>(ref this.userMobileData);
        }

        public int protocolVersion;

        public string deviceUid;

        public string accessToken;

        public string accountId;

        public NKMUserMobileData userMobileData;
    }

    [PacketId(ClientPacketId.kNKMPacket_LOGIN_ACK)]
    public sealed class NKMPacket_LOGIN_ACK : ISerializable
    {
        void ISerializable.Serialize(IPacketStream stream)
        {
            stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
            stream.PutOrGet(ref this.accessToken);
            stream.PutOrGet(ref this.gameServerIP);
            stream.PutOrGet(ref this.gameServerPort);
            stream.PutOrGet(ref this.contentsVersion);
            stream.PutOrGet(ref this.contentsTag);
            stream.PutOrGet(ref this.openTag);
        }

        public NKM_ERROR_CODE errorCode;

        public string accessToken;

        public string gameServerIP;

        public int gameServerPort;

        public string contentsVersion;

        public List<string> contentsTag = new List<string>();

        public List<string> openTag = new List<string>();
    }

    [PacketId(ClientPacketId.kNKMPacket_JOIN_LOBBY_REQ)]
    public sealed class NKMPacket_JOIN_LOBBY_REQ : ISerializable
    {
        void ISerializable.Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref this.protocolVersion);
            stream.PutOrGet(ref this.accessToken);
        }

        public int protocolVersion;

        public string accessToken;
    }

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

        public NKM_ERROR_CODE errorCode;

        public long friendCode;

        public NKMUserData userData;

        public NKMGameData gameData;

        public WarfareGameData warfareGameData = new WarfareGameData();

        public DateTime utcTime;

        public TimeSpan utcOffset;

        public DateTime lastCreditSupplyTakeTime;

        public DateTime lastEterniumSupplyTakeTime;

        public double totalPaidAmount;

        public List<ShopChainTabNextResetData> shopChainTabNestResetList = new List<ShopChainTabNextResetData>();

        public NKMPvpBanResult pvpBanResult = new NKMPvpBanResult();

        public PvpState asyncPvpState;

        public PvpState leaguePvpState;

        public DateTime pvpPointChargeTime;

        public bool rankPvpOpen;

        public bool leaguePvpOpen;

        public List<NKMReturningUserState> ReturningUserStates = new List<NKMReturningUserState>();

        public List<NKMContractState> contractState = new List<NKMContractState>();

        public List<NKMContractBonusState> contractBonusState = new List<NKMContractBonusState>();

        public NKMSelectableContractState selectableContractState = new NKMSelectableContractState();

        public List<NKMStagePlayData> stagePlayDataList = new List<NKMStagePlayData>();

        public EventInfo eventInfo = new EventInfo();

        public string reconnectKey;

        public ZlongUserData zlongUserData = new ZlongUserData();

        public NKMBackgroundInfo backGroundInfo = new NKMBackgroundInfo();

        public PrivateGuildData privateGuildData = new PrivateGuildData();

        public DateTime blockMuteEndDate;

        public bool marketReviewCompletion;

        public bool fierceDailyRewardReceived;

        public GuildDungeonRewardInfo guildDungeonRewardInfo = new GuildDungeonRewardInfo();

        public NKMEquipTuningCandidate equipTuningCandidate = new NKMEquipTuningCandidate();

        public NKMPvpGameLobbyState pvpGameLobby = new NKMPvpGameLobbyState();

        public DraftPvpRoomData leaguePvpRoomData;

        public List<PvpSingleHistory> leaguePvpHistories = new List<PvpSingleHistory>();

        public List<PvpSingleHistory> privatePvpHistories = new List<PvpSingleHistory>();

        public NKMMyOfficeState officeState;

        public KakaoMissionData kakaoMissionData;

        public List<int> unlockedStageIds = new List<int>();

        public List<NKMPhaseClearData> phaseClearDataList = new List<NKMPhaseClearData>();

        public PhaseModeState phaseModeState;

        public List<NKMServerKillCountData> serverKillCountDataList = new List<NKMServerKillCountData>();

        public List<NKMKillCountData> killCountDataList = new List<NKMKillCountData>();

        public List<NKMUnitMissionData> completedUnitMissions = new List<NKMUnitMissionData>();

        public List<NKMUnitMissionData> rewardEnableUnitMissions = new List<NKMUnitMissionData>();

        public PvpCastingVoteData pvpCastingVoteData = new PvpCastingVoteData();

        public List<NKMIntervalData> intervalData = new List<NKMIntervalData>();

        public List<NKMConsumerPackageData> consumerPackages = new List<NKMConsumerPackageData>();

        public NpcPvpData npcPvpData;

        public NKMTrimIntervalData trimIntervalData = new NKMTrimIntervalData();

        public List<NKMTrimClearData> trimClearList = new List<NKMTrimClearData>();

        public NKMShipModuleCandidate shipSlotCandidate = new NKMShipModuleCandidate();

        public TrimModeState trimModeState;

        public bool enableAccountLink;

        public NKMEventCollectionInfo eventCollectionInfo = new NKMEventCollectionInfo();

        public NKMUserProfileData userProfileData = new NKMUserProfileData();

        public NKMShortCutInfo lastPlayInfo = new NKMShortCutInfo();

        public PvpState eventPvpState;

        public List<NKMCustomPickupContract> customPickupContracts = new List<NKMCustomPickupContract>();

        public NKMPotentialOptionChangeCandidate potentialOptionCandidate = new NKMPotentialOptionChangeCandidate();

        public PvpCastingVoteData pvpDraftVoteData = new PvpCastingVoteData();
    }
}
