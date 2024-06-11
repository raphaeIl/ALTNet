using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace ClientPacket.Common
{
	// Token: 0x020011A3 RID: 4515
	public sealed class ZlongPaymentCustomParams : ISerializable
	{
		// Token: 0x0600A961 RID: 43361 RVA: 0x003851E3 File Offset: 0x003833E3
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.selectIndices);
		}

		// Token: 0x04009CD0 RID: 40144
		public List<int> selectIndices = new List<int>();
	}
}
