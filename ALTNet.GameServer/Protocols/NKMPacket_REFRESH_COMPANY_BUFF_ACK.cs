using Cs.Protocol;
using NKM;
using Protocol;

namespace ClientPacket.User
{
	// Token: 0x02000DA9 RID: 3497
	[PacketId(ClientPacketId.kNKMPacket_REFRESH_COMPANY_BUFF_ACK)]
	public sealed class NKMPacket_REFRESH_COMPANY_BUFF_ACK : ISerializable
	{
		// Token: 0x0600A1AE RID: 41390 RVA: 0x00379B8F File Offset: 0x00377D8F
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
			stream.PutOrGet<NKMCompanyBuffData>(ref this.companyBuffDataList);
		}

		// Token: 0x04009277 RID: 37495
		public NKM_ERROR_CODE errorCode;

		// Token: 0x04009278 RID: 37496
		public List<NKMCompanyBuffData> companyBuffDataList = new List<NKMCompanyBuffData>();
	}
}
