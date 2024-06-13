using System;
using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Service
{
	// Token: 0x02000E23 RID: 3619
	[PacketId(ClientPacketId.kNKMPacket_UI_SCEN_CHANGED_REQ)]
	public sealed class NKMPacket_UI_SCEN_CHANGED_REQ : ISerializable
	{
		// Token: 0x0600A2A2 RID: 41634 RVA: 0x0037B147 File Offset: 0x00379347
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_SCEN_ID>(ref this.scenID);
		}

		// Token: 0x040093A2 RID: 37794
		public NKM_SCEN_ID scenID;
	}
}
