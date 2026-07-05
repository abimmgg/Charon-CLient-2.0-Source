using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ImGuiNET;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000063 RID: 99
	internal class 럽
	{
		// Token: 0x06000385 RID: 901 RVA: 0x0007EB30 File Offset: 0x0007CD30
		private static void 랾(string A_0, string A_1, string A_2 = "[Charon Client]:", 럽.랾 A_3 = 럽.랾.랾, bool A_4 = false)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			if (!A_4 && ConfigFile.showNotifications && !A_0.Contains("/"))
			{
				string text = string.IsNullOrWhiteSpace(A_2) ? "Notification" : A_2;
				switch (A_3)
				{
				case 럽.랾.럎:
					랃.럎(text, A_0, 4f);
					return;
				case 럽.랾.람:
					랃.람(text, A_0, 4f);
					return;
				case 럽.랾.럒:
					랃.럒(text, A_0, 4f);
					return;
				default:
					랃.랾(text, A_0, 4f);
					return;
				}
			}
			else
			{
				if (ControllerHelper.chatUI == null)
				{
					return;
				}
				string text2;
				if (!string.IsNullOrWhiteSpace(A_2))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
					defaultInterpolatedStringHandler.AppendLiteral("b><color=");
					defaultInterpolatedStringHandler.AppendFormatted(A_1);
					defaultInterpolatedStringHandler.AppendLiteral(">");
					defaultInterpolatedStringHandler.AppendFormatted(A_2);
					defaultInterpolatedStringHandler.AppendLiteral("<b ");
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text2 = string.Empty;
				}
				string text3 = text2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(16, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("<color=");
				defaultInterpolatedStringHandler2.AppendFormatted(A_1);
				defaultInterpolatedStringHandler2.AppendLiteral(">");
				defaultInterpolatedStringHandler2.AppendFormatted(A_0);
				defaultInterpolatedStringHandler2.AppendLiteral("</color>");
				ChatMessage chatMessage = new ChatMessage(defaultInterpolatedStringHandler2.ToStringAndClear(), DateTime.Now, 6, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), text3, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
				ControllerHelper.chatUI.NewMessage(chatMessage);
				return;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0003E438 File Offset: 0x0003C638
		public static void 랾(string A_0, bool A_1 = false)
		{
			럽.랾(A_0, "#00FF00", "[Charon Client]:", 럽.랾.럎, A_1);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0003E44C File Offset: 0x0003C64C
		public static void 럎(string A_0, bool A_1 = false)
		{
			럽.랾(A_0, "#FFFF00", "[Charon Client]:", 럽.랾.람, A_1);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0003E460 File Offset: 0x0003C660
		public static void 람(string A_0, bool A_1 = false)
		{
			럽.랾(A_0, "#FF4C4C", "[Charon Client]:", 럽.랾.럒, A_1);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0003E474 File Offset: 0x0003C674
		public static void 럒(string A_0, bool A_1 = false)
		{
			럽.랾(A_0, "#89CFF0", "[Charon Client]:", 럽.랾.랾, A_1);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0003E488 File Offset: 0x0003C688
		public static void 랾(string A_0, string A_1, bool A_2 = true)
		{
			럽.랾(A_0, "#89CFF0", "[" + A_1 + "]:", 럽.랾.랾, A_2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0007EC8C File Offset: 0x0007CE8C
		public static void 럎(string A_0, string A_1, bool A_2 = true)
		{
			string str = string.IsNullOrWhiteSpace(A_1) ? "Client_UNKNOWN" : A_1.Trim();
			럽.랾(A_0, "#89CFF0", str + " Sent:", 럽.랾.랾, A_2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0003E4A7 File Offset: 0x0003C6A7
		public static void 럼(string A_0, bool A_1 = false)
		{
			럽.랾(A_0, "#BF40BF", "[BSON]:", 럽.랾.랾, A_1);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0007ECC8 File Offset: 0x0007CEC8
		public static Vector2i 랾(Vector2 A_0)
		{
			Vector2i result = default(Vector2i);
			result.x = (int)Mathf.Round(A_0.x / ConfigData.tileSizeX);
			result.y = (int)((A_0.y + ConfigData.tileSizeX / 2f) / ConfigData.tileSizeY);
			return result;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0003E4BB File Offset: 0x0003C6BB
		public static Vector2 랾(Vector2i A_0)
		{
			return new Vector2((float)A_0.x * ConfigData.tileSizeX, (float)A_0.y * ConfigData.tileSizeY);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0007ED18 File Offset: 0x0007CF18
		public static bool 랾()
		{
			PlayerConnectionStatus playerConnectionStatus;
			return 럽.랾(out playerConnectionStatus) && playerConnectionStatus == 9;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0007ED38 File Offset: 0x0007CF38
		public static bool 럎()
		{
			PlayerConnectionStatus playerConnectionStatus;
			return 럽.랾(out playerConnectionStatus) && playerConnectionStatus == 7;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0007ED54 File Offset: 0x0007CF54
		public static bool 람()
		{
			PlayerConnectionStatus playerConnectionStatus;
			return 럽.랾(out playerConnectionStatus) && playerConnectionStatus == 8;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0007ED70 File Offset: 0x0007CF70
		public static NetworkPlayer[] 럒()
		{
			NetworkPlayer[] result;
			try
			{
				List<NetworkPlayer> otherPlayers = NetworkPlayers.otherPlayers;
				Il2CppArrayBase<NetworkPlayer> il2CppArrayBase = (otherPlayers != null) ? otherPlayers.ToArray() : null;
				result = ((il2CppArrayBase != null) ? il2CppArrayBase : Array.Empty<NetworkPlayer>());
			}
			catch
			{
				result = Array.Empty<NetworkPlayer>();
			}
			return result;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0007EDBC File Offset: 0x0007CFBC
		public static bool 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			try
			{
				foreach (NetworkPlayer networkPlayer in 럽.럒())
				{
					if (networkPlayer != null && string.Equals(networkPlayer.clientId, A_0, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public static bool 럼()
		{
			return 럓.랾.worldName == 럓.랾.clanName;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0003E4F7 File Offset: 0x0003C6F7
		public static bool 랋()
		{
			return 럓.랾.lockWorldDataHelper.DoesPlayerHaveAccessToLock(럓.랾.playerId, 럽.럼(), 럓.랾.clanMemberRank);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0003E521 File Offset: 0x0003C721
		public static bool 랉()
		{
			return 럓.랾.lockWorldDataHelper.DoesPlayerHaveMinorAccessToLock(럓.랾.playerId, 럽.럼(), 럓.랾.clanMemberRank);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0003E54B File Offset: 0x0003C74B
		public static bool 럐()
		{
			return 럽.랾(true);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0003E553 File Offset: 0x0003C753
		public static bool 랓()
		{
			return 럽.랾(false);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0007EE1C File Offset: 0x0007D01C
		private static bool 랾(bool A_0)
		{
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				bool flag;
				if (networkPlayer == null)
				{
					flag = (null != null);
				}
				else
				{
					Player playerScript = networkPlayer.playerScript;
					flag = (((playerScript != null) ? playerScript.myPlayerData : null) != null);
				}
				if (flag)
				{
					string clanName = networkPlayer.playerScript.myPlayerData.GetClanName();
					int clanMemberRank = networkPlayer.playerScript.myPlayerData.GetClanMemberRank();
					bool flag2 = clanName == 럓.랾.worldName;
					if (A_0 ? 럓.랾.lockWorldDataHelper.DoesPlayerHaveAccessToLock(networkPlayer.clientId, flag2, clanMemberRank) : 럓.랾.lockWorldDataHelper.DoesPlayerHaveMinorAccessToLock(networkPlayer.clientId, flag2, clanMemberRank))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0007EED0 File Offset: 0x0007D0D0
		private static bool 랾(out PlayerConnectionStatus A_0)
		{
			A_0 = 0;
			bool result;
			try
			{
				NetworkClient networkClient = ControllerHelper.networkClient;
				if (networkClient == null)
				{
					result = false;
				}
				else
				{
					A_0 = networkClient.playerConnectionStatus;
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0003E55B File Offset: 0x0003C75B
		public static bool 랾(World.BlockType A_0)
		{
			return A_0 == 110 || A_0 == 4103 || A_0 == 3966;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0003E574 File Offset: 0x0003C774
		public static bool 랾(World A_0, World.BlockType A_1)
		{
			return A_0.ContainsBlock(A_1);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0007EF18 File Offset: 0x0007D118
		public static bool 랾(World A_0)
		{
			foreach (World.BlockType blockType in 럽.랾)
			{
				if (A_0.ContainsBlock(blockType))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0003E57D File Offset: 0x0003C77D
		public static bool 럎(World.BlockType A_0)
		{
			return A_0 == 3966;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0003E587 File Offset: 0x0003C787
		public static bool 람(World.BlockType A_0)
		{
			return A_0 == 4171;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003E591 File Offset: 0x0003C791
		public static void 랾(int A_0, int A_1)
		{
			OutgoingMessages.SendHitBlockMessage(new Vector2i(A_0, A_1), DateTime.Now, false);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0003E5A5 File Offset: 0x0003C7A5
		public static void 럎(int A_0, int A_1)
		{
			OutgoingMessages.SendHitBlockBackgroundMessage(new Vector2i(A_0, A_1), DateTime.Now);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0003E5B8 File Offset: 0x0003C7B8
		public static void 람(int A_0, int A_1)
		{
			OutgoingMessages.SendHitBlockWaterMessage(new Vector2i(A_0, A_1), DateTime.Now);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0007EF4C File Offset: 0x0007D14C
		public static void 랾(int A_0, int A_1, int A_2)
		{
			BSONObject bsonobject = new BSONObject();
			bsonobject["ID"] = "SB";
			bsonobject["x"] = A_0;
			bsonobject["y"] = A_1;
			bsonobject["BlockType"] = A_2;
			OutgoingMessages.AddOneMessageToList(bsonobject);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0003E5CB File Offset: 0x0003C7CB
		public static World.BlockType 랾(int A_0)
		{
			return PlayerData.InventoryKey.IntToInventoryKey(A_0).blockType;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0007EFAC File Offset: 0x0007D1AC
		public static List<World.BlockType> 랾(List<int> A_0)
		{
			List<PlayerData.InventoryKey> list = PlayerData.InventoryKey.IntListToInventoryKeyList(A_0);
			List<World.BlockType> list2 = new List<World.BlockType>();
			foreach (PlayerData.InventoryKey inventoryKey in list)
			{
				list2.Add(inventoryKey.blockType);
			}
			if (list2.Count <= 0)
			{
				return new List<World.BlockType>
				{
					0
				};
			}
			return list2;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0003E5D8 File Offset: 0x0003C7D8
		public static PlayerData.InventoryKey 랾(World.BlockType A_0, PlayerData.InventoryItemType A_1)
		{
			return new PlayerData.InventoryKey(A_0, A_1);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0007F000 File Offset: 0x0007D200
		public static bool 랾(PlayerData.InventoryKey A_0)
		{
			int num = PlayerData.InventoryKey.BlockTypeAndInventoryItemTypeToInt(A_0.blockType, A_0.itemType);
			return 럓.랾.inventory.ContainsKey(num);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0007F030 File Offset: 0x0007D230
		public static bool 랾(string A_0, int A_1 = 1)
		{
			if (!string.IsNullOrWhiteSpace(A_0) && A_1 > 0)
			{
				Player player = 럓.랾;
				if (((player != null) ? player.myPlayerData : null) != null)
				{
					World.BlockType blockType;
					if (!럽.랾(A_0, out blockType))
					{
						return false;
					}
					PlayerData.InventoryItemType blockTypeInventoryItemType = ConfigData.GetBlockTypeInventoryItemType(blockType);
					short num = (short)Math.Clamp(A_1, 1, 32767);
					럓.랾.myPlayerData.AddItemToInventory(blockType, blockTypeInventoryItemType, num, null);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0007F094 File Offset: 0x0007D294
		public static bool 랾(string A_0, out World.BlockType A_1)
		{
			if (A_0 != null)
			{
				switch (A_0.Length)
				{
				case 8:
					if (A_0 == "DarkLock")
					{
						A_1 = 882;
						return true;
					}
					break;
				case 9:
				{
					char c = A_0[0];
					if (c != 'L')
					{
						if (c != 'S')
						{
							if (c == 'W')
							{
								if (A_0 == "WorldLock")
								{
									A_1 = 413;
									return true;
								}
							}
						}
						else if (A_0 == "SmallLock")
						{
							A_1 = 410;
							return true;
						}
					}
					else if (A_0 == "LargeLock")
					{
						A_1 = 412;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = A_0[0];
					if (c != 'B')
					{
						if (c == 'M')
						{
							if (A_0 == "MediumLock")
							{
								A_1 = 411;
								return true;
							}
						}
					}
					else if (A_0 == "BattleLock")
					{
						A_1 = 1132;
						return true;
					}
					break;
				}
				case 12:
					if (A_0 == "PlatinumLock")
					{
						A_1 = 796;
						return true;
					}
					break;
				case 15:
					if (A_0 == "BattleWorldLock")
					{
						A_1 = 1131;
						return true;
					}
					break;
				}
			}
			return Enum.TryParse<World.BlockType>(A_0, true, out A_1);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0007F1F0 File Offset: 0x0007D3F0
		public static Color 럯()
		{
			float num = Time.time * 럧.랫;
			return new Color(Mathf.Sin(num) * 0.5f + 0.5f, Mathf.Sin(num + 2f) * 0.5f + 0.5f, Mathf.Sin(num + 4f) * 0.5f + 0.5f);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0007F250 File Offset: 0x0007D450
		private static void 랾(BSONObject A_0, string A_1, string A_2 = "")
		{
			try
			{
				Directory.CreateDirectory(럽.랾);
				럽.람 람 = new 럽.람();
				람.랾 = new StreamWriter(A_1, true);
				try
				{
					럽.랾(A_0, A_2, new Action<string, string, BSONValue>(람.랾));
				}
				finally
				{
					if (람.랾 != null)
					{
						((IDisposable)람.랾).Dispose();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0003E5E1 File Offset: 0x0003C7E1
		public static void 랾(BSONObject A_0, string A_1 = "")
		{
			if (럧.럑)
			{
				럽.랾(A_0, 럽.럎, A_1);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0003E5F6 File Offset: 0x0003C7F6
		public static void 럎(BSONObject A_0, string A_1 = "")
		{
			if (럧.럑)
			{
				럽.랾(A_0, 럽.람, A_1);
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0007F2C8 File Offset: 0x0007D4C8
		public static void 람(BSONObject A_0, string A_1 = "")
		{
			if (!ConfigFile.bsonInGameLoggerToggle)
			{
				return;
			}
			string path = Path.Combine(럽.랾, "BSON Logger.txt");
			try
			{
				럽.럒 럒 = new 럽.럒();
				Directory.CreateDirectory(럽.랾);
				럒.랾 = new List<double>();
				럒.랾 = new StreamWriter(path, true);
				try
				{
					럽.랾(A_0, A_1, new Action<string, string, BSONValue>(럒.랾));
				}
				finally
				{
					if (럒.랾 != null)
					{
						((IDisposable)럒.랾).Dispose();
					}
				}
				if (럒.랾.Count > 0)
				{
					double num = 럒.랾.Average();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Mean value: ");
					defaultInterpolatedStringHandler.AppendFormatted<double>(num);
					Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
					using (StreamWriter streamWriter = new StreamWriter(path, true))
					{
						TextWriter textWriter = streamWriter;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("Mean Value: ");
						defaultInterpolatedStringHandler2.AppendFormatted<double>(Math.Round(num));
						textWriter.WriteLine(defaultInterpolatedStringHandler2.ToStringAndClear());
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0007F414 File Offset: 0x0007D614
		public static void 럎(string A_0)
		{
			if (!ConfigFile.packetConsole || string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			object obj = 럧.랾;
			lock (obj)
			{
				럧.럒.Add(A_0);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0007F468 File Offset: 0x0007D668
		public static void 람(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			object obj = 럧.럎;
			lock (obj)
			{
				럧.럼.Add(A_0);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0007F4B8 File Offset: 0x0007D6B8
		public static void 럒(BSONObject A_0, string A_1 = "")
		{
			럽.럼 럼 = new 럽.럼();
			if (A_0 == null)
			{
				return;
			}
			럼.랾 = DateTime.Now.ToString("HH:mm:ss.fff");
			럽.랾(A_0, A_1, new Action<string, string, BSONValue>(럼.랾));
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0003E60B File Offset: 0x0003C80B
		public static void 럼(BSONObject A_0, string A_1 = "")
		{
			럽.랾(A_0, A_1, new Action<string, string, BSONValue>(럽.럎.랾.랾));
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0007F500 File Offset: 0x0007D700
		public static string 랋(BSONObject A_0, string A_1 = "")
		{
			럽.랋 랋 = new 럽.랋();
			랋.랾 = new StringBuilder();
			럽.랾(A_0, A_1, new Action<string, string, BSONValue>(랋.랾));
			return 랋.랾.ToString();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0003E633 File Offset: 0x0003C833
		public static void 랉(BSONObject A_0, string A_1 = "")
		{
			럽.랾(A_0, A_1, new Action<string, string, BSONValue>(럽.럎.랾.럎));
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0007F53C File Offset: 0x0007D73C
		private static string 랾(string A_0, string A_1, BSONValue A_2)
		{
			string value = 럽.랾(A_0, A_1);
			string text = 럽.랾(A_2);
			if (text == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted<BSONValue.ValueType>(A_2.valueType);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(6, 3);
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			defaultInterpolatedStringHandler2.AppendLiteral(" | ");
			defaultInterpolatedStringHandler2.AppendFormatted<BSONValue.ValueType>(A_2.valueType);
			defaultInterpolatedStringHandler2.AppendLiteral(" = ");
			defaultInterpolatedStringHandler2.AppendFormatted(text);
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0007F5D4 File Offset: 0x0007D7D4
		private static string 랾(BSONValue A_0)
		{
			if (A_0 == null)
			{
				return "h";
			}
			switch (A_0.valueType)
			{
			case 0:
				return A_0.doubleValue.ToString();
			case 1:
				return A_0.stringValue;
			case 2:
				return "[array]";
			case 3:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				Il2CppStructArray<byte> binaryValue = A_0.binaryValue;
				defaultInterpolatedStringHandler.AppendFormatted<int>((binaryValue != null) ? binaryValue.Length : 0);
				defaultInterpolatedStringHandler.AppendLiteral(" bytes]");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			case 4:
				return A_0.boolValue.ToString();
			case 7:
				return A_0.int32Value.ToString();
			case 8:
				return A_0.int64Value.ToString();
			case 9:
				return "{object}";
			}
			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0007F6C0 File Offset: 0x0007D8C0
		private static void 랾(BSONObject A_0, string A_1, Action<string, string, BSONValue> A_2)
		{
			if (A_0 == null || A_0.mMap == null || A_2 == null)
			{
				return;
			}
			foreach (string text in A_0.mMap.Keys)
			{
				BSONValue bsonvalue;
				try
				{
					bsonvalue = A_0[text];
				}
				catch
				{
					continue;
				}
				if (!(bsonvalue == null))
				{
					A_2(A_1, text, bsonvalue);
					if (bsonvalue.valueType == 3 && bsonvalue.binaryValue != null && bsonvalue.binaryValue.Length != 0)
					{
						try
						{
							BSONObject bsonobject = SimpleBSON.Load(bsonvalue.binaryValue);
							if (bsonobject != null)
							{
								럽.랾(bsonobject, 럽.랾(A_1, text), A_2);
							}
						}
						catch
						{
						}
					}
				}
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0003E65B File Offset: 0x0003C85B
		private static string 랾(string A_0, string A_1)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return A_1 ?? string.Empty;
			}
			if (string.IsNullOrWhiteSpace(A_1))
			{
				return A_0;
			}
			return A_0 + "." + A_1;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0007F78C File Offset: 0x0007D98C
		public static void 랾(BSONObject A_0)
		{
			foreach (string text in A_0.mMap.Keys)
			{
				BSONValue bsonvalue = A_0[text];
				switch (bsonvalue.valueType)
				{
				case 0:
				{
					double doubleValue = bsonvalue.doubleValue;
					if (ImGui.InputDouble("##" + text, ref doubleValue))
					{
						A_0[text] = new BSONValue(doubleValue);
						continue;
					}
					continue;
				}
				case 1:
				{
					string stringValue = bsonvalue.stringValue;
					if (ImGui.InputText("##" + text, ref stringValue, 100U))
					{
						A_0[text] = new BSONValue(stringValue);
						continue;
					}
					continue;
				}
				case 2:
					ImGui.Text(text + ": Array data");
					continue;
				case 3:
					ImGui.Text(text + ": Binary data");
					continue;
				case 4:
				{
					bool boolValue = bsonvalue.boolValue;
					if (ImGui.Checkbox("##" + text, ref boolValue))
					{
						A_0[text] = new BSONValue(boolValue);
						continue;
					}
					continue;
				}
				case 7:
				{
					int int32Value = bsonvalue.int32Value;
					if (ImGui.InputInt("##" + text, ref int32Value))
					{
						A_0[text] = new BSONValue(int32Value);
						continue;
					}
					continue;
				}
				case 8:
				{
					string s = bsonvalue.int64Value.ToString();
					long num;
					if (ImGui.InputText("##" + text, ref s, 20U) && long.TryParse(s, out num))
					{
						A_0[text] = new BSONValue(num);
						continue;
					}
					continue;
				}
				case 9:
					ImGui.Text(text + ": Nested BSON Object");
					럽.랾(SimpleBSON.Load(bsonvalue.binaryValue));
					continue;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(": ");
				defaultInterpolatedStringHandler.AppendFormatted<BSONValue.ValueType>(bsonvalue.valueType);
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0007F994 File Offset: 0x0007DB94
		public static string 럒(string A_0)
		{
			string result2;
			using (HttpClient httpClient = new HttpClient())
			{
				HttpResponseMessage result = httpClient.GetAsync(A_0).GetAwaiter().GetResult();
				if (!result.IsSuccessStatusCode)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Failed to fetch data. Status code: ");
					defaultInterpolatedStringHandler.AppendFormatted<HttpStatusCode>(result.StatusCode);
					throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				result2 = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
			}
			return result2;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0007FA2C File Offset: 0x0007DC2C
		public static void 랾(string A_0, Dictionary<string, int> A_1)
		{
			if (A_1.ContainsKey(A_0))
			{
				int num = A_1[A_0];
				A_1[A_0] = num + 1;
				return;
			}
			A_1[A_0] = 1;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0007FA60 File Offset: 0x0007DC60
		public static void 랾(Dictionary<string, int> A_0, int A_1, string A_2)
		{
			foreach (KeyValuePair<string, int> keyValuePair in A_0)
			{
				if (keyValuePair.Value > A_1)
				{
					foreach (NetworkPlayer networkPlayer in 럽.럒())
					{
						Object @object;
						if (networkPlayer == null)
						{
							@object = null;
						}
						else
						{
							Player playerScript = networkPlayer.playerScript;
							@object = ((playerScript != null) ? playerScript.playerNameTextMeshPro : null);
						}
						if (!(@object == null) && !(networkPlayer.name != keyValuePair.Key))
						{
							string text = "<color=red>[" + A_2 + "]";
							if (!networkPlayer.playerScript.playerNameTextMeshPro.text.Contains(text))
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 2);
								defaultInterpolatedStringHandler.AppendLiteral("<color=red>Cheater Detected: <#00FF00>Player: ");
								defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Key);
								defaultInterpolatedStringHandler.AppendLiteral(" (");
								defaultInterpolatedStringHandler.AppendFormatted(A_2);
								defaultInterpolatedStringHandler.AppendLiteral(")");
								럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
								networkPlayer.playerScript.playerNameTextMeshPro.text = networkPlayer.playerScript.playerNameTextMeshPro.text + " " + text;
							}
						}
					}
				}
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0007FBD0 File Offset: 0x0007DDD0
		public static float 랾(Vector2i A_0, Vector2i A_1)
		{
			float num = (float)(A_0.x - A_1.x);
			float num2 = (float)(A_0.y - A_1.y);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0007FC08 File Offset: 0x0007DE08
		public static bool 럼(string A_0)
		{
			foreach (string b in 럧.랋)
			{
				if (A_0 == b)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0003E686 File Offset: 0x0003C886
		public static bool 럒(World.BlockType A_0)
		{
			return A_0 - 4012 <= 44;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0007FC3C File Offset: 0x0007DE3C
		// Note: this type is marked as 'beforefieldinit'.
		static 럽()
		{
			World.BlockType[] array = new World.BlockType[8];
			RuntimeHelpers.InitializeArray(array, fieldof(럖.람).FieldHandle);
			럽.랾 = array;
			럽.랾 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logger");
			럽.럎 = Path.Combine(럽.랾, "Server Logger.txt");
			럽.람 = Path.Combine(럽.랾, "Client Logger.txt");
		}

		// Token: 0x040002D1 RID: 721
		private static readonly World.BlockType[] 랾;

		// Token: 0x040002D2 RID: 722
		private static readonly string 랾;

		// Token: 0x040002D3 RID: 723
		private static readonly string 럎;

		// Token: 0x040002D4 RID: 724
		private static readonly string 람;

		// Token: 0x02000064 RID: 100
		private enum 랾
		{
			// Token: 0x040002D6 RID: 726
			랾,
			// Token: 0x040002D7 RID: 727
			럎,
			// Token: 0x040002D8 RID: 728
			람,
			// Token: 0x040002D9 RID: 729
			럒
		}

		// Token: 0x02000065 RID: 101
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x0003E6A2 File Offset: 0x0003C8A2
			internal void 랾(string A_1, string A_2, BSONValue A_3)
			{
				Console.WriteLine(럽.랾(A_1, A_2, A_3));
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0003E6B1 File Offset: 0x0003C8B1
			internal void 럎(string A_1, string A_2, BSONValue A_3)
			{
				럽.랾(럽.랾(A_1, A_2, A_3), false);
			}

			// Token: 0x040002DA RID: 730
			public static readonly 럽.럎 랾 = new 럽.럎();

			// Token: 0x040002DB RID: 731
			public static Action<string, string, BSONValue> 랾;

			// Token: 0x040002DC RID: 732
			public static Action<string, string, BSONValue> 럎;
		}

		// Token: 0x02000066 RID: 102
		[CompilerGenerated]
		private sealed class 람
		{
			// Token: 0x060003C7 RID: 967 RVA: 0x0007FC9C File Offset: 0x0007DE9C
			internal void 랾(string A_1, string A_2, BSONValue A_3)
			{
				TextWriter textWriter = this.랾;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Time: ");
				defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(럽.랾(A_1, A_2, A_3));
				textWriter.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
			}

			// Token: 0x040002DD RID: 733
			public StreamWriter 랾;
		}

		// Token: 0x02000067 RID: 103
		[CompilerGenerated]
		private sealed class 럒
		{
			// Token: 0x060003C9 RID: 969 RVA: 0x0007FCF8 File Offset: 0x0007DEF8
			internal void 랾(string A_1, string A_2, BSONValue A_3)
			{
				if (A_3.valueType == null)
				{
					this.랾.Add(A_3.doubleValue);
				}
				if (A_3.valueType == 6 && A_2.Contains("AHD"))
				{
					return;
				}
				this.랾.WriteLine(럽.랾(A_1, A_2, A_3));
			}

			// Token: 0x040002DE RID: 734
			public List<double> 랾;

			// Token: 0x040002DF RID: 735
			public StreamWriter 랾;
		}

		// Token: 0x02000068 RID: 104
		[CompilerGenerated]
		private sealed class 럼
		{
			// Token: 0x060003CB RID: 971 RVA: 0x0003E6C1 File Offset: 0x0003C8C1
			internal void 랾(string A_1, string A_2, BSONValue A_3)
			{
				럽.럎("[" + this.랾 + "] " + 럽.랾(A_1, A_2, A_3));
			}

			// Token: 0x040002E0 RID: 736
			public string 랾;
		}

		// Token: 0x02000069 RID: 105
		[CompilerGenerated]
		private sealed class 랋
		{
			// Token: 0x060003CD RID: 973 RVA: 0x0003E6E5 File Offset: 0x0003C8E5
			internal void 랾(string A_1, string A_2, BSONValue A_3)
			{
				this.랾.AppendLine(럽.랾(A_1, A_2, A_3));
			}

			// Token: 0x040002E1 RID: 737
			public StringBuilder 랾;
		}
	}
}
