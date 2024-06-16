using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000D90 RID: 3472
	[PacketId(ClientPacketId.kNKMPacket_MISSION_UPDATE_NOT)]
	public sealed class NKMPacket_MISSION_UPDATE_NOT : ISerializable
	{
		// Token: 0x0600A17C RID: 41340 RVA: 0x00379701 File Offset: 0x00377901
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet<NKMMissionData>(ref this.missionDataList);
		}

		// Token: 0x04009234 RID: 37428
		public HashSet<NKMMissionData> missionDataList = new HashSet<NKMMissionData>();
	}
}
