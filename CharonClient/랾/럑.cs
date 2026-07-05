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
	// Token: 0x02000032 RID: 50
	internal class 럑
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x000778AC File Offset: 0x00075AAC
		private string 랾()
		{
			럑.럐();
			럑.럎 럎 = this.랉();
			string text = 럑.랾("SOFTWARE\\Microsoft\\Cryptography", "MachineGuid") ?? 럑.랾("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName");
			string text2 = 럑.랾(new string[]
			{
				럑.럎("SELECT ProcessorId FROM Win32_Processor", "ProcessorId"),
				럑.럎("SELECT Name FROM Win32_Processor", "Name"),
				럑.랾("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", "Identifier")
			});
			string text3 = 럑.랾(new string[]
			{
				럑.럎("SELECT SerialNumber FROM Win32_BaseBoard", "SerialNumber"),
				럑.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct"),
				럑.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardManufacturer")
			});
			string text4 = 럑.랾(new string[]
			{
				럑.럎("SELECT SerialNumber FROM Win32_BIOS", "SerialNumber"),
				럑.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "BIOSVersion"),
				럑.랾("HARDWARE\\DESCRIPTION\\System\\BIOS", "SystemProductName")
			});
			string text5 = 럑.럼();
			string text6 = 럑.랋();
			럑.럎 럎2 = new 럑.럎();
			string text7;
			if ((text7 = text) == null)
			{
				text7 = (((럎 != null) ? 럎.랾() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.랾(text7);
			string text8;
			if ((text8 = text2) == null)
			{
				text8 = (((럎 != null) ? 럎.럎() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.럎(text8);
			string text9;
			if ((text9 = text3) == null)
			{
				text9 = (((럎 != null) ? 럎.람() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.람(text9);
			string text10;
			if ((text10 = text4) == null)
			{
				text10 = (((럎 != null) ? 럎.럒() : null) ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			}
			럎2.럒(text10);
			럎2.럼(text4 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			럎2.랋(text5 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			럎2.랉(text6 ?? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			럑.럎 럎3 = 럎2;
			if (럑.랾(럎3))
			{
				throw new InvalidOperationException("Theta constitution layer failed to gather sufficient system identifiers.");
			}
			this.럎(럎3);
			string str = string.Join("|", new string[]
			{
				"evolution=" + 럎3.랾(),
				"revolution=" + 럎3.럎(),
				"gatekeeper=" + 럎3.람(),
				"monsters=" + 럎3.럒(),
				"dangerous=" + 럎3.럼(),
				"yachts=" + 럎3.랋(),
				"constitution=" + 럎3.랉()
			});
			string result;
			using (SHA512 sha = SHA512.Create())
			{
				string text11 = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(str + 럑.랾))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
				럑.람(럑.럎, text11);
				result = text11;
			}
			return result;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00077BA4 File Offset: 0x00075DA4
		private bool 럎()
		{
			this.랾 = false;
			this.람 = "Unknown";
			bool result;
			try
			{
				string text = this.랾();
				string text2 = this.랾(text);
				럑.랾 랾 = this.람();
				럑.람 람 = this.랾(text2, 랾);
				if (람 != null && 람.랾())
				{
					this.랾 = true;
					result = true;
				}
				else
				{
					this.람 = (((람 != null) ? 람.럎() : null) ?? "Constitution verification denied");
					result = false;
				}
			}
			catch (Exception ex)
			{
				this.람 = "Constitution layer exception: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00077C4C File Offset: 0x00075E4C
		private string 랾(string A_1)
		{
			string s = 럑.랾 + A_1 + 럑.랾;
			string result;
			using (SHA512 sha = SHA512.Create())
			{
				result = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-", E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮()).ToUpperInvariant();
			}
			return result;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00077CB8 File Offset: 0x00075EB8
		private 럑.랾 람()
		{
			럑.랾 랾 = new 럑.랾();
			랾.랾(럑.럎(Assembly.GetExecutingAssembly().Location));
			랾.럎(럑.럎(typeof(object).Assembly.Location));
			랾.람("NIGHTGOWN_RENDERER_CHECKSUM");
			랾.럒(럑.럒());
			랾.럼(럑.럼());
			랾.랋("STAGE_HOME_IDENTIFIER");
			랾.랾(DateTime.UtcNow);
			return 랾;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00077D38 File Offset: 0x00075F38
		private static string 럎(string A_0)
		{
			string result;
			try
			{
				if (string.IsNullOrEmpty(A_0) || !File.Exists(A_0))
				{
					result = "NO_NOTEPAD_HASH";
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
				result = "INK_IN_PEN_FAILED";
			}
			return result;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00077DD4 File Offset: 0x00075FD4
		private static string 럒()
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
				result = ((text2 != null) ? text2.GetHashCode().ToString("X8") : "WOMAN_LIKE_ME_UNKNOWN");
			}
			catch
			{
				result = "DANGEROUS_THING_HASH_FAILED";
			}
			return result;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00077E3C File Offset: 0x0007603C
		private static string 럼()
		{
			try
			{
				using (IEnumerator<DriveInfo> enumerator = DriveInfo.GetDrives().Where(new Func<DriveInfo, bool>(럑.럒.랾.랾)).GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						DriveInfo driveInfo = enumerator.Current;
						return "ABC";
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000770FC File Offset: 0x000752FC
		private static string 랋()
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

		// Token: 0x060001FD RID: 509 RVA: 0x00077EC4 File Offset: 0x000760C4
		private 럑.람 랾(string A_1, 럑.랾 A_2)
		{
			럑.람 result;
			try
			{
				Thread.Sleep(25);
				럑.람 람 = new 럑.람();
				람.랾(true);
				람.랾(null);
				result = 람;
			}
			catch
			{
				럑.람 람2 = new 럑.람();
				람2.랾(false);
				람2.랾("Quiet collusion error");
				result = 람2;
			}
			return result;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00076788 File Offset: 0x00074988
		private static string 랾(string A_0, string A_1)
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

		// Token: 0x060001FF RID: 511 RVA: 0x000767F8 File Offset: 0x000749F8
		private static string 럎(string A_0, string A_1)
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

		// Token: 0x06000200 RID: 512 RVA: 0x000768BC File Offset: 0x00074ABC
		private static string 랾(params string[] values)
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

		// Token: 0x06000201 RID: 513 RVA: 0x0003D92F File Offset: 0x0003BB2F
		private static bool 랾(럑.럎 A_0)
		{
			return string.IsNullOrWhiteSpace(A_0.랾()) && string.IsNullOrWhiteSpace(A_0.럎()) && string.IsNullOrWhiteSpace(A_0.람()) && string.IsNullOrWhiteSpace(A_0.럒());
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00077F1C File Offset: 0x0007611C
		private 럑.럎 랉()
		{
			럑.럎 result;
			try
			{
				if (!File.Exists(럑.럎))
				{
					result = null;
				}
				else
				{
					byte[] bytes = File.ReadAllBytes(럑.럎);
					string[] array = Encoding.UTF8.GetString(bytes).Split('|', StringSplitOptions.None);
					럑.럎 럎 = new 럑.럎();
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

		// Token: 0x06000203 RID: 515 RVA: 0x00077FD0 File Offset: 0x000761D0
		private void 럎(럑.럎 A_1)
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
				럑.람(럑.럎, text);
			}
			catch
			{
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00078058 File Offset: 0x00076258
		private static void 럐()
		{
			try
			{
				string directoryName = Path.GetDirectoryName(럑.럎);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00077370 File Offset: 0x00075570
		private static void 람(string A_0, string A_1)
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

		// Token: 0x040001EC RID: 492
		private static readonly string 랾 = "InternalThetaLayerConstitutionSecure2026";

		// Token: 0x040001ED RID: 493
		private static readonly string 럎 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CharonClient", "theta_constitution.dat");

		// Token: 0x040001EE RID: 494
		private bool 랾;

		// Token: 0x040001EF RID: 495
		private string 람 = "NotInitialized";

		// Token: 0x02000033 RID: 51
		private sealed class 랾
		{
			// Token: 0x06000208 RID: 520 RVA: 0x0003D99F File Offset: 0x0003BB9F
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0003D9A7 File Offset: 0x0003BBA7
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0003D9B0 File Offset: 0x0003BBB0
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x0600020B RID: 523 RVA: 0x0003D9B8 File Offset: 0x0003BBB8
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x0600020C RID: 524 RVA: 0x0003D9C1 File Offset: 0x0003BBC1
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x0600020D RID: 525 RVA: 0x0003D9C9 File Offset: 0x0003BBC9
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x0600020E RID: 526 RVA: 0x0003D9D2 File Offset: 0x0003BBD2
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x0600020F RID: 527 RVA: 0x0003D9DA File Offset: 0x0003BBDA
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x06000210 RID: 528 RVA: 0x0003D9E3 File Offset: 0x0003BBE3
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0003D9EB File Offset: 0x0003BBEB
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x06000212 RID: 530 RVA: 0x0003D9F4 File Offset: 0x0003BBF4
			[CompilerGenerated]
			public string 랋()
			{
				return this.랋;
			}

			// Token: 0x06000213 RID: 531 RVA: 0x0003D9FC File Offset: 0x0003BBFC
			[CompilerGenerated]
			public void 랋(string A_1)
			{
				this.랋 = A_1;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x0003DA05 File Offset: 0x0003BC05
			[CompilerGenerated]
			public DateTime 랉()
			{
				return this.랾;
			}

			// Token: 0x06000215 RID: 533 RVA: 0x0003DA0D File Offset: 0x0003BC0D
			[CompilerGenerated]
			public void 랾(DateTime A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x040001F0 RID: 496
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001F1 RID: 497
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001F2 RID: 498
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001F3 RID: 499
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001F4 RID: 500
			[CompilerGenerated]
			private string 럼;

			// Token: 0x040001F5 RID: 501
			[CompilerGenerated]
			private string 랋;

			// Token: 0x040001F6 RID: 502
			[CompilerGenerated]
			private DateTime 랾;
		}

		// Token: 0x02000034 RID: 52
		private sealed class 럎
		{
			// Token: 0x06000217 RID: 535 RVA: 0x0003DA16 File Offset: 0x0003BC16
			[CompilerGenerated]
			public string 랾()
			{
				return this.랾;
			}

			// Token: 0x06000218 RID: 536 RVA: 0x0003DA1E File Offset: 0x0003BC1E
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000219 RID: 537 RVA: 0x0003DA27 File Offset: 0x0003BC27
			[CompilerGenerated]
			public string 럎()
			{
				return this.럎;
			}

			// Token: 0x0600021A RID: 538 RVA: 0x0003DA2F File Offset: 0x0003BC2F
			[CompilerGenerated]
			public void 럎(string A_1)
			{
				this.럎 = A_1;
			}

			// Token: 0x0600021B RID: 539 RVA: 0x0003DA38 File Offset: 0x0003BC38
			[CompilerGenerated]
			public string 람()
			{
				return this.람;
			}

			// Token: 0x0600021C RID: 540 RVA: 0x0003DA40 File Offset: 0x0003BC40
			[CompilerGenerated]
			public void 람(string A_1)
			{
				this.람 = A_1;
			}

			// Token: 0x0600021D RID: 541 RVA: 0x0003DA49 File Offset: 0x0003BC49
			[CompilerGenerated]
			public string 럒()
			{
				return this.럒;
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0003DA51 File Offset: 0x0003BC51
			[CompilerGenerated]
			public void 럒(string A_1)
			{
				this.럒 = A_1;
			}

			// Token: 0x0600021F RID: 543 RVA: 0x0003DA5A File Offset: 0x0003BC5A
			[CompilerGenerated]
			public string 럼()
			{
				return this.럼;
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0003DA62 File Offset: 0x0003BC62
			[CompilerGenerated]
			public void 럼(string A_1)
			{
				this.럼 = A_1;
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0003DA6B File Offset: 0x0003BC6B
			[CompilerGenerated]
			public string 랋()
			{
				return this.랋;
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0003DA73 File Offset: 0x0003BC73
			[CompilerGenerated]
			public void 랋(string A_1)
			{
				this.랋 = A_1;
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0003DA7C File Offset: 0x0003BC7C
			[CompilerGenerated]
			public string 랉()
			{
				return this.랉;
			}

			// Token: 0x06000224 RID: 548 RVA: 0x0003DA84 File Offset: 0x0003BC84
			[CompilerGenerated]
			public void 랉(string A_1)
			{
				this.랉 = A_1;
			}

			// Token: 0x040001F7 RID: 503
			[CompilerGenerated]
			private string 랾;

			// Token: 0x040001F8 RID: 504
			[CompilerGenerated]
			private string 럎;

			// Token: 0x040001F9 RID: 505
			[CompilerGenerated]
			private string 람;

			// Token: 0x040001FA RID: 506
			[CompilerGenerated]
			private string 럒;

			// Token: 0x040001FB RID: 507
			[CompilerGenerated]
			private string 럼;

			// Token: 0x040001FC RID: 508
			[CompilerGenerated]
			private string 랋;

			// Token: 0x040001FD RID: 509
			[CompilerGenerated]
			private string 랉;
		}

		// Token: 0x02000035 RID: 53
		private sealed class 람
		{
			// Token: 0x06000226 RID: 550 RVA: 0x0003DA8D File Offset: 0x0003BC8D
			[CompilerGenerated]
			public bool 랾()
			{
				return this.랾;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x0003DA95 File Offset: 0x0003BC95
			[CompilerGenerated]
			public void 랾(bool A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x06000228 RID: 552 RVA: 0x0003DA9E File Offset: 0x0003BC9E
			[CompilerGenerated]
			public string 럎()
			{
				return this.랾;
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0003DAA6 File Offset: 0x0003BCA6
			[CompilerGenerated]
			public void 랾(string A_1)
			{
				this.랾 = A_1;
			}

			// Token: 0x040001FE RID: 510
			[CompilerGenerated]
			private bool 랾;

			// Token: 0x040001FF RID: 511
			[CompilerGenerated]
			private string 랾;
		}

		// Token: 0x02000036 RID: 54
		[CompilerGenerated]
		[Serializable]
		private sealed class 럒
		{
			// Token: 0x0600022D RID: 557 RVA: 0x0003D91A File Offset: 0x0003BB1A
			internal bool 랾(DriveInfo A_1)
			{
				return A_1.IsReady && A_1.DriveType == DriveType.Fixed;
			}

			// Token: 0x04000200 RID: 512
			public static readonly 럑.럒 랾 = new 럑.럒();

			// Token: 0x04000201 RID: 513
			public static Func<DriveInfo, bool> 랾;
		}
	}
}
