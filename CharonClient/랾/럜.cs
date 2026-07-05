using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Win32;

namespace 랾
{
	// Token: 0x0200006A RID: 106
	internal static class 럜
	{
		// Token: 0x060003CE RID: 974 RVA: 0x0003E6FB File Offset: 0x0003C8FB
		public static void 랾(string A_0, string A_1)
		{
			럜.랾(럜.랾, A_0, A_1);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0003E709 File Offset: 0x0003C909
		public static void 럎(string A_0, string A_1)
		{
			럜.랾(럜.럎, A_0, A_1);
			럜.럼(A_0, A_1);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0007FD48 File Offset: 0x0007DF48
		public static bool 람(string A_0, string A_1)
		{
			럜.랾 랾 = 럜.랾(럜.럎);
			return 랾 != null && string.Equals(랾.랾(), A_0, StringComparison.OrdinalIgnoreCase) && string.Equals(랾.럎(), A_1, StringComparison.Ordinal) && DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - 랾.람() <= (long)럜.랾.TotalMilliseconds && 럜.럒(A_0, A_1);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0007FDB4 File Offset: 0x0007DFB4
		public static bool 랾()
		{
			string 랱 = 럧.랱;
			string text = (랱 != null) ? 랱.Trim() : null;
			string text2 = 럳.랾(럧.럑);
			string text3 = (text2 != null) ? text2.Trim() : null;
			return 럜.럒(text, text3);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0007FDF0 File Offset: 0x0007DFF0
		public static bool 럒(string A_0, string A_1)
		{
			bool result;
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\CharonClient\\Verification", false))
				{
					if (registryKey == null)
					{
						result = false;
					}
					else if (!럜.랾(registryKey.GetValue("Authorized")))
					{
						result = false;
					}
					else if (!string.Equals(럜.랾(registryKey, "Hwid"), (A_0 != null) ? A_0.Trim() : null, StringComparison.OrdinalIgnoreCase))
					{
						result = false;
					}
					else if (!string.Equals(럜.랾(registryKey, "InstallId"), (A_1 != null) ? A_1.Trim() : null, StringComparison.Ordinal))
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0003E71E File Offset: 0x0003C91E
		public static void 럎()
		{
			럳.럎(럜.랾);
			럳.럎(럜.럎);
			럳.럎(럜.람);
			럜.람();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0007FEA4 File Offset: 0x0007E0A4
		private static void 랾(string A_0, string A_1, string A_2)
		{
			try
			{
				럜.랾 랾 = new 럜.랾();
				랾.랾(A_1 ?? string.Empty);
				랾.럎(A_2 ?? string.Empty);
				랾.랾(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
				랾.람(랱.랾());
				랾.럒("2.0");
				럜.랾 value = 랾;
				럳.랾(A_0, JsonSerializer.Serialize<럜.랾>(value, null));
			}
			catch
			{
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0007FF24 File Offset: 0x0007E124
		private static void 럼(string A_0, string A_1)
		{
			try
			{
				럳.럎(럜.람);
				using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\CharonClient\\Verification", true))
				{
					if (registryKey != null)
					{
						registryKey.SetValue("Authorized", 1, RegistryValueKind.DWord);
						registryKey.SetValue("Hwid", A_0 ?? string.Empty, RegistryValueKind.String);
						registryKey.SetValue("InstallId", A_1 ?? string.Empty, RegistryValueKind.String);
						registryKey.SetValue("Machine", 랱.랾() ?? string.Empty, RegistryValueKind.String);
						registryKey.SetValue("Version", "2.0", RegistryValueKind.String);
						registryKey.SetValue("TimestampUtc", DateTimeOffset.UtcNow.ToString("O"), RegistryValueKind.String);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00080008 File Offset: 0x0007E208
		private static void 람()
		{
			try
			{
				Registry.CurrentUser.DeleteSubKeyTree("Software\\CharonClient\\Verification", false);
			}
			catch
			{
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0008003C File Offset: 0x0007E23C
		private static bool 랾(object A_0)
		{
			bool result;
			if (A_0 is int)
			{
				int num = (int)A_0;
				result = (num == 1);
			}
			else
			{
				string text = A_0 as string;
				result = (text != null && (string.Equals(text.Trim(), "true", StringComparison.OrdinalIgnoreCase) || string.Equals(text.Trim(), "1", StringComparison.Ordinal)));
			}
			return result;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0008009C File Offset: 0x0007E29C
		private static string 랾(RegistryKey A_0, string A_1)
		{
			string result;
			try
			{
				object value = A_0.GetValue(A_1);
				string text;
				if (value == null)
				{
					text = null;
				}
				else
				{
					string text2 = value.ToString();
					text = ((text2 != null) ? text2.Trim() : null);
				}
				result = text;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000800E4 File Offset: 0x0007E2E4
		private static 럜.랾 랾(string A_0)
		{
			럜.랾 result;
			try
			{
				string text = 럳.랾(A_0);
				if (string.IsNullOrWhiteSpace(text))
				{
					result = null;
				}
				else
				{
					result = JsonSerializer.Deserialize<럜.랾>(text, null);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040002E2 RID: 738
		private static readonly string 랾 = Path.Combine(럧.량, "verify_attempt.dat");

		// Token: 0x040002E3 RID: 739
		private static readonly string 럎 = Path.Combine(럧.량, "verify_success.dat");

		// Token: 0x040002E4 RID: 740
		private static readonly string 람 = Path.Combine(럧.량, "hwid_verified.reg");

		// Token: 0x040002E5 RID: 741
		private const string 럒 = "Software\\CharonClient\\Verification";

		// Token: 0x040002E6 RID: 742
		private static readonly TimeSpan 랾 = TimeSpan.FromMinutes(2.0);

		// Token: 0x0200006B RID: 107
		private sealed class 랾
		{
			// Token: 0x060003DB RID: 987 RVA: 0x0003E743 File Offset: 0x0003C943
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0003E74B File Offset: 0x0003C94B
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060003DD RID: 989 RVA: 0x0003E754 File Offset: 0x0003C954
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x0003E75C File Offset: 0x0003C95C
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060003DF RID: 991 RVA: 0x0003E765 File Offset: 0x0003C965
			[CompilerGenerated]
			public long 람()
			{
				return this.랾;
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x0003E76D File Offset: 0x0003C96D
			[CompilerGenerated]
			public void 랾(long A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0003E776 File Offset: 0x0003C976
			[CompilerGenerated]
			public string 럒()
			{
				return this.람;
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0003E77E File Offset: 0x0003C97E
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x0003E787 File Offset: 0x0003C987
			[CompilerGenerated]
			public string 럼()
			{
				return this.럒;
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0003E78F File Offset: 0x0003C98F
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x040002E7 RID: 743
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040002E8 RID: 744
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040002E9 RID: 745
			[CompilerGenerated]
			private long 랾;

			// Token: 0x040002EA RID: 746
			[CompilerGenerated]
			private string 람;

			// Token: 0x040002EB RID: 747
			[CompilerGenerated]
			private string 럒;
		}
	}
}
