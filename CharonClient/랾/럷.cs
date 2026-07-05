using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ImGuiNET;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200008C RID: 140
	internal static class 럷
	{
		// Token: 0x060005A5 RID: 1445 RVA: 0x00095634 File Offset: 0x00093834
		public static bool 랾(string A_0)
		{
			럷.럎 럎;
			if (!럷.랾.TryGetValue(A_0, out 럎))
			{
				return false;
			}
			럷.랾 랾 = 럎.럎();
			return 랾 != null && 랾.랾 != IntPtr.Zero;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00095670 File Offset: 0x00093870
		public static IntPtr 럎(string A_0)
		{
			럷.럎 럎;
			if (!럷.랾.TryGetValue(A_0, out 럎))
			{
				return IntPtr.Zero;
			}
			럷.랾 랾 = 럎.럎();
			if (랾 == null)
			{
				return IntPtr.Zero;
			}
			return 랾.랾;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000956A8 File Offset: 0x000938A8
		[return: TupleElementNames(new string[]
		{
			"width",
			"height"
		})]
		public static ValueTuple<int, int> 람(string A_0)
		{
			럷.럎 럎;
			if (럷.랾.TryGetValue(A_0, out 럎))
			{
				럷.랾 랾 = 럎.럎();
				if (((랾 != null) ? 랾.랾 : null) != null)
				{
					return new ValueTuple<int, int>(랾.랾.width, 랾.랾.height);
				}
			}
			return new ValueTuple<int, int>(0, 0);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00095704 File Offset: 0x00093904
		public static int 럒(string A_0)
		{
			럷.럎 럎;
			if (!럷.랾.TryGetValue(A_0, out 럎))
			{
				return 0;
			}
			return 럎.랾.Count;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00095730 File Offset: 0x00093930
		public static bool 럼(string A_0)
		{
			럷.럎 럎;
			return 럷.랾.TryGetValue(A_0, out 럎) && 럎.랾();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00095754 File Offset: 0x00093954
		public static void 랾(string A_0, Vector2 A_1, bool A_2 = false)
		{
			if (!럷.랾(A_0))
			{
				return;
			}
			Vector2 vector = A_2 ? new Vector2(0f, 0f) : new Vector2(0f, 1f);
			Vector2 vector2 = A_2 ? new Vector2(1f, 1f) : new Vector2(1f, 0f);
			ImGui.Image(럷.럎(A_0), A_1, vector, vector2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000957C0 File Offset: 0x000939C0
		public static void 랾(string A_0, float A_1 = 0.5f, bool A_2 = false)
		{
			if (!럷.랾(A_0))
			{
				return;
			}
			ValueTuple<int, int> valueTuple = 럷.람(A_0);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			if (item == 0)
			{
				return;
			}
			float num = ImGui.GetContentRegionAvail().X * A_1;
			float y = num * ((float)item2 / (float)item);
			럷.랾(A_0, new Vector2(num, y), A_2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00095810 File Offset: 0x00093A10
		public static void 랾(string A_0, string A_1)
		{
			byte[] array = File.ReadAllBytes(A_1);
			if (럷.랾(array))
			{
				럷.람(A_0, array, A_1);
				return;
			}
			if (럷.럎(array))
			{
				럷.럎(A_0, array, A_1);
				return;
			}
			Console.WriteLine("[Charon] Unsupported image type: " + A_1);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0003F2C8 File Offset: 0x0003D4C8
		private static bool 랾(byte[] A_0)
		{
			return A_0.Length >= 6 && A_0[0] == 71 && A_0[1] == 73 && A_0[2] == 70 && A_0[3] == 56 && (A_0[4] == 55 || A_0[4] == 57) && A_0[5] == 97;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00095858 File Offset: 0x00093A58
		private static bool 럎(byte[] A_0)
		{
			return A_0.Length >= 8 && A_0[0] == 137 && A_0[1] == 80 && A_0[2] == 78 && A_0[3] == 71 && A_0[4] == 13 && A_0[5] == 10 && A_0[6] == 26 && A_0[7] == 10;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000958A8 File Offset: 0x00093AA8
		public static void 럎(string A_0, string A_1)
		{
			럷.랋 랋 = new 럷.랋();
			랋.랾 = A_1;
			if (럷.랾.ContainsKey(A_0))
			{
				return;
			}
			try
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
				string text = manifestResourceNames.FirstOrDefault(new Func<string, bool>(랋.랾)) ?? manifestResourceNames.FirstOrDefault(new Func<string, bool>(랋.럎));
				if (text == null)
				{
					Console.WriteLine("[Charon] Embedded resource not found");
				}
				else
				{
					using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text))
					{
						if (manifestResourceStream != null)
						{
							using (MemoryStream memoryStream = new MemoryStream())
							{
								manifestResourceStream.CopyTo(memoryStream);
								byte[] array = memoryStream.ToArray();
								럷.랾(A_0, array, 랋.랾);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("[Charon] Failed to load [" + A_0 + "]: " + ex.Message);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000959B8 File Offset: 0x00093BB8
		public static void 람(string A_0, string A_1)
		{
			if (럷.랾.ContainsKey(A_0))
			{
				return;
			}
			try
			{
				if (!File.Exists(A_1))
				{
					Console.WriteLine("[Charon] File not found: " + A_1);
				}
				else
				{
					byte[] array = File.ReadAllBytes(A_1);
					럷.랾(A_0, array, Path.GetFileName(A_1));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("[Charon] Failed to load [" + A_0 + "]: " + ex.Message);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0003F303 File Offset: 0x0003D503
		private static void 랾(string A_0, byte[] A_1, string A_2)
		{
			if (럣.랾(A_1))
			{
				럷.람(A_0, A_1, A_2);
				return;
			}
			럷.럎(A_0, A_1, A_2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00095A34 File Offset: 0x00093C34
		private static void 럎(string A_0, byte[] A_1, string A_2)
		{
			if (!럷.럎())
			{
				럷.랋(A_2);
				return;
			}
			Texture2D texture2D = new Texture2D(2, 2, 4, false);
			if (!ImageConversion.LoadImage(texture2D, A_1))
			{
				Console.WriteLine("[Charon] Failed to decode: " + A_2);
				return;
			}
			럷.럎 럎 = new 럷.럎();
			럎.랾.Add(new 럷.랾
			{
				랾 = texture2D,
				랾 = 0f
			});
			럷.랾[A_0] = 럎;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 4);
			defaultInterpolatedStringHandler.AppendLiteral("[Charon] Decoded [");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral("]: ");
			defaultInterpolatedStringHandler.AppendFormatted(A_2);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(texture2D.width);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(texture2D.height);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00095B28 File Offset: 0x00093D28
		private static void 람(string A_0, byte[] A_1, string A_2)
		{
			if (!럷.럎())
			{
				럷.랋(A_2);
				return;
			}
			if (A_1 == null || A_1.Length == 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[Charon] GIF load skipped [");
				defaultInterpolatedStringHandler.AppendFormatted(A_0);
				defaultInterpolatedStringHandler.AppendLiteral("]: no data (");
				defaultInterpolatedStringHandler.AppendFormatted(A_2);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			try
			{
				List<럣.랾> list = 럣.럎(A_1);
				if (list == null || list.Count == 0)
				{
					Console.WriteLine("[Charon] GIF decode returned no frames: " + A_2);
				}
				else
				{
					럷.럎 럎 = new 럷.럎();
					럎.랾.Capacity = list.Count;
					for (int i = 0; i < list.Count; i++)
					{
						럣.랾 랾 = list[i];
						if (((랾 != null) ? 랾.랾 : null) != null && 랾.랾.Length != 0)
						{
							Texture2D texture2D = new Texture2D(랾.랾, 랾.럎, 4, false);
							럷.랾(texture2D, 랾.랾);
							texture2D.Apply(false, true);
							럎.랾.Add(new 럷.랾
							{
								랾 = texture2D,
								랾 = ((랾.랾 > 0f) ? 랾.랾 : 100f)
							});
						}
					}
					if (럎.랾.Count == 0)
					{
						Console.WriteLine("[Charon] GIF decode produced no usable frames: " + A_2);
					}
					else
					{
						럷.랾[A_0] = 럎;
						럣.랾 랾2 = list[0];
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(30, 5);
						defaultInterpolatedStringHandler2.AppendLiteral("[Charon] GIF [");
						defaultInterpolatedStringHandler2.AppendFormatted(A_0);
						defaultInterpolatedStringHandler2.AppendLiteral("]: ");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(럎.랾.Count);
						defaultInterpolatedStringHandler2.AppendLiteral(" frames, ");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(랾2.랾);
						defaultInterpolatedStringHandler2.AppendLiteral("x");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(랾2.럎);
						defaultInterpolatedStringHandler2.AppendLiteral(" (");
						defaultInterpolatedStringHandler2.AppendFormatted(A_2);
						defaultInterpolatedStringHandler2.AppendLiteral(")");
						Console.WriteLine(defaultInterpolatedStringHandler2.ToStringAndClear());
					}
				}
			}
			catch (Exception value)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(31, 2);
				defaultInterpolatedStringHandler3.AppendLiteral("[Charon] GIF decode failed [");
				defaultInterpolatedStringHandler3.AppendFormatted(A_0);
				defaultInterpolatedStringHandler3.AppendLiteral("]: ");
				defaultInterpolatedStringHandler3.AppendFormatted<Exception>(value);
				Console.WriteLine(defaultInterpolatedStringHandler3.ToStringAndClear());
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00095DAC File Offset: 0x00093FAC
		private static void 랾(Texture2D A_0, byte[] A_1)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(A_1.Length);
			try
			{
				Marshal.Copy(A_1, 0, intPtr, A_1.Length);
				A_0.LoadRawTextureData(intPtr, A_1.Length);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00095DF0 File Offset: 0x00093FF0
		public static void 랾()
		{
			if (!럷.럎())
			{
				return;
			}
			float unscaledTime = Time.unscaledTime;
			float num = (unscaledTime - 럷.랾) * 1000f;
			럷.랾 = unscaledTime;
			foreach (KeyValuePair<string, 럷.럎> keyValuePair in 럷.랾)
			{
				럷.럎 value = keyValuePair.Value;
				foreach (럷.랾 랾 in value.랾)
				{
					if (!랾.랾 && !(랾.랾 == null))
					{
						랾.랾++;
						if (랾.랾 >= 90)
						{
							랾.랾 = true;
							럷.랾(keyValuePair.Key, 랾);
						}
					}
				}
				if (value.랾())
				{
					럷.랾 랾2 = value.럎();
					if (랾2 != null && !(랾2.랾 == IntPtr.Zero))
					{
						value.랾 += num;
						float num2 = 랾2.랾;
						if (num2 <= 0f)
						{
							num2 = 100f;
						}
						if (value.랾 >= num2)
						{
							value.랾 -= num2;
							value.랾 = (value.랾 + 1) % value.랾.Count;
							int num3 = value.랾;
							while (value.랾[value.랾].랾 == IntPtr.Zero)
							{
								value.랾 = (value.랾 + 1) % value.랾.Count;
								if (value.랾 == num3)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00095FE4 File Offset: 0x000941E4
		private static void 랾(string A_0, 럷.랾 A_1)
		{
			try
			{
				if (럷.럎())
				{
					A_1.랾.hideFlags = 61;
					IntPtr nativeTexturePtr = A_1.랾.GetNativeTexturePtr();
					if (nativeTexturePtr == IntPtr.Zero)
					{
						Console.WriteLine("[Charon] GetNativeTexturePtr null for [" + A_0 + "]");
					}
					else
					{
						IntPtr intPtr;
						Marshal.GetDelegateForFunctionPointer<럷.람>(Marshal.ReadIntPtr(Marshal.ReadIntPtr(nativeTexturePtr), 3 * IntPtr.Size))(nativeTexturePtr, out intPtr);
						if (intPtr == IntPtr.Zero)
						{
							Console.WriteLine("[Charon] GetDevice null for [" + A_0 + "]");
						}
						else
						{
							IntPtr intPtr2;
							int num = Marshal.GetDelegateForFunctionPointer<럷.럒>(Marshal.ReadIntPtr(Marshal.ReadIntPtr(intPtr), 7 * IntPtr.Size))(intPtr, nativeTexturePtr, IntPtr.Zero, out intPtr2);
							럷.랾(intPtr);
							if (num < 0 || intPtr2 == IntPtr.Zero)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
								defaultInterpolatedStringHandler.AppendLiteral("[Charon] CreateSRV failed for [");
								defaultInterpolatedStringHandler.AppendFormatted(A_0);
								defaultInterpolatedStringHandler.AppendLiteral("]: 0x");
								defaultInterpolatedStringHandler.AppendFormatted<int>(num, "X8");
								Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								럷.럎(intPtr2);
								럷.럎(nativeTexturePtr);
								A_1.랾 = intPtr2;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("[Charon] SRV failed for [" + A_0 + "]: " + ex.Message);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0003F31E File Offset: 0x0003D51E
		private static bool 럎()
		{
			return !Application.unityVersion.StartsWith("6000.", StringComparison.Ordinal);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00096158 File Offset: 0x00094358
		private static void 랋(string A_0)
		{
			if (럷.랾)
			{
				return;
			}
			럷.랾 = true;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Charon] Custom Unity texture loading disabled on Unity ");
			defaultInterpolatedStringHandler.AppendFormatted(Application.unityVersion);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0003F333 File Offset: 0x0003D533
		private static void 랾(IntPtr A_0)
		{
			if (A_0 == IntPtr.Zero)
			{
				return;
			}
			Marshal.GetDelegateForFunctionPointer<럷.럼>(Marshal.ReadIntPtr(Marshal.ReadIntPtr(A_0), 2 * IntPtr.Size))(A_0);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0003F361 File Offset: 0x0003D561
		private static void 럎(IntPtr A_0)
		{
			if (A_0 == IntPtr.Zero)
			{
				return;
			}
			Marshal.GetDelegateForFunctionPointer<럷.럼>(Marshal.ReadIntPtr(Marshal.ReadIntPtr(A_0), IntPtr.Size))(A_0);
		}

		// Token: 0x0400050C RID: 1292
		private static readonly Dictionary<string, 럷.럎> 랾 = new Dictionary<string, 럷.럎>();

		// Token: 0x0400050D RID: 1293
		private const int 랾 = 90;

		// Token: 0x0400050E RID: 1294
		private static float 랾 = 0f;

		// Token: 0x0400050F RID: 1295
		private static bool 랾;

		// Token: 0x0200008D RID: 141
		private class 랾
		{
			// Token: 0x04000510 RID: 1296
			public Texture2D 랾;

			// Token: 0x04000511 RID: 1297
			public IntPtr 랾 = IntPtr.Zero;

			// Token: 0x04000512 RID: 1298
			public bool 랾;

			// Token: 0x04000513 RID: 1299
			public int 랾;

			// Token: 0x04000514 RID: 1300
			public float 랾;
		}

		// Token: 0x0200008E RID: 142
		private class 럎
		{
			// Token: 0x060005BD RID: 1469 RVA: 0x0003F3B6 File Offset: 0x0003D5B6
			public bool 랾()
			{
				return this.랾.Count > 1;
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x0003F3C6 File Offset: 0x0003D5C6
			public 럷.랾 럎()
			{
				if (this.랾.Count <= 0)
				{
					return null;
				}
				return this.랾[this.랾];
			}

			// Token: 0x04000515 RID: 1301
			public List<럷.랾> 랾 = new List<럷.랾>();

			// Token: 0x04000516 RID: 1302
			public int 랾;

			// Token: 0x04000517 RID: 1303
			public float 랾;
		}

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060005C1 RID: 1473
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void 람(IntPtr, out IntPtr);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060005C5 RID: 1477
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int 럒(IntPtr, IntPtr, IntPtr, out IntPtr);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060005C9 RID: 1481
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint 럼(IntPtr);

		// Token: 0x02000092 RID: 146
		[CompilerGenerated]
		private sealed class 랋
		{
			// Token: 0x060005CD RID: 1485 RVA: 0x0003F3FC File Offset: 0x0003D5FC
			internal bool 랾(string A_1)
			{
				return A_1.Equals(this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x0003F40B File Offset: 0x0003D60B
			internal bool 럎(string A_1)
			{
				return A_1.EndsWith(this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000518 RID: 1304
			public string 랾;
		}
	}
}
