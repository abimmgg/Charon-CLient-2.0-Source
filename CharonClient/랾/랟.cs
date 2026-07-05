using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;

namespace 랾
{
	// Token: 0x0200006E RID: 110
	public static class 랟
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00080694 File Offset: 0x0007E894
		public static void 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				럽.럎("Packet ID cannot be empty.", false);
				return;
			}
			if (랟.랾.Add(A_0))
			{
				럽.랾("Now ignoring packet: " + A_0, false);
				return;
			}
			럽.럎("Packet already ignored: " + A_0, false);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000806E8 File Offset: 0x0007E8E8
		public static void 럎(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				럽.럎("Packet ID cannot be empty.", false);
				return;
			}
			if (랟.랾.Remove(A_0))
			{
				럽.랾("No longer ignoring packet: " + A_0, false);
				return;
			}
			럽.럎("Packet was not being ignored: " + A_0, false);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0003E7B4 File Offset: 0x0003C9B4
		public static bool 람(string A_0)
		{
			return !string.IsNullOrWhiteSpace(A_0) && 랟.랾.Contains(A_0);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0003E7CB File Offset: 0x0003C9CB
		public static bool 럒(string A_0)
		{
			return !string.IsNullOrWhiteSpace(A_0) && 랟.럎.Contains(A_0);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0003E7E2 File Offset: 0x0003C9E2
		public static void 랾()
		{
			랟.랾.Clear();
			럽.랾("Cleared all ignored packets.", false);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0003E7F9 File Offset: 0x0003C9F9
		public static List<string> 럎()
		{
			return 랟.랾.OrderBy(new Func<string, string>(랟.럎.랾.랾)).ToList<string>();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0008073C File Offset: 0x0007E93C
		public static void 랾(BSONObject A_0, string A_1)
		{
			if (A_0 == null)
			{
				return;
			}
			string text = 럘.랾(A_0);
			if (!랟.랋(text))
			{
				return;
			}
			럓.랾(A_1);
			int value = (A_0.mMap != null) ? (A_0.mMap.Count - 1) : 0;
			int num = 럘.럎(A_0);
			string str = 랟.랾(A_0);
			랟.랾(text, A_1, num);
			string value2 = DateTime.Now.ToString("HH:mm:ss.fff");
			object obj;
			if (num <= 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 4);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral("] ");
				defaultInterpolatedStringHandler.AppendFormatted(A_1);
				defaultInterpolatedStringHandler.AppendLiteral(" [");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("] | ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral(" fields");
				obj = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(25, 5);
				defaultInterpolatedStringHandler2.AppendLiteral("[");
				defaultInterpolatedStringHandler2.AppendFormatted(value2);
				defaultInterpolatedStringHandler2.AppendLiteral("] ");
				defaultInterpolatedStringHandler2.AppendFormatted(A_1);
				defaultInterpolatedStringHandler2.AppendLiteral(" [");
				defaultInterpolatedStringHandler2.AppendFormatted(text);
				defaultInterpolatedStringHandler2.AppendLiteral("] | ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler2.AppendLiteral(" fields | ");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler2.AppendLiteral(" bytes");
				obj = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			object obj2 = obj;
			Console.WriteLine(obj2);
			Console.WriteLine("  Fields: " + str);
			럽.럎(obj2);
			럽.럎("  " + str);
			if (string.Equals(A_1, "Server", StringComparison.OrdinalIgnoreCase))
			{
				럽.랾(A_0, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
				return;
			}
			럽.럎(A_0, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000808F8 File Offset: 0x0007EAF8
		[return: TupleElementNames(new string[]
		{
			"count",
			"totalBytes",
			"direction",
			"lastSeen"
		})]
		public static Dictionary<string, ValueTuple<int, int, string, DateTime>> 람()
		{
			Dictionary<string, ValueTuple<int, int, string, DateTime>> dictionary = new Dictionary<string, ValueTuple<int, int, string, DateTime>>(StringComparer.OrdinalIgnoreCase);
			foreach (KeyValuePair<string, 랟.랾> keyValuePair in 랟.랾)
			{
				dictionary[keyValuePair.Key] = new ValueTuple<int, int, string, DateTime>(keyValuePair.Value.랾, keyValuePair.Value.럎, keyValuePair.Value.랾, keyValuePair.Value.럎);
			}
			return dictionary;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00080994 File Offset: 0x0007EB94
		public static string 럼(string A_0)
		{
			랟.랾 랾;
			if (!랟.랾.TryGetValue(A_0, out 랾))
			{
				return "Never seen";
			}
			double num = Math.Max(1.0, (DateTime.Now - 랾.랾).TotalSeconds);
			double value = (double)랾.랾 / num;
			double value2 = (랾.랾 > 0) ? ((double)랾.럎 / (double)랾.랾) : 0.0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 5);
			defaultInterpolatedStringHandler.AppendFormatted<int>(랾.랾);
			defaultInterpolatedStringHandler.AppendLiteral(" total | ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("/sec | ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(랾.럎);
			defaultInterpolatedStringHandler.AppendLiteral(" bytes | ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value2, "F1");
			defaultInterpolatedStringHandler.AppendLiteral(" avg | Last: ");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(랾.럎, "HH:mm:ss");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0003E829 File Offset: 0x0003CA29
		public static void 럒()
		{
			랟.랾.Clear();
			럽.랾("Packet stats cleared.", false);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00080A94 File Offset: 0x0007EC94
		public static void 랾(BSONObject A_0, string A_1, string A_2)
		{
			if (A_0 == null || A_1 != "KErr")
			{
				return;
			}
			int num;
			if (!럘.랾(A_0, "ER", out num))
			{
				럽.람("Kick error packet received from " + A_2 + ", but ER was missing.", false);
				return;
			}
			string text;
			string value = 랟.랾.TryGetValue(num, out text) ? text : "Unknown";
			럴.AssertRuntimeKeyValid("HandleKickErrorPacket");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Kick Error Code: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" - ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			럽.람(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0003E840 File Offset: 0x0003CA40
		private static bool 랋(string A_0)
		{
			return !string.IsNullOrWhiteSpace(A_0) && !랟.람(A_0) && !랟.럒(A_0) && (!럧.랋 || !(A_0 == "GPd"));
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00080B40 File Offset: 0x0007ED40
		private static void 랾(string A_0, string A_1, int A_2)
		{
			랟.랾 랾;
			if (!랟.랾.TryGetValue(A_0, out 랾))
			{
				if (랟.랾.Count >= 500)
				{
					랟.럼();
				}
				랾 = new 랟.랾
				{
					랾 = DateTime.Now
				};
				랟.랾[A_0] = 랾;
			}
			랾.랾++;
			랾.럎 += Math.Max(0, A_2);
			랾.럎 = DateTime.Now;
			랾.랾 = A_1;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00080BC4 File Offset: 0x0007EDC4
		private static void 럼()
		{
			foreach (string key in 랟.랾.OrderBy(new Func<KeyValuePair<string, 랟.랾>, DateTime>(랟.럎.랾.랾)).Take(랟.랾.Count - 300).Select(new Func<KeyValuePair<string, 랟.랾>, string>(랟.럎.랾.럎)).ToList<string>())
			{
				랟.랾.Remove(key);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00080C80 File Offset: 0x0007EE80
		private static string 랾(BSONObject A_0)
		{
			if (((A_0 != null) ? A_0.mMap : null) == null || A_0.mMap.Count == 0)
			{
				return "(empty)";
			}
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, BSONValue> keyValuePair in A_0.mMap)
			{
				if (!(keyValuePair.Key == "ID"))
				{
					try
					{
						list.Add(keyValuePair.Key + "=" + 랟.랾(keyValuePair.Value, 0));
					}
					catch (Exception ex)
					{
						list.Add(keyValuePair.Key + "=<error:" + ex.GetType().Name + ">");
					}
				}
			}
			if (list.Count <= 0)
			{
				return "(empty)";
			}
			return string.Join(", ", list);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00080D5C File Offset: 0x0007EF5C
		private static string 랾(BSONValue A_0, int A_1)
		{
			if (A_0 == null)
			{
				return "h";
			}
			switch (A_0.valueType)
			{
			case 0:
				return A_0.doubleValue.ToString("F2", CultureInfo.InvariantCulture);
			case 1:
				return "\"" + (A_0.stringValue ?? string.Empty) + "\"";
			case 2:
				return 랟.럎(A_0, A_1 + 1, int.MaxValue);
			case 3:
				return 랟.럎(A_0, A_1 + 1);
			case 4:
				return A_0.boolValue.ToString();
			case 7:
				return A_0.int32Value.ToString();
			case 8:
				return A_0.int64Value.ToString();
			case 9:
				return 랟.랾(A_0, A_1 + 1, int.MaxValue);
			}
			return A_0.valueType.ToString();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00080E58 File Offset: 0x0007F058
		private static string 럎(BSONValue A_0, int A_1)
		{
			Il2CppStructArray<byte> binaryValue = A_0.binaryValue;
			int num = (binaryValue != null) ? binaryValue.Length : 0;
			if (num == 0)
			{
				return "[0 bytes]";
			}
			string result;
			try
			{
				BSONObject bsonobject = SimpleBSON.Load(A_0.binaryValue);
				if (((bsonobject != null) ? bsonobject.mMap : null) == null || bsonobject.mMap.Count == 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral(" bytes]");
					result = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					string text = 럘.랾(bsonobject);
					string value = 랟.랾(bsonobject, A_1 + 1, int.MaxValue);
					if (string.IsNullOrWhiteSpace(text) || string.Equals(text, "UNKNOWN", StringComparison.OrdinalIgnoreCase))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(9, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("[");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(num);
						defaultInterpolatedStringHandler2.AppendLiteral(" bytes] ");
						defaultInterpolatedStringHandler2.AppendFormatted(value);
						result = defaultInterpolatedStringHandler2.ToStringAndClear();
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(10, 3);
						defaultInterpolatedStringHandler3.AppendLiteral("[");
						defaultInterpolatedStringHandler3.AppendFormatted<int>(num);
						defaultInterpolatedStringHandler3.AppendLiteral(" bytes ");
						defaultInterpolatedStringHandler3.AppendFormatted(text);
						defaultInterpolatedStringHandler3.AppendLiteral("] ");
						defaultInterpolatedStringHandler3.AppendFormatted(value);
						result = defaultInterpolatedStringHandler3.ToStringAndClear();
					}
				}
			}
			catch
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler4.AppendLiteral("[");
				defaultInterpolatedStringHandler4.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler4.AppendLiteral(" bytes]");
				result = defaultInterpolatedStringHandler4.ToStringAndClear();
			}
			return result;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00080FF0 File Offset: 0x0007F1F0
		private static string 랾(BSONValue A_0, int A_1, int A_2 = 2147483647)
		{
			string result;
			try
			{
				result = 랟.랾(A_0.TryCast<BSONObject>(), A_1, A_2);
			}
			catch (Exception ex)
			{
				result = "{object-error:" + ex.GetType().Name + "}";
			}
			return result;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0008103C File Offset: 0x0007F23C
		private static string 랾(BSONObject A_0, int A_1, int A_2 = 2147483647)
		{
			if (((A_0 != null) ? A_0.mMap : null) == null || A_0.mMap.Count == 0)
			{
				return "{}";
			}
			List<string> list = new List<string>();
			int num = 0;
			foreach (KeyValuePair<string, BSONValue> keyValuePair in A_0.mMap)
			{
				if (num >= A_2)
				{
					List<string> list2 = list;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
					defaultInterpolatedStringHandler.AppendLiteral("...+");
					defaultInterpolatedStringHandler.AppendFormatted<int>(A_0.mMap.Count - A_2);
					list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					break;
				}
				list.Add(keyValuePair.Key + "=" + 랟.랾(keyValuePair.Value, A_1));
				num++;
			}
			return "{" + string.Join(", ", list) + "}";
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0008110C File Offset: 0x0007F30C
		private static string 럎(BSONValue A_0, int A_1, int A_2 = 2147483647)
		{
			string result;
			try
			{
				string text;
				string text2;
				string text3;
				string text4;
				if (A_0 == null)
				{
					result = "[]";
				}
				else if (랟.랾(A_0, A_2, out text))
				{
					result = text;
				}
				else if (랟.럎(A_0, A_2, out text2))
				{
					result = text2;
				}
				else if (랟.람(A_0, A_2, out text3))
				{
					result = text3;
				}
				else if (랟.럒(A_0, A_2, out text4))
				{
					result = text4;
				}
				else
				{
					List<string> list = new List<string>();
					for (int i = 0; i < A_2; i++)
					{
						try
						{
							BSONValue bsonvalue = A_0[i];
							if (bsonvalue == null)
							{
								break;
							}
							list.Add(랟.랾(bsonvalue, A_1));
						}
						catch
						{
							break;
						}
					}
					if (list.Count > 0)
					{
						result = "[" + string.Join(", ", list) + "]";
					}
					else
					{
						result = "[array]";
					}
				}
			}
			catch (Exception ex)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[array-error:");
				defaultInterpolatedStringHandler.AppendFormatted(ex.GetType().Name);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				result = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return result;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00081268 File Offset: 0x0007F468
		private static bool 랾(BSONValue A_0, int A_1, out string A_2)
		{
			A_2 = null;
			bool result;
			try
			{
				List<int> int32ListValue = A_0.int32ListValue;
				if (int32ListValue == null || int32ListValue.Count == 0)
				{
					result = false;
				}
				else if (int32ListValue.Count == 1)
				{
					A_2 = int32ListValue[0].ToString();
					result = true;
				}
				else
				{
					List<string> list = new List<string>();
					int num = Math.Min(int32ListValue.Count, A_1);
					for (int i = 0; i < num; i++)
					{
						list.Add(int32ListValue[i].ToString());
					}
					if (int32ListValue.Count > A_1)
					{
						List<string> list2 = list;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
						defaultInterpolatedStringHandler.AppendLiteral("...+");
						defaultInterpolatedStringHandler.AppendFormatted<int>(int32ListValue.Count - A_1);
						list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					A_2 = "[" + string.Join(", ", list) + "]";
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00081360 File Offset: 0x0007F560
		private static bool 럎(BSONValue A_0, int A_1, out string A_2)
		{
			A_2 = null;
			bool result;
			try
			{
				List<long> int64ListValue = A_0.int64ListValue;
				if (int64ListValue == null || int64ListValue.Count == 0)
				{
					result = false;
				}
				else
				{
					List<string> list = new List<string>();
					int num = Math.Min(int64ListValue.Count, A_1);
					for (int i = 0; i < num; i++)
					{
						list.Add(int64ListValue[i].ToString());
					}
					if (int64ListValue.Count > A_1)
					{
						List<string> list2 = list;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
						defaultInterpolatedStringHandler.AppendLiteral("...+");
						defaultInterpolatedStringHandler.AppendFormatted<int>(int64ListValue.Count - A_1);
						list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					A_2 = "[" + string.Join(", ", list) + "]";
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00081434 File Offset: 0x0007F634
		private static bool 람(BSONValue A_0, int A_1, out string A_2)
		{
			A_2 = null;
			bool result;
			try
			{
				List<string> stringListValue = A_0.stringListValue;
				if (stringListValue == null || stringListValue.Count == 0)
				{
					result = false;
				}
				else
				{
					List<string> list = new List<string>();
					int num = Math.Min(stringListValue.Count, A_1);
					for (int i = 0; i < num; i++)
					{
						list.Add("\"" + (stringListValue[i] ?? string.Empty) + "\"");
					}
					if (stringListValue.Count > A_1)
					{
						List<string> list2 = list;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
						defaultInterpolatedStringHandler.AppendLiteral("...+");
						defaultInterpolatedStringHandler.AppendFormatted<int>(stringListValue.Count - A_1);
						list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					A_2 = "[" + string.Join(", ", list) + "]";
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00081518 File Offset: 0x0007F718
		private static bool 럒(BSONValue A_0, int A_1, out string A_2)
		{
			A_2 = null;
			bool result;
			try
			{
				List<Vector2i> vector2iListValue = A_0.vector2iListValue;
				if (vector2iListValue == null || vector2iListValue.Count == 0)
				{
					result = false;
				}
				else
				{
					List<string> list = new List<string>();
					int num = Math.Min(vector2iListValue.Count, A_1);
					for (int i = 0; i < num; i++)
					{
						Vector2i vector2i = vector2iListValue[i];
						List<string> list2 = list;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
						defaultInterpolatedStringHandler.AppendLiteral("(");
						defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.x);
						defaultInterpolatedStringHandler.AppendLiteral(", ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i.y);
						defaultInterpolatedStringHandler.AppendLiteral(")");
						list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					if (vector2iListValue.Count > A_1)
					{
						List<string> list3 = list;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(4, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("...+");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(vector2iListValue.Count - A_1);
						list3.Add(defaultInterpolatedStringHandler2.ToStringAndClear());
					}
					A_2 = "[" + string.Join(", ", list) + "]";
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0003E875 File Offset: 0x0003CA75
		private static string 랾(string A_0, int A_1)
		{
			if (string.IsNullOrEmpty(A_0) || A_0.Length <= A_1)
			{
				return A_0 ?? string.Empty;
			}
			return A_0.Substring(0, A_1) + "...";
		}

		// Token: 0x040002EE RID: 750
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x040002EF RID: 751
		private static readonly HashSet<string> 럎 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"mP",
			"ST",
			"p",
			"cZva",
			"GFLi",
			"AI",
			"PSicU",
			"FiOffAM",
			"FiOnAM",
			"FiBmS",
			"FiBmH",
			"FiBmME"
		};

		// Token: 0x040002F0 RID: 752
		private static readonly Dictionary<string, 랟.랾> 랾 = new Dictionary<string, 랟.랾>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x040002F1 RID: 753
		private static readonly Dictionary<int, string> 랾 = new Dictionary<int, string>
		{
			{
				1,
				"Map Point Desynced"
			},
			{
				2,
				"Travelling Too Fast"
			},
			{
				3,
				"Invalid Movement (Flying/Floating)"
			},
			{
				7,
				"Possible Packet Spam (Teleport, Aimbot, etc...)"
			}
		};

		// Token: 0x040002F2 RID: 754
		private const int 랾 = 500;

		// Token: 0x040002F3 RID: 755
		private const int 럎 = 300;

		// Token: 0x0200006F RID: 111
		private sealed class 랾
		{
			// Token: 0x040002F4 RID: 756
			public int 랾;

			// Token: 0x040002F5 RID: 757
			public int 럎;

			// Token: 0x040002F6 RID: 758
			public DateTime 랾;

			// Token: 0x040002F7 RID: 759
			public DateTime 럎;

			// Token: 0x040002F8 RID: 760
			public string 랾;
		}

		// Token: 0x02000070 RID: 112
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x06000410 RID: 1040 RVA: 0x0003CAD1 File Offset: 0x0003ACD1
			internal string 랾(string A_1)
			{
				return A_1;
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0003E8B1 File Offset: 0x0003CAB1
			internal DateTime 랾(KeyValuePair<string, 랟.랾> A_1)
			{
				return A_1.Value.럎;
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x0003E8BF File Offset: 0x0003CABF
			internal string 럎(KeyValuePair<string, 랟.랾> A_1)
			{
				return A_1.Key;
			}

			// Token: 0x040002F9 RID: 761
			public static readonly 랟.럎 랾 = new 랟.럎();

			// Token: 0x040002FA RID: 762
			public static Func<string, string> 랾;

			// Token: 0x040002FB RID: 763
			public static Func<KeyValuePair<string, 랟.랾>, DateTime> 랾;

			// Token: 0x040002FC RID: 764
			public static Func<KeyValuePair<string, 랟.랾>, string> 랾;
		}
	}
}
