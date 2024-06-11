using System;

namespace NKM.Templet.Base
{
	// Token: 0x0200064E RID: 1614
	public interface INKMTemplet
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003218 RID: 12824
		int Key { get; }

		// Token: 0x06003219 RID: 12825
		void Join();

		// Token: 0x0600321A RID: 12826
		void Validate();
	}
}
