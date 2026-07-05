using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000138 RID: 312
	internal class 럅
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x00041B64 File Offset: 0x0003FD64
		internal static int 랾()
		{
			return 럅.랾.Length;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00041B6D File Offset: 0x0003FD6D
		internal static string 랾(int A_0)
		{
			if (A_0 < 0 || A_0 >= 럅.랾.Length)
			{
				return 럅.랾[0].랾();
			}
			return 럅.랾[A_0].랾();
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000B7D7C File Offset: 0x000B5F7C
		public static void 럎()
		{
			럧.럴 += Time.deltaTime;
			럧.럲 += Time.deltaTime;
			럅.럒();
			럅.랋();
			럅.랾 랾 = 럅.람();
			if (럧.럴 >= 10f)
			{
				럽.랾("Stay within placement range for " + 랾.랾() + ".", false);
				럧.럴 = 0f;
			}
			if (럓.랾 == null || 럓.랾 == null || 럓.랾 == null || 럓.랾.myPlayerData == null)
			{
				럅.럼();
				if (럧.럲 >= 3f)
				{
					럽.럎("Player data or world not loaded!", false);
					럧.럲 = 0f;
				}
				return;
			}
			if (럓.랾.DoesWorldHaveSmallLocks())
			{
				럅.럼();
				if (럧.럲 >= 5f)
				{
					럽.럎("World Already Has Small Locks!", false);
					럧.럲 = 0f;
				}
				return;
			}
			if (럓.랾.lockWorldDataHelper != null && 럓.랾.lockWorldDataHelper.GetBlockType() != null)
			{
				럅.럼();
				if (럧.럲 >= 5f)
				{
					럽.럎("World Already Has A World Lock!", false);
					럧.럲 = 0f;
				}
				return;
			}
			Il2CppStructArray<PlayerData.InventoryKey> inventoryAsOrderedByInventoryItemType = 럓.랾.myPlayerData.GetInventoryAsOrderedByInventoryItemType();
			if (inventoryAsOrderedByInventoryItemType == null)
			{
				return;
			}
			int num = 럓.랾.GetIsPerkActive(11) ? 4 : 3;
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			Vector2i playerSpawnPosition = 럓.랾.GetPlayerSpawnPosition();
			bool flag = currentPlayerMapPoint == playerSpawnPosition;
			int num2 = 럅.랾(inventoryAsOrderedByInventoryItemType, 랾.람());
			int num3;
			럅.랾(inventoryAsOrderedByInventoryItemType, 랾.람(), out num3);
			int num4;
			럅.랾(inventoryAsOrderedByInventoryItemType, out num4);
			bool flag2 = num2 < 2;
			bool flag3 = false;
			if (flag2)
			{
				flag3 = 럅.랾(랾);
			}
			if (flag && 럅.랾(currentPlayerMapPoint, playerSpawnPosition, num, num4))
			{
				return;
			}
			if (num3 == -1)
			{
				if (flag3)
				{
					return;
				}
				if (럧.럲 >= 5f)
				{
					럽.럎(랾.랾() + " is missing from your inventory.", false);
					럧.럲 = 0f;
				}
				return;
			}
			else
			{
				if (flag && 럅.랾(new Vector2i(playerSpawnPosition.x, playerSpawnPosition.y - 1), num3, currentPlayerMapPoint, num))
				{
					return;
				}
				Vector2i vector2i = 럅.랾(currentPlayerMapPoint, num);
				if (vector2i.x >= 0 && vector2i.y >= 0)
				{
					럅.랾(vector2i, num3, currentPlayerMapPoint, num);
				}
				return;
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000B7FDC File Offset: 0x000B61DC
		private static 럅.랾 람()
		{
			int num = ConfigFile.autoPlaceLockTypeIndex;
			if (num < 0 || num >= 럅.랾.Length)
			{
				num = 3;
				ConfigFile.autoPlaceLockTypeIndex = num;
			}
			return 럅.랾[num];
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000B8010 File Offset: 0x000B6210
		private static void 럒()
		{
			World world = 럓.랾;
			string a = ((world != null) ? world.worldName : null) ?? string.Empty;
			if (a == 럅.랾)
			{
				return;
			}
			럅.랾 = a;
			럅.럼();
			럅.랋 = 0f;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00041B9E File Offset: 0x0003FD9E
		private static void 럼()
		{
			럅.랾 = new Vector2i(-1, -1);
			럅.럎 = new Vector2i(-1, -1);
			럅.랾 = -1;
			럅.럼 = 0f;
			럅.랉 = 0f;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000B805C File Offset: 0x000B625C
		private static void 랋()
		{
			if (럅.랾 == -1)
			{
				if (럅.럎(럅.럎))
				{
					World.BlockType blockType = 럓.랾.GetBlockType(럅.럎);
					if (blockType == null || ConfigData.DoesBlockHaveCollider(blockType))
					{
						럅.럎 = new Vector2i(-1, -1);
						럅.랉 = 0f;
					}
				}
				return;
			}
			if (!럅.럎(럅.랾))
			{
				럅.럼();
				return;
			}
			World.BlockType blockType2 = 럓.랾.GetBlockType(럅.랾);
			if (blockType2 != null)
			{
				if (blockType2 == 럅.랾)
				{
					럅.랾(럅.랾);
				}
				럅.럼();
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000B80EC File Offset: 0x000B62EC
		private static bool 랾(PlayerData.InventoryKey[] A_0, World.BlockType A_1, out int A_2)
		{
			A_2 = -1;
			foreach (PlayerData.InventoryKey inventoryKey in A_0)
			{
				if (inventoryKey.blockType == A_1 && 럓.랾.GetCount(inventoryKey) > 0)
				{
					A_2 = inventoryKey.blockType;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000B8138 File Offset: 0x000B6338
		private static void 랾(World.BlockType A_0)
		{
			Il2CppStructArray<PlayerData.InventoryKey> inventoryAsOrderedByInventoryItemType = 럓.랾.myPlayerData.GetInventoryAsOrderedByInventoryItemType();
			if (inventoryAsOrderedByInventoryItemType == null)
			{
				return;
			}
			foreach (PlayerData.InventoryKey inventoryKey in inventoryAsOrderedByInventoryItemType)
			{
				if (inventoryKey.blockType == A_0)
				{
					if (럓.랾.GetCount(inventoryKey) <= 0)
					{
						break;
					}
					럓.랾.RemoveItemsFromInventory(inventoryKey, 1);
					break;
				}
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000B81B4 File Offset: 0x000B63B4
		private static bool 랾(PlayerData.InventoryKey[] A_0, out int A_1)
		{
			A_1 = -1;
			foreach (PlayerData.InventoryKey inventoryKey in A_0)
			{
				if (inventoryKey.itemType == null && 럓.랾.GetCount(inventoryKey) > 0 && ConfigData.DoesBlockHaveCollider(inventoryKey.blockType) && !ConfigData.IsBlockLock(inventoryKey.blockType) && !럽.랾(inventoryKey.blockType) && !ConfigData.IsBlockPortal(inventoryKey.blockType))
				{
					A_1 = inventoryKey.blockType;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000B8234 File Offset: 0x000B6434
		private static bool 랾(Vector2i A_0, Vector2i A_1, int A_2, int A_3)
		{
			if (A_3 == -1)
			{
				return false;
			}
			foreach (Vector2i vector2i in new Vector2i[]
			{
				new Vector2i(A_1.x - 1, A_1.y),
				new Vector2i(A_1.x + 1, A_1.y)
			})
			{
				if (럅.럎(vector2i) && 럽.랾(A_0, vector2i) <= (float)A_2)
				{
					World.BlockType blockType = 럓.랾.GetBlockType(vector2i);
					if (blockType == null)
					{
						if (럅.랾(vector2i, A_3, A_0, A_2))
						{
							return true;
						}
					}
					else if (!ConfigData.DoesBlockHaveCollider(blockType) && 럅.랾(vector2i))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000B82DC File Offset: 0x000B64DC
		private static bool 랾(Vector2i A_0)
		{
			if (럅.럎 == A_0 && Time.time < 럅.랉)
			{
				return true;
			}
			럽.랾(A_0.x, A_0.y);
			럅.럎 = A_0;
			럅.랉 = Time.time + 0.35f;
			return true;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000B832C File Offset: 0x000B652C
		private static int 랾(PlayerData.InventoryKey[] A_0, World.BlockType A_1)
		{
			foreach (PlayerData.InventoryKey inventoryKey in A_0)
			{
				if (inventoryKey.blockType == A_1)
				{
					return (int)럓.랾.GetCount(inventoryKey);
				}
			}
			return 0;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000B8368 File Offset: 0x000B6568
		private static bool 랾(럅.랾 A_0)
		{
			if (!ConfigFile.autoBuyMissingLockToggle)
			{
				return false;
			}
			if (럓.랾.gems < A_0.럒())
			{
				if (럧.럲 >= 5f)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Need ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(A_0.럒());
					defaultInterpolatedStringHandler.AppendLiteral(" gems to buy ");
					defaultInterpolatedStringHandler.AppendFormatted(A_0.랾());
					defaultInterpolatedStringHandler.AppendLiteral(".");
					럽.럎(defaultInterpolatedStringHandler.ToStringAndClear(), false);
					럧.럲 = 0f;
				}
				return false;
			}
			if (Time.time < 럅.랋)
			{
				return true;
			}
			BSONObject bsonobject = new BSONObject();
			bsonobject["ID"] = "BIPack";
			bsonobject["IPId"] = A_0.럎();
			OutgoingMessages.AddOneMessageToList(bsonobject);
			럽.랾(A_0.럎(), 1);
			럅.랋 = Time.time + 1f;
			럽.랾("Buying " + A_0.랾() + "...", false);
			return true;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000B8480 File Offset: 0x000B6680
		private static Vector2i 랾(Vector2i A_0, int A_1)
		{
			float num = float.MaxValue;
			Vector2i vector2i;
			vector2i..ctor(-1, -1);
			int num2 = Math.Max(0, A_0.x - A_1);
			int num3 = Math.Min(럓.랾.worldSizeX - 1, A_0.x + A_1);
			int num4 = Math.Max(0, A_0.y - A_1);
			int num5 = Math.Min(럓.랾.worldSizeY - 1, A_0.y + A_1);
			for (int i = num4; i <= num5; i++)
			{
				for (int j = num2; j <= num3; j++)
				{
					Vector2i vector2i2;
					vector2i2..ctor(j, i);
					if (!(vector2i2 == A_0) && 럅.랾(vector2i2, A_0, A_1))
					{
						float num6 = 럽.랾(A_0, vector2i2);
						if (num6 <= num && (num6 != num || vector2i.x < 0 || vector2i2.y <= vector2i.y))
						{
							num = num6;
							vector2i = vector2i2;
						}
					}
				}
			}
			return vector2i;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000B8564 File Offset: 0x000B6764
		private static bool 랾(Vector2i A_0, int A_1, Vector2i A_2, int A_3)
		{
			if (!럅.랾(A_0, A_2, A_3))
			{
				return false;
			}
			if (Time.time < 럅.럼)
			{
				return true;
			}
			럽.랾(A_0.x, A_0.y, A_1);
			럅.랾 = A_0;
			럅.랾 = A_1;
			럅.럼 = Time.time + 0.1f;
			return true;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00041BD2 File Offset: 0x0003FDD2
		private static bool 랾(Vector2i A_0, Vector2i A_1, int A_2)
		{
			return 럅.럎(A_0) && 럽.랾(A_1, A_0) <= (float)A_2 && 럓.랾.GetBlockType(A_0) == 0;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00041BF9 File Offset: 0x0003FDF9
		private static bool 럎(Vector2i A_0)
		{
			return A_0.x >= 0 && A_0.y >= 0 && A_0.x < 럓.랾.worldSizeX && A_0.y < 럓.랾.worldSizeY;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000B85BC File Offset: 0x000B67BC
		public static void 랾(int A_0, int A_1)
		{
			Random random = new Random();
			int num = 럓.랾.worldSizeX / 2;
			int num2 = 럓.랾.worldSizeY / 2;
			int performanceTestCollectableOffset = 럓.랾.performanceTestCollectableOffset;
			for (int i = 0; i < A_0; i++)
			{
				Vector2i vector2i;
				vector2i..ctor(random.Next(num - performanceTestCollectableOffset, num + performanceTestCollectableOffset + 1), random.Next(num2 - performanceTestCollectableOffset, num2 + performanceTestCollectableOffset + 1));
				if (vector2i.x == 럓.랾.playerStartPosition.x && (vector2i.y == 럓.랾.playerStartPosition.y || vector2i.y == 럓.랾.playerStartPosition.y + 1))
				{
					vector2i.x++;
				}
				PlayerData.InventoryItemType blockTypeInventoryItemType = ConfigData.GetBlockTypeInventoryItemType(A_1);
				CollectableData collectableData = 럓.랾.AddCollectable(A_1, (short)random.Next(1, 201), blockTypeInventoryItemType, vector2i, null);
				ControllerHelper.worldController.DoCollectableBlockForPerformanceTest(collectableData);
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000B86BC File Offset: 0x000B68BC
		public static void 랉()
		{
			if (Array.IndexOf<string>(럅.랾, 럓.랾.worldName) < 0)
			{
				return;
			}
			foreach (KeyValuePair<int, AIEnemyMonoBehaviourBase> keyValuePair in ControllerHelper.worldController.aiEnemyMonoBehaviours)
			{
				keyValuePair.value.isActive = false;
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000B870C File Offset: 0x000B690C
		public static void 럐()
		{
			if (NetworkPlayers.otherPlayers == null)
			{
				return;
			}
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				NetworkPlayers.otherPlayers.Remove(networkPlayer);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00041C33 File Offset: 0x0003FE33
		public static void 랓()
		{
			if (!럽.랾(럓.랾))
			{
				return;
			}
			럅.랾(new Func<World.BlockType, bool>(럅.럎.랾.랾), 3);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00041C67 File Offset: 0x0003FE67
		public static void 럯()
		{
			CinematicsAnimation cinematicsAnimation = 럅.란();
			if (cinematicsAnimation == null)
			{
				return;
			}
			cinematicsAnimation.SkipButtonPressed();
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000B8748 File Offset: 0x000B6948
		public static void 럭()
		{
			if (!럽.랾() || LoadingScreenController.instance.isActiveAndEnabled)
			{
				return;
			}
			if (럓.랾.worldName != "SECRETBASE")
			{
				럽.랾("Enter The Secret Base First!", false);
				럧.럺 = false;
				return;
			}
			if (NetworkPlayers.GetNetworkPlayersCount() > 0)
			{
				럽.랾("Found A Party!", false);
				럧.럺 = false;
				return;
			}
			럽.랾("Requeuing Matchmaking!", false);
			SceneLoader.ReloadWorld();
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00041C78 File Offset: 0x0003FE78
		public static void 랱()
		{
			if (럓.랾.worldLightingType != null)
			{
				ControllerHelper.rootUI.RemoveWorldLighting();
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00041C90 File Offset: 0x0003FE90
		public static void 럙()
		{
			럅.랾(true, ConfigFile.autoKickFullAccess, ConfigFile.autoKickMinorAccess, new Action(럅.럎.랾.랾));
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00041CC1 File Offset: 0x0003FEC1
		public static void 랫()
		{
			럅.랾(false, ConfigFile.autoBanFullAccess, ConfigFile.autoBanMinorAccess, new Action(럅.럎.랾.럎));
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000B87BC File Offset: 0x000B69BC
		private static void 랾(bool A_0, bool A_1, bool A_2, Action A_3)
		{
			if (!럽.랉() && !럽.랋())
			{
				A_3();
				return;
			}
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (networkPlayer != null)
				{
					bool flag = 럽.럐();
					bool flag2 = 럽.랓();
					if (럅.랾(flag, flag2, A_1, A_2))
					{
						if (A_0)
						{
							OutgoingMessages.KickPlayer(networkPlayer.clientId);
						}
						else
						{
							OutgoingMessages.BanAndKickPlayer(networkPlayer.clientId);
						}
					}
				}
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00041CF2 File Offset: 0x0003FEF2
		private static bool 랾(bool A_0, bool A_1, bool A_2, bool A_3)
		{
			return (!A_0 && !A_1) || ((!A_0 || A_2) && (!A_1 || A_3));
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000B882C File Offset: 0x000B6A2C
		public static void 럍()
		{
			if (럓.랾 == null)
			{
				return;
			}
			bool flag = 럽.랾(럓.랾, 2007) && 럓.랾.GetBlockCountInWorldFromAnyLayer(2007) >= 30;
			bool flag2 = 럽.랾(럓.랾, 2166) && 럓.랾.GetBlockCountInWorldFromAnyLayer(2166) >= 30;
			if (!flag && !flag2)
			{
				return;
			}
			for (int i = 0; i < 럓.랾.worldSizeY; i++)
			{
				for (int j = 0; j < 럓.랾.worldSizeX; j++)
				{
					World.BlockType blockType = 럓.랾.GetBlockType(j, i);
					if (flag && blockType == 2007)
					{
						럅.랾(j, i, 3);
					}
					else if (flag2 && blockType == 2166)
					{
						럅.랾(j, i, 2146);
					}
				}
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000B8904 File Offset: 0x000B6B04
		public static void 랬()
		{
			WiringWireController wiringWireController = 럅.럇();
			if (wiringWireController != null)
			{
				Object.Destroy(wiringWireController);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000A83DC File Offset: 0x000A65DC
		private static 랾 랾<랾>(ref 랾 A_0, ref float A_1) where 랾 : Object
		{
			if (A_0 != null)
			{
				return A_0;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (realtimeSinceStartup < A_1)
			{
				return default(랾);
			}
			A_1 = realtimeSinceStartup + 0.35f;
			A_0 = Object.FindObjectOfType<랾>();
			return A_0;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00041D0D File Offset: 0x0003FF0D
		private static CinematicsAnimation 란()
		{
			return 럅.랾<CinematicsAnimation>(ref 럅.랾, ref 럅.럐);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00041D1E File Offset: 0x0003FF1E
		private static WiringWireController 럇()
		{
			return 럅.랾<WiringWireController>(ref 럅.랾, ref 럅.랓);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00041D2F File Offset: 0x0003FF2F
		public static int 럎(World.BlockType A_0)
		{
			if (ConfigData.IsFish(A_0))
			{
				return ConfigData.GetFishRecycleValueForFishRecycler(A_0);
			}
			if (ConfigData.IsBlockMiningGemstone(A_0))
			{
				return ConfigData.GetGemstoneRecycleValueForMiningGemstoneRecycler(A_0);
			}
			if (ConfigData.IsConsumableTreasurePouch(A_0))
			{
				return ConfigData.GetTreasurePouchRewardAmount(A_0);
			}
			return 0;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000B8928 File Offset: 0x000B6B28
		private static void 랾(int A_0, int A_1, World.BlockType A_2)
		{
			Vector2i vector2i;
			vector2i..ctor(A_0, A_1);
			ControllerHelper.worldController.SetBlock(A_2, A_0, A_1);
			럓.랾.SetBlock(A_2, A_0, A_1, 럓.랾.GetOwnerOfTheMapPointPlayerID(vector2i), 럓.랾.GetOwnerOfTheMapPoint(vector2i), false);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000B8970 File Offset: 0x000B6B70
		private static void 랾(Func<World.BlockType, bool> A_0, World.BlockType A_1)
		{
			for (int i = 0; i < 럓.랾.worldSizeY; i++)
			{
				for (int j = 0; j < 럓.랾.worldSizeX; j++)
				{
					if (A_0(럓.랾.GetBlockType(j, i)))
					{
						럅.랾(j, i, A_1);
					}
				}
			}
		}

		// Token: 0x04000731 RID: 1841
		private const float 랾 = 0.1f;

		// Token: 0x04000732 RID: 1842
		private const float 럎 = 1f;

		// Token: 0x04000733 RID: 1843
		private const float 람 = 0.35f;

		// Token: 0x04000734 RID: 1844
		private const float 럒 = 0.35f;

		// Token: 0x04000735 RID: 1845
		private static string 랾 = string.Empty;

		// Token: 0x04000736 RID: 1846
		private static Vector2i 랾 = new Vector2i(-1, -1);

		// Token: 0x04000737 RID: 1847
		private static Vector2i 럎 = new Vector2i(-1, -1);

		// Token: 0x04000738 RID: 1848
		private static int 랾 = -1;

		// Token: 0x04000739 RID: 1849
		private static float 럼 = 0f;

		// Token: 0x0400073A RID: 1850
		private static float 랋 = 0f;

		// Token: 0x0400073B RID: 1851
		private static float 랉 = 0f;

		// Token: 0x0400073C RID: 1852
		private static CinematicsAnimation 랾;

		// Token: 0x0400073D RID: 1853
		private static float 럐;

		// Token: 0x0400073E RID: 1854
		private static WiringWireController 랾;

		// Token: 0x0400073F RID: 1855
		private static float 랓;

		// Token: 0x04000740 RID: 1856
		private static readonly 럅.랾[] 랾 = new 럅.랾[]
		{
			new 럅.랾("Small Lock", "SmallLock", 410, 100),
			new 럅.랾("Medium Lock", "MediumLock", 411, 500),
			new 럅.랾("Large Lock", "LargeLock", 412, 1000),
			new 럅.랾("World Lock", "WorldLock", 413, 3500),
			new 럅.랾("Dark Lock", "DarkLock", 882, 28000),
			new 럅.랾("Platinum Lock", "PlatinumLock", 796, 350000),
			new 럅.랾("Battle Lock", "BattleLock", 1132, 3000),
			new 럅.랾("Battle World Lock", "BattleWorldLock", 1131, 7500)
		};

		// Token: 0x04000741 RID: 1857
		private static readonly string[] 랾 = new string[]
		{
			"NETHERWORLD",
			"DEEPNETHER",
			"SECRETBASE",
			"MINEWORLD"
		};

		// Token: 0x04000742 RID: 1858
		private const int 럎 = 30;

		// Token: 0x02000139 RID: 313
		private readonly struct 랾
		{
			// Token: 0x06000A56 RID: 2646 RVA: 0x00041D5F File Offset: 0x0003FF5F
			public 랾(string A_1, string A_2, World.BlockType A_3, int A_4)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.랾 = A_3;
				this.랾 = A_4;
			}

			// Token: 0x06000A57 RID: 2647 RVA: 0x00041D7E File Offset: 0x0003FF7E
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000A58 RID: 2648 RVA: 0x00041D86 File Offset: 0x0003FF86
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x06000A59 RID: 2649 RVA: 0x00041D8E File Offset: 0x0003FF8E
			[CompilerGenerated]
			public World.BlockType 람()
			{
				return this.랾;
			}

			// Token: 0x06000A5A RID: 2650 RVA: 0x00041D96 File Offset: 0x0003FF96
			[CompilerGenerated]
			public int 럒()
			{
				return this.랾;
			}

			// Token: 0x04000743 RID: 1859
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000744 RID: 1860
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x04000745 RID: 1861
			[CompilerGenerated]
			private readonly World.BlockType 랾;

			// Token: 0x04000746 RID: 1862
			[CompilerGenerated]
			private readonly int 랾;
		}

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x06000A5D RID: 2653 RVA: 0x00041DAA File Offset: 0x0003FFAA
			internal bool 랾(World.BlockType A_1)
			{
				return 럽.럒(A_1);
			}

			// Token: 0x06000A5E RID: 2654 RVA: 0x00041DB2 File Offset: 0x0003FFB2
			internal void 랾()
			{
				ConfigFile.autoKickToggle = false;
				ConfigFile.autoKickFullAccess = false;
				ConfigFile.autoKickMinorAccess = false;
				럽.랾(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩랂(), false);
			}

			// Token: 0x06000A5F RID: 2655 RVA: 0x00041DD1 File Offset: 0x0003FFD1
			internal void 럎()
			{
				ConfigFile.autoBanToggle = false;
				ConfigFile.autoBanFullAccess = false;
				ConfigFile.autoBanMinorAccess = false;
				럽.랾(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩래(), false);
			}

			// Token: 0x04000747 RID: 1863
			public static readonly 럅.럎 랾 = new 럅.럎();

			// Token: 0x04000748 RID: 1864
			public static Func<World.BlockType, bool> 랾;

			// Token: 0x04000749 RID: 1865
			public static Action 랾;

			// Token: 0x0400074A RID: 1866
			public static Action 럎;
		}
	}
}
