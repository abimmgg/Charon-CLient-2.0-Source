using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;

namespace 랾
{
	// Token: 0x0200007F RID: 127
	internal static class 럟
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x00086F60 File Offset: 0x00085160
		public static void 랾(Action A_0)
		{
			if (A_0 == null)
			{
				return;
			}
			object obj = 럟.랾;
			lock (obj)
			{
				럟.랾.Enqueue(A_0);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00086FA8 File Offset: 0x000851A8
		public static void 랾(Func<Task> A_0)
		{
			if (A_0 == null)
			{
				return;
			}
			object obj = 럟.랾;
			lock (obj)
			{
				럟.랾.Enqueue(A_0);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00086FF0 File Offset: 0x000851F0
		public static void 랾()
		{
			Action action;
			Func<Task> func;
			while (럟.랾(out action, out func))
			{
				try
				{
					if (action != null)
					{
						action();
						continue;
					}
					럟.럎(func);
					continue;
				}
				catch (Exception ex)
				{
					ManualLogSource manualLogSource = 럴.랾();
					if (manualLogSource != null)
					{
						bool flag;
						BepInExWarningLogInterpolatedStringHandler bepInExWarningLogInterpolatedStringHandler = new BepInExWarningLogInterpolatedStringHandler(21, 2, ref flag);
						if (flag)
						{
							bepInExWarningLogInterpolatedStringHandler.AppendLiteral("[MainThreadRunner] ");
							bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(ex.GetType().Name);
							bepInExWarningLogInterpolatedStringHandler.AppendLiteral(": ");
							bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(ex.Message);
						}
						manualLogSource.LogWarning(bepInExWarningLogInterpolatedStringHandler);
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0008708C File Offset: 0x0008528C
		private static Task 럎(Func<Task> A_0)
		{
			럟.랾 랾;
			랾.랾 = AsyncTaskMethodBuilder.Create();
			랾.랾 = A_0;
			랾.랾 = -1;
			랾.랾.Start<럟.랾>(ref 랾);
			return 랾.랾.Task;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000870D0 File Offset: 0x000852D0
		private static bool 랾(out Action A_0, out Func<Task> A_1)
		{
			object obj = 럟.랾;
			lock (obj)
			{
				if (럟.랾.Count > 0)
				{
					A_0 = 럟.랾.Dequeue();
					A_1 = null;
					return true;
				}
				if (럟.랾.Count > 0)
				{
					A_0 = null;
					A_1 = 럟.랾.Dequeue();
					return true;
				}
			}
			A_0 = null;
			A_1 = null;
			return false;
		}

		// Token: 0x0400049C RID: 1180
		private static readonly Queue<Action> 랾 = new Queue<Action>();

		// Token: 0x0400049D RID: 1181
		private static readonly Queue<Func<Task>> 랾 = new Queue<Func<Task>>();

		// Token: 0x0400049E RID: 1182
		private static readonly object 랾 = new object();
	}
}
