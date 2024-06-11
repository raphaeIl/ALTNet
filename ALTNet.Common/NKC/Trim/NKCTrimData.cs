using System;
using System.Collections.Generic;
using ClientPacket.Common;

namespace NKC.Trim
{
	// Token: 0x020008F2 RID: 2290
	public class NKCTrimData
	{
		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06005CBC RID: 23740 RVA: 0x001BBA11 File Offset: 0x001B9C11
		public NKMTrimIntervalData TrimIntervalData
		{
			get
			{
				if (this.trimIntervalData == null)
				{
					return new NKMTrimIntervalData();
				}
				return this.trimIntervalData;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x001BBA27 File Offset: 0x001B9C27
		public List<NKMTrimClearData> TrimClearList
		{
			get
			{
				if (this.trimClearList == null)
				{
					return new List<NKMTrimClearData>();
				}
				return this.trimClearList;
			}
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x001BBA45 File Offset: 0x001B9C45
		public void SetTrimIntervalData(NKMTrimIntervalData _trimIntervalData)
		{
			if (_trimIntervalData == null)
			{
				return;
			}
			this.trimIntervalData = _trimIntervalData;
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x001BBA52 File Offset: 0x001B9C52
		public void SetTrimClearList(List<NKMTrimClearData> _trimClearList)
		{
			if (_trimClearList == null)
			{
				return;
			}
			this.trimClearList = _trimClearList;
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x001BBA60 File Offset: 0x001B9C60
		public void SetTrimClearData(NKMTrimClearData trimClearData)
		{
			if (trimClearData == null || this.trimClearList == null)
			{
				return;
			}
			int num = this.trimClearList.FindIndex((NKMTrimClearData e) => e.trimId == trimClearData.trimId && e.trimLevel == trimClearData.trimLevel);
			if (num >= 0)
			{
				this.trimClearList[num] = trimClearData;
				return;
			}
			this.trimClearList.Add(trimClearData);
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x001BBACC File Offset: 0x001B9CCC
		public int GetClearedTrimLevel(int trimId)
		{
			int clearedLevel = 0;
			if (this.trimClearList != null)
			{
				List<NKMTrimClearData> list = this.trimClearList.FindAll((NKMTrimClearData e) => e.trimId == trimId);
				if (list != null && list.Count > 0)
				{
					list.ForEach(delegate(NKMTrimClearData e)
					{
						if (e.isWin && clearedLevel < e.trimLevel)
						{
							clearedLevel = e.trimLevel;
						}
					});
				}
			}
			return clearedLevel;
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x001BBB34 File Offset: 0x001B9D34
		public NKMTrimClearData GetTrimClearData(int trimId, int trimLevel)
		{
			List<NKMTrimClearData> list = this.trimClearList;
			if (list == null)
			{
				return null;
			}
			return list.Find((NKMTrimClearData e) => e.trimId == trimId && e.trimLevel == trimLevel);
		}

		// Token: 0x040048AD RID: 18605
		private NKMTrimIntervalData trimIntervalData;

		// Token: 0x040048AE RID: 18606
		private List<NKMTrimClearData> trimClearList;
	}
}
