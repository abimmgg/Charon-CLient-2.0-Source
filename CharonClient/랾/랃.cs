using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using CharonClient.Configuration;
using ImGuiNET;
using UnityEngine;

namespace 랾
{
	// Token: 0x020000AC RID: 172
	internal static class 랃
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x0003F8A9 File Offset: 0x0003DAA9
		public static void 랾(string A_0, string A_1 = "", float A_2 = 4f)
		{
			랃.랾(A_0, A_1, 랃.랾.랾, A_2);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0003F8B4 File Offset: 0x0003DAB4
		public static void 럎(string A_0, string A_1 = "", float A_2 = 4f)
		{
			랃.랾(A_0, A_1, 랃.랾.럎, A_2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0003F8BF File Offset: 0x0003DABF
		public static void 람(string A_0, string A_1 = "", float A_2 = 4f)
		{
			랃.랾(A_0, A_1, 랃.랾.람, A_2);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0003F8CA File Offset: 0x0003DACA
		public static void 럒(string A_0, string A_1 = "", float A_2 = 4f)
		{
			랃.랾(A_0, A_1, 랃.랾.럒, A_2);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0009E828 File Offset: 0x0009CA28
		private static void 랾(string A_0, string A_1, 랃.랾 A_2, float A_3)
		{
			if (A_0 == null)
			{
				A_0 = string.Empty;
			}
			if (A_1 == null)
			{
				A_1 = string.Empty;
			}
			bool showNotifications = ConfigFile.showNotifications;
			bool flag = ConfigFile.notificationConsoleToggle && showNotifications;
			object obj = 랃.랾;
			lock (obj)
			{
				if (flag)
				{
					랃.람 람 = new 랃.람
					{
						랾 = DateTime.Now,
						랾 = A_0,
						럎 = A_1,
						랾 = A_2
					};
					if (!랃.랾(람))
					{
						if (랃.랾.Count >= 500)
						{
							랃.랾.RemoveAt(0);
						}
						랃.랾.Add(람);
					}
				}
				if (showNotifications)
				{
					if (!랃.랾(A_0, A_1, A_2))
					{
						if (랃.랾.Count >= 5)
						{
							랃.랾.RemoveAt(0);
						}
						랃.랾.Add(new 랃.럎
						{
							랾 = A_0,
							럎 = A_1,
							랾 = A_2,
							랾 = A_3,
							럎 = A_3,
							람 = 0f
						});
					}
				}
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0009E948 File Offset: 0x0009CB48
		private static bool 랾(랃.람 A_0)
		{
			if (랃.랾.Count == 0)
			{
				return false;
			}
			랃.람 람 = 랃.랾[랃.랾.Count - 1];
			return 람.랾 == A_0.랾 && string.Equals(람.랾, A_0.랾, StringComparison.Ordinal) && string.Equals(람.럎, A_0.럎, StringComparison.Ordinal) && (A_0.랾 - 람.랾).TotalMilliseconds < 250.0;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0009E9D8 File Offset: 0x0009CBD8
		private static bool 랾(string A_0, string A_1, 랃.랾 A_2)
		{
			if (랃.랾.Count == 0)
			{
				return false;
			}
			랃.럎 럎 = 랃.랾[랃.랾.Count - 1];
			return 럎.랾 == A_2 && string.Equals(럎.랾, A_0, StringComparison.Ordinal) && string.Equals(럎.럎, A_1, StringComparison.Ordinal) && 럎.랾 > 럎.럎 - 0.25f;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0003F8D5 File Offset: 0x0003DAD5
		public static void 랾()
		{
			랃.럎();
			랃.람();
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0009EA48 File Offset: 0x0009CC48
		private static void 럎()
		{
			object obj = 랃.랾;
			lock (obj)
			{
				if (랃.랾.Count != 0)
				{
					float deltaTime = Time.deltaTime;
					float x = ImGui.GetIO().DisplaySize.X;
					float num = Math.Clamp(ConfigFile.uiToastWidth, 320f, 760f);
					float val = Math.Clamp(ConfigFile.uiToastMinHeight, 72f, 220f);
					float num2 = Math.Clamp(ConfigFile.uiToastSpacing, 4f, 24f);
					float num3 = Math.Clamp(ConfigFile.uiToastOffsetX, 8f, 72f);
					float num4 = Math.Clamp(ConfigFile.uiToastOffsetY, 8f, 72f);
					float num5 = Math.Clamp(ConfigFile.uiToastRounding, 6f, 28f);
					float num6 = Math.Clamp(ConfigFile.uiToastAccentBarWidth, 3f, 14f);
					float num7 = Math.Clamp(ConfigFile.uiToastBorderThickness, 0.6f, 3f);
					float num8 = Math.Clamp(ConfigFile.uiToastGlowStrength, 0f, 0.8f);
					float num9 = Math.Clamp(ConfigFile.uiToastTitleScale, 0.85f, 1.45f);
					float num10 = Math.Clamp(ConfigFile.uiToastMessageScale, 0.8f, 1.35f);
					Vector4 vector = 랃.럼();
					Vector4 vector2 = 랃.랋();
					Vector4 vector3 = 랃.랉();
					float fontSize = ImGui.GetFontSize();
					for (int i = 랃.랾.Count - 1; i >= 0; i--)
					{
						랃.럎 럎 = 랃.랾[i];
						럎.랾 -= deltaTime;
						float num11 = 럎.럎 - 럎.랾;
						if (num11 < 0.3f)
						{
							럎.람 = num11 / 0.3f;
						}
						else if (럎.랾 < 0.5f)
						{
							럎.람 = 럎.랾 / 0.5f;
						}
						else
						{
							럎.람 = 1f;
						}
						럎.람 = Math.Clamp(럎.람, 0f, 1f);
						if (럎.랾 <= 0f)
						{
							랃.랾.RemoveAt(i);
						}
						else
						{
							ValueTuple<Vector4, string, string> valueTuple = 랃.럒(럎.랾);
							Vector4 item = valueTuple.Item1;
							string item2 = valueTuple.Item2;
							string item3 = valueTuple.Item3;
							float x2 = x - num - num3;
							float num12 = num6 + 18f;
							float num13 = 18f;
							float num14 = num - num12 - num13;
							float num15 = fontSize * 0.78f + 6f;
							float num16 = Math.Max(fontSize * num9, ImGui.CalcTextSize(럎.랾, false, num14).Y * num9);
							float num17 = string.IsNullOrWhiteSpace(럎.럎) ? 0f : Math.Max(fontSize * num10, ImGui.CalcTextSize(럎.럎, false, num14).Y * num10);
							float y = Math.Max(val, 18f + num15 + 8f + num16 + ((num17 > 0f) ? (10f + num17) : 6f) + 24f);
							ImGui.SetNextWindowPos(new Vector2(x2, num4), 1);
							ImGui.SetNextWindowSize(new Vector2(num, y), 1);
							ImGui.PushStyleVar(0, 럎.람);
							ImGui.PushStyleVar(3, num5);
							ImGui.PushStyleVar(2, Vector2.Zero);
							ImGui.PushStyleVar(4, 0f);
							ImGui.PushStyleColor(2, vector);
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
							defaultInterpolatedStringHandler.AppendLiteral("##toast_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(i);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(럎.GetHashCode());
							string text = defaultInterpolatedStringHandler.ToStringAndClear();
							bool flag2 = false;
							try
							{
								ImGui.Begin(text, 201515);
								flag2 = true;
								Vector2 windowPos = ImGui.GetWindowPos();
								Vector2 windowSize = ImGui.GetWindowSize();
								float num18 = (럎.럎 <= 0.001f) ? 0f : Math.Clamp(럎.랾 / 럎.럎, 0f, 1f);
								랃.랾(windowPos, windowSize, num5, num6, num7, num8, vector, item, num18);
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 1);
								defaultInterpolatedStringHandler2.AppendFormatted<float>(Math.Max(0f, 럎.랾), "0.0");
								defaultInterpolatedStringHandler2.AppendLiteral("s");
								string text2 = defaultInterpolatedStringHandler2.ToStringAndClear();
								Vector2 vector4 = ImGui.CalcTextSize(text2);
								ImGui.SetCursorPos(new Vector2(num12, 14f));
								ImGui.SetWindowFontScale(0.78f);
								ImGui.TextColored(랽.랾(item, 0.95f), item2 + " " + item3);
								ImGui.SetCursorPos(new Vector2(windowSize.X - num13 - vector4.X, 14f));
								ImGui.TextColored(랽.랾(vector3, 0.78f), text2);
								ImGui.SetCursorPos(new Vector2(num12, 14f + num15));
								ImGui.SetWindowFontScale(num9);
								ImGui.PushTextWrapPos(num12 + num14);
								ImGui.TextColored(vector2, 럎.랾);
								ImGui.PopTextWrapPos();
								if (!string.IsNullOrWhiteSpace(럎.럎))
								{
									ImGui.SetCursorPos(new Vector2(num12, ImGui.GetCursorPosY() + 2f));
									ImGui.SetWindowFontScale(num10);
									ImGui.PushTextWrapPos(num12 + num14);
									ImGui.TextColored(vector3, 럎.럎);
									ImGui.PopTextWrapPos();
								}
								ImGui.SetWindowFontScale(1f);
								num4 += windowSize.Y + num2;
							}
							catch
							{
								랃.랾.RemoveAt(i);
							}
							finally
							{
								if (flag2)
								{
									ImGui.End();
								}
								ImGui.PopStyleColor();
								ImGui.PopStyleVar(4);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0009F020 File Offset: 0x0009D220
		private static void 람()
		{
			bool notificationConsoleToggle = ConfigFile.notificationConsoleToggle;
			if (!럦.랾("NotificationConsoleWindow", notificationConsoleToggle))
			{
				return;
			}
			int frameCount = ImGui.GetFrameCount();
			if (랃.람 == frameCount)
			{
				return;
			}
			랃.람 = frameCount;
			bool notificationConsoleToggle2 = ConfigFile.notificationConsoleToggle;
			ImGuiWindowFlags imGuiWindowFlags = 32;
			if (!notificationConsoleToggle)
			{
				imGuiWindowFlags |= 201216;
			}
			bool flag = 럦.럎("NotificationConsoleWindow", notificationConsoleToggle);
			bool flag2 = ImGui.Begin("Notification Console", ref notificationConsoleToggle2, imGuiWindowFlags);
			try
			{
				if (flag2)
				{
					럦.랉();
					try
					{
						if (랃.랾 == null)
						{
							랃.랾 = string.Empty;
						}
						List<랃.람> list = new List<랃.람>();
						object obj = 랃.랾;
						lock (obj)
						{
							list.AddRange(랃.랾);
						}
						List<랃.람> list2 = new List<랃.람>(list.Count);
						for (int i = 0; i < list.Count; i++)
						{
							랃.람 람 = list[i];
							if (랃.랾(람.랾) && 랃.럎(람))
							{
								list2.Add(람);
							}
						}
						ImGui.Checkbox("Auto-scroll", ref 랃.랾);
						ImGui.SameLine();
						if (ImGui.SmallButton("All"))
						{
							랃.럎 = true;
							랃.람 = true;
							랃.럒 = true;
							랃.럼 = true;
						}
						ImGui.SameLine();
						if (ImGui.SmallButton("None"))
						{
							랃.럎 = false;
							랃.람 = false;
							랃.럒 = false;
							랃.럼 = false;
						}
						ImGui.Checkbox("Info", ref 랃.럎);
						ImGui.SameLine();
						ImGui.Checkbox("Success", ref 랃.람);
						ImGui.SameLine();
						ImGui.Checkbox("Warning", ref 랃.럒);
						ImGui.SameLine();
						ImGui.Checkbox("Error", ref 랃.럼);
						ImGui.PushItemWidth(-70f);
						ImGui.InputTextWithHint("##notificationSearch", "Search title or message...", ref 랃.랾, 256U);
						ImGui.PopItemWidth();
						ImGui.SameLine();
						if (ImGui.SmallButton("Clear"))
						{
							랃.랾 = string.Empty;
						}
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Showing ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(list2.Count);
						defaultInterpolatedStringHandler.AppendLiteral(" of ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
						defaultInterpolatedStringHandler.AppendLiteral(" notification(s)");
						ImGui.TextDisabled(defaultInterpolatedStringHandler.ToStringAndClear());
						if (ImGui.Button("Clear Console"))
						{
							obj = 랃.랾;
							lock (obj)
							{
								랃.랾.Clear();
							}
							list2.Clear();
							list.Clear();
						}
						ImGui.SameLine();
						if (ImGui.Button("Copy Visible"))
						{
							ImGui.SetClipboardText(랃.럒());
						}
						ImGui.Separator();
						bool flag4 = false;
						try
						{
							ImGui.BeginChild("##notificationHistory", new Vector2(0f, 0f), 0, 2048);
							flag4 = true;
							bool flag5 = 랃.랾 && ImGui.GetScrollY() >= ImGui.GetScrollMaxY() - 20f;
							if (list2.Count == 0)
							{
								ImGui.TextDisabled("No notifications match the current filters.");
							}
							else
							{
								for (int j = 0; j < list2.Count; j++)
								{
									랃.람 람2 = list2[j];
									Vector4 vector = 랃.람(람2.랾);
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(6, 3);
									defaultInterpolatedStringHandler2.AppendLiteral("[");
									defaultInterpolatedStringHandler2.AppendFormatted<DateTime>(람2.랾, "HH:mm:ss");
									defaultInterpolatedStringHandler2.AppendLiteral("] [");
									defaultInterpolatedStringHandler2.AppendFormatted(랃.럎(람2.랾));
									defaultInterpolatedStringHandler2.AppendLiteral("] ");
									defaultInterpolatedStringHandler2.AppendFormatted(람2.랾);
									string text = defaultInterpolatedStringHandler2.ToStringAndClear();
									if (!string.IsNullOrWhiteSpace(람2.럎))
									{
										text = text + " - " + 람2.럎;
									}
									ImGui.TextColored(vector, text);
								}
							}
							if (flag5)
							{
								ImGui.SetScrollHereY(1f);
							}
						}
						finally
						{
							if (flag4)
							{
								ImGui.EndChild();
							}
						}
					}
					catch
					{
						ImGui.TextDisabled("Notification console unavailable.");
					}
					finally
					{
						럦.럼("NotificationConsoleWindow");
					}
				}
			}
			finally
			{
				ImGui.End();
				if (flag)
				{
					ImGui.PopStyleVar();
				}
				if (notificationConsoleToggle)
				{
					ConfigFile.notificationConsoleToggle = notificationConsoleToggle2;
				}
				if (notificationConsoleToggle && !notificationConsoleToggle2)
				{
					럦.람("NotificationConsoleWindow");
				}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0009F4F0 File Offset: 0x0009D6F0
		private static bool 랾(랃.랾 A_0)
		{
			bool result;
			switch (A_0)
			{
			case 랃.랾.랾:
				result = 랃.럎;
				break;
			case 랃.랾.럎:
				result = 랃.람;
				break;
			case 랃.랾.람:
				result = 랃.럒;
				break;
			case 랃.랾.럒:
				result = 랃.럼;
				break;
			default:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0009F538 File Offset: 0x0009D738
		private static bool 럎(랃.람 A_0)
		{
			if (string.IsNullOrWhiteSpace(랃.랾))
			{
				return true;
			}
			string value = 랃.랾.Trim();
			string text = A_0.랾;
			if (((text != null) ? text.IndexOf(value, StringComparison.OrdinalIgnoreCase) : -1) < 0)
			{
				string text2 = A_0.럎;
				return ((text2 != null) ? text2.IndexOf(value, StringComparison.OrdinalIgnoreCase) : -1) >= 0;
			}
			return true;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0009F594 File Offset: 0x0009D794
		private static string 럒()
		{
			StringBuilder stringBuilder = new StringBuilder();
			object obj = 랃.랾;
			lock (obj)
			{
				for (int i = 0; i < 랃.랾.Count; i++)
				{
					랃.람 람 = 랃.랾[i];
					if (랃.랾(람.랾) && 랃.럎(람))
					{
						stringBuilder.Append('[').Append(람.랾.ToString("HH:mm:ss")).Append("] ");
						stringBuilder.Append('[').Append(랃.럎(람.랾)).Append("] ");
						stringBuilder.Append(람.랾);
						if (!string.IsNullOrWhiteSpace(람.럎))
						{
							stringBuilder.Append(" - ").Append(람.럎);
						}
						stringBuilder.AppendLine();
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0009F6A8 File Offset: 0x0009D8A8
		private static void 랾(Vector2 A_0, Vector2 A_1, float A_2, float A_3, float A_4, float A_5, Vector4 A_6, Vector4 A_7, float A_8)
		{
			ImDrawListPtr backgroundDrawList = ImGui.GetBackgroundDrawList();
			ImDrawListPtr windowDrawList = ImGui.GetWindowDrawList();
			uint num = ImGui.ColorConvertFloat4ToU32(A_7);
			uint num2 = ImGui.ColorConvertFloat4ToU32(랽.랾(랽.랾(A_6, A_7, 0.52f), 0.82f));
			uint num3 = ImGui.ColorConvertFloat4ToU32(랽.랾(A_7, 0.14f + A_5 * 0.1f));
			uint num4 = ImGui.ColorConvertFloat4ToU32(랽.랾(A_7, 0.22f));
			uint num5 = ImGui.ColorConvertFloat4ToU32(랽.랾(A_7, 0.08f));
			if (A_5 > 0.01f)
			{
				for (int i = 0; i < 3; i++)
				{
					float num6 = 4f + (float)i * 4f;
					float num7 = 1.4f + (float)i * 0.5f;
					backgroundDrawList.AddRect(new Vector2(A_0.X - num6, A_0.Y - num6), new Vector2(A_0.X + A_1.X + num6, A_0.Y + A_1.Y + num6), num3, A_2 + num6, 0, num7);
				}
			}
			windowDrawList.AddRectFilled(A_0, new Vector2(A_0.X + A_1.X, A_0.Y + A_1.Y), ImGui.ColorConvertFloat4ToU32(A_6), A_2);
			windowDrawList.AddRectFilled(A_0, new Vector2(A_0.X + A_3, A_0.Y + A_1.Y), num, A_2);
			windowDrawList.AddRectFilled(new Vector2(A_0.X + A_3, A_0.Y), new Vector2(A_0.X + A_1.X, A_0.Y + 3f), num4, A_2);
			windowDrawList.AddRectFilled(new Vector2(A_0.X + A_3, A_0.Y + 3f), new Vector2(A_0.X + A_1.X, A_0.Y + 18f), num5, A_2);
			float num8 = 3f;
			float num9 = A_0.X + A_3;
			float num10 = (A_1.X - A_3) * Math.Clamp(A_8, 0f, 1f);
			float num11 = A_0.Y + A_1.Y - num8;
			windowDrawList.AddRectFilled(new Vector2(num9, num11), new Vector2(A_0.X + A_1.X, num11 + num8), ImGui.ColorConvertFloat4ToU32(랽.랾(A_7, 0.14f)));
			windowDrawList.AddRectFilled(new Vector2(num9, num11), new Vector2(num9 + num10, num11 + num8), num);
			windowDrawList.AddRect(A_0, new Vector2(A_0.X + A_1.X, A_0.Y + A_1.Y), num2, A_2, 0, A_4);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0009F948 File Offset: 0x0009DB48
		private static string 럎(랃.랾 A_0)
		{
			string result;
			switch (A_0)
			{
			case 랃.랾.럎:
				result = "Success";
				break;
			case 랃.랾.람:
				result = "Warning";
				break;
			case 랃.랾.럒:
				result = "Error";
				break;
			default:
				result = "Info";
				break;
			}
			return result;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0009F98C File Offset: 0x0009DB8C
		private static Vector4 람(랃.랾 A_0)
		{
			Vector4 result;
			switch (A_0)
			{
			case 랃.랾.럎:
				result = 랽.럎(랽.랾(ConfigFile.uiToastSuccessColor, new Color(0.34f, 0.89f, 0.65f, 1f)));
				break;
			case 랃.랾.람:
				result = 랽.럎(랽.랾(ConfigFile.uiToastWarningColor, new Color(1f, 0.79f, 0.42f, 1f)));
				break;
			case 랃.랾.럒:
				result = 랽.럎(랽.랾(ConfigFile.uiToastErrorColor, new Color(1f, 0.42f, 0.55f, 1f)));
				break;
			default:
				result = 랽.럎(랽.랾(ConfigFile.uiToastInfoColor, new Color(0.4f, 0.75f, 1f, 1f)));
				break;
			}
			return result;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0009FA60 File Offset: 0x0009DC60
		[return: TupleElementNames(new string[]
		{
			"accent",
			"icon",
			"label"
		})]
		private static ValueTuple<Vector4, string, string> 럒(랃.랾 A_0)
		{
			ValueTuple<Vector4, string, string> result;
			switch (A_0)
			{
			case 랃.랾.럎:
				result = new ValueTuple<Vector4, string, string>(랃.람(A_0), "[+]", "SUCCESS");
				break;
			case 랃.랾.람:
				result = new ValueTuple<Vector4, string, string>(랃.람(A_0), "[!]", "WARNING");
				break;
			case 랃.랾.럒:
				result = new ValueTuple<Vector4, string, string>(랃.람(A_0), "[x]", "ERROR");
				break;
			default:
				result = new ValueTuple<Vector4, string, string>(랃.람(A_0), "[i]", "INFO");
				break;
			}
			return result;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0003F8E1 File Offset: 0x0003DAE1
		private static Vector4 럼()
		{
			return 랽.럎(랽.랾(ConfigFile.uiToastBackgroundColor, new Color(0.07f, 0.09f, 0.13f, 0.95f)));
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0003F90B File Offset: 0x0003DB0B
		private static Vector4 랋()
		{
			return 랽.럎(랽.랾(ConfigFile.uiToastTitleColor, new Color(0.96f, 0.97f, 1f, 1f)));
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0003F935 File Offset: 0x0003DB35
		private static Vector4 랉()
		{
			return 랽.럎(랽.랾(ConfigFile.uiToastMessageColor, new Color(0.69f, 0.75f, 0.85f, 1f)));
		}

		// Token: 0x04000569 RID: 1385
		private static readonly List<랃.럎> 랾 = new List<랃.럎>();

		// Token: 0x0400056A RID: 1386
		private static readonly List<랃.람> 랾 = new List<랃.람>();

		// Token: 0x0400056B RID: 1387
		private static readonly object 랾 = new object();

		// Token: 0x0400056C RID: 1388
		private const float 랾 = 0.3f;

		// Token: 0x0400056D RID: 1389
		private const float 럎 = 0.5f;

		// Token: 0x0400056E RID: 1390
		private const float 람 = 4f;

		// Token: 0x0400056F RID: 1391
		private const int 랾 = 5;

		// Token: 0x04000570 RID: 1392
		private const int 럎 = 500;

		// Token: 0x04000571 RID: 1393
		private static string 랾 = string.Empty;

		// Token: 0x04000572 RID: 1394
		private static bool 랾 = true;

		// Token: 0x04000573 RID: 1395
		private static bool 럎 = true;

		// Token: 0x04000574 RID: 1396
		private static bool 람 = true;

		// Token: 0x04000575 RID: 1397
		private static bool 럒 = true;

		// Token: 0x04000576 RID: 1398
		private static bool 럼 = true;

		// Token: 0x04000577 RID: 1399
		private static int 람 = -1;

		// Token: 0x020000AD RID: 173
		private enum 랾
		{
			// Token: 0x04000579 RID: 1401
			랾,
			// Token: 0x0400057A RID: 1402
			럎,
			// Token: 0x0400057B RID: 1403
			람,
			// Token: 0x0400057C RID: 1404
			럒
		}

		// Token: 0x020000AE RID: 174
		private sealed class 럎
		{
			// Token: 0x0400057D RID: 1405
			public string 랾 = string.Empty;

			// Token: 0x0400057E RID: 1406
			public string 럎 = string.Empty;

			// Token: 0x0400057F RID: 1407
			public 랃.랾 랾;

			// Token: 0x04000580 RID: 1408
			public float 랾;

			// Token: 0x04000581 RID: 1409
			public float 럎;

			// Token: 0x04000582 RID: 1410
			public float 람;
		}

		// Token: 0x020000AF RID: 175
		private sealed class 람
		{
			// Token: 0x04000583 RID: 1411
			public DateTime 랾;

			// Token: 0x04000584 RID: 1412
			public string 랾 = string.Empty;

			// Token: 0x04000585 RID: 1413
			public string 럎 = string.Empty;

			// Token: 0x04000586 RID: 1414
			public 랃.랾 랾;
		}
	}
}
