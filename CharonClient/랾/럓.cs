using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BasicTypes;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using CharonClient.Configuration;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000077 RID: 119
	public sealed class 럓
	{
		// Token: 0x06000446 RID: 1094 RVA: 0x0003EA0C File Offset: 0x0003CC0C
		internal static void 랾()
		{
			global::랾.럓.럎 = Time.frameCount;
			if (!global::랾.럓.럎)
			{
				global::랾.럓.럎 = true;
				global::랾.럓.랾("Overlay render active.", false);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0003EA30 File Offset: 0x0003CC30
		internal static void 럎()
		{
			if (global::랾.럓.랾)
			{
				return;
			}
			global::랾.럓.랾 = true;
			global::랾.럓.랾("Session update active.", false);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000839D8 File Offset: 0x00081BD8
		internal static void 랾(World A_0)
		{
			if (global::랾.럓.람 || A_0 == null || global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				return;
			}
			global::랾.럓.람 = true;
			string str = string.IsNullOrWhiteSpace(A_0.worldName) ? "Unknown" : A_0.worldName;
			global::랾.럓.랾("World data ready (" + str + ").", false);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00083A3C File Offset: 0x00081C3C
		internal static void 랾(string A_0)
		{
			if (!string.Equals(A_0, "Server", StringComparison.OrdinalIgnoreCase))
			{
				if (string.Equals(A_0, "Client", StringComparison.OrdinalIgnoreCase))
				{
					if (global::랾.럓.랋)
					{
						return;
					}
					global::랾.럓.랋 = true;
					global::랾.럓.랾("Outgoing traffic detected.", false);
				}
				return;
			}
			if (global::랾.럓.럼)
			{
				return;
			}
			global::랾.럓.럼 = true;
			global::랾.럓.랾("Incoming traffic detected.", false);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00083A98 File Offset: 0x00081C98
		internal static void 람()
		{
			if (global::랾.럽.람())
			{
				if (!global::랾.럓.랉)
				{
					global::랾.럓.랉 = true;
					global::랾.럓.럐 = false;
					global::랾.럓.랓 = false;
					global::랾.럓.랾 = Time.realtimeSinceStartup;
					global::랾.럓.랾("World join started.", false);
					return;
				}
				if (!global::랾.럓.럐 && global::랾.럓.랾 >= 0f && Time.realtimeSinceStartup - global::랾.럓.랾 >= 20f)
				{
					global::랾.럓.럐 = true;
					global::랾.럓.랾("World join is taking longer than expected.", true);
				}
				return;
			}
			else
			{
				if (global::랾.럽.랾())
				{
					if (!global::랾.럓.럒)
					{
						global::랾.럓.럒 = true;
						string str = (global::랾.럓.랾 != null && !string.IsNullOrWhiteSpace(global::랾.럓.랾.worldName)) ? global::랾.럓.랾.worldName : "Unknown";
						global::랾.럓.랾("Entered world (" + str + ").", false);
					}
					global::랾.럓.랉 = false;
					global::랾.럓.럐 = false;
					global::랾.럓.랓 = false;
					global::랾.럓.랾 = -1f;
					return;
				}
				if (global::랾.럓.랉 && !global::랾.럓.랓)
				{
					global::랾.럓.랓 = true;
					global::랾.럓.랾("World join ended before room was ready.", true);
				}
				return;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00083BA4 File Offset: 0x00081DA4
		private static void 랾(string A_0, bool A_1 = false)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			if (A_1)
			{
				ManualLogSource manualLogSource = global::랾.럴.랾();
				if (manualLogSource != null)
				{
					bool flag;
					BepInExWarningLogInterpolatedStringHandler bepInExWarningLogInterpolatedStringHandler = new BepInExWarningLogInterpolatedStringHandler(10, 1, ref flag);
					if (flag)
					{
						bepInExWarningLogInterpolatedStringHandler.AppendLiteral("[Session] ");
						bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(A_0);
					}
					manualLogSource.LogWarning(bepInExWarningLogInterpolatedStringHandler);
					return;
				}
			}
			else
			{
				ManualLogSource manualLogSource = global::랾.럴.랾();
				if (manualLogSource != null)
				{
					bool flag;
					BepInExInfoLogInterpolatedStringHandler bepInExInfoLogInterpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(10, 1, ref flag);
					if (flag)
					{
						bepInExInfoLogInterpolatedStringHandler.AppendLiteral("[Session] ");
						bepInExInfoLogInterpolatedStringHandler.AppendFormatted<string>(A_0);
					}
					manualLogSource.LogInfo(bepInExInfoLogInterpolatedStringHandler);
				}
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00083C20 File Offset: 0x00081E20
		internal static 랊 럒()
		{
			return new 랊(global::랾.럓.랾, global::랾.럓.랾, global::랾.럓.럎, global::랾.럓.람, global::랾.럓.럒, global::랾.럓.랾 != null, global::랾.럓.랾 != null, global::랾.럓.랾 != null, global::랾.럽.랾(), ConfigFile.showMenu, ConfigFile.packetConsole, global::랾.럧.랋, ConfigFile.fakeLagToggle);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00083C84 File Offset: 0x00081E84
		private static void 럼()
		{
			global::랾.럓.랾 = "Idle";
			global::랾.럓.랾 = -1;
			global::랾.럓.럎 = -1;
			global::랾.럓.람 = -1;
			global::랾.럓.럒 = 0;
			global::랾.럓.랾 = false;
			global::랾.럓.럎 = false;
			global::랾.럓.람 = false;
			global::랾.럓.럒 = false;
			global::랾.럓.럼 = false;
			global::랾.럓.랋 = false;
			global::랾.럓.랉 = false;
			global::랾.럓.럐 = false;
			global::랾.럓.랓 = false;
			global::랾.럓.랾 = -1f;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00083CF4 File Offset: 0x00081EF4
		public static void 럎(string A_0)
		{
			int frameCount = Time.frameCount;
			if (global::랾.럓.럼 == frameCount)
			{
				return;
			}
			global::랾.럓.랾 = A_0;
			global::랾.럓.랾 = frameCount;
			global::랾.럓.럒++;
			global::랾.럓.럼 = frameCount;
			try
			{
				global::랾.럓.랾.럭();
			}
			catch (Exception ex)
			{
				global::랾.럓.랾("Tick", ex, 10f);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00083D60 File Offset: 0x00081F60
		public static void 랋()
		{
			global::랾.럓.람 = Time.frameCount;
			try
			{
				global::랾.럓.랾.랪();
			}
			catch (Exception ex)
			{
				global::랾.럓.랾("RenderEspOverlay", ex, 10f);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00083DA8 File Offset: 0x00081FA8
		public static void 랉()
		{
			global::랾.럓.럼 = -1;
			global::랾.럓.럯 = false;
			global::랾.럓.랾.Clear();
			global::랾.럓.럎.Clear();
			global::랾.럓.랾.럐();
			global::랾.럓.럼();
			global::랾.럩.람();
			global::랾.럲.럎();
			랳.럽();
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00083E18 File Offset: 0x00082018
		private static void 랾(string A_0, Exception A_1, float A_2 = 10f)
		{
			if (A_1 == null)
			{
				return;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(A_1.GetType().FullName);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(A_1.Message);
			string key = defaultInterpolatedStringHandler.ToStringAndClear();
			float num;
			if (global::랾.럓.랾.TryGetValue(key, out num) && realtimeSinceStartup - num < A_2)
			{
				return;
			}
			global::랾.럓.랾[key] = realtimeSinceStartup;
			string text = A_0;
			if (string.Equals(A_0, "Tick", StringComparison.Ordinal) && !string.IsNullOrWhiteSpace(global::랾.럓.랾) && !string.Equals(global::랾.럓.랾, A_0, StringComparison.Ordinal))
			{
				text = A_0 + ":" + global::랾.럓.랾;
			}
			ManualLogSource manualLogSource = global::랾.럴.랾();
			if (manualLogSource != null)
			{
				bool flag;
				BepInExWarningLogInterpolatedStringHandler bepInExWarningLogInterpolatedStringHandler = new BepInExWarningLogInterpolatedStringHandler(5, 3, ref flag);
				if (flag)
				{
					bepInExWarningLogInterpolatedStringHandler.AppendLiteral("[");
					bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(text);
					bepInExWarningLogInterpolatedStringHandler.AppendLiteral("] ");
					bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(A_1.GetType().Name);
					bepInExWarningLogInterpolatedStringHandler.AppendLiteral(": ");
					bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(A_1.Message);
				}
				manualLogSource.LogWarning(bepInExWarningLogInterpolatedStringHandler);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00083F4C File Offset: 0x0008214C
		private static void 랾(Action A_0, string A_1, Action A_2 = null, float A_3 = 10f)
		{
			try
			{
				A_0();
			}
			catch (Exception ex)
			{
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float num;
				if (!global::랾.럓.럎.TryGetValue(A_1, out num) || realtimeSinceStartup - num >= A_3)
				{
					global::랾.럓.럎[A_1] = realtimeSinceStartup;
					ManualLogSource manualLogSource = global::랾.럴.랾();
					if (manualLogSource != null)
					{
						bool flag;
						BepInExWarningLogInterpolatedStringHandler bepInExWarningLogInterpolatedStringHandler = new BepInExWarningLogInterpolatedStringHandler(9, 3, ref flag);
						if (flag)
						{
							bepInExWarningLogInterpolatedStringHandler.AppendLiteral("[ESP:");
							bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(A_1);
							bepInExWarningLogInterpolatedStringHandler.AppendLiteral("] ");
							bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(ex.GetType().Name);
							bepInExWarningLogInterpolatedStringHandler.AppendLiteral(": ");
							bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(ex.Message);
						}
						manualLogSource.LogWarning(bepInExWarningLogInterpolatedStringHandler);
					}
				}
				if (A_2 != null)
				{
					A_2();
				}
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0003EA4B File Offset: 0x0003CC4B
		private void 럐()
		{
			this.럒.랋();
			this.럼.랋();
			this.람.랋();
			this.랬 = false;
			this.랉 = 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0003CE27 File Offset: 0x0003B027
		private static void 람(string A_0)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00084014 File Offset: 0x00082214
		private static void 랓()
		{
			try
			{
				global::랾.랖.랾();
				global::랾.럜.럎();
				if (File.Exists(global::랾.럧.럊))
				{
					File.Delete(global::랾.럧.럊);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00084058 File Offset: 0x00082258
		private void 럯()
		{
			럓.랋 랋;
			랋.랾 = AsyncVoidMethodBuilder.Create();
			랋.랾 = this;
			랋.랾 = -1;
			랋.랾.Start<럓.랋>(ref 랋);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00084090 File Offset: 0x00082290
		private void 럭()
		{
			global::랾.럟.랾();
			global::랾.럓.럎();
			global::랾.럓.럍();
			랅.럎();
			this.럇();
			this.랯();
			this.러();
			this.량();
			global::랾.럩.럒();
			global::랾.럲.람();
			global::랾.럓.랫();
			this.럜();
			this.럕();
			this.럩();
			this.럔();
			this.랦();
			if (ConfigFile.antiWiringCrash)
			{
				럅.랬();
			}
			if (global::랾.럧.랃)
			{
				랆.럎람();
			}
			if (global::랾.럧.랐)
			{
				랆.럎랾();
			}
			if (global::랾.럧.럆)
			{
				랐.럐();
			}
			this.럑();
			global::랾.럓.람();
			if (global::랾.럽.랾())
			{
				this.럚();
			}
			else
			{
				this.럳();
			}
			this.랞();
			if (global::랾.럧.랉)
			{
				foreach (object obj in Enum.GetValues(typeof(KeyCode)))
				{
					KeyCode keyCode = (KeyCode)obj;
					if (keyCode != null)
					{
						bool flag = keyCode >= 8 && keyCode <= 319;
						bool flag2 = keyCode >= 323 && keyCode <= 329;
						if ((flag || flag2) && 랅.럎(keyCode))
						{
							global::랾.럓.랾(keyCode);
							global::랾.럧.랉 = false;
							global::랾.럧.랾 = global::랾.럧.랾.랾;
							break;
						}
					}
				}
			}
			this.럎.럎(Time.deltaTime);
			this.람.럎(Time.deltaTime);
			this.럼.럎(Time.deltaTime);
			this.럒.럎(Time.deltaTime);
			if (this.럒.럒() && !this.랬)
			{
				this.럒.랋();
			}
			if (!this.란 && !this.럭)
			{
				this.란 = true;
				this.랬();
			}
			this.랋.럎(Time.deltaTime);
			if (this.랋.럒() && !this.럭)
			{
				this.랋.랋();
				this.랬();
			}
			global::랾.럽.랾();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0003EA7C File Offset: 0x0003CC7C
		public static void 랱()
		{
			global::랾.럓.랾 = true;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0003EA86 File Offset: 0x0003CC86
		public static void 럙()
		{
			global::랾.럓.럎 = true;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000842AC File Offset: 0x000824AC
		private static void 랫()
		{
			if (global::랾.럓.랾 == "ImGui")
			{
				return;
			}
			try
			{
				if (global::랾.럓.럎)
				{
					global::랾.럓.럎 = false;
					global::랾.럓.랾 = false;
					SceneLoader.ReloadGame();
				}
				else if (global::랾.럓.랾)
				{
					global::랾.럓.랾 = false;
					SceneLoader.ReloadWorld();
				}
			}
			catch (Exception ex)
			{
				global::랾.럓.랾 = false;
				global::랾.럓.럎 = false;
				global::랾.럓.랾("DeferredUiAction", ex, 0f);
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00084338 File Offset: 0x00082538
		private static void 럍()
		{
			global::랾.럓.랾.람(Time.deltaTime);
			if (global::랾.럓.랾.럒())
			{
				global::랾.럓.랾.랋();
				if (ConfigFile.fpsCapToggle)
				{
					QualitySettings.vSyncCount = 0;
					Application.targetFrameRate = ConfigFile.maxFps;
					return;
				}
				Application.targetFrameRate = -1;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0008438C File Offset: 0x0008258C
		private void 랬()
		{
			럓.럼 럼;
			럼.랾 = AsyncVoidMethodBuilder.Create();
			럼.랾 = this;
			럼.랾 = -1;
			럼.랾.Start<럓.럼>(ref 럼);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000843C4 File Offset: 0x000825C4
		public static bool 럒(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			object obj = global::랾.럓.랾;
			lock (obj)
			{
				using (List<string>.Enumerator enumerator = global::랾.럧.람.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (string.Equals(enumerator.Current, A_0, StringComparison.OrdinalIgnoreCase))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00084450 File Offset: 0x00082650
		public static string 란()
		{
			object obj = global::랾.럓.랾;
			string result;
			lock (obj)
			{
				if (global::랾.럧.람.Count == 0)
				{
					result = "No users online.";
				}
				else
				{
					result = string.Join(", ", global::랾.럧.람);
				}
			}
			return result;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0003EA90 File Offset: 0x0003CC90
		private void 럇()
		{
			global::랾.럧.럍 += Time.deltaTime;
			if (global::랾.럧.럍 >= 30f)
			{
				ConfigFile.럼();
				global::랾.럧.럍 = 0f;
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000844B0 File Offset: 0x000826B0
		private void 랯()
		{
			global::랾.럧.럐 += Time.deltaTime;
			if (global::랾.럧.럐 >= 1f)
			{
				global::랾.럧.랋 = 1f / Time.unscaledDeltaTime;
				global::랾.럧.랉 = (float)Math.Round((double)global::랾.럧.랋);
				global::랾.럧.럐 = 0f;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0003EABD File Offset: 0x0003CCBD
		private void 러()
		{
			global::랾.럓.람 += Time.deltaTime;
			if (global::랾.럓.람 < 15f)
			{
				return;
			}
			global::랾.럓.람 = 0f;
			global::랾.랞.럎();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00084504 File Offset: 0x00082704
		private void 량()
		{
			WorldController worldController = ControllerHelper.worldController;
			global::랾.럓.랾 = ControllerHelper.chatUI;
			if (worldController == null)
			{
				global::랾.럓.랾 = null;
				global::랾.럓.랾 = null;
				global::랾.럓.랾 = null;
				global::랾.럓.랾 = null;
				global::랾.럓.랾 = null;
				return;
			}
			global::랾.럓.랾 = worldController.player;
			global::랾.럓.랾 = ((global::랾.럓.랾 != null) ? global::랾.럓.랾.myPlayerData : null);
			global::랾.럓.랾 = worldController.world;
			global::랾.럓.랾(global::랾.럓.랾);
			global::랾.럓.럼 += Time.deltaTime;
			if (global::랾.럓.럼 < 0.5f)
			{
				return;
			}
			global::랾.럓.럼 = 0f;
			global::랾.럓.랾 = Object.FindObjectOfType<FishingResultsPopupUI>();
			global::랾.럓.랾 = Object.FindObjectOfType<FishingGaugeMinigameUI>();
			if (!global::랾.럓.럯 && global::랾.럓.랾 != null)
			{
				global::랾.럧.랉 = global::랾.럓.랾.jumpMode;
				global::랾.럓.럯 = true;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0003EAEB File Offset: 0x0003CCEB
		private void 럑()
		{
			if (global::랾.럽.럎())
			{
				ConfigFile.pausedLeaveToggle = true;
				return;
			}
			if (global::랾.럽.람())
			{
				ConfigFile.pausedLeaveToggle = false;
			}
		}

		// Token: 0x06000464 RID: 1124
		[DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent")]
		private static extern bool 럊();

		// Token: 0x06000465 RID: 1125
		[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent")]
		private static extern bool 랾(IntPtr, ref bool);

		// Token: 0x06000466 RID: 1126 RVA: 0x000845EC File Offset: 0x000827EC
		public static void 랠()
		{
			if (global::랾.럓.럏())
			{
				if (!global::랾.럓.럇)
				{
					global::랾.럓.럇 = true;
					string text = "tampering";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(95, 4);
					defaultInterpolatedStringHandler.AppendLiteral("Discord User: ");
					defaultInterpolatedStringHandler.AppendFormatted(global::랾.럧.럙);
					defaultInterpolatedStringHandler.AppendLiteral(", Discord ID: ");
					defaultInterpolatedStringHandler.AppendFormatted(global::랾.럧.랫);
					defaultInterpolatedStringHandler.AppendLiteral(", Machine: ");
					defaultInterpolatedStringHandler.AppendFormatted(global::랾.랱.랾());
					defaultInterpolatedStringHandler.AppendLiteral(", Client: ");
					defaultInterpolatedStringHandler.AppendFormatted("2.0");
					defaultInterpolatedStringHandler.AppendLiteral(" | Debugger attached to process. Closing game.");
					global::랾.럕.랾(text, defaultInterpolatedStringHandler.ToStringAndClear());
					global::랾.럧.럍 = "Debugger detected";
				}
				Application.Quit();
				return;
			}
			global::랾.럓.랓 += Time.deltaTime;
			if (global::랾.럓.랓 >= 30f)
			{
				global::랾.럓.랓 = 0f;
				global::랾.럓.럲();
			}
			global::랾.럓.랉 += Time.deltaTime;
			if (global::랾.럓.랉 < 5f)
			{
				return;
			}
			global::랾.럓.랉 = 0f;
			global::랾.럓.럫();
			global::랾.럧.럍 = "No debugger detected";
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0008470C File Offset: 0x0008290C
		private static bool 럏()
		{
			bool flag = false;
			global::랾.럓.랾(Process.GetCurrentProcess().Handle, ref flag);
			return global::랾.럓.럊() || flag;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0003EB08 File Offset: 0x0003CD08
		private static void 럫()
		{
			if (global::랾.럓.람)
			{
				return;
			}
			global::랾.럓.람 = true;
			Task.Run(new Action(global::랾.럓.럎.랾.랾));
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00084734 File Offset: 0x00082934
		private static bool 럴()
		{
			bool flag = false;
			Process[] processes;
			try
			{
				processes = Process.GetProcesses();
			}
			catch
			{
				return global::랾.럓.럒;
			}
			foreach (Process process in processes)
			{
				try
				{
					string text = global::랾.럓.럼(process.ProcessName);
					if (!string.IsNullOrWhiteSpace(text))
					{
						if (!flag && global::랾.럓.랋(text))
						{
							flag = true;
						}
						string value;
						if (global::랾.럓.랾(text, out value))
						{
							string text2 = "tampering";
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(69, 5);
							defaultInterpolatedStringHandler.AppendLiteral("Discord User: ");
							defaultInterpolatedStringHandler.AppendFormatted(global::랾.럧.럙);
							defaultInterpolatedStringHandler.AppendLiteral(", Discord ID: ");
							defaultInterpolatedStringHandler.AppendFormatted(global::랾.럧.랫);
							defaultInterpolatedStringHandler.AppendLiteral(", Machine: ");
							defaultInterpolatedStringHandler.AppendFormatted(global::랾.랱.랾());
							defaultInterpolatedStringHandler.AppendLiteral(", Client: ");
							defaultInterpolatedStringHandler.AppendFormatted("2.0");
							defaultInterpolatedStringHandler.AppendLiteral(" | ");
							defaultInterpolatedStringHandler.AppendFormatted(value);
							defaultInterpolatedStringHandler.AppendLiteral(". Process killed.");
							global::랾.럕.랾(text2, defaultInterpolatedStringHandler.ToStringAndClear());
							try
							{
								process.Kill();
								process.WaitForExit(500);
							}
							catch
							{
							}
						}
					}
				}
				catch
				{
				}
				finally
				{
					process.Dispose();
				}
			}
			return flag;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000848AC File Offset: 0x00082AAC
		private static string 럼(string A_0)
		{
			return (A_0 ?? string.Empty).Replace(".exe", string.Empty, StringComparison.OrdinalIgnoreCase).Replace("-", string.Empty).Replace("_", string.Empty).Trim().ToLowerInvariant();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000848FC File Offset: 0x00082AFC
		private static bool 랋(string A_0)
		{
			foreach (string value in global::랾.럓.럎)
			{
				if (A_0.Contains(value, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00084930 File Offset: 0x00082B30
		private static bool 랾(string A_0, out string A_1)
		{
			foreach (string text in global::랾.럓.랾)
			{
				string b = global::랾.럓.럼(text);
				if (string.Equals(A_0, b, StringComparison.OrdinalIgnoreCase))
				{
					string text2;
					if (text != null)
					{
						switch (text.Length)
						{
						case 3:
							if (!(text == "ida"))
							{
								goto IL_3CC;
							}
							goto IL_3AE;
						case 4:
						case 10:
						case 14:
							goto IL_3CC;
						case 5:
						{
							char c = text[1];
							if (c != 'd')
							{
								if (c != 'l')
								{
									if (c != 'n')
									{
										goto IL_3CC;
									}
									if (!(text == "dnspy"))
									{
										goto IL_3CC;
									}
									goto IL_390;
								}
								else
								{
									if (!(text == "ilspy"))
									{
										goto IL_3CC;
									}
									goto IL_390;
								}
							}
							else
							{
								if (!(text == "ida64"))
								{
									goto IL_3CC;
								}
								goto IL_3AE;
							}
							break;
						}
						case 6:
						{
							char c = text[1];
							if (c <= '6')
							{
								if (c != '3')
								{
									if (c != '6')
									{
										goto IL_3CC;
									}
									if (!(text == "x64dbg"))
									{
										goto IL_3CC;
									}
									goto IL_3AE;
								}
								else
								{
									if (!(text == "x32dbg"))
									{
										goto IL_3CC;
									}
									goto IL_3AE;
								}
							}
							else if (c != 'e')
							{
								if (c != 'i')
								{
									goto IL_3CC;
								}
								if (!(text == "windbg"))
								{
									goto IL_3CC;
								}
								goto IL_3AE;
							}
							else
							{
								if (!(text == "de4dot"))
								{
									goto IL_3CC;
								}
								goto IL_390;
							}
							break;
						}
						case 7:
						{
							char c = text[0];
							switch (c)
							{
							case 'c':
								if (!(text == "charles"))
								{
									goto IL_3CC;
								}
								break;
							case 'd':
								if (!(text == "dotpeek"))
								{
									goto IL_3CC;
								}
								goto IL_390;
							case 'e':
								goto IL_3CC;
							case 'f':
								if (!(text == "fiddler"))
								{
									goto IL_3CC;
								}
								break;
							default:
								if (c != 'o')
								{
									goto IL_3CC;
								}
								if (!(text == "ollydbg"))
								{
									goto IL_3CC;
								}
								goto IL_3AE;
							}
							break;
						}
						case 8:
							if (!(text == "artmoney"))
							{
								goto IL_3CC;
							}
							goto IL_39F;
						case 9:
						{
							char c = text[0];
							if (c != 'b')
							{
								if (c != 'm')
								{
									if (c != 'w')
									{
										goto IL_3CC;
									}
									if (!(text == "wireshark"))
									{
										goto IL_3CC;
									}
								}
								else if (!(text == "mitmproxy"))
								{
									goto IL_3CC;
								}
							}
							else if (!(text == "burpsuite"))
							{
								goto IL_3CC;
							}
							break;
						}
						case 11:
							if (!(text == "cheatengine"))
							{
								goto IL_3CC;
							}
							goto IL_39F;
						case 12:
						{
							char c = text[0];
							if (c != 'c')
							{
								if (c != 'g')
								{
									if (c != 'h')
									{
										goto IL_3CC;
									}
									if (!(text == "httpdebugger"))
									{
										goto IL_3CC;
									}
								}
								else
								{
									if (!(text == "gameguardian"))
									{
										goto IL_3CC;
									}
									goto IL_39F;
								}
							}
							else
							{
								if (!(text == "cheat engine"))
								{
									goto IL_3CC;
								}
								goto IL_39F;
							}
							break;
						}
						case 13:
						{
							char c = text[0];
							if (c != 'j')
							{
								if (c != 'p')
								{
									goto IL_3CC;
								}
								if (!(text == "processhacker"))
								{
									goto IL_3CC;
								}
								goto IL_3BD;
							}
							else
							{
								if (!(text == "justdecompile"))
								{
									goto IL_3CC;
								}
								goto IL_390;
							}
							break;
						}
						case 15:
						{
							char c = text[0];
							if (c != 'e')
							{
								if (c != 'p')
								{
									goto IL_3CC;
								}
								if (!(text == "processexplorer"))
								{
									goto IL_3CC;
								}
								goto IL_3BD;
							}
							else
							{
								if (!(text == "extremeinjector"))
								{
									goto IL_3CC;
								}
								goto IL_3BD;
							}
							break;
						}
						default:
							goto IL_3CC;
						}
						text2 = "Network interceptor detected: " + text;
						goto IL_3D9;
						IL_390:
						text2 = "Decompiler detected: " + text;
						goto IL_3D9;
						IL_39F:
						text2 = "Memory editor detected: " + text;
						goto IL_3D9;
						IL_3AE:
						text2 = "Debugger detected: " + text;
						goto IL_3D9;
						IL_3BD:
						text2 = "DLL injector detected: " + text;
						goto IL_3D9;
					}
					IL_3CC:
					text2 = "Blocked process detected: " + text;
					IL_3D9:
					A_1 = text2;
					return true;
				}
			}
			A_1 = string.Empty;
			return false;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00084D34 File Offset: 0x00082F34
		private static void 럲()
		{
			GameObject gameObject = GameObject.Find("UniverseLibCanvas");
			if (gameObject == null)
			{
				global::랾.럓.랯 = false;
				return;
			}
			Object.Destroy(gameObject);
			if (global::랾.럓.랯)
			{
				return;
			}
			global::랾.럓.랯 = true;
			string text = "tampering";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(96, 4);
			defaultInterpolatedStringHandler.AppendLiteral("Discord User: ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.럧.럙);
			defaultInterpolatedStringHandler.AppendLiteral(", Discord ID: ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.럧.랫);
			defaultInterpolatedStringHandler.AppendLiteral(", Machine: ");
			defaultInterpolatedStringHandler.AppendFormatted(global::랾.랱.랾());
			defaultInterpolatedStringHandler.AppendLiteral(", Client: ");
			defaultInterpolatedStringHandler.AppendFormatted("2.0");
			defaultInterpolatedStringHandler.AppendLiteral(" | UniverseLib Explorer detected and destroyed.");
			global::랾.럕.랾(text, defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00084DF8 File Offset: 0x00082FF8
		private void 럩()
		{
			bool flag = global::랾.럧.랋;
			global::랾.럧.랋 = global::랾.럓.럒;
			if (!global::랾.럧.랋 || flag)
			{
				return;
			}
			Console.Clear();
			Console.WriteLine("Cleared console due to stream detection. This is for the safety of any sensitive information being shown.");
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00084E34 File Offset: 0x00083034
		private void 랦()
		{
			if (랅.럎(ConfigFile.menuToggleKey))
			{
				ConfigFile.showMenu = !ConfigFile.showMenu;
			}
			if (global::랾.럧.럯 && ConfigFile.teleportCancelKey != null && 랅.럎(ConfigFile.teleportCancelKey))
			{
				럺.럒();
				string text = "Teleport";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cancelled with ");
				defaultInterpolatedStringHandler.AppendFormatted<KeyCode>(ConfigFile.teleportCancelKey);
				랃.럎(text, defaultInterpolatedStringHandler.ToStringAndClear(), 4f);
			}
			if (랅.럎(284))
			{
				ConfigFile.showMiniMapToggle = !ConfigFile.showMiniMapToggle;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00084ECC File Offset: 0x000830CC
		private static void 랾(KeyCode A_0)
		{
			if (global::랾.럧.랾 == global::랾.럧.랾.럎)
			{
				ConfigFile.teleportCancelKey = A_0;
				string text = "Keybind";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Teleport cancel key set to ");
				defaultInterpolatedStringHandler.AppendFormatted<KeyCode>(A_0);
				랃.럎(text, defaultInterpolatedStringHandler.ToStringAndClear(), 4f);
				return;
			}
			ConfigFile.menuToggleKey = A_0;
			string text2 = "Keybind";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("Menu key set to ");
			defaultInterpolatedStringHandler2.AppendFormatted<KeyCode>(A_0);
			랃.럎(text2, defaultInterpolatedStringHandler2.ToStringAndClear(), 4f);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0003EB41 File Offset: 0x0003CD41
		private static void 랾(ref bool A_0, string A_1)
		{
			A_0 = !A_0;
			global::랾.럽.랾(A_1 + " " + (A_0 ? "Enabled" : "Disabled"), false);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0003EB6B File Offset: 0x0003CD6B
		private void 럔()
		{
			if (global::랾.럧.럺)
			{
				럅.럭();
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00084F58 File Offset: 0x00083158
		private void 랞()
		{
			if (global::랾.럧.럈 && !global::랾.럽.랾())
			{
				랆.럎();
			}
			if (global::랾.럧.랺)
			{
				랆.랴();
				랆.럖();
				랆.럶();
				ConfigFile.clientRelayChatToggle = false;
			}
			if (global::랾.럧.랛)
			{
				랆.럷();
				랆.럶();
				ConfigFile.clientRelayChatToggle = false;
			}
			if (global::랾.럧.럷)
			{
				랆.럀();
				랆.럖();
				랆.럶();
				ConfigFile.clientRelayChatToggle = false;
			}
			if (global::랾.럧.랅)
			{
				랆.럖();
				랆.럶();
				ConfigFile.clientRelayChatToggle = false;
			}
			if (global::랾.럧.랪)
			{
				랆.럱();
				랆.럖();
				랆.럶();
				ConfigFile.clientRelayChatToggle = false;
			}
			if (global::랾.럧.럈)
			{
				랆.럖();
				ConfigFile.clientRelayChatToggle = false;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0008500C File Offset: 0x0008320C
		private void 럚()
		{
			global::랾.럧.럒 = true;
			global::랾.럧.랢 += Time.deltaTime;
			global::랾.럧.랬 += Time.deltaTime;
			this.랢();
			랴.랯();
			랳.럝();
			this.럻();
			this.랖();
			this.럝();
			this.럽();
			this.랺();
			this.럈();
			this.럧();
			this.럓();
			this.랊();
			this.럟();
			this.럦();
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00085094 File Offset: 0x00083294
		private void 럳()
		{
			global::랾.럧.럒 = false;
			global::랾.럧.랢 = 0f;
			global::랾.럧.랾.Clear();
			global::랾.럧.럼 = -1;
			global::랾.럧.럎.Clear();
			global::랾.럧.람.Clear();
			global::랾.럧.럎.Clear();
			global::랾.럧.람.Clear();
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			global::랾.럓.랾 = null;
			럆.럎();
			랳.럽();
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00085114 File Offset: 0x00083314
		private void 랢()
		{
			if (랐.랢())
			{
				return;
			}
			if (랆.럴())
			{
				return;
			}
			if (랆.랕())
			{
				return;
			}
			if (랅.랾(304) && 랅.랾(323) && global::랾.럧.랢)
			{
				랮.람();
			}
			if (랅.랾(304) && 랅.럎(323))
			{
				if (global::랾.럧.럻)
				{
					랴.랱();
				}
				if (ConfigFile.clickToKick)
				{
					랴.랓();
				}
				if (ConfigFile.clickToBan)
				{
					랴.럯();
				}
				if (ConfigFile.clickToSummon)
				{
					랴.럭();
				}
			}
			if (랅.랾(308) && 랅.럎(323) && ConfigFile.teleportToggle && !ConfigFile.showMiniMapToggle)
			{
				Vector2i vector2i = global::랾.럽.랾(Camera.main.ScreenToWorldPoint(랅.람()));
				WorldItemBase worldItemData = ControllerHelper.worldController.world.GetWorldItemData(vector2i.x, vector2i.y);
				럠.럎(vector2i, worldItemData);
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00085208 File Offset: 0x00083408
		private void 럻()
		{
			global::랾.럧.럻 += Time.deltaTime;
			if (global::랾.럧.럻 < 3f)
			{
				return;
			}
			foreach (World.RatingPair ratingPair in global::랾.럓.랾.worldRatings)
			{
				global::랾.럧.랾[ratingPair.userId] = (int)ratingPair.rating;
			}
			global::랾.럧.럻 = 0f;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00085274 File Offset: 0x00083474
		private void 랖()
		{
			if (!global::랾.럧.랠)
			{
				return;
			}
			List<InventoryItemBase> list = new List<InventoryItemBase>();
			foreach (InventoryItemBase inventoryItemBase in global::랾.럓.랾.inventoryData.Values)
			{
				if (ConfigData.IsBlockFamiliar(inventoryItemBase.blockType))
				{
					list.Add(inventoryItemBase);
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			global::랾.럧.럳 += Time.deltaTime;
			if (global::랾.럧.럳 < 1.5f)
			{
				return;
			}
			OutgoingMessages.SendFamiliarChange(list[global::랾.럧.럙].blockType);
			Player player = global::랾.럓.랾;
			World.BlockType blockType = list[global::랾.럧.럙].blockType;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럙);
			player.ChangeFamiliar(blockType, defaultInterpolatedStringHandler.ToStringAndClear(), true);
			global::랾.럧.럳 = 0f;
			global::랾.럧.럙 = (global::랾.럧.럙 + 1) % list.Count;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0008535C File Offset: 0x0008355C
		private void 럝()
		{
			for (int i = global::랾.럧.랾.Count - 1; i >= 0; i--)
			{
				if (!global::랾.럽.랾(global::랾.럧.랾[i].Item1))
				{
					global::랾.럧.랾.RemoveAt(i);
				}
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0003EB79 File Offset: 0x0003CD79
		private void 럽()
		{
			if (!ConfigFile.reportModAndAdminSightingsToggle)
			{
				return;
			}
			this.랉.럎(Time.deltaTime);
			if (!this.랉.럒())
			{
				return;
			}
			this.랉.랋();
			global::랾.럩.랾();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000853A4 File Offset: 0x000835A4
		private void 럜()
		{
			if (!ConfigFile.reportModAndAdminSightingsToggle)
			{
				this.럙 = false;
				this.랱 = false;
				this.럐.랋();
				global::랾.럩.람();
				return;
			}
			this.럐.랾((float)Mathf.Clamp(ConfigFile.modAndAdminSightingPollSeconds, 120, 360));
			this.럐.럎(Time.deltaTime);
			if ((this.럙 && !this.럐.럒()) || this.랱)
			{
				return;
			}
			this.럙 = true;
			this.럐.랋();
			this.럘();
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00085440 File Offset: 0x00083640
		private void 럕()
		{
			if (!ConfigFile.clientRelayChatToggle)
			{
				this.럍 = false;
				this.랫 = false;
				this.랓.랋();
				global::랾.럲.럎();
				return;
			}
			this.랓.랾((float)Mathf.Clamp(ConfigFile.clientRelayChatPollSeconds, 30, 320));
			this.랓.럎(Time.deltaTime);
			if ((this.럍 && !this.랓.럒()) || this.랫)
			{
				return;
			}
			this.럍 = true;
			this.랓.랋();
			this.랟();
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000854DC File Offset: 0x000836DC
		private void 럘()
		{
			럓.럒 럒;
			럒.랾 = AsyncVoidMethodBuilder.Create();
			럒.랾 = this;
			럒.랾 = -1;
			럒.랾.Start<럓.럒>(ref 럒);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00085514 File Offset: 0x00083714
		private void 랟()
		{
			럓.람 람;
			람.랾 = AsyncVoidMethodBuilder.Create();
			람.랾 = this;
			람.랾 = -1;
			람.랾.Start<럓.람>(ref 람);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0003EBB1 File Offset: 0x0003CDB1
		private void 랺()
		{
			if (ConfigFile.infiniteJetpackFuel)
			{
				ConfigData.rocketFuelConsumptionSpeed = 0f;
				ConfigData.rocketFuelConsumptionSpeed60FPS = 0f;
				return;
			}
			ConfigData.rocketFuelConsumptionSpeed = 1.15f;
			ConfigData.rocketFuelConsumptionSpeed60FPS = 1.29f;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0003EBE3 File Offset: 0x0003CDE3
		private void 럈()
		{
			if (global::랾.럧.랖)
			{
				랆.럮();
			}
			랄.럎();
			랄.럒();
			if (ConfigFile.cheaterDetectorToggle)
			{
				랄.랾();
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0008554C File Offset: 0x0008374C
		private void 럧()
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			Player player = global::랾.럓.랾 ?? global::랾.럓.랾;
			KukouriCamera kukouriCamera = ControllerHelper.kukouriCamera;
			if (ConfigFile.teleportToggle)
			{
				Action action;
				if ((action = global::랾.럓.랾.랾) == null)
				{
					action = (global::랾.럓.랾.랾 = new Action(럺.랾));
				}
				global::랾.럓.랾(action, "TeleportMain");
			}
			if (ConfigFile.aimbotPVEToggle)
			{
				Action action2;
				if ((action2 = global::랾.럓.랾.럎) == null)
				{
					action2 = (global::랾.럓.랾.럎 = new Action(랴.럼));
				}
				global::랾.럓.랾(action2, "EnemyAimBot");
			}
			if (ConfigFile.aimbotToggle)
			{
				Action action3;
				if ((action3 = global::랾.럓.랾.람) == null)
				{
					action3 = (global::랾.럓.랾.람 = new Action(랴.럎));
				}
				global::랾.럓.랾(action3, "PlayerAimBot");
			}
			if (ConfigFile.autoNetherTargetTreasure)
			{
				Action action4;
				if ((action4 = global::랾.럓.랾.럒) == null)
				{
					action4 = (global::랾.럓.랾.럒 = new Action(랴.랋));
				}
				global::랾.럓.랾(action4, "BlockAimBot");
			}
			if (ConfigFile.flyToggle)
			{
				Action action5;
				if ((action5 = global::랾.럓.랾.럼) == null)
				{
					action5 = (global::랾.럓.랾.럼 = new Action(랴.랉));
				}
				global::랾.럓.랾(action5, "FlyMode");
			}
			if (ConfigFile.zoomHackToggle)
			{
				Action action6;
				if ((action6 = global::랾.럓.랾.랋) == null)
				{
					action6 = (global::랾.럓.랾.랋 = new Action(랴.러));
				}
				global::랾.럓.랾(action6, "ZoomHack");
			}
			else if (kukouriCamera != null)
			{
				kukouriCamera.maxZoom = 10;
			}
			if (ConfigFile.fullAccessToggle)
			{
				Action action7;
				if ((action7 = global::랾.럓.랾.랉) == null)
				{
					action7 = (global::랾.럓.랾.랉 = new Action(랴.럙));
				}
				global::랾.럓.랾(action7, "FullAccess");
			}
			if (ConfigFile.extendedPickUpToggle)
			{
				Action action8;
				if ((action8 = global::랾.럓.랾.럐) == null)
				{
					action8 = (global::랾.럓.랾.럐 = new Action(랴.럇));
				}
				global::랾.럓.랾(action8, "ExtendedPickUpRange");
			}
			Action action9;
			if ((action9 = global::랾.럓.랾.랓) == null)
			{
				action9 = (global::랾.럓.랾.랓 = new Action(랴.럍));
			}
			global::랾.럓.랾(action9, "FreeCamUpdate");
			if (ConfigFile.autoGiftBoxPickupToggle)
			{
				Action action10;
				if ((action10 = global::랾.럓.랾.럯) == null)
				{
					action10 = (global::랾.럓.랾.럯 = new Action(랆.럾));
				}
				global::랾.럓.랾(action10, "AutoCollectGiftBoxPrize");
			}
			if (player != null)
			{
				if (global::랾.럧.럷 && ConfigFile.abandonNetherPlayersToggle && global::랾.럓.랾 != null && global::랾.럓.랾.worldName == "NETHERWORLD" && NetworkPlayers.otherPlayers.Count > 0)
				{
					global::랾.럽.럼("Abandoning Nether Player Detected!", false);
					OutgoingMessages.LeaveWorld();
				}
				player.isLocalPlayer = (!ConfigFile.freeCamToggle || global::랾.럧.럯);
				if (player.playerNameTextMeshPro != null && ConfigFile.customPlayerName)
				{
					player.playerNameTextMeshPro.text = "<b>" + ConfigFile.customPlayerNameValue;
				}
				if (ConfigFile.infiniteJumps)
				{
					player.jumpMode = 1;
					player.isDoubleJumpFirstJumpDone = false;
				}
			}
			Action action11;
			if ((action11 = global::랾.럓.랾.럭) == null)
			{
				action11 = (global::랾.럓.랾.럭 = new Action(랴.량));
			}
			global::랾.럓.랾(action11, "SpectateUpdate");
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0008580C File Offset: 0x00083A0C
		private static void 랾(Action A_0, string A_1)
		{
			try
			{
				A_0();
				global::랾.럓.랾.Remove(A_1);
			}
			catch (Exception)
			{
				global::랾.럓.랾.Add(A_1);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0008584C File Offset: 0x00083A4C
		private void 럓()
		{
			if (global::랾.럧.럳)
			{
				랮.럎();
			}
			if (global::랾.럧.럝)
			{
				랮.랾();
			}
			if (global::랾.럧.럽)
			{
				랮.럒();
			}
			if (global::랾.럧.랞)
			{
				랮.럼();
			}
			if (global::랾.럧.랦)
			{
				랮.랉();
			}
			if (global::랾.럧.럩)
			{
				랮.랋();
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000858A4 File Offset: 0x00083AA4
		private void 랊()
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			Action action;
			if ((action = global::랾.럓.랾.랱) == null)
			{
				action = (global::랾.럓.랾.랱 = new Action(럅.럯));
			}
			global::랾.럓.럎(action, "SkipTutorialCinematic");
			if (ConfigFile.optimizeWorldToggle)
			{
				Action action2;
				if ((action2 = global::랾.럓.랾.럙) == null)
				{
					action2 = (global::랾.럓.랾.럙 = new Action(럅.럍));
				}
				global::랾.럓.럎(action2, "OptimizeWorld");
			}
			if (global::랾.럧.랳)
			{
				Action action3;
				if ((action3 = global::랾.럓.랾.랫) == null)
				{
					action3 = (global::랾.럓.랾.랫 = new Action(럅.럎));
				}
				global::랾.럓.럎(action3, "AutoPlaceLock");
			}
			if (global::랾.럧.럸)
			{
				Action action4;
				if ((action4 = global::랾.럓.랾.럍) == null)
				{
					action4 = (global::랾.럓.랾.럍 = new Action(랆.랶));
				}
				global::랾.럓.럎(action4, "ClearWorld");
			}
			if (global::랾.럧.럏)
			{
				Action action5;
				if ((action5 = global::랾.럓.랾.랬) == null)
				{
					action5 = (global::랾.럓.랾.랬 = new Action(럅.럐));
				}
				global::랾.럓.럎(action5, "HidePlayers");
			}
			if (global::랾.럧.랴)
			{
				Action action6;
				if ((action6 = global::랾.럓.랾.란) == null)
				{
					action6 = (global::랾.럓.랾.란 = new Action(럅.랉));
				}
				global::랾.럓.럎(action6, "HideEnemies");
			}
			if (global::랾.럧.럜)
			{
				Action action7;
				if ((action7 = global::랾.럓.랾.럇) == null)
				{
					action7 = (global::랾.럓.랾.럇 = new Action(럅.랓));
				}
				global::랾.럓.럎(action7, "HideOres");
			}
			if (ConfigFile.antiDarknessToggle)
			{
				Action action8;
				if ((action8 = global::랾.럓.랾.랯) == null)
				{
					action8 = (global::랾.럓.랾.랯 = new Action(럅.랱));
				}
				global::랾.럓.럎(action8, "AntiDarkness");
			}
			if (ConfigFile.autoHarvestGrownSeedsToggle || ConfigFile.autoPlantSeedsToggle)
			{
				Action action9;
				if ((action9 = global::랾.럓.랾.러) == null)
				{
					action9 = (global::랾.럓.랾.러 = new Action(럆.랾));
				}
				global::랾.럓.럎(action9, "AutoPlantHarvest");
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00085A48 File Offset: 0x00083C48
		private static void 럎(Action A_0, string A_1)
		{
			try
			{
				A_0();
				global::랾.럓.럎.Remove(A_1);
			}
			catch (Exception)
			{
				global::랾.럓.럎.Add(A_1);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00085A88 File Offset: 0x00083C88
		private void 럟()
		{
			if (global::랾.럧.랽)
			{
				랆.럵();
			}
			if (global::랾.럧.랡)
			{
				랆.럨();
			}
			if (global::랾.럧.럦)
			{
				랆.랝();
			}
			if (global::랾.럧.럈)
			{
				랆.럎();
			}
			if (ConfigFile.openPouchSpam)
			{
				랆.략();
			}
			if (global::랾.럧.럧)
			{
				global::랾.럽.럎("Auto Recycle disabled for safety.", false);
				global::랾.럧.럧 = false;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00085AEC File Offset: 0x00083CEC
		private void 럦()
		{
			if (ConfigFile.antiAFKToggle && ConfigData.playerChangeToSleepSeconds != 0 && ConfigData.playerChangeToSleepSeconds != 2147483647)
			{
				ConfigData.playerChangeToSleepSeconds = int.MaxValue;
				ConfigData.playerInactivitySeconds = int.MaxValue;
				ConfigData.playerInactivitySecondsFishing = int.MaxValue;
				ConfigData.playerInactivitySecondsMatchmaking = int.MaxValue;
			}
			Player player = global::랾.럓.랾 ?? global::랾.럓.랾;
			if (ConfigFile.fastRespawnToggle)
			{
				ConfigData.playerIsDeadBackupTimerCheck = 0f;
				if (player != null)
				{
					player.isDeadTimeCounter = float.MaxValue;
				}
			}
			else
			{
				ConfigData.playerIsDeadBackupTimerCheck = 2.5f;
				if (player != null)
				{
					player.isDeadTimeCounter = 0f;
				}
			}
			ConfigData.minTimeBetweenFRQMessages = (ConfigFile.removeFrequencyCooldownToggle ? 0 : 30);
			if (ConfigFile.unCappedTextToggle)
			{
				byte b = (byte)8192;
				int maxCharsPerSign = 50175;
				ConfigData.maxChatLines = 64;
				ConfigData.chatCharacterLimit = b;
				ConfigData.maxCharsPerSign = maxCharsPerSign;
			}
			else
			{
				ConfigData.maxChatLines = 10;
				ConfigData.chatCharacterLimit = 124;
				ConfigData.maxCharsPerSign = int.MaxValue;
			}
			if (ConfigFile.unlimitedOxygenToggle)
			{
				ConfigData.oxygenRegenerationSpeed = 1000f;
				ConfigData.oxygenConsumptionSpeed = 0f;
			}
			else
			{
				ConfigData.oxygenRegenerationSpeed = 10f;
				ConfigData.oxygenConsumptionSpeed = 1f;
			}
			ConfigData.inAirDamping = (ConfigFile.airResistanceToggle ? 1E+11f : 3.5f);
			ConfigData.clientDisconnectForcedTimeoutInSeconds = ((ConfigFile.ghostLagToggle || global::랾.럧.럯) ? int.MaxValue : 12);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00085C44 File Offset: 0x00083E44
		private void 랪()
		{
			if (!랳.럎())
			{
				return;
			}
			if (ConfigFile.fakeLagToggle && global::랾.럧.럑)
			{
				Action action;
				if ((action = global::랾.럓.랾.량) == null)
				{
					action = (global::랾.럓.랾.량 = new Action(랳.랁));
				}
				global::랾.럓.랾(action, "GhostMarker", new Action(global::랾.럓.럎.랾.럎), 10f);
			}
			if (ConfigFile.alwaysShowTeleportPath || (랅.랾(308) && ConfigFile.teleportToggle && ConfigFile.showTeleportPathToggle) || (global::랾.럧.랺 && ConfigFile.showTeleportPathToggle))
			{
				Action action2;
				if ((action2 = global::랾.럓.랾.럑) == null)
				{
					action2 = (global::랾.럓.랾.럑 = new Action(랳.랽));
				}
				global::랾.럓.랾(action2, "PathPreview", null, 10f);
			}
			if (랐.럻())
			{
				Action action3;
				if ((action3 = global::랾.럓.랾.럊) == null)
				{
					action3 = (global::랾.럓.랾.럊 = new Action(랐.럃));
				}
				global::랾.럓.랾(action3, "AutoFarmerOverlay", null, 10f);
			}
			if (랆.럢())
			{
				Action action4;
				if ((action4 = global::랾.럓.랾.랠) == null)
				{
					action4 = (global::랾.럓.랾.랠 = new Action(랆.럄));
				}
				global::랾.럓.랾(action4, "WorldCleanerOverlay", null, 10f);
			}
			if (global::랾.럧.럈 || 랆.럊())
			{
				Action action5;
				if ((action5 = global::랾.럓.랾.럏) == null)
				{
					action5 = (global::랾.럓.랾.럏 = new Action(랆.럲));
				}
				global::랾.럓.랾(action5, "AutoFishReturnSpotOverlay", null, 10f);
			}
			if (랆.럌())
			{
				Action action6;
				if ((action6 = global::랾.럓.랾.럫) == null)
				{
					action6 = (global::랾.럓.랾.럫 = new Action(랆.랼));
				}
				global::랾.럓.랾(action6, "AutoNetherPortalOverlay", null, 10f);
			}
			if (ConfigFile.collectableESPTracer || ConfigFile.collectableESPBox || ConfigFile.playerESPBox || ConfigFile.playerESPTracer || ConfigFile.modESPBox || ConfigFile.modESPTracers)
			{
				Action action7;
				if ((action7 = global::랾.럓.랾.럴) == null)
				{
					action7 = (global::랾.럓.랾.럴 = new Action(랳.럟));
				}
				global::랾.럓.랾(action7, "BigESP", null, 10f);
			}
			if (ConfigFile.enemyESPBox || ConfigFile.enemyESPTracer)
			{
				Action action8;
				if ((action8 = global::랾.럓.랾.럲) == null)
				{
					action8 = (global::랾.럓.랾.럲 = new Action(랳.랊));
				}
				global::랾.럓.랾(action8, "EnemyESP", null, 10f);
			}
			if (ConfigFile.oreESPToggle)
			{
				Action action9;
				if ((action9 = global::랾.럓.랾.럩) == null)
				{
					action9 = (global::랾.럓.랾.럩 = new Action(랳.럴));
				}
				global::랾.럓.랾(action9, "OreESP", null, 10f);
			}
			if (ConfigFile.butterflyESPTracer)
			{
				Action action10;
				if ((action10 = global::랾.럓.랾.랦) == null)
				{
					action10 = (global::랾.럓.랾.랦 = new Action(랳.럳));
				}
				global::랾.럓.랾(action10, "ButterflyESP", null, 10f);
			}
			if (ConfigFile.blueParticleESPToggle)
			{
				Action action11;
				if ((action11 = global::랾.럓.랾.럔) == null)
				{
					action11 = (global::랾.럓.랾.럔 = new Action(랳.랢));
				}
				global::랾.럓.랾(action11, "BlueParticleESP", null, 10f);
			}
			if (ConfigFile.eggESPToggle)
			{
				Action action12;
				if ((action12 = global::랾.럓.랾.랞) == null)
				{
					action12 = (global::랾.럓.랾.랞 = new Action(랳.럻));
				}
				global::랾.럓.랾(action12, "EggESP", null, 10f);
			}
			if (ConfigFile.giftBoxESPToggle)
			{
				Action action13;
				if ((action13 = global::랾.럓.랾.럚) == null)
				{
					action13 = (global::랾.럓.랾.럚 = new Action(랳.럔));
				}
				global::랾.럓.랾(action13, "GiftBoxESP", null, 10f);
			}
			if (ConfigFile.netherBossESPToggle)
			{
				Action action14;
				if ((action14 = global::랾.럓.랾.럳) == null)
				{
					action14 = (global::랾.럓.랾.럳 = new Action(랳.랺));
				}
				global::랾.럓.랾(action14, "NetherBossESP", null, 10f);
			}
			if (ConfigFile.netherExitESPToggle)
			{
				Action action15;
				if ((action15 = global::랾.럓.랾.랢) == null)
				{
					action15 = (global::랾.럓.랾.랢 = new Action(랳.랞));
				}
				global::랾.럓.랾(action15, "NetherExitESP", null, 10f);
			}
			if (ConfigFile.netherKeyESPToggle)
			{
				Action action16;
				if ((action16 = global::랾.럓.랾.럻) == null)
				{
					action16 = (global::랾.럓.랾.럻 = new Action(랳.랪));
				}
				global::랾.럓.랾(action16, "NetherKeyESP", null, 10f);
			}
			if (ConfigFile.portalESPToggle)
			{
				Action action17;
				if ((action17 = global::랾.럓.랾.랖) == null)
				{
					action17 = (global::랾.럓.랾.랖 = new Action(랳.랦));
				}
				global::랾.럓.랾(action17, "PortalESP", null, 10f);
			}
			if (ConfigFile.swordInTheStoneTracerToggle)
			{
				Action action18;
				if ((action18 = global::랾.럓.랾.럝) == null)
				{
					action18 = (global::랾.럓.랾.럝 = new Action(랳.럚));
				}
				global::랾.럓.랾(action18, "SwordInTheStoneESP", null, 10f);
			}
			if (ConfigFile.valentineHeartESPToggle)
			{
				Action action19;
				if ((action19 = global::랾.럓.랾.럽) == null)
				{
					action19 = (global::랾.럓.랾.럽 = new Action(랳.랖));
				}
				global::랾.럓.랾(action19, "ValentineHeartESP", null, 10f);
			}
			if (ConfigFile.crossBreedSeedEspToggle)
			{
				Action action20;
				if ((action20 = global::랾.럓.랾.럜) == null)
				{
					action20 = (global::랾.럓.랾.럜 = new Action(랳.럏));
				}
				global::랾.럓.랾(action20, "CrossBreedSeedESP", null, 10f);
			}
		}

		// Token: 0x04000414 RID: 1044
		private static string 랾 = "Idle";

		// Token: 0x04000415 RID: 1045
		private static int 랾 = -1;

		// Token: 0x04000416 RID: 1046
		private static int 럎 = -1;

		// Token: 0x04000417 RID: 1047
		private static int 람 = -1;

		// Token: 0x04000418 RID: 1048
		private static int 럒;

		// Token: 0x04000419 RID: 1049
		private static bool 랾;

		// Token: 0x0400041A RID: 1050
		private static bool 럎;

		// Token: 0x0400041B RID: 1051
		private static bool 람;

		// Token: 0x0400041C RID: 1052
		private static bool 럒;

		// Token: 0x0400041D RID: 1053
		private static bool 럼;

		// Token: 0x0400041E RID: 1054
		private static bool 랋;

		// Token: 0x0400041F RID: 1055
		private static bool 랉;

		// Token: 0x04000420 RID: 1056
		private static bool 럐;

		// Token: 0x04000421 RID: 1057
		private static bool 랓;

		// Token: 0x04000422 RID: 1058
		private static float 랾 = -1f;

		// Token: 0x04000423 RID: 1059
		private const float 럎 = 20f;

		// Token: 0x04000424 RID: 1060
		public static Player 랾;

		// Token: 0x04000425 RID: 1061
		public static PlayerData 랾;

		// Token: 0x04000426 RID: 1062
		public static World 랾;

		// Token: 0x04000427 RID: 1063
		public static ChatUI 랾;

		// Token: 0x04000428 RID: 1064
		public static FishingResultsPopupUI 랾;

		// Token: 0x04000429 RID: 1065
		public static FishingGaugeMinigameUI 랾;

		// Token: 0x0400042A RID: 1066
		private static readonly 럓 랾 = new 럓();

		// Token: 0x0400042B RID: 1067
		private static int 럼 = -1;

		// Token: 0x0400042C RID: 1068
		private static bool 럯;

		// Token: 0x0400042D RID: 1069
		private static readonly Dictionary<string, float> 랾 = new Dictionary<string, float>();

		// Token: 0x0400042E RID: 1070
		private static readonly Dictionary<string, float> 럎 = new Dictionary<string, float>();

		// Token: 0x0400042F RID: 1071
		public static 랓 랾 = new 랓(5f);

		// Token: 0x04000430 RID: 1072
		private readonly 랓 럎 = new 랓(30f);

		// Token: 0x04000431 RID: 1073
		private readonly 랓 람 = new 랓(5f);

		// Token: 0x04000432 RID: 1074
		private readonly 랓 럒 = new 랓(180f);

		// Token: 0x04000433 RID: 1075
		private readonly 랓 럼 = new 랓(20f);

		// Token: 0x04000434 RID: 1076
		private const int 랋 = 3;

		// Token: 0x04000435 RID: 1077
		private 랓 랋 = new 랓(30f);

		// Token: 0x04000436 RID: 1078
		private 랓 랉 = new 랓(3f);

		// Token: 0x04000437 RID: 1079
		private 랓 럐 = new 랓(180f);

		// Token: 0x04000438 RID: 1080
		private 랓 랓 = new 랓(30f);

		// Token: 0x04000439 RID: 1081
		private bool 럭;

		// Token: 0x0400043A RID: 1082
		private bool 랱;

		// Token: 0x0400043B RID: 1083
		private bool 럙;

		// Token: 0x0400043C RID: 1084
		private bool 랫;

		// Token: 0x0400043D RID: 1085
		private bool 럍;

		// Token: 0x0400043E RID: 1086
		private bool 랬;

		// Token: 0x0400043F RID: 1087
		private int 랉;

		// Token: 0x04000440 RID: 1088
		private bool 란;

		// Token: 0x04000441 RID: 1089
		private static volatile bool 랾;

		// Token: 0x04000442 RID: 1090
		private static volatile bool 럎;

		// Token: 0x04000443 RID: 1091
		private static readonly object 랾 = new object();

		// Token: 0x04000444 RID: 1092
		private static float 람 = 12f;

		// Token: 0x04000445 RID: 1093
		private const float 럒 = 15f;

		// Token: 0x04000446 RID: 1094
		private static float 럼 = 0f;

		// Token: 0x04000447 RID: 1095
		private const float 랋 = 0.5f;

		// Token: 0x04000448 RID: 1096
		private static readonly string[] 랾 = new string[]
		{
			"fiddler",
			"wireshark",
			"charles",
			"mitmproxy",
			"burpsuite",
			"httpdebugger",
			"dnspy",
			"ilspy",
			"dotpeek",
			"justdecompile",
			"de4dot",
			"cheatengine",
			"artmoney",
			"gameguardian",
			"cheat engine",
			"x64dbg",
			"x32dbg",
			"ollydbg",
			"windbg",
			"ida64",
			"ida",
			"extremeinjector",
			"processexplorer",
			"processhacker"
		};

		// Token: 0x04000449 RID: 1097
		private static readonly string[] 럎 = new string[]
		{
			"obs",
			"obs32",
			"obs64",
			"streamlabs",
			"streamlabsobs",
			"xsplit",
			"twitchstudio",
			"lightstream",
			"prismlive"
		};

		// Token: 0x0400044A RID: 1098
		private static float 랉 = 0f;

		// Token: 0x0400044B RID: 1099
		private const float 럐 = 5f;

		// Token: 0x0400044C RID: 1100
		private static float 랓 = 0f;

		// Token: 0x0400044D RID: 1101
		private const float 럯 = 30f;

		// Token: 0x0400044E RID: 1102
		private static volatile bool 람;

		// Token: 0x0400044F RID: 1103
		private static volatile bool 럒;

		// Token: 0x04000450 RID: 1104
		private static bool 럇;

		// Token: 0x04000451 RID: 1105
		private static bool 랯;

		// Token: 0x04000452 RID: 1106
		private static readonly HashSet<string> 랾 = new HashSet<string>();

		// Token: 0x04000453 RID: 1107
		private static readonly HashSet<string> 럎 = new HashSet<string>();

		// Token: 0x02000078 RID: 120
		[CompilerGenerated]
		private static class 랾
		{
			// Token: 0x04000454 RID: 1108
			public static Action 랾;

			// Token: 0x04000455 RID: 1109
			public static Action 럎;

			// Token: 0x04000456 RID: 1110
			public static Action 람;

			// Token: 0x04000457 RID: 1111
			public static Action 럒;

			// Token: 0x04000458 RID: 1112
			public static Action 럼;

			// Token: 0x04000459 RID: 1113
			public static Action 랋;

			// Token: 0x0400045A RID: 1114
			public static Action 랉;

			// Token: 0x0400045B RID: 1115
			public static Action 럐;

			// Token: 0x0400045C RID: 1116
			public static Action 랓;

			// Token: 0x0400045D RID: 1117
			public static Action 럯;

			// Token: 0x0400045E RID: 1118
			public static Action 럭;

			// Token: 0x0400045F RID: 1119
			public static Action 랱;

			// Token: 0x04000460 RID: 1120
			public static Action 럙;

			// Token: 0x04000461 RID: 1121
			public static Action 랫;

			// Token: 0x04000462 RID: 1122
			public static Action 럍;

			// Token: 0x04000463 RID: 1123
			public static Action 랬;

			// Token: 0x04000464 RID: 1124
			public static Action 란;

			// Token: 0x04000465 RID: 1125
			public static Action 럇;

			// Token: 0x04000466 RID: 1126
			public static Action 랯;

			// Token: 0x04000467 RID: 1127
			public static Action 러;

			// Token: 0x04000468 RID: 1128
			public static Action 량;

			// Token: 0x04000469 RID: 1129
			public static Action 럑;

			// Token: 0x0400046A RID: 1130
			public static Action 럊;

			// Token: 0x0400046B RID: 1131
			public static Action 랠;

			// Token: 0x0400046C RID: 1132
			public static Action 럏;

			// Token: 0x0400046D RID: 1133
			public static Action 럫;

			// Token: 0x0400046E RID: 1134
			public static Action 럴;

			// Token: 0x0400046F RID: 1135
			public static Action 럲;

			// Token: 0x04000470 RID: 1136
			public static Action 럩;

			// Token: 0x04000471 RID: 1137
			public static Action 랦;

			// Token: 0x04000472 RID: 1138
			public static Action 럔;

			// Token: 0x04000473 RID: 1139
			public static Action 랞;

			// Token: 0x04000474 RID: 1140
			public static Action 럚;

			// Token: 0x04000475 RID: 1141
			public static Action 럳;

			// Token: 0x04000476 RID: 1142
			public static Action 랢;

			// Token: 0x04000477 RID: 1143
			public static Action 럻;

			// Token: 0x04000478 RID: 1144
			public static Action 랖;

			// Token: 0x04000479 RID: 1145
			public static Action 럝;

			// Token: 0x0400047A RID: 1146
			public static Action 럽;

			// Token: 0x0400047B RID: 1147
			public static Action 럜;
		}

		// Token: 0x02000079 RID: 121
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x0600048D RID: 1165 RVA: 0x00086330 File Offset: 0x00084530
			internal void 랾()
			{
				try
				{
					global::랾.럓.럒 = global::랾.럓.럴();
				}
				finally
				{
					global::랾.럓.람 = false;
				}
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0003EC13 File Offset: 0x0003CE13
			internal void 럎()
			{
				ConfigFile.fakeLagToggle = false;
			}

			// Token: 0x0400047C RID: 1148
			public static readonly 럓.럎 랾 = new 럓.럎();

			// Token: 0x0400047D RID: 1149
			public static Action 랾;

			// Token: 0x0400047E RID: 1150
			public static Action 럎;
		}
	}
}
