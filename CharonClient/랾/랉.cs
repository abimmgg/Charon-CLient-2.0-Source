using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace 랾
{
	// Token: 0x02000008 RID: 8
	internal static class 랉
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0006F098 File Offset: 0x0006D298
		public static bool 랾(string A_0, out string A_1)
		{
			A_1 = null;
			string str;
			if (!랉.랾(out str))
			{
				A_1 = "EnvironmentCheck(" + str + ")";
				return false;
			}
			if (string.IsNullOrWhiteSpace(A_0) || !File.Exists(A_0))
			{
				A_1 = "ArtifactAssemblyLocationMissing";
				return false;
			}
			string text = 랉.랾(A_0);
			if (string.IsNullOrWhiteSpace(text) || !File.Exists(text))
			{
				A_1 = "ArtifactManifestMissing";
				return false;
			}
			랉.랾 랾;
			if (!랉.랾(text, out 랾, out A_1))
			{
				return false;
			}
			Dictionary<string, string> dictionary = 랾.람();
			string directoryName = Path.GetDirectoryName(text);
			if (string.IsNullOrWhiteSpace(directoryName) || !Directory.Exists(directoryName))
			{
				A_1 = "ArtifactPluginRootMissing";
				return false;
			}
			for (int i = 0; i < 랉.랾.Length; i++)
			{
				string text2 = 랉.랾[i];
				string text3;
				if (!dictionary.TryGetValue(text2, out text3) || string.IsNullOrWhiteSpace(text3))
				{
					A_1 = "ArtifactManifestEntryMissing(" + text2 + ")";
					return false;
				}
				string text4 = 랉.랾(directoryName, text2);
				if (string.IsNullOrWhiteSpace(text4) || !File.Exists(text4))
				{
					A_1 = "ArtifactMissing(" + text2 + ")";
					return false;
				}
				string text5 = 랉.럎(text4);
				if (string.IsNullOrWhiteSpace(text5))
				{
					A_1 = "ArtifactHashReadFailed(" + text2 + ")";
					return false;
				}
				if (!string.Equals(text3.Trim(), text5.Trim(), StringComparison.OrdinalIgnoreCase))
				{
					A_1 = "ArtifactHashMismatch(" + text2 + ")";
					return false;
				}
			}
			랉.랾(directoryName, dictionary, 랾.럎());
			return true;
		}

		// Token: 0x0600000C RID: 12
		[DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent", ExactSpelling = true)]
		private static extern bool 랾();

		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true)]
		private static extern bool 랾(IntPtr, [MarshalAs(UnmanagedType.Bool)] out bool);

		// Token: 0x0600000E RID: 14
		[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", ExactSpelling = true)]
		private static extern int 랾(IntPtr, int, ref IntPtr, int, ref int);

		// Token: 0x0600000F RID: 15 RVA: 0x0006F218 File Offset: 0x0006D418
		public static bool 랾(out string A_0)
		{
			A_0 = null;
			try
			{
				if (Debugger.IsAttached)
				{
					A_0 = "DebuggerAttached(Managed)";
					return false;
				}
			}
			catch
			{
			}
			try
			{
				if (랉.랾())
				{
					A_0 = "DebuggerAttached(Win32)";
					return false;
				}
			}
			catch
			{
			}
			try
			{
				using (Process currentProcess = Process.GetCurrentProcess())
				{
					bool flag;
					if (랉.랾(currentProcess.Handle, out flag) && flag)
					{
						A_0 = "DebuggerAttached(Remote)";
						return false;
					}
				}
			}
			catch
			{
			}
			try
			{
				using (Process currentProcess2 = Process.GetCurrentProcess())
				{
					IntPtr zero = IntPtr.Zero;
					int num = 0;
					if (랉.랾(currentProcess2.Handle, 7, ref zero, IntPtr.Size, ref num) == 0 && zero != IntPtr.Zero)
					{
						A_0 = "DebuggerAttached(NtPort)";
						return false;
					}
				}
			}
			catch
			{
			}
			try
			{
				using (Process currentProcess3 = Process.GetCurrentProcess())
				{
					IntPtr zero2 = IntPtr.Zero;
					int num2 = 0;
					if (랉.랾(currentProcess3.Handle, 30, ref zero2, IntPtr.Size, ref num2) == 0 && zero2 != IntPtr.Zero)
					{
						A_0 = "DebuggerAttached(DebugObject)";
						return false;
					}
				}
			}
			catch
			{
			}
			long ticks = DateTime.UtcNow.Ticks;
			long num3 = Interlocked.Read(ref 랉.랾);
			if (ticks - num3 >= 랉.럎)
			{
				Interlocked.Exchange(ref 랉.랾, ticks);
				string str;
				if (랉.람(out str))
				{
					A_0 = "SuspiciousProcess(" + str + ")";
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0006F3FC File Offset: 0x0006D5FC
		public static bool 럎(out string A_0)
		{
			A_0 = null;
			try
			{
				if (Debugger.IsAttached)
				{
					A_0 = "DebuggerAttached(Managed)";
					return false;
				}
			}
			catch
			{
			}
			try
			{
				if (랉.랾())
				{
					A_0 = "DebuggerAttached(Win32)";
					return false;
				}
			}
			catch
			{
			}
			try
			{
				using (Process currentProcess = Process.GetCurrentProcess())
				{
					bool flag;
					if (랉.랾(currentProcess.Handle, out flag) && flag)
					{
						A_0 = "DebuggerAttached(Remote)";
						return false;
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0006F4A8 File Offset: 0x0006D6A8
		private static bool 람(out string A_0)
		{
			A_0 = null;
			Process[] array = null;
			try
			{
				array = Process.GetProcesses();
				foreach (Process process in array)
				{
					try
					{
						string processName = process.ProcessName;
						if (!string.IsNullOrEmpty(processName))
						{
							string text = processName.ToLowerInvariant();
							foreach (string value in 랉.럎)
							{
								if (text.Contains(value))
								{
									A_0 = processName;
									return true;
								}
							}
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (array != null)
				{
					foreach (Process process2 in array)
					{
						try
						{
							process2.Dispose();
						}
						catch
						{
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0006F58C File Offset: 0x0006D78C
		private static void 랾(string A_0, Dictionary<string, string> A_1, string A_2)
		{
			object obj = 랉.랾;
			lock (obj)
			{
				if (랉.랾 == null)
				{
					try
					{
						using (SHA256 sha = SHA256.Create())
						{
							랉.랾 = sha.ComputeHash(Encoding.UTF8.GetBytes("PinnedHashKey:" + (A_2 ?? string.Empty)));
							List<string> list = new List<string>(랉.랾.Length);
							List<byte[]> list2 = new List<byte[]>(랉.랾.Length);
							foreach (string text in 랉.랾)
							{
								string text2;
								if (A_1.TryGetValue(text, out text2) && !string.IsNullOrWhiteSpace(text2))
								{
									string text3 = 랉.랾(A_0, text);
									if (!string.IsNullOrWhiteSpace(text3))
									{
										byte[] item = 랉.럎(Convert.FromHexString(text2), 랉.랾);
										list.Add(text3);
										list2.Add(item);
									}
								}
							}
							랉.랾 = list.ToArray();
							랉.랾 = list2.ToArray();
						}
					}
					catch
					{
						랉.랾 = null;
						랉.랾 = null;
						랉.랾 = null;
					}
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0006F708 File Offset: 0x0006D908
		private static bool 럒(out string A_0)
		{
			A_0 = null;
			object obj = 랉.랾;
			byte[][] array;
			string[] array2;
			byte[] array3;
			lock (obj)
			{
				if (랉.랾 == null)
				{
					return true;
				}
				array = 랉.랾;
				array2 = 랉.랾;
				array3 = 랉.랾;
			}
			for (int i = 0; i < array.Length; i++)
			{
				string text = array2[i];
				if (!File.Exists(text))
				{
					A_0 = "PinnedAssemblyMissing(" + Path.GetFileName(text) + ")";
					return false;
				}
				string text2 = 랉.럎(text);
				if (string.IsNullOrWhiteSpace(text2))
				{
					A_0 = "PinnedHashReadFailed(" + Path.GetFileName(text) + ")";
					return false;
				}
				if (!랉.랾(랉.럎(Convert.FromHexString(text2), array3), array[i]))
				{
					A_0 = "PinnedHashMismatch(" + Path.GetFileName(text) + ")";
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0006F810 File Offset: 0x0006DA10
		private static bool 랾(byte[] A_0, byte[] A_1)
		{
			if (A_0 == null || A_1 == null)
			{
				return A_0 == A_1;
			}
			if (A_0.Length != A_1.Length)
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < A_0.Length; i++)
			{
				num |= (int)(A_0[i] ^ A_1[i]);
			}
			return num == 0;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0006F850 File Offset: 0x0006DA50
		private static byte[] 럎(byte[] A_0, byte[] A_1)
		{
			if (A_0 == null || A_1 == null || A_1.Length == 0)
			{
				return A_0 ?? Array.Empty<byte>();
			}
			byte[] array = new byte[A_0.Length];
			for (int i = 0; i < A_0.Length; i++)
			{
				array[i] = (A_0[i] ^ A_1[i % A_1.Length]);
			}
			return array;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0003CA21 File Offset: 0x0003AC21
		public static bool 럼(out string A_0)
		{
			return 랉.랾(out A_0) && 랉.럒(out A_0);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0006F89C File Offset: 0x0006DA9C
		public static void 럎()
		{
			string str;
			if (!랉.럼(out str))
			{
				try
				{
					Environment.FailFast("PortableGuardViolation:" + str);
				}
				catch
				{
				}
				try
				{
					Environment.Exit(0);
				}
				catch
				{
				}
				try
				{
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0006F90C File Offset: 0x0006DB0C
		private static string 랾(string A_0)
		{
			string text = Path.GetDirectoryName(A_0);
			int num = 0;
			while (num < 4 && !string.IsNullOrWhiteSpace(text))
			{
				string text2 = Path.Combine(text, "oracle-hashes.json");
				if (File.Exists(text2))
				{
					return text2;
				}
				DirectoryInfo parent = Directory.GetParent(text);
				text = ((parent != null) ? parent.FullName : null);
				num++;
			}
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0006F960 File Offset: 0x0006DB60
		private static string 랾(string A_0, string A_1)
		{
			string text = Path.Combine(A_0, A_1);
			if (File.Exists(text))
			{
				return text;
			}
			string text2 = Path.Combine(A_0, "ImGui", A_1);
			if (File.Exists(text2))
			{
				return text2;
			}
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0006F998 File Offset: 0x0006DB98
		private static bool 랾(string A_0, out 랉.랾 A_1, out string A_2)
		{
			A_1 = null;
			A_2 = null;
			bool result;
			try
			{
				using (JsonDocument jsonDocument = JsonDocument.Parse(File.ReadAllText(A_0), default(JsonDocumentOptions)))
				{
					JsonElement rootElement = jsonDocument.RootElement;
					JsonElement jsonElement;
					int num;
					JsonElement jsonElement2;
					if (rootElement.ValueKind != JsonValueKind.Object)
					{
						A_2 = "ArtifactManifestInvalid";
						result = false;
					}
					else if (!rootElement.TryGetProperty("version", out jsonElement) || jsonElement.ValueKind != JsonValueKind.Number || !jsonElement.TryGetInt32(out num))
					{
						A_2 = "ArtifactManifestInvalid";
						result = false;
					}
					else if (num != 1)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
						defaultInterpolatedStringHandler.AppendLiteral("ArtifactManifestVersionUnsupported(");
						defaultInterpolatedStringHandler.AppendFormatted<int>(num);
						defaultInterpolatedStringHandler.AppendLiteral(")");
						A_2 = defaultInterpolatedStringHandler.ToStringAndClear();
						result = false;
					}
					else if (!rootElement.TryGetProperty("generated_utc", out jsonElement2) || jsonElement2.ValueKind != JsonValueKind.String)
					{
						A_2 = "ArtifactManifestInvalid";
						result = false;
					}
					else
					{
						string @string = jsonElement2.GetString();
						JsonElement jsonElement3;
						if (string.IsNullOrWhiteSpace(@string))
						{
							A_2 = "ArtifactManifestInvalid";
							result = false;
						}
						else if (!rootElement.TryGetProperty("assemblies", out jsonElement3) || jsonElement3.ValueKind != JsonValueKind.Object)
						{
							A_2 = "ArtifactManifestInvalid";
							result = false;
						}
						else
						{
							Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
							foreach (JsonProperty jsonProperty in jsonElement3.EnumerateObject())
							{
								if (jsonProperty.Value.ValueKind != JsonValueKind.String)
								{
									A_2 = "ArtifactManifestInvalid";
									return false;
								}
								string string2 = jsonProperty.Value.GetString();
								if (string.IsNullOrWhiteSpace(string2))
								{
									A_2 = "ArtifactManifestEntryMissing(" + jsonProperty.Name + ")";
									return false;
								}
								dictionary[jsonProperty.Name] = string2;
							}
							JsonElement jsonElement4;
							JsonElement jsonElement5;
							JsonElement jsonElement6;
							if (dictionary.Count == 0)
							{
								A_2 = "ArtifactManifestInvalid";
								result = false;
							}
							else if (!rootElement.TryGetProperty("signature", out jsonElement4) || jsonElement4.ValueKind != JsonValueKind.Object)
							{
								A_2 = "ArtifactManifestSignatureMissing";
								result = false;
							}
							else if (!jsonElement4.TryGetProperty("algorithm", out jsonElement5) || jsonElement5.ValueKind != JsonValueKind.String)
							{
								A_2 = "ArtifactManifestSignatureMissing";
								result = false;
							}
							else if (!jsonElement4.TryGetProperty("value", out jsonElement6) || jsonElement6.ValueKind != JsonValueKind.String)
							{
								A_2 = "ArtifactManifestSignatureMissing";
								result = false;
							}
							else
							{
								랉.랾 랾 = new 랉.랾();
								랾.랾(num);
								랾.랾(@string);
								랾.랾(dictionary);
								랾.럎(jsonElement5.GetString());
								랾.람(jsonElement6.GetString());
								A_1 = 랾;
								if (!랉.랾(A_1, out A_2))
								{
									result = false;
								}
								else
								{
									result = true;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				A_2 = 랉.랾("ArtifactManifestReadFailed", ex);
				result = false;
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0006FCC4 File Offset: 0x0006DEC4
		private static string 럎(string A_0)
		{
			string result;
			try
			{
				using (FileStream fileStream = File.OpenRead(A_0))
				{
					using (SHA256 sha = SHA256.Create())
					{
						result = Convert.ToHexString(sha.ComputeHash(fileStream));
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0006FD30 File Offset: 0x0006DF30
		private static bool 랾(랉.랾 A_0, out string A_1)
		{
			A_1 = null;
			if (A_0 == null)
			{
				A_1 = "ArtifactManifestInvalid";
				return false;
			}
			if (!string.Equals(A_0.럒(), "RSA-SHA256", StringComparison.OrdinalIgnoreCase))
			{
				A_1 = "ArtifactManifestSignatureAlgorithmUnsupported(" + (A_0.럒() ?? "h") + ")";
				return false;
			}
			if (string.IsNullOrWhiteSpace(A_0.럼()))
			{
				A_1 = "ArtifactManifestSignatureMissing";
				return false;
			}
			byte[] bytes;
			byte[] signature;
			try
			{
				bytes = Encoding.UTF8.GetBytes(랉.랾(A_0));
				signature = Convert.FromBase64String(A_0.럼());
			}
			catch (FormatException)
			{
				A_1 = "ArtifactManifestSignatureInvalid";
				return false;
			}
			catch (Exception ex)
			{
				A_1 = 랉.랾("ArtifactManifestSignaturePayloadReadFailed", ex);
				return false;
			}
			bool result;
			try
			{
				using (RSA rsa = 랉.람())
				{
					if (!rsa.VerifyData(bytes, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1))
					{
						A_1 = "ArtifactManifestSignatureInvalid";
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			catch (CryptographicException ex2)
			{
				A_1 = 랉.랾("ArtifactManifestSignatureCryptoFailed", ex2);
				result = false;
			}
			catch (TypeInitializationException ex3)
			{
				A_1 = 랉.랾("ArtifactManifestSignatureCryptoInitFailed", ex3);
				result = false;
			}
			catch (Exception ex4)
			{
				A_1 = 랉.랾("ArtifactManifestSignatureReadFailed", ex4);
				result = false;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0006FE9C File Offset: 0x0006E09C
		private static RSA 람()
		{
			RSAParameters parameters = new RSAParameters
			{
				Modulus = Convert.FromBase64String("24EABqOqXHAZ+reghJ5BnZBwDgS9/X4k06OMg63Y1OU1t6D6cBbYZ8hsyj4umwu4AMEvCZwR+E1hGFraYj2WXxCpbRclC9WpODRUy5WDh4m1G+khgo0TagLa51Up9nH/yJz4GMbZXbf4nV8T3gPa/UXE4R0wHM4Ln/s/iiNr80LS4KBATnGzbvbXx8Kc4p+Dp3XciPa0hbdsZnA5eB6fWCVNmBu/gK8UbZZCegs/JWfHU2gFx2pyi1fP7xONIko62sXi9TmKnIyPXcKzeeyRpacT2zKjmEnvKtvK5e4zX609vF6OZU0MrdUNFjIZzn/8PXKd4Dn/36R65aFVDX97RsEz2sQlnu8ifQ/wVlYNZtHbpYqcMVsOIqnGxfKJlG2xTlWR6rxucl8qCQfByjjdEMAB6LMBVotimeMYLUUGphg1FFCD+FEIAKNRadXCfO5Pr8fvjnwTm9XvTRg3LLW91nyvxjErnlQBpYh+nLJ8Zou1NvA83dAM3yjwYDSJjq1t"),
				Exponent = Convert.FromBase64String("AQAB")
			};
			Exception ex = null;
			try
			{
				RSA rsa = RSA.Create();
				rsa.ImportParameters(parameters);
				return rsa;
			}
			catch (Exception ex)
			{
			}
			RSA result;
			try
			{
				RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
				rsacryptoServiceProvider.PersistKeyInCsp = false;
				rsacryptoServiceProvider.ImportParameters(parameters);
				result = rsacryptoServiceProvider;
			}
			catch (Exception ex2)
			{
				throw new CryptographicException("Unable to initialize RSA verifier. Primary=" + 랉.랾(ex) + " Fallback=" + 랉.랾(ex2), ex2);
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0006FF44 File Offset: 0x0006E144
		private static string 랾(랉.랾 A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PortableArtifactManifestSignatureV1");
			stringBuilder.Append("version=").Append(A_0.랾()).Append('\n');
			stringBuilder.Append("generated_utc=").Append(A_0.럎() ?? string.Empty).Append('\n');
			foreach (string text in A_0.람().Keys.OrderBy(new Func<string, string>(랉.럎.랾.랾), StringComparer.Ordinal))
			{
				stringBuilder.Append("assembly:").Append(text).Append('=').Append(A_0.람()[text] ?? string.Empty).Append('\n');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0003CA38 File Offset: 0x0003AC38
		private static string 랾(string A_0, Exception A_1)
		{
			return A_0 + "(" + 랉.랾(A_1) + ")";
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00070050 File Offset: 0x0006E250
		private static string 랾(Exception A_0)
		{
			if (A_0 == null)
			{
				return "h";
			}
			if (A_0.InnerException == null)
			{
				return A_0.GetType().Name + ": " + A_0.Message;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
			defaultInterpolatedStringHandler.AppendFormatted(A_0.GetType().Name);
			defaultInterpolatedStringHandler.AppendLiteral(": ");
			defaultInterpolatedStringHandler.AppendFormatted(A_0.Message);
			defaultInterpolatedStringHandler.AppendLiteral(" -> ");
			defaultInterpolatedStringHandler.AppendFormatted(랉.랾(A_0.InnerException));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04000005 RID: 5
		private const string 랾 = "oracle-hashes.json";

		// Token: 0x04000006 RID: 6
		private const int 랾 = 1;

		// Token: 0x04000007 RID: 7
		private const string 럎 = "RSA-SHA256";

		// Token: 0x04000008 RID: 8
		private const string 람 = "24EABqOqXHAZ+reghJ5BnZBwDgS9/X4k06OMg63Y1OU1t6D6cBbYZ8hsyj4umwu4AMEvCZwR+E1hGFraYj2WXxCpbRclC9WpODRUy5WDh4m1G+khgo0TagLa51Up9nH/yJz4GMbZXbf4nV8T3gPa/UXE4R0wHM4Ln/s/iiNr80LS4KBATnGzbvbXx8Kc4p+Dp3XciPa0hbdsZnA5eB6fWCVNmBu/gK8UbZZCegs/JWfHU2gFx2pyi1fP7xONIko62sXi9TmKnIyPXcKzeeyRpacT2zKjmEnvKtvK5e4zX609vF6OZU0MrdUNFjIZzn/8PXKd4Dn/36R65aFVDX97RsEz2sQlnu8ifQ/wVlYNZtHbpYqcMVsOIqnGxfKJlG2xTlWR6rxucl8qCQfByjjdEMAB6LMBVotimeMYLUUGphg1FFCD+FEIAKNRadXCfO5Pr8fvjnwTm9XvTRg3LLW91nyvxjErnlQBpYh+nLJ8Zou1NvA83dAM3yjwYDSJjq1t";

		// Token: 0x04000009 RID: 9
		private const string 럒 = "AQAB";

		// Token: 0x0400000A RID: 10
		private static readonly string[] 랾 = new string[]
		{
			"CharonClient.dll",
			"DearImGuiInjection.dll",
			"RendererFinder.dll"
		};

		// Token: 0x0400000B RID: 11
		private static readonly string[] 럎 = new string[]
		{
			"dnspy",
			"dnspyex",
			"de4dot",
			"ilspy",
			"dotpeek",
			"justdecompile",
			"reflector",
			"x64dbg",
			"x32dbg",
			"ollydbg",
			"windbg",
			"windbgx",
			"idapro",
			"ida64",
			"ghidra",
			"binaryninja",
			"pestudio",
			"pe-bear",
			"cff explorer",
			"lordpe",
			"cheatengine-x86_64",
			"cheatengine",
			"scylla",
			"scyllax64",
			"megadumper",
			"extremedumper",
			"processhacker",
			"processhacker2",
			"reshacker"
		};

		// Token: 0x0400000C RID: 12
		private static long 랾;

		// Token: 0x0400000D RID: 13
		private static readonly long 럎 = TimeSpan.FromSeconds(30.0).Ticks;

		// Token: 0x0400000E RID: 14
		private static volatile byte[][] 랾;

		// Token: 0x0400000F RID: 15
		private static volatile string[] 랾;

		// Token: 0x04000010 RID: 16
		private static byte[] 랾;

		// Token: 0x04000011 RID: 17
		private static readonly object 랾 = new object();

		// Token: 0x02000009 RID: 9
		private sealed class 랾
		{
			// Token: 0x06000022 RID: 34 RVA: 0x0003CA50 File Offset: 0x0003AC50
			[CompilerGenerated]
			public int 랾()
			{
				return this.랾;
			}

			// Token: 0x06000023 RID: 35 RVA: 0x0003CA58 File Offset: 0x0003AC58
			[CompilerGenerated]
			public void 랾(int A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000024 RID: 36 RVA: 0x0003CA61 File Offset: 0x0003AC61
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x06000025 RID: 37 RVA: 0x0003CA69 File Offset: 0x0003AC69
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000026 RID: 38 RVA: 0x0003CA72 File Offset: 0x0003AC72
			[CompilerGenerated]
			public Dictionary<string, string> 람()
			{
				return this.랾;
			}

			// Token: 0x06000027 RID: 39 RVA: 0x0003CA7A File Offset: 0x0003AC7A
			[CompilerGenerated]
			public void 랾(Dictionary<string, string> A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000028 RID: 40 RVA: 0x0003CA83 File Offset: 0x0003AC83
			[CompilerGenerated]
			public string 럒()
			{
				return this.럎;
			}

			// Token: 0x06000029 RID: 41 RVA: 0x0003CA8B File Offset: 0x0003AC8B
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x0600002A RID: 42 RVA: 0x0003CA94 File Offset: 0x0003AC94
			[CompilerGenerated]
			public string 럼()
			{
				return this.람;
			}

			// Token: 0x0600002B RID: 43 RVA: 0x0003CA9C File Offset: 0x0003AC9C
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x04000012 RID: 18
			[CompilerGenerated]
			private int 랾;

			// Token: 0x04000013 RID: 19
			[CompilerGenerated]
			private string 랾;

			// Token: 0x04000014 RID: 20
			[CompilerGenerated]
			private Dictionary<string, string> 랾 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

			// Token: 0x04000015 RID: 21
			[CompilerGenerated]
			private string 럎;

			// Token: 0x04000016 RID: 22
			[CompilerGenerated]
			private string 람;
		}

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x0600002F RID: 47 RVA: 0x0003CAD1 File Offset: 0x0003ACD1
			internal string 랾(string A_1)
			{
				return A_1;
			}

			// Token: 0x04000017 RID: 23
			public static readonly 랉.럎 랾 = new 랉.럎();

			// Token: 0x04000018 RID: 24
			public static Func<string, string> 랾;
		}
	}
}
