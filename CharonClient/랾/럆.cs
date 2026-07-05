using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BasicTypes;
using CharonClient.Configuration;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200011A RID: 282
	internal static class 럆
	{
		// Token: 0x060008C6 RID: 2246 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		public static void 랾()
		{
			if (!럽.랾() || 럓.랾 == null || 럓.랾 == null || 럓.랾 == null || 럓.랾.plantedSeeds == null)
			{
				럆.럎();
				return;
			}
			if (럧.럯 || 럓.랾.isPortalAnimationActive)
			{
				return;
			}
			럆.럼();
			if (!ConfigFile.autoHarvestGrownSeedsToggle)
			{
				럆.랓();
			}
			if (!ConfigFile.autoPlantSeedsToggle)
			{
				럆.럯();
			}
			if (!ConfigFile.autoHarvestGrownSeedsToggle && !ConfigFile.autoPlantSeedsToggle)
			{
				럆.럎();
				return;
			}
			럆.랋();
			Vector2i vector2i = 럆.럐();
			int num = 럆.랉();
			if (num <= 0 || !럓.랾.IsMapPointInWorld(vector2i))
			{
				return;
			}
			if (ConfigFile.autoHarvestGrownSeedsToggle && 럆.랾(vector2i, num))
			{
				return;
			}
			if (ConfigFile.autoPlantSeedsToggle)
			{
				럆.럎(vector2i, num);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00040F22 File Offset: 0x0003F122
		public static void 럎()
		{
			럆.랾 = string.Empty;
			럆.랓();
			럆.럯();
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000ACF90 File Offset: 0x000AB190
		public static List<럆.랾> 람()
		{
			List<럆.랾> list = new List<럆.랾>();
			PlayerData playerData = 럓.랾;
			PlayerData.InventoryKey[] array = (playerData != null) ? playerData.GetInventoryAsOrderedByInventoryItemType() : null;
			if (array == null)
			{
				return list;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (PlayerData.InventoryKey inventoryKey in array)
			{
				if (inventoryKey.itemType == 2)
				{
					short count = 럓.랾.GetCount(inventoryKey);
					if (count > 0)
					{
						int blockType = inventoryKey.blockType;
						if (hashSet.Add(blockType))
						{
							list.Add(new 럆.랾(inventoryKey.blockType, 럆.랾(inventoryKey), count));
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000AD028 File Offset: 0x000AB228
		public static string 럒()
		{
			if (ConfigFile.autoPlantSelectedSeedBlockType == -1)
			{
				return "All Seeds (Inventory Order)";
			}
			List<럆.랾> list = 럆.람();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].랾() == ConfigFile.autoPlantSelectedSeedBlockType)
				{
					return list[i].럎();
				}
			}
			if (ConfigFile.autoPlantSelectedSeedBlockType > 0)
			{
				return 럆.람(ConfigFile.autoPlantSelectedSeedBlockType);
			}
			return "Pick a seed";
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000AD098 File Offset: 0x000AB298
		private static void 럼()
		{
			World world = 럓.랾;
			string a = ((world != null) ? world.worldName : null) ?? string.Empty;
			if (string.Equals(a, 럆.랾, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
			럆.랾 = a;
			럆.랓();
			럆.럯();
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
		private static void 랋()
		{
			SeedData seedData;
			if (럆.랾(럆.럎) && (!럆.랾(럆.럎, out seedData) || !럆.랾(seedData)))
			{
				럆.랓();
			}
			if (!럆.랾(럆.람))
			{
				return;
			}
			SeedData seedData2;
			if (럆.랾(럆.람, out seedData2))
			{
				럆.럯();
				return;
			}
			if (럓.랾.GetBlockType(럆.람) != null)
			{
				럆.럯();
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000AD14C File Offset: 0x000AB34C
		private static bool 랾(Vector2i A_0, int A_1)
		{
			if (럆.랾(럆.럎))
			{
				SeedData seedData;
				if (!럆.랾(럆.럎, out seedData) || !럆.랾(seedData))
				{
					럆.랓();
				}
				else if (Time.time >= 럆.람)
				{
					럽.랾(럆.럎.x, 럆.럎.y);
					럆.람 = Time.time + 0.35f;
				}
				return true;
			}
			Vector2i vector2i;
			if (!럆.랾(A_0, A_1, out vector2i))
			{
				return false;
			}
			럆.럎 = vector2i;
			럆.람 = Time.time + 0.35f;
			럽.랾(vector2i.x, vector2i.y);
			return true;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000AD1F0 File Offset: 0x000AB3F0
		private static bool 럎(Vector2i A_0, int A_1)
		{
			if (럆.랾(럆.람))
			{
				SeedData seedData;
				if (럆.랾(럆.람, out seedData) || 럓.랾.GetBlockType(럆.람) != null)
				{
					럆.럯();
				}
				else if (!럆.랾(럆.람, A_0, A_1) || !럆.럎(럆.랾))
				{
					럆.럯();
				}
				else if (Time.time >= 럆.럒)
				{
					럆.랾(럆.람, 럆.랾);
					럆.럒 = Time.time + 0.2f;
				}
				return true;
			}
			PlayerData.InventoryKey inventoryKey;
			if (!럆.랾(out inventoryKey))
			{
				return false;
			}
			Vector2i vector2i;
			if (!럆.럎(A_0, A_1, out vector2i))
			{
				return false;
			}
			럆.람 = vector2i;
			럆.랾 = inventoryKey.blockType;
			럆.럒 = Time.time + 0.2f;
			럆.랾(vector2i, inventoryKey.blockType);
			return true;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000AD2C8 File Offset: 0x000AB4C8
		private static bool 랾(Vector2i A_0, World.BlockType A_1)
		{
			if (A_1 == null)
			{
				return false;
			}
			try
			{
				WorldController worldController = ControllerHelper.worldController;
				if (worldController != null)
				{
					return worldController.SetSeedWithTool(A_1, A_0, 0f);
				}
			}
			catch
			{
			}
			OutgoingMessages.SendSetSeedMessage(A_0, A_1);
			럆.랾(A_1);
			return true;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000AD320 File Offset: 0x000AB520
		private static void 랾(World.BlockType A_0)
		{
			if (A_0 == null || 럓.랾 == null)
			{
				return;
			}
			try
			{
				PlayerData.InventoryKey inventoryKey;
				inventoryKey..ctor(A_0, 2);
				if (럓.랾.GetCount(inventoryKey) > 0)
				{
					럓.랾.RemoveItemsFromInventory(inventoryKey, 1);
					Player player = 럓.랾;
					if (player != null)
					{
						player.StripItemOnInventoryRemove(inventoryKey);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000AD384 File Offset: 0x000AB584
		private static bool 랾(Vector2i A_0, int A_1, out Vector2i A_2)
		{
			A_2 = 럆.랾;
			Il2CppReferenceArray<Il2CppReferenceArray<SeedData>> plantedSeeds = 럓.랾.plantedSeeds;
			if (plantedSeeds == null)
			{
				return false;
			}
			float num = float.MaxValue;
			int num2 = Math.Max(0, A_0.x - A_1);
			int num3 = Math.Min(럓.랾.worldSizeX - 1, A_0.x + A_1);
			int num4 = Math.Max(0, A_0.y - A_1);
			int num5 = Math.Min(럓.랾.worldSizeY - 1, A_0.y + A_1);
			for (int i = num2; i <= num3; i++)
			{
				SeedData[] array = plantedSeeds[i];
				if (array != null)
				{
					for (int j = num4; j <= num5; j++)
					{
						SeedData seedData = array[j];
						if (럆.랾(seedData))
						{
							Vector2i position = seedData.position;
							if (럓.랾.IsMapPointInWorld(position) && 럆.럎(A_0, position, A_1))
							{
								float num6 = 럽.랾(A_0, position);
								if (num6 < num)
								{
									num = num6;
									A_2 = position;
								}
							}
						}
					}
				}
			}
			return 럆.랾(A_2);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000AD494 File Offset: 0x000AB694
		private static bool 럎(Vector2i A_0, int A_1, out Vector2i A_2)
		{
			A_2 = 럆.랾;
			float num = float.MaxValue;
			int num2 = Math.Max(0, A_0.x - A_1);
			int num3 = Math.Min(럓.랾.worldSizeX - 1, A_0.x + A_1);
			int num4 = Math.Max(0, A_0.y - A_1);
			int num5 = Math.Min(럓.랾.worldSizeY - 1, A_0.y + A_1);
			for (int i = num2; i <= num3; i++)
			{
				for (int j = num4; j <= num5; j++)
				{
					Vector2i vector2i;
					vector2i..ctor(i, j);
					if (럆.랾(vector2i, A_0, A_1))
					{
						float num6 = 럽.랾(A_0, vector2i);
						if (num6 < num)
						{
							num = num6;
							A_2 = vector2i;
						}
					}
				}
			}
			return 럆.랾(A_2);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000AD560 File Offset: 0x000AB760
		private static bool 랾(out PlayerData.InventoryKey A_0)
		{
			A_0 = default(PlayerData.InventoryKey);
			PlayerData playerData = 럓.랾;
			PlayerData.InventoryKey[] array = (playerData != null) ? playerData.GetInventoryAsOrderedByInventoryItemType() : null;
			if (array == null)
			{
				return false;
			}
			int autoPlantSelectedSeedBlockType = ConfigFile.autoPlantSelectedSeedBlockType;
			foreach (PlayerData.InventoryKey inventoryKey in array)
			{
				if (inventoryKey.itemType == 2 && 럓.랾.GetCount(inventoryKey) > 0 && (autoPlantSelectedSeedBlockType == -1 || inventoryKey.blockType == autoPlantSelectedSeedBlockType))
				{
					A_0 = inventoryKey;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000AD5DC File Offset: 0x000AB7DC
		private static bool 럎(World.BlockType A_0)
		{
			if (A_0 == null || 럓.랾 == null)
			{
				return false;
			}
			bool result;
			try
			{
				PlayerData.InventoryKey inventoryKey;
				inventoryKey..ctor(A_0, 2);
				result = (럓.랾.GetCount(inventoryKey) > 0);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000AD628 File Offset: 0x000AB828
		private static bool 랾(Vector2i A_0, Vector2i A_1, int A_2)
		{
			SeedData seedData;
			return 럓.랾.IsMapPointInWorld(A_0) && 럆.럎(A_1, A_0, A_2) && !(A_0 == A_1) && A_0.y > 0 && 럓.랾.GetBlockType(A_0) == null && !럆.랾(A_0, out seedData) && !럓.랾.IsCollectableAmountFullInMapPoint(A_0) && (ConfigFile.placeSeedsAnywhereToggle || ConfigData.CanPlaceSeedTopOf(럓.랾.GetBlockType(A_0.x, A_0.y - 1)));
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000AD6B4 File Offset: 0x000AB8B4
		private static bool 랾(Vector2i A_0, out SeedData A_1)
		{
			A_1 = null;
			if (럓.랾 == null || !럓.랾.IsMapPointInWorld(A_0))
			{
				return false;
			}
			bool result;
			try
			{
				A_1 = 럓.랾.GetSeedDataAt(A_0.x, A_0.y);
				result = (A_1 != null);
			}
			catch
			{
				A_1 = null;
				result = false;
			}
			return result;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000AD714 File Offset: 0x000AB914
		private static bool 랾(SeedData A_0)
		{
			if (A_0 == null || A_0.blockType == null)
			{
				return false;
			}
			bool result;
			try
			{
				result = (A_0.growthEndTime <= KukouriTime.Get());
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0004054C File Offset: 0x0003E74C
		private static int 랉()
		{
			if (럓.랾 == null || !럓.랾.GetIsPerkActive(11))
			{
				return 3;
			}
			return 4;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00040F38 File Offset: 0x0003F138
		private static bool 럎(Vector2i A_0, Vector2i A_1, int A_2)
		{
			return 럽.랾(A_0, A_1) <= (float)A_2;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000AD758 File Offset: 0x000AB958
		private static Vector2i 럐()
		{
			Vector2i result;
			try
			{
				result = 럓.랾.GetPlayerMapPointForServer();
			}
			catch
			{
				result = 럓.랾.currentPlayerMapPoint;
			}
			return result;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00040F48 File Offset: 0x0003F148
		private static void 랓()
		{
			럆.럎 = 럆.랾;
			럆.람 = 0f;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00040F5E File Offset: 0x0003F15E
		private static void 럯()
		{
			럆.람 = 럆.랾;
			럆.랾 = 0;
			럆.럒 = 0f;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00040F7A File Offset: 0x0003F17A
		private static bool 랾(Vector2i A_0)
		{
			return A_0.x != 럆.랾.x || A_0.y != 럆.랾.y;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000AD794 File Offset: 0x000AB994
		private static string 랾(PlayerData.InventoryKey A_0)
		{
			try
			{
				string blockTypeOrSeedName = TextManager.GetBlockTypeOrSeedName(A_0);
				if (!string.IsNullOrWhiteSpace(blockTypeOrSeedName))
				{
					return blockTypeOrSeedName;
				}
			}
			catch
			{
			}
			return 럆.람(A_0.blockType);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000A200C File Offset: 0x000A020C
		private static string 람(World.BlockType A_0)
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

		// Token: 0x04000682 RID: 1666
		public const int 랾 = -1;

		// Token: 0x04000683 RID: 1667
		private static readonly Vector2i 랾 = new Vector2i(int.MinValue, int.MinValue);

		// Token: 0x04000684 RID: 1668
		private const float 랾 = 0.35f;

		// Token: 0x04000685 RID: 1669
		private const float 럎 = 0.2f;

		// Token: 0x04000686 RID: 1670
		private static string 랾 = string.Empty;

		// Token: 0x04000687 RID: 1671
		private static Vector2i 럎 = 럆.랾;

		// Token: 0x04000688 RID: 1672
		private static float 람;

		// Token: 0x04000689 RID: 1673
		private static Vector2i 람 = 럆.랾;

		// Token: 0x0400068A RID: 1674
		private static World.BlockType 랾 = 0;

		// Token: 0x0400068B RID: 1675
		private static float 럒;

		// Token: 0x0200011B RID: 283
		internal readonly struct 랾
		{
			// Token: 0x060008E0 RID: 2272 RVA: 0x00040FDF File Offset: 0x0003F1DF
			public 랾(World.BlockType A_1, string A_2, short A_3)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.랾 = A_3;
			}

			// Token: 0x060008E1 RID: 2273 RVA: 0x00040FF6 File Offset: 0x0003F1F6
			[CompilerGenerated]
			public World.BlockType 랾()
			{
				return this.랾;
			}

			// Token: 0x060008E2 RID: 2274 RVA: 0x00040FFE File Offset: 0x0003F1FE
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x060008E3 RID: 2275 RVA: 0x00041006 File Offset: 0x0003F206
			[CompilerGenerated]
			public short 람()
			{
				return this.랾;
			}

			// Token: 0x0400068C RID: 1676
			[CompilerGenerated]
			private readonly World.BlockType 랾;

			// Token: 0x0400068D RID: 1677
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x0400068E RID: 1678
			[CompilerGenerated]
			private readonly short 랾;
		}
	}
}
