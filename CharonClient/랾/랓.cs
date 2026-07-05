using System;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200000C RID: 12
	public class 랓
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0003CAE2 File Offset: 0x0003ACE2
		public float 랾()
		{
			return this.랾;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0003CAEA File Offset: 0x0003ACEA
		public void 랾(float A_1)
		{
			this.랾 = Mathf.Max(0f, A_1);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0003CAFD File Offset: 0x0003ACFD
		public float 럎()
		{
			return this.럎;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0003CB05 File Offset: 0x0003AD05
		public float 람()
		{
			return Mathf.Max(0f, this.랾 - this.럎);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0003CB1E File Offset: 0x0003AD1E
		public bool 럒()
		{
			return this.럎 >= this.랾;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0003CB31 File Offset: 0x0003AD31
		public float 럼()
		{
			if (this.랾 > 0f)
			{
				return Mathf.Clamp01(this.럎 / this.랾);
			}
			return 1f;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0003CB58 File Offset: 0x0003AD58
		public 랓(float A_1)
		{
			this.랾 = Mathf.Max(0f, A_1);
			this.럎 = 0f;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0003CB7C File Offset: 0x0003AD7C
		public void 럎(float A_1)
		{
			this.럎 += A_1;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0003CB8C File Offset: 0x0003AD8C
		public bool 람(float A_1)
		{
			this.럎 += A_1;
			return this.럎 >= this.랾;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0003CBAD File Offset: 0x0003ADAD
		public void 랋()
		{
			this.럎 = 0f;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0003CBBA File Offset: 0x0003ADBA
		public void 럒(float A_1)
		{
			this.랾 = Mathf.Max(0f, A_1);
			this.럎 = 0f;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0003CBD8 File Offset: 0x0003ADD8
		public void 랉()
		{
			this.럎 = this.랾;
		}

		// Token: 0x0400001C RID: 28
		private float 랾;

		// Token: 0x0400001D RID: 29
		private float 럎;
	}
}
