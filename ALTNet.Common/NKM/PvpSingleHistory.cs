using System;
using System.Collections.Generic;
using ClientPacket.Common;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x0200045C RID: 1116
	public class PvpSingleHistory : ISerializable, IComparable<PvpSingleHistory>
	{
		// Token: 0x06001E7D RID: 7805 RVA: 0x00092FDE File Offset: 0x000911DE
		public int CompareTo(PvpSingleHistory other)
		{
			return other.RegdateTick.CompareTo(this.RegdateTick);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00092FF4 File Offset: 0x000911F4
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.gameUid);
			stream.PutOrGet(ref this.MyUserLevel);
			stream.PutOrGet(ref this.TargetUserLevel);
			stream.PutOrGet(ref this.TargetNickName);
			stream.PutOrGetEnum<PVP_RESULT>(ref this.Result);
			stream.PutOrGet(ref this.GainScore);
			stream.PutOrGet(ref this.MyTier);
			stream.PutOrGet(ref this.MyScore);
			stream.PutOrGet(ref this.TargetTier);
			stream.PutOrGet(ref this.TargetScore);
			stream.PutOrGet(ref this.RegdateTick);
			stream.PutOrGet<NKMAsyncDeckData>(ref this.MyDeckData);
			stream.PutOrGet<NKMAsyncDeckData>(ref this.TargetDeckData);
			stream.PutOrGetEnum<NKM_GAME_TYPE>(ref this.GameType);
			stream.PutOrGet(ref this.TargetFriendCode);
			stream.PutOrGet(ref this.SourceGuildUid);
			stream.PutOrGet(ref this.SourceGuildName);
			stream.PutOrGet(ref this.SourceGuildBadgeId);
			stream.PutOrGet(ref this.TargetGuildUid);
			stream.PutOrGet(ref this.TargetGuildName);
			stream.PutOrGet(ref this.TargetGuildBadgeId);
			stream.PutOrGet(ref this.myBanUnitIds);
			stream.PutOrGet(ref this.targetBanUnitIds);
			stream.PutOrGet(ref this.forfeitured);
			stream.PutOrGet(ref this.TargetTitleId);
			stream.PutOrGet(ref this.myBanShipIds);
			stream.PutOrGet(ref this.targetBanShipIds);
		}

		// Token: 0x0400201A RID: 8218
		public long gameUid;

		// Token: 0x0400201B RID: 8219
		public long idx;

		// Token: 0x0400201C RID: 8220
		public int MyUserLevel;

		// Token: 0x0400201D RID: 8221
		public int TargetUserLevel;

		// Token: 0x0400201E RID: 8222
		public string TargetNickName;

		// Token: 0x0400201F RID: 8223
		public PVP_RESULT Result;

		// Token: 0x04002020 RID: 8224
		public int GainScore;

		// Token: 0x04002021 RID: 8225
		public int MyTier;

		// Token: 0x04002022 RID: 8226
		public int MyScore;

		// Token: 0x04002023 RID: 8227
		public int TargetTier;

		// Token: 0x04002024 RID: 8228
		public int TargetScore;

		// Token: 0x04002025 RID: 8229
		public long RegdateTick;

		// Token: 0x04002026 RID: 8230
		public NKMAsyncDeckData MyDeckData;

		// Token: 0x04002027 RID: 8231
		public NKMAsyncDeckData TargetDeckData;

		// Token: 0x04002028 RID: 8232
		public NKM_GAME_TYPE GameType;

		// Token: 0x04002029 RID: 8233
		public long TargetFriendCode;

		// Token: 0x0400202A RID: 8234
		public long SourceGuildUid;

		// Token: 0x0400202B RID: 8235
		public string SourceGuildName;

		// Token: 0x0400202C RID: 8236
		public long SourceGuildBadgeId;

		// Token: 0x0400202D RID: 8237
		public long TargetGuildUid;

		// Token: 0x0400202E RID: 8238
		public string TargetGuildName;

		// Token: 0x0400202F RID: 8239
		public long TargetGuildBadgeId;

		// Token: 0x04002030 RID: 8240
		public List<int> myBanUnitIds = new List<int>();

		// Token: 0x04002031 RID: 8241
		public List<int> targetBanUnitIds = new List<int>();

		// Token: 0x04002032 RID: 8242
		public bool forfeitured;

		// Token: 0x04002033 RID: 8243
		public int TargetTitleId;

		// Token: 0x04002034 RID: 8244
		public List<int> myBanShipIds = new List<int>();

		// Token: 0x04002035 RID: 8245
		public List<int> targetBanShipIds = new List<int>();
	}
}
