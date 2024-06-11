using System;
using System.Collections.Generic;
using System.Linq;
using ClientPacket.Common;
using ClientPacket.Community;
using ClientPacket.Contract;
using ClientPacket.Event;
using ClientPacket.Mode;
using ClientPacket.Shop;
using ClientPacket.User;
using ClientPacket.WorldMap;
using Cs.Protocol;
using NKC.Office;
using NKC.Trim;

namespace NKM
{
	public class NKMUserData : ISerializable
	{
		public NKMUserData()
		{
			//this.m_ArmyData.SetOwner(this);
		}

		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_UserUID);
			stream.PutOrGet(ref this.m_FriendCode);
			stream.PutOrGet(ref this.m_UserNickName);
			stream.PutOrGet(ref this.m_UserLevel);
			stream.PutOrGet(ref this.m_lUserLevelEXP);
			stream.PutOrGetEnum<NKM_USER_AUTH_LEVEL>(ref this.m_eAuthLevel);
			stream.PutOrGet<NKMUserDateData>(ref this.m_NKMUserDateData);
			stream.PutOrGet<NKMInventoryData>(ref this.m_InventoryData);
			stream.PutOrGet<NKMArmyData>(ref this.m_ArmyData);
			stream.PutOrGet<NKMUserOption>(ref this.m_UserOption);
			stream.PutOrGet<NKMDungeonClearData>(ref this.m_dicNKMDungeonClearData);
			stream.PutOrGet<NKMWorldMapData>(ref this.m_WorldmapData);
			stream.PutOrGet<NKMWarfareClearData>(ref this.m_dicNKMWarfareClearData);
			stream.PutOrGet<NKMShopData>(ref this.m_ShopData);
			stream.PutOrGet<NKMUserMissionData>(ref this.m_MissionData);
			stream.PutOrGet<NKMCounterCaseData>(ref this.m_dicNKMCounterCaseData);
			stream.PutOrGet<NKMCraftData>(ref this.m_CraftData);
			stream.PutOrGet<NKMEpisodeCompleteData>(ref this.m_dicEpisodeCompleteData);
			stream.PutOrGet<PvpState>(ref this.m_PvpData);
			stream.PutOrGet<PvpHistoryList>(ref this.m_SyncPvpHistory);
			stream.PutOrGet<PvpHistoryList>(ref this.m_AsyncPvpHistory);
			stream.PutOrGet<PvpHistoryList>(ref this.m_EventPvpHistory);
			stream.PutOrGet<NKMDiveGameData>(ref this.m_DiveGameData);
			stream.PutOrGet(ref this.m_DiveClearData);
			stream.PutOrGet(ref this.m_DiveHistoryData);
			stream.PutOrGet<NKMAttendanceData>(ref this.m_AttendanceData);
			stream.PutOrGetEnum<UserState>(ref this.m_UserState);
			stream.PutOrGet<NKMCompanyBuffData>(ref this.m_companyBuffDataList);
			stream.PutOrGet<NKMShadowPalace>(ref this.m_ShadowPalace);
			stream.PutOrGet<NKMBackgroundInfo>(ref this.backGroundInfo);
			stream.PutOrGet<RecallHistoryInfo>(ref this.m_RecallHistoryData);
			stream.PutOrGet<NKMUserBirthDayData>(ref this.m_BirthDayData);
			stream.PutOrGet<NKMJukeboxData>(ref this.m_JukeboxData);
		}

		public List<NKMCompanyBuffData> m_companyBuffDataList = new List<NKMCompanyBuffData>();

		public long m_UserUID;

		public long m_FriendCode;

		public string m_UserNickName = "";

		public NKM_PUBLISHER_TYPE m_NKM_PUBLISHER_TYPE;

		public UserState m_UserState;

		public NKM_USER_AUTH_LEVEL m_eAuthLevel = NKM_USER_AUTH_LEVEL.NORMAL_USER;

		public NKMUserDateData m_NKMUserDateData = new NKMUserDateData();

		public NKMInventoryData m_InventoryData = new NKMInventoryData();

		public NKMArmyData m_ArmyData = new NKMArmyData();

		public NKMUserOption m_UserOption = new NKMUserOption();

		public Dictionary<int, NKMDungeonClearData> m_dicNKMDungeonClearData = new Dictionary<int, NKMDungeonClearData>();

		public NKMWorldMapData m_WorldmapData = new NKMWorldMapData();

		public Dictionary<int, NKMWarfareClearData> m_dicNKMWarfareClearData = new Dictionary<int, NKMWarfareClearData>();

		public NKMShopData m_ShopData = new NKMShopData();

		public NKMUserMissionData m_MissionData = new NKMUserMissionData();

		public Dictionary<int, NKMCounterCaseData> m_dicNKMCounterCaseData = new Dictionary<int, NKMCounterCaseData>();

		public NKMCraftData m_CraftData = new NKMCraftData();

		public NKMEquipTuningCandidate m_EquipTuningCandidate = new NKMEquipTuningCandidate();

		public NKMShipModuleCandidate m_ShipCmdModuleCandidate = new NKMShipModuleCandidate();

		public Dictionary<long, NKMEpisodeCompleteData> m_dicEpisodeCompleteData = new Dictionary<long, NKMEpisodeCompleteData>();

		public PvpState m_PvpData = new PvpState();

		public PvpHistoryList m_SyncPvpHistory = new PvpHistoryList();

		public PvpHistoryList m_AsyncPvpHistory = new PvpHistoryList();

		public PvpHistoryList m_EventPvpHistory = new PvpHistoryList();

		public NKMDiveGameData m_DiveGameData;

		public HashSet<int> m_DiveClearData = new HashSet<int>();

		public HashSet<int> m_DiveHistoryData = new HashSet<int>();

		public NKMAttendanceData m_AttendanceData = new NKMAttendanceData();

		public NKMShadowPalace m_ShadowPalace = new NKMShadowPalace();

		public NKMBackgroundInfo backGroundInfo = new NKMBackgroundInfo();

		public Dictionary<int, RecallHistoryInfo> m_RecallHistoryData = new Dictionary<int, RecallHistoryInfo>();

		public NKMUserBirthDayData m_BirthDayData;

		public NKMJukeboxData m_JukeboxData = new NKMJukeboxData();

		public int m_UserLevel = 1;

		public int m_lUserLevelEXP;

		public PvpState m_AsyncData = new PvpState();

		public PvpState m_LeagueData = new PvpState();

		public PvpState m_eventPvpData = new PvpState();

		public NpcPvpData m_NpcData = new NpcPvpData();

		public NKMPotentialOptionChangeCandidate m_PotentialOptionCandidate = new NKMPotentialOptionChangeCandidate();

		public bool m_enableAccountLink;

		public bool m_RankOpen;

		public bool m_LeagueOpen;

		public DateTime LastPvpPointChargeTimeUTC;

		public DateTime m_GuildJoinDisableTime;

		public PvpHistoryList m_LeaguePvpHistory = new PvpHistoryList();

		public PvpHistoryList m_PrivatePvpHistory = new PvpHistoryList();

		public HashSet<int> m_LastDiveHistoryData = new HashSet<int>();

		public NKCOfficeData OfficeData = new NKCOfficeData();

		public NKCTrimData TrimData = new NKCTrimData();

		private Dictionary<int, NKMConsumerPackageData> m_dicConsumerPackageData = new Dictionary<int, NKMConsumerPackageData>();

		private NKMEventCollectionInfo m_eventCollectionInfo;

		public NKMShortCutInfo m_LastPlayInfo = new NKMShortCutInfo();

		private NKMUserProfileData m_UserProfileData;

		private const string BGM_CONTINUE_KEY = "BGM_CONTINUE_KEY";

		private DateTime m_lastUpdateAsyncTicket = DateTime.MinValue;

		private DateTime m_lastUpdateEterniumCap = DateTime.MinValue;

		public Dictionary<ReturningUserType, NKMReturningUserState> m_dicReturningUserState = new Dictionary<ReturningUserType, NKMReturningUserState>();

		private Dictionary<int, NKMStagePlayData> m_dicStagePlayData = new Dictionary<int, NKMStagePlayData>();

		private NKMUserData.strMentoringData m_MyMentoringData;

		public KakaoMissionData kakaoMissionData;

		private NKMUserData.RaceData m_RaceEventData = new NKMUserData.RaceData();

		public enum eChangeNotifyType
		{
			Add,
			Update,
			Remove
		}

		public struct strMentoringData
		{
			public strMentoringData(bool bInit = false)
			{
				this.SeasonId = 0;
				this.lstMenteeMatch = null;
				this.lstRecommend = null;
				this.lstInvited = null;
				this.MyMentor = null;
				this.bMenteeGraduate = false;
				this.bMentoringNotify = false;
			}

			public int SeasonId;

			public List<MenteeInfo> lstMenteeMatch;

			public List<FriendListData> lstRecommend;

			public List<FriendListData> lstInvited;

			public FriendListData MyMentor;

			public bool bMenteeGraduate;

			public bool bMentoringNotify;
		}

		public class RaceData
		{
			private int m_iEventID;

			private int m_iRaceIndex;

			private NKMEventBetResult m_UserBetLastInfo;

			private NKMEventBetPrivate m_UserBetCurInfo;

			private List<NKMEventBetPrivateResult> m_lstUserBetJoinHistory;

			public NKMEventBetRecord BetRecord;
		}
	}
}
