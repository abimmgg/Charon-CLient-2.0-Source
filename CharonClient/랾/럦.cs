using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppSystem.Collections.Generic;
using ImGuiNET;
using Kernys.Bson;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace 랾
{
	// Token: 0x02000081 RID: 129
	internal class 럦
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00087284 File Offset: 0x00085484
		public static void 랾()
		{
			global::랾.럓.랾();
			global::랾.럦.램();
			global::랾.럦.랛();
			global::랾.럷.랾();
			try
			{
				global::랾.럐.럎();
				global::랾.럦.럒();
				global::랾.럦.랦();
				global::랾.럦.럍();
				global::랾.럦.랬();
				global::랾.럦.럑();
				global::랾.럦.럊();
				global::랾.럦.랔();
				global::랾.럦.랿();
				if (!ConfigFile.showMiniMapToggle && (global::랾.랅.랾(304) || ConfigFile.alwaysShowToolTipToggle))
				{
					global::랾.럠.랾();
				}
				global::랾.럦.랒();
				global::랾.랃.랾();
			}
			finally
			{
				global::랾.럦.럎();
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00087314 File Offset: 0x00085514
		private unsafe static void 럎()
		{
			bool flag = false;
			bool flag2 = false;
			try
			{
				if (global::랾.랉.랾() && global::랾.랉.럎() != IntPtr.Zero)
				{
					ImGuiIOPtr imGuiIOPtr = global::랾.랉.람();
					flag = *imGuiIOPtr.WantCaptureMouse;
					flag2 = *imGuiIOPtr.WantTextInput;
				}
			}
			catch
			{
				flag = false;
				flag2 = false;
			}
			global::랾.랉.랾(flag, flag2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00087378 File Offset: 0x00085578
		private static void 람()
		{
			string text;
			if (!global::랾.럧.럑)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 4);
				defaultInterpolatedStringHandler.AppendLiteral("FPS: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.럧.랉);
				defaultInterpolatedStringHandler.AppendLiteral(" | Ping: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(KukouriTime.lag);
				defaultInterpolatedStringHandler.AppendLiteral(" | Clients Online: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.람);
				defaultInterpolatedStringHandler.AppendLiteral(" | User: ");
				defaultInterpolatedStringHandler.AppendFormatted(global::랾.럦.랾(30));
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(33, 3);
				defaultInterpolatedStringHandler2.AppendLiteral("FPS: ");
				defaultInterpolatedStringHandler2.AppendFormatted<float>(global::랾.럧.랉);
				defaultInterpolatedStringHandler2.AppendLiteral(" | Ping: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(KukouriTime.lag);
				defaultInterpolatedStringHandler2.AppendLiteral(" | Clients Online: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럧.람);
				text = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			ImGui.Text(text);
			if (global::랾.럧.랋)
			{
				ImGui.Separator();
				ImGui.Text("Stream Detected! Sensitive Information Hidden.");
				ImGui.Text("Your stream is secure, we detect this by checking if the game window is currently being captured by any streaming software.");
				ImGui.Text("ID: " + global::랾.럦.랾(50));
			}
			ImGui.Separator();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0008749C File Offset: 0x0008569C
		private static void 럒()
		{
			bool showMenu = ConfigFile.showMenu;
			if (!global::랾.럦.랾("MainMenuWindow", showMenu))
			{
				return;
			}
			bool showMenu2 = true;
			global::랾.럦.랋();
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!showMenu)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag = global::랾.럦.럎("MainMenuWindow", showMenu);
			bool flag2 = ImGui.Begin("Charon Free Edition 2.0", ref showMenu2, imGuiWindowFlags);
			try
			{
				if (flag2)
				{
					global::랾.럦.랾(8f);
					global::랾.럦.랉();
					global::랾.럦.럼();
				}
				global::랾.럦.럼("MainMenuWindow");
			}
			finally
			{
				ImGui.End();
				if (flag)
				{
					ImGui.PopStyleVar();
				}
			}
			if (showMenu)
			{
				ConfigFile.showMenu = showMenu2;
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00087538 File Offset: 0x00085738
		private static void 럼()
		{
			if (!ImGui.BeginTabBar("MainTabs", 257))
			{
				return;
			}
			try
			{
				global::랾.럦.럺();
				global::랾.럦.럠();
				global::랾.럦.략();
				global::랾.럦.럵();
				global::랾.럦.랝();
				global::랾.럦.럃();
				global::랾.럦.럐();
				global::랾.럦.랣();
				global::랾.럦.랺();
				global::랾.럦.럾();
				global::랾.럦.럀();
				if (global::랾.럧.럑)
				{
					global::랾.럦.랳();
				}
			}
			finally
			{
				ImGui.EndTabBar();
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		private static void 랋()
		{
			ImGui.SetNextWindowSize(global::랾.럦.랾, 4);
			ImGui.SetNextWindowSizeConstraints(global::랾.럦.럎, new Vector2(float.MaxValue, float.MaxValue));
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000875B4 File Offset: 0x000857B4
		private unsafe static void 랾(float A_0 = 8f)
		{
			Vector2 vector = *ImGui.GetIO().DisplaySize;
			if (vector.X <= 0f || vector.Y <= 0f)
			{
				return;
			}
			Vector2 windowPos = ImGui.GetWindowPos();
			Vector2 windowSize = ImGui.GetWindowSize();
			float max = MathF.Max(A_0, vector.X - windowSize.X - A_0);
			float max2 = MathF.Max(A_0, vector.Y - windowSize.Y - A_0);
			Vector2 vector2 = new Vector2(Math.Clamp(windowPos.X, A_0, max), Math.Clamp(windowPos.Y, A_0, max2));
			if (Vector2.DistanceSquared(windowPos, vector2) > 0.01f)
			{
				ImGui.SetWindowPos(vector2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00087664 File Offset: 0x00085864
		private static bool 랾(string A_0, int A_1)
		{
			ImGuiTableFlags imGuiTableFlags = 33296;
			if (ConfigFile.uiEnhancedSurfacesEnabled || ConfigFile.uiPillTabsEnabled)
			{
				imGuiTableFlags &= -513;
			}
			return ImGui.BeginTable(A_0, A_1, imGuiTableFlags);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00087698 File Offset: 0x00085898
		private static void 랾(string A_0)
		{
			Vector4 vector = global::랾.럦.랃();
			ImGui.TextColored(global::랾.랽.랾(global::랾.럦.랾, vector, 0.24f), A_0);
			if (!ConfigFile.uiSectionAccentEnabled)
			{
				ImGui.Separator();
				return;
			}
			float num = Math.Clamp(ConfigFile.uiSectionAccentThickness, 1f, 4f);
			float num2 = Math.Clamp(ConfigFile.uiSectionAccentLength, 0.2f, 1f);
			Vector2 itemRectMin = ImGui.GetItemRectMin();
			Vector2 itemRectMax = ImGui.GetItemRectMax();
			float num3 = itemRectMax.X - itemRectMin.X;
			float num4 = ImGui.GetContentRegionAvail().X - num3 - 12f;
			if (num4 <= 20f)
			{
				ImGui.Separator();
				return;
			}
			float num5 = Math.Min(num4, Math.Max(32f, num4 * num2));
			float y = itemRectMin.Y + (itemRectMax.Y - itemRectMin.Y) * 0.72f;
			Vector2 vector2 = new Vector2(itemRectMax.X + 12f, y);
			Vector2 vector3 = new Vector2(vector2.X + num5, y);
			Vector4 vector4 = global::랾.랽.랾(vector, 0.9f);
			Vector4 vector5 = global::랾.랽.랾(vector, 0.28f);
			ImDrawListPtr windowDrawList = ImGui.GetWindowDrawList();
			windowDrawList.AddLine(vector2, vector3, ImGui.ColorConvertFloat4ToU32(vector4), num);
			windowDrawList.AddLine(new Vector2(itemRectMin.X, itemRectMax.Y + 6f), new Vector2(itemRectMin.X + (itemRectMax.X - itemRectMin.X) + num5, itemRectMax.Y + 6f), ImGui.ColorConvertFloat4ToU32(vector5), 1f);
			ImGui.Dummy(new Vector2(0f, 5f));
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00087834 File Offset: 0x00085A34
		internal unsafe static void 랉()
		{
			if (!ConfigFile.uiWindowGlowEnabled)
			{
				return;
			}
			Vector2 windowPos = ImGui.GetWindowPos();
			Vector2 windowSize = ImGui.GetWindowSize();
			if (windowSize.X <= 16f || windowSize.Y <= 16f)
			{
				return;
			}
			Vector4 vector = global::랾.럦.랃();
			float num = Math.Clamp(ConfigFile.uiWindowGlowStrength, 0.05f, 0.65f);
			float num2 = *ImGui.GetStyle().WindowRounding;
			ImDrawListPtr backgroundDrawList = ImGui.GetBackgroundDrawList();
			uint num3 = ImGui.ColorConvertFloat4ToU32(global::랾.랽.랾(vector, 0.05f * num));
			uint num4 = ImGui.ColorConvertFloat4ToU32(global::랾.랽.랾(vector, 0.11f * num));
			uint num5 = ImGui.ColorConvertFloat4ToU32(global::랾.랽.랾(vector, 0.38f * num));
			for (int i = 0; i < 3; i++)
			{
				float num6 = 6f + (float)i * 5f;
				float num7 = num2 + num6;
				uint num8 = (i == 0) ? num4 : num3;
				backgroundDrawList.AddRect(new Vector2(windowPos.X - num6, windowPos.Y - num6), new Vector2(windowPos.X + windowSize.X + num6, windowPos.Y + windowSize.Y + num6), num8, num7, 0, 1.5f + (float)i * 0.5f);
			}
			backgroundDrawList.AddRect(windowPos, new Vector2(windowPos.X + windowSize.X, windowPos.Y + windowSize.Y), num5, num2, 0, 1.2f);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0008799C File Offset: 0x00085B9C
		public static string 랾(int A_0)
		{
			string text = global::랾.럧.랱;
			if (string.IsNullOrWhiteSpace(text))
			{
				return "Unknown";
			}
			if (A_0 < text.Length)
			{
				return text.Substring(A_0);
			}
			return text;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000879D0 File Offset: 0x00085BD0
		private static void 럐()
		{
			if (!ImGui.BeginTabItem("Automation"))
			{
				return;
			}
			global::랾.럦.람();
			ImGui.TextWrapped("Start and stop each automation tool here. Open a control center when you want detailed timing, routing, recovery, or storage settings.");
			ImGui.Separator();
			if (global::랾.럦.랾("AutomationSections", 2))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Control Centers");
					ImGui.TextDisabled("These are the main automation bots with their own detailed windows.");
					global::랾.럦.랓();
					ImGui.TableNextColumn();
					global::랾.럦.랾("Support Tools");
					ImGui.TextDisabled("These are smaller helpers that work alongside the main bots.");
					global::랾.럦.럯();
					goto IL_97;
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			global::랾.럦.랾("Control Centers");
			global::랾.럦.랓();
			ImGui.Spacing();
			global::랾.럦.랾("Support Tools");
			global::랾.럦.럯();
			IL_97:
			ImGui.Spacing();
			global::랾.럦.랾("World Helpers");
			global::랾.럦.럘();
			ImGui.EndTabItem();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00087AA0 File Offset: 0x00085CA0
		private static void 랓()
		{
			string text = "Auto Fish";
			string text2 = "Fishbot";
			bool 럈 = global::랾.럧.럈;
			Action<bool> action;
			if ((action = global::랾.럦.럒.랾) == null)
			{
				action = (global::랾.럦.럒.랾 = new Action<bool>(global::랾.럦.럒));
			}
			Action action2;
			if ((action2 = global::랾.럦.럒.랾) == null)
			{
				action2 = (global::랾.럦.럒.랾 = new Action(global::랾.럦.럭));
			}
			global::랾.럦.랾(text, text2, 럈, action, ref global::랾.럦.럎, action2);
			ImGui.Spacing();
			string text3 = "Auto Mine";
			string text4 = "Minebot";
			bool 랺 = global::랾.럧.랺;
			Action<bool> action3;
			if ((action3 = global::랾.럦.럒.럎) == null)
			{
				action3 = (global::랾.럦.럒.럎 = new Action<bool>(global::랾.럦.럎));
			}
			Action action4;
			if ((action4 = global::랾.럦.럒.럎) == null)
			{
				action4 = (global::랾.럦.럒.럎 = new Action(global::랾.럦.럽));
			}
			global::랾.럦.랾(text3, text4, 랺, action3, ref global::랾.럦.람, action4);
			ImGui.Spacing();
			string text5 = "Auto Nether";
			string text6 = "Netherbot";
			bool 럷 = global::랾.럧.럷;
			Action<bool> action5 = new Action<bool>(global::랾.럦.럼.랾.랾);
			Action action6;
			if ((action6 = global::랾.럦.럒.람) == null)
			{
				action6 = (global::랾.럦.럒.람 = new Action(global::랾.럦.러));
			}
			global::랾.럦.랾(text5, text6, 럷, action5, ref global::랾.럦.럒, action6);
			ImGui.Spacing();
			string text7 = "Auto Farm";
			string text8 = "AutoFarm";
			bool 럆 = global::랾.럧.럆;
			Action<bool> action7;
			if ((action7 = global::랾.럦.럒.람) == null)
			{
				action7 = (global::랾.럦.럒.람 = new Action<bool>(global::랾.럦.랾));
			}
			Action action8;
			if ((action8 = global::랾.럦.럒.럒) == null)
			{
				action8 = (global::랾.럦.럒.럒 = new Action(global::랾.럦.랫));
			}
			global::랾.럦.랾(text7, text8, 럆, action7, ref global::랾.럦.랾, action8);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00087BFC File Offset: 0x00085DFC
		private static void 랾(string A_0, string A_1, bool A_2, Action<bool> A_3, ref bool A_4, Action A_5)
		{
			bool flag = A_2;
			if (ImGui.Checkbox(A_0, ref flag))
			{
				A_3(flag);
				A_2 = flag;
				if (flag)
				{
					A_4 = true;
				}
			}
			ImGui.SameLine();
			if (ImGui.Button(A_2 ? ("Open " + A_1) : ("Configure " + A_1)))
			{
				A_4 = true;
			}
			if (A_5 != null)
			{
				A_5();
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00087C60 File Offset: 0x00085E60
		private static void 럯()
		{
			ImGui.TextDisabled("Travel and Loot");
			ImGui.Checkbox("Auto Mining Wheel", ref global::랾.럧.랽);
			global::랾.러.랾("Open Pouches", ref ConfigFile.openPouchSpam);
			ImGui.Spacing();
			ImGui.TextDisabled("Combat and Recycling");
			ImGui.Checkbox("Auto Recycle", ref global::랾.럧.럧);
			if (global::랾.럧.럧)
			{
				global::랾.럦.럜();
			}
			ImGui.Checkbox("Auto SB Boss", ref global::랾.럧.럦);
			ImGui.Checkbox("Auto Secret Base", ref global::랾.럧.랃);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00087CE4 File Offset: 0x00085EE4
		private static void 럭()
		{
			string value = global::랾.랆.량();
			string text;
			if (!global::랾.럧.럈)
			{
				text = "Open the Fishbot window for delays, stats, recovery, and webhook settings.";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Fishbot: ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럫);
				defaultInterpolatedStringHandler.AppendLiteral(" caught | ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.랆.럩(), "F1");
				defaultInterpolatedStringHandler.AppendLiteral("/hr");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			ImGui.TextDisabled(text);
			if (!global::랾.럧.럈)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("Preview: ");
			defaultInterpolatedStringHandler2.AppendFormatted(global::랾.랆.럙());
			defaultInterpolatedStringHandler2.AppendLiteral(" (");
			defaultInterpolatedStringHandler2.AppendFormatted(global::랾.랆.랫());
			defaultInterpolatedStringHandler2.AppendLiteral(")");
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler3.AppendLiteral("Last Catch: ");
			defaultInterpolatedStringHandler3.AppendFormatted(global::랾.랆.럍());
			defaultInterpolatedStringHandler3.AppendLiteral(" (");
			defaultInterpolatedStringHandler3.AppendFormatted(global::랾.랆.랬());
			defaultInterpolatedStringHandler3.AppendLiteral(")");
			ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
			if (global::랾.랆.럝())
			{
				ImGui.TextColored(new Vector4(1f, 0.8f, 0.35f, 1f), "Current fish is being skipped because the active rod cannot safely land huge fish.");
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0003EDB2 File Offset: 0x0003CFB2
		private static void 랾(bool A_0)
		{
			global::랾.럧.럆 = A_0;
			if (!A_0)
			{
				global::랾.랐.랓();
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0003EDC2 File Offset: 0x0003CFC2
		private static void 럎(bool A_0)
		{
			global::랾.럧.랺 = A_0;
			if (!A_0)
			{
				global::랾.랆.랋(false);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0003EDD3 File Offset: 0x0003CFD3
		private static bool 랱()
		{
			return global::랾.럧.럸;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00087E48 File Offset: 0x00086048
		private static void 럙()
		{
			global::랾.럦.럼 = true;
			if (global::랾.럧.럸)
			{
				return;
			}
			string text;
			if (global::랾.랆.랾(out text))
			{
				global::랾.럽.럒("World Cleaner started.", true);
				return;
			}
			global::랾.럽.럎(text, false);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0003EDDA File Offset: 0x0003CFDA
		private static void 람(bool A_0)
		{
			if (!A_0)
			{
				global::랾.랆.럐(false);
				return;
			}
			global::랾.럦.럙();
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00087E80 File Offset: 0x00086080
		private static void 랫()
		{
			string value = global::랾.랐.럯();
			string text;
			if (!global::랾.럧.럆)
			{
				text = "Open the AutoFarm window to choose the pattern, refill storage, output storage, and refill order.";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
				defaultInterpolatedStringHandler.AppendLiteral("AutoFarm: ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted(global::랾.랐.랫());
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.럔());
				defaultInterpolatedStringHandler.AppendLiteral(" spots");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			ImGui.TextDisabled(text);
			if (!global::랾.럧.럆)
			{
				return;
			}
			ImGui.Text("Anchor: " + global::랾.랐.럙());
			ImGui.Text("Refill: " + global::랾.랐.럏());
			ImGui.Text("Output: " + global::랾.랐.럫());
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0003EDEB File Offset: 0x0003CFEB
		private static void 럒(bool A_0)
		{
			global::랾.럧.럈 = A_0;
			if (!A_0)
			{
				global::랾.랆.럎(false);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00087F4C File Offset: 0x0008614C
		private static void 럍()
		{
			bool flag = ConfigFile.showMenu && global::랾.럦.럎;
			if (!global::랾.럦.랾("Fishbot Control Center", flag))
			{
				return;
			}
			ImGui.SetNextWindowSize(new Vector2(760f, 585f), 4);
			ImGui.SetNextWindowSizeConstraints(new Vector2(580f, 430f), new Vector2(float.MaxValue, float.MaxValue));
			bool flag2 = global::랾.럦.럎;
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!flag)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag3 = global::랾.럦.럎("Fishbot Control Center", flag);
			if (!ImGui.Begin("Fishbot Control Center", ref flag2, imGuiWindowFlags))
			{
				if (flag)
				{
					global::랾.럦.럎 = flag2;
				}
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("Fishbot Control Center");
				}
				return;
			}
			try
			{
				if (flag)
				{
					global::랾.럦.럎 = flag2;
				}
				global::랾.럦.랾(8f);
				global::랾.럦.랉();
				ImGui.BeginChild("##AutoFishWindowBody", new Vector2(0f, -ImGui.GetFrameHeightWithSpacing() - 8f), 0);
				try
				{
					bool 럈 = global::랾.럧.럈;
					if (ImGui.Checkbox("Enable Auto Fish", ref 럈))
					{
						global::랾.럦.럒(럈);
					}
					ImGui.SameLine();
					ImGui.Checkbox("Legitimate Mode", ref ConfigFile.LegitimateAutoFish);
					ImGui.SameLine();
					if (ImGui.Button("Reset State"))
					{
						global::랾.랆.럎(false);
						global::랾.럽.럒("AutoFish runtime reset.", true);
					}
					ImGui.SameLine();
					if (ImGui.Button("Reset Session"))
					{
						global::랾.랆.럎(true);
						global::랾.럽.럒("AutoFish session stats reset.", true);
					}
					ImGui.TextColored(new Vector4(0.45f, 0.85f, 1f, 1f), "Status: " + global::랾.랆.량());
					ImGui.TextWrapped("Using a low-level rod, such as Bamboo or Fiberglass, will cause huge fish to be intentionally skipped. Carbon Fiber or Titanium is the safer choice for unattended fishing.");
					if (!ConfigFile.LegitimateAutoFish)
					{
						ImGui.TextColored(new Vector4(1f, 0.45f, 0.45f, 1f), "Warning:");
						ImGui.TextWrapped("Legitimate Mode adds longer natural pauses. Turning it off can increase game and shadow-ban risk.");
					}
					ImGui.Separator();
					if (ImGui.BeginTabBar("##AutoFishTabs"))
					{
						try
						{
							if (ImGui.BeginTabItem("Overview"))
							{
								try
								{
									global::랾.럦.럻();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Delays"))
							{
								try
								{
									global::랾.럦.랖();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Alerts"))
							{
								try
								{
									global::랾.럦.럝();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
						}
						finally
						{
							ImGui.EndTabBar();
						}
					}
				}
				finally
				{
					ImGui.EndChild();
				}
				if (ImGui.Button("Close"))
				{
					global::랾.럦.럎 = false;
				}
			}
			finally
			{
				global::랾.럦.럼("Fishbot Control Center");
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("Fishbot Control Center");
				}
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0008825C File Offset: 0x0008645C
		private static void 랬()
		{
			bool flag = ConfigFile.showMenu && global::랾.럦.람;
			if (!global::랾.럦.랾("Minebot Control Center", flag))
			{
				return;
			}
			ImGui.SetNextWindowSize(new Vector2(760f, 535f), 4);
			ImGui.SetNextWindowSizeConstraints(new Vector2(580f, 420f), new Vector2(float.MaxValue, float.MaxValue));
			bool flag2 = global::랾.럦.람;
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!flag)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag3 = global::랾.럦.럎("Minebot Control Center", flag);
			if (!ImGui.Begin("Minebot Control Center", ref flag2, imGuiWindowFlags))
			{
				if (flag)
				{
					global::랾.럦.람 = flag2;
				}
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("Minebot Control Center");
				}
				return;
			}
			try
			{
				if (flag)
				{
					global::랾.럦.람 = flag2;
				}
				global::랾.럦.랾(8f);
				global::랾.럦.랉();
				ImGui.BeginChild("##AutoMineWindowBody", new Vector2(0f, -ImGui.GetFrameHeightWithSpacing() - 8f), 0);
				try
				{
					bool 랺 = global::랾.럧.랺;
					if (ImGui.Checkbox("Enable Auto Mine", ref 랺))
					{
						global::랾.럦.럎(랺);
					}
					ImGui.SameLine();
					ImGui.Checkbox("Auto Convert Nuggets", ref ConfigFile.autoConvert);
					ImGui.SameLine();
					ImGui.Checkbox("Auto Mining Wheel", ref global::랾.럧.랽);
					ImGui.SameLine();
					if (ImGui.Button("Reset State"))
					{
						global::랾.랆.랋(false);
						global::랾.럽.럒("Auto Mine runtime reset.", true);
					}
					ImGui.SameLine();
					if (ImGui.Button("Reset Session"))
					{
						global::랾.랆.랋(true);
						global::랾.럽.럒("Auto Mine session stats reset.", true);
					}
					ImGui.TextColored(new Vector4(0.45f, 0.85f, 1f, 1f), "Status: " + global::랾.랆.랡());
					ImGui.TextWrapped("Minebot joins the next enabled mine key you have, clears gemstones and collectables, then leaves through the exit when the mine is empty.");
					ImGui.Separator();
					if (ImGui.BeginTabBar("##AutoMineTabs"))
					{
						try
						{
							if (ImGui.BeginTabItem("Overview"))
							{
								try
								{
									global::랾.럦.란();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Routing"))
							{
								try
								{
									global::랾.럦.럇();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Timing"))
							{
								try
								{
									global::랾.럦.랯();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
						}
						finally
						{
							ImGui.EndTabBar();
						}
					}
				}
				finally
				{
					ImGui.EndChild();
				}
				if (ImGui.Button("Close"))
				{
					global::랾.럦.람 = false;
				}
			}
			finally
			{
				global::랾.럦.럼("Minebot Control Center");
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("Minebot Control Center");
				}
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00088550 File Offset: 0x00086750
		private static void 란()
		{
			if (ImGui.BeginTable("##AutoMineOverviewGrid", 2, 33280))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Session");
					ImGui.Text("Time: " + global::랾.랆.럸());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Completed: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럳);
					ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Disconnects: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럧.랢);
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("Rate: ");
					defaultInterpolatedStringHandler3.AppendFormatted<float>(global::랾.랆.랳(), "F1");
					defaultInterpolatedStringHandler3.AppendLiteral("/hr");
					ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler4.AppendLiteral("Current Mine: ");
					defaultInterpolatedStringHandler4.AppendFormatted<float>(global::랾.럧.랺, "F1");
					defaultInterpolatedStringHandler4.AppendLiteral("s");
					ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
					ImGui.TableNextColumn();
					global::랾.럦.랾("Runtime");
					ImGui.Text("World: " + global::랾.랆.랆());
					ImGui.Text("Target: " + global::랾.랆.랃());
					ImGui.Text("Route: " + global::랾.랆.랛());
					ImGui.Text("Collectables: " + global::랾.랆.랐());
					ImGui.Text("In Mine: " + global::랾.랆.럆());
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			global::랾.럦.랾("Behavior");
			ImGui.Text("Key Order: " + global::랾.랆.랄());
			ImGui.TextWrapped("Minebot checks the enabled mine keys from lowest to highest, spends the first one you have, and falls back to the free mine if no enabled key is available.");
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0008872C File Offset: 0x0008692C
		private static void 럇()
		{
			global::랾.럦.랾("Menu Return World");
			ImGui.TextWrapped("This is the world Auto Mine returns to before it spends the next mine key. This setting is shared with the generic automation reconnect flow.");
			ImGui.InputText("##AutoMineReturnWorldName", ref ConfigFile.rejoinWorldName, 100U);
			ImGui.Spacing();
			global::랾.럦.랾("Mine Key Levels");
			ImGui.TextWrapped("Enable the mine levels Auto Mine is allowed to spend. It will try them in order from Mine I to Mine IV.");
			ImGui.Checkbox("Use Mine I Keys", ref ConfigFile.MineLevel1);
			ImGui.Checkbox("Use Mine II Keys", ref ConfigFile.MineLevel2);
			ImGui.Checkbox("Use Mine III Keys", ref ConfigFile.MineLevel3);
			ImGui.Checkbox("Use Mine IV Keys", ref ConfigFile.MineLevel4);
			ImGui.Spacing();
			global::랾.럦.랾("Related Automation");
			ImGui.TextWrapped("Auto Convert turns mining nuggets into bars when the stack is high enough. Auto Mining Wheel spends mining roulette tokens whenever they are capped.");
			ImGui.Checkbox("Auto Convert Nuggets##AutoMineRoutingConvert", ref ConfigFile.autoConvert);
			ImGui.Checkbox("Auto Mining Wheel##AutoMineRoutingWheel", ref global::랾.럧.랽);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000887F4 File Offset: 0x000869F4
		private static void 랯()
		{
			global::랾.럦.랾("Teleport Delay");
			ImGui.TextWrapped("How long Minebot waits before it starts the next teleport hop toward the current target.");
			ImGui.SliderFloat("Teleport Delay##AutoMineTeleportDelay", ref ConfigFile.autoMineTeleportTimerMax, 0.05f, 3f, "%.2fs");
			global::랾.럦.랾("Break Delay");
			ImGui.TextWrapped("How often Minebot tries to break the next block around the player while it is clearing a route.");
			ImGui.SliderFloat("Break Delay##AutoMineBreakDelay", ref ConfigFile.autoMineBreakTimerMax, 0.05f, 2f, "%.2fs");
			ImGui.Spacing();
			global::랾.럦.랾("Defaults");
			ImGui.TextWrapped("These two timers control most of the pacing. Lower values are faster but look more aggressive.");
			if (ImGui.Button("Reset Timing to Defaults##AutoMine"))
			{
				ConfigFile.autoMineTeleportTimerMax = 0.5f;
				ConfigFile.autoMineBreakTimerMax = 0.3f;
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000888A0 File Offset: 0x00086AA0
		private static void 러()
		{
			string value = global::랾.랆.래();
			string value2 = global::랾.럦.랾[Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.럦.랾.Length - 1)];
			string text;
			if (!global::랾.럧.럷)
			{
				text = "Open the Netherbot window to choose scroll or red portal entry, targets, and status.";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Netherbot: ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | Entry: ");
				defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.랈());
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			ImGui.TextDisabled(text);
			if (!global::랾.럧.럷)
			{
				return;
			}
			ImGui.Text("Source: " + global::랾.랆.랎());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(15, 3);
			defaultInterpolatedStringHandler2.AppendLiteral("Targets: ");
			defaultInterpolatedStringHandler2.AppendFormatted(global::랾.럧.럣 ? "Enemies On" : "Enemies Off");
			defaultInterpolatedStringHandler2.AppendLiteral(" | ");
			defaultInterpolatedStringHandler2.AppendFormatted(ConfigFile.autoNetherTargetTreasure ? "Treasure Chests On" : "Treasure Chests Off");
			defaultInterpolatedStringHandler2.AppendLiteral(" | ");
			defaultInterpolatedStringHandler2.AppendFormatted(ConfigFile.autoNetherTargetGiftBoxes ? "Gift Boxes On" : "Gift Boxes Off");
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			if (ConfigFile.autoNetherEntryMode == 1)
			{
				ImGui.TextWrapped(global::랾.랆.럿());
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000889E8 File Offset: 0x00086BE8
		private static void 량()
		{
			string value = global::랾.랆.랍();
			bool flag = global::랾.럦.랱();
			string text;
			if (!flag)
			{
				text = "Open the World Cleaner window to preview the clear, start it instantly, and track the current target.";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
				defaultInterpolatedStringHandler.AppendLiteral("World Cleaner: ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.랏());
				defaultInterpolatedStringHandler.AppendLiteral(" tiles left | ETA ");
				defaultInterpolatedStringHandler.AppendFormatted(global::랾.랆.랾(global::랾.랆.럋()));
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			ImGui.TextDisabled(text);
			if (!flag && !global::랾.럽.랾())
			{
				return;
			}
			ImGui.Text("Phase: " + global::랾.랆.럞());
			ImGui.Text("Target: " + global::랾.랆.랔());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(31, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("Preview: ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.랆.랷());
			defaultInterpolatedStringHandler2.AppendLiteral(" blocks | ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.랆.랤());
			defaultInterpolatedStringHandler2.AppendLiteral(" backgrounds");
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00088AF0 File Offset: 0x00086CF0
		private static void 럑()
		{
			bool flag = ConfigFile.showMenu && global::랾.럦.럒;
			if (!global::랾.럦.랾("Netherbot Control Center", flag))
			{
				return;
			}
			ImGui.SetNextWindowSize(new Vector2(760f, 530f), 4);
			ImGui.SetNextWindowSizeConstraints(new Vector2(580f, 420f), new Vector2(float.MaxValue, float.MaxValue));
			bool flag2 = global::랾.럦.럒;
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!flag)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag3 = global::랾.럦.럎("Netherbot Control Center", flag);
			if (!ImGui.Begin("Netherbot Control Center", ref flag2, imGuiWindowFlags))
			{
				if (flag)
				{
					global::랾.럦.럒 = flag2;
				}
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("Netherbot Control Center");
				}
				return;
			}
			try
			{
				if (flag)
				{
					global::랾.럦.럒 = flag2;
				}
				global::랾.럦.랾(8f);
				global::랾.럦.랉();
				ImGui.BeginChild("##AutoNetherWindowBody", new Vector2(0f, -ImGui.GetFrameHeightWithSpacing() - 8f), 0);
				try
				{
					bool 럷 = global::랾.럧.럷;
					if (ImGui.Checkbox("Enable Auto Nether", ref 럷))
					{
						global::랾.럧.럷 = 럷;
					}
					ImGui.SameLine();
					ImGui.Checkbox("Target Enemies", ref global::랾.럧.럣);
					ImGui.SameLine();
					ImGui.Checkbox("Target Treasure Chests", ref ConfigFile.autoNetherTargetTreasure);
					ImGui.TextColored(new Vector4(0.45f, 0.85f, 1f, 1f), "Status: " + global::랾.랆.래());
					ImGui.TextWrapped("Scroll mode uses the matching red scroll from your inventory. Selected Red Portal mode uses the portal tile you save here, and the portal level must match the Nether Level you choose.");
					ImGui.Separator();
					if (ImGui.BeginTabBar("##AutoNetherTabs"))
					{
						try
						{
							if (ImGui.BeginTabItem("Overview"))
							{
								try
								{
									global::랾.럦.럫();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Entry"))
							{
								try
								{
									global::랾.럦.럴();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Timing"))
							{
								try
								{
									global::랾.럦.럩();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Targets"))
							{
								try
								{
									global::랾.럦.럲();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
						}
						finally
						{
							ImGui.EndTabBar();
						}
					}
				}
				finally
				{
					ImGui.EndChild();
				}
				if (ImGui.Button("Close"))
				{
					global::랾.럦.럒 = false;
				}
			}
			finally
			{
				global::랾.럦.럼("Netherbot Control Center");
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("Netherbot Control Center");
				}
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00088DD4 File Offset: 0x00086FD4
		private static void 럊()
		{
			bool flag = ConfigFile.showMenu && global::랾.럦.럼;
			if (!global::랾.럦.랾("World Cleaner Control Center", flag))
			{
				return;
			}
			ImGui.SetNextWindowSize(new Vector2(760f, 545f), 4);
			ImGui.SetNextWindowSizeConstraints(new Vector2(580f, 420f), new Vector2(float.MaxValue, float.MaxValue));
			bool flag2 = global::랾.럦.럼;
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!flag)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag3 = global::랾.럦.럎("World Cleaner Control Center", flag);
			if (!ImGui.Begin("World Cleaner Control Center", ref flag2, imGuiWindowFlags))
			{
				if (flag)
				{
					global::랾.럦.럼 = flag2;
				}
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("World Cleaner Control Center");
				}
				return;
			}
			try
			{
				if (flag)
				{
					global::랾.럦.럼 = flag2;
				}
				global::랾.럦.랾(8f);
				global::랾.럦.랉();
				ImGui.BeginChild("##WorldCleanerWindowBody", new Vector2(0f, -ImGui.GetFrameHeightWithSpacing() - 8f), 0);
				try
				{
					bool flag4 = global::랾.럦.랱();
					if (ImGui.Checkbox("Enable World Cleaner", ref flag4))
					{
						global::랾.럦.람(flag4);
					}
					ImGui.SameLine();
					if (ImGui.Button(global::랾.럧.럸 ? "Stop" : "Start Now"))
					{
						if (global::랾.럧.럸)
						{
							global::랾.럦.람(false);
						}
						else
						{
							global::랾.럦.럙();
						}
					}
					ImGui.SameLine();
					if (ImGui.Button("Refresh Preview"))
					{
						global::랾.랆.랜();
					}
					ImGui.SameLine();
					if (ImGui.Button("Reset Session"))
					{
						global::랾.랆.럐(true);
						global::랾.럽.럒("World Cleaner session reset.", true);
					}
					ImGui.TextColored(new Vector4(0.45f, 0.85f, 1f, 1f), "Status: " + global::랾.랆.랍());
					ImGui.TextWrapped("World Cleaner uses pathfinding to teleport, clears every reachable foreground block first, then any backgrounds that is exposed. It skips spawn tiles, locks, and any storage block so the storage stays untouched.");
					ImGui.Separator();
					if (ImGui.BeginTabBar("##WorldCleanerTabs"))
					{
						try
						{
							if (ImGui.BeginTabItem("Overview"))
							{
								try
								{
									global::랾.럦.랠();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Safety"))
							{
								try
								{
									global::랾.럦.럏();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
						}
						finally
						{
							ImGui.EndTabBar();
						}
					}
				}
				finally
				{
					ImGui.EndChild();
				}
				if (ImGui.Button("Close"))
				{
					global::랾.럦.럼 = false;
				}
			}
			finally
			{
				global::랾.럦.럼("World Cleaner Control Center");
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("World Cleaner Control Center");
				}
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00089094 File Offset: 0x00087294
		private static void 랠()
		{
			if (ImGui.BeginTable("##WorldCleanerOverviewGrid", 2, 33280))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Session");
					ImGui.Text("Elapsed: " + global::랾.랆.랾(global::랾.랆.럤()));
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Cleared Blocks: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.랿());
					ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Cleared Backgrounds: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.랆.럥());
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
					ImGui.Text("Remaining ETA: " + global::랾.랆.랾(global::랾.랆.럋()));
					ImGui.TableNextColumn();
					global::랾.럦.랾("Runtime");
					ImGui.Text("World: " + global::랾.랆.런());
					ImGui.Text("Phase: " + global::랾.랆.럞());
					ImGui.Text("Target: " + global::랾.랆.랔());
					ImGui.Text("Status: " + global::랾.랆.랍());
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			ImGui.Spacing();
			global::랾.럦.랾("Preview");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler3.AppendLiteral("Blocks Left: ");
			defaultInterpolatedStringHandler3.AppendFormatted<int>(global::랾.랆.랷());
			ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler4.AppendLiteral("Backgrounds Left: ");
			defaultInterpolatedStringHandler4.AppendFormatted<int>(global::랾.랆.랤());
			ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler5.AppendLiteral("Total Actions Left: ");
			defaultInterpolatedStringHandler5.AppendFormatted<int>(global::랾.랆.랏());
			ImGui.Text(defaultInterpolatedStringHandler5.ToStringAndClear());
			ImGui.Text("Estimated Total Time: " + global::랾.랆.랾(global::랾.랆.랒()));
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0008927C File Offset: 0x0008747C
		private static void 럏()
		{
			global::랾.럦.랾("Clear Order");
			ImGui.TextWrapped("Foreground blocks are always removed before any background tiles. Once the block count reaches zero, the cleaner switches over to backgrounds for the same world.");
			ImGui.Spacing();
			global::랾.럦.랾("Skipped Tiles");
			ImGui.TextWrapped("Spawn tiles are protected. Any block where ConfigData.IsBlockLock is true is protected. Any storage block where ConfigData.IsBlockStorage is true is protected too, so safes and chest-like storage stay untouched.");
			ImGui.Spacing();
			global::랾.럦.랾("Timing");
			ImGui.TextWrapped("The ETA uses an average of 0.30 seconds per action. Foreground hits and background hits both use the same estimate.");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Average Time Per Tile: ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.랆.럪(), "F2");
			defaultInterpolatedStringHandler.AppendLiteral("s");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.Spacing();
			global::랾.럦.랾("Current Preview");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("Preview Blocks: ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.랆.랷());
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler3.AppendLiteral("Preview Backgrounds: ");
			defaultInterpolatedStringHandler3.AppendFormatted<int>(global::랾.랆.랤());
			ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
			ImGui.Text("Preview ETA: " + global::랾.랆.랾(global::랾.랆.랒()));
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00089394 File Offset: 0x00087594
		private static void 럫()
		{
			bool flag = global::랾.럽.랾() && global::랾.럓.랾 != null && string.Equals(global::랾.럓.랾.worldName, "NETHERWORLD", StringComparison.OrdinalIgnoreCase);
			string str = (global::랾.럽.랾() && global::랾.럓.랾 != null) ? global::랾.럓.랾.worldName : "Not in a world";
			if (ImGui.BeginTable("##AutoNetherOverviewGrid", 2, 33280))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Entry");
					ImGui.Text("Current World: " + str);
					ImGui.Text("Entry Method: " + global::랾.랆.랈());
					ImGui.Text("Nether Level: " + global::랾.럦.랾[Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.럦.랾.Length - 1)]);
					ImGui.Text("Source: " + global::랾.랆.랎());
					ImGui.Text("In Nether: " + (flag ? "Yes" : "No"));
					ImGui.TableNextColumn();
					global::랾.럦.랾("Behavior");
					ImGui.Text("Enemies: " + (global::랾.럧.럣 ? "On" : "Off"));
					ImGui.Text("Treasure Chests: " + (ConfigFile.autoNetherTargetTreasure ? "On" : "Off"));
					ImGui.Text("Gift Boxes: " + (ConfigFile.autoNetherTargetGiftBoxes ? "On" : "Off"));
					ImGui.Text("Nether Keys: Always collected");
					ImGui.TextWrapped("Exit: Leaves after the key is gone and there are no enabled reachable targets left.");
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			if (ConfigFile.autoNetherEntryMode == 1)
			{
				global::랾.럦.랾("Red Portal");
				ImGui.Text("Selected Portal: " + global::랾.랆.럹());
				ImGui.TextWrapped(global::랾.랆.럿());
				return;
			}
			global::랾.럦.랾("Scroll");
			ImGui.Text("Selected Scroll: " + global::랾.럦.랾[Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.럦.랾.Length - 1)]);
			ImGui.TextWrapped("Auto Nether will use the matching red scroll from your inventory and confirm the Nether popup for you.");
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000895A8 File Offset: 0x000877A8
		private static void 럴()
		{
			global::랾.럦.랾("Nether Level");
			ImGui.TextWrapped("This is the Nether tier Auto Nether will try to enter.");
			int num = Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.럦.랾.Length - 1);
			if (ImGui.BeginCombo("##AutoNetherLevel", global::랾.럦.랾[num]))
			{
				for (int i = 0; i < global::랾.럦.랾.Length; i++)
				{
					bool flag = num == i;
					if (ImGui.Selectable(global::랾.럦.랾[i], flag))
					{
						ConfigFile.autoNetherScrollLevel = i;
					}
					if (flag)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
			ImGui.Spacing();
			global::랾.럦.랾("Entry Method");
			ImGui.TextWrapped("Choose whether Auto Nether should spend a scroll or use a saved red portal.");
			int num2 = Math.Clamp(ConfigFile.autoNetherEntryMode, 0, global::랾.럦.럎.Length - 1);
			if (ImGui.BeginCombo("##AutoNetherEntryMode", global::랾.럦.럎[num2]))
			{
				for (int j = 0; j < global::랾.럦.럎.Length; j++)
				{
					bool flag2 = num2 == j;
					if (ImGui.Selectable(global::랾.럦.럎[j], flag2))
					{
						ConfigFile.autoNetherEntryMode = j;
					}
					if (flag2)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
			ImGui.Spacing();
			global::랾.럦.랾("Abandon Other Players");
			ImGui.TextWrapped("Choose whether Auto Nether should leave the world if other players are entering the Nether.");
			ImGui.Checkbox("Abandon Other Players", ref ConfigFile.abandonNetherPlayersToggle);
			ImGui.Spacing();
			if (ConfigFile.autoNetherEntryMode == 1)
			{
				global::랾.럦.랾("Selected Portal");
				ImGui.Text("Saved Portal: " + global::랾.랆.럹());
				bool flag3 = global::랾.럽.랾() && global::랾.럓.랾 != null;
				if (ImGui.Button(global::랾.랆.랩() ? "Cancel Portal Picking" : "Pick Portal In World") && flag3)
				{
					global::랾.랆.랉(!global::랾.랆.랩());
				}
				ImGui.SameLine();
				if (ImGui.Button("Use Portal Under Player"))
				{
					if (global::랾.랆.램())
					{
						global::랾.럽.럒("Auto Nether portal set to " + global::랾.랆.럹() + ".", true);
					}
					else
					{
						global::랾.럽.럎("Stand on a red portal first.", false);
					}
				}
				ImGui.SameLine();
				if (ImGui.Button("Clear Selected Portal"))
				{
					global::랾.랆.랥();
					global::랾.럽.럒("Auto Nether red portal cleared.", true);
				}
				if (global::랾.랆.랩())
				{
					ImGui.TextWrapped("Portal picking is on. Left-click a red portal tile in the world to save it. Right-click cancels.");
				}
				else if (!flag3)
				{
					ImGui.TextWrapped("Join the world that has the red portal first if you want to pick it from the world view.");
				}
				ImGui.TextWrapped(global::랾.랆.럿());
				return;
			}
			global::랾.럦.랾("Scroll Entry");
			ImGui.TextWrapped("Auto Nether will use the matching red scroll from your inventory and confirm the Nether popup automatically.");
			ImGui.TextWrapped("Current selection: " + global::랾.럦.랾[Math.Clamp(ConfigFile.autoNetherScrollLevel, 0, global::랾.럦.랾.Length - 1)]);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00089810 File Offset: 0x00087A10
		private static void 럲()
		{
			global::랾.럦.랾("Routing");
			bool 럣 = global::랾.럧.럣;
			if (ImGui.Checkbox("Target Enemies##AutoNetherTargets", ref 럣))
			{
				global::랾.럧.럣 = 럣;
			}
			ImGui.TextWrapped("When this is on, Netherbot teleports to reachable enemies and clears them.");
			bool autoNetherTargetTreasure = ConfigFile.autoNetherTargetTreasure;
			if (ImGui.Checkbox("Target Treasure Chests##AutoNetherTargets", ref autoNetherTargetTreasure))
			{
				ConfigFile.autoNetherTargetTreasure = autoNetherTargetTreasure;
			}
			ImGui.TextWrapped("When this is on, Netherbot also goes to reachable Nether treasure chests.");
			bool autoNetherTargetGiftBoxes = ConfigFile.autoNetherTargetGiftBoxes;
			if (ImGui.Checkbox("Target Gift Boxes##AutoNetherTargets", ref autoNetherTargetGiftBoxes))
			{
				ConfigFile.autoNetherTargetGiftBoxes = autoNetherTargetGiftBoxes;
			}
			ImGui.TextWrapped("When this is on, Netherbot goes to gift boxes that still have an item for you and collects them.");
			global::랾.럦.랾("Always On");
			ImGui.TextWrapped("Nether keys are always collected. After the key is gone, Netherbot keeps clearing enabled reachable targets first, then heads to the exit.");
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000898A8 File Offset: 0x00087AA8
		private static void 럩()
		{
			global::랾.럦.랾("Run Start");
			ImGui.TextWrapped("This controls how long Netherbot waits before it starts a new run while you are outside Nether.");
			ImGui.SliderFloat("Entry Delay##AutoNether", ref ConfigFile.autoNetherEntryDelaySeconds, 0.5f, 15f, "%.2fs");
			ImGui.TextDisabled("Used before it spends a scroll, or before it starts working through the selected red portal.");
			global::랾.럦.랾("Inside Nether");
			ImGui.TextWrapped("This controls how quickly Netherbot moves from one Nether target to the next.");
			ImGui.SliderFloat("Teleport Delay##AutoNether", ref ConfigFile.autoNetherTeleportDelaySeconds, 0.25f, 15f, "%.2fs");
			ImGui.TextDisabled("Lower values make it move more often. Higher values make it wait longer between teleports.");
			global::랾.럦.랾("Red Portal Steps");
			ImGui.TextWrapped("This only matters when Entry Method is set to Selected Red Portal.");
			ImGui.SliderFloat("Portal Step Delay##AutoNether", ref ConfigFile.autoNetherPortalStepDelaySeconds, 0.05f, 3f, "%.2fs");
			ImGui.TextDisabled("Used between moving to the portal, activating it, confirming the popup, and entering it.");
			if (ImGui.Button("Reset Timing to Defaults"))
			{
				ConfigFile.autoNetherEntryDelaySeconds = 5f;
				ConfigFile.autoNetherTeleportDelaySeconds = 6f;
				ConfigFile.autoNetherPortalStepDelaySeconds = 0.35f;
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00089998 File Offset: 0x00087B98
		private static void 랦()
		{
			bool flag = ConfigFile.showMenu && global::랾.럦.랾;
			if (!global::랾.럦.랾("AutoFarm Control Center", flag))
			{
				return;
			}
			ImGui.SetNextWindowSize(new Vector2(790f, 610f), 4);
			ImGui.SetNextWindowSizeConstraints(new Vector2(600f, 450f), new Vector2(float.MaxValue, float.MaxValue));
			bool flag2 = global::랾.럦.랾;
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!flag)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag3 = global::랾.럦.럎("AutoFarm Control Center", flag);
			if (!ImGui.Begin("AutoFarm Control Center", ref flag2, imGuiWindowFlags))
			{
				if (flag)
				{
					global::랾.럦.랾 = flag2;
				}
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("AutoFarm Control Center");
				}
				return;
			}
			try
			{
				if (flag)
				{
					global::랾.럦.랾 = flag2;
				}
				global::랾.럦.랾(8f);
				global::랾.럦.랉();
				ImGui.BeginChild("##AutoFarmerWindowBody", new Vector2(0f, -ImGui.GetFrameHeightWithSpacing() - 8f), 0);
				try
				{
					bool 럆 = global::랾.럧.럆;
					if (ImGui.Checkbox("Enable Auto Farm", ref 럆))
					{
						global::랾.럦.랾(럆);
					}
					ImGui.SameLine();
					if (ImGui.Button("Reset State"))
					{
						global::랾.랐.랓();
						global::랾.럽.럒("Auto Farm runtime reset.", true);
					}
					ImGui.TextColored(new Vector4(0.45f, 0.85f, 1f, 1f), "Status: " + global::랾.랐.럯());
					ImGui.TextWrapped("Auto Farm uses the tile under your player as the anchor. It can refill farm blocks from one storage, dump seeds and extra blocks into another storage, and keep using your chosen block order while it runs.");
					ImGui.Separator();
					if (ImGui.BeginTabBar("##AutoFarmerTabs"))
					{
						try
						{
							if (ImGui.BeginTabItem("Overview"))
							{
								try
								{
									global::랾.럦.럔();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Storage"))
							{
								try
								{
									global::랾.럦.랞();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Pattern"))
							{
								try
								{
									global::랾.럦.럚();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
							if (ImGui.BeginTabItem("Timing"))
							{
								try
								{
									global::랾.럦.럳();
								}
								finally
								{
									ImGui.EndTabItem();
								}
							}
						}
						finally
						{
							ImGui.EndTabBar();
						}
					}
				}
				finally
				{
					ImGui.EndChild();
				}
				if (ImGui.Button("Close"))
				{
					global::랾.럦.랾 = false;
				}
			}
			finally
			{
				global::랾.럦.럼("AutoFarm Control Center");
				ImGui.End();
				if (flag3)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !flag2)
				{
					global::랾.럦.람("AutoFarm Control Center");
				}
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00089C70 File Offset: 0x00087E70
		private static void 럔()
		{
			if (global::랾.럦.랾("##AutoFarmerOverviewGrid", 2))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Session");
					ImGui.Text("Time: " + global::랾.럦.럎(global::랾.랐.랋()));
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Blocks Placed: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랐.랾());
					ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Blocks Broken: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.랐.럎());
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("Drops Collected: ");
					defaultInterpolatedStringHandler3.AppendFormatted<int>(global::랾.랐.람());
					ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler4.AppendLiteral("Refill Trips: ");
					defaultInterpolatedStringHandler4.AppendFormatted<int>(global::랾.랐.럒());
					ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler5.AppendLiteral("Output Trips: ");
					defaultInterpolatedStringHandler5.AppendFormatted<int>(global::랾.랐.럼());
					ImGui.Text(defaultInterpolatedStringHandler5.ToStringAndClear());
					ImGui.TableNextColumn();
					global::랾.럦.랾("Runtime");
					ImGui.Text("Status: " + global::랾.랐.럯());
					ImGui.Text("Current Target: " + global::랾.랐.랱());
					ImGui.Text("Anchor: " + global::랾.랐.럙());
					ImGui.Text("Active Block: " + global::랾.랐.랫());
					ImGui.Text("Manual Block: " + global::랾.랐.럍());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler6.AppendLiteral("Farm Spots: ");
					defaultInterpolatedStringHandler6.AppendFormatted<int>(global::랾.랐.럔());
					ImGui.Text(defaultInterpolatedStringHandler6.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler7.AppendLiteral("Inventory Slots: ");
					defaultInterpolatedStringHandler7.AppendFormatted<int>(global::랾.랐.랬());
					ImGui.Text(defaultInterpolatedStringHandler7.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler8 = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler8.AppendLiteral("Seed Slots: ");
					defaultInterpolatedStringHandler8.AppendFormatted<int>(global::랾.랐.란());
					ImGui.Text(defaultInterpolatedStringHandler8.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler9 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler9.AppendLiteral("Output Slots: ");
					defaultInterpolatedStringHandler9.AppendFormatted<int>(global::랾.랐.럇());
					ImGui.Text(defaultInterpolatedStringHandler9.ToStringAndClear());
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			global::랾.럦.랾("Storage");
			ImGui.Text("Refill Storage: " + global::랾.랐.럏());
			ImGui.Text("Output Storage: " + global::랾.랐.럫());
			ImGui.Text("Refill Storage Enabled: " + (ConfigFile.autoFarmerUseRefillStorage ? "Yes" : "No"));
			ImGui.Text("Output Storage Enabled: " + (ConfigFile.autoFarmerUseOutputStorage ? "Yes" : "No"));
			ImGui.TextWrapped("When Auto Farm starts, it saves the tile under your player as the anchor. If a storage is saved in another world, the location still stays saved, but you need to join that world to preview or change the live contents.");
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00089F68 File Offset: 0x00088168
		private static void 랞()
		{
			global::랾.럦.랾("Refill Storage");
			ImGui.Checkbox("Use Refill Storage", ref ConfigFile.autoFarmerUseRefillStorage);
			ImGui.Text("Selected: " + global::랾.랐.럏());
			if (global::랾.랐.럴())
			{
				ImGui.Text(global::랾.랐.럩() ? "Current World: This refill storage is in the world you are in now." : "Current World: Join the saved refill-storage world to view its live contents.");
			}
			global::랾.럦.럼(true);
			ConfigFile.autoFarmerRefillWhenBlockCountAtOrBelow = Math.Clamp(ConfigFile.autoFarmerRefillWhenBlockCountAtOrBelow, 1, 900);
			ImGui.SliderInt("Refill When Count Is At Or Below##AutoFarmer", ref ConfigFile.autoFarmerRefillWhenBlockCountAtOrBelow, 1, 900, "%d");
			ImGui.TextDisabled("When the current farm block reaches this count or lower, Auto Farm heads to the refill storage.");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(114, 1);
			defaultInterpolatedStringHandler.AppendLiteral("When it refills, Auto Farm takes as many of the active farm block as it can without going past ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(900);
			defaultInterpolatedStringHandler.AppendLiteral(" in your inventory.");
			ImGui.TextDisabled(defaultInterpolatedStringHandler.ToStringAndClear());
			global::랾.럦.랢();
			global::랾.럦.랾("Output Storage");
			ImGui.Checkbox("Use Output Storage", ref ConfigFile.autoFarmerUseOutputStorage);
			ImGui.Text("Selected: " + global::랾.랐.럫());
			if (global::랾.랐.럲())
			{
				ImGui.Text(global::랾.랐.랦() ? "Current World: This output storage is in the world you are in now." : "Current World: Join the saved output-storage world to update that container.");
			}
			global::랾.럦.럼(false);
			ConfigFile.autoFarmerDumpWhenInventorySlotsAtOrAbove = Math.Clamp(ConfigFile.autoFarmerDumpWhenInventorySlotsAtOrAbove, 1, 200);
			ConfigFile.autoFarmerKeepBlockCountDuringDump = Math.Clamp(ConfigFile.autoFarmerKeepBlockCountDuringDump, 0, 900);
			ImGui.SliderInt("Dump When Slots Reach##AutoFarmer", ref ConfigFile.autoFarmerDumpWhenInventorySlotsAtOrAbove, 1, 200, "%d");
			ImGui.TextDisabled("When your inventory gets this full, Auto Farm goes to the output storage.");
			ImGui.SliderInt("Keep This Many Current Farm Blocks##AutoFarmer", ref ConfigFile.autoFarmerKeepBlockCountDuringDump, 0, 900, "%d");
			if (ConfigFile.autoFarmerKeepBlockCountDuringDump > 900)
			{
				ConfigFile.autoFarmerKeepBlockCountDuringDump = 900;
			}
			ImGui.TextDisabled("Seeds are always stored. This only protects some of the active farm block from being dumped.");
			ImGui.TextWrapped("Output includes all seeds plus extra copies of the managed farm blocks. Managed blocks come from your selected refill list, the manual block choice, and whatever block Auto Farm is actively placing.");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0008A128 File Offset: 0x00088328
		private static void 럚()
		{
			global::랾.럦.랾("Manual Farm Block");
			ImGui.TextWrapped("This is the block Auto Farm falls back to when its refill priority list does not pick something else.");
			ImGui.InputText("Search Blocks##AutoFarmer", ref global::랾.럦.랉, 128U);
			IReadOnlyList<랐.랾> readOnlyList = global::랾.랐.럚();
			string text = global::랾.랐.럍();
			if (ImGui.BeginCombo("##AutoFarmerBlockSelection", text))
			{
				string text2 = global::랾.럦.랉;
				string value = ((text2 != null) ? text2.Trim() : null) ?? string.Empty;
				bool flag = false;
				for (int i = 0; i < readOnlyList.Count; i++)
				{
					랐.랾 랾 = readOnlyList[i];
					string text3 = global::랾.랐.랾(랾.랾());
					if (string.IsNullOrWhiteSpace(value) || text3.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0 || 랾.랾().ToString().IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
					{
						flag = true;
						bool flag2 = ConfigFile.autoFarmerSelectedBlockType == 랾.랾();
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
						defaultInterpolatedStringHandler.AppendFormatted(text3);
						defaultInterpolatedStringHandler.AppendLiteral(" | Inventory ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(랾.럎());
						string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (랾.람() > 0)
						{
							string str = text4;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(18, 1);
							defaultInterpolatedStringHandler2.AppendLiteral(" | Refill Storage ");
							defaultInterpolatedStringHandler2.AppendFormatted<int>(랾.람());
							text4 = str + defaultInterpolatedStringHandler2.ToStringAndClear();
						}
						if (ImGui.Selectable(text4, flag2))
						{
							ConfigFile.autoFarmerSelectedBlockType = 랾.랾();
						}
						if (flag2)
						{
							ImGui.SetItemDefaultFocus();
						}
					}
				}
				if (!flag)
				{
					ImGui.TextDisabled("No blocks match the current search.");
				}
				ImGui.EndCombo();
			}
			if (readOnlyList.Count == 0)
			{
				ImGui.TextColored(new Vector4(1f, 0.75f, 0.35f, 1f), "No refill blocks or placeable blocks were found in your inventory yet.");
			}
			else
			{
				ImGui.TextDisabled("Inventory order is shown first. If the refill storage is in this world, its block counts are shown too.");
			}
			global::랾.럦.랾("Farm Pattern");
			ImGui.TextWrapped("These switches decide which tiles around your anchor Auto Farm will clear, place, and break.");
			ImGui.Checkbox("Farm Above", ref ConfigFile.autoFarmerFarmAbove);
			ImGui.SameLine();
			ImGui.Checkbox("Farm Below", ref ConfigFile.autoFarmerFarmBelow);
			ImGui.Checkbox("Farm Left", ref ConfigFile.autoFarmerFarmLeft);
			ImGui.SameLine();
			ImGui.Checkbox("Farm Right", ref ConfigFile.autoFarmerFarmRight);
			ImGui.Checkbox("Use Diagonal Spots", ref ConfigFile.autoFarmerFarmDiagonals);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler3.AppendLiteral("Preview Spot Count: ");
			defaultInterpolatedStringHandler3.AppendFormatted<int>(global::랾.랐.럔());
			ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
			ImGui.TextWrapped("The tile directly under your feet stays free. Reset the state after moving if you want a new anchor tile.");
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0008A398 File Offset: 0x00088598
		private static void 럳()
		{
			global::랾.럦.랾("Farming Loop");
			ImGui.TextWrapped("These timings control how fast Auto Farm breaks and places blocks.");
			ImGui.SliderFloat("Hit Interval##AutoFarmer", ref ConfigFile.autoFarmerHitInterval, 0.1f, 3f, "%.2fs");
			ImGui.TextDisabled("Used while it clears old blocks and breaks the current farm block.");
			ImGui.SliderFloat("Place Delay##AutoFarmer", ref ConfigFile.autoFarmerPlaceDelay, 0.05f, 3f, "%.2fs");
			ImGui.TextDisabled("Used between place attempts while the farm pattern is being filled.");
			global::랾.럦.랾("Collecting and Storage");
			ImGui.SliderInt("Rounds Before Collect##AutoFarmer", ref ConfigFile.autoFarmerRoundsBeforeCollect, 1, 50, "%d");
			ImGui.TextDisabled("After this many full break cycles, Auto Farm pauses to gather drops even if the farm tiles are not clogged yet.");
			ImGui.SliderFloat("Storage Step Delay##AutoFarmer", ref ConfigFile.autoFarmerStorageTransferDelay, 0.05f, 3f, "%.2fs");
			ImGui.TextDisabled("Used between moving items into or out of the selected storage units.");
			if (ImGui.Button("Reset Timing to Defaults##AutoFarmer"))
			{
				ConfigFile.autoFarmerHitInterval = 0.8f;
				ConfigFile.autoFarmerPlaceDelay = 0.3f;
				ConfigFile.autoFarmerStorageTransferDelay = 0.35f;
				ConfigFile.autoFarmerRoundsBeforeCollect = 10;
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0008A494 File Offset: 0x00088694
		private static void 럼(bool A_0)
		{
			bool flag = global::랾.럽.랾() && global::랾.럓.랾 != null;
			bool flag2 = A_0 ? global::랾.랐.랯() : global::랾.랐.러();
			string str = flag2 ? (A_0 ? "Cancel Refill Storage Picking" : "Cancel Output Storage Picking") : (A_0 ? "Pick Refill Storage In World" : "Pick Output Storage In World");
			if (!flag)
			{
				ImGui.BeginDisabled();
			}
			if (ImGui.Button(str + "##" + (A_0 ? "Refill" : "Output")))
			{
				if (A_0)
				{
					global::랾.랐.랾(!global::랾.랐.랯());
				}
				else
				{
					global::랾.랐.럎(!global::랾.랐.러());
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Use Nearby Storage##" + (A_0 ? "Refill" : "Output")))
			{
				if (A_0 ? global::랾.랐.량() : global::랾.랐.럑())
				{
					global::랾.럽.럒(A_0 ? ("Auto Farm refill storage set to " + global::랾.랐.럏() + ".") : ("Auto Farm output storage set to " + global::랾.랐.럫() + "."), true);
				}
				else
				{
					global::랾.럽.럎("Stand next to a storage block first.", false);
				}
			}
			if (!flag)
			{
				ImGui.EndDisabled();
			}
			ImGui.SameLine();
			if (ImGui.Button("Clear Saved Storage##" + (A_0 ? "Refill" : "Output")))
			{
				if (A_0)
				{
					global::랾.랐.럊();
					global::랾.럽.럒("Auto Farm refill storage cleared.", true);
				}
				else
				{
					global::랾.랐.랠();
					global::랾.럽.럒("Auto Farm output storage cleared.", true);
				}
			}
			if (flag2)
			{
				ImGui.TextWrapped(A_0 ? "Storage picking is on. Left-click a storage block in the world to save it. Right-click cancels." : "Output storage picking is on. Left-click a storage block in the world to save it. Right-click cancels.");
				return;
			}
			if (!flag)
			{
				ImGui.TextWrapped("Join the world that has the storage first if you want to pick it straight from the world view.");
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0008A61C File Offset: 0x0008881C
		private static void 랢()
		{
			global::랾.럦.랾("Refill Block Selection");
			ImGui.TextWrapped("Tick the blocks Auto Farm is allowed to pull from the refill storage. The order list below decides which block it tries first.");
			IReadOnlyList<랐.럎> readOnlyList = global::랾.랐.럳();
			if (readOnlyList.Count == 0)
			{
				ImGui.TextWrapped("No refill blocks are visible right now. Save a refill storage in this world or join the refill-storage world to preview its contents.");
				return;
			}
			ImGui.BeginChild("##AutoFarmerRefillOptions", new Vector2(0f, 170f), 1);
			try
			{
				for (int i = 0; i < readOnlyList.Count; i++)
				{
					랐.럎 럎 = readOnlyList[i];
					bool flag = 럎.럒();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("AutoFarmerRefillBlock_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(럎.랾());
					ImGui.PushID(defaultInterpolatedStringHandler.ToStringAndClear());
					if (ImGui.Checkbox("##Selected", ref flag))
					{
						global::랾.랐.랾(럎.랾(), flag);
					}
					ImGui.SameLine();
					ImGui.Text(global::랾.랐.랾(럎.랾()) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					ImGui.SameLine();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("Storage ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(럎.럎());
					defaultInterpolatedStringHandler2.AppendLiteral(" | Inventory ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(럎.람());
					ImGui.TextDisabled(defaultInterpolatedStringHandler2.ToStringAndClear());
					ImGui.PopID();
				}
			}
			finally
			{
				ImGui.EndChild();
			}
			global::랾.럦.랾("Refill Block Order");
			ImGui.TextWrapped("Drag a selected block up or down to change which one gets used first.");
			List<World.BlockType> list = global::랾.랐.랞().ToList<World.BlockType>();
			if (list.Count == 0)
			{
				ImGui.TextWrapped("Nothing is selected yet. Tick at least one block above to build the refill order.");
				return;
			}
			ImGui.BeginChild("##AutoFarmerRefillPriority", new Vector2(0f, 150f), 1);
			try
			{
				for (int j = 0; j < list.Count; j++)
				{
					World.BlockType blockType = list[j];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler3.AppendFormatted<int>(j + 1);
					defaultInterpolatedStringHandler3.AppendLiteral(". ");
					defaultInterpolatedStringHandler3.AppendFormatted(global::랾.랐.랾(blockType));
					string text = defaultInterpolatedStringHandler3.ToStringAndClear();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(19, 1);
					defaultInterpolatedStringHandler4.AppendLiteral("AutoFarmerPriority_");
					defaultInterpolatedStringHandler4.AppendFormatted<int>(j);
					ImGui.PushID(defaultInterpolatedStringHandler4.ToStringAndClear());
					ImGui.Selectable(text, false);
					if (ImGui.IsItemActive() && !ImGui.IsItemHovered())
					{
						int num = (ImGui.GetMouseDragDelta(0).Y < 0f) ? -1 : 1;
						int num2 = j + num;
						if (num2 >= 0 && num2 < list.Count)
						{
							global::랾.랐.랾(j, num2);
							ImGui.ResetMouseDragDelta();
						}
					}
					ImGui.SameLine();
					ImGui.TextDisabled("Drag");
					ImGui.PopID();
				}
			}
			finally
			{
				ImGui.EndChild();
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0008A8BC File Offset: 0x00088ABC
		private static string 럎(float A_0)
		{
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

		// Token: 0x060004F0 RID: 1264 RVA: 0x0008A9D4 File Offset: 0x00088BD4
		private static void 럻()
		{
			int value = global::랾.럧.럫 + global::랾.럧.럴 + global::랾.럧.럲;
			bool flag = global::랾.랆.러();
			if (ImGui.BeginTable("##AutoFishOverviewGrid", 2, 33280))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Session");
					ImGui.Text("Time: " + global::랾.랆.럔());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Caught: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럫);
					ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Missed: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럧.럴);
					ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("Skipped: ");
					defaultInterpolatedStringHandler3.AppendFormatted<int>(global::랾.럧.럲);
					ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler4.AppendLiteral("Attempts: ");
					defaultInterpolatedStringHandler4.AppendFormatted<int>(value);
					ImGui.Text(defaultInterpolatedStringHandler4.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler5.AppendLiteral("Success Rate: ");
					defaultInterpolatedStringHandler5.AppendFormatted<float>(global::랾.랆.랦(), "F1");
					defaultInterpolatedStringHandler5.AppendLiteral("%");
					ImGui.Text(defaultInterpolatedStringHandler5.ToStringAndClear());
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler6.AppendLiteral("Catch Rate: ");
					defaultInterpolatedStringHandler6.AppendFormatted<float>(global::랾.랆.럩(), "F1");
					defaultInterpolatedStringHandler6.AppendLiteral("/hr");
					ImGui.Text(defaultInterpolatedStringHandler6.ToStringAndClear());
					ImGui.TableNextColumn();
					global::랾.럦.랾("Runtime");
					ImGui.Text("Preview: " + global::랾.랆.럙());
					ImGui.Text("Preview Size: " + global::랾.랆.랫());
					ImGui.Text("Last Catch: " + global::랾.랆.럍());
					ImGui.Text("Last Catch Size: " + global::랾.랆.랬());
					ImGui.Text("Current Lure: " + global::랾.랆.란());
					ImGui.Text("Lure Left: " + global::랾.럦.럎(global::랾.랆.럇()));
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler7.AppendLiteral("Total Lures: ");
					defaultInterpolatedStringHandler7.AppendFormatted<int>(global::랾.랆.랯());
					ImGui.Text(defaultInterpolatedStringHandler7.ToStringAndClear());
					if (flag)
					{
						ImGui.TextColored(new Vector4(1f, 0.45f, 0.45f, 1f), "Inventory Full: Yes");
					}
					else
					{
						ImGui.Text("Inventory Full: No");
					}
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			global::랾.럦.랾("Recovery");
			ImGui.Text("Auto Rejoin World");
			ImGui.InputText("##AutoFishWorldName", ref ConfigFile.autoFishRejoinWorldName, 100U);
			ImGui.Text("Portal ID");
			ImGui.InputText("##AutoFishPortalId", ref ConfigFile.autoFishRejoinEntryPointId, 100U);
			ImGui.Spacing();
			ImGui.Checkbox("Return to saved tile after rejoin", ref ConfigFile.autoFishReturnToSpotAfterRejoin);
			ImGui.TextWrapped("If Fishbot disconnects and joins the world again, it will move back to this tile before it starts fishing.");
			ImGui.Text("Saved Tile: " + global::랾.랆.랠());
			bool flag2 = global::랾.럽.랾() && global::랾.럓.랾 != null;
			if (ImGui.Button(global::랾.랆.럊() ? "Cancel Tile Picking" : "Pick Tile In World") && flag2)
			{
				global::랾.랆.럒(!global::랾.랆.럊());
			}
			ImGui.SameLine();
			if (ImGui.Button("Use Current Tile") && global::랾.랆.럏())
			{
				global::랾.럽.럒("Auto Fish return tile set to " + global::랾.랆.랠() + ".", true);
			}
			ImGui.SameLine();
			if (ImGui.Button("Clear Saved Tile"))
			{
				global::랾.랆.럫();
				global::랾.럽.럒("Auto Fish return tile cleared.", true);
			}
			if (global::랾.랆.럊())
			{
				ImGui.TextWrapped("Tile picking is on. Left-click a tile in the world to save it. Right-click to cancel.");
				return;
			}
			if (!flag2)
			{
				ImGui.TextWrapped("Join the fishing world first if you want to pick a tile from the world view.");
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0008AD98 File Offset: 0x00088F98
		private static void 랖()
		{
			ImGui.TextWrapped("All delay groups are optional.");
			ImGui.TextWrapped("Order: cast -> hook -> reel -> land -> recast.");
			ImGui.TextWrapped("If you want a fixed delay, set the min and max to the same value.");
			global::랾.럦.랾("Recast Delay", ref ConfigFile.autoFishRecastDelayEnabled, ref ConfigFile.autoFishRecastDelayMinSeconds, ref ConfigFile.autoFishRecastDelayMaxSeconds, 0f, 5f, "Used after a fish is finished. Fishbot waits this long before it puts the lure back on and starts the next cast.");
			global::랾.럦.랾("Hook Delay", ref ConfigFile.autoFishHookDelayEnabled, ref ConfigFile.autoFishHookDelayMinSeconds, ref ConfigFile.autoFishHookDelayMaxSeconds, 0f, 1.5f, "Used when the strike prompt appears. Fishbot waits this long before it presses the hook button.");
			global::랾.럦.랾("Land Delay", ref ConfigFile.autoFishLandDelayEnabled, ref ConfigFile.autoFishLandDelayMinSeconds, ref ConfigFile.autoFishLandDelayMaxSeconds, 0f, 1.5f, "Used when the fish is ready to land. Fishbot waits this long before it presses the land button.");
			global::랾.럦.랾("Legit Pause Cycle");
			ImGui.TextWrapped("These only apply when Legitimate Mode is on.");
			ImGui.TextWrapped("Pause Every is how long Fishbot runs before it takes a break. Pause Duration is how long that break lasts.");
			ImGui.SliderFloat("Pause Every Min##AutoFishPauseDelayMin", ref ConfigFile.autoFishLegitPauseDelayMinSeconds, 5f, 120f, "%.1fs");
			ImGui.SliderFloat("Pause Every Max##AutoFishPauseDelayMax", ref ConfigFile.autoFishLegitPauseDelayMaxSeconds, 5f, 120f, "%.1fs");
			global::랾.럦.랾(ref ConfigFile.autoFishLegitPauseDelayMinSeconds, ref ConfigFile.autoFishLegitPauseDelayMaxSeconds, 5f, 120f);
			ImGui.SliderFloat("Pause Duration Min##AutoFishPauseDurationMin", ref ConfigFile.autoFishLegitPauseDurationMinSeconds, 0.5f, 20f, "%.1fs");
			ImGui.SliderFloat("Pause Duration Max##AutoFishPauseDurationMax", ref ConfigFile.autoFishLegitPauseDurationMaxSeconds, 0.5f, 20f, "%.1fs");
			global::랾.럦.랾(ref ConfigFile.autoFishLegitPauseDurationMinSeconds, ref ConfigFile.autoFishLegitPauseDurationMaxSeconds, 0.5f, 20f);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0008AF08 File Offset: 0x00089108
		private static void 럝()
		{
			ImGui.Checkbox("Webhook Notifications (Discord/iPhone/Android)", ref global::랾.럧.럶);
			if (!global::랾.럧.럶)
			{
				ImGui.TextWrapped("Enable this to send notifications after every fish caught.");
				return;
			}
			ImGui.TextWrapped("Endpoint URL");
			ImGui.InputText("##AutoFishWebhookURL", ref ConfigFile.autoFishWebhookLink, 512U);
			ConfigFile.autoFishWebhookFishCount = Math.Clamp(ConfigFile.autoFishWebhookFishCount, 1, 500);
			ImGui.SliderInt("Notify Every X Fish", ref ConfigFile.autoFishWebhookFishCount, 1, 250);
			global::랾.럦.랾("Preview");
			ImGui.BeginChild("##AutoFishWebhookPreview", new Vector2(0f, 170f), 1);
			ImGui.TextWrapped(global::랾.랆.럑());
			ImGui.EndChild();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0008AFB8 File Offset: 0x000891B8
		private static void 랾(string A_0, ref bool A_1, ref float A_2, ref float A_3, float A_4, float A_5, string A_6)
		{
			global::랾.럦.랾(A_0);
			ImGui.Checkbox("Enable " + A_0 + "##" + A_0, ref A_1);
			ImGui.TextWrapped(A_6);
			ImGui.SliderFloat("Minimum Delay##" + A_0, ref A_2, A_4, A_5, "%.2fs");
			ImGui.SliderFloat("Maximum Delay##" + A_0, ref A_3, A_4, A_5, "%.2fs");
			global::랾.럦.랾(ref A_2, ref A_3, A_4, A_5);
			string text;
			if (!A_1)
			{
				text = "Disabled. Fishbot will act as soon as it can.";
			}
			else if (MathF.Abs(A_2 - A_3) >= 0.0001f)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Using a random delay between ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(A_2, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("s and ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(A_3, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("s.");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("Using a fixed ");
				defaultInterpolatedStringHandler2.AppendFormatted<float>(A_2, "F2");
				defaultInterpolatedStringHandler2.AppendLiteral("s delay.");
				text = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			ImGui.TextDisabled(text);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0003EDFC File Offset: 0x0003CFFC
		private static void 랾(ref float A_0, ref float A_1, float A_2, float A_3)
		{
			A_0 = Math.Clamp(A_0, A_2, A_3);
			A_1 = Math.Clamp(A_1, A_2, A_3);
			if (A_1 < A_0)
			{
				A_1 = A_0;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0003EE1E File Offset: 0x0003D01E
		private static string 럎(int A_0)
		{
			if (A_0 < 0)
			{
				return "Unknown";
			}
			return A_0.ToString();
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0008B0DC File Offset: 0x000892DC
		private static void 럽()
		{
			string value = global::랾.랆.랡();
			string text;
			if (!global::랾.럧.랺)
			{
				text = "Open the Minebot window to change key levels, route timing, and see the current route.";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Minebot: ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럧.럳);
				defaultInterpolatedStringHandler.AppendLiteral(" completed | ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(global::랾.랆.랳(), "F1");
				defaultInterpolatedStringHandler.AppendLiteral("/hr");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			ImGui.TextDisabled(text);
			if (!global::랾.럧.랺)
			{
				return;
			}
			ImGui.Text("Target: " + global::랾.랆.랃());
			ImGui.Text("Route: " + global::랾.랆.랛());
			ImGui.Text("World: " + global::랾.랆.랆());
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0003EE31 File Offset: 0x0003D031
		private static void 럜()
		{
			ImGui.Checkbox("Blocks", ref global::랾.럧.랊);
			ImGui.Checkbox("Wearables", ref global::랾.럧.럓);
			ImGui.Checkbox("Weapons", ref global::랾.럧.럟);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0008B1AC File Offset: 0x000893AC
		private static void 럕()
		{
			string[] array = global::랾.랆.럎;
			int value = (array != null) ? array.Length : 0;
			string text = global::랾.랆.럛();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Progress: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.랆.럑);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (!string.IsNullOrWhiteSpace(text))
			{
				ImGui.Text("Current: " + text);
			}
			ImGui.SliderFloat("##decaydelay", ref global::랾.랆.럈, 1f, 10f);
			if (ImGui.Button("Reset Auto Decay Finder"))
			{
				global::랾.랆.럭(true);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0008B254 File Offset: 0x00089454
		private static void 럘()
		{
			ImGui.TextDisabled("Cleaning");
			string text = "Clear World";
			string text2 = "World Cleaner";
			bool flag = global::랾.럦.랱();
			Action<bool> action;
			if ((action = global::랾.럦.럒.럒) == null)
			{
				action = (global::랾.럦.럒.럒 = new Action<bool>(global::랾.럦.람));
			}
			Action action2;
			if ((action2 = global::랾.럦.럒.럼) == null)
			{
				action2 = (global::랾.럦.럒.럼 = new Action(global::랾.럦.량));
			}
			global::랾.럦.랾(text, text2, flag, action, ref global::랾.럦.럼, action2);
			ImGui.Spacing();
			ImGui.TextDisabled("Discovery");
			ImGui.Checkbox("Auto World/Decay Finder", ref global::랾.럧.랐);
			if (global::랾.럧.랐)
			{
				global::랾.럦.럕();
			}
			ImGui.Spacing();
			ImGui.TextDisabled("Placement");
			ImGui.Checkbox("Auto-Place Lock", ref global::랾.럧.랳);
			global::랾.럦.럨();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0008B30C File Offset: 0x0008950C
		private static void 랟()
		{
			bool flag = global::랾.럦.랱();
			if (ImGui.Checkbox("World Clearer", ref flag))
			{
				global::랾.럦.람(flag);
			}
			ImGui.SameLine();
			if (ImGui.SmallButton("Open Cleaner"))
			{
				global::랾.럦.럼 = true;
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0008B34C File Offset: 0x0008954C
		private static void 랺()
		{
			if (!ImGui.BeginTabItem("Customize"))
			{
				return;
			}
			global::랾.럦.람();
			ImGui.TextWrapped("Change the look of the client here. Theme, menu animation, ESP colors, path lines, and notifications are all here.");
			ImGui.Separator();
			if (ImGui.BeginTabBar("##CustomizeTabs"))
			{
				try
				{
					if (ImGui.BeginTabItem("UI Style"))
					{
						try
						{
							global::랾.럦.럈();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("ESP Colors"))
					{
						try
						{
							global::랾.럦.럧();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("Path Lines"))
					{
						try
						{
							global::랾.럦.럓();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("Notifications"))
					{
						try
						{
							global::랾.럦.랊();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("Presets"))
					{
						try
						{
							global::랾.럦.럣();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
				}
				finally
				{
					ImGui.EndTabBar();
				}
			}
			ImGui.EndTabItem();
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0008B460 File Offset: 0x00089660
		private static void 럈()
		{
			global::랾.럦.랾("Theme Preset");
			ImGui.TextWrapped("Pick a base theme first. The settings below let you change it further.");
			global::랾.럦.래();
			ImGui.Spacing();
			global::랾.럦.랾("Quick Looks");
			ImGui.TextWrapped("These presets change the style settings below. They do not change your selected theme.");
			if (ImGui.Button("Classic"))
			{
				global::랾.럦.랾(global::랾.럦.랾.랾);
			}
			ImGui.SameLine();
			if (ImGui.Button("Soft Glass"))
			{
				global::랾.럦.랾(global::랾.럦.랾.럎);
			}
			ImGui.SameLine();
			if (ImGui.Button("Studio"))
			{
				global::랾.럦.랾(global::랾.럦.랾.람);
			}
			ImGui.SameLine();
			if (ImGui.Button("Compact"))
			{
				global::랾.럦.랾(global::랾.럦.랾.럒);
			}
			ImGui.Spacing();
			global::랾.럦.랾("General");
			ImGui.SliderFloat("UI Scale##Customize", ref ConfigFile.uiGlobalScale, 0.85f, 1.4f, "%.2fx");
			ImGui.TextDisabled("Changes the size of the whole UI.");
			ImGui.SliderFloat("Layout Spacing##Customize", ref ConfigFile.uiLayoutSpacingScale, 0.8f, 1.35f, "%.2fx");
			ImGui.TextDisabled("Changes spacing inside tabs.");
			ImGui.SliderFloat("Window Padding##Customize", ref ConfigFile.uiWindowPaddingScale, 0.85f, 1.35f, "%.2fx");
			ImGui.TextDisabled("Changes padding inside windows and panels.");
			ImGui.Checkbox("Use Custom Menu Opacity", ref ConfigFile.uiCustomOpacityEnabled);
			if (ConfigFile.uiCustomOpacityEnabled)
			{
				ImGui.SliderFloat("Menu Opacity##Customize", ref ConfigFile.uiGlobalAlpha, 0.75f, 1f, "%.2f");
				ImGui.TextDisabled("Only changes menu opacity.");
			}
			else
			{
				ImGui.TextDisabled("Opacity override is off. The theme opacity is being used.");
			}
			ImGui.Spacing();
			global::랾.럦.랾("Panels and Tabs");
			ImGui.Checkbox("Use Enhanced Panels", ref ConfigFile.uiEnhancedSurfacesEnabled);
			if (ConfigFile.uiEnhancedSurfacesEnabled)
			{
				ImGui.SliderFloat("Panel Lift##Customize", ref ConfigFile.uiPanelLift, 0f, 0.16f, "%.2f");
				ImGui.SliderFloat("Panel Border Strength##Customize", ref ConfigFile.uiPanelBorderStrength, 0f, 1f, "%.2f");
				ImGui.TextDisabled("Lift makes panels stand out more. Border strength changes how strong the edges look.");
			}
			else
			{
				ImGui.TextDisabled("Enhanced panels are off.");
			}
			ImGui.Checkbox("Use Pill Tabs", ref ConfigFile.uiPillTabsEnabled);
			ImGui.TextDisabled("Makes the top tabs look more like rounded buttons.");
			ImGui.Checkbox("Use Section Accent Lines", ref ConfigFile.uiSectionAccentEnabled);
			if (ConfigFile.uiSectionAccentEnabled)
			{
				ImGui.SliderFloat("Accent Thickness##Customize", ref ConfigFile.uiSectionAccentThickness, 1f, 4f, "%.1f");
				ImGui.SliderFloat("Accent Length##Customize", ref ConfigFile.uiSectionAccentLength, 0.2f, 1f, "%.2f");
			}
			ImGui.Checkbox("Use Window Glow", ref ConfigFile.uiWindowGlowEnabled);
			if (ConfigFile.uiWindowGlowEnabled)
			{
				ImGui.SliderFloat("Glow Strength##Customize", ref ConfigFile.uiWindowGlowStrength, 0.05f, 0.65f, "%.2f");
				ImGui.TextDisabled("Adds a soft glow around floating windows.");
			}
			ImGui.Spacing();
			global::랾.럦.랾("Colors");
			ImGui.Checkbox("Use Custom Accent Color", ref ConfigFile.uiCustomAccentEnabled);
			if (ConfigFile.uiCustomAccentEnabled)
			{
				global::랾.럦.랾("Accent Color##Customize", ref ConfigFile.uiAccentColor, "#D9D1C7FF");
			}
			else
			{
				ImGui.TextDisabled("Accent override is off. The theme accent color is being used.");
			}
			ImGui.Checkbox("Use Custom Window Background", ref ConfigFile.uiCustomBackgroundEnabled);
			if (ConfigFile.uiCustomBackgroundEnabled)
			{
				global::랾.럦.랾("Background Color##Customize", ref ConfigFile.uiBackgroundColor, "#111010F2");
			}
			else
			{
				ImGui.TextDisabled("Background override is off. The theme background colors are being used.");
			}
			ImGui.Spacing();
			global::랾.럦.랾("Corners");
			ImGui.Checkbox("Use Custom Corner Settings", ref ConfigFile.uiCustomShapeEnabled);
			if (ConfigFile.uiCustomShapeEnabled)
			{
				ImGui.SliderFloat("Window Rounding##Customize", ref ConfigFile.uiWindowRounding, 0f, 18f, "%.1f");
				ImGui.SliderFloat("Frame Rounding##Customize", ref ConfigFile.uiFrameRounding, 0f, 18f, "%.1f");
				ImGui.SliderFloat("Child Rounding##Customize", ref ConfigFile.uiChildRounding, 0f, 18f, "%.1f");
				ImGui.SliderFloat("Tab Rounding##Customize", ref ConfigFile.uiTabRounding, 0f, 18f, "%.1f");
			}
			else
			{
				ImGui.TextDisabled("Corner override is off. The theme corner settings are being used.");
			}
			ImGui.Spacing();
			global::랾.럦.랾("Menu Animation");
			ImGui.Checkbox("Enable Menu Open Animation", ref ConfigFile.uiOpenAnimationEnabled);
			ImGui.TextWrapped("Adds a short fade and lift when the menu opens. It no longer resizes the window.");
			if (ConfigFile.uiOpenAnimationEnabled)
			{
				ImGui.SliderFloat("Animation Duration##Customize", ref ConfigFile.uiOpenAnimationDuration, 0.05f, 0.5f, "%.2fs");
				ImGui.SliderFloat("Lift Distance##Customize", ref ConfigFile.uiOpenAnimationOffset, 6f, 36f, "%.0f px");
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0008B894 File Offset: 0x00089A94
		private static void 럧()
		{
			ImGui.TextWrapped("These colors only change how ESP is drawn.");
			ImGui.Spacing();
			if (global::랾.럦.랾("##CustomizeEspColorGrid", 2))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Players and Combat");
					global::랾.럦.랾("Player ESP##Customize", ref ConfigFile.uiEspPlayerColor, "#33FF66FF");
					global::랾.럦.랾("Enemy ESP##Customize", ref ConfigFile.uiEspEnemyColor, "#FF4D4DFF");
					ImGui.Checkbox("Rainbow Staff ESP", ref ConfigFile.uiEspStaffRainbow);
					if (!ConfigFile.uiEspStaffRainbow)
					{
						global::랾.럦.랾("Staff ESP##Customize", ref ConfigFile.uiEspStaffColor, "#FF4DE6FF");
					}
					else
					{
						ImGui.TextDisabled("Staff ESP stays rainbow while this is on.");
					}
					global::랾.럦.랾("Nether Boss##Customize", ref ConfigFile.uiEspNetherBossColor, "#FFE03DFF");
					global::랾.럦.랾("Nether Key##Customize", ref ConfigFile.uiEspNetherKeyColor, "#FFD93DFF");
					global::랾.럦.랾("Nether Exit##Customize", ref ConfigFile.uiEspNetherExitColor, "#FF8C1AFF");
					ImGui.Spacing();
					global::랾.럦.랾("Helpers");
					global::랾.럦.랾("Cross-Breed Helper##Customize", ref ConfigFile.uiEspCrossBreedColor, "#33FF8CFF");
					global::랾.럦.랾("Cross-Breed New Recipe##Customize", ref ConfigFile.uiEspCrossBreedNewColor, "#FFCC33FF");
					ImGui.TableNextColumn();
					global::랾.럦.랾("World and Loot");
					global::랾.럦.랾("Collectable##Customize", ref ConfigFile.uiEspCollectableColor, "#338DFFFF");
					global::랾.럦.랾("Gift Box##Customize", ref ConfigFile.uiEspGiftBoxColor, "#FFD93DFF");
					global::랾.럦.랾("Ore##Customize", ref ConfigFile.uiEspOreColor, "#FFFFFFFF");
					global::랾.럦.랾("Butterfly##Customize", ref ConfigFile.uiEspButterflyColor, "#FFE03DFF");
					global::랾.럦.랾("Event Objects##Customize", ref ConfigFile.uiEspEventColor, "#FF4DE6FF");
					global::랾.럦.랾("Portal (Unlocked)##Customize", ref ConfigFile.uiEspPortalUnlockedColor, "#37D65CFF");
					global::랾.럦.랾("Portal (Locked)##Customize", ref ConfigFile.uiEspPortalLockedColor, "#FF4F4FFF");
					global::랾.럦.랾("Sword In Stone##Customize", ref ConfigFile.uiEspSwordColor, "#101010FF");
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			if (ImGui.Button("Reset ESP Colors"))
			{
				global::랾.럦.랐();
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0008BA88 File Offset: 0x00089C88
		private static void 럓()
		{
			global::랾.럦.랾("Style");
			ImGui.TextWrapped("This only changes how path previews look.");
			ImGui.TextDisabled("Hold down left-alt to see the change in-game and teleport with left-alt + right click to see the live route change too.");
			int num = Math.Clamp(ConfigFile.uiPathLineStyle, 0, global::랾.럦.람.Length - 1);
			if (ImGui.BeginCombo("Path Line Style##Customize", global::랾.럦.람[num]))
			{
				for (int i = 0; i < global::랾.럦.람.Length; i++)
				{
					bool flag = i == num;
					if (ImGui.Selectable(global::랾.럦.람[i], flag))
					{
						ConfigFile.uiPathLineStyle = i;
					}
					if (flag)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
			ImGui.SliderFloat("Thickness Scale##Customize", ref ConfigFile.uiPathLineThicknessScale, 0.5f, 3f, "%.2fx");
			ImGui.TextDisabled("Higher values make the lines thicker.");
			if (ConfigFile.uiPathLineStyle == 3)
			{
				ImGui.SliderFloat("Dash Length##Customize", ref ConfigFile.uiPathDashLength, 8f, 28f, "%.0f");
				ImGui.SliderFloat("Gap Length##Customize", ref ConfigFile.uiPathGapLength, 4f, 18f, "%.0f");
			}
			ImGui.Spacing();
			global::랾.럦.랾("Colors");
			global::랾.럦.랾("Hover Preview##Customize", ref ConfigFile.uiPathHoverColor, "#59D9FFCC");
			global::랾.럦.랾("Teleport Route##Customize", ref ConfigFile.uiPathTeleportColor, "#59D9FFF2");
			global::랾.럦.랾("Mining Route##Customize", ref ConfigFile.uiPathMiningColor, "#FFA629CC");
			global::랾.럦.랾("Walkable Prefix##Customize", ref ConfigFile.uiPathReachableColor, "#33FF73F2");
			global::랾.럦.랾("Break Target##Customize", ref ConfigFile.uiPathBreakTargetColor, "#FF75D7FA");
			if (ConfigFile.uiPathLineStyle == 0)
			{
				ImGui.TextDisabled("Clean is the plain line style.");
			}
			else if (ConfigFile.uiPathLineStyle == 1)
			{
				ImGui.TextDisabled("Soft adds a slight outer glow.");
			}
			else if (ConfigFile.uiPathLineStyle == 2)
			{
				ImGui.TextDisabled("Flow uses a moving trail.");
			}
			else if (ConfigFile.uiPathLineStyle == 3)
			{
				ImGui.TextDisabled("Dashed breaks the line into segments.");
			}
			else if (ConfigFile.uiPathLineStyle == 4)
			{
				ImGui.TextDisabled("Pulse sends bright points along the line.");
			}
			else if (ConfigFile.uiPathLineStyle == 5)
			{
				ImGui.TextDisabled("Ribbon uses a fuller moving line.");
			}
			if (ImGui.Button("Reset Path Preview"))
			{
				global::랾.럦.럆();
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0008BC7C File Offset: 0x00089E7C
		private static void 랊()
		{
			ImGui.TextWrapped("Change how notifications look here. You can adjust the size, text, glow, and colors, then export just the notification style if you want to share it.");
			ImGui.Spacing();
			global::랾.럦.랾("Quick Looks");
			ImGui.TextWrapped("These presets give you a quick starting point.");
			if (ImGui.Button("Modern Slate"))
			{
				global::랾.럦.랾(global::랾.럦.럎.랾);
			}
			ImGui.SameLine();
			if (ImGui.Button("Futuristic Pulse"))
			{
				global::랾.럦.랾(global::랾.럦.럎.럎);
			}
			ImGui.SameLine();
			if (ImGui.Button("Frost Glass"))
			{
				global::랾.럦.랾(global::랾.럦.럎.람);
			}
			ImGui.SameLine();
			if (ImGui.Button("Minimal Dark"))
			{
				global::랾.럦.랾(global::랾.럦.럎.럒);
			}
			ImGui.Spacing();
			if (global::랾.럦.랾("##CustomizeNotificationGrid", 2))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.럟();
					ImGui.Spacing();
					global::랾.럦.럦();
					ImGui.Spacing();
					global::랾.럦.랪();
					ImGui.TableNextColumn();
					global::랾.럦.럷();
					goto IL_E1;
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			global::랾.럦.럟();
			ImGui.Spacing();
			global::랾.럦.럦();
			ImGui.Spacing();
			global::랾.럦.랪();
			ImGui.Spacing();
			global::랾.럦.럷();
			IL_E1:
			ImGui.Spacing();
			global::랾.럦.랾("Preview");
			ImGui.TextWrapped("Use these to see how the current notification style looks.");
			if (ImGui.Button("Run Test Notification"))
			{
				global::랾.랃.랾("Notification Preview", "This is a test notification.", 4f);
			}
			ImGui.TextDisabled("The buttons below let you preview each notification type.");
			if (ImGui.Button("Preview Info"))
			{
				global::랾.랃.랾("Route Updated", "This is an info notification preview.", 4f);
			}
			ImGui.SameLine();
			if (ImGui.Button("Preview Success"))
			{
				global::랾.랃.럎("Automation Complete", "This is a success notification preview.", 4f);
			}
			ImGui.SameLine();
			if (ImGui.Button("Preview Warning"))
			{
				global::랾.랃.람("Storage Running Low", "This is a warning notification preview.", 4f);
			}
			ImGui.SameLine();
			if (ImGui.Button("Preview Error"))
			{
				global::랾.랃.럒("Reconnect Failed", "This is an error notification preview.", 4f);
			}
			ImGui.Spacing();
			global::랾.럦.랾("Sharing");
			ImGui.TextWrapped("Export or import only the notification style here.");
			string text = "Export Notifications To Clipboard";
			string text2 = "Import Notifications From Clipboard";
			Func<ValueTuple<bool, string>> exportAction;
			if ((exportAction = global::랾.럦.럒.랾) == null)
			{
				exportAction = (global::랾.럦.럒.랾 = new Func<ValueTuple<bool, string>>(global::랾.럦.랡));
			}
			Func<string, bool> func;
			if ((func = global::랾.럦.럒.랾) == null)
			{
				func = (global::랾.럦.럒.랾 = new Func<string, bool>(ConfigFile.럯));
			}
			global::랾.럦.랾(text, text2, exportAction, func, "Notification settings copied to your clipboard.", "Notification settings imported.");
			ImGui.SameLine();
			if (ImGui.Button("Reset Notifications"))
			{
				global::랾.럦.랄();
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0008BECC File Offset: 0x0008A0CC
		private static void 럟()
		{
			global::랾.럦.랾("Layout");
			ImGui.SliderFloat("Toast Width##Customize", ref ConfigFile.uiToastWidth, 320f, 760f, "%.0f px");
			ImGui.TextDisabled("How wide each notification is.");
			ImGui.SliderFloat("Minimum Height##Customize", ref ConfigFile.uiToastMinHeight, 72f, 220f, "%.0f px");
			ImGui.TextDisabled("Notifications can grow taller for longer messages, but not smaller than this.");
			ImGui.SliderFloat("Stack Spacing##Customize", ref ConfigFile.uiToastSpacing, 4f, 24f, "%.0f px");
			ImGui.SliderFloat("Right Offset##Customize", ref ConfigFile.uiToastOffsetX, 8f, 72f, "%.0f px");
			ImGui.SliderFloat("Top Offset##Customize", ref ConfigFile.uiToastOffsetY, 8f, 72f, "%.0f px");
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0008BF94 File Offset: 0x0008A194
		private static void 럦()
		{
			global::랾.럦.랾("Typography");
			ImGui.SliderFloat("Title Size##Customize", ref ConfigFile.uiToastTitleScale, 0.85f, 1.45f, "%.2fx");
			ImGui.TextDisabled("Changes the title size.");
			ImGui.SliderFloat("Message Size##Customize", ref ConfigFile.uiToastMessageScale, 0.8f, 1.35f, "%.2fx");
			ImGui.TextDisabled("Changes the message text size.");
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0008C000 File Offset: 0x0008A200
		private static void 랪()
		{
			global::랾.럦.랾("Surface");
			ImGui.SliderFloat("Corner Rounding##Customize", ref ConfigFile.uiToastRounding, 6f, 28f, "%.0f px");
			ImGui.SliderFloat("Border Thickness##Customize", ref ConfigFile.uiToastBorderThickness, 0.6f, 3f, "%.1f");
			ImGui.SliderFloat("Accent Bar Width##Customize", ref ConfigFile.uiToastAccentBarWidth, 3f, 14f, "%.0f px");
			ImGui.SliderFloat("Glow Strength##Customize", ref ConfigFile.uiToastGlowStrength, 0f, 0.8f, "%.2f");
			ImGui.TextDisabled("Glow changes how strong the outer highlight is.");
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0008C0A0 File Offset: 0x0008A2A0
		private static void 럷()
		{
			global::랾.럦.랾("Colors");
			global::랾.럦.랾("Background##Customize", ref ConfigFile.uiToastBackgroundColor, "#121720F2");
			global::랾.럦.랾("Title Text##Customize", ref ConfigFile.uiToastTitleColor, "#F4F7FFFF");
			global::랾.럦.랾("Message Text##Customize", ref ConfigFile.uiToastMessageColor, "#AFC0D9FF");
			global::랾.럦.랾("Info Accent##Customize", ref ConfigFile.uiToastInfoColor, "#66BEFFFF");
			global::랾.럦.랾("Success Accent##Customize", ref ConfigFile.uiToastSuccessColor, "#57E2A5FF");
			global::랾.럦.랾("Warning Accent##Customize", ref ConfigFile.uiToastWarningColor, "#FFC96BFF");
			global::랾.럦.랾("Error Accent##Customize", ref ConfigFile.uiToastErrorColor, "#FF6B8DFF");
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0008C144 File Offset: 0x0008A344
		private static void 럣()
		{
			ImGui.TextWrapped("Share style settings here.");
			ImGui.Spacing();
			global::랾.럦.랾("Full UI Look");
			ImGui.TextWrapped("Includes theme, UI style, ESP colors, path lines, and notifications.");
			string text = "Export Full UI To Clipboard";
			string text2 = "Import Full UI From Clipboard";
			Func<ValueTuple<bool, string>> exportAction;
			if ((exportAction = global::랾.럦.럒.럎) == null)
			{
				exportAction = (global::랾.럦.럒.럎 = new Func<ValueTuple<bool, string>>(global::랾.럦.랅));
			}
			Func<string, bool> func;
			if ((func = global::랾.럦.럒.럎) == null)
			{
				func = (global::랾.럦.럒.럎 = new Func<string, bool>(ConfigFile.랋));
			}
			global::랾.럦.랾(text, text2, exportAction, func, "Full UI settings copied to your clipboard.", "Full UI settings imported.");
			ImGui.Spacing();
			global::랾.럦.랾("ESP Colors Only");
			ImGui.TextWrapped("Use this to share only the ESP colors.");
			string text3 = "Export ESP Colors To Clipboard";
			string text4 = "Import ESP Colors From Clipboard";
			Func<ValueTuple<bool, string>> exportAction2;
			if ((exportAction2 = global::랾.럦.럒.람) == null)
			{
				exportAction2 = (global::랾.럦.럒.람 = new Func<ValueTuple<bool, string>>(global::랾.럦.랁));
			}
			Func<string, bool> func2;
			if ((func2 = global::랾.럦.럒.람) == null)
			{
				func2 = (global::랾.럦.럒.람 = new Func<string, bool>(ConfigFile.럐));
			}
			global::랾.럦.랾(text3, text4, exportAction2, func2, "ESP color settings copied to your clipboard.", "ESP color settings imported.");
			ImGui.SameLine();
			if (ImGui.Button("Reset ESP Colors##PresetTab"))
			{
				global::랾.럦.랐();
			}
			ImGui.Spacing();
			global::랾.럦.랾("Path Lines Only");
			ImGui.TextWrapped("Use this to share only the path line settings.");
			string text5 = "Export Path Lines To Clipboard";
			string text6 = "Import Path Lines From Clipboard";
			Func<ValueTuple<bool, string>> exportAction3;
			if ((exportAction3 = global::랾.럦.럒.럒) == null)
			{
				exportAction3 = (global::랾.럦.럒.럒 = new Func<ValueTuple<bool, string>>(global::랾.럦.랽));
			}
			Func<string, bool> func3;
			if ((func3 = global::랾.럦.럒.럒) == null)
			{
				func3 = (global::랾.럦.럒.럒 = new Func<string, bool>(ConfigFile.랓));
			}
			global::랾.럦.랾(text5, text6, exportAction3, func3, "Path-line settings copied to your clipboard.", "Path-line settings imported.");
			ImGui.SameLine();
			if (ImGui.Button("Reset Path Lines##PresetTab"))
			{
				global::랾.럦.럆();
			}
			ImGui.Spacing();
			global::랾.럦.랾("Notifications Only");
			ImGui.TextWrapped("Use this to share only the notification style.");
			string text7 = "Export Notifications To Clipboard##PresetTab";
			string text8 = "Import Notifications From Clipboard##PresetTab";
			Func<ValueTuple<bool, string>> exportAction4;
			if ((exportAction4 = global::랾.럦.럒.랾) == null)
			{
				exportAction4 = (global::랾.럦.럒.랾 = new Func<ValueTuple<bool, string>>(global::랾.럦.랡));
			}
			Func<string, bool> func4;
			if ((func4 = global::랾.럦.럒.랾) == null)
			{
				func4 = (global::랾.럦.럒.랾 = new Func<string, bool>(ConfigFile.럯));
			}
			global::랾.럦.랾(text7, text8, exportAction4, func4, "Notification settings copied to your clipboard.", "Notification settings imported.");
			ImGui.SameLine();
			if (ImGui.Button("Reset Notifications##PresetTab"))
			{
				global::랾.럦.랄();
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0008C340 File Offset: 0x0008A540
		private static void 랾(string A_0, string A_1, [TupleElementNames(new string[]
		{
			"success",
			"json"
		})] Func<ValueTuple<bool, string>> exportAction, Func<string, bool> A_3, string A_4, string A_5)
		{
			if (ImGui.Button(A_0))
			{
				ValueTuple<bool, string> valueTuple = exportAction();
				bool item = valueTuple.Item1;
				string item2 = valueTuple.Item2;
				if (item)
				{
					ImGui.SetClipboardText(item2);
					global::랾.럽.랾(A_4, false);
				}
				else
				{
					global::랾.럽.람("Failed to " + A_0.ToLowerInvariant() + ".", false);
				}
			}
			ImGui.SameLine();
			if (ImGui.Button(A_1))
			{
				string arg = ImGui.GetClipboardText() ?? string.Empty;
				if (A_3(arg))
				{
					global::랾.럽.랾(A_5, false);
					return;
				}
				global::랾.럽.람("Failed to " + A_1.ToLowerInvariant() + ".", false);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0008C3E0 File Offset: 0x0008A5E0
		[return: TupleElementNames(new string[]
		{
			"success",
			"json"
		})]
		private static ValueTuple<bool, string> 랅()
		{
			string item;
			if (!ConfigFile.랾(out item))
			{
				return new ValueTuple<bool, string>(false, string.Empty);
			}
			return new ValueTuple<bool, string>(true, item);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0008C40C File Offset: 0x0008A60C
		[return: TupleElementNames(new string[]
		{
			"success",
			"json"
		})]
		private static ValueTuple<bool, string> 랁()
		{
			string item;
			if (!ConfigFile.람(out item))
			{
				return new ValueTuple<bool, string>(false, string.Empty);
			}
			return new ValueTuple<bool, string>(true, item);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0008C438 File Offset: 0x0008A638
		[return: TupleElementNames(new string[]
		{
			"success",
			"json"
		})]
		private static ValueTuple<bool, string> 랽()
		{
			string item;
			if (!ConfigFile.럒(out item))
			{
				return new ValueTuple<bool, string>(false, string.Empty);
			}
			return new ValueTuple<bool, string>(true, item);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0008C464 File Offset: 0x0008A664
		[return: TupleElementNames(new string[]
		{
			"success",
			"json"
		})]
		private static ValueTuple<bool, string> 랡()
		{
			string item;
			if (!ConfigFile.럼(out item))
			{
				return new ValueTuple<bool, string>(false, string.Empty);
			}
			return new ValueTuple<bool, string>(true, item);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0003EE63 File Offset: 0x0003D063
		private static void 랾(int A_0, float A_1, string A_2, string A_3, string A_4, string A_5, string A_6)
		{
			ConfigFile.uiPathLineStyle = Math.Clamp(A_0, 0, global::랾.럦.람.Length - 1);
			ConfigFile.uiPathLineThicknessScale = A_1;
			ConfigFile.uiPathHoverColor = A_2;
			ConfigFile.uiPathTeleportColor = A_3;
			ConfigFile.uiPathMiningColor = A_4;
			ConfigFile.uiPathReachableColor = A_5;
			ConfigFile.uiPathBreakTargetColor = A_6;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0008C490 File Offset: 0x0008A690
		private static void 랾(string A_0, ref string A_1, string A_2)
		{
			Color color = global::랾.랽.랾(A_2, Color.white);
			Vector4 vector = global::랾.랽.럎(global::랾.랽.랾(A_1, color));
			if (ImGui.ColorEdit4(A_0, ref vector, 327680))
			{
				A_1 = global::랾.랽.랾(global::랾.랽.랾(vector));
			}
			ImGui.SameLine();
			if (ImGui.SmallButton("Reset##" + A_0))
			{
				A_1 = A_2;
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0008C4F0 File Offset: 0x0008A6F0
		private static void 랾(럦.랾 A_0)
		{
			switch (A_0)
			{
			case global::랾.럦.랾.랾:
				ConfigFile.uiEnhancedSurfacesEnabled = false;
				ConfigFile.uiPanelLift = 0.06f;
				ConfigFile.uiPanelBorderStrength = 0.35f;
				ConfigFile.uiPillTabsEnabled = false;
				ConfigFile.uiSectionAccentEnabled = true;
				ConfigFile.uiSectionAccentThickness = 2f;
				ConfigFile.uiSectionAccentLength = 0.45f;
				ConfigFile.uiLayoutSpacingScale = 1f;
				ConfigFile.uiWindowPaddingScale = 1f;
				ConfigFile.uiWindowGlowEnabled = false;
				ConfigFile.uiWindowGlowStrength = 0.22f;
				ConfigFile.uiCustomShapeEnabled = false;
				return;
			case global::랾.럦.랾.럎:
				ConfigFile.uiEnhancedSurfacesEnabled = true;
				ConfigFile.uiPanelLift = 0.1f;
				ConfigFile.uiPanelBorderStrength = 0.48f;
				ConfigFile.uiPillTabsEnabled = true;
				ConfigFile.uiSectionAccentEnabled = true;
				ConfigFile.uiSectionAccentThickness = 2f;
				ConfigFile.uiSectionAccentLength = 0.52f;
				ConfigFile.uiLayoutSpacingScale = 1.05f;
				ConfigFile.uiWindowPaddingScale = 1.1f;
				ConfigFile.uiWindowGlowEnabled = true;
				ConfigFile.uiWindowGlowStrength = 0.24f;
				ConfigFile.uiCustomShapeEnabled = true;
				ConfigFile.uiWindowRounding = 18f;
				ConfigFile.uiFrameRounding = 12f;
				ConfigFile.uiChildRounding = 16f;
				ConfigFile.uiTabRounding = 16f;
				return;
			case global::랾.럦.랾.람:
				ConfigFile.uiEnhancedSurfacesEnabled = true;
				ConfigFile.uiPanelLift = 0.08f;
				ConfigFile.uiPanelBorderStrength = 0.62f;
				ConfigFile.uiPillTabsEnabled = true;
				ConfigFile.uiSectionAccentEnabled = true;
				ConfigFile.uiSectionAccentThickness = 2.5f;
				ConfigFile.uiSectionAccentLength = 0.38f;
				ConfigFile.uiLayoutSpacingScale = 1.02f;
				ConfigFile.uiWindowPaddingScale = 1.08f;
				ConfigFile.uiWindowGlowEnabled = true;
				ConfigFile.uiWindowGlowStrength = 0.18f;
				ConfigFile.uiCustomShapeEnabled = true;
				ConfigFile.uiWindowRounding = 14f;
				ConfigFile.uiFrameRounding = 10f;
				ConfigFile.uiChildRounding = 14f;
				ConfigFile.uiTabRounding = 14f;
				return;
			case global::랾.럦.랾.럒:
				ConfigFile.uiEnhancedSurfacesEnabled = true;
				ConfigFile.uiPanelLift = 0.05f;
				ConfigFile.uiPanelBorderStrength = 0.28f;
				ConfigFile.uiPillTabsEnabled = false;
				ConfigFile.uiSectionAccentEnabled = true;
				ConfigFile.uiSectionAccentThickness = 1.5f;
				ConfigFile.uiSectionAccentLength = 0.3f;
				ConfigFile.uiLayoutSpacingScale = 0.88f;
				ConfigFile.uiWindowPaddingScale = 0.92f;
				ConfigFile.uiWindowGlowEnabled = false;
				ConfigFile.uiWindowGlowStrength = 0.22f;
				ConfigFile.uiCustomShapeEnabled = true;
				ConfigFile.uiWindowRounding = 8f;
				ConfigFile.uiFrameRounding = 6f;
				ConfigFile.uiChildRounding = 8f;
				ConfigFile.uiTabRounding = 8f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0008C720 File Offset: 0x0008A920
		private static void 랾(럦.럎 A_0)
		{
			switch (A_0)
			{
			case global::랾.럦.럎.랾:
				ConfigFile.uiToastWidth = 430f;
				ConfigFile.uiToastMinHeight = 88f;
				ConfigFile.uiToastSpacing = 10f;
				ConfigFile.uiToastOffsetX = 18f;
				ConfigFile.uiToastOffsetY = 16f;
				ConfigFile.uiToastTitleScale = 1.05f;
				ConfigFile.uiToastMessageScale = 0.93f;
				ConfigFile.uiToastRounding = 16f;
				ConfigFile.uiToastBorderThickness = 1.2f;
				ConfigFile.uiToastAccentBarWidth = 4f;
				ConfigFile.uiToastGlowStrength = 0.24f;
				ConfigFile.uiToastBackgroundColor = "#121720F2";
				ConfigFile.uiToastTitleColor = "#F4F7FFFF";
				ConfigFile.uiToastMessageColor = "#AFC0D9FF";
				ConfigFile.uiToastInfoColor = "#66BEFFFF";
				ConfigFile.uiToastSuccessColor = "#57E2A5FF";
				ConfigFile.uiToastWarningColor = "#FFC96BFF";
				ConfigFile.uiToastErrorColor = "#FF6B8DFF";
				return;
			case global::랾.럦.럎.럎:
				ConfigFile.uiToastWidth = 456f;
				ConfigFile.uiToastMinHeight = 92f;
				ConfigFile.uiToastSpacing = 11f;
				ConfigFile.uiToastOffsetX = 18f;
				ConfigFile.uiToastOffsetY = 16f;
				ConfigFile.uiToastTitleScale = 1.08f;
				ConfigFile.uiToastMessageScale = 0.94f;
				ConfigFile.uiToastRounding = 18f;
				ConfigFile.uiToastBorderThickness = 1.4f;
				ConfigFile.uiToastAccentBarWidth = 5f;
				ConfigFile.uiToastGlowStrength = 0.46f;
				ConfigFile.uiToastBackgroundColor = "#0D1220F4";
				ConfigFile.uiToastTitleColor = "#F6F7FFFF";
				ConfigFile.uiToastMessageColor = "#9FB3D6FF";
				ConfigFile.uiToastInfoColor = "#4ED8FFFF";
				ConfigFile.uiToastSuccessColor = "#42F5B6FF";
				ConfigFile.uiToastWarningColor = "#FFC847FF";
				ConfigFile.uiToastErrorColor = "#FF5FA8FF";
				return;
			case global::랾.럦.럎.람:
				ConfigFile.uiToastWidth = 440f;
				ConfigFile.uiToastMinHeight = 90f;
				ConfigFile.uiToastSpacing = 10f;
				ConfigFile.uiToastOffsetX = 20f;
				ConfigFile.uiToastOffsetY = 18f;
				ConfigFile.uiToastTitleScale = 1.03f;
				ConfigFile.uiToastMessageScale = 0.92f;
				ConfigFile.uiToastRounding = 20f;
				ConfigFile.uiToastBorderThickness = 1f;
				ConfigFile.uiToastAccentBarWidth = 4f;
				ConfigFile.uiToastGlowStrength = 0.2f;
				ConfigFile.uiToastBackgroundColor = "#1A2330E8";
				ConfigFile.uiToastTitleColor = "#F7FAFFFF";
				ConfigFile.uiToastMessageColor = "#C0CBDCFF";
				ConfigFile.uiToastInfoColor = "#8FCAFFFF";
				ConfigFile.uiToastSuccessColor = "#8DE5C2FF";
				ConfigFile.uiToastWarningColor = "#FFD89AFF";
				ConfigFile.uiToastErrorColor = "#FF9CB0FF";
				return;
			case global::랾.럦.럎.럒:
				ConfigFile.uiToastWidth = 400f;
				ConfigFile.uiToastMinHeight = 80f;
				ConfigFile.uiToastSpacing = 8f;
				ConfigFile.uiToastOffsetX = 16f;
				ConfigFile.uiToastOffsetY = 14f;
				ConfigFile.uiToastTitleScale = 1f;
				ConfigFile.uiToastMessageScale = 0.9f;
				ConfigFile.uiToastRounding = 12f;
				ConfigFile.uiToastBorderThickness = 0.9f;
				ConfigFile.uiToastAccentBarWidth = 3f;
				ConfigFile.uiToastGlowStrength = 0.08f;
				ConfigFile.uiToastBackgroundColor = "#111317F5";
				ConfigFile.uiToastTitleColor = "#ECEFF4FF";
				ConfigFile.uiToastMessageColor = "#A9B0BCFF";
				ConfigFile.uiToastInfoColor = "#83B9F8FF";
				ConfigFile.uiToastSuccessColor = "#7ED3A8FF";
				ConfigFile.uiToastWarningColor = "#E8C07DFF";
				ConfigFile.uiToastErrorColor = "#E57E9FFF";
				return;
			default:
				return;
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0008CA18 File Offset: 0x0008AC18
		private unsafe static Vector4 랃()
		{
			if (ConfigFile.uiCustomAccentEnabled)
			{
				return global::랾.랽.럎(global::랾.랽.랾(ConfigFile.uiAccentColor, new Color(0.85f, 0.82f, 0.78f, 1f)));
			}
			RangeAccessor<Vector4> colors = ImGui.GetStyle().Colors;
			Vector4 vector = *colors[18];
			if (vector.W < 0.05f)
			{
				vector = *colors[20];
			}
			if (vector.W < 0.05f)
			{
				vector = *colors[22];
			}
			if (vector.W < 0.05f)
			{
				vector = new Vector4(0.84f, 0.78f, 0.92f, 1f);
			}
			vector.W = Math.Max(vector.W, 1f);
			return vector;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0008CAEC File Offset: 0x0008ACEC
		private unsafe static void 랛()
		{
			*ImGui.GetIO().FontGlobalScale = Math.Clamp(ConfigFile.uiGlobalScale, 0.85f, 1.4f);
			ImGuiStylePtr style = ImGui.GetStyle();
			*style.Alpha = (ConfigFile.uiCustomOpacityEnabled ? Math.Clamp(ConfigFile.uiGlobalAlpha, 0.75f, 1f) : 1f);
			if (ConfigFile.uiCustomShapeEnabled)
			{
				*style.WindowRounding = Math.Clamp(ConfigFile.uiWindowRounding, 0f, 18f);
				*style.FrameRounding = Math.Clamp(ConfigFile.uiFrameRounding, 0f, 18f);
				*style.ChildRounding = Math.Clamp(ConfigFile.uiChildRounding, 0f, 18f);
				*style.TabRounding = Math.Clamp(ConfigFile.uiTabRounding, 0f, 18f);
				*style.GrabRounding = Math.Clamp(ConfigFile.uiFrameRounding, 0f, 18f);
				*style.PopupRounding = Math.Clamp(ConfigFile.uiWindowRounding, 0f, 18f);
			}
			float num = Math.Clamp(ConfigFile.uiLayoutSpacingScale, 0.8f, 1.35f);
			float num2 = Math.Clamp(ConfigFile.uiWindowPaddingScale, 0.85f, 1.35f);
			*style.WindowPadding = new Vector2(style.WindowPadding.X * num2, style.WindowPadding.Y * num2);
			*style.FramePadding = new Vector2(style.FramePadding.X * num, style.FramePadding.Y * num);
			*style.ItemSpacing = new Vector2(style.ItemSpacing.X * num, style.ItemSpacing.Y * num);
			*style.ItemInnerSpacing = new Vector2(style.ItemInnerSpacing.X * num, style.ItemInnerSpacing.Y * num);
			*style.CellPadding = new Vector2(style.CellPadding.X * num, style.CellPadding.Y * num);
			if (ConfigFile.uiPillTabsEnabled)
			{
				*style.TabRounding = Math.Max(*style.TabRounding, 12f);
				*style.FrameRounding = Math.Max(*style.FrameRounding, 10f);
				*style.GrabRounding = Math.Max(*style.GrabRounding, *style.FrameRounding);
				*style.TabBorderSize = Math.Max(*style.TabBorderSize, 1f);
				*style.FramePadding = new Vector2(style.FramePadding.X + 6f, style.FramePadding.Y + 1f);
				*style.ItemSpacing = new Vector2(style.ItemSpacing.X + 2f, style.ItemSpacing.Y + 2f);
			}
			RangeAccessor<Vector4> colors = style.Colors;
			if (ConfigFile.uiCustomAccentEnabled)
			{
				Vector4 vector = global::랾.럦.랃();
				Vector4 vector2 = global::랾.랽.럎(vector, 0.32f);
				Vector4 vector3 = global::랾.랽.럎(vector, 0.65f);
				*colors[18] = vector;
				*colors[19] = vector3;
				*colors[20] = vector;
				*colors[22] = vector3;
				*colors[23] = vector;
				*colors[25] = vector3;
				*colors[26] = vector;
				*colors[28] = vector3;
				*colors[29] = vector;
				*colors[31] = vector3;
				*colors[32] = vector;
				*colors[33] = vector3;
				*colors[52] = vector2;
			}
			if (ConfigFile.uiCustomBackgroundEnabled)
			{
				Vector4 vector4 = global::랾.랽.럎(global::랾.랽.랾(ConfigFile.uiBackgroundColor, new Color(0.07f, 0.06f, 0.06f, 0.95f)));
				Vector4 vector5 = new Vector4(Mathf.Clamp01(vector4.X + 0.02f), Mathf.Clamp01(vector4.Y + 0.02f), Mathf.Clamp01(vector4.Z + 0.02f), vector4.W);
				Vector4 vector6 = new Vector4(Mathf.Clamp01(vector4.X - 0.01f), Mathf.Clamp01(vector4.Y - 0.01f), Mathf.Clamp01(vector4.Z - 0.01f), Mathf.Clamp(vector4.W + 0.04f, 0f, 1f));
				*colors[2] = vector4;
				*colors[3] = vector5;
				*colors[4] = vector6;
				*colors[11] = vector5;
			}
			if (ConfigFile.uiEnhancedSurfacesEnabled || ConfigFile.uiPillTabsEnabled)
			{
				Vector4 vector7 = global::랾.럦.랃();
				Vector4 vector8 = global::랾.랽.럎(vector7, 0.22f);
				Vector4 vector9 = global::랾.랽.럎(vector7, 0.48f);
				Vector4 vector10 = *colors[2];
				Vector4 vector11 = *colors[3];
				Vector4 vector12 = *colors[7];
				Vector4 vector13 = *colors[34];
				if (ConfigFile.uiEnhancedSurfacesEnabled)
				{
					float num3 = Math.Clamp(ConfigFile.uiPanelLift, 0f, 0.16f);
					float num4 = Math.Clamp(ConfigFile.uiPanelBorderStrength, 0f, 1f);
					Vector4 vector14 = global::랾.랽.랾(global::랾.랽.람(vector10, 0.02f + num3), global::랾.랽.람(vector11, num3), 0.55f);
					Vector4 vector15 = global::랾.랽.랾(global::랾.랽.람(vector12, num3 * 0.75f), vector8, 0.1f);
					Vector4 vector16 = global::랾.랽.랾(*colors[5], global::랾.랽.럎(vector7, 0.55f), 0.2f + num4 * 0.45f);
					vector16.W = Mathf.Lerp(vector16.W, 0.55f, num4);
					*colors[3] = vector14;
					*colors[7] = vector15;
					*colors[8] = global::랾.랽.랾(vector15, vector8, 0.55f);
					*colors[9] = global::랾.랽.랾(vector15, vector9, 0.7f);
					*colors[21] = global::랾.랽.랾(vector15, vector8, 0.2f);
					*colors[22] = global::랾.랽.랾(vector15, vector9, 0.4f);
					*colors[23] = global::랾.랽.랾(vector15, vector7, 0.6f);
					*colors[24] = global::랾.랽.랾(vector14, vector8, 0.28f);
					*colors[25] = global::랾.랽.랾(vector14, vector9, 0.42f);
					*colors[26] = global::랾.랽.랾(vector14, vector7, 0.54f);
					*colors[5] = vector16;
					*colors[27] = global::랾.랽.랾(vector16, vector8, 0.2f);
					*colors[28] = global::랾.랽.랾(vector16, vector9, 0.4f);
					*colors[29] = global::랾.랽.랾(vector16, vector7, 0.6f);
					*colors[11] = global::랾.랽.랾(vector14, vector8, 0.18f);
					*style.WindowBorderSize = Math.Max(*style.WindowBorderSize, 1f);
					*style.ChildBorderSize = Math.Max(*style.ChildBorderSize, 1f);
					*style.FrameBorderSize = ((num4 >= 0.4f) ? Math.Max(*style.FrameBorderSize, 1f) : (*style.FrameBorderSize));
				}
				if (ConfigFile.uiPillTabsEnabled)
				{
					Vector4 vector17 = global::랾.랽.랾(global::랾.랽.람(vector13, 0.05f), global::랾.랽.람(*colors[3], 0.04f), 0.7f);
					*colors[34] = vector17;
					*colors[33] = global::랾.랽.랾(vector17, vector8, 0.75f);
					*colors[35] = global::랾.랽.랾(vector17, vector9, 0.88f);
					*colors[37] = global::랾.랽.랾(vector17, global::랾.랽.럒(vector10, 0.1f), 0.6f);
					*colors[38] = global::랾.랽.랾(*colors[35], vector10, 0.18f);
					*colors[5] = global::랾.랽.랾(*colors[5], global::랾.랽.럎(vector7, 0.35f), 0.18f);
				}
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0008D408 File Offset: 0x0008B608
		private static 럦.람 럎(string A_0)
		{
			럦.람 람;
			if (!global::랾.럦.랾.TryGetValue(A_0, out 람))
			{
				람 = new 럦.람();
				global::랾.럦.랾[A_0] = 람;
			}
			return 람;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0003EEA1 File Offset: 0x0003D0A1
		internal static void 람(string A_0)
		{
			럦.람 람 = global::랾.럦.럎(A_0);
			람.랾 = false;
			람.럎 = false;
			람.랾 = -1f;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0008D438 File Offset: 0x0008B638
		internal static bool 랾(string A_0, bool A_1)
		{
			럦.람 람 = global::랾.럦.럎(A_0);
			if (!ConfigFile.uiOpenAnimationEnabled)
			{
				if (!A_1)
				{
					global::랾.럦.람(A_0);
					return false;
				}
				람.랾 = true;
				람.럎 = false;
				return true;
			}
			else
			{
				if (A_1)
				{
					if (!람.랾 || 람.럎)
					{
						람.랾 = true;
						람.럎 = false;
						람.랾 = Time.realtimeSinceStartup;
					}
					return true;
				}
				if (!람.랾)
				{
					return false;
				}
				if (!람.럎)
				{
					람.럎 = true;
					람.랾 = Time.realtimeSinceStartup;
				}
				if (global::랾.럦.람(람.랾) >= 0.999f)
				{
					global::랾.럦.람(A_0);
					return false;
				}
				return true;
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0003EEC1 File Offset: 0x0003D0C1
		internal static bool 럒(string A_0)
		{
			return global::랾.럦.럎(A_0, true);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0008D4DC File Offset: 0x0008B6DC
		internal static bool 럎(string A_0, bool A_1)
		{
			if (!ConfigFile.uiOpenAnimationEnabled)
			{
				return false;
			}
			럦.람 람 = global::랾.럦.럎(A_0);
			if (A_1)
			{
				if (!람.랾 || 람.럎)
				{
					람.랾 = true;
					람.럎 = false;
					람.랾 = Time.realtimeSinceStartup;
				}
			}
			else
			{
				if (!람.랾)
				{
					return false;
				}
				if (!람.럎)
				{
					람.럎 = true;
					람.랾 = Time.realtimeSinceStartup;
				}
			}
			float num = global::랾.럦.람(람.랾);
			if (num < 0.999f)
			{
				float num2 = A_1 ? Mathf.Lerp(0.35f, 1f, num) : Mathf.Lerp(1f, 0f, num);
				if (람.람)
				{
					float num3 = Math.Clamp(ConfigFile.uiOpenAnimationOffset, 6f, 36f);
					float num4 = A_1 ? Mathf.Lerp(num3, 0f, num) : Mathf.Lerp(0f, num3 * 0.6f, num);
					ImGui.SetNextWindowPos(new Vector2(람.랾.X, 람.랾.Y + num4), 1);
				}
				ImGui.PushStyleVar(0, num2);
				return true;
			}
			if (!A_1)
			{
				return false;
			}
			람.랾 = -1f;
			return false;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0008D608 File Offset: 0x0008B808
		private static float 람(float A_0)
		{
			if (!ConfigFile.uiOpenAnimationEnabled || A_0 < 0f)
			{
				return 1f;
			}
			float num = Math.Max(0.05f, ConfigFile.uiOpenAnimationDuration);
			float num2 = Mathf.Clamp01((Time.realtimeSinceStartup - A_0) / num);
			return 1f - Mathf.Pow(1f - num2, 3f);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0008D660 File Offset: 0x0008B860
		internal static void 럼(string A_0)
		{
			럦.람 람 = global::랾.럦.럎(A_0);
			if (ConfigFile.uiOpenAnimationEnabled && (람.랾 >= 0f || 람.럎))
			{
				return;
			}
			Vector2 windowPos = ImGui.GetWindowPos();
			Vector2 windowSize = ImGui.GetWindowSize();
			if (windowSize.X > 32f && windowSize.Y > 32f)
			{
				람.랾 = windowPos;
				람.람 = true;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0008D6C8 File Offset: 0x0008B8C8
		private static void 랆()
		{
			ConfigFile.uiCustomAccentEnabled = false;
			ConfigFile.uiAccentColor = "#D9D1C7FF";
			ConfigFile.uiCustomBackgroundEnabled = false;
			ConfigFile.uiBackgroundColor = "#111010F2";
			ConfigFile.uiCustomShapeEnabled = false;
			ConfigFile.uiGlobalScale = 1f;
			ConfigFile.uiCustomOpacityEnabled = false;
			ConfigFile.uiGlobalAlpha = 1f;
			ConfigFile.uiEnhancedSurfacesEnabled = false;
			ConfigFile.uiPanelLift = 0.06f;
			ConfigFile.uiPanelBorderStrength = 0.35f;
			ConfigFile.uiPillTabsEnabled = false;
			ConfigFile.uiSectionAccentEnabled = true;
			ConfigFile.uiSectionAccentThickness = 2f;
			ConfigFile.uiSectionAccentLength = 0.45f;
			ConfigFile.uiLayoutSpacingScale = 1f;
			ConfigFile.uiWindowPaddingScale = 1f;
			ConfigFile.uiWindowGlowEnabled = false;
			ConfigFile.uiWindowGlowStrength = 0.22f;
			ConfigFile.uiWindowRounding = 4f;
			ConfigFile.uiFrameRounding = 3f;
			ConfigFile.uiChildRounding = 3f;
			ConfigFile.uiTabRounding = 3f;
			ConfigFile.uiOpenAnimationEnabled = true;
			ConfigFile.uiOpenAnimationDuration = 0.18f;
			ConfigFile.uiOpenAnimationStartScale = 0.94f;
			ConfigFile.uiOpenAnimationOffset = 18f;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0008D7C0 File Offset: 0x0008B9C0
		private static void 랐()
		{
			ConfigFile.uiEspPlayerColor = "#33FF66FF";
			ConfigFile.uiEspEnemyColor = "#FF4D4DFF";
			ConfigFile.uiEspStaffRainbow = true;
			ConfigFile.uiEspStaffColor = "#FF4DE6FF";
			ConfigFile.uiEspCollectableColor = "#338DFFFF";
			ConfigFile.uiEspGiftBoxColor = "#FFD93DFF";
			ConfigFile.uiEspOreColor = "#FFFFFFFF";
			ConfigFile.uiEspPortalUnlockedColor = "#37D65CFF";
			ConfigFile.uiEspPortalLockedColor = "#FF4F4FFF";
			ConfigFile.uiEspButterflyColor = "#FFE03DFF";
			ConfigFile.uiEspEventColor = "#FF4DE6FF";
			ConfigFile.uiEspNetherBossColor = "#FFE03DFF";
			ConfigFile.uiEspNetherKeyColor = "#FFD93DFF";
			ConfigFile.uiEspNetherExitColor = "#FF8C1AFF";
			ConfigFile.uiEspSwordColor = "#101010FF";
			ConfigFile.uiEspCrossBreedColor = "#33FF8CFF";
			ConfigFile.uiEspCrossBreedNewColor = "#FFCC33FF";
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0008D874 File Offset: 0x0008BA74
		private static void 럆()
		{
			ConfigFile.uiPathLineStyle = 0;
			ConfigFile.uiPathLineThicknessScale = 1f;
			ConfigFile.uiPathDashLength = 14f;
			ConfigFile.uiPathGapLength = 8f;
			ConfigFile.uiPathHoverColor = "#59D9FFCC";
			ConfigFile.uiPathTeleportColor = "#59D9FFF2";
			ConfigFile.uiPathMiningColor = "#FFA629CC";
			ConfigFile.uiPathReachableColor = "#33FF73F2";
			ConfigFile.uiPathBreakTargetColor = "#FF75D7FA";
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0008D8D8 File Offset: 0x0008BAD8
		private static void 랄()
		{
			ConfigFile.uiToastWidth = 430f;
			ConfigFile.uiToastMinHeight = 88f;
			ConfigFile.uiToastSpacing = 10f;
			ConfigFile.uiToastOffsetX = 18f;
			ConfigFile.uiToastOffsetY = 16f;
			ConfigFile.uiToastTitleScale = 1.05f;
			ConfigFile.uiToastMessageScale = 0.93f;
			ConfigFile.uiToastRounding = 16f;
			ConfigFile.uiToastBorderThickness = 1.2f;
			ConfigFile.uiToastAccentBarWidth = 4f;
			ConfigFile.uiToastGlowStrength = 0.24f;
			ConfigFile.uiToastBackgroundColor = "#121720F2";
			ConfigFile.uiToastTitleColor = "#F4F7FFFF";
			ConfigFile.uiToastMessageColor = "#AFC0D9FF";
			ConfigFile.uiToastInfoColor = "#66BEFFFF";
			ConfigFile.uiToastSuccessColor = "#57E2A5FF";
			ConfigFile.uiToastWarningColor = "#FFC96BFF";
			ConfigFile.uiToastErrorColor = "#FF6B8DFF";
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0008D99C File Offset: 0x0008BB9C
		private static void 랳()
		{
			if (!ImGui.BeginTabItem("Diagnostics [Dev]"))
			{
				return;
			}
			global::랾.럦.람();
			랊 랊 = global::랾.럓.럒();
			global::랾.럦.랾("Runtime");
			if (global::랾.럦.랾("diagnostics_runtime", 2))
			{
				global::랾.럦.랾("Scene", global::랾.럦.럸());
				global::랾.럦.랾("Tick Source", 랊.랾());
				global::랾.럦.랾("Tick Count", 랊.럼().ToString());
				global::랾.럦.랾("Last Tick Frame", global::랾.럦.람(랊.럎()));
				global::랾.럦.랾("UI Render Frame", global::랾.럦.람(랊.람()));
				global::랾.럦.랾("ESP Render Frame", global::랾.럦.람(랊.럒()));
				global::랾.럦.랾("Uptime", global::랾.럦.랴());
				ImGui.EndTable();
			}
			global::랾.럦.랾("State");
			if (global::랾.럦.랾("diagnostics_state", 2))
			{
				global::랾.럦.랾("In World", global::랾.럦.랋(랊.랓()));
				global::랾.럦.랾("Menu Visible", global::랾.럦.랋(랊.럯()));
				global::랾.럦.랾("Packet Console", global::랾.럦.랋(랊.럭()));
				global::랾.럦.랾("Player Cache", global::랾.럦.랋(랊.랋()));
				global::랾.럦.랾("World Cache", global::랾.럦.랋(랊.랉()));
				global::랾.럦.랾("Chat Cache", global::랾.럦.랋(랊.럐()));
				global::랾.럦.랾("Ghost Lag", global::랾.럦.랋(랊.럙()));
				global::랾.럦.랾("Stream Detected", global::랾.럦.랋(랊.랱()));
				ImGui.EndTable();
			}
			ImGui.EndTabItem();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0003EECA File Offset: 0x0003D0CA
		private static void 랾(string A_0, string A_1)
		{
			ImGui.TableNextRow();
			ImGui.TableNextColumn();
			ImGui.TextUnformatted(A_0);
			ImGui.TableNextColumn();
			ImGui.TextUnformatted(A_1);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0003EEE9 File Offset: 0x0003D0E9
		private static string 랋(bool A_0)
		{
			if (!A_0)
			{
				return "No";
			}
			return "Yes";
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0003EEF9 File Offset: 0x0003D0F9
		private static string 람(int A_0)
		{
			if (A_0 >= 0)
			{
				return A_0.ToString();
			}
			return "Not yet";
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0008DB40 File Offset: 0x0008BD40
		private static string 럸()
		{
			Scene activeScene = SceneManager.GetActiveScene();
			if (!string.IsNullOrWhiteSpace(activeScene.name))
			{
				return activeScene.name;
			}
			return "Unknown";
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0008DB70 File Offset: 0x0008BD70
		private static string 랴()
		{
			if (global::랾.럴.랾 == null)
			{
				return "Unknown";
			}
			return (DateTime.Now - global::랾.럴.랾.Value).ToString("hh\\:mm\\:ss");
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0008DBB0 File Offset: 0x0008BDB0
		private static void 럺()
		{
			if (!ImGui.BeginTabItem("Home"))
			{
				return;
			}
			global::랾.럦.람();
			string str = string.IsNullOrWhiteSpace(StaticPlayer.theRealPlayername) ? "Player" : StaticPlayer.theRealPlayername;
			ImGui.Text("Welcome back, " + str + "!");
			ImGui.Separator();
			ImGui.TextWrapped("Never share your console with anyone except Charon.");
			ImGui.TextWrapped("If you plan on screensharing then do it fullscreen to avoid sensitive information being leaked by the console.");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Use ");
			defaultInterpolatedStringHandler.AppendFormatted<KeyCode>(ConfigFile.menuToggleKey);
			defaultInterpolatedStringHandler.AppendLiteral(" to interact with the menu.");
			ImGui.TextWrapped(defaultInterpolatedStringHandler.ToStringAndClear());
			if (ImGui.CollapsingHeader("Known Bugs"))
			{
				ImGui.TextWrapped("Any unknown bugs. Report issues directly.");
				ImGui.TextWrapped("Autofishing: Recycling fish may fail depending if it exists in the world and how close you are to it. It may also not refresh your inventory, I recommend disabling it for now");
				ImGui.TextWrapped("Autofishing: Auto Buy Packs for autofish will require /rg to refresh the inventory, I recommend disabling it for now and just mass-buy lure before fishing");
				ImGui.TextWrapped("Auto Farm: May Tweak a little bit, not 100% sure if it's fixed");
				ImGui.TextWrapped("Auto Mine: Won't work until I fix the teleport due to new anti-cheat measures");
			}
			ImGui.EndTabItem();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0008DC94 File Offset: 0x0008BE94
		private static void 럠()
		{
			if (!ImGui.BeginTabItem("Player"))
			{
				return;
			}
			global::랾.럦.람();
			if (global::랾.럦.랾("PlayerSections", 2))
			{
				ImGui.TableNextColumn();
				global::랾.럦.랮();
				ImGui.Spacing();
				global::랾.럦.럅();
				ImGui.TableNextColumn();
				global::랾.럦.랰();
				ImGui.Spacing();
				global::랾.럦.럖();
				ImGui.EndTable();
			}
			ImGui.EndTabItem();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0003EF0C File Offset: 0x0003D10C
		private static void 랮()
		{
			global::랾.럦.랾("Identity");
			ImGui.TextWrapped("Change the local player name text shown on your client.");
			ImGui.Checkbox("Custom Name", ref ConfigFile.customPlayerName);
			ImGui.InputText("Player Name##Player", ref ConfigFile.customPlayerNameValue, 100U);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0008DCF4 File Offset: 0x0008BEF4
		private static void 럅()
		{
			global::랾.럦.랾("Movement");
			ImGui.Checkbox("Air Resistance", ref ConfigFile.airResistanceToggle);
			global::랾.러.랾("Fly", ref ConfigFile.flyToggle);
			ImGui.Checkbox("Fly (Arrow Keys)", ref ConfigFile.alternativeFlyHotkeysToggle);
			ImGui.SliderFloat("Fly Speed##Player", ref ConfigFile.flySpeed, 0.5f, 20f, "%.2f");
			global::랾.러.랾("Free Cam", ref ConfigFile.freeCamToggle);
			global::랾.러.랾("Infinite Jetpack", ref ConfigFile.infiniteJetpackFuel);
			global::랾.러.랾("Infinite Jumps", ref ConfigFile.infiniteJumps);
			global::랾.럦.럶();
			global::랾.러.랾("Player Speed", ref ConfigFile.increasedRunSpeedToggle);
			ImGui.SliderFloat("Run Speed##Player", ref global::랾.럧.랓, 1.8f, 10f, "%.2f");
			global::랾.러.랾("Hit Speed", ref ConfigFile.increasedHitSpeedToggle);
			ImGui.SliderFloat("Hit Speed##Player", ref global::랾.럧.럯, 0.11f, 0.2f, "%.3f");
			global::랾.러.랾("Zoom Hack", ref ConfigFile.zoomHackToggle);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0008DE00 File Offset: 0x0008C000
		private static void 랰()
		{
			global::랾.럦.랾("Protection");
			global::랾.러.랾("Anti-Block Kill", ref ConfigFile.antiBlockKillToggle);
			ImGui.Checkbox("Anti-Bounce", ref ConfigFile.antiBounceToggle);
			ImGui.Checkbox("Anti-Checkpoint", ref ConfigFile.antiCheckPointToggle);
			ImGui.Checkbox("Anti-Darkness", ref ConfigFile.antiDarknessToggle);
			ImGui.Checkbox("Anti-Fan", ref ConfigFile.antiFanToggle);
			global::랾.러.랾("Anti-Knockback", ref ConfigFile.antiKnockbackToggle);
			ImGui.Checkbox("Anti-Portal", ref ConfigFile.antiPortalToggle);
			global::랾.러.랾("Anti-Poison", ref ConfigFile.antiPoisonToggle);
			ImGui.Checkbox("Delay Summon", ref ConfigFile.antiSummonToggle);
			global::랾.러.랾("God Mode", ref ConfigFile.godModeToggle);
			ImGui.Checkbox("Leave Upon Summon", ref ConfigFile.leaveUponSummon);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0008DEC8 File Offset: 0x0008C0C8
		private static void 럖()
		{
			global::랾.럦.랾("Utility");
			ImGui.Checkbox("Anti-Censor", ref ConfigFile.antiCensorToggle);
			ImGui.Checkbox("Anti-Pickup", ref global::랾.럧.럲);
			ImGui.Checkbox("Auto Math", ref global::랾.럧.랆);
			ImGui.Checkbox("Chat Commands", ref ConfigFile.enableChatCommandsToggle);
			ImGui.Checkbox("Click To Drop", ref global::랾.럧.럻);
			global::랾.러.랾("Extended Pick-Up", ref ConfigFile.extendedPickUpToggle);
			global::랾.러.랾("Fake Movement Lag", ref ConfigFile.fakeLagToggle);
			global::랾.러.랾("Fast Respawn", ref ConfigFile.fastRespawnToggle);
			ImGui.Checkbox("Max Oxygen", ref ConfigFile.unlimitedOxygenToggle);
			global::랾.러.랾("Max Text", ref ConfigFile.unCappedTextToggle);
			ImGui.Checkbox("Paused Leave", ref ConfigFile.pausedLeaveToggle);
			ImGui.Spacing();
			global::랾.럦.랾("Spectate");
			bool 럫 = global::랾.럧.럫;
			if (ImGui.Checkbox("Spectate Mode", ref 럫))
			{
				global::랾.랴.럎(럫);
			}
			NetworkPlayer[] array = global::랾.럽.럒();
			if (global::랾.럧.럫 && array.Length != 0)
			{
				global::랾.럦.랾(array);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0008DFD0 File Offset: 0x0008C1D0
		private unsafe static void 랾(NetworkPlayer[] A_0)
		{
			if (A_0 == null || A_0.Length == 0)
			{
				global::랾.럧.럴 = "None";
				return;
			}
			ImGui.Spacing();
			ImGui.Text("Watching: " + global::랾.럧.럴);
			ImGui.SameLine();
			if (ImGui.SmallButton("<##spec"))
			{
				global::랾.럧.럐--;
				if (global::랾.럧.럐 < 0)
				{
					global::랾.럧.럐 = A_0.Length - 1;
				}
			}
			ImGui.SameLine();
			if (ImGui.SmallButton(">##spec"))
			{
				global::랾.럧.럐++;
				if (global::랾.럧.럐 >= A_0.Length)
				{
					global::랾.럧.럐 = 0;
				}
			}
			if (ImGui.BeginChild("##SpectatePlayers", new Vector2(0f, 140f), 1))
			{
				ImGuiListClipperPtr imGuiListClipperPtr;
				imGuiListClipperPtr..ctor(ImGuiNative.ImGuiListClipper_ImGuiListClipper());
				imGuiListClipperPtr.Begin(A_0.Length);
				while (imGuiListClipperPtr.Step())
				{
					for (int i = *imGuiListClipperPtr.DisplayStart; i < *imGuiListClipperPtr.DisplayEnd; i++)
					{
						NetworkPlayer networkPlayer = A_0[i];
						string text;
						if ((text = ((networkPlayer != null) ? networkPlayer.name : null)) == null)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
							defaultInterpolatedStringHandler.AppendLiteral("Player ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
							text = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						if (ImGui.Selectable(text, global::랾.럧.럐 == i))
						{
							global::랾.럧.럐 = i;
						}
					}
				}
				imGuiListClipperPtr.End();
			}
			ImGui.EndChild();
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0008E118 File Offset: 0x0008C318
		private static void 럶()
		{
			ImGui.Text("Jump Mode");
			int num = global::랾.럦.랻();
			if (num < 0)
			{
				ImGui.TextDisabled("Unavailable");
				return;
			}
			if (!ImGui.BeginCombo("##jumpMode", global::랾.럧.럎[num]))
			{
				return;
			}
			for (int i = 0; i < global::랾.럧.럎.Length; i++)
			{
				bool flag = num == i;
				if (ImGui.Selectable(global::랾.럧.럎[i], flag))
				{
					global::랾.럧.랉 = i;
					PlayerJumpMode jumpMode;
					if (global::랾.럓.랾 != null && Enum.TryParse<PlayerJumpMode>(global::랾.럧.럎[i], out jumpMode))
					{
						global::랾.럓.랾.jumpMode = jumpMode;
					}
				}
				if (flag)
				{
					ImGui.SetItemDefaultFocus();
				}
			}
			ImGui.EndCombo();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0008E1BC File Offset: 0x0008C3BC
		private static int 랻()
		{
			if (global::랾.럧.럎 == null || global::랾.럧.럎.Length == 0)
			{
				return -1;
			}
			int num = global::랾.럧.랉;
			if (num < global::랾.럧.럎.Length)
			{
				return num;
			}
			if (global::랾.럓.랾 != null)
			{
				int num2 = Array.IndexOf<string>(global::랾.럧.럎, global::랾.럓.랾.jumpMode.ToString());
				if (num2 >= 0)
				{
					global::랾.럧.랉 = num2;
					return num2;
				}
			}
			global::랾.럧.랉 = 0;
			return 0;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0008E230 File Offset: 0x0008C430
		private static void 략()
		{
			if (!ImGui.BeginTabItem("Combat"))
			{
				return;
			}
			global::랾.럦.람();
			global::랾.럦.랾("Aimbot");
			global::랾.러.랾("PVE Aimbot", ref ConfigFile.aimbotPVEToggle);
			global::랾.러.랾("PVP Aimbot", ref ConfigFile.aimbotToggle);
			ImGui.Checkbox("Nether Treasure Breaker", ref ConfigFile.autoNetherTargetTreasure);
			ImGui.SliderFloat("PVE Aimbot Delay", ref ConfigFile.pveAimbotInterval, 0.08f, 0.5f, "%.2fs");
			ImGui.SliderFloat("PVP Aimbot Delay", ref ConfigFile.pvpAimbotInterval, 0.08f, 0.5f, "%.2fs");
			global::랾.럦.랾("Click Actions");
			global::랾.러.랾("Click To Ban", ref ConfigFile.clickToBan);
			global::랾.러.랾("Click To Kick", ref ConfigFile.clickToKick);
			global::랾.러.랾("Click To Summon", ref ConfigFile.clickToSummon);
			global::랾.럦.랾("Detection");
			ImGui.Checkbox("Cheat Detector", ref ConfigFile.cheaterDetectorToggle);
			ImGui.EndTabItem();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0008E320 File Offset: 0x0008C520
		private static void 럵()
		{
			if (!ImGui.BeginTabItem("World"))
			{
				return;
			}
			global::랾.럦.람();
			if (global::랾.럦.랾("WorldSections", 2))
			{
				ImGui.TableNextColumn();
				global::랾.럦.랾("Protection");
				ImGui.Checkbox("Anti-Text Crash", ref ConfigFile.antiTextCrash);
				ImGui.Checkbox("Anti-Trap Crash", ref ConfigFile.antiTrapCrash);
				ImGui.Checkbox("Anti-Wiring Crash", ref ConfigFile.antiWiringCrash);
				ImGui.Checkbox("Optimize Lag", ref ConfigFile.optimizeWorldToggle);
				ImGui.TableNextColumn();
				global::랾.럦.랾("Access & Display");
				global::랾.러.랾("Full Access", ref ConfigFile.fullAccessToggle);
				ImGui.Checkbox("Hide Enemies", ref global::랾.럧.랴);
				ImGui.Checkbox("Hide Ore", ref global::랾.럧.럜);
				ImGui.Checkbox("Hide Players", ref global::랾.럧.럏);
				ImGui.Checkbox("SB Matchmaker", ref global::랾.럧.럺);
				global::랾.럦.랟();
				ImGui.TableNextColumn();
				global::랾.럦.랾("Quality Of Life");
				global::랾.러.랾("Place Seeds Anywhere", ref ConfigFile.placeSeedsAnywhereToggle);
				global::랾.러.랾("Place Blocks Anywhere", ref ConfigFile.placeBlocksOnPlayersToggle);
				global::랾.러.랾("Auto Gift Box Pickup", ref ConfigFile.autoGiftBoxPickupToggle);
				ImGui.Checkbox("Anti-AFK", ref ConfigFile.antiAFKToggle);
				ImGui.Checkbox("Show GM/FRQ Chat World", ref ConfigFile.showGMWorldToggle);
				ImGui.TableNextColumn();
				global::랾.럦.랾("Seed Automation");
				global::랾.러.랾("Auto Harvest Grown Seeds", ref ConfigFile.autoHarvestGrownSeedsToggle);
				ImGui.TextWrapped("This breaks fully grown planted seeds around your player using your normal build range.");
				global::랾.러.랾("Auto Plant Seeds", ref ConfigFile.autoPlantSeedsToggle);
				ImGui.TextWrapped("This plants seeds into empty valid spots around your player after harvests or whenever space is open.");
				if (ConfigFile.autoPlantSeedsToggle)
				{
					List<럆.랾> list = global::랾.럆.람();
					int autoPlantSelectedSeedBlockType = ConfigFile.autoPlantSelectedSeedBlockType;
					string text = global::랾.럆.럒();
					ImGui.Text("Seed To Plant");
					if (ImGui.BeginCombo("##AutoPlantSeedSelection", text))
					{
						bool flag = autoPlantSelectedSeedBlockType == -1;
						if (ImGui.Selectable("All Seeds (Inventory Order)", flag))
						{
							ConfigFile.autoPlantSelectedSeedBlockType = -1;
						}
						if (flag)
						{
							ImGui.SetItemDefaultFocus();
						}
						for (int i = 0; i < list.Count; i++)
						{
							럆.랾 랾 = list[i];
							bool flag2 = autoPlantSelectedSeedBlockType == 랾.랾();
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
							defaultInterpolatedStringHandler.AppendFormatted(랾.럎());
							defaultInterpolatedStringHandler.AppendLiteral(" x");
							defaultInterpolatedStringHandler.AppendFormatted<short>(랾.람());
							if (ImGui.Selectable(defaultInterpolatedStringHandler.ToStringAndClear(), flag2))
							{
								ConfigFile.autoPlantSelectedSeedBlockType = 랾.랾();
							}
							if (flag2)
							{
								ImGui.SetItemDefaultFocus();
							}
						}
						ImGui.EndCombo();
					}
					if (list.Count == 0)
					{
						ImGui.TextColored(new Vector4(1f, 0.7f, 0.35f, 1f), "No seeds found in inventory.");
					}
					else
					{
						ImGui.TextWrapped("Choose one seed to keep replanting it, or choose All Seeds to place every seed in your inventory order.");
					}
				}
				ImGui.EndTable();
			}
			ImGui.EndTabItem();
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0008E5C8 File Offset: 0x0008C7C8
		private static void 럨()
		{
			int num = ConfigFile.autoPlaceLockTypeIndex;
			if (num < 0 || num >= global::랾.럅.랾())
			{
				num = 3;
				ConfigFile.autoPlaceLockTypeIndex = num;
			}
			string text = global::랾.럅.랾(num);
			if (ImGui.BeginCombo("Lock Type", text))
			{
				for (int i = 0; i < global::랾.럅.랾(); i++)
				{
					bool flag = i == num;
					if (ImGui.Selectable(global::랾.럅.랾(i), flag))
					{
						ConfigFile.autoPlaceLockTypeIndex = i;
					}
					if (flag)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
			ImGui.Checkbox("Auto-Buy Missing Lock", ref ConfigFile.autoBuyMissingLockToggle);
			ImGui.TextWrapped("At spawn it fills left and right with solid blocks first, then prefers placing the selected lock one tile above spawn.");
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0008E654 File Offset: 0x0008C854
		private static void 럃()
		{
			if (!ImGui.BeginTabItem("ESP"))
			{
				return;
			}
			global::랾.럦.람();
			ImGui.TextWrapped("Choose what the ESP should highlight here. Related options are grouped together so player, world, loot, and helper settings are easier to scan.");
			ImGui.Separator();
			if (global::랾.럦.랾("ESPSections", 2))
			{
				try
				{
					ImGui.TableNextColumn();
					global::랾.럦.랾("Players and Combat");
					ImGui.TextDisabled("Track people, staff, and enemy targets.");
					global::랾.럦.랾("Player", ref ConfigFile.playerESPTracer, ref ConfigFile.playerESPBox);
					global::랾.럦.랾("Enemy", ref ConfigFile.enemyESPTracer, ref ConfigFile.enemyESPBox);
					global::랾.럦.랾("Mod/Admin", ref ConfigFile.modESPTracers, ref ConfigFile.modESPBox);
					global::랾.러.랾("Nether Boss", ref ConfigFile.netherBossESPToggle);
					ImGui.Spacing();
					global::랾.럦.랾("Nether and Portals");
					ImGui.TextDisabled("Useful when routing inside Nether or finding world objects.");
					global::랾.러.랾("Nether Key", ref ConfigFile.netherKeyESPToggle);
					global::랾.러.랾("Nether Exit", ref ConfigFile.netherExitESPToggle);
					global::랾.러.랾("Portal", ref ConfigFile.portalESPToggle);
					global::랾.러.랾("Sword In Stone", ref ConfigFile.swordInTheStoneTracerToggle);
					ImGui.TableNextColumn();
					global::랾.럦.랾("Drops and World Objects");
					ImGui.TextDisabled("Loot, resources, and collectible world items.");
					global::랾.러.랾("Collectable", ref ConfigFile.collectableESPTracer);
					global::랾.러.랾("Gift Box", ref ConfigFile.giftBoxESPToggle);
					if (ConfigFile.giftBoxESPToggle)
					{
						ImGui.Indent();
						ImGui.Checkbox("Only show boxes you can still loot", ref ConfigFile.giftBoxESPUntakenOnly);
						ImGui.TextWrapped("This hides empty gift boxes and boxes already listed in your accessed gift box history.");
						ImGui.Unindent();
					}
					ImGui.Checkbox("Butterfly", ref ConfigFile.butterflyESPTracer);
					ImGui.Checkbox("Blue Particle", ref ConfigFile.blueParticleESPToggle);
					ImGui.Checkbox("Egg", ref ConfigFile.eggESPToggle);
					global::랾.러.랾("Ore", ref ConfigFile.oreESPToggle);
					ImGui.Checkbox("Valentine Heart", ref ConfigFile.valentineHeartESPToggle);
					ImGui.Spacing();
					global::랾.럦.랾("Helpers");
					ImGui.TextDisabled("Filters and helper overlays that add more context.");
					ImGui.Checkbox("Cross-Breed Helper", ref ConfigFile.crossBreedSeedEspToggle);
					if (ConfigFile.crossBreedSeedEspToggle)
					{
						ImGui.Indent();
						ImGui.Checkbox("Only show new recipes", ref ConfigFile.crossBreedSeedEspNewRecipesOnly);
						ImGui.TextWrapped("This hides seed pairings that only lead to recipes you already unlocked.");
						ImGui.Unindent();
					}
				}
				finally
				{
					ImGui.EndTable();
				}
			}
			ImGui.EndTabItem();
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0003EF44 File Offset: 0x0003D144
		private static void 랾(string A_0, ref bool A_1, ref bool A_2)
		{
			ImGui.Checkbox(A_0 + "##" + A_0 + "Tracer", ref A_1);
			ImGui.SameLine(220f);
			ImGui.Checkbox("Show Box##" + A_0 + "Box", ref A_2);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0008E884 File Offset: 0x0008CA84
		private static void 랝()
		{
			if (!ImGui.BeginTabItem("Teleport"))
			{
				return;
			}
			global::랾.럦.람();
			if (global::랾.럧.럯)
			{
				int count = global::랾.럧.랾.Count;
				int num = count - global::랾.럧.럒;
				float teleportSpeed = ConfigFile.TeleportSpeed;
				int num2 = global::랾.럺.럎(count, global::랾.럧.랺);
				float value = (float)((num2 > 0) ? (num / num2) : num) * teleportSpeed;
				Vector4 vector = new Vector4(0.4f, 0.8f, 1f, 1f);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Teleporting: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral(" nodes left (~");
				defaultInterpolatedStringHandler.AppendFormatted<float>(value, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("s)");
				ImGui.TextColored(vector, defaultInterpolatedStringHandler.ToStringAndClear());
				float num3 = (count > 0) ? ((float)global::랾.럧.럒 / (float)count) : 0f;
				Vector2 vector2 = new Vector2(-1f, 0f);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럧.럒);
				defaultInterpolatedStringHandler2.AppendLiteral("/");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(count);
				ImGui.ProgressBar(num3, vector2, defaultInterpolatedStringHandler2.ToStringAndClear());
				if (ImGui.Button("Cancel Teleport"))
				{
					global::랾.럺.럒();
				}
				ImGui.Separator();
			}
			global::랾.러.랾("Enable Teleport", ref ConfigFile.teleportToggle);
			ImGui.Checkbox("Show Teleport Path", ref ConfigFile.showTeleportPathToggle);
			ImGui.Checkbox("Always Show Teleport Path", ref ConfigFile.alwaysShowTeleportPath);
			ImGui.Checkbox("Show Teleport Notifications", ref ConfigFile.showTeleportNotifications);
			ImGui.SliderInt("Teleport Chunk Amount", ref ConfigFile.teleportChunkAmount, 1, 10);
			if (!ConfigFile.instantTeleportToggle)
			{
				ImGui.SliderFloat("Base Speed", ref ConfigFile.DefaultTeleportSpeedThreshold, 0.01f, 0.5f, "%.3fs");
				if (global::랾.럧.랺)
				{
					ImGui.SliderFloat("Auto-Mine Speed", ref ConfigFile.AutoMiningTeleportSpeedThreshold, 0.01f, 0.5f, "%.3fs");
				}
			}
			if (ConfigFile.instantTeleportToggle || ConfigFile.teleportChunkAmount >= 10)
			{
				ImGui.TextColored(new Vector4(1f, 0.45f, 0.45f, 1f), "Important:");
				ImGui.TextWrapped("This may cause a lot more disconnects. The suggested settings are 1-5 teleport chunks with instant teleport turned off.");
			}
			ImGui.Separator();
			global::랾.럦.랾("Cancel Hotkey");
			global::랾.럦.랾("Teleport Cancel Key", ConfigFile.teleportCancelKey, global::랾.럧.랾.럎, 0, new Action<KeyCode>(global::랾.럦.럼.랾.랾));
			ImGui.TextWrapped("Press this while a teleport is running to cancel the current route. Keyboard keys and mouse buttons are supported.");
			ImGui.Separator();
			ImGui.TextWrapped("Alt + Right Click on the world or minimap to move along the path using normal-looking movement.");
			ImGui.TextWrapped("Wearing a jetpack will make the teleport less likely to trigger anti-cheat, but it's not required. Same with Roller Skates.");
			ImGui.EndTabItem();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0008EAFC File Offset: 0x0008CCFC
		private static void 럾()
		{
			if (!ImGui.BeginTabItem("Troll"))
			{
				return;
			}
			global::랾.럦.람();
			ImGui.Text("Target Player");
			ImGui.InputText("##TargetName", ref global::랾.럧.랺, 100U);
			ImGui.Separator();
			ImGui.Checkbox("Click-2-Spike Bomb", ref global::랾.럧.랢);
			ImGui.Checkbox("Clone Chat", ref global::랾.럧.럚);
			ImGui.Checkbox("Finish Race", ref global::랾.럧.랦);
			ImGui.Checkbox("Player Randomizer", ref global::랾.럧.럝);
			ImGui.Checkbox("Poison Effect", ref global::랾.럧.럩);
			ImGui.Checkbox("Spawn Spike Bombs", ref global::랾.럧.럳);
			ImGui.Checkbox("Specific Trade", ref global::랾.럧.랞);
			ImGui.Checkbox("Trade All", ref global::랾.럧.럽);
			ImGui.Checkbox("Trap Crash", ref global::랾.럧.럔);
			ImGui.EndTabItem();
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0008EBD4 File Offset: 0x0008CDD4
		private static void 럀()
		{
			if (!ImGui.BeginTabItem("Settings"))
			{
				return;
			}
			global::랾.럦.람();
			if (ImGui.CollapsingHeader("Hotkeys", 32))
			{
				global::랾.럦.랂();
			}
			if (ImGui.CollapsingHeader("Discord RPC"))
			{
				global::랾.럦.랸();
			}
			if (ImGui.CollapsingHeader("Debug"))
			{
				global::랾.럦.랈();
			}
			if (ImGui.CollapsingHeader("Notifications & Messages"))
			{
				global::랾.럦.랎();
			}
			if (ImGui.CollapsingHeader("Online Presence"))
			{
				global::랾.럦.럹();
			}
			if (ImGui.CollapsingHeader("Profiles"))
			{
				if (ImGui.Button("Open Guided Setup"))
				{
					global::랾.럐.랾();
				}
				global::랾.럦.럿();
			}
			ImGui.Checkbox("FPS Cap", ref ConfigFile.fpsCapToggle);
			ImGui.SliderInt("Max FPS", ref ConfigFile.maxFps, 15, 480);
			ImGui.EndTabItem();
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0008EC98 File Offset: 0x0008CE98
		private static void 랂()
		{
			global::랾.럦.랾("Menu Key", ConfigFile.menuToggleKey, global::랾.럧.랾.랾, 283, new Action<KeyCode>(global::랾.럦.럼.랾.럎));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Use ");
			defaultInterpolatedStringHandler.AppendFormatted<KeyCode>(ConfigFile.menuToggleKey);
			defaultInterpolatedStringHandler.AppendLiteral(" to hide the menu.");
			ImGui.TextWrapped(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0008ED14 File Offset: 0x0008CF14
		private static void 랾(string A_0, KeyCode A_1, 럧.랾 A_2, KeyCode A_3, Action<KeyCode> A_4)
		{
			if (global::랾.럧.랉 && global::랾.럧.랾 == A_2)
			{
				ImGui.TextColored(new Vector4(1f, 0.8f, 0.3f, 1f), A_0 + ": Press any key...");
				return;
			}
			ImGui.Text(A_0 + ": " + global::랾.럦.랾(A_1));
			ImGui.SameLine();
			if (ImGui.SmallButton("Change##" + A_0))
			{
				global::랾.럧.랉 = true;
				global::랾.럧.랾 = A_2;
			}
			ImGui.SameLine();
			if (ImGui.SmallButton("Reset##" + A_0))
			{
				A_4(A_3);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0003EF7F File Offset: 0x0003D17F
		private static string 랾(KeyCode A_0)
		{
			if (A_0 != null)
			{
				return A_0.ToString();
			}
			return "None";
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0008EDB4 File Offset: 0x0008CFB4
		private static void 래()
		{
			int num = global::랾.럦.랕();
			if (num < 0)
			{
				ImGui.TextDisabled("Theme presets unavailable.");
				return;
			}
			if (!ImGui.BeginCombo("##Theme", global::랾.럧.람[num]))
			{
				return;
			}
			for (int i = 0; i < global::랾.럧.람.Length; i++)
			{
				bool flag = i == num;
				if (ImGui.Selectable(global::랾.럧.람[i], flag))
				{
					global::랾.럦.럒(i);
				}
				if (flag)
				{
					ImGui.SetItemDefaultFocus();
				}
			}
			ImGui.EndCombo();
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0008EE24 File Offset: 0x0008D024
		private static void 랸()
		{
			ImGui.Checkbox("Enable Discord RPC", ref ConfigFile.discordRPCToggle);
			ImGui.Checkbox("Show Player Name", ref ConfigFile.ShowRPCPlayerName);
			ImGui.Checkbox("Show Player Count", ref ConfigFile.ShowRPCPlayerCount);
			ImGui.Checkbox("Show World Name", ref ConfigFile.ShowRPCPlayerWorld);
			ImGui.Separator();
			ImGui.Text("Fake Player Name");
			ImGui.InputText("##RPCName", ref ConfigFile.rpcPlayerName, 128U);
			ImGui.Text("Fake World Name");
			ImGui.InputText("##RPCWorld", ref ConfigFile.rpcWorldName, 128U);
			ImGui.Separator();
			ImGui.Text("RPC Image");
			int num = global::랾.럦.럌();
			if (num < 0)
			{
				ImGui.TextDisabled("RPC images unavailable.");
				return;
			}
			if (!ImGui.BeginCombo("##album", global::랾.럧.랾[num]))
			{
				return;
			}
			for (int i = 0; i < global::랾.럧.랾.Length; i++)
			{
				bool flag = num == i;
				if (ImGui.Selectable(global::랾.럧.랾[i], flag))
				{
					ConfigFile.selectedAlbumIndex = i;
					string a = global::랾.럧.랾[i];
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
				if (flag)
				{
					ImGui.SetItemDefaultFocus();
				}
			}
			ImGui.EndCombo();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0008EF68 File Offset: 0x0008D168
		private static void 랈()
		{
			ImGui.Checkbox("Always Show Tooltips", ref ConfigFile.alwaysShowToolTipToggle);
			ImGui.Checkbox("Auto Leave", ref ConfigFile.autoLeaveToggle);
			ImGui.Checkbox("Mod/Admin Console", ref ConfigFile.showModAndAdminConsole);
			ImGui.Checkbox("Mods Online Checker", ref global::랾.럧.랖);
			ImGui.Checkbox("Packet Console", ref ConfigFile.packetConsole);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0008EFC8 File Offset: 0x0008D1C8
		private static void 랎()
		{
			ImGui.Checkbox("Show Notification Console", ref ConfigFile.notificationConsoleToggle);
			ImGui.Checkbox("Show Notifications Over Text", ref ConfigFile.showNotifications);
			ImGui.Checkbox("Show Mod/Admin Notifications", ref ConfigFile.modAndAdminNotifications);
			ImGui.Checkbox("Show Teleport Notifications", ref ConfigFile.showTeleportNotifications);
			ImGui.Separator();
			ImGui.Checkbox("Enable Mod Detection via Webhook", ref ConfigFile.webhookModDetectToggle);
			ImGui.TextWrapped("Enter an endpoint URL/webhook below to send a notification if a mod is detected. This is useful for autofishing and similar unattended features.");
			ImGui.InputText("Mod Detector Endpoint URL/Webhook", ref ConfigFile.modDetectedWebhookLink, 512U);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0008F04C File Offset: 0x0008D24C
		private static void 럹()
		{
			ImGui.Checkbox("Share Online Presence", ref ConfigFile.onlinePresenceToggle);
			ImGui.TextWrapped("When enabled, your client adds itself to the shared online clients list. Turning this off removes your own presence entry but still lets you see the live client count.");
			ImGui.Separator();
			ImGui.Checkbox("Report Mod And Admin Sightings", ref ConfigFile.reportModAndAdminSightingsToggle);
			ImGui.TextWrapped("When enabled, the client reports a sighting only when a Moderator or Admin player ID is detected in-world or in chat.");
			int developerSightingCooldownSeconds = ConfigFile.developerSightingCooldownSeconds;
			if (ImGui.SliderInt("Sighting Report Cooldown (seconds)", ref developerSightingCooldownSeconds, 30, 600))
			{
				ConfigFile.developerSightingCooldownSeconds = developerSightingCooldownSeconds;
			}
			int modAndAdminSightingPollSeconds = ConfigFile.modAndAdminSightingPollSeconds;
			if (ImGui.SliderInt("Sighting Alert Check (seconds)", ref modAndAdminSightingPollSeconds, 120, 360))
			{
				ConfigFile.modAndAdminSightingPollSeconds = modAndAdminSightingPollSeconds;
			}
			ImGui.Separator();
			ImGui.Checkbox("Enable Client Relay Chat", ref ConfigFile.clientRelayChatToggle);
			ImGui.TextWrapped("Polls the shared client chat feed and forces incoming relay messages into in-game chat. Use /cmsg <message> to send one. If you have bad wi-fi, then I'd suggest 5-15 seconds, but it'd delay chat by 5-15 seconds.");
			string text = ConfigFile.clientRelayChatDisplayName ?? string.Empty;
			if (ImGui.InputText("Client Relay Name", ref text, 33U))
			{
				ConfigFile.clientRelayChatDisplayName = global::랾.럲.람(text);
			}
			ImGui.TextWrapped("Optional relay name. Letters, numbers, spaces, _ - and . only. Blank falls back to Client_XXXXXX.");
			int clientRelayChatPollSeconds = ConfigFile.clientRelayChatPollSeconds;
			if (ImGui.SliderInt("Client Relay Poll (seconds)", ref clientRelayChatPollSeconds, 3, 320))
			{
				ConfigFile.clientRelayChatPollSeconds = clientRelayChatPollSeconds;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0008F148 File Offset: 0x0008D348
		private static void 럿()
		{
			List<string> list = ConfigFile.랋();
			bool flag = list.Count > 0;
			if (flag)
			{
				global::랾.럦.랾 = Math.Clamp(global::랾.럦.랾, 0, list.Count - 1);
			}
			else
			{
				global::랾.럦.랾 = 0;
			}
			string text = flag ? list[global::랾.럦.랾] : string.Empty;
			ImGui.TextWrapped("Profiles let you save and load different client setups. This is useful for things like normal play, farming, testing, or packet manipulation.");
			ImGui.TextDisabled("Saving stores your current settings. Loading replaces your current settings with the saved profile.");
			ImGui.Separator();
			ImGui.InputText("Profile Name", ref global::랾.럦.럐, 64U);
			if (ImGui.Button("Save Profile"))
			{
				global::랾.럦.랾(ConfigFile.람(global::랾.럦.럐), "Saved profile: " + global::랾.럦.럐, "Failed to save profile.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Import Clipboard"))
			{
				string text2 = ImGui.GetClipboardText() ?? string.Empty;
				global::랾.럦.랾(ConfigFile.랾(global::랾.럦.럐, text2), "Imported profile: " + global::랾.럦.럐, "Failed to import profile.");
			}
			ImGui.Separator();
			if (!flag)
			{
				ImGui.TextDisabled("No saved profiles yet.");
				ImGui.TextDisabled("Current Profile: " + ConfigFile.랾());
				ImGui.TextDisabled("Startup Profile: " + global::랾.럦.랩());
				return;
			}
			if (ImGui.BeginCombo("Saved Profiles", text))
			{
				for (int i = 0; i < list.Count; i++)
				{
					bool flag2 = i == global::랾.럦.랾;
					if (ImGui.Selectable(list[i], flag2))
					{
						global::랾.럦.랾 = i;
						global::랾.럦.럐 = list[i];
					}
					if (flag2)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
			text = list[global::랾.럦.랾];
			ImGui.TextDisabled("Current Profile: " + ConfigFile.랾());
			ImGui.TextDisabled("Startup Profile: " + global::랾.럦.랩());
			ImGui.Separator();
			if (ImGui.Button("Load Selected"))
			{
				bool flag3 = ConfigFile.럒(text);
				if (flag3)
				{
					global::랾.랪.럯();
				}
				global::랾.럦.랾(flag3, "Loaded profile: " + text, "Failed to load profile.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Export Selected"))
			{
				string clipboardText;
				if (ConfigFile.랾(text, out clipboardText))
				{
					ImGui.SetClipboardText(clipboardText);
					global::랾.럽.랾("Exported profile: " + text, false);
				}
				else
				{
					global::랾.럽.람("Failed to export profile.", false);
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Delete Selected"))
			{
				bool flag4 = ConfigFile.럼(text);
				if (flag4 && global::랾.럦.랾 >= list.Count - 1)
				{
					global::랾.럦.랾 = Math.Max(0, list.Count - 2);
				}
				global::랾.럦.랾(flag4, "Deleted profile: " + text, "Failed to delete profile.");
			}
			ImGui.Separator();
			ImGui.TextDisabled("Rename and Duplicate use the Profile Name box above.");
			if (ImGui.Button("Rename Selected"))
			{
				global::랾.럦.랾(ConfigFile.럎(text, global::랾.럦.럐), "Renamed profile to: " + global::랾.럦.럐, "Failed to rename profile.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Duplicate Selected"))
			{
				global::랾.럦.랾(ConfigFile.람(text, global::랾.럦.럐), "Duplicated profile as: " + global::랾.럦.럐, "Failed to duplicate profile.");
			}
			ImGui.Separator();
			if (ImGui.Button("Set Selected As Startup"))
			{
				global::랾.럦.랾(ConfigFile.럙(text), "Startup profile set to: " + text, "Failed to set startup profile.");
			}
			if (!string.IsNullOrWhiteSpace(ConfigFile.startupProfileName))
			{
				ImGui.SameLine();
				if (ImGui.Button("Clear Startup"))
				{
					ConfigFile.랉();
					global::랾.럽.랾("Startup profile cleared.", false);
				}
			}
			ImGui.Separator();
			ImGui.TextDisabled("Export copies the selected profile JSON to your clipboard.");
			ImGui.TextDisabled("Import reads JSON from your clipboard and saves it under the profile name above.");
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0003EF97 File Offset: 0x0003D197
		private static void 랾(bool A_0, string A_1, string A_2)
		{
			if (A_0)
			{
				global::랾.럽.랾(A_1, false);
				return;
			}
			global::랾.럽.람(A_2, false);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0003EFAB File Offset: 0x0003D1AB
		private static string 랩()
		{
			if (!string.IsNullOrWhiteSpace(ConfigFile.startupProfileName))
			{
				return ConfigFile.startupProfileName;
			}
			return "None";
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0008F4AC File Offset: 0x0008D6AC
		private static void 램()
		{
			if (ConfigFile.defaultTheme)
			{
				global::랾.랁.랾();
				return;
			}
			if (ConfigFile.darkTheme)
			{
				global::랾.랁.럎();
				return;
			}
			if (ConfigFile.moonlightTheme)
			{
				global::랾.랁.람();
				return;
			}
			if (ConfigFile.cinderTheme)
			{
				global::랾.랁.럒();
				return;
			}
			if (ConfigFile.catppuccinTheme)
			{
				global::랾.랁.럼();
				return;
			}
			if (ConfigFile.purpleTheme)
			{
				global::랾.랁.랋();
				return;
			}
			if (ConfigFile.redTheme)
			{
				global::랾.랁.랉();
				return;
			}
			if (ConfigFile.whiteDressTheme)
			{
				global::랾.랁.럐();
				return;
			}
			if (ConfigFile.blackDressTheme)
			{
				global::랾.랁.랓();
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0008F530 File Offset: 0x0008D730
		private static int 랥()
		{
			if (ConfigFile.darkTheme)
			{
				return 1;
			}
			if (ConfigFile.moonlightTheme)
			{
				return 2;
			}
			if (ConfigFile.cinderTheme)
			{
				return 3;
			}
			if (ConfigFile.catppuccinTheme)
			{
				return 4;
			}
			if (ConfigFile.purpleTheme)
			{
				return 5;
			}
			if (ConfigFile.redTheme)
			{
				return 6;
			}
			if (ConfigFile.whiteDressTheme)
			{
				return 7;
			}
			if (ConfigFile.blackDressTheme)
			{
				return 8;
			}
			return 0;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0008F588 File Offset: 0x0008D788
		private static int 랕()
		{
			if (global::랾.럧.람 == null || global::랾.럧.람.Length == 0)
			{
				return -1;
			}
			int num = global::랾.럦.랥();
			if (num >= global::랾.럧.람.Length)
			{
				num = 0;
			}
			ConfigFile.selectedThemeIndex = num;
			return num;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
		private static int 럌()
		{
			if (global::랾.럧.랾 == null || global::랾.럧.랾.Length == 0)
			{
				return -1;
			}
			int num = ConfigFile.selectedAlbumIndex;
			if (num >= global::랾.럧.랾.Length)
			{
				num = 0;
				ConfigFile.selectedAlbumIndex = 0;
			}
			return num;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0008F5F8 File Offset: 0x0008D7F8
		private static void 럒(int A_0)
		{
			ConfigFile.selectedThemeIndex = A_0;
			ConfigFile.defaultTheme = (A_0 == 0);
			ConfigFile.darkTheme = (A_0 == 1);
			ConfigFile.moonlightTheme = (A_0 == 2);
			ConfigFile.cinderTheme = (A_0 == 3);
			ConfigFile.catppuccinTheme = (A_0 == 4);
			ConfigFile.purpleTheme = (A_0 == 5);
			ConfigFile.redTheme = (A_0 == 6);
			ConfigFile.whiteDressTheme = (A_0 == 7);
			ConfigFile.blackDressTheme = (A_0 == 8);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0003EFC4 File Offset: 0x0003D1C4
		private static void 랾(Action A_0, ref bool A_1)
		{
			A_0();
			global::랾.럦.랼();
			A_1 = true;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0003EFD4 File Offset: 0x0003D1D4
		private static void 랼()
		{
			global::랾.럧.랱 = false;
			global::랾.럧.럙 = false;
			global::랾.럧.랫 = false;
			global::랾.럧.럍 = false;
			global::랾.럧.랬 = false;
			global::랾.럧.란 = false;
			global::랾.럧.럇 = false;
			global::랾.럧.랯 = false;
			global::랾.럧.러 = false;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0008F65C File Offset: 0x0008D85C
		private static void 랣()
		{
			if (!ImGui.BeginTabItem("Tools"))
			{
				return;
			}
			global::랾.럦.람();
			ImGui.TextWrapped("Tools now groups the utility-style pages together so the top bar stays cleaner. Commands, packet work, and the mini map all live here now.");
			ImGui.Separator();
			if (ImGui.BeginTabBar("##ToolsTabs"))
			{
				try
				{
					if (ImGui.BeginTabItem("Utility"))
					{
						try
						{
							global::랾.럦.럂();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("Commands"))
					{
						try
						{
							global::랾.럦.랧();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("Packet Manipulator"))
					{
						try
						{
							global::랾.럦.럱();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
					if (ImGui.BeginTabItem("MiniMap"))
					{
						try
						{
							global::랾.럦.럥();
						}
						finally
						{
							ImGui.EndTabItem();
						}
					}
				}
				finally
				{
					ImGui.EndTabBar();
				}
			}
			ImGui.EndTabItem();
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0008F74C File Offset: 0x0008D94C
		private static void 럂()
		{
			if (ImGui.CollapsingHeader("Account"))
			{
				global::랾.럦.럁();
			}
			if (ImGui.CollapsingHeader("Shop"))
			{
				global::랾.랡.랾();
			}
			if (ImGui.CollapsingHeader("Block Data"))
			{
				global::랾.럦.럮();
			}
			if (ImGui.CollapsingHeader("Class Inspector"))
			{
				global::랾.럦.랭();
			}
			if (ImGui.CollapsingHeader("Data Editors"))
			{
				global::랾.럦.럪();
			}
			if (ImGui.CollapsingHeader("Packet Creator"))
			{
				global::랾.럦.럤();
			}
			if (global::랾.럧.럑 && ImGui.CollapsingHeader("Reporting [Dev]"))
			{
				global::랾.럦.럞();
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0003F00C File Offset: 0x0003D20C
		private static void 럱()
		{
			global::랾.랪.랾();
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0003F013 File Offset: 0x0003D213
		private static void 랧()
		{
			global::랾.랰.랾();
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0008F7D8 File Offset: 0x0008D9D8
		private static void 럁()
		{
			ImGui.TextWrapped("Some features may be missing this is to ensure there's little to no errors for release surrounding their new account creation system.");
			ImGui.SameLine();
			if (ImGui.Button("Reload World"))
			{
				global::랾.럓.랱();
				global::랾.럽.럒("Queued world reload.", false);
			}
			ImGui.SameLine();
			if (ImGui.Button("Reload Game"))
			{
				global::랾.럓.럙();
				global::랾.럽.럒("Queued game reload.", false);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0008F834 File Offset: 0x0008DA34
		private static void 럮()
		{
			ImGui.TextColored(new Vector4(1f, 0.4f, 0.4f, 1f), "Warning: May ban you. Use an alt.");
			if (global::랾.럓.랾 == null || global::랾.럓.랾 == null)
			{
				ImGui.Text("Unavailable.");
				return;
			}
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			WorldItemBase worldItemBase = global::랾.럦.랾(currentPlayerMapPoint);
			if (worldItemBase == null || worldItemBase.itemId == -1)
			{
				return;
			}
			if (ImGui.Button("Update Block"))
			{
				OutgoingMessages.SendWorldItemUpdateMessage(currentPlayerMapPoint, worldItemBase, 1);
				OutgoingMessages.SendWorldItemUpdateMessage(global::랾.럓.랾.currentPlayerBelowMapPoint, worldItemBase, 1);
				global::랾.럽.랾("Updated!", false);
			}
			global::랾.럦.랾(worldItemBase);
			global::랾.럦.럎(worldItemBase);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0008F8E0 File Offset: 0x0008DAE0
		private static void 랭()
		{
			ImGui.TextColored(new Vector4(1f, 0.4f, 0.4f, 1f), "Warning: May ban you. Use an alt.");
			ImGui.TextDisabled("Safety mode: field values are limited and property values are metadata-only to avoid IL2CPP render-time crashes.");
			ImGui.TextDisabled("Type suggestions are disabled for stability. Use an exact type name when possible.");
			ImGui.InputText("Class", ref global::랾.럧.럜, 100U);
			ImGui.InputText("Search", ref global::랾.럧.럽, 100U);
			if (string.IsNullOrWhiteSpace(global::랾.럧.럜))
			{
				ImGui.Text("Enter a class name.");
				return;
			}
			Type type = global::랾.럸.럎(global::랾.럧.럜);
			if (type == null)
			{
				ImGui.Text("Not found. Try the exact type name.");
				return;
			}
			ImGui.TextDisabled(type.FullName + " [" + type.Assembly.GetName().Name + "]");
			if (ImGui.CollapsingHeader("Properties", 32))
			{
				global::랾.럸.럎(type);
			}
			if (ImGui.CollapsingHeader("Methods"))
			{
				global::랾.럸.람(type);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0008F9D0 File Offset: 0x0008DBD0
		private static void 럪()
		{
			ImGui.Checkbox("BSON Logger", ref ConfigFile.bsonInGameLoggerToggle);
			ImGui.Checkbox("Chat Logger", ref ConfigFile.chatLoggerToggle);
			global::랾.러.랾("FRQ Cooldown Removal", ref ConfigFile.removeFrequencyCooldownToggle);
			ImGui.Checkbox("Trade Info", ref ConfigFile.otherPlayerTradeInfoToggle);
			ImGui.Separator();
			ImGui.Checkbox("Bottle Data", ref ConfigFile.bottleDataToggle);
			ImGui.Checkbox("Fish Trophy Data", ref ConfigFile.fishTrophyDataToggle);
			ImGui.Checkbox("Pet Data", ref ConfigFile.petDataToggle);
			global::랾.러.랾("Pickaxe Data", ref ConfigFile.durabilityChangerToggle);
			ImGui.Checkbox("Trophy Data", ref ConfigFile.trophyDataToggle);
			if (ConfigFile.bottleDataToggle)
			{
				ImGui.Separator();
				ImGui.InputText("World", ref global::랾.럧.랦, 100000U);
				ImGui.InputText("Title", ref global::랾.럧.랞, 100000U);
				ImGui.InputText("Sender", ref global::랾.럧.럔, 100000U);
				ImGui.InputText("Message", ref global::랾.럧.럚, 100000U);
				ImGui.InputInt("Day", ref global::랾.럧.럍);
				ImGui.InputInt("Month", ref global::랾.럧.랬);
				ImGui.InputInt("Year", ref global::랾.럧.란);
				if (ImGui.Button("Image Tool"))
				{
					Application.OpenURL("https://speedychuck.com/ImageToPw.html");
					return;
				}
			}
			else
			{
				if (ConfigFile.durabilityChangerToggle)
				{
					ImGui.Separator();
					ImGui.InputInt("Durability", ref global::랾.럧.랠);
					return;
				}
				if (ConfigFile.fishTrophyDataToggle)
				{
					ImGui.Separator();
					ImGui.InputText("Name", ref global::랾.럧.럻, 100000U);
					ImGui.InputFloat("Weight", ref global::랾.럧.럙);
					ImGui.InputInt("Day", ref global::랾.럧.량);
					ImGui.InputInt("Month", ref global::랾.럧.럑);
					ImGui.InputInt("Year", ref global::랾.럧.럊);
					return;
				}
				if (ConfigFile.petDataToggle)
				{
					ImGui.Separator();
					ImGui.InputText("Name", ref global::랾.럧.럩, 16U);
					ImGui.InputInt("Level", ref global::랾.럧.랓);
					ImGui.InputInt("Day", ref global::랾.럧.럯);
					ImGui.InputInt("Month", ref global::랾.럧.럭);
					ImGui.InputInt("Year", ref global::랾.럧.랱);
					return;
				}
				if (ConfigFile.trophyDataToggle)
				{
					ImGui.Separator();
					ImGui.InputText("Winner", ref global::랾.럧.럳, 100000U);
					ImGui.InputText("World", ref global::랾.럧.랢, 100000U);
					ImGui.InputInt("Day", ref global::랾.럧.럇);
					ImGui.InputInt("Month", ref global::랾.럧.랯);
					ImGui.InputInt("Year", ref global::랾.럧.러);
				}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0008FC64 File Offset: 0x0008DE64
		private static void 럤()
		{
			if (ImGui.SmallButton(global::랾.럦.랋 ? "Hide Help" : "? Help"))
			{
				global::랾.럦.랋 = !global::랾.럦.랋;
			}
			if (global::랾.럦.랋)
			{
				ImGui.BeginChild("##pkthelp", new Vector2(0f, 140f), 1);
				ImGui.TextColored(new Vector4(1f, 0.8f, 0.3f, 1f), "How to use:");
				ImGui.Separator();
				ImGui.Text("Row 1 = packet ID (SB, GGBI, mP, etc.)");
				ImGui.Text("Other rows = key-value pairs.");
				ImGui.Text("Auto-types: int, double, bool, string.");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "Variables:");
				ImGui.BulletText("playerposx / playerposy (+/- offsets)");
				ImGui.BulletText("worldname / playerid / playername");
				ImGui.EndChild();
			}
			ImGui.Separator();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Fields: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럦.럎);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.SameLine();
			if (ImGui.SmallButton("+") && global::랾.럦.럎 < 8)
			{
				global::랾.럦.럎++;
			}
			ImGui.SameLine();
			if (ImGui.SmallButton("-") && global::랾.럦.럎 > 1)
			{
				global::랾.럦.럎--;
			}
			ImGui.Separator();
			for (int i = 0; i < global::랾.럦.럎; i++)
			{
				ImGui.PushItemWidth(120f);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("##k");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(i);
				ImGui.InputTextWithHint(defaultInterpolatedStringHandler2.ToStringAndClear(), (i == 0) ? "e.g. SB" : "key", ref global::랾.럧.럒[i], 100U);
				ImGui.PopItemWidth();
				ImGui.SameLine();
				string str = global::랾.럦.럐(global::랾.럧.럼[i]);
				ImGui.TextDisabled("[" + str + "]");
				ImGui.SameLine();
				ImGui.PushItemWidth(ImGui.GetContentRegionAvail().X);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler3.AppendLiteral("##v");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(i);
				ImGui.InputTextWithHint(defaultInterpolatedStringHandler3.ToStringAndClear(), (i == 0) ? "ID value" : "value", ref global::랾.럧.럼[i], 200U);
				ImGui.PopItemWidth();
			}
			ImGui.Separator();
			if (ImGui.Button("Send"))
			{
				BSONObject bsonobject = global::랾.럦.랍();
				if (bsonobject != null)
				{
					OutgoingMessages.AddOneMessageToList(bsonobject);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler4.AppendLiteral("Sent (");
					defaultInterpolatedStringHandler4.AppendFormatted<int>(bsonobject.mMap.Count);
					defaultInterpolatedStringHandler4.AppendLiteral(" fields)");
					global::랾.럦.랓 = defaultInterpolatedStringHandler4.ToStringAndClear();
					global::랾.럦.랾 = 3f;
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Preview"))
			{
				BSONObject bsonobject2 = global::랾.럦.랍();
				if (bsonobject2 != null)
				{
					global::랾.럽.랉(bsonobject2, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					global::랾.럦.랓 = "Previewed.";
					global::랾.럦.랾 = 3f;
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Clear"))
			{
				for (int j = 0; j < 8; j++)
				{
					global::랾.럧.럒[j] = string.Empty;
					global::랾.럧.럼[j] = string.Empty;
				}
				global::랾.럦.랓 = "Cleared.";
				global::랾.럦.랾 = 3f;
			}
			ImGui.SameLine();
			if (ImGui.BeginCombo("##pre", "Presets"))
			{
				if (ImGui.Selectable("Set Block"))
				{
					global::랾.럦.랾(new ValueTuple<string, string>[]
					{
						new ValueTuple<string, string>("ID", "SB"),
						new ValueTuple<string, string>("x", "playerposx"),
						new ValueTuple<string, string>("y", "playerposy"),
						new ValueTuple<string, string>("BlockType", "0")
					});
				}
				if (ImGui.Selectable("Gift Box"))
				{
					global::랾.럦.랾(new ValueTuple<string, string>[]
					{
						new ValueTuple<string, string>("ID", "GGBI"),
						new ValueTuple<string, string>("x", "playerposx"),
						new ValueTuple<string, string>("y", "playerposy")
					});
				}
				if (ImGui.Selectable("Portal In"))
				{
					global::랾.럦.랾(new ValueTuple<string, string>[]
					{
						new ValueTuple<string, string>("ID", "PAiP"),
						new ValueTuple<string, string>("x", "playerposx"),
						new ValueTuple<string, string>("y", "playerposy")
					});
				}
				if (ImGui.Selectable("Portal Out"))
				{
					global::랾.럦.랾(new ValueTuple<string, string>[]
					{
						new ValueTuple<string, string>("ID", "PAoP"),
						new ValueTuple<string, string>("x", "playerposx"),
						new ValueTuple<string, string>("y", "playerposy")
					});
				}
				if (ImGui.Selectable("Hit Block"))
				{
					global::랾.럦.랾(new ValueTuple<string, string>[]
					{
						new ValueTuple<string, string>("ID", "HB"),
						new ValueTuple<string, string>("x", "playerposx"),
						new ValueTuple<string, string>("y", "playerposy")
					});
				}
				ImGui.EndCombo();
			}
			if (global::랾.럦.랾 > 0f)
			{
				global::랾.럦.랾 -= Time.deltaTime;
				ImGui.TextColored(new Vector4(0.5f, 1f, 0.5f, 1f), global::랾.럦.랓);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000901F0 File Offset: 0x0008E3F0
		private static BSONObject 랍()
		{
			if (string.IsNullOrEmpty(global::랾.럧.럒[0]) || string.IsNullOrEmpty(global::랾.럧.럼[0]))
			{
				global::랾.럦.랓 = "First row required.";
				global::랾.럦.랾 = 3f;
				return null;
			}
			BSONObject bsonobject = new BSONObject();
			for (int i = 0; i < global::랾.럦.럎; i++)
			{
				if (!string.IsNullOrEmpty(global::랾.럧.럒[i]))
				{
					BSONValue bsonvalue = bsonobject;
					string text = global::랾.럧.럒[i].Trim();
					string text2 = global::랾.럧.럼[i];
					bsonvalue[text] = global::랾.럦.랋(((text2 != null) ? text2.Trim() : null) ?? string.Empty);
				}
			}
			return bsonobject;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00090288 File Offset: 0x0008E488
		private static BSONValue 랋(string A_0)
		{
			if (string.IsNullOrEmpty(A_0))
			{
				return new BSONValue(string.Empty);
			}
			bool flag;
			if (bool.TryParse(A_0, out flag))
			{
				return new BSONValue(flag);
			}
			int num;
			if (int.TryParse(A_0, out num))
			{
				return new BSONValue(num);
			}
			double num2;
			if (double.TryParse(A_0, out num2))
			{
				return new BSONValue(num2);
			}
			string text = A_0.ToLowerInvariant();
			if (text.StartsWith("playerposx") || text.StartsWith("playerposy"))
			{
				return new BSONValue(global::랾.럦.랉(text));
			}
			if (text == "worldname")
			{
				World world = global::랾.럓.랾;
				return new BSONValue(((world != null) ? world.worldName : null) ?? string.Empty);
			}
			if (text == "playerid")
			{
				PlayerData playerData = global::랾.럓.랾;
				return new BSONValue(((playerData != null) ? playerData.playerId : null) ?? string.Empty);
			}
			if (text == "playername")
			{
				return new BSONValue(StaticPlayer.theRealPlayername ?? string.Empty);
			}
			return new BSONValue(A_0);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0009038C File Offset: 0x0008E58C
		private static double 랉(string A_0)
		{
			double num = (double)(A_0.Contains("playerposx") ? global::랾.럓.랾.currentPlayerMapPoint.x : global::랾.럓.랾.currentPlayerMapPoint.y);
			if (A_0.Contains("+"))
			{
				string[] array = A_0.Split('+', StringSplitOptions.None);
				double num2;
				if (array.Length == 2 && double.TryParse(array[1].Trim(), out num2))
				{
					return num + num2;
				}
			}
			else if (A_0.Contains("-") && A_0.IndexOf('-') > 0)
			{
				string[] array2 = A_0.Split('-', StringSplitOptions.None);
				double num3;
				if (array2.Length == 2 && double.TryParse(array2[1].Trim(), out num3))
				{
					return num - num3;
				}
			}
			return num;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0009043C File Offset: 0x0008E63C
		private static string 럐(string A_0)
		{
			if (string.IsNullOrEmpty(A_0))
			{
				return "empty";
			}
			bool flag;
			if (bool.TryParse(A_0, out flag))
			{
				return "bool";
			}
			int num;
			if (int.TryParse(A_0, out num))
			{
				return "int";
			}
			double num2;
			if (double.TryParse(A_0, out num2))
			{
				return "dbl";
			}
			string text = A_0.ToLowerInvariant();
			if (text.StartsWith("playerpos"))
			{
				return "pos";
			}
			if (text == "worldname" || text == "playerid" || text == "playername")
			{
				return "var";
			}
			return "str";
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000904D4 File Offset: 0x0008E6D4
		private static void 랾([TupleElementNames(new string[]
		{
			"key",
			"value"
		})] params ValueTuple<string, string>[] fields)
		{
			for (int i = 0; i < 8; i++)
			{
				global::랾.럧.럒[i] = ((i < fields.Length) ? fields[i].Item1 : string.Empty);
				global::랾.럧.럼[i] = ((i < fields.Length) ? fields[i].Item2 : string.Empty);
			}
			global::랾.럦.럎 = Math.Max(fields.Length, 2);
			global::랾.럦.랓 = "Preset loaded.";
			global::랾.럦.랾 = 3f;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00090550 File Offset: 0x0008E750
		private static void 럞()
		{
			ImGui.InputText("Player ID", ref global::랾.럧.럈, 100U);
			ImGui.InputText("World", ref global::랾.럧.럧, 100U);
			ImGui.InputText("Message", ref global::랾.럧.랊, 100U);
			ImGui.InputText("Reason", ref global::랾.럧.럓, 100U);
			if (ImGui.Button("Submit Report"))
			{
				OutgoingMessages.ChatReport(global::랾.럓.랾.myPlayerData.playerId, global::랾.럧.럈, global::랾.럧.랊, global::랾.럧.럧, global::랾.럧.럓, string.Empty);
				global::랾.럽.랾("Reported: " + global::랾.럧.럈, false);
			}
			ImGui.Text("This will submit fake reports of a player sending your specified message to the moderators and admins.");
			ImGui.Text("Be careful when using this, as submitting too many reports may get your account flagged and make sure the player ID and world is correct.");
			ImGui.Text("For the reason choose Offensive Language you may choose other categories but ensure the spelling is correct.");
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00090614 File Offset: 0x0008E814
		private static WorldItemBase 랾(Vector2i A_0, World.BlockType A_1)
		{
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return null;
			}
			WorldItemBase worldItemData = global::랾.럓.랾.GetWorldItemData(A_0);
			if (worldItemData == null)
			{
				return null;
			}
			if (A_1 <= 1994)
			{
				if (A_1 <= 590)
				{
					if (A_1 <= 234)
					{
						if (A_1 <= 120)
						{
							if (A_1 <= 76)
							{
								if (A_1 == 74)
								{
									return worldItemData.TryCast<SignData>();
								}
								if (A_1 == 76)
								{
									return worldItemData.TryCast<DoorData>();
								}
							}
							else
							{
								if (A_1 == 99)
								{
									return worldItemData.TryCast<GlassDoorData>();
								}
								switch (A_1)
								{
								case 110:
									return worldItemData.TryCast<EntrancePortalData>();
								case 111:
								case 113:
									break;
								case 112:
									return worldItemData.TryCast<LEDSignData>();
								case 114:
									return worldItemData.TryCast<DungeonDoorData>();
								default:
									if (A_1 == 120)
									{
										return worldItemData.TryCast<HugeMetalFanData>();
									}
									break;
								}
							}
						}
						else if (A_1 <= 135)
						{
							if (A_1 == 125)
							{
								return worldItemData.TryCast<CastleDoorData>();
							}
							if (A_1 == 135)
							{
								return worldItemData.TryCast<SafeData>();
							}
						}
						else
						{
							if (A_1 == 155)
							{
								return worldItemData.TryCast<BarnDoorData>();
							}
							if (A_1 == 227)
							{
								return worldItemData.TryCast<ScifiDoorData>();
							}
							if (A_1 == 234)
							{
								return worldItemData.TryCast<GravestoneData>();
							}
						}
					}
					else if (A_1 <= 277)
					{
						if (A_1 <= 264)
						{
							if (A_1 == 236)
							{
								return worldItemData.TryCast<DiplomaData>();
							}
							if (A_1 == 264)
							{
								return worldItemData.TryCast<BookPodiumData>();
							}
						}
						else
						{
							if (A_1 == 271)
							{
								return worldItemData.TryCast<NoteBoardData>();
							}
							if (A_1 == 272)
							{
								return worldItemData.TryCast<GlassDoorTintedData>();
							}
							if (A_1 == 277)
							{
								return worldItemData.TryCast<HelloBotData>();
							}
						}
					}
					else if (A_1 <= 305)
					{
						if (A_1 == 279)
						{
							return worldItemData.TryCast<ArrowSignData>();
						}
						switch (A_1)
						{
						case 293:
							return worldItemData.TryCast<ScoreBoardData>();
						case 294:
							return worldItemData.TryCast<MagicCauldronData>();
						case 295:
							return worldItemData.TryCast<VortexPortalData>();
						default:
							if (A_1 == 305)
							{
								return worldItemData.TryCast<AmateurRadioData>();
							}
							break;
						}
					}
					else
					{
						if (A_1 == 329)
						{
							return worldItemData.TryCast<PortalData>();
						}
						if (A_1 == 336)
						{
							return worldItemData.TryCast<WhiteboardData>();
						}
						if (A_1 == 590)
						{
							return worldItemData.TryCast<BonusDoorVIPData>();
						}
					}
				}
				else if (A_1 <= 1371)
				{
					if (A_1 <= 1125)
					{
						if (A_1 <= 649)
						{
							if (A_1 == 648)
							{
								return worldItemData.TryCast<HatchWoodenData>();
							}
							if (A_1 == 649)
							{
								return worldItemData.TryCast<HatchMetalData>();
							}
						}
						else
						{
							if (A_1 == 785)
							{
								return worldItemData.TryCast<QuestNPCData>();
							}
							if (A_1 == 966)
							{
								return worldItemData.TryCast<GiftBoxData>();
							}
							if (A_1 == 1125)
							{
								return worldItemData.TryCast<FAMFoodMachineData>();
							}
						}
					}
					else if (A_1 <= 1355)
					{
						if (A_1 == 1126)
						{
							return worldItemData.TryCast<FAMEvolveratorData>();
						}
						if (A_1 == 1133)
						{
							return worldItemData.TryCast<BattleBarrierBasicData>();
						}
						if (A_1 == 1355)
						{
							return worldItemData.TryCast<BattleBarrierBonesData>();
						}
					}
					else
					{
						if (A_1 == 1363)
						{
							return worldItemData.TryCast<HeadstoneData>();
						}
						if (A_1 == 1364)
						{
							return worldItemData.TryCast<CelticCrossData>();
						}
						if (A_1 == 1371)
						{
							return worldItemData.TryCast<AIEnemySpawnerBasicData>();
						}
					}
				}
				else if (A_1 <= 1482)
				{
					if (A_1 <= 1399)
					{
						if (A_1 == 1398)
						{
							return worldItemData.TryCast<TreasureSpawnerData>();
						}
						if (A_1 == 1399)
						{
							return worldItemData.TryCast<CheckPointSpawnerData>();
						}
					}
					else
					{
						if (A_1 == 1451)
						{
							return worldItemData.TryCast<GingerbreadSignData>();
						}
						if (A_1 == 1481)
						{
							return worldItemData.TryCast<AnniversaryPortalData>();
						}
						if (A_1 == 1482)
						{
							return worldItemData.TryCast<VendorNPCData>();
						}
					}
				}
				else if (A_1 <= 1596)
				{
					if (A_1 == 1504)
					{
						return worldItemData.TryCast<NetherSignData>();
					}
					if (A_1 == 1568)
					{
						return worldItemData.TryCast<InfoNPCData>();
					}
					if (A_1 == 1596)
					{
						return worldItemData.TryCast<PortalWOTWData>();
					}
				}
				else
				{
					if (A_1 == 1799)
					{
						return worldItemData.TryCast<NetherGroupPortalData>();
					}
					if (A_1 == 1922)
					{
						return worldItemData.TryCast<RecyclerBasicData>();
					}
					if (A_1 == 1994)
					{
						return worldItemData.TryCast<LabEnterPortalData>();
					}
				}
			}
			else if (A_1 <= 3152)
			{
				if (A_1 <= 2402)
				{
					if (A_1 <= 2087)
					{
						if (A_1 <= 2001)
						{
							if (A_1 == 1995)
							{
								return worldItemData.TryCast<LabExitPortalData>();
							}
							if (A_1 == 2001)
							{
								return worldItemData.TryCast<BluePortalData>();
							}
						}
						else
						{
							if (A_1 == 2008)
							{
								return worldItemData.TryCast<GravityModifierData>();
							}
							if (A_1 == 2065)
							{
								return worldItemData.TryCast<BattleBarrierLabData>();
							}
							if (A_1 == 2087)
							{
								return worldItemData.TryCast<QuantumSafeData>();
							}
						}
					}
					else if (A_1 <= 2166)
					{
						if (A_1 == 2146)
						{
							return worldItemData.TryCast<DisplayBlockData>();
						}
						if (A_1 == 2166)
						{
							return worldItemData.TryCast<MannequinData>();
						}
					}
					else
					{
						switch (A_1)
						{
						case 2203:
							return worldItemData.TryCast<DoorLevelVIPData>();
						case 2204:
							return worldItemData.TryCast<DoorLevelData>();
						case 2205:
							return worldItemData.TryCast<DoorVIPData>();
						case 2206:
							return worldItemData.TryCast<HatchLevelVIPData>();
						case 2207:
							return worldItemData.TryCast<HatchLevelData>();
						case 2208:
							return worldItemData.TryCast<HatchVIPData>();
						default:
							if (A_1 == 2258)
							{
								return worldItemData.TryCast<FantasyWellData>();
							}
							if (A_1 == 2402)
							{
								return worldItemData.TryCast<HugeMetalFanRedData>();
							}
							break;
						}
					}
				}
				else if (A_1 <= 2904)
				{
					if (A_1 <= 2623)
					{
						if (A_1 == 2612)
						{
							return worldItemData.TryCast<DungeonDoorWhiteData>();
						}
						if (A_1 == 2623)
						{
							return worldItemData.TryCast<AnniversaryRadioData>();
						}
					}
					else
					{
						if (A_1 == 2693)
						{
							return worldItemData.TryCast<HeartSignData>();
						}
						if (A_1 == 2766)
						{
							return worldItemData.TryCast<TutorialSleepPodData>();
						}
						if (A_1 == 2904)
						{
							return worldItemData.TryCast<TutorialCablePortalData>();
						}
					}
				}
				else if (A_1 <= 3090)
				{
					if (A_1 == 2992)
					{
						return worldItemData.TryCast<RiftPortalData>();
					}
					if (A_1 == 3052)
					{
						return worldItemData.TryCast<AdTVData>();
					}
					if (A_1 == 3090)
					{
						return worldItemData.TryCast<MessagingComputerData>();
					}
				}
				else
				{
					switch (A_1)
					{
					case 3098:
						return worldItemData.TryCast<WiringTriggerSwitchData>();
					case 3099:
						return worldItemData.TryCast<WiringTriggerButtonData>();
					case 3100:
						return worldItemData.TryCast<WiringTriggerLeverData>();
					case 3101:
						return worldItemData.TryCast<WiringTriggerPressurePadData>();
					case 3102:
						return worldItemData.TryCast<WiringTriggerProximitySensorData>();
					default:
						if (A_1 == 3112)
						{
							return worldItemData.TryCast<DisappearingBlockData>();
						}
						switch (A_1)
						{
						case 3148:
							return worldItemData.TryCast<WiringTriggerButtonScifiData>();
						case 3149:
							return worldItemData.TryCast<WiringTriggerPushButtonData>();
						case 3150:
							return worldItemData.TryCast<WiringTriggerGroundLeverWoodenData>();
						case 3151:
							return worldItemData.TryCast<WiringTriggerSwitchScifiData>();
						case 3152:
							return worldItemData.TryCast<WiringTriggerPowerSwitchData>();
						}
						break;
					}
				}
			}
			else if (A_1 <= 3887)
			{
				if (A_1 <= 3559)
				{
					if (A_1 <= 3222)
					{
						if (A_1 == 3168)
						{
							return worldItemData.TryCast<WiringTriggerButtonStoneData>();
						}
						if (A_1 == 3222)
						{
							return worldItemData.TryCast<GreenParrotData>();
						}
					}
					else
					{
						if (A_1 == 3437)
						{
							return worldItemData.TryCast<ColorOMatData>();
						}
						if (A_1 == 3438)
						{
							return worldItemData.TryCast<PortalPasswordData>();
						}
						if (A_1 == 3559)
						{
							return worldItemData.TryCast<DoorClanData>();
						}
					}
				}
				else if (A_1 <= 3639)
				{
					switch (A_1)
					{
					case 3600:
						return worldItemData.TryCast<PortalFactionDarkData>();
					case 3601:
						return worldItemData.TryCast<PortalFactionLightData>();
					case 3602:
						return worldItemData.TryCast<DoorFactionDarkData>();
					case 3603:
						return worldItemData.TryCast<DoorFactionLightData>();
					case 3604:
						return worldItemData.TryCast<DonationBoxData>();
					case 3605:
						return worldItemData.TryCast<GuestBookData>();
					default:
						switch (A_1)
						{
						case 3628:
							return worldItemData.TryCast<WiringTriggerPressurePadSecretData>();
						case 3629:
							return worldItemData.TryCast<DisappearingBlockSecret01Data>();
						case 3630:
							return worldItemData.TryCast<DisappearingBlockSecret02Data>();
						case 3631:
							return worldItemData.TryCast<DisappearingBlockSecret03Data>();
						default:
							if (A_1 == 3639)
							{
								return worldItemData.TryCast<DonationBoxValentinesData>();
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (A_1 == 3677)
					{
						return worldItemData.TryCast<LoreBotData>();
					}
					if (A_1 == 3678)
					{
						return worldItemData.TryCast<LoreSignData>();
					}
					switch (A_1)
					{
					case 3883:
						return worldItemData.TryCast<WiringTriggerPressurePadCustomData>();
					case 3886:
						return worldItemData.TryCast<WiringTriggerPuzzleLoreLightData>();
					case 3887:
						return worldItemData.TryCast<WiringTriggerPuzzleLoreDarkData>();
					}
				}
			}
			else if (A_1 <= 4373)
			{
				if (A_1 <= 4103)
				{
					switch (A_1)
					{
					case 3964:
						return worldItemData.TryCast<PortalCrypticData>();
					case 3965:
						return worldItemData.TryCast<PortalPixelMinesData>();
					case 3966:
						return worldItemData.TryCast<PortalMineExitData>();
					default:
						if (A_1 == 4103)
						{
							return worldItemData.TryCast<PortalMiningEntryData>();
						}
						break;
					}
				}
				else
				{
					if (A_1 == 4277)
					{
						return worldItemData.TryCast<HelloBotSkeletonData>();
					}
					if (A_1 == 4286)
					{
						return worldItemData.TryCast<JetRaceForcefieldStartData>();
					}
					if (A_1 == 4373)
					{
						return worldItemData.TryCast<JetRaceGroupPortalData>();
					}
				}
			}
			else if (A_1 <= 4549)
			{
				if (A_1 == 4475)
				{
					return worldItemData.TryCast<GuestBookAnniversaryData>();
				}
				if (A_1 == 4476)
				{
					return worldItemData.TryCast<LoreBotLeftData>();
				}
				switch (A_1)
				{
				case 4546:
					return worldItemData.TryCast<ForSaleSignData>();
				case 4548:
					return worldItemData.TryCast<WoodenSignPlanksData>();
				case 4549:
					return worldItemData.TryCast<RoadMarkerStoneData>();
				}
			}
			else
			{
				if (A_1 == 4584)
				{
					return worldItemData.TryCast<SignLocalizedData>();
				}
				if (A_1 == 4649)
				{
					return worldItemData.TryCast<SignSwitchableTextWoodenData>();
				}
				if (A_1 == 4863)
				{
					return worldItemData.TryCast<AnniversaryDisplayBlockData>();
				}
			}
			return (worldItemData != null && worldItemData.GetType() != typeof(WorldItemBase)) ? worldItemData : null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000911D4 File Offset: 0x0008F3D4
		private static WorldItemBase 럎(Vector2i A_0, World.BlockType A_1)
		{
			if (global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_0))
			{
				return null;
			}
			WorldItemBase worldItemData = global::랾.럓.랾.GetWorldItemData(A_0);
			if (worldItemData == null)
			{
				return null;
			}
			if (A_1 <= 882)
			{
				if (A_1 <= 111)
				{
					if (A_1 == 109)
					{
						return worldItemData.TryCast<SpikeTrapData>();
					}
					if (A_1 == 111)
					{
						return worldItemData.TryCast<FireTrapData>();
					}
				}
				else
				{
					switch (A_1)
					{
					case 410:
						return worldItemData.TryCast<LockSmallData>();
					case 411:
						return worldItemData.TryCast<LockMediumData>();
					case 412:
						return worldItemData.TryCast<LockLargeData>();
					case 413:
						return worldItemData.TryCast<LockWorldData>();
					default:
						if (A_1 == 882)
						{
							return worldItemData.TryCast<LockWorldDarkData>();
						}
						break;
					}
				}
			}
			else if (A_1 <= 1132)
			{
				if (A_1 == 957)
				{
					return worldItemData.TryCast<PoisonTrapData>();
				}
				if (A_1 == 1132)
				{
					return worldItemData.TryCast<LockBattleData>();
				}
			}
			else
			{
				if (A_1 == 2007)
				{
					return worldItemData.TryCast<LaserBeamTrapData>();
				}
				if (A_1 == 2212)
				{
					return worldItemData.TryCast<LockWorldNoobData>();
				}
			}
			return null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000912F0 File Offset: 0x0008F4F0
		public static WorldItemBase 랾(Vector2i A_0)
		{
			WorldItemBase worldItemBase = global::랾.럦.랾(A_0, global::랾.럓.랾.GetBlockType(A_0));
			if (worldItemBase != null)
			{
				return worldItemBase;
			}
			Vector2i currentPlayerBelowMapPoint = global::랾.럓.랾.currentPlayerBelowMapPoint;
			WorldItemBase worldItemBase2 = global::랾.럦.럎(currentPlayerBelowMapPoint, global::랾.럓.랾.GetBlockType(currentPlayerBelowMapPoint));
			if (worldItemBase2 != null)
			{
				return worldItemBase2;
			}
			return new WorldItemBase(-1, 0);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00091340 File Offset: 0x0008F540
		private static void 랾(WorldItemBase A_0)
		{
			foreach (PropertyInfo propertyInfo in A_0.GetType().GetProperties())
			{
				if (propertyInfo.CanWrite && !(propertyInfo.Name == "isBattleOnKey") && !(propertyInfo.Name == "isBattleOn"))
				{
					if (propertyInfo.PropertyType == typeof(string))
					{
						string value = (string)propertyInfo.GetValue(A_0);
						ImGui.Text("Str: " + propertyInfo.Name);
						ImGui.InputText("##" + propertyInfo.Name, ref value, 1000000U);
						propertyInfo.SetValue(A_0, value);
					}
					else if (propertyInfo.PropertyType == typeof(int))
					{
						int num = (int)propertyInfo.GetValue(A_0);
						ImGui.Text("Int: " + propertyInfo.Name);
						ImGui.InputInt("##" + propertyInfo.Name, ref num);
						propertyInfo.SetValue(A_0, num);
					}
					else if (propertyInfo.PropertyType == typeof(float))
					{
						float num2 = (float)propertyInfo.GetValue(A_0);
						ImGui.Text("Float: " + propertyInfo.Name);
						ImGui.InputFloat("##" + propertyInfo.Name, ref num2);
						propertyInfo.SetValue(A_0, num2);
					}
					else if (propertyInfo.PropertyType == typeof(long))
					{
						long num3 = (long)propertyInfo.GetValue(A_0);
						int num4 = (num3 >= -2147483648L && num3 <= 2147483647L) ? ((int)num3) : int.MaxValue;
						ImGui.Text("Long: " + propertyInfo.Name);
						ImGui.InputInt("##" + propertyInfo.Name, ref num4);
						propertyInfo.SetValue(A_0, (long)num4);
					}
					else if (propertyInfo.PropertyType == typeof(bool))
					{
						bool flag = (bool)propertyInfo.GetValue(A_0);
						ImGui.Checkbox(propertyInfo.Name + "##" + propertyInfo.Name, ref flag);
						propertyInfo.SetValue(A_0, flag);
					}
					else if (propertyInfo.PropertyType == typeof(World.BlockType))
					{
						int num5 = (World.BlockType)propertyInfo.GetValue(A_0);
						ImGui.Text("Block: " + propertyInfo.Name);
						if (ImGui.InputInt("##" + propertyInfo.Name, ref num5))
						{
							propertyInfo.SetValue(A_0, num5);
						}
					}
					else if (propertyInfo.PropertyType == typeof(BlockDirection))
					{
						int num6 = (BlockDirection)propertyInfo.GetValue(A_0);
						ImGui.Text("Dir: " + propertyInfo.Name);
						if (ImGui.InputInt("##" + propertyInfo.Name, ref num6))
						{
							propertyInfo.SetValue(A_0, num6);
						}
					}
					else if (propertyInfo.PropertyType == typeof(BSONObject))
					{
						BSONObject bsonobject = (BSONObject)propertyInfo.GetValue(A_0);
						if (ImGui.TreeNode("##" + propertyInfo.Name))
						{
							global::랾.럽.랾(bsonobject);
							ImGui.TreePop();
						}
						propertyInfo.SetValue(A_0, bsonobject);
					}
				}
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000916CC File Offset: 0x0008F8CC
		private static void 럎(WorldItemBase A_0)
		{
			foreach (MethodInfo methodInfo in A_0.GetType().GetMethods())
			{
				if (!methodInfo.IsSpecialName && methodInfo.IsPublic && !global::랾.럦.랾.Contains(methodInfo.Name))
				{
					ImGui.Text("Method: " + methodInfo.Name);
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != 0)
					{
						if (!global::랾.럧.랾.ContainsKey(methodInfo.Name))
						{
							global::랾.럧.랾[methodInfo.Name] = new object[parameters.Length];
						}
						for (int j = 0; j < parameters.Length; j++)
						{
							ParameterInfo parameterInfo = parameters[j];
							ImGui.Text(parameterInfo.Name + " (" + parameterInfo.ParameterType.Name + ")");
							if (parameterInfo.ParameterType == typeof(string))
							{
								string text = (global::랾.럧.랾[methodInfo.Name][j] as string) ?? string.Empty;
								ImGui.InputText("##" + methodInfo.Name + "_" + parameterInfo.Name, ref text, 100U);
								global::랾.럧.랾[methodInfo.Name][j] = text;
							}
							else if (parameterInfo.ParameterType == typeof(int))
							{
								object obj = global::랾.럧.랾[methodInfo.Name][j];
								int num2;
								if (obj is int)
								{
									int num = (int)obj;
									num2 = num;
								}
								else
								{
									num2 = 0;
								}
								int num3 = num2;
								ImGui.InputInt("##" + methodInfo.Name + "_" + parameterInfo.Name, ref num3);
								global::랾.럧.랾[methodInfo.Name][j] = num3;
							}
							else if (parameterInfo.ParameterType == typeof(float))
							{
								object obj = global::랾.럧.랾[methodInfo.Name][j];
								float num5;
								if (obj is float)
								{
									float num4 = (float)obj;
									num5 = num4;
								}
								else
								{
									num5 = 0f;
								}
								float num6 = num5;
								ImGui.InputFloat("##" + methodInfo.Name + "_" + parameterInfo.Name, ref num6);
								global::랾.럧.랾[methodInfo.Name][j] = num6;
							}
							else if (parameterInfo.ParameterType == typeof(bool))
							{
								object obj = global::랾.럧.랾[methodInfo.Name][j];
								bool flag;
								bool flag2;
								if (obj is bool)
								{
									flag = (bool)obj;
									flag2 = true;
								}
								else
								{
									flag2 = false;
								}
								bool flag3 = flag2 && flag;
								ImGui.Checkbox("##" + methodInfo.Name + "_" + parameterInfo.Name, ref flag3);
								global::랾.럧.랾[methodInfo.Name][j] = flag3;
							}
						}
					}
					if (ImGui.Button("Run##" + methodInfo.Name))
					{
						try
						{
							object obj2 = methodInfo.Invoke(A_0, (parameters.Length != 0) ? global::랾.럧.랾[methodInfo.Name] : null);
							BSONObject bsonobject = obj2 as BSONObject;
							if (bsonobject != null)
							{
								global::랾.럽.랉(bsonobject, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
							}
							else if (obj2 != null)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
								defaultInterpolatedStringHandler.AppendLiteral("Result: ");
								defaultInterpolatedStringHandler.AppendFormatted<object>(obj2);
								global::랾.럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
							}
							else
							{
								global::랾.럽.랾("Done.", false);
							}
						}
						catch (Exception ex)
						{
							global::랾.럽.람("Error: " + ex.Message, false);
						}
					}
				}
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00091A98 File Offset: 0x0008FC98
		private static void 런()
		{
			object obj = global::랾.럧.랾;
			lock (obj)
			{
				global::랾.럦.럎.Clear();
				global::랾.럦.럎.AddRange(global::랾.럦.럎);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00091AEC File Offset: 0x0008FCEC
		public static void 랔()
		{
			bool packetConsole = ConfigFile.packetConsole;
			if (!global::랾.럦.랾("PacketLoggerWindow", packetConsole))
			{
				return;
			}
			if (!global::랾.럦.럐)
			{
				global::랾.럦.런();
			}
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!packetConsole)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag = global::랾.럦.럎("PacketLoggerWindow", packetConsole);
			ImGui.Begin("Packets: " + global::랾.럦.랾(30), ref ConfigFile.packetConsole, imGuiWindowFlags);
			global::랾.럦.랉();
			try
			{
				ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X - 650f);
				ImGui.InputTextWithHint("##pktfilter", "Search packets...", ref global::랾.럦.럯, 200U);
				ImGui.SameLine();
				if (ImGui.SmallButton("X##clearfilter"))
				{
					global::랾.럦.럯 = string.Empty;
				}
				ImGui.SameLine();
				global::랾.럦.랓("All");
				ImGui.SameLine();
				global::랾.럦.랓("Server");
				ImGui.SameLine();
				global::랾.럦.랓("Client");
				ImGui.SameLine();
				if (ImGui.SmallButton(global::랾.럦.럐 ? "Resume" : "Pause"))
				{
					global::랾.럦.럐 = !global::랾.럦.럐;
				}
				ImGui.SameLine();
				if (ImGui.SmallButton("Copy"))
				{
					global::랾.럦.랲();
				}
				ImGui.SameLine();
				if (ImGui.SmallButton("Clear"))
				{
					object obj = global::랾.럧.랾;
					lock (obj)
					{
						global::랾.럧.럒.Clear();
					}
					global::랾.럦.럎.Clear();
					global::랾.럦.랾.Clear();
					global::랾.럦.랾.Clear();
				}
				ImGui.SameLine();
				bool flag3 = !string.IsNullOrEmpty(global::랾.럦.럯) || global::랾.럦.랱 != "All";
				string value = global::랾.럦.랋(global::랾.럦.랏());
				string text;
				if (!flag3)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럦.럎.Count);
					defaultInterpolatedStringHandler.AppendLiteral(" packets | ");
					defaultInterpolatedStringHandler.AppendFormatted(value);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(4, 3);
					defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럦.랾.Count);
					defaultInterpolatedStringHandler2.AppendLiteral("/");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럦.럎.Count);
					defaultInterpolatedStringHandler2.AppendLiteral(" | ");
					defaultInterpolatedStringHandler2.AppendFormatted(value);
					text = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				ImGui.TextDisabled(text);
				if (flag3 && global::랾.럦.랷())
				{
					global::랾.럦.랤();
				}
				global::랾.럦.랚();
				ImGui.BeginChild("##pktscroll", new Vector2(0f, -ImGui.GetTextLineHeightWithSpacing()), 0, 2048);
				bool flag4 = ImGui.GetScrollY() >= ImGui.GetScrollMaxY();
				if (flag3)
				{
					global::랾.럦.랾(global::랾.럦.랾, true);
				}
				else
				{
					global::랾.럦.랾(null, false);
				}
				if (flag4 && !global::랾.럦.럐)
				{
					ImGui.SetScrollHereY(1f);
				}
				ImGui.EndChild();
			}
			finally
			{
				global::랾.럦.럼("PacketLoggerWindow");
				ImGui.End();
				if (flag)
				{
					ImGui.PopStyleVar();
				}
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00091DF0 File Offset: 0x0008FFF0
		private static void 랓(string A_0)
		{
			bool flag = global::랾.럦.랱 == A_0;
			if (flag)
			{
				ImGui.PushStyleColor(21, new Vector4(0.2f, 0.4f, 0.7f, 1f));
			}
			if (ImGui.SmallButton((A_0 == "Server") ? "S" : ((A_0 == "Client") ? "C" : "All")))
			{
				global::랾.럦.랱 = A_0;
			}
			if (flag)
			{
				ImGui.PopStyleColor();
			}
			if (ImGui.IsItemHovered())
			{
				ImGui.SetTooltip(A_0);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00091E7C File Offset: 0x0009007C
		private unsafe static void 랾(List<int> A_0, bool A_1)
		{
			int num = A_1 ? A_0.Count : global::랾.럦.럎.Count;
			ImGuiListClipperPtr imGuiListClipperPtr;
			imGuiListClipperPtr..ctor(ImGuiNative.ImGuiListClipper_ImGuiListClipper());
			imGuiListClipperPtr.Begin(num);
			while (imGuiListClipperPtr.Step())
			{
				for (int i = *imGuiListClipperPtr.DisplayStart; i < *imGuiListClipperPtr.DisplayEnd; i++)
				{
					int num2 = A_1 ? A_0[i] : i;
					string text = global::랾.럦.럎[num2];
					int num3 = num2;
					if (!text.StartsWith("["))
					{
						for (int j = num2 - 1; j >= 0; j--)
						{
							if (global::랾.럦.럎[j].StartsWith("["))
							{
								num3 = j;
								break;
							}
						}
					}
					bool flag = global::랾.럦.럒 == num3;
					Vector4 vector;
					if (text.StartsWith("["))
					{
						if (text.Contains("] Server ["))
						{
							vector = new Vector4(0.4f, 0.7f, 1f, 1f);
						}
						else if (text.Contains("] Client ["))
						{
							vector = new Vector4(0.5f, 0.85f, 0.4f, 1f);
						}
						else
						{
							vector = *ImGui.GetStyleColorVec4(0);
						}
					}
					else
					{
						vector = new Vector4(0.65f, 0.65f, 0.65f, 1f);
					}
					if (flag)
					{
						ImGui.PushStyleColor(24, new Vector4(0.3f, 0.3f, 0.5f, 0.4f));
					}
					ImGui.PushStyleColor(0, vector);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("##sel_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
					if (ImGui.Selectable(defaultInterpolatedStringHandler.ToStringAndClear(), flag, 18, new Vector2(0f, 0f)))
					{
						global::랾.럦.럒 = (flag ? -1 : num3);
						global::랾.럦.럼(num3);
					}
					if (ImGui.IsItemHovered())
					{
						ImGui.SetTooltip("Click to copy packet");
					}
					ImGui.SameLine(0f, 0f);
					ImGui.TextUnformatted(text);
					ImGui.PopStyleColor();
					if (flag)
					{
						ImGui.PopStyleColor();
					}
				}
			}
			imGuiListClipperPtr.End();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00092094 File Offset: 0x00090294
		private static void 럼(int A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(global::랾.럦.럎[A_0]);
			int num = A_0 + 1;
			while (num < global::랾.럦.럎.Count && !global::랾.럦.럎[num].StartsWith("["))
			{
				stringBuilder.AppendLine(global::랾.럦.럎[num]);
				num++;
			}
			ImGui.SetClipboardText(stringBuilder.ToString().TrimEnd());
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0003F01A File Offset: 0x0003D21A
		private static bool 랷()
		{
			return global::랾.럦.럯 != global::랾.럦.럭 || global::랾.럦.럎.Count != global::랾.럦.람 || global::랾.럦.랱 != global::랾.럦.럙;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0009210C File Offset: 0x0009030C
		private static void 랤()
		{
			global::랾.럦.랾.Clear();
			global::랾.럦.랚();
			럦.랋 랋;
			랋.랾 = (global::랾.럦.럯 ?? string.Empty);
			랋.럎 = 랋.랾.ToLowerInvariant();
			for (int i = 0; i < global::랾.럦.럎.Count; i++)
			{
				string text = global::랾.럦.럎[i];
				if (text.StartsWith("[") && (!(global::랾.럦.랱 == "Server") || text.Contains("] Server [")) && (!(global::랾.럦.랱 == "Client") || text.Contains("] Client [")))
				{
					bool flag = global::랾.럦.랾(text, global::랾.럦.랾[i], ref 랋);
					if (!flag)
					{
						int num = i + 1;
						while (num < global::랾.럦.럎.Count && !global::랾.럦.럎[num].StartsWith("["))
						{
							if (global::랾.럦.랾(global::랾.럦.럎[num], global::랾.럦.랾[num], ref 랋))
							{
								flag = true;
								break;
							}
							num++;
						}
					}
					if (flag)
					{
						global::랾.럦.랾.Add(i);
						int num2 = i + 1;
						while (num2 < global::랾.럦.럎.Count && !global::랾.럦.럎[num2].StartsWith("["))
						{
							global::랾.럦.랾.Add(num2);
							num2++;
						}
					}
				}
			}
			global::랾.럦.럭 = global::랾.럦.럯;
			global::랾.럦.람 = global::랾.럦.럎.Count;
			global::랾.럦.럙 = global::랾.럦.랱;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0003F04F File Offset: 0x0003D24F
		private static void 랚()
		{
			while (global::랾.럦.랾.Count < global::랾.럦.럎.Count)
			{
				global::랾.럦.랾.Add(global::랾.럦.럎[global::랾.럦.랾.Count].ToLowerInvariant());
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000922A8 File Offset: 0x000904A8
		private static void 랲()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string value in global::랾.럦.럎)
			{
				stringBuilder.AppendLine(value);
			}
			ImGui.SetClipboardText(stringBuilder.ToString());
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0009230C File Offset: 0x0009050C
		private static int 랏()
		{
			int num = 0;
			foreach (string text in global::랾.럦.럎)
			{
				if (text.StartsWith("["))
				{
					int num2 = text.LastIndexOf("| ", StringComparison.Ordinal);
					if (num2 >= 0)
					{
						ReadOnlySpan<char> span = text.AsSpan(num2 + 2);
						int num3 = span.IndexOf(' ');
						int num4;
						if (num3 > 0 && int.TryParse(span.Slice(0, num3), out num4))
						{
							num += num4;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000923AC File Offset: 0x000905AC
		private static string 랋(int A_0)
		{
			if (A_0 < 1024)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(A_0);
				defaultInterpolatedStringHandler.AppendLiteral(" B");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (A_0 < 1048576)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler2.AppendFormatted<double>((double)A_0 / 1024.0, "F1");
				defaultInterpolatedStringHandler2.AppendLiteral(" KB");
				return defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler3.AppendFormatted<double>((double)A_0 / 1048576.0, "F2");
			defaultInterpolatedStringHandler3.AppendLiteral(" MB");
			return defaultInterpolatedStringHandler3.ToStringAndClear();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00092458 File Offset: 0x00090658
		public unsafe static void 랿()
		{
			bool flag = ConfigFile.showMenu && ConfigFile.showModAndAdminConsole;
			if (!global::랾.럦.랾("ModAdminConsoleWindow", flag))
			{
				return;
			}
			ImGui.SetNextWindowSize(new Vector2(800f, 500f));
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!flag)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag2 = global::랾.럦.럎("ModAdminConsoleWindow", flag);
			ImGui.Begin("Mod/Admin Console: " + global::랾.럦.랾(30), imGuiWindowFlags);
			global::랾.럦.랉();
			try
			{
				ImGui.BeginChild("##conscroll", new Vector2(0f, -ImGui.GetTextLineHeightWithSpacing()), 0, 2048);
				bool flag3 = ImGui.GetScrollY() >= ImGui.GetScrollMaxY();
				object obj = global::랾.럧.럎;
				string[] array;
				lock (obj)
				{
					array = global::랾.럧.럼.ToArray();
				}
				ImGuiListClipperPtr imGuiListClipperPtr;
				imGuiListClipperPtr..ctor(ImGuiNative.ImGuiListClipper_ImGuiListClipper());
				imGuiListClipperPtr.Begin(array.Length);
				while (imGuiListClipperPtr.Step())
				{
					for (int i = *imGuiListClipperPtr.DisplayStart; i < *imGuiListClipperPtr.DisplayEnd; i++)
					{
						ImGui.TextUnformatted(array[i]);
					}
				}
				imGuiListClipperPtr.End();
				if (flag3)
				{
					ImGui.SetScrollHereY(1f);
				}
				ImGui.EndChild();
				if (ImGui.Button("Help"))
				{
					global::랾.럽.람("Mod/Admin activity is logged here.");
				}
				ImGui.SameLine();
				if (ImGui.Button("Clear"))
				{
					obj = global::랾.럧.럎;
					lock (obj)
					{
						global::랾.럧.럼.Clear();
					}
				}
				ImGui.SameLine();
				if (ImGui.Button("Close"))
				{
					ConfigFile.showModAndAdminConsole = false;
				}
				ImGui.Separator();
				ImGui.Text("Recent Mod Sightings:");
				if (ConfigFile.showPlayerButtons)
				{
					string nameWithId = NetworkPlayers.GetNameWithId(global::랾.럧.러, false);
					if (ImGui.Button("Kick " + nameWithId))
					{
						OutgoingMessages.KickPlayer(global::랾.럧.러);
					}
					ImGui.SameLine();
					if (ImGui.Button("Ban " + nameWithId))
					{
						OutgoingMessages.BanAndKickPlayer(global::랾.럧.러);
					}
					ImGui.SameLine();
					if (ImGui.Button("Summon " + nameWithId))
					{
						OutgoingMessages.SummonPlayerToLocation(global::랾.럧.러);
					}
				}
			}
			finally
			{
				global::랾.럦.럼("ModAdminConsoleWindow");
				ImGui.End();
				if (flag2)
				{
					ImGui.PopStyleVar();
				}
				if (flag && !ConfigFile.showModAndAdminConsole)
				{
					global::랾.럦.람("ModAdminConsoleWindow");
				}
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000926F8 File Offset: 0x000908F8
		private static void 럥()
		{
			global::랾.럦.람();
			ImGui.Checkbox("Show MiniMap (F3)", ref ConfigFile.showMiniMapToggle);
			ImGui.Checkbox("Show Player Buttons", ref ConfigFile.showPlayerButtons);
			ImGui.Separator();
			ImGui.Checkbox("Render Collectables", ref ConfigFile.renderCollectablesToggle);
			ImGui.Checkbox("Render Enemies", ref ConfigFile.renderEnemiesToggle);
			ImGui.Checkbox("Render Players", ref ConfigFile.renderPlayersToggle);
			ImGui.Checkbox("Render World", ref ConfigFile.renderWorldToggle);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00092770 File Offset: 0x00090970
		public static void 랒()
		{
			bool showMiniMapToggle = ConfigFile.showMiniMapToggle;
			if (!global::랾.럦.랾("MiniMapWindow", showMiniMapToggle))
			{
				return;
			}
			bool flag = true;
			ImGuiWindowFlags imGuiWindowFlags = 0;
			if (!showMiniMapToggle)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag2 = global::랾.럦.럎("MiniMapWindow", showMiniMapToggle);
			bool flag3 = ImGui.Begin("Mini Map", ref flag, imGuiWindowFlags);
			try
			{
				if (flag3)
				{
					global::랾.럦.랉();
					World world = global::랾.럓.랾;
					Player player = global::랾.럓.랾;
					if (world != null && !(player == null))
					{
						int worldSizeX = world.worldSizeX;
						int worldSizeY = world.worldSizeY;
						if (worldSizeX > 0 && worldSizeY > 0)
						{
							ImDrawListPtr windowDrawList = ImGui.GetWindowDrawList();
							float num = 200f / (float)worldSizeX + 10f;
							float num2 = 200f / (float)worldSizeY + 10f;
							Vector2 cursorScreenPos = ImGui.GetCursorScreenPos();
							global::랾.럦.럎 += Time.deltaTime;
							if ((global::랾.럦.럎 >= 1f || global::랾.럦.럼 != worldSizeX || global::랾.럦.랋 != worldSizeY) && ConfigFile.renderWorldToggle && global::랾.럦.랾(world, num, num2, worldSizeX, worldSizeY))
							{
								global::랾.럦.럎 = 0f;
							}
							if (ConfigFile.renderWorldToggle)
							{
								global::랾.럦.랾(windowDrawList, cursorScreenPos);
							}
							if (ConfigFile.renderEnemiesToggle)
							{
								global::랾.럦.랾(windowDrawList, cursorScreenPos, num, num2, worldSizeY);
							}
							if (ConfigFile.renderPlayersToggle)
							{
								global::랾.럦.럎(windowDrawList, cursorScreenPos, num, num2, worldSizeY);
							}
							if (ConfigFile.renderCollectablesToggle)
							{
								global::랾.럦.랾(windowDrawList, world, cursorScreenPos, num, num2, worldSizeY);
							}
							global::랾.럦.랾(windowDrawList, cursorScreenPos, player, num, num2, worldSizeY);
							global::랾.럦.랾(world, player, cursorScreenPos, num, num2, worldSizeX, worldSizeY);
							if (ConfigFile.showPlayerButtons)
							{
								global::랾.럦.럋();
							}
						}
					}
				}
			}
			finally
			{
				global::랾.럦.럼("MiniMapWindow");
				ImGui.End();
				if (flag2)
				{
					ImGui.PopStyleVar();
				}
				if (!flag)
				{
					ConfigFile.showMiniMapToggle = false;
					global::랾.럦.람("MiniMapWindow");
				}
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00092958 File Offset: 0x00090B58
		private static bool 랾(World A_0, float A_1, float A_2, int A_3, int A_4)
		{
			if (A_0 == null || A_3 <= 0 || A_4 <= 0)
			{
				return false;
			}
			List<ValueTuple<Vector2, Vector2, uint>> list = new List<ValueTuple<Vector2, Vector2, uint>>();
			List<ValueTuple<Vector2, Vector2, uint>> list2 = new List<ValueTuple<Vector2, Vector2, uint>>();
			try
			{
				for (int i = 0; i < A_4; i++)
				{
					for (int j = 0; j < A_3; j++)
					{
						Vector2i vector2i;
						vector2i..ctor(j, i);
						Vector2 vector = new Vector2((float)j * A_1, (float)(A_4 - i - 1) * A_2);
						Vector2 item = new Vector2(vector.X + A_1, vector.Y + A_2);
						list2.Add(new ValueTuple<Vector2, Vector2, uint>(vector, item, global::랾.럼.랾(global::랾.럼.랾(A_0.GetBlockWaterType(vector2i)))));
						list.Add(new ValueTuple<Vector2, Vector2, uint>(vector, item, global::랾.럼.랾(global::랾.럼.랾(A_0.GetBlockType(vector2i)))));
					}
				}
			}
			catch
			{
				return false;
			}
			global::랾.럦.랾 = list;
			global::랾.럦.럎 = list2;
			global::랾.럦.럼 = A_3;
			global::랾.럦.랋 = A_4;
			return true;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00092A50 File Offset: 0x00090C50
		private static void 랾(ImDrawListPtr A_0, Vector2 A_1)
		{
			for (int i = 0; i < global::랾.럦.럎.Count; i++)
			{
				ValueTuple<Vector2, Vector2, uint> valueTuple = global::랾.럦.럎[i];
				Vector2 item = valueTuple.Item1;
				Vector2 item2 = valueTuple.Item2;
				uint item3 = valueTuple.Item3;
				A_0.AddRectFilled(new Vector2(A_1.X + item.X, A_1.Y + item.Y), new Vector2(A_1.X + item2.X, A_1.Y + item2.Y), item3);
			}
			for (int j = 0; j < global::랾.럦.랾.Count; j++)
			{
				ValueTuple<Vector2, Vector2, uint> valueTuple2 = global::랾.럦.랾[j];
				Vector2 item4 = valueTuple2.Item1;
				Vector2 item5 = valueTuple2.Item2;
				uint item6 = valueTuple2.Item3;
				A_0.AddRectFilled(new Vector2(A_1.X + item4.X, A_1.Y + item4.Y), new Vector2(A_1.X + item5.X, A_1.Y + item5.Y), item6);
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00092B64 File Offset: 0x00090D64
		private static void 랾(ImDrawListPtr A_0, Vector2 A_1, float A_2, float A_3, int A_4)
		{
			IReadOnlyList<AIEnemyMonoBehaviourBase> readOnlyList = global::랾.랳.럜();
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				AIEnemyMonoBehaviourBase aienemyMonoBehaviourBase = readOnlyList[i];
				if (!(aienemyMonoBehaviourBase == null) && aienemyMonoBehaviourBase.aiBase != null && Array.IndexOf<AIEnemyType>(global::랾.럦.랾, aienemyMonoBehaviourBase.aiBase.GetEnemyType()) < 0)
				{
					Vector2i roundedMapPoint = aienemyMonoBehaviourBase.aiBase.GetRoundedMapPoint();
					A_0.AddCircleFilled(new Vector2(A_1.X + (float)roundedMapPoint.x * A_2, A_1.Y + (float)(A_4 - roundedMapPoint.y - 1) * A_3), 3f, global::랾.럼.랾("rose"));
				}
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00092C0C File Offset: 0x00090E0C
		private static void 럎(ImDrawListPtr A_0, Vector2 A_1, float A_2, float A_3, int A_4)
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
				if (networkPlayer != null && networkPlayer.playerScript)
				{
					Vector2i currentPlayerMapPoint = networkPlayer.playerScript.currentPlayerMapPoint;
					Vector2 vector = new Vector2(A_1.X + (float)currentPlayerMapPoint.x * A_2, A_1.Y + (float)(A_4 - currentPlayerMapPoint.y - 1) * A_3);
					A_0.AddCircleFilled(vector, 6f, global::랾.럼.랾(" "));
					A_0.AddText(vector, global::랾.럼.랾("white"), networkPlayer.name);
				}
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00092CE4 File Offset: 0x00090EE4
		private static void 랾(ImDrawListPtr A_0, World A_1, Vector2 A_2, float A_3, float A_4, int A_5)
		{
			CollectableData[] array;
			try
			{
				List<CollectableData> collectables = A_1.collectables;
				array = ((collectables != null) ? collectables.ToArray() : null);
			}
			catch
			{
				return;
			}
			if (array == null)
			{
				return;
			}
			foreach (CollectableData collectableData in array)
			{
				if (collectableData != null)
				{
					Vector2i mapPoint = collectableData.mapPoint;
					A_0.AddCircleFilled(new Vector2(A_2.X + (float)mapPoint.x * A_3, A_2.Y + (float)(A_5 - mapPoint.y - 1) * A_4), 3f, global::랾.럼.랾("blue"));
				}
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00092D84 File Offset: 0x00090F84
		private static void 랾(ImDrawListPtr A_0, Vector2 A_1, Player A_2, float A_3, float A_4, int A_5)
		{
			if (A_2 == null)
			{
				return;
			}
			Vector2i currentPlayerMapPoint = A_2.currentPlayerMapPoint;
			Vector2 vector = new Vector2(A_1.X + (float)currentPlayerMapPoint.x * A_3, A_1.Y + (float)(A_5 - currentPlayerMapPoint.y - 1) * A_4);
			A_0.AddTriangleFilled(new Vector2(vector.X, vector.Y - 9f), new Vector2(vector.X - 4.5f, vector.Y + 4.5f), new Vector2(vector.X + 4.5f, vector.Y + 4.5f), global::랾.럼.랾(" "));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00092E34 File Offset: 0x00091034
		private static void 럋()
		{
			for (int i = 0; i < 47; i++)
			{
				ImGui.NewLine();
			}
			ImGui.Text("Players:");
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
				if (networkPlayer != null && ImGui.Button(networkPlayer.name))
				{
					global::랾.럧.러 = networkPlayer.clientId;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Selected: ");
					defaultInterpolatedStringHandler.AppendFormatted(networkPlayer.name);
					defaultInterpolatedStringHandler.AppendLiteral(" (");
					defaultInterpolatedStringHandler.AppendFormatted(networkPlayer.clientId);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					global::랾.럽.람(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00092F20 File Offset: 0x00091120
		private unsafe static void 랾(World A_0, Player A_1, Vector2 A_2, float A_3, float A_4, int A_5, int A_6)
		{
			if (A_0 == null || A_1 == null)
			{
				return;
			}
			Vector2 mousePos = ImGui.GetMousePos();
			int num = (int)((mousePos.X - A_2.X) / A_3);
			int num2 = A_6 - 1 - (int)((mousePos.Y - A_2.Y) / A_4);
			if (num < 0 || num >= A_5 || num2 < 0 || num2 >= A_6)
			{
				return;
			}
			Vector2i vector2i;
			vector2i..ctor(num, num2);
			WorldItemBase worldItemBase;
			try
			{
				worldItemBase = A_0.GetWorldItemData(num, num2);
			}
			catch
			{
				worldItemBase = null;
			}
			ImGui.BeginTooltip();
			try
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
				NetworkPlayer[] array;
				try
				{
					List<NetworkPlayer> otherPlayers = NetworkPlayers.otherPlayers;
					array = ((otherPlayers != null) ? otherPlayers.ToArray() : null);
				}
				catch
				{
					array = null;
				}
				if (array != null)
				{
					foreach (NetworkPlayer networkPlayer in array)
					{
						if (networkPlayer != null && networkPlayer.playerScript && vector2i == networkPlayer.playerScript.currentPlayerMapPoint)
						{
							ImGui.Text("Player: " + networkPlayer.name);
						}
					}
				}
				global::랾.럠.랾(worldItemBase);
			}
			catch
			{
				ImGui.Text("(tooltip unavailable)");
			}
			finally
			{
				ImGui.EndTooltip();
			}
			if (ImGui.IsMouseClicked(0) && *ImGui.GetIO().KeyAlt)
			{
				global::랾.럠.럎(vector2i, worldItemBase);
			}
			if (ImGui.IsMouseClicked(1) && *ImGui.GetIO().KeyAlt)
			{
				Vector2i currentPlayerMapPoint = A_1.currentPlayerMapPoint;
				if (global::랾.랛.랾(num, num2, currentPlayerMapPoint, false, false))
				{
					if (global::랾.럺.랾(global::랾.랛.랾(currentPlayerMapPoint, vector2i, global::랾.랛.럎()), false))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(16, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("TP set (");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(global::랾.럧.랾.Count);
						defaultInterpolatedStringHandler2.AppendLiteral(" blocks)");
						global::랾.럽.랾(defaultInterpolatedStringHandler2.ToStringAndClear(), false);
						return;
					}
					global::랾.럽.럎("Already teleporting. Wait for the current path to finish first.", false);
					return;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(11, 2);
					defaultInterpolatedStringHandler3.AppendLiteral("(");
					defaultInterpolatedStringHandler3.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler3.AppendLiteral(",");
					defaultInterpolatedStringHandler3.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler3.AppendLiteral(") blocked");
					global::랾.럽.럎(defaultInterpolatedStringHandler3.ToStringAndClear(), false);
				}
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000931B8 File Offset: 0x000913B8
		// Note: this type is marked as 'beforefieldinit'.
		static 럦()
		{
			AIEnemyType[] array = new AIEnemyType[23];
			RuntimeHelpers.InitializeArray(array, fieldof(global::랾.럖.랾).FieldHandle);
			global::랾.럦.랾 = array;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0003F08C File Offset: 0x0003D28C
		[CompilerGenerated]
		internal static bool 랾(string A_0, string A_1, ref 럦.랋 A_2)
		{
			return string.IsNullOrEmpty(A_2.랾) || A_1.Contains(A_2.럎);
		}

		// Token: 0x040004A3 RID: 1187
		private const string 랾 = "MainMenuWindow";

		// Token: 0x040004A4 RID: 1188
		private static readonly Vector2 랾 = new Vector2(300f, 300f);

		// Token: 0x040004A5 RID: 1189
		private static readonly Vector2 럎 = new Vector2(300f, 300f);

		// Token: 0x040004A6 RID: 1190
		private static readonly Vector4 랾 = new Vector4(0.7f, 0.8f, 1f, 1f);

		// Token: 0x040004A7 RID: 1191
		private const ImGuiTabBarFlags 랾 = 257;

		// Token: 0x040004A8 RID: 1192
		private const ImGuiTableFlags 랾 = 33296;

		// Token: 0x040004A9 RID: 1193
		private const string 럎 = "AutoFarm Control Center";

		// Token: 0x040004AA RID: 1194
		private const string 람 = "Fishbot Control Center";

		// Token: 0x040004AB RID: 1195
		private const string 럒 = "Minebot Control Center";

		// Token: 0x040004AC RID: 1196
		private const string 럼 = "Netherbot Control Center";

		// Token: 0x040004AD RID: 1197
		private const string 랋 = "World Cleaner Control Center";

		// Token: 0x040004AE RID: 1198
		private static bool 랾;

		// Token: 0x040004AF RID: 1199
		private static bool 럎;

		// Token: 0x040004B0 RID: 1200
		private static bool 람;

		// Token: 0x040004B1 RID: 1201
		private static bool 럒;

		// Token: 0x040004B2 RID: 1202
		private static bool 럼;

		// Token: 0x040004B3 RID: 1203
		private static string 랉 = string.Empty;

		// Token: 0x040004B4 RID: 1204
		private static readonly string[] 랾 = new string[]
		{
			"Level 1 (5016)",
			"Level 2 (5017)",
			"Level 3 (5018)",
			"Level 4 (5019)",
			"Level 5 (5020)"
		};

		// Token: 0x040004B5 RID: 1205
		private static readonly string[] 럎 = new string[]
		{
			"Scroll",
			"Selected Red Portal"
		};

		// Token: 0x040004B6 RID: 1206
		private static readonly string[] 람 = new string[]
		{
			"Clean",
			"Soft",
			"Flow",
			"Dashed",
			"Pulse",
			"Ribbon"
		};

		// Token: 0x040004B7 RID: 1207
		private static readonly Dictionary<string, 럦.람> 랾 = new Dictionary<string, 럦.람>();

		// Token: 0x040004B8 RID: 1208
		private static string 럐 = "Default";

		// Token: 0x040004B9 RID: 1209
		private static int 랾 = 0;

		// Token: 0x040004BA RID: 1210
		private static bool 랋 = false;

		// Token: 0x040004BB RID: 1211
		private static string 랓 = string.Empty;

		// Token: 0x040004BC RID: 1212
		private static float 랾 = 0f;

		// Token: 0x040004BD RID: 1213
		private static int 럎 = 4;

		// Token: 0x040004BE RID: 1214
		private static readonly HashSet<string> 랾 = new HashSet<string>
		{
			"Cast",
			"Equals",
			"Finalize",
			"GetIl2CppType",
			"MemberwiseClone",
			"SetIsBattleOn",
			"ToString",
			"TryCast",
			"Unbox"
		};

		// Token: 0x040004BF RID: 1215
		private static string 럯 = string.Empty;

		// Token: 0x040004C0 RID: 1216
		private static List<int> 랾 = new List<int>();

		// Token: 0x040004C1 RID: 1217
		private static string 럭 = string.Empty;

		// Token: 0x040004C2 RID: 1218
		private static bool 랉 = false;

		// Token: 0x040004C3 RID: 1219
		private static int 람 = 0;

		// Token: 0x040004C4 RID: 1220
		private static bool 럐 = false;

		// Token: 0x040004C5 RID: 1221
		private static string 랱 = "All";

		// Token: 0x040004C6 RID: 1222
		private static string 럙 = "All";

		// Token: 0x040004C7 RID: 1223
		private static List<string> 랾 = new List<string>();

		// Token: 0x040004C8 RID: 1224
		private static List<string> 럎 = new List<string>();

		// Token: 0x040004C9 RID: 1225
		private static int 럒 = -1;

		// Token: 0x040004CA RID: 1226
		private static float 럎 = 0f;

		// Token: 0x040004CB RID: 1227
		private const float 람 = 1f;

		// Token: 0x040004CC RID: 1228
		[TupleElementNames(new string[]
		{
			"min",
			"max",
			"color"
		})]
		private static List<ValueTuple<Vector2, Vector2, uint>> 랾 = new List<ValueTuple<Vector2, Vector2, uint>>();

		// Token: 0x040004CD RID: 1229
		[TupleElementNames(new string[]
		{
			"min",
			"max",
			"color"
		})]
		private static List<ValueTuple<Vector2, Vector2, uint>> 럎 = new List<ValueTuple<Vector2, Vector2, uint>>();

		// Token: 0x040004CE RID: 1230
		private static int 럼 = 0;

		// Token: 0x040004CF RID: 1231
		private static int 랋 = 0;

		// Token: 0x040004D0 RID: 1232
		private static readonly AIEnemyType[] 랾;

		// Token: 0x02000082 RID: 130
		private enum 랾
		{
			// Token: 0x040004D2 RID: 1234
			랾,
			// Token: 0x040004D3 RID: 1235
			럎,
			// Token: 0x040004D4 RID: 1236
			람,
			// Token: 0x040004D5 RID: 1237
			럒
		}

		// Token: 0x02000083 RID: 131
		private enum 럎
		{
			// Token: 0x040004D7 RID: 1239
			랾,
			// Token: 0x040004D8 RID: 1240
			럎,
			// Token: 0x040004D9 RID: 1241
			람,
			// Token: 0x040004DA RID: 1242
			럒
		}

		// Token: 0x02000084 RID: 132
		private sealed class 람
		{
			// Token: 0x040004DB RID: 1243
			public bool 랾;

			// Token: 0x040004DC RID: 1244
			public bool 럎;

			// Token: 0x040004DD RID: 1245
			public bool 람;

			// Token: 0x040004DE RID: 1246
			public float 랾 = -1f;

			// Token: 0x040004DF RID: 1247
			public Vector2 랾 = new Vector2(80f, 80f);
		}

		// Token: 0x02000085 RID: 133
		[CompilerGenerated]
		private static class 럒
		{
			// Token: 0x040004E0 RID: 1248
			public static Action<bool> 랾;

			// Token: 0x040004E1 RID: 1249
			public static Action 랾;

			// Token: 0x040004E2 RID: 1250
			public static Action<bool> 럎;

			// Token: 0x040004E3 RID: 1251
			public static Action 럎;

			// Token: 0x040004E4 RID: 1252
			public static Action 람;

			// Token: 0x040004E5 RID: 1253
			public static Action<bool> 람;

			// Token: 0x040004E6 RID: 1254
			public static Action 럒;

			// Token: 0x040004E7 RID: 1255
			public static Action<bool> 럒;

			// Token: 0x040004E8 RID: 1256
			public static Action 럼;

			// Token: 0x040004E9 RID: 1257
			[TupleElementNames(new string[]
			{
				"success",
				"json"
			})]
			public static Func<ValueTuple<bool, string>> 랾;

			// Token: 0x040004EA RID: 1258
			public static Func<string, bool> 랾;

			// Token: 0x040004EB RID: 1259
			[TupleElementNames(new string[]
			{
				"success",
				"json"
			})]
			public static Func<ValueTuple<bool, string>> 럎;

			// Token: 0x040004EC RID: 1260
			public static Func<string, bool> 럎;

			// Token: 0x040004ED RID: 1261
			[TupleElementNames(new string[]
			{
				"success",
				"json"
			})]
			public static Func<ValueTuple<bool, string>> 람;

			// Token: 0x040004EE RID: 1262
			public static Func<string, bool> 람;

			// Token: 0x040004EF RID: 1263
			[TupleElementNames(new string[]
			{
				"success",
				"json"
			})]
			public static Func<ValueTuple<bool, string>> 럒;

			// Token: 0x040004F0 RID: 1264
			public static Func<string, bool> 럒;
		}

		// Token: 0x02000086 RID: 134
		[CompilerGenerated]
		[Serializable]
		private sealed class 럼
		{
			// Token: 0x06000574 RID: 1396 RVA: 0x0003F0DD File Offset: 0x0003D2DD
			internal void 랾(bool A_1)
			{
				global::랾.럧.럷 = A_1;
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x0003F0E5 File Offset: 0x0003D2E5
			internal void 랾(KeyCode A_1)
			{
				ConfigFile.teleportCancelKey = A_1;
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x0003F0ED File Offset: 0x0003D2ED
			internal void 럎(KeyCode A_1)
			{
				ConfigFile.menuToggleKey = A_1;
			}

			// Token: 0x040004F1 RID: 1265
			public static readonly 럦.럼 랾 = new 럦.럼();

			// Token: 0x040004F2 RID: 1266
			public static Action<bool> 랾;

			// Token: 0x040004F3 RID: 1267
			public static Action<KeyCode> 랾;

			// Token: 0x040004F4 RID: 1268
			public static Action<KeyCode> 럎;
		}

		// Token: 0x02000087 RID: 135
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct 랋
		{
			// Token: 0x040004F5 RID: 1269
			public string 랾;

			// Token: 0x040004F6 RID: 1270
			public string 럎;
		}
	}
}
