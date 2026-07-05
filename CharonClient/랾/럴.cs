using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BepInEx;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using CharonAndFriends.HarmonyPatches;
using CharonClient.Configuration;
using HarmonyLib;
using Microsoft.Win32;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200003B RID: 59
	[BepInDependency("CharonXXIII.DearImGuiInjection", 1)]
	[BepInPlugin("Charon_Client_White_Dress", "Charon Client (White Dress) 2.0", "2.0")]
	internal class 럴 : BasePlugin
	{
		// Token: 0x06000242 RID: 578 RVA: 0x0003DB32 File Offset: 0x0003BD32
		[CompilerGenerated]
		internal static ManualLogSource 랾()
		{
			return 럴.랾;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0003DB39 File Offset: 0x0003BD39
		[CompilerGenerated]
		private static void 랾(ManualLogSource A_0)
		{
			럴.랾 = A_0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000785A0 File Offset: 0x000767A0
		public override void Load()
		{
			럴.랾(base.Log);
			ManualLogSource log = base.Log;
			bool flag;
			BepInExFatalLogInterpolatedStringHandler bepInExFatalLogInterpolatedStringHandler = new BepInExFatalLogInterpolatedStringHandler(14, 2, ref flag);
			if (flag)
			{
				bepInExFatalLogInterpolatedStringHandler.AppendFormatted<string>(this.럎);
				bepInExFatalLogInterpolatedStringHandler.AppendLiteral(" ");
				bepInExFatalLogInterpolatedStringHandler.AppendFormatted<string>("2.0");
				bepInExFatalLogInterpolatedStringHandler.AppendLiteral(" Now Loading!");
			}
			log.LogFatal(bepInExFatalLogInterpolatedStringHandler);
			if (!this.랋())
			{
				return;
			}
			base.Log.LogFatal("Verifying identity...");
			base.Log.LogFatal("HWID Verified!");
			럴.랾 = new DateTime?(DateTime.Now);
			this.럎();
			this.람();
			string text = "general";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendFormatted(럧.럲);
			defaultInterpolatedStringHandler.AppendLiteral(" HWID: ");
			defaultInterpolatedStringHandler.AppendFormatted(럧.랱);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(ConfigFile.customPlayerNameValue);
			럕.랾(text, defaultInterpolatedStringHandler.ToStringAndClear());
			this.럒();
			this.럼();
			if (ConfigFile.discordRPCToggle)
			{
				랞.랾(global::랾.럙.럒());
			}
			AppDomain.CurrentDomain.ProcessExit += this.랾;
			럴.AssertRuntimeKeyValid("Load");
			Action action;
			if ((action = 럴.럼.랾) == null)
			{
				action = (럴.럼.랾 = new Action(럓.랋));
			}
			global::랾.랉.랾(action);
			Action action2;
			if ((action2 = 럴.럼.럎) == null)
			{
				action2 = (럴.럼.럎 = new Action(럦.랾));
			}
			global::랾.랉.랾(action2);
			ManualLogSource log2 = base.Log;
			bepInExFatalLogInterpolatedStringHandler = new BepInExFatalLogInterpolatedStringHandler(22, 2, ref flag);
			if (flag)
			{
				bepInExFatalLogInterpolatedStringHandler.AppendFormatted<string>(this.럎);
				bepInExFatalLogInterpolatedStringHandler.AppendLiteral(" ");
				bepInExFatalLogInterpolatedStringHandler.AppendFormatted<string>("2.0");
				bepInExFatalLogInterpolatedStringHandler.AppendLiteral(" Loaded Successfully!");
			}
			log2.LogFatal(bepInExFatalLogInterpolatedStringHandler);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00078768 File Offset: 0x00076968
		private void 랾(string A_1)
		{
			럧.럎 = true;
			try
			{
				ManualLogSource log = base.Log;
				bool flag;
				BepInExFatalLogInterpolatedStringHandler bepInExFatalLogInterpolatedStringHandler = new BepInExFatalLogInterpolatedStringHandler(7, 1, ref flag);
				if (flag)
				{
					bepInExFatalLogInterpolatedStringHandler.AppendLiteral("Error: ");
					bepInExFatalLogInterpolatedStringHandler.AppendFormatted<string>(A_1);
				}
				log.LogFatal(bepInExFatalLogInterpolatedStringHandler);
			}
			catch
			{
			}
			try
			{
				global::랾.럯.랾(A_1);
			}
			catch
			{
				럴.럎(A_1);
			}
			럴.ForceTerminateProcess();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000787E0 File Offset: 0x000769E0
		private static void 럎(string A_0)
		{
			string text = string.IsNullOrWhiteSpace(A_0) ? "Unknown integrity failure." : A_0;
			string text2 = (text.StartsWith("MissingRequiredClasses(", StringComparison.Ordinal) ? "One or more required game classes are missing." : "A required game integrity check failed.") + "" + text;
			try
			{
				럴.랾(IntPtr.Zero, text2, "Charon Client Integrity Error", 331792U);
			}
			catch
			{
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00078850 File Offset: 0x00076A50
		[Obfuscation(Exclude = true, Feature = "renaming", ApplyToMembers = false)]
		private static void ForceTerminateProcess()
		{
			try
			{
				Application.Quit();
			}
			catch
			{
			}
			try
			{
				Environment.Exit(1);
			}
			catch
			{
			}
			try
			{
				Process.GetCurrentProcess().Kill();
			}
			catch
			{
			}
		}

		// Token: 0x06000248 RID: 584
		[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBoxW", SetLastError = true)]
		private static extern int 랾(IntPtr, string, string, uint);

		// Token: 0x06000249 RID: 585 RVA: 0x000788AC File Offset: 0x00076AAC
		private void 럎()
		{
			try
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("com.unity.internal.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Random.Range(100, 999));
				this.랾 = new Harmony(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
				{
					if (type.GetCustomAttributes(typeof(HarmonyPatch), false).Length != 0 && !(type.DeclaringType == typeof(TrackingPatches)))
					{
						this.랾.CreateClassProcessor(type).Patch();
					}
				}
				base.Log.LogInfo("Harmony patches applied successfully!");
			}
			catch (Exception ex)
			{
				ManualLogSource log = base.Log;
				bool flag;
				BepInExErrorLogInterpolatedStringHandler bepInExErrorLogInterpolatedStringHandler = new BepInExErrorLogInterpolatedStringHandler(25, 1, ref flag);
				if (flag)
				{
					bepInExErrorLogInterpolatedStringHandler.AppendLiteral("Harmony patching failed: ");
					bepInExErrorLogInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				}
				log.LogError(bepInExErrorLogInterpolatedStringHandler);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0003DB41 File Offset: 0x0003BD41
		private void 람()
		{
			ConfigFile.럒();
			ConfigFile.럐();
			랪.럯();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000789A8 File Offset: 0x00076BA8
		private void 럒()
		{
			try
			{
				AnalyticsManager.SetHasPlayerGivenConsent(false);
			}
			catch
			{
			}
			try
			{
				AnalyticsManager.hasPlayerGivenConsent = false;
			}
			catch
			{
			}
			try
			{
				AnalyticsManager.Uninitialize();
			}
			catch
			{
			}
			try
			{
				FirebaseManager.firebaseInitialized = false;
			}
			catch
			{
			}
			try
			{
				DevtodevManager.isInitialized = false;
			}
			catch
			{
			}
			try
			{
				SingularManager.UpdatePlayerConsent();
			}
			catch
			{
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00078A48 File Offset: 0x00076C48
		private void 럼()
		{
			if (럧.랾 == null || 럧.랾.Length == 0)
			{
				return;
			}
			int num = ConfigFile.selectedAlbumIndex;
			if (num >= 럧.랾.Length)
			{
				num = 0;
				ConfigFile.selectedAlbumIndex = 0;
			}
			string a = 럧.랾[num];
			string rpcimage;
			if (!(a == "White Dress"))
			{
				if (!(a == "Black Dress"))
				{
					rpcimage = ConfigFile.RPCImage;
				}
				else
				{
					rpcimage = "black_dress";
				}
			}
			else
			{
				rpcimage = "white_dress";
			}
			ConfigFile.RPCImage = rpcimage;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00078AC0 File Offset: 0x00076CC0
		private bool 랋()
		{
			bool result;
			try
			{
				IL2CPPChainloader instance = IL2CPPChainloader.Instance;
				if (instance == null)
				{
					result = true;
				}
				else
				{
					instance.PluginLoad -= this.랾;
					instance.PluginLoad += this.랾;
					result = this.랾(instance.Plugins.Values, "startup");
				}
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0003DB53 File Offset: 0x0003BD53
		private void 랾(PluginInfo A_1, Assembly A_2, BasePlugin A_3)
		{
			if (럴.랾)
			{
				return;
			}
			IL2CPPChainloader instance = IL2CPPChainloader.Instance;
			IEnumerable<PluginInfo> enumerable;
			if (instance == null)
			{
				enumerable = null;
			}
			else
			{
				Dictionary<string, PluginInfo> plugins = instance.Plugins;
				enumerable = ((plugins != null) ? plugins.Values : null);
			}
			this.랾(enumerable, "plugin load");
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00078B30 File Offset: 0x00076D30
		private bool 랾(IEnumerable<PluginInfo> A_1, string A_2)
		{
			if (럴.랾 || A_1 == null)
			{
				return !럴.랾;
			}
			List<PluginInfo> list = A_1.Where(new Func<PluginInfo, bool>(럴.랋.랾.랾)).GroupBy(new Func<PluginInfo, string>(럴.랋.랾.럎), StringComparer.OrdinalIgnoreCase).Select(new Func<IGrouping<string, PluginInfo>, PluginInfo>(럴.랋.랾.랾)).ToList<PluginInfo>();
			List<PluginInfo> list2 = list.Where(new Func<PluginInfo, bool>(럴.랋.랾.람)).ToList<PluginInfo>();
			if (list2.Count == 0 && list.Count <= 럴.랾.Count)
			{
				return true;
			}
			string text;
			if (list2.Count <= 0)
			{
				string str = "Too many BepInEx plugins detected during ";
				string str2 = ": ";
				string separator = ", ";
				IEnumerable<PluginInfo> source = list;
				Func<PluginInfo, string> selector;
				if ((selector = 럴.럼.랾) == null)
				{
					selector = (럴.럼.랾 = new Func<PluginInfo, string>(럴.랾));
				}
				text = str + A_2 + str2 + string.Join(separator, source.Select(selector));
			}
			else
			{
				string str3 = "Unauthorized BepInEx plugin(s) detected during ";
				string str4 = ": ";
				string separator2 = ", ";
				IEnumerable<PluginInfo> source2 = list2;
				Func<PluginInfo, string> selector2;
				if ((selector2 = 럴.럼.랾) == null)
				{
					selector2 = (럴.럼.랾 = new Func<PluginInfo, string>(럴.랾));
				}
				text = str3 + A_2 + str4 + string.Join(separator2, source2.Select(selector2));
			}
			string text2 = text;
			this.람(text2);
			return false;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00078C9C File Offset: 0x00076E9C
		private static string 랾(PluginInfo A_0)
		{
			string text;
			if (A_0 == null)
			{
				text = null;
			}
			else
			{
				BepInPlugin metadata = A_0.Metadata;
				text = ((metadata != null) ? metadata.GUID : null);
			}
			string str = text ?? "unknown-guid";
			string text2;
			if (A_0 == null)
			{
				text2 = null;
			}
			else
			{
				BepInPlugin metadata2 = A_0.Metadata;
				text2 = ((metadata2 != null) ? metadata2.Name : null);
			}
			return (text2 ?? "unknown-name") + " [" + str + "]";
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00078CFC File Offset: 0x00076EFC
		private void 람(string A_1)
		{
			if (럴.랾)
			{
				return;
			}
			럴.랾 = true;
			try
			{
				럴.ForceTerminateProcess();
			}
			catch
			{
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0003DB86 File Offset: 0x0003BD86
		private void 랾(object A_1, EventArgs A_2)
		{
			this.랉();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00078D34 File Offset: 0x00076F34
		private void 랉()
		{
			if (this.럎)
			{
				return;
			}
			this.럎 = true;
			ManualLogSource log = base.Log;
			bool flag;
			BepInExInfoLogInterpolatedStringHandler bepInExInfoLogInterpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(12, 1, ref flag);
			if (flag)
			{
				bepInExInfoLogInterpolatedStringHandler.AppendLiteral("Quitting ");
				bepInExInfoLogInterpolatedStringHandler.AppendFormatted<string>(this.럎);
				bepInExInfoLogInterpolatedStringHandler.AppendLiteral("...");
			}
			log.LogInfo(bepInExInfoLogInterpolatedStringHandler);
			try
			{
				if (럴.랾 != null)
				{
					TimeSpan timeSpan = DateTime.Now - 럴.랾.Value;
					if (럧.랾 != null)
					{
						럧.랾.Value += timeSpan.TotalMinutes;
					}
				}
				ConfigFile.럼();
			}
			catch (Exception ex)
			{
				ManualLogSource log2 = base.Log;
				BepInExErrorLogInterpolatedStringHandler bepInExErrorLogInterpolatedStringHandler = new BepInExErrorLogInterpolatedStringHandler(23, 1, ref flag);
				if (flag)
				{
					bepInExErrorLogInterpolatedStringHandler.AppendLiteral("Error during shutdown: ");
					bepInExErrorLogInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				}
				log2.LogError(bepInExErrorLogInterpolatedStringHandler);
			}
			AppDomain.CurrentDomain.ProcessExit -= this.랾;
			if (IL2CPPChainloader.Instance != null)
			{
				IL2CPPChainloader.Instance.PluginLoad -= this.랾;
			}
			Action action;
			if ((action = 럴.럼.랾) == null)
			{
				action = (럴.럼.랾 = new Action(럓.랋));
			}
			global::랾.랉.럎(action);
			Action action2;
			if ((action2 = 럴.럼.럎) == null)
			{
				action2 = (럴.럼.럎 = new Action(럦.랾));
			}
			global::랾.랉.럎(action2);
			럓.랉();
			Harmony harmony = this.랾;
			if (harmony != null)
			{
				harmony.UnpatchSelf();
			}
			랞.랾();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00078EA8 File Offset: 0x000770A8
		private string 럐()
		{
			this.랬();
			럴.럎 럎 = 럴.랓();
			string text = 럴.럒(럴.랾("SOFTWARE\\Microsoft\\Cryptography", "MachineGuid"));
			string text2 = 럴.럒(럴.럎("SELECT ProcessorId FROM Win32_Processor", "ProcessorId"));
			string text3 = 럴.럒(럴.랾(new string[]
			{
				럴.랾("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", "Identifier"),
				럴.랾("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", "ProcessorNameString")
			}));
			string text4 = 럴.럒(럴.럎(global::랾.럙.럼(), "SerialNumber"));
			string text5 = 럴.럒(럴.랾(new string[]
			{
				럴.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct"),
				럴.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardManufacturer")
			}));
			string text6 = 럴.럒(럴.럎(global::랾.럙.랋(), "SerialNumber"));
			string text7 = 럴.럒(럴.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "SystemProductName"));
			럴.럎 럎2 = new 럴.럎();
			럎2.랾(럴.랾(new string[]
			{
				text,
				(럎 != null) ? 럎.랾() : null
			}));
			럎2.럎(럴.랾(new string[]
			{
				text2,
				(럎 != null) ? 럎.럎() : null,
				text3
			}));
			럎2.람(럴.랾(new string[]
			{
				text4,
				(럎 != null) ? 럎.람() : null,
				text5
			}));
			럎2.럒(럴.랾(new string[]
			{
				text6,
				(럎 != null) ? 럎.럒() : null,
				text7
			}));
			럴.럎 럎3 = 럎2;
			if (럴.랾(럎3))
			{
				throw new InvalidOperationException("Could not gather any hardware identifiers.");
			}
			럴.럎(럎3);
			string s = string.Join("|", new string[]
			{
				"machineguid=" + 럎3.랾(),
				"cpu=" + 럎3.럎(),
				"baseboard=" + 럎3.람(),
				"system=" + 럎3.럒()
			});
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				result = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
			}
			return result;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00076788 File Offset: 0x00074988
		private static string 랾(string A_0, string A_1)
		{
			string result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(A_0, false))
				{
					string text;
					if (registryKey == null)
					{
						text = null;
					}
					else
					{
						object value = registryKey.GetValue(A_1);
						if (value == null)
						{
							text = null;
						}
						else
						{
							string text2 = value.ToString();
							text = ((text2 != null) ? text2.Trim() : null);
						}
					}
					result = text;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0007911C File Offset: 0x0007731C
		private static string 럎(string A_0, string A_1)
		{
			try
			{
				Type type = Type.GetType("System.Management.ManagementObjectSearcher, System.Management", false);
				if (type == null)
				{
					return null;
				}
				using (IDisposable disposable = Activator.CreateInstance(type, new object[]
				{
					A_0
				}) as IDisposable)
				{
					MethodInfo method = type.GetMethod("Get", Type.EmptyTypes);
					IEnumerable enumerable = ((method != null) ? method.Invoke(disposable, null) : null) as IEnumerable;
					if (enumerable == null)
					{
						return null;
					}
					foreach (object obj in enumerable)
					{
						try
						{
							string text = 럴.럒(럴.랾(obj, A_1));
							if (!string.IsNullOrWhiteSpace(text))
							{
								return text;
							}
						}
						finally
						{
							IDisposable disposable2 = obj as IDisposable;
							if (disposable2 != null)
							{
								disposable2.Dispose();
							}
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00079238 File Offset: 0x00077438
		private static string 랾(object A_0, string A_1)
		{
			string result;
			try
			{
				PropertyInfo property = A_0.GetType().GetProperty("Item", new Type[]
				{
					typeof(string)
				});
				string text;
				if (property == null)
				{
					text = null;
				}
				else
				{
					object value = property.GetValue(A_0, new object[]
					{
						A_1
					});
					if (value == null)
					{
						text = null;
					}
					else
					{
						string text2 = value.ToString();
						text = ((text2 != null) ? text2.Trim() : null);
					}
				}
				result = text;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000792B0 File Offset: 0x000774B0
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

		// Token: 0x06000259 RID: 601 RVA: 0x000792E0 File Offset: 0x000774E0
		private static string 럒(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return string.Empty;
			}
			string text = A_0.Trim();
			if (!text.Equals("None", StringComparison.OrdinalIgnoreCase))
			{
				return text.ToUpperInvariant();
			}
			return string.Empty;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0003DB8E File Offset: 0x0003BD8E
		private static bool 랾(럴.럎 A_0)
		{
			return string.IsNullOrWhiteSpace(A_0.랾()) && string.IsNullOrWhiteSpace(A_0.럎()) && string.IsNullOrWhiteSpace(A_0.람()) && string.IsNullOrWhiteSpace(A_0.럒());
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0007931C File Offset: 0x0007751C
		private static 럴.럎 랓()
		{
			럴.럎 result;
			try
			{
				string text = 럴.랓(럴.럼);
				if (string.IsNullOrWhiteSpace(text))
				{
					result = null;
				}
				else
				{
					string[] array = text.Split('|', StringSplitOptions.None);
					럴.럎 럎 = new 럴.럎();
					럎.랾((array.Length != 0) ? array[0] : string.Empty);
					럎.럎((array.Length > 1) ? array[1] : string.Empty);
					럎.람((array.Length > 2) ? array[2] : string.Empty);
					럎.럒((array.Length > 3) ? array[3] : string.Empty);
					result = 럎;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000793C4 File Offset: 0x000775C4
		private static void 럎(럴.럎 A_0)
		{
			try
			{
				string text = string.Join("|", new string[]
				{
					A_0.랾() ?? string.Empty,
					A_0.럎() ?? string.Empty,
					A_0.람() ?? string.Empty,
					A_0.럒() ?? string.Empty
				});
				럴.럼(럴.럼, text);
			}
			catch
			{
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0007944C File Offset: 0x0007764C
		[Obfuscation(Exclude = true, Feature = "renaming", ApplyToMembers = false)]
		private string HashWithSalt(string input)
		{
			string s = 럴.럒 + input + 럴.럒;
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				result = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
			}
			return result;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0003CE27 File Offset: 0x0003B027
		[Obfuscation(Exclude = true, Feature = "renaming", ApplyToMembers = false)]
		internal static void AssertRuntimeKeyValid([CallerMemberName] string caller = "")
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000794B8 File Offset: 0x000776B8
		[Obfuscation(Exclude = true, Feature = "renaming", ApplyToMembers = false)]
		private void MaterializeRuntimeKey(string runtimeKeyPayload)
		{
			object obj = 럴.랾;
			lock (obj)
			{
				if (!럴.랾)
				{
					if (string.IsNullOrWhiteSpace(runtimeKeyPayload) || runtimeKeyPayload.Length < 64)
					{
						럴.럒("tamper", "Invalid runtime key payload from server.");
						Environment.Exit(0);
					}
					else
					{
						Buffer.BlockCopy(Convert.FromHexString(runtimeKeyPayload.Substring(0, 64)), 0, 럴.랾, 0, 32);
						럴.랾 = true;
					}
				}
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0007954C File Offset: 0x0007774C
		internal static byte[] 랾(byte[] A_0)
		{
			럴.AssertRuntimeKeyValid("DecryptFeaturePayload");
			byte[] result;
			using (Aes aes = Aes.Create())
			{
				aes.Key = 럴.랾;
				aes.IV = RuntimeHelpers.GetSubArray<byte>(A_0, Range.EndAt(16));
				aes.Mode = CipherMode.CBC;
				aes.Padding = PaddingMode.PKCS7;
				using (ICryptoTransform cryptoTransform = aes.CreateDecryptor())
				{
					result = cryptoTransform.TransformFinalBlock(A_0, 16, A_0.Length - 16);
				}
			}
			return result;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000795E4 File Offset: 0x000777E4
		[Obfuscation(Exclude = true, Feature = "renaming", ApplyToMembers = false)]
		private bool VerifyHWID()
		{
			this.람 = false;
			럴.랾 = false;
			Array.Clear(럴.랾, 0, 럴.랾.Length);
			럜.럎();
			bool result;
			try
			{
				this.람 = "Unknown";
				string input = this.럐();
				string text = this.HashWithSalt(input);
				base.Log.LogWarning("Your HWID is: " + text);
				string text2 = "hwid-sender";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
				defaultInterpolatedStringHandler.AppendLiteral("HWID: ");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(", Machine: ");
				defaultInterpolatedStringHandler.AppendFormatted(global::랾.랱.랾());
				defaultInterpolatedStringHandler.AppendLiteral(", IP: ");
				defaultInterpolatedStringHandler.AppendFormatted(global::랾.랱.럎());
				럕.랾(text2, defaultInterpolatedStringHandler.ToStringAndClear());
				럧.랱 = text;
				string text3 = this.럙();
				럧.랠 = text3;
				string text4 = this.랫();
				럧.럏 = text4;
				럴.랾 랾 = 럴.럯();
				럴.럒 럒 = this.랾(text, text3, text4, 랾);
				switch (럒.랾)
				{
				case 럴.람.랾:
				{
					string text5;
					if (string.IsNullOrWhiteSpace(럒.럒))
					{
						this.럍();
						this.랾(text, "MissingToken", 럒.랾, null);
						result = false;
					}
					else if (럴.랉(럒.럼))
					{
						this.럍();
						this.랾(text, "ExpiredToken", 럒.랾, 럒.럼);
						result = false;
					}
					else if (!럴.랾(럒, 랾, out text5))
					{
						this.럍();
						this.랾(text, text5, 럒.랾, null);
						result = false;
					}
					else
					{
						this.람 = 럒.랾;
						if (!string.IsNullOrEmpty(럒.럒))
						{
							this.럐(럒.럒);
						}
						this.MaterializeRuntimeKey(럒.럭);
						랖.랾(text, text3, 럒.럒);
						럜.럎(text, text3);
						럴.랱();
						base.Log.LogMessage("Verification successful.");
						if (!string.IsNullOrEmpty(럒.랾))
						{
							ManualLogSource log = base.Log;
							bool flag;
							BepInExMessageLogInterpolatedStringHandler bepInExMessageLogInterpolatedStringHandler = new BepInExMessageLogInterpolatedStringHandler(10, 1, ref flag);
							if (flag)
							{
								bepInExMessageLogInterpolatedStringHandler.AppendLiteral("Welcome, ");
								bepInExMessageLogInterpolatedStringHandler.AppendFormatted<string>(럒.랾);
								bepInExMessageLogInterpolatedStringHandler.AppendLiteral(".");
							}
							log.LogMessage(bepInExMessageLogInterpolatedStringHandler);
						}
						string text6 = "success";
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(68, 4);
						defaultInterpolatedStringHandler2.AppendLiteral("Verification succeeded | Name: ");
						defaultInterpolatedStringHandler2.AppendFormatted(럒.랾 ?? "Unknown");
						defaultInterpolatedStringHandler2.AppendLiteral(" | Machine: ");
						defaultInterpolatedStringHandler2.AppendFormatted(global::랾.랱.랾());
						defaultInterpolatedStringHandler2.AppendLiteral(" | Client: ");
						defaultInterpolatedStringHandler2.AppendFormatted("2.0");
						defaultInterpolatedStringHandler2.AppendLiteral(" | Developer: ");
						defaultInterpolatedStringHandler2.AppendFormatted<bool>(this.람);
						럴.럒(text6, defaultInterpolatedStringHandler2.ToStringAndClear());
						result = true;
					}
					break;
				}
				case 럴.람.럎:
					this.럍();
					this.랾(text, "Expired", 럒.랾, 럒.럎);
					result = false;
					break;
				case 럴.람.람:
					this.럍();
					this.랾(text, "InstallMismatch", 럒.랾, null);
					result = false;
					break;
				case 럴.람.럒:
					this.럍();
					this.랾(text, "InvalidToken", 럒.랾, null);
					result = false;
					break;
				case 럴.람.럼:
					this.럍();
					this.랾(text, "NotFound", null, null);
					result = false;
					break;
				case 럴.람.랋:
					this.랾(text, "RemoteError: " + 럒.람, null, null);
					result = false;
					break;
				default:
					this.랾(text, "Unknown", null, null);
					result = false;
					break;
				}
			}
			catch (Exception ex)
			{
				this.람 = "Exception: " + ex.Message;
				ManualLogSource log2 = base.Log;
				bool flag;
				BepInExErrorLogInterpolatedStringHandler bepInExErrorLogInterpolatedStringHandler = new BepInExErrorLogInterpolatedStringHandler(19, 1, ref flag);
				if (flag)
				{
					bepInExErrorLogInterpolatedStringHandler.AppendLiteral("VerifyHWID failed: ");
					bepInExErrorLogInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				}
				log2.LogError(bepInExErrorLogInterpolatedStringHandler);
				Environment.Exit(0);
				result = false;
			}
			return result;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00079A08 File Offset: 0x00077C08
		private void 랾(string A_1, string A_2, string A_3, string A_4)
		{
			this.람 = A_2;
			List<string> list = new List<string>
			{
				"Reason: " + A_2
			};
			if (!string.IsNullOrEmpty(A_3))
			{
				list.Add("Name: " + A_3);
			}
			if (!string.IsNullOrEmpty(A_4))
			{
				list.Add("Expired: " + A_4);
			}
			list.Add("Machine: " + global::랾.랱.랾());
			list.Add("Client: 2.0");
			base.Log.LogWarning("Your HWID is: " + A_1);
			럕.랾("failure", "Verification failed | " + string.Join(" | ", list) + " HWID: " + A_1);
			ManualLogSource log = base.Log;
			bool flag;
			BepInExWarningLogInterpolatedStringHandler bepInExWarningLogInterpolatedStringHandler = new BepInExWarningLogInterpolatedStringHandler(20, 1, ref flag);
			if (flag)
			{
				bepInExWarningLogInterpolatedStringHandler.AppendLiteral("Failed VerifyHWID | ");
				bepInExWarningLogInterpolatedStringHandler.AppendFormatted<string>(string.Join(" | ", list));
			}
			log.LogWarning(bepInExWarningLogInterpolatedStringHandler);
			럴.럒("security", "Verification failed | " + string.Join(" | ", list));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00079B18 File Offset: 0x00077D18
		private 럴.럒 랾(string A_1, string A_2, string A_3, 럴.랾 A_4)
		{
			럴.럒 result;
			try
			{
				럜.랾(A_1, A_2);
				Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
				dictionary["hwid"] = A_1;
				dictionary["install_id"] = A_2;
				dictionary["token"] = (string.IsNullOrWhiteSpace(A_3) ? null : A_3);
				dictionary["client_version"] = "2.0";
				dictionary["plugin_sha256"] = ((A_4 != null) ? A_4.랾() : null);
				dictionary["injector_sha256"] = ((A_4 != null) ? A_4.럎() : null);
				dictionary["renderer_sha256"] = ((A_4 != null) ? A_4.람() : null);
				dictionary["process_sha256"] = ((A_4 != null) ? A_4.럒() : null);
				string text = JsonSerializer.Serialize<Dictionary<string, object>>(dictionary, null);
				럚.랾 랾 = 럚.랾(럧.랪, text);
				string text2 = 랾.럎();
				if (!랾.람())
				{
					럴.럒 럒 = new 럴.럒();
					럒.랾 = 럴.람.랋;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
					defaultInterpolatedStringHandler.AppendLiteral("HTTP ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(랾.랾());
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					럒.람 = defaultInterpolatedStringHandler.ToStringAndClear();
					result = 럒;
				}
				else
				{
					using (JsonDocument jsonDocument = JsonDocument.Parse(text2, default(JsonDocumentOptions)))
					{
						JsonElement rootElement = jsonDocument.RootElement;
						JsonElement jsonElement;
						bool flag = rootElement.TryGetProperty("authorized", out jsonElement) && jsonElement.GetBoolean();
						JsonElement jsonElement2;
						string text3 = rootElement.TryGetProperty("name", out jsonElement2) ? jsonElement2.GetString() : null;
						JsonElement jsonElement3;
						bool flag2 = rootElement.TryGetProperty("is_developer", out jsonElement3) && jsonElement3.ValueKind == JsonValueKind.True;
						JsonElement jsonElement4;
						string 랋 = rootElement.TryGetProperty("expected_plugin_sha256", out jsonElement4) ? jsonElement4.GetString() : null;
						JsonElement jsonElement5;
						string 랉 = rootElement.TryGetProperty("expected_injector_sha256", out jsonElement5) ? jsonElement5.GetString() : null;
						JsonElement jsonElement6;
						string 럐 = rootElement.TryGetProperty("expected_renderer_sha256", out jsonElement6) ? jsonElement6.GetString() : null;
						JsonElement jsonElement7;
						string 랓 = rootElement.TryGetProperty("expected_process_sha256", out jsonElement7) ? jsonElement7.GetString() : null;
						JsonElement jsonElement8;
						string 럯 = rootElement.TryGetProperty("expected_client_version", out jsonElement8) ? jsonElement8.GetString() : null;
						if (flag)
						{
							JsonElement jsonElement9;
							string 럭 = rootElement.TryGetProperty("runtime_key_payload", out jsonElement9) ? jsonElement9.GetString() : null;
							JsonElement jsonElement10;
							string 럏 = rootElement.TryGetProperty("token", out jsonElement10) ? jsonElement10.GetString() : null;
							럧.럏 = 럏;
							JsonElement jsonElement11;
							result = new 럴.럒
							{
								랾 = 럴.람.랾,
								랾 = text3,
								럒 = 럏,
								럼 = (rootElement.TryGetProperty("token_expires_at", out jsonElement11) ? jsonElement11.GetString() : null),
								랾 = flag2,
								랋 = 랋,
								랉 = 랉,
								럐 = 럐,
								랓 = 랓,
								럯 = 럯,
								럭 = 럭
							};
						}
						else
						{
							JsonElement jsonElement12;
							string text4 = rootElement.TryGetProperty("reason", out jsonElement12) ? jsonElement12.GetString() : null;
							JsonElement jsonElement13;
							string text5 = rootElement.TryGetProperty("expired_on", out jsonElement13) ? jsonElement13.GetString() : null;
							if (text4 == "expired")
							{
								result = new 럴.럒
								{
									랾 = 럴.람.럎,
									랾 = text3,
									럎 = text5
								};
							}
							else if (text4 == "install_mismatch")
							{
								result = new 럴.럒
								{
									랾 = 럴.람.람,
									랾 = text3
								};
							}
							else if (text4 == "bad_token" || text4 == "missing_token" || text4 == "session_mismatch" || text4 == "session_expired")
							{
								result = new 럴.럒
								{
									랾 = 럴.람.럒,
									랾 = text3
								};
							}
							else if (text4 == "not_found")
							{
								result = new 럴.럒
								{
									랾 = 럴.람.럼
								};
							}
							else
							{
								JsonElement jsonElement14;
								string text6 = rootElement.TryGetProperty("message", out jsonElement14) ? jsonElement14.GetString() : null;
								JsonElement jsonElement15;
								string text7 = rootElement.TryGetProperty("code", out jsonElement15) ? jsonElement15.ToString() : null;
								if (!string.IsNullOrWhiteSpace(text4) || !string.IsNullOrWhiteSpace(text6) || !string.IsNullOrWhiteSpace(text7))
								{
									럴.럒 럒2 = new 럴.럒();
									럒2.랾 = 럴.람.랋;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(63, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("Unexpected verify response | reason=");
									defaultInterpolatedStringHandler2.AppendFormatted(text4 ?? "<missing>");
									defaultInterpolatedStringHandler2.AppendLiteral(" | message=");
									defaultInterpolatedStringHandler2.AppendFormatted(text6 ?? "<missing>");
									defaultInterpolatedStringHandler2.AppendLiteral(" | code=");
									defaultInterpolatedStringHandler2.AppendFormatted(text7 ?? "<missing>");
									defaultInterpolatedStringHandler2.AppendLiteral(" | body=");
									defaultInterpolatedStringHandler2.AppendFormatted(럴.럼(text2));
									럒2.람 = defaultInterpolatedStringHandler2.ToStringAndClear();
									result = 럒2;
								}
								else
								{
									result = new 럴.럒
									{
										랾 = 럴.람.럼
									};
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				result = new 럴.럒
				{
					랾 = 럴.람.랋,
					람 = ex.Message
				};
			}
			return result;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0007A078 File Offset: 0x00078278
		private static string 럼(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return "<empty>";
			}
			string text = A_0.Trim();
			if (text.Length <= 300)
			{
				return text;
			}
			return text.Substring(0, 300) + "...";
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0007A0C0 File Offset: 0x000782C0
		private static 럴.랾 럯()
		{
			럴.랾 랾 = new 럴.랾();
			랾.랾(럴.랋(Assembly.GetExecutingAssembly().Location));
			랾.럎(럴.랋(typeof(랉).Assembly.Location));
			랾.람(럴.랋(typeof(랫).Assembly.Location));
			랾.럒(럴.랋(럴.럭()));
			랾.럼(럴.럭());
			return 랾;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0007A140 File Offset: 0x00078340
		private static string 럭()
		{
			string result;
			try
			{
				result = Environment.ProcessPath;
			}
			catch
			{
				try
				{
					using (Process currentProcess = Process.GetCurrentProcess())
					{
						ProcessModule mainModule = currentProcess.MainModule;
						result = ((mainModule != null) ? mainModule.FileName : null);
					}
				}
				catch
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0007A1AC File Offset: 0x000783AC
		private static string 랋(string A_0)
		{
			string result;
			try
			{
				if (string.IsNullOrWhiteSpace(A_0) || !File.Exists(A_0))
				{
					result = null;
				}
				else
				{
					using (FileStream fileStream = File.OpenRead(A_0))
					{
						using (SHA256 sha = SHA256.Create())
						{
							result = BitConverter.ToString(sha.ComputeHash(fileStream)).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0007A240 File Offset: 0x00078440
		private static bool 랾(럴.럒 A_0, 럴.랾 A_1, out string A_2)
		{
			A_2 = null;
			if (!string.IsNullOrWhiteSpace(A_0.럯) && !string.Equals(A_0.럯.Trim(), "2.0", StringComparison.OrdinalIgnoreCase))
			{
				A_2 = "ClientVersionMismatch(" + A_0.럯.Trim() + ")";
				return false;
			}
			if (!럴.람(A_0.랋, (A_1 != null) ? A_1.랾() : null))
			{
				A_2 = "PluginHashMismatch";
				return false;
			}
			if (!럴.람(A_0.랉, (A_1 != null) ? A_1.럎() : null))
			{
				A_2 = "InjectorHashMismatch";
				return false;
			}
			if (!럴.람(A_0.럐, (A_1 != null) ? A_1.람() : null))
			{
				A_2 = "RendererHashMismatch";
				return false;
			}
			if (!럴.람(A_0.랓, (A_1 != null) ? A_1.럒() : null))
			{
				A_2 = "ProcessHashMismatch";
				return false;
			}
			return true;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
		private static bool 람(string A_0, string A_1)
		{
			return string.IsNullOrWhiteSpace(A_0) || (!string.IsNullOrWhiteSpace(A_1) && string.Equals(A_0.Trim(), A_1.Trim(), StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0007A31C File Offset: 0x0007851C
		private static bool 랉(string A_0)
		{
			DateTimeOffset left;
			return !string.IsNullOrWhiteSpace(A_0) && DateTimeOffset.TryParse(A_0, out left) && left <= DateTimeOffset.UtcNow;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0007A34C File Offset: 0x0007854C
		private static void 럒(string A_0, string A_1)
		{
			try
			{
				럕.랾(A_0, A_1);
			}
			catch
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0007A37C File Offset: 0x0007857C
		private static void 랱()
		{
			Thread thread = 럴.랾;
			if (thread != null && thread.IsAlive)
			{
				return;
			}
			럴.랾 = new Thread(new ThreadStart(럴.랋.랾.랾))
			{
				IsBackground = true,
				Name = "RuntimeKeyWatchdog"
			};
			럴.랾.Start();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0007A3E0 File Offset: 0x000785E0
		private string 럙()
		{
			this.랬();
			string text = 럴.랓(럧.럑);
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			string text2 = Guid.NewGuid().ToString("N");
			럴.럼(럧.럑, text2);
			return text2;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0003DBEC File Offset: 0x0003BDEC
		private string 랫()
		{
			this.랬();
			return 럴.랓(럧.럊);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0003DBFE File Offset: 0x0003BDFE
		private void 럐(string A_1)
		{
			this.랬();
			럴.럼(럧.럊, A_1);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0007A428 File Offset: 0x00078628
		private void 럍()
		{
			try
			{
				랖.랾();
				if (File.Exists(럧.럊))
				{
					File.Delete(럧.럊);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0003DC11 File Offset: 0x0003BE11
		private void 랬()
		{
			if (!Directory.Exists(럧.량))
			{
				Directory.CreateDirectory(럧.량);
			}
			럴.럯(럧.량);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0007A468 File Offset: 0x00078668
		private static void 럼(string A_0, string A_1)
		{
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(A_1 ?? string.Empty);
				byte[] bytes2;
				try
				{
					bytes2 = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
				}
				catch (Exception)
				{
					return;
				}
				File.WriteAllBytes(A_0, bytes2);
				럴.럯(A_0);
			}
			catch
			{
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0007A4C8 File Offset: 0x000786C8
		private static string 랓(string A_0)
		{
			string result;
			try
			{
				if (!File.Exists(A_0))
				{
					result = null;
				}
				else
				{
					byte[] array = File.ReadAllBytes(A_0);
					if (array.Length == 0)
					{
						result = string.Empty;
					}
					else
					{
						try
						{
							byte[] bytes = ProtectedData.Unprotect(array, null, DataProtectionScope.CurrentUser);
							result = Encoding.UTF8.GetString(bytes);
						}
						catch
						{
							result = Encoding.UTF8.GetString(array);
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0007A540 File Offset: 0x00078740
		private static void 럯(string A_0)
		{
			try
			{
				if (File.Exists(A_0) || Directory.Exists(A_0))
				{
					FileAttributes fileAttributes = File.GetAttributes(A_0);
					fileAttributes |= FileAttributes.Hidden;
					File.SetAttributes(A_0, fileAttributes);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400020E RID: 526
		private const string 랾 = "Charon_Client_White_Dress";

		// Token: 0x0400020F RID: 527
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"Charon_Client_White_Dress",
			"CharonXXIII.DearImGuiInjection"
		};

		// Token: 0x04000210 RID: 528
		private static bool 랾;

		// Token: 0x04000211 RID: 529
		private readonly string 럎 = global::랾.럙.랉();

		// Token: 0x04000212 RID: 530
		internal static DateTime? 랾 = new DateTime?(DateTime.Now);

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		private static ManualLogSource 랾;

		// Token: 0x04000214 RID: 532
		private Harmony 랾;

		// Token: 0x04000215 RID: 533
		private string 람 = "Unknown";

		// Token: 0x04000216 RID: 534
		private const uint 랾 = 0U;

		// Token: 0x04000217 RID: 535
		private const uint 럎 = 16U;

		// Token: 0x04000218 RID: 536
		private const uint 람 = 4096U;

		// Token: 0x04000219 RID: 537
		private const uint 럒 = 65536U;

		// Token: 0x0400021A RID: 538
		private const uint 럼 = 262144U;

		// Token: 0x0400021B RID: 539
		private bool 럎;

		// Token: 0x0400021C RID: 540
		private static readonly string 럒 = global::랾.럙.랾();

		// Token: 0x0400021D RID: 541
		private static readonly string 럼 = Path.Combine(럧.량, "state_cache.dat");

		// Token: 0x0400021E RID: 542
		private bool 람;

		// Token: 0x0400021F RID: 543
		private static readonly byte[] 랾 = new byte[32];

		// Token: 0x04000220 RID: 544
		private static volatile bool 랾 = false;

		// Token: 0x04000221 RID: 545
		private static readonly object 랾 = new object();

		// Token: 0x04000222 RID: 546
		private static Thread 랾;

		// Token: 0x0200003C RID: 60
		private sealed class 랾
		{
			// Token: 0x06000277 RID: 631 RVA: 0x0003DC52 File Offset: 0x0003BE52
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000278 RID: 632 RVA: 0x0003DC5A File Offset: 0x0003BE5A
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000279 RID: 633 RVA: 0x0003DC63 File Offset: 0x0003BE63
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0003DC6B File Offset: 0x0003BE6B
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0003DC74 File Offset: 0x0003BE74
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x0003DC7C File Offset: 0x0003BE7C
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x0600027D RID: 637 RVA: 0x0003DC85 File Offset: 0x0003BE85
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0003DC8D File Offset: 0x0003BE8D
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x0600027F RID: 639 RVA: 0x0003DC96 File Offset: 0x0003BE96
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x06000280 RID: 640 RVA: 0x0003DC9E File Offset: 0x0003BE9E
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x04000223 RID: 547
			[CompilerGenerated]
			private string 랾;

			// Token: 0x04000224 RID: 548
			[CompilerGenerated]
			private string 럎;

			// Token: 0x04000225 RID: 549
			[CompilerGenerated]
			private string 람;

			// Token: 0x04000226 RID: 550
			[CompilerGenerated]
			private string 럒;

			// Token: 0x04000227 RID: 551
			[CompilerGenerated]
			private string 럼;
		}

		// Token: 0x0200003D RID: 61
		private sealed class 럎
		{
			// Token: 0x06000282 RID: 642 RVA: 0x0003DCA7 File Offset: 0x0003BEA7
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000283 RID: 643 RVA: 0x0003DCAF File Offset: 0x0003BEAF
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0003DCC0 File Offset: 0x0003BEC0
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x06000286 RID: 646 RVA: 0x0003DCC9 File Offset: 0x0003BEC9
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x06000287 RID: 647 RVA: 0x0003DCD1 File Offset: 0x0003BED1
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0003DCDA File Offset: 0x0003BEDA
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0003DCE2 File Offset: 0x0003BEE2
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x04000228 RID: 552
			[CompilerGenerated]
			private string 랾;

			// Token: 0x04000229 RID: 553
			[CompilerGenerated]
			private string 럎;

			// Token: 0x0400022A RID: 554
			[CompilerGenerated]
			private string 람;

			// Token: 0x0400022B RID: 555
			[CompilerGenerated]
			private string 럒;
		}

		// Token: 0x0200003E RID: 62
		private enum 람
		{
			// Token: 0x0400022D RID: 557
			랾,
			// Token: 0x0400022E RID: 558
			럎,
			// Token: 0x0400022F RID: 559
			람,
			// Token: 0x04000230 RID: 560
			럒,
			// Token: 0x04000231 RID: 561
			럼,
			// Token: 0x04000232 RID: 562
			랋
		}

		// Token: 0x0200003F RID: 63
		private sealed class 럒
		{
			// Token: 0x04000233 RID: 563
			public 럴.람 랾;

			// Token: 0x04000234 RID: 564
			public string 랾;

			// Token: 0x04000235 RID: 565
			public string 럎;

			// Token: 0x04000236 RID: 566
			public string 람;

			// Token: 0x04000237 RID: 567
			public string 럒;

			// Token: 0x04000238 RID: 568
			public string 럼;

			// Token: 0x04000239 RID: 569
			public bool 랾;

			// Token: 0x0400023A RID: 570
			public string 랋;

			// Token: 0x0400023B RID: 571
			public string 랉;

			// Token: 0x0400023C RID: 572
			public string 럐;

			// Token: 0x0400023D RID: 573
			public string 랓;

			// Token: 0x0400023E RID: 574
			public string 럯;

			// Token: 0x0400023F RID: 575
			public string 럭;
		}

		// Token: 0x02000040 RID: 64
		[CompilerGenerated]
		private static class 럼
		{
			// Token: 0x04000240 RID: 576
			public static Action 랾;

			// Token: 0x04000241 RID: 577
			public static Action 럎;

			// Token: 0x04000242 RID: 578
			public static Func<PluginInfo, string> 랾;
		}

		// Token: 0x02000041 RID: 65
		[CompilerGenerated]
		[Serializable]
		private sealed class 랋
		{
			// Token: 0x0600028E RID: 654 RVA: 0x0003DCF7 File Offset: 0x0003BEF7
			internal bool 랾(PluginInfo A_1)
			{
				string value;
				if (A_1 == null)
				{
					value = null;
				}
				else
				{
					BepInPlugin metadata = A_1.Metadata;
					value = ((metadata != null) ? metadata.GUID : null);
				}
				return !string.IsNullOrWhiteSpace(value);
			}

			// Token: 0x0600028F RID: 655 RVA: 0x0003DD19 File Offset: 0x0003BF19
			internal string 럎(PluginInfo A_1)
			{
				return A_1.Metadata.GUID;
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0003DD26 File Offset: 0x0003BF26
			internal PluginInfo 랾(IGrouping<string, PluginInfo> A_1)
			{
				return A_1.First<PluginInfo>();
			}

			// Token: 0x06000291 RID: 657 RVA: 0x0003DD2E File Offset: 0x0003BF2E
			internal bool 람(PluginInfo A_1)
			{
				return !럴.랾.Contains(A_1.Metadata.GUID);
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0003DD48 File Offset: 0x0003BF48
			internal bool 랾(byte A_1)
			{
				return A_1 == 0;
			}

			// Token: 0x06000293 RID: 659 RVA: 0x0007A608 File Offset: 0x00078808
			internal void 랾()
			{
				for (;;)
				{
					Thread.Sleep(45000);
					럴.AssertRuntimeKeyValid("StartRuntimeKeyWatchdog");
					string str;
					if (!global::랾.랉.럼(out str))
					{
						럴.럒("tamper", "Periodic runtime guard check failed: " + str);
						Environment.Exit(0);
					}
				}
			}

			// Token: 0x04000243 RID: 579
			public static readonly 럴.랋 랾 = new 럴.랋();

			// Token: 0x04000244 RID: 580
			public static Func<PluginInfo, bool> 랾;

			// Token: 0x04000245 RID: 581
			public static Func<PluginInfo, string> 랾;

			// Token: 0x04000246 RID: 582
			public static Func<IGrouping<string, PluginInfo>, PluginInfo> 랾;

			// Token: 0x04000247 RID: 583
			public static Func<PluginInfo, bool> 럎;

			// Token: 0x04000248 RID: 584
			public static Func<byte, bool> 랾;

			// Token: 0x04000249 RID: 585
			public static ThreadStart 랾;
		}
	}
}
