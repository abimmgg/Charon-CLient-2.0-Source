using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BepInEx;
using CharonClient.Configuration;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;
using UnityEngine;
using 랾;

namespace CharonAndFriends
{
	// Token: 0x02000071 RID: 113
	[HarmonyPatch(typeof(NetworkClient), "HandleMessages")]
	public static class NetworkClient_HandleMessage
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00081738 File Offset: 0x0007F938
		public static void Prefix(ref BSONObject messages)
		{
			int num;
			if (!럘.랾(messages, "mc", out num))
			{
				return;
			}
			if (랦.럼() != 랦.랾.랾)
			{
				return;
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				BSONObject bsonobject;
				if (럘.랾(messages, "m" + i.ToString(), out bsonobject) && !랪.럎(bsonobject, "Server"))
				{
					if (num2 != i)
					{
						messages["m" + num2.ToString()] = bsonobject;
					}
					num2++;
					string text = 럘.랾(bsonobject);
					if (!(text == "mP") && !랟.람(text))
					{
						랟.랾(bsonobject, "Server");
						NetworkClient_HandleMessage.HandleWarnings(bsonobject, text);
						NetworkClient_HandleMessage.HandleModMessageDeletion(bsonobject, text);
						NetworkClient_HandleMessage.HandleFrequencyMessageDeletion(bsonobject, text);
						NetworkClient_HandleMessage.HandleFishingPreview(bsonobject, text);
						NetworkClient_HandleMessage.HandlePortalAnimation(bsonobject, text);
						NetworkClient_HandleMessage.HandleKickBan(bsonobject, text);
						NetworkClient_HandleMessage.HandleSummon(bsonobject, text);
						랟.랾(bsonobject, text, "Server");
						if (!(text == "ST"))
						{
							string userId;
							if (럘.랾(bsonobject, "U", out userId))
							{
								NetworkClient_HandleMessage.HandlePlayerGemLogging(bsonobject, userId);
								NetworkClient_HandleMessage.HandleStaffDetection(text, userId);
								NetworkClient_HandleMessage.HandleAddNetworkPlayer(bsonobject, text, userId);
							}
							else
							{
								NetworkClient_HandleMessage.HandleTradeCompleted(bsonobject, text);
							}
							NetworkClient_HandleMessage.HandleChatMessage(bsonobject);
						}
					}
				}
			}
			if (num2 != num)
			{
				for (int j = num2; j < num; j++)
				{
					messages.mMap.Remove("m" + j.ToString());
				}
				messages["mc"] = num2;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000818C4 File Offset: 0x0007FAC4
		private static void HandleWarnings(BSONObject packet, string packetId)
		{
			if (packetId != "WarnPlayer")
			{
				return;
			}
			string str;
			if (!럘.랾(packet, "ReasonForWarning", out str))
			{
				str = "Unknown";
			}
			string text = "An Admin/Mod Has Warned You For: " + str;
			럽.람(text, false);
			럽.람(text);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0008190C File Offset: 0x0007FB0C
		private static void HandleModMessageDeletion(BSONObject packet, string packetId)
		{
			if (packetId != "MGMbP")
			{
				return;
			}
			string b;
			if (!럘.랾(packet, "TID", out b))
			{
				return;
			}
			string str = string.Empty;
			foreach (ChatMessage chatMessage in ChatClient.storedMessagesForWorldChange)
			{
				if (chatMessage.userID == b)
				{
					str = chatMessage.nick;
					break;
				}
			}
			string text = "A Moderator Tried Deleting A Global Message Sent By: " + str;
			럽.랾(text, false);
			럽.람(text);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00081988 File Offset: 0x0007FB88
		private static void HandleFrequencyMessageDeletion(BSONObject packet, string packetId)
		{
			if (packetId != "MFMbP")
			{
				return;
			}
			string text;
			if (!럘.랾(packet, "TID", out text))
			{
				return;
			}
			int value;
			럘.랾(packet, "FRQ", out value);
			string text2;
			if (럽.랾(text))
			{
				string nameWithId = NetworkPlayers.GetNameWithId(text, false);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(76, 2);
				defaultInterpolatedStringHandler.AppendLiteral("A Moderator Tried Deleting A Frequency Message Sent By: ");
				defaultInterpolatedStringHandler.AppendFormatted(nameWithId);
				defaultInterpolatedStringHandler.AppendLiteral(" At A Frequency Of: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(86, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("A Moderator Tried Deleting A Frequency Message Sent By Player ID: ");
				defaultInterpolatedStringHandler2.AppendFormatted(text);
				defaultInterpolatedStringHandler2.AppendLiteral(" At A Frequency Of: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(value);
				text2 = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			럽.랾(text2, false);
			럽.람(text2);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00081A54 File Offset: 0x0007FC54
		private static void HandlePortalAnimation(BSONObject packet, string packetId)
		{
			if (packetId != "PAiP")
			{
				return;
			}
			int value;
			int value2;
			string text;
			if (!럘.랾(packet, "x", out value) || !럘.랾(packet, "y", out value2) || !럘.랾(packet, "U", out text))
			{
				return;
			}
			string nameWithId = NetworkPlayers.GetNameWithId(text, true);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
			defaultInterpolatedStringHandler.AppendLiteral("Portal Activated By: ");
			defaultInterpolatedStringHandler.AppendFormatted(nameWithId);
			defaultInterpolatedStringHandler.AppendLiteral(", ID: ");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(". At X:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral(" Y:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
			럽.랾(nameWithId, 럧.럎);
			럽.랾(럧.럎, 50, "CHEATER");
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00081B28 File Offset: 0x0007FD28
		private static void HandleFishingPreview(BSONObject packet, string packetId)
		{
			if (packetId != "MGA")
			{
				return;
			}
			int 럔;
			if (럘.랾(packet, "MGT", out 럔))
			{
				럧.럔 = 럔;
			}
			int 랞;
			if (럘.랾(packet, "MGD", out 랞))
			{
				럧.랞 = 랞;
			}
			int 럩;
			bool flag = 럘.랾(packet, "BT", out 럩);
			int 랦;
			bool flag2 = 럘.랾(packet, "WBT", out 랦);
			if (flag)
			{
				럧.럩 = 럩;
			}
			if (flag2)
			{
				럧.랦 = 랦;
			}
			if (flag || flag2)
			{
				럧.럸 = Time.realtimeSinceStartup;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0003E8C8 File Offset: 0x0003CAC8
		private static void HandleKickBan(BSONObject packet, string packetId)
		{
			if (packetId != "LW" || !ConfigFile.pausedLeaveToggle || !럽.랾())
			{
				return;
			}
			럽.람("Incoming Kick/Ban From The World", false);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00081BAC File Offset: 0x0007FDAC
		private static void HandleSummon(BSONObject packet, string packetId)
		{
			if (packetId != "DoPSE" || !럽.랾())
			{
				return;
			}
			string a;
			if (럘.랾(packet, "U", out a) && a == 럓.랾.playerId && ConfigFile.leaveUponSummon)
			{
				럽.람("You were summoned. Leaving world.", false);
				OutgoingMessages.LeaveWorld();
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00081C08 File Offset: 0x0007FE08
		private static void HandlePlayerGemLogging(BSONObject packet, string userId)
		{
			if (!럽.람() && !럽.랾())
			{
				return;
			}
			int num;
			if (럘.랾(packet, "GAmt", out num))
			{
				string value;
				럘.랾(packet, "UN", out value);
				int item;
				럘.랾(packet, "xpLvL", out item);
				if (!럧.랾.Contains(new ValueTuple<string, int, int>(userId, num, item)))
				{
					럧.랾.Add(new ValueTuple<string, int, int>(userId, num, item));
				}
				if (ConfigFile.bsonInGameLoggerToggle)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendLiteral("Player: ");
					defaultInterpolatedStringHandler.AppendFormatted(value);
					defaultInterpolatedStringHandler.AppendLiteral(", User ID: ");
					defaultInterpolatedStringHandler.AppendFormatted(userId);
					defaultInterpolatedStringHandler.AppendLiteral(", Gems: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					럽.럼(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				}
				if (!string.IsNullOrWhiteSpace(userId) && 럧.랾.Add(userId))
				{
					string.IsNullOrWhiteSpace(value);
				}
			}
			럽.럼(packet, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00081CFC File Offset: 0x0007FEFC
		private static void HandleStaffDetection(string packetId, string userId)
		{
			if (packetId == "AnP")
			{
				return;
			}
			if (!럧.랾.ContainsKey(userId))
			{
				return;
			}
			string text = 럧.랾[userId];
			string text2;
			string str;
			if (럽.랾(userId))
			{
				text2 = "Mod/Admin found: " + text;
				str = "visible";
			}
			else
			{
				text2 = "Invisible Mod/Admin found: " + text;
				str = "invisible";
			}
			if (럽.랾() && 럧.럑)
			{
				럽.랾("Mod/Admin found. Kicking from world.", false);
			}
			if (!NetworkClient_HandleMessage.ShouldEmitStaffDetection(userId, "local:" + str))
			{
				return;
			}
			럽.람(text2, false);
			럽.람(text2);
			string text3 = text;
			World world = 럓.랾;
			럩.랾(userId, text3, (world != null) ? world.worldName : null, "local");
			if (ConfigFile.webhookModDetectToggle && !Utility.IsNullOrWhiteSpace(ConfigFile.modDetectedWebhookLink))
			{
				랫.랾(ConfigFile.modDetectedWebhookLink, "Mod/Admin Detected", text2);
			}
			if (ConfigFile.autoLeaveToggle)
			{
				SceneLoader.GoFromWorldToMainMenu();
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		private static void HandleAddNetworkPlayer(BSONObject packet, string packetId, string userId)
		{
			if (packet == null || packetId != "AnP")
			{
				return;
			}
			if (string.IsNullOrEmpty(userId))
			{
				userId = "UnknownUserId";
			}
			string text = "Unknown";
			럘.랾(packet, "UN", out text);
			if (럧.럷 && ConfigFile.abandonNetherPlayersToggle && 럓.랾 != null && 럓.랾.worldName == "NETHERWORLD")
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Abandoning Nether Player Detected: ");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(" (");
				defaultInterpolatedStringHandler.AppendFormatted(userId);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				럽.럼(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				OutgoingMessages.LeaveWorld();
			}
			string value;
			if (럧.랾 != null && 럧.랾.TryGetValue(userId, out value))
			{
				bool flag = false;
				try
				{
					flag = NetworkClient_HandleMessage.IsOtherPlayerVisible(userId);
				}
				catch (Exception value2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 3);
					defaultInterpolatedStringHandler2.AppendLiteral("IsOtherPlayerVisible failed for ");
					defaultInterpolatedStringHandler2.AppendFormatted(text);
					defaultInterpolatedStringHandler2.AppendLiteral(" (");
					defaultInterpolatedStringHandler2.AppendFormatted(userId);
					defaultInterpolatedStringHandler2.AppendLiteral("): ");
					defaultInterpolatedStringHandler2.AppendFormatted<Exception>(value2);
					럽.람(defaultInterpolatedStringHandler2.ToStringAndClear(), false);
					return;
				}
				if (!flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(32, 2);
					defaultInterpolatedStringHandler3.AppendLiteral("[INVISIBLE] Admin/Mod found: ");
					defaultInterpolatedStringHandler3.AppendFormatted(value);
					defaultInterpolatedStringHandler3.AppendLiteral(" (");
					defaultInterpolatedStringHandler3.AppendFormatted(text);
					defaultInterpolatedStringHandler3.AppendLiteral(")");
					string text2 = defaultInterpolatedStringHandler3.ToStringAndClear();
					if (!NetworkClient_HandleMessage.ShouldEmitStaffDetection(userId, "anp:invisible:" + text))
					{
						NetworkClient_HandleMessage.HandleUndercoverDetection(packet, text);
						return;
					}
					럽.람(text2, false);
					럽.람(text2);
					if (ConfigFile.autoLeaveToggle)
					{
						SceneLoader.GoFromWorldToMainMenu();
					}
					럽.럼(packet, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					return;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler4.AppendLiteral("Admin/Mod found: ");
					defaultInterpolatedStringHandler4.AppendFormatted(value);
					defaultInterpolatedStringHandler4.AppendLiteral(" (");
					defaultInterpolatedStringHandler4.AppendFormatted(text);
					defaultInterpolatedStringHandler4.AppendLiteral(")");
					string text3 = defaultInterpolatedStringHandler4.ToStringAndClear();
					if (NetworkClient_HandleMessage.ShouldEmitStaffDetection(userId, "anp:visible:" + text))
					{
						럽.람(text3, false);
						럽.람(text3);
						if (ConfigFile.autoLeaveToggle)
						{
							SceneLoader.GoFromWorldToMainMenu();
						}
					}
				}
			}
			NetworkClient_HandleMessage.HandleUndercoverDetection(packet, text);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0008204C File Offset: 0x0008024C
		private static void HandleUndercoverDetection(BSONObject packet, string userName)
		{
			bool flag2;
			bool flag = 럘.랾(packet, "AdminSetUndercoverModeValue", out flag2);
			bool flag4;
			bool flag3 = 럘.랾(packet, "AdminSetGhostModeValue", out flag4);
			if (!flag && !flag3)
			{
				return;
			}
			if (flag2)
			{
				string text = "Undercover Admin/Mod found: " + userName;
				if (NetworkClient_HandleMessage.ShouldEmitStaffDetection(userName, "undercover"))
				{
					럽.람(text, false);
					럽.람(text);
				}
			}
			if (flag4)
			{
				string text2 = "Ghost Admin/Mod found: " + userName;
				if (NetworkClient_HandleMessage.ShouldEmitStaffDetection(userName, "ghost"))
				{
					럽.람(text2, false);
					럽.람(text2);
				}
			}
			if ((flag2 || flag4) && ConfigFile.autoLeaveToggle)
			{
				SceneLoader.GoFromWorldToMainMenu();
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000820E0 File Offset: 0x000802E0
		private static void HandleTradeCompleted(BSONObject packet, string packetId)
		{
			if (packetId != "TVC" || !ConfigFile.otherPlayerTradeInfoToggle)
			{
				return;
			}
			string text;
			string text2;
			List<int> list;
			List<int> list2;
			if (!럘.랾(packet, "starterId", out text) || !럘.랾(packet, "partnerId", out text2) || !럘.랾(packet, "starterItems", out list) || !럘.랾(packet, "partnerItems", out list2))
			{
				return;
			}
			string value = NetworkClient_HandleMessage.NormalizeTradeName(NetworkPlayers.GetNameWithId(text, true));
			string value2 = NetworkClient_HandleMessage.NormalizeTradeName(NetworkPlayers.GetNameWithId(text2, true));
			List<World.BlockType> values = 럽.랾(list);
			List<World.BlockType> values2 = 럽.랾(list2);
			string value3 = string.Join<World.BlockType>(", ", values);
			string value4 = string.Join<World.BlockType>(", ", values2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 6);
			defaultInterpolatedStringHandler.AppendLiteral("Player: ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" Completed Trade With: ");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("");
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" Items: ");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral("");
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(" Items: ");
			defaultInterpolatedStringHandler.AppendFormatted(value4);
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00082234 File Offset: 0x00080434
		private static void HandleChatMessage(BSONObject packet)
		{
			BSONObject bsonobject;
			if (!럘.랾(packet, "CmB", out bsonobject))
			{
				return;
			}
			int num;
			럘.랾(bsonobject, "channelIndex", out num);
			if (num == 1)
			{
				return;
			}
			럽.럼(bsonobject, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			string text;
			string text2;
			string text3;
			string text4;
			if (!럘.랾(bsonobject, "message", out text) || !럘.랾(bsonobject, "nick", out text2) || !럘.랾(bsonobject, "userID", out text3) || !럘.랾(bsonobject, "channel", out text4))
			{
				return;
			}
			if (num == 2)
			{
				Console.WriteLine("World: " + text4 + " Message: " + text);
			}
			NetworkClient_HandleMessage.DetectStaffInChat(text3, text2, text4);
			랺.랾(text2, text3, text4, text);
			NetworkClient_HandleMessage.HandleCloneChat(text2, text);
			NetworkClient_HandleMessage.HandleAutoMath(text4, text);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000822EC File Offset: 0x000804EC
		private static void DetectStaffInChat(string playerId, string playerName, string worldName)
		{
			if (!럧.랾.ContainsKey(playerId))
			{
				return;
			}
			if (!NetworkClient_HandleMessage.ShouldEmitStaffDetection(playerId, "chat:" + playerName))
			{
				return;
			}
			string value = 럧.랾[playerId];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Mod/Admin Detected: World: ");
			defaultInterpolatedStringHandler.AppendFormatted(worldName);
			defaultInterpolatedStringHandler.AppendLiteral(", Mod Name: ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(", Undercover Name: ");
			defaultInterpolatedStringHandler.AppendFormatted(playerName);
			럽.람(defaultInterpolatedStringHandler.ToStringAndClear());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(34, 3);
			defaultInterpolatedStringHandler2.AppendLiteral("Mod/Admin Detected: ");
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			defaultInterpolatedStringHandler2.AppendLiteral(" (");
			defaultInterpolatedStringHandler2.AppendFormatted(playerName);
			defaultInterpolatedStringHandler2.AppendLiteral(") in World: ");
			defaultInterpolatedStringHandler2.AppendFormatted(worldName);
			럽.람(defaultInterpolatedStringHandler2.ToStringAndClear(), !ConfigFile.modAndAdminNotifications);
			럩.랾(playerId, playerName, worldName, "chat");
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000823E0 File Offset: 0x000805E0
		private static bool ShouldEmitStaffDetection(string subjectKey, string reasonKey)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			World world = 럓.랾;
			string b = ((world != null) ? world.worldName : null) ?? string.Empty;
			if (!string.Equals(NetworkClient_HandleMessage.랾, b, StringComparison.OrdinalIgnoreCase))
			{
				NetworkClient_HandleMessage.랾 = b;
				NetworkClient_HandleMessage.랾.Clear();
			}
			string key = subjectKey + "|" + reasonKey;
			float num;
			if (NetworkClient_HandleMessage.랾.TryGetValue(key, out num) && realtimeSinceStartup < num)
			{
				return false;
			}
			NetworkClient_HandleMessage.랾[key] = realtimeSinceStartup + 10f;
			if (NetworkClient_HandleMessage.랾.Count > 256)
			{
				NetworkClient_HandleMessage.TrimExpiredStaffDetectionCooldowns(realtimeSinceStartup);
			}
			return true;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00082478 File Offset: 0x00080678
		private static void TrimExpiredStaffDetectionCooldowns(float now)
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, float> keyValuePair in NetworkClient_HandleMessage.랾)
			{
				if (keyValuePair.Value <= now)
				{
					list.Add(keyValuePair.Key);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				NetworkClient_HandleMessage.랾.Remove(list[i]);
			}
			if (NetworkClient_HandleMessage.랾.Count > 256)
			{
				NetworkClient_HandleMessage.랾.Clear();
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00082520 File Offset: 0x00080720
		private static void HandleCloneChat(string playerName, string message)
		{
			if (!럧.럚 || string.IsNullOrWhiteSpace(playerName))
			{
				return;
			}
			if ((럧.랺 ?? string.Empty).IndexOf(playerName, StringComparison.OrdinalIgnoreCase) < 0)
			{
				return;
			}
			럓.랾.Submit(message.Replace("/", string.Empty));
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0003E8F1 File Offset: 0x0003CAF1
		private static void HandleAutoMath(string worldName, string message)
		{
			if (!럧.랆 || 럓.랾 == null)
			{
				return;
			}
			if (럓.랾.worldName != worldName)
			{
				return;
			}
			랴.랾(message);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0003E91B File Offset: 0x0003CB1B
		private static bool IsOtherPlayerVisible(string userId)
		{
			return 럽.랾(userId);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0003E923 File Offset: 0x0003CB23
		private static string NormalizeTradeName(string name)
		{
			if (!(name == "Default"))
			{
				return name;
			}
			return ConfigFile.customPlayerNameValue;
		}

		// Token: 0x040002FD RID: 765
		private const float 랾 = 10f;

		// Token: 0x040002FE RID: 766
		private const int 랾 = 256;

		// Token: 0x040002FF RID: 767
		private static readonly Dictionary<string, float> 랾 = new Dictionary<string, float>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000300 RID: 768
		private static string 랾 = string.Empty;
	}
}
