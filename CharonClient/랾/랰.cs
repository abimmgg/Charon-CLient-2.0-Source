using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using CharonClient.Configuration;
using ImGuiNET;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200013B RID: 315
	internal static class 랰
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x000B8B4C File Offset: 0x000B6D4C
		public static void 랾()
		{
			랰.럎();
			bool 럑 = 럧.럑;
			List<랰.랾> list = 랰.랾(럑);
			if (랰.랾 < 0 || 랰.랾 >= list.Count)
			{
				랰.랾 = 0;
			}
			List<란> list2 = 랰.랾(럑, list[랰.랾]);
			란 란 = 랰.람(list2);
			ImGui.TextWrapped("Browse, favorite, and run chat commands here without typing them manually. This can also be used by typing '/help' in-game.");
			ImGui.Separator();
			랰.랾(list);
			ImGui.Separator();
			ImGui.BeginChild("##commandBrowserLeft", new Vector2(330f, 0f));
			랰.랾(list2);
			ImGui.EndChild();
			ImGui.SameLine();
			ImGui.BeginChild("##commandBrowserRight", new Vector2(0f, 0f));
			랰.럎(란);
			ImGui.EndChild();
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000B8C04 File Offset: 0x000B6E04
		private static void 랾(List<랰.랾> A_0)
		{
			ImGui.PushItemWidth(250f);
			ImGui.InputTextWithHint("##commandSearch", "Search command or description...", ref 랰.랾, 256U);
			ImGui.PopItemWidth();
			ImGui.SameLine();
			ImGui.PushItemWidth(170f);
			if (ImGui.BeginCombo("##commandCategory", A_0[랰.랾].랾()))
			{
				for (int i = 0; i < A_0.Count; i++)
				{
					bool flag = i == 랰.랾;
					if (ImGui.Selectable(A_0[i].랾(), flag))
					{
						랰.랾 = i;
					}
					if (flag)
					{
						ImGui.SetItemDefaultFocus();
					}
				}
				ImGui.EndCombo();
			}
			ImGui.PopItemWidth();
			ImGui.SameLine();
			if (ImGui.SmallButton("Clear Filters"))
			{
				랰.랾 = string.Empty;
				랰.랾 = 0;
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000B8CCC File Offset: 0x000B6ECC
		private static void 랾(List<란> A_0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Commands: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_0.Count);
			ImGui.TextDisabled(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.Separator();
			if (ImGui.CollapsingHeader("All Matching Commands", 32))
			{
				if (A_0.Count == 0)
				{
					ImGui.TextDisabled("No commands matched your search/filter.");
					return;
				}
				foreach (란 란 in A_0)
				{
					랰.랾(란);
				}
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000B8D6C File Offset: 0x000B6F6C
		private static void 럎(List<란> A_0)
		{
			List<란> list = A_0.Where(new Func<란, bool>(랰.럎.랾.랾)).OrderBy(new Func<란, string>(랰.럎.랾.럎)).ToList<란>();
			if (list.Count == 0)
			{
				ImGui.TextDisabled("No favorite commands in the current filter.");
				return;
			}
			foreach (란 란 in list)
			{
				랰.랾(란);
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000B8E1C File Offset: 0x000B701C
		private static void 랾(란 A_0)
		{
			bool flag = string.Equals(A_0.랾(), 랰.람, StringComparison.OrdinalIgnoreCase);
			if (ImGui.Selectable((랰.랾.Contains(A_0.랾()) ? "[*]" : "[ ]") + " " + A_0.랾() + (A_0.럼() ? " [DEV]" : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()), flag))
			{
				랰.람 = A_0.랾();
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000B8E90 File Offset: 0x000B7090
		private static void 럎(란 A_0)
		{
			if (A_0 == null)
			{
				ImGui.TextDisabled("Select a command to see details.");
				return;
			}
			bool flag = 랰.랾.Contains(A_0.랾());
			ImGui.TextColored(new Vector4(0.5f, 0.85f, 1f, 1f), A_0.랾());
			ImGui.SameLine();
			if (ImGui.SmallButton(flag ? "Unfavorite" : "Favorite"))
			{
				랰.럎(A_0.랾());
			}
			ImGui.TextDisabled("Category: " + 랰.랾(A_0.람()));
			if (A_0.럼())
			{
				ImGui.TextColored(new Vector4(1f, 0.7f, 0.35f, 1f), "Developer only");
			}
			if (A_0.럒())
			{
				ImGui.TextColored(new Vector4(1f, 1f, 0.55f, 1f), "This command expects arguments.");
			}
			ImGui.Separator();
			ImGui.TextWrapped(A_0.럎());
			ImGui.Separator();
			ImGui.Text("Command Input");
			ImGui.PushItemWidth(-1f);
			ImGui.InputTextWithHint("##commandInput", "Type the full command here...", ref 랰.럎, 512U);
			ImGui.PopItemWidth();
			if (ImGui.Button("Use Command"))
			{
				랰.럎 = 랰.랋(A_0);
			}
			ImGui.SameLine();
			if (ImGui.Button("Run"))
			{
				랰.럒(A_0);
			}
			ImGui.SameLine();
			if (ImGui.Button("Help"))
			{
				랰.랾("/help " + A_0.랾());
			}
			ImGui.SameLine();
			if (ImGui.Button("Copy Name"))
			{
				ImGui.SetClipboardText(A_0.랾());
				랰.럒("Copied " + A_0.랾());
			}
			ImGui.SameLine();
			if (ImGui.Button("Copy Input"))
			{
				string text = 랰.럼(A_0);
				ImGui.SetClipboardText(text);
				랰.럒("Copied " + text);
			}
			ImGui.Separator();
			랰.람(A_0);
			if (랰.랾 > 0f)
			{
				랰.랾 -= Time.deltaTime;
				ImGui.Separator();
				ImGui.TextColored(new Vector4(0.55f, 1f, 0.55f, 1f), 랰.럒);
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000B90C0 File Offset: 0x000B72C0
		private static void 람(란 A_0)
		{
			ImGui.TextDisabled("Quick Actions");
			if (!A_0.럒())
			{
				if (ImGui.Button("Run " + A_0.랾()))
				{
					랰.랾(A_0.랾());
				}
			}
			else
			{
				ImGui.TextWrapped("This command needs arguments. Use 'Use Command' to prefill the input, then edit and run it.");
			}
			if (A_0.랾() == "/help")
			{
				ImGui.SameLine();
				if (ImGui.Button("Run /help"))
				{
					랰.랾("/help");
				}
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000B913C File Offset: 0x000B733C
		private static void 럒(란 A_0)
		{
			string text = 랰.럼(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				랰.럒("Command input is empty.");
				return;
			}
			랰.랾(text);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000B916C File Offset: 0x000B736C
		private static void 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				랰.럒("Command input is empty.");
				return;
			}
			if (!A_0.StartsWith("/"))
			{
				A_0 = "/" + A_0;
			}
			if (ControllerHelper.chatUI == null)
			{
				랰.럒("Chat UI is not available right now.");
				return;
			}
			ControllerHelper.chatUI.Submit(A_0);
			랰.람(A_0.Split(' ', StringSplitOptions.None)[0]);
			랰.럒("Ran " + A_0);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000B91EC File Offset: 0x000B73EC
		private static void 럎(string A_0)
		{
			if (랰.랾.Contains(A_0))
			{
				랰.랾.Remove(A_0);
				랰.럒("Removed " + A_0 + " from favorites");
			}
			else
			{
				랰.랾.Add(A_0);
				랰.럒("Added " + A_0 + " to favorites");
			}
			랰.럒();
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000B9250 File Offset: 0x000B7450
		private static void 람(string A_0)
		{
			랰.람 람 = new 랰.람();
			람.랾 = A_0;
			랰.랾.RemoveAll(new Predicate<string>(람.랾));
			랰.랾.Insert(0, 람.랾);
			if (랰.랾.Count > 12)
			{
				랰.랾.RemoveAt(랰.랾.Count - 1);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000B92B8 File Offset: 0x000B74B8
		private static List<랰.랾> 랾(bool A_0)
		{
			List<랰.랾> list = new List<랰.랾>
			{
				new 랰.랾("All Categories", null),
				new 랰.랾("Info", new 랬?(랬.랾)),
				new 랰.랾("Navigation", new 랬?(랬.럎)),
				new 랰.랾("Player", new 랬?(랬.람)),
				new 랰.랾("Currency", new 랬?(랬.럒)),
				new 랰.랾("Items", new 랬?(랬.럼)),
				new 랰.랾("Drop", new 랬?(랬.랋)),
				new 랰.랾("Trash", new 랬?(랬.랉)),
				new 랰.랾("World Admin", new 랬?(랬.럐)),
				new 랰.랾("UI", new 랬?(랬.랓)),
				new 랰.랾("Death", new 랬?(랬.럯)),
				new 랰.랾("Pet", new 랬?(랬.럭)),
				new 랰.랾("Misc", new 랬?(랬.랱))
			};
			if (A_0)
			{
				list.Add(new 랰.랾("Dev", new 랬?(랬.럙)));
			}
			return list;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000B940C File Offset: 0x000B760C
		private static List<란> 랾(bool A_0, 랰.랾 A_1)
		{
			랰.럒 럒 = new 랰.럒();
			럒.랾 = A_1;
			IEnumerable<란> source = 럇.랾(A_0);
			if (럒.랾.럎() != null)
			{
				source = source.Where(new Func<란, bool>(럒.랾));
			}
			if (!string.IsNullOrWhiteSpace(랰.랾))
			{
				랰.럼 럼 = new 랰.럼();
				럼.랾 = 랰.랾.Trim();
				source = source.Where(new Func<란, bool>(럼.랾));
			}
			return source.OrderByDescending(new Func<란, bool>(랰.럎.랾.람)).ThenBy(new Func<란, string>(랰.럎.랾.럒)).ToList<란>();
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000B94D8 File Offset: 0x000B76D8
		private static 란 람(List<란> A_0)
		{
			if (A_0.Count == 0)
			{
				랰.람 = string.Empty;
				return null;
			}
			란 란 = A_0.FirstOrDefault(new Func<란, bool>(랰.럎.랾.럼));
			if (란 == null)
			{
				란 = A_0[0];
				랰.람 = 란.랾();
			}
			return 란;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000B9538 File Offset: 0x000B7738
		private static string 럼(란 A_0)
		{
			string text = 랰.럎;
			string text2 = ((text != null) ? text.Trim() : null) ?? string.Empty;
			if (string.IsNullOrWhiteSpace(text2) && A_0 != null)
			{
				text2 = 랰.랋(A_0);
			}
			return text2;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		private static string 랋(란 A_0)
		{
			if (A_0 == null)
			{
				return string.Empty;
			}
			if (!A_0.럒())
			{
				return A_0.랾();
			}
			return A_0.랾() + " ";
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000B9574 File Offset: 0x000B7774
		private static string 랾(랬 A_0)
		{
			string result;
			if (A_0 == 랬.럐)
			{
				result = "World Admin";
			}
			else
			{
				result = A_0.ToString();
			}
			return result;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x000B959C File Offset: 0x000B779C
		private static void 럎()
		{
			if (랰.랾)
			{
				return;
			}
			if (랰.랾 == null)
			{
				랰.랾 = string.Empty;
			}
			if (랰.럎 == null)
			{
				랰.럎 = string.Empty;
			}
			if (랰.람 == null)
			{
				랰.람 = string.Empty;
			}
			if (랰.럒 == null)
			{
				랰.럒 = string.Empty;
			}
			랰.람();
			랰.랾 = true;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000B9600 File Offset: 0x000B7800
		private static void 람()
		{
			랰.랾.Clear();
			string text = ConfigFile.chatCommandFavorites ?? string.Empty;
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			foreach (string text2 in text.Split('|', StringSplitOptions.RemoveEmptyEntries))
			{
				랰.랾.Add(text2.Trim());
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00041E1A File Offset: 0x0004001A
		private static void 럒()
		{
			ConfigFile.chatCommandFavorites = string.Join("|", 랰.랾.OrderBy(new Func<string, string>(랰.럎.랾.랾)));
			ConfigFile.럼();
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00041E59 File Offset: 0x00040059
		private static void 럒(string A_0)
		{
			랰.럒 = (A_0 ?? string.Empty);
			랰.랾 = 3f;
		}

		// Token: 0x0400074B RID: 1867
		private static readonly List<string> 랾 = new List<string>();

		// Token: 0x0400074C RID: 1868
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400074D RID: 1869
		private static bool 랾;

		// Token: 0x0400074E RID: 1870
		private static string 랾 = string.Empty;

		// Token: 0x0400074F RID: 1871
		private static string 럎 = string.Empty;

		// Token: 0x04000750 RID: 1872
		private static string 람 = string.Empty;

		// Token: 0x04000751 RID: 1873
		private static string 럒 = string.Empty;

		// Token: 0x04000752 RID: 1874
		private static float 랾;

		// Token: 0x04000753 RID: 1875
		private static int 랾;

		// Token: 0x04000754 RID: 1876
		private const int 럎 = 12;

		// Token: 0x0200013C RID: 316
		private sealed class 랾
		{
			// Token: 0x06000A76 RID: 2678 RVA: 0x00041E74 File Offset: 0x00040074
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x00041E7C File Offset: 0x0004007C
			[CompilerGenerated]
			public 랬? 럎()
			{
				return this.랾;
			}

			// Token: 0x06000A78 RID: 2680 RVA: 0x00041E84 File Offset: 0x00040084
			public 랾(string A_1, 랬? A_2)
			{
				this.랾 = A_1;
				this.랾 = A_2;
			}

			// Token: 0x04000755 RID: 1877
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000756 RID: 1878
			[CompilerGenerated]
			private readonly 랬? 랾;
		}

		// Token: 0x0200013D RID: 317
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x06000A7B RID: 2683 RVA: 0x00041EA6 File Offset: 0x000400A6
			internal bool 랾(란 A_1)
			{
				return 랰.랾.Contains(A_1.랾());
			}

			// Token: 0x06000A7C RID: 2684 RVA: 0x0003D01B File Offset: 0x0003B21B
			internal string 럎(란 A_1)
			{
				return A_1.랾();
			}

			// Token: 0x06000A7D RID: 2685 RVA: 0x00041EA6 File Offset: 0x000400A6
			internal bool 람(란 A_1)
			{
				return 랰.랾.Contains(A_1.랾());
			}

			// Token: 0x06000A7E RID: 2686 RVA: 0x0003D01B File Offset: 0x0003B21B
			internal string 럒(란 A_1)
			{
				return A_1.랾();
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00041EB8 File Offset: 0x000400B8
			internal bool 럼(란 A_1)
			{
				return string.Equals(A_1.랾(), 랰.람, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x06000A80 RID: 2688 RVA: 0x0003CAD1 File Offset: 0x0003ACD1
			internal string 랾(string A_1)
			{
				return A_1;
			}

			// Token: 0x04000757 RID: 1879
			public static readonly 랰.럎 랾 = new 랰.럎();

			// Token: 0x04000758 RID: 1880
			public static Func<란, bool> 랾;

			// Token: 0x04000759 RID: 1881
			public static Func<란, string> 랾;

			// Token: 0x0400075A RID: 1882
			public static Func<란, bool> 럎;

			// Token: 0x0400075B RID: 1883
			public static Func<란, string> 럎;

			// Token: 0x0400075C RID: 1884
			public static Func<란, bool> 람;

			// Token: 0x0400075D RID: 1885
			public static Func<string, string> 랾;
		}

		// Token: 0x0200013E RID: 318
		[CompilerGenerated]
		private sealed class 람
		{
			// Token: 0x06000A82 RID: 2690 RVA: 0x00041ECB File Offset: 0x000400CB
			internal bool 랾(string A_1)
			{
				return string.Equals(A_1, this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x0400075E RID: 1886
			public string 랾;
		}

		// Token: 0x0200013F RID: 319
		[CompilerGenerated]
		private sealed class 럒
		{
			// Token: 0x06000A84 RID: 2692 RVA: 0x000B96AC File Offset: 0x000B78AC
			internal bool 랾(란 A_1)
			{
				return A_1.람() == this.랾.럎().Value;
			}

			// Token: 0x0400075F RID: 1887
			public 랰.랾 랾;
		}

		// Token: 0x02000140 RID: 320
		[CompilerGenerated]
		private sealed class 럼
		{
			// Token: 0x06000A86 RID: 2694 RVA: 0x00041EDA File Offset: 0x000400DA
			internal bool 랾(란 A_1)
			{
				return A_1.랾().Contains(this.랾, StringComparison.OrdinalIgnoreCase) || A_1.럎().Contains(this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000760 RID: 1888
			public string 랾;
		}
	}
}
