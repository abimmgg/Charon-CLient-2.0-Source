using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using CharonClient.Configuration;
using Il2CppSystem.Collections.Generic;
using ImGuiNET;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000088 RID: 136
	internal static class 랪
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x000933F0 File Offset: 0x000915F0
		public static void 랾()
		{
			랪.랓();
			if (ImGui.SmallButton(랪.랾 ? "Hide Help" : "Help?"))
			{
				랪.랾 = !랪.랾;
			}
			ImGui.Checkbox("Packet Match Notifications", ref ConfigFile.packetManipulatorNotifications);
			if (랪.랾)
			{
				ImGui.BeginChild("##pktmaniphelp", new Vector2(0f, 280f));
				ImGui.TextColored(new Vector4(1f, 0.8f, 0.3f, 1f), "Packet Manipulator Help");
				ImGui.Separator();
				ImGui.TextWrapped("This tool lets you change packet fields automatically when a specific packet is seen.");
				ImGui.TextWrapped("You make a rule, choose which packet ID it should target, then choose which fields to replace.");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "Basic Steps:");
				ImGui.BulletText("1. Enter a Rule Name so you know what the rule is for.");
				ImGui.BulletText("2. Enter the Packet ID you want to target, for example WREU.");
				ImGui.BulletText("3. Choose whether the rule should affect Incoming packets, Outgoing packets, or both.");
				ImGui.BulletText("4. Add one or more field rows below.");
				ImGui.BulletText("5. In each row, enter the field name on the left and the new value on the right.");
				ImGui.BulletText("6. Click Add Rule to save it.");
				ImGui.BulletText("7. Make sure the rule is enabled in the saved rules list.");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "What Incoming / Outgoing Means:");
				ImGui.BulletText("Incoming = packets coming from the server to your game.");
				ImGui.BulletText("Outgoing = packets your game sends to the server.");
				ImGui.BulletText("If you are changing something the server sends you, use Incoming.");
				ImGui.BulletText("If you are changing something your client sends out, use Outgoing.");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "Field Values:");
				ImGui.BulletText("0 -> integer number");
				ImGui.BulletText("1.5 -> decimal number");
				ImGui.BulletText("true / false -> boolean");
				ImGui.BulletText("hello -> text");
				ImGui.BulletText("[0,1,2] -> integer array");
				ImGui.BulletText("[\"a\",\"b\"] -> text array");
				ImGui.BulletText("playerposx / playerposy -> your current tile position");
				ImGui.BulletText("playerposx+1 / playerposy-1 -> your current tile position with an offset");
				ImGui.BulletText("worldname / playerid / playername -> built-in variables");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "Example:");
				ImGui.TextWrapped("If a packet with ID WREU comes in and you want T and WREgA to become 0:");
				ImGui.BulletText("Rule Name: WREU Zero");
				ImGui.BulletText("Packet ID: WREU");
				ImGui.BulletText("Incoming: On");
				ImGui.BulletText("Outgoing: Off");
				ImGui.BulletText("Field 1: T = 0");
				ImGui.BulletText("Field 2: WREgA = 0");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.3f, 0.8f, 1f, 1f), "Saved Rules / Sharing:");
				ImGui.BulletText("Add Rule saves the current editor values as a rule.");
				ImGui.BulletText("Load Selected puts a saved rule back into the editor so you can edit it.");
				ImGui.BulletText("Update Selected overwrites the currently selected saved rule.");
				ImGui.BulletText("Export Selected / Export All puts rules into the text box for sharing.");
				ImGui.BulletText("Copy Buffer copies that text so you can send it to other people.");
				ImGui.BulletText("Paste Clipboard + Import Buffer loads shared rules from other people.");
				ImGui.Separator();
				ImGui.TextColored(new Vector4(1f, 0.45f, 0.45f, 1f), "Important:");
				ImGui.TextWrapped("Wrong packet edits can break features, desync things, or crash parts of the game. Test new rules carefully and only enable one new rule at a time when possible.");
				ImGui.EndChild();
			}
			랪.럎();
			ImGui.Separator();
			랪.람();
			ImGui.Separator();
			랪.럒();
			ImGui.Separator();
			랪.럼();
			if (랪.랾 > 0f)
			{
				랪.랾 -= Time.deltaTime;
				ImGui.TextColored(new Vector4(0.5f, 1f, 0.5f, 1f), 랪.랾);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00093744 File Offset: 0x00091944
		public static void 랾(BSONObject A_0, string A_1)
		{
			if (A_0 == null || 랪.랾.Count == 0)
			{
				return;
			}
			string text = 럘.랾(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			bool flag = string.Equals(A_1, "Server", StringComparison.OrdinalIgnoreCase);
			bool flag2 = string.Equals(A_1, "Client", StringComparison.OrdinalIgnoreCase);
			for (int i = 0; i < 랪.랾.Count; i++)
			{
				랪.럎 럎 = 랪.랾[i];
				if (럎.랾 && string.Equals(럎.럎, text, StringComparison.OrdinalIgnoreCase) && (!flag || 럎.럎) && (!flag2 || 럎.람))
				{
					랪.랾(A_0, 럎);
				}
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000937EC File Offset: 0x000919EC
		public static bool 럎(BSONObject A_0, string A_1)
		{
			if (A_0 == null || 랪.랾.Count == 0)
			{
				return false;
			}
			string text = 럘.랾(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			for (int i = 0; i < 랪.랾.Count; i++)
			{
				랪.럎 럎 = 랪.랾[i];
				if (랪.랾(럎, text, A_1))
				{
					if (럎.럒)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 3);
						defaultInterpolatedStringHandler.AppendLiteral("[Packet Manipulator] Blocked ");
						defaultInterpolatedStringHandler.AppendFormatted(A_1);
						defaultInterpolatedStringHandler.AppendLiteral(" [");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral("] via rule \"");
						defaultInterpolatedStringHandler.AppendFormatted(럎.랾);
						defaultInterpolatedStringHandler.AppendLiteral("\"");
						럽.럎(defaultInterpolatedStringHandler.ToStringAndClear());
						if (ConfigFile.packetManipulatorNotifications)
						{
							string text2 = "Packet Manipulator";
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(29, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("Blocked ");
							defaultInterpolatedStringHandler2.AppendFormatted(A_1);
							defaultInterpolatedStringHandler2.AppendLiteral(" packet ");
							defaultInterpolatedStringHandler2.AppendFormatted(text);
							defaultInterpolatedStringHandler2.AppendLiteral(" with rule \"");
							defaultInterpolatedStringHandler2.AppendFormatted(럎.랾);
							defaultInterpolatedStringHandler2.AppendLiteral("\"");
							랃.랾(text2, defaultInterpolatedStringHandler2.ToStringAndClear(), 4f);
						}
						return true;
					}
					랪.랾(A_0, 럎);
					if (ConfigFile.packetManipulatorNotifications)
					{
						string text3 = "Packet Manipulator";
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(30, 3);
						defaultInterpolatedStringHandler3.AppendLiteral("Modified ");
						defaultInterpolatedStringHandler3.AppendFormatted(A_1);
						defaultInterpolatedStringHandler3.AppendLiteral(" packet ");
						defaultInterpolatedStringHandler3.AppendFormatted(text);
						defaultInterpolatedStringHandler3.AppendLiteral(" with rule \"");
						defaultInterpolatedStringHandler3.AppendFormatted(럎.랾);
						defaultInterpolatedStringHandler3.AppendLiteral("\"");
						랃.랾(text3, defaultInterpolatedStringHandler3.ToStringAndClear(), 4f);
					}
				}
			}
			return false;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000939B8 File Offset: 0x00091BB8
		private static bool 랾(랪.럎 A_0, string A_1, string A_2)
		{
			if (A_0 == null || !A_0.랾 || string.IsNullOrWhiteSpace(A_0.럎))
			{
				return false;
			}
			if (!string.Equals(A_0.럎, A_1, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			bool flag = string.Equals(A_2, "Server", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "Incoming", StringComparison.OrdinalIgnoreCase);
			bool flag2 = string.Equals(A_2, "Client", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "Outgoing", StringComparison.OrdinalIgnoreCase);
			return (flag || flag2) && (!flag || A_0.럎) && (!flag2 || A_0.람);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00093A50 File Offset: 0x00091C50
		private static void 럎()
		{
			ImGui.Text("Rule Editor");
			ImGui.PushItemWidth(180f);
			ImGui.InputTextWithHint("##ruleName", "Rule Name", ref 랪.랾.랾, 128U);
			ImGui.PopItemWidth();
			ImGui.SameLine();
			ImGui.PushItemWidth(120f);
			ImGui.InputTextWithHint("##rulePacketId", "Packet ID", ref 랪.랾.럎, 64U);
			ImGui.PopItemWidth();
			ImGui.Checkbox("Enabled", ref 랪.랾.랾);
			ImGui.SameLine();
			ImGui.Checkbox("Incoming", ref 랪.랾.럎);
			ImGui.SameLine();
			ImGui.Checkbox("Outgoing", ref 랪.랾.람);
			ImGui.SameLine();
			ImGui.Checkbox("Block Packet", ref 랪.랾.럒);
			if (랪.랾.럒)
			{
				ImGui.TextDisabled("Matching packets will be dropped before field edits are applied.");
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Fields: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(랪.럒);
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.SameLine();
			if (ImGui.SmallButton("+##pktmanipfields") && 랪.럒 < 8)
			{
				랪.럒++;
			}
			ImGui.SameLine();
			if (ImGui.SmallButton("-##pktmanipfields") && 랪.럒 > 1)
			{
				랪.럒--;
			}
			ImGui.Separator();
			for (int i = 0; i < 랪.럒; i++)
			{
				랪.랾 랾 = 랪.랾.랾[i];
				if (랾.랾 == null)
				{
					랾.랾 = string.Empty;
				}
				랾 = 랪.랾.랾[i];
				if (랾.럎 == null)
				{
					랾.럎 = string.Empty;
				}
				ImGui.PushItemWidth(120f);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("##pmk");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(i);
				ImGui.InputTextWithHint(defaultInterpolatedStringHandler2.ToStringAndClear(), "key", ref 랪.랾.랾[i].랾, 100U);
				ImGui.PopItemWidth();
				ImGui.SameLine();
				ImGui.TextDisabled("[" + 랪.람(랪.랾.랾[i].럎) + "]");
				ImGui.SameLine();
				ImGui.PushItemWidth(ImGui.GetContentRegionAvail().X);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler3.AppendLiteral("##pmv");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(i);
				ImGui.InputTextWithHint(defaultInterpolatedStringHandler3.ToStringAndClear(), "value", ref 랪.랾.랾[i].럎, 200U);
				ImGui.PopItemWidth();
			}
			ImGui.Separator();
			if (ImGui.Button("Add Rule"))
			{
				랪.랾.Add(랪.랾.랾());
				랪.람 = 랪.랾.Count - 1;
				랪.럭();
				랪.랋("Rule added.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Update Selected"))
			{
				if (랪.랉())
				{
					랪.랾[랪.람] = 랪.랾.랾();
					랪.럭();
					랪.랋("Selected rule updated.");
				}
				else
				{
					랪.랋("No rule selected.");
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Load Selected"))
			{
				if (랪.랉())
				{
					랪.랾 = 랪.랾[랪.람].랾();
					랪.럒 = Math.Max(1, 랪.럒(랪.랾));
					랪.랋("Selected rule loaded into editor.");
				}
				else
				{
					랪.랋("No rule selected.");
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Clear Draft"))
			{
				랪.랾 = 랪.럐();
				랪.럒 = 2;
				랪.랋("Draft cleared.");
			}
			ImGui.SameLine();
			if (ImGui.BeginCombo("##pktmanippresets", "Presets"))
			{
				if (ImGui.Selectable("Spoof OS"))
				{
					랪.랾 = 랪.럐();
					랪.랾.랾 = "Spoof Operating System";
					랪.랾.럎 = "VChk";
					랪.랾.럎 = false;
					랪.랾.람 = true;
					랪.랾.럒 = false;
					랪.랾.랾[0].랾 = "OS";
					랪.랾.랾[0].럎 = "Linux";
					랪.랾.랾[1].랾 = "OSt";
					랪.랾.랾[1].럎 = "4";
					랪.랾.랾[2].랾 = "sdid";
					랪.랾.랾[2].럎 = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
					랪.럒 = 3;
					랪.랋("Preset loaded into editor.");
				}
				if (ImGui.Selectable("Block HB"))
				{
					랪.랾 = 랪.럐();
					랪.랾.랾 = "Block HB";
					랪.랾.럎 = "HB";
					랪.랾.럎 = false;
					랪.랾.람 = true;
					랪.랾.럒 = true;
					랪.럒 = 2;
					랪.랋("Preset loaded into editor.");
				}
				if (ImGui.Selectable("WREU Zero (Array Example)"))
				{
					랪.랾("WREU Zero", "WREU", true, false, new ValueTuple<string, string>[]
					{
						new ValueTuple<string, string>("T", "0"),
						new ValueTuple<string, string>("WREgA", "0")
					});
				}
				ImGui.EndCombo();
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00093FF0 File Offset: 0x000921F0
		private static void 람()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Enabled Rules (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(랪.랾.Count(new Func<랪.럎, bool>(랪.람.랾.랾)));
			defaultInterpolatedStringHandler.AppendLiteral(")");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.BeginChild("##enabledRules", new Vector2(0f, 100f));
			bool flag = false;
			for (int i = 0; i < 랪.랾.Count; i++)
			{
				랪.럎 럎 = 랪.랾[i];
				if (럎.랾)
				{
					flag = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(11, 4);
					defaultInterpolatedStringHandler2.AppendFormatted(럎.랾);
					defaultInterpolatedStringHandler2.AppendLiteral(" -> ");
					defaultInterpolatedStringHandler2.AppendFormatted(럎.럎);
					defaultInterpolatedStringHandler2.AppendLiteral(" [");
					defaultInterpolatedStringHandler2.AppendFormatted(랪.럎(럎));
					defaultInterpolatedStringHandler2.AppendLiteral("] :: ");
					defaultInterpolatedStringHandler2.AppendFormatted(랪.랾(럎));
					ImGui.TextWrapped(defaultInterpolatedStringHandler2.ToStringAndClear());
				}
			}
			if (!flag)
			{
				ImGui.TextDisabled("No enabled rules.");
			}
			ImGui.EndChild();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00094128 File Offset: 0x00092328
		private static void 럒()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Saved Rules (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(랪.랾.Count);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.BeginChild("##savedRules", new Vector2(0f, 180f));
			for (int i = 0; i < 랪.랾.Count; i++)
			{
				랪.럎 럎 = 랪.랾[i];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 5);
				defaultInterpolatedStringHandler2.AppendFormatted(럎.랾 ? "[ON]" : "[OFF]");
				defaultInterpolatedStringHandler2.AppendLiteral(" ");
				defaultInterpolatedStringHandler2.AppendFormatted(럎.랾);
				defaultInterpolatedStringHandler2.AppendLiteral(" -> ");
				defaultInterpolatedStringHandler2.AppendFormatted(럎.럎);
				defaultInterpolatedStringHandler2.AppendLiteral(" [");
				defaultInterpolatedStringHandler2.AppendFormatted(랪.럎(럎));
				defaultInterpolatedStringHandler2.AppendLiteral("]##rule");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(i);
				if (ImGui.Selectable(defaultInterpolatedStringHandler2.ToStringAndClear(), 랪.람 == i))
				{
					랪.람 = i;
				}
			}
			ImGui.EndChild();
			if (ImGui.Button("Enable/Disable Selected"))
			{
				if (랪.랉())
				{
					랪.랾[랪.람].랾 = !랪.랾[랪.람].랾;
					랪.럭();
					랪.랋("Rule " + (랪.랾[랪.람].랾 ? "enabled" : "disabled") + ".");
				}
				else
				{
					랪.랋("No rule selected.");
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Copy Selected"))
			{
				if (랪.랉())
				{
					랪.럎 럎2 = 랪.랾[랪.람].랾();
					럎2.랾 += " Copy";
					랪.랾.Add(럎2);
					랪.람 = 랪.랾.Count - 1;
					랪.럭();
					랪.랋("Rule copied.");
				}
				else
				{
					랪.랋("No rule selected.");
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Remove Selected"))
			{
				if (랪.랉())
				{
					랪.랾.RemoveAt(랪.람);
					if (랪.람 >= 랪.랾.Count)
					{
						랪.람 = 랪.랾.Count - 1;
					}
					랪.럭();
					랪.랋("Rule removed.");
					return;
				}
				랪.랋("No rule selected.");
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000943C4 File Offset: 0x000925C4
		private static void 럼()
		{
			ImGui.Text("Import / Export");
			ImGui.PushItemWidth(ImGui.GetContentRegionAvail().X);
			ImGui.InputTextMultiline("##pktmanipio", ref 랪.럎, 32768U, new Vector2(0f, 140f));
			ImGui.PopItemWidth();
			if (ImGui.Button("Export Selected"))
			{
				if (랪.랉())
				{
					랪.럎 = 랪.람(랪.랾[랪.람]);
					랪.랋("Selected rule exported.");
				}
				else
				{
					랪.랋("No rule selected.");
				}
			}
			ImGui.SameLine();
			if (ImGui.Button("Export All"))
			{
				랪.럎 = 랪.랾(랪.랾);
				랪.랋("All rules exported.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Copy Buffer"))
			{
				ImGui.SetClipboardText(랪.럎 ?? string.Empty);
				랪.랋("Buffer copied to clipboard.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Paste Clipboard"))
			{
				랪.럎 = (ImGui.GetClipboardText() ?? string.Empty);
				랪.랋("Clipboard pasted into buffer.");
			}
			ImGui.SameLine();
			if (ImGui.Button("Import Buffer"))
			{
				List<랪.럎> list;
				string text;
				if (랪.랾(랪.럎, out list, out text))
				{
					랪.랾.AddRange(list);
					if (랪.람 < 0 && 랪.랾.Count > 0)
					{
						랪.람 = 0;
					}
					랪.럭();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Imported ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
					defaultInterpolatedStringHandler.AppendLiteral(" rule(s).");
					랪.랋(defaultInterpolatedStringHandler.ToStringAndClear());
					return;
				}
				랪.랋(text);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0009456C File Offset: 0x0009276C
		private static void 랾(BSONObject A_0, 랪.럎 A_1)
		{
			for (int i = 0; i < A_1.랾.Count; i++)
			{
				string text = A_1.랾[i].랾;
				string text2 = (text != null) ? text.Trim() : null;
				string text3 = A_1.랾[i].럎;
				string text4 = ((text3 != null) ? text3.Trim() : null) ?? string.Empty;
				if (!string.IsNullOrWhiteSpace(text2))
				{
					랪.랾(A_0, text2, text4);
				}
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000945E4 File Offset: 0x000927E4
		private static void 랾(BSONObject A_0, string A_1, string A_2)
		{
			if (!A_0.ContainsKey(A_1))
			{
				A_0[A_1] = 랪.랾(A_2);
				return;
			}
			BSONValue bsonvalue = A_0[A_1];
			if (bsonvalue == null)
			{
				A_0[A_1] = 랪.랾(A_2);
				return;
			}
			if (bsonvalue.valueType == 2 && 랪.랾(bsonvalue, A_2))
			{
				return;
			}
			A_0[A_1] = 랪.랾(A_2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00094648 File Offset: 0x00092848
		private static bool 랾(BSONValue A_0, string A_1)
		{
			List<int> list;
			if (랪.랾(A_1, out list))
			{
				if (랪.랾(A_0, list))
				{
					return true;
				}
				if (랪.럎(A_0, list))
				{
					return true;
				}
			}
			int item;
			if (랪.랾(A_1, out item))
			{
				if (랪.랾(A_0, new List<int>
				{
					item
				}))
				{
					return true;
				}
				if (랪.럎(A_0, new List<int>
				{
					item
				}))
				{
					return true;
				}
			}
			List<string> list2;
			return 랪.랾(A_1, out list2) && 랪.랾(A_0, list2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000946C4 File Offset: 0x000928C4
		private static bool 랾(BSONValue A_0, List<int> A_1)
		{
			bool result;
			try
			{
				List<int> int32ListValue = A_0.int32ListValue;
				if (int32ListValue == null)
				{
					result = false;
				}
				else
				{
					int32ListValue.Clear();
					for (int i = 0; i < A_1.Count; i++)
					{
						int32ListValue.Add(A_1[i]);
					}
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00094720 File Offset: 0x00092920
		private static bool 럎(BSONValue A_0, List<int> A_1)
		{
			bool result;
			try
			{
				List<long> int64ListValue = A_0.int64ListValue;
				if (int64ListValue == null)
				{
					result = false;
				}
				else
				{
					int64ListValue.Clear();
					for (int i = 0; i < A_1.Count; i++)
					{
						int64ListValue.Add((long)A_1[i]);
					}
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0009477C File Offset: 0x0009297C
		private static bool 랾(BSONValue A_0, List<string> A_1)
		{
			bool result;
			try
			{
				List<string> stringListValue = A_0.stringListValue;
				if (stringListValue == null)
				{
					result = false;
				}
				else
				{
					stringListValue.Clear();
					for (int i = 0; i < A_1.Count; i++)
					{
						stringListValue.Add(A_1[i]);
					}
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000947D8 File Offset: 0x000929D8
		private static BSONValue 랾(string A_0)
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
			if (int.TryParse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture, out num))
			{
				return new BSONValue(num);
			}
			double num2;
			if (double.TryParse(A_0, NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
			{
				return new BSONValue(num2);
			}
			string text = A_0.ToLowerInvariant();
			if (text.StartsWith("playerposx") || text.StartsWith("playerposy"))
			{
				return new BSONValue(랪.럎(text));
			}
			if (text == "worldname")
			{
				World world = 럓.랾;
				return new BSONValue(((world != null) ? world.worldName : null) ?? string.Empty);
			}
			if (text == "playerid")
			{
				PlayerData playerData = 럓.랾;
				return new BSONValue(((playerData != null) ? playerData.playerId : null) ?? string.Empty);
			}
			if (text == "playername")
			{
				return new BSONValue(StaticPlayer.theRealPlayername ?? string.Empty);
			}
			return new BSONValue(A_0);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000948EC File Offset: 0x00092AEC
		private static int 럎(string A_0)
		{
			if (럓.랾 == null)
			{
				return 0;
			}
			int num = A_0.Contains("playerposx") ? 럓.랾.currentPlayerMapPoint.x : 럓.랾.currentPlayerMapPoint.y;
			if (A_0.Contains("+"))
			{
				string[] array = A_0.Split('+', StringSplitOptions.None);
				int num2;
				if (array.Length == 2 && int.TryParse(array[1].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out num2))
				{
					return num + num2;
				}
			}
			else if (A_0.Contains("-") && A_0.IndexOf('-') > 0)
			{
				string[] array2 = A_0.Split('-', StringSplitOptions.None);
				int num3;
				if (array2.Length == 2 && int.TryParse(array2[1].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out num3))
				{
					return num - num3;
				}
			}
			return num;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000949B4 File Offset: 0x00092BB4
		private static bool 랾(string A_0, out int A_1)
		{
			A_1 = 0;
			bool result;
			try
			{
				BSONValue bsonvalue = 랪.랾(A_0);
				if (bsonvalue == null)
				{
					result = false;
				}
				else
				{
					BSONValue.ValueType valueType = bsonvalue.valueType;
					if (valueType != null)
					{
						if (valueType != 7)
						{
							if (valueType != 8)
							{
								result = false;
							}
							else
							{
								A_1 = (int)bsonvalue.int64Value;
								result = true;
							}
						}
						else
						{
							A_1 = bsonvalue.int32Value;
							result = true;
						}
					}
					else
					{
						A_1 = (int)bsonvalue.doubleValue;
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00094A2C File Offset: 0x00092C2C
		private static bool 랾(string A_0, out List<int> A_1)
		{
			A_1 = null;
			if (string.IsNullOrWhiteSpace(A_0) || A_0[0] != '[' || A_0[A_0.Length - 1] != ']')
			{
				return false;
			}
			string text = A_0.Substring(1, A_0.Length - 2).Trim();
			if (string.IsNullOrWhiteSpace(text))
			{
				A_1 = new List<int>();
				return true;
			}
			string[] array = text.Split(',', StringSplitOptions.None);
			A_1 = new List<int>();
			for (int i = 0; i < array.Length; i++)
			{
				int item;
				if (!랪.랾(array[i].Trim(), out item))
				{
					return false;
				}
				A_1.Add(item);
			}
			return true;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00094AC4 File Offset: 0x00092CC4
		private static bool 랾(string A_0, out List<string> A_1)
		{
			A_1 = null;
			if (string.IsNullOrWhiteSpace(A_0) || A_0[0] != '[' || A_0[A_0.Length - 1] != ']')
			{
				return false;
			}
			string text = A_0.Substring(1, A_0.Length - 2).Trim();
			if (string.IsNullOrWhiteSpace(text))
			{
				A_1 = new List<string>();
				return true;
			}
			string[] array = text.Split(',', StringSplitOptions.None);
			A_1 = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				A_1.Add(array[i].Trim().Trim('"'));
			}
			return true;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00094B58 File Offset: 0x00092D58
		private static string 람(string A_0)
		{
			if (string.IsNullOrEmpty(A_0))
			{
				return "empty";
			}
			if (A_0.StartsWith("[") && A_0.EndsWith("]"))
			{
				return "arr";
			}
			bool flag;
			if (bool.TryParse(A_0, out flag))
			{
				return "bool";
			}
			int num;
			if (int.TryParse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture, out num))
			{
				return "int";
			}
			double num2;
			if (double.TryParse(A_0, NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
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

		// Token: 0x0600058B RID: 1419 RVA: 0x00094C20 File Offset: 0x00092E20
		private static string 랋()
		{
			string value = (랪.랾.럎 && 랪.랾.람) ? "incoming/outgoing" : (랪.랾.럎 ? "incoming" : (랪.랾.람 ? "outgoing" : "disabled"));
			if (랪.랾.럒)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Rule: ");
				defaultInterpolatedStringHandler.AppendFormatted(랪.랾.랾);
				defaultInterpolatedStringHandler.AppendLiteral(" -> BLOCK ");
				defaultInterpolatedStringHandler.AppendFormatted(랪.랾.럎);
				defaultInterpolatedStringHandler.AppendLiteral(" (");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			List<string> list = new List<string>();
			for (int i = 0; i < 랪.럒; i++)
			{
				string text = 랪.랾.랾[i].랾;
				string text2 = (text != null) ? text.Trim() : null;
				string text3 = 랪.랾.랾[i].럎;
				string str = (text3 != null) ? text3.Trim() : null;
				if (!string.IsNullOrWhiteSpace(text2))
				{
					list.Add(text2 + "=" + str);
				}
			}
			if (list.Count == 0)
			{
				return "No override fields set.";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(17, 4);
			defaultInterpolatedStringHandler2.AppendLiteral("Rule: ");
			defaultInterpolatedStringHandler2.AppendFormatted(랪.랾.랾);
			defaultInterpolatedStringHandler2.AppendLiteral(" -> ");
			defaultInterpolatedStringHandler2.AppendFormatted(랪.랾.럎);
			defaultInterpolatedStringHandler2.AppendLiteral(" (");
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			defaultInterpolatedStringHandler2.AppendLiteral(") -> ");
			defaultInterpolatedStringHandler2.AppendFormatted(string.Join(", ", list));
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00094DF4 File Offset: 0x00092FF4
		private static string 랾(랪.럎 A_0)
		{
			if (A_0.럒)
			{
				return "BLOCK PACKET";
			}
			List<string> list = new List<string>();
			for (int i = 0; i < A_0.랾.Count; i++)
			{
				string text = A_0.랾[i].랾;
				string text2 = (text != null) ? text.Trim() : null;
				string text3 = A_0.랾[i].럎;
				string str = (text3 != null) ? text3.Trim() : null;
				if (!string.IsNullOrWhiteSpace(text2))
				{
					list.Add(text2 + "=" + str);
				}
			}
			if (list.Count != 0)
			{
				return string.Join(", ", list);
			}
			return "(no fields)";
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0003F0F5 File Offset: 0x0003D2F5
		private static string 럎(랪.럎 A_0)
		{
			if (A_0.럎 && A_0.람)
			{
				return "In/Out";
			}
			if (A_0.럎)
			{
				return "In";
			}
			if (A_0.람)
			{
				return "Out";
			}
			return "Off";
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00094E9C File Offset: 0x0009309C
		private static string 랾(List<랪.럎> A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < A_0.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append(랪.람(A_0[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00094EE4 File Offset: 0x000930E4
		private static string 람(랪.럎 A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("PacketManipulatorRule");
			stringBuilder.AppendLine("Name=" + 랪.럒(A_0.랾));
			stringBuilder.AppendLine("PacketId=" + 랪.럒(A_0.럎));
			stringBuilder.AppendLine("Enabled=" + A_0.랾.ToString(CultureInfo.InvariantCulture));
			stringBuilder.AppendLine("Incoming=" + A_0.럎.ToString(CultureInfo.InvariantCulture));
			stringBuilder.AppendLine("Outgoing=" + A_0.람.ToString(CultureInfo.InvariantCulture));
			stringBuilder.AppendLine("BlockPacket=" + A_0.럒.ToString(CultureInfo.InvariantCulture));
			for (int i = 0; i < A_0.랾.Count; i++)
			{
				string text = A_0.랾[i].랾;
				string text2 = (text != null) ? text.Trim() : null;
				string text3 = A_0.랾[i].럎 ?? string.Empty;
				if (!string.IsNullOrWhiteSpace(text2))
				{
					stringBuilder.AppendLine("Field=" + 랪.럒(text2) + "|" + 랪.럒(text3));
				}
			}
			stringBuilder.AppendLine("EndRule");
			return stringBuilder.ToString();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0009504C File Offset: 0x0009324C
		private static bool 랾(string A_0, out List<랪.럎> A_1, out string A_2)
		{
			A_1 = new List<랪.럎>();
			A_2 = string.Empty;
			if (string.IsNullOrWhiteSpace(A_0))
			{
				A_2 = "Import buffer is empty.";
				return false;
			}
			string[] array = A_0.Split('\n', StringSplitOptions.None);
			랪.럎 럎 = null;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (!string.IsNullOrWhiteSpace(text))
				{
					if (text == "PacketManipulatorRule")
					{
						럎 = 랪.럐();
						럎.랾.Clear();
					}
					else if (text == "EndRule")
					{
						if (럎 != null)
						{
							랪.럼(럎);
							A_1.Add(럎);
							럎 = null;
						}
					}
					else if (럎 != null)
					{
						int num = text.IndexOf('=');
						if (num > 0)
						{
							string text2 = text.Substring(0, num);
							string text3 = text.Substring(num + 1);
							if (text2 != null)
							{
								switch (text2.Length)
								{
								case 4:
									if (text2 == "Name")
									{
										럎.랾 = 랪.럼(text3);
									}
									break;
								case 5:
									if (text2 == "Field")
									{
										int num2 = text3.IndexOf('|');
										if (num2 > -1)
										{
											럎.랾.Add(new 랪.랾
											{
												랾 = 랪.럼(text3.Substring(0, num2)),
												럎 = 랪.럼(text3.Substring(num2 + 1))
											});
										}
									}
									break;
								case 7:
									if (text2 == "Enabled")
									{
										bool.TryParse(text3, out 럎.랾);
									}
									break;
								case 8:
								{
									char c = text2[0];
									if (c != 'I')
									{
										if (c != 'O')
										{
											if (c == 'P')
											{
												if (text2 == "PacketId")
												{
													럎.럎 = 랪.럼(text3);
												}
											}
										}
										else if (text2 == "Outgoing")
										{
											bool.TryParse(text3, out 럎.람);
										}
									}
									else if (text2 == "Incoming")
									{
										bool.TryParse(text3, out 럎.럎);
									}
									break;
								}
								case 11:
									if (text2 == "BlockPacket")
									{
										bool.TryParse(text3, out 럎.럒);
									}
									break;
								}
							}
						}
					}
				}
			}
			if (A_1.Count == 0)
			{
				A_2 = "No valid rules found in import buffer.";
				return false;
			}
			return true;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0003F12E File Offset: 0x0003D32E
		private static string 럒(string A_0)
		{
			return Uri.EscapeDataString(A_0 ?? string.Empty);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0003F13F File Offset: 0x0003D33F
		private static string 럼(string A_0)
		{
			return Uri.UnescapeDataString(A_0 ?? string.Empty);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000952E0 File Offset: 0x000934E0
		private static void 랾(string A_0, string A_1, bool A_2, bool A_3, [TupleElementNames(new string[]
		{
			"key",
			"value"
		})] params ValueTuple<string, string>[] fields)
		{
			랪.랾 = 랪.럐();
			랪.랾.랾 = A_0;
			랪.랾.럎 = A_1;
			랪.랾.럎 = A_2;
			랪.랾.람 = A_3;
			for (int i = 0; i < 8; i++)
			{
				랪.랾.랾[i].랾 = ((i < fields.Length) ? fields[i].Item1 : string.Empty);
				랪.랾.랾[i].럎 = ((i < fields.Length) ? fields[i].Item2 : string.Empty);
			}
			랪.럒 = Math.Max(fields.Length, 2);
			랪.랋("Preset loaded into editor.");
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0003F150 File Offset: 0x0003D350
		private static void 랋(string A_0)
		{
			랪.랾 = (A_0 ?? string.Empty);
			랪.랾 = 3f;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0003F16B File Offset: 0x0003D36B
		private static bool 랉()
		{
			return 랪.람 >= 0 && 랪.람 < 랪.랾.Count;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000953A8 File Offset: 0x000935A8
		private static int 럒(랪.럎 A_0)
		{
			int val = 0;
			for (int i = 0; i < A_0.랾.Count; i++)
			{
				if (!string.IsNullOrWhiteSpace(A_0.랾[i].랾))
				{
					val = i + 1;
				}
			}
			return Math.Max(val, 2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0003F188 File Offset: 0x0003D388
		private static 랪.럎 럐()
		{
			랪.럎 럎 = new 랪.럎();
			랪.럼(럎);
			return 럎;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000953F0 File Offset: 0x000935F0
		private static void 럼(랪.럎 A_0)
		{
			while (A_0.랾.Count < 8)
			{
				A_0.랾.Add(new 랪.랾());
			}
			for (int i = 0; i < A_0.랾.Count; i++)
			{
				랪.랾 랾 = A_0.랾[i];
				if (랾.랾 == null)
				{
					랾.랾 = string.Empty;
				}
				랾 = A_0.랾[i];
				if (랾.럎 == null)
				{
					랾.럎 = string.Empty;
				}
			}
			if (A_0.랾 == null)
			{
				A_0.랾 = string.Empty;
			}
			if (A_0.럎 == null)
			{
				A_0.럎 = string.Empty;
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000954A0 File Offset: 0x000936A0
		private static void 랓()
		{
			if (랪.랾 == null)
			{
				랪.랾 = 랪.럐();
			}
			랪.럼(랪.랾);
			if (랪.럒 < 1)
			{
				랪.럒 = 1;
			}
			else if (랪.럒 > 8)
			{
				랪.럒 = 8;
			}
			if (랪.랾 == null)
			{
				랪.랾 = string.Empty;
			}
			if (랪.럎 == null)
			{
				랪.럎 = string.Empty;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00095508 File Offset: 0x00093708
		public static void 럯()
		{
			랪.랓();
			랪.랾.Clear();
			랪.람 = -1;
			if (!ConfigFile.packetManipulatorRememberRules)
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(ConfigFile.packetManipulatorRules))
			{
				return;
			}
			List<랪.럎> collection;
			string str;
			if (랪.랾(ConfigFile.packetManipulatorRules, out collection, out str))
			{
				랪.랾.AddRange(collection);
				if (랪.랾.Count > 0)
				{
					랪.람 = 0;
					return;
				}
			}
			else
			{
				Console.WriteLine("[Charon] Failed to load packet manipulator rules: " + str);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0003F195 File Offset: 0x0003D395
		public static void 럭()
		{
			랪.랓();
			if (!ConfigFile.packetManipulatorRememberRules)
			{
				ConfigFile.packetManipulatorRules = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				랪.랱();
				return;
			}
			ConfigFile.packetManipulatorRules = 랪.랾(랪.랾);
			랪.랱();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0003F1C7 File Offset: 0x0003D3C7
		private static void 랱()
		{
			ConfigFile.럼();
			if (!string.IsNullOrWhiteSpace(ConfigFile.랾()) && !string.Equals(ConfigFile.랾(), "Default", StringComparison.OrdinalIgnoreCase))
			{
				ConfigFile.람(ConfigFile.랾());
			}
		}

		// Token: 0x040004F7 RID: 1271
		private const int 랾 = 8;

		// Token: 0x040004F8 RID: 1272
		private const int 럎 = 32768;

		// Token: 0x040004F9 RID: 1273
		private static readonly List<랪.럎> 랾 = new List<랪.럎>();

		// Token: 0x040004FA RID: 1274
		private static 랪.럎 랾 = 랪.럐();

		// Token: 0x040004FB RID: 1275
		private static bool 랾;

		// Token: 0x040004FC RID: 1276
		private static int 람 = -1;

		// Token: 0x040004FD RID: 1277
		private static int 럒 = 2;

		// Token: 0x040004FE RID: 1278
		private static string 랾 = string.Empty;

		// Token: 0x040004FF RID: 1279
		private static float 랾;

		// Token: 0x04000500 RID: 1280
		private static string 럎 = string.Empty;

		// Token: 0x02000089 RID: 137
		private sealed class 랾
		{
			// Token: 0x0600059E RID: 1438 RVA: 0x0003F22D File Offset: 0x0003D42D
			public 랪.랾 랾()
			{
				return new 랪.랾
				{
					랾 = (this.랾 ?? string.Empty),
					럎 = (this.럎 ?? string.Empty)
				};
			}

			// Token: 0x04000501 RID: 1281
			public string 랾 = string.Empty;

			// Token: 0x04000502 RID: 1282
			public string 럎 = string.Empty;
		}

		// Token: 0x0200008A RID: 138
		private sealed class 럎
		{
			// Token: 0x060005A0 RID: 1440 RVA: 0x00095580 File Offset: 0x00093780
			public 랪.럎 랾()
			{
				랪.럎 럎 = new 랪.럎
				{
					랾 = (this.랾 ?? string.Empty),
					럎 = (this.럎 ?? string.Empty),
					랾 = this.랾,
					럎 = this.럎,
					람 = this.람,
					럒 = this.럒
				};
				럎.랾.Clear();
				for (int i = 0; i < this.랾.Count; i++)
				{
					럎.랾.Add(this.랾[i].랾());
				}
				랪.럼(럎);
				return 럎;
			}

			// Token: 0x04000503 RID: 1283
			public string 랾 = "New_Rule";

			// Token: 0x04000504 RID: 1284
			public string 럎 = "Packet_ID";

			// Token: 0x04000505 RID: 1285
			public bool 랾 = true;

			// Token: 0x04000506 RID: 1286
			public bool 럎 = true;

			// Token: 0x04000507 RID: 1287
			public bool 람;

			// Token: 0x04000508 RID: 1288
			public bool 럒;

			// Token: 0x04000509 RID: 1289
			public readonly List<랪.랾> 랾 = new List<랪.랾>(8);
		}

		// Token: 0x0200008B RID: 139
		[CompilerGenerated]
		[Serializable]
		private sealed class 람
		{
			// Token: 0x060005A4 RID: 1444 RVA: 0x0003F2C0 File Offset: 0x0003D4C0
			internal bool 랾(랪.럎 A_1)
			{
				return A_1.랾;
			}

			// Token: 0x0400050A RID: 1290
			public static readonly 랪.람 랾 = new 랪.람();

			// Token: 0x0400050B RID: 1291
			public static Func<랪.럎, bool> 랾;
		}
	}
}
