using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace 랾
{
	// Token: 0x0200000D RID: 13
	internal static class 럯
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00070844 File Offset: 0x0006EA44
		internal static bool 랾(out string A_0)
		{
			List<럯.랾> list;
			if (!럯.랾(out list, out A_0))
			{
				return false;
			}
			Dictionary<string, HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
			List<string> list2 = new List<string>();
			for (int i = 0; i < list.Count; i++)
			{
				럯.랾 랾 = list[i];
				HashSet<string> hashSet;
				if (!dictionary.TryGetValue(랾.람(), out hashSet))
				{
					if (!럯.랾(랾.람(), out hashSet))
					{
						A_0 = "MissingRequiredGameAssembly(" + 랾.람() + ".dll)";
						return false;
					}
					dictionary[랾.람()] = hashSet;
				}
				if (!hashSet.Contains(랾.럎()))
				{
					list2.Add(랾.랾());
				}
			}
			if (list2.Count > 0)
			{
				A_0 = 럯.랾(list2);
				return false;
			}
			A_0 = null;
			return true;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00070908 File Offset: 0x0006EB08
		internal static void 랾(string A_0)
		{
			string text = 럯.럎(A_0);
			try
			{
				럯.랾(IntPtr.Zero, text, "Charon Client Integrity Error", 331792U);
			}
			catch
			{
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00070948 File Offset: 0x0006EB48
		internal static string 럎(string A_0)
		{
			string text = string.IsNullOrWhiteSpace(A_0) ? "Unknown integrity failure." : A_0;
			return (text.StartsWith("MissingRequiredClasses(", StringComparison.Ordinal) ? "One or more required game classes are missing." : "A required game integrity check failed.") + "" + text;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0007098C File Offset: 0x0006EB8C
		private static bool 랾(out List<럯.랾> A_0, out string A_1)
		{
			A_0 = new List<럯.랾>();
			A_1 = null;
			string location = Assembly.GetExecutingAssembly().Location;
			if (string.IsNullOrWhiteSpace(location) || !File.Exists(location))
			{
				A_1 = "MissingPluginBinary";
				return false;
			}
			try
			{
				using (FileStream fileStream = File.OpenRead(location))
				{
					using (PEReader pereader = new PEReader(fileStream))
					{
						if (!pereader.HasMetadata)
						{
							A_1 = "PluginMetadataMissing";
							return false;
						}
						MetadataReader metadataReader = pereader.GetMetadataReader();
						HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
						foreach (TypeReferenceHandle typeReferenceHandle in metadataReader.TypeReferences)
						{
							string text = 럯.럎(metadataReader, typeReferenceHandle);
							if (럯.럼(text))
							{
								string text2 = 럯.랾(metadataReader, typeReferenceHandle);
								if (!string.IsNullOrWhiteSpace(text2) && !럯.랋(text2))
								{
									string item = text + "|" + text2;
									if (hashSet.Add(item))
									{
										A_0.Add(new 럯.랾(text2, text2, text));
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				A_1 = "PluginMetadataReadFailed(" + ex.GetType().Name + ")";
				return false;
			}
			return true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00070B08 File Offset: 0x0006ED08
		private static bool 랾(string A_0, out HashSet<string> A_1)
		{
			A_1 = null;
			string text;
			if (!럯.랾(A_0, out text))
			{
				return false;
			}
			bool result;
			try
			{
				A_1 = 럯.람(text);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00070B48 File Offset: 0x0006ED48
		private static HashSet<string> 람(string A_0)
		{
			HashSet<string> result;
			using (FileStream fileStream = File.OpenRead(A_0))
			{
				using (PEReader pereader = new PEReader(fileStream))
				{
					MetadataReader metadataReader = pereader.GetMetadataReader();
					HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
					foreach (TypeDefinitionHandle typeDefinitionHandle in metadataReader.TypeDefinitions)
					{
						if (metadataReader.GetTypeDefinition(typeDefinitionHandle).GetDeclaringType().IsNil)
						{
							럯.랾(metadataReader, typeDefinitionHandle, null, hashSet);
						}
					}
					result = hashSet;
				}
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00070C14 File Offset: 0x0006EE14
		private static void 랾(MetadataReader A_0, TypeDefinitionHandle A_1, string A_2, HashSet<string> A_3)
		{
			TypeDefinition typeDefinition = A_0.GetTypeDefinition(A_1);
			string @string = A_0.GetString(typeDefinition.Name);
			if (string.IsNullOrWhiteSpace(@string) || string.Equals(@string, "<Module>", StringComparison.Ordinal))
			{
				return;
			}
			string text = 럯.랾(A_0, typeDefinition, A_2);
			if (!string.IsNullOrWhiteSpace(text))
			{
				A_3.Add(text);
			}
			foreach (TypeDefinitionHandle typeDefinitionHandle in typeDefinition.GetNestedTypes())
			{
				럯.랾(A_0, typeDefinitionHandle, text, A_3);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00070C98 File Offset: 0x0006EE98
		private static string 랾(MetadataReader A_0, TypeDefinition A_1, string A_2)
		{
			string @string = A_0.GetString(A_1.Name);
			if (string.IsNullOrWhiteSpace(@string))
			{
				return null;
			}
			if (!string.IsNullOrWhiteSpace(A_2))
			{
				return A_2 + "+" + @string;
			}
			string string2 = A_0.GetString(A_1.Namespace);
			if (!string.IsNullOrWhiteSpace(string2))
			{
				return string2 + "." + @string;
			}
			return @string;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00070CF8 File Offset: 0x0006EEF8
		private static string 랾(MetadataReader A_0, TypeDefinitionHandle A_1)
		{
			TypeDefinition typeDefinition = A_0.GetTypeDefinition(A_1);
			TypeDefinitionHandle declaringType = typeDefinition.GetDeclaringType();
			if (declaringType.IsNil)
			{
				return 럯.랾(A_0, typeDefinition, null);
			}
			string text = 럯.랾(A_0, declaringType);
			string @string = A_0.GetString(typeDefinition.Name);
			if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(@string))
			{
				return text + "+" + @string;
			}
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00070D5C File Offset: 0x0006EF5C
		private static string 랾(MetadataReader A_0, TypeReferenceHandle A_1)
		{
			TypeReference typeReference = A_0.GetTypeReference(A_1);
			string @string = A_0.GetString(typeReference.Name);
			if (string.IsNullOrWhiteSpace(@string))
			{
				return null;
			}
			if (typeReference.ResolutionScope.Kind == HandleKind.TypeReference)
			{
				string text = 럯.랾(A_0, (TypeReferenceHandle)typeReference.ResolutionScope);
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text + "+" + @string;
				}
				return @string;
			}
			else
			{
				string string2 = A_0.GetString(typeReference.Namespace);
				if (!string.IsNullOrWhiteSpace(string2))
				{
					return string2 + "." + @string;
				}
				return @string;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00070DEC File Offset: 0x0006EFEC
		private static string 럎(MetadataReader A_0, TypeReferenceHandle A_1)
		{
			return 럯.랾(A_0, A_0.GetTypeReference(A_1).ResolutionScope);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00070E10 File Offset: 0x0006F010
		private static string 랾(MetadataReader A_0, EntityHandle A_1)
		{
			HandleKind kind = A_1.Kind;
			string result;
			if (kind != HandleKind.TypeReference)
			{
				if (kind == HandleKind.AssemblyReference)
				{
					result = A_0.GetString(A_0.GetAssemblyReference((AssemblyReferenceHandle)A_1).Name);
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = 럯.럎(A_0, (TypeReferenceHandle)A_1);
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00070E60 File Offset: 0x0006F060
		private static bool 랾(string A_0, out string A_1)
		{
			A_1 = null;
			try
			{
				foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
				{
					if (string.Equals(assembly.GetName().Name, A_0, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(assembly.Location) && File.Exists(assembly.Location))
					{
						A_1 = assembly.Location;
						return true;
					}
				}
			}
			catch
			{
			}
			foreach (string text in 럯.럒(A_0 + ".dll"))
			{
				if (File.Exists(text))
				{
					A_1 = text;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0003CBE6 File Offset: 0x0003ADE6
		private static IEnumerable<string> 럒(string A_0)
		{
			럯.람 람 = new 럯.람(-2);
			람.람 = A_0;
			return 람;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0003CBF6 File Offset: 0x0003ADF6
		private static IEnumerable<string> 랾()
		{
			return new 럯.럒(-2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0003CBFF File Offset: 0x0003ADFF
		private static IEnumerable<string> 랾(string A_0, int A_1)
		{
			럯.럎 럎 = new 럯.럎(-2);
			럎.람 = A_0;
			럎.럒 = A_1;
			return 럎;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00070F38 File Offset: 0x0006F138
		private static string 랾(List<string> A_0)
		{
			A_0.Sort(StringComparer.Ordinal);
			if (A_0.Count <= 12)
			{
				return "MissingRequiredClasses(" + string.Join(", ", A_0) + ")";
			}
			int value = A_0.Count - 12;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
			defaultInterpolatedStringHandler.AppendLiteral("MissingRequiredClasses(");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join(", ", A_0.Take(12)));
			defaultInterpolatedStringHandler.AppendLiteral(", +");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral(" more)");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00070FD8 File Offset: 0x0006F1D8
		private static bool 럼(string A_0)
		{
			for (int i = 0; i < 럯.랾.Length; i++)
			{
				if (string.Equals(럯.랾[i], A_0, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0003CC16 File Offset: 0x0003AE16
		private static bool 랋(string A_0)
		{
			return string.IsNullOrWhiteSpace(A_0) || A_0.IndexOf('<') >= 0 || A_0.IndexOf('>') >= 0 || A_0.StartsWith("<", StringComparison.Ordinal) || A_0.StartsWith("PrivateImplementationDetails", StringComparison.Ordinal);
		}

		// Token: 0x0600005A RID: 90
		[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBoxW", SetLastError = true)]
		private static extern int 랾(IntPtr, string, string, uint);

		// Token: 0x0400001E RID: 30
		private const uint 랾 = 0U;

		// Token: 0x0400001F RID: 31
		private const uint 럎 = 16U;

		// Token: 0x04000020 RID: 32
		private const uint 람 = 4096U;

		// Token: 0x04000021 RID: 33
		private const uint 럒 = 65536U;

		// Token: 0x04000022 RID: 34
		private const uint 럼 = 262144U;

		// Token: 0x04000023 RID: 35
		private static readonly string[] 랾 = new string[]
		{
			"Assembly-CSharp",
			"Assembly-CSharp-firstpass"
		};

		// Token: 0x0200000E RID: 14
		private readonly struct 랾
		{
			// Token: 0x0600005C RID: 92 RVA: 0x0003CC71 File Offset: 0x0003AE71
			internal 랾(string A_1, string A_2, string A_3)
			{
				this.랾 = A_1;
				this.럎 = A_2;
				this.람 = A_3;
			}

			// Token: 0x0600005D RID: 93 RVA: 0x0003CC88 File Offset: 0x0003AE88
			[CompilerGenerated]
			internal string 랾()
			{
				return this.랾;
			}

			// Token: 0x0600005E RID: 94 RVA: 0x0003CC90 File Offset: 0x0003AE90
			[CompilerGenerated]
			internal string 럎()
			{
				return this.럎;
			}

			// Token: 0x0600005F RID: 95 RVA: 0x0003CC98 File Offset: 0x0003AE98
			[CompilerGenerated]
			internal string 람()
			{
				return this.람;
			}

			// Token: 0x04000024 RID: 36
			[CompilerGenerated]
			private readonly string 랾;

			// Token: 0x04000025 RID: 37
			[CompilerGenerated]
			private readonly string 럎;

			// Token: 0x04000026 RID: 38
			[CompilerGenerated]
			private readonly string 람;
		}
	}
}
