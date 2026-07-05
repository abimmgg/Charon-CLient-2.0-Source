using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ImGuiNET;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000136 RID: 310
	internal class 럠
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x000B5B64 File Offset: 0x000B3D64
		public static void 랾()
		{
			if (럽.랾() && 럓.랾 != null)
			{
				WorldController worldController = ControllerHelper.worldController;
				if (((worldController != null) ? worldController.world : null) != null)
				{
					Vector2i vector2i;
					if (!럠.랾(out vector2i))
					{
						return;
					}
					if (!럓.랾.IsMapPointInWorld(vector2i))
					{
						return;
					}
					WorldItemBase worldItemData = ControllerHelper.worldController.world.GetWorldItemData(vector2i.x, vector2i.y);
					World.BlockType blockType = 럓.랾.GetBlockType(vector2i);
					ImGui.BeginTooltip();
					try
					{
						if (!ConfigFile.alwaysShowToolTipToggle)
						{
							럠.랾(vector2i, blockType);
						}
						럠.랾(vector2i);
						럠.랾(worldItemData);
						럠.럎(worldItemData);
						럠.람(worldItemData);
						럠.럒(worldItemData);
						럠.럼(worldItemData);
						럠.랋(worldItemData);
						럠.랉(worldItemData);
						럠.럐(worldItemData);
						럠.랾(vector2i, worldItemData);
						럠.랓(worldItemData);
						럠.럯(worldItemData);
						럠.럎(vector2i, blockType);
						럠.랾(vector2i, worldItemData, blockType);
						럠.럎(vector2i);
						럠.랾(worldItemData, blockType);
						럠.럎(worldItemData, blockType);
						럠.람(worldItemData, blockType);
						럠.럒(worldItemData, blockType);
						럠.럼(worldItemData, blockType);
						럠.랋(worldItemData, blockType);
						럠.랉(worldItemData, blockType);
						럠.럐(worldItemData, blockType);
					}
					catch
					{
						ImGui.Text("(tooltip unavailable)");
					}
					finally
					{
						ImGui.EndTooltip();
					}
					return;
				}
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000B5CB0 File Offset: 0x000B3EB0
		private static bool 랾(out Vector2i A_0)
		{
			A_0 = default(Vector2i);
			Camera main = Camera.main;
			if (main == null)
			{
				return false;
			}
			Vector2 mousePos = ImGui.GetMousePos();
			Vector2 vector;
			vector..ctor(mousePos.X, (float)Screen.height - mousePos.Y);
			Vector3 vector2 = main.ScreenToWorldPoint(new Vector3(vector.x, vector.y, main.nearClipPlane));
			A_0 = 럽.랾(vector2);
			return true;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000B5D28 File Offset: 0x000B3F28
		private static void 랾(Vector2i A_0, World.BlockType A_1)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Block Type: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			defaultInterpolatedStringHandler.AppendLiteral(" X:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_0.x);
			defaultInterpolatedStringHandler.AppendLiteral(" Y:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_0.y);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (A_1 == null)
			{
				return;
			}
			float value = (float)ConfigData.GetBlockDropBlockPercentage(A_1);
			float value2 = (float)ConfigData.GetTreeExtraDropChance(A_1);
			float value3 = (float)ConfigData.GetBlockDropSeedPercentage(A_1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(28, 3);
			defaultInterpolatedStringHandler2.AppendLiteral("Drop: ");
			defaultInterpolatedStringHandler2.AppendFormatted<float>(value);
			defaultInterpolatedStringHandler2.AppendLiteral("% | Extra: ");
			defaultInterpolatedStringHandler2.AppendFormatted<float>(value2);
			defaultInterpolatedStringHandler2.AppendLiteral("% | Seed: ");
			defaultInterpolatedStringHandler2.AppendFormatted<float>(value3);
			defaultInterpolatedStringHandler2.AppendLiteral("%");
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			string blockTier = ConfigData.GetBlockTier(A_1);
			int blockComplexity = ConfigData.GetBlockComplexity(A_1);
			int blockMaxCountInWorld = ConfigData.GetBlockMaxCountInWorld(A_1);
			PlayerData.InventoryItemType blockTypeInventoryItemType = ConfigData.GetBlockTypeInventoryItemType(A_1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(30, 3);
			defaultInterpolatedStringHandler3.AppendLiteral("Tier: ");
			defaultInterpolatedStringHandler3.AppendFormatted(blockTier);
			defaultInterpolatedStringHandler3.AppendLiteral(" | Type: ");
			defaultInterpolatedStringHandler3.AppendFormatted<PlayerData.InventoryItemType>(blockTypeInventoryItemType);
			defaultInterpolatedStringHandler3.AppendLiteral(" | Complexity: ");
			defaultInterpolatedStringHandler3.AppendFormatted<int>(blockComplexity);
			ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
			if (blockMaxCountInWorld > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler4.AppendLiteral("Max In World: ");
				defaultInterpolatedStringHandler4.AppendFormatted<int>(blockMaxCountInWorld);
				ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
			}
			int blockDropGemRangeMin = (int)ConfigData.GetBlockDropGemRangeMin(A_1);
			int blockDropGemRangeMax = (int)ConfigData.GetBlockDropGemRangeMax(A_1);
			if (blockDropGemRangeMin > 0 || blockDropGemRangeMax > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler5.AppendLiteral("Gem Drop: ");
				defaultInterpolatedStringHandler5.AppendFormatted<int>(blockDropGemRangeMin);
				defaultInterpolatedStringHandler5.AppendLiteral("-");
				defaultInterpolatedStringHandler5.AppendFormatted<int>(blockDropGemRangeMax);
				ImGui.Text(defaultInterpolatedStringHandler5.ToStringAndClear());
			}
			if (ConfigData.IsBlockFarmable(A_1))
			{
				double blockFarmability = ConfigData.GetBlockFarmability(A_1);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler6.AppendLiteral("Farmability: ");
				defaultInterpolatedStringHandler6.AppendFormatted<double>(blockFarmability, "F2");
				ImGui.Text(defaultInterpolatedStringHandler6.ToStringAndClear());
			}
			int blockHitsLeft = 럓.랾.GetBlockHitsLeft(A_0.x, A_0.y);
			int blockDurability = ConfigData.GetBlockDurability(A_1);
			if (blockDurability > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler7.AppendLiteral("Hits: ");
				defaultInterpolatedStringHandler7.AppendFormatted<int>(blockHitsLeft);
				defaultInterpolatedStringHandler7.AppendLiteral("/");
				defaultInterpolatedStringHandler7.AppendFormatted<int>(blockDurability);
				ImGui.Text(defaultInterpolatedStringHandler7.ToStringAndClear());
			}
			int blockLevelRequirement = ConfigData.GetBlockLevelRequirement(A_1);
			if (blockLevelRequirement > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler8 = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler8.AppendLiteral("Level Req: ");
				defaultInterpolatedStringHandler8.AppendFormatted<int>(blockLevelRequirement);
				ImGui.Text(defaultInterpolatedStringHandler8.ToStringAndClear());
			}
			if (ConfigData.IsBlockUntradeable(A_1))
			{
				ImGui.Text("[Untradeable]");
			}
			World.BlockType blockBackgroundType = 럓.랾.GetBlockBackgroundType(A_0);
			if (blockBackgroundType != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler9 = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler9.AppendLiteral("Background: ");
				defaultInterpolatedStringHandler9.AppendFormatted<World.BlockType>(blockBackgroundType);
				ImGui.Text(defaultInterpolatedStringHandler9.ToStringAndClear());
			}
			World.BlockType blockWaterType = 럓.랾.GetBlockWaterType(A_0);
			if (blockWaterType != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler10 = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler10.AppendLiteral("Water: ");
				defaultInterpolatedStringHandler10.AppendFormatted<World.BlockType>(blockWaterType);
				ImGui.Text(defaultInterpolatedStringHandler10.ToStringAndClear());
			}
			World.BlockType blockWiringType = 럓.랾.GetBlockWiringType(A_0);
			if (blockWiringType != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler11 = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler11.AppendLiteral("Wiring: ");
				defaultInterpolatedStringHandler11.AppendFormatted<World.BlockType>(blockWiringType);
				ImGui.Text(defaultInterpolatedStringHandler11.ToStringAndClear());
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000B60A8 File Offset: 0x000B42A8
		public static void 랾(Vector2i A_0)
		{
			NetworkPlayer[] array;
			try
			{
				List<NetworkPlayer> otherPlayers = NetworkPlayers.otherPlayers;
				array = ((otherPlayers != null) ? otherPlayers.ToArray() : null);
			}
			catch
			{
				return;
			}
			if (array == null)
			{
				return;
			}
			foreach (NetworkPlayer networkPlayer in array)
			{
				if (networkPlayer != null && !(NetworkPlayers.GetOtherPlayerMapPoint(networkPlayer.clientId) != A_0))
				{
					string nameWithId = NetworkPlayers.GetNameWithId(networkPlayer.clientId, false);
					ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
					ImGui.Text("Player: " + nameWithId);
					ImGui.Text("ID: " + networkPlayer.clientId);
					if (럧.랾.ContainsKey(networkPlayer.clientId))
					{
						ImGui.PushStyleColor(0, 4278190335U);
						ImGui.Text("STAFF: " + 럧.랾[networkPlayer.clientId]);
						ImGui.PopStyleColor();
					}
					럠.랾(networkPlayer.clientId);
					럠.럎(networkPlayer.name);
					if (networkPlayer.playerScript != null)
					{
						if (networkPlayer.playerScript.isDead)
						{
							ImGui.Text("State: Dead");
						}
						else if (networkPlayer.playerScript.isSwimming)
						{
							ImGui.Text("State: Swimming");
						}
						else if (networkPlayer.playerScript.isPortalAnimationActive)
						{
							ImGui.Text("State: In Portal");
						}
					}
				}
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000B620C File Offset: 0x000B440C
		private static void 랾(string A_0)
		{
			foreach (ValueTuple<string, int, int> valueTuple in 럧.랾)
			{
				if (!(valueTuple.Item1 != A_0))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Gems: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Item2);
					defaultInterpolatedStringHandler.AppendLiteral(" | Level: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Item3);
					ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
					break;
				}
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000B62B0 File Offset: 0x000B44B0
		private static void 럎(string A_0)
		{
			foreach (KeyValuePair<string, int> keyValuePair in 럧.랾)
			{
				string nameWithId = NetworkPlayers.GetNameWithId(keyValuePair.Key, true);
				if (!(A_0 != nameWithId))
				{
					ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
					string value = (keyValuePair.Value == 1) ? "Star" : "Stars";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Rated World: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(value);
					ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000B6380 File Offset: 0x000B4580
		public static void 랾(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsBlockPortal(A_0.blockType) || A_0.blockType == 110)
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			string str = 럠.럎(asBSON, "targetWorldID");
			string str2 = 럠.럎(asBSON, "entryPointID");
			string str3 = 럠.럎(asBSON, "targetEntryPointID");
			bool flag = 럠.럼(asBSON, "isLocked");
			ImGui.Text("Target World: " + str);
			ImGui.Text("Entry ID: " + str2 + " → Target ID: " + str3);
			ImGui.Text("Status: " + (flag ? "Locked" : "Unlocked"));
			if (flag)
			{
				bool flag2 = 럽.랉() || 럽.랋();
				ImGui.Text("Access: " + (flag2 ? "Granted" : "Denied"));
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000B6460 File Offset: 0x000B4660
		public static void 럎(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsBlockStorage(A_0.blockType))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Storage (");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0.blockType);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			럠.랾(asBSON, "storageItemsAsInventoryKeys", "storageItemsAmounts", "Item");
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x000B64E0 File Offset: 0x000B46E0
		public static void 람(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsBlockDonationBox(A_0.blockType))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			ImGui.Text("Donation Box");
			int num = 럠.람(asBSON, "minRarity");
			if (num > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Min Rarity: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			럠.랾(asBSON, "itemsAsInventoryKeys", "itemsAmounts", "Donated");
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x000B6568 File Offset: 0x000B4768
		private static void 랾(BSONObject A_0, string A_1, string A_2, string A_3)
		{
			try
			{
				List<int> int32ListValue = A_0[A_1].int32ListValue;
				List<int> int32ListValue2 = A_0[A_2].int32ListValue;
				if (int32ListValue.Count == 0)
				{
					ImGui.Text("(Empty)");
				}
				else if (int32ListValue.Count == int32ListValue2.Count)
				{
					int num = 0;
					for (int i = 0; i < int32ListValue.Count; i++)
					{
						PlayerData.InventoryKey inventoryKey = PlayerData.InventoryKey.IntToInventoryKey(int32ListValue[i]);
						PlayerData.InventoryItemType blockTypeInventoryItemType = ConfigData.GetBlockTypeInventoryItemType(inventoryKey.blockType);
						string blockTier = ConfigData.GetBlockTier(inventoryKey.blockType);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 4);
						defaultInterpolatedStringHandler.AppendFormatted(A_3);
						defaultInterpolatedStringHandler.AppendLiteral(": ");
						defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(inventoryKey.blockType);
						defaultInterpolatedStringHandler.AppendLiteral(" x");
						defaultInterpolatedStringHandler.AppendFormatted<int>(int32ListValue2[i]);
						defaultInterpolatedStringHandler.AppendLiteral(" (T");
						defaultInterpolatedStringHandler.AppendFormatted(blockTier);
						defaultInterpolatedStringHandler.AppendLiteral(")");
						global::랾.럼.랾(blockTypeInventoryItemType, defaultInterpolatedStringHandler.ToStringAndClear());
						num += int32ListValue2[i];
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("Total: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(int32ListValue.Count);
					defaultInterpolatedStringHandler2.AppendLiteral(" types, ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler2.AppendLiteral(" items");
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000B66E8 File Offset: 0x000B48E8
		public static void 럒(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsBlockLockWorld(A_0.blockType))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			string str = 럠.럎(asBSON, "playerWhoOwnsLockName");
			string text = 럠.럎(asBSON, "playerWhoOwnsLockId");
			string a = text;
			PlayerData playerData = 럓.랾;
			bool flag = a == ((playerData != null) ? playerData.playerId : null);
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("World Lock: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0.blockType);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.Text("Owner: " + str + (flag ? " (YOU)" : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()));
			ImGui.Text("Owner ID: " + text);
			string str2 = 럠.럎(asBSON, "isOpen");
			string str3 = 럠.럎(asBSON, "isBattleOn");
			ImGui.Text("Open: " + str2 + " | Battle: " + str3);
			try
			{
				int count = asBSON["playersWhoHaveAccessToLock"].stringListValue.Count;
				int count2 = asBSON["playersWhoHaveMinorAccessToLock"].stringListValue.Count;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("Full Rights: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(count);
				defaultInterpolatedStringHandler2.AppendLiteral(" | Minor Rights: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(count2);
				ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			}
			catch
			{
			}
			try
			{
				DateTime dateTimeValue = asBSON["creationTime"].dateTimeValue;
				DateTime dateTimeValue2 = asBSON["lastActivatedTime"].dateTimeValue;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler3.AppendLiteral("Created: ");
				defaultInterpolatedStringHandler3.AppendFormatted<DateTime>(dateTimeValue);
				ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler4.AppendLiteral("Last Active: ");
				defaultInterpolatedStringHandler4.AppendFormatted<DateTime>(dateTimeValue2);
				ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
				TimeSpan timeSpan = DateTime.Now - dateTimeValue;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler5.AppendLiteral("Lock Age: ");
				defaultInterpolatedStringHandler5.AppendFormatted<int>(timeSpan.Days);
				defaultInterpolatedStringHandler5.AppendLiteral("d ");
				defaultInterpolatedStringHandler5.AppendFormatted<int>(timeSpan.Hours);
				defaultInterpolatedStringHandler5.AppendLiteral("h");
				ImGui.Text(defaultInterpolatedStringHandler5.ToStringAndClear());
			}
			catch
			{
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000B694C File Offset: 0x000B4B4C
		public static void 럼(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsBlockLockSmall(A_0.blockType))
			{
				return;
			}
			if (ConfigData.IsBlockLockWorld(A_0.blockType))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			string str = 럠.럎(asBSON, "playerWhoOwnsLockName");
			string text = 럠.럎(asBSON, "playerWhoOwnsLockId");
			string a = text;
			PlayerData playerData = 럓.랾;
			bool flag = a == ((playerData != null) ? playerData.playerId : null);
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Small Lock: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0.blockType);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.Text("Owner: " + str + (flag ? " (YOU)" : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()));
			ImGui.Text("Owner ID: " + text);
			try
			{
				int count = asBSON["playersWhoHaveAccessToLock"].stringListValue.Count;
				int count2 = asBSON["playersWhoHaveMinorAccessToLock"].stringListValue.Count;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("Full Rights: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(count);
				defaultInterpolatedStringHandler2.AppendLiteral(" | Minor Rights: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(count2);
				ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			}
			catch
			{
			}
			try
			{
				DateTime dateTimeValue = asBSON["creationTime"].dateTimeValue;
				TimeSpan timeSpan = DateTime.Now - dateTimeValue;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler3.AppendLiteral("Age: ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(timeSpan.Days);
				defaultInterpolatedStringHandler3.AppendLiteral("d ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(timeSpan.Hours);
				defaultInterpolatedStringHandler3.AppendLiteral("h");
				ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
			}
			catch
			{
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000B6B24 File Offset: 0x000B4D24
		public static void 랋(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsDisplayBlock(A_0.blockType))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			string str = 럠.럎(asBSON, "text");
			string text = 럠.럎(asBSON, "blockType");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Display Case: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0.blockType);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (!string.IsNullOrEmpty(text) && text != "0" && text != "None")
			{
				ImGui.Text("Displaying: " + text);
				ImGui.Text("Label: " + str);
				return;
			}
			ImGui.Text("(Empty)");
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000B6BE8 File Offset: 0x000B4DE8
		public static void 랉(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsBlockGiftBox(A_0.blockType))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			ImGui.Text("Gift Box");
			string text = 럠.럎(asBSON, "blockType");
			int value = 럠.람(asBSON, "itemAmount");
			int num = 럠.람(asBSON, "takeAmount");
			if (!string.IsNullOrEmpty(text) && text != "0" && text != "None")
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Item: ");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(" x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
				ImGui.Text("Take Limit: " + ((num > 0) ? num.ToString() : "Unlimited"));
				int num2 = 럠.람(asBSON, "giftBoxesCollected");
				if (num2 > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Times Taken: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(num2);
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
					return;
				}
			}
			else
			{
				ImGui.Text("(Empty)");
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000B6D18 File Offset: 0x000B4F18
		public static void 럐(WorldItemBase A_0)
		{
			if (A_0 == null || !ConfigData.IsAnyDoor(A_0.blockType))
			{
				return;
			}
			bool flag = 럠.럼(A_0.GetAsBSON(), "isLocked");
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Door: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0.blockType);
			defaultInterpolatedStringHandler.AppendLiteral(" = ");
			defaultInterpolatedStringHandler.AppendFormatted(flag ? "Closed" : "Open");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (ConfigData.IsBlockPortalWireable(A_0.blockType))
			{
				ImGui.Text("(Wireable)");
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000B6DBC File Offset: 0x000B4FBC
		public static void 랾(Vector2i A_0, WorldItemBase A_1)
		{
			if (A_1 == null)
			{
				return;
			}
			World.BlockType blockType = 럓.랾.GetBlockType(A_0.x, A_0.y);
			if (Array.IndexOf<World.BlockType>(럠.랾, blockType) < 0)
			{
				return;
			}
			string text = 럠.럎(A_1.GetAsBSON(), "text");
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Sign (");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(blockType);
			defaultInterpolatedStringHandler.AppendLiteral("):");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.TextWrapped(text);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000B6E48 File Offset: 0x000B5048
		public static void 랓(WorldItemBase A_0)
		{
			if (A_0 == null)
			{
				return;
			}
			if (A_0.blockType != 3605 && A_0.blockType != 4475)
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			try
			{
				List<string> stringListValue = asBSON["messages"].stringListValue;
				List<string> stringListValue2 = asBSON["playerIds"].stringListValue;
				ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Guest Book (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(stringListValue.Count);
				defaultInterpolatedStringHandler.AppendLiteral(" entries)");
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
				int num = Math.Min(stringListValue.Count, stringListValue2.Count);
				int num2 = Math.Min(num, 10);
				for (int i = 0; i < num2; i++)
				{
					string nameWithId = NetworkPlayers.GetNameWithId(stringListValue2[i], false);
					ImGui.Text("  " + nameWithId + ": " + stringListValue[i]);
				}
				if (num > num2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("  ... +");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(num - num2);
					defaultInterpolatedStringHandler2.AppendLiteral(" more entries");
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000B6F9C File Offset: 0x000B519C
		public static void 럯(WorldItemBase A_0)
		{
			if (A_0 == null)
			{
				return;
			}
			if (!A_0.blockType.ToString().Contains("Mannequin") && A_0.blockType != 3300)
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Mannequin: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0.blockType);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			string text = 럠.럎(asBSON, "mannequinName");
			string text2 = 럠.럎(asBSON, "mannequinGender");
			string text3 = 럠.럎(asBSON, "mannequinDirection");
			if (!string.IsNullOrEmpty(text))
			{
				ImGui.Text("Name: " + text);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				ImGui.Text("Gender: " + text2);
			}
			if (!string.IsNullOrEmpty(text3))
			{
				ImGui.Text("Facing: " + text3);
			}
			럠.랾(asBSON, "equippedItems");
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000B7090 File Offset: 0x000B5290
		private static void 랾(BSONObject A_0, string A_1)
		{
			try
			{
				if (A_0.ContainsKey(A_1))
				{
					List<int> int32ListValue = A_0[A_1].int32ListValue;
					if (int32ListValue != null && int32ListValue.Count != 0)
					{
						for (int i = 0; i < int32ListValue.Count; i++)
						{
							if (int32ListValue[i] != 0)
							{
								PlayerData.InventoryKey inventoryKey = PlayerData.InventoryKey.IntToInventoryKey(int32ListValue[i]);
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
								defaultInterpolatedStringHandler.AppendLiteral("  Wearing: ");
								defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(inventoryKey.blockType);
								ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000B7130 File Offset: 0x000B5330
		private static void 럎(Vector2i A_0, World.BlockType A_1)
		{
			if (!ConfigData.IsBlockCheckPoint(A_1) && !ConfigData.IsBlockStartPoint(A_1) && !ConfigData.IsBlockFinishLine(A_1))
			{
				return;
			}
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			if (ConfigData.IsBlockStartPoint(A_1))
			{
				bool flag = 럓.랾.GetPlayerSpawnPosition() == A_0;
				ImGui.Text("Start Point" + (flag ? " (Active Spawn)" : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()));
				return;
			}
			if (ConfigData.IsBlockFinishLine(A_1))
			{
				ImGui.Text("Finish Line");
				return;
			}
			ImGui.Text("Checkpoint");
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000B71B8 File Offset: 0x000B53B8
		private static void 랾(Vector2i A_0, WorldItemBase A_1, World.BlockType A_2)
		{
			if (!ConfigData.IsBlockTrap(A_2) && !ConfigData.IsBlockShooterTrap(A_2) && !ConfigData.IsBlockDamageBeamTrap(A_2))
			{
				return;
			}
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Trap: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_2);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (A_1 != null)
			{
				BSONObject asBSON = A_1.GetAsBSON();
				int num = 럠.람(asBSON, "trapFrequencyType");
				if (num > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Frequency: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(num);
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
				}
				int num2 = 럠.람(asBSON, "trapMode");
				if (num2 > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("Mode: ");
					defaultInterpolatedStringHandler3.AppendFormatted<int>(num2);
					ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
				}
			}
			bool value = 럓.랾.CheckShouldTrapBeOn(new Vector2i(A_0.x, A_0.y), false, null);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler4.AppendLiteral("Active: ");
			defaultInterpolatedStringHandler4.AppendFormatted<bool>(value);
			ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
			if (ConfigData.IsBlockDamageBeamTrap(A_2) && 럓.랾.IsDamageBeamActiveInMapPoint(A_0))
			{
				World.BlockType activeDamageBeamBlockType = 럓.랾.GetActiveDamageBeamBlockType(A_0);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler5.AppendLiteral("Beam: ");
				defaultInterpolatedStringHandler5.AppendFormatted<World.BlockType>(activeDamageBeamBlockType);
				defaultInterpolatedStringHandler5.AppendLiteral(" (Active)");
				ImGui.Text(defaultInterpolatedStringHandler5.ToStringAndClear());
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000B732C File Offset: 0x000B552C
		private static void 럎(Vector2i A_0)
		{
			World world = 럓.랾;
			if (((world != null) ? world.plantedSeeds : null) == null || !럓.랾.IsMapPointInWorld(A_0))
			{
				return;
			}
			SeedData seedDataAt;
			try
			{
				seedDataAt = 럓.랾.GetSeedDataAt(A_0.x, A_0.y);
			}
			catch
			{
				return;
			}
			if (seedDataAt == null)
			{
				return;
			}
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			ImGui.Text("Planted Seed");
			try
			{
				Vector2i seedMapPosition = 럓.랾.GetSeedMapPosition(seedDataAt);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Position: (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(seedMapPosition.x);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(seedMapPosition.y);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			catch
			{
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000B7414 File Offset: 0x000B5614
		private static void 랾(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null || !ConfigData.IsBlockOnlyRatingBoard(A_1))
			{
				return;
			}
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			ImGui.Text("Rating/Score Board");
			if (럓.랾.worldRatings != null)
			{
				float worldRatingsAverage = 럓.랾.GetWorldRatingsAverage();
				int worldRatingsCount = 럓.랾.GetWorldRatingsCount();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Rating: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(worldRatingsAverage, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("/5 (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(worldRatingsCount);
				defaultInterpolatedStringHandler.AppendLiteral(" votes)");
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000B74B4 File Offset: 0x000B56B4
		private static void 럎(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null || !ConfigData.IsBlockMusicPlayer(A_1))
			{
				return;
			}
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Music Player: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000B7504 File Offset: 0x000B5704
		private static void 람(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null)
			{
				return;
			}
			if (!A_1.ToString().Contains("Spawner"))
			{
				return;
			}
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Spawner: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000B7564 File Offset: 0x000B5764
		private static void 럒(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null)
			{
				return;
			}
			if (!A_1.ToString().Contains("DeathCounter"))
			{
				return;
			}
			int value = 럠.람(A_0.GetAsBSON(), "deathCounter");
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Death Counter: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000B75D4 File Offset: 0x000B57D4
		private static void 럼(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null || !ConfigData.IsBlockBattleBarrier(A_1))
			{
				return;
			}
			bool flag = 럠.럼(A_0.GetAsBSON(), "isBattleOn");
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Battle Barrier: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.Text("Battle: " + (flag ? "Active" : "Inactive"));
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000B7650 File Offset: 0x000B5850
		private static void 랋(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null || !ConfigData.IsBlockRecycler(A_1))
			{
				return;
			}
			int value = 럠.람(A_0.GetAsBSON(), "recycledPoints");
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Recycler: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("Points: ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(value);
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000B76D8 File Offset: 0x000B58D8
		private static void 랉(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null || !ConfigData.IsBlockDisappearingBlock(A_1))
			{
				return;
			}
			int num = 럠.람(A_0.GetAsBSON(), "trapFrequencyType");
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Disappearing Block: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (num > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("Frequency: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(num);
				ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000B7764 File Offset: 0x000B5964
		private static void 럐(WorldItemBase A_0, World.BlockType A_1)
		{
			if (A_0 == null)
			{
				return;
			}
			if (!A_1.ToString().StartsWith("RuleBot"))
			{
				return;
			}
			BSONObject asBSON = A_0.GetAsBSON();
			ImGui.Text("- - - - - - - - - - - - - - - - - - - - - - - -");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Rule Block: ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_1);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			bool value = 럠.럼(asBSON, "isLocked");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("Locked: ");
			defaultInterpolatedStringHandler2.AppendFormatted<bool>(value);
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			bool flag = 럠.럼(asBSON, "isContinuousJumpingAllowed");
			bool flag2 = 럠.럼(asBSON, "isDoubleJumpAllowed");
			bool flag3 = 럠.럼(asBSON, "isTripleJumpAllowed");
			bool flag4 = 럠.럼(asBSON, "isLongJumpAllowed");
			bool flag5 = 럠.럼(asBSON, "isPotionsAllowed");
			if (flag)
			{
				ImGui.Text("  Continuous Jump: ON");
			}
			if (flag2)
			{
				ImGui.Text("  Double Jump: ON");
			}
			if (flag3)
			{
				ImGui.Text("  Triple Jump: ON");
			}
			if (flag4)
			{
				ImGui.Text("  Long Jump: ON");
			}
			if (flag5)
			{
				ImGui.Text("  Potions: ON");
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000B787C File Offset: 0x000B5A7C
		public static void 럎(Vector2i A_0, WorldItemBase A_1)
		{
			if (A_1 == null || !ConfigData.IsBlockPortal(A_1.blockType))
			{
				return;
			}
			BSONObject asBSON = A_1.GetAsBSON();
			bool flag = 럠.럼(asBSON, "isLocked");
			bool flag2 = 럽.랉() || 럽.랋();
			if (flag && !flag2)
			{
				럽.럎("Portal is locked and you don't have access", false);
				return;
			}
			string text = 럠.럎(asBSON, "entryPointID");
			string text2 = 럠.럎(asBSON, "targetEntryPointID");
			string text3 = (!string.IsNullOrEmpty(text)) ? text : text2;
			if (string.IsNullOrEmpty(text3))
			{
				럽.럎("Portal ID is invalid", false);
				return;
			}
			if (flag)
			{
				럽.랾("Entering locked portal (access granted)", false);
			}
			else
			{
				럽.랾("Entering portal", false);
			}
			SceneLoader.CheckIfWeCanGoFromWorldToWorld(럓.랾.worldName, text3, null, false, null);
			ConfigFile.zoomHackToggle = false;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000B7944 File Offset: 0x000B5B44
		private static string 럎(BSONObject A_0, string A_1)
		{
			try
			{
				if (A_0 != null && A_0.ContainsKey(A_1))
				{
					return A_0[A_1].stringValue ?? string.Empty;
				}
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x000B7998 File Offset: 0x000B5B98
		private static int 람(BSONObject A_0, string A_1)
		{
			try
			{
				if (A_0 != null && A_0.ContainsKey(A_1))
				{
					return A_0[A_1].int32Value;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000B79E0 File Offset: 0x000B5BE0
		private static long 럒(BSONObject A_0, string A_1)
		{
			try
			{
				if (A_0 != null && A_0.ContainsKey(A_1))
				{
					return A_0[A_1].int64Value;
				}
			}
			catch
			{
			}
			return 0L;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000B7A28 File Offset: 0x000B5C28
		private static bool 럼(BSONObject A_0, string A_1)
		{
			try
			{
				if (A_0 != null && A_0.ContainsKey(A_1))
				{
					return A_0[A_1].boolValue;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00041B06 File Offset: 0x0003FD06
		// Note: this type is marked as 'beforefieldinit'.
		static 럠()
		{
			World.BlockType[] array = new World.BlockType[21];
			RuntimeHelpers.InitializeArray(array, fieldof(럖.랾).FieldHandle);
			럠.랾 = array;
		}

		// Token: 0x0400072E RID: 1838
		private const string 랾 = "- - - - - - - - - - - - - - - - - - - - - - - -";

		// Token: 0x0400072F RID: 1839
		private static readonly World.BlockType[] 랾;
	}
}
