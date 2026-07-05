using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using BasicTypes;
using CharonClient.Configuration;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000110 RID: 272
	internal static class 랐
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x000408D2 File Offset: 0x0003EAD2
		public static int 랾()
		{
			return global::랾.랐.람;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000408D9 File Offset: 0x0003EAD9
		public static int 럎()
		{
			return global::랾.랐.럒;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000408E0 File Offset: 0x0003EAE0
		public static int 람()
		{
			return global::랾.랐.럼;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000408E7 File Offset: 0x0003EAE7
		public static int 럒()
		{
			return global::랾.랐.랋;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000408EE File Offset: 0x0003EAEE
		public static int 럼()
		{
			return global::랾.랐.랉;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000408F5 File Offset: 0x0003EAF5
		public static float 랋()
		{
			return global::랾.랐.럒;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000408FC File Offset: 0x0003EAFC
		public static string 랉()
		{
			return global::랾.랐.럎(global::랾.랐.랾);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000A982C File Offset: 0x000A7A2C
		public static void 럐()
		{
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return;
			}
			global::랾.랐.럒 += Time.deltaTime;
			global::랾.랐.람 += Time.deltaTime;
			global::랾.랐.럣();
			switch (global::랾.랐.랾)
			{
			case global::랾.랐.럒.랾:
				global::랾.랐.랖();
				return;
			case global::랾.랐.럒.럎:
				global::랾.랐.럝();
				return;
			case global::랾.랐.럒.람:
				global::랾.랐.럽();
				return;
			case global::랾.랐.럒.럒:
				global::랾.랐.럜();
				return;
			case global::랾.랐.럒.럼:
				global::랾.랐.럕();
				return;
			case global::랾.랐.럒.랋:
				global::랾.랐.럘();
				return;
			case global::랾.랐.럒.랉:
				global::랾.랐.랟();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000A98D4 File Offset: 0x000A7AD4
		public static void 랓()
		{
			global::랾.랐.랃();
			global::랾.랐.랾 = global::랾.랐.럒.랾;
			global::랾.랐.람 = 0f;
			global::랾.랐.럒 = 0f;
			global::랾.랐.럼 = 0f;
			global::랾.랐.럎 = 0;
			global::랾.랐.람 = 0;
			global::랾.랐.럒 = 0;
			global::랾.랐.럼 = 0;
			global::랾.랐.랋 = 0;
			global::랾.랐.랉 = 0;
			global::랾.랐.랾.Clear();
			global::랾.랐.럎 = global::랾.랐.랾;
			global::랾.랐.랾 = null;
			global::랾.랐.랾 = 0;
			global::랾.랐.랆();
			global::랾.랐.랾 = false;
			global::랾.랐.럎 = false;
			global::랾.랐.럸();
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000A996C File Offset: 0x000A7B6C
		public static string 럯()
		{
			string text = global::랾.랐.럎(global::랾.랐.랾);
			if (!string.IsNullOrWhiteSpace(global::랾.랐.랾))
			{
				return text + " | " + global::랾.랐.랾;
			}
			return text;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00040908 File Offset: 0x0003EB08
		public static int 럭()
		{
			return global::랾.랐.랾.Count;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000A99A4 File Offset: 0x000A7BA4
		public static string 랱()
		{
			if (!global::랾.랐.럒(global::랾.랐.람))
			{
				return "No target";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랐.랾);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.람.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.람.y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000A9A28 File Offset: 0x000A7C28
		public static string 럙()
		{
			if (!global::랾.랐.럒(global::랾.랐.럎))
			{
				return "Not set";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.럎.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.럎.y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00040914 File Offset: 0x0003EB14
		public static string 랫()
		{
			if (global::랾.랐.랾 != null)
			{
				return global::랾.랐.랾(global::랾.랐.랾);
			}
			return "No block selected";
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		public static string 럍()
		{
			World.BlockType blockType = global::랾.랐.랁();
			if (blockType != null)
			{
				return global::랾.랐.랾(blockType);
			}
			return "No block selected";
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000A9AC4 File Offset: 0x000A7CC4
		public static int 랬()
		{
			PlayerData playerData = global::랾.럓.랾;
			int? num;
			if (playerData == null)
			{
				num = null;
			}
			else
			{
				Il2CppStructArray<PlayerData.InventoryKey> inventoryAsOrderedByInventoryItemType = playerData.GetInventoryAsOrderedByInventoryItemType();
				num = ((inventoryAsOrderedByInventoryItemType != null) ? new int?(inventoryAsOrderedByInventoryItemType.Length) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0004092D File Offset: 0x0003EB2D
		public static int 란()
		{
			return global::랾.랐.럷().Count(new Func<PlayerData.InventoryKey, bool>(global::랾.랐.럼.랾.랾));
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00040958 File Offset: 0x0003EB58
		public static int 럇()
		{
			return global::랾.랐.럟().Count;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00040964 File Offset: 0x0003EB64
		public static bool 랯()
		{
			return global::랾.랐.랾;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0004096B File Offset: 0x0003EB6B
		public static void 랾(bool A_0)
		{
			global::랾.랐.랾 = A_0;
			if (A_0)
			{
				global::랾.랐.럎 = false;
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0004097C File Offset: 0x0003EB7C
		public static bool 러()
		{
			return global::랾.랐.럎;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00040983 File Offset: 0x0003EB83
		public static void 럎(bool A_0)
		{
			global::랾.랐.럎 = A_0;
			if (A_0)
			{
				global::랾.랐.랾 = false;
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00040994 File Offset: 0x0003EB94
		public static bool 량()
		{
			return global::랾.랐.럼(true);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0004099C File Offset: 0x0003EB9C
		public static bool 럑()
		{
			return global::랾.랐.럼(false);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000409A4 File Offset: 0x0003EBA4
		public static void 럊()
		{
			ConfigFile.autoFarmerRefillStorageWorldName = string.Empty;
			ConfigFile.autoFarmerRefillStorageX = -1;
			ConfigFile.autoFarmerRefillStorageY = -1;
			ConfigFile.autoFarmerPriorityBlockTypes = string.Empty;
			global::랾.랐.랾 = false;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000409CC File Offset: 0x0003EBCC
		public static void 랠()
		{
			ConfigFile.autoFarmerOutputStorageWorldName = string.Empty;
			ConfigFile.autoFarmerOutputStorageX = -1;
			ConfigFile.autoFarmerOutputStorageY = -1;
			global::랾.랐.럎 = false;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000409EA File Offset: 0x0003EBEA
		public static string 럏()
		{
			return global::랾.랐.랾(ConfigFile.autoFarmerRefillStorageWorldName, ConfigFile.autoFarmerRefillStorageX, ConfigFile.autoFarmerRefillStorageY);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00040A00 File Offset: 0x0003EC00
		public static string 럫()
		{
			return global::랾.랐.랾(ConfigFile.autoFarmerOutputStorageWorldName, ConfigFile.autoFarmerOutputStorageX, ConfigFile.autoFarmerOutputStorageY);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00040A16 File Offset: 0x0003EC16
		public static bool 럴()
		{
			return global::랾.랐.람(true);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00040A1E File Offset: 0x0003EC1E
		public static bool 럲()
		{
			return global::랾.랐.람(false);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00040A26 File Offset: 0x0003EC26
		public static bool 럩()
		{
			return global::랾.랐.략();
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00040A2D File Offset: 0x0003EC2D
		public static bool 랦()
		{
			return global::랾.랐.럵();
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000A9B0C File Offset: 0x000A7D0C
		public static int 럔()
		{
			HashSet<Vector2i> hashSet = new HashSet<Vector2i>();
			Vector2i vector2i = default(Vector2i);
			if (ConfigFile.autoFarmerFarmAbove)
			{
				hashSet.Add(new Vector2i(vector2i.x, vector2i.y + 1));
				hashSet.Add(new Vector2i(vector2i.x, vector2i.y + 2));
				hashSet.Add(new Vector2i(vector2i.x - 1, vector2i.y + 1));
				hashSet.Add(new Vector2i(vector2i.x + 1, vector2i.y + 1));
				hashSet.Add(new Vector2i(vector2i.x - 1, vector2i.y + 2));
				hashSet.Add(new Vector2i(vector2i.x + 1, vector2i.y + 2));
			}
			if (ConfigFile.autoFarmerFarmBelow)
			{
				hashSet.Add(new Vector2i(vector2i.x - 1, vector2i.y - 1));
				hashSet.Add(new Vector2i(vector2i.x + 1, vector2i.y - 1));
				hashSet.Add(new Vector2i(vector2i.x, vector2i.y - 2));
				hashSet.Add(new Vector2i(vector2i.x - 1, vector2i.y - 2));
				hashSet.Add(new Vector2i(vector2i.x + 1, vector2i.y - 2));
			}
			if (ConfigFile.autoFarmerFarmLeft)
			{
				hashSet.Add(new Vector2i(vector2i.x - 1, vector2i.y));
				hashSet.Add(new Vector2i(vector2i.x - 2, vector2i.y));
				hashSet.Add(new Vector2i(vector2i.x - 2, vector2i.y + 1));
				hashSet.Add(new Vector2i(vector2i.x - 2, vector2i.y - 1));
			}
			if (ConfigFile.autoFarmerFarmRight)
			{
				hashSet.Add(new Vector2i(vector2i.x + 1, vector2i.y));
				hashSet.Add(new Vector2i(vector2i.x + 2, vector2i.y));
				hashSet.Add(new Vector2i(vector2i.x + 2, vector2i.y + 1));
				hashSet.Add(new Vector2i(vector2i.x + 2, vector2i.y - 1));
			}
			if (ConfigFile.autoFarmerFarmDiagonals)
			{
				hashSet.Add(new Vector2i(vector2i.x - 1, vector2i.y - 1));
				hashSet.Add(new Vector2i(vector2i.x + 1, vector2i.y - 1));
				hashSet.Add(new Vector2i(vector2i.x - 2, vector2i.y + 2));
				hashSet.Add(new Vector2i(vector2i.x + 2, vector2i.y + 2));
				hashSet.Add(new Vector2i(vector2i.x - 2, vector2i.y - 2));
				hashSet.Add(new Vector2i(vector2i.x + 2, vector2i.y - 2));
			}
			hashSet.Remove(new Vector2i(vector2i.x, vector2i.y - 1));
			return hashSet.Count;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00040A34 File Offset: 0x0003EC34
		public static IReadOnlyList<World.BlockType> 랞()
		{
			return global::랾.랐.랅();
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000A9E24 File Offset: 0x000A8024
		public static IReadOnlyList<랐.랾> 럚()
		{
			List<World.BlockType> list = new List<World.BlockType>();
			foreach (PlayerData.InventoryKey inventoryKey in global::랾.랐.럷())
			{
				if (global::랾.랐.랾(inventoryKey) && global::랾.럓.랾.GetCount(inventoryKey) > 0 && !list.Contains(inventoryKey.blockType))
				{
					list.Add(inventoryKey.blockType);
				}
			}
			foreach (ValueTuple<World.BlockType, int> valueTuple in global::랾.랐.랪())
			{
				World.BlockType item = valueTuple.Item1;
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			foreach (World.BlockType item2 in global::랾.랐.랅())
			{
				if (!list.Contains(item2))
				{
					list.Add(item2);
				}
			}
			World.BlockType blockType = global::랾.랐.랁();
			if (blockType != null && !list.Contains(blockType))
			{
				list.Add(blockType);
			}
			List<랐.랾> list2 = new List<랐.랾>(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				World.BlockType blockType2 = list[i];
				list2.Add(new 랐.랾(blockType2, global::랾.랐.람(blockType2), global::랾.랐.럎(blockType2)));
			}
			return list2;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000A9FAC File Offset: 0x000A81AC
		public static IReadOnlyList<랐.럎> 럳()
		{
			HashSet<World.BlockType> hashSet = new HashSet<World.BlockType>(global::랾.랐.랅());
			List<ValueTuple<World.BlockType, int>> list = global::랾.랐.랪();
			Dictionary<World.BlockType, int> dictionary = list.GroupBy(new Func<ValueTuple<World.BlockType, int>, World.BlockType>(global::랾.랐.럼.랾.랾)).ToDictionary(new Func<IGrouping<World.BlockType, ValueTuple<World.BlockType, int>>, World.BlockType>(global::랾.랐.럼.랾.랾), new Func<IGrouping<World.BlockType, ValueTuple<World.BlockType, int>>, int>(global::랾.랐.럼.랾.럎));
			List<World.BlockType> list2 = new List<World.BlockType>();
			foreach (World.BlockType item in global::랾.랐.랅())
			{
				if (!list2.Contains(item))
				{
					list2.Add(item);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				World.BlockType item2 = list[i].Item1;
				if (!list2.Contains(item2))
				{
					list2.Add(item2);
				}
			}
			List<랐.럎> list3 = new List<랐.럎>(list2.Count);
			for (int j = 0; j < list2.Count; j++)
			{
				World.BlockType blockType = list2[j];
				int num;
				list3.Add(new 랐.럎(blockType, dictionary.TryGetValue(blockType, out num) ? num : 0, global::랾.랐.람(blockType), hashSet.Contains(blockType)));
			}
			return list3;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000AA120 File Offset: 0x000A8320
		public static void 랾(World.BlockType A_0, bool A_1)
		{
			랐.럐 럐 = new 랐.럐();
			럐.랾 = A_0;
			if (럐.랾 == null)
			{
				return;
			}
			List<World.BlockType> list = global::랾.랐.랅();
			bool flag = list.Contains(럐.랾);
			if (A_1)
			{
				if (!flag)
				{
					list.Add(럐.랾);
				}
			}
			else if (flag)
			{
				list.RemoveAll(new Predicate<World.BlockType>(럐.랾));
			}
			global::랾.랐.랾(list);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000AA188 File Offset: 0x000A8388
		public static void 랾(int A_0, int A_1)
		{
			List<World.BlockType> list = global::랾.랐.랅();
			if (A_0 < 0 || A_0 >= list.Count || A_1 < 0 || A_1 >= list.Count || A_0 == A_1)
			{
				return;
			}
			World.BlockType item = list[A_0];
			list.RemoveAt(A_0);
			list.Insert(A_1, item);
			global::랾.랐.랾(list);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000A200C File Offset: 0x000A020C
		public static string 랾(World.BlockType A_0)
		{
			try
			{
				string blockTypeName = TextManager.GetBlockTypeName(A_0);
				if (!string.IsNullOrWhiteSpace(blockTypeName))
				{
					return blockTypeName;
				}
			}
			catch
			{
			}
			return A_0.ToString();
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000AA1D8 File Offset: 0x000A83D8
		public static bool 랢()
		{
			if (!global::랾.랐.랾 && !global::랾.랐.럎)
			{
				return false;
			}
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || Camera.main == null)
			{
				return false;
			}
			if (global::랾.랐.럨())
			{
				return false;
			}
			if (global::랾.랅.럎(1))
			{
				global::랾.랐.랾 = false;
				global::랾.랐.럎 = false;
				global::랾.럽.럒("Auto Farm storage picking cancelled.", true);
				return true;
			}
			if (!global::랾.랅.럎(0))
			{
				return false;
			}
			Vector2i vector2i;
			if (!global::랾.랐.랾(out vector2i))
			{
				return false;
			}
			bool flag = global::랾.랐.랾;
			string text;
			if (global::랾.랐.랾(vector2i, flag, out text))
			{
				global::랾.랐.랾 = false;
				global::랾.랐.럎 = false;
				global::랾.럽.럒(flag ? ("Auto Farm refill storage set to " + global::랾.랐.럏() + ".") : ("Auto Farm output storage set to " + global::랾.랐.럫() + "."), true);
			}
			else
			{
				global::랾.럽.럎(text, false);
			}
			return true;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00040A3B File Offset: 0x0003EC3B
		public static bool 럻()
		{
			return global::랾.럧.럆 || global::랾.랐.랾 || global::랾.랐.럎;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000AA2AC File Offset: 0x000A84AC
		private static void 랖()
		{
			global::랾.랐.럸();
			global::랾.랐.럎 = global::랾.랐.랛();
			global::랾.랐.럈();
			if (global::랾.랐.랾.Count == 0)
			{
				global::랾.랐.랾("Pick at least one farm direction first.");
				return;
			}
			if (!global::랾.랐.랾(out global::랾.랐.랾))
			{
				global::랾.랐.랾 = global::랾.랐.랁();
			}
			global::랾.랐.랾 = (global::랾.랐.랊() ? global::랾.랐.럒.랋 : global::랾.랐.럒.럎);
			global::랾.랐.람 = 0f;
			string text = "Auto Farm";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Auto Farm is ready with ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.랾.Count);
			defaultInterpolatedStringHandler.AppendLiteral(" spots.");
			global::랾.랃.랾(text, defaultInterpolatedStringHandler.ToStringAndClear(), 4f);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000AA360 File Offset: 0x000A8560
		private static void 럝()
		{
			if (global::랾.랐.람 < global::랾.랐.랴())
			{
				return;
			}
			global::랾.랐.람 = 0f;
			for (int i = 0; i < global::랾.랐.랾.Count; i++)
			{
				Vector2i vector2i = global::랾.랐.랾[i];
				World.BlockType blockType = global::랾.럓.랾.GetBlockType(vector2i);
				if (blockType != null && blockType != global::랾.랐.랾)
				{
					global::랾.랐.람(vector2i, "CLEAR BLOCK");
					global::랾.럽.랾(vector2i.x, vector2i.y);
					return;
				}
			}
			global::랾.랐.럸();
			global::랾.랐.랾 = global::랾.랐.럒.람;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000AA3E4 File Offset: 0x000A85E4
		private static void 럽()
		{
			if (global::랾.랐.럓())
			{
				if (global::랾.랐.랾(global::랾.랐.럒.랉))
				{
					return;
				}
				global::랾.랐.랾 = global::랾.랐.럒.랉;
				global::랾.랐.람 = 0f;
				return;
			}
			else if (global::랾.랐.랊())
			{
				if (global::랾.랐.랾(global::랾.랐.럒.랋))
				{
					return;
				}
				global::랾.랐.랾 = global::랾.랐.럒.랋;
				global::랾.랐.람 = 0f;
				return;
			}
			else
			{
				if (global::랾.랐.람 < global::랾.랐.럺())
				{
					return;
				}
				global::랾.랐.람 = 0f;
				World.BlockType blockType;
				if (!global::랾.랐.랾(out blockType))
				{
					global::랾.랐.랾("No farm blocks are available in your inventory or refill storage.");
					return;
				}
				if (blockType != global::랾.랐.랾)
				{
					global::랾.랐.랾 = blockType;
					global::랾.랐.랾 = global::랾.랐.럒.럎;
					return;
				}
				if (global::랾.랐.럧())
				{
					global::랾.랐.럸();
					global::랾.랐.랾 = global::랾.랐.럒.럼;
					return;
				}
				int i = 0;
				while (i < global::랾.랐.랾.Count)
				{
					Vector2i vector2i = global::랾.랐.랾[i];
					if (global::랾.럓.랾.GetBlockType(vector2i) == null && !global::랾.럓.랾.IsCollectableAmountFullInMapPoint(vector2i))
					{
						if (global::랾.랐.랾(vector2i))
						{
							global::랾.랐.람(vector2i, "PLACE BLOCK");
							global::랾.랐.람++;
							return;
						}
						return;
					}
					else
					{
						i++;
					}
				}
				if (global::랾.랐.랾.Any(new Func<Vector2i, bool>(global::랾.랐.럼.랾.랾)))
				{
					global::랾.랐.럸();
					global::랾.랐.랾 = global::랾.랐.럒.럒;
				}
				return;
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000AA518 File Offset: 0x000A8718
		private static void 럜()
		{
			if (global::랾.랐.럓())
			{
				if (global::랾.랐.랾(global::랾.랐.럒.랉))
				{
					return;
				}
				global::랾.랐.럸();
				global::랾.랐.랾 = global::랾.랐.럒.럼;
				return;
			}
			else if (global::랾.랐.랊())
			{
				if (global::랾.랐.랾(global::랾.랐.럒.랋))
				{
					return;
				}
				global::랾.랐.럸();
				global::랾.랐.랾 = global::랾.랐.럒.럼;
				return;
			}
			else
			{
				if (global::랾.랐.람 < global::랾.랐.랴())
				{
					return;
				}
				global::랾.랐.람 = 0f;
				for (int i = 0; i < global::랾.랐.랾.Count; i++)
				{
					Vector2i vector2i = global::랾.랐.랾[i];
					World.BlockType blockType = global::랾.럓.랾.GetBlockType(vector2i);
					if (blockType != null && (global::랾.랐.랾 != null || blockType == global::랾.랐.랾))
					{
						global::랾.랐.람(vector2i, "BREAK BLOCK");
						global::랾.럽.랾(vector2i.x, vector2i.y);
						global::랾.랐.럒++;
						return;
					}
				}
				global::랾.랐.럎++;
				global::랾.랐.럸();
				global::랾.랐.랾 = (global::랾.랐.럧() ? global::랾.랐.럒.럼 : global::랾.랐.럒.람);
				return;
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000AA604 File Offset: 0x000A8804
		private static void 럕()
		{
			if (global::랾.럧.럯)
			{
				return;
			}
			global::랾.랐.럼 += Time.deltaTime;
			if (global::랾.랐.럼 < 1f)
			{
				return;
			}
			global::랾.랐.럼 = 0f;
			Vector2i vector2i = global::랾.랐.랛();
			CollectableData collectableData = global::랾.랐.럎(vector2i);
			if (collectableData != null)
			{
				List<랛.랾> list = global::랾.랛.랾(vector2i, collectableData.mapPoint, global::랾.랛.럎());
				if (list != null && list.Count > 0)
				{
					global::랾.랐.람(collectableData.mapPoint, "COLLECT DROPS");
					global::랾.랐.랾(list);
					global::랾.랐.럼++;
					return;
				}
			}
			global::랾.랐.럎 = 0;
			if (global::랾.랐.럎(global::랾.랐.럎, "RETURN TO FARM"))
			{
				return;
			}
			global::랾.랐.럸();
			if (global::랾.랐.랾 != null)
			{
				global::랾.랐.랾 = global::랾.랐.랾.Value;
				global::랾.랐.랾 = null;
				global::랾.랐.람 = 0f;
				return;
			}
			if (global::랾.랐.럓())
			{
				global::랾.랐.랾 = global::랾.랐.럒.랉;
				global::랾.랐.람 = 0f;
				return;
			}
			if (global::랾.랐.랊())
			{
				global::랾.랐.랾 = global::랾.랐.럒.랋;
				global::랾.랐.람 = 0f;
				return;
			}
			global::랾.랐.랾 = global::랾.랐.럒.람;
			global::랾.랐.람 = 0f;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000AA720 File Offset: 0x000A8920
		private static void 럘()
		{
			World.BlockType blockType;
			if (!global::랾.랐.랾(out blockType))
			{
				global::랾.랐.랾("No refill blocks were found in the selected priority list.");
				return;
			}
			global::랾.랐.랾 = blockType;
			int num = global::랾.랐.람(blockType);
			Vector2i vector2i;
			WorldItemBase worldItemBase;
			IStorage storage;
			if (!global::랾.랐.랾(true, out vector2i, out worldItemBase, out storage))
			{
				if (num > 0)
				{
					global::랾.랐.랺();
					return;
				}
				global::랾.랐.랾("Refill storage is not available in this world.");
				return;
			}
			else
			{
				int num2 = 0;
				List<랐.람> list = global::랾.랐.럎(storage);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].럎().blockType == blockType)
					{
						num2 += (int)list[i].람();
					}
				}
				if (num2 <= 0)
				{
					if (num > 0)
					{
						global::랾.랐.랺();
						return;
					}
					global::랾.랐.랾("No more " + global::랾.랐.랾(blockType) + " left in the refill storage.");
					return;
				}
				else
				{
					int num3 = Math.Min(900, num + num2);
					if (num >= num3)
					{
						global::랾.랐.랺();
						return;
					}
					if (!global::랾.랐.랾(vector2i, "MOVE TO REFILL"))
					{
						return;
					}
					if (!global::랾.랐.랾(vector2i, worldItemBase, storage))
					{
						return;
					}
					if (global::랾.랐.람 < global::랾.랐.럠())
					{
						return;
					}
					global::랾.랐.람 = 0f;
					int num4 = Math.Max(1, num3 - num);
					int num5;
					if (global::랾.랐.랾(vector2i, worldItemBase, storage, blockType, num4, out num5))
					{
						global::랾.랐.랋++;
						if (global::랾.랐.람(blockType) >= num3 || num5 >= num4 || global::랾.랐.럎(blockType) <= 0)
						{
							global::랾.랐.랺();
						}
						return;
					}
					if (num > 0)
					{
						global::랾.랐.랺();
						return;
					}
					global::랾.랐.랾("No more " + global::랾.랐.랾(blockType) + " left in the refill storage.");
					return;
				}
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000AA8A8 File Offset: 0x000A8AA8
		private static void 랟()
		{
			List<ValueTuple<PlayerData.InventoryKey, int>> list = global::랾.랐.럟();
			if (list.Count == 0)
			{
				global::랾.랐.랺();
				return;
			}
			Vector2i vector2i;
			WorldItemBase worldItemBase;
			IStorage storage;
			if (!global::랾.랐.랾(false, out vector2i, out worldItemBase, out storage))
			{
				global::랾.랐.랾("Output storage is not available in this world.");
				return;
			}
			if (!global::랾.랐.랾(vector2i, "MOVE TO OUTPUT"))
			{
				return;
			}
			if (!global::랾.랐.랾(vector2i, worldItemBase, storage))
			{
				return;
			}
			if (global::랾.랐.람 < global::랾.랐.럠())
			{
				return;
			}
			global::랾.랐.람 = 0f;
			if (global::랾.랐.랾(vector2i, worldItemBase, storage, list))
			{
				global::랾.랐.랉++;
				return;
			}
			if (global::랾.랐.랬() >= global::랾.랐.럖())
			{
				global::랾.랐.랾("Output storage is full or cannot store the farm output.");
				return;
			}
			global::랾.랐.랺();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000AA948 File Offset: 0x000A8B48
		private static bool 랾(Vector2i A_0, WorldItemBase A_1, IStorage A_2, [TupleElementNames(new string[]
		{
			"Key",
			"AmountToDeposit"
		})] List<ValueTuple<PlayerData.InventoryKey, int>> outputCandidates)
		{
			for (int i = 0; i < outputCandidates.Count; i++)
			{
				ValueTuple<PlayerData.InventoryKey, int> valueTuple = outputCandidates[i];
				PlayerData.InventoryKey item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				if (item2 > 0 && A_2.IsAllowedToStoreItem(item))
				{
					InventoryItemBase inventoryData = global::랾.럓.랾.GetInventoryData(item);
					int num = global::랾.랐.랾(A_2, item);
					if (num >= 0 || A_2.GetNumberOfItems() < A_2.GetMaxNumberOfItems())
					{
						short num2 = (short)Math.Clamp(item2, 1, 32767);
						if (num >= 0)
						{
							A_2.AdjustAmountInStorage(num, num2);
						}
						else
						{
							A_2.AddItemToStorage(item, num2, inventoryData);
						}
						WorldItemBase worldItemBase = global::랾.랐.랾(A_2, A_1, A_0);
						global::랾.럓.랾.RemoveItemsFromInventory(item, num2);
						global::랾.랐.람(item);
						OutgoingMessages.SendMoveFromInventoryToStorageMessage(A_0, worldItemBase, 0);
						global::랾.랐.랾(worldItemBase);
						WorldController worldController = ControllerHelper.worldController;
						if (worldController != null)
						{
							worldController.AdjustStorageAfterClose(worldItemBase, A_0);
						}
						global::랾.랐.랆();
						global::랾.랐.람(A_0, "STORE OUTPUT");
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000AAA3C File Offset: 0x000A8C3C
		private static bool 랾(Vector2i A_0, WorldItemBase A_1, IStorage A_2, World.BlockType A_3, int A_4, out int A_5)
		{
			랐.랓 랓 = new 랐.랓();
			랓.랾 = A_3;
			A_5 = 0;
			if (A_4 <= 0)
			{
				return false;
			}
			while (A_4 > 0)
			{
				IEnumerable<랐.람> source = global::랾.랐.럎(A_2);
				Func<랐.람, bool> predicate;
				if ((predicate = 랓.랾) == null)
				{
					predicate = (랓.랾 = new Func<랐.람, bool>(랓.랾));
				}
				랐.람? 람 = source.Where(predicate).OrderByDescending(new Func<랐.람, short>(global::랾.랐.럼.랾.랾)).Cast<랐.람?>().FirstOrDefault<랐.람?>();
				if (람 == null)
				{
					break;
				}
				랐.람 value = 람.Value;
				short num = (short)Math.Clamp(Math.Min((int)value.람(), A_4), 1, 32767);
				global::랾.럓.랾.AddItemToInventory(value.럎(), num, value.럒());
				if (num >= value.람())
				{
					A_2.RemoveItemFromStorage(value.랾());
				}
				else
				{
					A_2.AdjustAmountInStorage(value.랾(), -num);
				}
				WorldItemBase worldItemBase = global::랾.랐.랾(A_2, A_1, A_0);
				OutgoingMessages.SendMoveFromStorageToInventoryMessage(A_0, worldItemBase, 0);
				global::랾.랐.랾(worldItemBase);
				WorldController worldController = ControllerHelper.worldController;
				if (worldController != null)
				{
					worldController.AdjustStorageAfterClose(worldItemBase, A_0);
				}
				A_5 += (int)num;
				A_4 -= (int)num;
			}
			if (A_5 > 0)
			{
				global::랾.랐.랆();
				global::랾.랐.람(A_0, "REFILL BLOCKS");
				return true;
			}
			return false;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000AAB90 File Offset: 0x000A8D90
		private static WorldItemBase 랾(IStorage A_0, WorldItemBase A_1, Vector2i A_2)
		{
			if (A_0 != null)
			{
				try
				{
					WorldItemBase worldItemBase = A_0.TryCast<WorldItemBase>();
					if (worldItemBase != null)
					{
						return worldItemBase;
					}
				}
				catch
				{
				}
			}
			try
			{
				World world = global::랾.럓.랾;
				WorldItemBase worldItemBase2 = (world != null) ? world.GetWorldItemData(A_2) : null;
				if (worldItemBase2 != null)
				{
					return worldItemBase2;
				}
			}
			catch
			{
			}
			return A_1;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000AABF4 File Offset: 0x000A8DF4
		private static bool 랾(Vector2i A_0, WorldItemBase A_1, PlayerData.InventoryKey A_2, short A_3)
		{
			if (A_3 <= 0 || A_1 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			int num = global::랾.랐.럎(A_2);
			if (num <= 0)
			{
				return false;
			}
			bool result;
			try
			{
				ItemStorageUI itemStorageUI = global::랾.랐.랐();
				MethodInfo methodInfo = global::랾.랐.럆();
				if (itemStorageUI == null || methodInfo == null)
				{
					result = false;
				}
				else
				{
					methodInfo.Invoke(itemStorageUI, new object[]
					{
						A_2,
						A_3
					});
					result = (global::랾.랐.럎(A_2) < num);
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000AAC84 File Offset: 0x000A8E84
		private static bool 랾(Vector2i A_0, WorldItemBase A_1, 랐.람 A_2, int A_3, out int A_4)
		{
			A_4 = 0;
			if (A_3 <= 0 || A_1 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			int num = global::랾.랐.럎(A_2.럎());
			bool result;
			try
			{
				ItemStorageUI itemStorageUI = global::랾.랐.랐();
				MethodInfo methodInfo = global::랾.랐.랄();
				if (itemStorageUI == null || methodInfo == null)
				{
					result = false;
				}
				else
				{
					if (methodInfo == global::랾.랐.람)
					{
						methodInfo.Invoke(itemStorageUI, new object[]
						{
							A_2.럎(),
							A_3,
							A_2.럒()
						});
					}
					else
					{
						methodInfo.Invoke(itemStorageUI, new object[]
						{
							A_2.럎(),
							A_3
						});
					}
					A_4 = Math.Max(0, global::랾.랐.럎(A_2.럎()) - num);
					result = (A_4 > 0);
				}
			}
			catch
			{
				A_4 = 0;
				result = false;
			}
			return result;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00040A52 File Offset: 0x0003EC52
		private static void 랺()
		{
			global::랾.랐.랆();
			if (global::랾.랐.럎(global::랾.랐.럎, "RETURN TO FARM"))
			{
				return;
			}
			global::랾.랐.럸();
			global::랾.랐.랾 = global::랾.랐.럒.람;
			global::랾.랐.람 = 0f;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000AAD78 File Offset: 0x000A8F78
		private static bool 랾(Vector2i A_0)
		{
			PlayerData.InventoryKey inventoryKey;
			if (!global::랾.랐.랾(global::랾.랐.랾, out inventoryKey))
			{
				if (global::랾.랐.럶())
				{
					global::랾.랐.랾 = global::랾.랐.럒.랋;
					global::랾.랐.람 = 0f;
					return false;
				}
				global::랾.랐.랾("You ran out of " + global::랾.랐.랾(global::랾.랐.랾) + ".");
				return false;
			}
			else
			{
				if (global::랾.럓.랾.GetCount(inventoryKey) > 0)
				{
					BSONObject bsonobject = new BSONObject();
					bsonobject["ID"] = new BSONValue("SB");
					bsonobject["x"] = new BSONValue(A_0.x);
					bsonobject["y"] = new BSONValue(A_0.y);
					bsonobject["BlockType"] = new BSONValue(global::랾.랐.랾);
					bsonobject["U"] = new BSONValue(global::랾.럓.랾.myPlayerData.playerId);
					OutgoingMessages.AddOneMessageToList(bsonobject);
					global::랾.럓.랾.RemoveItemsFromInventory(inventoryKey, 1);
					global::랾.랐.람(inventoryKey);
					return true;
				}
				if (global::랾.랐.럶())
				{
					global::랾.랐.랾 = global::랾.랐.럒.랋;
					global::랾.랐.람 = 0f;
					return false;
				}
				global::랾.랐.랾("You ran out of " + global::랾.랐.랾(global::랾.랐.랾) + ".");
				return false;
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000AAEA8 File Offset: 0x000A90A8
		private static void 럈()
		{
			랐.랋 랋 = new 랐.랋();
			global::랾.랐.랾.Clear();
			랋.랾 = global::랾.랐.럎;
			if (ConfigFile.autoFarmerFarmAbove)
			{
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x, 랋.랾.y + 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x, 랋.랾.y + 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 1, 랋.랾.y + 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 1, 랋.랾.y + 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 1, 랋.랾.y + 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 1, 랋.랾.y + 2));
			}
			if (ConfigFile.autoFarmerFarmBelow)
			{
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 1, 랋.랾.y - 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 1, 랋.랾.y - 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x, 랋.랾.y - 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 1, 랋.랾.y - 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 1, 랋.랾.y - 2));
			}
			if (ConfigFile.autoFarmerFarmLeft)
			{
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 1, 랋.랾.y));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 2, 랋.랾.y));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 2, 랋.랾.y + 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 2, 랋.랾.y - 1));
			}
			if (ConfigFile.autoFarmerFarmRight)
			{
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 1, 랋.랾.y));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 2, 랋.랾.y));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 2, 랋.랾.y + 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 2, 랋.랾.y - 1));
			}
			if (ConfigFile.autoFarmerFarmDiagonals)
			{
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 1, 랋.랾.y - 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 1, 랋.랾.y - 1));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 2, 랋.랾.y + 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 2, 랋.랾.y + 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x - 2, 랋.랾.y - 2));
				global::랾.랐.랾.Add(new Vector2i(랋.랾.x + 2, 랋.랾.y - 2));
			}
			global::랾.랐.랾.RemoveAll(new Predicate<Vector2i>(랋.랾));
			global::랾.랐.랾.RemoveAll(new Predicate<Vector2i>(global::랾.랐.럼.랾.럎));
			List<Vector2i> collection = global::랾.랐.랾.Distinct<Vector2i>().ToList<Vector2i>();
			global::랾.랐.랾.Clear();
			global::랾.랐.랾.AddRange(collection);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000AB35C File Offset: 0x000A955C
		private static bool 럧()
		{
			if (!global::랾.랐.랽())
			{
				return false;
			}
			for (int i = 0; i < global::랾.랐.랾.Count; i++)
			{
				if (global::랾.럓.랾.IsCollectableAmountFullInMapPoint(global::랾.랐.랾[i]))
				{
					return true;
				}
			}
			return global::랾.랐.럎 >= global::랾.랐.랮();
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00040A80 File Offset: 0x0003EC80
		private static bool 럓()
		{
			return global::랾.랐.랻() && global::랾.랐.랬() >= global::랾.랐.럖() && global::랾.랐.럟().Count > 0;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000AB3B0 File Offset: 0x000A95B0
		private static bool 랊()
		{
			if (global::랾.랐.랾 == null)
			{
				return true;
			}
			int num = global::랾.랐.람(global::랾.랐.랾);
			if (num > global::랾.랐.럅())
			{
				return false;
			}
			if (!global::랾.랐.럶())
			{
				return num <= 0;
			}
			return global::랾.랐.럎(global::랾.랐.랾) > 0 || num <= 0;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000AB400 File Offset: 0x000A9600
		private static bool 랾(out World.BlockType A_0)
		{
			A_0 = 0;
			List<World.BlockType> list = global::랾.랐.랅();
			if (list.Count > 0)
			{
				if (global::랾.랐.랾 != null && list.Contains(global::랾.랐.랾) && (global::랾.랐.람(global::랾.랐.랾) > 0 || global::랾.랐.럎(global::랾.랐.랾) > 0))
				{
					A_0 = global::랾.랐.랾;
					return true;
				}
				for (int i = 0; i < list.Count; i++)
				{
					World.BlockType blockType = list[i];
					if (global::랾.랐.람(blockType) > 0)
					{
						A_0 = blockType;
						return true;
					}
				}
				for (int j = 0; j < list.Count; j++)
				{
					World.BlockType blockType2 = list[j];
					if (global::랾.랐.럎(blockType2) > 0)
					{
						A_0 = blockType2;
						return true;
					}
				}
			}
			World.BlockType blockType3 = global::랾.랐.랁();
			if (blockType3 != null && global::랾.랐.람(blockType3) > 0)
			{
				A_0 = blockType3;
				return true;
			}
			if (blockType3 != null && global::랾.랐.럶() && global::랾.랐.럎(blockType3) > 0)
			{
				A_0 = blockType3;
				return true;
			}
			return false;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000AB4E0 File Offset: 0x000A96E0
		[return: TupleElementNames(new string[]
		{
			"Key",
			"AmountToDeposit"
		})]
		private static List<ValueTuple<PlayerData.InventoryKey, int>> 럟()
		{
			랐.랉 랉 = new 랐.랉();
			List<ValueTuple<PlayerData.InventoryKey, int>> list = new List<ValueTuple<PlayerData.InventoryKey, int>>();
			HashSet<World.BlockType> hashSet = global::랾.랐.럦();
			foreach (PlayerData.InventoryKey inventoryKey in global::랾.랐.럷())
			{
				int count = (int)global::랾.럓.랾.GetCount(inventoryKey);
				if (count > 0)
				{
					if (inventoryKey.itemType == 2)
					{
						list.Add(new ValueTuple<PlayerData.InventoryKey, int>(inventoryKey, count));
					}
					else if (hashSet.Contains(inventoryKey.blockType))
					{
						int num = (inventoryKey.blockType == global::랾.랐.랾) ? global::랾.랐.랰() : 0;
						int num2 = count - num;
						if (num2 > 0)
						{
							list.Add(new ValueTuple<PlayerData.InventoryKey, int>(inventoryKey, num2));
						}
					}
				}
			}
			랉.랾 = global::랾.랐.랅().Select(new Func<World.BlockType, int, ValueTuple<World.BlockType, int>>(global::랾.랐.럼.랾.랾)).ToDictionary(new Func<ValueTuple<World.BlockType, int>, World.BlockType>(global::랾.랐.럼.랾.람), new Func<ValueTuple<World.BlockType, int>, int>(global::랾.랐.럼.랾.럒));
			list.Sort(new Comparison<ValueTuple<PlayerData.InventoryKey, int>>(랉.랾));
			return list;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000AB63C File Offset: 0x000A983C
		private static HashSet<World.BlockType> 럦()
		{
			HashSet<World.BlockType> hashSet = new HashSet<World.BlockType>(global::랾.랐.랅());
			World.BlockType blockType = global::랾.랐.랁();
			if (blockType != null)
			{
				hashSet.Add(blockType);
			}
			if (global::랾.랐.랾 != null)
			{
				hashSet.Add(global::랾.랐.랾);
			}
			return hashSet;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000AB67C File Offset: 0x000A987C
		private static int 럎(World.BlockType A_0)
		{
			Vector2i vector2i;
			WorldItemBase worldItemBase;
			IStorage storage;
			if (!global::랾.랐.랾(true, out vector2i, out worldItemBase, out storage))
			{
				return 0;
			}
			int num = 0;
			List<랐.람> list = global::랾.랐.럎(storage);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].럎().blockType == A_0)
				{
					num += (int)list[i].람();
				}
			}
			return num;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000AB6E8 File Offset: 0x000A98E8
		[return: TupleElementNames(new string[]
		{
			"BlockType",
			"StorageAmount"
		})]
		private static List<ValueTuple<World.BlockType, int>> 랪()
		{
			List<ValueTuple<World.BlockType, int>> list = new List<ValueTuple<World.BlockType, int>>();
			Vector2i vector2i;
			WorldItemBase worldItemBase;
			IStorage storage;
			if (!global::랾.랐.랾(true, out vector2i, out worldItemBase, out storage))
			{
				return list;
			}
			List<랐.람> list2 = global::랾.랐.럎(storage);
			for (int i = 0; i < list2.Count; i++)
			{
				랐.람 람 = list2[i];
				if (global::랾.랐.랾(람.럎()))
				{
					list.Add(new ValueTuple<World.BlockType, int>(람.럎().blockType, (int)람.람()));
				}
			}
			return list;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000AB760 File Offset: 0x000A9960
		private static bool 랾(PlayerData.InventoryKey A_0)
		{
			bool result;
			try
			{
				result = (A_0.blockType != null && A_0.itemType == ConfigData.GetBlockTypeInventoryItemType(A_0.blockType) && A_0.itemType != 2);
			}
			catch
			{
				result = (A_0.blockType != null && A_0.itemType == 0);
			}
			return result;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00040AA6 File Offset: 0x0003ECA6
		private static List<PlayerData.InventoryKey> 럷()
		{
			PlayerData playerData = global::랾.럓.랾;
			List<PlayerData.InventoryKey> list;
			if (playerData == null)
			{
				list = null;
			}
			else
			{
				Il2CppStructArray<PlayerData.InventoryKey> inventoryAsOrderedByInventoryItemType = playerData.GetInventoryAsOrderedByInventoryItemType();
				list = ((inventoryAsOrderedByInventoryItemType != null) ? inventoryAsOrderedByInventoryItemType.ToList<PlayerData.InventoryKey>() : null);
			}
			return list ?? new List<PlayerData.InventoryKey>();
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000AB7C4 File Offset: 0x000A99C4
		private static int 람(World.BlockType A_0)
		{
			if (A_0 == null || global::랾.럓.랾 == null)
			{
				return 0;
			}
			int num = 0;
			foreach (PlayerData.InventoryKey inventoryKey in global::랾.랐.럷())
			{
				if (global::랾.랐.랾(inventoryKey, A_0))
				{
					num += Math.Max(0, (int)global::랾.럓.랾.GetCount(inventoryKey));
				}
			}
			if (num <= 0)
			{
				PlayerData.InventoryKey inventoryKey2 = global::랾.랐.럒(A_0);
				if (inventoryKey2.IsValid())
				{
					num = Math.Max(0, (int)global::랾.럓.랾.GetCount(inventoryKey2));
				}
			}
			return num;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000AB864 File Offset: 0x000A9A64
		private static bool 랾(World.BlockType A_0, out PlayerData.InventoryKey A_1)
		{
			A_1 = PlayerData.InventoryKey.GetNoneBlockKey();
			if (A_0 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			PlayerData.InventoryKey inventoryKey = global::랾.랐.럒(A_0);
			if (inventoryKey.IsValid() && global::랾.럓.랾.GetCount(inventoryKey) > 0)
			{
				A_1 = inventoryKey;
				return true;
			}
			foreach (PlayerData.InventoryKey inventoryKey2 in global::랾.랐.럷())
			{
				if (global::랾.랐.랾(inventoryKey2, A_0) && global::랾.럓.랾.GetCount(inventoryKey2) > 0)
				{
					A_1 = inventoryKey2;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00040ACE File Offset: 0x0003ECCE
		private static bool 랾(PlayerData.InventoryKey A_0, World.BlockType A_1)
		{
			return A_0.blockType == A_1 && A_0.itemType != 2 && (global::랾.랐.랾(A_0) || A_0.itemType == 0);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000AB914 File Offset: 0x000A9B14
		private static PlayerData.InventoryKey 럒(World.BlockType A_0)
		{
			if (A_0 == null)
			{
				return PlayerData.InventoryKey.GetNoneBlockKey();
			}
			PlayerData.InventoryItemType blockTypeInventoryItemType = ConfigData.GetBlockTypeInventoryItemType(A_0);
			return new PlayerData.InventoryKey(A_0, blockTypeInventoryItemType);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000AB938 File Offset: 0x000A9B38
		private static void 럣()
		{
			if (!string.IsNullOrWhiteSpace(ConfigFile.autoFarmerPriorityBlockTypes))
			{
				return;
			}
			List<ValueTuple<World.BlockType, int>> list = global::랾.랐.랪();
			if (list.Count == 0)
			{
				return;
			}
			global::랾.랐.랾(list.Select(new Func<ValueTuple<World.BlockType, int>, World.BlockType>(global::랾.랐.럼.랾.럼)).Distinct<World.BlockType>().ToList<World.BlockType>());
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000AB998 File Offset: 0x000A9B98
		private static List<World.BlockType> 랅()
		{
			List<World.BlockType> list = new List<World.BlockType>();
			string text = ConfigFile.autoFarmerPriorityBlockTypes ?? string.Empty;
			if (string.IsNullOrWhiteSpace(text))
			{
				return list;
			}
			string[] array = text.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
			for (int i = 0; i < array.Length; i++)
			{
				int num;
				if (int.TryParse(array[i], out num) && Enum.IsDefined(typeof(World.BlockType), num))
				{
					World.BlockType blockType = num;
					if (blockType != null && !list.Contains(blockType))
					{
						list.Add(blockType);
					}
				}
			}
			return list;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000ABA1C File Offset: 0x000A9C1C
		private static void 랾(List<World.BlockType> A_0)
		{
			ConfigFile.autoFarmerPriorityBlockTypes = string.Join(",", A_0.Where(new Func<World.BlockType, bool>(global::랾.랐.럼.랾.랾)).Distinct<World.BlockType>().Select(new Func<World.BlockType, string>(global::랾.랐.럼.랾.럎)));
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000ABA88 File Offset: 0x000A9C88
		private static World.BlockType 랁()
		{
			int autoFarmerSelectedBlockType = ConfigFile.autoFarmerSelectedBlockType;
			if (Enum.IsDefined(typeof(World.BlockType), autoFarmerSelectedBlockType))
			{
				World.BlockType blockType = autoFarmerSelectedBlockType;
				if (blockType != null)
				{
					return blockType;
				}
			}
			return 1;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000ABABC File Offset: 0x000A9CBC
		private static bool 랽()
		{
			World world = global::랾.럓.랾;
			if (((world != null) ? world.collectables : null) == null || global::랾.럓.랾.collectables.Count == 0)
			{
				return false;
			}
			foreach (CollectableData collectableData in global::랾.럓.랾.collectables)
			{
				if (collectableData != null && global::랾.랐.람(collectableData.mapPoint))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000ABB24 File Offset: 0x000A9D24
		private static bool 랡()
		{
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			for (int i = 0; i < global::랾.랐.랾.Count; i++)
			{
				if (global::랾.럓.랾.GetBlockType(global::랾.랐.랾[i]) != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000ABB6C File Offset: 0x000A9D6C
		private static bool 랾(랐.럒 A_0)
		{
			global::랾.랐.랾 = new 랐.럒?(A_0);
			if (global::랾.랐.랡())
			{
				global::랾.랐.럸();
				global::랾.랐.랾 = global::랾.랐.럒.럒;
				global::랾.랐.람 = 0f;
				return true;
			}
			if (global::랾.랐.랽())
			{
				global::랾.랐.럸();
				global::랾.랐.랾 = global::랾.랐.럒.럼;
				global::랾.랐.럼 = 0f;
				return true;
			}
			global::랾.랐.랾 = null;
			return false;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000ABBCC File Offset: 0x000A9DCC
		private static CollectableData 럎(Vector2i A_0)
		{
			World world = global::랾.럓.랾;
			if (((world != null) ? world.collectables : null) == null)
			{
				return null;
			}
			float num = float.MaxValue;
			CollectableData result = null;
			foreach (CollectableData collectableData in global::랾.럓.랾.collectables)
			{
				if (collectableData != null && global::랾.랐.람(collectableData.mapPoint) && global::랾.랛.랾(collectableData.mapPoint.x, collectableData.mapPoint.y, A_0, false, false) && !ConfigData.IsCollectableBlockedByColliderBlock(global::랾.럓.랾, collectableData.mapPoint))
				{
					float num2 = Vector2.Distance(global::랾.럽.랾(A_0), global::랾.럽.랾(collectableData.mapPoint));
					if (num2 < num)
					{
						num = num2;
						result = collectableData;
					}
				}
			}
			return result;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000ABC7C File Offset: 0x000A9E7C
		private static bool 람(Vector2i A_0)
		{
			if (global::랾.랐.랾.Count == 0)
			{
				return false;
			}
			int x = global::랾.랐.럎.x;
			int x2 = global::랾.랐.럎.x;
			int y = global::랾.랐.럎.y;
			int y2 = global::랾.랐.럎.y;
			for (int i = 0; i < global::랾.랐.랾.Count; i++)
			{
				Vector2i vector2i = global::랾.랐.랾[i];
				if (vector2i.x < x)
				{
					x = vector2i.x;
				}
				if (vector2i.x > x2)
				{
					x2 = vector2i.x;
				}
				if (vector2i.y < y)
				{
					y = vector2i.y;
				}
				if (vector2i.y > y2)
				{
					y2 = vector2i.y;
				}
			}
			return A_0.x >= x - 1 && A_0.x <= x2 + 1 && A_0.y >= y - 1 && A_0.y <= y2 + 1;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000ABD64 File Offset: 0x000A9F64
		private static bool 랾(Vector2i A_0, string A_1)
		{
			Vector2i vector2i = global::랾.랐.랛();
			if (Math.Abs(vector2i.x - A_0.x) <= 1 && Math.Abs(vector2i.y - A_0.y) <= 1)
			{
				return true;
			}
			if (global::랾.럧.럯)
			{
				global::랾.랐.람(A_0, A_1);
				return false;
			}
			List<랛.랾> list;
			if (!global::랾.랐.랾(A_0, vector2i, out list))
			{
				global::랾.랐.랾("Could not path to the selected storage.");
				return false;
			}
			global::랾.랐.람(A_0, A_1);
			global::랾.랐.랾(list);
			return false;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000ABDD8 File Offset: 0x000A9FD8
		private static bool 럎(Vector2i A_0, string A_1)
		{
			if (!global::랾.랐.럒(A_0))
			{
				return false;
			}
			Vector2i vector2i = global::랾.랐.랛();
			if (vector2i.x == A_0.x && vector2i.y == A_0.y)
			{
				return false;
			}
			if (global::랾.럧.럯)
			{
				global::랾.랐.람(A_0, A_1);
				return true;
			}
			List<랛.랾> list = global::랾.랛.랾(vector2i, A_0, global::랾.랛.럎());
			if (list == null || list.Count <= 1)
			{
				return false;
			}
			global::랾.랐.람(A_0, A_1);
			global::랾.랐.랾(list);
			return true;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000ABE4C File Offset: 0x000AA04C
		private static bool 랾(Vector2i A_0, Vector2i A_1, out List<랛.랾> A_2)
		{
			A_2 = null;
			int num = int.MaxValue;
			for (int i = 0; i < global::랾.랐.랾.Length; i++)
			{
				Vector2i vector2i;
				vector2i..ctor(A_0.x + global::랾.랐.랾[i].x, A_0.y + global::랾.랐.랾[i].y);
				if (global::랾.럓.랾.IsMapPointInWorld(vector2i) && global::랾.랛.랾(vector2i.x, vector2i.y, A_1, false, false))
				{
					List<랛.랾> list = global::랾.랛.랾(A_1, vector2i, global::랾.랛.럎());
					if (list != null && list.Count > 1 && list.Count < num)
					{
						num = list.Count;
						A_2 = list;
					}
				}
			}
			return A_2 != null;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00040AF7 File Offset: 0x0003ECF7
		private static void 랾(List<랛.랾> A_0)
		{
			if (A_0 == null || A_0.Count <= 1)
			{
				return;
			}
			global::랾.럺.랾(A_0, false);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00040B0E File Offset: 0x0003ED0E
		private static void 랃()
		{
			global::랾.럧.랾.Clear();
			global::랾.럧.럎.Clear();
			global::랾.럧.럒 = 0;
			global::랾.럧.럼 = -1;
			global::랾.럧.럼 = 0f;
			global::랾.럧.럯 = false;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000ABF04 File Offset: 0x000AA104
		private static Vector2i 랛()
		{
			if (global::랾.럓.랾 == null)
			{
				return global::랾.랐.랾;
			}
			if (global::랾.럓.랾.myTransform != null && global::랾.럓.랾 != null)
			{
				Vector2i vector2i = global::랾.럽.랾(global::랾.럓.랾.myTransform.position);
				if (global::랾.럓.랾.IsMapPointInWorld(vector2i))
				{
					return vector2i;
				}
			}
			Vector2i currentPlayerMapPoint;
			try
			{
				currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			}
			catch
			{
				currentPlayerMapPoint = global::랾.랐.랾;
			}
			return currentPlayerMapPoint;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00040B40 File Offset: 0x0003ED40
		private static void 람(Vector2i A_0, string A_1)
		{
			global::랾.랐.람 = A_0;
			global::랾.랐.랾 = (A_1 ?? string.Empty);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000ABF90 File Offset: 0x000AA190
		private static bool 랾(Vector2i A_0, WorldItemBase A_1, IStorage A_2)
		{
			if (!global::랾.랐.럒(A_0) || A_1 == null || A_2 == null)
			{
				return false;
			}
			if (global::랾.랐.럒.x != A_0.x || global::랾.랐.럒.y != A_0.y)
			{
				global::랾.랐.럒 = A_0;
				global::랾.랐.랋 = Time.time;
				global::랾.랐.럎(A_0, A_1, A_2);
				OutgoingMessages.TryToSecureWorldItemForEditing(A_0);
				global::랾.랐.람(A_0, "PREPARE STORAGE");
				return false;
			}
			if (Time.time - global::랾.랐.랋 < 0.15f)
			{
				global::랾.랐.람(A_0, "PREPARE STORAGE");
				return false;
			}
			return true;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00040B57 File Offset: 0x0003ED57
		private static void 랆()
		{
			global::랾.랐.럒 = global::랾.랐.랾;
			global::랾.랐.랋 = 0f;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000AC01C File Offset: 0x000AA21C
		private static void 럎(Vector2i A_0, WorldItemBase A_1, IStorage A_2)
		{
			try
			{
				global::랾.랐.랾<WorldItemBase>(ref global::랾.랐.랾, "currentStorageData", A_1);
				global::랾.랐.랾<IStorage>(ref global::랾.랐.럎, "currentStorage", A_2);
				global::랾.랐.랾<Vector2i>(ref global::랾.랐.람, "currentMapPoint", A_0);
				global::랾.랐.랾<World.BlockType>(ref global::랾.랐.럒, "currentStorageType", A_1.blockType);
				global::랾.랐.랾<int>(ref global::랾.랐.럼, "currentSlotsAmount", global::랾.랐.랾(A_2));
				global::랾.랐.랾<bool>(ref global::랾.랐.랋, "isLocalPlayerUsing", true);
			}
			catch
			{
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000AC0A8 File Offset: 0x000AA2A8
		private static void 랾<랾>(ref FieldInfo A_0, string A_1, 랾 A_2)
		{
			try
			{
				if (A_0 == null)
				{
					A_0 = typeof(ItemStorageUI).GetField(A_1, BindingFlags.Static | BindingFlags.NonPublic);
				}
				FieldInfo fieldInfo = A_0;
				if (fieldInfo != null)
				{
					fieldInfo.SetValue(null, A_2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000AC0F8 File Offset: 0x000AA2F8
		private static int 랾(IStorage A_0)
		{
			if (A_0 == null)
			{
				return 0;
			}
			int result;
			try
			{
				result = Math.Max(A_0.GetMaxNumberOfItems(), A_0.GetNumberOfItems());
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000AC138 File Offset: 0x000AA338
		private static int 럎(PlayerData.InventoryKey A_0)
		{
			if (!A_0.IsValid() || global::랾.럓.랾 == null)
			{
				return 0;
			}
			int result;
			try
			{
				result = (int)global::랾.럓.랾.GetCount(A_0);
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000AC17C File Offset: 0x000AA37C
		private static ItemStorageUI 랐()
		{
			try
			{
				if (ControllerHelper.rootUI != null)
				{
					BaseMenuUI menufromCache = ControllerHelper.rootUI.GetMenufromCache(Il2CppType.Of<ItemStorageUI>());
					ItemStorageUI itemStorageUI = (menufromCache != null) ? menufromCache.TryCast<ItemStorageUI>() : null;
					if (itemStorageUI != null)
					{
						return itemStorageUI;
					}
				}
			}
			catch
			{
			}
			try
			{
				if (ControllerHelper.rootUI != null)
				{
					if (global::랾.랐.랾 == null)
					{
						global::랾.랐.랾 = global::랾.랐.랳();
					}
					if (global::랾.랐.랾 != null)
					{
						return global::랾.랐.랾.MakeGenericMethod(new Type[]
						{
							typeof(ItemStorageUI)
						}).Invoke(ControllerHelper.rootUI, null) as ItemStorageUI;
					}
				}
			}
			catch
			{
			}
			ItemStorageUI result;
			try
			{
				result = Object.FindObjectOfType<ItemStorageUI>();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000AC260 File Offset: 0x000AA460
		private static MethodInfo 럆()
		{
			if (global::랾.랐.럎 != null)
			{
				return global::랾.랐.럎;
			}
			global::랾.랐.럎 = typeof(ItemStorageUI).GetMethod("MoveFromInventoryToStorage", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(PlayerData.InventoryKey),
				typeof(short)
			}, null);
			return global::랾.랐.럎;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000AC2C4 File Offset: 0x000AA4C4
		private static MethodInfo 랄()
		{
			if (global::랾.랐.람 != null)
			{
				return global::랾.랐.람;
			}
			global::랾.랐.람 = typeof(ItemStorageUI).GetMethod("MoveFromStorageToInventoryWithInventoryItemBase", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(PlayerData.InventoryKey),
				typeof(int),
				typeof(InventoryItemBase)
			}, null);
			if (global::랾.랐.람 != null)
			{
				return global::랾.랐.람;
			}
			if (global::랾.랐.럒 == null)
			{
				global::랾.랐.럒 = typeof(ItemStorageUI).GetMethod("MoveFromStorageToInventory", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
				{
					typeof(PlayerData.InventoryKey),
					typeof(int)
				}, null);
			}
			return global::랾.랐.럒;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000A2850 File Offset: 0x000A0A50
		private static MethodInfo 랳()
		{
			foreach (MethodInfo methodInfo in typeof(RootUI).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (!(methodInfo.Name != "GetUIElementOfType") && methodInfo.IsGenericMethodDefinition && methodInfo.GetParameters().Length == 0)
				{
					return methodInfo;
				}
			}
			return null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000AC38C File Offset: 0x000AA58C
		private static void 람(PlayerData.InventoryKey A_0)
		{
			if (!A_0.IsValid())
			{
				return;
			}
			try
			{
				Player player = global::랾.럓.랾;
				if (player != null)
				{
					player.StripItemOnInventoryRemove(A_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000AC3CC File Offset: 0x000AA5CC
		private static void 랾(WorldItemBase A_0)
		{
			if (A_0 == null)
			{
				return;
			}
			try
			{
				ItemStorageUI.UpdateSlotsIfOpen(A_0);
			}
			catch
			{
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00040B6D File Offset: 0x0003ED6D
		private static void 럸()
		{
			global::랾.랐.람 = global::랾.랐.랾;
			global::랾.랐.랾 = string.Empty;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00040B83 File Offset: 0x0003ED83
		private static bool 럒(Vector2i A_0)
		{
			return A_0.x != global::랾.랐.랾.x || A_0.y != global::랾.랐.랾.y;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00040BAE File Offset: 0x0003EDAE
		private static float 랴()
		{
			ConfigFile.autoFarmerHitInterval = Mathf.Clamp(ConfigFile.autoFarmerHitInterval, 0.1f, 3f);
			return ConfigFile.autoFarmerHitInterval;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00040BCE File Offset: 0x0003EDCE
		private static float 럺()
		{
			ConfigFile.autoFarmerPlaceDelay = Mathf.Clamp(ConfigFile.autoFarmerPlaceDelay, 0.05f, 3f);
			return ConfigFile.autoFarmerPlaceDelay;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00040BEE File Offset: 0x0003EDEE
		private static float 럠()
		{
			ConfigFile.autoFarmerStorageTransferDelay = Mathf.Clamp(ConfigFile.autoFarmerStorageTransferDelay, 0.05f, 3f);
			return ConfigFile.autoFarmerStorageTransferDelay;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00040C0E File Offset: 0x0003EE0E
		private static int 랮()
		{
			ConfigFile.autoFarmerRoundsBeforeCollect = Math.Clamp(ConfigFile.autoFarmerRoundsBeforeCollect, 1, 50);
			return ConfigFile.autoFarmerRoundsBeforeCollect;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00040C27 File Offset: 0x0003EE27
		private static int 럅()
		{
			ConfigFile.autoFarmerRefillWhenBlockCountAtOrBelow = Math.Clamp(ConfigFile.autoFarmerRefillWhenBlockCountAtOrBelow, 1, 9999);
			return ConfigFile.autoFarmerRefillWhenBlockCountAtOrBelow;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00040C43 File Offset: 0x0003EE43
		private static int 랰()
		{
			ConfigFile.autoFarmerKeepBlockCountDuringDump = Math.Clamp(ConfigFile.autoFarmerKeepBlockCountDuringDump, 0, 900);
			return ConfigFile.autoFarmerKeepBlockCountDuringDump;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00040C5F File Offset: 0x0003EE5F
		private static int 럖()
		{
			ConfigFile.autoFarmerDumpWhenInventorySlotsAtOrAbove = Math.Clamp(ConfigFile.autoFarmerDumpWhenInventorySlotsAtOrAbove, 1, 200);
			return ConfigFile.autoFarmerDumpWhenInventorySlotsAtOrAbove;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00040C7B File Offset: 0x0003EE7B
		private static bool 럶()
		{
			return ConfigFile.autoFarmerUseRefillStorage && global::랾.랐.람(true);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00040C8C File Offset: 0x0003EE8C
		private static bool 랻()
		{
			return ConfigFile.autoFarmerUseOutputStorage && global::랾.랐.람(false);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000AC3FC File Offset: 0x000AA5FC
		private static bool 람(bool A_0)
		{
			if (!A_0)
			{
				return !string.IsNullOrWhiteSpace(ConfigFile.autoFarmerOutputStorageWorldName) && ConfigFile.autoFarmerOutputStorageX >= 0 && ConfigFile.autoFarmerOutputStorageY >= 0;
			}
			return !string.IsNullOrWhiteSpace(ConfigFile.autoFarmerRefillStorageWorldName) && ConfigFile.autoFarmerRefillStorageX >= 0 && ConfigFile.autoFarmerRefillStorageY >= 0;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00040C9D File Offset: 0x0003EE9D
		private static bool 략()
		{
			return global::랾.럓.랾 != null && !string.IsNullOrWhiteSpace(ConfigFile.autoFarmerRefillStorageWorldName) && string.Equals(global::랾.럓.랾.worldName, ConfigFile.autoFarmerRefillStorageWorldName, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00040CC9 File Offset: 0x0003EEC9
		private static bool 럵()
		{
			return global::랾.럓.랾 != null && !string.IsNullOrWhiteSpace(ConfigFile.autoFarmerOutputStorageWorldName) && string.Equals(global::랾.럓.랾.worldName, ConfigFile.autoFarmerOutputStorageWorldName, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00040CF5 File Offset: 0x0003EEF5
		private static Vector2i 럒(bool A_0)
		{
			if (!A_0)
			{
				return new Vector2i(ConfigFile.autoFarmerOutputStorageX, ConfigFile.autoFarmerOutputStorageY);
			}
			return new Vector2i(ConfigFile.autoFarmerRefillStorageX, ConfigFile.autoFarmerRefillStorageY);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000AC450 File Offset: 0x000AA650
		private static bool 랾(bool A_0, out Vector2i A_1, out WorldItemBase A_2, out IStorage A_3)
		{
			A_1 = global::랾.랐.럒(A_0);
			A_2 = null;
			A_3 = null;
			if (!global::랾.랐.람(A_0) || global::랾.럓.랾 == null)
			{
				return false;
			}
			string b = A_0 ? ConfigFile.autoFarmerRefillStorageWorldName : ConfigFile.autoFarmerOutputStorageWorldName;
			return string.Equals(global::랾.럓.랾.worldName, b, StringComparison.OrdinalIgnoreCase) && global::랾.랐.랾(A_1, out A_2, out A_3);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000AC4B4 File Offset: 0x000AA6B4
		private static bool 랾(Vector2i A_0, out WorldItemBase A_1, out IStorage A_2)
		{
			A_1 = null;
			A_2 = null;
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return false;
			}
			if (!ConfigData.IsBlockStorage(global::랾.럓.랾.GetBlockType(A_0)))
			{
				return false;
			}
			A_1 = global::랾.럓.랾.GetWorldItemData(A_0);
			if (A_1 == null)
			{
				return false;
			}
			A_2 = A_1.TryCast<IStorage>();
			return A_2 != null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000AC514 File Offset: 0x000AA714
		private static List<랐.람> 럎(IStorage A_0)
		{
			List<랐.람> list = new List<랐.람>();
			if (A_0 == null)
			{
				return list;
			}
			int numberOfItems = A_0.GetNumberOfItems();
			for (int i = 0; i < numberOfItems; i++)
			{
				PlayerData.InventoryKey inventoryKeyOfSlot = A_0.GetInventoryKeyOfSlot(i);
				short inventoryAmountOfSlot = A_0.GetInventoryAmountOfSlot(i);
				if (inventoryKeyOfSlot.IsValid() && inventoryAmountOfSlot > 0)
				{
					list.Add(new 랐.람(i, inventoryKeyOfSlot, inventoryAmountOfSlot, A_0.GetInventoryData(i)));
				}
			}
			return list;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000AC578 File Offset: 0x000AA778
		private static int 랾(IStorage A_0, PlayerData.InventoryKey A_1)
		{
			if (A_0 == null)
			{
				return -1;
			}
			int numberOfItems = A_0.GetNumberOfItems();
			for (int i = 0; i < numberOfItems; i++)
			{
				if (A_0.GetInventoryKeyOfSlot(i) == A_1)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000AC5B0 File Offset: 0x000AA7B0
		private static bool 랾(Vector2i A_0, bool A_1, out string A_2)
		{
			A_2 = string.Empty;
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null)
			{
				A_2 = "Join a world first.";
				return false;
			}
			WorldItemBase worldItemBase;
			IStorage storage;
			if (!global::랾.랐.랾(A_0, out worldItemBase, out storage))
			{
				A_2 = "That tile is not a storage block.";
				return false;
			}
			if (A_1)
			{
				bool flag = !string.Equals(ConfigFile.autoFarmerRefillStorageWorldName, global::랾.럓.랾.worldName, StringComparison.OrdinalIgnoreCase) || ConfigFile.autoFarmerRefillStorageX != A_0.x || ConfigFile.autoFarmerRefillStorageY != A_0.y;
				ConfigFile.autoFarmerRefillStorageWorldName = global::랾.럓.랾.worldName;
				ConfigFile.autoFarmerRefillStorageX = A_0.x;
				ConfigFile.autoFarmerRefillStorageY = A_0.y;
				if (flag)
				{
					ConfigFile.autoFarmerPriorityBlockTypes = string.Empty;
				}
			}
			else
			{
				ConfigFile.autoFarmerOutputStorageWorldName = global::랾.럓.랾.worldName;
				ConfigFile.autoFarmerOutputStorageX = A_0.x;
				ConfigFile.autoFarmerOutputStorageY = A_0.y;
			}
			global::랾.랐.럣();
			return true;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000AC688 File Offset: 0x000AA888
		private static bool 럼(bool A_0)
		{
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			for (int i = 0; i < global::랾.랐.랾.Length; i++)
			{
				Vector2i vector2i;
				vector2i..ctor(currentPlayerMapPoint.x + global::랾.랐.랾[i].x, currentPlayerMapPoint.y + global::랾.랐.랾[i].y);
				string text;
				if (global::랾.럓.랾.IsMapPointInWorld(vector2i) && global::랾.랐.랾(vector2i, A_0, out text))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000AC720 File Offset: 0x000AA920
		private static bool 랾(out Vector2i A_0)
		{
			A_0 = default(Vector2i);
			Camera main = Camera.main;
			if (main == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			A_0 = global::랾.럽.랾(main.ScreenToWorldPoint(global::랾.랅.람()));
			return global::랾.럓.랾.IsMapPointInWorld(A_0);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000A2154 File Offset: 0x000A0354
		private unsafe static bool 럨()
		{
			try
			{
				if (global::랾.랉.랾() && global::랾.랉.럎() != IntPtr.Zero)
				{
					return *global::랾.랉.람().WantCaptureMouse;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000AC778 File Offset: 0x000AA978
		public static void 럃()
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			Camera main = Camera.main;
			if (main == null)
			{
				return;
			}
			if (global::랾.럧.럆 && global::랾.랐.랾.Count > 0)
			{
				global::랾.랐.랾(main);
			}
			global::랾.랐.랾(main, global::랾.랐.럒(true), global::랾.랐.략(), global::랾.랐.람.x == ConfigFile.autoFarmerRefillStorageX && global::랾.랐.람.y == ConfigFile.autoFarmerRefillStorageY, "REFILL STORAGE", new Color(0.2f, 0.32f, 0.62f, 0.18f), new Color(0.45f, 0.78f, 1f, 0.95f));
			global::랾.랐.랾(main, global::랾.랐.럒(false), global::랾.랐.럵(), global::랾.랐.람.x == ConfigFile.autoFarmerOutputStorageX && global::랾.랐.람.y == ConfigFile.autoFarmerOutputStorageY, "OUTPUT STORAGE", new Color(0.22f, 0.42f, 0.16f, 0.18f), new Color(0.62f, 1f, 0.52f, 0.95f));
			if (global::랾.랐.럒(global::랾.랐.람) && !global::랾.랐.랾.Contains(global::랾.랐.람))
			{
				global::랾.랐.랾(main, global::랾.랐.람, string.IsNullOrWhiteSpace(global::랾.랐.랾) ? "TARGET" : global::랾.랐.랾, new Color(0.46f, 0.24f, 0.05f, 0.28f), new Color(1f, 0.8f, 0.2f, 1f), 1.85f);
			}
			Vector2i vector2i;
			if ((global::랾.랐.랾 || global::랾.랐.럎) && global::랾.랐.랾(out vector2i))
			{
				WorldItemBase worldItemBase;
				IStorage storage;
				bool flag = global::랾.랐.랾(vector2i, out worldItemBase, out storage);
				string text = flag ? (global::랾.랐.랾 ? "SAVE REFILL STORAGE" : "SAVE OUTPUT STORAGE") : "NOT A STORAGE";
				global::랾.랐.랾(main, vector2i, text, flag ? new Color(0.58f, 0.32f, 0.08f, 0.26f) : new Color(0.3f, 0.08f, 0.08f, 0.18f), flag ? new Color(1f, 0.74f, 0.24f, 0.95f) : new Color(1f, 0.44f, 0.44f, 0.92f), 1.85f);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000AC9CC File Offset: 0x000AABCC
		private static void 랾(Camera A_0)
		{
			for (int i = 0; i < global::랾.랐.랾.Count; i++)
			{
				Vector2i vector2i = global::랾.랐.랾[i];
				bool flag = vector2i.x == global::랾.랐.람.x && vector2i.y == global::랾.랐.람.y;
				global::랾.랐.랾(A_0, vector2i, flag ? global::랾.랐.랾 : null, flag ? new Color(0.45f, 0.28f, 0.05f, 0.28f) : new Color(0.1f, 0.35f, 0.5f, 0.14f), flag ? new Color(1f, 0.82f, 0.2f, 1f) : new Color(0.35f, 0.85f, 1f, 0.9f), flag ? 2.5f : 1.75f);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000ACAB8 File Offset: 0x000AACB8
		private static void 랾(Camera A_0, Vector2i A_1, bool A_2, bool A_3, string A_4, Color A_5, Color A_6)
		{
			if (!A_2 || !global::랾.랐.럒(A_1))
			{
				return;
			}
			global::랾.랐.랾(A_0, A_1, A_4, A_3 ? new Color(0.46f, 0.24f, 0.05f, 0.28f) : A_5, A_3 ? new Color(1f, 0.8f, 0.2f, 1f) : A_6, A_3 ? 2.5f : 1.85f);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000ACB2C File Offset: 0x000AAD2C
		private static void 랾(Camera A_0, Vector2i A_1, string A_2, Color A_3, Color A_4, float A_5 = 1.85f)
		{
			Rect rect;
			if (!global::랾.랐.랾(A_0, A_1, out rect))
			{
				return;
			}
			global::랾.럈.랾(rect.x, rect.y, rect.width, rect.height, A_3);
			global::랾.럈.랾(rect.x, rect.y, rect.width, rect.height, A_4, A_5);
			if (string.IsNullOrWhiteSpace(A_2))
			{
				return;
			}
			Vector2 vector = global::랾.럈.랾(A_2, 0);
			float num = rect.x + (rect.width - vector.x) * 0.5f;
			float num2 = rect.y - vector.y - 6f;
			global::랾.럈.랾(num - 4f, num2 - 2f, vector.x + 8f, vector.y + 4f, new Color(0f, 0f, 0f, 0.55f));
			global::랾.랐.랾(A_2, num, num2, A_4);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000A2290 File Offset: 0x000A0490
		private static bool 랾(Camera A_0, Vector2i A_1, out Rect A_2)
		{
			A_2 = default(Rect);
			WorldController worldController = ControllerHelper.worldController;
			if (worldController == null)
			{
				return false;
			}
			Vector2 vector = worldController.ConvertMapPointToWorldPoint(A_1);
			float num = ConfigData.tileSizeX * 0.5f;
			Vector3 vector2;
			vector2..ctor(vector.x - num, vector.y - ConfigData.tileSizeY * 0.5f, 0f);
			Vector3 vector3;
			vector3..ctor(vector.x + num, vector.y + ConfigData.tileSizeY * 0.5f, 0f);
			Vector3 vector4 = A_0.WorldToScreenPoint(vector2);
			Vector3 vector5 = A_0.WorldToScreenPoint(vector3);
			if (vector4.z <= 0.1f || vector5.z <= 0.1f || float.IsNaN(vector4.x) || float.IsNaN(vector4.y) || float.IsNaN(vector5.x) || float.IsNaN(vector5.y) || float.IsInfinity(vector4.x) || float.IsInfinity(vector4.y) || float.IsInfinity(vector5.x) || float.IsInfinity(vector5.y))
			{
				return false;
			}
			float num2 = Mathf.Min(vector4.x, vector5.x);
			float num3 = Mathf.Max(vector4.x, vector5.x);
			float num4 = (float)Screen.height - Mathf.Max(vector4.y, vector5.y);
			float num5 = (float)Screen.height - Mathf.Min(vector4.y, vector5.y);
			if (num3 - num2 < 1f || num5 - num4 < 1f)
			{
				return false;
			}
			A_2 = new Rect(num2, num4, num3 - num2, num5 - num4);
			return true;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000A2458 File Offset: 0x000A0658
		private static void 랾(string A_0, float A_1, float A_2, Color A_3)
		{
			Color color;
			color..ctor(0f, 0f, 0f, 1f);
			global::랾.럈.랾(A_0, A_1 - 1f, A_2, color, 0);
			global::랾.럈.랾(A_0, A_1 + 1f, A_2, color, 0);
			global::랾.럈.랾(A_0, A_1, A_2 - 1f, color, 0);
			global::랾.럈.랾(A_0, A_1, A_2 + 1f, color, 0);
			global::랾.럈.랾(A_0, A_1, A_2, A_3, 0);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000ACC20 File Offset: 0x000AAE20
		private static string 랾(string A_0, int A_1, int A_2)
		{
			if (string.IsNullOrWhiteSpace(A_0) || A_1 < 0 || A_2 < 0)
			{
				return "No storage selected";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000ACC90 File Offset: 0x000AAE90
		private static string 럎(랐.럒 A_0)
		{
			string result;
			switch (A_0)
			{
			case global::랾.랐.럒.랾:
				result = "Setting up";
				break;
			case global::랾.랐.럒.럎:
				result = "Clearing old blocks";
				break;
			case global::랾.랐.럒.람:
				result = "Placing farm blocks";
				break;
			case global::랾.랐.럒.럒:
				result = "Breaking farm blocks";
				break;
			case global::랾.랐.럒.럼:
				result = "Collecting drops";
				break;
			case global::랾.랐.럒.랋:
				result = "Refilling from storage";
				break;
			case global::랾.랐.럒.랉:
				result = "Storing farm output";
				break;
			default:
				result = A_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00040D19 File Offset: 0x0003EF19
		private static void 랾(string A_0)
		{
			global::랾.랐.랃();
			global::랾.랐.랾 = null;
			global::랾.랐.랆();
			global::랾.랐.럸();
			global::랾.랐.랾 = global::랾.랐.럒.랾;
			global::랾.럧.럆 = false;
			if (!string.IsNullOrWhiteSpace(A_0))
			{
				global::랾.랃.람("Auto Farm", A_0, 4f);
			}
		}

		// Token: 0x04000638 RID: 1592
		internal const int 랾 = 900;

		// Token: 0x04000639 RID: 1593
		private static readonly Vector2i 랾 = new Vector2i(int.MinValue, int.MinValue);

		// Token: 0x0400063A RID: 1594
		private const float 랾 = 1f;

		// Token: 0x0400063B RID: 1595
		private const float 럎 = 0.15f;

		// Token: 0x0400063C RID: 1596
		private static readonly Vector2i[] 랾 = new Vector2i[]
		{
			new Vector2i(0, 0),
			new Vector2i(0, -1),
			new Vector2i(-1, 0),
			new Vector2i(1, 0),
			new Vector2i(0, 1),
			new Vector2i(-1, -1),
			new Vector2i(1, -1),
			new Vector2i(-1, 1),
			new Vector2i(1, 1)
		};

		// Token: 0x0400063D RID: 1597
		private static 랐.럒 랾 = global::랾.랐.럒.랾;

		// Token: 0x0400063E RID: 1598
		private static float 람;

		// Token: 0x0400063F RID: 1599
		private static float 럒;

		// Token: 0x04000640 RID: 1600
		private static float 럼;

		// Token: 0x04000641 RID: 1601
		private static int 럎;

		// Token: 0x04000642 RID: 1602
		private static int 람;

		// Token: 0x04000643 RID: 1603
		private static int 럒;

		// Token: 0x04000644 RID: 1604
		private static int 럼;

		// Token: 0x04000645 RID: 1605
		private static int 랋;

		// Token: 0x04000646 RID: 1606
		private static int 랉;

		// Token: 0x04000647 RID: 1607
		private static readonly List<Vector2i> 랾 = new List<Vector2i>();

		// Token: 0x04000648 RID: 1608
		private static Vector2i 럎 = global::랾.랐.랾;

		// Token: 0x04000649 RID: 1609
		private static Vector2i 람 = global::랾.랐.랾;

		// Token: 0x0400064A RID: 1610
		private static string 랾 = string.Empty;

		// Token: 0x0400064B RID: 1611
		private static 랐.럒? 랾;

		// Token: 0x0400064C RID: 1612
		private static World.BlockType 랾 = 0;

		// Token: 0x0400064D RID: 1613
		private static Vector2i 럒 = global::랾.랐.랾;

		// Token: 0x0400064E RID: 1614
		private static float 랋;

		// Token: 0x0400064F RID: 1615
		private static bool 랾;

		// Token: 0x04000650 RID: 1616
		private static bool 럎;

		// Token: 0x04000651 RID: 1617
		private static MethodInfo 랾;

		// Token: 0x04000652 RID: 1618
		private static MethodInfo 럎;

		// Token: 0x04000653 RID: 1619
		private static MethodInfo 람;

		// Token: 0x04000654 RID: 1620
		private static MethodInfo 럒;

		// Token: 0x04000655 RID: 1621
		private static FieldInfo 랾;

		// Token: 0x04000656 RID: 1622
		private static FieldInfo 럎;

		// Token: 0x04000657 RID: 1623
		private static FieldInfo 람;

		// Token: 0x04000658 RID: 1624
		private static FieldInfo 럒;

		// Token: 0x04000659 RID: 1625
		private static FieldInfo 럼;

		// Token: 0x0400065A RID: 1626
		private static FieldInfo 랋;

		// Token: 0x02000111 RID: 273
		public readonly struct 랾
		{
			// Token: 0x060008A0 RID: 2208 RVA: 0x00040D59 File Offset: 0x0003EF59
			public 랾(World.BlockType A_1, int A_2, int A_3)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.럎 = A_3;
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x00040D70 File Offset: 0x0003EF70
			[CompilerGenerated]
			public World.BlockType 랾()
			{
				return this.랾;
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x00040D78 File Offset: 0x0003EF78
			[CompilerGenerated]
			public int 럎()
			{
				return this.랾;
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x00040D80 File Offset: 0x0003EF80
			[CompilerGenerated]
			public int 람()
			{
				return this.럎;
			}

			// Token: 0x0400065B RID: 1627
			[CompilerGenerated]
			private readonly World.BlockType 랾;

			// Token: 0x0400065C RID: 1628
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x0400065D RID: 1629
			[CompilerGenerated]
			private readonly int 럎;
		}

		// Token: 0x02000112 RID: 274
		public readonly struct 럎
		{
			// Token: 0x060008A4 RID: 2212 RVA: 0x00040D88 File Offset: 0x0003EF88
			public 럎(World.BlockType A_1, int A_2, int A_3, bool A_4)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.럎 = A_3;
				this.랾 = A_4;
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x00040DA7 File Offset: 0x0003EFA7
			[CompilerGenerated]
			public World.BlockType 랾()
			{
				return this.랾;
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x00040DAF File Offset: 0x0003EFAF
			[CompilerGenerated]
			public int 럎()
			{
				return this.랾;
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x00040DB7 File Offset: 0x0003EFB7
			[CompilerGenerated]
			public int 람()
			{
				return this.럎;
			}

			// Token: 0x060008A8 RID: 2216 RVA: 0x00040DBF File Offset: 0x0003EFBF
			[CompilerGenerated]
			public bool 럒()
			{
				return this.랾;
			}

			// Token: 0x0400065E RID: 1630
			[CompilerGenerated]
			private readonly World.BlockType 랾;

			// Token: 0x0400065F RID: 1631
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x04000660 RID: 1632
			[CompilerGenerated]
			private readonly int 럎;

			// Token: 0x04000661 RID: 1633
			[CompilerGenerated]
			private readonly bool 랾;
		}

		// Token: 0x02000113 RID: 275
		private readonly struct 람
		{
			// Token: 0x060008A9 RID: 2217 RVA: 0x00040DC7 File Offset: 0x0003EFC7
			public 람(int A_1, PlayerData.InventoryKey A_2, short A_3, InventoryItemBase A_4)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.랾 = A_3;
				this.랾 = A_4;
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00040DE6 File Offset: 0x0003EFE6
			[CompilerGenerated]
			public int 랾()
			{
				return this.랾;
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x00040DEE File Offset: 0x0003EFEE
			[CompilerGenerated]
			public PlayerData.InventoryKey 럎()
			{
				return this.랾;
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x00040DF6 File Offset: 0x0003EFF6
			[CompilerGenerated]
			public short 람()
			{
				return this.랾;
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x00040DFE File Offset: 0x0003EFFE
			[CompilerGenerated]
			public InventoryItemBase 럒()
			{
				return this.랾;
			}

			// Token: 0x04000662 RID: 1634
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x04000663 RID: 1635
			[CompilerGenerated]
			private readonly PlayerData.InventoryKey 랾;

			// Token: 0x04000664 RID: 1636
			[CompilerGenerated]
			private readonly short 랾;

			// Token: 0x04000665 RID: 1637
			[CompilerGenerated]
			private readonly InventoryItemBase 랾;
		}

		// Token: 0x02000114 RID: 276
		private enum 럒
		{
			// Token: 0x04000667 RID: 1639
			랾,
			// Token: 0x04000668 RID: 1640
			럎,
			// Token: 0x04000669 RID: 1641
			람,
			// Token: 0x0400066A RID: 1642
			럒,
			// Token: 0x0400066B RID: 1643
			럼,
			// Token: 0x0400066C RID: 1644
			랋,
			// Token: 0x0400066D RID: 1645
			랉
		}

		// Token: 0x02000115 RID: 277
		[CompilerGenerated]
		[Serializable]
		private sealed class 럼
		{
			// Token: 0x060008B0 RID: 2224 RVA: 0x00040E12 File Offset: 0x0003F012
			internal bool 랾(PlayerData.InventoryKey A_1)
			{
				return A_1.itemType == 2 && global::랾.럓.랾.GetCount(A_1) > 0;
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00040E2D File Offset: 0x0003F02D
			internal World.BlockType 랾([TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})] ValueTuple<World.BlockType, int> entry)
			{
				return entry.Item1;
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x00040E35 File Offset: 0x0003F035
			internal World.BlockType 랾([TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})] IGrouping<World.BlockType, ValueTuple<World.BlockType, int>> group)
			{
				return group.Key;
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x00040E3D File Offset: 0x0003F03D
			internal int 럎([TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})] IGrouping<World.BlockType, ValueTuple<World.BlockType, int>> group)
			{
				return group.Sum(new Func<ValueTuple<World.BlockType, int>, int>(global::랾.랐.럼.랾.럎));
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x00040E64 File Offset: 0x0003F064
			internal int 럎([TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})] ValueTuple<World.BlockType, int> item)
			{
				return item.Item2;
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x00040E6C File Offset: 0x0003F06C
			internal bool 랾(Vector2i A_1)
			{
				return global::랾.럓.랾.GetBlockType(A_1) == global::랾.랐.랾;
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00040E80 File Offset: 0x0003F080
			internal short 랾(랐.람 A_1)
			{
				return A_1.람();
			}

			// Token: 0x060008B7 RID: 2231 RVA: 0x00040E89 File Offset: 0x0003F089
			internal bool 럎(Vector2i A_1)
			{
				return A_1.x < 0 || A_1.y < 0 || A_1.x >= global::랾.럓.랾.worldSizeX || A_1.y >= global::랾.럓.랾.worldSizeY;
			}

			// Token: 0x060008B8 RID: 2232 RVA: 0x00040EC6 File Offset: 0x0003F0C6
			[return: TupleElementNames(new string[]
			{
				"blockType",
				"index"
			})]
			internal ValueTuple<World.BlockType, int> 랾(World.BlockType A_1, int A_2)
			{
				return new ValueTuple<World.BlockType, int>(A_1, A_2);
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x00040E2D File Offset: 0x0003F02D
			internal World.BlockType 람([TupleElementNames(new string[]
			{
				"blockType",
				"index"
			})] ValueTuple<World.BlockType, int> item)
			{
				return item.Item1;
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x00040E64 File Offset: 0x0003F064
			internal int 럒([TupleElementNames(new string[]
			{
				"blockType",
				"index"
			})] ValueTuple<World.BlockType, int> item)
			{
				return item.Item2;
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x00040E2D File Offset: 0x0003F02D
			internal World.BlockType 럼([TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})] ValueTuple<World.BlockType, int> item)
			{
				return item.Item1;
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x00040ECF File Offset: 0x0003F0CF
			internal bool 랾(World.BlockType A_1)
			{
				return A_1 > 0;
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x000ACDF4 File Offset: 0x000AAFF4
			internal string 럎(World.BlockType A_1)
			{
				int num = A_1;
				return num.ToString();
			}

			// Token: 0x0400066E RID: 1646
			public static readonly 랐.럼 랾 = new 랐.럼();

			// Token: 0x0400066F RID: 1647
			public static Func<PlayerData.InventoryKey, bool> 랾;

			// Token: 0x04000670 RID: 1648
			[TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})]
			public static Func<ValueTuple<World.BlockType, int>, World.BlockType> 랾;

			// Token: 0x04000671 RID: 1649
			[TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})]
			public static Func<IGrouping<World.BlockType, ValueTuple<World.BlockType, int>>, World.BlockType> 랾;

			// Token: 0x04000672 RID: 1650
			[TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})]
			public static Func<ValueTuple<World.BlockType, int>, int> 랾;

			// Token: 0x04000673 RID: 1651
			[TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})]
			public static Func<IGrouping<World.BlockType, ValueTuple<World.BlockType, int>>, int> 랾;

			// Token: 0x04000674 RID: 1652
			public static Func<Vector2i, bool> 랾;

			// Token: 0x04000675 RID: 1653
			public static Func<랐.람, short> 랾;

			// Token: 0x04000676 RID: 1654
			public static Predicate<Vector2i> 랾;

			// Token: 0x04000677 RID: 1655
			[TupleElementNames(new string[]
			{
				"blockType",
				"index"
			})]
			public static Func<World.BlockType, int, ValueTuple<World.BlockType, int>> 랾;

			// Token: 0x04000678 RID: 1656
			[TupleElementNames(new string[]
			{
				"blockType",
				"index"
			})]
			public static Func<ValueTuple<World.BlockType, int>, World.BlockType> 럎;

			// Token: 0x04000679 RID: 1657
			[TupleElementNames(new string[]
			{
				"blockType",
				"index"
			})]
			public static Func<ValueTuple<World.BlockType, int>, int> 럎;

			// Token: 0x0400067A RID: 1658
			[TupleElementNames(new string[]
			{
				"BlockType",
				"StorageAmount"
			})]
			public static Func<ValueTuple<World.BlockType, int>, World.BlockType> 람;

			// Token: 0x0400067B RID: 1659
			public static Func<World.BlockType, bool> 랾;

			// Token: 0x0400067C RID: 1660
			public static Func<World.BlockType, string> 랾;
		}

		// Token: 0x02000116 RID: 278
		[CompilerGenerated]
		private sealed class 랋
		{
			// Token: 0x060008BF RID: 2239 RVA: 0x00040ED5 File Offset: 0x0003F0D5
			internal bool 랾(Vector2i A_1)
			{
				return A_1.x == this.랾.x && A_1.y == this.랾.y - 1;
			}

			// Token: 0x0400067D RID: 1661
			public Vector2i 랾;
		}

		// Token: 0x02000117 RID: 279
		[CompilerGenerated]
		private sealed class 랉
		{
			// Token: 0x060008C1 RID: 2241 RVA: 0x000ACE0C File Offset: 0x000AB00C
			internal int 랾([TupleElementNames(new string[]
			{
				"Key",
				"AmountToDeposit"
			})] ValueTuple<PlayerData.InventoryKey, int> left, [TupleElementNames(new string[]
			{
				"Key",
				"AmountToDeposit"
			})] ValueTuple<PlayerData.InventoryKey, int> right)
			{
				bool flag = left.Item1.itemType == 2;
				bool flag2 = right.Item1.itemType == 2;
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					int num2;
					int num = this.랾.TryGetValue(left.Item1.blockType, out num2) ? num2 : int.MaxValue;
					int num3;
					int value = this.랾.TryGetValue(right.Item1.blockType, out num3) ? num3 : int.MaxValue;
					int num4 = num.CompareTo(value);
					if (num4 != 0)
					{
						return num4;
					}
					return string.Compare(global::랾.랐.랾(left.Item1.blockType), global::랾.랐.랾(right.Item1.blockType), StringComparison.OrdinalIgnoreCase);
				}
			}

			// Token: 0x0400067E RID: 1662
			public Dictionary<World.BlockType, int> 랾;
		}

		// Token: 0x02000118 RID: 280
		[CompilerGenerated]
		private sealed class 럐
		{
			// Token: 0x060008C3 RID: 2243 RVA: 0x00040F01 File Offset: 0x0003F101
			internal bool 랾(World.BlockType A_1)
			{
				return A_1 == this.랾;
			}

			// Token: 0x0400067F RID: 1663
			public World.BlockType 랾;
		}

		// Token: 0x02000119 RID: 281
		[CompilerGenerated]
		private sealed class 랓
		{
			// Token: 0x060008C5 RID: 2245 RVA: 0x00040F0C File Offset: 0x0003F10C
			internal bool 랾(랐.람 A_1)
			{
				return A_1.럎().blockType == this.랾;
			}

			// Token: 0x04000680 RID: 1664
			public World.BlockType 랾;

			// Token: 0x04000681 RID: 1665
			public Func<랐.람, bool> 랾;
		}
	}
}
