using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using CharonClient.Configuration;
using ImGuiNET;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200000B RID: 11
	internal static class 럐
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0003CAD4 File Offset: 0x0003ACD4
		public static void 랾()
		{
			global::랾.럐.랾 = true;
			global::랾.럐.랾 = 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00070244 File Offset: 0x0006E444
		public static void 럎()
		{
			if (!global::랾.럐.랾)
			{
				return;
			}
			ImGui.OpenPopup("Guided Setup");
			bool flag = true;
			ImGui.SetNextWindowSize(new Vector2(620f, 0f), 4);
			if (!ImGui.BeginPopupModal("Guided Setup", ref flag, 2))
			{
				if (!flag)
				{
					global::랾.럐.랾 = false;
				}
				return;
			}
			Vector4 vector = new Vector4(0.6f, 0.85f, 1f, 1f);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Step ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(global::랾.럐.랾 + 1);
			defaultInterpolatedStringHandler.AppendLiteral(" of 4");
			ImGui.TextColored(vector, defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.Separator();
			switch (global::랾.럐.랾)
			{
			case 0:
				global::랾.럐.람();
				break;
			case 1:
				global::랾.럐.럒();
				break;
			case 2:
				global::랾.럐.럼();
				break;
			case 3:
				global::랾.럐.랋();
				break;
			}
			ImGui.Separator();
			if (global::랾.럐.랾 > 0)
			{
				if (ImGui.Button("Back", new Vector2(100f, 0f)))
				{
					global::랾.럐.랾--;
				}
				ImGui.SameLine();
			}
			if (global::랾.럐.랾 < 3)
			{
				if (ImGui.Button("Next", new Vector2(100f, 0f)))
				{
					global::랾.럐.랾++;
				}
			}
			else
			{
				if (ImGui.Button("Finish", new Vector2(100f, 0f)))
				{
					ConfigFile.hasCompletedGuidedSetup = true;
					global::랾.럐.랾 = false;
					ConfigFile.럼();
					ImGui.CloseCurrentPopup();
					럽.랾("Guided setup completed.", false);
				}
				ImGui.SameLine();
				if (ImGui.Button("Apply Safe Defaults", new Vector2(150f, 0f)))
				{
					global::랾.럐.랉();
					ConfigFile.hasCompletedGuidedSetup = true;
					global::랾.럐.랾 = false;
					ConfigFile.럼();
					ImGui.CloseCurrentPopup();
					럽.랾("Safe defaults applied.", false);
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Skip", new Vector2(100f, 0f)))
			{
				ConfigFile.hasCompletedGuidedSetup = true;
				global::랾.럐.랾 = false;
				ConfigFile.럼();
				ImGui.CloseCurrentPopup();
			}
			ImGui.EndPopup();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00070454 File Offset: 0x0006E654
		private static void 람()
		{
			ImGui.TextWrapped("This setup helps new users get the client ready without digging through every tab manually.");
			ImGui.Spacing();
			ImGui.BulletText("Pick a theme");
			ImGui.BulletText("Set notification preferences");
			ImGui.BulletText("Enable a few safe recommended options");
			ImGui.BulletText("Learn where important settings are");
			ImGui.Spacing();
			ImGui.TextDisabled("You can reopen this later from Settings at any time.");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000704A8 File Offset: 0x0006E6A8
		private static void 럒()
		{
			global::랾.럐.럐();
			int num = global::랾.럐.랓();
			ImGui.TextWrapped("Choose the look you want to start with.");
			if (num < 0)
			{
				ImGui.TextDisabled("Theme presets unavailable.");
				return;
			}
			if (ImGui.BeginCombo("Theme", global::랾.럐.랾[num]))
			{
				for (int i = 0; i < global::랾.럐.랾.Length; i++)
				{
					bool flag = i == num;
					if (ImGui.Selectable(global::랾.럐.랾[i], flag))
					{
						global::랾.럐.랾(i);
					}
					if (flag)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00070528 File Offset: 0x0006E728
		private static void 럼()
		{
			ImGui.TextWrapped("Set up your basic notification and message preferences.");
			ImGui.Spacing();
			ImGui.Checkbox("Show Notifications Over Text", ref ConfigFile.showNotifications);
			ImGui.Checkbox("Show Notification Console", ref ConfigFile.notificationConsoleToggle);
			ImGui.Checkbox("Enable Chat Commands", ref ConfigFile.enableChatCommandsToggle);
			ImGui.Spacing();
			ImGui.Separator();
			ImGui.TextWrapped("You can change your menu key later from the Settings tab under Hotkeys.");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Current menu key: ");
			defaultInterpolatedStringHandler.AppendFormatted<KeyCode>(ConfigFile.menuToggleKey);
			ImGui.TextDisabled(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000705B8 File Offset: 0x0006E7B8
		private static void 랋()
		{
			ImGui.TextWrapped("These are the safer defaults most people will want enabled.");
			ImGui.Checkbox("Auto Leave", ref ConfigFile.autoLeaveToggle);
			ImGui.Checkbox("Show Mod/Admin Notifications", ref ConfigFile.modAndAdminNotifications);
			ImGui.Checkbox("Anti Trap Crash", ref ConfigFile.antiTrapCrash);
			ImGui.Checkbox("Anti Text Crash", ref ConfigFile.antiTextCrash);
			ImGui.Checkbox("Anti Wiring Crash", ref ConfigFile.antiWiringCrash);
			ImGui.Checkbox("Cheater Detector", ref ConfigFile.cheaterDetectorToggle);
			ImGui.Checkbox("Bot Detector", ref ConfigFile.botDetectorToggle);
			ImGui.Spacing();
			ImGui.TextDisabled("These can all be changed later in Settings.");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00070650 File Offset: 0x0006E850
		private static void 랉()
		{
			global::랾.럐.랾(7);
			ConfigFile.menuToggleKey = 283;
			ConfigFile.showNotifications = true;
			ConfigFile.notificationConsoleToggle = false;
			ConfigFile.enableChatCommandsToggle = true;
			ConfigFile.autoLeaveToggle = true;
			ConfigFile.modAndAdminNotifications = true;
			ConfigFile.antiTrapCrash = true;
			ConfigFile.antiTextCrash = true;
			ConfigFile.antiWiringCrash = true;
			ConfigFile.cheaterDetectorToggle = true;
			ConfigFile.botDetectorToggle = true;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000706AC File Offset: 0x0006E8AC
		private static void 럐()
		{
			if (ConfigFile.darkTheme)
			{
				ConfigFile.selectedThemeIndex = 1;
				return;
			}
			if (ConfigFile.moonlightTheme)
			{
				ConfigFile.selectedThemeIndex = 2;
				return;
			}
			if (ConfigFile.cinderTheme)
			{
				ConfigFile.selectedThemeIndex = 3;
				return;
			}
			if (ConfigFile.catppuccinTheme)
			{
				ConfigFile.selectedThemeIndex = 4;
				return;
			}
			if (ConfigFile.purpleTheme)
			{
				ConfigFile.selectedThemeIndex = 5;
				return;
			}
			if (ConfigFile.redTheme)
			{
				ConfigFile.selectedThemeIndex = 6;
				return;
			}
			if (ConfigFile.whiteDressTheme)
			{
				ConfigFile.selectedThemeIndex = 7;
				return;
			}
			if (ConfigFile.blackDressTheme)
			{
				ConfigFile.selectedThemeIndex = 8;
				return;
			}
			ConfigFile.selectedThemeIndex = 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00070730 File Offset: 0x0006E930
		private static void 랾(int A_0)
		{
			if (A_0 >= global::랾.럐.랾.Length)
			{
				A_0 = 0;
			}
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

		// Token: 0x06000039 RID: 57 RVA: 0x000707A4 File Offset: 0x0006E9A4
		private static int 랓()
		{
			if (global::랾.럐.랾.Length == 0)
			{
				return -1;
			}
			int num = ConfigFile.selectedThemeIndex;
			if (num >= global::랾.럐.랾.Length)
			{
				num = 0;
				ConfigFile.selectedThemeIndex = 0;
			}
			return num;
		}

		// Token: 0x04000019 RID: 25
		private static int 랾 = 0;

		// Token: 0x0400001A RID: 26
		private static bool 랾 = false;

		// Token: 0x0400001B RID: 27
		private static readonly string[] 랾 = new string[]
		{
			"Default",
			"Dark",
			"Moonlight",
			"Cinder",
			"Catppuccin",
			"Purple",
			"Red",
			"White Dress",
			"Black Dress"
		};
	}
}
