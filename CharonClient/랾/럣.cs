using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace 랾
{
	// Token: 0x02000093 RID: 147
	internal static class 럣
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x0003F41A File Offset: 0x0003D61A
		public static bool 랾(byte[] A_0)
		{
			return A_0 != null && A_0.Length >= 6 && (A_0[0] == 71 && A_0[1] == 73 && A_0[2] == 70 && A_0[3] == 56 && (A_0[4] == 55 || A_0[4] == 57)) && A_0[5] == 97;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000961C4 File Offset: 0x000943C4
		public static List<럣.랾> 럎(byte[] A_0)
		{
			List<럣.랾> list = new List<럣.랾>();
			int i = 0;
			i = 6;
			int num = 럣.랾(A_0, ref i);
			int num2 = 럣.랾(A_0, ref i);
			byte b = A_0[i++];
			byte b2 = A_0[i++];
			i++;
			bool flag = (b & 128) > 0;
			int num3 = 1 << (int)((b & 7) + 1);
			byte[] array = null;
			if (flag)
			{
				array = new byte[num3 * 3];
				Array.Copy(A_0, i, array, 0, array.Length);
				i += array.Length;
			}
			byte[] array2 = new byte[num * num2 * 4];
			byte[] array3 = null;
			int num4 = 0;
			int num5 = -1;
			float 랾 = 100f;
			bool flag2 = false;
			while (i < A_0.Length)
			{
				byte b3 = A_0[i++];
				if (b3 == 59)
				{
					break;
				}
				if (b3 == 33)
				{
					if (A_0[i++] == 249)
					{
						i++;
						byte b4 = A_0[i++];
						num4 = (b4 >> 2 & 7);
						flag2 = ((b4 & 1) > 0);
						랾 = (float)럣.랾(A_0, ref i) * 10f;
						num5 = (int)(flag2 ? A_0[i++] : A_0[i++]);
						if (!flag2)
						{
							num5 = -1;
						}
						i++;
					}
					else
					{
						럣.럎(A_0, ref i);
					}
				}
				else
				{
					if (b3 != 44)
					{
						break;
					}
					int num6 = 럣.랾(A_0, ref i);
					int num7 = 럣.랾(A_0, ref i);
					int num8 = 럣.랾(A_0, ref i);
					int num9 = 럣.랾(A_0, ref i);
					byte b5 = A_0[i++];
					bool flag3 = (b5 & 128) > 0;
					bool flag4 = (b5 & 64) > 0;
					int num10 = flag3 ? (1 << (int)((b5 & 7) + 1)) : 0;
					byte[] array4 = null;
					if (flag3)
					{
						array4 = new byte[num10 * 3];
						Array.Copy(A_0, i, array4, 0, array4.Length);
						i += array4.Length;
					}
					byte[] array5 = array4 ?? array;
					if (num4 == 3)
					{
						array3 = new byte[array2.Length];
						Array.Copy(array2, array3, array2.Length);
					}
					int num11 = (int)A_0[i++];
					byte[] array6 = 럣.랾(A_0, ref i, num11, num8 * num9);
					int[] array7 = flag4 ? 럣.랾(num9) : null;
					for (int j = 0; j < num9; j++)
					{
						int num12 = flag4 ? array7[j] : j;
						for (int k = 0; k < num8; k++)
						{
							int num13 = num12 * num8 + k;
							if (num13 < array6.Length)
							{
								int num14 = (int)array6[num13];
								if (!flag2 || num14 != num5)
								{
									int num15 = num6 + k;
									int num16 = num7 + j;
									if (num15 < num && num16 < num2)
									{
										int num17 = num14 * 3;
										if (array5 != null && num17 + 2 < array5.Length)
										{
											int num18 = (num16 * num + num15) * 4;
											array2[num18] = array5[num17];
											array2[num18 + 1] = array5[num17 + 1];
											array2[num18 + 2] = array5[num17 + 2];
											array2[num18 + 3] = byte.MaxValue;
										}
									}
								}
							}
						}
					}
					byte[] array8 = new byte[num * num2 * 4];
					for (int l = 0; l < num2; l++)
					{
						int sourceIndex = l * num * 4;
						int destinationIndex = (num2 - 1 - l) * num * 4;
						Array.Copy(array2, sourceIndex, array8, destinationIndex, num * 4);
					}
					list.Add(new 럣.랾
					{
						랾 = num,
						럎 = num2,
						랾 = array8,
						랾 = 랾
					});
					if (num4 != 2)
					{
						if (num4 == 3)
						{
							if (array3 != null)
							{
								Array.Copy(array3, array2, array2.Length);
							}
						}
					}
					else
					{
						for (int m = 0; m < num9; m++)
						{
							for (int n = 0; n < num8; n++)
							{
								int num19 = num6 + n;
								int num20 = num7 + m;
								if (num19 < num && num20 < num2)
								{
									int num21 = (num20 * num + num19) * 4;
									array2[num21] = 0;
									array2[num21 + 1] = 0;
									array2[num21 + 2] = 0;
									array2[num21 + 3] = 0;
								}
							}
						}
					}
					num4 = 0;
					num5 = -1;
					랾 = 100f;
					flag2 = false;
				}
			}
			return list;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00096594 File Offset: 0x00094794
		private static byte[] 랾(byte[] A_0, ref int A_1, int A_2, int A_3)
		{
			럣.럎 럎;
			럎.럒 = A_2;
			List<byte> list = new List<byte>(A_3);
			List<byte> list2 = new List<byte>();
			while (A_1 < A_0.Length)
			{
				int i = A_1;
				A_1 = i + 1;
				int num = (int)A_0[i];
				if (num == 0)
				{
					break;
				}
				int num2 = 0;
				while (num2 < num && A_1 < A_0.Length)
				{
					List<byte> list3 = list2;
					i = A_1;
					A_1 = i + 1;
					list3.Add(A_0[i]);
					num2++;
				}
			}
			럎.랾 = list2.ToArray();
			럎.랋 = 0;
			int num3 = 1 << 럎.럒;
			럎.럎 = num3 + 1;
			럎.람 = 럎.럒 + 1;
			럎.럼 = (1 << 럎.람) - 1;
			럎.랾 = 0;
			int num4 = 4096;
			럎.랾 = new int[num4][];
			럣.랾(ref 럎);
			int num5 = 럣.럎(ref 럎);
			if (num5 == num3)
			{
				num5 = 럣.럎(ref 럎);
			}
			if (num5 != 럎.럎 && num5 < 럎.랾)
			{
				foreach (int num6 in 럎.랾[num5])
				{
					list.Add((byte)num6);
				}
				int num7 = num5;
				while (list.Count < A_3)
				{
					num5 = 럣.럎(ref 럎);
					if (num5 == 럎.럎)
					{
						break;
					}
					if (num5 == num3)
					{
						럣.랾(ref 럎);
						num5 = 럣.럎(ref 럎);
						if (num5 == 럎.럎 || num5 >= 럎.랾)
						{
							break;
						}
						foreach (int num8 in 럎.랾[num5])
						{
							list.Add((byte)num8);
						}
						num7 = num5;
					}
					else
					{
						int[] array2;
						if (num5 < 럎.랾)
						{
							array2 = 럎.랾[num5];
						}
						else
						{
							if (num5 != 럎.랾)
							{
								break;
							}
							int[] array3 = 럎.랾[num7];
							array2 = new int[array3.Length + 1];
							Array.Copy(array3, array2, array3.Length);
							array2[array3.Length] = array3[0];
						}
						foreach (int num9 in array2)
						{
							list.Add((byte)num9);
						}
						if (럎.랾 < num4)
						{
							int[] array4 = 럎.랾[num7];
							int[] array5 = new int[array4.Length + 1];
							Array.Copy(array4, array5, array4.Length);
							array5[array4.Length] = array2[0];
							int[][] 랾 = 럎.랾;
							int i = 럎.랾;
							럎.랾 = i + 1;
							랾[i] = array5;
							if (럎.랾 > 럎.럼 && 럎.람 < 12)
							{
								i = 럎.람;
								럎.람 = i + 1;
								럎.럼 = (1 << 럎.람) - 1;
							}
						}
						num7 = num5;
					}
				}
				return list.ToArray();
			}
			if (list.Count <= 0)
			{
				return new byte[A_3];
			}
			return list.ToArray();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0003F45A File Offset: 0x0003D65A
		private static int 랾(byte[] A_0, ref int A_1)
		{
			int result = (int)A_0[A_1] | (int)A_0[A_1 + 1] << 8;
			A_1 += 2;
			return result;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00096894 File Offset: 0x00094A94
		private static void 럎(byte[] A_0, ref int A_1)
		{
			while (A_1 < A_0.Length)
			{
				int num = A_1;
				A_1 = num + 1;
				int num2 = (int)A_0[num];
				if (num2 == 0)
				{
					break;
				}
				A_1 += num2;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000968C0 File Offset: 0x00094AC0
		private static int[] 랾(int A_0)
		{
			int[] array = new int[A_0];
			int num = 0;
			for (int i = 0; i < A_0; i += 8)
			{
				array[num++] = i;
			}
			for (int j = 4; j < A_0; j += 8)
			{
				array[num++] = j;
			}
			for (int k = 2; k < A_0; k += 4)
			{
				array[num++] = k;
			}
			for (int l = 1; l < A_0; l += 2)
			{
				array[num++] = l;
			}
			int[] array2 = new int[A_0];
			for (int m = 0; m < A_0; m++)
			{
				array2[array[m]] = m;
			}
			return array2;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00096958 File Offset: 0x00094B58
		[CompilerGenerated]
		internal static void 랾(ref 럣.럎 A_0)
		{
			A_0.랾 = A_0.럎 + 1;
			A_0.람 = A_0.럒 + 1;
			A_0.럼 = (1 << A_0.람) - 1;
			for (int i = 0; i < A_0.랾; i++)
			{
				A_0.랾[i] = new int[]
				{
					i
				};
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000969B8 File Offset: 0x00094BB8
		[CompilerGenerated]
		internal static int 럎(ref 럣.럎 A_0)
		{
			if (A_0.랋 + A_0.람 > A_0.랾.Length * 8)
			{
				return A_0.럎;
			}
			int num = A_0.랋 >> 3;
			int num2 = A_0.랋 & 7;
			int num3 = (int)A_0.랾[num];
			if (num + 1 < A_0.랾.Length)
			{
				num3 |= (int)A_0.랾[num + 1] << 8;
			}
			if (num + 2 < A_0.랾.Length)
			{
				num3 |= (int)A_0.랾[num + 2] << 16;
			}
			A_0.랋 += A_0.람;
			return num3 >> num2 & A_0.럼;
		}

		// Token: 0x02000094 RID: 148
		public class 랾
		{
			// Token: 0x04000519 RID: 1305
			public int 랾;

			// Token: 0x0400051A RID: 1306
			public int 럎;

			// Token: 0x0400051B RID: 1307
			public byte[] 랾;

			// Token: 0x0400051C RID: 1308
			public float 랾;
		}

		// Token: 0x02000095 RID: 149
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct 럎
		{
			// Token: 0x0400051D RID: 1309
			public int 랾;

			// Token: 0x0400051E RID: 1310
			public int 럎;

			// Token: 0x0400051F RID: 1311
			public int 람;

			// Token: 0x04000520 RID: 1312
			public int 럒;

			// Token: 0x04000521 RID: 1313
			public int 럼;

			// Token: 0x04000522 RID: 1314
			public int[][] 랾;

			// Token: 0x04000523 RID: 1315
			public int 랋;

			// Token: 0x04000524 RID: 1316
			public byte[] 랾;
		}
	}
}
