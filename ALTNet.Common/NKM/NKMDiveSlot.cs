using System;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x0200037A RID: 890
	public sealed class NKMDiveSlot : ISerializable
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x00059F59 File Offset: 0x00058159
		public NKM_DIVE_SECTOR_TYPE SectorType
		{
			get
			{
				return this.sectorType;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00059F61 File Offset: 0x00058161
		public NKM_DIVE_EVENT_TYPE EventType
		{
			get
			{
				return this.eventType;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00059F69 File Offset: 0x00058169
		public int EventValue
		{
			get
			{
				return this.eventValue;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00059F71 File Offset: 0x00058171
		public int ArtifactEventRate
		{
			get
			{
				return this.artifactEventRate;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00059F79 File Offset: 0x00058179
		public int ArtifactRewardGroup
		{
			get
			{
				return this.artifactRewardGroup;
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00059F81 File Offset: 0x00058181
		public NKMDiveSlot()
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00059F89 File Offset: 0x00058189
		public NKMDiveSlot(NKM_DIVE_SECTOR_TYPE sectorType, NKM_DIVE_EVENT_TYPE eventType, int eventValue, int artifactEventRate, int artifactRewardGroup)
		{
			this.sectorType = sectorType;
			this.eventType = eventType;
			this.eventValue = eventValue;
			this.artifactEventRate = artifactEventRate;
			this.artifactRewardGroup = artifactRewardGroup;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00059FB6 File Offset: 0x000581B6
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_DIVE_SECTOR_TYPE>(ref this.sectorType);
			stream.PutOrGetEnum<NKM_DIVE_EVENT_TYPE>(ref this.eventType);
			stream.PutOrGet(ref this.eventValue);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00059FDC File Offset: 0x000581DC
		public void UpdateEvent(NKM_DIVE_EVENT_TYPE type, int value)
		{
			this.eventType = type;
			this.eventValue = value;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00059FEC File Offset: 0x000581EC
		public NKMDiveSlot Clone()
		{
			return new NKMDiveSlot(this.sectorType, this.eventType, this.eventValue, this.artifactEventRate, this.artifactRewardGroup);
		}

		// Token: 0x04000EF3 RID: 3827
		private NKM_DIVE_SECTOR_TYPE sectorType;

		// Token: 0x04000EF4 RID: 3828
		private NKM_DIVE_EVENT_TYPE eventType;

		// Token: 0x04000EF5 RID: 3829
		private int eventValue;

		// Token: 0x04000EF6 RID: 3830
		private int artifactEventRate;

		// Token: 0x04000EF7 RID: 3831
		private int artifactRewardGroup;
	}
}
