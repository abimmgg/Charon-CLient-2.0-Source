using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200004E RID: 78
	internal static class 랦
	{
		// Token: 0x0600030B RID: 779 RVA: 0x0007C83C File Offset: 0x0007AA3C
		internal static 랦.랾 랾()
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= 랦.랾)
			{
				return 랦.랾.럎;
			}
			if (utcNow >= 랦.럎.Add(랦.랾))
			{
				return 랦.랾.람;
			}
			if (랦.랾(utcNow))
			{
				return 랦.랾.럒;
			}
			return 랦.랾.랾;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0003E190 File Offset: 0x0003C390
		internal static bool 럎()
		{
			return 랦.랾() > 랦.랾.랾;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0007C884 File Offset: 0x0007AA84
		internal static bool 람()
		{
			랦.랾 랾 = 랦.랾();
			if (랾 == 랦.랾.랾)
			{
				랦.럎(DateTime.UtcNow);
				return false;
			}
			if (Interlocked.Exchange(ref 랦.랾, 1) != 0)
			{
				return true;
			}
			DateTime utcNow = DateTime.UtcNow;
			랾.ToString();
			랦.랋();
			return true;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0003E19A File Offset: 0x0003C39A
		internal static DateTime 럒()
		{
			return 랦.랾;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0003E1A1 File Offset: 0x0003C3A1
		internal static 랦.랾 럼()
		{
			return 랦.랾();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0007C8D0 File Offset: 0x0007AAD0
		private static bool 랾(DateTime A_0)
		{
			try
			{
				if (A_0 < 랦.럎)
				{
					return true;
				}
				DateTime t = 랦.람.Add(랦.랾.Elapsed).AddMinutes(-2.0);
				if (A_0 < t)
				{
					return true;
				}
				DateTime dateTime;
				if (File.Exists(랦.랾) && DateTime.TryParse(File.ReadAllText(랦.랾).Trim(), null, DateTimeStyles.RoundtripKind, out dateTime) && A_0 < dateTime.AddMinutes(-5.0))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0007C984 File Offset: 0x0007AB84
		private static void 럎(DateTime A_0)
		{
			try
			{
				string directoryName = Path.GetDirectoryName(랦.랾);
				if (!string.IsNullOrWhiteSpace(directoryName) && !Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(랦.랾, A_0.ToString("O"));
			}
			catch
			{
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0007C9E0 File Offset: 0x0007ABE0
		private static void 랋()
		{
			try
			{
				Application.Quit();
			}
			catch
			{
			}
			try
			{
				Environment.FailFast("Expiry enforcement triggered.");
			}
			catch
			{
			}
			try
			{
				Environment.Exit(1);
			}
			catch
			{
			}
			try
			{
				Process.GetCurrentProcess().Kill();
			}
			catch
			{
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly DateTime 랾 = new DateTime(2026, 10, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x04000289 RID: 649
		private static readonly DateTime 럎 = new DateTime(2026, 4, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x0400028A RID: 650
		private static readonly TimeSpan 랾 = TimeSpan.FromDays(183.0);

		// Token: 0x0400028B RID: 651
		private static readonly string 랾 = Path.Combine(Application.persistentDataPath, "DeathIsALullabyOfWhichICannotSing.dat");

		// Token: 0x0400028C RID: 652
		private static readonly Stopwatch 랾 = Stopwatch.StartNew();

		// Token: 0x0400028D RID: 653
		private static int 랾;

		// Token: 0x0400028E RID: 654
		private static DateTime 람 = DateTime.UtcNow;

		// Token: 0x0200004F RID: 79
		internal enum 랾
		{
			// Token: 0x04000290 RID: 656
			랾,
			// Token: 0x04000291 RID: 657
			럎,
			// Token: 0x04000292 RID: 658
			람,
			// Token: 0x04000293 RID: 659
			럒
		}
	}
}
