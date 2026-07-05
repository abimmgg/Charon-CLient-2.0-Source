using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace 랾
{
	// Token: 0x02000016 RID: 22
	internal static class 랫
	{
		// Token: 0x0600008E RID: 142 RVA: 0x000716C4 File Offset: 0x0006F8C4
		public static bool 랾(string A_0, string A_1, string A_2)
		{
			bool result;
			try
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
				dictionary["title"] = (A_1 ?? string.Empty);
				dictionary["message"] = (A_2 ?? string.Empty);
				using (StringContent stringContent = new StringContent(JsonSerializer.Serialize<Dictionary<string, string>>(dictionary, null), Encoding.UTF8, "application/json"))
				{
					result = 랫.랾.PostAsync(A_0, stringContent).GetAwaiter().GetResult().IsSuccessStatusCode;
				}
			}
			catch
			{
				럽.람("Failed to send webhook. You may have set it up incorrectly for fishing, mining, or whatever you selected.", false);
				result = false;
			}
			return result;
		}

		// Token: 0x04000041 RID: 65
		private static readonly HttpClient 랾 = new HttpClient();
	}
}
