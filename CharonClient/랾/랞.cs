using System;
using System.Runtime.CompilerServices;
using System.Text;
using CharonClient.Configuration;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Message;
using Il2CppSystem.Collections.Generic;
using UnityEngine.SceneManagement;

namespace 랾
{
	// Token: 0x02000053 RID: 83
	internal static class 랞
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0007D240 File Offset: 0x0007B440
		public static void 랾(string A_0)
		{
			if (랞.랾 != null && !랞.랾.IsDisposed)
			{
				return;
			}
			랞.랾 = new DiscordRpcClient(A_0);
			랞.랾.OnReady += 랞.랾.랾.랾;
			랞.랾.OnError += 랞.랾.랾.랾;
			랞.랾.Initialize();
			럴.AssertRuntimeKeyValid("Initialize");
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0003E219 File Offset: 0x0003C419
		public static void 랾()
		{
			랞.럒 = string.Empty;
			DiscordRpcClient discordRpcClient = 랞.랾;
			if (discordRpcClient != null)
			{
				discordRpcClient.Dispose();
			}
			랞.랾 = null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0007D2D4 File Offset: 0x0007B4D4
		public static void 럎()
		{
			if (랞.랾 == null || 랞.랾.IsDisposed)
			{
				return;
			}
			string text = "Playing as " + 랞.랉();
			string text2 = 랞.람();
			string text3 = 랞.랓();
			int num = 0;
			int num2 = 0;
			bool flag = 랞.랾(out num, out num2);
			string b = 랞.랾(text, text2, text3, num, num2, flag);
			if (string.Equals(랞.럒, b, StringComparison.Ordinal))
			{
				return;
			}
			RichPresence richPresence = new RichPresence
			{
				Details = text,
				State = text2,
				Assets = new Assets
				{
					LargeImageKey = text3
				},
				Buttons = new Button[]
				{
					new Button
					{
						Label = "Discord Server",
						Url = "https://discord.gg/QFYCkawHkE"
					}
				}
			};
			if (flag)
			{
				richPresence.Party = new Party
				{
					Size = num,
					Max = num2
				};
			}
			랞.랾.SetPresence(richPresence);
			랞.럒 = b;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0007D3CC File Offset: 0x0007B5CC
		private static string 람()
		{
			if (럧.럎)
			{
				return "In World: ?";
			}
			if (랞.럭())
			{
				return "In World: " + 랞.럐();
			}
			if (랞.랱())
			{
				return 랞.럒();
			}
			if (랞.럙())
			{
				return 랞.럼();
			}
			return 랞.랋();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0007D41C File Offset: 0x0007B61C
		private static string 럒()
		{
			string text = 랞.럐();
			if (!string.IsNullOrWhiteSpace(text))
			{
				return "Joining: " + text;
			}
			return "Joining World";
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0007D448 File Offset: 0x0007B648
		private static string 럼()
		{
			string text = 랞.랫();
			if (!string.IsNullOrWhiteSpace(text) && !string.Equals(text, "Unknown", StringComparison.OrdinalIgnoreCase))
			{
				return "Loading: " + 랞.람(text);
			}
			return "Loading...";
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0007D488 File Offset: 0x0007B688
		private static string 랋()
		{
			string text = 랞.랫();
			if (string.IsNullOrWhiteSpace(text) || string.Equals(text, "Unknown", StringComparison.OrdinalIgnoreCase))
			{
				return "In The Menus";
			}
			string text2 = 랞.럎(text);
			if (text2.Contains("welcome") || text2.Contains("title"))
			{
				return "At Title Screen";
			}
			if (text2.Contains("mainmenu") || text2.Contains("menu"))
			{
				return "In Main Menu";
			}
			return "In Scene: " + 랞.람(text);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0007D510 File Offset: 0x0007B710
		private static string 랉()
		{
			if (!ConfigFile.ShowRPCPlayerName)
			{
				return 랞.랾(new string[]
				{
					ConfigFile.rpcPlayerName,
					"White Dress"
				});
			}
			string result;
			try
			{
				result = 랞.랾(new string[]
				{
					StaticPlayer.playerName,
					ConfigFile.rpcPlayerName,
					"White Dress"
				});
			}
			catch
			{
				result = 랞.랾(new string[]
				{
					ConfigFile.rpcPlayerName,
					"White Dress"
				});
			}
			return result;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0007D598 File Offset: 0x0007B798
		private static string 럐()
		{
			if (!ConfigFile.ShowRPCPlayerWorld)
			{
				return 랞.랾(new string[]
				{
					ConfigFile.rpcWorldName,
					"Black Dress"
				});
			}
			string result;
			try
			{
				string[] array = new string[3];
				int num = 0;
				World world = 럓.랾;
				array[num] = ((world != null) ? world.worldName : null);
				array[1] = ConfigFile.rpcWorldName;
				array[2] = "Black Dress";
				result = 랞.랾(array);
			}
			catch
			{
				result = 랞.랾(new string[]
				{
					ConfigFile.rpcWorldName,
					"Black Dress"
				});
			}
			return result;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0003E23B File Offset: 0x0003C43B
		private static string 랓()
		{
			return 랞.랾(new string[]
			{
				ConfigFile.RPCImage,
				"white_dress"
			});
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0007D62C File Offset: 0x0007B82C
		private static bool 랾(out int A_0, out int A_1)
		{
			A_0 = 0;
			A_1 = 0;
			if (!랞.럭() && !랞.랱())
			{
				return false;
			}
			int val = ConfigFile.ShowRPCPlayerCount ? 랞.럯() : Math.Max(1, ConfigFile.RPCPlayerCount);
			A_0 = Math.Max(1, val);
			A_1 = Math.Max(50, A_0);
			return true;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0007D680 File Offset: 0x0007B880
		private static int 럯()
		{
			int result;
			try
			{
				List<NetworkPlayer> otherPlayers = NetworkPlayers.otherPlayers;
				int num = (otherPlayers != null) ? otherPlayers.Count : 0;
				result = Math.Max(1, num + 1);
			}
			catch
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0007D6C4 File Offset: 0x0007B8C4
		private static string 랾(string A_0, string A_1, string A_2, int A_3, int A_4, bool A_5)
		{
			return string.Join("|", new object[]
			{
				A_0,
				A_1,
				A_2,
				A_5 ? A_3 : 0,
				A_5 ? A_4 : 0,
				A_5
			});
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0007D718 File Offset: 0x0007B918
		private static bool 럭()
		{
			bool result;
			try
			{
				result = 럽.랾();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0007D744 File Offset: 0x0007B944
		private static bool 랱()
		{
			bool result;
			try
			{
				result = 럽.람();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0007D770 File Offset: 0x0007B970
		private static bool 럙()
		{
			bool result;
			try
			{
				if (LoadingScreenController.instance == null)
				{
					result = false;
				}
				else
				{
					result = (LoadingScreenController.instance.isActiveAndEnabled || LoadingScreenController.instance.IsLoading());
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0007D7C0 File Offset: 0x0007B9C0
		private static string 랫()
		{
			string result;
			try
			{
				Scene activeScene = SceneManager.GetActiveScene();
				if (!activeScene.IsValid())
				{
					result = "Unknown";
				}
				else
				{
					result = (string.IsNullOrWhiteSpace(activeScene.name) ? "Unknown" : activeScene.name);
				}
			}
			catch
			{
				result = "Unknown";
			}
			return result;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0003E258 File Offset: 0x0003C458
		private static string 럎(string A_0)
		{
			return (A_0 ?? string.Empty).Replace("_", string.Empty).ToLowerInvariant();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0007D820 File Offset: 0x0007BA20
		private static string 람(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return "Unknown";
			}
			string text = A_0.Replace("_", " ").Trim();
			if (text.Length == 0)
			{
				return "Unknown";
			}
			StringBuilder stringBuilder = new StringBuilder(text.Length + 8);
			char c = '\0';
			foreach (char c2 in text)
			{
				if (stringBuilder.Length > 0 && char.IsUpper(c2) && c != ' ' && !char.IsUpper(c))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(c2);
				c = c2;
			}
			return stringBuilder.ToString().Trim();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000792B0 File Offset: 0x000774B0
		private static string 랾(params string[] values)
		{
			foreach (string text in values)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
			}
			return string.Empty;
		}

		// Token: 0x040002A0 RID: 672
		private const string 랾 = "In The Menus";

		// Token: 0x040002A1 RID: 673
		private const string 럎 = "White Dress";

		// Token: 0x040002A2 RID: 674
		private const string 람 = "Black Dress";

		// Token: 0x040002A3 RID: 675
		private static DiscordRpcClient 랾;

		// Token: 0x040002A4 RID: 676
		private static string 럒 = string.Empty;

		// Token: 0x02000054 RID: 84
		[CompilerGenerated]
		[Serializable]
		private sealed class 랾
		{
			// Token: 0x0600033C RID: 828 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
			internal void 랾(object A_1, ReadyMessage A_2)
			{
				럧.럙 = A_2.User.Username;
				럧.랫 = A_2.User.ID.ToString();
				string text;
				if (!럧.럎)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
					defaultInterpolatedStringHandler.AppendLiteral("Discord: ");
					defaultInterpolatedStringHandler.AppendFormatted(럧.럙);
					defaultInterpolatedStringHandler.AppendLiteral(" ID: ");
					defaultInterpolatedStringHandler.AppendFormatted(럧.랫);
					defaultInterpolatedStringHandler.AppendLiteral(" | Machine: ");
					defaultInterpolatedStringHandler.AppendFormatted(global::랾.랱.랾());
					defaultInterpolatedStringHandler.AppendLiteral(" | Client: ");
					defaultInterpolatedStringHandler.AppendFormatted("2.0");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(52, 4);
					defaultInterpolatedStringHandler2.AppendLiteral("[UNAUTHORIZED] Discord: ");
					defaultInterpolatedStringHandler2.AppendFormatted(럧.럙);
					defaultInterpolatedStringHandler2.AppendLiteral(" ID: ");
					defaultInterpolatedStringHandler2.AppendFormatted(럧.랫);
					defaultInterpolatedStringHandler2.AppendLiteral(" | Machine: ");
					defaultInterpolatedStringHandler2.AppendFormatted(global::랾.랱.랾());
					defaultInterpolatedStringHandler2.AppendLiteral(" | Client: ");
					defaultInterpolatedStringHandler2.AppendFormatted("2.0");
					text = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				string text2 = text;
				럕.랾("discord", text2);
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0003E290 File Offset: 0x0003C490
			internal void 랾(object A_1, ErrorMessage A_2)
			{
				Console.WriteLine("[Discord RPC] Error");
			}

			// Token: 0x040002A5 RID: 677
			public static readonly 랞.랾 랾 = new 랞.랾();

			// Token: 0x040002A6 RID: 678
			public static OnReadyEvent 랾;

			// Token: 0x040002A7 RID: 679
			public static OnErrorEvent 랾;
		}
	}
}
