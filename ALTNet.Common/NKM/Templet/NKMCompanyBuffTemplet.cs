using System;
using System.Collections.Generic;
using System.Linq;
using NKC;
using NKM.Templet.Base;

namespace NKM.Templet
{
	// Token: 0x020005D0 RID: 1488
	public class NKMCompanyBuffTemplet : INKMTemplet
	{
		// Token: 0x04002C80 RID: 11392
		public int m_CompanyBuffID;

		// Token: 0x04002C81 RID: 11393
		public NKMCompanyBuffSource m_CompanyBuffSource;

		// Token: 0x04002C82 RID: 11394
		public NKMCompanyBuffCategory m_CompanyBuffCategory;

		// Token: 0x04002C83 RID: 11395
		public string m_CompanyBuffIcon;

		// Token: 0x04002C84 RID: 11396
		public string m_CompanyBuffItemIcon;

		// Token: 0x04002C85 RID: 11397
		public string m_CompanyBuffTitle;

		// Token: 0x04002C86 RID: 11398
		public string m_CompanyBuffDesc;

		// Token: 0x04002C87 RID: 11399
		public bool m_ShowEventMark = true;

		// Token: 0x04002C88 RID: 11400
		public int m_CompanyBuffTime;

		// Token: 0x04002C89 RID: 11401
		public int m_AccountLevelMin;

		// Token: 0x04002C8A RID: 11402
		public int m_AccountLevelMax;

		// Token: 0x04002C8B RID: 11403
		public List<NKMCompanyBuffInfo> m_CompanyBuffInfoList = new List<NKMCompanyBuffInfo>();

        public int Key => throw new NotImplementedException();

        public void Join()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
