using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200009B RID: 155
	internal static class 랽
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x0009ACF0 File Offset: 0x00098EF0
		public static Color 랾(string A_0, Color A_1)
		{
			Color result;
			if (!랽.랾(A_0, out result))
			{
				return A_1;
			}
			return result;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0009AD0C File Offset: 0x00098F0C
		public static bool 랾(string A_0, out Color A_1)
		{
			A_1 = default(Color);
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			string text = A_0.Trim();
			if (text.StartsWith("#", StringComparison.Ordinal))
			{
				text = text.Substring(1);
			}
			if (text.Length != 6 && text.Length != 8)
			{
				return false;
			}
			bool result;
			try
			{
				byte b = byte.Parse(text.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				byte b2 = byte.Parse(text.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				byte b3 = byte.Parse(text.Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				byte b4 = (text.Length == 8) ? byte.Parse(text.Substring(6, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture) : byte.MaxValue;
				A_1 = new Color32(b, b2, b3, b4);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0009AE00 File Offset: 0x00099000
		public static string 랾(Color A_0)
		{
			Color32 color = A_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 4);
			defaultInterpolatedStringHandler.AppendLiteral("#");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(color.r, "X2");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(color.g, "X2");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(color.b, "X2");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(color.a, "X2");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0003F476 File Offset: 0x0003D676
		public static Vector4 럎(Color A_0)
		{
			return new Vector4(A_0.r, A_0.g, A_0.b, A_0.a);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0003F495 File Offset: 0x0003D695
		public static Color 랾(Vector4 A_0)
		{
			return new Color(Mathf.Clamp01(A_0.X), Mathf.Clamp01(A_0.Y), Mathf.Clamp01(A_0.Z), Mathf.Clamp01(A_0.W));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0003F4C8 File Offset: 0x0003D6C8
		public static Vector4 랾(Vector4 A_0, float A_1)
		{
			return new Vector4(A_0.X, A_0.Y, A_0.Z, Mathf.Clamp01(A_1));
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0003F4E7 File Offset: 0x0003D6E7
		public static Vector4 럎(Vector4 A_0, float A_1)
		{
			return 랽.랾(A_0, A_0.W * A_1);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0009AE78 File Offset: 0x00099078
		public static Vector4 랾(Vector4 A_0, Vector4 A_1, float A_2)
		{
			A_2 = Mathf.Clamp01(A_2);
			return new Vector4(Mathf.Lerp(A_0.X, A_1.X, A_2), Mathf.Lerp(A_0.Y, A_1.Y, A_2), Mathf.Lerp(A_0.Z, A_1.Z, A_2), Mathf.Lerp(A_0.W, A_1.W, A_2));
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0009AEDC File Offset: 0x000990DC
		public static Vector4 람(Vector4 A_0, float A_1)
		{
			A_1 = Mathf.Clamp01(A_1);
			return new Vector4(Mathf.Lerp(A_0.X, 1f, A_1), Mathf.Lerp(A_0.Y, 1f, A_1), Mathf.Lerp(A_0.Z, 1f, A_1), A_0.W);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0009AF34 File Offset: 0x00099134
		public static Vector4 럒(Vector4 A_0, float A_1)
		{
			A_1 = Mathf.Clamp01(A_1);
			return new Vector4(Mathf.Lerp(A_0.X, 0f, A_1), Mathf.Lerp(A_0.Y, 0f, A_1), Mathf.Lerp(A_0.Z, 0f, A_1), A_0.W);
		}
	}
}
