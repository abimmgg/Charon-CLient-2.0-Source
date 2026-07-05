using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace 랾
{
	// Token: 0x02000013 RID: 19
	public static class 랱
	{
		// Token: 0x0600007D RID: 125 RVA: 0x0003CD87 File Offset: 0x0003AF87
		public static string 랾()
		{
			return Environment.MachineName;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000715A0 File Offset: 0x0006F7A0
		public static string 럎()
		{
			string result;
			using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP))
			{
				socket.Connect("8.8.8.8", 65530);
				result = ((IPEndPoint)socket.LocalEndPoint).Address.ToString();
			}
			return result;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000715FC File Offset: 0x0006F7FC
		public static string[] 람()
		{
			return Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(new Func<IPAddress, bool>(랱.랾.랾.랾)).Select(new Func<IPAddress, string>(랱.랾.랾.럎)).ToArray<string>();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00071668 File Offset: 0x0006F868
		public static string 럒()
		{
			return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		}

		// Token: 0x02000014 RID: 20
		[CompilerGenerated]
		[Serializable]
		private sealed class 랾
		{
			// Token: 0x06000083 RID: 131 RVA: 0x0003CD9A File Offset: 0x0003AF9A
			internal bool 랾(IPAddress A_1)
			{
				return A_1.AddressFamily == AddressFamily.InterNetwork;
			}

			// Token: 0x06000084 RID: 132 RVA: 0x0003CDA5 File Offset: 0x0003AFA5
			internal string 럎(IPAddress A_1)
			{
				return A_1.ToString();
			}

			// Token: 0x0400003D RID: 61
			public static readonly 랱.랾 랾 = new 랱.랾();

			// Token: 0x0400003E RID: 62
			public static Func<IPAddress, bool> 랾;

			// Token: 0x0400003F RID: 63
			public static Func<IPAddress, string> 랾;
		}
	}
}
