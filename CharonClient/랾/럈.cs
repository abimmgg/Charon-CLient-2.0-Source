using System;
using System.Numerics;
using ImGuiNET;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000074 RID: 116
	public static class 럈
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x0003E9AB File Offset: 0x0003CBAB
		private static uint 랾(Color A_0)
		{
			return ImGui.ColorConvertFloat4ToU32(new Vector4(A_0.r, A_0.g, A_0.b, A_0.a));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0003E9CF File Offset: 0x0003CBCF
		private static ImDrawListPtr 랾()
		{
			return ImGui.GetForegroundDrawList();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0003E9D6 File Offset: 0x0003CBD6
		private static Vector2 랾(Vector2 A_0)
		{
			return new Vector2(A_0.x, A_0.y);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00082C90 File Offset: 0x00080E90
		public static void 랾(Vector2 A_0, Vector2 A_1, Color A_2, float A_3)
		{
			럈.랾().AddLine(럈.랾(A_0), 럈.랾(A_1), 럈.랾(A_2), A_3);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0003E9E9 File Offset: 0x0003CBE9
		public static void 럎(Vector2 A_0, Vector2 A_1, Color A_2, float A_3 = 1f)
		{
			럈.랾(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00082CC0 File Offset: 0x00080EC0
		public static void 랾(Vector2 A_0, float A_1, Color A_2)
		{
			if (A_1 <= 0.01f)
			{
				return;
			}
			럈.랾().AddCircleFilled(럈.랾(A_0), A_1, 럈.랾(A_2));
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00082CF0 File Offset: 0x00080EF0
		public static void 랾(float A_0, float A_1, float A_2, float A_3, Color A_4, float A_5)
		{
			Vector2 vector = new Vector2(A_0, A_1);
			Vector2 vector2 = new Vector2(A_0 + A_2, A_1 + A_3);
			럈.랾().AddRect(vector, vector2, 럈.랾(A_4), 0f, 0, A_5);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		public static void 랾(Vector2 A_0, float A_1, float A_2, Color A_3, float A_4)
		{
			럈.랾(A_0.x, A_0.y, A_1, A_2, A_3, A_4);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00082D34 File Offset: 0x00080F34
		public static void 랾(float A_0, float A_1, float A_2, float A_3, Color A_4)
		{
			Vector2 vector = new Vector2(A_0, A_1);
			Vector2 vector2 = new Vector2(A_0 + A_2, A_1 + A_3);
			럈.랾().AddRectFilled(vector, vector2, 럈.랾(A_4));
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00082D70 File Offset: 0x00080F70
		public static void 랾(Vector2 A_0, Vector2 A_1, Color A_2, bool A_3 = true)
		{
			Vector2 vector = A_3 ? (A_0 - A_1 / 2f) : A_0;
			럈.랾(vector.x, vector.y, A_1.x, A_1.y, A_2);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00082DB4 File Offset: 0x00080FB4
		public static void 랾(Vector3 A_0, Vector3 A_1, bool A_2, Color A_3)
		{
			float num = A_1.y - A_0.y;
			float num2 = A_2 ? (num / 2f) : num;
			float num3 = num2 / 2f;
			float num4 = (float)Screen.height;
			float num5 = num4 - A_1.y;
			float num6 = num4 - A_0.y;
			럈.랾(A_0.x - num3, num5, num2, num6 - num5, A_3, 1f);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00082E18 File Offset: 0x00081018
		public static void 랾(Vector3 A_0, bool A_1, float A_2, Color A_3)
		{
			Camera main = Camera.main;
			if (main == null)
			{
				return;
			}
			Vector3 vector = main.WorldToScreenPoint(A_0);
			Vector3 vector2 = main.WorldToScreenPoint(A_0 + new Vector3(0f, A_2, 0f));
			럈.랾(vector, vector2, A_1, A_3);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00082E64 File Offset: 0x00081064
		public static void 랾(string A_0, float A_1, float A_2, Color A_3, int A_4)
		{
			Vector2 vector = new Vector2(A_1, A_2);
			uint num = 럈.랾(A_3);
			if (A_4 > 0)
			{
				럈.랾().AddText(ImGui.GetFont(), (float)A_4, vector, num, A_0);
				return;
			}
			럈.랾().AddText(vector, num, A_0);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00082EB0 File Offset: 0x000810B0
		public static Vector2 랾(string A_0, int A_1)
		{
			if (A_1 > 0)
			{
				float num = (float)A_1 / ImGui.GetFontSize();
				Vector2 vector = ImGui.CalcTextSize(A_0);
				return new Vector2(vector.X * num, vector.Y * num);
			}
			Vector2 vector2 = ImGui.CalcTextSize(A_0);
			return new Vector2(vector2.X, vector2.Y);
		}
	}
}
