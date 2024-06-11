using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Community
{
	// Token: 0x02001155 RID: 4437
	[PacketId(ClientPacketId.kNKMPacket_GREETING_MESSAGE_ACK)]
	public sealed class NKMPacket_GREETING_MESSAGE_ACK : ISerializable
	{
		// Token: 0x0600A8D5 RID: 43221 RVA: 0x003842B2 File Offset: 0x003824B2
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.message);
		}

		// Token: 0x04009BDA RID: 39898
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009BDB RID: 39899
		public string message;
	}
}
