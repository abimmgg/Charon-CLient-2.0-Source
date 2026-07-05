using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;
using UnityEngine;
using 랾;

namespace CharonClientWhiteDress.ChatCommands
{
	// Token: 0x0200001F RID: 31
	[HarmonyPatch(typeof(ChatUI), "Submit")]
	public static class PrefixSubmit
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00072594 File Offset: 0x00070794
		public static bool Prefix(ref string text)
		{
			if (!ConfigFile.enableChatCommandsToggle || string.IsNullOrWhiteSpace(text))
			{
				return true;
			}
			text = text.Trim();
			if (text.Length == 0 || text[0] != '/')
			{
				return true;
			}
			string lower = text.ToLowerInvariant();
			if (PrefixSubmit.TryHandleParameterizedCommand(text, lower))
			{
				return false;
			}
			if (PrefixSubmit.TryHandleExactCommand(lower))
			{
				return false;
			}
			럽.랾("Invalid Command", true);
			return false;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00072600 File Offset: 0x00070800
		private static bool TryHandleParameterizedCommand(string text, string lower)
		{
			if (lower.StartsWith("/help "))
			{
				PrefixSubmit.HandleHelp(text.Substring("/help ".Length).Trim());
				return true;
			}
			if (lower.StartsWith("/queryplayer "))
			{
				string text2 = text.Substring("/queryplayer ".Length).Trim();
				if (string.IsNullOrWhiteSpace(text2))
				{
					럽.랾("Usage: /queryplayer name", false);
					return true;
				}
				ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<PlayerInfoLiteUI>());
				OutgoingMessages.QueryPlayerInfo(text2);
				return true;
			}
			else
			{
				if (lower.StartsWith("/kick "))
				{
					PrefixSubmit.HandlePlayerAction(text, "/kick ", PrefixSubmit.랾.랾);
					return true;
				}
				if (lower.StartsWith("/ban "))
				{
					PrefixSubmit.HandlePlayerAction(text, "/ban ", PrefixSubmit.랾.럎);
					return true;
				}
				if (lower.StartsWith("/summon "))
				{
					PrefixSubmit.HandlePlayerAction(text, "/summon ", PrefixSubmit.랾.람);
					return true;
				}
				if (lower.StartsWith("/add "))
				{
					PrefixSubmit.HandleAdd(text);
					return true;
				}
				if (lower.StartsWith("/search "))
				{
					PrefixSubmit.HandleSearch(text.Substring("/search ".Length).Trim());
					return true;
				}
				if (lower.StartsWith("/warp ") || lower.StartsWith("/w "))
				{
					PrefixSubmit.HandleWarp(text);
					return true;
				}
				if (lower.StartsWith("/sethome "))
				{
					PrefixSubmit.HandleSetHome(text);
					return true;
				}
				if (lower.StartsWith("/hidemsg "))
				{
					PrefixSubmit.HandleHideMsg(text.Substring("/hidemsg ".Length));
					return true;
				}
				if (lower.StartsWith("/setblock "))
				{
					PrefixSubmit.HandleSetBlock(text.Substring("/setblock ".Length));
					return true;
				}
				if (lower.StartsWith("/cmsg "))
				{
					PrefixSubmit.HandleClientRelayMessage(text.Substring("/cmsg ".Length));
					return true;
				}
				return false;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000727B8 File Offset: 0x000709B8
		private static bool TryHandleExactCommand(string lower)
		{
			if (lower != null)
			{
				switch (lower.Length)
				{
				case 3:
				{
					char c = lower[2];
					if (c != 'g')
					{
						if (c == 'w')
						{
							if (lower == "/rw")
							{
								SceneLoader.ReloadWorld();
								return true;
							}
						}
					}
					else if (lower == "/rg")
					{
						SceneLoader.ReloadGame();
						return true;
					}
					break;
				}
				case 4:
				{
					char c = lower[1];
					if (c != 'p')
					{
						if (c == 's')
						{
							if (lower == "/sit")
							{
								럓.랾.DoSitAnimation();
								return true;
							}
						}
					}
					else if (lower == "/pwe")
					{
						PrefixSubmit.SpawnBlock(1605, "PWE Spawned (Only Allows You To Look At Items)");
						return true;
					}
					break;
				}
				case 5:
				{
					char c = lower[3];
					if (c > 'n')
					{
						if (c != 's')
						{
							if (c != 'v')
							{
								break;
							}
							if (!(lower == "/love"))
							{
								break;
							}
						}
						else
						{
							if (lower == "/cmsg")
							{
								럽.랾("Usage: /cmsg <message>", false);
								return true;
							}
							if (!(lower == "/kiss"))
							{
								break;
							}
						}
						OutgoingMessages.SendPetPetMessage(3);
						return true;
					}
					if (c != 'd')
					{
						switch (c)
						{
						case 'l':
							if (lower == "/help")
							{
								PrefixSubmit.HandleHelp(null);
								return true;
							}
							break;
						case 'm':
							if (lower == "/home")
							{
								PrefixSubmit.HandleHome();
								return true;
							}
							break;
						case 'n':
							if (lower == "/bank")
							{
								PrefixSubmit.SpawnBlock(3576, "Bank Bot Spawned");
								return true;
							}
							break;
						}
					}
					else if (lower == "/hide")
					{
						럓.랾.DoInvisibleAnimation(true);
						return true;
					}
					break;
				}
				case 6:
				{
					char c = lower[1];
					if (c != 'd')
					{
						if (c != 's')
						{
							if (c == 't')
							{
								if (lower == "/train")
								{
									OutgoingMessages.SendPetTrainMessage(3, 6);
									return true;
								}
							}
						}
						else if (lower == "/sleep")
						{
							PrefixSubmit.HandleSleep();
							return true;
						}
					}
					else if (lower == "/decay")
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Decay Date: ");
						defaultInterpolatedStringHandler.AppendFormatted<DateTime>(럓.랾.lockWorldDataHelper.GetLastActivatedTime());
						럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
						return true;
					}
					break;
				}
				case 7:
				{
					char c = lower[2];
					if (c != 'a')
					{
						if (c != 'g')
						{
							switch (c)
							{
							case 'o':
								if (lower == "/follow")
								{
									OutgoingMessages.SendPetCleanMessage(3);
									return true;
								}
								break;
							case 'q':
								if (lower == "/dquest")
								{
									ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<DailyGuestGiverUI>());
									return true;
								}
								break;
							case 'r':
								if (lower == "/dropbg")
								{
									PlayerData.InventoryKey[] array;
									if (!PrefixSubmit.TryGetInventory(out array))
									{
										return true;
									}
									랯.랾("/dropbg", "Backgrounds", array, new PlayerData.InventoryItemType?(1), false);
									return true;
								}
								break;
							case 't':
								if (lower == "/ctotem")
								{
									if (럓.랾.IsInClan())
									{
										ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<ClanTotemUI>());
									}
									else
									{
										럽.랾("You Are Not In A Clan", false);
									}
									return true;
								}
								break;
							case 'w':
								if (lower == "/mwheel")
								{
									ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<MiningRouletteUI>());
									return true;
								}
								break;
							}
						}
						else
						{
							if (lower == "/fgemui")
							{
								ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<FishingRecyclerUI>());
								return true;
							}
							if (lower == "/mgemui")
							{
								ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<MiningGemstoneRecyclerUI>());
								return true;
							}
						}
					}
					else if (lower == "/banall")
					{
						PrefixSubmit.OpenAdminToolIfAccess<AdminToolsBanPlayerFromWorldUI>("Ban");
						return true;
					}
					break;
				}
				case 8:
				{
					char c = lower[1];
					switch (c)
					{
					case 'd':
						if (lower == "/dropall")
						{
							PlayerData.InventoryKey[] array;
							if (!PrefixSubmit.TryGetInventory(out array))
							{
								return true;
							}
							랯.랾("/dropall", "Items", array, null, false);
							return true;
						}
						break;
					case 'e':
						if (lower == "/eyeless")
						{
							OutgoingMessages.SendWearableOrWeaponUndress(40);
							럓.랾.UndressWearableOrWeaponRemote(40);
							return true;
						}
						break;
					case 'f':
						if (lower == "/favholo")
						{
							PrefixSubmit.SpawnBlock(2145, "Favourite World Hologram Spawned");
							return true;
						}
						break;
					case 'g':
						if (lower == "/getgems")
						{
							PrefixSubmit.HandleGetWorldGems();
							return true;
						}
						break;
					case 'h':
					case 'i':
					case 'j':
					case 'm':
					case 'n':
						break;
					case 'k':
						if (lower == "/kickall")
						{
							PrefixSubmit.OpenAdminToolIfAccess<AdminToolsKickPlayerUI>("Kick");
							return true;
						}
						break;
					case 'l':
						if (lower == "/legless")
						{
							PrefixSubmit.UndressBlocks(new World.BlockType[]
							{
								517,
								43
							});
							return true;
						}
						break;
					case 'o':
						if (lower == "/ownerid")
						{
							if (럓.랾.lockWorldDataHelper == null)
							{
								럽.랾("There's no lockWorldDataHelper.", false);
								return true;
							}
							럽.랾("Owner ID: " + 럓.랾.lockWorldDataHelper.GetPlayerWhoOwnsLockId() + " (Sent To Console)", false);
							Console.WriteLine("Owner ID: " + 럓.랾.lockWorldDataHelper.GetPlayerWhoOwnsLockId());
							return true;
						}
						break;
					default:
						if (c == 'w')
						{
							if (lower == "/worldid")
							{
								럽.랾("World ID: " + 럓.랾.worldID, false);
								return true;
							}
						}
						break;
					}
					break;
				}
				case 9:
				{
					char c = lower[5];
					if (c != 'h')
					{
						switch (c)
						{
						case 'l':
							if (lower == "/bodyless")
							{
								PrefixSubmit.UndressBlocks(new World.BlockType[]
								{
									4670,
									44
								});
								return true;
							}
							break;
						case 'm':
						case 'n':
							break;
						case 'o':
							if (lower == "/modtools")
							{
								if (!PrefixSubmit.RequireDev())
								{
									return true;
								}
								ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<AdminToolsBanPlayerFromGameUI>());
								return true;
							}
							break;
						case 'p':
							if (lower == "/looppets")
							{
								if (!PrefixSubmit.RequireDev())
								{
									return true;
								}
								럧.랠 = !럧.랠;
								럽.랾("Loop Pets: " + (럧.랠 ? "On" : "Off"), false);
								return true;
							}
							break;
						default:
							if (c == 's')
							{
								if (lower == "/lastseen")
								{
									Task.Run(new Func<Task>(PrefixSubmit.럎.랾.랾));
									return true;
								}
							}
							break;
						}
					}
					else if (lower == "/trashall")
					{
						PlayerData.InventoryKey[] array;
						if (!PrefixSubmit.TryGetInventory(out array))
						{
							return true;
						}
						랯.랾("/trashall", "Items", array, null, true);
						return true;
					}
					break;
				}
				case 10:
				{
					char c = lower[1];
					switch (c)
					{
					case 'b':
						if (lower == "/breakdono")
						{
							WorldController worldController = ControllerHelper.worldController;
							if (((worldController != null) ? worldController.player : null) == null)
							{
								럽.랾("Player is not available.", false);
								return true;
							}
							PrefixSubmit.HandleBreakDono(ControllerHelper.worldController.player.currentPlayerMapPoint);
							return true;
						}
						break;
					case 'c':
					case 'e':
					case 'g':
						break;
					case 'd':
						if (lower == "/dropseeds")
						{
							PlayerData.InventoryKey[] array;
							if (!PrefixSubmit.TryGetInventory(out array))
							{
								return true;
							}
							랯.랾("/dropseeds", "Seeds", array, new PlayerData.InventoryItemType?(2), false);
							return true;
						}
						break;
					case 'f':
						if (lower == "/firedeath")
						{
							OutgoingMessages.ForceKillPlayerByBlockHit(111, Vector2i.GetZero(), DateTime.Now);
							return true;
						}
						break;
					case 'h':
						if (lower == "/headless1")
						{
							PrefixSubmit.UndressBlocks(new World.BlockType[]
							{
								618,
								38
							});
							return true;
						}
						break;
					default:
						switch (c)
						{
						case 'p':
							if (lower == "/pullsword")
							{
								PrefixSubmit.HandlePullSword();
								return true;
							}
							break;
						case 's':
							if (lower == "/summonall")
							{
								PrefixSubmit.OpenAdminToolIfAccess<AdminToolsSummonPlayerUI>("Summon");
								return true;
							}
							break;
						case 't':
							if (lower == "/tradegems")
							{
								PrefixSubmit.HandleGetTradeGems();
								return true;
							}
							break;
						}
						break;
					}
					break;
				}
				case 11:
				{
					char c = lower[1];
					switch (c)
					{
					case 'a':
						if (lower == "/accesslist")
						{
							PrefixSubmit.HandleAccessList();
							return true;
						}
						break;
					case 'b':
					case 'e':
						break;
					case 'c':
						if (lower == "/chairdeath")
						{
							OutgoingMessages.ForceKillPlayerByBlockHit(1339, Vector2i.GetZero(), DateTime.Now);
							return true;
						}
						break;
					case 'd':
						if (lower == "/dropblocks")
						{
							PlayerData.InventoryKey[] array;
							if (!PrefixSubmit.TryGetInventory(out array))
							{
								return true;
							}
							랯.랾("/dropblocks", "Blocks", array, new PlayerData.InventoryItemType?(0), false);
							return true;
						}
						break;
					case 'f':
						if (lower == "/frostdeath")
						{
							OutgoingMessages.ForceKillPlayerByBlockHit(4458, Vector2i.GetZero(), DateTime.Now);
							return true;
						}
						break;
					default:
						if (c != 's')
						{
							if (c == 't')
							{
								if (lower == "/trashseeds")
								{
									PlayerData.InventoryKey[] array;
									if (!PrefixSubmit.TryGetInventory(out array))
									{
										return true;
									}
									랯.랾("/trashseeds", "Seeds", array, new PlayerData.InventoryItemType?(2), true);
									return true;
								}
							}
						}
						else if (lower == "/serverinfo")
						{
							PrefixSubmit.HandleServerInfo();
							return true;
						}
						break;
					}
					break;
				}
				case 12:
				{
					char c = lower[1];
					if (c != 'd')
					{
						if (c != 'e')
						{
							if (c == 't')
							{
								if (lower == "/trashblocks")
								{
									PlayerData.InventoryKey[] array;
									if (!PrefixSubmit.TryGetInventory(out array))
									{
										return true;
									}
									랯.랾("/trashblocks", "Blocks", array, new PlayerData.InventoryItemType?(0), true);
									return true;
								}
							}
						}
						else if (lower == "/eyebrowless")
						{
							럽.랾("Do /headless then equip the half face superhero mask, it'll make your eyebrows disappear and also make you blink that mask's colour", false);
							return true;
						}
					}
					else if (lower == "/dropweapons")
					{
						PlayerData.InventoryKey[] array;
						if (!PrefixSubmit.TryGetInventory(out array))
						{
							return true;
						}
						랯.랾("/dropweapons", "Weapons", array, new PlayerData.InventoryItemType?(5), false);
						return true;
					}
					break;
				}
				case 13:
					if (lower == "/trashweapons")
					{
						PlayerData.InventoryKey[] array;
						if (!PrefixSubmit.TryGetInventory(out array))
						{
							return true;
						}
						랯.랾("/trashweapons", "Weapons", array, new PlayerData.InventoryItemType?(5), true);
						return true;
					}
					break;
				case 14:
					switch (lower[1])
					{
					case 'd':
						if (lower == "/dropwearables")
						{
							PlayerData.InventoryKey[] array;
							if (!PrefixSubmit.TryGetInventory(out array))
							{
								return true;
							}
							랯.랾("/dropwearables", "Wearables", array, new PlayerData.InventoryItemType?(4), false);
							return true;
						}
						break;
					case 'e':
						if (lower == "/electricdeath")
						{
							OutgoingMessages.ForceKillPlayerByBlockHit(961, Vector2i.GetZero(), DateTime.Now);
							return true;
						}
						break;
					case 'g':
						if (lower == "/getstoredgems")
						{
							PrefixSubmit.HandleGetStoredGems();
							return true;
						}
						break;
					}
					break;
				case 15:
					if (lower == "/trashwearables")
					{
						PlayerData.InventoryKey[] array;
						if (!PrefixSubmit.TryGetInventory(out array))
						{
							return true;
						}
						랯.랾("/trashwearables", "Wearables", array, new PlayerData.InventoryItemType?(4), true);
						return true;
					}
					break;
				case 16:
					if (lower == "/collectabledata")
					{
						PrefixSubmit.HandleCollectableData();
						return true;
					}
					break;
				case 17:
					if (lower == "/trashbackgrounds")
					{
						PlayerData.InventoryKey[] array;
						if (!PrefixSubmit.TryGetInventory(out array))
						{
							return true;
						}
						랯.랾("/trashbackgrounds", "Backgrounds", array, new PlayerData.InventoryItemType?(1), true);
						return true;
					}
					break;
				}
			}
			return false;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00073464 File Offset: 0x00071664
		private static void HandleHelp(string query = null)
		{
			PrefixSubmit.람 람 = new PrefixSubmit.람();
			bool 럑 = 럧.럑;
			if (string.IsNullOrWhiteSpace(query))
			{
				럽.랾("Help Usage: /help <category> or /help <command>", true);
				럽.랾("Categories: info, navigation, player, currency, items, drop, trash", true);
				럽.랾("Categories: worldadmin, ui, death, pet, misc" + (럑 ? ", dev" : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()), true);
				return;
			}
			if (럇.랾(query, out 람.랾))
			{
				IEnumerable<string> values = 럇.랾(럑).Where(new Func<란, bool>(람.랾)).Select(new Func<란, string>(PrefixSubmit.럎.랾.랾));
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted<랬>(람.랾);
				defaultInterpolatedStringHandler.AppendLiteral(": ");
				defaultInterpolatedStringHandler.AppendFormatted(string.Join(", ", values));
				럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				return;
			}
			란 란 = 럇.랾(query, 럑);
			if (란 != null)
			{
				럽.랾(란.랾() + " - " + 란.럎(), false);
				return;
			}
			럽.랾("No help found for \"" + query + "\"", true);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00073588 File Offset: 0x00071788
		private static void HandleDupe(string text)
		{
			if (!PrefixSubmit.RequireDev())
			{
				return;
			}
			string[] array = PrefixSubmit.SplitArguments(text);
			if (array.Length != 3)
			{
				럽.랾("Usage: /dupe <amount> <itemID>", false);
				return;
			}
			int num;
			if (!int.TryParse(array[1], out num) || num <= 0)
			{
				럽.랾("Invalid amount", false);
				return;
			}
			int num2;
			if (!int.TryParse(array[2], out num2))
			{
				럽.랾("Invalid item ID", false);
				return;
			}
			럅.랾(num, num2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000735F4 File Offset: 0x000717F4
		private static void HandleCurrency(string text, string prefix, bool addGems)
		{
			Player player;
			if (!PrefixSubmit.TryGetPlayer(out player))
			{
				return;
			}
			int num;
			if (!int.TryParse(text.Substring(prefix.Length).Trim(), out num))
			{
				럽.랾("Invalid amount", false);
				return;
			}
			if (addGems)
			{
				player.myPlayerData.AddGems(num);
			}
			else
			{
				player.myPlayerData.AddByteCoins(num);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Added ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(addGems ? "Gems" : "Bytes");
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0007369C File Offset: 0x0007189C
		private static void HandlePlayerAction(string text, string prefix, PrefixSubmit.랾 action)
		{
			string text2 = text.Substring(prefix.Length).Trim().ToLowerInvariant();
			if (string.IsNullOrWhiteSpace(text2))
			{
				럽.랾("Usage: " + prefix.Trim() + " <name>", false);
				return;
			}
			int num = 0;
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (networkPlayer != null && NetworkPlayers.GetNameWithId(networkPlayer.clientId, false).ToLowerInvariant().Contains(text2))
				{
					num++;
					switch (action)
					{
					case PrefixSubmit.랾.랾:
						OutgoingMessages.KickPlayer(networkPlayer.clientId);
						break;
					case PrefixSubmit.랾.럎:
						OutgoingMessages.BanAndKickPlayer(networkPlayer.clientId);
						break;
					case PrefixSubmit.랾.람:
						OutgoingMessages.SummonPlayerToLocation(networkPlayer.clientId);
						break;
					}
				}
			}
			if (num == 0)
			{
				럽.랾("No players matched \"" + text2 + "\"", false);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00073778 File Offset: 0x00071978
		private static void HandleAdd(string text)
		{
			Player player;
			if (!PrefixSubmit.TryGetPlayer(out player))
			{
				return;
			}
			string[] array = PrefixSubmit.SplitArguments(text);
			int num;
			if (array.Length < 2 || !int.TryParse(array[1], out num))
			{
				럽.랾("Usage: /add <itemID> [quantity]", false);
				return;
			}
			if (num < 0 || num > 6000)
			{
				럽.랾("Invalid Item ID", false);
				return;
			}
			int num2 = 1;
			if (array.Length >= 3 && (!int.TryParse(array[2], out num2) || num2 <= 0))
			{
				럽.랾("Invalid quantity", false);
				return;
			}
			if (num2 > 32767)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Quantity too large. Max is ");
				defaultInterpolatedStringHandler.AppendFormatted<short>(short.MaxValue);
				럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				return;
			}
			World.BlockType blockType = num;
			PlayerData.InventoryItemType blockTypeInventoryItemType = ConfigData.GetBlockTypeInventoryItemType(blockType);
			player.myPlayerData.AddItemToInventory(blockType, blockTypeInventoryItemType, (short)num2, null);
			player.ChangeWearableOrWeaponRemote(blockType, 0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(8, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("Added ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler2.AppendLiteral("x ");
			defaultInterpolatedStringHandler2.AppendFormatted<World.BlockType>(blockType);
			럽.랾(defaultInterpolatedStringHandler2.ToStringAndClear(), false);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00073890 File Offset: 0x00071A90
		private static void HandleSearch(string searchTerm)
		{
			if (string.IsNullOrWhiteSpace(searchTerm))
			{
				럽.랾("Usage: /search <term>", false);
				return;
			}
			string text = searchTerm.Trim();
			foreach (KeyValuePair<World.BlockType, string> keyValuePair in TextManager.blockDescriptions)
			{
				if (string.Equals(keyValuePair.Key.ToString(), text, StringComparison.OrdinalIgnoreCase))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
					defaultInterpolatedStringHandler.AppendLiteral("Item: ");
					defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(keyValuePair.Key);
					defaultInterpolatedStringHandler.AppendLiteral(" ID: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
					defaultInterpolatedStringHandler.AppendLiteral(" Description: ");
					defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Value);
					럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), true);
					return;
				}
			}
			List<string> list = new List<string>();
			foreach (KeyValuePair<World.BlockType, string> keyValuePair2 in TextManager.blockDescriptions)
			{
				if (keyValuePair2.Key.ToString().IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					List<string> list2 = list;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler2.AppendFormatted<World.BlockType>(keyValuePair2.Key);
					defaultInterpolatedStringHandler2.AppendLiteral(" ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(keyValuePair2.Key);
					list2.Add(defaultInterpolatedStringHandler2.ToStringAndClear());
				}
			}
			if (list.Count > 0)
			{
				럽.랾("No exact match. Did you mean: " + string.Join(", ", list), true);
				return;
			}
			럽.랾("No block found matching \"" + text + "\"", true);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00073A18 File Offset: 0x00071C18
		private static void HandleWarp(string text)
		{
			string[] array = PrefixSubmit.SplitArguments(text);
			if (array.Length < 2)
			{
				럽.랾("Usage: /warp <world> [portalID]", false);
				return;
			}
			string text2 = array[1];
			string text3 = (array.Length >= 3) ? array[2] : string.Empty;
			SceneLoader.CheckIfWeCanGoFromWorldToWorld(text2, text3, null, false, null);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00073A5C File Offset: 0x00071C5C
		private static void HandleSetHome(string text)
		{
			string[] array = PrefixSubmit.SplitArguments(text);
			if (array.Length != 2)
			{
				럽.랾("Usage: /sethome <worldname>", false);
				return;
			}
			string text2 = array[1];
			File.WriteAllText(PrefixSubmit.GetHomePath(), text2);
			럽.랾("Home Set To: " + text2, false);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00073AA4 File Offset: 0x00071CA4
		private static void HandleHome()
		{
			string homePath = PrefixSubmit.GetHomePath();
			if (!File.Exists(homePath))
			{
				럽.랾("Home Not Set. Use /sethome <worldname>", false);
				return;
			}
			string text = File.ReadAllText(homePath).Trim();
			if (string.IsNullOrWhiteSpace(text))
			{
				럽.랾("Home file is empty. Use /sethome <worldname>", false);
				return;
			}
			SceneLoader.CheckIfWeCanGoFromWorldToWorld(text, string.Empty, null, false, null);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00073AFC File Offset: 0x00071CFC
		private static void HandleHideMsg(string message)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				럽.랾("Usage: /hidemsg <text>", false);
				return;
			}
			if (럓.랾.lockWorldDataHelper.GetPlayerWhoOwnsLockId() != 럓.랾.playerId)
			{
				럽.랾("Failed To Send The Message", false);
				return;
			}
			bool flag = false;
			foreach (KeyValuePair<int, AIPetMonoBehaviourBase> keyValuePair in ControllerHelper.worldController.aiPetMonoBehaviours)
			{
				럓.랾.SubmitPetCommandChatMessage(keyValuePair.value.aiBase.id, message);
				flag = true;
			}
			if (flag)
			{
				ChatUI.SendMinigameMessage("Successfully Sent The Message");
				return;
			}
			럽.랾("No pets available.", false);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00073BA4 File Offset: 0x00071DA4
		private static void HandleSetBlock(string message)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				럽.랾("Usage: /setblock <below|above|left|right> <blockID>", false);
				return;
			}
			string[] array = message.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			if (array.Length < 2)
			{
				럽.랾("Usage: /setblock <below|above|left|right> <blockID>", false);
				return;
			}
			string text = array[0].ToLower();
			int num;
			if (!int.TryParse(array[1], out num))
			{
				럽.랾("Invalid block ID.", false);
				return;
			}
			if (num < 0 || num > 6000)
			{
				럽.랾("Block ID must be between 0 and 6000.", false);
				return;
			}
			World.BlockType blockType = num;
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			int num2 = currentPlayerMapPoint.x;
			int num3 = currentPlayerMapPoint.y;
			if (!(text == "below"))
			{
				if (!(text == "above"))
				{
					if (!(text == "left"))
					{
						if (!(text == "right"))
						{
							럽.랾("Invalid position. Use: below, above, left, right", false);
							return;
						}
						num2++;
					}
					else
					{
						num2--;
					}
				}
				else
				{
					num3++;
				}
			}
			else
			{
				num3--;
			}
			ControllerHelper.worldController.SetBlock(blockType, num2, num3);
			럽.랾("Placed block " + text + " player.", false);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0003CEB5 File Offset: 0x0003B0B5
		private static void HandleClientRelayMessage(string message)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				럽.랾("Usage: /cmsg <message>", false);
				return;
			}
			럲.랾(message);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00073CBC File Offset: 0x00071EBC
		private static void HandleServerInfo()
		{
			string serverAddress = AsynchronousClient.serverAddress;
			string serverReconnectAddress = AsynchronousClient.serverReconnectAddress;
			string value = "Unavailable";
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(serverAddress);
				if (hostEntry != null && hostEntry.AddressList != null && hostEntry.AddressList.Length != 0)
				{
					value = hostEntry.AddressList[0].ToString();
				}
			}
			catch (Exception ex)
			{
				value = "Lookup failed: " + ex.Message;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Server Address: ");
			defaultInterpolatedStringHandler.AppendFormatted(serverAddress);
			defaultInterpolatedStringHandler.AppendLiteral("");
			defaultInterpolatedStringHandler.AppendLiteral("Server Re-Connect Address: ");
			defaultInterpolatedStringHandler.AppendFormatted(serverReconnectAddress);
			defaultInterpolatedStringHandler.AppendLiteral("");
			defaultInterpolatedStringHandler.AppendLiteral("Server I.P: ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00073D98 File Offset: 0x00071F98
		private static void HandleAccessList()
		{
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			럽.랾("Owner: " + 럓.랾.GetOwnerOfTheMapPointPlayerID(currentPlayerMapPoint) + ";" + 럓.랾.GetOwnerOfTheMapPoint(currentPlayerMapPoint), false);
			foreach (string str in 럓.랾.lockWorldDataHelper.GetPlayersWhoHaveAccessToLock())
			{
				럽.랾("Full Access: " + str, false);
			}
			foreach (string str2 in 럓.랾.lockWorldDataHelper.GetPlayersWhoHaveMinorAccessToLock())
			{
				럽.랾("Minor Access: " + str2, false);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0003CED2 File Offset: 0x0003B0D2
		private static void HandleSleep()
		{
			if (ConfigData.playerChangeToSleepSeconds == 0)
			{
				ConfigData.playerChangeToSleepSeconds = int.MaxValue;
				럽.랾("Sleep mode disabled", false);
				return;
			}
			ConfigData.playerChangeToSleepSeconds = 0;
			럽.랾("You're now sleeping! Type again to stop.", false);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0003CF02 File Offset: 0x0003B102
		private static void HandlePullSword()
		{
			if (럓.랾.currentPlayerPositionBlockType == 2274)
			{
				OutgoingMessages.SendPullSwordInStone(럓.랾.currentPlayerMapPoint);
				럽.랾("Successfully Attempted To Pull The Sword!", false);
				return;
			}
			럽.랾("Your Player Isn't On A Fantasy Sword In Stone Block", false);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00073E4C File Offset: 0x0007204C
		private static void HandleBreakDono(Vector2i pos)
		{
			World.BlockType currentPlayerPositionBlockType = 럓.랾.currentPlayerPositionBlockType;
			if (currentPlayerPositionBlockType != 3604 && currentPlayerPositionBlockType != 3639)
			{
				럽.랾("Position The Player Onto A Donation Box", false);
				return;
			}
			int num = PlayerData.InventoryKey.InventoryKeyToInt(new PlayerData.InventoryKey(2372, 5));
			WorldItemBase worldItemData = 럓.랾.GetWorldItemData(pos.x, pos.y);
			BSONObject bsonobject = new BSONObject();
			bsonobject["ID"] = "AddDon";
			bsonobject["WiB"] = worldItemData.GetAsBSON();
			bsonobject["x"] = pos.x;
			bsonobject["y"] = pos.y;
			bsonobject["IK"] = num;
			bsonobject["Amt"] = -999;
			OutgoingMessages.AddOneMessageToList(bsonobject);
			럽.랾("Successfully Broken A Donation Box. You Can Do This Up To 3 Times On One Donation Box", false);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00073F38 File Offset: 0x00072138
		private static void HandleCollectableData()
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Logger");
			string path = Path.Combine(text, "Data Dump.txt");
			try
			{
				Directory.CreateDirectory(text);
				using (StreamWriter streamWriter = new StreamWriter(path))
				{
					foreach (CollectableData collectableData in 럓.랾.collectables)
					{
						TextWriter textWriter = streamWriter;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 4);
						defaultInterpolatedStringHandler.AppendLiteral("Item: ");
						defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(collectableData.blockType);
						defaultInterpolatedStringHandler.AppendLiteral(", Amount: ");
						defaultInterpolatedStringHandler.AppendFormatted<short>(collectableData.amount);
						defaultInterpolatedStringHandler.AppendLiteral(", ID: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(collectableData.id);
						defaultInterpolatedStringHandler.AppendLiteral(", Type: ");
						defaultInterpolatedStringHandler.AppendFormatted<PlayerData.InventoryItemType>(collectableData.inventoryItemType);
						textWriter.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
				럽.랾("Successfully Logged The World's Collectable Data.", false);
			}
			catch (Exception ex)
			{
				럽.람("Error: " + ex.Message, false);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00074068 File Offset: 0x00072268
		private static void HandleGetWorldGems()
		{
			int num = 0;
			foreach (CollectableData collectableData in 럓.랾.collectables)
			{
				num += 럅.럎(collectableData.blockType) * (int)collectableData.amount;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("World Gems: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000740D8 File Offset: 0x000722D8
		private static void HandleGetTradeGems()
		{
			InventoryControl inventoryControl = null;
			if (inventoryControl == null)
			{
				inventoryControl = Object.FindObjectOfType<InventoryControl>();
			}
			if (inventoryControl == null)
			{
				럽.럎("InventoryControl not found. Are you sure you're in a trade?", false);
				return;
			}
			if (!inventoryControl.IsTradeOverlayOpen())
			{
				럽.럎("You must be trading to use this command.", false);
				return;
			}
			int value;
			int num;
			if (!PrefixSubmit.TryGetPartnerTradeGemTotal(inventoryControl, out value, out num))
			{
				럽.럎("Could not read the partner trade slots from the trade overlay.", false);
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Partner Trade Gems: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" populated slot");
			defaultInterpolatedStringHandler.AppendFormatted((num == 1) ? string.Empty : "s");
			defaultInterpolatedStringHandler.AppendLiteral(")");
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000741A0 File Offset: 0x000723A0
		private static bool TryGetPartnerTradeGemTotal(InventoryControl inventoryControl, out int total, out int slotCount)
		{
			total = 0;
			slotCount = 0;
			object tradeMemberValue = PrefixSubmit.GetTradeMemberValue(inventoryControl, "partnerTradeItems");
			if (tradeMemberValue != null)
			{
				if (PrefixSubmit.TryCalculateTradeOverlayGemTotal(tradeMemberValue, "otherPlayerItems", "otherPlayerAmounts", out total, out slotCount))
				{
					return true;
				}
				if (PrefixSubmit.TryCalculateTradeOverlayGemTotal(tradeMemberValue, "myItems", "myAmounts", out total, out slotCount))
				{
					return true;
				}
			}
			object tradeMemberValue2 = PrefixSubmit.GetTradeMemberValue(inventoryControl, "ownTradeItems");
			return tradeMemberValue2 != null && PrefixSubmit.TryCalculateTradeOverlayGemTotal(tradeMemberValue2, "otherPlayerItems", "otherPlayerAmounts", out total, out slotCount);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00074214 File Offset: 0x00072414
		private static bool TryCalculateTradeOverlayGemTotal(object tradeOverlay, string itemsMemberName, string amountsMemberName, out int total, out int slotCount)
		{
			total = 0;
			slotCount = 0;
			object tradeMemberValue = PrefixSubmit.GetTradeMemberValue(tradeOverlay, itemsMemberName);
			object tradeMemberValue2 = PrefixSubmit.GetTradeMemberValue(tradeOverlay, amountsMemberName);
			if (tradeMemberValue == null || tradeMemberValue2 == null)
			{
				return false;
			}
			int val;
			int val2;
			if (!PrefixSubmit.TryGetTradeCollectionCount(tradeMemberValue, out val) || !PrefixSubmit.TryGetTradeCollectionCount(tradeMemberValue2, out val2))
			{
				return false;
			}
			int num = Math.Min(val, val2);
			bool result = false;
			for (int i = 0; i < num; i++)
			{
				object itemObject;
				object value;
				World.BlockType blockType;
				int num2;
				if (PrefixSubmit.TryGetTradeCollectionValue(tradeMemberValue, i, out itemObject) && PrefixSubmit.TryGetTradeCollectionValue(tradeMemberValue2, i, out value) && PrefixSubmit.TryGetTradeOfferBlockType(itemObject, out blockType) && PrefixSubmit.TryConvertTradeValueToInt32(value, out num2) && num2 > 0)
				{
					total += 럅.럎(blockType) * num2;
					slotCount++;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000742C4 File Offset: 0x000724C4
		private static object GetTradeMemberValue(object instance, string memberName)
		{
			if (instance == null || string.IsNullOrWhiteSpace(memberName))
			{
				return null;
			}
			Type type = instance.GetType();
			try
			{
				PropertyInfo property = type.GetProperty(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (property != null)
				{
					return property.GetValue(instance);
				}
				FieldInfo field = type.GetField(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (field != null)
				{
					return field.GetValue(instance);
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00074338 File Offset: 0x00072538
		private static bool TryGetTradeCollectionCount(object collection, out int count)
		{
			count = 0;
			if (collection == null)
			{
				return false;
			}
			Array array = collection as Array;
			if (array != null)
			{
				count = array.Length;
				return true;
			}
			ICollection collection2 = collection as ICollection;
			if (collection2 != null)
			{
				count = collection2.Count;
				return true;
			}
			return PrefixSubmit.TryConvertTradeValueToInt32(PrefixSubmit.GetTradeMemberValue(collection, "Count") ?? PrefixSubmit.GetTradeMemberValue(collection, "Length"), out count);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00074398 File Offset: 0x00072598
		private static bool TryGetTradeCollectionValue(object collection, int index, out object value)
		{
			value = null;
			if (collection == null || index < 0)
			{
				return false;
			}
			Array array = collection as Array;
			if (array != null)
			{
				if (index >= array.Length)
				{
					return false;
				}
				value = array.GetValue(index);
				return true;
			}
			else
			{
				IList list = collection as IList;
				if (list == null)
				{
					bool result;
					try
					{
						PropertyInfo property = collection.GetType().GetProperty("Item", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, new Type[]
						{
							typeof(int)
						}, null);
						if (property == null)
						{
							result = false;
						}
						else
						{
							value = property.GetValue(collection, new object[]
							{
								index
							});
							result = true;
						}
					}
					catch
					{
						result = false;
					}
					return result;
				}
				if (index >= list.Count)
				{
					return false;
				}
				value = list[index];
				return true;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0007445C File Offset: 0x0007265C
		private static bool TryGetTradeOfferBlockType(object itemObject, out World.BlockType blockType)
		{
			blockType = 0;
			if (itemObject == null)
			{
				return false;
			}
			object tradeMemberValue = PrefixSubmit.GetTradeMemberValue(itemObject, "blockType");
			if (tradeMemberValue is World.BlockType)
			{
				World.BlockType blockType2 = (World.BlockType)tradeMemberValue;
				blockType = blockType2;
				return true;
			}
			int num;
			if (!PrefixSubmit.TryConvertTradeValueToInt32(tradeMemberValue, out num))
			{
				return false;
			}
			blockType = num;
			return true;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000744A4 File Offset: 0x000726A4
		private static bool TryConvertTradeValueToInt32(object value, out int result)
		{
			result = 0;
			if (value == null)
			{
				return false;
			}
			if (value is int)
			{
				int num = (int)value;
				result = num;
				return true;
			}
			if (value is short)
			{
				short num2 = (short)value;
				result = (int)num2;
				return true;
			}
			if (value is byte)
			{
				byte b = (byte)value;
				result = (int)b;
				return true;
			}
			if (value is long)
			{
				long num3 = (long)value;
				if (num3 >= -2147483648L && num3 <= 2147483647L)
				{
					result = (int)num3;
					return true;
				}
			}
			bool result2;
			try
			{
				result = Convert.ToInt32(value);
				result2 = true;
			}
			catch
			{
				result2 = false;
			}
			return result2;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00074558 File Offset: 0x00072758
		private static void HandleGetStoredGems()
		{
			int num = 0;
			for (int i = 0; i < 럓.랾.worldSizeX; i++)
			{
				for (int j = 0; j < 럓.랾.worldSizeY; j++)
				{
					if (럓.랾.GetBlockType(i, j) == 135)
					{
						SafeData safeData = 럓.랾.GetWorldItemData(i, j).TryCast<SafeData>();
						if (safeData != null)
						{
							List<int> storageItemsAsInventoryKeys = safeData.storageItemsAsInventoryKeys;
							List<int> storageItemsAmounts = safeData.storageItemsAmounts;
							if (storageItemsAsInventoryKeys.Count == storageItemsAmounts.Count)
							{
								for (int k = 0; k < storageItemsAsInventoryKeys.Count; k++)
								{
									PlayerData.InventoryKey inventoryKey = PlayerData.InventoryKey.IntToInventoryKey(storageItemsAsInventoryKeys[k]);
									num += 럅.럎(inventoryKey.blockType) * storageItemsAmounts[k];
								}
							}
						}
					}
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Stored Gems In Safes: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00074654 File Offset: 0x00072854
		private static string FormatTimeAgo(long unixMs)
		{
			if (unixMs <= 0L)
			{
				return "unknown time";
			}
			TimeSpan timeSpan = DateTimeOffset.UtcNow - DateTimeOffset.FromUnixTimeMilliseconds(unixMs);
			if (timeSpan.TotalSeconds < 60.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>((int)timeSpan.TotalSeconds);
				defaultInterpolatedStringHandler.AppendLiteral("s ago");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (timeSpan.TotalMinutes < 60.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler2.AppendFormatted<int>((int)timeSpan.TotalMinutes);
				defaultInterpolatedStringHandler2.AppendLiteral("m ago");
				return defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			if (timeSpan.TotalHours < 24.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler3.AppendFormatted<int>((int)timeSpan.TotalHours);
				defaultInterpolatedStringHandler3.AppendLiteral("h ago");
				return defaultInterpolatedStringHandler3.ToStringAndClear();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler4.AppendFormatted<int>((int)timeSpan.TotalDays);
			defaultInterpolatedStringHandler4.AppendLiteral("d ago");
			return defaultInterpolatedStringHandler4.ToStringAndClear();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00074764 File Offset: 0x00072964
		private static void UndressBlocks(params World.BlockType[] blocks)
		{
			foreach (World.BlockType blockType in blocks)
			{
				OutgoingMessages.SendWearableOrWeaponUndress(blockType);
				럓.랾.UndressWearableOrWeaponRemote(blockType);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00074798 File Offset: 0x00072998
		private static void SpawnBlock(World.BlockType blockType, string message)
		{
			Player player;
			if (!PrefixSubmit.TryGetPlayer(out player))
			{
				return;
			}
			Vector2i currentPlayerMapPoint = player.currentPlayerMapPoint;
			ControllerHelper.worldController.SetBlock(blockType, currentPlayerMapPoint.x, currentPlayerMapPoint.y);
			ControllerHelper.worldController.world.SetBlock(blockType, currentPlayerMapPoint, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), false);
			럽.랾(message, false);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0003CF3B File Offset: 0x0003B13B
		private static void OpenAdminToolIfAccess<T>(string actionName) where T : Object
		{
			if (럽.랉() || 럽.랋())
			{
				ControllerHelper.rootUI.OnOrOffMenu(Il2CppType.Of<T>());
				return;
			}
			럽.람("You Do Not Have Permission To " + actionName + " All Players", false);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0003CF71 File Offset: 0x0003B171
		private static bool RequireDev()
		{
			if (럧.럑)
			{
				return true;
			}
			럽.랾("Invalid Command", false);
			return false;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0003CF88 File Offset: 0x0003B188
		private static bool TryGetInventory(out PlayerData.InventoryKey[] inventory)
		{
			inventory = null;
			if (럓.랾 == null)
			{
				럽.랾("Player data is not available.", false);
				return false;
			}
			inventory = 럓.랾.GetInventoryAsOrderedByInventoryItemType();
			return true;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0003CFB3 File Offset: 0x0003B1B3
		private static bool TryGetPlayer(out Player player)
		{
			WorldController worldController = ControllerHelper.worldController;
			player = ((worldController != null) ? worldController.player : null);
			if (player != null)
			{
				return true;
			}
			럽.랾("Player is not available.", false);
			return false;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0003CFE0 File Offset: 0x0003B1E0
		private static string[] SplitArguments(string text)
		{
			return text.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0003CFF4 File Offset: 0x0003B1F4
		private static string GetHomePath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "home.txt");
		}

		// Token: 0x02000020 RID: 32
		private enum 랾
		{
			// Token: 0x04000065 RID: 101
			랾,
			// Token: 0x04000066 RID: 102
			럎,
			// Token: 0x04000067 RID: 103
			람
		}

		// Token: 0x02000021 RID: 33
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x060000CD RID: 205 RVA: 0x000747F4 File Offset: 0x000729F4
			[global::랾.람(2)]
			internal Task 랾()
			{
				PrefixSubmit.럎.랾 랾;
				랾.랾 = AsyncTaskMethodBuilder.Create();
				랾.랾 = -1;
				랾.랾.Start<PrefixSubmit.럎.랾>(ref 랾);
				return 랾.랾.Task;
			}

			// Token: 0x060000CE RID: 206 RVA: 0x0003D013 File Offset: 0x0003B213
			internal long 랾([TupleElementNames(new string[]
			{
				"name",
				"world",
				"source",
				"ms"
			})] ValueTuple<string, string, string, long> e)
			{
				return e.Item4;
			}

			// Token: 0x060000CF RID: 207 RVA: 0x0003D01B File Offset: 0x0003B21B
			internal string 랾(란 A_1)
			{
				return A_1.랾();
			}

			// Token: 0x04000068 RID: 104
			public static readonly PrefixSubmit.럎 랾 = new PrefixSubmit.럎();

			// Token: 0x04000069 RID: 105
			[TupleElementNames(new string[]
			{
				"name",
				"world",
				"source",
				"ms"
			})]
			public static Func<ValueTuple<string, string, string, long>, long> 랾;

			// Token: 0x0400006A RID: 106
			[global::랾.럎(new byte[]
			{
				0,
				2
			})]
			public static Func<Task> 랾;

			// Token: 0x0400006B RID: 107
			public static Func<란, string> 랾;

			// Token: 0x02000022 RID: 34
			[StructLayout(LayoutKind.Auto)]
			private struct 랾 : IAsyncStateMachine
			{
				// Token: 0x060000D0 RID: 208 RVA: 0x00074830 File Offset: 0x00072A30
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.랾;
					try
					{
						ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = 럩.럯().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (this.랾 = 0);
								this.랾 = awaiter;
								this.랾.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, PrefixSubmit.럎.랾>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.랾;
							this.랾 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num = (this.랾 = -1);
						}
						string result = awaiter.GetResult();
						if (string.IsNullOrWhiteSpace(result))
						{
							럽.람(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩랸(), false);
						}
						else
						{
							JsonDocument jsonDocument = JsonDocument.Parse(result, default(JsonDocumentOptions));
							try
							{
								if (jsonDocument.RootElement.ValueKind != JsonValueKind.Array || jsonDocument.RootElement.GetArrayLength() == 0)
								{
									럽.람(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩랈(), false);
								}
								else
								{
									Dictionary<string, ValueTuple<string, string, string, long>> dictionary = new Dictionary<string, ValueTuple<string, string, string, long>>(StringComparer.OrdinalIgnoreCase);
									JsonElement.ArrayEnumerator enumerator = jsonDocument.RootElement.EnumerateArray().GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											JsonElement jsonElement = enumerator.Current;
											JsonElement jsonElement2;
											string text = jsonElement.TryGetProperty("tracked_player_id", out jsonElement2) ? jsonElement2.GetString() : null;
											JsonElement jsonElement3;
											string text2 = jsonElement.TryGetProperty("tracked_player_name", out jsonElement3) ? jsonElement3.GetString() : null;
											JsonElement jsonElement4;
											string item = jsonElement.TryGetProperty("world_name", out jsonElement4) ? (jsonElement4.GetString() ?? "Unknown") : "Unknown";
											JsonElement jsonElement5;
											string item2 = jsonElement.TryGetProperty("source", out jsonElement5) ? (jsonElement5.GetString() ?? "unknown") : "unknown";
											JsonElement jsonElement6;
											long num3;
											long num2 = (jsonElement.TryGetProperty("last_seen_unix_ms", out jsonElement6) && jsonElement6.TryGetInt64(out num3)) ? num3 : 0L;
											if (!string.IsNullOrWhiteSpace(text))
											{
												if (string.IsNullOrWhiteSpace(text2))
												{
													럧.랾.TryGetValue(text, out text2);
												}
												ValueTuple<string, string, string, long> valueTuple;
												if (!dictionary.TryGetValue(text, out valueTuple) || num2 > valueTuple.Item4)
												{
													dictionary[text] = new ValueTuple<string, string, string, long>(text2 ?? text, item, item2, num2);
												}
											}
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)enumerator).Dispose();
										}
									}
									if (dictionary.Count == 0)
									{
										럽.람(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩랎(), false);
									}
									else
									{
										List<ValueTuple<string, string, string, long>> list = dictionary.Values.OrderByDescending(new Func<ValueTuple<string, string, string, long>, long>(PrefixSubmit.럎.랾.랾)).ToList<ValueTuple<string, string, string, long>>();
										럽.랾(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩럹(), false);
										List<ValueTuple<string, string, string, long>>.Enumerator enumerator2 = list.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												ValueTuple<string, string, string, long> valueTuple2 = enumerator2.Current;
												string item3 = valueTuple2.Item1;
												string item4 = valueTuple2.Item2;
												string item5 = valueTuple2.Item3;
												string value = PrefixSubmit.FormatTimeAgo(valueTuple2.Item4);
												DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 4);
												defaultInterpolatedStringHandler.AppendLiteral("  ");
												defaultInterpolatedStringHandler.AppendFormatted(item3);
												defaultInterpolatedStringHandler.AppendLiteral(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩럿());
												defaultInterpolatedStringHandler.AppendFormatted(item4);
												defaultInterpolatedStringHandler.AppendLiteral(" (");
												defaultInterpolatedStringHandler.AppendFormatted(item5);
												defaultInterpolatedStringHandler.AppendLiteral(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩랩());
												defaultInterpolatedStringHandler.AppendFormatted(value);
												럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
											}
										}
										finally
										{
											if (num < 0)
											{
												((IDisposable)enumerator2).Dispose();
											}
										}
									}
								}
							}
							finally
							{
								if (num < 0 && jsonDocument != null)
								{
									((IDisposable)jsonDocument).Dispose();
								}
							}
						}
					}
					catch (Exception exception)
					{
						this.랾 = -2;
						this.랾.SetException(exception);
						return;
					}
					this.랾 = -2;
					this.랾.SetResult();
				}

				// Token: 0x060000D1 RID: 209 RVA: 0x0003D023 File Offset: 0x0003B223
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::랾.럎(1)] IAsyncStateMachine stateMachine)
				{
					this.랾.SetStateMachine(stateMachine);
				}

				// Token: 0x0400006C RID: 108
				public int 랾;

				// Token: 0x0400006D RID: 109
				public AsyncTaskMethodBuilder 랾;

				// Token: 0x0400006E RID: 110
				private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter 랾;
			}
		}

		// Token: 0x02000023 RID: 35
		[CompilerGenerated]
		private sealed class 람
		{
			// Token: 0x060000D3 RID: 211 RVA: 0x0003D031 File Offset: 0x0003B231
			internal bool 랾(란 A_1)
			{
				return A_1.람() == this.랾;
			}

			// Token: 0x0400006F RID: 111
			public 랬 랾;
		}
	}
}
