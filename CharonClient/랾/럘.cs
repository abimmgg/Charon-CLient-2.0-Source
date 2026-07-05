using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;

namespace 랾
{
	// Token: 0x0200006D RID: 109
	internal static class 럘
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x00080450 File Offset: 0x0007E650
		public static string 랾(BSONObject A_0)
		{
			string text;
			if (!럘.랾(A_0, "ID", out text) || string.IsNullOrWhiteSpace(text))
			{
				return "UNKNOWN";
			}
			return text;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0008047C File Offset: 0x0007E67C
		public static bool 랾(BSONObject A_0, string A_1, out BSONObject A_2)
		{
			A_2 = null;
			if (!럘.랾(A_0, A_1))
			{
				return false;
			}
			bool result;
			try
			{
				BSONValue bsonvalue = A_0[A_1];
				if (bsonvalue == null)
				{
					result = false;
				}
				else
				{
					A_2 = bsonvalue.TryCast<BSONObject>();
					if (A_2 != null)
					{
						result = true;
					}
					else if (bsonvalue.valueType != 3 || bsonvalue.binaryValue == null || bsonvalue.binaryValue.Length == 0)
					{
						result = false;
					}
					else
					{
						A_2 = SimpleBSON.Load(bsonvalue.binaryValue);
						result = (A_2 != null);
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00080514 File Offset: 0x0007E714
		public static bool 랾(BSONObject A_0, string A_1, out string A_2)
		{
			A_2 = null;
			if (!럘.랾(A_0, A_1))
			{
				return false;
			}
			bool result;
			try
			{
				A_2 = A_0[A_1].stringValue;
				result = (A_2 != null);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0008055C File Offset: 0x0007E75C
		public static bool 랾(BSONObject A_0, string A_1, out int A_2)
		{
			A_2 = 0;
			if (!럘.랾(A_0, A_1))
			{
				return false;
			}
			bool result;
			try
			{
				BSONValue bsonvalue = A_0[A_1];
				BSONValue.ValueType valueType = bsonvalue.valueType;
				if (valueType != 7)
				{
					if (valueType != 8)
					{
						result = false;
					}
					else
					{
						A_2 = (int)bsonvalue.int64Value;
						result = true;
					}
				}
				else
				{
					A_2 = bsonvalue.int32Value;
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000805C4 File Offset: 0x0007E7C4
		public static bool 랾(BSONObject A_0, string A_1, out bool A_2)
		{
			A_2 = false;
			if (!럘.랾(A_0, A_1))
			{
				return false;
			}
			bool result;
			try
			{
				A_2 = A_0[A_1].boolValue;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00080608 File Offset: 0x0007E808
		public static bool 랾(BSONObject A_0, string A_1, out List<int> A_2)
		{
			A_2 = null;
			if (!럘.랾(A_0, A_1))
			{
				return false;
			}
			bool result;
			try
			{
				A_2 = A_0[A_1];
				result = (A_2 != null);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00080650 File Offset: 0x0007E850
		public static int 럎(BSONObject A_0)
		{
			if (A_0 == null)
			{
				return 0;
			}
			int result;
			try
			{
				Il2CppStructArray<byte> il2CppStructArray = SimpleBSON.Dump(A_0);
				result = ((il2CppStructArray != null) ? il2CppStructArray.Length : 0);
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0003E798 File Offset: 0x0003C998
		private static bool 랾(BSONObject A_0, string A_1)
		{
			return A_0 != null && !string.IsNullOrEmpty(A_1) && A_0.ContainsKey(A_1);
		}
	}
}
