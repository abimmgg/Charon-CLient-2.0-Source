using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace 랾
{
	// Token: 0x02000107 RID: 263
	internal class 랆
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x000A0920 File Offset: 0x0009EB20
		private static PlayerData.InventoryKey[] 랾()
		{
			PlayerData.InventoryKey[] result;
			try
			{
				if (global::랾.럓.랾 == null)
				{
					result = Array.Empty<PlayerData.InventoryKey>();
				}
				else
				{
					result = (global::랾.럓.랾.GetInventoryAsOrderedByInventoryItemType() ?? Array.Empty<PlayerData.InventoryKey>());
				}
			}
			catch
			{
				result = Array.Empty<PlayerData.InventoryKey>();
			}
			return result;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0003FD3D File Offset: 0x0003DF3D
		private static void 랾(Vector2i A_0, Vector2i A_1, string A_2 = null)
		{
			if (A_0 == A_1)
			{
				return;
			}
			global::랾.랆.랾(global::랾.랛.랾(A_0, A_1, global::랾.랛.럎()), A_2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		private static void 럎(Vector2i A_0, Vector2i A_1, string A_2 = null)
		{
			if (A_0 == A_1)
			{
				return;
			}
			global::랾.랆.랾(global::랾.랛.럎(A_0, A_1, global::랾.랛.럎()), A_2);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0003FD7B File Offset: 0x0003DF7B
		private static bool 랾(List<랛.랾> A_0, string A_1 = null)
		{
			return global::랾.럺.랾(A_0, false);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0003FD89 File Offset: 0x0003DF89
		public static double 랾(Vector2i A_0, Vector2i A_1)
		{
			return Math.Sqrt(Math.Pow((double)(A_0.x - A_1.x), 2.0) + Math.Pow((double)(A_0.y - A_1.y), 2.0));
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000A0978 File Offset: 0x0009EB78
		private static void 랾(string A_0, string A_1)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(A_0, true))
				{
					TextWriter textWriter = streamWriter;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now);
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted(A_1);
					textWriter.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failed to write to log file: " + ex.Message);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000A0A04 File Offset: 0x0009EC04
		public static void 럎()
		{
			bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.isActiveAndEnabled;
			if (!global::랾.럽.랾())
			{
				global::랾.랆.람(flag);
				return;
			}
			global::랾.랆.럭 = 0f;
			if (global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾.isPortalAnimationActive)
			{
				return;
			}
			if (global::랾.랆.랱())
			{
				return;
			}
			FishingGaugeMinigameUI fishingGaugeMinigameUI = global::랾.럓.랾;
			FishingResultsPopupUI fishingResultsPopupUI = global::랾.럓.랾;
			PlayerData.InventoryKey[] array = global::랾.랆.랾();
			bool flag2 = global::랾.랆.랉(array);
			bool flag3 = global::랾.럓.랾.fishingState > 0;
			ConfigData.playerChangeToSleepSeconds = int.MaxValue;
			global::랾.럧.랆 += Time.deltaTime;
			global::랾.랆.럜();
			global::랾.랆.럼(flag2);
			if (fishingResultsPopupUI != null)
			{
				fishingResultsPopupUI.ClosePopup();
			}
			if (flag3 && !global::랾.랆.럒)
			{
				global::랾.랆.럒 = true;
				global::랾.랆.럼 = false;
				global::랾.랆.랋 = false;
				global::랾.랆.랉 = false;
				global::랾.랆.럙 = -1f;
			}
			if (!flag3 && global::랾.랆.럒)
			{
				global::랾.랆.랾(array);
			}
			bool flag4 = global::랾.랆.럝();
			if (flag4 && flag3)
			{
				global::랾.랆.랉 = true;
			}
			global::랾.랆.랾(fishingGaugeMinigameUI, flag4);
			global::랾.랆.럼();
			double totalSeconds = (DateTime.UtcNow - global::랾.럧.랾).TotalSeconds;
			if (global::랾.럓.랾.fishingState == null)
			{
				if (totalSeconds >= 8.0 && totalSeconds < 8.3)
				{
					global::랾.럓.랾.jumpButtonDown = true;
				}
				else
				{
					global::랾.럓.랾.jumpButtonDown = false;
				}
				if (totalSeconds >= 10.0)
				{
					global::랾.럓.랾.leftButton = false;
					global::랾.랆.럐();
					if (global::랾.랆.랋())
					{
						global::랾.랆.럎(array);
					}
					return;
				}
			}
			global::랾.랆.랾(flag4);
			if (global::랾.럧.럑)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 4);
				defaultInterpolatedStringHandler.AppendLiteral("Fish State: ");
				defaultInterpolatedStringHandler.AppendFormatted<FishingState>(global::랾.럓.랾.fishingState);
				defaultInterpolatedStringHandler.AppendLiteral(", Strike Active: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(global::랾.럓.랾.IsFishStrikeActive());
				defaultInterpolatedStringHandler.AppendLiteral(", Ready to Land: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool?>((fishingGaugeMinigameUI != null) ? new bool?(fishingGaugeMinigameUI.isReadyToLand) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", Should Avoid: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(flag4);
				global::랾.럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
			}
			if (!(fishingGaugeMinigameUI != null))
			{
				if (global::랾.럓.랾 != null)
				{
					global::랾.럓.랾.fishingLeftButton = false;
					global::랾.럓.랾.fishingRightButton = false;
				}
				return;
			}
			global::랾.럓.랾.fishingLeftButton = false;
			global::랾.럓.랾.fishingRightButton = false;
			if (flag4)
			{
				return;
			}
			if (ConfigFile.LegitimateAutoFish)
			{
				if (!global::랾.랆.럎)
				{
					global::랾.랆.럦();
				}
				global::랾.랆.랉 += Time.deltaTime;
				if (!global::랾.랆.랾)
				{
					if (global::랾.랆.랉 >= global::랾.랆.랓)
					{
						global::랾.랆.랾 = true;
						global::랾.랆.랉 = 0f;
						global::랾.랆.럐 = global::랾.랆.랊();
					}
				}
				else
				{
					if (global::랾.랆.랉 < global::랾.랆.럐)
					{
						return;
					}
					global::랾.랆.랾 = false;
					global::랾.랆.랉 = 0f;
					global::랾.랆.랓 = global::랾.랆.럟();
				}
			}
			fishingGaugeMinigameUI.targetAreaPosition = fishingGaugeMinigameUI.fishPosition + fishingGaugeMinigameUI.fishVelocity * Time.deltaTime;
			if (fishingGaugeMinigameUI.targetAreaPosition > fishingGaugeMinigameUI.fishTargetPoint)
			{
				global::랾.럓.랾.fishingLeftButton = true;
				return;
			}
			global::랾.럓.랾.fishingRightButton = true;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0003FDC9 File Offset: 0x0003DFC9
		private static void 람()
		{
			global::랾.랆.럒 = false;
			global::랾.랆.럼 = false;
			global::랾.랆.랋 = false;
			global::랾.랆.랉 = false;
			global::랾.랆.럐();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000A0D54 File Offset: 0x0009EF54
		private static void 랾(PlayerData.InventoryKey[] A_0)
		{
			if (global::랾.랆.랉)
			{
				global::랾.럧.럲++;
			}
			else if (global::랾.랆.랋)
			{
				global::랾.럧.럫++;
				global::랾.랆.럒();
				if (global::랾.럧.럶 && ConfigFile.autoFishWebhookFishCount > 0 && global::랾.럧.럫 % ConfigFile.autoFishWebhookFishCount == 0)
				{
					string autoFishWebhookLink = ConfigFile.autoFishWebhookLink;
					string text = ((autoFishWebhookLink != null) ? autoFishWebhookLink.Trim() : null) ?? string.Empty;
					string text2 = global::랾.랆.람(A_0);
					if (!((text.StartsWith("https://discord.com/api/webhooks/", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://discordapp.com/api/webhooks/", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://ptb.discord.com/api/webhooks/", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://canary.discord.com/api/webhooks/", StringComparison.OrdinalIgnoreCase)) ? global::랾.럕.랾(text, text2, false) : global::랾.랫.랾(text, "Fish Caught", text2)))
					{
						global::랾.럽.람("AutoFish webhook failed to send.", false);
					}
				}
			}
			else if (ConfigFile.LegitimateAutoFish && global::랾.랆.럼)
			{
				global::랾.럧.럴++;
			}
			global::랾.랆.랉();
			global::랾.랆.람();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		private static void 럒()
		{
			global::랾.랆.랋 = global::랾.랆.랞();
			global::랾.랆.랉 = global::랾.랆.럒;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0003FDFE File Offset: 0x0003DFFE
		private static void 럼()
		{
			if (ConfigFile.LegitimateAutoFish == global::랾.랆.람)
			{
				return;
			}
			global::랾.랆.람 = ConfigFile.LegitimateAutoFish;
			if (ConfigFile.LegitimateAutoFish)
			{
				if (!global::랾.랆.럎)
				{
					global::랾.랆.럦();
					return;
				}
			}
			else
			{
				global::랾.랆.럦();
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000A0E60 File Offset: 0x0009F060
		private static void 랾(bool A_0)
		{
			if (global::랾.럓.랾 == null || A_0 || global::랾.랆.럼 || !global::랾.럓.랾.IsFishStrikeActive())
			{
				global::랾.랆.랫 = -1f;
				return;
			}
			if (global::랾.랆.랫 < 0f)
			{
				global::랾.랆.랫 = Time.realtimeSinceStartup + global::랾.랆.랾(ConfigFile.autoFishHookDelayEnabled, ConfigFile.autoFishHookDelayMinSeconds, ConfigFile.autoFishHookDelayMaxSeconds);
			}
			if (Time.realtimeSinceStartup < global::랾.랆.랫)
			{
				return;
			}
			global::랾.랆.럼 = true;
			global::랾.랆.랫 = -1f;
			ControllerHelper.gameplayUI.OnButtonDownNew(4);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000A0EF0 File Offset: 0x0009F0F0
		private static void 랾(FishingGaugeMinigameUI A_0, bool A_1)
		{
			if (A_0 == null || A_1 || global::랾.랆.랋 || !A_0.isReadyToLand)
			{
				global::랾.랆.럍 = -1f;
				return;
			}
			if (global::랾.랆.럍 < 0f)
			{
				global::랾.랆.럍 = Time.realtimeSinceStartup + global::랾.랆.랾(ConfigFile.autoFishLandDelayEnabled, ConfigFile.autoFishLandDelayMinSeconds, ConfigFile.autoFishLandDelayMaxSeconds);
			}
			if (Time.realtimeSinceStartup < global::랾.랆.럍)
			{
				return;
			}
			global::랾.랆.랋 = true;
			global::랾.랆.럍 = -1f;
			A_0.LandButtonPressed();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0003FE30 File Offset: 0x0003E030
		private static bool 랋()
		{
			return global::랾.랆.럙 < 0f || Time.realtimeSinceStartup >= global::랾.랆.럙;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000A0F70 File Offset: 0x0009F170
		private static void 랉()
		{
			float num = global::랾.랆.랾(ConfigFile.autoFishRecastDelayEnabled, ConfigFile.autoFishRecastDelayMinSeconds, ConfigFile.autoFishRecastDelayMaxSeconds);
			global::랾.랆.럙 = ((num > 0f) ? (Time.realtimeSinceStartup + num) : -1f);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0003FE4F File Offset: 0x0003E04F
		private static void 럐()
		{
			global::랾.랆.랫 = -1f;
			global::랾.랆.럍 = -1f;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0003FE65 File Offset: 0x0003E065
		private static float 랾(bool A_0, float A_1, float A_2)
		{
			if (!A_0)
			{
				return 0f;
			}
			return global::랾.랆.랾(A_1, A_2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000A0FB0 File Offset: 0x0009F1B0
		private static float 랾(float A_0, float A_1)
		{
			float num = Mathf.Max(0f, A_0);
			float num2 = Mathf.Max(num, A_1);
			if (!Mathf.Approximately(num, num2))
			{
				return Random.Range(num, num2);
			}
			return num;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000A0FE4 File Offset: 0x0009F1E4
		private static bool 럎(PlayerData.InventoryKey[] A_0)
		{
			if (A_0 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			foreach (Vector2i vector2i in new Vector2i[]
			{
				new Vector2i(currentPlayerMapPoint.x - 1, currentPlayerMapPoint.y - 1),
				new Vector2i(currentPlayerMapPoint.x + 1, currentPlayerMapPoint.y - 1)
			})
			{
				if (global::랾.럓.랾.AreMapPointsValidForFishing(currentPlayerMapPoint, vector2i.x, vector2i.y))
				{
					foreach (PlayerData.InventoryKey inventoryKey in A_0)
					{
						if (ConfigData.IsFishingLure(inventoryKey.blockType) && global::랾.럓.랾.GetCount(inventoryKey) > 0)
						{
							global::랾.랆.럓();
							global::랾.랆.럕();
							global::랾.랆.럒 = inventoryKey.blockType;
							ControllerHelper.worldController.SetBaitWithTool(inventoryKey.blockType, vector2i, 0f);
							global::랾.랆.럙 = -1f;
							return true;
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000A1110 File Offset: 0x0009F310
		public static void 럎(bool A_0 = false)
		{
			global::랾.랆.럭();
			global::랾.랆.럭 = 0f;
			global::랾.랆.랾 = false;
			global::랾.랆.랉 = 0f;
			global::랾.랆.럐 = 0f;
			global::랾.랆.랓 = 0f;
			global::랾.랆.럎 = false;
			global::랾.랆.람 = ConfigFile.LegitimateAutoFish;
			if (!A_0)
			{
				return;
			}
			global::랾.럧.랆 = 0f;
			global::랾.럧.럫 = 0;
			global::랾.럧.럴 = 0;
			global::랾.럧.럲 = 0;
			global::랾.랆.랋 = 0;
			global::랾.랆.랉 = 0;
			global::랾.랆.럐 = false;
			global::랾.랆.랱 = -1f;
			global::랾.랆.람 = 0;
			global::랾.랆.랓 = false;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000A11A8 File Offset: 0x0009F3A8
		private static void 람(bool A_0)
		{
			global::랾.랆.럭();
			string text = global::랾.랆.랓();
			if (string.IsNullOrWhiteSpace(text))
			{
				global::랾.랆.럐 = false;
				global::랾.랆.랱 = -1f;
				global::랾.랆.람 = 0;
				global::랾.랆.럭 = 0f;
				return;
			}
			global::랾.랆.랾(text);
			if (A_0 || global::랾.럽.람())
			{
				global::랾.랆.럭 = 0f;
				return;
			}
			global::랾.랆.럭 += Time.deltaTime;
			if (global::랾.랆.럭 < 2.5f)
			{
				return;
			}
			SceneLoader.GoFromMainMenuToWorld(text, global::랾.랆.럯());
			global::랾.럧.량 = 0f;
			global::랾.랆.럭 = 0f;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000A1240 File Offset: 0x0009F440
		private static string 랓()
		{
			string text = (ConfigFile.autoFishRejoinWorldName ?? string.Empty).Trim();
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			return (ConfigFile.rejoinWorldName ?? string.Empty).Trim();
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0003FE77 File Offset: 0x0003E077
		private static string 럯()
		{
			return (ConfigFile.autoFishRejoinEntryPointId ?? string.Empty).Trim();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000A1280 File Offset: 0x0009F480
		private static void 럭()
		{
			global::랾.랆.람();
			global::랾.랆.럓();
			global::랾.랆.럕();
			global::랾.랆.럯 = 0f;
			global::랾.랆.럒 = 0;
			global::랾.랆.럙 = -1f;
			global::랾.랆.럐();
			if (global::랾.럓.랾 != null)
			{
				global::랾.럓.랾.fishingLeftButton = false;
				global::랾.럓.랾.fishingRightButton = false;
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000A12E0 File Offset: 0x0009F4E0
		private static void 랾(string A_0)
		{
			if (!ConfigFile.autoFishReturnToSpotAfterRejoin || !global::랾.랆.럚())
			{
				global::랾.랆.럐 = false;
				global::랾.랆.랱 = -1f;
				global::랾.랆.람 = 0;
				return;
			}
			string text = (ConfigFile.autoFishReturnSpotWorldName ?? string.Empty).Trim();
			if (!string.IsNullOrWhiteSpace(text) && !string.Equals(text, A_0, StringComparison.OrdinalIgnoreCase))
			{
				global::랾.랆.럐 = false;
				global::랾.랆.랱 = -1f;
				global::랾.랆.람 = 0;
				return;
			}
			global::랾.랆.럐 = true;
			global::랾.랆.랱 = -1f;
			global::랾.랆.람 = 0;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000A1368 File Offset: 0x0009F568
		private static bool 랱()
		{
			if (!global::랾.랆.럐 || !ConfigFile.autoFishReturnToSpotAfterRejoin)
			{
				return false;
			}
			if (global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return true;
			}
			if (!global::랾.랆.럚())
			{
				global::랾.랆.럐 = false;
				return false;
			}
			if (!global::랾.랆.랢())
			{
				global::랾.랆.럐 = false;
				return false;
			}
			Vector2i vector2i = global::랾.랆.럳();
			if (!global::랾.럓.랾.IsMapPointInWorld(vector2i))
			{
				global::랾.럽.럎("Auto Fish return tile is outside the world.", false);
				global::랾.랆.럐 = false;
				global::랾.랆.랱 = -1f;
				global::랾.랆.람 = 0;
				return false;
			}
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			if (currentPlayerMapPoint == vector2i)
			{
				global::랾.랆.럐 = false;
				global::랾.랆.랱 = -1f;
				global::랾.랆.람 = 0;
				return false;
			}
			if (global::랾.럧.럯)
			{
				return true;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (global::랾.랆.랱 >= 0f && realtimeSinceStartup < global::랾.랆.랱)
			{
				return true;
			}
			if (!global::랾.랛.랾(vector2i.x, vector2i.y, currentPlayerMapPoint, false, false))
			{
				return global::랾.랆.럎("Auto Fish return tile is not walkable.");
			}
			if (!global::랾.랆.랾(global::랾.랛.랾(currentPlayerMapPoint, vector2i, global::랾.랛.럎()), "Returning to saved fishing tile"))
			{
				return global::랾.랆.럎("Auto Fish could not find a path back to the saved tile.");
			}
			global::랾.랆.럐 = false;
			global::랾.랆.랱 = -1f;
			global::랾.랆.람 = 0;
			return true;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000A149C File Offset: 0x0009F69C
		private static bool 럎(string A_0)
		{
			global::랾.랆.람++;
			global::랾.랆.랱 = Time.realtimeSinceStartup + 0.75f;
			if (global::랾.랆.람 < 8)
			{
				return true;
			}
			global::랾.랆.럐 = false;
			global::랾.랆.랱 = -1f;
			global::랾.랆.람 = 0;
			global::랾.럽.럎(A_0, false);
			return false;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000A14F0 File Offset: 0x0009F6F0
		private static string 람(PlayerData.InventoryKey[] A_0)
		{
			StringBuilder stringBuilder2;
			StringBuilder stringBuilder = stringBuilder2 = new StringBuilder();
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("You've caught: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럫);
			appendInterpolatedStringHandler.AppendLiteral(" fish");
			stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Session Time: ");
			appendInterpolatedStringHandler.AppendFormatted(global::랾.랆.럔());
			stringBuilder4.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Catch Rate: ");
			appendInterpolatedStringHandler.AppendFormatted<float>(global::랾.랆.럩(), "F1");
			appendInterpolatedStringHandler.AppendLiteral("/hr");
			stringBuilder5.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder6 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Success Rate: ");
			appendInterpolatedStringHandler.AppendFormatted<float>(global::랾.랆.랦(), "F1");
			appendInterpolatedStringHandler.AppendLiteral("%");
			stringBuilder6.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Missed: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럴);
			stringBuilder7.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder8 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Skipped On Purpose: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럲);
			stringBuilder8.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder9 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Last Catch: ");
			appendInterpolatedStringHandler.AppendFormatted(global::랾.랆.럍());
			stringBuilder9.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder10 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Last Catch Size: ");
			appendInterpolatedStringHandler.AppendFormatted(global::랾.랆.랬());
			stringBuilder10.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder11 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Current Lure: ");
			appendInterpolatedStringHandler.AppendFormatted(global::랾.랆.란());
			stringBuilder11.AppendLine(ref appendInterpolatedStringHandler);
			int num = global::랾.랆.럒(A_0);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder12 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Lure Left: ");
			appendInterpolatedStringHandler.AppendFormatted((num >= 0) ? num.ToString() : "Unknown");
			stringBuilder12.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder13 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Total Lures Left: ");
			appendInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.럼(A_0));
			stringBuilder13.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder14 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Inventory Full: ");
			appendInterpolatedStringHandler.AppendFormatted(global::랾.랆.랋(A_0) ? "Yes" : "No");
			stringBuilder14.AppendLine(ref appendInterpolatedStringHandler);
			return stringBuilder.ToString().TrimEnd();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000A1788 File Offset: 0x0009F988
		public static string 럙()
		{
			int num = global::랾.랆.럽() ? global::랾.럧.럩 : global::랾.랆.럼;
			if (num <= 0)
			{
				return "Waiting...";
			}
			return global::랾.랆.랾(num);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000A17BC File Offset: 0x0009F9BC
		public static string 랫()
		{
			int num = global::랾.랆.럽() ? global::랾.럧.럩 : global::랾.랆.럼;
			if (num <= 0)
			{
				return "Waiting...";
			}
			return global::랾.랆.럎(num);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000A17F0 File Offset: 0x0009F9F0
		public static string 럍()
		{
			int num = (global::랾.랆.랋 > 0) ? global::랾.랆.랋 : global::랾.랆.랞();
			if (num <= 0)
			{
				return "Unknown";
			}
			return global::랾.랆.랾(num);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000A1824 File Offset: 0x0009FA24
		public static string 랬()
		{
			int num = (global::랾.랆.랋 > 0) ? global::랾.랆.랋 : global::랾.랆.랞();
			if (num <= 0)
			{
				return "Unknown";
			}
			return global::랾.랆.럎(num);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000A1858 File Offset: 0x0009FA58
		public static string 란()
		{
			int num = (global::랾.랆.럒 > 0) ? global::랾.랆.럒 : global::랾.랆.랉;
			if (num <= 0)
			{
				return "Unknown";
			}
			return global::랾.랆.랾(num, false);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0003FE8C File Offset: 0x0003E08C
		public static int 럇()
		{
			return global::랾.랆.럒(global::랾.랆.랾());
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0003FE98 File Offset: 0x0003E098
		public static int 랯()
		{
			return global::랾.랆.럼(global::랾.랆.랾());
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0003FEA4 File Offset: 0x0003E0A4
		public static bool 러()
		{
			return global::랾.랆.랋(global::랾.랆.랾());
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000A188C File Offset: 0x0009FA8C
		public static string 량()
		{
			if (!global::랾.럽.랾())
			{
				string text = global::랾.랆.랓();
				if (!string.IsNullOrWhiteSpace(text))
				{
					return "Rejoining " + text;
				}
				return "Waiting outside a world";
			}
			else
			{
				if (global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
				{
					return "Waiting for player state";
				}
				if (global::랾.랆.랓)
				{
					return "Pick a tile for the saved fishing spot";
				}
				if (global::랾.랆.럐)
				{
					if (!global::랾.럧.럯)
					{
						return "Returning to the saved fishing tile";
					}
					return "Moving back to the saved fishing tile";
				}
				else
				{
					if (!global::랾.랆.랉(global::랾.랆.랾()))
					{
						return "No fishing lure available";
					}
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					if (global::랾.랆.럙 >= 0f && realtimeSinceStartup < global::랾.랆.럙 && global::랾.럓.랾.fishingState == null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Waiting ");
						defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.랆.럙 - realtimeSinceStartup, "F1");
						defaultInterpolatedStringHandler.AppendLiteral("s to recast");
						return defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (global::랾.랆.럝() && global::랾.럓.랾.fishingState != null)
					{
						return "Avoiding huge fish";
					}
					if (global::랾.랆.럍 >= 0f && realtimeSinceStartup < global::랾.랆.럍)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(17, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("Waiting ");
						defaultInterpolatedStringHandler2.AppendFormatted<float>(global::랾.랆.럍 - realtimeSinceStartup, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("s to land");
						return defaultInterpolatedStringHandler2.ToStringAndClear();
					}
					if (global::랾.랆.랫 >= 0f && realtimeSinceStartup < global::랾.랆.랫 && global::랾.럓.랾.IsFishStrikeActive())
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(17, 1);
						defaultInterpolatedStringHandler3.AppendLiteral("Waiting ");
						defaultInterpolatedStringHandler3.AppendFormatted<float>(global::랾.랆.랫 - realtimeSinceStartup, "F2");
						defaultInterpolatedStringHandler3.AppendLiteral("s to hook");
						return defaultInterpolatedStringHandler3.ToStringAndClear();
					}
					if (ConfigFile.LegitimateAutoFish && global::랾.랆.랾)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(13, 1);
						defaultInterpolatedStringHandler4.AppendLiteral("Legit pause ");
						defaultInterpolatedStringHandler4.AppendFormatted<float>(Mathf.Max(0f, global::랾.랆.럐 - global::랾.랆.랉), "F1");
						defaultInterpolatedStringHandler4.AppendLiteral("s");
						return defaultInterpolatedStringHandler4.ToStringAndClear();
					}
					if (global::랾.럓.랾.fishingState != null)
					{
						return "Reeling";
					}
					return "Ready to cast";
				}
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0003FEB0 File Offset: 0x0003E0B0
		public static string 럑()
		{
			return global::랾.랆.람(global::랾.랆.랾());
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0003FEBC File Offset: 0x0003E0BC
		public static bool 럊()
		{
			return global::랾.랆.랓;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0003FEC3 File Offset: 0x0003E0C3
		public static void 럒(bool A_0)
		{
			global::랾.랆.랓 = A_0;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000A1AB4 File Offset: 0x0009FCB4
		public static string 랠()
		{
			if (!global::랾.랆.럚())
			{
				return "No tile saved";
			}
			string value = string.IsNullOrWhiteSpace(ConfigFile.autoFishReturnSpotWorldName) ? "Unknown World" : ConfigFile.autoFishReturnSpotWorldName.Trim();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(ConfigFile.autoFishReturnSpotX);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(ConfigFile.autoFishReturnSpotY);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0003FECB File Offset: 0x0003E0CB
		public static bool 럏()
		{
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			global::랾.랆.랾(global::랾.럓.랾.currentPlayerMapPoint);
			return true;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0003FEFA File Offset: 0x0003E0FA
		public static void 럫()
		{
			ConfigFile.autoFishReturnSpotWorldName = string.Empty;
			ConfigFile.autoFishReturnSpotX = -1;
			ConfigFile.autoFishReturnSpotY = -1;
			global::랾.랆.럐 = false;
			global::랾.랆.랱 = -1f;
			global::랾.랆.람 = 0;
			global::랾.랆.랓 = false;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000A1B40 File Offset: 0x0009FD40
		public static bool 럴()
		{
			if (!global::랾.랆.랓)
			{
				return false;
			}
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || Camera.main == null)
			{
				return false;
			}
			if (global::랾.랆.랖())
			{
				return false;
			}
			if (global::랾.랅.럎(1))
			{
				global::랾.랆.랓 = false;
				global::랾.럽.럒("Auto Fish tile picking cancelled.", true);
				return true;
			}
			if (!global::랾.랅.럎(0))
			{
				return false;
			}
			Vector2i vector2i;
			if (!global::랾.랆.랾(out vector2i))
			{
				return false;
			}
			global::랾.랆.랾(vector2i);
			global::랾.랆.랓 = false;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Auto Fish return tile set to (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.y);
			defaultInterpolatedStringHandler.AppendLiteral(") in ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.럓.랾.worldName);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			global::랾.럽.럒(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			return true;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000A1C2C File Offset: 0x0009FE2C
		public static void 럲()
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
			if (global::랾.랆.럻())
			{
				Color color = global::랾.랆.럐 ? new Color(0.46f, 0.24f, 0.05f, 0.28f) : new Color(0.08f, 0.36f, 0.22f, 0.18f);
				Color color2 = global::랾.랆.럐 ? new Color(1f, 0.8f, 0.2f, 1f) : new Color(0.42f, 1f, 0.72f, 0.95f);
				string text = global::랾.랆.럐 ? "RETURNING HERE" : "FISH TILE";
				global::랾.랆.랾(main, global::랾.랆.럳(), text, color, color2);
			}
			Vector2i vector2i;
			if (!global::랾.랆.랓 || !global::랾.랆.랾(out vector2i))
			{
				return;
			}
			global::랾.랆.랾(main, vector2i, "CLICK TO SAVE", new Color(0.08f, 0.23f, 0.42f, 0.2f), new Color(0.38f, 0.78f, 1f, 0.95f));
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003FF2E File Offset: 0x0003E12E
		public static float 럩()
		{
			if (global::랾.럧.랆 > 0f)
			{
				return (float)global::랾.럧.럫 / (global::랾.럧.랆 / 3600f);
			}
			return 0f;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000A1D48 File Offset: 0x0009FF48
		public static float 랦()
		{
			int num = global::랾.럧.럫 + global::랾.럧.럴 + global::랾.럧.럲;
			if (num > 0)
			{
				return (float)global::랾.럧.럫 / (float)num * 100f;
			}
			return 0f;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000A1D80 File Offset: 0x0009FF80
		public static string 럔()
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)Math.Max(0f, global::랾.럧.랆));
			int value = (int)timeSpan.TotalHours;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value, "D2");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Minutes, "D2");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds, "D2");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0003FF54 File Offset: 0x0003E154
		private static int 랞()
		{
			if (global::랾.럧.럩 > 0)
			{
				return global::랾.럧.럩;
			}
			return global::랾.랆.럼;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000A1E08 File Offset: 0x000A0008
		private static int 럒(PlayerData.InventoryKey[] A_0)
		{
			if (A_0 == null || global::랾.럓.랾 == null || global::랾.랆.럒 <= 0)
			{
				return -1;
			}
			int num = 0;
			foreach (PlayerData.InventoryKey inventoryKey in A_0)
			{
				if (inventoryKey.blockType == global::랾.랆.럒)
				{
					num += (int)global::랾.럓.랾.GetCount(inventoryKey);
				}
			}
			return num;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000A1E60 File Offset: 0x000A0060
		private static int 럼(PlayerData.InventoryKey[] A_0)
		{
			if (A_0 == null || global::랾.럓.랾 == null)
			{
				return 0;
			}
			int num = 0;
			foreach (PlayerData.InventoryKey inventoryKey in A_0)
			{
				if (ConfigData.IsFishingLure(inventoryKey.blockType))
				{
					num += (int)global::랾.럓.랾.GetCount(inventoryKey);
				}
			}
			return num;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0003FF69 File Offset: 0x0003E169
		private static bool 랋(PlayerData.InventoryKey[] A_0)
		{
			return A_0 != null && A_0.Length >= 200;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		private static string 랾(World.BlockType A_0, bool A_1 = false)
		{
			try
			{
				string text = TextManager.GetBlockTypeName(A_0);
				if (!string.IsNullOrWhiteSpace(text))
				{
					text = text.Trim();
					if (A_1)
					{
						text = global::랾.랆.람(text);
					}
					if (!string.IsNullOrWhiteSpace(text))
					{
						return text;
					}
				}
			}
			catch
			{
			}
			string text2 = A_0.ToString();
			if (string.IsNullOrWhiteSpace(text2))
			{
				return "Unknown";
			}
			if (A_1)
			{
				text2 = global::랾.랆.람(text2);
			}
			return global::랾.랆.럼(text2);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000A1F2C File Offset: 0x000A012C
		private static string 랾(World.BlockType A_0)
		{
			string text = global::랾.랆.람(A_0);
			if (!string.IsNullOrWhiteSpace(text))
			{
				string text2 = global::랾.랆.람(text.Trim());
				text2 = global::랾.랆.럒(text2).Trim();
				if (!string.IsNullOrWhiteSpace(text2))
				{
					return text2;
				}
			}
			string text3 = A_0.ToString();
			if (text3.StartsWith("Fish", StringComparison.Ordinal))
			{
				text3 = text3.Substring(4);
			}
			text3 = global::랾.랆.럒(text3);
			return global::랾.랆.럼(text3);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000A1F9C File Offset: 0x000A019C
		private static string 럎(World.BlockType A_0)
		{
			string text = A_0.ToString();
			if (text.EndsWith("Huge", StringComparison.OrdinalIgnoreCase))
			{
				return "Huge";
			}
			if (text.EndsWith("Large", StringComparison.OrdinalIgnoreCase))
			{
				return "Large";
			}
			if (text.EndsWith("Medium", StringComparison.OrdinalIgnoreCase))
			{
				return "Medium";
			}
			if (text.EndsWith("Small", StringComparison.OrdinalIgnoreCase))
			{
				return "Small";
			}
			return "Normal";
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000A200C File Offset: 0x000A020C
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

		// Token: 0x0600072D RID: 1837 RVA: 0x0003FF7D File Offset: 0x0003E17D
		private static bool 럚()
		{
			return ConfigFile.autoFishReturnSpotX >= 0 && ConfigFile.autoFishReturnSpotY >= 0 && !string.IsNullOrWhiteSpace(ConfigFile.autoFishReturnSpotWorldName);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003FF9E File Offset: 0x0003E19E
		private static Vector2i 럳()
		{
			return new Vector2i(ConfigFile.autoFishReturnSpotX, ConfigFile.autoFishReturnSpotY);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000A2050 File Offset: 0x000A0250
		private static bool 랢()
		{
			World world = global::랾.럓.랾;
			string b = ((world != null) ? world.worldName : null) ?? string.Empty;
			string text = (ConfigFile.autoFishReturnSpotWorldName ?? string.Empty).Trim();
			return !string.IsNullOrWhiteSpace(text) && string.Equals(text, b, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003FFAF File Offset: 0x0003E1AF
		private static bool 럻()
		{
			return global::랾.랆.럚() && global::랾.랆.랢() && (global::랾.럧.럈 || global::랾.랆.랓 || global::랾.랆.럐);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000A20A0 File Offset: 0x000A02A0
		private static void 랾(Vector2i A_0)
		{
			World world = global::랾.럓.랾;
			ConfigFile.autoFishReturnSpotWorldName = (((world != null) ? world.worldName : null) ?? string.Empty);
			ConfigFile.autoFishReturnSpotX = A_0.x;
			ConfigFile.autoFishReturnSpotY = A_0.y;
			global::랾.랆.럐 = false;
			global::랾.랆.랱 = -1f;
			global::랾.랆.람 = 0;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000A20F8 File Offset: 0x000A02F8
		private static bool 랾(out Vector2i A_0)
		{
			A_0 = default(Vector2i);
			if (global::랾.럓.랾 == null || Camera.main == null)
			{
				return false;
			}
			A_0 = global::랾.럽.랾(Camera.main.ScreenToWorldPoint(global::랾.랅.람()));
			return global::랾.럓.랾.IsMapPointInWorld(A_0);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000A2154 File Offset: 0x000A0354
		private unsafe static bool 랖()
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

		// Token: 0x06000734 RID: 1844 RVA: 0x000A21A4 File Offset: 0x000A03A4
		private static void 랾(Camera A_0, Vector2i A_1, string A_2, Color A_3, Color A_4)
		{
			Rect rect;
			if (!global::랾.랆.랾(A_0, A_1, out rect))
			{
				return;
			}
			global::랾.럈.랾(rect.x, rect.y, rect.width, rect.height, A_3);
			global::랾.럈.랾(rect.x, rect.y, rect.width, rect.height, A_4, 2.25f);
			Vector2 vector = global::랾.럈.랾(A_2, 0);
			float num = rect.x + (rect.width - vector.x) * 0.5f;
			float num2 = rect.y - vector.y - 6f;
			global::랾.럈.랾(num - 4f, num2 - 2f, vector.x + 8f, vector.y + 4f, new Color(0f, 0f, 0f, 0.55f));
			global::랾.랆.랾(A_2, num, num2, A_4);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000A2290 File Offset: 0x000A0490
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

		// Token: 0x06000736 RID: 1846 RVA: 0x000A2458 File Offset: 0x000A0658
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

		// Token: 0x06000737 RID: 1847 RVA: 0x0003FFD6 File Offset: 0x0003E1D6
		private static string 람(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return A_0;
			}
			if (A_0.StartsWith("Fish ", StringComparison.OrdinalIgnoreCase))
			{
				return A_0.Substring(5);
			}
			if (A_0.StartsWith("Fish", StringComparison.OrdinalIgnoreCase))
			{
				return A_0.Substring(4);
			}
			return A_0;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000A24CC File Offset: 0x000A06CC
		private static string 럒(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return A_0;
			}
			foreach (string text in new string[]
			{
				" Huge",
				" Large",
				" Medium",
				" Small",
				"Huge",
				"Large",
				"Medium",
				"Small"
			})
			{
				if (A_0.EndsWith(text, StringComparison.OrdinalIgnoreCase))
				{
					int length = text.Length;
					return A_0.Substring(0, A_0.Length - length);
				}
			}
			return A_0;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000A2564 File Offset: 0x000A0764
		private static string 럼(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return "Unknown";
			}
			StringBuilder stringBuilder = new StringBuilder(A_0.Length + 8);
			stringBuilder.Append(A_0[0]);
			for (int i = 1; i < A_0.Length; i++)
			{
				char c = A_0[i];
				char c2 = A_0[i - 1];
				bool flag = i + 1 < A_0.Length && char.IsLower(A_0[i + 1]);
				if (char.IsUpper(c) && (!char.IsUpper(c2) || flag))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000A260C File Offset: 0x000A080C
		private static bool 랉(PlayerData.InventoryKey[] A_0)
		{
			if (A_0 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			foreach (PlayerData.InventoryKey inventoryKey in A_0)
			{
				if (ConfigData.IsFishingLure(inventoryKey.blockType) && global::랾.럓.랾.GetCount(inventoryKey) > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000A265C File Offset: 0x000A085C
		private static void 럼(bool A_0)
		{
			if (A_0)
			{
				global::랾.랆.럯 = 0f;
				return;
			}
			global::랾.랆.럯 += Time.deltaTime;
			if (global::랾.랆.럯 < 5f)
			{
				return;
			}
			global::랾.랆.럯 = 0f;
			global::랾.럽.람("AutoFish: you have no fishing lure.", false);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0004000F File Offset: 0x0003E20F
		public static bool 럝()
		{
			return global::랾.랆.럽() && global::랾.랆.랾.Contains(global::랾.럧.랦) && global::랾.럧.럩 > 0 && global::랾.랆.럒(global::랾.럧.럩);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000A26AC File Offset: 0x000A08AC
		public static bool 럒(World.BlockType A_0)
		{
			if (A_0 <= 2451)
			{
				if (A_0 <= 2436)
				{
					if (A_0 != 2426 && A_0 != 2431 && A_0 != 2436)
					{
						return false;
					}
				}
				else if (A_0 != 2441 && A_0 != 2446 && A_0 != 2451)
				{
					return false;
				}
			}
			else if (A_0 <= 3352)
			{
				if (A_0 != 2456 && A_0 != 2461 && A_0 != 3352)
				{
					return false;
				}
			}
			else if (A_0 != 3358 && A_0 != 3685 && A_0 != 4590)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00040041 File Offset: 0x0003E241
		public static bool 럽()
		{
			return global::랾.럧.럩 > 0 && global::랾.럧.럸 >= 0f && Time.realtimeSinceStartup - global::랾.럧.럸 <= 6f;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0004006E File Offset: 0x0003E26E
		private static void 럜()
		{
			if (!global::랾.랆.럽())
			{
				return;
			}
			if (global::랾.럧.럩 > 0)
			{
				global::랾.랆.럼 = global::랾.럧.럩;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0004008A File Offset: 0x0003E28A
		private static void 럕()
		{
			global::랾.랆.럼 = 0;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000A2740 File Offset: 0x000A0940
		private static 랾 럘<랾>() where 랾 : BaseMenuUI
		{
			랾 랾;
			try
			{
				if (ControllerHelper.rootUI == null)
				{
					랾 = default(랾);
					랾 = 랾;
				}
				else
				{
					BaseMenuUI menufromCache = ControllerHelper.rootUI.GetMenufromCache(Il2CppType.Of<랾>());
					랾 = ((menufromCache != null) ? menufromCache.TryCast<랾>() : default(랾));
				}
			}
			catch
			{
				랾 = default(랾);
			}
			return 랾;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00040092 File Offset: 0x0003E292
		private static 랾 랟<랾>() where 랾 : BaseMenuUI
		{
			랾 result;
			if ((result = global::랾.랆.럘<랾>()) == null && (result = global::랾.랆.랺<랾>()) == null)
			{
				result = Object.FindObjectOfType<랾>();
			}
			return result;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000A27AC File Offset: 0x000A09AC
		private static 랾 랺<랾>() where 랾 : class
		{
			랾 랾;
			try
			{
				if (ControllerHelper.rootUI == null)
				{
					랾 = default(랾);
					랾 = 랾;
				}
				else
				{
					if (global::랾.랆.랾 == null)
					{
						global::랾.랆.랾 = global::랾.랆.럈();
					}
					if (global::랾.랆.랾 == null)
					{
						랾 = default(랾);
					}
					else
					{
						랾 = (global::랾.랆.랾.MakeGenericMethod(new Type[]
						{
							typeof(랾)
						}).Invoke(ControllerHelper.rootUI, null) as 랾);
					}
				}
			}
			catch
			{
				랾 = default(랾);
			}
			return 랾;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000A2850 File Offset: 0x000A0A50
		private static MethodInfo 럈()
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

		// Token: 0x06000745 RID: 1861 RVA: 0x000A28A8 File Offset: 0x000A0AA8
		private static bool 럧<랾>() where 랾 : BaseMenuUI
		{
			랾 랾 = global::랾.랆.럘<랾>();
			return 랾 != null && 랾.gameObject != null && 랾.gameObject.activeInHierarchy;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000400B5 File Offset: 0x0003E2B5
		private static void 럓()
		{
			global::랾.럧.럩 = 0;
			global::랾.럧.랦 = 0;
			global::랾.럧.럔 = 0;
			global::랾.럧.랞 = 0;
			global::랾.럧.럸 = -1f;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000400D9 File Offset: 0x0003E2D9
		private static float 랊()
		{
			return global::랾.랆.랾(ConfigFile.autoFishLegitPauseDurationMinSeconds, ConfigFile.autoFishLegitPauseDurationMaxSeconds);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000400EA File Offset: 0x0003E2EA
		private static float 럟()
		{
			return global::랾.랆.랾(ConfigFile.autoFishLegitPauseDelayMinSeconds, ConfigFile.autoFishLegitPauseDelayMaxSeconds);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000400FB File Offset: 0x0003E2FB
		private static void 럦()
		{
			global::랾.랆.랾 = false;
			global::랾.랆.랉 = 0f;
			global::랾.랆.럐 = 0f;
			global::랾.랆.랓 = global::랾.랆.럟();
			global::랾.랆.럎 = true;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000A28F0 File Offset: 0x000A0AF0
		public static void 랪()
		{
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			float num = float.MaxValue;
			CollectableData collectableData = null;
			foreach (CollectableData collectableData2 in global::랾.럓.랾.collectables)
			{
				Vector2i mapPoint = collectableData2.mapPoint;
				if (global::랾.랛.랾(mapPoint.x, mapPoint.y, mapPoint, false, false) && !ConfigData.IsCollectableBlockedByColliderBlock(global::랾.럓.랾, mapPoint))
				{
					float num2 = Vector2.Distance(global::랾.럽.랾(currentPlayerMapPoint), global::랾.럽.랾(mapPoint));
					if (num2 < num)
					{
						num = num2;
						collectableData = collectableData2;
					}
				}
			}
			if (collectableData != null)
			{
				global::랾.럧.럎 = collectableData.mapPoint;
				global::랾.랆.랾(currentPlayerMapPoint, global::랾.럧.럎, "Teleporting To Closest Collectable");
				return;
			}
			global::랾.럽.랾("No Collectables Detected", false);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000A29AC File Offset: 0x000A0BAC
		public static void 럷()
		{
			global::랾.럧.럟 += Time.deltaTime;
			if (global::랾.럓.랾.worldName != "THEBLACKTOWER")
			{
				if (global::랾.럓.랾.gems < 750)
				{
					global::랾.럽.람("Please Acquire 750 Gems, So You Can Start!", false);
					global::랾.럧.랛 = false;
					return;
				}
				if (global::랾.럧.럟 >= 1f)
				{
					SceneLoader.CheckIfWeCanGoFromWorldToWorld("THEBLACKTOWER", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), null, false, null);
					global::랾.럧.럟 = -15f;
				}
				return;
			}
			else
			{
				if (!global::랾.럓.랾.ContainsBlock(966) && global::랾.럧.럟 >= 2f)
				{
					SceneLoader.ReloadWorld();
					global::랾.럧.럟 = 0f;
					return;
				}
				if (global::랾.럧.럟 >= 1.5f)
				{
					global::랾.랆.럣();
					global::랾.럧.럟 = 0f;
				}
				return;
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000A2A74 File Offset: 0x000A0C74
		private static void 럣()
		{
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			float num = float.MaxValue;
			for (int i = 0; i < global::랾.럓.랾.worldSizeY; i++)
			{
				for (int j = 0; j < global::랾.럓.랾.worldSizeX; j++)
				{
					if (global::랾.럓.랾.GetBlockType(j, i) == 966)
					{
						float num2 = Vector2.Distance(global::랾.럽.랾(currentPlayerMapPoint), global::랾.럽.랾(new Vector2i(j, i)));
						if (num2 < num)
						{
							num = num2;
							global::랾.럧.럎 = new Vector2i(j, i);
						}
					}
				}
			}
			if (global::랾.럓.랾.currentPlayerPositionBlockType == 966)
			{
				ControllerHelper.worldController.SetBlock(2066, currentPlayerMapPoint.x, currentPlayerMapPoint.y);
				global::랾.럓.랾.SetBlock(2066, currentPlayerMapPoint.x, currentPlayerMapPoint.y, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), false);
			}
			global::랾.럽.랾("Teleporting To A Gift Box", false);
			global::랾.랆.랾(currentPlayerMapPoint, global::랾.럧.럎, null);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000A2B68 File Offset: 0x000A0D68
		public static void 랾(int A_0)
		{
			BSONArray bsonarray = new BSONArray();
			bsonarray.Add(A_0);
			BSONObject bsonobject = new BSONObject();
			bsonobject["ID"] = "wlA";
			bsonobject["WCSD"] = bsonarray;
			OutgoingMessages.AddOneMessageToList(bsonobject);
			SceneLoader.JoinDynamicWorld("MINEWORLD", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), false);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000A2BC4 File Offset: 0x000A0DC4
		public static void 랅()
		{
			if (!global::랾.럽.랾())
			{
				return;
			}
			global::랾.랆.랾();
			foreach (ValueTuple<World.BlockType, bool, int> valueTuple in new ValueTuple<World.BlockType, bool, int>[]
			{
				new ValueTuple<World.BlockType, bool, int>(3969, ConfigFile.MineLevel1, 1),
				new ValueTuple<World.BlockType, bool, int>(3970, ConfigFile.MineLevel2, 2),
				new ValueTuple<World.BlockType, bool, int>(3971, ConfigFile.MineLevel3, 3),
				new ValueTuple<World.BlockType, bool, int>(3972, ConfigFile.MineLevel4, 4)
			})
			{
				World.BlockType item = valueTuple.Item1;
				bool item2 = valueTuple.Item2;
				int item3 = valueTuple.Item3;
				if (item2 && global::랾.럓.랾.HasItemAmountInInventory(item, 7, 1))
				{
					global::랾.랆.랾(item3);
					global::랾.럧.랮 = true;
					return;
				}
			}
			global::랾.랆.랾(0);
			global::랾.럧.랮 = true;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000A2C98 File Offset: 0x000A0E98
		public static void 랁()
		{
			Vector2i firstMapPointOfBlockType = global::랾.럓.랾.GetFirstMapPointOfBlockType(3966, 0);
			BSONObject bsonobject = new BSONObject();
			bsonobject["ID"] = "GMExit";
			bsonobject["x"] = firstMapPointOfBlockType.x;
			bsonobject["y"] = firstMapPointOfBlockType.y;
			OutgoingMessages.AddOneMessageToList(bsonobject);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000A2D04 File Offset: 0x000A0F04
		public static void 랽()
		{
			if (!global::랾.럽.랾())
			{
				return;
			}
			foreach (PlayerData.InventoryKey inventoryKey in global::랾.랆.랾())
			{
				short count = global::랾.럓.랾.GetCount(inventoryKey);
				if (ConfigData.IsBlockMiningGemstone(inventoryKey.blockType) && count >= 988)
				{
					OutgoingMessages.RecycleMiningGemstone(inventoryKey, 5);
					global::랾.럓.랾.RemoveItemsFromInventory(inventoryKey, 5);
				}
				global::랾.럧.럈 += Time.deltaTime;
				if (ConfigData.IsMiningNugget(inventoryKey.blockType) && count >= 100 && global::랾.럧.럈 >= 10f && ConfigFile.autoConvert)
				{
					OutgoingMessages.ConvertItems(inventoryKey);
					global::랾.럧.럚++;
					if (global::랾.럧.럚 >= 5 && global::랾.럓.랾.worldName != "MINEWORLD")
					{
						SceneLoader.ReloadGame();
						global::랾.럧.럚 = 0;
					}
					global::랾.럧.럈 = 0f;
				}
				if (global::랾.럽.람(inventoryKey.blockType) && count >= 999 && global::랾.럓.랾.HasItemAmountInInventory(4171, 7, 990))
				{
					OutgoingMessages.SendSpinMiningRouletteMessage();
					global::랾.럓.랾.RemoveItemsFromInventory(inventoryKey, 1);
				}
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000A2E28 File Offset: 0x000A1028
		public static void 랋(bool A_0 = false)
		{
			global::랾.랆.럺();
			global::랾.럧.람 = new Vector2i(int.MinValue, int.MinValue);
			global::랾.럧.럒 = 0f;
			global::랾.럧.럧 = 0f;
			global::랾.럧.랺 = 0f;
			global::랾.럧.럜 = 0f;
			global::랾.럧.럕 = 0f;
			global::랾.럧.럘 = 0f;
			global::랾.럧.랟 = 0f;
			global::랾.럧.럓 = 0f;
			global::랾.럧.랊 = 0f;
			global::랾.럧.랮 = false;
			global::랾.럧.럠 = false;
			if (A_0)
			{
				global::랾.럧.랐 = 0f;
				global::랾.럧.럳 = 0;
				global::랾.럧.랢 = 0;
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		public static string 랡()
		{
			if (!global::랾.럧.랺)
			{
				return "Disabled";
			}
			bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.isActiveAndEnabled;
			if (global::랾.럽.럎())
			{
				if (!global::랾.럧.럘)
				{
					return "Waiting in menu";
				}
				return "Returning from menu";
			}
			else
			{
				if (global::랾.럽.람() || flag)
				{
					return "Joining world";
				}
				if (!global::랾.럽.랾() || global::랾.럓.랾 == null)
				{
					return "Waiting for world";
				}
				if (!string.Equals(global::랾.럓.랾.worldName, "MINEWORLD", StringComparison.OrdinalIgnoreCase))
				{
					if (global::랾.럧.럕 >= 2.5f)
					{
						return "Joining pixel mine";
					}
					return "Preparing from " + global::랾.럓.랾.worldName;
				}
				else
				{
					if (global::랾.럧.럯)
					{
						return "Teleporting to " + global::랾.랆.랃();
					}
					if (global::랾.럧.럅 || global::랾.럧.랰 || global::랾.럧.럖)
					{
						return "Routing to " + global::랾.랆.랃();
					}
					if (global::랾.럧.랮)
					{
						return "Scanning current mine";
					}
					return "Preparing mine run";
				}
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000A2FD0 File Offset: 0x000A11D0
		public static string 랃()
		{
			if (global::랾.랆.랾 != null)
			{
				return global::랾.랆.랾(global::랾.랆.랾.랾);
			}
			if (global::랾.럧.럅)
			{
				return "Gem Stone";
			}
			if (global::랾.럧.랰)
			{
				return "Collectable";
			}
			if (global::랾.럧.럖)
			{
				return "Mine Exit";
			}
			return "None";
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000A3020 File Offset: 0x000A1220
		public static string 랛()
		{
			List<랛.랾> list = global::랾.럧.랾;
			int num = (list != null) ? list.Count : 0;
			List<랛.랾> list2 = global::랾.럧.람;
			int num2 = (list2 != null) ? list2.Count : 0;
			if (num <= 1 && num2 <= 0)
			{
				return "No active route";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Teleport ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" nodes | Break path ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler.AppendLiteral(" nodes");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00040127 File Offset: 0x0003E327
		public static string 랆()
		{
			if (global::랾.럽.럎())
			{
				return "Main Menu";
			}
			if (global::랾.럽.람())
			{
				return "Joining World";
			}
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null)
			{
				return "Not in a world";
			}
			return global::랾.럓.랾.worldName;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000A30A4 File Offset: 0x000A12A4
		public static string 랐()
		{
			World world = global::랾.럓.랾;
			if (((world != null) ? world.collectables : null) == null)
			{
				return "Unknown";
			}
			return global::랾.럓.랾.collectables.Count.ToString();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00040161 File Offset: 0x0003E361
		public static string 럆()
		{
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || !string.Equals(global::랾.럓.랾.worldName, "MINEWORLD", StringComparison.OrdinalIgnoreCase))
			{
				return "No";
			}
			return "Yes";
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000A30E4 File Offset: 0x000A12E4
		public static string 랄()
		{
			List<string> list = new List<string>(4);
			if (ConfigFile.MineLevel1)
			{
				list.Add("Mine I");
			}
			if (ConfigFile.MineLevel2)
			{
				list.Add("Mine II");
			}
			if (ConfigFile.MineLevel3)
			{
				list.Add("Mine III");
			}
			if (ConfigFile.MineLevel4)
			{
				list.Add("Mine IV");
			}
			if (list.Count <= 0)
			{
				return "No paid mine levels enabled";
			}
			return string.Join(", ", list);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00040196 File Offset: 0x0003E396
		public static float 랳()
		{
			if (global::랾.럧.랐 <= 0f)
			{
				return 0f;
			}
			return (float)global::랾.럧.럳 / MathF.Max(global::랾.럧.랐 / 3600f, 0.0001f);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000A315C File Offset: 0x000A135C
		public static string 럸()
		{
			float num = MathF.Max(0f, global::랾.럧.랐);
			if (num <= 0f)
			{
				return "0s";
			}
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)num);
			if (timeSpan.TotalHours >= 1.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
				defaultInterpolatedStringHandler.AppendFormatted<int>((int)timeSpan.TotalHours);
				defaultInterpolatedStringHandler.AppendLiteral("h ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Minutes);
				defaultInterpolatedStringHandler.AppendLiteral("m ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds);
				defaultInterpolatedStringHandler.AppendLiteral("s");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (timeSpan.TotalMinutes >= 1.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler2.AppendFormatted<int>(timeSpan.Minutes);
				defaultInterpolatedStringHandler2.AppendLiteral("m ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(timeSpan.Seconds);
				defaultInterpolatedStringHandler2.AppendLiteral("s");
				return defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler3.AppendFormatted<int>(timeSpan.Seconds);
			defaultInterpolatedStringHandler3.AppendLiteral("s");
			return defaultInterpolatedStringHandler3.ToStringAndClear();
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000A3284 File Offset: 0x000A1484
		private static string 랾(랆.랾 A_0)
		{
			string result;
			switch (A_0)
			{
			case global::랾.랆.랾.럎:
				result = "Gem Stone";
				break;
			case global::랾.랆.랾.람:
				result = "Collectable";
				break;
			case global::랾.랆.랾.럒:
				result = "Mine Exit";
				break;
			default:
				result = "None";
				break;
			}
			return result;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000A32C8 File Offset: 0x000A14C8
		public static void 랴()
		{
			ConfigData.playerChangeToSleepSeconds = int.MaxValue;
			ConfigFile.antiBounceToggle = true;
			ConfigFile.aimbotPVEToggle = false;
			global::랾.럧.랐 += Time.deltaTime;
			string worldName = global::랾.럓.랾.worldName;
			Vector2i vector2i = global::랾.랆.랰();
			if (global::랾.럧.랮 && global::랾.럽.랾())
			{
				global::랾.랆.럎(vector2i);
				if (global::랾.럧.럅 || global::랾.럧.랰 || global::랾.럧.럖)
				{
					bool flag = global::랾.랆.람(vector2i);
					bool flag2 = global::랾.럧.람.Count > 0 && global::랾.랆.랾(global::랾.럧.람);
					global::랾.랆.럐(vector2i);
					global::랾.랆.랾(vector2i, flag, flag2);
				}
				else
				{
					global::랾.랆.럅();
				}
			}
			if (global::랾.럽.람())
			{
				global::랾.럧.럒 = -1f;
			}
			global::랾.럧.럕 += Time.deltaTime;
			if (worldName != "MINEWORLD" && global::랾.럧.럕 >= 2.5f)
			{
				global::랾.랆.럺();
				global::랾.랆.랅();
				global::랾.럧.럕 = 0f;
				global::랾.럧.랺 = 0f;
				global::랾.럧.랮 = false;
			}
			else if (worldName == "MINEWORLD")
			{
				global::랾.럧.랺 += Time.deltaTime;
				if (global::랾.럧.랺 >= 500f)
				{
					SceneLoader.ReloadWorld();
					global::랾.럧.랢++;
					global::랾.럧.랺 = 0f;
				}
				global::랾.럧.랮 = true;
			}
			global::랾.럧.럜 += Time.deltaTime;
			if (global::랾.럧.럜 >= 2.5f)
			{
				global::랾.랆.럶();
				global::랾.럧.럜 = -5f;
			}
			global::랾.럧.럠 = false;
			global::랾.랆.랽();
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000A344C File Offset: 0x000A164C
		private static void 럎(Vector2i A_0)
		{
			if (global::랾.럧.럯)
			{
				return;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (realtimeSinceStartup < global::랾.랆.럒)
			{
				return;
			}
			global::랾.랆.럒 = realtimeSinceStartup + 0.35f;
			bool flag = global::랾.랆.랾 == null || global::랾.랆.랾.랾 != A_0;
			if (global::랾.랆.랾 == null || realtimeSinceStartup >= global::랾.랆.럼 || global::랾.랆.럎 != global::랾.럓.랾.collectables.Count || !global::랾.랆.랾(global::랾.랆.랾))
			{
				global::랾.랆.랾 = global::랾.랆.럼(A_0);
				global::랾.랆.럼 = realtimeSinceStartup + 1.25f;
				global::랾.랆.럎 = global::랾.럓.랾.collectables.Count;
			}
			else if (flag && !global::랾.랆.랾(A_0, global::랾.랆.랾))
			{
				global::랾.랆.랾 = global::랾.랆.럼(A_0);
				global::랾.랆.럼 = realtimeSinceStartup + 1.25f;
				global::랾.랆.럎 = global::랾.럓.랾.collectables.Count;
			}
			global::랾.랆.럎(global::랾.랆.랾);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000A3540 File Offset: 0x000A1740
		private static bool 람(Vector2i A_0)
		{
			if (global::랾.럧.럯)
			{
				global::랾.럧.럒 = 0f;
				return false;
			}
			if (global::랾.럧.랾 == null || global::랾.럧.랾.Count <= 1)
			{
				global::랾.럧.럒 = 0f;
				return false;
			}
			global::랾.럧.럒 += Time.deltaTime;
			if (global::랾.럧.럒 <= ConfigFile.autoMineTeleportTimerMax)
			{
				return false;
			}
			bool result = global::랾.랆.랾(global::랾.럧.랾, global::랾.랆.럠());
			global::랾.럧.럒 = 0f;
			return result;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000A35B8 File Offset: 0x000A17B8
		private static bool 랾(Vector2i A_0, List<랛.랾> A_1, out List<랛.랾> A_2)
		{
			A_2 = null;
			if (A_1 == null || A_1.Count == 0)
			{
				return false;
			}
			List<랛.랾> list = global::랾.랛.랾(A_1, A_0);
			if (list.Count > 1)
			{
				랛.랾 랾 = list[list.Count - 1];
				if (!global::랾.랛.랾(랾, A_0))
				{
					List<랛.랾> list2 = global::랾.랛.랾(A_0, new Vector2i(랾.랾, 랾.럎), global::랾.랛.럎());
					if (list2 != null && list2.Count > 1)
					{
						A_2 = list2;
						return true;
					}
					A_2 = new List<랛.랾>(list);
					if (A_2.Count > 1)
					{
						return true;
					}
				}
			}
			return global::랾.랆.럎(A_0, A_1, out A_2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000A3648 File Offset: 0x000A1848
		private static bool 럎(Vector2i A_0, List<랛.랾> A_1, out List<랛.랾> A_2)
		{
			A_2 = null;
			if (A_1 == null || A_1.Count <= 1)
			{
				return false;
			}
			for (int i = A_1.Count - 1; i >= 1; i--)
			{
				랛.랾 랾 = A_1[i];
				Vector2i vector2i;
				vector2i..ctor(랾.랾, 랾.럎);
				if (!(vector2i == A_0) && global::랾.럓.랾.IsMapPointInWorld(vector2i) && global::랾.랛.랾(랾.랾, 랾.럎, A_0, false, false))
				{
					List<랛.랾> list = global::랾.랛.랾(A_0, vector2i, global::랾.랛.럎());
					if (list != null && list.Count > 1)
					{
						A_2 = list;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000A36E0 File Offset: 0x000A18E0
		private static bool 랾(Vector2i A_0, 랆.람 A_1)
		{
			if (A_1 == null)
			{
				return false;
			}
			switch (A_1.랾)
			{
			case global::랾.랆.랾.럎:
			case global::랾.랆.랾.럒:
			{
				List<랛.랾> list;
				global::랾.랆.랾(A_0, A_1.랾, out list);
				A_1.럎 = (list ?? new List<랛.랾>());
				A_1.랾 = global::랾.랛.람(A_1.랾, A_0);
				A_1.랾 = A_0;
				return A_1.랾 != null && A_1.랾.Count > 0;
			}
			case global::랾.랆.랾.람:
			{
				CollectableData collectableData = global::랾.랆.럒(A_1.럎);
				랆.람 람 = global::랾.랆.랾(A_0, collectableData);
				if (람 == null)
				{
					return false;
				}
				A_1.랾 = 람.랾;
				A_1.럎 = 람.럎;
				A_1.랾 = 람.랾;
				A_1.랾 = A_0;
				return true;
			}
			default:
				return false;
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000A37AC File Offset: 0x000A19AC
		private static bool 랾(랆.람 A_0)
		{
			if (A_0 == null || global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0.럎))
			{
				return false;
			}
			switch (A_0.랾)
			{
			case global::랾.랆.랾.럎:
				return global::랾.럽.럒(global::랾.럓.랾.GetBlockType(A_0.럎));
			case global::랾.랆.랾.람:
				foreach (CollectableData collectableData in global::랾.럓.랾.collectables)
				{
					if (collectableData != null && collectableData.mapPoint == A_0.럎)
					{
						return true;
					}
				}
				return false;
			case global::랾.랆.랾.럒:
				return global::랾.럓.랾.GetBlockType(A_0.럎) == 3966;
			default:
				return false;
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000A3860 File Offset: 0x000A1A60
		private static CollectableData 럒(Vector2i A_0)
		{
			foreach (CollectableData collectableData in global::랾.럓.랾.collectables)
			{
				if (collectableData != null && collectableData.mapPoint == A_0)
				{
					return collectableData;
				}
			}
			return null;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000A38A4 File Offset: 0x000A1AA4
		private static void 럺()
		{
			global::랾.랆.랾 = null;
			global::랾.랆.럒 = 0f;
			global::랾.랆.럼 = 0f;
			global::랾.랆.럎 = -1;
			global::랾.랆.럅();
			global::랾.럧.럎 = default(Vector2i);
			global::랾.럧.럅 = false;
			global::랾.럧.랰 = false;
			global::랾.럧.럖 = false;
			global::랾.럧.람.Clear();
			global::랾.럧.랾.Clear();
			global::랾.럧.럼 = -1;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000A3910 File Offset: 0x000A1B10
		private static 랆.람 럼(Vector2i A_0)
		{
			랆.람 람 = null;
			foreach (Vector2i vector2i in global::랾.랆.랋(A_0))
			{
				global::랾.랆.랾(global::랾.랆.랾(A_0, vector2i, global::랾.랆.랾.럎), ref 람);
			}
			foreach (CollectableData collectableData in global::랾.랆.랉(A_0))
			{
				global::랾.랆.랾(global::랾.랆.랾(A_0, collectableData), ref 람);
			}
			if (람 == null && global::랾.럓.랾.collectables.Count > 0)
			{
				foreach (CollectableData collectableData2 in global::랾.럓.랾.collectables)
				{
					global::랾.랆.랾(global::랾.랆.랾(A_0, collectableData2), ref 람);
				}
			}
			if (람 == null)
			{
				Vector2i firstMapPointOfBlockType = global::랾.럓.랾.GetFirstMapPointOfBlockType(3966, 0);
				global::랾.랆.랾(global::랾.랆.랾(A_0, firstMapPointOfBlockType, global::랾.랆.랾.럒), ref 람);
			}
			return 람;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000A3A1C File Offset: 0x000A1C1C
		private static IEnumerable<Vector2i> 랋(Vector2i A_0)
		{
			List<ValueTuple<Vector2i, float>> list = new List<ValueTuple<Vector2i, float>>();
			Vector2 vector = global::랾.럽.랾(A_0);
			for (int i = 0; i < global::랾.럓.랾.worldSizeY; i++)
			{
				for (int j = 0; j < global::랾.럓.랾.worldSizeX; j++)
				{
					if (global::랾.럽.럒(global::랾.럓.랾.GetBlockType(j, i)))
					{
						Vector2i vector2i;
						vector2i..ctor(j, i);
						float sqrMagnitude = (global::랾.럽.랾(vector2i) - vector).sqrMagnitude;
						global::랾.랆.랾(list, vector2i, sqrMagnitude);
					}
				}
			}
			return list.Select(new Func<ValueTuple<Vector2i, float>, Vector2i>(global::랾.랆.랋.랾.랾));
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000A3AC4 File Offset: 0x000A1CC4
		private static IEnumerable<CollectableData> 랉(Vector2i A_0)
		{
			Vector2 vector = global::랾.럽.랾(A_0);
			List<ValueTuple<CollectableData, float>> list = new List<ValueTuple<CollectableData, float>>();
			foreach (CollectableData collectableData in global::랾.럓.랾.collectables)
			{
				if (collectableData != null)
				{
					float sqrMagnitude = (global::랾.럽.랾(collectableData.mapPoint) - vector).sqrMagnitude;
					global::랾.랆.랾(list, collectableData, sqrMagnitude);
				}
			}
			return list.Select(new Func<ValueTuple<CollectableData, float>, CollectableData>(global::랾.랆.랋.랾.랾));
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000A3B4C File Offset: 0x000A1D4C
		private static void 랾([TupleElementNames(new string[]
		{
			"Pos",
			"Dist"
		})] List<ValueTuple<Vector2i, float>> candidates, Vector2i A_1, float A_2)
		{
			int num = candidates.Count;
			for (int i = 0; i < candidates.Count; i++)
			{
				if (A_2 < candidates[i].Item2)
				{
					num = i;
					break;
				}
			}
			if (num >= 6)
			{
				return;
			}
			candidates.Insert(num, new ValueTuple<Vector2i, float>(A_1, A_2));
			if (candidates.Count > 6)
			{
				candidates.RemoveAt(candidates.Count - 1);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000A3BB0 File Offset: 0x000A1DB0
		private static void 랾([TupleElementNames(new string[]
		{
			"Collectable",
			"Dist"
		})] List<ValueTuple<CollectableData, float>> candidates, CollectableData A_1, float A_2)
		{
			int num = candidates.Count;
			for (int i = 0; i < candidates.Count; i++)
			{
				if (A_2 < candidates[i].Item2)
				{
					num = i;
					break;
				}
			}
			if (num >= 6)
			{
				return;
			}
			candidates.Insert(num, new ValueTuple<CollectableData, float>(A_1, A_2));
			if (candidates.Count > 6)
			{
				candidates.RemoveAt(candidates.Count - 1);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000A3C14 File Offset: 0x000A1E14
		private static 랆.람 랾(Vector2i A_0, Vector2i A_1, 랆.랾 A_2)
		{
			if (!global::랾.럓.랾.IsMapPointInWorld(A_1))
			{
				return null;
			}
			List<랛.랾> list = global::랾.랛.랾(A_0, A_1);
			if (list == null || list.Count == 0)
			{
				return null;
			}
			List<랛.랾> list2;
			global::랾.랆.랾(A_0, list, out list2);
			if (!global::랾.랆.랾(A_0, list, list2))
			{
				return null;
			}
			return new 랆.람
			{
				랾 = A_2,
				랾 = A_0,
				럎 = A_1,
				랾 = list,
				럎 = (list2 ?? new List<랛.랾>()),
				랾 = global::랾.랛.람(list, A_0)
			};
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000A3C9C File Offset: 0x000A1E9C
		private static 랆.람 랾(Vector2i A_0, CollectableData A_1)
		{
			if (A_1 == null)
			{
				return null;
			}
			Vector2i mapPoint = A_1.mapPoint;
			if (!global::랾.럓.랾.IsMapPointInWorld(mapPoint))
			{
				return null;
			}
			List<랛.랾> list = null;
			List<랛.랾> list2 = null;
			float num = float.PositiveInfinity;
			if (!ConfigData.IsCollectableBlockedByColliderBlock(global::랾.럓.랾, mapPoint))
			{
				List<랛.랾> list3 = global::랾.랛.랾(A_0, mapPoint, global::랾.랛.럎());
				if (list3 != null && list3.Count > 0)
				{
					list = list3;
					num = global::랾.랛.럎(list3);
				}
			}
			List<랛.랾> list4 = global::랾.랛.랾(A_0, mapPoint);
			if (list4 != null && list4.Count > 0)
			{
				List<랛.랾> list5;
				global::랾.랆.랾(A_0, list4, out list5);
				float num2 = global::랾.랛.람(list4, A_0);
				if (list == null || num2 < num)
				{
					list2 = list4;
					list = (list5 ?? new List<랛.랾>());
					num = num2;
				}
			}
			if (list == null && list2 == null)
			{
				return null;
			}
			if (!global::랾.랆.랾(A_0, list2, list))
			{
				return null;
			}
			return new 랆.람
			{
				랾 = global::랾.랆.랾.람,
				랾 = A_0,
				럎 = mapPoint,
				랾 = (list2 ?? new List<랛.랾>()),
				럎 = (list ?? new List<랛.랾>()),
				랾 = num
			};
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000401C6 File Offset: 0x0003E3C6
		private static void 랾(랆.람 A_0, ref 랆.람 A_1)
		{
			if (A_0 == null)
			{
				return;
			}
			if (A_1 == null || A_0.랾 < A_1.랾)
			{
				A_1 = A_0;
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000A3DA0 File Offset: 0x000A1FA0
		private static void 럎(랆.람 A_0)
		{
			global::랾.럧.럅 = false;
			global::랾.럧.랰 = false;
			global::랾.럧.럖 = false;
			global::랾.럧.럎 = default(Vector2i);
			global::랾.럧.람 = new Vector2i(int.MinValue, int.MinValue);
			if (A_0 == null)
			{
				global::랾.럧.람.Clear();
				global::랾.럧.랾.Clear();
				global::랾.럧.럼 = -1;
				return;
			}
			global::랾.럧.럎 = A_0.럎;
			switch (A_0.랾)
			{
			case global::랾.랆.랾.럎:
				global::랾.럧.럅 = true;
				break;
			case global::랾.랆.랾.람:
				global::랾.럧.랰 = true;
				break;
			case global::랾.랆.랾.럒:
				global::랾.럧.럖 = true;
				break;
			}
			global::랾.랆.랾(A_0.랾, global::랾.럧.람);
			global::랾.랆.랾(A_0.럎, global::랾.럧.랾);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000401E2 File Offset: 0x0003E3E2
		private static void 랾(List<랛.랾> A_0, List<랛.랾> A_1)
		{
			A_1.Clear();
			if (A_0 == null || A_0.Count == 0)
			{
				return;
			}
			A_1.AddRange(A_0);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000A3E5C File Offset: 0x000A205C
		private static bool 랾(Vector2i A_0, List<랛.랾> A_1, List<랛.랾> A_2)
		{
			if (A_2 != null && A_2.Count > 1)
			{
				return true;
			}
			if (A_1 == null || A_1.Count == 0)
			{
				return false;
			}
			List<Vector2i> list = global::랾.랆.랓(A_0);
			int num = global::랾.랆.랾(A_1, A_0);
			for (int i = Math.Max(1, num - (global::랾.랆.랮() + 1)); i < A_1.Count; i++)
			{
				if (global::랾.랆.럎(list, A_1[i].랾, A_1[i].럎) && global::랾.랆.랾(A_1[i].랾, A_1[i].럎))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000401FD File Offset: 0x0003E3FD
		private static string 럠()
		{
			if (global::랾.럧.럅)
			{
				return "Setting Path To Gem Stone";
			}
			if (global::랾.럧.랰)
			{
				return "Setting Path To Collectable";
			}
			if (global::랾.럧.럖)
			{
				return "Setting Path To Exit";
			}
			return null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000A3EF4 File Offset: 0x000A20F4
		private static void 럐(Vector2i A_0)
		{
			if (!global::랾.럧.럖)
			{
				return;
			}
			if (!global::랾.랆.럯(A_0) && !global::랾.랆.럯(new Vector2i(A_0.x - 1, A_0.y)) && !global::랾.랆.럯(new Vector2i(A_0.x + 1, A_0.y)) && !global::랾.랆.럯(new Vector2i(A_0.x, A_0.y - 1)) && !global::랾.랆.럯(new Vector2i(A_0.x, A_0.y + 1)))
			{
				return;
			}
			global::랾.럧.랟 += Time.deltaTime;
			if ((double)global::랾.럧.랟 > 0.5 && global::랾.럓.랾.collectables.Count == 0)
			{
				global::랾.랆.랁();
				global::랾.럧.랾.Clear();
				global::랾.럧.럯 = false;
				global::랾.럧.럼 = -1;
				global::랾.럧.랋 = 0;
				GeneratedMineResultsUI generatedMineResultsUI = global::랾.랆.럎럼();
				if (generatedMineResultsUI != null)
				{
					generatedMineResultsUI.PositiveButtonPressed();
					global::랾.럧.럳++;
					string text = "automine";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 3);
					defaultInterpolatedStringHandler.AppendLiteral("Mine Complete | Time: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.럧.랺, "F1");
					defaultInterpolatedStringHandler.AppendLiteral("s | Count: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럳);
					defaultInterpolatedStringHandler.AppendLiteral(" | Disconnects: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.랢);
					global::랾.럕.랾(text, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				global::랾.럧.랟 = -5f;
			}
			global::랾.럧.럘 = -3f;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000A4074 File Offset: 0x000A2274
		public static bool 랾(List<랛.랾> A_0)
		{
			global::랾.럧.럧 += Time.deltaTime;
			if (global::랾.럧.럧 < ConfigFile.autoMineBreakTimerMax || !global::랾.럧.랮)
			{
				return false;
			}
			if (A_0 == null || A_0.Count == 0 || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				global::랾.럧.럧 = 0f;
				return false;
			}
			Vector2i vector2i = global::랾.랆.랰();
			int num = global::랾.랆.랾(A_0, vector2i);
			List<Vector2i> list = global::랾.랆.랓(vector2i);
			bool result = global::랾.랆.랾(A_0, list, num) || global::랾.랆.럎(A_0, list, num);
			global::랾.럧.럧 = 0f;
			return result;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000A4108 File Offset: 0x000A2308
		private static bool 랾(List<랛.랾> A_0, List<Vector2i> A_1, int A_2)
		{
			for (int i = Math.Max(1, A_2 - (global::랾.랆.랮() + 1)); i < A_0.Count; i++)
			{
				랛.랾 랾 = A_0[i];
				if (global::랾.랆.럎(A_1, 랾.랾, 랾.럎) && global::랾.랆.랾(랾.랾, 랾.럎))
				{
					global::랾.럽.랾(랾.랾, 랾.럎);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000A4178 File Offset: 0x000A2378
		private static bool 럎(List<랛.랾> A_0, List<Vector2i> A_1, int A_2)
		{
			int num = Math.Max(1, A_2 - (global::랾.랆.랮() + 1));
			int num2 = int.MaxValue;
			int num3 = int.MaxValue;
			Vector2i vector2i;
			vector2i..ctor(int.MinValue, int.MinValue);
			foreach (Vector2i vector2i2 in A_1)
			{
				if (global::랾.랆.랾(vector2i2.x, vector2i2.y))
				{
					int num4 = -1;
					int num5 = int.MaxValue;
					for (int i = num; i < A_0.Count; i++)
					{
						int num6 = Math.Abs(A_0[i].랾 - vector2i2.x) + Math.Abs(A_0[i].럎 - vector2i2.y);
						if (num6 < num5)
						{
							num5 = num6;
							num4 = i;
							if (num6 == 0)
							{
								break;
							}
						}
					}
					if (num4 != -1 && num5 <= 1 && (num4 < num2 || (num4 == num2 && num5 < num3)))
					{
						num2 = num4;
						num3 = num5;
						vector2i = vector2i2;
					}
				}
			}
			if (num2 == 2147483647)
			{
				return false;
			}
			global::랾.럽.랾(vector2i.x, vector2i.y);
			return true;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000A42B4 File Offset: 0x000A24B4
		private static List<Vector2i> 랓(Vector2i A_0)
		{
			List<Vector2i> list = new List<Vector2i>(48);
			int num = global::랾.랆.랮();
			for (int i = 1; i <= num; i++)
			{
				global::랾.랆.랾(list, A_0.x, A_0.y + i);
				global::랾.랆.랾(list, A_0.x, A_0.y - i);
			}
			for (int j = 1; j <= num; j++)
			{
				for (int k = 0; k <= num; k++)
				{
					global::랾.랆.랾(list, A_0.x - j, A_0.y + k);
					global::랾.랆.랾(list, A_0.x + j, A_0.y + k);
				}
			}
			global::랾.랆.랾(list, A_0.x - 1, A_0.y - 1);
			global::랾.랆.랾(list, A_0.x + 1, A_0.y - 1);
			for (int l = 2; l <= num; l++)
			{
				for (int m = -1; m <= 1; m++)
				{
					global::랾.랆.랾(list, A_0.x + m, A_0.y - l);
				}
			}
			return list;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000A43B4 File Offset: 0x000A25B4
		private static void 랾(List<Vector2i> A_0, int A_1, int A_2)
		{
			Vector2i vector2i;
			vector2i..ctor(A_1, A_2);
			if (!global::랾.럓.랾.IsMapPointInWorld(vector2i) || global::랾.랆.럎(A_0, A_1, A_2))
			{
				return;
			}
			A_0.Add(vector2i);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000A43EC File Offset: 0x000A25EC
		private static bool 럎(List<Vector2i> A_0, int A_1, int A_2)
		{
			for (int i = 0; i < A_0.Count; i++)
			{
				if (A_0[i].x == A_1 && A_0[i].y == A_2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000A442C File Offset: 0x000A262C
		private static bool 랾(int A_0, int A_1)
		{
			World.BlockType blockType = global::랾.럓.랾.GetBlockType(A_0, A_1);
			return ConfigData.DoesBlockHaveCollider(blockType) && !global::랾.럽.랾(blockType);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000A445C File Offset: 0x000A265C
		private static int 랮()
		{
			int num = (global::랾.럓.랾 != null && global::랾.럓.랾.GetIsPerkActive(11)) ? 4 : 3;
			return Math.Max(1, num - 1);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000A448C File Offset: 0x000A268C
		private static void 랾(Vector2i A_0, bool A_1, bool A_2)
		{
			if (global::랾.럧.럯)
			{
				global::랾.랆.럎(A_0, global::랾.럧.럎);
				return;
			}
			bool flag = A_0 != global::랾.랆.랾;
			bool flag2 = global::랾.럧.럎 != global::랾.랆.럎;
			if (flag || flag2 || A_1 || A_2)
			{
				global::랾.랆.럎(A_0, global::랾.럧.럎);
				return;
			}
			global::랾.랆.랋 += Time.deltaTime;
			global::랾.랆.랾 = A_0;
			global::랾.랆.럎 = global::랾.럧.럎;
			if (global::랾.랆.랋 < 1.25f)
			{
				return;
			}
			global::랾.랆.럺();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00040227 File Offset: 0x0003E427
		private static void 럅()
		{
			global::랾.랆.랋 = 0f;
			global::랾.랆.랾 = new Vector2i(int.MinValue, int.MinValue);
			global::랾.랆.럎 = new Vector2i(int.MinValue, int.MinValue);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0004025B File Offset: 0x0003E45B
		private static void 럎(Vector2i A_0, Vector2i A_1)
		{
			global::랾.랆.랋 = 0f;
			global::랾.랆.랾 = A_0;
			global::랾.랆.럎 = A_1;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000A4510 File Offset: 0x000A2710
		private static Vector2i 랰()
		{
			Player player = global::랾.럓.랾;
			if (((player != null) ? player.myTransform : null) != null && global::랾.럓.랾 != null)
			{
				Vector2i vector2i = global::랾.럽.랾(global::랾.럓.랾.myTransform.position);
				if (global::랾.럓.랾.IsMapPointInWorld(vector2i))
				{
					return vector2i;
				}
			}
			return global::랾.럓.랾.currentPlayerMapPoint;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000A4570 File Offset: 0x000A2770
		private static int 랾(List<랛.랾> A_0, Vector2i A_1)
		{
			if (A_0 == null || A_0.Count == 0)
			{
				return 0;
			}
			int result = 0;
			int num = int.MaxValue;
			for (int i = 0; i < A_0.Count; i++)
			{
				int num2 = Math.Abs(A_0[i].랾 - A_1.x) + Math.Abs(A_0[i].럎 - A_1.y);
				if (num2 < num)
				{
					num = num2;
					result = i;
					if (num2 == 0)
					{
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00040273 File Offset: 0x0003E473
		private static bool 럯(Vector2i A_0)
		{
			return global::랾.럓.랾.IsMapPointInWorld(A_0) && global::랾.럓.랾.GetBlockType(A_0) == 3966;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000A45E4 File Offset: 0x000A27E4
		public static void 럖()
		{
			if (LoadingScreenController.instance != null && LoadingScreenController.instance.isActiveAndEnabled)
			{
				global::랾.럧.량 += Time.deltaTime;
				if (global::랾.럧.량 > 20f)
				{
					SceneLoader.ReloadWorld();
					Console.WriteLine("Infinite Loading Detected");
					global::랾.럧.량 = 0f;
					return;
				}
			}
			else
			{
				global::랾.럧.량 = 0f;
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000A4650 File Offset: 0x000A2850
		public static void 럶()
		{
			bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.isActiveAndEnabled;
			if (global::랾.럽.럎())
			{
				global::랾.럧.럘 = true;
			}
			if (global::랾.럽.랾() || flag)
			{
				global::랾.럧.럘 = false;
				global::랾.럧.럜 = 0f;
			}
			if (global::랾.럽.럎() && !flag && global::랾.럧.럘)
			{
				string text = global::랾.랆.랻();
				if (string.IsNullOrWhiteSpace(text))
				{
					return;
				}
				SceneLoader.GoFromMainMenuToWorld(text, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
				global::랾.럧.량 = 0f;
				global::랾.럧.럽 = 0f;
				global::랾.럧.럝 = 0f;
				global::랾.럧.럘 = false;
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000A46F0 File Offset: 0x000A28F0
		private static string 랻()
		{
			if (global::랾.럧.럷)
			{
				string text = global::랾.랆.럎럙();
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
			}
			return (ConfigFile.rejoinWorldName ?? string.Empty).Trim();
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000A4728 File Offset: 0x000A2928
		public static void 략()
		{
			PlayerData.InventoryKey[] array = global::랾.랆.랾();
			int num = Math.Min(array.Length, 400);
			for (int i = 0; i < num; i++)
			{
				PlayerData.InventoryKey inventoryKey = array[i];
				if (ConfigData.IsConsumableTreasurePouch(inventoryKey.blockType))
				{
					short count = global::랾.럓.랾.GetCount(inventoryKey);
					for (int j = 0; j < (int)count; j++)
					{
						if (!global::랾.럽.랾(inventoryKey))
						{
							global::랾.럽.랾("Finished Opening Gem Pouches!", false);
							ConfigFile.openPouchSpam = false;
							return;
						}
						OutgoingMessages.SendOpenTreasureMessage(inventoryKey, true);
					}
				}
			}
			global::랾.럽.랾("Finished Opening Gem Pouches!", false);
			ConfigFile.openPouchSpam = false;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000A47BC File Offset: 0x000A29BC
		public static void 럵()
		{
			PlayerData.InventoryKey[] array = global::랾.랆.랾();
			int i = 0;
			while (i < array.Length)
			{
				PlayerData.InventoryKey inventoryKey = array[i];
				if (inventoryKey.blockType == 4171)
				{
					if (global::랾.럓.랾.myPlayerData.GetCount(inventoryKey) >= 1)
					{
						OutgoingMessages.SendSpinMiningRouletteMessage();
						return;
					}
					global::랾.럽.랾("Finished Spinning The Mining Wheel!", false);
					global::랾.럧.랽 = false;
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000A4820 File Offset: 0x000A2A20
		public static void 럨()
		{
			PlayerData.InventoryKey[] array = global::랾.랆.랾();
			int i = 0;
			while (i < array.Length)
			{
				PlayerData.InventoryKey inventoryKey = array[i];
				if (inventoryKey.blockType == 4373)
				{
					if (global::랾.럓.랾.myPlayerData.GetCount(inventoryKey) >= 1)
					{
						OutgoingMessages.SendSpinJetRaceRouletteMessage();
						return;
					}
					global::랾.럽.랾("Finished Spinning The JetRace Wheel!", false);
					global::랾.럧.랽 = false;
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000A4884 File Offset: 0x000A2A84
		public static void 럃()
		{
			if (!global::랾.럓.랾.ContainsBlock(1922))
			{
				global::랾.럽.람("World Doesn't Contain A Recycler", false);
				global::랾.럧.럧 = false;
				return;
			}
			global::랾.럧.랃 += Time.deltaTime;
			global::랾.럧.랛 += Time.deltaTime;
			if ((double)global::랾.럧.랃 >= 6.5)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Make Sure You're Within Distance To The Recycler");
				defaultInterpolatedStringHandler.AppendFormatted<int>(20 - (int)global::랾.럧.랛);
				defaultInterpolatedStringHandler.AppendLiteral(" SECONDS");
				global::랾.럽.람(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				global::랾.럧.랃 = 0f;
			}
			if (global::랾.럧.랛 < 20f)
			{
				return;
			}
			Vector2i firstMapPointOfBlockType = global::랾.럓.랾.GetFirstMapPointOfBlockType(1922, 0);
			PlayerData.InventoryItemType[] array = new PlayerData.InventoryItemType[5];
			RuntimeHelpers.InitializeArray(array, fieldof(global::랾.럖.랾).FieldHandle);
			PlayerData.InventoryItemType[] source = array;
			foreach (PlayerData.InventoryKey inventoryKey in global::랾.랆.랾())
			{
				short count = global::랾.럓.랾.GetCount(inventoryKey);
				if (source.Contains(inventoryKey.itemType) && global::랾.럧.랊)
				{
					OutgoingMessages.RecycleBlock(inventoryKey, count, firstMapPointOfBlockType);
				}
				else if (inventoryKey.itemType == 4 && global::랾.럧.럓)
				{
					OutgoingMessages.RecycleBlock(inventoryKey, count, firstMapPointOfBlockType);
				}
				else if (inventoryKey.itemType == 5 && global::랾.럧.럟)
				{
					OutgoingMessages.RecycleBlock(inventoryKey, count, firstMapPointOfBlockType);
				}
			}
			global::랾.럽.랾("Items Successfully Recycled!", false);
			global::랾.럧.랛 = 0f;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000A4A04 File Offset: 0x000A2C04
		public static void 랝()
		{
			if (global::랾.럓.랾.worldName != "SECRETBASE")
			{
				return;
			}
			LaboratoryBossMonoBehaviour laboratoryBossMonoBehaviour = global::랾.랆.럎랋();
			if (laboratoryBossMonoBehaviour == null && global::랾.럽.랾() && global::랾.럧.랃)
			{
				SceneLoader.ReloadWorld();
				return;
			}
			if (laboratoryBossMonoBehaviour != null && (!laboratoryBossMonoBehaviour.isHidden || !laboratoryBossMonoBehaviour.isActiveAndEnabled))
			{
				float num = (laboratoryBossMonoBehaviour.transform.position.x > global::랾.럓.랾.currentPlayerPosition.x) ? 1.25f : -1.25f;
				global::랾.럓.랾.ActivateForcedDirectionBounceByAIEnemy(num, 0.01f, 1f);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000A4AA8 File Offset: 0x000A2CA8
		public static void 럾()
		{
			ValueTuple<World.BlockType, Vector2i>[] array = new ValueTuple<World.BlockType, Vector2i>[]
			{
				new ValueTuple<World.BlockType, Vector2i>(global::랾.럓.랾.currentPlayerPositionAboveBlockType, global::랾.럓.랾.currentPlayerAboveMapPoint),
				new ValueTuple<World.BlockType, Vector2i>(global::랾.럓.랾.currentPlayerPositionBlockType, global::랾.럓.랾.currentPlayerMapPoint),
				new ValueTuple<World.BlockType, Vector2i>(global::랾.럓.랾.currentPlayerPositionRightBlockType, global::랾.럓.랾.currentPlayerRightMapPoint),
				new ValueTuple<World.BlockType, Vector2i>(global::랾.럓.랾.currentPlayerPositionLeftBlockType, global::랾.럓.랾.currentPlayerLeftMapPoint),
				new ValueTuple<World.BlockType, Vector2i>(global::랾.럓.랾.currentPlayerPositionBelowBlockType, global::랾.럓.랾.currentPlayerBelowMapPoint)
			};
			foreach (World.BlockType blockType in global::랾.랆.럎)
			{
				foreach (ValueTuple<World.BlockType, Vector2i> valueTuple in array)
				{
					World.BlockType item = valueTuple.Item1;
					Vector2i item2 = valueTuple.Item2;
					if (item == blockType)
					{
						WorldItemBase worldItemBase = global::랾.럦.랾(item2);
						if (worldItemBase != null)
						{
							int itemId;
							if (blockType != 966)
							{
								if (blockType != 1392)
								{
									if (blockType != 2066)
									{
										goto IL_16D;
									}
									LabGiftBoxData labGiftBoxData = worldItemBase as LabGiftBoxData;
									if (labGiftBoxData == null)
									{
										goto IL_16D;
									}
									itemId = labGiftBoxData.itemId;
								}
								else
								{
									NetherGiftBoxData netherGiftBoxData = worldItemBase as NetherGiftBoxData;
									if (netherGiftBoxData == null)
									{
										goto IL_16D;
									}
									itemId = netherGiftBoxData.itemId;
								}
							}
							else
							{
								GiftBoxData giftBoxData = worldItemBase as GiftBoxData;
								if (giftBoxData == null)
								{
									goto IL_16D;
								}
								itemId = giftBoxData.itemId;
							}
							if (!global::랾.럓.랾.giftBoxesAccessed.Contains(itemId))
							{
								OutgoingMessages.SendRequestItemFromGiftBoxMessage(item2);
							}
						}
					}
					IL_16D:;
				}
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000A4C40 File Offset: 0x000A2E40
		public static void 럀()
		{
			ConfigFile.aimbotPVEToggle = true;
			ConfigFile.autoGiftBoxPickupToggle = true;
			ConfigFile.extendedPickUpToggle = true;
			ConfigFile.godModeToggle = true;
			global::랾.랆.랂();
			bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.IsLoading();
			bool flag2 = global::랾.럽.랾();
			World world = global::랾.럓.랾;
			string a = ((world != null) ? world.worldName : null) ?? string.Empty;
			if (flag2)
			{
				global::랾.랆.람.람(Time.deltaTime);
				global::랾.랆.랾.럎(Time.deltaTime);
			}
			else
			{
				global::랾.랆.랣();
			}
			if (global::랾.랆.럎량())
			{
				global::랾.랆.람.랋();
				global::랾.랆.랾.랋();
			}
			if (flag2 && !string.Equals(a, "NETHERWORLD", StringComparison.OrdinalIgnoreCase) && !flag)
			{
				if (global::랾.랆.럎럯() == 1)
				{
					global::랾.랆.럂();
					return;
				}
				global::랾.랆.랣();
				if (global::랾.랆.람.럒())
				{
					string text;
					bool flag3;
					if (global::랾.랆.랾(out text, out flag3))
					{
						if (flag3)
						{
							global::랾.랆.럎량();
							global::랾.럽.랾("Using Nether scroll...", false);
							global::랾.럽.람("Warning: This is still a work in progress. I only released this version to fix bugs, but it may work fine with a jetpack equipped.", false);
						}
						else if (!string.IsNullOrWhiteSpace(text))
						{
							global::랾.럽.랾(text, false);
						}
					}
					else
					{
						global::랾.럽.랾("No Nether scroll found.", false);
					}
					global::랾.랆.람.랋();
				}
				return;
			}
			else
			{
				if (global::랾.럽.럎() && !flag && global::랾.랆.럎.럒())
				{
					global::랾.럽.랾(global::랾.랆.럎랱(), false);
					global::랾.랆.럎.랋();
					return;
				}
				if (!flag2 || global::랾.럓.랾 == null || global::랾.럓.랾 == null || ControllerHelper.worldController == null)
				{
					return;
				}
				if (!string.Equals(a, "NETHERWORLD", StringComparison.OrdinalIgnoreCase))
				{
					global::랾.랆.랣();
					return;
				}
				global::랾.랆.랣();
				global::랾.랆.럒.람(Time.deltaTime);
				if (!global::랾.랆.럒.럒())
				{
					global::랾.랆.랾 = "Inside Nether. Waiting for the next teleport.";
					return;
				}
				bool flag4 = false;
				try
				{
					World world2 = global::랾.럓.랾;
					List<CollectableData> list = (world2 != null) ? world2.collectables : null;
					if (list != null)
					{
						foreach (CollectableData collectableData in list)
						{
							if (collectableData != null && collectableData.blockType == 1420)
							{
								flag4 = true;
								break;
							}
						}
					}
				}
				catch
				{
				}
				Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
				bool jumpButtonDown = false;
				double totalSeconds = (DateTime.UtcNow - global::랾.럧.랾).TotalSeconds;
				if ((global::랾.럓.랾.GetBlockType(currentPlayerMapPoint) == 1392 || global::랾.럓.랾.GetBlockType(currentPlayerMapPoint) == 1400) && totalSeconds > 0.2)
				{
					jumpButtonDown = true;
				}
				else if (totalSeconds > 0.2)
				{
					List<CollectableData>.Enumerator enumerator = global::랾.럓.랾.collectables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.mapPoint == currentPlayerMapPoint)
						{
							jumpButtonDown = true;
							break;
						}
					}
				}
				global::랾.럓.랾.jumpButtonDown = jumpButtonDown;
				bool flag5 = global::랾.랆.럭(currentPlayerMapPoint);
				if (flag4)
				{
					if (!flag5)
					{
						global::랾.랆.랾 = "Inside Nether. No reachable targets found yet.";
					}
					global::랾.랆.럒.랋();
					return;
				}
				if (flag5)
				{
					global::랾.랆.럒.랋();
					return;
				}
				if (global::랾.럓.랾.GetBlockType(currentPlayerMapPoint) == 1419)
				{
					OutgoingMessages.SendRequestNetherWorldExitMessage(currentPlayerMapPoint);
					global::랾.럽.랾("Exiting Nether...", false);
					global::랾.랆.랾 = "The Nether key is gone and nothing else is left to do. Leaving the Nether.";
				}
				else
				{
					global::랾.랆.랾(1419, currentPlayerMapPoint);
					global::랾.랆.랾 = "The Nether key is gone and nothing else is left to do. Moving to the exit.";
				}
				global::랾.랆.럒.랋();
				return;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000A4FA4 File Offset: 0x000A31A4
		private static void 랂()
		{
			ConfigFile.autoNetherEntryDelaySeconds = Math.Clamp(ConfigFile.autoNetherEntryDelaySeconds, 0.5f, 15f);
			ConfigFile.autoNetherTeleportDelaySeconds = Math.Clamp(ConfigFile.autoNetherTeleportDelaySeconds, 0.25f, 15f);
			ConfigFile.autoNetherPortalStepDelaySeconds = Math.Clamp(ConfigFile.autoNetherPortalStepDelaySeconds, 0.05f, 3f);
			global::랾.랆.람.랾(ConfigFile.autoNetherEntryDelaySeconds);
			global::랾.랆.럒.랾(ConfigFile.autoNetherTeleportDelaySeconds);
			global::랾.랆.랾.랾(ConfigFile.autoNetherPortalStepDelaySeconds);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000A502C File Offset: 0x000A322C
		public static string 래()
		{
			if (!global::랾.럧.럷)
			{
				if (!string.IsNullOrWhiteSpace(global::랾.랆.랾))
				{
					return global::랾.랆.랾;
				}
				return "Idle";
			}
			else
			{
				bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.IsLoading();
				bool flag2 = global::랾.럽.랾();
				World world = global::랾.럓.랾;
				string a = ((world != null) ? world.worldName : null) ?? string.Empty;
				if (flag)
				{
					return "Loading";
				}
				if (!flag2)
				{
					if (global::랾.랆.럎럯() != 1 || !global::랾.랆.럎랫())
					{
						return "Waiting for a world";
					}
					return "Waiting to enter " + ConfigFile.autoNetherSelectedPortalWorldName;
				}
				else if (string.Equals(a, "NETHERWORLD", StringComparison.OrdinalIgnoreCase))
				{
					if (!string.IsNullOrWhiteSpace(global::랾.랆.랾) && !string.Equals(global::랾.랆.랾, "Idle", StringComparison.OrdinalIgnoreCase))
					{
						return global::랾.랆.랾;
					}
					if (!global::랾.랆.럒.럒())
					{
						return "Inside Nether. Waiting for the next teleport.";
					}
					return "Inside Nether. Finding the next target.";
				}
				else
				{
					if (!string.IsNullOrWhiteSpace(global::랾.랆.랾) && !string.Equals(global::랾.랆.랾, "Idle", StringComparison.OrdinalIgnoreCase))
					{
						return global::랾.랆.랾;
					}
					if (global::랾.랆.럎럯() != 1)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Ready to use a Level ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.럎럭());
						defaultInterpolatedStringHandler.AppendLiteral(" scroll");
						return defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (!global::랾.랆.럎랫())
					{
						return "Pick a red portal first";
					}
					if (!global::랾.랆.럎랬())
					{
						return "Join " + ConfigFile.autoNetherSelectedPortalWorldName + " to use the saved red portal";
					}
					return "Ready to use the selected red portal";
				}
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00040296 File Offset: 0x0003E496
		public static string 랸()
		{
			return global::랾.랆.래();
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0004029D File Offset: 0x0003E49D
		public static string 랈()
		{
			if (global::랾.랆.럎럯() != 1)
			{
				return "Scroll";
			}
			return "Selected Red Portal";
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000402B2 File Offset: 0x0003E4B2
		public static string 랎()
		{
			if (global::랾.랆.럎럯() != 1)
			{
				return global::랾.랆.람(global::랾.랆.럎럭()) + " scroll from inventory";
			}
			return global::랾.랆.럹();
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000A51A0 File Offset: 0x000A33A0
		public static string 럹()
		{
			if (!global::랾.랆.럎랫())
			{
				return "No red portal selected";
			}
			Vector2i vector2i = global::랾.랆.럎럍();
			string text = string.IsNullOrWhiteSpace(ConfigFile.autoNetherSelectedPortalWorldName) ? "Unknown World" : ConfigFile.autoNetherSelectedPortalWorldName.Trim();
			Vector2i vector2i2;
			NetherGroupPortalData netherGroupPortalData;
			string text2;
			if (global::랾.랆.랾(out vector2i2, out netherGroupPortalData, out text2))
			{
				return global::랾.랆.랾(text, vector2i, netherGroupPortalData);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000A524C File Offset: 0x000A344C
		public static string 럿()
		{
			if (!global::랾.랆.럎랫())
			{
				return "Pick a red portal in the world, or stand on one and save it from here.";
			}
			if (global::랾.럓.랾 == null || !global::랾.랆.럎랬())
			{
				return "Saved for " + ConfigFile.autoNetherSelectedPortalWorldName + ". Join that world when you want Auto Nether to use it.";
			}
			Vector2i vector2i;
			NetherGroupPortalData netherGroupPortalData;
			string result;
			if (!global::랾.랆.랾(out vector2i, out netherGroupPortalData, out result))
			{
				return result;
			}
			if (netherGroupPortalData.level != global::랾.랆.럎럭())
			{
				return "This portal is " + global::랾.랆.람(netherGroupPortalData.level) + ". Change Nether Level to match it, or pick another portal.";
			}
			if (netherGroupPortalData.isLocked && !global::랾.랆.럎란())
			{
				return "This portal is locked and the current character does not have access.";
			}
			return "This portal is " + global::랾.랆.람(netherGroupPortalData.level) + " and ready to use.";
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000402D6 File Offset: 0x0003E4D6
		public static bool 랩()
		{
			return global::랾.랆.럯;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000402DD File Offset: 0x0003E4DD
		public static void 랉(bool A_0)
		{
			global::랾.랆.럯 = A_0;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000A52F0 File Offset: 0x000A34F0
		public static bool 램()
		{
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return false;
			}
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			string text;
			return global::랾.랆.랾(currentPlayerMapPoint, out text) || global::랾.랆.랾(new Vector2i(currentPlayerMapPoint.x, currentPlayerMapPoint.y - 1), out text);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000402E5 File Offset: 0x0003E4E5
		public static void 랥()
		{
			ConfigFile.autoNetherSelectedPortalWorldName = string.Empty;
			ConfigFile.autoNetherSelectedPortalX = -1;
			ConfigFile.autoNetherSelectedPortalY = -1;
			global::랾.랆.럯 = false;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000A534C File Offset: 0x000A354C
		public static bool 랕()
		{
			if (!global::랾.랆.럯)
			{
				return false;
			}
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || Camera.main == null)
			{
				return false;
			}
			if (global::랾.랆.랖())
			{
				return false;
			}
			if (global::랾.랅.럎(1))
			{
				global::랾.랆.럯 = false;
				global::랾.럽.럒("Auto Nether portal picking cancelled.", true);
				return true;
			}
			if (!global::랾.랅.럎(0))
			{
				return false;
			}
			Vector2i vector2i;
			if (!global::랾.랆.랾(out vector2i))
			{
				return false;
			}
			string text;
			if (global::랾.랆.랾(vector2i, out text))
			{
				global::랾.랆.럯 = false;
				global::랾.럽.럒("Auto Nether portal set to " + global::랾.랆.럹() + ".", true);
			}
			else
			{
				global::랾.럽.럎(text, false);
			}
			return true;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00040303 File Offset: 0x0003E503
		public static bool 럌()
		{
			return global::랾.랆.럯 || (global::랾.럧.럷 && global::랾.랆.럎랫());
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000A53EC File Offset: 0x000A35EC
		public static void 랼()
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
			Vector2i vector2i;
			NetherGroupPortalData netherGroupPortalData;
			string text;
			if (global::랾.랆.럎랫() && global::랾.랆.럎랬() && global::랾.랆.랾(out vector2i, out netherGroupPortalData, out text))
			{
				string text2 = "RED PORTAL " + global::랾.랆.람(netherGroupPortalData.level).ToUpperInvariant();
				Color color = (global::랾.랆.럎럯() == 1) ? new Color(0.33f, 0.08f, 0.08f, 0.22f) : new Color(0.1f, 0.24f, 0.45f, 0.18f);
				Color color2 = (global::랾.랆.럎럯() == 1) ? new Color(1f, 0.42f, 0.3f, 0.95f) : new Color(0.4f, 0.8f, 1f, 0.95f);
				global::랾.랆.랾(main, vector2i, text2, color, color2);
			}
			Vector2i vector2i2;
			if (!global::랾.랆.럯 || !global::랾.랆.랾(out vector2i2))
			{
				return;
			}
			NetherGroupPortalData netherGroupPortalData2;
			bool flag = global::랾.랆.랾(vector2i2, out netherGroupPortalData2);
			string text3 = flag ? ("CLICK TO SAVE " + global::랾.랆.람(netherGroupPortalData2.level).ToUpperInvariant()) : "NOT A RED PORTAL";
			global::랾.랆.랾(main, vector2i2, text3, flag ? new Color(0.36f, 0.08f, 0.08f, 0.22f) : new Color(0.2f, 0.2f, 0.2f, 0.14f), flag ? new Color(1f, 0.52f, 0.35f, 0.95f) : new Color(0.7f, 0.7f, 0.7f, 0.85f));
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0004031C File Offset: 0x0003E51C
		private static void 랣()
		{
			global::랾.랆.럭 = false;
			global::랾.랆.랞 = -1f;
			global::랾.랆.럚 = -1f;
			global::랾.랆.럳 = -1f;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000A5598 File Offset: 0x000A3798
		private static void 럂()
		{
			if (global::랾.럓.랾 == null || global::랾.럓.랾 == null || ControllerHelper.worldController == null)
			{
				return;
			}
			if (!global::랾.랆.랾.럒())
			{
				if (global::랾.럧.럯)
				{
					global::랾.랆.랾 = "Moving to the selected red portal.";
					return;
				}
				if (global::랾.랆.럭)
				{
					global::랾.랆.랾 = "Waiting for the red portal to activate.";
				}
				return;
			}
			else
			{
				Vector2i vector2i;
				NetherGroupPortalData netherGroupPortalData;
				string text;
				if (!global::랾.랆.랾(out vector2i, out netherGroupPortalData, out text))
				{
					global::랾.랆.랾 = text;
					return;
				}
				int num = global::랾.랆.럎럭();
				if (netherGroupPortalData.level != num)
				{
					global::랾.랆.랾 = "Selected red portal is " + global::랾.랆.람(netherGroupPortalData.level) + ". Change Nether Level to match it, or pick another portal.";
					return;
				}
				if (netherGroupPortalData.isLocked && !global::랾.랆.럎란())
				{
					global::랾.랆.랾 = "Selected red portal is locked and you do not have access.";
					return;
				}
				Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
				string str = global::랾.랆.랾(netherGroupPortalData, vector2i);
				if (global::랾.럧.럯)
				{
					global::랾.랆.럳 = -1f;
					global::랾.랆.랾 = "Moving to " + str + ".";
					return;
				}
				if (currentPlayerMapPoint != vector2i)
				{
					if (global::랾.랆.랾(global::랾.랛.랾(currentPlayerMapPoint, vector2i, global::랾.랛.럎()), "Teleporting to selected red portal"))
					{
						global::랾.랆.랾 = "Moving to " + str + ".";
						global::랾.랆.랾.랋();
					}
					else
					{
						global::랾.랆.랾 = "Could not reach " + str + ".";
					}
					global::랾.랆.럳 = -1f;
					return;
				}
				if (global::랾.랆.럎량())
				{
					global::랾.랆.랾 = "Confirmed the popup for " + str + ".";
					global::랾.랆.랾.랋();
					return;
				}
				if (!netherGroupPortalData.isActivated)
				{
					global::랾.랆.럳 = -1f;
					if (global::랾.랆.럭 && Time.realtimeSinceStartup - global::랾.랆.랞 < 2.5f)
					{
						global::랾.랆.랾 = "Waiting for " + str + " to activate.";
						return;
					}
					OutgoingMessages.SendRequestActivateNetherGroupPortalMessage(vector2i);
					global::랾.랆.럫 = Time.realtimeSinceStartup + 1.5f;
					global::랾.랆.럭 = true;
					global::랾.랆.랞 = Time.realtimeSinceStartup;
					global::랾.랆.랾.랋();
					global::랾.랆.랾 = "Activating " + str + "...";
					return;
				}
				else
				{
					global::랾.랆.럭 = false;
					global::랾.랆.랞 = -1f;
					if (global::랾.랆.럳 < 0f)
					{
						global::랾.랆.럳 = Time.realtimeSinceStartup;
					}
					if (global::랾.랆.럎럇())
					{
						global::랾.랆.랣();
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Portal looked active but entry stalled for over ");
						defaultInterpolatedStringHandler.AppendFormatted<float>(15f, "0");
						defaultInterpolatedStringHandler.AppendLiteral("s. Reloading world.");
						global::랾.랆.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
						global::랾.럽.럎(global::랾.랆.랾, false);
						SceneLoader.ReloadWorld();
						return;
					}
					if (global::랾.랆.럚 > 0f && Time.realtimeSinceStartup - global::랾.랆.럚 < 0.75f)
					{
						global::랾.랆.랾 = "Waiting to enter " + str + ".";
						return;
					}
					WorldButtonsUI worldButtonsUI = global::랾.랆.럎랓();
					if (worldButtonsUI != null)
					{
						worldButtonsUI.PressNearestButton();
						global::랾.랆.럚 = Time.realtimeSinceStartup;
						global::랾.랆.랾.랋();
						global::랾.랆.랾 = "Entering " + str + "...";
						return;
					}
					string text2;
					if (!global::랾.랆.랾(netherGroupPortalData, out text2))
					{
						global::랾.랆.랾 = text2;
						return;
					}
					global::랾.랆.럚 = Time.realtimeSinceStartup;
					global::랾.랆.랾.랋();
					global::랾.랆.랾 = "Entering " + str + "...";
					return;
				}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000A58E4 File Offset: 0x000A3AE4
		private static bool 럭(Vector2i A_0)
		{
			랆.랉 랉;
			랉.랾 = A_0;
			global::랾.럧.랾.Clear();
			if (global::랾.랆.랱(랉.랾))
			{
				global::랾.랆.랫 = false;
				global::랾.랆.럍 = false;
				return true;
			}
			랉.랾 = new List<ValueTuple<Vector2i, List<랛.랾>, 랆.럎>>();
			if (global::랾.럧.럣)
			{
				WorldController worldController = ControllerHelper.worldController;
				if (((worldController != null) ? worldController.aiEnemyMonoBehaviours : null) != null)
				{
					List<ValueTuple<int, Vector2i>> list = new List<ValueTuple<int, Vector2i>>();
					foreach (KeyValuePair<int, AIEnemyMonoBehaviourBase> keyValuePair in ControllerHelper.worldController.aiEnemyMonoBehaviours)
					{
						AIEnemyMonoBehaviourBase value = keyValuePair.value;
						if (!(value == null) && Array.IndexOf<AIEnemyType>(global::랾.랳.랾, value.aiBase.GetEnemyType()) < 0)
						{
							Vector2i vector2i;
							vector2i..ctor((int)value.aiBase.mapPointX, (int)value.aiBase.mapPointY);
							if (global::랾.랛.랾(vector2i.x, vector2i.y, 랉.랾, false, false))
							{
								list.Add(new ValueTuple<int, Vector2i>(global::랾.랆.랋(랉.랾, vector2i), vector2i));
							}
						}
					}
					list.Sort(new Comparison<ValueTuple<int, Vector2i>>(global::랾.랆.랋.랾.랾));
					int num = Math.Min(list.Count, 10);
					for (int i = 0; i < num; i++)
					{
						Vector2i item = list[i].Item2;
						List<랛.랾> list2 = global::랾.랛.랾(랉.랾, item, global::랾.랛.럎());
						if (list2 != null && list2.Count > 0)
						{
							랉.랾.Add(new ValueTuple<Vector2i, List<랛.랾>, 랆.럎>(item, list2, global::랾.랆.럎.랾));
							global::랾.럧.랾.Add(item);
						}
					}
				}
			}
			if (ConfigFile.autoNetherTargetTreasure)
			{
				List<ValueTuple<int, Vector2i>> list3 = new List<ValueTuple<int, Vector2i>>();
				for (int j = 0; j < global::랾.럓.랾.worldSizeX; j++)
				{
					for (int k = 0; k < global::랾.럓.랾.worldSizeY; k++)
					{
						if (global::랾.럓.랾.GetBlockType(j, k) == 1400)
						{
							Vector2i vector2i2;
							vector2i2..ctor(j, k);
							if (global::랾.랛.랾(vector2i2.x, vector2i2.y, 랉.랾, false, false))
							{
								list3.Add(new ValueTuple<int, Vector2i>(global::랾.랆.랋(랉.랾, vector2i2), vector2i2));
							}
						}
					}
				}
				list3.Sort(new Comparison<ValueTuple<int, Vector2i>>(global::랾.랆.랋.랾.럎));
				int num2 = Math.Min(list3.Count, 10);
				for (int l = 0; l < num2; l++)
				{
					global::랾.랆.랾(list3[l].Item2, global::랾.랆.럎.럎, ref 랉);
				}
			}
			if (ConfigFile.autoNetherTargetGiftBoxes)
			{
				List<ValueTuple<int, Vector2i>> list4 = new List<ValueTuple<int, Vector2i>>();
				for (int m = 0; m < global::랾.럓.랾.worldSizeX; m++)
				{
					for (int n = 0; n < global::랾.럓.랾.worldSizeY; n++)
					{
						Vector2i vector2i3;
						vector2i3..ctor(m, n);
						WorldItemBase worldItemBase;
						if (global::랾.랆.랾(vector2i3, out worldItemBase) && global::랾.랛.랾(vector2i3.x, vector2i3.y, 랉.랾, false, true))
						{
							list4.Add(new ValueTuple<int, Vector2i>(global::랾.랆.랋(랉.랾, vector2i3), vector2i3));
						}
					}
				}
				list4.Sort(new Comparison<ValueTuple<int, Vector2i>>(global::랾.랆.랋.랾.람));
				int num3 = Math.Min(list4.Count, 10);
				for (int num4 = 0; num4 < num3; num4++)
				{
					global::랾.랆.랾(list4[num4].Item2, global::랾.랆.럎.람, ref 랉);
				}
			}
			if (global::랾.럓.랾 != null)
			{
				World world = global::랾.럓.랾;
				if (((world != null) ? world.collectables : null) != null)
				{
					foreach (CollectableData collectableData in global::랾.럓.랾.collectables)
					{
						if (collectableData.blockType == 1420)
						{
							Vector2i mapPoint = collectableData.mapPoint;
							if (global::랾.랛.랾(mapPoint.x, mapPoint.y, mapPoint, false, false) && !ConfigData.IsCollectableBlockedByColliderBlock(global::랾.럓.랾, mapPoint))
							{
								global::랾.랆.랾(mapPoint, global::랾.랆.럎.럒, ref 랉);
							}
						}
					}
				}
			}
			if (랉.랾.Count <= 0)
			{
				global::랾.랆.랫 = true;
				global::랾.랆.럍 = false;
				global::랾.랆.랾 = "Inside Nether. No reachable targets are left.";
				return false;
			}
			ValueTuple<Vector2i, List<랛.랾>, 랆.럎> valueTuple = 랉.랾.OrderBy(new Func<ValueTuple<Vector2i, List<랛.랾>, 랆.럎>, int>(global::랾.랆.랋.랾.랾)).First<ValueTuple<Vector2i, List<랛.랾>, 랆.럎>>();
			if (랉.랾 == valueTuple.Item1)
			{
				if (valueTuple.Item3 == global::랾.랆.럎.람 && global::랾.랆.랱(랉.랾))
				{
					return true;
				}
				string text;
				switch (valueTuple.Item3)
				{
				case global::랾.랆.럎.랾:
					text = "Already at an enemy target.";
					goto IL_4E2;
				case global::랾.랆.럎.럎:
					text = "Already at a treasure chest target.";
					goto IL_4E2;
				case global::랾.랆.럎.럒:
					text = "Already at the Nether key.";
					goto IL_4E2;
				}
				text = "Already at the current target.";
				IL_4E2:
				global::랾.랆.랾 = text;
				global::랾.랆.랫 = false;
				global::랾.랆.럍 = false;
				return true;
			}
			else
			{
				global::랾.럧.럎 = valueTuple.Item1;
				List<랛.랾> item2 = valueTuple.Item2;
				string text;
				switch (valueTuple.Item3)
				{
				case global::랾.랆.럎.랾:
					text = "Teleporting to Enemy";
					break;
				case global::랾.랆.럎.럎:
					text = "Teleporting to Treasure Chest";
					break;
				case global::랾.랆.럎.람:
					text = "Teleporting to Gift Box";
					break;
				case global::랾.랆.럎.럒:
					text = "Teleporting to Nether Key";
					break;
				default:
					text = null;
					break;
				}
				if (!global::랾.랆.랾(item2, text))
				{
					global::랾.랆.랫 = true;
					global::랾.랆.럍 = false;
					global::랾.랆.랾 = "Inside Nether. Failed to start the next teleport.";
					return false;
				}
				if (valueTuple.Item3 == global::랾.랆.럎.랾)
				{
					global::랾.럧.랾.Remove(valueTuple.Item1);
					global::랾.랆.럍 = true;
				}
				else
				{
					global::랾.랆.럍 = false;
				}
				global::랾.랆.랫 = false;
				switch (valueTuple.Item3)
				{
				case global::랾.랆.럎.랾:
					text = "Inside Nether. Moving to a reachable enemy.";
					break;
				case global::랾.랆.럎.럎:
					text = "Inside Nether. Moving to a reachable treasure chest.";
					break;
				case global::랾.랆.럎.람:
					text = "Inside Nether. Moving to a gift box that still has loot.";
					break;
				case global::랾.랆.럎.럒:
					text = "Inside Nether. Moving to the Nether key.";
					break;
				default:
					text = "Inside Nether. Moving to the next target.";
					break;
				}
				global::랾.랆.랾 = text;
				global::랾.럧.랄 = 0f;
				return true;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000A5EF4 File Offset: 0x000A40F4
		private static bool 랱(Vector2i A_0)
		{
			if (!ConfigFile.autoNetherTargetGiftBoxes || global::랾.럓.랾 == null)
			{
				return false;
			}
			foreach (Vector2i vector2i in new Vector2i[]
			{
				global::랾.럓.랾.currentPlayerAboveMapPoint,
				global::랾.럓.랾.currentPlayerMapPoint,
				global::랾.럓.랾.currentPlayerRightMapPoint,
				global::랾.럓.랾.currentPlayerLeftMapPoint,
				global::랾.럓.랾.currentPlayerBelowMapPoint
			})
			{
				WorldItemBase worldItemBase;
				if (global::랾.랆.랾(vector2i, out worldItemBase))
				{
					OutgoingMessages.SendRequestItemFromGiftBoxMessage(vector2i);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Inside Nether. Collecting the gift box at (");
					defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.x);
					defaultInterpolatedStringHandler.AppendLiteral(", ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.y);
					defaultInterpolatedStringHandler.AppendLiteral(").");
					global::랾.랆.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000A5FEC File Offset: 0x000A41EC
		private static bool 랾(Vector2i A_0, out WorldItemBase A_1)
		{
			A_1 = null;
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return false;
			}
			if (!ConfigData.IsBlockGiftBox(global::랾.럓.랾.GetBlockType(A_0)))
			{
				return false;
			}
			A_1 = global::랾.럓.랾.GetWorldItemData(A_0);
			return A_1 != null && global::랾.랆.랾(A_1) && !global::랾.랆.럎(A_1.itemId);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000A6054 File Offset: 0x000A4254
		private static bool 랾(WorldItemBase A_0)
		{
			bool result;
			try
			{
				BSONObject bsonobject = (A_0 != null) ? A_0.GetAsBSON() : null;
				if (bsonobject == null)
				{
					result = false;
				}
				else
				{
					int num = 0;
					string text = string.Empty;
					try
					{
						if (bsonobject.ContainsKey("itemAmount"))
						{
							num = bsonobject["itemAmount"].int32Value;
						}
					}
					catch
					{
						num = 0;
					}
					try
					{
						if (bsonobject.ContainsKey("blockType"))
						{
							text = (bsonobject["blockType"].stringValue ?? string.Empty);
						}
					}
					catch
					{
						text = string.Empty;
					}
					result = (num > 0 && !string.IsNullOrWhiteSpace(text) && !string.Equals(text, "0", StringComparison.OrdinalIgnoreCase) && !string.Equals(text, "None", StringComparison.OrdinalIgnoreCase));
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000A613C File Offset: 0x000A433C
		private static bool 럎(int A_0)
		{
			if (A_0 <= 0)
			{
				return false;
			}
			try
			{
				PlayerData playerData = global::랾.럓.랾;
				if (((playerData != null) ? playerData.giftBoxesAccessed : null) == null || global::랾.럓.랾.giftBoxesAccessed.Count <= 0)
				{
					return false;
				}
				for (int i = 0; i < global::랾.럓.랾.giftBoxesAccessed.Count; i++)
				{
					if (global::랾.럓.랾.giftBoxesAccessed[i] == A_0)
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

		// Token: 0x0600079F RID: 1951 RVA: 0x000A61C4 File Offset: 0x000A43C4
		public static void 럱()
		{
			ConfigFile.antiBounceToggle = true;
			bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.IsLoading();
			bool flag2 = global::랾.럽.랾();
			World world = global::랾.럓.랾;
			string a = ((world != null) ? world.worldName : null) ?? string.Empty;
			if (flag2 && string.Equals(a, "NETHERWORLD", StringComparison.OrdinalIgnoreCase) && global::랾.럓.랾 != null && global::랾.럓.랾 != null && ControllerHelper.worldController != null && global::랾.럓.랾.ContainsBlock(303) && !flag)
			{
				global::랾.랆.랧();
			}
			else if (!flag)
			{
				if (global::랾.랆.럎량())
				{
					global::랾.럧.럷 = 0f;
				}
				global::랾.럧.럷 += Time.deltaTime;
				if (global::랾.럧.럷 >= 5f)
				{
					if (global::랾.럽.랾())
					{
						if (global::랾.랆.럎러())
						{
							global::랾.랆.럎량();
							global::랾.럽.랾("Using Nether scroll...", false);
						}
						else
						{
							global::랾.럽.랾("No Nether scroll found.", false);
						}
					}
					else if (global::랾.럽.럎())
					{
						global::랾.럽.랾("Enter a world to start Auto Nether Boss...", false);
					}
					global::랾.럧.럷 = 0f;
				}
			}
			if (global::랾.럧.랡 >= 100f)
			{
				SceneLoader.ReloadWorld();
				global::랾.럧.랖++;
				global::랾.럧.랡 = 0f;
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000A6308 File Offset: 0x000A4508
		private static void 랧()
		{
			if (!(global::랾.럓.랾 == null) && global::랾.럓.랾 != null)
			{
				WorldController worldController = ControllerHelper.worldController;
				if (((worldController != null) ? worldController.world : null) != null)
				{
					global::랾.럧.랡 += Time.deltaTime;
					Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
					bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.IsLoading();
					NetherBossWraithMonoBehaviour netherBossWraithMonoBehaviour = global::랾.랆.럎랉();
					if (netherBossWraithMonoBehaviour != null && netherBossWraithMonoBehaviour.aiBase != null)
					{
						global::랾.럧.랪 += Time.deltaTime;
						if (global::랾.럧.랪 >= 5f && !global::랾.럧.럯)
						{
							global::랾.랆.럎(currentPlayerMapPoint, netherBossWraithMonoBehaviour.aiBase.GetRoundedMapPoint(), "Teleporting to Nether Boss");
							global::랾.럧.랪 = 0f;
						}
						return;
					}
					for (int i = 0; i < global::랾.럓.랾.worldSizeX; i++)
					{
						for (int j = 0; j < global::랾.럓.랾.worldSizeY; j++)
						{
							if (ConfigData.IsBlockGiftBox(global::랾.럓.랾.GetBlockType(i, j)))
							{
								WorldItemBase worldItemData = ControllerHelper.worldController.world.GetWorldItemData(i, j);
								if (worldItemData != null)
								{
									BSONObject asBSON = worldItemData.GetAsBSON();
									if (!(asBSON == null) && asBSON.ContainsKey("takeAmount") && asBSON["takeAmount"].int32Value == 1)
									{
										Vector2i vector2i;
										vector2i..ctor(i, j);
										if (global::랾.랛.랾(i, j, currentPlayerMapPoint, false, true))
										{
											global::랾.럧.럦 += Time.deltaTime;
											if (global::랾.럧.럦 >= 1f && !global::랾.럧.럯)
											{
												global::랾.랆.럎(currentPlayerMapPoint, vector2i, "Teleporting to Gift Box");
												global::랾.럧.럦 = 0f;
												global::랾.럧.랅 = 0f;
											}
										}
										if (currentPlayerMapPoint == vector2i)
										{
											global::랾.럧.랽 += Time.deltaTime;
											if (global::랾.럧.랽 >= 1f && !flag)
											{
												global::랾.랆.럾();
												global::랾.럧.럝++;
												string text = "autonether";
												DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 3);
												defaultInterpolatedStringHandler.AppendLiteral("Nether Boss Killed | Time: ");
												defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.럧.랡, "F1");
												defaultInterpolatedStringHandler.AppendLiteral("s | Count: ");
												defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럝);
												defaultInterpolatedStringHandler.AppendLiteral(" | Disconnects: ");
												defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.랖);
												global::랾.럕.랾(text, defaultInterpolatedStringHandler.ToStringAndClear());
												SceneLoader.ReloadWorld();
												global::랾.럧.랽 = 0f;
											}
										}
										return;
									}
								}
							}
						}
					}
					return;
				}
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000A6590 File Offset: 0x000A4790
		public static void 럁()
		{
			if (global::랾.럓.랾.worldName != "TUTORIAL2")
			{
				return;
			}
			if (global::랾.럓.랾.tutorialState != 1)
			{
				Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
				Vector2i vector2i;
				vector2i..ctor(46, 45);
				if (global::랾.랛.랾(vector2i.x, vector2i.y, currentPlayerMapPoint, false, false) && currentPlayerMapPoint != vector2i)
				{
					global::랾.랆.랾(currentPlayerMapPoint, vector2i, "Teleporting to tutorial exit");
				}
				if (global::랾.럓.랾.gems > 250 && global::랾.럓.랾.GetCollectablesCount() == 0)
				{
					OutgoingMessages.BuyItemPack("BasicClothes");
					OutgoingMessages.SendTutorialStateMessage(7);
					OutgoingMessages.LeaveWorld();
					OutgoingMessages.GetDailyQuest(1);
					OutgoingMessages.SendWelcomeGiftRequest();
					OutgoingMessages.SendBuyInventorySlots();
					OutgoingMessages.SendClaimAchievementReward(6, 1);
					OutgoingMessages.SendClaimAchievementReward(2, 1);
				}
				return;
			}
			CharacterCreationPopupUI characterCreationPopupUI = global::랾.랆.럎럐();
			if (characterCreationPopupUI == null)
			{
				return;
			}
			characterCreationPopupUI.OnDonePressed();
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000A6664 File Offset: 0x000A4864
		public static void 럮()
		{
			global::랾.럧.럚 += Time.deltaTime;
			if (!global::랾.럽.랾() || global::랾.럧.럚 < 0.5f)
			{
				return;
			}
			string worldName = global::랾.럓.랾.worldName;
			global::랾.랆.랭();
			int num = Array.IndexOf<string>(global::랾.랆.랾, worldName);
			if (num >= 0 && num < global::랾.랆.랾.Length - 1)
			{
				SceneLoader.CheckIfWeCanGoFromWorldToWorld(global::랾.랆.랾[num + 1], E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), null, false, null);
			}
			else if (num == global::랾.랆.랾.Length - 1)
			{
				global::랾.럽.람("Scan Complete!");
				global::랾.럧.랖 = false;
				SceneLoader.CheckIfWeCanGoFromWorldToWorld("PIXELSTATION", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), null, false, null);
			}
			else
			{
				SceneLoader.CheckIfWeCanGoFromWorldToWorld(global::랾.랆.랾[0], E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), null, false, null);
			}
			global::랾.럧.럚 = 0f;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000A6728 File Offset: 0x000A4928
		public static void 랭()
		{
			DateTime lastActivatedTime = global::랾.럓.랾.lockWorldDataHelper.GetLastActivatedTime();
			double totalMinutes = (DateTime.UtcNow - lastActivatedTime).TotalMinutes;
			string playerWhoOwnsLockName = global::랾.럓.랾.lockWorldDataHelper.GetPlayerWhoOwnsLockName();
			if (totalMinutes <= 30.0)
			{
				global::랾.럽.람(playerWhoOwnsLockName + " Is Online, Be Weary!");
				return;
			}
			if (totalMinutes <= 120.0)
			{
				global::랾.럽.람(playerWhoOwnsLockName + " Is Possibly Online, Be Weary!");
				return;
			}
			global::랾.럽.람(playerWhoOwnsLockName + " Is Offline.");
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000A67B4 File Offset: 0x000A49B4
		public static bool 랾(out string A_0)
		{
			A_0 = null;
			if (!global::랾.럽.랾() || global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				A_0 = "Join a world first.";
				return false;
			}
			global::랾.랆.럯(true);
			if (global::랾.랆.랫 + global::랾.랆.럍 <= 0)
			{
				A_0 = "Nothing is left to clear after skipping spawn, locks, and storage.";
				global::랾.랆.랾 = global::랾.랆.럒.럒;
				global::랾.랆.람 = (global::랾.럓.랾.worldName ?? string.Empty);
				global::랾.랆.랹();
				return false;
			}
			global::랾.랆.람 = (global::랾.럓.랾.worldName ?? string.Empty);
			global::랾.랆.랬 = global::랾.랆.랫;
			global::랾.랆.란 = global::랾.랆.럍;
			global::랾.랆.럽 = 0f;
			global::랾.랆.럝 = 0f;
			global::랾.랆.럕 = 0f;
			global::랾.랆.랾 = ((global::랾.랆.랫 > 0) ? global::랾.랆.럒.럎 : global::랾.랆.럒.람);
			global::랾.랆.랹();
			global::랾.랆.럼 = global::랾.랆.람;
			global::랾.랆.랋 = global::랾.랆.람;
			global::랾.랆.러 = 0;
			global::랾.랆.량 = global::랾.럓.랾.worldSizeY - 1;
			global::랾.랆.랯 = global::랾.럓.랾.worldSizeY - 1;
			global::랾.럧.럸 = true;
			return true;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000A68D4 File Offset: 0x000A4AD4
		public static void 럐(bool A_0 = false)
		{
			global::랾.럧.럸 = false;
			global::랾.랆.럝 = 0f;
			global::랾.랆.럕 = 0f;
			global::랾.랆.랹();
			global::랾.랆.럼 = global::랾.랆.람;
			global::랾.랆.랋 = global::랾.랆.람;
			if (A_0)
			{
				global::랾.랆.럽 = 0f;
				global::랾.랆.랬 = 0;
				global::랾.랆.란 = 0;
				global::랾.랆.랫 = 0;
				global::랾.랆.럍 = 0;
				global::랾.랆.럎 = string.Empty;
				global::랾.랆.람 = string.Empty;
				global::랾.랆.랾 = global::랾.랆.럒.랾;
				global::랾.랆.럜 = 0f;
				global::랾.랆.럘 = 0f;
				global::랾.랆.랯 = int.MinValue;
				global::랾.랆.러 = 0;
				global::랾.랆.량 = int.MinValue;
				return;
			}
			if (global::랾.랆.랾 != global::랾.랆.럒.럒)
			{
				global::랾.랆.랾 = global::랾.랆.럒.랾;
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00040342 File Offset: 0x0003E542
		public static float 럪()
		{
			return 0.175f;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00040349 File Offset: 0x0003E549
		public static float 럤()
		{
			return MathF.Max(0f, global::랾.랆.럽);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000A6990 File Offset: 0x000A4B90
		public static string 랍()
		{
			string result;
			if (global::랾.럧.럸)
			{
				global::랾.랆.럯(false);
				if (global::랾.럧.럯)
				{
					result = "Teleporting to " + global::랾.랆.랾(global::랾.랆.랾);
				}
				else
				{
					string text;
					switch (global::랾.랆.랾)
					{
					case global::랾.랆.럒.럎:
						text = "Clearing blocks";
						break;
					case global::랾.랆.럒.람:
						text = "Clearing backgrounds";
						break;
					case global::랾.랆.럒.럒:
						text = "Completed";
						break;
					default:
						text = "Preparing";
						break;
					}
					result = text;
				}
				return result;
			}
			랆.럒 럒 = global::랾.랆.랾;
			if (럒 != global::랾.랆.럒.랾)
			{
				if (럒 == global::랾.랆.럒.럒)
				{
					result = "Completed";
				}
				else
				{
					result = "Stopped";
				}
			}
			else
			{
				result = "Disabled";
			}
			return result;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000A6A2C File Offset: 0x000A4C2C
		public static string 럞()
		{
			string result;
			switch (global::랾.랆.랾)
			{
			case global::랾.랆.럒.럎:
				result = "Foreground";
				break;
			case global::랾.랆.럒.람:
				result = "Background";
				break;
			case global::랾.랆.럒.럒:
				result = "Completed";
				break;
			default:
				result = "Idle";
				break;
			}
			return result;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0004035A File Offset: 0x0003E55A
		public static string 런()
		{
			if (global::랾.럽.랾() && global::랾.럓.랾 != null)
			{
				return global::랾.럓.랾.worldName;
			}
			if (string.IsNullOrWhiteSpace(global::랾.랆.람))
			{
				return "Not in a world";
			}
			return global::랾.랆.람;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000A6A74 File Offset: 0x000A4C74
		public static string 랔()
		{
			if (!global::랾.랆.럊(global::랾.랆.럒))
			{
				return "No target";
			}
			string value = string.IsNullOrWhiteSpace(global::랾.랆.럒) ? global::랾.랆.랾(global::랾.랆.랾).ToUpperInvariant() : global::랾.랆.럒;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.럒.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.럒.y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0004038C File Offset: 0x0003E58C
		public static int 랷()
		{
			global::랾.랆.럯(false);
			return global::랾.랆.랫;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00040399 File Offset: 0x0003E599
		public static int 랤()
		{
			global::랾.랆.럯(false);
			return global::랾.랆.럍;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0004038C File Offset: 0x0003E58C
		public static int 랚()
		{
			global::랾.랆.럯(false);
			return global::랾.랆.랫;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00040399 File Offset: 0x0003E599
		public static int 랲()
		{
			global::랾.랆.럯(false);
			return global::랾.랆.럍;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000403A6 File Offset: 0x0003E5A6
		public static int 랏()
		{
			global::랾.랆.럯(false);
			return global::랾.랆.랫 + global::랾.랆.럍;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000403B9 File Offset: 0x0003E5B9
		public static int 랿()
		{
			global::랾.랆.럯(false);
			return Math.Max(0, global::랾.랆.랬 - global::랾.랆.랫);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000403D2 File Offset: 0x0003E5D2
		public static int 럥()
		{
			global::랾.랆.럯(false);
			return Math.Max(0, global::랾.랆.란 - global::랾.랆.럍);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000403EB File Offset: 0x0003E5EB
		public static float 랒()
		{
			global::랾.랆.럯(false);
			return (float)(global::랾.랆.랫 + global::랾.랆.럍) * 0.175f;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000403EB File Offset: 0x0003E5EB
		public static float 럋()
		{
			global::랾.랆.럯(false);
			return (float)(global::랾.랆.랫 + global::랾.랆.럍) * 0.175f;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00040405 File Offset: 0x0003E605
		public static void 랜()
		{
			global::랾.랆.럯(true);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000A6B14 File Offset: 0x000A4D14
		public static string 랾(float A_0)
		{
			A_0 = MathF.Max(0f, A_0);
			if (A_0 <= 0f)
			{
				return "0s";
			}
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)A_0);
			if (timeSpan.TotalHours >= 1.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
				defaultInterpolatedStringHandler.AppendFormatted<int>((int)timeSpan.TotalHours);
				defaultInterpolatedStringHandler.AppendLiteral("h ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Minutes);
				defaultInterpolatedStringHandler.AppendLiteral("m ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds);
				defaultInterpolatedStringHandler.AppendLiteral("s");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (timeSpan.TotalMinutes >= 1.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler2.AppendFormatted<int>(timeSpan.Minutes);
				defaultInterpolatedStringHandler2.AppendLiteral("m ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(timeSpan.Seconds);
				defaultInterpolatedStringHandler2.AppendLiteral("s");
				return defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler3.AppendFormatted<int>(timeSpan.Seconds);
			defaultInterpolatedStringHandler3.AppendLiteral("s");
			return defaultInterpolatedStringHandler3.ToStringAndClear();
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0004040D File Offset: 0x0003E60D
		public static bool 럢()
		{
			return global::랾.럧.럸 && global::랾.랆.럊(global::랾.랆.럒);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000A6C3C File Offset: 0x000A4E3C
		public static void 럄()
		{
			if (!global::랾.랆.럢() || global::랾.럓.랾 == null)
			{
				return;
			}
			Camera main = Camera.main;
			if (main == null)
			{
				return;
			}
			string text = string.IsNullOrWhiteSpace(global::랾.랆.럒) ? global::랾.랆.랾(global::랾.랆.랾).ToUpperInvariant() : global::랾.랆.럒;
			Color color = (global::랾.랆.랾 == global::랾.랆.럒.람) ? new Color(0.12f, 0.35f, 0.28f, 0.24f) : new Color(0.46f, 0.24f, 0.05f, 0.28f);
			Color color2 = (global::랾.랆.랾 == global::랾.랆.럒.람) ? new Color(0.55f, 1f, 0.78f, 0.96f) : new Color(1f, 0.82f, 0.2f, 1f);
			global::랾.랆.랾(main, global::랾.랆.럒, text, color, color2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000A6D14 File Offset: 0x000A4F14
		public static void 랶()
		{
			bool flag = LoadingScreenController.instance != null && LoadingScreenController.instance.isActiveAndEnabled;
			if (!global::랾.럽.랾())
			{
				global::랾.랆.랓(flag);
				return;
			}
			if (global::랾.럓.랾 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return;
			}
			if (!global::랾.랆.럗())
			{
				return;
			}
			global::랾.랆.럽 += Time.deltaTime;
			global::랾.랆.럯(false);
			if (global::랾.랆.랫 <= 0 && global::랾.랆.럍 <= 0)
			{
				global::랾.랆.랇();
				return;
			}
			global::랾.랆.랾 = ((global::랾.랆.랫 > 0) ? global::랾.랆.럒.럎 : global::랾.랆.럒.람);
			Vector2i vector2i = global::랾.랆.랑();
			global::랾.랆.랗();
			Vector2i vector2i2;
			if (global::랾.랆.랾(vector2i, out vector2i2))
			{
				global::랾.랆.랾(vector2i2, global::랾.랆.럙(vector2i2));
				global::랾.랆.럝 += Time.deltaTime;
				if (global::랾.랆.럝 >= 0.175f)
				{
					global::랾.랆.랫(vector2i2);
					global::랾.랆.럼 = vector2i2;
					global::랾.랆.럝 = 0f;
					global::랾.랆.럜 = 0f;
				}
			}
			else
			{
				global::랾.랆.럝 = 0f;
			}
			if (global::랾.럧.럯)
			{
				return;
			}
			if (global::랾.랆.럍(vector2i))
			{
				return;
			}
			if ((DateTime.UtcNow - global::랾.럧.랾).TotalSeconds < 1.0)
			{
				return;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (realtimeSinceStartup < global::랾.랆.럕)
			{
				return;
			}
			global::랾.랆.럕 = realtimeSinceStartup + 0.25f;
			랆.럼 럼;
			if (!global::랾.랆.랾(vector2i, out 럼))
			{
				int num = global::랾.랆.럡() * 2 + 1;
				global::랾.랆.러 += num;
				int num2 = global::랾.랆.러;
				World world = global::랾.럓.랾;
				if (num2 >= ((world != null) ? world.worldSizeX : 2147483647))
				{
					global::랾.랆.러 = 0;
					global::랾.랆.량 -= 10;
					global::랾.랆.랯 = global::랾.랆.량;
				}
				global::랾.랆.럕 = 0f;
				global::랾.랆.랾(global::랾.랆.람, string.Empty);
				return;
			}
			global::랾.랆.랾(럼.랾, "MOVE TO TARGET");
			if (럼.랾 != null && 럼.랾.Count > 1)
			{
				global::랾.랆.랾(럼.랾, "World Cleaner");
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000A6F14 File Offset: 0x000A5114
		private static string 럙(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null)
			{
				return "BREAK";
			}
			if (global::랾.럓.랾.GetBlockType(A_0) != null)
			{
				return "BREAK BLOCK";
			}
			if (global::랾.럓.랾.GetBlockWaterType(A_0) != null)
			{
				return "BREAK WATER";
			}
			if (global::랾.럓.랾.GetBlockBackgroundType(A_0) != null)
			{
				return "BREAK BACKGROUND";
			}
			return "BREAK";
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000A6F6C File Offset: 0x000A516C
		private static void 랫(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			bool flag = global::랾.럓.랾.GetBlockType(A_0) > 0;
			bool flag2 = global::랾.럓.랾.GetBlockWaterType(A_0) > 0;
			bool flag3 = global::랾.럓.랾.GetBlockBackgroundType(A_0) > 0;
			if (flag)
			{
				global::랾.럽.랾(A_0.x, A_0.y);
				if (flag3 || flag2)
				{
					global::랾.랆.랋 = A_0;
				}
				return;
			}
			if (flag2)
			{
				global::랾.럽.람(A_0.x, A_0.y);
				if (flag3)
				{
					global::랾.랆.랋 = A_0;
				}
				return;
			}
			if (flag3)
			{
				global::랾.럽.럎(A_0.x, A_0.y);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000A7000 File Offset: 0x000A5200
		private static bool 럍(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			List<Vector2i> list = global::랾.랆.럑(A_0);
			int num = global::랾.랆.랯;
			int num2 = global::랾.랆.럡() * 2 + 1;
			int num3 = Math.Min(global::랾.럓.랾.worldSizeX - 1, global::랾.랆.러 + num2 - 1);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].y == num && list[i].x >= global::랾.랆.러 && list[i].x <= num3 && global::랾.랆.란(list[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000A70A4 File Offset: 0x000A52A4
		private static bool 랾(Vector2i A_0, out 랆.럼 A_1)
		{
			A_1 = null;
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			int num = global::랾.랆.랯;
			if (num < 0 || num >= global::랾.럓.랾.worldSizeY)
			{
				return false;
			}
			int num2 = (int)((global::랾.럓.랾 != null && global::랾.럓.랾.GetIsPerkActive(11)) ? 4f : 3f) - 1;
			int num3 = 0;
			int num4 = int.MaxValue;
			int num5 = Math.Max(0, num - num2);
			int num6 = Math.Min(global::랾.럓.랾.worldSizeY - 1, num);
			int num7 = num2 * 2 + 1;
			int num8 = Math.Max(0, global::랾.랆.러 - num2);
			int num9 = Math.Min(global::랾.럓.랾.worldSizeX - 1, global::랾.랆.러 + num7 - 1 + num2);
			for (int i = num6; i >= num5; i--)
			{
				for (int j = num8; j <= num9; j++)
				{
					Vector2i vector2i;
					vector2i..ctor(j, i);
					if (global::랾.럓.랾.IsMapPointInWorld(vector2i) && global::랾.럓.랾.GetBlockType(vector2i) == null && global::랾.럓.랾.GetBlockWaterType(vector2i) == null && global::랾.럓.랾.GetBlockBackgroundType(vector2i) == null && global::랾.랛.랾(j, i, A_0, false, false))
					{
						if (i > 0)
						{
							Vector2i vector2i2;
							vector2i2..ctor(j, i - 1);
							if (!global::랾.럓.랾.IsMapPointInWorld(vector2i2))
							{
								goto IL_2D4;
							}
							World.BlockType blockType = global::랾.럓.랾.GetBlockType(vector2i2);
							if (blockType == null || (!ConfigData.doesBlockHaveCollider[blockType] && !global::랾.랛.랾(blockType)))
							{
								goto IL_2D4;
							}
						}
						Vector2i vector2i3;
						vector2i3..ctor(j, i);
						List<Vector2i> list = global::랾.랆.럑(vector2i3);
						int num10 = 0;
						int num11 = Math.Min(global::랾.럓.랾.worldSizeX - 1, global::랾.랆.러 + num7 - 1);
						for (int k = 0; k < list.Count; k++)
						{
							if (list[k].y == num && list[k].x >= global::랾.랆.러 && list[k].x <= num11 && global::랾.랆.란(list[k]))
							{
								num10++;
							}
						}
						if (num10 > 0 && num10 >= num3)
						{
							List<랛.랾> list2 = global::랾.랛.랾(A_0, vector2i3, global::랾.랛.럎());
							int num12 = (list2 == null || list2.Count <= 1) ? 0 : list2.Count;
							if (num10 > num3 || num12 < num4)
							{
								num3 = num10;
								num4 = num12;
								Vector2i vector2i4 = global::랾.랆.람;
								for (int l = 0; l < list.Count; l++)
								{
									if (list[l].y == num && global::랾.랆.란(list[l]))
									{
										vector2i4 = list[l];
										break;
									}
								}
								A_1 = new 랆.럼
								{
									랾 = vector2i4,
									럎 = vector2i3,
									랾 = false,
									랾 = ((list2 != null && list2.Count > 1) ? list2 : null),
									랾 = num12
								};
							}
						}
					}
					IL_2D4:;
				}
			}
			return A_1 != null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000A73A8 File Offset: 0x000A55A8
		private static void 랗()
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			int num = global::랾.랆.럡() * 2 + 1;
			if (global::랾.랆.량 == -2147483648 || global::랾.랆.랯 == -2147483648)
			{
				global::랾.랆.러 = 0;
				global::랾.랆.량 = global::랾.럓.랾.worldSizeY - 1;
				global::랾.랆.랯 = global::랾.럓.랾.worldSizeY - 1;
			}
			while (global::랾.랆.랯 >= 0)
			{
				if (global::랾.랆.량 - global::랾.랆.랯 < 10 && global::랾.랆.랾(global::랾.랆.랯, global::랾.랆.러, num))
				{
					return;
				}
				global::랾.랆.랯--;
				if (global::랾.랆.량 - global::랾.랆.랯 >= 10)
				{
					global::랾.랆.러 += num;
					if (global::랾.랆.러 >= global::랾.럓.랾.worldSizeX)
					{
						global::랾.랆.러 = 0;
						global::랾.랆.량 -= 10;
						global::랾.랆.랯 = global::랾.랆.량;
					}
					else
					{
						global::랾.랆.랯 = global::랾.랆.량;
					}
				}
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000A74A0 File Offset: 0x000A56A0
		private static bool 랾(int A_0, int A_1, int A_2)
		{
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			int num = Math.Min(global::랾.럓.랾.worldSizeX - 1, A_1 + A_2 - 1);
			for (int i = A_1; i <= num; i++)
			{
				if (global::랾.랆.란(new Vector2i(i, A_0)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00040422 File Offset: 0x0003E622
		private static void 랬(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			if (global::랾.럓.랾.GetBlockType(A_0) != null)
			{
				return;
			}
			if (global::랾.럓.랾.GetBlockBackgroundType(A_0) == null)
			{
				return;
			}
			global::랾.럽.럎(A_0.x, A_0.y);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000A74EC File Offset: 0x000A56EC
		private static void 랓(bool A_0)
		{
			if (!global::랾.럧.럸)
			{
				return;
			}
			string text = global::랾.랆.람;
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			if (A_0 || global::랾.럽.람())
			{
				global::랾.랆.럘 = 0f;
				return;
			}
			global::랾.랆.럘 += Time.deltaTime;
			if (global::랾.랆.럘 < 5f)
			{
				return;
			}
			SceneLoader.GoFromMainMenuToWorld(text, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			global::랾.럧.량 = 0f;
			global::랾.랆.럘 = 0f;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000A7564 File Offset: 0x000A5764
		private static bool 럗()
		{
			if (string.IsNullOrWhiteSpace(global::랾.랆.람) || global::랾.럓.랾 == null)
			{
				return true;
			}
			if (string.Equals(global::랾.럓.랾.worldName, global::랾.랆.람, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			global::랾.랆.럐(false);
			global::랾.랃.랾("World Cleaner", "Stopped because you changed worlds.", 4f);
			return false;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000A75BC File Offset: 0x000A57BC
		private static void 럯(bool A_0 = false)
		{
			if (global::랾.럓.랾 == null)
			{
				global::랾.랆.랫 = 0;
				global::랾.랆.럍 = 0;
				global::랾.랆.럎 = string.Empty;
				return;
			}
			string b = global::랾.럓.랾.worldName ?? string.Empty;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (!A_0 && string.Equals(global::랾.랆.럎, b, StringComparison.OrdinalIgnoreCase) && realtimeSinceStartup < global::랾.랆.럜)
			{
				return;
			}
			global::랾.랆.럎 = b;
			global::랾.랆.럜 = realtimeSinceStartup + 0.35f;
			global::랾.랆.랾(out global::랾.랆.랫, out global::랾.랆.럍);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000A763C File Offset: 0x000A583C
		private static void 랾(out int A_0, out int A_1)
		{
			A_0 = 0;
			A_1 = 0;
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			for (int i = 0; i < global::랾.럓.랾.worldSizeY; i++)
			{
				for (int j = 0; j < global::랾.럓.랾.worldSizeX; j++)
				{
					Vector2i vector2i;
					vector2i..ctor(j, i);
					World.BlockType blockType = global::랾.럓.랾.GetBlockType(vector2i);
					if (!global::랾.랆.랾(vector2i, blockType))
					{
						if (blockType != null)
						{
							A_0++;
						}
						else if (global::랾.럓.랾.GetBlockWaterType(vector2i) != null || global::랾.럓.랾.GetBlockBackgroundType(vector2i) != null)
						{
							A_1++;
						}
					}
				}
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000A76CC File Offset: 0x000A58CC
		private static bool 랾(Vector2i A_0, out Vector2i A_1)
		{
			A_1 = global::랾.랆.람;
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			if (global::랾.랆.럊(global::랾.랆.럒) && global::랾.랆.럒.y == global::랾.랆.랯 && global::랾.랆.란(global::랾.랆.럒) && global::랾.랆.람(A_0, global::랾.랆.럒))
			{
				A_1 = global::랾.랆.럒;
				return true;
			}
			int num = global::랾.랆.럡();
			int num2 = int.MaxValue;
			float num3 = float.MaxValue;
			int num4 = global::랾.랆.랯;
			if (num4 < 0 || num4 >= global::랾.럓.랾.worldSizeY)
			{
				return false;
			}
			int num5 = num * 2 + 1;
			int val = Math.Min(global::랾.럓.랾.worldSizeX - 1, global::랾.랆.러 + num5 - 1);
			int num6 = Math.Max(global::랾.랆.러, A_0.x - num);
			int num7 = Math.Min(val, A_0.x + num);
			for (int i = num6; i <= num7; i++)
			{
				Vector2i vector2i;
				vector2i..ctor(i, num4);
				if (global::랾.랆.란(vector2i) && global::랾.랆.람(A_0, vector2i))
				{
					int num8 = global::랾.랆.럒(vector2i, A_0);
					float num9 = global::랾.럽.랾(A_0, vector2i);
					if (num8 < num2 || (num8 == num2 && num9 < num3))
					{
						num2 = num8;
						num3 = num9;
						A_1 = vector2i;
					}
				}
			}
			return global::랾.랆.럊(A_1);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00040459 File Offset: 0x0003E659
		private static bool 럎(Vector2i A_0, out Vector2i A_1)
		{
			A_1 = global::랾.랆.람;
			if (!global::랾.랆.럊(global::랾.랆.랋))
			{
				global::랾.랆.랋 = global::랾.랆.람;
				return false;
			}
			if (global::랾.랆.랾(A_0, global::랾.랆.랋, out A_1))
			{
				return true;
			}
			global::랾.랆.랋 = global::랾.랆.람;
			return false;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000A780C File Offset: 0x000A5A0C
		private static bool 랾(Vector2i A_0, Vector2i A_1, out Vector2i A_2)
		{
			A_2 = global::랾.랆.람;
			if (!global::랾.랆.럊(A_1))
			{
				return false;
			}
			if (global::랾.랆.러(A_1) && global::랾.랆.람(A_0, A_1))
			{
				A_2 = A_1;
				return true;
			}
			int num = int.MaxValue;
			float num2 = float.MaxValue;
			int num3 = Math.Max(0, A_1.x - 1);
			int num4 = Math.Min(global::랾.럓.랾.worldSizeX - 1, A_1.x + 1);
			int num5 = Math.Max(0, A_1.y - 1);
			int num6 = Math.Min(global::랾.럓.랾.worldSizeY - 1, A_1.y + 1);
			for (int i = num5; i <= num6; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					Vector2i vector2i;
					vector2i..ctor(j, i);
					int num7 = Math.Abs(vector2i.x - A_1.x) + Math.Abs(vector2i.y - A_1.y);
					if (num7 > 0 && num7 <= 1 && global::랾.랆.러(vector2i) && global::랾.랆.람(A_0, vector2i))
					{
						float num8 = global::랾.럽.랾(A_0, vector2i);
						if (num7 < num || (num7 == num && num8 < num2))
						{
							num = num7;
							num2 = num8;
							A_2 = vector2i;
						}
					}
				}
			}
			return global::랾.랆.럊(A_2);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000A7958 File Offset: 0x000A5B58
		private static void 랾([TupleElementNames(new string[]
		{
			"Target",
			"Heuristic"
		})] List<ValueTuple<Vector2i, int>> candidates, Vector2i A_1, int A_2)
		{
			for (int i = 0; i < candidates.Count; i++)
			{
				if (global::랾.랆.럼(candidates[i].Item1, A_1))
				{
					return;
				}
			}
			int num = candidates.Count;
			for (int j = 0; j < candidates.Count; j++)
			{
				if (A_2 < candidates[j].Item2)
				{
					num = j;
					break;
				}
			}
			if (num >= 32 && candidates.Count >= 32)
			{
				return;
			}
			candidates.Insert(num, new ValueTuple<Vector2i, int>(A_1, A_2));
			if (candidates.Count > 32)
			{
				candidates.RemoveAt(candidates.Count - 1);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000A79EC File Offset: 0x000A5BEC
		private static bool 랾(Vector2i A_0, Vector2i A_1, out 랆.럼 A_2)
		{
			A_2 = null;
			if (!global::랾.랆.란(A_1))
			{
				return false;
			}
			if (global::랾.랆.람(A_0, A_1))
			{
				A_2 = new 랆.럼
				{
					랾 = A_1,
					럎 = A_0,
					랾 = false,
					랾 = 0
				};
				return true;
			}
			int num = global::랾.랆.럡();
			for (int i = A_1.y - num; i <= A_1.y + num; i++)
			{
				for (int j = A_1.x - num; j <= A_1.x + num; j++)
				{
					Vector2i vector2i;
					vector2i..ctor(j, i);
					if (global::랾.럓.랾.IsMapPointInWorld(vector2i) && global::랾.랆.람(vector2i, A_1) && global::랾.랛.랾(j, i, A_0, false, false))
					{
						List<랛.랾> list = global::랾.랛.랾(A_0, vector2i, global::랾.랛.럎());
						if (list != null && list.Count > 1)
						{
							int count = list.Count;
							if (A_2 == null || count < A_2.랾)
							{
								A_2 = new 랆.럼
								{
									랾 = A_1,
									럎 = vector2i,
									랾 = false,
									랾 = list,
									랾 = count
								};
							}
						}
					}
				}
			}
			return A_2 != null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00040499 File Offset: 0x0003E699
		private static bool 란(Vector2i A_0)
		{
			return global::랾.랆.랯(A_0) || global::랾.랆.럇(A_0) || global::랾.랆.러(A_0);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000404B3 File Offset: 0x0003E6B3
		private static bool 럇(Vector2i A_0)
		{
			return global::랾.럓.랾 != null && global::랾.럓.랾.IsMapPointInWorld(A_0) && global::랾.럓.랾.GetBlockWaterType(A_0) > 0;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000A7B10 File Offset: 0x000A5D10
		private static bool 랯(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return false;
			}
			World.BlockType blockType = global::랾.럓.랾.GetBlockType(A_0);
			return blockType != null && !global::랾.랆.랾(A_0, blockType);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000A7B50 File Offset: 0x000A5D50
		private static bool 러(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return false;
			}
			World.BlockType blockType = global::랾.럓.랾.GetBlockType(A_0);
			return blockType == null && !global::랾.랆.랾(A_0, blockType) && global::랾.럓.랾.GetBlockBackgroundType(A_0) > 0;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000404D9 File Offset: 0x0003E6D9
		private static bool 랾(Vector2i A_0, World.BlockType A_1)
		{
			return global::랾.랆.량(A_0) || (A_1 != null && (ConfigData.IsBlockLock(A_1) || ConfigData.IsBlockStorage(A_1) || A_1 == 3 || A_1 == 344 || A_1 == 343));
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000A7B9C File Offset: 0x000A5D9C
		private static bool 량(Vector2i A_0)
		{
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			try
			{
				Vector2i playerSpawnPosition = global::랾.럓.랾.GetPlayerSpawnPosition();
				if (global::랾.럓.랾.IsMapPointInWorld(playerSpawnPosition) && global::랾.랆.럼(A_0, playerSpawnPosition))
				{
					return true;
				}
			}
			catch
			{
			}
			Vector2i playerStartPosition = global::랾.럓.랾.playerStartPosition;
			if (global::랾.럓.랾.IsMapPointInWorld(playerStartPosition) && global::랾.랆.럼(A_0, playerStartPosition))
			{
				return true;
			}
			Vector2i vector2i;
			vector2i..ctor(playerStartPosition.x, playerStartPosition.y - 1);
			return global::랾.럓.랾.IsMapPointInWorld(vector2i) && global::랾.랆.럼(A_0, vector2i);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00040510 File Offset: 0x0003E710
		private static bool 람(Vector2i A_0, Vector2i A_1)
		{
			return global::랾.럓.랾 != null && global::랾.럓.랾.IsMapPointInWorld(A_0) && global::랾.럓.랾.IsMapPointInWorld(A_1) && global::랾.랆.럎(global::랾.랆.럑(A_0), A_1.x, A_1.y);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0004054C File Offset: 0x0003E74C
		private static int 랙()
		{
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.GetIsPerkActive(11))
			{
				return 3;
			}
			return 4;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00040566 File Offset: 0x0003E766
		private static int 럡()
		{
			return Math.Max(0, global::랾.랆.랙() - 1);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000A7C40 File Offset: 0x000A5E40
		private static Vector2i 랑()
		{
			try
			{
				if (global::랾.럓.랾 != null)
				{
					return global::랾.럓.랾.currentPlayerMapPoint;
				}
			}
			catch
			{
			}
			return global::랾.랆.랰();
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000A7C84 File Offset: 0x000A5E84
		private static List<Vector2i> 럑(Vector2i A_0)
		{
			int num = global::랾.랆.럡();
			List<Vector2i> list = new List<Vector2i>((num * 2 + 1) * (num * 2 + 1));
			for (int i = -num; i <= num; i++)
			{
				for (int j = -num; j <= num; j++)
				{
					if (j != 0 || i != -1)
					{
						global::랾.랆.랾(list, A_0.x + j, A_0.y + i);
					}
				}
			}
			return list;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000A7CE0 File Offset: 0x000A5EE0
		private static int 럒(Vector2i A_0, Vector2i A_1)
		{
			Vector2i vector2i = global::랾.랆.럊(global::랾.랆.럼) ? global::랾.랆.럼 : A_1;
			int num = Math.Abs(A_0.x - vector2i.x);
			int num2 = Math.Abs(A_0.x - A_1.x) + Math.Abs(A_0.y - A_1.y);
			return num * 1000 + num2;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000A7D44 File Offset: 0x000A5F44
		private static void 랇()
		{
			global::랾.럧.럸 = false;
			global::랾.랆.랾 = global::랾.랆.럒.럒;
			global::랾.랆.랫 = 0;
			global::랾.랆.럍 = 0;
			global::랾.랆.럜 = 0f;
			global::랾.랆.럝 = 0f;
			global::랾.랆.랯 = int.MinValue;
			global::랾.랆.러 = 0;
			global::랾.랆.량 = int.MinValue;
			global::랾.랆.랹();
			global::랾.랆.럼 = global::랾.랆.람;
			int value = global::랾.랆.랬 + global::랾.랆.란;
			string text = "World Cleaner";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Cleared ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral(" tiles in ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.랾(global::랾.랆.럽));
			defaultInterpolatedStringHandler.AppendLiteral(".");
			global::랾.랃.럎(text, defaultInterpolatedStringHandler.ToStringAndClear(), 4f);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00040575 File Offset: 0x0003E775
		private static void 랾(Vector2i A_0, string A_1)
		{
			global::랾.랆.럒 = A_0;
			global::랾.랆.럒 = (A_1 ?? string.Empty);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0004058C File Offset: 0x0003E78C
		private static void 랹()
		{
			global::랾.랆.럒 = global::랾.랆.람;
			global::랾.랆.럒 = string.Empty;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000405A2 File Offset: 0x0003E7A2
		private static bool 럊(Vector2i A_0)
		{
			return global::랾.럓.랾 != null && global::랾.럓.랾.IsMapPointInWorld(A_0) && A_0.x != int.MinValue && A_0.y != int.MinValue;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000405D7 File Offset: 0x0003E7D7
		private static bool 럼(Vector2i A_0, Vector2i A_1)
		{
			return A_0.x == A_1.x && A_0.y == A_1.y;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000405F7 File Offset: 0x0003E7F7
		private static string 랾(랆.럒 A_0)
		{
			if (A_0 != global::랾.랆.럒.람)
			{
				return "block";
			}
			return "background";
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00040608 File Offset: 0x0003E808
		public static string 럛()
		{
			return global::랾.랆.랋;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000A7E10 File Offset: 0x000A6010
		public static void 럭(bool A_0 = true)
		{
			global::랾.랆.럎 = null;
			global::랾.랆.럑 = 0;
			global::랾.랆.랺 = 0f;
			global::랾.랆.럊 = 0;
			global::랾.랆.럼 = null;
			global::랾.랆.랱 = false;
			global::랾.랆.랋 = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
			if (A_0)
			{
				global::랾.랃.랾("Decay Finder", "Reset. It will reload worlds.txt from the beginning.", 4f);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000A7E68 File Offset: 0x000A6068
		public static void 럎랾()
		{
			if (global::랾.랆.럎 == null)
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logger");
				string path = Path.Combine(text, "worlds.txt");
				global::랾.랆.럼 = Path.Combine(text, "Decays.txt");
				try
				{
					Directory.CreateDirectory(text);
				}
				catch
				{
					return;
				}
				if (!File.Exists(path))
				{
					global::랾.랃.럒("Decay Finder", "worlds.txt not found add it to: " + text, 4f);
					global::랾.럧.랐 = false;
					global::랾.랆.럭(false);
					return;
				}
				global::랾.랆.럎 = File.ReadAllLines(path).Select(new Func<string, string>(global::랾.랆.랋.랾.랾)).Where(new Func<string, bool>(global::랾.랆.랋.랾.럎)).Distinct(StringComparer.OrdinalIgnoreCase).ToArray<string>();
				if (global::랾.랆.럎.Length == 0)
				{
					global::랾.랃.럒("Decay Finder", "worlds.txt is empty", 4f);
					global::랾.럧.랐 = false;
					global::랾.랆.럭(false);
					return;
				}
				global::랾.랆.럑 = 0;
				global::랾.랆.럊 = 0;
				global::랾.랆.랱 = false;
				global::랾.랆.랋 = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				string text2 = "Decay Finder";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Scanning ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.럎.Length);
				defaultInterpolatedStringHandler.AppendLiteral(" worlds...");
				global::랾.랃.랾(text2, defaultInterpolatedStringHandler.ToStringAndClear(), 4f);
			}
			if (global::랾.랆.럑 >= global::랾.랆.럎.Length)
			{
				string text3 = "Decay Finder";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("Done. Scanned ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.랆.럊);
				defaultInterpolatedStringHandler2.AppendLiteral(" worlds.");
				global::랾.랃.럎(text3, defaultInterpolatedStringHandler2.ToStringAndClear(), 4f);
				global::랾.럧.랐 = false;
				global::랾.랆.럭(false);
				return;
			}
			if (global::랾.랆.랱)
			{
				if (!global::랾.럽.랾())
				{
					return;
				}
				if (global::랾.럓.랾 == null)
				{
					return;
				}
				if (string.IsNullOrEmpty(global::랾.럓.랾.worldName))
				{
					return;
				}
				if (!global::랾.럓.랾.worldName.Equals(global::랾.랆.랋, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
				try
				{
					string str;
					if (global::랾.럓.랾.lockWorldDataHelper != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(7, 1);
						defaultInterpolatedStringHandler3.AppendLiteral("Decay: ");
						defaultInterpolatedStringHandler3.AppendFormatted<DateTime>(global::랾.럓.랾.lockWorldDataHelper.GetLastActivatedTime());
						str = defaultInterpolatedStringHandler3.ToStringAndClear();
					}
					else if (global::랾.럓.랾.lockSmallDataHelper != null && global::랾.럓.랾.DoesWorldHaveSmallLocks())
					{
						str = "Small Lock (not lockable)";
					}
					else
					{
						str = "LOCKABLE (no lock)";
					}
					string text4 = global::랾.럓.랾.worldName + " | " + str;
					global::랾.랆.랾(global::랾.랆.럼, text4);
					global::랾.럽.람(text4);
					global::랾.랃.랾("Decay", global::랾.럓.랾.worldName + ": " + str, 2f);
				}
				catch
				{
					global::랾.랆.랾(global::랾.랆.럼, global::랾.랆.럎[global::랾.랆.럑] + " | Error reading lock data");
				}
				global::랾.랆.럊++;
				global::랾.랆.럑++;
				global::랾.랆.랱 = false;
				global::랾.랆.랋 = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				global::랾.랆.랺 = 0f;
				return;
			}
			else
			{
				global::랾.랆.랺 += Time.deltaTime;
				if (global::랾.랆.랺 < global::랾.랆.럈)
				{
					return;
				}
				SceneLoader.CheckIfWeCanGoFromWorldToWorld(global::랾.랆.랋 = global::랾.랆.럎[global::랾.랆.럑], E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), null, false, null);
				global::랾.랆.랱 = true;
				global::랾.랆.랺 = 0f;
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000A81F4 File Offset: 0x000A63F4
		public static void 럎럎()
		{
			if (SceneManager.GetActiveScene().name != SceneLoader.welcomeSceneName)
			{
				SceneLoader.GoToWelcomeScene();
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000A8220 File Offset: 0x000A6420
		public static void 럎람()
		{
			string worldName = global::랾.럓.랾.worldName;
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			if (!global::랾.럽.랾())
			{
				global::랾.럧.랄 = 0f;
				global::랾.랆.럙 = false;
				global::랾.랆.럧 = 0f;
				return;
			}
			global::랾.럧.랄 += Time.deltaTime;
			if (worldName != "SECRETBASE")
			{
				if (global::랾.럧.랄 >= 1f)
				{
					global::랾.랆.럎럒();
					SceneLoader.JoinDynamicWorld("SECRETBASE", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), false);
					global::랾.럧.랄 = 0f;
				}
				return;
			}
			if (LoadingScreenController.instance.IsLoading())
			{
				return;
			}
			global::랾.랆.럓 += Time.deltaTime;
			ConfigFile.godModeToggle = true;
			ConfigFile.aimbotPVEToggle = true;
			global::랾.럧.럦 = true;
			if (global::랾.럧.럯)
			{
				global::랾.럧.랄 = 0f;
			}
			global::랾.랆.럎럊();
			if (global::랾.럓.랾.currentPlayerPositionBlockType == 1995 && global::랾.랆.랫 && !global::랾.랆.럍)
			{
				global::랾.랆.랠(currentPlayerMapPoint);
				return;
			}
			if ((double)global::랾.럧.랄 >= 0.6 && !global::랾.랆.럍)
			{
				global::랾.랆.럏(currentPlayerMapPoint);
				return;
			}
			if ((double)global::랾.럧.랄 >= 0.6 && global::랾.랆.럍)
			{
				global::랾.랆.럫(currentPlayerMapPoint);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0004060F File Offset: 0x0003E80F
		private static void 럎럒()
		{
			global::랾.랆.럙 = false;
			global::랾.랆.럧 = 0f;
			global::랾.랆.럓 = 0f;
			global::랾.랆.랫 = true;
			global::랾.랆.럍 = false;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000A8358 File Offset: 0x000A6558
		private static void 랠(Vector2i A_0)
		{
			LabExitPortalData labExitPortalData = global::랾.럓.랾.GetWorldItemData(A_0).TryCast<LabExitPortalData>();
			if (labExitPortalData != null && labExitPortalData.isActivated)
			{
				WorldButtonsUI worldButtonsUI = global::랾.랆.럎랓();
				if (worldButtonsUI != null)
				{
					worldButtonsUI.PressNearestButton();
				}
			}
			else if (A_0 == new Vector2i(58, 64))
			{
				global::랾.랆.럧 += Time.deltaTime;
				global::랾.랆.럍 = false;
			}
			else
			{
				global::랾.랆.럍 = true;
			}
			if (global::랾.랆.럧 >= 3f && !global::랾.랆.럙)
			{
				global::랾.랆.럙 = true;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000A83DC File Offset: 0x000A65DC
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

		// Token: 0x060007E4 RID: 2020 RVA: 0x00040637 File Offset: 0x0003E837
		private static GeneratedMineResultsUI 럎럼()
		{
			return global::랾.랆.랾<GeneratedMineResultsUI>(ref global::랾.랆.랾, ref global::랾.랆.량);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00040648 File Offset: 0x0003E848
		private static LaboratoryBossMonoBehaviour 럎랋()
		{
			return global::랾.랆.랾<LaboratoryBossMonoBehaviour>(ref global::랾.랆.랾, ref global::랾.랆.럑);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00040659 File Offset: 0x0003E859
		private static NetherBossWraithMonoBehaviour 럎랉()
		{
			return global::랾.랆.랾<NetherBossWraithMonoBehaviour>(ref global::랾.랆.랾, ref global::랾.랆.럊);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0004066A File Offset: 0x0003E86A
		private static CharacterCreationPopupUI 럎럐()
		{
			return global::랾.랆.랾<CharacterCreationPopupUI>(ref global::랾.랆.랾, ref global::랾.랆.랠);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0004067B File Offset: 0x0003E87B
		private static WorldButtonsUI 럎랓()
		{
			return global::랾.랆.랾<WorldButtonsUI>(ref global::랾.랆.랾, ref global::랾.랆.럏);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0004068C File Offset: 0x0003E88C
		private static bool 랾(out string A_0, out bool A_1)
		{
			A_0 = string.Empty;
			A_1 = false;
			A_1 = global::랾.랆.럎러();
			if (A_1)
			{
				A_0 = "Using Nether scroll...";
			}
			return A_1;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000A8434 File Offset: 0x000A6634
		private static bool 럎(out string A_0)
		{
			A_0 = string.Empty;
			Vector2i vector2i;
			NetherGroupPortalData netherGroupPortalData;
			string text;
			if (!global::랾.랆.랾(out vector2i, out netherGroupPortalData, out text))
			{
				global::랾.랆.랾 = text;
				return false;
			}
			int num = global::랾.랆.럎럭();
			if (netherGroupPortalData.level != num)
			{
				global::랾.랆.랾 = "Selected red portal is " + global::랾.랆.람(netherGroupPortalData.level) + ". Change Nether Level to match it, or pick another portal.";
				return false;
			}
			if (netherGroupPortalData.isLocked && !global::랾.랆.럎란())
			{
				global::랾.랆.랾 = "Selected red portal is locked and you do not have access.";
				return false;
			}
			string text2;
			if (!global::랾.랆.랾(netherGroupPortalData, out text2))
			{
				global::랾.랆.랾 = text2;
				return false;
			}
			string value = global::랾.랆.랾(netherGroupPortalData, vector2i);
			string value2 = global::랾.랆.람(netherGroupPortalData.level);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Used ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			global::랾.랆.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("Using red portal ");
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			defaultInterpolatedStringHandler2.AppendLiteral(" (");
			defaultInterpolatedStringHandler2.AppendFormatted(value2);
			defaultInterpolatedStringHandler2.AppendLiteral(")...");
			A_0 = defaultInterpolatedStringHandler2.ToStringAndClear();
			return true;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000A8568 File Offset: 0x000A6768
		private static bool 랾(NetherGroupPortalData A_0, out string A_1)
		{
			A_1 = string.Empty;
			string text = (!string.IsNullOrWhiteSpace(A_0.entryPointID)) ? A_0.entryPointID : A_0.targetEntryPointID;
			if (string.IsNullOrWhiteSpace(text))
			{
				A_1 = "Selected red portal does not have a valid entry point.";
				return false;
			}
			bool result;
			try
			{
				SceneLoader.CheckIfWeCanGoFromWorldToWorld(global::랾.럓.랾.worldName, text, null, false, null);
				ConfigFile.zoomHackToggle = false;
				result = true;
			}
			catch (Exception ex)
			{
				A_1 = "Portal entry failed: " + ex.GetType().Name;
				result = false;
			}
			return result;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000406AC File Offset: 0x0003E8AC
		private static int 럎럯()
		{
			return Math.Clamp(ConfigFile.autoNetherEntryMode, 0, 1);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000406BA File Offset: 0x0003E8BA
		private static int 럎럭()
		{
			return Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.랆.랾.Length - 1);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000406D0 File Offset: 0x0003E8D0
		private static string 럎랱()
		{
			if (global::랾.랆.럎럯() == 1 && global::랾.랆.럎랫())
			{
				return "Enter " + ConfigFile.autoNetherSelectedPortalWorldName + " to start Auto Nether with the saved red portal...";
			}
			return "Enter a world to start Auto Nether...";
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000406FB File Offset: 0x0003E8FB
		private static string 럎럙()
		{
			if (global::랾.랆.럎럯() != 1 || !global::랾.랆.럎랫())
			{
				return string.Empty;
			}
			return (ConfigFile.autoNetherSelectedPortalWorldName ?? string.Empty).Trim();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00040725 File Offset: 0x0003E925
		private static bool 럎랫()
		{
			return !string.IsNullOrWhiteSpace(ConfigFile.autoNetherSelectedPortalWorldName) && ConfigFile.autoNetherSelectedPortalX >= 0 && ConfigFile.autoNetherSelectedPortalY >= 0;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00040748 File Offset: 0x0003E948
		private static Vector2i 럎럍()
		{
			return new Vector2i(ConfigFile.autoNetherSelectedPortalX, ConfigFile.autoNetherSelectedPortalY);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00040759 File Offset: 0x0003E959
		private static bool 럎랬()
		{
			return global::랾.럓.랾 != null && !string.IsNullOrWhiteSpace(ConfigFile.autoNetherSelectedPortalWorldName) && string.Equals(global::랾.럓.랾.worldName, ConfigFile.autoNetherSelectedPortalWorldName, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000A85F4 File Offset: 0x000A67F4
		private static bool 랾(out Vector2i A_0, out NetherGroupPortalData A_1, out string A_2)
		{
			A_0 = global::랾.랆.럎럍();
			A_1 = null;
			A_2 = string.Empty;
			if (!global::랾.랆.럎랫())
			{
				A_2 = "Pick a red portal first.";
				return false;
			}
			if (global::랾.럓.랾 == null)
			{
				A_2 = "World data is unavailable.";
				return false;
			}
			if (!global::랾.랆.럎랬())
			{
				A_2 = "Join " + ConfigFile.autoNetherSelectedPortalWorldName + " to use the saved red portal.";
				return false;
			}
			if (!global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				A_2 = "Saved portal tile is outside the current world.";
				return false;
			}
			if (!global::랾.랆.랾(A_0, out A_1))
			{
				A_2 = "Saved tile is no longer a red portal.";
				return false;
			}
			return true;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000A8688 File Offset: 0x000A6888
		private static bool 랾(Vector2i A_0, out NetherGroupPortalData A_1)
		{
			A_1 = null;
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return false;
			}
			if (global::랾.럓.랾.GetBlockType(A_0) != 1799)
			{
				return false;
			}
			WorldItemBase worldItemData = global::랾.럓.랾.GetWorldItemData(A_0);
			A_1 = ((worldItemData != null) ? worldItemData.TryCast<NetherGroupPortalData>() : null);
			return A_1 != null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000A86E4 File Offset: 0x000A68E4
		private static bool 랾(Vector2i A_0, out string A_1)
		{
			A_1 = string.Empty;
			if (global::랾.럓.랾 == null)
			{
				A_1 = "World data is unavailable.";
				return false;
			}
			if (!global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				A_1 = "That tile is outside the world.";
				return false;
			}
			NetherGroupPortalData netherGroupPortalData;
			if (!global::랾.랆.랾(A_0, out netherGroupPortalData))
			{
				A_1 = "That tile is not a red portal.";
				return false;
			}
			ConfigFile.autoNetherSelectedPortalWorldName = (global::랾.럓.랾.worldName ?? string.Empty);
			ConfigFile.autoNetherSelectedPortalX = A_0.x;
			ConfigFile.autoNetherSelectedPortalY = A_0.y;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Saved ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.랾(netherGroupPortalData, A_0));
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.람(netherGroupPortalData.level));
			defaultInterpolatedStringHandler.AppendLiteral(").");
			global::랾.랆.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
			return true;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00040785 File Offset: 0x0003E985
		private static bool 럎란()
		{
			return global::랾.럽.랉() || global::랾.럽.랋();
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00040795 File Offset: 0x0003E995
		private static bool 럎럇()
		{
			return global::랾.랆.럳 > 0f && Time.realtimeSinceStartup - global::랾.랆.럳 >= 15f && global::랾.랆.럎랯();
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000407BC File Offset: 0x0003E9BC
		private static bool 럎랯()
		{
			World world = global::랾.럓.랾;
			return ((world != null) ? world.lockWorldDataHelper : null) != null && global::랾.럓.랾 != null && string.Equals(global::랾.럓.랾.lockWorldDataHelper.GetPlayerWhoOwnsLockId(), global::랾.럓.랾.playerId, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000A87BC File Offset: 0x000A69BC
		private static string 랾(string A_0, Vector2i A_1, NetherGroupPortalData A_2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 5);
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.랾(A_2, A_1));
			defaultInterpolatedStringHandler.AppendLiteral(" | ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.람(A_2.level));
			defaultInterpolatedStringHandler.AppendLiteral(" | ");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1.y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000A8858 File Offset: 0x000A6A58
		private static string 랾(NetherGroupPortalData A_0, Vector2i A_1)
		{
			string text;
			if (A_0 == null)
			{
				text = null;
			}
			else
			{
				string name = A_0.name;
				text = ((name != null) ? name.Trim() : null);
			}
			string text2 = text;
			if (!string.IsNullOrWhiteSpace(text2))
			{
				return text2;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Red Portal (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1.x);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1.y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000A88D8 File Offset: 0x000A6AD8
		private static string 람(int A_0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Level ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Max(1, A_0 + 1));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000A8914 File Offset: 0x000A6B14
		private static bool 럎러()
		{
			if (global::랾.럓.랾 == null)
			{
				global::랾.랆.랾 = "PlayerData unavailable";
				return false;
			}
			PlayerData.InventoryKey inventoryKey;
			if (!global::랾.랆.랾(out inventoryKey))
			{
				return false;
			}
			InventoryControl inventoryControl = null;
			foreach (InventoryControl inventoryControl2 in Object.FindObjectsOfType<InventoryControl>())
			{
				if (!(inventoryControl2 == null))
				{
					if (inventoryControl2.gameObject != null && inventoryControl2.gameObject.activeInHierarchy)
					{
						inventoryControl = inventoryControl2;
						break;
					}
					if (inventoryControl == null)
					{
						inventoryControl = inventoryControl2;
					}
				}
			}
			if (inventoryControl == null)
			{
				inventoryControl = Object.FindObjectOfType<InventoryControl>();
			}
			if (inventoryControl == null)
			{
				foreach (Object @object in Resources.FindObjectsOfTypeAll(Il2CppType.Of<InventoryControl>()))
				{
					InventoryControl inventoryControl3 = @object.TryCast<InventoryControl>();
					if (inventoryControl3 != null)
					{
						inventoryControl = inventoryControl3;
						break;
					}
				}
			}
			MethodInfo methodInfo = global::랾.랆.럎럑();
			if (inventoryControl == null)
			{
				global::랾.랆.랾 = "InventoryControl not found";
				return false;
			}
			if (methodInfo == null)
			{
				global::랾.랆.랾 = "UseConsumable method missing";
				return false;
			}
			bool result;
			try
			{
				methodInfo.Invoke(inventoryControl, new object[]
				{
					inventoryKey
				});
				global::랾.랆.럫 = Time.realtimeSinceStartup + 1.5f;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Used ");
				defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(inventoryKey.blockType);
				defaultInterpolatedStringHandler.AppendLiteral(" (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inventoryKey.blockType);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				global::랾.랆.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
				result = true;
			}
			catch (Exception ex)
			{
				global::랾.랆.랾 = "UseConsumable failed: " + ex.GetType().Name;
				result = false;
			}
			return result;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000A8AF4 File Offset: 0x000A6CF4
		private static bool 럎량()
		{
			bool flag = global::랾.랆.럫 > 0f && Time.realtimeSinceStartup <= global::랾.랆.럫;
			BluePopupUI bluePopupUI = global::랾.랆.랟<BluePopupUI>();
			if (bluePopupUI == null || bluePopupUI.gameObject == null || !bluePopupUI.gameObject.activeInHierarchy)
			{
				if (flag)
				{
					global::랾.랆.랾 = "Waiting for the Nether confirmation popup.";
				}
				if (!flag)
				{
					global::랾.랆.럫 = 0f;
				}
				return false;
			}
			if (!global::랾.랆.랾(bluePopupUI, flag))
			{
				global::랾.랆.랾 = "Popup found, but it is not the Nether portal prompt.";
				return false;
			}
			bool result;
			try
			{
				bluePopupUI.PositiveButtonClicked();
				global::랾.랆.럫 = 0f;
				global::랾.랆.랾 = "Confirmed the Nether popup.";
				result = true;
			}
			catch (Exception ex)
			{
				global::랾.랆.랾 = "Popup confirm failed: " + ex.GetType().Name;
				result = false;
			}
			return result;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000A8BCC File Offset: 0x000A6DCC
		private static bool 랾(out PlayerData.InventoryKey A_0)
		{
			A_0 = default(PlayerData.InventoryKey);
			if (global::랾.럓.랾 == null)
			{
				global::랾.랆.랾 = "PlayerData unavailable";
				return false;
			}
			World.BlockType blockType;
			if (!global::랾.랆.랾(out blockType))
			{
				global::랾.랆.랾 = "Invalid Nether scroll level";
				return false;
			}
			if (global::랾.랆.랾(blockType, out A_0))
			{
				return true;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Missing ");
			defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(blockType);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(blockType);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			global::랾.랆.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
			return false;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000A8C60 File Offset: 0x000A6E60
		private static bool 랾(World.BlockType A_0, out PlayerData.InventoryKey A_1)
		{
			A_1 = default(PlayerData.InventoryKey);
			bool result;
			try
			{
				PlayerData.InventoryKey inventoryKey;
				inventoryKey..ctor(A_0, 7);
				if (!global::랾.럓.랾.HasItemAmountInInventory(inventoryKey, 1))
				{
					result = false;
				}
				else
				{
					A_1 = inventoryKey;
					result = true;
				}
			}
			catch
			{
				A_1 = default(PlayerData.InventoryKey);
				result = false;
			}
			return result;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000A8CB8 File Offset: 0x000A6EB8
		private static bool 랾(out World.BlockType A_0)
		{
			int num = Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.랆.랾.Length - 1);
			A_0 = global::랾.랆.랾[num];
			return A_0 != 0;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000A8CE8 File Offset: 0x000A6EE8
		private static MethodInfo 럎럑()
		{
			if (global::랾.랆.럎 != null)
			{
				return global::랾.랆.럎;
			}
			foreach (MethodInfo methodInfo in typeof(InventoryControl).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (!(methodInfo.Name != "UseConsumable") && methodInfo.GetParameters().Length == 1)
				{
					global::랾.랆.럎 = methodInfo;
					break;
				}
			}
			return global::랾.랆.럎;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000A8D58 File Offset: 0x000A6F58
		private static bool 랾(BluePopupUI A_0, bool A_1)
		{
			if (A_0 == null)
			{
				return false;
			}
			string value = global::랾.랆.랾(A_0, ref global::랾.랆.람, "headerText");
			string value2 = global::랾.랆.랾(A_0, ref global::랾.랆.럒, "ribbonHeaderText");
			string value3 = global::랾.랆.랾(A_0, ref global::랾.랆.럼, "bodyText");
			string value4 = global::랾.랆.랾(A_0, ref global::랾.랆.랋, "positiveText");
			string value5 = global::랾.랆.랾(A_0, ref global::랾.랆.랉, "negativeText");
			string value6 = global::랾.랆.랾(ref global::랾.랆.랾, "headerTextString");
			string value7 = global::랾.랆.랾(ref global::랾.랆.럎, "bodyTextString");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 7);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value4);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value5);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value6);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(value7);
			string text = defaultInterpolatedStringHandler.ToStringAndClear().Trim();
			if (!string.IsNullOrWhiteSpace(text))
			{
				text = text.ToUpperInvariant();
				if (text.Contains("NETHER") && (text.Contains("ENTER") || text.Contains("SCROLL") || text.Contains("WORLD") || text.Contains("ACTIVATE") || text.Contains("PORTAL")))
				{
					return true;
				}
			}
			return A_1;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000A8EEC File Offset: 0x000A70EC
		private static string 랾(BluePopupUI A_0, ref FieldInfo A_1, string A_2)
		{
			string result;
			try
			{
				if (A_1 == null)
				{
					A_1 = typeof(BluePopupUI).GetField(A_2, BindingFlags.Instance | BindingFlags.NonPublic);
				}
				FieldInfo fieldInfo = A_1;
				object obj = (fieldInfo != null) ? fieldInfo.GetValue(A_0) : null;
				if (obj == null)
				{
					result = null;
				}
				else
				{
					PropertyInfo property = obj.GetType().GetProperty("text", BindingFlags.Instance | BindingFlags.Public);
					result = (((property != null) ? property.GetValue(obj, null) : null) as string);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000A8F68 File Offset: 0x000A7168
		private static string 랾(ref FieldInfo A_0, string A_1)
		{
			string result;
			try
			{
				if (A_0 == null)
				{
					A_0 = typeof(BluePopupUI).GetField(A_1, BindingFlags.Static | BindingFlags.NonPublic);
				}
				FieldInfo fieldInfo = A_0;
				result = (((fieldInfo != null) ? fieldInfo.GetValue(null) : null) as string);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000A8FBC File Offset: 0x000A71BC
		private static void 럎럊()
		{
			if (!global::랾.럓.랾.ContainsBlock(1975))
			{
				return;
			}
			for (int i = 0; i < global::랾.럓.랾.worldSizeY; i++)
			{
				for (int j = 0; j < global::랾.럓.랾.worldSizeX; j++)
				{
					int blockType = global::랾.럓.랾.GetBlockType(j, i);
					World.BlockType blockType2 = global::랾.럓.랾.GetBlockType(j - 1, i);
					World.BlockType blockType3 = global::랾.럓.랾.GetBlockType(j, i + 1);
					if (blockType == 1975 && blockType2 == null && blockType3 != 1995)
					{
						Vector2i vector2i;
						vector2i..ctor(j, i);
						ControllerHelper.worldController.SetBlock(2146, vector2i.x, vector2i.y);
						global::랾.럓.랾.SetBlock(2146, vector2i.x, vector2i.y, global::랾.럓.랾.GetOwnerOfTheMapPointPlayerID(vector2i), global::랾.럓.랾.GetOwnerOfTheMapPoint(vector2i), false);
					}
				}
			}
			List<Vector2i> list = new List<Vector2i>();
			for (int k = 61; k <= 64; k++)
			{
				list.Add(new Vector2i(k, 25));
			}
			for (int l = 37; l <= 40; l++)
			{
				list.Add(new Vector2i(l, 41));
			}
			for (int m = 37; m <= 40; m++)
			{
				list.Add(new Vector2i(m, 25));
			}
			foreach (Vector2i vector2i2 in list)
			{
				if (global::랾.럓.랾.GetBlockType(vector2i2) == 1975)
				{
					ControllerHelper.worldController.SetBlock(2146, vector2i2.x, vector2i2.y);
					global::랾.럓.랾.SetBlock(2146, vector2i2.x, vector2i2.y, global::랾.럓.랾.GetOwnerOfTheMapPointPlayerID(vector2i2), global::랾.럓.랾.GetOwnerOfTheMapPoint(vector2i2), false);
				}
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000A91B8 File Offset: 0x000A73B8
		private static void 럏(Vector2i A_0)
		{
			랆.럐 럐 = new 랆.럐();
			럐.랾 = A_0;
			global::랾.럧.럎.Clear();
			for (int i = 0; i < global::랾.럓.랾.worldSizeX; i++)
			{
				for (int j = 0; j < global::랾.럓.랾.worldSizeY; j++)
				{
					if (global::랾.럓.랾.GetBlockType(i, j) == 1995)
					{
						Vector2i vector2i;
						vector2i..ctor(i, j);
						if (global::랾.랛.랾(vector2i.x, vector2i.y, 럐.랾, false, false))
						{
							List<랛.랾> list = global::랾.랛.랾(럐.랾, vector2i, global::랾.랛.럎());
							if (list != null && list.Count > 0)
							{
								global::랾.럧.럎.Add(vector2i);
							}
						}
					}
				}
			}
			if (global::랾.럧.럎.Count > 0)
			{
				Vector2i vector2i2 = global::랾.럧.럎.OrderBy(new Func<Vector2i, double>(럐.랾)).First<Vector2i>();
				if (럐.랾 != vector2i2)
				{
					global::랾.랆.랾(global::랾.랛.랾(럐.랾, vector2i2, global::랾.랛.럎()), "Teleporting to portal");
				}
				global::랾.럧.럎.Clear();
			}
			global::랾.럧.랄 = 0f;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000A92DC File Offset: 0x000A74DC
		private static void 럫(Vector2i A_0)
		{
			global::랾.럧.랾.Clear();
			List<ValueTuple<Vector2i, List<랛.랾>>> list = new List<ValueTuple<Vector2i, List<랛.랾>>>();
			foreach (KeyValuePair<int, AIEnemyMonoBehaviourBase> keyValuePair in ControllerHelper.worldController.aiEnemyMonoBehaviours)
			{
				AIEnemyMonoBehaviourBase value = keyValuePair.value;
				if (!(value == null) && Array.IndexOf<AIEnemyType>(global::랾.랳.랾, value.aiBase.GetEnemyType()) < 0)
				{
					Vector2i vector2i;
					vector2i..ctor((int)value.aiBase.mapPointX, (int)value.aiBase.mapPointY);
					if (global::랾.랛.랾(vector2i.x, vector2i.y, A_0, false, false))
					{
						List<랛.랾> list2 = global::랾.랛.랾(A_0, vector2i, global::랾.랛.럎());
						if (list2 != null && list2.Count > 0)
						{
							list.Add(new ValueTuple<Vector2i, List<랛.랾>>(vector2i, list2));
							global::랾.럧.랾.Add(vector2i);
						}
					}
				}
			}
			if (list.Count > 0)
			{
				ValueTuple<Vector2i, List<랛.랾>> valueTuple = list.OrderBy(new Func<ValueTuple<Vector2i, List<랛.랾>>, int>(global::랾.랆.랋.랾.랾)).First<ValueTuple<Vector2i, List<랛.랾>>>();
				if (A_0 != valueTuple.Item1)
				{
					global::랾.랆.랾(valueTuple.Item2, "Teleporting to enemy");
				}
				global::랾.럧.랾.Remove(valueTuple.Item1);
				global::랾.랆.럍 = true;
				global::랾.랆.랫 = false;
			}
			else
			{
				global::랾.랆.랫 = true;
				global::랾.랆.럍 = false;
			}
			global::랾.럧.랄 = 0f;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000A9440 File Offset: 0x000A7640
		private static void 랾(World.BlockType A_0, Vector2i A_1)
		{
			global::랾.럴.AssertRuntimeKeyValid("TeleportToBlockType");
			global::랾.럧.럎.Clear();
			List<ValueTuple<Vector2i, List<랛.랾>>> list = new List<ValueTuple<Vector2i, List<랛.랾>>>();
			for (int i = 0; i < global::랾.럓.랾.worldSizeX; i++)
			{
				for (int j = 0; j < global::랾.럓.랾.worldSizeY; j++)
				{
					if (global::랾.럓.랾.GetBlockType(i, j) == A_0)
					{
						Vector2i vector2i;
						vector2i..ctor(i, j);
						if (global::랾.랛.랾(vector2i.x, vector2i.y, A_1, false, false))
						{
							List<랛.랾> list2 = global::랾.랛.랾(A_1, vector2i, global::랾.랛.럎());
							if (list2 != null && list2.Count > 0)
							{
								list.Add(new ValueTuple<Vector2i, List<랛.랾>>(vector2i, list2));
								global::랾.럧.럎.Add(vector2i);
							}
						}
					}
				}
			}
			if (list.Count > 0)
			{
				ValueTuple<Vector2i, List<랛.랾>> valueTuple = list.OrderBy(new Func<ValueTuple<Vector2i, List<랛.랾>>, int>(global::랾.랆.랋.랾.럎)).First<ValueTuple<Vector2i, List<랛.랾>>>();
				if (A_1 != valueTuple.Item1)
				{
					List<랛.랾> item = valueTuple.Item2;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Teleporting to ");
					defaultInterpolatedStringHandler.AppendFormatted<World.BlockType>(A_0);
					global::랾.랆.랾(item, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				global::랾.럧.럎.Clear();
			}
			global::랾.럧.랄 = 0f;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000A9590 File Offset: 0x000A7790
		// Note: this type is marked as 'beforefieldinit'.
		static 랆()
		{
			World.BlockType[] array = new World.BlockType[5];
			RuntimeHelpers.InitializeArray(array, fieldof(global::랾.럖.럎).FieldHandle);
			global::랾.랆.랾 = array;
			global::랾.랆.랾 = "Idle";
			global::랾.랆.랾 = new 랓(0.35f);
			global::랾.랆.랞 = -1f;
			global::랾.랆.럚 = -1f;
			global::랾.랆.럳 = -1f;
			World.BlockType[] array2 = new World.BlockType[3];
			RuntimeHelpers.InitializeArray(array2, fieldof(global::랾.럖.럎).FieldHandle);
			global::랾.랆.럎 = array2;
			global::랾.랆.럎 = new 랓(5f);
			global::랾.랆.람 = new 랓(5f);
			global::랾.랆.럒 = new 랓(6f);
			global::랾.랆.랾 = new string[]
			{
				"COMMANDER_K",
				"ENDLESS",
				"SORSA",
				"MAEVE",
				"NOTPLEIST",
				"SUMMER",
				"EDWARDSON"
			};
			global::랾.랆.람 = new Vector2i(int.MinValue, int.MinValue);
			global::랾.랆.럎 = string.Empty;
			global::랾.랆.람 = string.Empty;
			global::랾.랆.럘 = 0f;
			global::랾.랆.랾 = global::랾.랆.럒.랾;
			global::랾.랆.럒 = global::랾.랆.람;
			global::랾.랆.럼 = global::랾.랆.람;
			global::랾.랆.랋 = global::랾.랆.람;
			global::랾.랆.럒 = string.Empty;
			global::랾.랆.랯 = int.MinValue;
			global::랾.랆.러 = 0;
			global::랾.랆.량 = int.MinValue;
			global::랾.랆.럎 = null;
			global::랾.랆.럑 = 0;
			global::랾.랆.랺 = 0f;
			global::랾.랆.럈 = 2.5f;
			global::랾.랆.럊 = 0;
			global::랾.랆.럼 = null;
			global::랾.랆.랱 = false;
			global::랾.랆.랋 = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
			global::랾.랆.럙 = false;
			global::랾.랆.랫 = true;
			global::랾.랆.럍 = false;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000407F9 File Offset: 0x0003E9F9
		[CompilerGenerated]
		internal static int 랋(Vector2i A_0, Vector2i A_1)
		{
			return Math.Abs(A_0.x - A_1.x) + Math.Abs(A_0.y - A_1.y);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000A97EC File Offset: 0x000A79EC
		[CompilerGenerated]
		internal static void 랾(Vector2i A_0, 랆.럎 A_1, ref 랆.랉 A_2)
		{
			List<랛.랾> list = global::랾.랛.랾(A_2.랾, A_0, global::랾.랛.럎());
			if (list != null && list.Count > 0)
			{
				A_2.랾.Add(new ValueTuple<Vector2i, List<랛.랾>, 랆.럎>(A_0, list, A_1));
			}
		}

		// Token: 0x04000596 RID: 1430
		private const int 랾 = 6;

		// Token: 0x04000597 RID: 1431
		private const float 랾 = 0.35f;

		// Token: 0x04000598 RID: 1432
		private const float 럎 = 1.25f;

		// Token: 0x04000599 RID: 1433
		private const float 람 = 1.25f;

		// Token: 0x0400059A RID: 1434
		private static float 럒;

		// Token: 0x0400059B RID: 1435
		private static float 럼;

		// Token: 0x0400059C RID: 1436
		private static float 랋;

		// Token: 0x0400059D RID: 1437
		private static int 럎 = -1;

		// Token: 0x0400059E RID: 1438
		private static 랆.람 랾;

		// Token: 0x0400059F RID: 1439
		private static Vector2i 랾 = new Vector2i(int.MinValue, int.MinValue);

		// Token: 0x040005A0 RID: 1440
		private static Vector2i 럎 = new Vector2i(int.MinValue, int.MinValue);

		// Token: 0x040005A1 RID: 1441
		private static bool 랾;

		// Token: 0x040005A2 RID: 1442
		private static bool 럎;

		// Token: 0x040005A3 RID: 1443
		private static bool 람;

		// Token: 0x040005A4 RID: 1444
		private static float 랉;

		// Token: 0x040005A5 RID: 1445
		private static float 럐;

		// Token: 0x040005A6 RID: 1446
		private static float 랓;

		// Token: 0x040005A7 RID: 1447
		private static bool 럒;

		// Token: 0x040005A8 RID: 1448
		private static bool 럼;

		// Token: 0x040005A9 RID: 1449
		private static bool 랋;

		// Token: 0x040005AA RID: 1450
		private static bool 랉;

		// Token: 0x040005AB RID: 1451
		private static float 럯;

		// Token: 0x040005AC RID: 1452
		private static float 럭;

		// Token: 0x040005AD RID: 1453
		private static bool 럐;

		// Token: 0x040005AE RID: 1454
		private static bool 랓;

		// Token: 0x040005AF RID: 1455
		private static float 랱 = -1f;

		// Token: 0x040005B0 RID: 1456
		private static int 람;

		// Token: 0x040005B1 RID: 1457
		private static int 럒;

		// Token: 0x040005B2 RID: 1458
		private static int 럼;

		// Token: 0x040005B3 RID: 1459
		private static int 랋;

		// Token: 0x040005B4 RID: 1460
		private static int 랉;

		// Token: 0x040005B5 RID: 1461
		private static float 럙 = -1f;

		// Token: 0x040005B6 RID: 1462
		private static float 랫 = -1f;

		// Token: 0x040005B7 RID: 1463
		private static float 럍 = -1f;

		// Token: 0x040005B8 RID: 1464
		private const int 럐 = 0;

		// Token: 0x040005B9 RID: 1465
		private const int 랓 = 1;

		// Token: 0x040005BA RID: 1466
		private const float 랬 = 6f;

		// Token: 0x040005BB RID: 1467
		private const float 란 = 5f;

		// Token: 0x040005BC RID: 1468
		private const float 럇 = 2.5f;

		// Token: 0x040005BD RID: 1469
		private const float 랯 = 0.75f;

		// Token: 0x040005BE RID: 1470
		private const int 럯 = 8;

		// Token: 0x040005BF RID: 1471
		private const float 러 = 0.35f;

		// Token: 0x040005C0 RID: 1472
		private static readonly HashSet<int> 랾 = new HashSet<int>
		{
			2406,
			2407,
			2408,
			2409,
			2410,
			2411,
			2412
		};

		// Token: 0x040005C1 RID: 1473
		private static MethodInfo 랾;

		// Token: 0x040005C2 RID: 1474
		private static GeneratedMineResultsUI 랾;

		// Token: 0x040005C3 RID: 1475
		private static float 량;

		// Token: 0x040005C4 RID: 1476
		private static LaboratoryBossMonoBehaviour 랾;

		// Token: 0x040005C5 RID: 1477
		private static float 럑;

		// Token: 0x040005C6 RID: 1478
		private static NetherBossWraithMonoBehaviour 랾;

		// Token: 0x040005C7 RID: 1479
		private static float 럊;

		// Token: 0x040005C8 RID: 1480
		private static CharacterCreationPopupUI 랾;

		// Token: 0x040005C9 RID: 1481
		private static float 랠;

		// Token: 0x040005CA RID: 1482
		private static WorldButtonsUI 랾;

		// Token: 0x040005CB RID: 1483
		private static float 럏;

		// Token: 0x040005CC RID: 1484
		private static readonly World.BlockType[] 랾;

		// Token: 0x040005CD RID: 1485
		private static MethodInfo 럎;

		// Token: 0x040005CE RID: 1486
		private static FieldInfo 랾;

		// Token: 0x040005CF RID: 1487
		private static FieldInfo 럎;

		// Token: 0x040005D0 RID: 1488
		private static FieldInfo 람;

		// Token: 0x040005D1 RID: 1489
		private static FieldInfo 럒;

		// Token: 0x040005D2 RID: 1490
		private static FieldInfo 럼;

		// Token: 0x040005D3 RID: 1491
		private static FieldInfo 랋;

		// Token: 0x040005D4 RID: 1492
		private static FieldInfo 랉;

		// Token: 0x040005D5 RID: 1493
		private static float 럫;

		// Token: 0x040005D6 RID: 1494
		private const float 럴 = 1.5f;

		// Token: 0x040005D7 RID: 1495
		private const float 럲 = 0.35f;

		// Token: 0x040005D8 RID: 1496
		private const float 럩 = 2.5f;

		// Token: 0x040005D9 RID: 1497
		private const float 랦 = 0.75f;

		// Token: 0x040005DA RID: 1498
		private const float 럔 = 15f;

		// Token: 0x040005DB RID: 1499
		private static string 랾;

		// Token: 0x040005DC RID: 1500
		private static bool 럯;

		// Token: 0x040005DD RID: 1501
		private static readonly 랓 랾;

		// Token: 0x040005DE RID: 1502
		private static bool 럭;

		// Token: 0x040005DF RID: 1503
		private static float 랞;

		// Token: 0x040005E0 RID: 1504
		private static float 럚;

		// Token: 0x040005E1 RID: 1505
		private static float 럳;

		// Token: 0x040005E2 RID: 1506
		private static readonly World.BlockType[] 럎;

		// Token: 0x040005E3 RID: 1507
		public static 랓 럎;

		// Token: 0x040005E4 RID: 1508
		public static 랓 람;

		// Token: 0x040005E5 RID: 1509
		public static 랓 럒;

		// Token: 0x040005E6 RID: 1510
		private const int 럭 = 10;

		// Token: 0x040005E7 RID: 1511
		private static readonly string[] 랾;

		// Token: 0x040005E8 RID: 1512
		private static readonly Vector2i 람;

		// Token: 0x040005E9 RID: 1513
		private const float 랢 = 0.175f;

		// Token: 0x040005EA RID: 1514
		private const float 럻 = 0.35f;

		// Token: 0x040005EB RID: 1515
		private const float 랖 = 0.25f;

		// Token: 0x040005EC RID: 1516
		private const int 랱 = 32;

		// Token: 0x040005ED RID: 1517
		private const int 럙 = 1;

		// Token: 0x040005EE RID: 1518
		private static float 럝;

		// Token: 0x040005EF RID: 1519
		private static float 럽;

		// Token: 0x040005F0 RID: 1520
		private static float 럜;

		// Token: 0x040005F1 RID: 1521
		private static float 럕;

		// Token: 0x040005F2 RID: 1522
		private static string 럎;

		// Token: 0x040005F3 RID: 1523
		private static string 람;

		// Token: 0x040005F4 RID: 1524
		private static float 럘;

		// Token: 0x040005F5 RID: 1525
		private const float 랟 = 5f;

		// Token: 0x040005F6 RID: 1526
		private static int 랫;

		// Token: 0x040005F7 RID: 1527
		private static int 럍;

		// Token: 0x040005F8 RID: 1528
		private static int 랬;

		// Token: 0x040005F9 RID: 1529
		private static int 란;

		// Token: 0x040005FA RID: 1530
		private static 랆.럒 랾;

		// Token: 0x040005FB RID: 1531
		private static Vector2i 럒;

		// Token: 0x040005FC RID: 1532
		private static Vector2i 럼;

		// Token: 0x040005FD RID: 1533
		private static Vector2i 랋;

		// Token: 0x040005FE RID: 1534
		private static string 럒;

		// Token: 0x040005FF RID: 1535
		private const int 럇 = 10;

		// Token: 0x04000600 RID: 1536
		private static int 랯;

		// Token: 0x04000601 RID: 1537
		private static int 러;

		// Token: 0x04000602 RID: 1538
		private static int 량;

		// Token: 0x04000603 RID: 1539
		public static string[] 럎;

		// Token: 0x04000604 RID: 1540
		public static int 럑;

		// Token: 0x04000605 RID: 1541
		public static float 랺;

		// Token: 0x04000606 RID: 1542
		public static float 럈;

		// Token: 0x04000607 RID: 1543
		public static int 럊;

		// Token: 0x04000608 RID: 1544
		public static string 럼;

		// Token: 0x04000609 RID: 1545
		public static bool 랱;

		// Token: 0x0400060A RID: 1546
		private static string 랋;

		// Token: 0x0400060B RID: 1547
		public static bool 럙;

		// Token: 0x0400060C RID: 1548
		public static bool 랫;

		// Token: 0x0400060D RID: 1549
		public static bool 럍;

		// Token: 0x0400060E RID: 1550
		public static float 럧;

		// Token: 0x0400060F RID: 1551
		public static float 럓;

		// Token: 0x02000108 RID: 264
		private enum 랾
		{
			// Token: 0x04000611 RID: 1553
			랾,
			// Token: 0x04000612 RID: 1554
			럎,
			// Token: 0x04000613 RID: 1555
			람,
			// Token: 0x04000614 RID: 1556
			럒
		}

		// Token: 0x02000109 RID: 265
		private enum 럎
		{
			// Token: 0x04000616 RID: 1558
			랾,
			// Token: 0x04000617 RID: 1559
			럎,
			// Token: 0x04000618 RID: 1560
			람,
			// Token: 0x04000619 RID: 1561
			럒
		}

		// Token: 0x0200010A RID: 266
		private sealed class 람
		{
			// Token: 0x0400061A RID: 1562
			public 랆.랾 랾;

			// Token: 0x0400061B RID: 1563
			public Vector2i 랾;

			// Token: 0x0400061C RID: 1564
			public Vector2i 럎;

			// Token: 0x0400061D RID: 1565
			public List<랛.랾> 랾 = new List<랛.랾>();

			// Token: 0x0400061E RID: 1566
			public List<랛.랾> 럎 = new List<랛.랾>();

			// Token: 0x0400061F RID: 1567
			public float 랾 = float.PositiveInfinity;
		}

		// Token: 0x0200010B RID: 267
		private enum 럒
		{
			// Token: 0x04000621 RID: 1569
			랾,
			// Token: 0x04000622 RID: 1570
			럎,
			// Token: 0x04000623 RID: 1571
			람,
			// Token: 0x04000624 RID: 1572
			럒
		}

		// Token: 0x0200010C RID: 268
		private sealed class 럼
		{
			// Token: 0x04000625 RID: 1573
			public Vector2i 랾;

			// Token: 0x04000626 RID: 1574
			public Vector2i 럎;

			// Token: 0x04000627 RID: 1575
			public bool 랾;

			// Token: 0x04000628 RID: 1576
			public List<랛.랾> 랾 = new List<랛.랾>();

			// Token: 0x04000629 RID: 1577
			public int 랾 = int.MaxValue;
		}

		// Token: 0x0200010D RID: 269
		[CompilerGenerated]
		[Serializable]
		private sealed class 랋
		{
			// Token: 0x06000811 RID: 2065 RVA: 0x00040873 File Offset: 0x0003EA73
			internal Vector2i 랾([TupleElementNames(new string[]
			{
				"Pos",
				"Dist"
			})] ValueTuple<Vector2i, float> c)
			{
				return c.Item1;
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x0004087B File Offset: 0x0003EA7B
			internal CollectableData 랾([TupleElementNames(new string[]
			{
				"Collectable",
				"Dist"
			})] ValueTuple<CollectableData, float> c)
			{
				return c.Item1;
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x00040883 File Offset: 0x0003EA83
			internal int 랾([TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})] ValueTuple<int, Vector2i> a, [TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})] ValueTuple<int, Vector2i> b)
			{
				return a.Item1.CompareTo(b.Item1);
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x00040883 File Offset: 0x0003EA83
			internal int 럎([TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})] ValueTuple<int, Vector2i> a, [TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})] ValueTuple<int, Vector2i> b)
			{
				return a.Item1.CompareTo(b.Item1);
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x00040883 File Offset: 0x0003EA83
			internal int 람([TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})] ValueTuple<int, Vector2i> a, [TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})] ValueTuple<int, Vector2i> b)
			{
				return a.Item1.CompareTo(b.Item1);
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x00040897 File Offset: 0x0003EA97
			internal int 랾([TupleElementNames(new string[]
			{
				"Position",
				"Path",
				"Kind"
			})] ValueTuple<Vector2i, List<랛.랾>, 랆.럎> t)
			{
				return t.Item2.Count;
			}

			// Token: 0x06000817 RID: 2071 RVA: 0x000408A4 File Offset: 0x0003EAA4
			internal string 랾(string A_1)
			{
				return A_1.Trim();
			}

			// Token: 0x06000818 RID: 2072 RVA: 0x000408AC File Offset: 0x0003EAAC
			internal bool 럎(string A_1)
			{
				return !string.IsNullOrEmpty(A_1);
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x000408B7 File Offset: 0x0003EAB7
			internal int 랾([TupleElementNames(new string[]
			{
				"Position",
				"Path"
			})] ValueTuple<Vector2i, List<랛.랾>> e)
			{
				return e.Item2.Count;
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x000408B7 File Offset: 0x0003EAB7
			internal int 럎([TupleElementNames(new string[]
			{
				"Position",
				"Path"
			})] ValueTuple<Vector2i, List<랛.랾>> b)
			{
				return b.Item2.Count;
			}

			// Token: 0x0400062A RID: 1578
			public static readonly 랆.랋 랾 = new 랆.랋();

			// Token: 0x0400062B RID: 1579
			[TupleElementNames(new string[]
			{
				"Pos",
				"Dist"
			})]
			public static Func<ValueTuple<Vector2i, float>, Vector2i> 랾;

			// Token: 0x0400062C RID: 1580
			[TupleElementNames(new string[]
			{
				"Collectable",
				"Dist"
			})]
			public static Func<ValueTuple<CollectableData, float>, CollectableData> 랾;

			// Token: 0x0400062D RID: 1581
			[TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})]
			public static Comparison<ValueTuple<int, Vector2i>> 랾;

			// Token: 0x0400062E RID: 1582
			[TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})]
			public static Comparison<ValueTuple<int, Vector2i>> 럎;

			// Token: 0x0400062F RID: 1583
			[TupleElementNames(new string[]
			{
				"dist",
				"pos"
			})]
			public static Comparison<ValueTuple<int, Vector2i>> 람;

			// Token: 0x04000630 RID: 1584
			[TupleElementNames(new string[]
			{
				"Position",
				"Path",
				"Kind"
			})]
			public static Func<ValueTuple<Vector2i, List<랛.랾>, 랆.럎>, int> 랾;

			// Token: 0x04000631 RID: 1585
			public static Func<string, string> 랾;

			// Token: 0x04000632 RID: 1586
			public static Func<string, bool> 랾;

			// Token: 0x04000633 RID: 1587
			[TupleElementNames(new string[]
			{
				"Position",
				"Path"
			})]
			public static Func<ValueTuple<Vector2i, List<랛.랾>>, int> 랾;

			// Token: 0x04000634 RID: 1588
			[TupleElementNames(new string[]
			{
				"Position",
				"Path"
			})]
			public static Func<ValueTuple<Vector2i, List<랛.랾>>, int> 럎;
		}

		// Token: 0x0200010E RID: 270
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct 랉
		{
			// Token: 0x04000635 RID: 1589
			public Vector2i 랾;

			// Token: 0x04000636 RID: 1590
			[TupleElementNames(new string[]
			{
				"Position",
				"Path",
				"Kind"
			})]
			public List<ValueTuple<Vector2i, List<랛.랾>, 랆.럎>> 랾;
		}

		// Token: 0x0200010F RID: 271
		[CompilerGenerated]
		private sealed class 럐
		{
			// Token: 0x0600081C RID: 2076 RVA: 0x000408C4 File Offset: 0x0003EAC4
			internal double 랾(Vector2i A_1)
			{
				return global::랾.랆.랾(this.랾, A_1);
			}

			// Token: 0x04000637 RID: 1591
			public Vector2i 랾;
		}
	}
}
