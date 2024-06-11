using System;
using Cs.Protocol;
using NKM.Templet;

namespace ClientPacket.Warfare
{
	// Token: 0x02000D61 RID: 3425
	public sealed class WarfareTileData : ISerializable
	{
		// Token: 0x0600A11E RID: 41246 RVA: 0x00378B43 File Offset: 0x00376D43
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.index);
			stream.PutOrGetEnum<NKM_WARFARE_MAP_TILE_TYPE>(ref this.tileType);
			stream.PutOrGet(ref this.battleConditionId);
		}

		// Token: 0x04009181 RID: 37249
		public short index;

		// Token: 0x04009182 RID: 37250
		public NKM_WARFARE_MAP_TILE_TYPE tileType;

		// Token: 0x04009183 RID: 37251
		public int battleConditionId;
	}
}
