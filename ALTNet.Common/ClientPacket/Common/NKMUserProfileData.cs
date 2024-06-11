using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Common
{
	// Token: 0x02001197 RID: 4503
	public sealed class NKMUserProfileData : ISerializable
	{
		// Token: 0x0600A949 RID: 43337 RVA: 0x00384DBC File Offset: 0x00382FBC
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMCommonProfile>(ref this.commonProfile);
			stream.PutOrGet(ref this.friendIntro);
			stream.PutOrGet<NKMUserProfileData.PvpProfileData>(ref this.rankPvpData);
			stream.PutOrGet<NKMUserProfileData.PvpProfileData>(ref this.asyncPvpData);
			stream.PutOrGet<NKMUserProfileData.PvpProfileData>(ref this.leaguePvpData);
			stream.PutOrGet<NKMDummyDeckData>(ref this.profileDeck);
			stream.PutOrGet<NKMDummyDeckData>(ref this.leagueDeck);
			stream.PutOrGet<NKMAsyncDeckData>(ref this.defenceDeck);
			stream.PutOrGet<NKMEmblemData>(ref this.emblems);
			stream.PutOrGet(ref this.selfiFrameId);
			stream.PutOrGet<NKMGuildSimpleData>(ref this.guildData);
			stream.PutOrGet(ref this.hasOffice);
			stream.PutOrGetEnum<PrivatePvpInvitation>(ref this.privatePvpInvitation);
		}

		// Token: 0x04009C90 RID: 40080
		public NKMCommonProfile commonProfile = new NKMCommonProfile();

		// Token: 0x04009C91 RID: 40081
		public string friendIntro;

		// Token: 0x04009C92 RID: 40082
		public NKMUserProfileData.PvpProfileData rankPvpData = new NKMUserProfileData.PvpProfileData();

		// Token: 0x04009C93 RID: 40083
		public NKMUserProfileData.PvpProfileData asyncPvpData = new NKMUserProfileData.PvpProfileData();

		// Token: 0x04009C94 RID: 40084
		public NKMUserProfileData.PvpProfileData leaguePvpData = new NKMUserProfileData.PvpProfileData();

		// Token: 0x04009C95 RID: 40085
		public NKMDummyDeckData profileDeck;

		// Token: 0x04009C96 RID: 40086
		public NKMDummyDeckData leagueDeck;

		// Token: 0x04009C97 RID: 40087
		public NKMAsyncDeckData defenceDeck = new NKMAsyncDeckData();

		// Token: 0x04009C98 RID: 40088
		public List<NKMEmblemData> emblems = new List<NKMEmblemData>();

		// Token: 0x04009C99 RID: 40089
		public int selfiFrameId;

		// Token: 0x04009C9A RID: 40090
		public NKMGuildSimpleData guildData = new NKMGuildSimpleData();

		// Token: 0x04009C9B RID: 40091
		public bool hasOffice;

		// Token: 0x04009C9C RID: 40092
		public PrivatePvpInvitation privatePvpInvitation;

		// Token: 0x02001C67 RID: 7271
		public sealed class PvpProfileData : ISerializable
		{
			// Token: 0x0600CBB9 RID: 52153 RVA: 0x003C3E4B File Offset: 0x003C204B
			void ISerializable.Serialize(IPacketStream stream)
			{
				stream.PutOrGet(ref this.seasonId);
				stream.PutOrGet(ref this.leagueTierId);
				stream.PutOrGet(ref this.score);
			}

			// Token: 0x0400BDB5 RID: 48565
			public int seasonId;

			// Token: 0x0400BDB6 RID: 48566
			public int leagueTierId;

			// Token: 0x0400BDB7 RID: 48567
			public int score;
		}
	}
}
