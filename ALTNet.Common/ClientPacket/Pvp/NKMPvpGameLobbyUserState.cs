using System;
using ClientPacket.Common;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Pvp
{
	// Token: 0x02000E79 RID: 3705
	public sealed class NKMPvpGameLobbyUserState : ISerializable
	{
		// Token: 0x0600A34A RID: 41802 RVA: 0x0037C2F2 File Offset: 0x0037A4F2
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMUserProfileData>(ref this.profileData);
			stream.PutOrGet(ref this.isReady);
			stream.PutOrGet(ref this.isHost);
			stream.PutOrGet<NKMDeckIndex>(ref this.deckIndex);
			stream.PutOrGet<NKMDummyDeckData>(ref this.deckData);
		}

		// Token: 0x040094B5 RID: 38069
		public NKMUserProfileData profileData = new NKMUserProfileData();

		// Token: 0x040094B6 RID: 38070
		public bool isReady;

		// Token: 0x040094B7 RID: 38071
		public bool isHost;

		// Token: 0x040094B8 RID: 38072
		public NKMDeckIndex deckIndex;

		// Token: 0x040094B9 RID: 38073
		public NKMDummyDeckData deckData;
	}
}
