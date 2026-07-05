using System;
using System.IO;
using System.Reflection;

namespace 랾
{
	// Token: 0x02000059 RID: 89
	internal static class 럻
	{
		// Token: 0x06000351 RID: 849 RVA: 0x0007DF4C File Offset: 0x0007C14C
		public static bool 랾(out string A_0)
		{
			object obj = 럻.랾;
			bool result;
			lock (obj)
			{
				if (!랉.랾(Assembly.GetExecutingAssembly().Location, out A_0))
				{
					result = false;
				}
				else if (!럻.람(out A_0))
				{
					result = false;
				}
				else if (!럯.랾(out A_0))
				{
					result = false;
				}
				else
				{
					A_0 = null;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0007DFBC File Offset: 0x0007C1BC
		public static bool 럎(out string A_0)
		{
			object obj = 럻.랾;
			bool result;
			lock (obj)
			{
				string value;
				string value2;
				string value3;
				bool flag2;
				if (!랉.랾(Assembly.GetExecutingAssembly().Location, out A_0))
				{
					result = false;
				}
				else if (!럻.람(out A_0))
				{
					result = false;
				}
				else if (!럯.랾(out A_0))
				{
					result = false;
				}
				else if (!랖.랾(out value, out value2, out value3, out flag2))
				{
					A_0 = "MissingSessionState";
					result = false;
				}
				else if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(value2) || string.IsNullOrWhiteSpace(value3))
				{
					A_0 = "IncompleteSessionState";
					result = false;
				}
				else if (string.IsNullOrWhiteSpace(럧.랱) || string.Equals(럧.랱, "NOT_SET_YET", StringComparison.OrdinalIgnoreCase))
				{
					A_0 = "MissingRuntimeHwid";
					result = false;
				}
				else if (!럝.랾() || string.IsNullOrWhiteSpace(럧.랪))
				{
					A_0 = "MissingVerifyService";
					result = false;
				}
				else
				{
					A_0 = null;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0007E0C4 File Offset: 0x0007C2C4
		private static bool 람(out string A_0)
		{
			string text = 럻.랾();
			if (string.IsNullOrWhiteSpace(text) || !File.Exists(text))
			{
				A_0 = "MissingRequiredFile(DiscordRPC.dll)";
				return false;
			}
			if (!럭.랾(text, "4DD4D48E0681604E3A7A72B6EAE42173421D0B806B1AF8FA03B45D9999978499"))
			{
				A_0 = "RequiredFileHashMismatch(DiscordRPC.dll)";
				return false;
			}
			A_0 = null;
			return true;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0007E10C File Offset: 0x0007C30C
		private static string 랾()
		{
			try
			{
				Type type = Type.GetType("DiscordRPC.DiscordRpcClient, DiscordRPC", false);
				if (((type != null) ? type.Assembly : null) != null && !string.IsNullOrWhiteSpace(type.Assembly.Location))
				{
					return type.Assembly.Location;
				}
			}
			catch
			{
			}
			return Path.Combine(럻.럎(), "DiscordRPC.dll");
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0007E180 File Offset: 0x0007C380
		private static string 럎()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			if (!string.IsNullOrWhiteSpace(directoryName))
			{
				return directoryName;
			}
			return AppContext.BaseDirectory;
		}

		// Token: 0x040002B0 RID: 688
		private const string 랾 = "4DD4D48E0681604E3A7A72B6EAE42173421D0B806B1AF8FA03B45D9999978499";

		// Token: 0x040002B1 RID: 689
		private const string 럎 = "DiscordRPC.dll";

		// Token: 0x040002B2 RID: 690
		private static readonly object 랾 = new object();
	}
}
