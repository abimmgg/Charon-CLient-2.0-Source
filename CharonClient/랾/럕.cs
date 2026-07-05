using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace 랾
{
	// Token: 0x0200006C RID: 108
	internal static class 럕
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x00080180 File Offset: 0x0007E380
		public static bool 랾(string A_0, string A_1)
		{
			if (!럕.랾.Contains(A_0))
			{
				return false;
			}
			if (string.IsNullOrWhiteSpace(A_1))
			{
				return false;
			}
			string value;
			string value2;
			string value3;
			bool result;
			if (!랖.랾(out value, out value2, out value3, out result))
			{
				return false;
			}
			string text = 럕.랾(럧.랪);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			try
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
				dictionary["hwid"] = value;
				dictionary["install_id"] = value2;
				dictionary["token"] = value3;
				dictionary["channel"] = A_0;
				dictionary["message"] = A_1;
				string text2 = JsonSerializer.Serialize<Dictionary<string, object>>(dictionary, null);
				if (!럚.랾(text, text2).람())
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0008024C File Offset: 0x0007E44C
		private static string 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return null;
			}
			string text = A_0.Trim();
			if (text.EndsWith("/verify", StringComparison.OrdinalIgnoreCase))
			{
				return text.Substring(0, text.Length - "/verify".Length) + "/log";
			}
			if (text.EndsWith("/", StringComparison.Ordinal))
			{
				return text + "log";
			}
			return text + "/log";
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000802C0 File Offset: 0x0007E4C0
		public static bool 랾(string A_0, string A_1, bool A_2 = false)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				if (A_2)
				{
					Environment.Exit(0);
				}
				return false;
			}
			bool result2;
			try
			{
				using (StringContent stringContent = new StringContent("{\"content\":\"" + 럕.럎(A_1) + "\"}", Encoding.UTF8, "application/json"))
				{
					HttpResponseMessage result = 럕.랾.PostAsync(A_0, stringContent).GetAwaiter().GetResult();
					if (!result.IsSuccessStatusCode && A_2)
					{
						Environment.Exit(0);
					}
					result2 = result.IsSuccessStatusCode;
				}
			}
			catch
			{
				if (A_2)
				{
					Environment.Exit(0);
				}
				result2 = false;
			}
			return result2;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00080370 File Offset: 0x0007E570
		private static string 럎(string A_0)
		{
			return (A_0 ?? string.Empty).Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("", "\\n").Replace("", "\\r").Replace("\t", "\\t");
		}

		// Token: 0x040002EC RID: 748
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"general",
			"security",
			"success",
			"tampering",
			"failure",
			"hwid-sender",
			"discord"
		};

		// Token: 0x040002ED RID: 749
		private static readonly HttpClient 랾 = new HttpClient();
	}
}
