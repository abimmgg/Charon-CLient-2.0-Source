using System;
using System.Collections.Generic;
using System.Text;

namespace 랾
{
	// Token: 0x02000058 RID: 88
	internal static class 랢
	{
		// Token: 0x0600034B RID: 843 RVA: 0x0007DD60 File Offset: 0x0007BF60
		public static int 랾()
		{
			object obj = 랢.랾;
			int result;
			lock (obj)
			{
				result = 랢.랾;
			}
			return result;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		public static void 랾(string A_0, string A_1)
		{
			string key;
			string text;
			if (!랢.랾(A_0, A_1, out key, out text))
			{
				return;
			}
			object obj = 랢.랾;
			lock (obj)
			{
				string a;
				if (!랢.랾.TryGetValue(key, out a) || !string.Equals(a, text, StringComparison.Ordinal))
				{
					랢.랾[key] = text;
					랢.랾++;
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0007DE1C File Offset: 0x0007C01C
		public static bool 랾(string A_0, out string A_1)
		{
			A_1 = string.Empty;
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			object obj = 랢.랾;
			bool result;
			lock (obj)
			{
				result = 랢.랾.TryGetValue(A_0.Trim(), out A_1);
			}
			return result;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0007DE7C File Offset: 0x0007C07C
		private static bool 랾(string A_0, string A_1, out string A_2, out string A_3)
		{
			A_2 = ((A_0 == null) ? string.Empty : A_0.Trim());
			A_3 = 랢.랾(A_1).Trim();
			return !string.IsNullOrWhiteSpace(A_2) && !string.IsNullOrWhiteSpace(A_3) && !string.Equals(A_2, A_3, StringComparison.Ordinal) && A_3.IndexOf("unknown", StringComparison.OrdinalIgnoreCase) < 0;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0007DEE0 File Offset: 0x0007C0E0
		private static string 랾(string A_0)
		{
			if (string.IsNullOrEmpty(A_0))
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder(A_0.Length);
			bool flag = false;
			foreach (char c in A_0)
			{
				if (c == '<')
				{
					flag = true;
				}
				else if (c == '>')
				{
					flag = false;
				}
				else if (!flag)
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040002AD RID: 685
		private static readonly Dictionary<string, string> 랾 = new Dictionary<string, string>(StringComparer.Ordinal);

		// Token: 0x040002AE RID: 686
		private static readonly object 랾 = new object();

		// Token: 0x040002AF RID: 687
		private static int 랾;
	}
}
