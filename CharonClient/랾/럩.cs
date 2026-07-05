using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CharonClient.Configuration;

namespace 랾
{
	// Token: 0x02000048 RID: 72
	internal static class 럩
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x0007B750 File Offset: 0x00079950
		public static void 랾()
		{
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				string text;
				if (networkPlayer != null && 럩.랾(networkPlayer.clientId, out text))
				{
					string clientId = networkPlayer.clientId;
					string text2 = text;
					World world = 럓.랾;
					럩.랾(clientId, text2, (world != null) ? world.worldName : null, "world");
				}
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0007B7AC File Offset: 0x000799AC
		public static void 랾(string A_0, string A_1, string A_2, string A_3)
		{
			if (!ConfigFile.reportModAndAdminSightingsToggle)
			{
				return;
			}
			string text = ((A_0 != null) ? A_0.Trim() : null) ?? string.Empty;
			string text2;
			if (!럩.랾(text, out text2))
			{
				return;
			}
			PlayerData playerData = 럓.랾;
			if (string.Equals((playerData != null) ? playerData.playerId : null, text, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
			if (!럝.랾())
			{
				럩.랋();
				return;
			}
			World world = 럓.랾;
			string text3 = 럩.랾(A_2, (world != null) ? world.worldName : null, "UNKNOWN_WORLD");
			string text4 = 럩.랾(A_1, "Unknown", "Unknown");
			string text5 = 럩.랾(A_3, "unknown", "unknown").ToLowerInvariant();
			string text6 = 럩.럎(text3, text4, text5);
			long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			object obj = 럩.랾;
			lock (obj)
			{
				bool flag2 = 럩.랾.Contains(text);
				bool flag3 = false;
				ValueTuple<string, long> valueTuple;
				if (럩.랾.TryGetValue(text, out valueTuple))
				{
					flag3 = (num - valueTuple.Item2 < (long)럩.랉() * 1000L);
				}
				if (flag2 || flag3)
				{
					return;
				}
				럩.랾.Add(text);
				럩.랾[text] = new ValueTuple<string, long>(text6, num);
			}
			string text7 = 럩.랓();
			if (string.IsNullOrWhiteSpace(text7))
			{
				obj = 럩.랾;
				lock (obj)
				{
					럩.랾.Remove(text);
				}
				return;
			}
			string text8 = 럩.럎(text7, text);
			Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
			dictionary["id"] = text8;
			dictionary["tracked_player_id"] = text;
			dictionary["tracked_player_name"] = text4;
			dictionary["world_name"] = text3;
			dictionary["source"] = text5;
			dictionary["reporter_name"] = 럩.럐();
			dictionary["reporter_version"] = "2.0";
			dictionary["last_seen_unix_ms"] = num;
			dictionary["last_seen_utc"] = DateTime.UtcNow.ToString("O");
			Dictionary<string, object> dictionary2 = dictionary;
			럩.랾(text8, dictionary2, text, text4, text3, text6, num);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0007B9FC File Offset: 0x00079BFC
		public static Task 럎()
		{
			럩.럒 럒;
			럒.랾 = AsyncTaskMethodBuilder.Create();
			럒.랾 = -1;
			럒.랾.Start<럩.럒>(ref 럒);
			return 럒.랾.Task;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0007BA38 File Offset: 0x00079C38
		public static void 람()
		{
			object obj = 럩.랾;
			lock (obj)
			{
				럩.럎 = false;
				럩.람 = false;
				럩.랾.Clear();
				럩.랾.Clear();
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0007BA94 File Offset: 0x00079C94
		public static void 럒()
		{
			List<럩.람> list = new List<럩.람>();
			object obj = 럩.랾;
			lock (obj)
			{
				while (럩.랾.Count > 0)
				{
					list.Add(럩.랾.Dequeue());
				}
			}
			foreach (럩.람 람 in list)
			{
				럩.럎 럎 = 람.랾();
				if (럎 != 럩.럎.랾)
				{
					if (럎 == 럩.럎.럎)
					{
						랃.랾(람.럎(), 람.람(), 4f);
					}
				}
				else
				{
					럽.람(람.람(), false);
				}
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0007BB64 File Offset: 0x00079D64
		private static Task 랾(string A_0, Dictionary<string, object> A_1, string A_2, string A_3, string A_4, string A_5, long A_6)
		{
			럩.럼 럼;
			럼.랾 = AsyncTaskMethodBuilder.Create();
			럼.랾 = A_1;
			럼.람 = A_2;
			럼.랾 = A_3;
			럼.럎 = A_4;
			럼.럒 = A_5;
			럼.랾 = A_6;
			럼.랾 = -1;
			럼.랾.Start<럩.럼>(ref 럼);
			return 럼.랾.Task;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0003DF55 File Offset: 0x0003C155
		private static bool 럼()
		{
			bool flag = 럝.랾();
			if (flag)
			{
				럩.랾 = false;
			}
			return flag;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0003DF65 File Offset: 0x0003C165
		private static void 랋()
		{
			if (럩.랾)
			{
				return;
			}
			럩.랾 = true;
			랃.람("Developer Sightings", "Shared service session unavailable for developer sighting reports.", 4f);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0007BBD4 File Offset: 0x00079DD4
		private static int 랉()
		{
			int num = ConfigFile.developerSightingCooldownSeconds;
			if (num <= 0)
			{
				num = 120;
			}
			return Math.Clamp(num, 30, 3600);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0003DF89 File Offset: 0x0003C189
		private static bool 랾(string A_0, out string A_1)
		{
			A_1 = null;
			return !string.IsNullOrWhiteSpace(A_0) && 럧.랾.TryGetValue(A_0.Trim(), out A_1);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0007BBFC File Offset: 0x00079DFC
		private static void 랾(Dictionary<string, 럩.랾> A_0)
		{
			List<string> list = new List<string>();
			object obj = 럩.랾;
			lock (obj)
			{
				if (!럩.람)
				{
					럩.랾.Clear();
					foreach (KeyValuePair<string, 럩.랾> keyValuePair in A_0)
					{
						string text;
						럩.랾 랾;
						keyValuePair.Deconstruct(out text, out 랾);
						string key = text;
						럩.랾 value = 랾;
						럩.랾[key] = value;
					}
					럩.람 = true;
					return;
				}
				foreach (KeyValuePair<string, 럩.랾> keyValuePair in A_0)
				{
					string text;
					럩.랾 랾;
					keyValuePair.Deconstruct(out text, out 랾);
					string text2 = text;
					럩.랾 value2 = 랾;
					럩.랾 랾2;
					if (!럩.랾.TryGetValue(text2, out 랾2) || value2.럒() > 랾2.럒())
					{
						string value3 = string.IsNullOrWhiteSpace(value2.랾()) ? text2 : value2.랾();
						List<string> list2 = list;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
						defaultInterpolatedStringHandler.AppendFormatted(value3);
						defaultInterpolatedStringHandler.AppendLiteral(" seen in ");
						defaultInterpolatedStringHandler.AppendFormatted(value2.럎());
						defaultInterpolatedStringHandler.AppendLiteral(" (");
						defaultInterpolatedStringHandler.AppendFormatted(value2.람());
						defaultInterpolatedStringHandler.AppendLiteral(")");
						list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
						럩.랾[text2] = value2;
					}
				}
			}
			foreach (string str in list)
			{
				럩.랾("New Mod/Admin Sighting: " + str);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0007BE28 File Offset: 0x0007A028
		private static void 랾(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			object obj = 럩.랾;
			lock (obj)
			{
				럩.랾.Enqueue(new 럩.람(럩.럎.랾, string.Empty, A_0));
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0007BE80 File Offset: 0x0007A080
		private static void 랾(string A_0, string A_1)
		{
			object obj = 럩.랾;
			lock (obj)
			{
				럩.랾.Enqueue(new 럩.람(럩.럎.럎, A_0 ?? string.Empty, A_1 ?? string.Empty));
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0003DFA9 File Offset: 0x0003C1A9
		private static string 럐()
		{
			return "User_" + 럦.랾(30);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
		private static string 랓()
		{
			string result;
			try
			{
				string text = 럳.랾(럧.럑);
				string text2 = (text != null) ? text.Trim() : null;
				if (!string.IsNullOrWhiteSpace(text2))
				{
					result = text2;
				}
				else
				{
					string text3 = Guid.NewGuid().ToString("N");
					럳.랾(럧.럑, text3);
					result = text3;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0007BF48 File Offset: 0x0007A148
		private static string 럎(string A_0, string A_1)
		{
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				byte[] array = sha.ComputeHash(Encoding.UTF8.GetBytes(A_0 + ":" + A_1));
				StringBuilder stringBuilder = new StringBuilder(35);
				stringBuilder.Append("ds_");
				for (int i = 0; i < 16; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0003DFBC File Offset: 0x0003C1BC
		private static string 랾(string A_0, string A_1, string A_2)
		{
			if (!string.IsNullOrWhiteSpace(A_0))
			{
				return A_0.Trim();
			}
			if (!string.IsNullOrWhiteSpace(A_1))
			{
				return A_1.Trim();
			}
			return A_2;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0007BFD8 File Offset: 0x0007A1D8
		private static string 럎(string A_0, string A_1, string A_2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0.ToUpperInvariant());
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(A_1.ToUpperInvariant());
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(A_2.ToUpperInvariant());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0007ADD8 File Offset: 0x00078FD8
		private static string 랾(JsonElement A_0, string A_1)
		{
			JsonElement jsonElement;
			if (!A_0.TryGetProperty(A_1, out jsonElement))
			{
				return string.Empty;
			}
			string result;
			switch (jsonElement.ValueKind)
			{
			case JsonValueKind.String:
				result = (jsonElement.GetString() ?? string.Empty);
				break;
			case JsonValueKind.Number:
				result = jsonElement.ToString();
				break;
			case JsonValueKind.True:
				result = bool.TrueString;
				break;
			case JsonValueKind.False:
				result = bool.FalseString;
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0007AE54 File Offset: 0x00079054
		private static long 럎(JsonElement A_0, string A_1)
		{
			JsonElement jsonElement;
			if (!A_0.TryGetProperty(A_1, out jsonElement))
			{
				return 0L;
			}
			long result;
			if (jsonElement.ValueKind == JsonValueKind.Number && jsonElement.TryGetInt64(out result))
			{
				return result;
			}
			long result2;
			if (jsonElement.ValueKind == JsonValueKind.String && long.TryParse(jsonElement.GetString(), out result2))
			{
				return result2;
			}
			return 0L;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0003DFDD File Offset: 0x0003C1DD
		public static Task<string> 럯()
		{
			return 럝.랾("sightings/fetch", new Dictionary<string, object>());
		}

		// Token: 0x04000268 RID: 616
		private const int 랾 = 120;

		// Token: 0x04000269 RID: 617
		private static readonly object 랾 = new object();

		// Token: 0x0400026A RID: 618
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400026B RID: 619
		[TupleElementNames(new string[]
		{
			"dedupeKey",
			"atUnixMs"
		})]
		private static readonly Dictionary<string, ValueTuple<string, long>> 랾 = new Dictionary<string, ValueTuple<string, long>>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400026C RID: 620
		private static readonly Dictionary<string, 럩.랾> 랾 = new Dictionary<string, 럩.랾>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400026D RID: 621
		private static readonly Queue<럩.람> 랾 = new Queue<럩.람>();

		// Token: 0x0400026E RID: 622
		private static bool 랾;

		// Token: 0x0400026F RID: 623
		private static bool 럎;

		// Token: 0x04000270 RID: 624
		private static bool 람;

		// Token: 0x02000049 RID: 73
		private readonly struct 랾 : IEquatable<럩.랾>
		{
			// Token: 0x060002E7 RID: 743 RVA: 0x0003DFEE File Offset: 0x0003C1EE
			public 랾(string A_1, string A_2, string A_3, long A_4)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.람 = A_3;
				this.랾 = A_4;
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0003E00D File Offset: 0x0003C20D
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0003E015 File Offset: 0x0003C215
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0003E01E File Offset: 0x0003C21E
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0003E026 File Offset: 0x0003C226
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0003E02F File Offset: 0x0003C22F
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0003E037 File Offset: 0x0003C237
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0003E040 File Offset: 0x0003C240
			[CompilerGenerated]
			public long 럒()
			{
				return this.랾;
			}

			// Token: 0x060002EF RID: 751 RVA: 0x0003E048 File Offset: 0x0003C248
			[CompilerGenerated]
			public void 랾(long A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x0007C084 File Offset: 0x0007A284
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("RemoteSightingSnapshot");
				stringBuilder.Append(" { ");
				if (this.랾(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x0007C0D0 File Offset: 0x0007A2D0
			[CompilerGenerated]
			private bool 랾(StringBuilder A_1)
			{
				A_1.Append("TrackedPlayerName = ");
				A_1.Append(this.랾());
				A_1.Append(", WorldName = ");
				A_1.Append(this.럎());
				A_1.Append(", Source = ");
				A_1.Append(this.람());
				A_1.Append(", LastSeenUnixMs = ");
				A_1.Append(this.럒().ToString());
				return true;
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x0003E051 File Offset: 0x0003C251
			[CompilerGenerated]
			public static bool operator !=(럩.랾 A_0, 럩.랾 A_1)
			{
				return !(A_0 == A_1);
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0003E05D File Offset: 0x0003C25D
			[CompilerGenerated]
			public static bool operator ==(럩.랾 A_0, 럩.랾 A_1)
			{
				return A_0.Equals(A_1);
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x0007C150 File Offset: 0x0007A350
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<string>.Default.GetHashCode(this.랾) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.럎)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.람)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(this.랾);
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x0003E067 File Offset: 0x0003C267
			[CompilerGenerated]
			public override bool Equals(object A_1)
			{
				return A_1 is 럩.랾 && this.Equals((럩.랾)A_1);
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x0007C1B4 File Offset: 0x0007A3B4
			[CompilerGenerated]
			public bool Equals(럩.랾 A_1)
			{
				return EqualityComparer<string>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.럎, A_1.럎) && EqualityComparer<string>.Default.Equals(this.람, A_1.람) && EqualityComparer<long>.Default.Equals(this.랾, A_1.랾);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0003E07F File Offset: 0x0003C27F
			[CompilerGenerated]
			public void 랾(out string A_1, out string A_2, out string A_3, out long A_4)
			{
				A_1 = this.랾();
				A_2 = this.럎();
				A_3 = this.람();
				A_4 = this.럒();
			}

			// Token: 0x04000271 RID: 625
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000272 RID: 626
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x04000273 RID: 627
			[CompilerGenerated]
			private readonly string 람;

			// Token: 0x04000274 RID: 628
			[CompilerGenerated]
			private readonly long 랾;
		}

		// Token: 0x0200004A RID: 74
		private enum 럎
		{
			// Token: 0x04000276 RID: 630
			랾,
			// Token: 0x04000277 RID: 631
			럎
		}

		// Token: 0x0200004B RID: 75
		private readonly struct 람 : IEquatable<럩.람>
		{
			// Token: 0x060002F8 RID: 760 RVA: 0x0003E0A2 File Offset: 0x0003C2A2
			public 람(럩.럎 A_1, string A_2, string A_3)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.럎 = A_3;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0003E0B9 File Offset: 0x0003C2B9
			[CompilerGenerated]
			public 럩.럎 랾()
			{
				return this.랾;
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0003E0C1 File Offset: 0x0003C2C1
			[CompilerGenerated]
			public void 랾(럩.럎 A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0003E0CA File Offset: 0x0003C2CA
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0003E0D2 File Offset: 0x0003C2D2
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0003E0DB File Offset: 0x0003C2DB
			[CompilerGenerated]
			public string 람()
			{
				return this.럎;
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0003E0E3 File Offset: 0x0003C2E3
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0007C224 File Offset: 0x0007A424
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("PendingUiNotification");
				stringBuilder.Append(" { ");
				if (this.랾(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0007C270 File Offset: 0x0007A470
			[CompilerGenerated]
			private bool 랾(StringBuilder A_1)
			{
				A_1.Append("Kind = ");
				A_1.Append(this.랾().ToString());
				A_1.Append(", Title = ");
				A_1.Append(this.럎());
				A_1.Append(", Message = ");
				A_1.Append(this.람());
				return true;
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0003E0EC File Offset: 0x0003C2EC
			[CompilerGenerated]
			public static bool operator !=(럩.람 A_0, 럩.람 A_1)
			{
				return !(A_0 == A_1);
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0003E0F8 File Offset: 0x0003C2F8
			[CompilerGenerated]
			public static bool operator ==(럩.람 A_0, 럩.람 A_1)
			{
				return A_0.Equals(A_1);
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0003E102 File Offset: 0x0003C302
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<럩.럎>.Default.GetHashCode(this.랾) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.랾)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.럎);
			}

			// Token: 0x06000304 RID: 772 RVA: 0x0003E142 File Offset: 0x0003C342
			[CompilerGenerated]
			public override bool Equals(object A_1)
			{
				return A_1 is 럩.람 && this.Equals((럩.람)A_1);
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0007C2D8 File Offset: 0x0007A4D8
			[CompilerGenerated]
			public bool Equals(럩.람 A_1)
			{
				return EqualityComparer<럩.럎>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.럎, A_1.럎);
			}

			// Token: 0x06000306 RID: 774 RVA: 0x0003E15A File Offset: 0x0003C35A
			[CompilerGenerated]
			public void 랾(out 럩.럎 A_1, out string A_2, out string A_3)
			{
				A_1 = this.랾();
				A_2 = this.럎();
				A_3 = this.람();
			}

			// Token: 0x04000278 RID: 632
			[CompilerGenerated]
			private readonly 럩.럎 랾;

			// Token: 0x04000279 RID: 633
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x0400027A RID: 634
			[CompilerGenerated]
			private readonly string 럎;
		}
	}
}
