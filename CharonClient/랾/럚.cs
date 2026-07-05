using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace 랾
{
	// Token: 0x02000055 RID: 85
	internal static class 럚
	{
		// Token: 0x0600033E RID: 830 RVA: 0x0007DA00 File Offset: 0x0007BC00
		public static 럚.랾 랾(string A_0, string A_1)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				throw new ArgumentException("URL must be provided.", "url");
			}
			Uri uri = new Uri(A_0);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Accept = "application/json,text/plain,*/*";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/135.0.0.0 Safari/537.36";
			httpWebRequest.ProtocolVersion = HttpVersion.Version11;
			httpWebRequest.KeepAlive = true;
			httpWebRequest.AutomaticDecompression = DecompressionMethods.None;
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.Timeout = 10000;
			httpWebRequest.ReadWriteTimeout = 10000;
			httpWebRequest.Headers["Accept-Language"] = "en-GB,en;q=0.9";
			httpWebRequest.Headers["X-Requested-With"] = "CharonClient";
			string leftPart = uri.GetLeftPart(UriPartial.Authority);
			httpWebRequest.Headers["Origin"] = leftPart;
			httpWebRequest.Referer = leftPart + "/";
			httpWebRequest.Headers["Sec-Fetch-Site"] = "same-origin";
			httpWebRequest.Headers["Sec-Fetch-Mode"] = "cors";
			httpWebRequest.Headers["Sec-Fetch-Dest"] = "empty";
			byte[] bytes = Encoding.UTF8.GetBytes(A_1 ?? string.Empty);
			httpWebRequest.ContentLength = (long)bytes.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			럚.랾 result;
			HttpWebResponse httpWebResponse2;
			object obj;
			WebException ex;
			bool flag;
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					result = 럚.랾(httpWebResponse);
				}
			}
			catch when (delegate
			{
				// Failed to create a 'catch-when' expression
				ex = (obj as WebException);
				if (ex == null)
				{
					flag = false;
				}
				else
				{
					httpWebResponse2 = (ex.Response as HttpWebResponse);
					flag = ((httpWebResponse2 != null) > false);
				}
				endfilter(flag);
			})
			{
				result = 럚.랾(httpWebResponse2);
			}
			return result;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0007DBEC File Offset: 0x0007BDEC
		private static 럚.랾 랾(HttpWebResponse A_0)
		{
			럚.랾 result;
			using (Stream responseStream = A_0.GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream ?? Stream.Null, Encoding.UTF8))
				{
					럚.랾 랾 = new 럚.랾();
					랾.랾((int)A_0.StatusCode);
					랾.랾(streamReader.ReadToEnd());
					result = 랾;
				}
			}
			return result;
		}

		// Token: 0x040002A8 RID: 680
		private const string 랾 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/135.0.0.0 Safari/537.36";

		// Token: 0x040002A9 RID: 681
		private const string 럎 = "application/json,text/plain,*/*";

		// Token: 0x040002AA RID: 682
		private const string 람 = "en-GB,en;q=0.9";

		// Token: 0x02000056 RID: 86
		internal sealed class 랾
		{
			// Token: 0x06000340 RID: 832 RVA: 0x0003E29C File Offset: 0x0003C49C
			[CompilerGenerated]
			public int 랾()
			{
				return this.랾;
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
			[CompilerGenerated]
			public void 랾(int A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0003E2AD File Offset: 0x0003C4AD
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x06000343 RID: 835 RVA: 0x0003E2B5 File Offset: 0x0003C4B5
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0007DC68 File Offset: 0x0007BE68
			public bool 람()
			{
				int num = this.랾();
				return num >= 200 && num <= 299;
			}

			// Token: 0x040002AB RID: 683
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x040002AC RID: 684
			[CompilerGenerated]
			private readonly string 랾;
		}
	}
}
