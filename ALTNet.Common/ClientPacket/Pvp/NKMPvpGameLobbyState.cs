using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;

namespace ClientPacket.Pvp
{
	// Token: 0x02000E7A RID: 3706
	public sealed class NKMPvpGameLobbyState : ISerializable
	{
		// Token: 0x0600A34C RID: 41804 RVA: 0x0037C343 File Offset: 0x0037A543
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_GAME_STATE>(ref this.gameState);
			stream.PutOrGet<NKMPrivateGameConfig>(ref this.config);
			stream.PutOrGet<NKMPvpGameLobbyUserState>(ref this.users);
			stream.PutOrGet<NKMPvpGameLobbyUserState>(ref this.observers);
		}

		// Token: 0x040094BA RID: 38074
		public NKM_GAME_STATE gameState;

		// Token: 0x040094BB RID: 38075
		public NKMPrivateGameConfig config = new NKMPrivateGameConfig();

		// Token: 0x040094BC RID: 38076
		public List<NKMPvpGameLobbyUserState> users = new List<NKMPvpGameLobbyUserState>();

		// Token: 0x040094BD RID: 38077
		public List<NKMPvpGameLobbyUserState> observers = new List<NKMPvpGameLobbyUserState>();
	}
}
