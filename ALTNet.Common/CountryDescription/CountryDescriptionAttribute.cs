using System;

namespace Cs.GameLog.CountryDescription
{
	// Token: 0x02001234 RID: 4660
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public sealed class CountryDescriptionAttribute : Attribute
	{
		// Token: 0x0600AC44 RID: 44100 RVA: 0x0038D140 File Offset: 0x0038B340
		public CountryDescriptionAttribute(string desc, CountryCode code = CountryCode.KOR)
		{
			this.Description = desc;
			this.CountryCode = code;
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x0038D156 File Offset: 0x0038B356
		public string Description { get; }

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x0038D15E File Offset: 0x0038B35E
		public CountryCode CountryCode { get; }
	}
}
