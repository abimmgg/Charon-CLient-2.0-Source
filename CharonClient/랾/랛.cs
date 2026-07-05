using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BasicTypes;
using CharonClient.Configuration;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x020000B0 RID: 176
	public class 랛
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x0009FB40 File Offset: 0x0009DD40
		private static bool[,] 랾()
		{
			int worldSizeX = 럓.랾.worldSizeX;
			int worldSizeY = 럓.랾.worldSizeY;
			if (랛.랾 == null || 랛.랾.GetLength(0) != worldSizeX || 랛.랾.GetLength(1) != worldSizeY)
			{
				랛.랾 = new bool[worldSizeX, worldSizeY];
			}
			else
			{
				Array.Clear(랛.랾, 0, 랛.랾.Length);
			}
			return 랛.랾;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0003F99B File Offset: 0x0003DB9B
		public static bool[,] 럎()
		{
			return new bool[럓.랾.worldSizeX, 럓.랾.worldSizeY];
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0003F9B6 File Offset: 0x0003DBB6
		private static bool 랾(int A_0, int A_1)
		{
			return A_0 >= 0 && A_0 < 럓.랾.worldSizeX && A_1 >= 0 && A_1 < 럓.랾.worldSizeY;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0009FBB0 File Offset: 0x0009DDB0
		public static World.BlockType 럎(int A_0, int A_1)
		{
			Vector2i vector2i;
			vector2i..ctor(럓.랾.playerStartPosition.x, 럓.랾.playerStartPosition.y - 1);
			if (vector2i.x == A_0 && vector2i.y == A_1)
			{
				return 16;
			}
			return 럓.랾.GetBlockType(new Vector2i(A_0, A_1));
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0003F9DC File Offset: 0x0003DBDC
		public static bool 랾(World.BlockType A_0)
		{
			return ConfigData.IsBlockPlatform(A_0) || A_0 == 1384 || A_0 == 1373 || A_0 == 656 || A_0 == 3648 || A_0 == 956;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0009FC0C File Offset: 0x0009DE0C
		public static bool 랾(int A_0, int A_1, Vector2i A_2, bool A_3 = false, bool A_4 = false)
		{
			if (!랛.랾(A_0, A_1))
			{
				return false;
			}
			World.BlockType blockType = 랛.럎(A_0, A_1);
			if (!럓.랾.IsMapPointInWorld(new Vector2i(A_0, A_1)))
			{
				return false;
			}
			if (럓.랾.worldName == "MINEWORLD" && 랛.랾(blockType))
			{
				return true;
			}
			if (랛.랾(blockType))
			{
				bool flag = A_2.x == A_0 && A_2.y > A_1;
				bool flag2 = A_2.y <= A_1 || Math.Abs(A_2.x - A_0) > 0;
				bool flag3 = flag && !flag2;
				if (!flag3 && A_2.y == A_1 + 1)
				{
					World.BlockType blockType2 = 랛.럎(A_0, A_1 + 1);
					if (!ConfigData.doesBlockHaveCollider[blockType2] && 랛.랾(blockType))
					{
						flag3 = true;
					}
				}
				return !flag3;
			}
			if (blockType == 4103 || blockType == 3966 || blockType == 3965)
			{
				return true;
			}
			if (blockType == 110 && (A_2.y < A_1 || A_2.x <= A_0 || A_2.x >= A_0))
			{
				return true;
			}
			if (blockType == 1499 || blockType == 3366)
			{
				return false;
			}
			if (ConfigData.IsAnyDoor(blockType) && ControllerHelper.worldController.DoesPlayerHaveRightToGoDoorForCollider(new Vector2i(A_0, A_1)))
			{
				return true;
			}
			if (ConfigData.IsBlockDisappearingBlock(blockType) || ConfigData.IsBlockBattleBarrier(blockType))
			{
				try
				{
					WorldItemBase worldItemData = 럓.랾.GetWorldItemData(new Vector2i(A_0, A_1));
					if (worldItemData != null)
					{
						BSONObject asBSON = worldItemData.GetAsBSON();
						if (asBSON != null && asBSON.ContainsKey("isOpen") && asBSON["isOpen"].boolValue)
						{
							return true;
						}
					}
				}
				catch
				{
				}
			}
			return blockType == 1420 || blockType == 4286 || blockType == 4366 || blockType == 4372 || !ConfigData.doesBlockHaveCollider[blockType];
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0003FA10 File Offset: 0x0003DC10
		public static List<랛.랾> 랾(Vector2i A_0, Vector2i A_1, bool[,] A_2)
		{
			return 랛.랾(A_0, A_1, false);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0003FA1A File Offset: 0x0003DC1A
		public static List<랛.랾> 럎(Vector2i A_0, Vector2i A_1, bool[,] A_2)
		{
			return 랛.랾(A_0, A_1, true);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0003FA24 File Offset: 0x0003DC24
		private static List<랛.랾> 랾(Vector2i A_0, Vector2i A_1, bool A_2)
		{
			return 랛.럎(A_0, A_1, A_2);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0009FDF4 File Offset: 0x0009DFF4
		private static List<랛.랾> 럎(Vector2i A_0, Vector2i A_1, bool A_2)
		{
			bool[,] array = 랛.랾();
			SortedSet<ValueTuple<float, int, 랛.랾>> sortedSet = new SortedSet<ValueTuple<float, int, 랛.랾>>(Comparer<ValueTuple<float, int, 랛.랾>>.Create(new Comparison<ValueTuple<float, int, 랛.랾>>(랛.람.랾.랾)));
			랛.랾 item = new 랛.랾(A_0.x, A_0.y, null);
			sortedSet.Add(new ValueTuple<float, int, 랛.랾>(랛.랾(A_0.x, A_0.y, A_1.x, A_1.y), 0, item));
			array[A_0.x, A_0.y] = true;
			int num = 1;
			while (sortedSet.Count > 0)
			{
				랛.랾 item2 = sortedSet.Min.Item3;
				sortedSet.Remove(sortedSet.Min);
				if (item2.랾 == A_1.x && item2.럎 == A_1.y)
				{
					return 랛.랾(item2);
				}
				Vector2i vector2i;
				vector2i..ctor(item2.랾, item2.럎);
				for (int i = 0; i < 4; i++)
				{
					int num2 = item2.랾 + 랛.람[i];
					int num3 = item2.럎 + 랛.럒[i];
					if (랛.랾(num2, num3) && !array[num2, num3])
					{
						World.BlockType blockType = 랛.럎(num2, num3);
						if (!랛.랾(num2, num3, vector2i, false, A_2))
						{
							if (!랛.랾(blockType))
							{
								array[num2, num3] = true;
							}
						}
						else
						{
							array[num2, num3] = true;
							float num4 = 1f;
							float num5 = 랛.랾(num2, num3, A_1.x, A_1.y);
							sortedSet.Add(new ValueTuple<float, int, 랛.랾>(num4 + num5, num++, new 랛.랾(num2, num3, item2)));
						}
					}
				}
			}
			return new List<랛.랾>();
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0003FA2E File Offset: 0x0003DC2E
		private static float 랾(int A_0, int A_1, int A_2, int A_3)
		{
			return (float)(Math.Abs(A_0 - A_2) + Math.Abs(A_1 - A_3));
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
		public static List<랛.랾> 랾(Vector2i A_0, Vector2i A_1)
		{
			bool[,] array = 랛.랾();
			SortedSet<ValueTuple<float, int, 랛.랾>> sortedSet = new SortedSet<ValueTuple<float, int, 랛.랾>>(Comparer<ValueTuple<float, int, 랛.랾>>.Create(new Comparison<ValueTuple<float, int, 랛.랾>>(랛.람.랾.럎)));
			랛.랾 item = new 랛.랾(A_0.x, A_0.y, null);
			sortedSet.Add(new ValueTuple<float, int, 랛.랾>(랛.랾(A_0.x, A_0.y, A_1.x, A_1.y), 0, item));
			array[A_0.x, A_0.y] = true;
			int num = 1;
			while (sortedSet.Count > 0)
			{
				랛.랾 item2 = sortedSet.Min.Item3;
				sortedSet.Remove(sortedSet.Min);
				if (item2.랾 == A_1.x && item2.럎 == A_1.y)
				{
					return 랛.랾(item2);
				}
				for (int i = 0; i < 4; i++)
				{
					int num2 = item2.랾 + 랛.람[i];
					int num3 = item2.럎 + 랛.럒[i];
					if (랛.랾(num2, num3) && !array[num2, num3] && 랛.람(num2, num3))
					{
						array[num2, num3] = true;
						World.BlockType blockType = 럓.랾.GetBlockType(new Vector2i(num2, num3));
						float num4 = Math.Max(1f, (float)랛.럎(blockType));
						float num5 = 랛.랾(num2, num3, A_1.x, A_1.y);
						sortedSet.Add(new ValueTuple<float, int, 랛.랾>(num4 + num5, num++, new 랛.랾(num2, num3, item2)));
					}
				}
			}
			return new List<랛.랾>();
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0003FA42 File Offset: 0x0003DC42
		private static bool 람(int A_0, int A_1)
		{
			return 랛.럎(럓.랾.GetBlockType(new Vector2i(A_0, A_1))) != 0;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000A0174 File Offset: 0x0009E374
		public static int 럎(World.BlockType A_0)
		{
			if (A_0 == null)
			{
				return 1;
			}
			if (A_0 != 3)
			{
				switch (A_0)
				{
				case 3980:
				case 3981:
				case 3982:
				case 3983:
				case 3984:
					return 2;
				case 3985:
				case 3986:
				case 3992:
					return 8;
				case 3988:
				case 3990:
				case 3993:
					return 16;
				case 3989:
				case 3994:
					return 3;
				case 3991:
					return 4;
				}
				return 1;
			}
			return 0;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000A01E4 File Offset: 0x0009E3E4
		private static List<랛.랾> 랾(랛.랾 A_0)
		{
			Stack<랛.랾> stack = new Stack<랛.랾>();
			for (랛.랾 랾 = A_0; 랾 != null; 랾 = 랾.랾)
			{
				stack.Push(랾);
			}
			List<랛.랾> list = new List<랛.랾>(stack.Count);
			while (stack.Count > 0)
			{
				list.Add(stack.Pop());
			}
			return list;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000A0230 File Offset: 0x0009E430
		public static int 랾(List<랛.랾> A_0)
		{
			int result = -1;
			float num = float.MaxValue;
			Vector3 currentPlayerPosition = 럓.랾.currentPlayerPosition;
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			for (int i = 0; i < A_0.Count; i++)
			{
				랛.랾 랾 = A_0[i];
				if (랛.랾(랾.랾, 랾.럎, currentPlayerMapPoint, false, false))
				{
					float num2 = Vector3.Distance(currentPlayerPosition, new Vector3((float)랾.랾, (float)랾.럎));
					if (num2 < num)
					{
						num = num2;
						result = i;
					}
				}
			}
			return result;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0003FA5D File Offset: 0x0003DC5D
		public static bool 랾(랛.랾 A_0, Vector2i A_1)
		{
			return A_0.랾 == A_1.x && A_0.럎 == A_1.y;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000A02BC File Offset: 0x0009E4BC
		private static bool 럎(랛.랾 A_0, Vector2i A_1)
		{
			World.BlockType blockType = 럓.랾.GetBlockType(new Vector2i(A_0.랾, A_0.럎));
			bool flag = 랛.랾(A_0.랾, A_0.럎, A_1, false, false);
			bool flag2 = ConfigData.DoesBlockHaveCollider(blockType) && blockType != 4103 && blockType != 3966;
			return flag && !flag2;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000A0320 File Offset: 0x0009E520
		public static List<랛.랾> 랾(List<랛.랾> A_0, Vector2i A_1)
		{
			List<랛.랾> list = new List<랛.랾>();
			if (A_0 == null || A_0.Count == 0)
			{
				return list;
			}
			Vector2i vector2i = A_1;
			for (int i = 0; i < A_0.Count; i++)
			{
				랛.랾 랾 = A_0[i];
				if (!랛.럎(랾, vector2i))
				{
					break;
				}
				list.Add(랾);
				vector2i..ctor(랾.랾, 랾.럎);
			}
			return list;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000A0380 File Offset: 0x0009E580
		public static int 럎(List<랛.랾> A_0, Vector2i A_1)
		{
			if (A_0 == null || A_0.Count == 0)
			{
				return 0;
			}
			int num = 0;
			Vector2i vector2i = A_1;
			for (int i = 0; i < A_0.Count; i++)
			{
				랛.랾 랾 = A_0[i];
				if (!랛.럎(랾, vector2i))
				{
					break;
				}
				num++;
				vector2i..ctor(랾.랾, 랾.럎);
			}
			return num;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000A03D8 File Offset: 0x0009E5D8
		public static float 람(List<랛.랾> A_0, Vector2i A_1)
		{
			if (A_0 == null || A_0.Count <= 1)
			{
				return 0f;
			}
			float num = 0f;
			Vector2i vector2i = A_1;
			Vector2i vector2i2;
			vector2i2..ctor(A_0[A_0.Count - 1].랾, A_0[A_0.Count - 1].럎);
			for (int i = 1; i < A_0.Count; i++)
			{
				랛.랾 랾 = A_0[i];
				num += 랛.랾(vector2i.x, vector2i.y, 랾.랾, 랾.럎, vector2i2);
				vector2i..ctor(랾.랾, 랾.럎);
			}
			return num;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000A0480 File Offset: 0x0009E680
		public static float 럎(List<랛.랾> A_0)
		{
			if (A_0 == null || A_0.Count <= 1)
			{
				return 0f;
			}
			float num = 0f;
			for (int i = 1; i < A_0.Count; i++)
			{
				int num2 = Math.Abs(A_0[i].랾 - A_0[i - 1].랾);
				int num3 = Math.Abs(A_0[i].럎 - A_0[i - 1].럎);
				num += ((num2 == 1 && num3 == 1) ? 1.4142135f : 1f);
			}
			return num;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000A0510 File Offset: 0x0009E710
		private static float 랾(int A_0, int A_1, int A_2, int A_3, Vector2i A_4)
		{
			Vector2i vector2i;
			vector2i..ctor(A_0, A_1);
			World.BlockType blockType = 럓.랾.GetBlockType(new Vector2i(A_2, A_3));
			bool flag = 랛.랾(A_2, A_3, vector2i, false, false);
			bool flag2 = ConfigData.DoesBlockHaveCollider(blockType) && blockType != 4103 && blockType != 3966;
			if (flag && !flag2)
			{
				return 1f;
			}
			int num = Math.Max(1, 랛.럎(blockType));
			float num2 = Math.Max(0.05f, 럺.랾(16, true));
			float num3 = Math.Max(0.05f, ConfigFile.autoMineBreakTimerMax) * (float)num;
			float num4 = Math.Max(2f, num3 / num2);
			if (A_2 == A_4.x && A_3 == A_4.y)
			{
				num4 *= 0.75f;
			}
			return num4;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000A05D4 File Offset: 0x0009E7D4
		// Note: this type is marked as 'beforefieldinit'.
		static 랛()
		{
			int[] array = new int[4];
			array[0] = -1;
			array[1] = 1;
			랛.람 = array;
			랛.럒 = new int[]
			{
				0,
				0,
				-1,
				1
			};
		}

		// Token: 0x04000587 RID: 1415
		private static readonly int[] 랾 = new int[]
		{
			-1,
			1,
			0,
			0,
			-1,
			1,
			1,
			-1
		};

		// Token: 0x04000588 RID: 1416
		private static readonly int[] 럎 = new int[]
		{
			0,
			0,
			-1,
			1,
			1,
			-1,
			1,
			-1
		};

		// Token: 0x04000589 RID: 1417
		private static readonly int[] 람;

		// Token: 0x0400058A RID: 1418
		private static readonly int[] 럒;

		// Token: 0x0400058B RID: 1419
		private static bool[,] 랾;

		// Token: 0x020000B1 RID: 177
		public class 랾
		{
			// Token: 0x06000699 RID: 1689 RVA: 0x0003FA7D File Offset: 0x0003DC7D
			public 랾(int A_1, int A_2, 랛.랾 A_3 = null)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.랾 = A_3;
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x000A0634 File Offset: 0x0009E834
			public override string ToString()
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.랾);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.럎);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x0003FA9A File Offset: 0x0003DC9A
			public Vector2 랾()
			{
				return ControllerHelper.worldController.ConvertMapPointToWorldPoint(new Vector2i(this.랾, this.럎));
			}

			// Token: 0x0400058C RID: 1420
			public int 랾;

			// Token: 0x0400058D RID: 1421
			public int 럎;

			// Token: 0x0400058E RID: 1422
			public 랛.랾 랾;
		}

		// Token: 0x020000B2 RID: 178
		private class 럎 : IComparable<랛.럎>
		{
			// Token: 0x0600069C RID: 1692 RVA: 0x0003FABC File Offset: 0x0003DCBC
			public 럎(랛.랾 A_1, float A_2, float A_3)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.럎 = A_3;
			}

			// Token: 0x0600069D RID: 1693 RVA: 0x0003FAD9 File Offset: 0x0003DCD9
			public int CompareTo(랛.럎 A_1)
			{
				return this.럎.CompareTo(A_1.럎);
			}

			// Token: 0x0400058F RID: 1423
			public 랛.랾 랾;

			// Token: 0x04000590 RID: 1424
			public float 랾;

			// Token: 0x04000591 RID: 1425
			public float 럎;
		}

		// Token: 0x020000B3 RID: 179
		[CompilerGenerated]
		[Serializable]
		private sealed class 람
		{
			// Token: 0x060006A0 RID: 1696 RVA: 0x000A0678 File Offset: 0x0009E878
			internal int 랾([TupleElementNames(new string[]
			{
				"f",
				"tiebreak",
				"node"
			})] ValueTuple<float, int, 랛.랾> a, [TupleElementNames(new string[]
			{
				"f",
				"tiebreak",
				"node"
			})] ValueTuple<float, int, 랛.랾> b)
			{
				int num = a.Item1.CompareTo(b.Item1);
				if (num == 0)
				{
					return a.Item2.CompareTo(b.Item2);
				}
				return num;
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x000A0678 File Offset: 0x0009E878
			internal int 럎([TupleElementNames(new string[]
			{
				"f",
				"tiebreak",
				"node"
			})] ValueTuple<float, int, 랛.랾> a, [TupleElementNames(new string[]
			{
				"f",
				"tiebreak",
				"node"
			})] ValueTuple<float, int, 랛.랾> b)
			{
				int num = a.Item1.CompareTo(b.Item1);
				if (num == 0)
				{
					return a.Item2.CompareTo(b.Item2);
				}
				return num;
			}

			// Token: 0x04000592 RID: 1426
			public static readonly 랛.람 랾 = new 랛.람();

			// Token: 0x04000593 RID: 1427
			[TupleElementNames(new string[]
			{
				"f",
				"tiebreak",
				"node"
			})]
			public static Comparison<ValueTuple<float, int, 랛.랾>> 랾;

			// Token: 0x04000594 RID: 1428
			[TupleElementNames(new string[]
			{
				"f",
				"tiebreak",
				"node"
			})]
			public static Comparison<ValueTuple<float, int, 랛.랾>> 럎;
		}
	}
}
