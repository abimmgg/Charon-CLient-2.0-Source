using System;
using System.IO;
using System.Text;

namespace 랾
{
	// Token: 0x02000015 RID: 21
	internal static class 럙
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00071688 File Offset: 0x0006F888
		private static string 랾(string A_0)
		{
			byte[] array = Convert.FromBase64String(A_0);
			for (int i = 0; i < array.Length; i++)
			{
				byte[] array2 = array;
				int num = i;
				array2[num] ^= 90;
			}
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0003CDAD File Offset: 0x0003AFAD
		public static string 랾()
		{
			return 럙.랾("DjI/CS80GzYpNQgzKT8pFTQOMjUpPw0yNRw7MzYOMj8ZOzY2");
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0003CDB9 File Offset: 0x0003AFB9
		public static string 럎()
		{
			return 럙.랾("Mi4uKmB1dWtsa3RoaWt0aG5rdGtva3U=");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0003CDC5 File Offset: 0x0003AFC5
		public static string 람()
		{
			return 럙.랾("a2xrdGhpa3Robmt0a29r");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0003CDD1 File Offset: 0x0003AFD1
		public static string 럒()
		{
			return 럙.랾("a25ja21tY2tiYmpqbWltbmNiYg==");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0003CDDD File Offset: 0x0003AFDD
		public static string 럼()
		{
			return 럙.랾("CR8WHxkOegk/KDM7NhQvNzg/KHocCBUXeg0zNGloBRg7KT8YNTsoPg==");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0003CDE9 File Offset: 0x0003AFE9
		public static string 랋()
		{
			return 럙.랾("CR8WHxkOegk/KDM7NhQvNzg/KHocCBUXeg0zNGloBRgTFQk=");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0003CDF5 File Offset: 0x0003AFF5
		public static string 랉()
		{
			return 럙.랾("GTI7KDU0ehk2Mz80LnpyDTIzLj96Hig/KSlz");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0003CE01 File Offset: 0x0003B001
		public static bool 럐()
		{
			return File.Exists(럧.럑) && File.Exists(럧.럊);
		}

		// Token: 0x04000040 RID: 64
		public const int 랾 = 60;
	}
}
