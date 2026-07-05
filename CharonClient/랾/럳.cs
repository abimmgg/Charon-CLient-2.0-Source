using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace 랾
{
	// Token: 0x02000057 RID: 87
	internal static class 럳
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0007DC94 File Offset: 0x0007BE94
		public static void 랾(string A_0, string A_1)
		{
			try
			{
				럳.람(A_0);
				byte[] bytes = Encoding.UTF8.GetBytes(A_1 ?? string.Empty);
				byte[] bytes2;
				try
				{
					bytes2 = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
				}
				catch
				{
					bytes2 = bytes;
				}
				File.WriteAllBytes(A_0, bytes2);
				럳.럒(A_0);
			}
			catch
			{
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0007A4C8 File Offset: 0x000786C8
		public static string 랾(string A_0)
		{
			string result;
			try
			{
				if (!File.Exists(A_0))
				{
					result = null;
				}
				else
				{
					byte[] array = File.ReadAllBytes(A_0);
					if (array.Length == 0)
					{
						result = string.Empty;
					}
					else
					{
						try
						{
							byte[] bytes = ProtectedData.Unprotect(array, null, DataProtectionScope.CurrentUser);
							result = Encoding.UTF8.GetString(bytes);
						}
						catch
						{
							result = Encoding.UTF8.GetString(array);
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0007DCFC File Offset: 0x0007BEFC
		public static void 럎(string A_0)
		{
			try
			{
				if (File.Exists(A_0))
				{
					File.Delete(A_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0007DD2C File Offset: 0x0007BF2C
		private static void 람(string A_0)
		{
			string directoryName = Path.GetDirectoryName(A_0);
			if (string.IsNullOrWhiteSpace(directoryName))
			{
				return;
			}
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			럳.럒(directoryName);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0007A540 File Offset: 0x00078740
		private static void 럒(string A_0)
		{
			try
			{
				if (File.Exists(A_0) || Directory.Exists(A_0))
				{
					FileAttributes fileAttributes = File.GetAttributes(A_0);
					fileAttributes |= FileAttributes.Hidden;
					File.SetAttributes(A_0, fileAttributes);
				}
			}
			catch
			{
			}
		}
	}
}
