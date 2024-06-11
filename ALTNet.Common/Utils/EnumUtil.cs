using System;
using System.Collections.Generic;
using System.Linq;

namespace Cs.Core.Util
{
	// Token: 0x02001239 RID: 4665
	public static class EnumUtil<T> where T : Enum
	{
		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x0600AC5D RID: 44125 RVA: 0x0038D3BC File Offset: 0x0038B5BC
		public static int Count
		{
			get
			{
				return Enum.GetNames(typeof(T)).Length;
			}
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x0038D3CF File Offset: 0x0038B5CF
		public static IEnumerable<T> GetValues()
		{
			return Enum.GetValues(typeof(T)).Cast<T>();
		}
	}
}
