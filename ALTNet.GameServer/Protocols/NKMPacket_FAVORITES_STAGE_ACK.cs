using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.Mode
{
	// Token: 0x02000F58 RID: 3928
	[PacketId(ClientPacketId.kNKMPacket_FAVORITES_STAGE_ACK)]
	public sealed class NKMPacket_FAVORITES_STAGE_ACK : ISerializable
	{
		// Token: 0x0600A4FF RID: 42239 RVA: 0x0037E5E4 File Offset: 0x0037C7E4
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet(ref this.favoritesStage);
		}

		// Token: 0x0400967C RID: 38524
		public NKM_ERROR_CODE errorCode;

		// Token: 0x0400967D RID: 38525
		public Dictionary<int, int> favoritesStage = new Dictionary<int, int>();
	}
}
