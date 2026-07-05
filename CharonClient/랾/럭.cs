using System;
using System.IO;
using System.Security.Cryptography;

namespace 랾
{
	// Token: 0x02000012 RID: 18
	public static class 럭
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00071544 File Offset: 0x0006F744
		public static string 랾(string A_0)
		{
			string result;
			using (FileStream fileStream = File.OpenRead(A_0))
			{
				using (SHA256 sha = SHA256.Create())
				{
					result = Convert.ToHexString(sha.ComputeHash(fileStream));
				}
			}
			return result;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0003CD6E File Offset: 0x0003AF6E
		public static bool 랾(string A_0, string A_1)
		{
			return File.Exists(A_0) && string.Equals(럭.랾(A_0), A_1, StringComparison.OrdinalIgnoreCase);
		}
	}
}
