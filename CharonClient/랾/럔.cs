using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace 랾
{
	// Token: 0x02000050 RID: 80
	public static class 럔
	{
		// Token: 0x06000314 RID: 788 RVA: 0x0007CACC File Offset: 0x0007ACCC
		public static Task<HashSet<string>> 랾()
		{
			럔.랾 랾;
			랾.랾 = AsyncTaskMethodBuilder<HashSet<string>>.Create();
			랾.랾 = -1;
			랾.랾.Start<럔.랾>(ref 랾);
			return 랾.랾.Task;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0007CB08 File Offset: 0x0007AD08
		public static Task<bool> 럎()
		{
			럔.럎 럎;
			럎.랾 = AsyncTaskMethodBuilder<bool>.Create();
			럎.랾 = -1;
			럎.랾.Start<럔.럎>(ref 럎);
			return 럎.랾.Task;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0007CB44 File Offset: 0x0007AD44
		public static bool 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			object obj = 럔.랾;
			bool result;
			lock (obj)
			{
				result = 럔.랾.Contains(A_0);
			}
			return result;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		private static Dictionary<string, object> 람()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
			dictionary["presence_name"] = 럔.랋();
			return dictionary;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0007CB94 File Offset: 0x0007AD94
		private static bool 랾(out string A_0, out string A_1, out string A_2)
		{
			A_0 = string.Empty;
			A_1 = string.Empty;
			A_2 = string.Empty;
			string text;
			string text2;
			string text3;
			if (!럝.랾(out text, out text2, out text3))
			{
				return false;
			}
			A_0 = 럔.럎(text);
			A_1 = (((text2 != null) ? text2.Trim() : null) ?? string.Empty);
			A_2 = (((text3 != null) ? text3.Trim() : null) ?? string.Empty);
			return !string.IsNullOrWhiteSpace(A_0) && !string.IsNullOrWhiteSpace(A_1) && !string.IsNullOrWhiteSpace(A_2);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0007CC1C File Offset: 0x0007AE1C
		private static bool 랾(JsonElement A_0, string A_1)
		{
			JsonElement jsonElement;
			bool flag;
			return A_0.TryGetProperty(A_1, out jsonElement) && (jsonElement.ValueKind == JsonValueKind.True || (jsonElement.ValueKind == JsonValueKind.String && bool.TryParse(jsonElement.GetString(), out flag) && flag));
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0007CC60 File Offset: 0x0007AE60
		private static int 랾(JsonElement A_0, string A_1, int A_2)
		{
			JsonElement jsonElement;
			if (!A_0.TryGetProperty(A_1, out jsonElement))
			{
				return A_2;
			}
			int result;
			if (jsonElement.ValueKind == JsonValueKind.Number && jsonElement.TryGetInt32(out result))
			{
				return result;
			}
			if (jsonElement.ValueKind == JsonValueKind.String && int.TryParse(jsonElement.GetString(), out result))
			{
				return result;
			}
			return A_2;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0007CCB0 File Offset: 0x0007AEB0
		private static void 럒()
		{
			object obj = 럔.랾;
			lock (obj)
			{
				럔.랾.Clear();
				럔.럎 = 0;
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0007CCFC File Offset: 0x0007AEFC
		private static HashSet<string> 럼()
		{
			object obj = 럔.랾;
			HashSet<string> result;
			lock (obj)
			{
				result = new HashSet<string>(럔.랾, StringComparer.OrdinalIgnoreCase);
			}
			return result;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0007CD48 File Offset: 0x0007AF48
		private static void 랾(IEnumerable<string> A_0, int A_1)
		{
			object obj = 럔.랾;
			lock (obj)
			{
				럔.랾.Clear();
				foreach (string item in A_0)
				{
					럔.랾.Add(item);
				}
				럔.럎 = Math.Max(0, A_1);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0003E1C4 File Offset: 0x0003C3C4
		private static string 랋()
		{
			return ("User_" + 럦.랾(30)).Trim();
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0007CDD4 File Offset: 0x0007AFD4
		private static string 럎(string A_0)
		{
			string text = ((A_0 != null) ? A_0.Trim().ToUpperInvariant() : null) ?? string.Empty;
			if (text.Length != 64)
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x04000294 RID: 660
		public const float 랾 = 30f;

		// Token: 0x04000295 RID: 661
		private static readonly object 랾 = new object();

		// Token: 0x04000296 RID: 662
		private static int 랾;

		// Token: 0x04000297 RID: 663
		public static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000298 RID: 664
		public static int 럎 = 0;
	}
}
