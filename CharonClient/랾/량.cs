using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using Microsoft.Win32;

namespace 랾
{
	// Token: 0x02000028 RID: 40
	internal class 량
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00076268 File Offset: 0x00074468
		private string 랾()
		{
			량.랋();
			string text = 량.럎(량.럎) + 량.럎(량.람) + 량.럎(량.럒);
			량.럎 럎 = this.럼();
			string text2 = 량.람("SOFTWARE\\Microsoft\\Cryptography", "MachineGuid");
			string text3 = 량.랾(new string[]
			{
				량.럒("SELECT ProcessorId FROM Win32_Processor", "ProcessorId"),
				량.럒("SELECT Name FROM Win32_Processor", "Name")
			});
			string text4 = 량.랾(new string[]
			{
				량.럒("SELECT SerialNumber FROM Win32_BaseBoard", "SerialNumber"),
				량.람("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct")
			});
			string text5 = 량.랾(new string[]
			{
				량.럒("SELECT SerialNumber FROM Win32_BIOS", "SerialNumber"),
				량.람("HARDWARE\\DESCRIPTION\\System\\BIOS", "BIOSVersion")
			});
			량.럎 럎2 = new 량.럎();
			string text6;
			if ((text6 = text2) == null)
			{
				text6 = (((럎 != null) ? 럎.랾() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.랾(text6);
			string text7;
			if ((text7 = text3) == null)
			{
				text7 = (((럎 != null) ? 럎.럎() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.럎(text7);
			string text8;
			if ((text8 = text4) == null)
			{
				text8 = (((럎 != null) ? 럎.람() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.람(text8);
			string text9;
			if ((text9 = text5) == null)
			{
				text9 = (((럎 != null) ? 럎.럒() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.럒(text9);
			럎2.럼(text5 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			량.럎 럎3 = 럎2;
			this.랾(럎3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 4);
			defaultInterpolatedStringHandler.AppendLiteral("A1=");
			defaultInterpolatedStringHandler.AppendFormatted(럎3.랾());
			defaultInterpolatedStringHandler.AppendLiteral("|B2=");
			defaultInterpolatedStringHandler.AppendFormatted(럎3.럎());
			defaultInterpolatedStringHandler.AppendLiteral("|C3=");
			defaultInterpolatedStringHandler.AppendFormatted(럎3.람());
			defaultInterpolatedStringHandler.AppendLiteral("|D4=");
			defaultInterpolatedStringHandler.AppendFormatted(럎3.럒());
			string text10 = 량.랾(defaultInterpolatedStringHandler.ToStringAndClear(), 량.랾 + text.Substring(0, 48));
			량.람(text10);
			return text10;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00076480 File Offset: 0x00074680
		private bool 럎()
		{
			this.랾 = false;
			this.럼 = "Unknown";
			bool result;
			try
			{
				string text = this.랾();
				량.랾 랾 = this.람();
				if (text.Length > 60 && 랾 != null)
				{
					this.랾 = true;
					result = true;
				}
				else
				{
					this.럼 = "Decryption failed in X7vK9pL2mQ8z";
					result = false;
				}
			}
			catch (Exception ex)
			{
				this.럼 = "X7vK9pL2mQ8z error: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00076504 File Offset: 0x00074704
		private 량.랾 람()
		{
			량.랾 랾 = new 량.랾();
			랾.랾(량.랾(Assembly.GetExecutingAssembly().Location));
			랾.럎(량.랾(typeof(object).Assembly.Location));
			랾.람("NIGHTGOWN_SYLVIA_PLATH");
			랾.럒("DEBUTANTE_WHITE_YACHTS");
			랾.럼(량.럒());
			return 랾;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0007656C File Offset: 0x0007476C
		private static string 랾(string A_0)
		{
			string result;
			try
			{
				if (string.IsNullOrEmpty(A_0) || !File.Exists(A_0))
				{
					result = "INK_IN_PEN_FAILED";
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
				result = "BLOOD_ON_WALLS";
			}
			return result;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00076608 File Offset: 0x00074808
		private static string 럒()
		{
			try
			{
				using (IEnumerator<DriveInfo> enumerator = DriveInfo.GetDrives().Where(new Func<DriveInfo, bool>(량.랓.랾.랾)).GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return enumerator.Current.VolumeLabel.ToString() + "_BOWERY";
					}
				}
			}
			catch
			{
			}
			return "CHURCH_BASEMENT";
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000766A0 File Offset: 0x000748A0
		private static string 랾(string A_0, string A_1)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(A_0);
			byte[] bytes2 = Encoding.UTF8.GetBytes(A_1);
			byte[] array = new byte[bytes.Length];
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = (bytes[i] ^ bytes2[i % bytes2.Length] ^ 127 ^ 165);
			}
			return Convert.ToBase64String(array) + ":X7vK9pL2mQ8z";
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00076704 File Offset: 0x00074904
		private static string 럎(string A_0, string A_1)
		{
			string result;
			try
			{
				byte[] array = Convert.FromBase64String(A_0.Split(':', StringSplitOptions.None)[0]);
				byte[] bytes = Encoding.UTF8.GetBytes(A_1);
				byte[] array2 = new byte[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = (array[i] ^ bytes[i % bytes.Length] ^ 127 ^ 165);
				}
				result = Encoding.UTF8.GetString(array2);
			}
			catch
			{
				result = "HOPE_IS_DANGEROUS_DECRYPT_FAILED";
			}
			return result;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0003D5CE File Offset: 0x0003B7CE
		private static string 럎(string A_0)
		{
			return 량.럎(A_0, 량.랾 + "SylviaPlathNightgownDebutantes");
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00076788 File Offset: 0x00074988
		private static string 람(string A_0, string A_1)
		{
			string result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(A_0, false))
				{
					string text;
					if (registryKey == null)
					{
						text = null;
					}
					else
					{
						object value = registryKey.GetValue(A_1);
						if (value == null)
						{
							text = null;
						}
						else
						{
							string text2 = value.ToString();
							text = ((text2 != null) ? text2.Trim() : null);
						}
					}
					result = text;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000767F8 File Offset: 0x000749F8
		private static string 럒(string A_0, string A_1)
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(A_0))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							object obj = managementObject[A_1];
							string text;
							if (obj == null)
							{
								text = null;
							}
							else
							{
								string text2 = obj.ToString();
								text = ((text2 != null) ? text2.Trim() : null);
							}
							string text3 = text;
							if (!string.IsNullOrEmpty(text3))
							{
								return text3;
							}
						}
						finally
						{
							managementObject.Dispose();
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000768BC File Offset: 0x00074ABC
		private static string 랾(params string[] v)
		{
			foreach (string text in v)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000768E8 File Offset: 0x00074AE8
		private 량.럎 럼()
		{
			량.럎 result;
			try
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient", "x7vk9pl2mq8z.dat");
				if (!File.Exists(path))
				{
					result = null;
				}
				else
				{
					string[] array = Encoding.UTF8.GetString(File.ReadAllBytes(path)).Split('|', StringSplitOptions.None);
					량.럎 럎 = new 량.럎();
					럎.랾((array.Length != 0) ? array[0] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					럎.럎((array.Length > 1) ? array[1] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					럎.람((array.Length > 2) ? array[2] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					럎.럒((array.Length > 3) ? array[3] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					result = 럎;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000769A8 File Offset: 0x00074BA8
		private void 랾(량.럎 A_1)
		{
			try
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient", "x7vk9pl2mq8z.dat");
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				string s = string.Join("|", new string[]
				{
					A_1.랾() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(),
					A_1.럎() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(),
					A_1.람() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(),
					A_1.럒() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()
				});
				File.WriteAllBytes(path, Encoding.UTF8.GetBytes(s));
			}
			catch
			{
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00076A64 File Offset: 0x00074C64
		private static void 랋()
		{
			try
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient");
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00076AA8 File Offset: 0x00074CA8
		private static void 람(string A_0)
		{
			try
			{
				File.WriteAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient", "x7vk9pl2mq8z_final.dat"), Encoding.UTF8.GetBytes(A_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00076AF0 File Offset: 0x00074CF0
		private string 랉()
		{
			량.랫();
			량.람 람 = this.럙();
			string text = 량.럼("SOFTWARE\\Microsoft\\Cryptography", "MachineGuid") ?? 량.럼("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName");
			string text2 = 량.럎(new string[]
			{
				량.랋("SELECT ProcessorId FROM Win32_Processor", "ProcessorId"),
				량.랋("SELECT Name FROM Win32_Processor", "Name"),
				량.럼("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", "Identifier")
			});
			string text3 = 량.럎(new string[]
			{
				량.랋("SELECT SerialNumber FROM Win32_BaseBoard", "SerialNumber"),
				량.럼("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct"),
				량.럼("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardManufacturer")
			});
			string text4 = 량.럎(new string[]
			{
				량.랋("SELECT SerialNumber FROM Win32_BIOS", "SerialNumber"),
				량.럼("HARDWARE\\DESCRIPTION\\System\\BIOS", "BIOSVersion"),
				량.럼("HARDWARE\\DESCRIPTION\\System\\BIOS", "SystemProductName")
			});
			string text5 = 량.럭();
			string text6 = 량.랱();
			량.람 람2 = new 량.람();
			string text7;
			if ((text7 = text) == null)
			{
				text7 = (((람 != null) ? 람.랾() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			람2.랾(text7);
			string text8;
			if ((text8 = text2) == null)
			{
				text8 = (((람 != null) ? 람.럎() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			람2.럎(text8);
			string text9;
			if ((text9 = text3) == null)
			{
				text9 = (((람 != null) ? 람.람() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			람2.람(text9);
			string text10;
			if ((text10 = text4) == null)
			{
				text10 = (((람 != null) ? 람.럒() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			람2.럒(text10);
			람2.럼(text4 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			람2.랋(text5 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			람2.랉(text6 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			량.람 람3 = 람2;
			if (량.랾(람3))
			{
				throw new InvalidOperationException("Epsilon layer could not collect hardware identifiers.");
			}
			this.럎(람3);
			string str = string.Join("|", new string[]
			{
				"mid=" + 람3.랾(),
				"proc=" + 람3.럎(),
				"bb=" + 람3.람(),
				"sys=" + 람3.럒(),
				"bios=" + 람3.럼(),
				"disk=" + 람3.랋(),
				"mem=" + 람3.랉()
			});
			string result;
			using (SHA512 sha = SHA512.Create())
			{
				string text11 = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(str + 량.랋))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
				량.랉(량.랉, text11);
				result = text11;
			}
			return result;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00076DE8 File Offset: 0x00074FE8
		private bool 럐()
		{
			this.럎 = false;
			this.럐 = "Unknown";
			bool result;
			try
			{
				string text = this.랉();
				string text2 = this.럒(text);
				량.럒 럒 = this.랓();
				량.럼 럼 = this.랾(text2, 럒);
				if (럼 != null && 럼.랾())
				{
					this.럎 = true;
					result = true;
				}
				else
				{
					this.럐 = (((럼 != null) ? 럼.럎() : null) ?? "Remote verification denied");
					result = false;
				}
			}
			catch (Exception ex)
			{
				this.럐 = "Layer error: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00076E90 File Offset: 0x00075090
		private string 럒(string A_1)
		{
			string s = 량.랋 + A_1 + 량.랋;
			string result;
			using (SHA512 sha = SHA512.Create())
			{
				result = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
			}
			return result;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00076EFC File Offset: 0x000750FC
		private 량.럒 랓()
		{
			량.럒 럒 = new 량.럒();
			럒.랾(량.럼(Assembly.GetExecutingAssembly().Location));
			럒.럎(량.럼(typeof(object).Assembly.Location));
			럒.람("RENDERER_CHECKSUM_PLACEHOLDER");
			럒.럒(량.럯());
			럒.럼(량.럭());
			럒.랾(DateTime.UtcNow);
			return 럒;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00076F70 File Offset: 0x00075170
		private static string 럼(string A_0)
		{
			string result;
			try
			{
				if (string.IsNullOrEmpty(A_0) || !File.Exists(A_0))
				{
					result = "NO_FILE_HASH";
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
				result = "HASH_FAILED";
			}
			return result;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0007700C File Offset: 0x0007520C
		private static string 럯()
		{
			string result;
			try
			{
				string text;
				if ((text = Environment.ProcessPath) == null)
				{
					ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
					text = ((mainModule != null) ? mainModule.FileName : null);
				}
				string text2 = text;
				result = ((text2 != null) ? text2.GetHashCode().ToString("X8") : "PROCESS_UNKNOWN");
			}
			catch
			{
				result = "PROCESS_HASH_FAILED";
			}
			return result;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00077074 File Offset: 0x00075274
		private static string 럭()
		{
			try
			{
				using (IEnumerator<DriveInfo> enumerator = DriveInfo.GetDrives().Where(new Func<DriveInfo, bool>(량.랓.랾.럎)).GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						DriveInfo driveInfo = enumerator.Current;
						return "XB";
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000770FC File Offset: 0x000752FC
		private static string 랱()
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory"))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						object obj = ((ManagementObject)managementBaseObject)["Capacity"];
						string text = (obj != null) ? obj.ToString() : null;
						if (!string.IsNullOrEmpty(text))
						{
							return text;
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000771A0 File Offset: 0x000753A0
		private 량.럼 랾(string A_1, 량.럒 A_2)
		{
			량.럼 result;
			try
			{
				Thread.Sleep(30);
				량.럼 럼 = new 량.럼();
				럼.랾(true);
				럼.랾(null);
				result = 럼;
			}
			catch
			{
				량.럼 럼2 = new 량.럼();
				럼2.랾(false);
				럼2.랾("Communication error");
				result = 럼2;
			}
			return result;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00076788 File Offset: 0x00074988
		private static string 럼(string A_0, string A_1)
		{
			string result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(A_0, false))
				{
					string text;
					if (registryKey == null)
					{
						text = null;
					}
					else
					{
						object value = registryKey.GetValue(A_1);
						if (value == null)
						{
							text = null;
						}
						else
						{
							string text2 = value.ToString();
							text = ((text2 != null) ? text2.Trim() : null);
						}
					}
					result = text;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000767F8 File Offset: 0x000749F8
		private static string 랋(string A_0, string A_1)
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(A_0))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							object obj = managementObject[A_1];
							string text;
							if (obj == null)
							{
								text = null;
							}
							else
							{
								string text2 = obj.ToString();
								text = ((text2 != null) ? text2.Trim() : null);
							}
							string text3 = text;
							if (!string.IsNullOrEmpty(text3))
							{
								return text3;
							}
						}
						finally
						{
							managementObject.Dispose();
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000768BC File Offset: 0x00074ABC
		private static string 럎(params string[] values)
		{
			foreach (string text in values)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0003D5E5 File Offset: 0x0003B7E5
		private static bool 랾(량.람 A_0)
		{
			return string.IsNullOrWhiteSpace(A_0.랾()) && string.IsNullOrWhiteSpace(A_0.럎()) && string.IsNullOrWhiteSpace(A_0.람()) && string.IsNullOrWhiteSpace(A_0.럒());
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000771F8 File Offset: 0x000753F8
		private 량.람 럙()
		{
			량.람 result;
			try
			{
				if (!File.Exists(량.랉))
				{
					result = null;
				}
				else
				{
					byte[] bytes = File.ReadAllBytes(량.랉);
					string[] array = Encoding.UTF8.GetString(bytes).Split('|', StringSplitOptions.None);
					량.람 람 = new 량.람();
					람.랾((array.Length != 0) ? array[0] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					람.럎((array.Length > 1) ? array[1] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					람.람((array.Length > 2) ? array[2] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					람.럒((array.Length > 3) ? array[3] : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
					result = 람;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000772AC File Offset: 0x000754AC
		private void 럎(량.람 A_1)
		{
			try
			{
				string text = string.Join("|", new string[]
				{
					A_1.랾() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(),
					A_1.럎() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(),
					A_1.람() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(),
					A_1.럒() ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()
				});
				량.랉(량.랉, text);
			}
			catch
			{
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00077334 File Offset: 0x00075534
		private static void 랫()
		{
			try
			{
				string directoryName = Path.GetDirectoryName(량.랉);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00077370 File Offset: 0x00075570
		private static void 랉(string A_0, string A_1)
		{
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(A_1 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
				File.WriteAllBytes(A_0, bytes);
			}
			catch
			{
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000773B0 File Offset: 0x000755B0
		private bool 랋(string A_1)
		{
			this.람 = false;
			this.럭 = "Unknown";
			bool result;
			try
			{
				string text = this.랉(A_1);
				량.랉 랉 = this.럍();
				량.랋 랋 = new 량.랋();
				랋.랾(text);
				랋.럎(this.럇());
				랋.람("1.4.2");
				랋.럒(this.랯());
				랋.랾(랉);
				량.랋 랋2 = 랋;
				량.럐 럐 = this.랾(랋2);
				if (럐 != null && 럐.랾())
				{
					if (!string.IsNullOrEmpty(럐.람()))
					{
						this.랓(럐.람());
					}
					this.람 = true;
					result = true;
				}
				else
				{
					this.럭 = (((럐 != null) ? 럐.럼() : null) ?? "Backend service denied access");
					result = false;
				}
			}
			catch (Exception ex)
			{
				this.럭 = "Omega backend exception: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000774A0 File Offset: 0x000756A0
		private string 랉(string A_1)
		{
			string s = 량.랓 + A_1 + 량.랓;
			string result;
			using (SHA512 sha = SHA512.Create())
			{
				result = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
			}
			return result;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0007750C File Offset: 0x0007570C
		private 량.랉 럍()
		{
			량.랉 랉 = new 량.랉();
			랉.랾(량.럐("core_module.dll"));
			랉.럎(량.럐("loader_component.bin"));
			랉.람("PLATH_RENDERER_SIGNATURE");
			랉.럒(량.랬());
			랉.럼(량.란());
			랉.랋("DEBUTANTE_STAGE_HOME");
			return 랉;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0007756C File Offset: 0x0007576C
		private static string 럐(string A_0)
		{
			string result;
			try
			{
				string s = A_0 + DateTime.UtcNow.Ticks.ToString();
				using (SHA256 sha = SHA256.Create())
				{
					result = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
				}
			}
			catch
			{
				result = "BACKEND_SIGNATURE_FAILED";
			}
			return result;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000775FC File Offset: 0x000757FC
		private static string 랬()
		{
			string result;
			try
			{
				result = (Environment.ProcessPath ?? "UNKNOWN_PROCESS").GetHashCode().ToString("X8") + "_NIGHTGOWN";
			}
			catch
			{
				result = "DANGEROUS_NIGHTGOWN_HASH";
			}
			return result;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00077650 File Offset: 0x00075850
		private static string 란()
		{
			try
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives().Where(new Func<DriveInfo, bool>(량.랓.랾.람)))
				{
					"BOWERY".Equals(driveInfo.VolumeLabel, StringComparison.OrdinalIgnoreCase);
				}
			}
			catch
			{
			}
			return "NO_BOWERY_VOLUME";
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000776E4 File Offset: 0x000758E4
		private string 럇()
		{
			return Guid.NewGuid().ToString("N").ToUpperInvariant();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00077708 File Offset: 0x00075908
		private string 랯()
		{
			string result;
			try
			{
				if (File.Exists(량.럯))
				{
					result = Encoding.UTF8.GetString(File.ReadAllBytes(량.럯));
				}
				else
				{
					result = string.Empty;
				}
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0007775C File Offset: 0x0007595C
		private void 랓(string A_1)
		{
			try
			{
				string directoryName = Path.GetDirectoryName(량.럯);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllBytes(량.럯, Encoding.UTF8.GetBytes(A_1));
			}
			catch
			{
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000777B0 File Offset: 0x000759B0
		private 량.럐 랾(량.랋 A_1)
		{
			Thread.Sleep(45);
			량.럐 럐 = new 량.럐();
			럐.랾(true);
			럐.랾("success");
			럐.럎(Guid.NewGuid().ToString("N"));
			럐.람(DateTime.UtcNow.AddHours(24.0).ToString("o"));
			럐.럒(null);
			럐.럎(false);
			return 럐;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00076788 File Offset: 0x00074988
		private static string 럐(string A_0, string A_1)
		{
			string result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(A_0, false))
				{
					string text;
					if (registryKey == null)
					{
						text = null;
					}
					else
					{
						object value = registryKey.GetValue(A_1);
						if (value == null)
						{
							text = null;
						}
						else
						{
							string text2 = value.ToString();
							text = ((text2 != null) ? text2.Trim() : null);
						}
					}
					result = text;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000767F8 File Offset: 0x000749F8
		private static string 랓(string A_0, string A_1)
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(A_0))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							object obj = managementObject[A_1];
							string text;
							if (obj == null)
							{
								text = null;
							}
							else
							{
								string text2 = obj.ToString();
								text = ((text2 != null) ? text2.Trim() : null);
							}
							string text3 = text;
							if (!string.IsNullOrEmpty(text3))
							{
								return text3;
							}
						}
						finally
						{
							managementObject.Dispose();
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x040001B0 RID: 432
		private static readonly string 랾 = "U2FsdGVkX1+HopeIsADangerousThingForAWomanLikeMeToHaveSylviaPlathNightgown2026";

		// Token: 0x040001B1 RID: 433
		private static readonly string 럎 = "U2FsdGVkX1+9vX8fKzL9pQ==:SlimAaronsDebutantesWhiteYachts";

		// Token: 0x040001B2 RID: 434
		private static readonly string 람 = "U2FsdGVkX1+8mN7vPqR2xT==:BoweryBumsTriadSociopathNarcissist";

		// Token: 0x040001B3 RID: 435
		private static readonly string 럒 = "U2FsdGVkX1+7kL5qWvB3yU==:MonstersGatekeeperConstitutionBloodOnWalls";

		// Token: 0x040001B4 RID: 436
		private bool 랾;

		// Token: 0x040001B5 RID: 437
		private string 럼 = "NotInitialized";

		// Token: 0x040001B6 RID: 438
		private static readonly string 랋 = "CharonInternalLayerEpsilon2026Secure";

		// Token: 0x040001B7 RID: 439
		private static readonly string 랉 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient", "epsilon_cache.dat");

		// Token: 0x040001B8 RID: 440
		private bool 럎;

		// Token: 0x040001B9 RID: 441
		private string 럐 = "NotInitialized";

		// Token: 0x040001BA RID: 442
		private static readonly string 랓 = "CharonBackendOmegaServiceSecure2026";

		// Token: 0x040001BB RID: 443
		private static readonly string 럯 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient", "omega_backend.session");

		// Token: 0x040001BC RID: 444
		private bool 람;

		// Token: 0x040001BD RID: 445
		private string 럭 = "NotInitialized";

		// Token: 0x02000029 RID: 41
		private sealed class 랾
		{
			// Token: 0x06000194 RID: 404 RVA: 0x0003D644 File Offset: 0x0003B844
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000195 RID: 405 RVA: 0x0003D64C File Offset: 0x0003B84C
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000196 RID: 406 RVA: 0x0003D655 File Offset: 0x0003B855
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x06000197 RID: 407 RVA: 0x0003D65D File Offset: 0x0003B85D
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x06000198 RID: 408 RVA: 0x0003D666 File Offset: 0x0003B866
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x06000199 RID: 409 RVA: 0x0003D66E File Offset: 0x0003B86E
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x0600019A RID: 410 RVA: 0x0003D677 File Offset: 0x0003B877
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x0600019B RID: 411 RVA: 0x0003D67F File Offset: 0x0003B87F
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x0600019C RID: 412 RVA: 0x0003D688 File Offset: 0x0003B888
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x0600019D RID: 413 RVA: 0x0003D690 File Offset: 0x0003B890
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x040001BE RID: 446
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001BF RID: 447
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001C0 RID: 448
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001C1 RID: 449
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001C2 RID: 450
			[CompilerGenerated]
			private string 럼;
		}

		// Token: 0x0200002A RID: 42
		private sealed class 럎
		{
			// Token: 0x0600019F RID: 415 RVA: 0x0003D699 File Offset: 0x0003B899
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x0003D6A1 File Offset: 0x0003B8A1
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x0003D6AA File Offset: 0x0003B8AA
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x0003D6B2 File Offset: 0x0003B8B2
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x0003D6BB File Offset: 0x0003B8BB
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x0003D6C3 File Offset: 0x0003B8C3
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x0003D6CC File Offset: 0x0003B8CC
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x0003D6DD File Offset: 0x0003B8DD
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x0003D6E5 File Offset: 0x0003B8E5
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x040001C3 RID: 451
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001C4 RID: 452
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001C5 RID: 453
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001C6 RID: 454
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001C7 RID: 455
			[CompilerGenerated]
			private string 럼;
		}

		// Token: 0x0200002B RID: 43
		private sealed class 람
		{
			// Token: 0x060001AA RID: 426 RVA: 0x0003D6EE File Offset: 0x0003B8EE
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x0003D6F6 File Offset: 0x0003B8F6
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001AC RID: 428 RVA: 0x0003D6FF File Offset: 0x0003B8FF
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x0003D707 File Offset: 0x0003B907
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060001AE RID: 430 RVA: 0x0003D710 File Offset: 0x0003B910
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x0003D718 File Offset: 0x0003B918
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x0003D721 File Offset: 0x0003B921
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x0003D729 File Offset: 0x0003B929
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x0003D732 File Offset: 0x0003B932
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x0003D73A File Offset: 0x0003B93A
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x0003D743 File Offset: 0x0003B943
			[CompilerGenerated]
			public string 랋()
			{
				return this.랋;
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x0003D74B File Offset: 0x0003B94B
			[CompilerGenerated]
			public void 랋(string A_1)
			{
				this.랋 = A_1;
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x0003D754 File Offset: 0x0003B954
			[CompilerGenerated]
			public string 랉()
			{
				return this.랉;
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x0003D75C File Offset: 0x0003B95C
			[CompilerGenerated]
			public void 랉(string A_1)
			{
				this.랉 = A_1;
			}

			// Token: 0x040001C8 RID: 456
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001C9 RID: 457
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001CA RID: 458
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001CB RID: 459
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001CC RID: 460
			[CompilerGenerated]
			private string 럼;

			// Token: 0x040001CD RID: 461
			[CompilerGenerated]
			private string 랋;

			// Token: 0x040001CE RID: 462
			[CompilerGenerated]
			private string 랉;
		}

		// Token: 0x0200002C RID: 44
		private sealed class 럒
		{
			// Token: 0x060001B9 RID: 441 RVA: 0x0003D765 File Offset: 0x0003B965
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x0003D76D File Offset: 0x0003B96D
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x0003D776 File Offset: 0x0003B976
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060001BC RID: 444 RVA: 0x0003D77E File Offset: 0x0003B97E
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060001BD RID: 445 RVA: 0x0003D787 File Offset: 0x0003B987
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060001BE RID: 446 RVA: 0x0003D78F File Offset: 0x0003B98F
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060001BF RID: 447 RVA: 0x0003D798 File Offset: 0x0003B998
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x0003D7A9 File Offset: 0x0003B9A9
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x0003D7B1 File Offset: 0x0003B9B1
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x0003D7BA File Offset: 0x0003B9BA
			[CompilerGenerated]
			public DateTime 랋()
			{
				return this.랾;
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x0003D7C2 File Offset: 0x0003B9C2
			[CompilerGenerated]
			public void 랾(DateTime A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x040001CF RID: 463
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001D0 RID: 464
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001D1 RID: 465
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001D2 RID: 466
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001D3 RID: 467
			[CompilerGenerated]
			private string 럼;

			// Token: 0x040001D4 RID: 468
			[CompilerGenerated]
			private DateTime 랾;
		}

		// Token: 0x0200002D RID: 45
		private sealed class 럼
		{
			// Token: 0x060001C6 RID: 454 RVA: 0x0003D7CB File Offset: 0x0003B9CB
			[CompilerGenerated]
			public bool 랾()
			{
				return this.랾;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x0003D7D3 File Offset: 0x0003B9D3
			[CompilerGenerated]
			public void 랾(bool A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x0003D7DC File Offset: 0x0003B9DC
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x040001D5 RID: 469
			[CompilerGenerated]
			private bool 랾;

			// Token: 0x040001D6 RID: 470
			[CompilerGenerated]
			private string 랾;
		}

		// Token: 0x0200002E RID: 46
		private sealed class 랋
		{
			// Token: 0x060001CB RID: 459 RVA: 0x0003D7ED File Offset: 0x0003B9ED
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060001CC RID: 460 RVA: 0x0003D7F5 File Offset: 0x0003B9F5
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x0003D7FE File Offset: 0x0003B9FE
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060001CE RID: 462 RVA: 0x0003D806 File Offset: 0x0003BA06
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060001CF RID: 463 RVA: 0x0003D80F File Offset: 0x0003BA0F
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x0003D817 File Offset: 0x0003BA17
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x0003D820 File Offset: 0x0003BA20
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x0003D828 File Offset: 0x0003BA28
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x0003D831 File Offset: 0x0003BA31
			[CompilerGenerated]
			public 량.랉 럼()
			{
				return this.랾;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x0003D839 File Offset: 0x0003BA39
			[CompilerGenerated]
			public void 랾(량.랉 A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x040001D7 RID: 471
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001D8 RID: 472
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001D9 RID: 473
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001DA RID: 474
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001DB RID: 475
			[CompilerGenerated]
			private 량.랉 랾;
		}

		// Token: 0x0200002F RID: 47
		private sealed class 랉
		{
			// Token: 0x060001D6 RID: 470 RVA: 0x0003D842 File Offset: 0x0003BA42
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0003D84A File Offset: 0x0003BA4A
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x0003D853 File Offset: 0x0003BA53
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x0003D85B File Offset: 0x0003BA5B
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060001DA RID: 474 RVA: 0x0003D864 File Offset: 0x0003BA64
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x060001DB RID: 475 RVA: 0x0003D86C File Offset: 0x0003BA6C
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060001DC RID: 476 RVA: 0x0003D875 File Offset: 0x0003BA75
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x060001DD RID: 477 RVA: 0x0003D87D File Offset: 0x0003BA7D
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0003D886 File Offset: 0x0003BA86
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0003D88E File Offset: 0x0003BA8E
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x0003D897 File Offset: 0x0003BA97
			[CompilerGenerated]
			public string 랋()
			{
				return this.랋;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x0003D89F File Offset: 0x0003BA9F
			[CompilerGenerated]
			public void 랋(string A_1)
			{
				this.랋 = A_1;
			}

			// Token: 0x040001DC RID: 476
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001DD RID: 477
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001DE RID: 478
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001DF RID: 479
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001E0 RID: 480
			[CompilerGenerated]
			private string 럼;

			// Token: 0x040001E1 RID: 481
			[CompilerGenerated]
			private string 랋;
		}

		// Token: 0x02000030 RID: 48
		private sealed class 럐
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
			[CompilerGenerated]
			public bool 랾()
			{
				return this.랾;
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x0003D8B0 File Offset: 0x0003BAB0
			[CompilerGenerated]
			public void 랾(bool A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x0003D8B9 File Offset: 0x0003BAB9
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x0003D8C1 File Offset: 0x0003BAC1
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x0003D8CA File Offset: 0x0003BACA
			[CompilerGenerated]
			public string 람()
			{
				return this.럎;
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x0003D8D2 File Offset: 0x0003BAD2
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x0003D8DB File Offset: 0x0003BADB
			[CompilerGenerated]
			public string 럒()
			{
				return this.람;
			}

			// Token: 0x060001EA RID: 490 RVA: 0x0003D8E3 File Offset: 0x0003BAE3
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x060001EB RID: 491 RVA: 0x0003D8EC File Offset: 0x0003BAEC
			[CompilerGenerated]
			public string 럼()
			{
				return this.럒;
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x0003D8FD File Offset: 0x0003BAFD
			[CompilerGenerated]
			public bool 랋()
			{
				return this.럎;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0003D905 File Offset: 0x0003BB05
			[CompilerGenerated]
			public void 럎(bool A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x040001E2 RID: 482
			[CompilerGenerated]
			private bool 랾;

			// Token: 0x040001E3 RID: 483
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001E4 RID: 484
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001E5 RID: 485
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001E6 RID: 486
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001E7 RID: 487
			[CompilerGenerated]
			private bool 럎;
		}

		// Token: 0x02000031 RID: 49
		[CompilerGenerated]
		[Serializable]
		private sealed class 랓
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x0003D91A File Offset: 0x0003BB1A
			internal bool 랾(DriveInfo A_1)
			{
				return A_1.IsReady && A_1.DriveType == DriveType.Fixed;
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x0003D91A File Offset: 0x0003BB1A
			internal bool 럎(DriveInfo A_1)
			{
				return A_1.IsReady && A_1.DriveType == DriveType.Fixed;
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x0003D91A File Offset: 0x0003BB1A
			internal bool 람(DriveInfo A_1)
			{
				return A_1.IsReady && A_1.DriveType == DriveType.Fixed;
			}

			// Token: 0x040001E8 RID: 488
			public static readonly 량.랓 랾 = new 량.랓();

			// Token: 0x040001E9 RID: 489
			public static Func<DriveInfo, bool> 랾;

			// Token: 0x040001EA RID: 490
			public static Func<DriveInfo, bool> 럎;

			// Token: 0x040001EB RID: 491
			public static Func<DriveInfo, bool> 람;
		}
	}
}
