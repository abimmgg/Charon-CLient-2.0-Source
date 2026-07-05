using System;

namespace 랾
{
	// Token: 0x0200005A RID: 90
	internal static class 랖
	{
		// Token: 0x06000357 RID: 855 RVA: 0x0007E1AC File Offset: 0x0007C3AC
		public static void 랾(string A_0, string A_1, string A_2)
		{
			object obj = 랖.랾;
			lock (obj)
			{
				if (!string.IsNullOrWhiteSpace(A_0))
				{
					랖.랾 = A_0.Trim();
				}
				if (!string.IsNullOrWhiteSpace(A_1))
				{
					랖.럎 = A_1.Trim();
				}
				if (!string.IsNullOrWhiteSpace(A_2))
				{
					랖.람 = A_2.Trim();
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0007E220 File Offset: 0x0007C420
		public static void 랾()
		{
			object obj = 랖.랾;
			lock (obj)
			{
				랖.랾 = null;
				랖.럎 = null;
				랖.람 = null;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0007E26C File Offset: 0x0007C46C
		public static bool 랾(out string A_0, out string A_1, out string A_2, out bool A_3)
		{
			string text = 럳.랾(럧.럑);
			string text2 = (text != null) ? text.Trim() : null;
			string text3 = 럳.랾(럧.럊);
			string text4 = (text3 != null) ? text3.Trim() : null;
			string 랱 = 럧.랱;
			string text5 = (랱 != null) ? 랱.Trim() : null;
			object obj = 랖.랾;
			string text6;
			string text7;
			string text8;
			lock (obj)
			{
				text6 = 랖.랾;
				text7 = 랖.럎;
				text8 = 랖.람;
			}
			A_0 = ((!string.IsNullOrWhiteSpace(text5)) ? text5 : text6);
			A_1 = ((!string.IsNullOrWhiteSpace(text2)) ? text2 : text7);
			A_2 = ((!string.IsNullOrWhiteSpace(text8)) ? text8 : text4);
			if (string.IsNullOrWhiteSpace(A_0) || string.IsNullOrWhiteSpace(A_1) || string.IsNullOrWhiteSpace(A_2))
			{
				A_3 = false;
				return false;
			}
			A_3 = false;
			if (string.IsNullOrWhiteSpace(text2))
			{
				럳.랾(럧.럑, A_1);
				A_3 = true;
			}
			if (string.IsNullOrWhiteSpace(text4))
			{
				럳.랾(럧.럊, A_2);
				A_3 = true;
			}
			obj = 랖.랾;
			lock (obj)
			{
				랖.랾 = A_0;
				랖.럎 = A_1;
				랖.람 = A_2;
			}
			return true;
		}

		// Token: 0x040002B3 RID: 691
		private static readonly object 랾 = new object();

		// Token: 0x040002B4 RID: 692
		private static string 랾;

		// Token: 0x040002B5 RID: 693
		private static string 럎;

		// Token: 0x040002B6 RID: 694
		private static string 람;
	}
}
