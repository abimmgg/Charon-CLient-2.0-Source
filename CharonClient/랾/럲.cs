using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using CharonClient.Configuration;

namespace 랾
{
	// Token: 0x02000042 RID: 66
	internal static class 럲
	{
		// Token: 0x06000294 RID: 660 RVA: 0x0007A650 File Offset: 0x00078850
		public static Task 랾(string A_0)
		{
			럲.럼 럼;
			럼.랾 = AsyncTaskMethodBuilder.Create();
			럼.랾 = A_0;
			럼.랾 = -1;
			럼.랾.Start<럲.럼>(ref 럼);
			return 럼.랾.Task;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0007A694 File Offset: 0x00078894
		public static Task 랾()
		{
			럲.럒 럒;
			럒.랾 = AsyncTaskMethodBuilder.Create();
			럒.랾 = -1;
			럒.랾.Start<럲.럒>(ref 럒);
			return 럒.랾.Task;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0007A6D0 File Offset: 0x000788D0
		public static void 럎()
		{
			object obj = 럲.랾;
			lock (obj)
			{
				럲.랾 = false;
				럲.럎 = false;
				럲.랾.Clear();
				럲.랾.Clear();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0007A72C File Offset: 0x0007892C
		public static void 람()
		{
			List<럲.럎> list = new List<럲.럎>();
			object obj = 럲.랾;
			lock (obj)
			{
				while (럲.랾.Count > 0)
				{
					list.Add(럲.랾.Dequeue());
				}
			}
			foreach (럲.럎 럎 in list)
			{
				if (럎.람())
				{
					럽.럒(럎.럎(), true);
				}
				else
				{
					럽.럎(럎.럎(), 럎.랾(), true);
				}
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0003DD4E File Offset: 0x0003BF4E
		private static bool 럒()
		{
			bool flag = 럝.랾();
			if (flag)
			{
				럲.람 = false;
			}
			return flag;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0003DD5E File Offset: 0x0003BF5E
		private static void 럼()
		{
			if (럲.람)
			{
				return;
			}
			럲.람 = true;
			랃.람("Client Relay Chat", "Shared service session unavailable for client relay chat.", 4f);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0007A7F0 File Offset: 0x000789F0
		private static List<럲.랾> 랾(JsonElement A_0)
		{
			List<럲.랾> list = new List<럲.랾>();
			foreach (JsonElement jsonElement in A_0.EnumerateArray())
			{
				string text = 럲.랾(jsonElement, "id");
				string text2 = 럲.랾(jsonElement, "sender_client_id");
				string text3 = 럲.랾(jsonElement, "sender_name");
				string text4 = 럲.럼(럲.랾(jsonElement, "message"));
				long num = 럲.럎(jsonElement, "created_unix_ms");
				if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2) && !string.IsNullOrWhiteSpace(text4) && num > 0L)
				{
					list.Add(new 럲.랾(text, 럲.럎(text3, text2), text4, num));
				}
			}
			return list;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0007A8CC File Offset: 0x00078ACC
		private static void 랾(List<럲.랾> A_0)
		{
			if (A_0.Count == 0)
			{
				return;
			}
			List<럲.랾> list = new List<럲.랾>();
			object obj = 럲.랾;
			lock (obj)
			{
				if (!럲.럎)
				{
					foreach (럲.랾 랾 in A_0)
					{
						럲.랾.Add(랾.랾());
					}
					럲.럎 = true;
					return;
				}
				foreach (럲.랾 item in A_0)
				{
					if (럲.랾.Add(item.랾()))
					{
						list.Add(item);
					}
				}
			}
			foreach (럲.랾 랾2 in list)
			{
				럲.랾(랾2.럎(), 랾2.람());
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0007AA0C File Offset: 0x00078C0C
		private static void 랾(string A_0, string A_1)
		{
			object obj = 럲.랾;
			lock (obj)
			{
				럲.랾.Enqueue(new 럲.럎(A_0, A_1, false));
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0007AA58 File Offset: 0x00078C58
		private static void 럎(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			object obj = 럲.랾;
			lock (obj)
			{
				럲.랾.Enqueue(new 럲.럎(string.Empty, A_0, true));
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0007AAB0 File Offset: 0x00078CB0
		private static void 랋()
		{
			object obj = 럲.랾;
			lock (obj)
			{
				럲.럎 = true;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0007AAF0 File Offset: 0x00078CF0
		private static string 랉()
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
			catch (Exception ex)
			{
				럲.랉("Failed to create client relay ID: " + ex.Message);
				result = null;
			}
			return result;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0007AB70 File Offset: 0x00078D70
		public static string 람(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return string.Empty;
			}
			string text = A_0.Trim();
			StringBuilder stringBuilder = new StringBuilder(text.Length);
			bool flag = false;
			foreach (char c in text)
			{
				if (char.IsLetterOrDigit(c) || c == '_' || c == '-' || c == '.')
				{
					stringBuilder.Append(c);
					flag = false;
				}
				else if (char.IsWhiteSpace(c) && stringBuilder.Length > 0 && !flag)
				{
					stringBuilder.Append(' ');
					flag = true;
				}
				if (stringBuilder.Length >= 32)
				{
					break;
				}
			}
			return stringBuilder.ToString().Trim();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0007AC18 File Offset: 0x00078E18
		private static string 럐()
		{
			string text = 럲.람(ConfigFile.clientRelayChatDisplayName);
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			return "Client";
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0007AC40 File Offset: 0x00078E40
		private static string 럎(string A_0, string A_1)
		{
			string text = 럲.람(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = "Client";
			}
			return text + "_" + 럲.럒(A_1);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0007AC74 File Offset: 0x00078E74
		private static string 럒(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return "UNKNOWN";
			}
			string text = A_0.Trim();
			int num = Math.Min(6, text.Length);
			return text.Substring(text.Length - num, num).ToUpperInvariant();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0007ACB8 File Offset: 0x00078EB8
		private static string 럼(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return string.Empty;
			}
			string text = A_0.Trim();
			if (text.Length > 220)
			{
				return text.Substring(0, 220);
			}
			return text;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0007ACF8 File Offset: 0x00078EF8
		private static string 랋(string A_0)
		{
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted(A_0);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<long>(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid(), "N");
				string s = defaultInterpolatedStringHandler.ToStringAndClear();
				byte[] array = sha.ComputeHash(Encoding.UTF8.GetBytes(s));
				StringBuilder stringBuilder = new StringBuilder(35);
				stringBuilder.Append("cm_");
				for (int i = 0; i < 16; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0007ADD8 File Offset: 0x00078FD8
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

		// Token: 0x060002A7 RID: 679 RVA: 0x0007AE54 File Offset: 0x00079054
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

		// Token: 0x060002A8 RID: 680 RVA: 0x0007AEA8 File Offset: 0x000790A8
		private static void 랉(string A_0)
		{
			ManualLogSource manualLogSource = 럴.랾();
			if (manualLogSource != null)
			{
				bool flag;
				BepInExInfoLogInterpolatedStringHandler bepInExInfoLogInterpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(32, 1, ref flag);
				if (flag)
				{
					bepInExInfoLogInterpolatedStringHandler.AppendLiteral("[ClientRelayChat/SharedService] ");
					bepInExInfoLogInterpolatedStringHandler.AppendFormatted<string>(A_0);
				}
				manualLogSource.LogInfo(bepInExInfoLogInterpolatedStringHandler);
			}
		}

		// Token: 0x0400024A RID: 586
		private const int 랾 = 220;

		// Token: 0x0400024B RID: 587
		private const int 럎 = 32;

		// Token: 0x0400024C RID: 588
		private const int 람 = 6;

		// Token: 0x0400024D RID: 589
		private const int 럒 = 40;

		// Token: 0x0400024E RID: 590
		private static readonly object 랾 = new object();

		// Token: 0x0400024F RID: 591
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000250 RID: 592
		private static readonly Queue<럲.럎> 랾 = new Queue<럲.럎>();

		// Token: 0x04000251 RID: 593
		private static bool 랾;

		// Token: 0x04000252 RID: 594
		private static bool 럎;

		// Token: 0x04000253 RID: 595
		private static bool 람;

		// Token: 0x02000043 RID: 67
		private readonly struct 랾 : IEquatable<럲.랾>
		{
			// Token: 0x060002AA RID: 682 RVA: 0x0003DDA7 File Offset: 0x0003BFA7
			public 랾(string A_1, string A_2, string A_3, long A_4)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.람 = A_3;
				this.랾 = A_4;
			}

			// Token: 0x060002AB RID: 683 RVA: 0x0003DDC6 File Offset: 0x0003BFC6
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060002AC RID: 684 RVA: 0x0003DDCE File Offset: 0x0003BFCE
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002AD RID: 685 RVA: 0x0003DDD7 File Offset: 0x0003BFD7
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060002AE RID: 686 RVA: 0x0003DDDF File Offset: 0x0003BFDF
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060002AF RID: 687 RVA: 0x0003DDE8 File Offset: 0x0003BFE8
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0003DDF9 File Offset: 0x0003BFF9
			[CompilerGenerated]
			public long 럒()
			{
				return this.랾;
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0003DE01 File Offset: 0x0003C001
			[CompilerGenerated]
			public void 랾(long A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0007AEE8 File Offset: 0x000790E8
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("RemoteRelayMessage");
				stringBuilder.Append(" { ");
				if (this.랾(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0007AF34 File Offset: 0x00079134
			[CompilerGenerated]
			private bool 랾(StringBuilder A_1)
			{
				A_1.Append("RowId = ");
				A_1.Append(this.랾());
				A_1.Append(", DisplayClientId = ");
				A_1.Append(this.럎());
				A_1.Append(", Message = ");
				A_1.Append(this.람());
				A_1.Append(", CreatedUnixMs = ");
				A_1.Append(this.럒().ToString());
				return true;
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0003DE0A File Offset: 0x0003C00A
			[CompilerGenerated]
			public static bool operator !=(럲.랾 A_0, 럲.랾 A_1)
			{
				return !(A_0 == A_1);
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0003DE16 File Offset: 0x0003C016
			[CompilerGenerated]
			public static bool operator ==(럲.랾 A_0, 럲.랾 A_1)
			{
				return A_0.Equals(A_1);
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0007AFB4 File Offset: 0x000791B4
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<string>.Default.GetHashCode(this.랾) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.럎)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.람)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(this.랾);
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0003DE20 File Offset: 0x0003C020
			[CompilerGenerated]
			public override bool Equals(object A_1)
			{
				return A_1 is 럲.랾 && this.Equals((럲.랾)A_1);
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0007B018 File Offset: 0x00079218
			[CompilerGenerated]
			public bool Equals(럲.랾 A_1)
			{
				return EqualityComparer<string>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.럎, A_1.럎) && EqualityComparer<string>.Default.Equals(this.람, A_1.람) && EqualityComparer<long>.Default.Equals(this.랾, A_1.랾);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0003DE38 File Offset: 0x0003C038
			[CompilerGenerated]
			public void 랾(out string A_1, out string A_2, out string A_3, out long A_4)
			{
				A_1 = this.랾();
				A_2 = this.럎();
				A_3 = this.람();
				A_4 = this.럒();
			}

			// Token: 0x04000254 RID: 596
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000255 RID: 597
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x04000256 RID: 598
			[CompilerGenerated]
			private readonly string 람;

			// Token: 0x04000257 RID: 599
			[CompilerGenerated]
			private readonly long 랾;
		}

		// Token: 0x02000044 RID: 68
		private readonly struct 럎 : IEquatable<럲.럎>
		{
			// Token: 0x060002BB RID: 699 RVA: 0x0003DE5B File Offset: 0x0003C05B
			public 럎(string A_1, string A_2, bool A_3)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.랾 = A_3;
			}

			// Token: 0x060002BC RID: 700 RVA: 0x0003DE72 File Offset: 0x0003C072
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060002BD RID: 701 RVA: 0x0003DE7A File Offset: 0x0003C07A
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0003DE83 File Offset: 0x0003C083
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060002BF RID: 703 RVA: 0x0003DE8B File Offset: 0x0003C08B
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x0003DE94 File Offset: 0x0003C094
			[CompilerGenerated]
			public bool 람()
			{
				return this.랾;
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x0003DE9C File Offset: 0x0003C09C
			[CompilerGenerated]
			public void 랾(bool A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x0007B088 File Offset: 0x00079288
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("PendingRelayMessage");
				stringBuilder.Append(" { ");
				if (this.랾(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0007B0D4 File Offset: 0x000792D4
			[CompilerGenerated]
			private bool 랾(StringBuilder A_1)
			{
				A_1.Append("SenderClientId = ");
				A_1.Append(this.랾());
				A_1.Append(", Message = ");
				A_1.Append(this.럎());
				A_1.Append(", IsSystem = ");
				A_1.Append(this.람().ToString());
				return true;
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0003DEA5 File Offset: 0x0003C0A5
			[CompilerGenerated]
			public static bool operator !=(럲.럎 A_0, 럲.럎 A_1)
			{
				return !(A_0 == A_1);
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x0003DEB1 File Offset: 0x0003C0B1
			[CompilerGenerated]
			public static bool operator ==(럲.럎 A_0, 럲.럎 A_1)
			{
				return A_0.Equals(A_1);
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x0003DEBB File Offset: 0x0003C0BB
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<string>.Default.GetHashCode(this.랾) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.럎)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.랾);
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x0003DEFB File Offset: 0x0003C0FB
			[CompilerGenerated]
			public override bool Equals(object A_1)
			{
				return A_1 is 럲.럎 && this.Equals((럲.럎)A_1);
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0007B13C File Offset: 0x0007933C
			[CompilerGenerated]
			public bool Equals(럲.럎 A_1)
			{
				return EqualityComparer<string>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.럎, A_1.럎) && EqualityComparer<bool>.Default.Equals(this.랾, A_1.랾);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0003DF13 File Offset: 0x0003C113
			[CompilerGenerated]
			public void 랾(out string A_1, out string A_2, out bool A_3)
			{
				A_1 = this.랾();
				A_2 = this.럎();
				A_3 = this.람();
			}

			// Token: 0x04000258 RID: 600
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000259 RID: 601
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x0400025A RID: 602
			[CompilerGenerated]
			private readonly bool 랾;
		}

		// Token: 0x02000045 RID: 69
		[CompilerGenerated]
		[Serializable]
		private sealed class 람
		{
			// Token: 0x060002CC RID: 716 RVA: 0x0007B194 File Offset: 0x00079394
			internal int 랾(럲.랾 A_1, 럲.랾 A_2)
			{
				int num = A_1.럒().CompareTo(A_2.럒());
				if (num == 0)
				{
					return string.CompareOrdinal(A_1.랾(), A_2.랾());
				}
				return num;
			}

			// Token: 0x0400025B RID: 603
			public static readonly 럲.람 랾 = new 럲.람();

			// Token: 0x0400025C RID: 604
			public static Comparison<럲.랾> 랾;
		}
	}
}
