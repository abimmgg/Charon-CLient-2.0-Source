using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using UnityEngine;

namespace CharonClient.Configuration
{
	// Token: 0x02000025 RID: 37
	public static class ConfigFile
	{
		// Token: 0x0600013E RID: 318 RVA: 0x0003D49D File Offset: 0x0003B69D
		[CompilerGenerated]
		public static string 랾()
		{
			return ConfigFile.<CurrentProfileName>k__BackingField;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0003D4A4 File Offset: 0x0003B6A4
		[CompilerGenerated]
		private static void 랾(string A_0)
		{
			ConfigFile.<CurrentProfileName>k__BackingField = A_0;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00074C14 File Offset: 0x00072E14
		private static HashSet<string> 럎()
		{
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (FieldInfo fieldInfo in ConfigFile.SettingFields)
			{
				if (fieldInfo.Name.StartsWith("ui", StringComparison.Ordinal))
				{
					hashSet.Add(fieldInfo.Name);
				}
			}
			hashSet.Add("selectedThemeIndex");
			hashSet.Add("defaultTheme");
			hashSet.Add("darkTheme");
			hashSet.Add("moonlightTheme");
			hashSet.Add("cinderTheme");
			hashSet.Add("catppuccinTheme");
			hashSet.Add("purpleTheme");
			hashSet.Add("redTheme");
			hashSet.Add("whiteDressTheme");
			hashSet.Add("blackDressTheme");
			return hashSet;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00074CE0 File Offset: 0x00072EE0
		private static HashSet<string> 람()
		{
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (string text in ConfigFile.UiSettingsFields)
			{
				if (!text.StartsWith("uiEsp", StringComparison.Ordinal) && !text.StartsWith("uiPath", StringComparison.Ordinal))
				{
					hashSet.Add(text);
				}
			}
			return hashSet;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00074D5C File Offset: 0x00072F5C
		private static HashSet<string> 럎(string A_0)
		{
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (FieldInfo fieldInfo in ConfigFile.SettingFields)
			{
				if (fieldInfo.Name.StartsWith(A_0, StringComparison.Ordinal))
				{
					hashSet.Add(fieldInfo.Name);
				}
			}
			return hashSet;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00074DAC File Offset: 0x00072FAC
		public static void 럒()
		{
			if (!File.Exists(ConfigFile.SettingsFilePath))
			{
				ConfigFile.럼();
				return;
			}
			try
			{
				ConfigFile.랾(JsonSerializer.Deserialize<JsonElement>(File.ReadAllText(ConfigFile.SettingsFilePath), null), null, null);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error loading settings: " + ex.Message);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00074E10 File Offset: 0x00073010
		public static void 럼()
		{
			try
			{
				string contents = JsonSerializer.Serialize<Dictionary<string, object>>(ConfigFile.랾(null, null), ConfigFile.JsonOptions);
				File.WriteAllText(ConfigFile.SettingsFilePath, contents);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error saving settings: " + ex.Message);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00074E64 File Offset: 0x00073064
		public static bool 람(string A_0)
		{
			string text = ConfigFile.랱(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			bool result;
			try
			{
				Directory.CreateDirectory(ConfigFile.ProfilesFolderPath);
				string path = ConfigFile.럭(text);
				string contents = JsonSerializer.Serialize<Dictionary<string, object>>(ConfigFile.랾(ConfigFile.GlobalOnlyFields, null), ConfigFile.JsonOptions);
				File.WriteAllText(path, contents);
				ConfigFile.랾(text);
				result = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error saving profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00074EEC File Offset: 0x000730EC
		public static bool 럒(string A_0)
		{
			string text = ConfigFile.랱(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			bool result;
			try
			{
				string path = ConfigFile.럭(text);
				if (!File.Exists(path))
				{
					result = false;
				}
				else
				{
					ConfigFile.랾(JsonSerializer.Deserialize<JsonElement>(File.ReadAllText(path), null), ConfigFile.GlobalOnlyFields, null);
					ConfigFile.랾(text);
					ConfigFile.럼();
					result = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error loading profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00074F78 File Offset: 0x00073178
		public static bool 럼(string A_0)
		{
			string text = ConfigFile.랱(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			bool result;
			try
			{
				string path = ConfigFile.럭(text);
				if (!File.Exists(path))
				{
					result = false;
				}
				else
				{
					File.Delete(path);
					if (string.Equals(ConfigFile.랾(), text, StringComparison.OrdinalIgnoreCase))
					{
						ConfigFile.랾("Default");
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error deleting profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00075000 File Offset: 0x00073200
		public static List<string> 랋()
		{
			List<string> result;
			try
			{
				Directory.CreateDirectory(ConfigFile.ProfilesFolderPath);
				IEnumerable<string> files = Directory.GetFiles(ConfigFile.ProfilesFolderPath, "*.json");
				Func<string, string> selector;
				if ((selector = ConfigFile.랾.랾) == null)
				{
					selector = (ConfigFile.랾.랾 = new Func<string, string>(Path.GetFileNameWithoutExtension));
				}
				result = files.Select(selector).Where(new Func<string, bool>(ConfigFile.럎.랾.랾)).OrderBy(new Func<string, string>(ConfigFile.럎.랾.럎), StringComparer.OrdinalIgnoreCase).ToList<string>();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error getting profiles: " + ex.Message);
				result = new List<string>();
			}
			return result;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000750CC File Offset: 0x000732CC
		private static void 랾(JsonElement A_0, HashSet<string> A_1 = null, HashSet<string> A_2 = null)
		{
			foreach (FieldInfo fieldInfo in ConfigFile.SettingFields)
			{
				JsonElement jsonElement;
				if ((A_1 == null || !A_1.Contains(fieldInfo.Name)) && (A_2 == null || A_2.Contains(fieldInfo.Name)) && A_0.TryGetProperty(fieldInfo.Name, out jsonElement))
				{
					try
					{
						if (fieldInfo.FieldType == typeof(bool))
						{
							fieldInfo.SetValue(null, jsonElement.GetBoolean());
						}
						else if (fieldInfo.FieldType == typeof(int))
						{
							fieldInfo.SetValue(null, jsonElement.GetInt32());
						}
						else if (fieldInfo.FieldType == typeof(float))
						{
							fieldInfo.SetValue(null, (float)jsonElement.GetDouble());
						}
						else if (fieldInfo.FieldType == typeof(string))
						{
							fieldInfo.SetValue(null, jsonElement.GetString() ?? string.Empty);
						}
						else if (fieldInfo.FieldType.IsEnum)
						{
							int value2;
							if (jsonElement.ValueKind == JsonValueKind.String)
							{
								string @string = jsonElement.GetString();
								object value;
								if (!string.IsNullOrWhiteSpace(@string) && Enum.TryParse(fieldInfo.FieldType, @string, true, out value))
								{
									fieldInfo.SetValue(null, value);
								}
							}
							else if (jsonElement.ValueKind == JsonValueKind.Number && jsonElement.TryGetInt32(out value2))
							{
								fieldInfo.SetValue(null, Enum.ToObject(fieldInfo.FieldType, value2));
							}
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error loading setting '" + fieldInfo.Name + "': " + ex.Message);
					}
				}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000752A8 File Offset: 0x000734A8
		private static Dictionary<string, object> 랾(HashSet<string> A_0 = null, HashSet<string> A_1 = null)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (FieldInfo fieldInfo in ConfigFile.SettingFields)
			{
				if ((A_0 == null || !A_0.Contains(fieldInfo.Name)) && (A_1 == null || A_1.Contains(fieldInfo.Name)))
				{
					object value = fieldInfo.GetValue(null);
					dictionary[fieldInfo.Name] = (fieldInfo.FieldType.IsEnum ? (((value != null) ? value.ToString() : null) ?? string.Empty) : value);
				}
			}
			return dictionary;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0003D4AC File Offset: 0x0003B6AC
		public static bool 랾(out string A_0)
		{
			return ConfigFile.랾(ConfigFile.UiSettingsFields, out A_0, "UI settings");
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0003D4BE File Offset: 0x0003B6BE
		public static bool 랋(string A_0)
		{
			return ConfigFile.랾(A_0, ConfigFile.UiSettingsFields, "UI settings");
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0003D4D0 File Offset: 0x0003B6D0
		public static bool 럎(out string A_0)
		{
			return ConfigFile.랾(ConfigFile.UiStyleSettingsFields, out A_0, "UI style settings");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0003D4E2 File Offset: 0x0003B6E2
		public static bool 랉(string A_0)
		{
			return ConfigFile.랾(A_0, ConfigFile.UiStyleSettingsFields, "UI style settings");
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0003D4F4 File Offset: 0x0003B6F4
		public static bool 람(out string A_0)
		{
			return ConfigFile.랾(ConfigFile.UiEspSettingsFields, out A_0, "ESP UI settings");
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0003D506 File Offset: 0x0003B706
		public static bool 럐(string A_0)
		{
			return ConfigFile.랾(A_0, ConfigFile.UiEspSettingsFields, "ESP UI settings");
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0003D518 File Offset: 0x0003B718
		public static bool 럒(out string A_0)
		{
			return ConfigFile.랾(ConfigFile.UiPathSettingsFields, out A_0, "path UI settings");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0003D52A File Offset: 0x0003B72A
		public static bool 랓(string A_0)
		{
			return ConfigFile.랾(A_0, ConfigFile.UiPathSettingsFields, "path UI settings");
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0003D53C File Offset: 0x0003B73C
		public static bool 럼(out string A_0)
		{
			return ConfigFile.랾(ConfigFile.UiToastSettingsFields, out A_0, "notification UI settings");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0003D54E File Offset: 0x0003B74E
		public static bool 럯(string A_0)
		{
			return ConfigFile.랾(A_0, ConfigFile.UiToastSettingsFields, "notification UI settings");
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00075338 File Offset: 0x00073538
		private static bool 랾(HashSet<string> A_0, out string A_1, string A_2)
		{
			A_1 = string.Empty;
			bool result;
			try
			{
				A_1 = JsonSerializer.Serialize<Dictionary<string, object>>(ConfigFile.랾(null, A_0), ConfigFile.JsonOptions);
				result = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error exporting " + A_2 + ": " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00075394 File Offset: 0x00073594
		private static bool 랾(string A_0, HashSet<string> A_1, string A_2)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			bool result;
			try
			{
				Dictionary<string, JsonElement> dictionary = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(A_0, null);
				if (dictionary == null || dictionary.Count == 0)
				{
					result = false;
				}
				else
				{
					Dictionary<string, JsonElement> dictionary2 = new Dictionary<string, JsonElement>(StringComparer.OrdinalIgnoreCase);
					foreach (KeyValuePair<string, JsonElement> keyValuePair in dictionary)
					{
						string text;
						JsonElement jsonElement;
						keyValuePair.Deconstruct(out text, out jsonElement);
						string text2 = text;
						JsonElement value = jsonElement;
						if (A_1.Contains(text2))
						{
							dictionary2[text2] = value;
						}
					}
					if (dictionary2.Count == 0)
					{
						result = false;
					}
					else
					{
						ConfigFile.랾(JsonSerializer.Deserialize<JsonElement>(JsonSerializer.Serialize<Dictionary<string, JsonElement>>(dictionary2, ConfigFile.JsonOptions), null), null, A_1);
						ConfigFile.럼();
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error importing " + A_2 + ": " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0003D560 File Offset: 0x0003B760
		private static string 럭(string A_0)
		{
			return Path.Combine(ConfigFile.ProfilesFolderPath, A_0 + ".json");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00075490 File Offset: 0x00073690
		private static string 랱(string A_0)
		{
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return string.Empty;
			}
			string text = A_0.Trim();
			foreach (char oldChar in Path.GetInvalidFileNameChars())
			{
				text = text.Replace(oldChar, '_');
			}
			return text;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000754D8 File Offset: 0x000736D8
		public static bool 랾(string A_0, out string A_1)
		{
			A_1 = string.Empty;
			string text = ConfigFile.랱(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			bool result;
			try
			{
				string path = ConfigFile.럭(text);
				if (!File.Exists(path))
				{
					result = false;
				}
				else
				{
					Dictionary<string, JsonElement> dictionary = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(File.ReadAllText(path), null);
					if (dictionary == null || dictionary.Count == 0)
					{
						result = false;
					}
					else
					{
						foreach (string key in ConfigFile.GlobalOnlyFields)
						{
							dictionary.Remove(key);
						}
						A_1 = JsonSerializer.Serialize<Dictionary<string, JsonElement>>(dictionary, ConfigFile.JsonOptions);
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error exporting profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000755BC File Offset: 0x000737BC
		public static bool 랾(string A_0, string A_1)
		{
			string text = ConfigFile.랱(A_0);
			if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(A_1))
			{
				return false;
			}
			bool result;
			try
			{
				Directory.CreateDirectory(ConfigFile.ProfilesFolderPath);
				Dictionary<string, JsonElement> dictionary = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(A_1, null);
				if (dictionary == null || dictionary.Count == 0)
				{
					result = false;
				}
				else
				{
					foreach (string key in ConfigFile.GlobalOnlyFields)
					{
						dictionary.Remove(key);
					}
					string contents = JsonSerializer.Serialize<Dictionary<string, JsonElement>>(dictionary, ConfigFile.JsonOptions);
					File.WriteAllText(ConfigFile.럭(text), contents);
					result = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error importing profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0007569C File Offset: 0x0007389C
		public static bool 럎(string A_0, string A_1)
		{
			string text = ConfigFile.랱(A_0);
			string text2 = ConfigFile.랱(A_1);
			if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(text2))
			{
				return false;
			}
			if (string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			bool result;
			try
			{
				string text3 = ConfigFile.럭(text);
				string text4 = ConfigFile.럭(text2);
				if (!File.Exists(text3) || File.Exists(text4))
				{
					result = false;
				}
				else
				{
					File.Move(text3, text4);
					if (string.Equals(ConfigFile.랾(), text, StringComparison.OrdinalIgnoreCase))
					{
						ConfigFile.랾(text2);
					}
					if (string.Equals(ConfigFile.startupProfileName, text, StringComparison.OrdinalIgnoreCase))
					{
						ConfigFile.startupProfileName = text2;
					}
					ConfigFile.럼();
					result = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error renaming profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00075768 File Offset: 0x00073968
		public static bool 람(string A_0, string A_1)
		{
			string text = ConfigFile.랱(A_0);
			string text2 = ConfigFile.랱(A_1);
			if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(text2))
			{
				return false;
			}
			if (string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			bool result;
			try
			{
				Directory.CreateDirectory(ConfigFile.ProfilesFolderPath);
				string path = ConfigFile.럭(text);
				string path2 = ConfigFile.럭(text2);
				if (!File.Exists(path) || File.Exists(path2))
				{
					result = false;
				}
				else
				{
					Dictionary<string, JsonElement> dictionary = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(File.ReadAllText(path), null);
					if (dictionary == null || dictionary.Count == 0)
					{
						result = false;
					}
					else
					{
						foreach (string key in ConfigFile.GlobalOnlyFields)
						{
							dictionary.Remove(key);
						}
						string contents = JsonSerializer.Serialize<Dictionary<string, JsonElement>>(dictionary, ConfigFile.JsonOptions);
						File.WriteAllText(path2, contents);
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error duplicating profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0007588C File Offset: 0x00073A8C
		public static bool 럙(string A_0)
		{
			string text = ConfigFile.랱(A_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			bool result;
			try
			{
				if (!File.Exists(ConfigFile.럭(text)))
				{
					result = false;
				}
				else
				{
					ConfigFile.startupProfileName = text;
					ConfigFile.럼();
					result = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error setting startup profile '" + A_0 + "': " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0003D577 File Offset: 0x0003B777
		public static void 랉()
		{
			ConfigFile.startupProfileName = string.Empty;
			ConfigFile.럼();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0003D588 File Offset: 0x0003B788
		public static bool 럐()
		{
			return !string.IsNullOrWhiteSpace(ConfigFile.startupProfileName) && ConfigFile.럒(ConfigFile.startupProfileName);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000758FC File Offset: 0x00073AFC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigFile()
		{
			ConfigFile.<CurrentProfileName>k__BackingField = "Default";
			ConfigFile.startupProfileName = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
			ConfigFile.SettingsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CharonClientSettings.json");
			ConfigFile.ProfilesFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CharonClientProfiles");
			ConfigFile.JsonOptions = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			ConfigFile.SettingFields = typeof(ConfigFile).GetFields(BindingFlags.Static | BindingFlags.Public).Where(new Func<FieldInfo, bool>(ConfigFile.럎.랾.랾)).ToArray<FieldInfo>();
			ConfigFile.UiSettingsFields = ConfigFile.럎();
			ConfigFile.UiStyleSettingsFields = ConfigFile.람();
			ConfigFile.UiEspSettingsFields = ConfigFile.럎("uiEsp");
			ConfigFile.UiPathSettingsFields = ConfigFile.럎("uiPath");
			ConfigFile.UiToastSettingsFields = ConfigFile.럎("uiToast");
			ConfigFile.GlobalOnlyFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
			{
				"menuToggleKey",
				"teleportCancelKey",
				"modDetectedWebhookLink",
				"autoFishWebhookLink",
				"chatCommandFavorites",
				"packetManipulatorRules",
				"developerSightingCooldownSeconds",
				"modAndAdminSightingPollSeconds",
				"reportModAndAdminSightingsToggle",
				"clientRelayChatPollSeconds",
				"clientRelayChatToggle",
				"clientRelayChatDisplayName"
			};
		}

		// Token: 0x04000070 RID: 112
		public static bool hasCompletedGuidedSetup = false;

		// Token: 0x04000071 RID: 113
		public static string welcomeName = "Charon";

		// Token: 0x04000072 RID: 114
		public static string customPlayerNameValue = "<color=blue>Xorry (Blue T-Shirt)";

		// Token: 0x04000073 RID: 115
		public static string rpcPlayerName = "White Dress";

		// Token: 0x04000074 RID: 116
		public static string rpcWorldName = "Black Dress";

		// Token: 0x04000075 RID: 117
		public static string modDetectedWebhookLink = "Mod Detector Endpoint URL/Webhook";

		// Token: 0x04000076 RID: 118
		public static string autoFishWebhookLink = "Autofish Endpoint URL/Webhook";

		// Token: 0x04000077 RID: 119
		public static string clientRelayChatDisplayName = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000078 RID: 120
		public static int selectedAlbumIndex = 0;

		// Token: 0x04000079 RID: 121
		public static int developerSightingCooldownSeconds = 180;

		// Token: 0x0400007A RID: 122
		public static int modAndAdminSightingPollSeconds = 180;

		// Token: 0x0400007B RID: 123
		public static int clientRelayChatPollSeconds = 30;

		// Token: 0x0400007C RID: 124
		public static int autoNetherScrollLevel = 0;

		// Token: 0x0400007D RID: 125
		public static int autoNetherEntryMode = 0;

		// Token: 0x0400007E RID: 126
		public static bool abandonNetherPlayersToggle = false;

		// Token: 0x0400007F RID: 127
		public static bool leaveUponSummon = false;

		// Token: 0x04000080 RID: 128
		public static bool antiAFKToggle = true;

		// Token: 0x04000081 RID: 129
		public static bool antiPoisonToggle = false;

		// Token: 0x04000082 RID: 130
		public static bool teleportToggle = true;

		// Token: 0x04000083 RID: 131
		public static bool showTeleportPathToggle = true;

		// Token: 0x04000084 RID: 132
		public static bool alwaysShowTeleportPath = true;

		// Token: 0x04000085 RID: 133
		public static bool airResistanceToggle;

		// Token: 0x04000086 RID: 134
		public static bool aimbotPVEToggle;

		// Token: 0x04000087 RID: 135
		public static bool aimbotToggle;

		// Token: 0x04000088 RID: 136
		public static bool antiBlockKillToggle;

		// Token: 0x04000089 RID: 137
		public static bool antiBounceToggle = false;

		// Token: 0x0400008A RID: 138
		public static bool antiCheckPointToggle;

		// Token: 0x0400008B RID: 139
		public static bool antiDarknessToggle = true;

		// Token: 0x0400008C RID: 140
		public static bool antiDeflectorToggle;

		// Token: 0x0400008D RID: 141
		public static bool antiElevatorToggle;

		// Token: 0x0400008E RID: 142
		public static bool antiFanToggle;

		// Token: 0x0400008F RID: 143
		public static bool antiKnockbackToggle;

		// Token: 0x04000090 RID: 144
		public static bool antiPortalToggle;

		// Token: 0x04000091 RID: 145
		public static bool antiTriggerWiringToggle;

		// Token: 0x04000092 RID: 146
		public static bool autoLeaveToggle;

		// Token: 0x04000093 RID: 147
		public static bool clickToBan;

		// Token: 0x04000094 RID: 148
		public static bool clickToKick;

		// Token: 0x04000095 RID: 149
		public static bool clickToSummon;

		// Token: 0x04000096 RID: 150
		public static bool customPlayerName = true;

		// Token: 0x04000097 RID: 151
		public static bool extendedPickUpToggle;

		// Token: 0x04000098 RID: 152
		public static bool fastRespawnToggle;

		// Token: 0x04000099 RID: 153
		public static bool freeCamToggle;

		// Token: 0x0400009A RID: 154
		public static bool fullAccessToggle;

		// Token: 0x0400009B RID: 155
		public static bool godModeToggle;

		// Token: 0x0400009C RID: 156
		public static bool ghostLagToggle;

		// Token: 0x0400009D RID: 157
		public static bool increasedRunSpeedToggle;

		// Token: 0x0400009E RID: 158
		public static bool increasedHitSpeedToggle;

		// Token: 0x0400009F RID: 159
		public static bool infiniteJumps;

		// Token: 0x040000A0 RID: 160
		public static bool openPouchSpam;

		// Token: 0x040000A1 RID: 161
		public static bool placeBlocksOnPlayersToggle;

		// Token: 0x040000A2 RID: 162
		public static bool unlimitedOxygenToggle;

		// Token: 0x040000A3 RID: 163
		public static bool defaultTheme;

		// Token: 0x040000A4 RID: 164
		public static bool darkTheme;

		// Token: 0x040000A5 RID: 165
		public static bool moonlightTheme;

		// Token: 0x040000A6 RID: 166
		public static bool cinderTheme;

		// Token: 0x040000A7 RID: 167
		public static bool catppuccinTheme;

		// Token: 0x040000A8 RID: 168
		public static bool purpleTheme;

		// Token: 0x040000A9 RID: 169
		public static bool redTheme;

		// Token: 0x040000AA RID: 170
		public static bool whiteDressTheme = true;

		// Token: 0x040000AB RID: 171
		public static bool blackDressTheme;

		// Token: 0x040000AC RID: 172
		public static bool alwaysShowToolTipToggle;

		// Token: 0x040000AD RID: 173
		public static KeyCode menuToggleKey = 283;

		// Token: 0x040000AE RID: 174
		public static bool notificationConsoleToggle;

		// Token: 0x040000AF RID: 175
		public static bool showNotifications = true;

		// Token: 0x040000B0 RID: 176
		public static bool modAndAdminNotifications = true;

		// Token: 0x040000B1 RID: 177
		public static bool showTeleportNotifications = true;

		// Token: 0x040000B2 RID: 178
		public static bool webhookModDetectToggle = false;

		// Token: 0x040000B3 RID: 179
		public static KeyCode teleportCancelKey = 0;

		// Token: 0x040000B4 RID: 180
		public static bool packetManipulatorNotifications = true;

		// Token: 0x040000B5 RID: 181
		public static bool packetManipulatorRememberRules = true;

		// Token: 0x040000B6 RID: 182
		public static string packetManipulatorRules = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x040000B7 RID: 183
		public static bool showModAndAdminConsole = false;

		// Token: 0x040000B8 RID: 184
		public static string chatCommandFavorites = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x040000B9 RID: 185
		public static bool discordRPCToggle = true;

		// Token: 0x040000BA RID: 186
		public static bool ShowRPCPlayerName = false;

		// Token: 0x040000BB RID: 187
		public static bool ShowRPCPlayerWorld = false;

		// Token: 0x040000BC RID: 188
		public static bool ShowRPCPlayerCount = false;

		// Token: 0x040000BD RID: 189
		public static int RPCPlayerCount = 50;

		// Token: 0x040000BE RID: 190
		public static string RPCImage = "white_dress";

		// Token: 0x040000BF RID: 191
		public static bool OriginalRPCThemeToggle = false;

		// Token: 0x040000C0 RID: 192
		public static float freeCamSpeed = 0.1f;

		// Token: 0x040000C1 RID: 193
		public static float flySpeed = 5f;

		// Token: 0x040000C2 RID: 194
		public static float pvpAimbotInterval = 0.16f;

		// Token: 0x040000C3 RID: 195
		public static float pveAimbotInterval = 0.15f;

		// Token: 0x040000C4 RID: 196
		public static bool autoNetherTargetTreasure = true;

		// Token: 0x040000C5 RID: 197
		public static bool autoNetherTargetGiftBoxes = true;

		// Token: 0x040000C6 RID: 198
		public static bool instantTeleportToggle = false;

		// Token: 0x040000C7 RID: 199
		public static bool ghostTeleportToggle = true;

		// Token: 0x040000C8 RID: 200
		public static bool groundedPathfindingToggle = true;

		// Token: 0x040000C9 RID: 201
		public static bool teleportEffectToggle = false;

		// Token: 0x040000CA RID: 202
		public static bool extendedGhostTPToggle = false;

		// Token: 0x040000CB RID: 203
		public static float AutoMiningTeleportSpeedThreshold = 0.275f;

		// Token: 0x040000CC RID: 204
		public static float DefaultTeleportSpeedThreshold = 0.1f;

		// Token: 0x040000CD RID: 205
		public static float TeleportSpeed = 0.175f;

		// Token: 0x040000CE RID: 206
		public static float LegitTeleportMoveSpeed = 2.35f;

		// Token: 0x040000CF RID: 207
		public static int teleportChunkAmount = 1;

		// Token: 0x040000D0 RID: 208
		public static int selectedThemeIndex = 7;

		// Token: 0x040000D1 RID: 209
		public static bool showMenu = true;

		// Token: 0x040000D2 RID: 210
		public static bool packetConsole = false;

		// Token: 0x040000D3 RID: 211
		public static bool showPlayerButtons = false;

		// Token: 0x040000D4 RID: 212
		public static bool uiCustomAccentEnabled = false;

		// Token: 0x040000D5 RID: 213
		public static string uiAccentColor = "#D9D1C7FF";

		// Token: 0x040000D6 RID: 214
		public static bool uiCustomBackgroundEnabled = false;

		// Token: 0x040000D7 RID: 215
		public static string uiBackgroundColor = "#111010F2";

		// Token: 0x040000D8 RID: 216
		public static bool uiCustomShapeEnabled = false;

		// Token: 0x040000D9 RID: 217
		public static float uiGlobalScale = 1f;

		// Token: 0x040000DA RID: 218
		public static bool uiCustomOpacityEnabled = false;

		// Token: 0x040000DB RID: 219
		public static float uiGlobalAlpha = 1f;

		// Token: 0x040000DC RID: 220
		public static bool uiEnhancedSurfacesEnabled = false;

		// Token: 0x040000DD RID: 221
		public static float uiPanelLift = 0.06f;

		// Token: 0x040000DE RID: 222
		public static float uiPanelBorderStrength = 0.35f;

		// Token: 0x040000DF RID: 223
		public static bool uiPillTabsEnabled = false;

		// Token: 0x040000E0 RID: 224
		public static bool uiSectionAccentEnabled = true;

		// Token: 0x040000E1 RID: 225
		public static float uiSectionAccentThickness = 2f;

		// Token: 0x040000E2 RID: 226
		public static float uiSectionAccentLength = 0.45f;

		// Token: 0x040000E3 RID: 227
		public static float uiLayoutSpacingScale = 1f;

		// Token: 0x040000E4 RID: 228
		public static float uiWindowPaddingScale = 1f;

		// Token: 0x040000E5 RID: 229
		public static bool uiWindowGlowEnabled = false;

		// Token: 0x040000E6 RID: 230
		public static float uiWindowGlowStrength = 0.22f;

		// Token: 0x040000E7 RID: 231
		public static float uiWindowRounding = 4f;

		// Token: 0x040000E8 RID: 232
		public static float uiFrameRounding = 3f;

		// Token: 0x040000E9 RID: 233
		public static float uiChildRounding = 3f;

		// Token: 0x040000EA RID: 234
		public static float uiTabRounding = 3f;

		// Token: 0x040000EB RID: 235
		public static bool uiOpenAnimationEnabled = true;

		// Token: 0x040000EC RID: 236
		public static float uiOpenAnimationDuration = 0.5f;

		// Token: 0x040000ED RID: 237
		public static float uiOpenAnimationStartScale = 0.94f;

		// Token: 0x040000EE RID: 238
		public static float uiOpenAnimationOffset = 18f;

		// Token: 0x040000EF RID: 239
		public static int uiPathLineStyle = 0;

		// Token: 0x040000F0 RID: 240
		public static float uiPathLineThicknessScale = 1f;

		// Token: 0x040000F1 RID: 241
		public static float uiPathDashLength = 14f;

		// Token: 0x040000F2 RID: 242
		public static float uiPathGapLength = 8f;

		// Token: 0x040000F3 RID: 243
		public static string uiPathHoverColor = "#59D9FFCC";

		// Token: 0x040000F4 RID: 244
		public static string uiPathTeleportColor = "#59D9FFF2";

		// Token: 0x040000F5 RID: 245
		public static string uiPathMiningColor = "#FFA629CC";

		// Token: 0x040000F6 RID: 246
		public static string uiPathReachableColor = "#33FF73F2";

		// Token: 0x040000F7 RID: 247
		public static string uiPathBreakTargetColor = "#FF75D7FA";

		// Token: 0x040000F8 RID: 248
		public static string uiEspPlayerColor = "#33FF66FF";

		// Token: 0x040000F9 RID: 249
		public static string uiEspEnemyColor = "#FF4D4DFF";

		// Token: 0x040000FA RID: 250
		public static bool uiEspStaffRainbow = true;

		// Token: 0x040000FB RID: 251
		public static string uiEspStaffColor = "#FF4DE6FF";

		// Token: 0x040000FC RID: 252
		public static string uiEspCollectableColor = "#338DFFFF";

		// Token: 0x040000FD RID: 253
		public static string uiEspGiftBoxColor = "#FFD93DFF";

		// Token: 0x040000FE RID: 254
		public static string uiEspOreColor = "#FFFFFFFF";

		// Token: 0x040000FF RID: 255
		public static string uiEspPortalUnlockedColor = "#37D65CFF";

		// Token: 0x04000100 RID: 256
		public static string uiEspPortalLockedColor = "#FF4F4FFF";

		// Token: 0x04000101 RID: 257
		public static string uiEspButterflyColor = "#FFE03DFF";

		// Token: 0x04000102 RID: 258
		public static string uiEspEventColor = "#FF4DE6FF";

		// Token: 0x04000103 RID: 259
		public static string uiEspNetherBossColor = "#FFE03DFF";

		// Token: 0x04000104 RID: 260
		public static string uiEspNetherKeyColor = "#FFD93DFF";

		// Token: 0x04000105 RID: 261
		public static string uiEspNetherExitColor = "#FF8C1AFF";

		// Token: 0x04000106 RID: 262
		public static string uiEspSwordColor = "#101010FF";

		// Token: 0x04000107 RID: 263
		public static string uiEspCrossBreedColor = "#33FF8CFF";

		// Token: 0x04000108 RID: 264
		public static string uiEspCrossBreedNewColor = "#FFCC33FF";

		// Token: 0x04000109 RID: 265
		public static float uiToastWidth = 430f;

		// Token: 0x0400010A RID: 266
		public static float uiToastMinHeight = 88f;

		// Token: 0x0400010B RID: 267
		public static float uiToastSpacing = 10f;

		// Token: 0x0400010C RID: 268
		public static float uiToastOffsetX = 18f;

		// Token: 0x0400010D RID: 269
		public static float uiToastOffsetY = 16f;

		// Token: 0x0400010E RID: 270
		public static float uiToastTitleScale = 1.05f;

		// Token: 0x0400010F RID: 271
		public static float uiToastMessageScale = 0.93f;

		// Token: 0x04000110 RID: 272
		public static float uiToastRounding = 16f;

		// Token: 0x04000111 RID: 273
		public static float uiToastBorderThickness = 1.2f;

		// Token: 0x04000112 RID: 274
		public static float uiToastAccentBarWidth = 4f;

		// Token: 0x04000113 RID: 275
		public static float uiToastGlowStrength = 0.24f;

		// Token: 0x04000114 RID: 276
		public static string uiToastBackgroundColor = "#121720F2";

		// Token: 0x04000115 RID: 277
		public static string uiToastTitleColor = "#F4F7FFFF";

		// Token: 0x04000116 RID: 278
		public static string uiToastMessageColor = "#AFC0D9FF";

		// Token: 0x04000117 RID: 279
		public static string uiToastInfoColor = "#66BEFFFF";

		// Token: 0x04000118 RID: 280
		public static string uiToastSuccessColor = "#57E2A5FF";

		// Token: 0x04000119 RID: 281
		public static string uiToastWarningColor = "#FFC96BFF";

		// Token: 0x0400011A RID: 282
		public static string uiToastErrorColor = "#FF6B8DFF";

		// Token: 0x0400011B RID: 283
		public static bool enableChatCommandsToggle = true;

		// Token: 0x0400011C RID: 284
		public static bool chatLoggerToggle = false;

		// Token: 0x0400011D RID: 285
		public static bool flyToggle = true;

		// Token: 0x0400011E RID: 286
		public static bool fakeLagToggle = false;

		// Token: 0x0400011F RID: 287
		public static bool infiniteJetpackFuel = true;

		// Token: 0x04000120 RID: 288
		public static bool alternativeFlyHotkeysToggle = false;

		// Token: 0x04000121 RID: 289
		public static bool loginByTokenToggle = false;

		// Token: 0x04000122 RID: 290
		public static bool zoomHackToggle = false;

		// Token: 0x04000123 RID: 291
		public static float zoomValue = 2f;

		// Token: 0x04000124 RID: 292
		public static bool autoBanToggle = false;

		// Token: 0x04000125 RID: 293
		public static bool autoBanFullAccess = false;

		// Token: 0x04000126 RID: 294
		public static bool autoBanMinorAccess = false;

		// Token: 0x04000127 RID: 295
		public static bool autoKickToggle = false;

		// Token: 0x04000128 RID: 296
		public static bool autoKickFullAccess = false;

		// Token: 0x04000129 RID: 297
		public static bool autoKickMinorAccess = false;

		// Token: 0x0400012A RID: 298
		public static bool autoBuyMissingLockToggle = true;

		// Token: 0x0400012B RID: 299
		public static bool autoGiftBoxPickupToggle = false;

		// Token: 0x0400012C RID: 300
		public static bool autoHarvestGrownSeedsToggle = false;

		// Token: 0x0400012D RID: 301
		public static bool autoPlantSeedsToggle = false;

		// Token: 0x0400012E RID: 302
		public static int autoPlantSelectedSeedBlockType = -1;

		// Token: 0x0400012F RID: 303
		public static int autoPlaceLockTypeIndex = 3;

		// Token: 0x04000130 RID: 304
		public static bool optimizeWorldToggle = true;

		// Token: 0x04000131 RID: 305
		public static bool placeSeedsAnywhereToggle = false;

		// Token: 0x04000132 RID: 306
		public static string rejoinWorldName = "PIXELSTATION";

		// Token: 0x04000133 RID: 307
		public static string autoFishRejoinWorldName = "ROD";

		// Token: 0x04000134 RID: 308
		public static string autoFishRejoinEntryPointId = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000135 RID: 309
		public static string autoFishReturnSpotWorldName = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000136 RID: 310
		public static string autoNetherSelectedPortalWorldName = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000137 RID: 311
		public static float autoMineTeleportTimerMax = 0.5f;

		// Token: 0x04000138 RID: 312
		public static float autoMineBreakTimerMax = 0.3f;

		// Token: 0x04000139 RID: 313
		public static float autoFarmerHitInterval = 0.8f;

		// Token: 0x0400013A RID: 314
		public static float autoFarmerPlaceDelay = 0.3f;

		// Token: 0x0400013B RID: 315
		public static float autoFarmerStorageTransferDelay = 0.35f;

		// Token: 0x0400013C RID: 316
		public static float autoNetherEntryDelaySeconds = 5f;

		// Token: 0x0400013D RID: 317
		public static float autoNetherTeleportDelaySeconds = 6f;

		// Token: 0x0400013E RID: 318
		public static float autoNetherPortalStepDelaySeconds = 0.35f;

		// Token: 0x0400013F RID: 319
		public static bool MineLevel1 = true;

		// Token: 0x04000140 RID: 320
		public static bool MineLevel2 = true;

		// Token: 0x04000141 RID: 321
		public static bool MineLevel3 = true;

		// Token: 0x04000142 RID: 322
		public static bool MineLevel4 = true;

		// Token: 0x04000143 RID: 323
		public static bool autoConvert = true;

		// Token: 0x04000144 RID: 324
		public static bool LegitimateAutoFish = true;

		// Token: 0x04000145 RID: 325
		public static bool autoFishRecastDelayEnabled = true;

		// Token: 0x04000146 RID: 326
		public static float autoFishRecastDelayMinSeconds = 0.45f;

		// Token: 0x04000147 RID: 327
		public static float autoFishRecastDelayMaxSeconds = 1.1f;

		// Token: 0x04000148 RID: 328
		public static bool autoFishHookDelayEnabled = false;

		// Token: 0x04000149 RID: 329
		public static float autoFishHookDelayMinSeconds = 0.08f;

		// Token: 0x0400014A RID: 330
		public static float autoFishHookDelayMaxSeconds = 0.22f;

		// Token: 0x0400014B RID: 331
		public static bool autoFishLandDelayEnabled = false;

		// Token: 0x0400014C RID: 332
		public static float autoFishLandDelayMinSeconds = 0.1f;

		// Token: 0x0400014D RID: 333
		public static float autoFishLandDelayMaxSeconds = 0.25f;

		// Token: 0x0400014E RID: 334
		public static float autoFishLegitPauseDelayMinSeconds = 20f;

		// Token: 0x0400014F RID: 335
		public static float autoFishLegitPauseDelayMaxSeconds = 40f;

		// Token: 0x04000150 RID: 336
		public static float autoFishLegitPauseDurationMinSeconds = 4f;

		// Token: 0x04000151 RID: 337
		public static float autoFishLegitPauseDurationMaxSeconds = 7.5f;

		// Token: 0x04000152 RID: 338
		public static int autoFishWebhookFishCount = 25;

		// Token: 0x04000153 RID: 339
		public static bool autoFishReturnToSpotAfterRejoin = false;

		// Token: 0x04000154 RID: 340
		public static bool autoFarmerFarmAbove = true;

		// Token: 0x04000155 RID: 341
		public static bool autoFarmerFarmBelow = true;

		// Token: 0x04000156 RID: 342
		public static bool autoFarmerFarmLeft = true;

		// Token: 0x04000157 RID: 343
		public static bool autoFarmerFarmRight = true;

		// Token: 0x04000158 RID: 344
		public static bool autoFarmerFarmDiagonals = true;

		// Token: 0x04000159 RID: 345
		public static bool autoFarmerUseRefillStorage = true;

		// Token: 0x0400015A RID: 346
		public static bool autoFarmerUseOutputStorage = true;

		// Token: 0x0400015B RID: 347
		public static int autoFarmerSelectedBlockType = -1;

		// Token: 0x0400015C RID: 348
		public static int autoFarmerRoundsBeforeCollect = 10;

		// Token: 0x0400015D RID: 349
		public static int autoFarmerRefillWhenBlockCountAtOrBelow = 25;

		// Token: 0x0400015E RID: 350
		public static int autoFarmerKeepBlockCountDuringDump = 50;

		// Token: 0x0400015F RID: 351
		public static int autoFarmerDumpWhenInventorySlotsAtOrAbove = 170;

		// Token: 0x04000160 RID: 352
		public static string autoFarmerRefillStorageWorldName = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000161 RID: 353
		public static int autoFarmerRefillStorageX = -1;

		// Token: 0x04000162 RID: 354
		public static int autoFarmerRefillStorageY = -1;

		// Token: 0x04000163 RID: 355
		public static string autoFarmerOutputStorageWorldName = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000164 RID: 356
		public static int autoFarmerOutputStorageX = -1;

		// Token: 0x04000165 RID: 357
		public static int autoFarmerOutputStorageY = -1;

		// Token: 0x04000166 RID: 358
		public static string autoFarmerPriorityBlockTypes = E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();

		// Token: 0x04000167 RID: 359
		public static int autoFishReturnSpotX = -1;

		// Token: 0x04000168 RID: 360
		public static int autoFishReturnSpotY = -1;

		// Token: 0x04000169 RID: 361
		public static int autoNetherSelectedPortalX = -1;

		// Token: 0x0400016A RID: 362
		public static int autoNetherSelectedPortalY = -1;

		// Token: 0x0400016B RID: 363
		public static bool playerESPTracer = false;

		// Token: 0x0400016C RID: 364
		public static bool playerESPBox = false;

		// Token: 0x0400016D RID: 365
		public static bool enemyESPTracer = false;

		// Token: 0x0400016E RID: 366
		public static bool enemyESPBox = false;

		// Token: 0x0400016F RID: 367
		public static bool collectableESPTracer = false;

		// Token: 0x04000170 RID: 368
		public static bool collectableESPBox = false;

		// Token: 0x04000171 RID: 369
		public static bool butterflyESPTracer = false;

		// Token: 0x04000172 RID: 370
		public static bool modESPTracers = false;

		// Token: 0x04000173 RID: 371
		public static bool modESPBox = false;

		// Token: 0x04000174 RID: 372
		public static bool blueParticleESPToggle = false;

		// Token: 0x04000175 RID: 373
		public static bool eggESPToggle = false;

		// Token: 0x04000176 RID: 374
		public static bool giftBoxESPToggle = false;

		// Token: 0x04000177 RID: 375
		public static bool giftBoxESPUntakenOnly = false;

		// Token: 0x04000178 RID: 376
		public static bool netherBossESPToggle = false;

		// Token: 0x04000179 RID: 377
		public static bool netherExitESPToggle = false;

		// Token: 0x0400017A RID: 378
		public static bool netherKeyESPToggle = false;

		// Token: 0x0400017B RID: 379
		public static bool portalESPToggle = false;

		// Token: 0x0400017C RID: 380
		public static bool oreESPToggle = false;

		// Token: 0x0400017D RID: 381
		public static bool swordInTheStoneTracerToggle = false;

		// Token: 0x0400017E RID: 382
		public static bool valentineHeartESPToggle = false;

		// Token: 0x0400017F RID: 383
		public static bool crossBreedSeedEspToggle = false;

		// Token: 0x04000180 RID: 384
		public static bool crossBreedSeedEspNewRecipesOnly = false;

		// Token: 0x04000181 RID: 385
		public static bool antiTrapCrash = true;

		// Token: 0x04000182 RID: 386
		public static bool antiTextCrash = true;

		// Token: 0x04000183 RID: 387
		public static bool antiWiringCrash = true;

		// Token: 0x04000184 RID: 388
		public static bool antiCensorToggle = true;

		// Token: 0x04000185 RID: 389
		public static bool antiSummonToggle = false;

		// Token: 0x04000186 RID: 390
		public static bool cheaterDetectorToggle = true;

		// Token: 0x04000187 RID: 391
		public static bool botDetectorToggle = true;

		// Token: 0x04000188 RID: 392
		public static bool showMiniMapToggle = false;

		// Token: 0x04000189 RID: 393
		public static bool renderWorldToggle = true;

		// Token: 0x0400018A RID: 394
		public static bool renderPlayersToggle = true;

		// Token: 0x0400018B RID: 395
		public static bool renderEnemiesToggle = true;

		// Token: 0x0400018C RID: 396
		public static bool renderCollectablesToggle = true;

		// Token: 0x0400018D RID: 397
		public static bool durabilityChangerToggle = false;

		// Token: 0x0400018E RID: 398
		public static bool petDataToggle = false;

		// Token: 0x0400018F RID: 399
		public static bool bottleDataToggle = false;

		// Token: 0x04000190 RID: 400
		public static bool fishTrophyDataToggle = false;

		// Token: 0x04000191 RID: 401
		public static bool trophyDataToggle = false;

		// Token: 0x04000192 RID: 402
		public static bool otherPlayerTradeInfoToggle = false;

		// Token: 0x04000193 RID: 403
		public static bool showGMWorldToggle = true;

		// Token: 0x04000194 RID: 404
		public static bool accountManagerToggle = false;

		// Token: 0x04000195 RID: 405
		public static bool specificReportToggle = false;

		// Token: 0x04000196 RID: 406
		public static bool pausedLeaveToggle = true;

		// Token: 0x04000197 RID: 407
		public static bool unCappedTextToggle = true;

		// Token: 0x04000198 RID: 408
		public static bool removeFrequencyCooldownToggle = true;

		// Token: 0x04000199 RID: 409
		public static bool bsonInGameLoggerToggle = false;

		// Token: 0x0400019A RID: 410
		public static bool packetCreator = false;

		// Token: 0x0400019B RID: 411
		public static bool onlinePresenceToggle = true;

		// Token: 0x0400019C RID: 412
		public static bool reportModAndAdminSightingsToggle = true;

		// Token: 0x0400019D RID: 413
		public static bool clientRelayChatToggle = true;

		// Token: 0x0400019E RID: 414
		public static bool fpsCapToggle = true;

		// Token: 0x0400019F RID: 415
		public static int maxFps = 60;

		// Token: 0x040001A1 RID: 417
		public static string startupProfileName;

		// Token: 0x040001A2 RID: 418
		private static readonly string SettingsFilePath;

		// Token: 0x040001A3 RID: 419
		private static readonly string ProfilesFolderPath;

		// Token: 0x040001A4 RID: 420
		private static readonly JsonSerializerOptions JsonOptions;

		// Token: 0x040001A5 RID: 421
		private static readonly FieldInfo[] SettingFields;

		// Token: 0x040001A6 RID: 422
		private static readonly HashSet<string> UiSettingsFields;

		// Token: 0x040001A7 RID: 423
		private static readonly HashSet<string> UiStyleSettingsFields;

		// Token: 0x040001A8 RID: 424
		private static readonly HashSet<string> UiEspSettingsFields;

		// Token: 0x040001A9 RID: 425
		private static readonly HashSet<string> UiPathSettingsFields;

		// Token: 0x040001AA RID: 426
		private static readonly HashSet<string> UiToastSettingsFields;

		// Token: 0x040001AB RID: 427
		private static readonly HashSet<string> GlobalOnlyFields;

		// Token: 0x02000026 RID: 38
		[CompilerGenerated]
		private static class 랾
		{
			// Token: 0x040001AC RID: 428
			public static Func<string, string> 랾;
		}

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		[Serializable]
		private sealed class 럎
		{
			// Token: 0x06000163 RID: 355 RVA: 0x0003D5AE File Offset: 0x0003B7AE
			internal bool 랾(string A_1)
			{
				return !string.IsNullOrWhiteSpace(A_1);
			}

			// Token: 0x06000164 RID: 356 RVA: 0x0003CAD1 File Offset: 0x0003ACD1
			internal string 럎(string A_1)
			{
				return A_1;
			}

			// Token: 0x06000165 RID: 357 RVA: 0x0003D5B9 File Offset: 0x0003B7B9
			internal bool 랾(FieldInfo A_1)
			{
				return !A_1.IsLiteral && !A_1.IsInitOnly;
			}

			// Token: 0x040001AD RID: 429
			public static readonly ConfigFile.럎 랾 = new ConfigFile.럎();

			// Token: 0x040001AE RID: 430
			public static Func<string, bool> 랾;

			// Token: 0x040001AF RID: 431
			public static Func<string, string> 랾;
		}
	}
}
