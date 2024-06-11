using System;
using Cs.Protocol;

namespace NKM
{
	// Token: 0x02000397 RID: 919
	public sealed class NKMUserMobileData : ISerializable
	{
		// Token: 0x0600176A RID: 5994 RVA: 0x0005FDA8 File Offset: 0x0005DFA8
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.m_MarketId);
			stream.PutOrGet(ref this.m_Country);
			stream.PutOrGet(ref this.m_Language);
			stream.PutOrGet(ref this.m_AuthPlatform);
			stream.PutOrGet(ref this.m_Platform);
			stream.PutOrGet(ref this.m_OsVersion);
			stream.PutOrGet(ref this.m_AdId);
			stream.PutOrGet(ref this.m_ClientVersion);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0005FE18 File Offset: 0x0005E018
		public short GetMarketID()
		{
			string marketId = this.m_MarketId;
			if (marketId != null)
			{
				if (marketId == "Google Play Store")
				{
					return 1;
				}
				if (marketId == "Apple App Store")
				{
					return 2;
				}
				if (marketId == "One Store")
				{
					return 3;
				}
				if (marketId == "WINDOWS")
				{
					return 200;
				}
			}
			return 0;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0005FE72 File Offset: 0x0005E072
		public static string GetMarketStr(short index)
		{
			switch (index)
			{
			case 1:
				return "Google Play Store";
			case 2:
				return "Apple App Store";
			case 3:
				return "One Store";
			default:
				if (index != 200)
				{
					return "Unknown";
				}
				return "WINDOWS";
			}
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0005FEB0 File Offset: 0x0005E0B0
		public ClientOsType GetOsType()
		{
			string marketId = this.m_MarketId;
			if (marketId != null)
			{
				if (marketId == "Google Play Store")
				{
					return ClientOsType.Android;
				}
				if (marketId == "Apple App Store")
				{
					return ClientOsType.iOS;
				}
				if (marketId == "One Store")
				{
					return ClientOsType.Android;
				}
				if (marketId == "Steam" || marketId == "WINDOWS")
				{
					return ClientOsType.Windows;
				}
			}
			return ClientOsType.Unknown;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0005FF14 File Offset: 0x0005E114
		public ClientOsNxLogType GetNxLogOsType()
		{
			string marketId = this.m_MarketId;
			if (marketId != null)
			{
				if (marketId == "Google Play Store")
				{
					return ClientOsNxLogType.Android;
				}
				if (marketId == "Apple App Store")
				{
					return ClientOsNxLogType.iOS;
				}
				if (marketId == "One Store")
				{
					return ClientOsNxLogType.Android;
				}
				if (marketId == "WINDOWS")
				{
					return ClientOsNxLogType.Windows;
				}
			}
			return ClientOsNxLogType.Unknown;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0005FF6C File Offset: 0x0005E16C
		public string GetMarketStrID()
		{
			string marketId = this.m_MarketId;
			if (marketId != null)
			{
				if (marketId == "Google Play Store")
				{
					return "GPS";
				}
				if (marketId == "Apple App Store")
				{
					return "AAS";
				}
				if (marketId == "One Store")
				{
					return "ONE";
				}
			}
			return string.Empty;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0005FFC4 File Offset: 0x0005E1C4
		public byte GetAuthPlatformID()
		{
			byte result = 0;
			string authPlatform = this.m_AuthPlatform;
			if (authPlatform != null)
			{
				if (!(authPlatform == "NexonPlay"))
				{
					if (!(authPlatform == "KaKao"))
					{
						if (!(authPlatform == "NPA"))
						{
							if (!(authPlatform == "Nexon.com"))
							{
								if (authPlatform == "inner")
								{
									result = 5;
								}
							}
							else
							{
								result = 4;
							}
						}
						else
						{
							result = 3;
						}
					}
					else
					{
						result = 2;
					}
				}
				else
				{
					result = 1;
				}
			}
			return result;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00060034 File Offset: 0x0005E234
		public string GetPlatformStrID()
		{
			string platform = this.m_Platform;
			if (platform != null)
			{
				if (platform == "Android")
				{
					return "A";
				}
				if (platform == "IPhonePlayer")
				{
					return "I";
				}
			}
			return string.Empty;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00060078 File Offset: 0x0005E278
		public string GetPlatformStrIDForNGSM()
		{
			string platform = this.m_Platform;
			if (platform != null)
			{
				if (platform == "Android")
				{
					return "AOS";
				}
				if (platform == "IPhonePlayer")
				{
					return "IOS";
				}
			}
			return string.Empty;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x000600BC File Offset: 0x0005E2BC
		public string GetCountryCode()
		{
			string country = this.m_Country;
			if (country != null && (country == "KO_KR" || country == "Korea"))
			{
				return "KR";
			}
			return this.m_Country;
		}

		// Token: 0x04000FF2 RID: 4082
		public const string NxPcMarketId = "WINDOWS";

		// Token: 0x04000FF3 RID: 4083
		public static readonly NKMUserMobileData DevDefault = new NKMUserMobileData
		{
			m_MarketId = "DevDefault",
			m_Country = "DevDefault",
			m_Language = "DevDefault",
			m_AuthPlatform = "DevDefault",
			m_Platform = "DevDefault",
			m_OsVersion = "DevDefault",
			m_AdId = "DevDefault",
			m_ClientVersion = "DevDefault"
		};

		// Token: 0x04000FF4 RID: 4084
		public string m_MarketId;

		// Token: 0x04000FF5 RID: 4085
		public string m_Country;

		// Token: 0x04000FF6 RID: 4086
		public string m_Language;

		// Token: 0x04000FF7 RID: 4087
		public string m_AuthPlatform;

		// Token: 0x04000FF8 RID: 4088
		public string m_Platform;

		// Token: 0x04000FF9 RID: 4089
		public string m_OsVersion;

		// Token: 0x04000FFA RID: 4090
		public string m_AdId;

		// Token: 0x04000FFB RID: 4091
		public string m_ClientVersion;
	}
}
