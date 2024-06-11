using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x020003E1 RID: 993
	public struct NKMDeckIndex : ISerializable, IEquatable<NKMDeckIndex>
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x000712FD File Offset: 0x0006F4FD
		public NKMDeckIndex(NKM_DECK_TYPE eDeckType)
		{
			this.m_eDeckType = eDeckType;
			this.m_iIndex = 0;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0007130D File Offset: 0x0006F50D
		public NKMDeckIndex(NKM_DECK_TYPE eDeckType, int Index)
		{
			this.m_eDeckType = ((Index < 0) ? NKM_DECK_TYPE.NDT_NONE : eDeckType);
			this.m_iIndex = (byte)Index;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00071325 File Offset: 0x0006F525
		public bool Compare(NKMDeckIndex rhs)
		{
			return this.m_eDeckType == rhs.m_eDeckType && this.m_iIndex == rhs.m_iIndex;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00071345 File Offset: 0x0006F545
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGetEnum<NKM_DECK_TYPE>(ref this.m_eDeckType);
			stream.PutOrGet(ref this.m_iIndex);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0007135F File Offset: 0x0006F55F
		public override string ToString()
		{
			return string.Format("DeckIndex {0} {1}", this.m_eDeckType.ToString(), this.m_iIndex);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00071387 File Offset: 0x0006F587
		public static bool operator ==(NKMDeckIndex lhs, NKMDeckIndex rhs)
		{
			return lhs.m_eDeckType == rhs.m_eDeckType && lhs.m_iIndex == rhs.m_iIndex;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000713A7 File Offset: 0x0006F5A7
		public static bool operator !=(NKMDeckIndex lhs, NKMDeckIndex rhs)
		{
			return lhs.m_eDeckType != rhs.m_eDeckType || lhs.m_iIndex != rhs.m_iIndex;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000713CC File Offset: 0x0006F5CC
		public override bool Equals(object obj)
		{
			if (!(obj is NKMDeckIndex))
			{
				return false;
			}
			NKMDeckIndex nkmdeckIndex = (NKMDeckIndex)obj;
			return this.m_eDeckType == nkmdeckIndex.m_eDeckType && this.m_iIndex == nkmdeckIndex.m_iIndex;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00071408 File Offset: 0x0006F608
		public override int GetHashCode()
		{
			return new ValueTuple<NKM_DECK_TYPE, byte>(this.m_eDeckType, this.m_iIndex).GetHashCode();
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00071434 File Offset: 0x0006F634
		public bool Equals(NKMDeckIndex other)
		{
			return this.m_eDeckType == other.m_eDeckType && this.m_iIndex == other.m_iIndex;
		}

		// Token: 0x0400134B RID: 4939
		public static readonly NKMDeckIndex None = new NKMDeckIndex(NKM_DECK_TYPE.NDT_NONE);

		// Token: 0x0400134C RID: 4940
		public NKM_DECK_TYPE m_eDeckType;

		// Token: 0x0400134D RID: 4941
		public byte m_iIndex;
	}
}
