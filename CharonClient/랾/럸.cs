using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using Il2CppSystem;
using ImGuiNET;

namespace 랾
{
	// Token: 0x02000124 RID: 292
	internal class 럸
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x000B0D9C File Offset: 0x000AEF9C
		private static 럸.랾 랾(Type A_0)
		{
			럸.랾 랾;
			if (럸.랾.TryGetValue(A_0, out 랾))
			{
				return 랾;
			}
			럸.랾 랾2 = new 럸.랾();
			랾2.랾 = A_0.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<FieldInfo, bool>(럸.럼.랾.랾)).OrderBy(new Func<FieldInfo, string>(럸.럼.랾.럎), StringComparer.OrdinalIgnoreCase).ToArray<FieldInfo>();
			랾2.랾 = A_0.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<PropertyInfo, bool>(럸.럼.랾.랾)).OrderBy(new Func<PropertyInfo, string>(럸.럼.랾.럎), StringComparer.OrdinalIgnoreCase).ToArray<PropertyInfo>();
			IEnumerable<MethodInfo> source = A_0.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<MethodInfo, bool>(럸.럼.랾.랾));
			Func<MethodInfo, string> keySelector;
			if ((keySelector = 럸.럒.랾) == null)
			{
				keySelector = (럸.럒.랾 = new Func<MethodInfo, string>(럸.랾));
			}
			랾2.랾 = source.GroupBy(keySelector, StringComparer.Ordinal).Select(new Func<IGrouping<string, MethodInfo>, MethodInfo>(럸.럼.랾.랾)).OrderBy(new Func<MethodInfo, string>(럸.럼.랾.럎), StringComparer.OrdinalIgnoreCase).ToArray<MethodInfo>();
			랾2.럎 = A_0.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<FieldInfo, bool>(럸.럼.랾.람)).OrderBy(new Func<FieldInfo, string>(럸.럼.랾.럒), StringComparer.OrdinalIgnoreCase).ToArray<FieldInfo>();
			랾2.럎 = A_0.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<PropertyInfo, bool>(럸.럼.랾.람)).OrderBy(new Func<PropertyInfo, string>(럸.럼.랾.럒), StringComparer.OrdinalIgnoreCase).ToArray<PropertyInfo>();
			랾 = 랾2;
			럸.랾[A_0] = 랾;
			return 랾;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00041556 File Offset: 0x0003F756
		private static bool 랾(MemberInfo A_0)
		{
			return A_0.IsDefined(typeof(CompilerGeneratedAttribute), false);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000B0FF8 File Offset: 0x000AF1F8
		private static string 랾(MethodInfo A_0)
		{
			string value = string.Join(",", A_0.GetParameters().Select(new Func<ParameterInfo, string>(럸.럼.랾.랾)));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0.ReturnType.FullName ?? A_0.ReturnType.Name);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(A_0.Name);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00041569 File Offset: 0x0003F769
		public static void 랾()
		{
			럸.랾.Clear();
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000B1098 File Offset: 0x000AF298
		public static void 랾(object A_0, string A_1 = null)
		{
			럸.랉 랉 = new 럸.랉();
			랉.랾 = A_0;
			if (랉.랾 == null)
			{
				ImGui.TextColored(럸.럎, (A_1 != null) ? (A_1 + ": null") : "h");
				return;
			}
			Type type = 랉.랾.GetType();
			if (A_1 == null)
			{
				A_1 = type.Name;
			}
			ImGui.TextColored(럸.람, "[" + 럸.랋(type) + "]");
			ImGui.SameLine();
			ImGui.Text(A_1);
			ImGui.Separator();
			럸.랾(랉.랾, type);
			럸.랾 랾 = 럸.랾(type);
			럸.랾<FieldInfo>("Fields", 랾.럎, new Action<FieldInfo>(랉.랾));
			럸.랾<PropertyInfo>("Properties", 랾.럎, new Action<PropertyInfo>(랉.랾));
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000B1170 File Offset: 0x000AF370
		private static void 랾(object A_0, Type A_1)
		{
			if (A_1.Name != "GameObject")
			{
				string fullName = A_1.FullName;
				if (fullName == null || !fullName.Contains("UnityEngine.GameObject"))
				{
					return;
				}
			}
			try
			{
				MethodInfo method = A_1.GetMethod("GetComponents", new Type[]
				{
					typeof(Type)
				});
				if (!(method == null))
				{
					Type type = 럸.럎("UnityEngine.Component");
					if (!(type == null))
					{
						Array array = method.Invoke(A_0, new object[]
						{
							type
						}) as Array;
						if (array != null)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
							defaultInterpolatedStringHandler.AppendLiteral("Components (");
							defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
							defaultInterpolatedStringHandler.AppendLiteral(")##go_comp");
							if (ImGui.CollapsingHeader(defaultInterpolatedStringHandler.ToStringAndClear(), 32))
							{
								ImGui.Indent();
								for (int i = 0; i < array.Length; i++)
								{
									object value = array.GetValue(i);
									if (value != null)
									{
										Type type2 = value.GetType();
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
										defaultInterpolatedStringHandler2.AppendLiteral("comp_");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(i);
										using (new 럸.람(defaultInterpolatedStringHandler2.ToStringAndClear()))
										{
											DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(7, 2);
											defaultInterpolatedStringHandler3.AppendFormatted(type2.Name);
											defaultInterpolatedStringHandler3.AppendLiteral("##comp_");
											defaultInterpolatedStringHandler3.AppendFormatted<int>(i);
											if (ImGui.CollapsingHeader(defaultInterpolatedStringHandler3.ToStringAndClear()))
											{
												ImGui.Indent();
												럸.랾(value, type2.Name);
												ImGui.Unindent();
											}
										}
									}
								}
								ImGui.Unindent();
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000B1358 File Offset: 0x000AF558
		public static void 럎(Type A_0)
		{
			럸.랾 랾 = 럸.랾(A_0);
			럸.랾<PropertyInfo>("Static Properties", 랾.랾, new Action<PropertyInfo>(럸.럼.랾.럼));
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000B139C File Offset: 0x000AF59C
		public static void 람(Type A_0)
		{
			foreach (MethodInfo methodInfo in 럸.랾(A_0).랾)
			{
				if (럸.럒(methodInfo.Name))
				{
					try
					{
						럸.럎(methodInfo);
					}
					catch (Exception ex)
					{
						ImGui.TextColored(럸.랾, "[!] " + methodInfo.Name + ": " + ex.Message);
					}
				}
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000B1418 File Offset: 0x000AF618
		private static void 랾<랾>(string A_0, 랾[] A_1, Action<랾> A_2) where 랾 : MemberInfo
		{
			if (A_1.Length == 0)
			{
				return;
			}
			int num;
			if (!string.IsNullOrEmpty(럧.럽))
			{
				num = A_1.Count(new Func<랾, bool>(럸.랋<랾>.랾.랾));
			}
			else
			{
				num = A_1.Length;
			}
			int num2 = num;
			if (num2 == 0)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler.AppendLiteral(")##");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			if (!ImGui.CollapsingHeader(defaultInterpolatedStringHandler.ToStringAndClear(), 32))
			{
				return;
			}
			ImGui.Indent();
			foreach (랾 랾 in A_1)
			{
				if (럸.럒(랾.Name))
				{
					try
					{
						A_2(랾);
					}
					catch (Exception ex)
					{
						ImGui.TextColored(럸.랾, "[!] " + 랾.Name + ": " + ex.Message);
					}
				}
			}
			ImGui.Unindent();
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00041575 File Offset: 0x0003F775
		private static void 랾(FieldInfo A_0, Func<object> A_1, Action<object> A_2, int A_3)
		{
			럸.랾("Field", A_0.Name, A_0.FieldType, A_1, A_2, A_3);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00041590 File Offset: 0x0003F790
		private static void 랾(PropertyInfo A_0, Func<object> A_1, Action<object> A_2, int A_3)
		{
			럸.랾("Prop", A_0.Name, A_0.PropertyType, A_1, A_2, A_3);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000B1530 File Offset: 0x000AF730
		private static void 랾(string A_0, string A_1, Type A_2, Func<object> A_3, Action<object> A_4, int A_5)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(A_1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_5);
			using (new 럸.람(defaultInterpolatedStringHandler.ToStringAndClear()))
			{
				object obj;
				try
				{
					obj = A_3();
				}
				catch
				{
					obj = null;
				}
				if (!럸.랾(A_0, A_1, A_2, obj, A_4, A_5))
				{
					string value = 럸.럎(obj, A_2);
					ImGui.TextColored((A_4 == null) ? 럸.럼 : 럸.럒, A_0 + ":");
					ImGui.SameLine();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(4, 3);
					defaultInterpolatedStringHandler2.AppendFormatted(A_1);
					defaultInterpolatedStringHandler2.AppendLiteral(" [");
					defaultInterpolatedStringHandler2.AppendFormatted(럸.랋(A_2));
					defaultInterpolatedStringHandler2.AppendLiteral("] ");
					defaultInterpolatedStringHandler2.AppendFormatted(value);
					if (ImGui.TreeNode(defaultInterpolatedStringHandler2.ToStringAndClear()))
					{
						럸.랾(A_1, obj, A_2, A_4, A_5 + 1);
						ImGui.TreePop();
					}
				}
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000B1664 File Offset: 0x000AF864
		private static bool 랾(string A_0, string A_1, Type A_2, object A_3, Action<object> A_4, int A_5)
		{
			bool flag = A_4 == null;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 3);
			defaultInterpolatedStringHandler.AppendLiteral("##");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(A_1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_5);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (A_2 == typeof(string))
			{
				럸.랾(A_0, A_1, A_2, flag);
				string text2 = (A_3 as string) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				if (flag)
				{
					럸.랾((text2.Length > 120) ? ("\"" + text2.Substring(0, 120) + "...\"") : ("\"" + text2 + "\""));
					럸.랾(text2, text);
				}
				else if (ImGui.InputText(text, ref text2, 1024U))
				{
					A_4(text2);
				}
				return true;
			}
			if (A_2 == typeof(int))
			{
				럸.랾(A_0, A_1, A_2, flag);
				int num2;
				if (A_3 is int)
				{
					int num = (int)A_3;
					num2 = num;
				}
				else
				{
					num2 = 0;
				}
				int num3 = num2;
				if (flag)
				{
					럸.랾(num3.ToString());
					return true;
				}
				if (ImGui.InputInt(text, ref num3))
				{
					A_4(num3);
				}
				return true;
			}
			else if (A_2 == typeof(float))
			{
				럸.랾(A_0, A_1, A_2, flag);
				float num5;
				if (A_3 is float)
				{
					float num4 = (float)A_3;
					num5 = num4;
				}
				else
				{
					num5 = 0f;
				}
				float num6 = num5;
				if (flag)
				{
					럸.랾(num6.ToString("0.####"));
					return true;
				}
				if (ImGui.DragFloat(text, ref num6, 0.1f))
				{
					A_4(num6);
				}
				return true;
			}
			else if (A_2 == typeof(double))
			{
				럸.랾(A_0, A_1, A_2, flag);
				double num8;
				if (A_3 is double)
				{
					double num7 = (double)A_3;
					num8 = num7;
				}
				else
				{
					num8 = 0.0;
				}
				double num9 = num8;
				float num10 = (float)num9;
				if (flag)
				{
					럸.랾(num9.ToString("0.####"));
					return true;
				}
				if (ImGui.DragFloat(text, ref num10, 0.1f))
				{
					A_4((double)num10);
				}
				return true;
			}
			else if (A_2 == typeof(long))
			{
				럸.랾(A_0, A_1, A_2, flag);
				string text3 = ((A_3 != null) ? A_3.ToString() : null) ?? "0";
				if (flag)
				{
					럸.랾(text3);
					return true;
				}
				long num11;
				if (ImGui.InputText(text, ref text3, 64U) && long.TryParse(text3, out num11))
				{
					A_4(num11);
				}
				return true;
			}
			else if (A_2 == typeof(byte))
			{
				럸.랾(A_0, A_1, A_2, flag);
				int num12;
				if (A_3 is byte)
				{
					byte b = (byte)A_3;
					num12 = (int)b;
				}
				else
				{
					num12 = 0;
				}
				int num13 = num12;
				if (flag)
				{
					럸.랾(num13.ToString());
					return true;
				}
				if (ImGui.SliderInt(text, ref num13, 0, 255))
				{
					A_4((byte)num13);
				}
				return true;
			}
			else if (A_2 == typeof(short))
			{
				럸.랾(A_0, A_1, A_2, flag);
				int num15;
				if (A_3 is short)
				{
					short num14 = (short)A_3;
					num15 = (int)num14;
				}
				else
				{
					num15 = 0;
				}
				int value = num15;
				if (flag)
				{
					럸.랾(value.ToString());
					return true;
				}
				if (ImGui.InputInt(text, ref value))
				{
					A_4((short)Math.Clamp(value, -32768, 32767));
				}
				return true;
			}
			else if (A_2 == typeof(bool))
			{
				bool flag2;
				bool flag3;
				if (A_3 is bool)
				{
					flag2 = (bool)A_3;
					flag3 = true;
				}
				else
				{
					flag3 = false;
				}
				bool flag4 = flag3 && flag2;
				if (flag)
				{
					럸.랾(A_0, A_1, A_2, true);
					ImGui.TextColored(flag4 ? 럸.럯 : 럸.럭, flag4 ? "True" : "False");
					return true;
				}
				if (ImGui.Checkbox(A_0 + ": " + A_1 + text, ref flag4))
				{
					A_4(flag4);
				}
				return true;
			}
			else if (A_2.IsEnum)
			{
				럸.랾(A_0, A_1, A_2, flag);
				string[] names = Enum.GetNames(A_2);
				int num16 = (A_3 != null) ? Array.IndexOf<string>(names, A_3.ToString()) : 0;
				if (num16 < 0)
				{
					num16 = 0;
				}
				if (flag)
				{
					string text4 = ((A_3 != null) ? A_3.ToString() : null) ?? names[0];
					if (A_2 == typeof(World.BlockType))
					{
						Vector4 vector = 럸.랓;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 2);
						defaultInterpolatedStringHandler2.AppendFormatted(text4);
						defaultInterpolatedStringHandler2.AppendLiteral(" (");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(Convert.ToInt32(A_3));
						defaultInterpolatedStringHandler2.AppendLiteral(")");
						ImGui.TextColored(vector, defaultInterpolatedStringHandler2.ToStringAndClear());
					}
					else
					{
						럸.랾(text4);
					}
					return true;
				}
				if (ImGui.Combo(text, ref num16, names, names.Length))
				{
					A_4(Enum.Parse(A_2, names[num16]));
				}
				return true;
			}
			else if (A_2 == typeof(Vector2))
			{
				럸.랾(A_0, A_1, A_2, flag);
				Vector2 vector3;
				if (A_3 is Vector2)
				{
					Vector2 vector2 = (Vector2)A_3;
					vector3 = vector2;
				}
				else
				{
					vector3 = Vector2.Zero;
				}
				Vector2 vector4 = vector3;
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(4, 2);
					defaultInterpolatedStringHandler3.AppendLiteral("(");
					defaultInterpolatedStringHandler3.AppendFormatted<float>(vector4.X, "0.##");
					defaultInterpolatedStringHandler3.AppendLiteral(", ");
					defaultInterpolatedStringHandler3.AppendFormatted<float>(vector4.Y, "0.##");
					defaultInterpolatedStringHandler3.AppendLiteral(")");
					럸.랾(defaultInterpolatedStringHandler3.ToStringAndClear());
					return true;
				}
				if (ImGui.DragFloat2(text, ref vector4, 0.1f))
				{
					A_4(vector4);
				}
				return true;
			}
			else if (A_2 == typeof(Vector4))
			{
				럸.랾(A_0, A_1, A_2, flag);
				Vector4 vector6;
				if (A_3 is Vector4)
				{
					Vector4 vector5 = (Vector4)A_3;
					vector6 = vector5;
				}
				else
				{
					vector6 = Vector4.Zero;
				}
				Vector4 vector7 = vector6;
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(8, 4);
					defaultInterpolatedStringHandler4.AppendLiteral("(");
					defaultInterpolatedStringHandler4.AppendFormatted<float>(vector7.X, "0.##");
					defaultInterpolatedStringHandler4.AppendLiteral(", ");
					defaultInterpolatedStringHandler4.AppendFormatted<float>(vector7.Y, "0.##");
					defaultInterpolatedStringHandler4.AppendLiteral(", ");
					defaultInterpolatedStringHandler4.AppendFormatted<float>(vector7.Z, "0.##");
					defaultInterpolatedStringHandler4.AppendLiteral(", ");
					defaultInterpolatedStringHandler4.AppendFormatted<float>(vector7.W, "0.##");
					defaultInterpolatedStringHandler4.AppendLiteral(")");
					럸.랾(defaultInterpolatedStringHandler4.ToStringAndClear());
					return true;
				}
				if (ImGui.DragFloat4(text, ref vector7, 0.1f))
				{
					A_4(vector7);
				}
				return true;
			}
			else if (A_2 == typeof(Vector2i))
			{
				럸.랾(A_0, A_1, A_2, flag);
				object obj;
				if (A_3 is Vector2i)
				{
					Vector2i vector2i = (Vector2i)A_3;
					obj = vector2i;
				}
				else
				{
					obj = new Vector2i(0, 0);
				}
				object obj2 = obj;
				int x = obj2.x;
				int y = obj2.y;
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(4, 2);
					defaultInterpolatedStringHandler5.AppendLiteral("(");
					defaultInterpolatedStringHandler5.AppendFormatted<int>(x);
					defaultInterpolatedStringHandler5.AppendLiteral(", ");
					defaultInterpolatedStringHandler5.AppendFormatted<int>(y);
					defaultInterpolatedStringHandler5.AppendLiteral(")");
					럸.랾(defaultInterpolatedStringHandler5.ToStringAndClear());
					return true;
				}
				ImGui.SetNextItemWidth(100f);
				bool flag5 = ImGui.DragInt("X" + text, ref x);
				ImGui.SameLine();
				ImGui.SetNextItemWidth(100f);
				if (flag5 | ImGui.DragInt("Y" + text, ref y))
				{
					A_4(new Vector2i(x, y));
				}
				return true;
			}
			else if (A_2 == typeof(World.BlockType))
			{
				럸.랾(A_0, A_1, A_2, flag);
				int num17 = (A_3 != null) ? Convert.ToInt32(A_3) : 0;
				string value2 = ((A_3 != null) ? A_3.ToString() : null) ?? "None";
				if (flag)
				{
					Vector4 vector8 = 럸.랓;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler6.AppendFormatted(value2);
					defaultInterpolatedStringHandler6.AppendLiteral(" (");
					defaultInterpolatedStringHandler6.AppendFormatted<int>(num17);
					defaultInterpolatedStringHandler6.AppendLiteral(")");
					ImGui.TextColored(vector8, defaultInterpolatedStringHandler6.ToStringAndClear());
					return true;
				}
				if (ImGui.InputInt(text, ref num17))
				{
					A_4(num17);
				}
				ImGui.SameLine();
				Vector4 vector9 = 럸.랓;
				World.BlockType blockType = num17;
				ImGui.TextColored(vector9, blockType.ToString());
				return true;
			}
			else
			{
				if (!(A_2 == typeof(PlayerData.InventoryKey)))
				{
					return false;
				}
				럸.랾(A_0, A_1, A_2, flag);
				int num18 = 0;
				if (A_3 is PlayerData.InventoryKey)
				{
					PlayerData.InventoryKey inventoryKey = (PlayerData.InventoryKey)A_3;
					num18 = inventoryKey.blockType;
				}
				string value3 = ((A_3 != null) ? A_3.ToString() : null) ?? "None";
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler7.AppendFormatted(value3);
					defaultInterpolatedStringHandler7.AppendLiteral(" (");
					defaultInterpolatedStringHandler7.AppendFormatted<int>(num18);
					defaultInterpolatedStringHandler7.AppendLiteral(")");
					럸.랾(defaultInterpolatedStringHandler7.ToStringAndClear());
					return true;
				}
				if (ImGui.InputInt(text, ref num18))
				{
					A_4(PlayerData.InventoryKey.IntToInventoryKey(num18));
				}
				ImGui.SameLine();
				Vector4 vector10 = 럸.랓;
				World.BlockType blockType = num18;
				ImGui.TextColored(vector10, blockType.ToString());
				return true;
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000B1F7C File Offset: 0x000B017C
		private static void 랾(string A_0, string A_1, Type A_2, bool A_3)
		{
			ImGui.TextColored(A_3 ? 럸.럼 : 럸.럒, A_0 + ": " + A_1);
			ImGui.SameLine();
			ImGui.TextColored(럸.람, "[" + 럸.랋(A_2) + "]");
			ImGui.SameLine();
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000415AB File Offset: 0x0003F7AB
		private static void 랾(string A_0)
		{
			ImGui.TextColored(럸.럐, A_0);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000415B8 File Offset: 0x0003F7B8
		private static void 랾(string A_0, string A_1)
		{
			ImGui.SameLine();
			if (ImGui.SmallButton("Copy" + A_1))
			{
				ImGui.SetClipboardText(A_0);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000B1FD4 File Offset: 0x000B01D4
		private static void 랾(string A_0, object A_1, Type A_2, Action<object> A_3, int A_4)
		{
			if (A_1 == null)
			{
				ImGui.TextColored(럸.럎, "h");
				return;
			}
			if (A_4 > 5)
			{
				ImGui.TextDisabled("(max depth)");
				return;
			}
			IDictionary dictionary = A_1 as IDictionary;
			if (dictionary != null)
			{
				럸.랾(A_0, dictionary, A_4);
				return;
			}
			IEnumerable enumerable = A_1 as IEnumerable;
			if (enumerable != null && A_2 != typeof(string))
			{
				럸.랾(A_0, enumerable, A_2, A_4);
				return;
			}
			럸.랾(A_1, A_2, A_4);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000B2048 File Offset: 0x000B0248
		private static void 랾(string A_0, IDictionary A_1, int A_2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Count: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1.Count);
			ImGui.TextDisabled(defaultInterpolatedStringHandler.ToStringAndClear());
			int num = 0;
			foreach (object obj in A_1)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if (num >= 128)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("(first ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(128);
					defaultInterpolatedStringHandler2.AppendLiteral(" shown)");
					ImGui.TextDisabled(defaultInterpolatedStringHandler2.ToStringAndClear());
					break;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler3.AppendFormatted(A_0);
				defaultInterpolatedStringHandler3.AppendLiteral("_d");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(num);
				using (new 럸.람(defaultInterpolatedStringHandler3.ToStringAndClear()))
				{
					object key = dictionaryEntry.Key;
					object value = dictionaryEntry.Value;
					Type type = ((value != null) ? value.GetType() : null) ?? typeof(object);
					string text = ((key != null) ? key.ToString() : null) ?? "h";
					if (text.Length > 60)
					{
						text = text.Substring(0, 60) + "...";
					}
					if (value == null)
					{
						ImGui.TextColored(럸.랉, "[" + text + "]");
						ImGui.SameLine();
						ImGui.TextColored(럸.럎, "= null");
					}
					else if (럸.럼(type))
					{
						ImGui.TextColored(럸.랉, "[" + text + "]");
						ImGui.SameLine();
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(2, 1);
						defaultInterpolatedStringHandler4.AppendLiteral("= ");
						defaultInterpolatedStringHandler4.AppendFormatted<object>(value);
						럸.랾(defaultInterpolatedStringHandler4.ToStringAndClear());
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(6, 3);
						defaultInterpolatedStringHandler5.AppendLiteral("[");
						defaultInterpolatedStringHandler5.AppendFormatted(text);
						defaultInterpolatedStringHandler5.AppendLiteral("] [");
						defaultInterpolatedStringHandler5.AppendFormatted(럸.랋(type));
						defaultInterpolatedStringHandler5.AppendLiteral("] ");
						defaultInterpolatedStringHandler5.AppendFormatted(럸.럎(value, type));
						if (ImGui.TreeNode(defaultInterpolatedStringHandler5.ToStringAndClear()))
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(1, 1);
							defaultInterpolatedStringHandler6.AppendLiteral("d");
							defaultInterpolatedStringHandler6.AppendFormatted<int>(num);
							럸.랾(defaultInterpolatedStringHandler6.ToStringAndClear(), value, type, null, A_2 + 1);
							ImGui.TreePop();
						}
					}
					num++;
				}
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000B2310 File Offset: 0x000B0510
		private static void 랾(string A_0, IEnumerable A_1, Type A_2, int A_3)
		{
			int? num = 럸.랾(A_1);
			if (num != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Count: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num.Value);
				ImGui.TextDisabled(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			Type type = 럸.럒(A_2);
			int num2 = 0;
			foreach (object obj in A_1)
			{
				if (num2 >= 128)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("(first ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(128);
					defaultInterpolatedStringHandler2.AppendLiteral(" shown)");
					ImGui.TextDisabled(defaultInterpolatedStringHandler2.ToStringAndClear());
					break;
				}
				Type type2;
				if ((type2 = ((obj != null) ? obj.GetType() : null)) == null)
				{
					type2 = (type ?? typeof(object));
				}
				Type type3 = type2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler3.AppendFormatted(A_0);
				defaultInterpolatedStringHandler3.AppendLiteral("_");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(num2);
				using (new 럸.람(defaultInterpolatedStringHandler3.ToStringAndClear()))
				{
					string text = "Item";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler4.AppendLiteral("[");
					defaultInterpolatedStringHandler4.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler4.AppendLiteral("]");
					if (럸.랾(text, defaultInterpolatedStringHandler4.ToStringAndClear(), type3, obj, null, A_3))
					{
						num2++;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(6, 3);
						defaultInterpolatedStringHandler5.AppendLiteral("[");
						defaultInterpolatedStringHandler5.AppendFormatted<int>(num2);
						defaultInterpolatedStringHandler5.AppendLiteral("] [");
						defaultInterpolatedStringHandler5.AppendFormatted(럸.랋(type3));
						defaultInterpolatedStringHandler5.AppendLiteral("] ");
						defaultInterpolatedStringHandler5.AppendFormatted(럸.럎(obj, type3));
						if (ImGui.TreeNode(defaultInterpolatedStringHandler5.ToStringAndClear()))
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(2, 1);
							defaultInterpolatedStringHandler6.AppendLiteral("[");
							defaultInterpolatedStringHandler6.AppendFormatted<int>(num2);
							defaultInterpolatedStringHandler6.AppendLiteral("]");
							럸.랾(defaultInterpolatedStringHandler6.ToStringAndClear(), obj, type3, null, A_3 + 1);
							ImGui.TreePop();
						}
						num2++;
					}
				}
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000B2574 File Offset: 0x000B0774
		private static void 랾(object A_0, Type A_1, int A_2)
		{
			럸.럭 럭 = new 럸.럭();
			럭.랾 = A_0;
			럸.랾 랾 = 럸.랾(A_1);
			FieldInfo[] array = 랾.럎;
			for (int i = 0; i < array.Length; i++)
			{
				럸.랱 랱 = new 럸.랱();
				랱.랾 = 럭;
				랱.랾 = array[i];
				if (string.IsNullOrEmpty(럧.럽) || 럸.럒(랱.랾.Name))
				{
					try
					{
						럸.랾(랱.랾, new Func<object>(랱.랾), (랱.랾.IsLiteral || 랱.랾.IsInitOnly) ? null : new Action<object>(랱.랾), A_2);
					}
					catch (Exception ex)
					{
						ImGui.TextColored(럸.랾, "[!] " + 랱.랾.Name + ": " + ex.Message);
					}
				}
			}
			PropertyInfo[] array2 = 랾.럎;
			for (int i = 0; i < array2.Length; i++)
			{
				럸.럙 럙 = new 럸.럙();
				럙.랾 = 럭;
				럙.랾 = array2[i];
				if (string.IsNullOrEmpty(럧.럽) || 럸.럒(럙.랾.Name))
				{
					try
					{
						MethodInfo setMethod = 럙.랾.GetSetMethod(true);
						럸.랾(럙.랾, new Func<object>(럙.랾), (setMethod != null) ? new Action<object>(럙.랾) : null, A_2);
					}
					catch (Exception ex2)
					{
						ImGui.TextColored(럸.랾, "[!] " + 럙.랾.Name + ": " + ex2.Message);
					}
				}
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000B2750 File Offset: 0x000B0950
		private static void 럎(MethodInfo A_0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			defaultInterpolatedStringHandler.AppendFormatted(럸.랋(A_0.ReturnType));
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(A_0.Name);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join(", ", A_0.GetParameters().Select(new Func<ParameterInfo, string>(럸.럼.랾.럎))));
			defaultInterpolatedStringHandler.AppendLiteral(")");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			string value = string.Join("_", A_0.GetParameters().Select(new Func<ParameterInfo, string>(럸.럼.랾.람)));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(4, 4);
			Type declaringType = A_0.DeclaringType;
			defaultInterpolatedStringHandler2.AppendFormatted(((declaringType != null) ? declaringType.FullName : null) ?? "?");
			defaultInterpolatedStringHandler2.AppendLiteral("::");
			defaultInterpolatedStringHandler2.AppendFormatted(A_0.Name);
			defaultInterpolatedStringHandler2.AppendLiteral("_");
			defaultInterpolatedStringHandler2.AppendFormatted(A_0.ReturnType.FullName ?? A_0.ReturnType.Name);
			defaultInterpolatedStringHandler2.AppendLiteral("_");
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			string text2 = defaultInterpolatedStringHandler2.ToStringAndClear();
			ParameterInfo[] parameters = A_0.GetParameters();
			ImGui.TextColored(럸.랋, text);
			if (!럧.랾.ContainsKey(text2))
			{
				럧.랾[text2] = new object[parameters.Length];
			}
			if (parameters.Length != 0)
			{
				ImGui.Indent();
				for (int i = 0; i < parameters.Length; i++)
				{
					ParameterInfo parameterInfo = parameters[i];
					ImGui.TextColored(럸.럒, parameterInfo.Name);
					ImGui.SameLine();
					ImGui.TextColored(럸.람, "[" + 럸.랋(parameterInfo.ParameterType) + "]");
					if (럧.랾[text2][i] == null)
					{
						럧.랾[text2][i] = (parameterInfo.ParameterType.IsValueType ? Activator.CreateInstance(parameterInfo.ParameterType) : ((parameterInfo.ParameterType == typeof(string)) ? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮() : null));
					}
					럸.랾(text2, i, parameterInfo.ParameterType);
				}
				ImGui.Unindent();
			}
			if (ImGui.Button("Execute##" + text2))
			{
				럸.랾(A_0, text2);
			}
			ImGui.Separator();
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000B29D4 File Offset: 0x000B0BD4
		private static void 랾(string A_0, int A_1, Type A_2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("##");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral("_p");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			object[] array = 럧.랾[A_0];
			if (A_2 == typeof(string))
			{
				string text2 = (array[A_1] as string) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				if (ImGui.InputText(text, ref text2, 512U))
				{
					array[A_1] = text2;
					return;
				}
			}
			else if (A_2 == typeof(int))
			{
				object obj = array[A_1];
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
				if (ImGui.InputInt(text, ref num3))
				{
					array[A_1] = num3;
					return;
				}
			}
			else if (A_2 == typeof(float))
			{
				object obj = array[A_1];
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
				if (ImGui.DragFloat(text, ref num6, 0.1f))
				{
					array[A_1] = num6;
					return;
				}
			}
			else if (A_2 == typeof(bool))
			{
				object obj = array[A_1];
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
				if (ImGui.Checkbox(text, ref flag3))
				{
					array[A_1] = flag3;
					return;
				}
			}
			else if (A_2 == typeof(long))
			{
				object obj2 = array[A_1];
				string s = ((obj2 != null) ? obj2.ToString() : null) ?? "0";
				long num7;
				if (ImGui.InputText(text, ref s, 64U) && long.TryParse(s, out num7))
				{
					array[A_1] = num7;
					return;
				}
			}
			else if (A_2 == typeof(double))
			{
				object obj = array[A_1];
				float num9;
				if (obj is double)
				{
					double num8 = (double)obj;
					num9 = (float)num8;
				}
				else
				{
					num9 = 0f;
				}
				float num10 = num9;
				if (ImGui.DragFloat(text, ref num10, 0.1f))
				{
					array[A_1] = (double)num10;
					return;
				}
			}
			else
			{
				if (A_2 == typeof(World.BlockType))
				{
					object obj = array[A_1];
					int num12;
					if (obj is int)
					{
						int num11 = (int)obj;
						num12 = num11;
					}
					else
					{
						obj = array[A_1];
						if (obj is World.BlockType)
						{
							World.BlockType blockType = (World.BlockType)obj;
							num12 = blockType;
						}
						else
						{
							num12 = 0;
						}
					}
					int num13 = num12;
					if (ImGui.InputInt(text, ref num13))
					{
						array[A_1] = num13;
					}
					ImGui.SameLine();
					Vector4 vector = 럸.랓;
					World.BlockType blockType2 = num13;
					ImGui.TextColored(vector, blockType2.ToString());
					return;
				}
				if (A_2 == typeof(Vector2i))
				{
					object obj = array[A_1];
					object obj3;
					if (obj is Vector2i)
					{
						Vector2i vector2i = (Vector2i)obj;
						obj3 = vector2i;
					}
					else
					{
						obj3 = new Vector2i(0, 0);
					}
					object obj4 = obj3;
					int x = obj4.x;
					int y = obj4.y;
					ImGui.SetNextItemWidth(100f);
					ImGui.InputInt(text + "_X", ref x);
					ImGui.SameLine();
					ImGui.SetNextItemWidth(100f);
					ImGui.InputInt(text + "_Y", ref y);
					array[A_1] = new Vector2i(x, y);
					return;
				}
				if (A_2 == typeof(PlayerData.InventoryKey))
				{
					int num14 = 0;
					object obj = array[A_1];
					if (obj is PlayerData.InventoryKey)
					{
						PlayerData.InventoryKey inventoryKey = (PlayerData.InventoryKey)obj;
						num14 = inventoryKey.blockType;
					}
					if (ImGui.InputInt(text, ref num14))
					{
						array[A_1] = PlayerData.InventoryKey.IntToInventoryKey(num14);
					}
					ImGui.SameLine();
					Vector4 vector2 = 럸.랓;
					World.BlockType blockType2 = num14;
					ImGui.TextColored(vector2, blockType2.ToString());
					return;
				}
				if (A_2 == typeof(InventoryItemBase))
				{
					InventoryItemBase inventoryItemBase = array[A_1] as InventoryItemBase;
					int num15 = (inventoryItemBase != null) ? inventoryItemBase.blockType : 0;
					if (ImGui.InputInt(text, ref num15))
					{
						array[A_1] = new InventoryItemBase(num15);
					}
					ImGui.SameLine();
					Vector4 vector3 = 럸.랓;
					World.BlockType blockType2 = num15;
					ImGui.TextColored(vector3, blockType2.ToString());
					return;
				}
				if (A_2 == typeof(DateTime))
				{
					럸.랾(A_0, A_1);
					return;
				}
				if (A_2 == typeof(List<string>))
				{
					럸.랾<string>(A_0, A_1, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), new 럸.럎<string>(럸.럼.랾.랾));
					return;
				}
				if (A_2 == typeof(List<int>))
				{
					럸.랾<int>(A_0, A_1, 0, new 럸.럎<int>(럸.럼.랾.랾));
					return;
				}
				if (A_2.IsEnum)
				{
					string[] names = Enum.GetNames(A_2);
					int num16 = 0;
					if (array[A_1] != null)
					{
						int num17 = Array.IndexOf<string>(names, array[A_1].ToString());
						if (num17 >= 0)
						{
							num16 = num17;
						}
					}
					if (ImGui.Combo(text, ref num16, names, names.Length))
					{
						array[A_1] = Enum.Parse(A_2, names[num16]);
						return;
					}
				}
				else
				{
					ImGui.TextDisabled("  [" + 럸.랋(A_2) + "] (not editable)");
				}
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000B2EE0 File Offset: 0x000B10E0
		private static void 랾(string A_0, int A_1)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("##");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral("_p");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1);
			string str = defaultInterpolatedStringHandler.ToStringAndClear();
			object[] array = 럧.랾[A_0];
			object obj = array[A_1];
			DateTime dateTime2;
			if (obj is DateTime)
			{
				DateTime dateTime = (DateTime)obj;
				dateTime2 = dateTime;
			}
			else
			{
				dateTime2 = DateTime.Now;
			}
			DateTime dateTime3 = dateTime2;
			int year = dateTime3.Year;
			int num = dateTime3.Month;
			int num2 = dateTime3.Day;
			int num3 = dateTime3.Hour;
			int num4 = dateTime3.Minute;
			int num5 = dateTime3.Second;
			ImGui.SetNextItemWidth(70f);
			ImGui.InputInt("Y" + str, ref year);
			ImGui.SameLine();
			ImGui.SetNextItemWidth(45f);
			ImGui.InputInt("M" + str, ref num);
			ImGui.SameLine();
			ImGui.SetNextItemWidth(45f);
			ImGui.InputInt("D" + str, ref num2);
			ImGui.SetNextItemWidth(45f);
			ImGui.InputInt("h" + str, ref num3);
			ImGui.SameLine();
			ImGui.SetNextItemWidth(45f);
			ImGui.InputInt("m" + str, ref num4);
			ImGui.SameLine();
			ImGui.SetNextItemWidth(45f);
			ImGui.InputInt("s" + str, ref num5);
			num = Math.Clamp(num, 1, 12);
			num2 = Math.Clamp(num2, 1, DateTime.DaysInMonth(Math.Max(1, year), num));
			num3 = Math.Clamp(num3, 0, 23);
			num4 = Math.Clamp(num4, 0, 59);
			num5 = Math.Clamp(num5, 0, 59);
			try
			{
				array[A_1] = new DateTime(year, num, num2, num3, num4, num5);
			}
			catch
			{
				ImGui.TextColored(럸.랾, "  Invalid date");
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000B30D4 File Offset: 0x000B12D4
		private static void 랾<랾>(string A_0, int A_1, 랾 A_2, 럸.럎<랾> A_3)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("##");
			defaultInterpolatedStringHandler.AppendFormatted(A_0);
			defaultInterpolatedStringHandler.AppendLiteral("_p");
			defaultInterpolatedStringHandler.AppendFormatted<int>(A_1);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			object[] array = 럧.랾[A_0];
			List<랾> list = (array[A_1] as List<랾>) ?? new List<랾>();
			for (int i = 0; i < list.Count; i++)
			{
				List<랾> list2 = list;
				int index = i;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler2.AppendFormatted(text);
				defaultInterpolatedStringHandler2.AppendLiteral("_");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(i);
				list2[index] = A_3(defaultInterpolatedStringHandler2.ToStringAndClear(), list[i]);
				ImGui.SameLine();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler3.AppendLiteral("X");
				defaultInterpolatedStringHandler3.AppendFormatted(text);
				defaultInterpolatedStringHandler3.AppendLiteral("_");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(i);
				if (ImGui.SmallButton(defaultInterpolatedStringHandler3.ToStringAndClear()))
				{
					list.RemoveAt(i);
					i--;
				}
			}
			if (ImGui.SmallButton("+ Add" + text))
			{
				list.Add(A_2);
			}
			array[A_1] = list;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000B3208 File Offset: 0x000B1408
		private static void 랾(MethodInfo A_0, string A_1)
		{
			try
			{
				ParameterInfo[] parameters = A_0.GetParameters();
				object[] array = null;
				if (parameters.Length != 0)
				{
					object[] array2 = 럧.랾[A_1];
					array = new object[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						Type parameterType = parameters[i].ParameterType;
						object obj = array2[i];
						object[] array3 = array;
						int num = i;
						World.BlockType blockType;
						if (parameterType == typeof(World.BlockType) && obj is int)
						{
							int num2 = (int)obj;
							blockType = num2;
						}
						else
						{
							blockType = obj;
						}
						array3[num] = blockType;
					}
				}
				object obj2 = A_0.Invoke(null, array);
				if (A_0.ReturnType == typeof(void) || obj2 == null)
				{
					럽.랾(A_0.Name + "() OK", false);
				}
				else
				{
					List<string> list = obj2 as List<string>;
					string text;
					if (list == null)
					{
						List<int> list2 = obj2 as List<int>;
						if (list2 == null)
						{
							ICollection collection = obj2 as ICollection;
							if (collection == null)
							{
								text = obj2.ToString();
							}
							else
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendFormatted(럸.랋(obj2.GetType()));
								defaultInterpolatedStringHandler.AppendLiteral(" (Count: ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(collection.Count);
								defaultInterpolatedStringHandler.AppendLiteral(")");
								text = defaultInterpolatedStringHandler.ToStringAndClear();
							}
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("List<int>[");
							defaultInterpolatedStringHandler2.AppendFormatted<int>(list2.Count);
							defaultInterpolatedStringHandler2.AppendLiteral("]: ");
							defaultInterpolatedStringHandler2.AppendFormatted(string.Join<int>(", ", list2.Take(20)));
							text = defaultInterpolatedStringHandler2.ToStringAndClear();
						}
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(16, 2);
						defaultInterpolatedStringHandler3.AppendLiteral("List<string>[");
						defaultInterpolatedStringHandler3.AppendFormatted<int>(list.Count);
						defaultInterpolatedStringHandler3.AppendLiteral("]: ");
						defaultInterpolatedStringHandler3.AppendFormatted(string.Join(", ", list.Take(20)));
						text = defaultInterpolatedStringHandler3.ToStringAndClear();
					}
					string str = text;
					럽.랾(A_0.Name + "() -> " + str, false);
				}
			}
			catch (TargetInvocationException ex)
			{
				string str2 = "Method error: ";
				Exception innerException = ex.InnerException;
				럽.람(str2 + (((innerException != null) ? innerException.Message : null) ?? ex.Message), false);
			}
			catch (Exception ex2)
			{
				럽.람("Execution error: " + ex2.Message, false);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000B34A0 File Offset: 0x000B16A0
		private static int? 랾(IEnumerable A_0)
		{
			ICollection collection = A_0 as ICollection;
			if (collection != null)
			{
				return new int?(collection.Count);
			}
			PropertyInfo property = A_0.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Public);
			int? num;
			if (property == null || !property.CanRead)
			{
				num = null;
				return num;
			}
			try
			{
				object value = property.GetValue(A_0);
				int? num2;
				if (value is int)
				{
					int value2 = (int)value;
					num2 = new int?(value2);
				}
				else
				{
					num = null;
					num2 = num;
				}
				num = num2;
			}
			catch
			{
				num = null;
			}
			return num;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000B3544 File Offset: 0x000B1744
		private static Type 럒(Type A_0)
		{
			if (A_0.IsArray)
			{
				return A_0.GetElementType();
			}
			if (A_0.IsGenericType)
			{
				return A_0.GetGenericArguments().FirstOrDefault<Type>();
			}
			Type type = A_0.GetInterfaces().FirstOrDefault(new Func<Type, bool>(럸.럼.랾.랾));
			if (type == null)
			{
				return null;
			}
			return type.GetGenericArguments().FirstOrDefault<Type>();
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000B35B0 File Offset: 0x000B17B0
		private static string 럎(object A_0, Type A_1)
		{
			if (A_0 == null)
			{
				return "(null)";
			}
			if (A_1 == typeof(string))
			{
				string text = (string)A_0;
				if (text.Length <= 60)
				{
					return "= \"" + text + "\"";
				}
				return "= \"" + text.Substring(0, 60) + "...\"";
			}
			else
			{
				if (A_1.IsPrimitive || A_1.IsEnum || A_1 == typeof(decimal))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("= ");
					defaultInterpolatedStringHandler.AppendFormatted<object>(A_0);
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				IDictionary dictionary = A_0 as IDictionary;
				if (dictionary != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("(Count: ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(dictionary.Count);
					defaultInterpolatedStringHandler2.AppendLiteral(")");
					return defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				IEnumerable enumerable = A_0 as IEnumerable;
				if (enumerable == null || !(A_1 != typeof(string)))
				{
					MethodInfo method = A_1.GetMethod("ToString", Type.EmptyTypes);
					if (method != null && method.DeclaringType != typeof(object) && method.DeclaringType != typeof(ValueType))
					{
						try
						{
							string text2 = A_0.ToString();
							if (text2 != null && text2 != A_1.FullName && text2.Length <= 80)
							{
								return "= " + text2;
							}
						}
						catch
						{
						}
					}
					return E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				}
				int? num = 럸.랾(enumerable);
				if (num == null)
				{
					return E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler3.AppendLiteral("(Count: ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(num.Value);
				defaultInterpolatedStringHandler3.AppendLiteral(")");
				return defaultInterpolatedStringHandler3.ToStringAndClear();
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000B37A4 File Offset: 0x000B19A4
		private static string 람(object A_0, Type A_1)
		{
			if (A_0 == null)
			{
				return "h";
			}
			if (A_1 == typeof(string))
			{
				string text = (string)A_0;
				if (text.Length <= 80)
				{
					return "\"" + text + "\"";
				}
				return "\"" + text.Substring(0, 80) + "...\"";
			}
			else
			{
				if (A_1.IsPrimitive || A_1.IsEnum || A_1 == typeof(decimal))
				{
					return A_0.ToString();
				}
				ICollection collection = A_0 as ICollection;
				if (collection != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler.AppendFormatted(럸.랋(A_1));
					defaultInterpolatedStringHandler.AppendLiteral(" (Count: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(collection.Count);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				return A_0.ToString();
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000415D7 File Offset: 0x0003F7D7
		private static bool 럼(Type A_0)
		{
			return A_0.IsPrimitive || A_0.IsEnum || A_0 == typeof(string) || A_0 == typeof(decimal);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000B3884 File Offset: 0x000B1A84
		private static string 랋(Type A_0)
		{
			if (A_0 == null)
			{
				return "?";
			}
			if (A_0 == typeof(int))
			{
				return "int";
			}
			if (A_0 == typeof(float))
			{
				return "float";
			}
			if (A_0 == typeof(double))
			{
				return "double";
			}
			if (A_0 == typeof(bool))
			{
				return "bool";
			}
			if (A_0 == typeof(string))
			{
				return "string";
			}
			if (A_0 == typeof(long))
			{
				return "long";
			}
			if (A_0 == typeof(byte))
			{
				return "byte";
			}
			if (A_0 == typeof(short))
			{
				return "short";
			}
			if (A_0 == typeof(void))
			{
				return "void";
			}
			if (A_0 == typeof(object))
			{
				return "object";
			}
			if (A_0.IsArray)
			{
				return 럸.랋(A_0.GetElementType()) + "[]";
			}
			if (!A_0.IsGenericType)
			{
				return A_0.Name;
			}
			string text = A_0.Name;
			int num = text.IndexOf('`');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			string str = text;
			string str2 = "<";
			string separator = ", ";
			IEnumerable<Type> genericArguments = A_0.GetGenericArguments();
			Func<Type, string> selector;
			if ((selector = 럸.럒.랾) == null)
			{
				selector = (럸.럒.랾 = new Func<Type, string>(럸.랋));
			}
			return str + str2 + string.Join(separator, genericArguments.Select(selector)) + ">";
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0004160D File Offset: 0x0003F80D
		public static IReadOnlyList<string> 럎()
		{
			return Array.Empty<string>();
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000B3A1C File Offset: 0x000B1C1C
		public static Type 럎(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return null;
			}
			string text = A_0.Trim();
			foreach (Assembly assembly in 럸.람())
			{
				try
				{
					Type type = assembly.GetType(text, false, true);
					if (type != null)
					{
						return type;
					}
				}
				catch
				{
				}
			}
			Type result;
			try
			{
				result = Type.GetType(text, false, true);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000B3ABC File Offset: 0x000B1CBC
		private static IEnumerable<Assembly> 람()
		{
			Dictionary<string, Assembly> dictionary = new Dictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				if (!(assembly == null) && !assembly.IsDynamic)
				{
					string name = assembly.GetName().Name;
					if (!string.IsNullOrWhiteSpace(name) && !럸.람(name))
					{
						dictionary[name] = assembly;
					}
				}
			}
			foreach (string text in new string[]
			{
				"Assembly-CSharp",
				"Assembly-CSharp-firstpass",
				"UnityEngine",
				"UnityEngine.CoreModule",
				"UnityEngine.UI"
			})
			{
				if (!dictionary.ContainsKey(text))
				{
					try
					{
						Assembly assembly2 = Assembly.Load(text);
						if (assembly2 != null)
						{
							dictionary[text] = assembly2;
						}
					}
					catch
					{
					}
				}
			}
			return dictionary.Values;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00041614 File Offset: 0x0003F814
		private static bool 람(string A_0)
		{
			return A_0.StartsWith("System", StringComparison.OrdinalIgnoreCase) || A_0.StartsWith("Microsoft", StringComparison.OrdinalIgnoreCase) || A_0.StartsWith("mscorlib", StringComparison.OrdinalIgnoreCase) || A_0.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0004164E File Offset: 0x0003F84E
		private static bool 럒(string A_0)
		{
			return string.IsNullOrEmpty(럧.럽) || A_0.IndexOf(럧.럽, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		// Token: 0x040006D9 RID: 1753
		private const int 랾 = 5;

		// Token: 0x040006DA RID: 1754
		private const int 럎 = 128;

		// Token: 0x040006DB RID: 1755
		private const int 람 = 1024;

		// Token: 0x040006DC RID: 1756
		private const int 럒 = 120;

		// Token: 0x040006DD RID: 1757
		private static readonly Vector4 랾 = new Vector4(1f, 0.4f, 0.4f, 1f);

		// Token: 0x040006DE RID: 1758
		private static readonly Vector4 럎 = new Vector4(0.5f, 0.5f, 0.5f, 1f);

		// Token: 0x040006DF RID: 1759
		private static readonly Vector4 람 = new Vector4(0.4f, 0.8f, 1f, 1f);

		// Token: 0x040006E0 RID: 1760
		private static readonly Vector4 럒 = new Vector4(0.85f, 0.85f, 0.45f, 1f);

		// Token: 0x040006E1 RID: 1761
		private static readonly Vector4 럼 = new Vector4(0.65f, 0.65f, 0.65f, 1f);

		// Token: 0x040006E2 RID: 1762
		private static readonly Vector4 랋 = new Vector4(0.45f, 1f, 0.45f, 1f);

		// Token: 0x040006E3 RID: 1763
		private static readonly Vector4 랉 = new Vector4(0.55f, 0.7f, 0.95f, 1f);

		// Token: 0x040006E4 RID: 1764
		private static readonly Vector4 럐 = new Vector4(0.9f, 0.75f, 0.5f, 1f);

		// Token: 0x040006E5 RID: 1765
		private static readonly Vector4 랓 = new Vector4(0.6f, 0.9f, 0.6f, 1f);

		// Token: 0x040006E6 RID: 1766
		private static readonly Vector4 럯 = new Vector4(0.3f, 1f, 0.3f, 1f);

		// Token: 0x040006E7 RID: 1767
		private static readonly Vector4 럭 = new Vector4(1f, 0.3f, 0.3f, 1f);

		// Token: 0x040006E8 RID: 1768
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.Ordinal)
		{
			"BanAndKickPlayerFromGameByHammer",
			"BanAndKickPlayerFromGame",
			"SubmitGlobalChatMessage"
		};

		// Token: 0x040006E9 RID: 1769
		private static readonly Dictionary<Type, 럸.랾> 랾 = new Dictionary<Type, 럸.랾>();

		// Token: 0x02000125 RID: 293
		private sealed class 랾
		{
			// Token: 0x040006EA RID: 1770
			public FieldInfo[] 랾;

			// Token: 0x040006EB RID: 1771
			public PropertyInfo[] 랾;

			// Token: 0x040006EC RID: 1772
			public MethodInfo[] 랾;

			// Token: 0x040006ED RID: 1773
			public FieldInfo[] 럎;

			// Token: 0x040006EE RID: 1774
			public PropertyInfo[] 럎;
		}

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x0600098C RID: 2444
		private delegate 랾 럎<랾>(string, 랾);

		// Token: 0x02000127 RID: 295
		private readonly struct 람 : IDisposable
		{
			// Token: 0x0600098F RID: 2447 RVA: 0x00041670 File Offset: 0x0003F870
			public 람(string A_1)
			{
				ImGui.PushID(A_1);
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x00041678 File Offset: 0x0003F878
			public void Dispose()
			{
				ImGui.PopID();
			}
		}

		// Token: 0x02000128 RID: 296
		[CompilerGenerated]
		private static class 럒
		{
			// Token: 0x040006EF RID: 1775
			public static Func<MethodInfo, string> 랾;

			// Token: 0x040006F0 RID: 1776
			public static Func<Type, string> 랾;
		}

		// Token: 0x02000129 RID: 297
		[CompilerGenerated]
		[Serializable]
		private sealed class 럼
		{
			// Token: 0x06000993 RID: 2451 RVA: 0x0004168B File Offset: 0x0003F88B
			internal bool 랾(FieldInfo A_1)
			{
				return !A_1.IsSpecialName && !럸.랾(A_1);
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x000416A0 File Offset: 0x0003F8A0
			internal string 럎(FieldInfo A_1)
			{
				return A_1.Name;
			}

			// Token: 0x06000995 RID: 2453 RVA: 0x000B3D48 File Offset: 0x000B1F48
			internal bool 랾(PropertyInfo A_1)
			{
				if (A_1.GetIndexParameters().Length == 0 && !럸.랾(A_1))
				{
					MethodInfo getMethod = A_1.GetGetMethod(true);
					if (getMethod != null)
					{
						return getMethod.IsStatic;
					}
				}
				return false;
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x000416A0 File Offset: 0x0003F8A0
			internal string 럎(PropertyInfo A_1)
			{
				return A_1.Name;
			}

			// Token: 0x06000997 RID: 2455 RVA: 0x000416A8 File Offset: 0x0003F8A8
			internal bool 랾(MethodInfo A_1)
			{
				return !A_1.IsSpecialName && !럸.랾.Contains(A_1.Name);
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x000416C7 File Offset: 0x0003F8C7
			internal MethodInfo 랾(IGrouping<string, MethodInfo> A_1)
			{
				return A_1.First<MethodInfo>();
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x000416A0 File Offset: 0x0003F8A0
			internal string 럎(MethodInfo A_1)
			{
				return A_1.Name;
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x0004168B File Offset: 0x0003F88B
			internal bool 람(FieldInfo A_1)
			{
				return !A_1.IsSpecialName && !럸.랾(A_1);
			}

			// Token: 0x0600099B RID: 2459 RVA: 0x000416A0 File Offset: 0x0003F8A0
			internal string 럒(FieldInfo A_1)
			{
				return A_1.Name;
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x000416CF File Offset: 0x0003F8CF
			internal bool 람(PropertyInfo A_1)
			{
				return A_1.GetIndexParameters().Length == 0 && A_1.CanRead && !럸.랾(A_1);
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x000416A0 File Offset: 0x0003F8A0
			internal string 럒(PropertyInfo A_1)
			{
				return A_1.Name;
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x000416ED File Offset: 0x0003F8ED
			internal string 랾(ParameterInfo A_1)
			{
				return A_1.ParameterType.FullName ?? A_1.ParameterType.Name;
			}

			// Token: 0x0600099F RID: 2463 RVA: 0x000B3D7C File Offset: 0x000B1F7C
			internal void 럼(PropertyInfo A_1)
			{
				럸.럯 럯 = new 럸.럯();
				럯.랾 = A_1;
				MethodInfo setMethod = 럯.랾.GetSetMethod(true);
				bool flag = setMethod != null && setMethod.IsStatic;
				럸.랾(럯.랾, new Func<object>(럯.랾), flag ? new Action<object>(럯.랾) : null, 0);
			}

			// Token: 0x060009A0 RID: 2464 RVA: 0x00041709 File Offset: 0x0003F909
			internal string 럎(ParameterInfo A_1)
			{
				return 럸.랋(A_1.ParameterType) + " " + A_1.Name;
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x00041726 File Offset: 0x0003F926
			internal string 람(ParameterInfo A_1)
			{
				return 럸.랋(A_1.ParameterType);
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x000B3DE0 File Offset: 0x000B1FE0
			internal string 랾(string A_1, string A_2)
			{
				string result = A_2 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
				ImGui.InputText(A_1, ref result, 256U);
				return result;
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x000B3E08 File Offset: 0x000B2008
			internal int 랾(string A_1, int A_2)
			{
				int result = A_2;
				ImGui.InputInt(A_1, ref result);
				return result;
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x00041733 File Offset: 0x0003F933
			internal bool 랾(Type A_1)
			{
				return A_1.IsGenericType && A_1.GetGenericTypeDefinition() == typeof(IEnumerable<>);
			}

			// Token: 0x040006F1 RID: 1777
			public static readonly 럸.럼 랾 = new 럸.럼();

			// Token: 0x040006F2 RID: 1778
			public static Func<FieldInfo, bool> 랾;

			// Token: 0x040006F3 RID: 1779
			public static Func<FieldInfo, string> 랾;

			// Token: 0x040006F4 RID: 1780
			public static Func<PropertyInfo, bool> 랾;

			// Token: 0x040006F5 RID: 1781
			public static Func<PropertyInfo, string> 랾;

			// Token: 0x040006F6 RID: 1782
			public static Func<MethodInfo, bool> 랾;

			// Token: 0x040006F7 RID: 1783
			public static Func<IGrouping<string, MethodInfo>, MethodInfo> 랾;

			// Token: 0x040006F8 RID: 1784
			public static Func<MethodInfo, string> 랾;

			// Token: 0x040006F9 RID: 1785
			public static Func<FieldInfo, bool> 럎;

			// Token: 0x040006FA RID: 1786
			public static Func<FieldInfo, string> 럎;

			// Token: 0x040006FB RID: 1787
			public static Func<PropertyInfo, bool> 럎;

			// Token: 0x040006FC RID: 1788
			public static Func<PropertyInfo, string> 럎;

			// Token: 0x040006FD RID: 1789
			public static Func<ParameterInfo, string> 랾;

			// Token: 0x040006FE RID: 1790
			public static Action<PropertyInfo> 랾;

			// Token: 0x040006FF RID: 1791
			public static Func<ParameterInfo, string> 럎;

			// Token: 0x04000700 RID: 1792
			public static Func<ParameterInfo, string> 람;

			// Token: 0x04000701 RID: 1793
			public static 럸.럎<string> 랾;

			// Token: 0x04000702 RID: 1794
			public static 럸.럎<int> 랾;

			// Token: 0x04000703 RID: 1795
			public static Func<Type, bool> 랾;
		}

		// Token: 0x0200012A RID: 298
		[CompilerGenerated]
		[Serializable]
		private sealed class 랋<랾> where 랾 : MemberInfo
		{
			// Token: 0x060009A7 RID: 2471 RVA: 0x00041760 File Offset: 0x0003F960
			internal bool 랾(랾 A_1)
			{
				return 럸.럒(A_1.Name);
			}

			// Token: 0x04000704 RID: 1796
			public static readonly 럸.랋<랾> 랾 = new 럸.랋<랾>();

			// Token: 0x04000705 RID: 1797
			public static Func<랾, bool> 랾;
		}

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		private sealed class 랉
		{
			// Token: 0x060009A9 RID: 2473 RVA: 0x000B3E24 File Offset: 0x000B2024
			internal void 랾(FieldInfo A_1)
			{
				럸.럐 럐 = new 럸.럐();
				럐.랾 = this;
				럐.랾 = A_1;
				럸.랾(럐.랾, new Func<object>(럐.랾), (럐.랾.IsLiteral || 럐.랾.IsInitOnly) ? null : new Action<object>(럐.랾), 0);
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x000B3E88 File Offset: 0x000B2088
			internal void 랾(PropertyInfo A_1)
			{
				럸.랓 랓 = new 럸.랓();
				랓.랾 = this;
				랓.랾 = A_1;
				MethodInfo setMethod = 랓.랾.GetSetMethod(true);
				럸.랾(랓.랾, new Func<object>(랓.랾), (setMethod != null) ? new Action<object>(랓.랾) : null, 0);
			}

			// Token: 0x04000706 RID: 1798
			public object 랾;
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		private sealed class 럐
		{
			// Token: 0x060009AC RID: 2476 RVA: 0x00041772 File Offset: 0x0003F972
			internal object 랾()
			{
				return this.랾.GetValue(this.랾.랾);
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x0004178A File Offset: 0x0003F98A
			internal void 랾(object A_1)
			{
				this.랾.SetValue(this.랾.랾, A_1);
			}

			// Token: 0x04000707 RID: 1799
			public FieldInfo 랾;

			// Token: 0x04000708 RID: 1800
			public 럸.랉 랾;
		}

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		private sealed class 랓
		{
			// Token: 0x060009AF RID: 2479 RVA: 0x000417A3 File Offset: 0x0003F9A3
			internal object 랾()
			{
				return this.랾.GetValue(this.랾.랾);
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x000417BB File Offset: 0x0003F9BB
			internal void 랾(object A_1)
			{
				this.랾.SetValue(this.랾.랾, A_1);
			}

			// Token: 0x04000709 RID: 1801
			public PropertyInfo 랾;

			// Token: 0x0400070A RID: 1802
			public 럸.랉 랾;
		}

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		private sealed class 럯
		{
			// Token: 0x060009B2 RID: 2482 RVA: 0x000417D4 File Offset: 0x0003F9D4
			internal object 랾()
			{
				return this.랾.GetValue(null);
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x000417E2 File Offset: 0x0003F9E2
			internal void 랾(object A_1)
			{
				this.랾.SetValue(null, A_1);
			}

			// Token: 0x0400070B RID: 1803
			public PropertyInfo 랾;
		}

		// Token: 0x0200012F RID: 303
		[CompilerGenerated]
		private sealed class 럭
		{
			// Token: 0x0400070C RID: 1804
			public object 랾;
		}

		// Token: 0x02000130 RID: 304
		[CompilerGenerated]
		private sealed class 랱
		{
			// Token: 0x060009B6 RID: 2486 RVA: 0x000417F1 File Offset: 0x0003F9F1
			internal object 랾()
			{
				return this.랾.GetValue(this.랾.랾);
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x00041809 File Offset: 0x0003FA09
			internal void 랾(object A_1)
			{
				this.랾.SetValue(this.랾.랾, A_1);
			}

			// Token: 0x0400070D RID: 1805
			public FieldInfo 랾;

			// Token: 0x0400070E RID: 1806
			public 럸.럭 랾;
		}

		// Token: 0x02000131 RID: 305
		[CompilerGenerated]
		private sealed class 럙
		{
			// Token: 0x060009B9 RID: 2489 RVA: 0x00041822 File Offset: 0x0003FA22
			internal object 랾()
			{
				return this.랾.GetValue(this.랾.랾);
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x0004183A File Offset: 0x0003FA3A
			internal void 랾(object A_1)
			{
				this.랾.SetValue(this.랾.랾, A_1);
			}

			// Token: 0x0400070F RID: 1807
			public PropertyInfo 랾;

			// Token: 0x04000710 RID: 1808
			public 럸.럭 랾;
		}
	}
}
