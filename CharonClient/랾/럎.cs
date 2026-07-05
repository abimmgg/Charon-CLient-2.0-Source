using System;
using System.Runtime.CompilerServices;

namespace 랾
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[랾]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class 럎 : Attribute
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0003C9DC File Offset: 0x0003ABDC
		public 럎(byte A_1)
		{
			this.랾 = new byte[]
			{
				A_1
			};
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		public 럎(byte[] A_1)
		{
			this.랾 = A_1;
		}

		// Token: 0x04000001 RID: 1
		public readonly byte[] 랾;
	}
}
