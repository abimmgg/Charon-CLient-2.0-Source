using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};

namespace 랾
{
	// Token: 0x0200005B RID: 91
	internal static class 럝
	{
		// Token: 0x0600035B RID: 859 RVA: 0x0003E2F1 File Offset: 0x0003C4F1
		public static bool 랾()
		{
			return !string.IsNullOrWhiteSpace(럧.랪);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0007E3C0 File Offset: 0x0007C5C0
		public static bool 랾(out string A_0, out string A_1, out string A_2)
		{
			bool flag;
			return 랖.랾(out A_0, out A_1, out A_2, out flag);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0007E3D8 File Offset: 0x0007C5D8
		public static Task<string> 랾(string A_0, IDictionary<string, object> A_1)
		{
			럝.랋 랋;
			랋.랾 = AsyncTaskMethodBuilder<string>.Create();
			랋.랾 = A_0;
			랋.랾 = A_1;
			랋.랾 = -1;
			랋.랾.Start<럝.랋>(ref 랋);
			return 랋.랾.Task;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0007E424 File Offset: 0x0007C624
		public static Task<럝.럎> 럎()
		{
			럝.랉 랉;
			랉.랾 = AsyncTaskMethodBuilder<럝.럎>.Create();
			랉.랾 = -1;
			랉.랾.Start<럝.랉>(ref 랉);
			return 랉.랾.Task;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0007E460 File Offset: 0x0007C660
		public static string 랾(string A_0)
		{
			string text = (럧.랪 ?? string.Empty).Trim();
			if (text.EndsWith("/verify", StringComparison.OrdinalIgnoreCase))
			{
				string text2 = text;
				int length = "/verify".Length;
				text = text2.Substring(0, text2.Length - length);
			}
			if (text.EndsWith("/", StringComparison.Ordinal))
			{
				string text2 = text;
				text = text2.Substring(0, text2.Length - 1);
			}
			string text3 = (A_0 ?? string.Empty).Trim();
			if (text3.StartsWith("/", StringComparison.Ordinal))
			{
				text3 = text3.Substring(1);
			}
			return text + "/" + text3;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0007E500 File Offset: 0x0007C700
		private static 럝.람 람()
		{
			럝.람 람 = new 럝.람();
			람.랾(럝.럎(Assembly.GetExecutingAssembly().Location));
			람.럎(럝.럎(typeof(global::랾.랉).Assembly.Location));
			람.람(럝.럎(typeof(랫).Assembly.Location));
			람.럒(럝.럎(럝.럒()));
			return 람;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0007A140 File Offset: 0x00078340
		private static string 럒()
		{
			string result;
			try
			{
				result = Environment.ProcessPath;
			}
			catch
			{
				try
				{
					using (Process currentProcess = Process.GetCurrentProcess())
					{
						ProcessModule mainModule = currentProcess.MainModule;
						result = ((mainModule != null) ? mainModule.FileName : null);
					}
				}
				catch
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0007A1AC File Offset: 0x000783AC
		private static string 럎(string A_0)
		{
			string result;
			try
			{
				if (string.IsNullOrWhiteSpace(A_0) || !File.Exists(A_0))
				{
					result = null;
				}
				else
				{
					using (FileStream fileStream = File.OpenRead(A_0))
					{
						using (SHA256 sha = SHA256.Create())
						{
							result = BitConverter.ToString(sha.ComputeHash(fileStream)).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0007E578 File Offset: 0x0007C778
		private static bool 랾(JsonElement A_0, 럝.람 A_1, out string A_2)
		{
			A_2 = null;
			string text;
			if (럝.랾(A_0, "expected_client_version", out text) && !string.IsNullOrWhiteSpace(text) && !string.Equals(text.Trim(), "2.0", StringComparison.OrdinalIgnoreCase))
			{
				A_2 = "ClientVersionMismatch(" + text.Trim() + ")";
				return false;
			}
			string text2;
			if (!럝.랾(럝.랾(A_0, "expected_plugin_sha256", out text2) ? text2 : null, (A_1 != null) ? A_1.랾() : null))
			{
				A_2 = "PluginHashMismatch";
				return false;
			}
			string text3;
			if (!럝.랾(럝.랾(A_0, "expected_injector_sha256", out text3) ? text3 : null, (A_1 != null) ? A_1.럎() : null))
			{
				A_2 = "InjectorHashMismatch";
				return false;
			}
			string text4;
			if (!럝.랾(럝.랾(A_0, "expected_renderer_sha256", out text4) ? text4 : null, (A_1 != null) ? A_1.람() : null))
			{
				A_2 = "RendererHashMismatch";
				return false;
			}
			string text5;
			if (!럝.랾(럝.랾(A_0, "expected_process_sha256", out text5) ? text5 : null, (A_1 != null) ? A_1.럒() : null))
			{
				A_2 = "ProcessHashMismatch";
				return false;
			}
			return true;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0007E68C File Offset: 0x0007C88C
		private static bool 랾(JsonElement A_0, string A_1, out string A_2)
		{
			A_2 = null;
			JsonElement jsonElement;
			if (!A_0.TryGetProperty(A_1, out jsonElement))
			{
				return false;
			}
			if (jsonElement.ValueKind == JsonValueKind.Null || jsonElement.ValueKind == JsonValueKind.Undefined)
			{
				return true;
			}
			A_2 = jsonElement.GetString();
			return true;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
		private static bool 랾(string A_0, string A_1)
		{
			return string.IsNullOrWhiteSpace(A_0) || (!string.IsNullOrWhiteSpace(A_1) && string.Equals(A_0.Trim(), A_1.Trim(), StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x0200005C RID: 92
		internal enum 랾
		{
			// Token: 0x040002B8 RID: 696
			랾,
			// Token: 0x040002B9 RID: 697
			럎,
			// Token: 0x040002BA RID: 698
			람,
			// Token: 0x040002BB RID: 699
			럒
		}

		// Token: 0x0200005D RID: 93
		internal readonly struct 럎 : IEquatable<럝.럎>
		{
			// Token: 0x06000366 RID: 870 RVA: 0x0003E300 File Offset: 0x0003C500
			public 럎(럝.랾 A_1, string A_2)
			{
				this.랾 = A_1;
				this.랾 = A_2;
			}

			// Token: 0x06000367 RID: 871 RVA: 0x0003E310 File Offset: 0x0003C510
			[CompilerGenerated]
			public 럝.랾 랾()
			{
				return this.랾;
			}

			// Token: 0x06000368 RID: 872 RVA: 0x0003E318 File Offset: 0x0003C518
			[CompilerGenerated]
			public void 랾(럝.랾 A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000369 RID: 873 RVA: 0x0003E321 File Offset: 0x0003C521
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0003E329 File Offset: 0x0003C529
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x0600036B RID: 875 RVA: 0x0003E332 File Offset: 0x0003C532
			public bool 람()
			{
				return this.랾() == 럝.랾.랾;
			}

			// Token: 0x0600036C RID: 876 RVA: 0x0007E6CC File Offset: 0x0007C8CC
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("SessionValidationResult");
				stringBuilder.Append(" { ");
				if (this.랾(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0007E718 File Offset: 0x0007C918
			[CompilerGenerated]
			private bool 랾(StringBuilder A_1)
			{
				A_1.Append("Status = ");
				A_1.Append(this.랾().ToString());
				A_1.Append(", Reason = ");
				A_1.Append(this.럎());
				A_1.Append(", IsAuthorized = ");
				A_1.Append(this.람().ToString());
				return true;
			}

			// Token: 0x0600036E RID: 878 RVA: 0x0003E33D File Offset: 0x0003C53D
			[CompilerGenerated]
			public static bool operator !=(럝.럎 A_0, 럝.럎 A_1)
			{
				return !(A_0 == A_1);
			}

			// Token: 0x0600036F RID: 879 RVA: 0x0003E349 File Offset: 0x0003C549
			[CompilerGenerated]
			public static bool operator ==(럝.럎 A_0, 럝.럎 A_1)
			{
				return A_0.Equals(A_1);
			}

			// Token: 0x06000370 RID: 880 RVA: 0x0003E353 File Offset: 0x0003C553
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return EqualityComparer<럝.랾>.Default.GetHashCode(this.랾) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.랾);
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0003E37C File Offset: 0x0003C57C
			[CompilerGenerated]
			public override bool Equals(object A_1)
			{
				return A_1 is 럝.럎 && this.Equals((럝.럎)A_1);
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0003E394 File Offset: 0x0003C594
			[CompilerGenerated]
			public bool Equals(럝.럎 A_1)
			{
				return EqualityComparer<럝.랾>.Default.Equals(this.랾, A_1.랾) && EqualityComparer<string>.Default.Equals(this.랾, A_1.랾);
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0003E3C6 File Offset: 0x0003C5C6
			[CompilerGenerated]
			public void 랾(out 럝.랾 A_1, out string A_2)
			{
				A_1 = this.랾();
				A_2 = this.럎();
			}

			// Token: 0x040002BC RID: 700
			[CompilerGenerated]
			private readonly 럝.랾 랾;

			// Token: 0x040002BD RID: 701
			[CompilerGenerated]
			private readonly string 랾;
		}

		// Token: 0x0200005E RID: 94
		private sealed class 람
		{
			// Token: 0x06000374 RID: 884 RVA: 0x0003E3D8 File Offset: 0x0003C5D8
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0003E3E0 File Offset: 0x0003C5E0
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000376 RID: 886 RVA: 0x0003E3E9 File Offset: 0x0003C5E9
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x06000377 RID: 887 RVA: 0x0003E3F1 File Offset: 0x0003C5F1
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x06000378 RID: 888 RVA: 0x0003E3FA File Offset: 0x0003C5FA
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x06000379 RID: 889 RVA: 0x0003E402 File Offset: 0x0003C602
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0003E40B File Offset: 0x0003C60B
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0003E413 File Offset: 0x0003C613
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x040002BE RID: 702
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x040002BF RID: 703
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x040002C0 RID: 704
			[CompilerGenerated]
			private readonly string 람;

			// Token: 0x040002C1 RID: 705
			[CompilerGenerated]
			private readonly string 럒;
		}

		// Token: 0x0200005F RID: 95
		[CompilerGenerated]
		private sealed class 럒
		{
			// Token: 0x0600037E RID: 894 RVA: 0x0007E790 File Offset: 0x0007C990
			internal string 랾()
			{
				럚.랾 랾 = 럚.랾(럝.랾(this.랾), JsonSerializer.Serialize<Dictionary<string, object>>(this.랾, null));
				if (!랾.람())
				{
					return null;
				}
				return 랾.럎();
			}

			// Token: 0x040002C2 RID: 706
			public string 랾;

			// Token: 0x040002C3 RID: 707
			public Dictionary<string, object> 랾;
		}

		// Token: 0x02000060 RID: 96
		[CompilerGenerated]
		private sealed class 럼
		{
			// Token: 0x06000380 RID: 896 RVA: 0x0007E7CC File Offset: 0x0007C9CC
			internal 럝.럎 랾()
			{
				럚.랾 랾 = 럚.랾(럝.랾("verify"), JsonSerializer.Serialize<Dictionary<string, object>>(this.랾, null));
				if (!랾.람())
				{
					럝.랾 랾2 = 럝.랾.람;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("http_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(랾.랾());
					return new 럝.럎(랾2, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				string text = 랾.럎();
				if (string.IsNullOrWhiteSpace(text))
				{
					return new 럝.럎(럝.랾.람, "empty_response");
				}
				럝.럎 result;
				using (JsonDocument jsonDocument = JsonDocument.Parse(text, default(JsonDocumentOptions)))
				{
					JsonElement rootElement = jsonDocument.RootElement;
					JsonElement jsonElement;
					if (!rootElement.TryGetProperty("authorized", out jsonElement) || !jsonElement.GetBoolean())
					{
						JsonElement jsonElement2;
						string text2 = rootElement.TryGetProperty("reason", out jsonElement2) ? jsonElement2.GetString() : "unauthorized";
						result = new 럝.럎(럝.랾.럎, string.IsNullOrWhiteSpace(text2) ? "unauthorized" : text2);
					}
					else
					{
						JsonElement jsonElement3;
						if (rootElement.TryGetProperty("token", out jsonElement3))
						{
							string @string = jsonElement3.GetString();
							if (!string.IsNullOrWhiteSpace(@string) && !string.Equals(@string, this.랾, StringComparison.Ordinal))
							{
								럳.랾(럧.럊, @string);
								랖.랾(this.럎, this.람, @string);
							}
							else
							{
								랖.랾(this.럎, this.람, this.랾);
							}
						}
						string text3;
						if (!럝.랾(rootElement, this.랾, out text3))
						{
							result = new 럝.럎(럝.랾.럎, string.IsNullOrWhiteSpace(text3) ? "policy_failed" : text3);
						}
						else
						{
							string text4 = 럳.랾(럧.럊);
							string text5 = (text4 != null) ? text4.Trim() : null;
							랖.랾(this.럎, this.람, string.IsNullOrWhiteSpace(text5) ? this.랾 : text5);
							result = new 럝.럎(럝.랾.랾, "authorized");
						}
					}
				}
				return result;
			}

			// Token: 0x040002C4 RID: 708
			public Dictionary<string, object> 랾;

			// Token: 0x040002C5 RID: 709
			public string 랾;

			// Token: 0x040002C6 RID: 710
			public string 럎;

			// Token: 0x040002C7 RID: 711
			public string 람;

			// Token: 0x040002C8 RID: 712
			public 럝.람 랾;
		}
	}
}
