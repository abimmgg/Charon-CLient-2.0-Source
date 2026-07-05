using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace 랾
{
	// Token: 0x02000037 RID: 55
	public static class 럊
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00078094 File Offset: 0x00076294
		public static 럏 랾(string A_0, string A_1, string A_2)
		{
			럏 result;
			try
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
				dictionary["hwid"] = A_0;
				dictionary["install_id"] = A_1;
				dictionary["token"] = A_2;
				string text = JsonSerializer.Serialize<Dictionary<string, object>>(dictionary, null);
				럚.랾 랾 = 럚.랾(럧.랪.TrimEnd('/') + "/ui-script", text);
				string text2 = 랾.럎();
				if (!랾.람())
				{
					럏 럏 = new 럏();
					럏.랾((랾.랾() == 401) ? 랠.럎 : 랠.람);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
					defaultInterpolatedStringHandler.AppendLiteral("HTTP ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(랾.랾());
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					럏.럼(defaultInterpolatedStringHandler.ToStringAndClear());
					result = 럏;
				}
				else
				{
					using (JsonDocument jsonDocument = JsonDocument.Parse(text2, default(JsonDocumentOptions)))
					{
						JsonElement rootElement = jsonDocument.RootElement;
						JsonElement jsonElement;
						if (!rootElement.TryGetProperty("ok", out jsonElement) || !jsonElement.GetBoolean())
						{
							JsonElement jsonElement2;
							string text3 = rootElement.TryGetProperty("error", out jsonElement2) ? jsonElement2.GetString() : "unknown_error";
							럏 럏2 = new 럏();
							럏2.랾(랠.람);
							럏2.럼(text3);
							result = 럏2;
						}
						else
						{
							JsonElement jsonElement3;
							string text4 = rootElement.TryGetProperty("code", out jsonElement3) ? jsonElement3.GetString() : null;
							JsonElement jsonElement4;
							string text5 = rootElement.TryGetProperty("sha256", out jsonElement4) ? jsonElement4.GetString() : null;
							JsonElement jsonElement5;
							string text6 = rootElement.TryGetProperty("signature", out jsonElement5) ? jsonElement5.GetString() : null;
							JsonElement jsonElement6;
							long num = rootElement.TryGetProperty("version", out jsonElement6) ? jsonElement6.GetInt64() : 0L;
							JsonElement jsonElement7;
							string text7 = rootElement.TryGetProperty("updated_at", out jsonElement7) ? jsonElement7.GetString() : null;
							if (string.IsNullOrWhiteSpace(text4))
							{
								럏 럏3 = new 럏();
								럏3.랾(랠.럒);
								럏3.럼("UI script was empty.");
								result = 럏3;
							}
							else
							{
								럏 럏4 = new 럏();
								럏4.랾(랠.랾);
								럏4.랾(text4);
								럏4.럎(text5);
								럏4.람(text6);
								럏4.랾(num);
								럏4.럒(text7);
								result = 럏4;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				럏 럏5 = new 럏();
				럏5.랾(랠.람);
				럏5.럼(ex.Message);
				result = 럏5;
			}
			return result;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00078320 File Offset: 0x00076520
		public static bool 랾(럏 A_0, string A_1, out string A_2)
		{
			A_2 = null;
			bool result;
			try
			{
				if (A_0 == null)
				{
					A_2 = "UI script result was null.";
					result = false;
				}
				else if (A_0.랾() != 랠.랾)
				{
					A_2 = (A_0.랉() ?? "UI script fetch failed.");
					result = false;
				}
				else if (!럫.랾(A_0.럎(), A_0.럼(), A_0.람(), A_0.럒(), A_1))
				{
					A_2 = "UI script signature verification failed.";
					result = false;
				}
				else
				{
					ScriptOptions options = ScriptOptions.Default.AddReferences(new Assembly[]
					{
						typeof(object).Assembly,
						typeof(럓).Assembly,
						typeof(럦).Assembly,
						typeof(랉).Assembly
					}).AddImports(new string[]
					{
						"System"
					});
					CSharpScript.RunAsync(A_0.럎(), options, null, null, default(CancellationToken)).GetAwaiter().GetResult();
					result = true;
				}
			}
			catch (CompilationErrorException ex)
			{
				A_2 = string.Join<Diagnostic>(Environment.NewLine, ex.Diagnostics);
				result = false;
			}
			catch (Exception ex2)
			{
				A_2 = ex2.ToString();
				result = false;
			}
			return result;
		}
	}
}
