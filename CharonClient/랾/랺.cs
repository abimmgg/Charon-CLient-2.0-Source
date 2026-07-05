using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CharonClient.Configuration;

namespace 랾
{
	// Token: 0x02000072 RID: 114
	internal static class 랺
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x00082574 File Offset: 0x00080774
		public static void 랾(string A_0, string A_1, string A_2, string A_3)
		{
			if (!ConfigFile.chatLoggerToggle)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 5);
			defaultInterpolatedStringHandler.AppendLiteral("Time: ");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now);
			defaultInterpolatedStringHandler.AppendLiteral(" Player: ");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(" PlayerID: ");
			defaultInterpolatedStringHandler.AppendFormatted(A_1);
			defaultInterpolatedStringHandler.AppendLiteral(" World: ");
			defaultInterpolatedStringHandler.AppendFormatted(A_2);
			defaultInterpolatedStringHandler.AppendLiteral(" Message: ");
			defaultInterpolatedStringHandler.AppendFormatted(A_3);
			string item = defaultInterpolatedStringHandler.ToStringAndClear();
			object obj = 랺.랾;
			lock (obj)
			{
				랺.랾.Add(item);
				if (랺.랾.Count >= 50 || DateTime.Now - 랺.랾 >= 랺.랾)
				{
					랺.럎();
				}
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00082668 File Offset: 0x00080868
		public static void 랾()
		{
			object obj = 랺.랾;
			lock (obj)
			{
				랺.럎();
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000826A8 File Offset: 0x000808A8
		private static void 럎()
		{
			if (랺.랾.Count == 0)
			{
				return;
			}
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Logger");
			string path = Path.Combine(text, "Chat Logger.txt");
			try
			{
				Directory.CreateDirectory(text);
				File.AppendAllText(path, string.Join(Environment.NewLine, 랺.랾) + Environment.NewLine);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error flushing chat log: " + ex.Message);
			}
			랺.랾.Clear();
			랺.랾 = DateTime.Now;
		}

		// Token: 0x04000301 RID: 769
		private static readonly List<string> 랾 = new List<string>();

		// Token: 0x04000302 RID: 770
		private static readonly object 랾 = new object();

		// Token: 0x04000303 RID: 771
		private static DateTime 랾 = DateTime.Now;

		// Token: 0x04000304 RID: 772
		private const int 랾 = 50;

		// Token: 0x04000305 RID: 773
		private static readonly TimeSpan 랾 = TimeSpan.FromSeconds(10.0);
	}
}
