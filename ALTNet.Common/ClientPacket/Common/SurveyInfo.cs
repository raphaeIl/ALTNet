using System;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x0200119E RID: 4510
	public sealed class SurveyInfo : ISerializable
	{
		// Token: 0x0600A957 RID: 43351 RVA: 0x003850A7 File Offset: 0x003832A7
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.surveyId);
			stream.PutOrGet(ref this.userLevel);
			stream.PutOrGet(ref this.startDate);
			stream.PutOrGet(ref this.endDate);
		}

		// Token: 0x04009CBB RID: 40123
		public long surveyId;

		// Token: 0x04009CBC RID: 40124
		public int userLevel;

		// Token: 0x04009CBD RID: 40125
		public DateTime startDate;

		// Token: 0x04009CBE RID: 40126
		public DateTime endDate;
	}
}
