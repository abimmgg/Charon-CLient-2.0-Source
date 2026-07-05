using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};

namespace 랾
{
	// Token: 0x0200003A RID: 58
	public static class 럫
	{
		// Token: 0x0600023F RID: 575 RVA: 0x00078470 File Offset: 0x00076670
		public static string 랾(string A_0)
		{
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				result = Convert.ToHexString(sha.ComputeHash(Encoding.UTF8.GetBytes(A_0 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()))).ToLowerInvariant();
			}
			return result;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000784C8 File Offset: 0x000766C8
		public static string 랾(string A_0, string A_1)
		{
			string result;
			using (HMACSHA256 hmacsha = new HMACSHA256(Encoding.UTF8.GetBytes(A_0 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮())))
			{
				result = Convert.ToHexString(hmacsha.ComputeHash(Encoding.UTF8.GetBytes(A_1 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()))).ToLowerInvariant();
			}
			return result;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00078534 File Offset: 0x00076734
		public static bool 랾(string A_0, long A_1, string A_2, string A_3, string A_4)
		{
			if (!string.Equals(럫.랾(A_0), A_2, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<long>(A_1);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted(A_2);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			return string.Equals(럫.랾(A_4, defaultInterpolatedStringHandler.ToStringAndClear()), A_3, StringComparison.OrdinalIgnoreCase);
		}
	}
}
