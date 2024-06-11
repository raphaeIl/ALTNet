using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003FB RID: 1019
	public sealed class NKMPotentialOption : ISerializable
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x000786F0 File Offset: 0x000768F0
		public int OpenedSocketCount
		{
			get
			{
				int num = 0;
				for (int i = 0; i < this.sockets.Length; i++)
				{
					if (this.sockets[i] != null)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00078721 File Offset: 0x00076921
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.optionKey);
			stream.PutOrGetEnum<NKM_STAT_TYPE>(ref this.statType);
			stream.PutOrGet<NKMPotentialOption.SocketData>(ref this.sockets);
			stream.PutOrGet(ref this.precisionChangeCount);
		}

		// Token: 0x0400142C RID: 5164
		public int optionKey;

		// Token: 0x0400142D RID: 5165
		public NKM_STAT_TYPE statType;

		// Token: 0x0400142E RID: 5166
		public NKMPotentialOption.SocketData[] sockets = new NKMPotentialOption.SocketData[3];

		// Token: 0x0400142F RID: 5167
		public int precisionChangeCount;

		// Token: 0x0200134E RID: 4942
		public sealed class SocketData : ISerializable
		{
			// Token: 0x0600AF19 RID: 44825 RVA: 0x003919E7 File Offset: 0x0038FBE7
			void ISerializable.Serialize(IPacketStream stream)
			{
				stream.PutOrGet(ref this.statValue);
				stream.PutOrGet(ref this.precision);
			}

			// Token: 0x0400A1D5 RID: 41429
			public float statValue;

			// Token: 0x0400A1D6 RID: 41430
			public int precision;
		}
	}
}
