using System;
using CharonClient.Configuration;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000096 RID: 150
	internal static class 랅
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x0003F46F File Offset: 0x0003D66F
		public static bool 랾()
		{
			return 랅.럎;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00096A5C File Offset: 0x00094C5C
		public static void 럎()
		{
			if (랅.랾)
			{
				return;
			}
			랅.랾 = true;
			try
			{
				랅.랾 = IL2CPP.ResolveICall<랅.랾>("UnityEngine.Input::GetKeyInt(UnityEngine.KeyCode)");
				랅.럎 = IL2CPP.ResolveICall<랅.랾>("UnityEngine.Input::GetKeyDownInt(UnityEngine.KeyCode)");
				랅.람 = IL2CPP.ResolveICall<랅.랾>("UnityEngine.Input::GetKeyUpInt(UnityEngine.KeyCode)");
				랅.랾 = IL2CPP.ResolveICall<랅.럎>("UnityEngine.Input::GetMouseButton(System.Int32)");
				랅.럎 = IL2CPP.ResolveICall<랅.럎>("UnityEngine.Input::GetMouseButtonDown(System.Int32)");
				랅.랾 = IL2CPP.ResolveICall<랅.람>("UnityEngine.Input::get_mousePosition_Injected(UnityEngine.Vector3&)");
				랅.럎 = (랅.랾 != null && 랅.럎 != null && 랅.람 != null && 랅.랾 != null && 랅.럎 != null && 랅.랾 != null);
				if (랅.럎)
				{
					Console.WriteLine("[Charon] InputSafe: Unity input primary, ICall fallback ready.");
				}
				else
				{
					Console.WriteLine("[Charon] InputSafe: Unity input primary, ICall fallback partially unavailable.");
				}
			}
			catch (Exception ex)
			{
				랅.럎 = false;
				Console.WriteLine("[Charon] InputSafe: Failed to resolve ICalls - " + ex.Message);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00096B54 File Offset: 0x00094D54
		public static bool 랾(KeyCode A_0)
		{
			if (랅.럒(A_0))
			{
				return false;
			}
			bool result;
			try
			{
				result = Input.GetKey(A_0);
			}
			catch
			{
				if (!랅.럎)
				{
					result = false;
				}
				else
				{
					try
					{
						result = 랅.랾(A_0);
					}
					catch
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00096BB4 File Offset: 0x00094DB4
		public static bool 럎(KeyCode A_0)
		{
			if (랅.럒(A_0))
			{
				return false;
			}
			bool result;
			try
			{
				result = Input.GetKeyDown(A_0);
			}
			catch
			{
				if (!랅.럎)
				{
					result = false;
				}
				else
				{
					try
					{
						result = 랅.럎(A_0);
					}
					catch
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00096C14 File Offset: 0x00094E14
		public static bool 람(KeyCode A_0)
		{
			if (랅.럒(A_0))
			{
				return false;
			}
			bool result;
			try
			{
				result = Input.GetKeyUp(A_0);
			}
			catch
			{
				if (!랅.럎)
				{
					result = false;
				}
				else
				{
					try
					{
						result = 랅.람(A_0);
					}
					catch
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00096C74 File Offset: 0x00094E74
		public static bool 랾(int A_0)
		{
			if (랅.럒())
			{
				return false;
			}
			bool result;
			try
			{
				result = Input.GetMouseButton(A_0);
			}
			catch
			{
				if (!랅.럎)
				{
					result = false;
				}
				else
				{
					try
					{
						result = 랅.랾(A_0);
					}
					catch
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00096CD4 File Offset: 0x00094ED4
		public static bool 럎(int A_0)
		{
			if (랅.럒())
			{
				return false;
			}
			bool result;
			try
			{
				result = Input.GetMouseButtonDown(A_0);
			}
			catch
			{
				if (!랅.럎)
				{
					result = false;
				}
				else
				{
					try
					{
						result = 랅.럎(A_0);
					}
					catch
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00096D34 File Offset: 0x00094F34
		public static Vector3 람()
		{
			Vector3 result;
			try
			{
				result = Input.mousePosition;
			}
			catch
			{
				if (!랅.럎)
				{
					result = Vector3.zero;
				}
				else
				{
					try
					{
						Vector3 vector;
						랅.랾(out vector);
						result = vector;
					}
					catch
					{
						result = Vector3.zero;
					}
				}
			}
			return result;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00096D90 File Offset: 0x00094F90
		private static bool 럒(KeyCode A_0)
		{
			bool result;
			try
			{
				if (A_0 == ConfigFile.menuToggleKey)
				{
					result = false;
				}
				else
				{
					result = 랉.럭();
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00096DC8 File Offset: 0x00094FC8
		private static bool 럒()
		{
			bool result;
			try
			{
				result = 랉.럯();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000525 RID: 1317
		private static 랅.랾 랾;

		// Token: 0x04000526 RID: 1318
		private static 랅.랾 럎;

		// Token: 0x04000527 RID: 1319
		private static 랅.랾 람;

		// Token: 0x04000528 RID: 1320
		private static 랅.럎 랾;

		// Token: 0x04000529 RID: 1321
		private static 랅.럎 럎;

		// Token: 0x0400052A RID: 1322
		private static 랅.람 랾;

		// Token: 0x0400052B RID: 1323
		private static bool 랾;

		// Token: 0x0400052C RID: 1324
		private static bool 럎;

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060005E3 RID: 1507
		private delegate bool 랾(KeyCode);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060005E7 RID: 1511
		private delegate bool 럎(int);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060005EB RID: 1515
		private delegate void 람(out Vector3);
	}
}
