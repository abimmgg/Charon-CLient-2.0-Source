using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using ImGuiNET;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200009C RID: 156
	internal static class 랡
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0009AF8C File Offset: 0x0009918C
		public static void 랾()
		{
			ImGui.TextColored(new Vector4(1f, 0.4f, 0.4f, 1f), "Warning: May not refresh your inventory. I suggest typing /rg after buying anything to refresh the game. If it fails to purchase then lower the amount as it may block them due to mass packets being sent.");
			if (럓.랾 == null)
			{
				ImGui.Text("Player data unavailable.");
				return;
			}
			랡.랉();
			랡.럎();
			랡.람();
			랡.럼();
			랡.랋();
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0009AFE8 File Offset: 0x000991E8
		private static void 럎()
		{
			PlayerData playerData = 럓.랾;
			int value = (playerData != null) ? playerData.gems : 0;
			int value2 = 랡.랓();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Gems: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value, "n0");
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			ImGui.SameLine();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("Byte Coins: ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(value2, "n0");
			ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
			ImGui.SameLine();
			if (ImGui.SmallButton("Refresh Catalog"))
			{
				랡.럐();
			}
			ImGui.TextDisabled(랡.랾);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0009B090 File Offset: 0x00099290
		private static void 람()
		{
			Dictionary<string, List<랡.럎>> dictionary = 랡.럒();
			ImGui.SeparatorText("Categories");
			if (ImGui.BeginTable("ShopCategoryGrid", 8, 32768))
			{
				for (int i = 0; i < 랡.랾.Length; i++)
				{
					if (i % 8 == 0)
					{
						ImGui.TableNextRow();
					}
					ImGui.TableSetColumnIndex(i % 8);
					string text = 랡.랾[i];
					List<랡.럎> list;
					int value = dictionary.TryGetValue(text, out list) ? list.Count : 0;
					bool flag = string.Equals(랡.럎, text, StringComparison.OrdinalIgnoreCase);
					if (flag)
					{
						ImGui.PushStyleColor(21, new Vector4(0.16f, 0.55f, 0.95f, 0.85f));
						ImGui.PushStyleColor(22, new Vector4(0.21f, 0.62f, 1f, 0.95f));
						ImGui.PushStyleColor(23, new Vector4(0.11f, 0.48f, 0.86f, 1f));
					}
					Vector2 vector = new Vector2(Math.Max(1f, ImGui.GetContentRegionAvail().X), 48f);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value);
					defaultInterpolatedStringHandler.AppendLiteral(" items");
					if (ImGui.Button(defaultInterpolatedStringHandler.ToStringAndClear(), vector))
					{
						랡.럎 = text;
					}
					if (flag)
					{
						ImGui.PopStyleColor(3);
					}
				}
				ImGui.EndTable();
			}
			List<랡.럎> list2;
			if (!dictionary.TryGetValue(랡.럎, out list2))
			{
				list2 = new List<랡.럎>();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler2.AppendFormatted(랡.럎);
			defaultInterpolatedStringHandler2.AppendLiteral(" (");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(list2.Count);
			defaultInterpolatedStringHandler2.AppendLiteral(")");
			ImGui.SeparatorText(defaultInterpolatedStringHandler2.ToStringAndClear());
			if (list2.Count == 0)
			{
				ImGui.TextDisabled("No shop data discovered for this category yet.");
				return;
			}
			랡.랾(list2);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0009B264 File Offset: 0x00099464
		private static void 랾(List<랡.럎> A_0)
		{
			if (!ImGui.BeginTable("ShopItemsTable", 5, 34752))
			{
				return;
			}
			ImGui.TableSetupColumn("Item");
			ImGui.TableSetupColumn("Price");
			ImGui.TableSetupColumn("Owned Currency");
			ImGui.TableSetupColumn("Amount");
			ImGui.TableSetupColumn("Buy");
			ImGui.TableHeadersRow();
			foreach (랡.럎 럎 in A_0)
			{
				ImGui.TableNextRow();
				ImGui.TableNextColumn();
				ImGui.TextUnformatted(럎.럎());
				ImGui.TextDisabled(럎.랾());
				ImGui.TableNextColumn();
				int num = 랡.럒(럎.랾());
				int num2 = checked(럎.럒() * Math.Max(1, num));
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2, "n0");
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(럎.랉());
				ImGui.TextUnformatted(defaultInterpolatedStringHandler.ToStringAndClear());
				ImGui.TableNextColumn();
				int num3 = 랡.랾(럎.럼());
				Vector4 vector = (num3 >= num2) ? new Vector4(0.55f, 1f, 0.55f, 1f) : new Vector4(1f, 0.55f, 0.55f, 1f);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler2.AppendFormatted<int>(num3, "n0");
				ImGui.TextColored(vector, defaultInterpolatedStringHandler2.ToStringAndClear());
				ImGui.TableNextColumn();
				ImGui.PushID(럎.랾());
				int value = num;
				if (ImGui.InputInt("##Amount", ref value))
				{
					랡.랾[럎.랾()] = Math.Clamp(value, 1, 200);
				}
				ImGui.TableNextColumn();
				if (ImGui.Button("Buy"))
				{
					랡.랾(럎, Math.Clamp(랡.랾[럎.랾()], 1, 200));
				}
				ImGui.PopID();
			}
			ImGui.EndTable();
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0009B474 File Offset: 0x00099674
		private static Dictionary<string, List<랡.럎>> 럒()
		{
			Dictionary<string, List<랡.럎>> dictionary = new Dictionary<string, List<랡.럎>>(StringComparer.OrdinalIgnoreCase);
			foreach (string key in 랡.랾)
			{
				dictionary[key] = new List<랡.럎>();
			}
			foreach (랡.럎 럎 in 랡.랾)
			{
				string key2 = string.IsNullOrWhiteSpace(럎.람()) ? "Other" : 럎.람();
				List<랡.럎> list;
				if (!dictionary.TryGetValue(key2, out list))
				{
					list = new List<랡.럎>();
					dictionary[key2] = list;
				}
				list.Add(럎);
			}
			using (Dictionary<string, List<랡.럎>>.ValueCollection.Enumerator enumerator2 = dictionary.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Sort(new Comparison<랡.럎>(랡.랉.랾.랾));
				}
			}
			return dictionary;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0009B594 File Offset: 0x00099794
		private static void 럼()
		{
			ImGui.SeparatorText("Custom Purchase");
			ImGui.TextWrapped("If the live catalog misses an item, you can still buy it directly with the packet ID. You can get the packet ID by buying the item once, checking your console for the ID, and adding it inside of the input box.");
			ImGui.InputText("IPId", ref 랡.람, 128U);
			ImGui.InputInt("Amount", ref 랡.럒);
			랡.럒 = Math.Clamp(랡.럒, 1, 200);
			if (ImGui.Button("Buy Custom Item"))
			{
				if (string.IsNullOrWhiteSpace(랡.람))
				{
					랡.랾 = "Enter an IPId first.";
					return;
				}
				랡.랾(랡.람.Trim(), 랡.럒);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0009B628 File Offset: 0x00099828
		private static void 랋()
		{
			if (랡.랾)
			{
				ImGui.OpenPopup("Confirm Shop Purchase");
				랡.랾 = false;
			}
			bool flag = true;
			if (!ImGui.BeginPopupModal("Confirm Shop Purchase", ref flag, 64))
			{
				return;
			}
			if (랡.랾 == null)
			{
				ImGui.TextDisabled("No pending purchase.");
				if (ImGui.Button("Close"))
				{
					ImGui.CloseCurrentPopup();
				}
				ImGui.EndPopup();
				return;
			}
			ImGui.TextWrapped("Check the purchase details below before sending any shop packets.");
			ImGui.Separator();
			ImGui.Text("Item: " + 랡.랾.럎());
			ImGui.TextDisabled(랡.랾.랾());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Amount: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(랡.랾.람());
			ImGui.Text(defaultInterpolatedStringHandler.ToStringAndClear());
			if (랡.랾.럒() > 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("Total Cost: ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(랡.랾.럒(), "n0");
				defaultInterpolatedStringHandler2.AppendLiteral(" ");
				defaultInterpolatedStringHandler2.AppendFormatted(랡.랾.랉());
				ImGui.Text(defaultInterpolatedStringHandler2.ToStringAndClear());
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler3.AppendLiteral("Balance: ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(랡.랾.랋(), "n0");
				defaultInterpolatedStringHandler3.AppendLiteral(" ");
				defaultInterpolatedStringHandler3.AppendFormatted(랡.랾.랉());
				ImGui.Text(defaultInterpolatedStringHandler3.ToStringAndClear());
				bool flag2 = 랡.랾.랋() >= 랡.랾.럒();
				ImGui.TextColored(flag2 ? new Vector4(0.55f, 1f, 0.55f, 1f) : new Vector4(1f, 0.55f, 0.55f, 1f), flag2 ? "Affordable" : "Not enough currency");
			}
			else
			{
				ImGui.TextDisabled("Price unknown for this custom item.");
			}
			ImGui.Separator();
			if (ImGui.Button("Confirm Buy"))
			{
				랡.럎(랡.랾.랾(), 랡.랾.람());
				랡.랾 = null;
				ImGui.CloseCurrentPopup();
			}
			ImGui.SameLine();
			if (ImGui.Button("Cancel"))
			{
				랡.랾 = null;
				ImGui.CloseCurrentPopup();
			}
			ImGui.EndPopup();
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0003F4F7 File Offset: 0x0003D6F7
		private static void 랉()
		{
			if (랡.럎 >= 0f && Time.realtimeSinceStartup < 랡.럎)
			{
				return;
			}
			랡.럐();
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0009B874 File Offset: 0x00099A74
		private static void 럐()
		{
			랡.럎 = Time.realtimeSinceStartup + 15f;
			try
			{
				Dictionary<string, 랡.럎> dictionary = new Dictionary<string, 랡.럎>(StringComparer.OrdinalIgnoreCase);
				랡.럎(dictionary);
				랡.랾(dictionary);
				랡.랾.Clear();
				랡.랾.AddRange(dictionary.Values.OrderBy(new Func<랡.럎, int>(랡.랉.랾.랾)).ThenBy(new Func<랡.럎, string>(랡.랉.랾.럎), StringComparer.OrdinalIgnoreCase));
				foreach (랡.럎 럎 in 랡.랾)
				{
					if (!랡.랾.ContainsKey(럎.랾()))
					{
						랡.랾[럎.랾()] = 1;
					}
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Catalog refreshed: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(랡.랾.Count);
				defaultInterpolatedStringHandler.AppendLiteral(" items.");
				랡.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			catch (Exception ex)
			{
				랡.랾 = "Catalog refresh failed: " + ex.Message;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0009B9F0 File Offset: 0x00099BF0
		private static void 랾(IDictionary<string, 랡.럎> A_0)
		{
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				if (!(assembly == null) && !assembly.IsDynamic && (assembly.GetName().Name ?? string.Empty).Equals("Assembly-CSharp", StringComparison.OrdinalIgnoreCase))
				{
					foreach (Type type in 랡.랾(assembly))
					{
						if (랡.랾(type))
						{
							랡.랾(type, A_0);
						}
					}
				}
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0009BA9C File Offset: 0x00099C9C
		private static IEnumerable<Type> 랾(Assembly A_0)
		{
			IEnumerable<Type> result;
			try
			{
				result = A_0.GetTypes();
			}
			catch (ReflectionTypeLoadException ex)
			{
				result = ex.Types.Where(new Func<Type, bool>(랡.랉.랾.랾));
			}
			catch
			{
				result = Array.Empty<Type>();
			}
			return result;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0009BB04 File Offset: 0x00099D04
		private static bool 랾(Type A_0)
		{
			string text = A_0.FullName ?? A_0.Name;
			return text.Contains("Shop", StringComparison.OrdinalIgnoreCase) || text.Contains("Store", StringComparison.OrdinalIgnoreCase) || text.Contains("Pack", StringComparison.OrdinalIgnoreCase) || text.Contains("Inventory", StringComparison.OrdinalIgnoreCase) || text.Contains("Config", StringComparison.OrdinalIgnoreCase) || text.Contains("Menu", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0009BB78 File Offset: 0x00099D78
		private static void 랾(Type A_0, IDictionary<string, 랡.럎> A_1)
		{
			FieldInfo[] fields = A_0.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				랡.럐 럐 = new 랡.럐();
				럐.랾 = fields[i];
				if (랡.랾(럐.랾.Name, 럐.랾.FieldType))
				{
					랡.랾(랡.랾(new Func<object>(럐.랾)), A_0.Name + "." + 럐.랾.Name, 0, A_1, new HashSet<object>(ReferenceEqualityComparer.Instance));
				}
			}
			PropertyInfo[] properties = A_0.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < properties.Length; i++)
			{
				랡.랓 랓 = new 랡.랓();
				랓.랾 = properties[i];
				if (랓.랾.GetIndexParameters().Length == 0 && 랓.랾.CanRead && 랡.랾(랓.랾.Name, 랓.랾.PropertyType))
				{
					랡.랾(랡.랾(new Func<object>(랓.랾)), A_0.Name + "." + 랓.랾.Name, 0, A_1, new HashSet<object>(ReferenceEqualityComparer.Instance));
				}
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0009BCB0 File Offset: 0x00099EB0
		private static bool 랾(string A_0, Type A_1)
		{
			string text = A_0 ?? string.Empty;
			string text2;
			if ((text2 = ((A_1 != null) ? A_1.FullName : null)) == null)
			{
				text2 = (((A_1 != null) ? A_1.Name : null) ?? string.Empty);
			}
			string text3 = text2;
			return text.Contains("shop", StringComparison.OrdinalIgnoreCase) || text.Contains("pack", StringComparison.OrdinalIgnoreCase) || text.Contains("store", StringComparison.OrdinalIgnoreCase) || text.Contains("buy", StringComparison.OrdinalIgnoreCase) || text.Contains("category", StringComparison.OrdinalIgnoreCase) || text.Contains("inventory", StringComparison.OrdinalIgnoreCase) || text3.Contains("Shop", StringComparison.OrdinalIgnoreCase) || text3.Contains("Pack", StringComparison.OrdinalIgnoreCase) || text3.Contains("Store", StringComparison.OrdinalIgnoreCase) || typeof(IEnumerable).IsAssignableFrom(A_1);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0009BD84 File Offset: 0x00099F84
		private static void 랾(object A_0, string A_1, int A_2, IDictionary<string, 랡.럎> A_3, HashSet<object> A_4)
		{
			랡.럯 럯 = new 랡.럯();
			럯.랾 = A_0;
			if (럯.랾 == null || A_2 > 3)
			{
				return;
			}
			Type type = 럯.랾.GetType();
			if (type == typeof(string) || type.IsPrimitive || type.IsEnum)
			{
				return;
			}
			if (!type.IsValueType && !A_4.Add(럯.랾))
			{
				return;
			}
			랡.럎 럎 = 랡.랾(럯.랾, A_1);
			if (럎 != null)
			{
				A_3[럎.랾()] = 럎;
				return;
			}
			IEnumerable enumerable = 럯.랾 as IEnumerable;
			if (enumerable != null)
			{
				int num = 0;
				foreach (object obj in enumerable)
				{
					if (num++ >= 256)
					{
						break;
					}
					랡.랾(obj, A_1, A_2 + 1, A_3, A_4);
				}
				return;
			}
			랡.랾 랾 = 랡.럎(type);
			FieldInfo[] array = 랾.랾();
			for (int i = 0; i < array.Length; i++)
			{
				랡.럭 럭 = new 랡.럭();
				럭.랾 = 럯;
				럭.랾 = array[i];
				랡.랾(랡.랾(new Func<object>(럭.랾)), A_1 + "." + 럭.랾.Name, A_2 + 1, A_3, A_4);
			}
			PropertyInfo[] array2 = 랾.럎();
			for (int i = 0; i < array2.Length; i++)
			{
				랡.랱 랱 = new 랡.랱();
				랱.랾 = 럯;
				랱.랾 = array2[i];
				랡.랾(랡.랾(new Func<object>(랱.랾)), A_1 + "." + 랱.랾.Name, A_2 + 1, A_3, A_4);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0009BF64 File Offset: 0x0009A164
		private static 랡.럎 랾(object A_0, string A_1)
		{
			랡.랾 랾 = 랡.럎(A_0.GetType());
			int num = 랡.랾(A_0, 랾, new string[]
			{
				"purchasePrice",
				"price",
				"regularGems",
				"vipGems",
				"gems"
			});
			if (num <= 0)
			{
				return null;
			}
			string text = 랡.럎(A_0, 랾, new string[]
			{
				"IPId",
				"ipId",
				"itemPackId",
				"itemPackID",
				"packId",
				"productId",
				"identifier",
				"id"
			});
			string text2 = 랡.럎(A_0, 랾, new string[]
			{
				"title",
				"displayName",
				"itemName",
				"name",
				"Name"
			});
			string text3 = 랡.럎(A_0, 랾, new string[]
			{
				"category",
				"mainCategory",
				"subCategory",
				"shopCategory",
				"buttonAppearance"
			});
			object obj = 랡.람(A_0, 랾, new string[]
			{
				"regularItem",
				"vipItem",
				"item",
				"blockType"
			});
			if (string.IsNullOrWhiteSpace(text) && obj != null)
			{
				text = obj.ToString();
			}
			if (string.IsNullOrWhiteSpace(text2))
			{
				text2 = text;
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			랡.람 람 = 랡.럎(A_0, 랾, A_1);
			string text4 = 랡.랾(text3, text, text2, A_1);
			return new 랡.럎(text, 랡.랾(text2), text4, num, 람, A_1);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0009C0F4 File Offset: 0x0009A2F4
		private static 랡.랾 럎(Type A_0)
		{
			랡.랾 랾;
			if (랡.랾.TryGetValue(A_0, out 랾))
			{
				return 랾;
			}
			랡.랾 랾2 = new 랡.랾();
			랾2.랾(A_0.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<FieldInfo, bool>(랡.랉.랾.랾)).ToArray<FieldInfo>());
			랾2.랾(A_0.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<PropertyInfo, bool>(랡.랉.랾.랾)).ToArray<PropertyInfo>());
			랾 = 랾2;
			랡.랾[A_0] = 랾;
			return 랾;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0009C194 File Offset: 0x0009A394
		private static bool 럎(string A_0, Type A_1)
		{
			string text = A_0 ?? string.Empty;
			string text2;
			if ((text2 = ((A_1 != null) ? A_1.FullName : null)) == null)
			{
				text2 = (((A_1 != null) ? A_1.Name : null) ?? string.Empty);
			}
			string text3 = text2;
			return !text.Contains("NativeFieldInfoPtr", StringComparison.OrdinalIgnoreCase) && !text.Contains("MethodInfoStore", StringComparison.OrdinalIgnoreCase) && (text.Contains("price", StringComparison.OrdinalIgnoreCase) || text.Contains("currency", StringComparison.OrdinalIgnoreCase) || text.Contains("item", StringComparison.OrdinalIgnoreCase) || text.Contains("category", StringComparison.OrdinalIgnoreCase) || text.Contains("shop", StringComparison.OrdinalIgnoreCase) || text.Contains("pack", StringComparison.OrdinalIgnoreCase) || text.Contains("name", StringComparison.OrdinalIgnoreCase) || text.Contains("title", StringComparison.OrdinalIgnoreCase) || typeof(IEnumerable).IsAssignableFrom(A_1) || text3.Contains("Shop", StringComparison.OrdinalIgnoreCase) || text3.Contains("Pack", StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0009C298 File Offset: 0x0009A498
		private static int 랾(object A_0, 랡.랾 A_1, params string[] names)
		{
			foreach (string text in names)
			{
				object obj = 랡.랾(A_0, A_1, text);
				if (obj != null)
				{
					try
					{
						return Convert.ToInt32(obj);
					}
					catch
					{
					}
				}
			}
			return 0;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0009C2E8 File Offset: 0x0009A4E8
		private static string 럎(object A_0, 랡.랾 A_1, params string[] names)
		{
			foreach (string text in names)
			{
				object obj = 랡.랾(A_0, A_1, text);
				if (obj != null)
				{
					string text2 = obj.ToString();
					if (!string.IsNullOrWhiteSpace(text2))
					{
						return text2;
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0009C330 File Offset: 0x0009A530
		private static object 람(object A_0, 랡.랾 A_1, params string[] names)
		{
			foreach (string text in names)
			{
				object obj = 랡.랾(A_0, A_1, text);
				if (obj != null)
				{
					return obj;
				}
			}
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0009C360 File Offset: 0x0009A560
		private static object 랾(object A_0, 랡.랾 A_1, string A_2)
		{
			랡.럙 럙 = new 랡.럙();
			럙.랾 = A_2;
			럙.랾 = A_0;
			럙.랾 = A_1.랾().FirstOrDefault(new Func<FieldInfo, bool>(럙.랾));
			if (럙.랾 != null)
			{
				return 랡.랾(new Func<object>(럙.랾));
			}
			럙.랾 = A_1.럎().FirstOrDefault(new Func<PropertyInfo, bool>(럙.랾));
			if (럙.랾 != null)
			{
				return 랡.랾(new Func<object>(럙.럎));
			}
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0003F517 File Offset: 0x0003D717
		private static 랡.람 럎(object A_0, 랡.랾 A_1, string A_2)
		{
			object obj = 랡.랾(A_0, A_1, "purchaseCurrency") ?? 랡.랾(A_0, A_1, "currency");
			if ((((obj != null) ? obj.ToString() : null) ?? A_2).Contains("byte", StringComparison.OrdinalIgnoreCase))
			{
				return 랡.람.럎;
			}
			return 랡.람.랾;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0009C3FC File Offset: 0x0009A5FC
		private static string 랾(string A_0, string A_1, string A_2, string A_3)
		{
			if (!string.IsNullOrWhiteSpace(A_0))
			{
				string text = A_0.Trim();
				if (text != null)
				{
					switch (text.Length)
					{
					case 4:
					{
						char c = text[0];
						if (c <= 'K')
						{
							if (c != 'C')
							{
								if (c == 'K')
								{
									if (text == "Kits")
									{
										return "Kits";
									}
								}
							}
							else if (text == "Clan")
							{
								return "Clan Items";
							}
						}
						else if (c != 'O')
						{
							if (c == 'P')
							{
								if (text == "Pets")
								{
									return "Pets";
								}
							}
						}
						else if (text == "Orbs")
						{
							return "Orbs";
						}
						break;
					}
					case 5:
					{
						char c = text[0];
						if (c <= 'I')
						{
							if (c != 'C')
							{
								if (c == 'I')
								{
									if (text == "Items")
									{
										return "Special Items";
									}
								}
							}
							else if (text == "Cards")
							{
								return "Battle Cards";
							}
						}
						else if (c != 'L')
						{
							if (c == 'S')
							{
								if (text == "Seeds")
								{
									return "Seeds";
								}
							}
						}
						else if (text == "Locks")
						{
							return "Locks";
						}
						break;
					}
					case 6:
					{
						char c = text[0];
						if (c != 'T')
						{
							if (c == 'W')
							{
								if (text == "Wiring")
								{
									return "Wiring";
								}
							}
						}
						else if (text == "Themes")
						{
							return "Boosters";
						}
						break;
					}
					case 7:
						if (text == "Fishing")
						{
							return "Fishing";
						}
						break;
					case 9:
					{
						char c = text[0];
						if (c != 'C')
						{
							if (c == 'F')
							{
								if (text == "Familiars")
								{
									return "Familiars";
								}
							}
						}
						else if (text == "Community")
						{
							return "Community Items";
						}
						break;
					}
					case 10:
						if (text == "Blueprints")
						{
							return "Blueprints";
						}
						break;
					case 11:
						if (text == "FashionPack")
						{
							return "Wearables";
						}
						break;
					}
				}
			}
			string text2 = string.Join(" ", new string[]
			{
				A_0 ?? string.Empty,
				A_1 ?? string.Empty,
				A_2 ?? string.Empty,
				A_3 ?? string.Empty
			});
			if (랡.랾(text2, new string[]
			{
				"lock"
			}))
			{
				return "Locks";
			}
			if (랡.랾(text2, new string[]
			{
				"wearable",
				"shirt",
				"pants",
				"skirt",
				"outfit",
				"hair",
				"hat",
				"shoe",
				"cape",
				"mask",
				"glove",
				"dress"
			}))
			{
				return "Wearables";
			}
			if (랡.랾(text2, new string[]
			{
				"familiar"
			}))
			{
				return "Familiars";
			}
			if (랡.랾(text2, new string[]
			{
				"orb"
			}))
			{
				return "Orbs";
			}
			if (랡.랾(text2, new string[]
			{
				"wiring",
				"wire",
				"logic"
			}))
			{
				return "Wiring";
			}
			if (랡.랾(text2, new string[]
			{
				"blueprint"
			}))
			{
				return "Blueprints";
			}
			if (랡.랾(text2, new string[]
			{
				"clan"
			}))
			{
				return "Clan Items";
			}
			if (랡.랾(text2, new string[]
			{
				"booster"
			}))
			{
				return "Boosters";
			}
			if (랡.랾(text2, new string[]
			{
				"seed"
			}))
			{
				return "Seeds";
			}
			if (랡.랾(text2, new string[]
			{
				"fish",
				"bait",
				"lure",
				"rod"
			}))
			{
				return "Fishing";
			}
			if (랡.랾(text2, new string[]
			{
				"pet"
			}))
			{
				return "Pets";
			}
			if (랡.랾(text2, new string[]
			{
				"card"
			}))
			{
				return "Battle Cards";
			}
			if (랡.랾(text2, new string[]
			{
				"community"
			}))
			{
				return "Community Items";
			}
			if (랡.랾(text2, new string[]
			{
				"special",
				"vip",
				"mystery",
				"roulette"
			}))
			{
				return "Special Items";
			}
			if (랡.랾(text2, new string[]
			{
				"kit",
				"starter"
			}))
			{
				return "Kits";
			}
			return "Other";
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0009C914 File Offset: 0x0009AB14
		private static bool 랾(string A_0, params string[] needles)
		{
			랡.랫 랫 = new 랡.랫();
			랫.랾 = A_0;
			return needles.Any(new Func<string, bool>(랫.랾));
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0009C940 File Offset: 0x0009AB40
		private static string 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return "Unknown Item";
			}
			IEnumerable<string> source = Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(A_0.Replace('_', ' ').Replace('-', ' '), "([A-Z]+)([A-Z][a-z])", "$1 $2"), "([a-z0-9])([A-Z])", "$1 $2"), "(?i)(?<=[a-z])(booster|pack|kit|lock|orb|portal|rod|box|board|counter|modifier|terminal)$", " $1"), "(?i)(?<=[a-z])(world)(?=lock)", " $1"), "(?i)(?<=[0-9])(?=[A-Za-z])", " ").Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			Func<string, string> selector;
			if ((selector = 랡.랋.랾) == null)
			{
				selector = (랡.랋.랾 = new Func<string, string>(랡.럎));
			}
			string[] value = source.Select(selector).ToArray<string>();
			return string.Join(" ", value).Trim();
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0009CA00 File Offset: 0x0009AC00
		private static string 럎(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return A_0;
			}
			if (A_0.All(new Func<char, bool>(랡.랉.랾.랾)))
			{
				return A_0;
			}
			if (A_0.Length == 1)
			{
				return char.ToUpperInvariant(A_0[0]).ToString();
			}
			if (A_0.All(new Func<char, bool>(랡.랉.랾.럎)))
			{
				return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(A_0);
			}
			return char.ToUpperInvariant(A_0[0]).ToString() + A_0.Substring(1);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0009CAB8 File Offset: 0x0009ACB8
		private static int 람(string A_0)
		{
			랡.럍 럍 = new 랡.럍();
			럍.랾 = A_0;
			int num = Array.FindIndex<string>(랡.랾, new Predicate<string>(럍.랾));
			if (num < 0)
			{
				return int.MaxValue;
			}
			return num;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0009CAF4 File Offset: 0x0009ACF4
		private static int 럒(string A_0)
		{
			int value;
			if (!랡.랾.TryGetValue(A_0, out value))
			{
				value = 1;
				랡.랾[A_0] = value;
			}
			return Math.Clamp(value, 1, 200);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0003F556 File Offset: 0x0003D756
		private static int 랾(랡.람 A_0)
		{
			if (A_0 == 랡.람.럎)
			{
				return 랡.랓();
			}
			PlayerData playerData = 럓.랾;
			if (playerData == null)
			{
				return 0;
			}
			return playerData.gems;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0009CB2C File Offset: 0x0009AD2C
		private static int 랓()
		{
			object obj = 럓.랾;
			if (obj == null)
			{
				return 0;
			}
			foreach (string name in new string[]
			{
				"bytecoinBalance",
				"byteCoinBalance",
				"byteCoins",
				"bytecoins",
				"ByteCoins"
			})
			{
				PropertyInfo property = obj.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (property != null && property.CanRead)
				{
					try
					{
						return Convert.ToInt32(property.GetValue(obj));
					}
					catch
					{
					}
				}
				FieldInfo field = obj.GetType().GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (field != null)
				{
					try
					{
						return Convert.ToInt32(field.GetValue(obj));
					}
					catch
					{
					}
				}
			}
			return 0;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0009CC10 File Offset: 0x0009AE10
		private static void 랾(랡.럎 A_0, int A_1)
		{
			int num = Math.Clamp(A_1, 1, 200);
			int num2 = checked(A_0.럒() * num);
			랡.랾 = new 랡.럒(A_0.랾(), A_0.럎(), num, num2, A_0.럼(), 랡.랾(A_0.럼()));
			랡.랾 = true;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0009CC64 File Offset: 0x0009AE64
		private static void 랾(string A_0, int A_1)
		{
			int num = Math.Clamp(A_1, 1, 200);
			랡.랾 = new 랡.럒(A_0, 랡.랾(A_0), num, 0, 랡.람.랾, 0);
			랡.랾 = true;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0009CC9C File Offset: 0x0009AE9C
		private static void 럎(string A_0, int A_1)
		{
			int num = Math.Clamp(A_1, 1, 200);
			for (int i = 0; i < num; i++)
			{
				BSONObject bsonobject = new BSONObject();
				bsonobject["ID"] = "BIPack";
				bsonobject["IPId"] = A_0;
				OutgoingMessages.AddOneMessageToList(bsonobject);
			}
			럽.랾(A_0, num);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Sent BIPack x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" for ");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			랡.랾 = defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0009CD44 File Offset: 0x0009AF44
		private static object 랾(Func<object> A_0)
		{
			object result;
			try
			{
				result = A_0();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0009CD70 File Offset: 0x0009AF70
		private static void 럎(IDictionary<string, 랡.럎> A_0)
		{
			foreach (랡.럼 럼 in 랡.랾)
			{
				A_0[럼.랾()] = new 랡.럎(럼.랾(), 랡.랾(럼.랾()), 랡.럼(럼.럎()), 럼.람(), 럼.럒(), "Seed");
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0009CDE0 File Offset: 0x0009AFE0
		private static string 럼(string A_0)
		{
			if (A_0 != null)
			{
				switch (A_0.Length)
				{
				case 4:
				{
					char c = A_0[0];
					if (c <= 'K')
					{
						if (c != 'C')
						{
							if (c == 'K')
							{
								if (A_0 == "Kits")
								{
									return "Kits";
								}
							}
						}
						else if (A_0 == "Clan")
						{
							return "Clan Items";
						}
					}
					else if (c != 'O')
					{
						if (c == 'P')
						{
							if (A_0 == "Pets")
							{
								return "Pets";
							}
						}
					}
					else if (A_0 == "Orbs")
					{
						return "Orbs";
					}
					break;
				}
				case 5:
				{
					char c = A_0[0];
					if (c <= 'I')
					{
						if (c != 'C')
						{
							if (c == 'I')
							{
								if (A_0 == "Items")
								{
									return "Special Items";
								}
							}
						}
						else if (A_0 == "Cards")
						{
							return "Battle Cards";
						}
					}
					else if (c != 'L')
					{
						if (c == 'S')
						{
							if (A_0 == "Seeds")
							{
								return "Seeds";
							}
						}
					}
					else if (A_0 == "Locks")
					{
						return "Locks";
					}
					break;
				}
				case 6:
				{
					char c = A_0[0];
					if (c != 'T')
					{
						if (c == 'W')
						{
							if (A_0 == "Wiring")
							{
								return "Wiring";
							}
						}
					}
					else if (A_0 == "Themes")
					{
						return "Boosters";
					}
					break;
				}
				case 7:
					if (A_0 == "Fishing")
					{
						return "Fishing";
					}
					break;
				case 9:
				{
					char c = A_0[0];
					if (c != 'C')
					{
						if (c == 'F')
						{
							if (A_0 == "Familiars")
							{
								return "Familiars";
							}
						}
					}
					else if (A_0 == "Community")
					{
						return "Community Items";
					}
					break;
				}
				case 10:
					if (A_0 == "Blueprints")
					{
						return "Blueprints";
					}
					break;
				case 11:
					if (A_0 == "FashionPack")
					{
						return "Wearables";
					}
					break;
				}
			}
			return "Other";
		}

		// Token: 0x0400052D RID: 1325
		private const int 랾 = 3;

		// Token: 0x0400052E RID: 1326
		private const int 럎 = 256;

		// Token: 0x0400052F RID: 1327
		private const float 랾 = 15f;

		// Token: 0x04000530 RID: 1328
		private const int 람 = 8;

		// Token: 0x04000531 RID: 1329
		private static readonly string[] 랾 = new string[]
		{
			"Kits",
			"Wearables",
			"Locks",
			"Familiars",
			"Orbs",
			"Wiring",
			"Blueprints",
			"Clan Items",
			"Boosters",
			"Seeds",
			"Fishing",
			"Pets",
			"Battle Cards",
			"Special Items",
			"Community Items",
			"Other"
		};

		// Token: 0x04000532 RID: 1330
		private static readonly List<랡.럎> 랾 = new List<랡.럎>();

		// Token: 0x04000533 RID: 1331
		private static readonly Dictionary<string, int> 랾 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000534 RID: 1332
		private static readonly Dictionary<Type, 랡.랾> 랾 = new Dictionary<Type, 랡.랾>();

		// Token: 0x04000535 RID: 1333
		private static float 럎 = -1f;

		// Token: 0x04000536 RID: 1334
		private static string 랾 = "Catalog not loaded yet.";

		// Token: 0x04000537 RID: 1335
		private static string 럎 = 랡.랾[0];

		// Token: 0x04000538 RID: 1336
		private static string 람 = string.Empty;

		// Token: 0x04000539 RID: 1337
		private static int 럒 = 1;

		// Token: 0x0400053A RID: 1338
		private static 랡.럒 랾;

		// Token: 0x0400053B RID: 1339
		private static bool 랾 = false;

		// Token: 0x0400053C RID: 1340
		private static readonly 랡.럼[] 랾 = new 랡.럼[]
		{
			new 랡.럼("TreeKit", "Kits", 1450, 랡.람.랾),
			new 랡.럼("GardenKit", "Kits", 2000, 랡.람.랾),
			new 랡.럼("DecorationKit", "Kits", 2500, 랡.람.랾),
			new 랡.럼("CastleKit", "Kits", 4500, 랡.람.랾),
			new 랡.럼("DashPack", "Kits", 4500, 랡.람.랾),
			new 랡.럼("UnderwaterKit", "Kits", 7500, 랡.람.랾),
			new 랡.럼("AlienPlanetKit", "Kits", 12000, 랡.람.랾),
			new 랡.럼("AncientTimesBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("scifipack", "Themes", 500, 랡.람.랾),
			new 랡.럼("PlatformerBooster", "Themes", 500, 랡.람.랾),
			new 랡.럼("MedievalPack", "Themes", 550, 랡.람.랾),
			new 랡.럼("GangstaPack", "Themes", 700, 랡.람.랾),
			new 랡.럼("SamuraiBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("VikingBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("UrbanBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("ElfBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("ChaosBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("PirateBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("AlienBooster", "Themes", 999, 랡.람.랾),
			new 랡.럼("Shardbooster", "Themes", 1000, 랡.람.랾),
			new 랡.럼("BasicClothes", "FashionPack", 50, 랡.람.랾),
			new 랡.럼("ProClothes", "FashionPack", 500, 랡.람.랾),
			new 랡.럼("VikingHairPack", "FashionPack", 550, 랡.람.랾),
			new 랡.럼("WinterPack", "Seeds", 2800, 랡.람.랾),
			new 랡.럼("Fertilizer", "Seeds", 150, 랡.람.랾),
			new 랡.럼("FertilizerLarge", "Seeds", 300, 랡.람.랾),
			new 랡.럼("BasicSeeds", "Seeds", 50, 랡.람.랾),
			new 랡.럼("AdvancedSeeds", "Seeds", 500, 랡.람.랾),
			new 랡.럼("RockPack", "Seeds", 500, 랡.람.랾),
			new 랡.럼("Water", "Seeds", 1000, 랡.람.랾),
			new 랡.럼("SandPack", "Seeds", 1000, 랡.람.랾),
			new 랡.럼("SmallLock", "Locks", 100, 랡.람.랾),
			new 랡.럼("MediumLock", "Locks", 500, 랡.람.랾),
			new 랡.럼("LargeLock", "Locks", 1000, 랡.람.랾),
			new 랡.럼("WorldLock", "Locks", 3500, 랡.람.랾),
			new 랡.럼("DarkLock", "Locks", 28000, 랡.람.랾),
			new 랡.럼("PlatinumLock", "Locks", 350000, 랡.람.랾),
			new 랡.럼("BattleLock", "Locks", 3000, 랡.람.랾),
			new 랡.럼("BattleWorldLock", "Locks", 7500, 랡.람.랾),
			new 랡.럼("LureBooster", "Fishing", 100, 랡.람.랾),
			new 랡.럼("LureBoosterLarge", "Fishing", 500, 랡.람.랾),
			new 랡.럼("FishingRodBambooBasic", "Fishing", 500, 랡.람.랾),
			new 랡.럼("FishingRodFiberglassBasic", "Fishing", 2500, 랡.람.랾),
			new 랡.럼("FishingRodCarbonFiberBasic", "Fishing", 15000, 랡.람.랾),
			new 랡.럼("FishingRodTitaniumBasic", "Fishing", 35000, 랡.람.랾),
			new 랡.럼("FishingRodUpgradeStation", "Fishing", 10000, 랡.람.랾),
			new 랡.럼("FishingScoreBoard", "Fishing", 15000, 랡.람.랾),
			new 랡.럼("FishingRecycler", "Fishing", 20000, 랡.람.랾),
			new 랡.럼("Bunny", "Familiars", 35000, 랡.람.랾),
			new 랡.럼("Gem", "Familiars", 45000, 랡.람.랾),
			new 랡.럼("Crow", "Familiars", 50000, 랡.람.랾),
			new 랡.럼("Mini-bot", "Familiars", 65000, 랡.람.랾),
			new 랡.럼("Gremlin", "Familiars", 75000, 랡.람.랾),
			new 랡.럼("Lock", "Familiars", 75000, 랡.람.랾),
			new 랡.럼("Parrot", "Familiars", 85000, 랡.람.랾),
			new 랡.럼("FAMEvolverator", "Familiars", 35000, 랡.람.랾),
			new 랡.럼("FAMFoodMachine", "Familiars", 50000, 랡.람.랾),
			new 랡.럼("VirtualPetDog", "Pets", 10000, 랡.람.랾),
			new 랡.럼("VirtualPetCat", "Pets", 10000, 랡.람.랾),
			new 랡.럼("PetFoodDogBasic", "Pets", 500, 랡.람.랾),
			new 랡.럼("PetFoodDogPremium", "Pets", 1250, 랡.람.랾),
			new 랡.럼("PetFoodCatBasic", "Pets", 500, 랡.람.랾),
			new 랡.럼("PetFoodCatPremium", "Pets", 1250, 랡.람.랾),
			new 랡.럼("PetFoodSlimeBasic", "Pets", 500, 랡.람.랾),
			new 랡.럼("PetFoodSlimePremium", "Pets", 1250, 랡.람.랾),
			new 랡.럼("PetMedicineBasic", "Pets", 500, 랡.람.랾),
			new 랡.럼("OrbLightingLesserDark", "Orbs", 75000, 랡.람.랾),
			new 랡.럼("OrbLightingDark", "Orbs", 75000, 랡.람.랾),
			new 랡.럼("OrbLightingGreatDark", "Orbs", 75000, 랡.람.랾),
			new 랡.럼("OrbLightingNone", "Orbs", 2000, 랡.람.랾),
			new 랡.럼("OrbWeatherNone", "Orbs", 1000, 랡.람.랾),
			new 랡.럼("OrbWeatherLightRain", "Orbs", 10000, 랡.람.랾),
			new 랡.럼("OrbWeatherHeavyRain", "Orbs", 15000, 랡.람.랾),
			new 랡.럼("OrbWeatherSandStorm", "Orbs", 17500, 랡.람.랾),
			new 랡.럼("OrbWeatherPixelTrail", "Orbs", 50000, 랡.람.랾),
			new 랡.럼("ForestOrb", "Orbs", 2000, 랡.람.랾),
			new 랡.럼("StarOrb", "Orbs", 5000, 랡.람.랾),
			new 랡.럼("SandOrb", "Orbs", 9000, 랡.람.랾),
			new 랡.럼("NightOrb", "Orbs", 12000, 랡.람.랾),
			new 랡.럼("CityOrb", "Orbs", 15000, 랡.람.랾),
			new 랡.럼("CardPackBasicOne", "Cards", 5000, 랡.람.랾),
			new 랡.럼("CardPackBasicSmallSet", "Cards", 50000, 랡.람.랾),
			new 랡.럼("WeaponWiringTool", "Wiring", 7500, 랡.람.랾),
			new 랡.럼("WiringTriggerLever", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringTriggerSwitch", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringTriggerButton", "Wiring", 350, 랡.람.랾),
			new 랡.럼("WiringTriggerPressurePad", "Wiring", 500, 랡.람.랾),
			new 랡.럼("WiringTriggerProximitySensor", "Wiring", 500, 랡.람.랾),
			new 랡.럼("OnOffLight", "Wiring", 100, 랡.람.랾),
			new 랡.럼("DisappearingBlock", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateAND", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateNAND", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateOR", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateNOR", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateXOR", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateXNOR", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateNOT", "Wiring", 250, 랡.람.랾),
			new 랡.럼("WiringLogicGateSIGNALDIVIDER", "Wiring", 150, 랡.람.랾),
			new 랡.럼("WiringLogicGateRANDOMIZER", "Wiring", 500, 랡.람.랾),
			new 랡.럼("WiringLogicGateTOGGLE", "Wiring", 500, 랡.람.랾),
			new 랡.럼("WiringLogicGateDELAYTIMER", "Wiring", 500, 랡.람.랾),
			new 랡.럼("WiringLogicGateSIGNALHOLDER", "Wiring", 500, 랡.람.랾),
			new 랡.럼("WiringLogicGateTIMER", "Wiring", 500, 랡.람.랾),
			new 랡.럼("ConsumableRedScroll", "Items", 150, 랡.람.랾),
			new 랡.럼("ConsumableRedScroll10", "Items", 1000, 랡.람.랾),
			new 랡.럼("RedPortal", "Items", 9000, 랡.람.랾),
			new 랡.럼("JetRaceGroupPortal", "Items", 45000, 랡.람.랾),
			new 랡.럼("ScreenshotForbidden", "Items", 100, 랡.람.랾),
			new 랡.럼("ConsumableCameraWorld", "Items", 100, 랡.람.랾),
			new 랡.럼("PrizeBox", "Items", 350, 랡.람.랾),
			new 랡.럼("AdTV", "Items", 500, 랡.람.랾),
			new 랡.럼("Recall", "Items", 1000, 랡.람.랾),
			new 랡.럼("RatingBoard", "Items", 1200, 랡.람.랾),
			new 랡.럼("DeathCounter", "Items", 2000, 랡.람.랾),
			new 랡.럼("EntrancePortal", "Items", 3750, 랡.람.랾),
			new 랡.럼("MagicCauldron", "Items", 5750, 랡.람.랾),
			new 랡.럼("Recycler", "Items", 7500, 랡.람.랾),
			new 랡.럼("RuleBot", "Items", 10000, 랡.람.랾),
			new 랡.럼("RuleBotWeapon", "Items", 10000, 랡.람.랾),
			new 랡.럼("RuleBotPotion", "Items", 10000, 랡.람.랾),
			new 랡.럼("RuleBotMount", "Items", 125000, 랡.람.랾),
			new 랡.럼("BestSetPhotoBooth", "Items", 15000, 랡.람.랾),
			new 랡.럼("SafeBox", "Items", 17500, 랡.람.랾),
			new 랡.럼("Replicator", "Items", 20000, 랡.람.랾),
			new 랡.럼("ColorOMat", "Items", 25000, 랡.람.랾),
			new 랡.럼("PWETerminal", "Items", 49000, 랡.람.랾),
			new 랡.럼("GravityModifier", "Items", 150000, 랡.람.랾),
			new 랡.럼("BlueprintOrbSpaceBackground", "Blueprints", 50000, 랡.람.랾),
			new 랡.럼("BlueprintNecklaceGlimmer", "Blueprints", 60000, 랡.람.랾),
			new 랡.럼("BlueprintMaskTiki", "Blueprints", 100000, 랡.람.랾),
			new 랡.럼("BlueprintWeaponSwordLaserGreen", "Blueprints", 350000, 랡.람.랾),
			new 랡.럼("BlueprintWeaponSwordLaserRed", "Blueprints", 350000, 랡.람.랾),
			new 랡.럼("BlueprintWeaponSwordLaserBlue", "Blueprints", 350000, 랡.람.랾),
			new 랡.럼("BlueprintShirtArmorKnight", "Blueprints", 225000, 랡.람.랾),
			new 랡.럼("BlueprintPantsArmorKnight", "Blueprints", 225000, 랡.람.랾),
			new 랡.럼("BlueprintHatHelmetArmorKnight", "Blueprints", 225000, 랡.람.랾),
			new 랡.럼("BlueprintWeaponSwordKnight", "Blueprints", 350000, 랡.람.랾),
			new 랡.럼("BlueprintCapeDark", "Blueprints", 475000, 랡.람.랾),
			new 랡.럼("BlueprintWeaponSwordLaserClaymore", "Blueprints", 500000, 랡.람.랾),
			new 랡.럼("BlueprintJetPackPlasma", "Blueprints", 500000, 랡.람.랾),
			new 랡.럼("BlueprintHatHaloBloodBlack", "Blueprints", 600000, 랡.람.랾),
			new 랡.럼("BlueprintWeaponSwordFlaming", "Blueprints", 725000, 랡.람.랾),
			new 랡.럼("BlueprintWingsValkyria", "Blueprints", 750000, 랡.람.랾),
			new 랡.럼("BlueprintWingsMechanicalGolden", "Blueprints", 950000, 랡.람.랾),
			new 랡.럼("KiddieRide", "Community", 10000, 랡.람.랾),
			new 랡.럼("FamiliarBubbly", "Community", 55000, 랡.람.랾),
			new 랡.럼("FamiliarLion", "Community", 55000, 랡.람.랾),
			new 랡.럼("FamiliarSugarglider", "Community", 55000, 랡.람.랾),
			new 랡.럼("DoorClan", "Clan", 1000, 랡.람.랾),
			new 랡.럼("ClanQuestBot", "Clan", 7500, 랡.람.랾),
			new 랡.럼("ClanTotem", "Clan", 9000, 랡.람.랾),
			new 랡.럼("DoorFactionDark", "Clan", 2000, 랡.람.랾),
			new 랡.럼("DoorFactionLight", "Clan", 2000, 랡.람.랾),
			new 랡.럼("CheckPointFactionDark", "Clan", 3500, 랡.람.랾),
			new 랡.럼("CheckPointFactionLight", "Clan", 3500, 랡.람.랾),
			new 랡.럼("PortalFactionDark", "Clan", 4000, 랡.람.랾),
			new 랡.럼("PortalFactionLight", "Clan", 4000, 랡.람.랾),
			new 랡.럼("BattleScoreBoardFaction", "Clan", 8000, 랡.람.랾),
			new 랡.럼("LockBattleFaction", "Clan", 7500, 랡.람.랾),
			new 랡.럼("LockWorldBattleFaction", "Clan", 9000, 랡.람.랾),
			new 랡.럼("NecklaceClanLight", "Clan", 3500, 랡.람.랾),
			new 랡.럼("NecklaceClanDark", "Clan", 3500, 랡.람.랾),
			new 랡.럼("ShirtHoodieClanLight", "Clan", 5000, 랡.람.랾),
			new 랡.럼("ShirtHoodieClanDark", "Clan", 5000, 랡.람.랾),
			new 랡.럼("MaskFacePaintClanLight", "Clan", 7500, 랡.람.랾),
			new 랡.럼("MaskFacePaintClanDark", "Clan", 7500, 랡.람.랾),
			new 랡.럼("GlassesVisorClanLight", "Clan", 10000, 랡.람.랾),
			new 랡.럼("GlassesVisorClanDark", "Clan", 10000, 랡.람.랾),
			new 랡.럼("WeaponShieldClanLight", "Clan", 12000, 랡.람.랾),
			new 랡.럼("WeaponShieldClanDark", "Clan", 12000, 랡.람.랾),
			new 랡.럼("MaskGasClanLight", "Clan", 15000, 랡.람.랾),
			new 랡.럼("MaskGasClanDark", "Clan", 15000, 랡.람.랾),
			new 랡.럼("HatCrownClanLight", "Clan", 35000, 랡.람.랾),
			new 랡.럼("HatCrownClanDark", "Clan", 35000, 랡.람.랾),
			new 랡.럼("WeaponSwordClanLight", "Clan", 75000, 랡.람.랾),
			new 랡.럼("WeaponSwordClanDark", "Clan", 75000, 랡.람.랾),
			new 랡.럼("FamiliarClanLight1A", "Clan", 100000, 랡.람.랾),
			new 랡.럼("FamiliarClanDark1A", "Clan", 100000, 랡.람.랾),
			new 랡.럼("WingsClanLight", "Clan", 250000, 랡.람.랾),
			new 랡.럼("WingsClanDark", "Clan", 250000, 랡.람.랾)
		};

		// Token: 0x0200009D RID: 157
		private sealed class 랾
		{
			// Token: 0x06000627 RID: 1575 RVA: 0x0003F572 File Offset: 0x0003D772
			[CompilerGenerated]
			public FieldInfo[] 랾()
			{
				return this.랾;
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x0003F57A File Offset: 0x0003D77A
			[CompilerGenerated]
			public void 랾(FieldInfo[] A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x0003F583 File Offset: 0x0003D783
			[CompilerGenerated]
			public PropertyInfo[] 럎()
			{
				return this.랾;
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x0003F58B File Offset: 0x0003D78B
			[CompilerGenerated]
			public void 랾(PropertyInfo[] A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x0400053D RID: 1341
			[CompilerGenerated]
			private FieldInfo[] 랾 = Array.Empty<FieldInfo>();

			// Token: 0x0400053E RID: 1342
			[CompilerGenerated]
			private PropertyInfo[] 랾 = Array.Empty<PropertyInfo>();
		}

		// Token: 0x0200009E RID: 158
		private sealed class 럎
		{
			// Token: 0x0600062C RID: 1580 RVA: 0x0003F5B2 File Offset: 0x0003D7B2
			public 럎(string A_1, string A_2, string A_3, int A_4, 랡.람 A_5, string A_6)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.람 = A_3;
				this.랾 = A_4;
				this.랾 = A_5;
				this.럒 = A_6;
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x0003F5E7 File Offset: 0x0003D7E7
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x0003F5EF File Offset: 0x0003D7EF
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x0600062F RID: 1583 RVA: 0x0003F5F7 File Offset: 0x0003D7F7
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x0003F5FF File Offset: 0x0003D7FF
			[CompilerGenerated]
			public int 럒()
			{
				return this.랾;
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x0003F607 File Offset: 0x0003D807
			[CompilerGenerated]
			public 랡.람 럼()
			{
				return this.랾;
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x0003F60F File Offset: 0x0003D80F
			[CompilerGenerated]
			public string 랋()
			{
				return this.럒;
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x0003F617 File Offset: 0x0003D817
			public string 랉()
			{
				if (this.럼() != 랡.람.럎)
				{
					return "Gems";
				}
				return "Byte Coins";
			}

			// Token: 0x0400053F RID: 1343
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000540 RID: 1344
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x04000541 RID: 1345
			[CompilerGenerated]
			private readonly string 람;

			// Token: 0x04000542 RID: 1346
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x04000543 RID: 1347
			[CompilerGenerated]
			private readonly 랡.람 랾;

			// Token: 0x04000544 RID: 1348
			[CompilerGenerated]
			private readonly string 럒;
		}

		// Token: 0x0200009F RID: 159
		private enum 람
		{
			// Token: 0x04000546 RID: 1350
			랾,
			// Token: 0x04000547 RID: 1351
			럎
		}

		// Token: 0x020000A0 RID: 160
		private sealed class 럒
		{
			// Token: 0x06000634 RID: 1588 RVA: 0x0003F62D File Offset: 0x0003D82D
			public 럒(string A_1, string A_2, int A_3, int A_4, 랡.람 A_5, int A_6)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.랾 = A_3;
				this.럎 = A_4;
				this.랾 = A_5;
				this.람 = A_6;
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x0003F662 File Offset: 0x0003D862
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x0003F66A File Offset: 0x0003D86A
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x0003F672 File Offset: 0x0003D872
			[CompilerGenerated]
			public int 람()
			{
				return this.랾;
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x0003F67A File Offset: 0x0003D87A
			[CompilerGenerated]
			public int 럒()
			{
				return this.럎;
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x0003F682 File Offset: 0x0003D882
			[CompilerGenerated]
			public 랡.람 럼()
			{
				return this.랾;
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x0003F68A File Offset: 0x0003D88A
			[CompilerGenerated]
			public int 랋()
			{
				return this.람;
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x0003F692 File Offset: 0x0003D892
			public string 랉()
			{
				if (this.럼() != 랡.람.럎)
				{
					return "Gems";
				}
				return "Byte Coins";
			}

			// Token: 0x04000548 RID: 1352
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000549 RID: 1353
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x0400054A RID: 1354
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x0400054B RID: 1355
			[CompilerGenerated]
			private readonly int 럎;

			// Token: 0x0400054C RID: 1356
			[CompilerGenerated]
			private readonly 랡.람 랾;

			// Token: 0x0400054D RID: 1357
			[CompilerGenerated]
			private readonly int 람;
		}

		// Token: 0x020000A1 RID: 161
		private readonly struct 럼 : IEquatable<랡.럼>
		{
			// Token: 0x0600063C RID: 1596 RVA: 0x0003F6A8 File Offset: 0x0003D8A8
			public 럼(string A_1, string A_2, int A_3, 랡.람 A_4)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.랾 = A_3;
				this.랾 = A_4;
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x0003F6C7 File Offset: 0x0003D8C7
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x0003F6CF File Offset: 0x0003D8CF
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x0003F6E0 File Offset: 0x0003D8E0
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x0003F6E9 File Offset: 0x0003D8E9
			[CompilerGenerated]
			public int 람()
			{
				return this.랾;
			}

			// Token: 0x06000642 RID: 1602 RVA: 0x0003F6F1 File Offset: 0x0003D8F1
			[CompilerGenerated]
			public void 랾(int A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x0003F6FA File Offset: 0x0003D8FA
			[CompilerGenerated]
			public 랡.람 럒()
			{
				return this.랾;
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x0003F702 File Offset: 0x0003D902
			[CompilerGenerated]
			public void 랾(랡.람 A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x0009E678 File Offset: 0x0009C878
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("ShopSeedItem");
				stringBuilder.Append(" { ");
				if (this.랾(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x0009E6C4 File Offset: 0x0009C8C4
			[CompilerGenerated]
			private bool 랾(StringBuilder A_1)
			{
				A_1.Append("PacketId = ");
				A_1.Append(this.랾());
				A_1.Append(", SourceCategory = ");
				A_1.Append(this.럎());
				A_1.Append(", Price = ");
				A_1.Append(this.람().ToString());
				A_1.Append(", Currency = ");
				A_1.Append(this.럒().ToString());
				return true;
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x0003F70B File Offset: 0x0003D90B
			[CompilerGenerated]
			public static bool operator !=(랡.럼 A_0, 랡.럼 A_1)
			{
				return !(A_0 == A_1);
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x0003F717 File Offset: 0x0003D917
			[CompilerGenerated]
			public static bool operator ==(랡.럼 A_0, 랡.럼 A_1)
			{
				return A_0.Equals(A_1);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x0009E754 File Offset: 0x0009C954
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<string>.Default.GetHashCode(this.랾) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.럎)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.랾)) * -1521134295 + EqualityComparer<랡.람>.Default.GetHashCode(this.랾);
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x0003F721 File Offset: 0x0003D921
			[CompilerGenerated]
			public override bool Equals(object A_1)
			{
				return A_1 is 랡.럼 && this.Equals((랡.럼)A_1);
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x0009E7B8 File Offset: 0x0009C9B8
			[CompilerGenerated]
			public bool Equals(랡.럼 A_1)
			{
				return EqualityComparer<string>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.럎, A_1.럎) && EqualityComparer<int>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<랡.람>.Default.Equals(this.랾, A_1.랾);
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x0003F739 File Offset: 0x0003D939
			[CompilerGenerated]
			public void 랾(out string A_1, out string A_2, out int A_3, out 랡.람 A_4)
			{
				A_1 = this.랾();
				A_2 = this.럎();
				A_3 = this.람();
				A_4 = this.럒();
			}

			// Token: 0x0400054E RID: 1358
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x0400054F RID: 1359
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x04000550 RID: 1360
			[CompilerGenerated]
			private readonly int 랾;

			// Token: 0x04000551 RID: 1361
			[CompilerGenerated]
			private readonly 랡.람 랾;
		}

		// Token: 0x020000A2 RID: 162
		[CompilerGenerated]
		private static class 랋
		{
			// Token: 0x04000552 RID: 1362
			public static Func<string, string> 랾;
		}

		// Token: 0x020000A3 RID: 163
		[CompilerGenerated]
		[Serializable]
		private sealed class 랉
		{
			// Token: 0x0600064F RID: 1615 RVA: 0x0003F768 File Offset: 0x0003D968
			internal int 랾(랡.럎 A_1, 랡.럎 A_2)
			{
				return StringComparer.OrdinalIgnoreCase.Compare(A_1.럎(), A_2.럎());
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x0003F780 File Offset: 0x0003D980
			internal int 랾(랡.럎 A_1)
			{
				return 랡.람(A_1.람());
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x0003F78D File Offset: 0x0003D98D
			internal string 럎(랡.럎 A_1)
			{
				return A_1.럎();
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x0003F795 File Offset: 0x0003D995
			internal bool 랾(Type A_1)
			{
				return A_1 != null;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x0003F79E File Offset: 0x0003D99E
			internal bool 랾(FieldInfo A_1)
			{
				return !A_1.IsStatic && 랡.럎(A_1.Name, A_1.FieldType);
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x0003F7BB File Offset: 0x0003D9BB
			internal bool 랾(PropertyInfo A_1)
			{
				return A_1.CanRead && A_1.GetIndexParameters().Length == 0 && 랡.럎(A_1.Name, A_1.PropertyType);
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x0003F7E1 File Offset: 0x0003D9E1
			internal bool 랾(char A_1)
			{
				return !char.IsLetter(A_1) || char.IsUpper(A_1);
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x0003F7F3 File Offset: 0x0003D9F3
			internal bool 럎(char A_1)
			{
				return !char.IsLetter(A_1) || char.IsLower(A_1);
			}

			// Token: 0x04000553 RID: 1363
			public static readonly 랡.랉 랾 = new 랡.랉();

			// Token: 0x04000554 RID: 1364
			public static Comparison<랡.럎> 랾;

			// Token: 0x04000555 RID: 1365
			public static Func<랡.럎, int> 랾;

			// Token: 0x04000556 RID: 1366
			public static Func<랡.럎, string> 랾;

			// Token: 0x04000557 RID: 1367
			public static Func<Type, bool> 랾;

			// Token: 0x04000558 RID: 1368
			public static Func<FieldInfo, bool> 랾;

			// Token: 0x04000559 RID: 1369
			public static Func<PropertyInfo, bool> 랾;

			// Token: 0x0400055A RID: 1370
			public static Func<char, bool> 랾;

			// Token: 0x0400055B RID: 1371
			public static Func<char, bool> 럎;
		}

		// Token: 0x020000A4 RID: 164
		[CompilerGenerated]
		private sealed class 럐
		{
			// Token: 0x06000658 RID: 1624 RVA: 0x0003F805 File Offset: 0x0003DA05
			internal object 랾()
			{
				return this.랾.GetValue(null);
			}

			// Token: 0x0400055C RID: 1372
			public FieldInfo 랾;
		}

		// Token: 0x020000A5 RID: 165
		[CompilerGenerated]
		private sealed class 랓
		{
			// Token: 0x0600065A RID: 1626 RVA: 0x0003F813 File Offset: 0x0003DA13
			internal object 랾()
			{
				return this.랾.GetValue(null);
			}

			// Token: 0x0400055D RID: 1373
			public PropertyInfo 랾;
		}

		// Token: 0x020000A6 RID: 166
		[CompilerGenerated]
		private sealed class 럯
		{
			// Token: 0x0400055E RID: 1374
			public object 랾;
		}

		// Token: 0x020000A7 RID: 167
		[CompilerGenerated]
		private sealed class 럭
		{
			// Token: 0x0600065D RID: 1629 RVA: 0x0003F821 File Offset: 0x0003DA21
			internal object 랾()
			{
				return this.랾.GetValue(this.랾.랾);
			}

			// Token: 0x0400055F RID: 1375
			public FieldInfo 랾;

			// Token: 0x04000560 RID: 1376
			public 랡.럯 랾;
		}

		// Token: 0x020000A8 RID: 168
		[CompilerGenerated]
		private sealed class 랱
		{
			// Token: 0x0600065F RID: 1631 RVA: 0x0003F839 File Offset: 0x0003DA39
			internal object 랾()
			{
				return this.랾.GetValue(this.랾.랾);
			}

			// Token: 0x04000561 RID: 1377
			public PropertyInfo 랾;

			// Token: 0x04000562 RID: 1378
			public 랡.럯 랾;
		}

		// Token: 0x020000A9 RID: 169
		[CompilerGenerated]
		private sealed class 럙
		{
			// Token: 0x06000661 RID: 1633 RVA: 0x0003F851 File Offset: 0x0003DA51
			internal bool 랾(FieldInfo A_1)
			{
				return A_1.Name.Equals(this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x0003F865 File Offset: 0x0003DA65
			internal object 랾()
			{
				return this.랾.GetValue(this.랾);
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x0003F851 File Offset: 0x0003DA51
			internal bool 랾(PropertyInfo A_1)
			{
				return A_1.Name.Equals(this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x0003F878 File Offset: 0x0003DA78
			internal object 럎()
			{
				return this.랾.GetValue(this.랾);
			}

			// Token: 0x04000563 RID: 1379
			public string 랾;

			// Token: 0x04000564 RID: 1380
			public FieldInfo 랾;

			// Token: 0x04000565 RID: 1381
			public object 랾;

			// Token: 0x04000566 RID: 1382
			public PropertyInfo 랾;
		}

		// Token: 0x020000AA RID: 170
		[CompilerGenerated]
		private sealed class 랫
		{
			// Token: 0x06000666 RID: 1638 RVA: 0x0003F88B File Offset: 0x0003DA8B
			internal bool 랾(string A_1)
			{
				return this.랾.Contains(A_1, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000567 RID: 1383
			public string 랾;
		}

		// Token: 0x020000AB RID: 171
		[CompilerGenerated]
		private sealed class 럍
		{
			// Token: 0x06000668 RID: 1640 RVA: 0x0003F89A File Offset: 0x0003DA9A
			internal bool 랾(string A_1)
			{
				return string.Equals(A_1, this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000568 RID: 1384
			public string 랾;
		}
	}
}
