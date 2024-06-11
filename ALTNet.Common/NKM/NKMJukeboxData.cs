using System;
using System.Collections.Generic;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000394 RID: 916
	public class NKMJukeboxData : ISerializable
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x0005FCFC File Offset: 0x0005DEFC
		public int GetJukeboxBgmId(NKM_BGM_TYPE bgmType)
		{
			if (!this.dicBgmId.ContainsKey((int)bgmType))
			{
				return 0;
			}
			return this.dicBgmId[(int)bgmType];
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0005FD27 File Offset: 0x0005DF27
		public void SetJukeboxBgm(int bgmType, int bgmId)
		{
			if (!this.dicBgmId.ContainsKey(bgmType))
			{
				this.dicBgmId.Add(bgmType, bgmId);
				return;
			}
			this.dicBgmId[bgmType] = bgmId;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0005FD54 File Offset: 0x0005DF54
		public bool IsBgmChanged(NKM_BGM_TYPE bgmType, int bgmId)
		{
			return !this.dicBgmId.ContainsKey((int)bgmType) || this.dicBgmId[(int)bgmType] != bgmId;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0005FD85 File Offset: 0x0005DF85
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.dicBgmId);
		}

		// Token: 0x04000FE2 RID: 4066
		private Dictionary<int, int> dicBgmId = new Dictionary<int, int>();
	}
}
