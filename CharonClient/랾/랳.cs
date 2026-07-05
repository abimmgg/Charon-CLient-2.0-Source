using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using BasicTypes;
using CharonClient.Configuration;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Kernys.Bson;
using Microsoft.CSharp.RuntimeBinder;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200011D RID: 285
	internal class 랳
	{
		// Token: 0x060008ED RID: 2285 RVA: 0x000ADCD4 File Offset: 0x000ABED4
		public static bool 랾()
		{
			if (!global::랾.럽.랾())
			{
				return false;
			}
			try
			{
				if (LoadingScreenController.instance != null && LoadingScreenController.instance.isActiveAndEnabled)
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			WorldController worldController = ControllerHelper.worldController;
			if (worldController == null || worldController.world == null)
			{
				return false;
			}
			if (!(global::랾.럓.랾 ?? worldController.player))
			{
				return false;
			}
			try
			{
				World world = worldController.world;
				if (world.worldSizeX <= 0 || world.worldSizeY <= 0)
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0004100E File Offset: 0x0003F20E
		public static bool 럎()
		{
			return 랳.랾() && Camera.main != null;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000ADD88 File Offset: 0x000ABF88
		private static void 랾(Action A_0, Action A_1 = null)
		{
			try
			{
				if (A_0 != null)
				{
					A_0();
				}
			}
			catch
			{
				if (A_1 != null)
				{
					A_1();
				}
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00041024 File Offset: 0x0003F224
		private static Color 랾(string A_0, Color A_1)
		{
			return global::랾.랽.랾(A_0, A_1);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0004102D File Offset: 0x0003F22D
		private static Color 람()
		{
			return 랳.랾(ConfigFile.uiEspPlayerColor, new Color(0.2f, 1f, 0.45f, 1f));
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00041052 File Offset: 0x0003F252
		private static Color 럒()
		{
			return 랳.랾(ConfigFile.uiEspEnemyColor, new Color(1f, 0.2f, 0.2f, 1f));
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00041077 File Offset: 0x0003F277
		private static Color 럼()
		{
			return 랳.랾(ConfigFile.uiEspStaffColor, new Color(1f, 0.3f, 0.9f, 1f));
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0004109C File Offset: 0x0003F29C
		private static Color 랋()
		{
			return 랳.랾(ConfigFile.uiEspCollectableColor, new Color(0.2f, 0.55f, 1f, 1f));
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000410C1 File Offset: 0x0003F2C1
		private static Color 랉()
		{
			return 랳.랾(ConfigFile.uiEspGiftBoxColor, new Color(1f, 0.85f, 0.15f, 1f));
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000410E6 File Offset: 0x0003F2E6
		private static Color 럐()
		{
			return 랳.랾(ConfigFile.uiEspOreColor, Color.white);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000410F7 File Offset: 0x0003F2F7
		private static Color 랓()
		{
			return 랳.랾(ConfigFile.uiEspPortalUnlockedColor, Color.green);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00041108 File Offset: 0x0003F308
		private static Color 럯()
		{
			return 랳.랾(ConfigFile.uiEspPortalLockedColor, new Color(1f, 0.3f, 0.3f, 1f));
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0004112D File Offset: 0x0003F32D
		private static Color 럭()
		{
			return 랳.랾(ConfigFile.uiEspButterflyColor, Color.yellow);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0004113E File Offset: 0x0003F33E
		private static Color 랱()
		{
			return 랳.랾(ConfigFile.uiEspEventColor, Color.magenta);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0004114F File Offset: 0x0003F34F
		private static Color 럙()
		{
			return 랳.랾(ConfigFile.uiEspNetherBossColor, new Color(1f, 0.88f, 0.2f, 1f));
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00041174 File Offset: 0x0003F374
		private static Color 랫()
		{
			return 랳.랾(ConfigFile.uiEspNetherKeyColor, new Color(1f, 0.85f, 0.15f, 1f));
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00041199 File Offset: 0x0003F399
		private static Color 럍()
		{
			return 랳.랾(ConfigFile.uiEspNetherExitColor, new Color(1f, 0.55f, 0.1f, 1f));
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000411BE File Offset: 0x0003F3BE
		private static Color 랬()
		{
			return 랳.랾(ConfigFile.uiEspSwordColor, Color.black);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000411CF File Offset: 0x0003F3CF
		private static Color 란()
		{
			return 랳.랾(ConfigFile.uiEspCrossBreedColor, new Color(0.2f, 1f, 0.55f, 1f));
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000411F4 File Offset: 0x0003F3F4
		private static Color 럇()
		{
			return 랳.랾(ConfigFile.uiEspCrossBreedNewColor, new Color(1f, 0.8f, 0.2f, 1f));
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00041219 File Offset: 0x0003F419
		private static Color 랯()
		{
			return 랳.랾(ConfigFile.uiPathHoverColor, new Color(0.35f, 0.85f, 1f, 0.8f));
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0004123E File Offset: 0x0003F43E
		private static Color 러()
		{
			return 랳.랾(ConfigFile.uiPathTeleportColor, new Color(0.35f, 0.85f, 1f, 0.95f));
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00041263 File Offset: 0x0003F463
		private static Color 량()
		{
			return 랳.랾(ConfigFile.uiPathMiningColor, new Color(1f, 0.65f, 0.15f, 0.8f));
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00041288 File Offset: 0x0003F488
		private static Color 럑()
		{
			return 랳.랾(ConfigFile.uiPathReachableColor, new Color(0.2f, 1f, 0.45f, 0.95f));
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000412AD File Offset: 0x0003F4AD
		private static Color 럊()
		{
			return 랳.랾(ConfigFile.uiPathBreakTargetColor, new Color(1f, 0.46f, 0.84f, 0.98f));
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000412D2 File Offset: 0x0003F4D2
		private static float 랾(float A_0)
		{
			return Mathf.Max(0.65f, A_0 * Mathf.Clamp(ConfigFile.uiPathLineThicknessScale, 0.75f, 3f));
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000ADDBC File Offset: 0x000ABFBC
		private static NetworkPlayer[] 랠()
		{
			NetworkPlayer[] result;
			try
			{
				List<NetworkPlayer> otherPlayers = NetworkPlayers.otherPlayers;
				result = ((otherPlayers != null) ? otherPlayers.ToArray() : null);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000ADDF8 File Offset: 0x000ABFF8
		private static CollectableData[] 랾(World A_0)
		{
			CollectableData[] result;
			try
			{
				Il2CppArrayBase<CollectableData> il2CppArrayBase;
				if (A_0 == null)
				{
					il2CppArrayBase = null;
				}
				else
				{
					List<CollectableData> collectables = A_0.collectables;
					il2CppArrayBase = ((collectables != null) ? collectables.ToArray() : null);
				}
				result = il2CppArrayBase;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000ADE3C File Offset: 0x000AC03C
		private static bool 랾(Vector3 A_0, out Vector3 A_1)
		{
			Camera main = Camera.main;
			if (main == null)
			{
				A_1 = default(Vector3);
				return false;
			}
			A_1 = main.WorldToScreenPoint(A_0);
			return A_1.z > 0.1f;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000412F4 File Offset: 0x0003F4F4
		private static Vector2 랾(Vector3 A_0)
		{
			return new Vector2(A_0.x, (float)Screen.height - A_0.y);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000ADE7C File Offset: 0x000AC07C
		private static bool 랾(Vector3 A_0, out Vector3 A_1, out Vector3 A_2, float A_3 = 0.1f, float A_4 = 0.2f)
		{
			Vector3 vector = new Vector3(A_0.x, A_0.y - A_3, A_0.z);
			Vector3 vector2;
			vector2..ctor(A_0.x, A_0.y + A_4, A_0.z);
			bool flag = 랳.랾(vector, out A_1);
			bool flag2 = 랳.랾(vector2, out A_2);
			return flag && flag2;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0004130E File Offset: 0x0003F50E
		private static bool 럎(float A_0)
		{
			return !float.IsNaN(A_0) && !float.IsInfinity(A_0);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000ADED0 File Offset: 0x000AC0D0
		private static bool 럎(Vector3 A_0, out Vector3 A_1)
		{
			A_1 = default(Vector3);
			Camera main = Camera.main;
			if (main == null)
			{
				return false;
			}
			A_1 = main.WorldToScreenPoint(A_0);
			if (!랳.럎(A_1.x) || !랳.럎(A_1.y) || !랳.럎(A_1.z))
			{
				return false;
			}
			if (A_1.z <= 0.1f)
			{
				A_1.x = (float)Screen.width - A_1.x;
				A_1.y = (float)Screen.height - A_1.y;
				A_1.z = 0.1f;
			}
			return true;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000ADF6C File Offset: 0x000AC16C
		private static Vector2 랾(Vector3 A_0, float A_1 = 12f)
		{
			Vector2 vector;
			vector..ctor(A_0.x, (float)Screen.height - A_0.y);
			vector.x = Mathf.Clamp(vector.x, A_1, (float)Screen.width - A_1);
			vector.y = Mathf.Clamp(vector.y, A_1, (float)Screen.height - A_1);
			return vector;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000ADFCC File Offset: 0x000AC1CC
		private static bool 랾(Vector3 A_0, out Vector2 A_1, out Vector2 A_2, float A_3 = 0.25f, float A_4 = 0.25f)
		{
			A_1 = default(Vector2);
			A_2 = default(Vector2);
			if (global::랾.럓.랾 == null)
			{
				return false;
			}
			Vector3 position = global::랾.럓.랾.transform.position;
			position.y += A_3;
			Vector3 vector = A_0;
			vector.y += A_4;
			Vector3 vector2;
			if (!랳.럎(position, out vector2))
			{
				return false;
			}
			Vector3 vector3;
			if (!랳.럎(vector, out vector3))
			{
				return false;
			}
			A_1 = 랳.랾(vector2, 12f);
			A_2 = 랳.랾(vector3, 12f);
			return (A_2 - A_1).sqrMagnitude >= 4f;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000AE080 File Offset: 0x000AC280
		private static bool 랾(Vector3 A_0, out Vector2 A_1)
		{
			A_1 = default(Vector2);
			Camera main = Camera.main;
			if (main == null)
			{
				return false;
			}
			Vector3 vector = main.WorldToScreenPoint(A_0);
			if (!랳.럎(vector.x) || !랳.럎(vector.y) || !랳.럎(vector.z) || vector.z <= 0.1f)
			{
				return false;
			}
			Vector2 vector2 = 랳.랾(vector);
			if (vector2.x < -64f || vector2.x > (float)Screen.width + 64f || vector2.y < -64f || vector2.y > (float)Screen.height + 64f)
			{
				return false;
			}
			A_1 = vector2;
			return true;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000AE138 File Offset: 0x000AC338
		private static void 랾(Vector3 A_0, Color A_1, float A_2 = 1.5f, float A_3 = 0.25f)
		{
			Vector2 vector;
			Vector2 vector2;
			if (!랳.랾(A_0, out vector, out vector2, 0.25f, A_3))
			{
				return;
			}
			global::랾.럈.랾(vector, vector2, A_1, A_2);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000AE164 File Offset: 0x000AC364
		private static void 랾(Vector3 A_0, Vector3 A_1, Color A_2, float A_3 = 1.5f)
		{
			float num = (float)Screen.height - A_1.y;
			float num2 = (float)Screen.height - A_0.y;
			float num3 = Mathf.Min(num, num2);
			float num4 = Mathf.Abs(num2 - num);
			if (num4 < 1f)
			{
				return;
			}
			float num5 = Mathf.Max(8f, num4 * 0.5f);
			global::랾.럈.랾(A_0.x - num5 * 0.5f, num3, num5, num4, A_2, A_3);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000AE1D4 File Offset: 0x000AC3D4
		private static void 랾(Vector3 A_0, float A_1, Color A_2, float A_3 = 1.25f)
		{
			Vector2 vector = 랳.랾(A_0);
			float num = A_1 * 0.5f;
			global::랾.럈.랾(vector.x - num, vector.y - num, A_1, A_1, A_2, A_3);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000AE20C File Offset: 0x000AC40C
		private static void 랾(랳.랾[] A_0, float A_1 = 1.5f, float A_2 = 0.25f)
		{
			foreach (랳.랾 랾 in A_0)
			{
				랳.랾(랾.랾(), 랾.럎(), A_1, A_2);
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000AE244 File Offset: 0x000AC444
		public static void 럏()
		{
			랳.럎[] array = 랳.랾;
			if (array.Length == 0)
			{
				return;
			}
			float num = 16f;
			Color color = 랳.란();
			Color color2;
			color2..ctor(color.r * 0.25f, color.g * 0.3f, color.b * 0.25f, 0.22f);
			Color color3 = 랳.럇();
			Color color4;
			color4..ctor(color3.r * 0.36f, color3.g * 0.24f, color3.b * 0.1f, 0.24f);
			foreach (랳.럎 럎 in array)
			{
				Vector3 vector;
				if (랳.랾(global::랾.럽.랾(럎.랾), out vector))
				{
					Vector2 vector2 = 랳.랾(vector);
					float num2 = vector2.x - num;
					float num3 = vector2.y - num;
					Color color5 = 럎.랾 ? color3 : color;
					Color color6 = 럎.랾 ? color4 : color2;
					global::랾.럈.랾(num2, num3, 32f, 32f, color6);
					global::랾.럈.랾(num2, num3, 32f, 32f, color5, 2f);
					string text = 럎.랾 + " -> " + 럎.럎;
					if (럎.랾 > 0)
					{
						string str = text;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
						defaultInterpolatedStringHandler.AppendLiteral(" (+");
						defaultInterpolatedStringHandler.AppendFormatted<int>(럎.랾);
						defaultInterpolatedStringHandler.AppendLiteral(")");
						text = str + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (럎.랾)
					{
						text += " [NEW RECIPE]";
					}
					Vector2 vector3 = global::랾.럈.랾(text, 0);
					float num4 = Mathf.Clamp(vector2.x - vector3.x * 0.5f, 4f, Mathf.Max(4f, (float)Screen.width - vector3.x - 4f));
					float num5 = Mathf.Clamp(num3 - vector3.y - 6f, 4f, Mathf.Max(4f, (float)Screen.height - vector3.y - 4f));
					global::랾.럈.랾(num4 - 4f, num5 - 2f, vector3.x + 8f, vector3.y + 4f, new Color(0f, 0f, 0f, 0.55f));
					랳.랾(text, num4, num5, color5);
				}
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000AE4CC File Offset: 0x000AC6CC
		private static void 럫()
		{
			if (랳.럎 == ConfigFile.crossBreedSeedEspNewRecipesOnly && Time.realtimeSinceStartup < 랳.럼)
			{
				return;
			}
			랳.럎 = ConfigFile.crossBreedSeedEspNewRecipesOnly;
			랳.럼 = Time.realtimeSinceStartup + 0.35f;
			랳.랾.Clear();
			if (!ConfigFile.crossBreedSeedEspToggle)
			{
				return;
			}
			World world = global::랾.럓.랾;
			PlayerData playerData = global::랾.럓.랾;
			if (((world != null) ? world.plantedSeeds : null) == null || playerData == null)
			{
				return;
			}
			List<랳.람> list = 랳.랾(playerData);
			if (list.Count == 0)
			{
				return;
			}
			HashSet<long> hashSet = new HashSet<long>();
			Il2CppReferenceArray<Il2CppReferenceArray<SeedData>> plantedSeeds = world.plantedSeeds;
			DateTime dateTime = KukouriTime.Get();
			for (int i = 0; i < plantedSeeds.Length; i++)
			{
				SeedData[] array = plantedSeeds[i];
				if (array != null)
				{
					foreach (SeedData seedData in array)
					{
						if (seedData != null)
						{
							Vector2i position = seedData.position;
							long item = (long)position.x << 32 | (long)((ulong)position.y);
							랳.럎 럎;
							if (hashSet.Add(item) && world.IsMapPointInWorld(position) && 랳.랾(seedData, dateTime) && 랳.랾(seedData, list, out 럎) && (!ConfigFile.crossBreedSeedEspNewRecipesOnly || 럎.랾))
							{
								랳.랾.Add(럎);
							}
						}
					}
				}
			}
			랳.랾 = 랳.랾.ToArray();
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000AE63C File Offset: 0x000AC83C
		private static bool 랾(SeedData A_0, dynamic now)
		{
			if (A_0 == null || A_0.isAlreadyCrossBred || A_0.blockType == null)
			{
				return false;
			}
			try
			{
				if (랳.랋.랾 == null)
				{
					랳.랋.랾 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(랳), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = 랳.랋.랾.Target;
				CallSite arg = 랳.랋.랾;
				if (랳.랋.랾 == null)
				{
					랳.랋.랾 = CallSite<Func<CallSite, DateTime, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThanOrEqual, typeof(랳), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target(arg, 랳.랋.랾.Target(랳.랋.랾, A_0.growthEndTime, now)))
				{
					return false;
				}
				if (랳.랋.럎 == null)
				{
					랳.랋.럎 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(랳), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target2 = 랳.랋.럎.Target;
				CallSite arg2 = 랳.랋.럎;
				if (랳.랋.럎 == null)
				{
					랳.랋.럎 = CallSite<Func<CallSite, DateTime, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThanOrEqual, typeof(랳), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target2(arg2, 랳.랋.럎.Target(랳.랋.럎, A_0.GetLastPossibleCrossbreedTime(), now)))
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000AE7D4 File Offset: 0x000AC9D4
		private static List<랳.람> 랾(PlayerData A_0)
		{
			List<랳.람> list = new List<랳.람>();
			PlayerData.InventoryKey[] array = A_0.GetInventoryAsOrderedByInventoryItemType();
			if (array == null)
			{
				return list;
			}
			foreach (PlayerData.InventoryKey inventoryKey in array)
			{
				if (inventoryKey.itemType == 2)
				{
					short count = A_0.GetCount(inventoryKey);
					if (count > 0)
					{
						string text = 랳.랾(inventoryKey);
						list.Add(new 랳.람(inventoryKey.blockType, count, text));
					}
				}
			}
			list.Sort(new Comparison<랳.람>(랳.럼.랾.랾));
			return list;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000AE868 File Offset: 0x000ACA68
		private static bool 랾(SeedData A_0, List<랳.람> A_1, out 랳.럎 A_2)
		{
			A_2 = null;
			랳.람? 람 = null;
			World.BlockType blockType = 0;
			bool flag = false;
			int num = 0;
			for (int i = 0; i < A_1.Count; i++)
			{
				랳.람 value = A_1[i];
				World.BlockType blockType2 = 랳.랾(value.랾(), A_0.blockType);
				if (blockType2 != null)
				{
					num++;
					bool flag2 = 랳.럎(blockType2);
					if (람 == null || (flag2 && !flag))
					{
						람 = new 랳.람?(value);
						blockType = blockType2;
						flag = flag2;
					}
				}
			}
			if (람 == null || blockType == null)
			{
				return false;
			}
			A_2 = new 랳.럎
			{
				랾 = A_0.position,
				랾 = 람.Value.람(),
				럎 = 랳.랾(blockType),
				랾 = Mathf.Max(0, num - 1),
				랾 = flag
			};
			return true;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000AE944 File Offset: 0x000ACB44
		private static World.BlockType 랾(World.BlockType A_0, World.BlockType A_1)
		{
			try
			{
				World.BlockType crossBreedingResult = Seeds.GetCrossBreedingResult(new BlockTuple(A_0, A_1));
				if (crossBreedingResult != null)
				{
					return crossBreedingResult;
				}
			}
			catch
			{
			}
			World.BlockType result;
			try
			{
				result = Seeds.GetCrossBreedingResult(new BlockTuple(A_1, A_0));
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000AE99C File Offset: 0x000ACB9C
		private static string 랾(PlayerData.InventoryKey A_0)
		{
			try
			{
				string blockTypeOrSeedName = TextManager.GetBlockTypeOrSeedName(A_0);
				if (!string.IsNullOrWhiteSpace(blockTypeOrSeedName))
				{
					return blockTypeOrSeedName;
				}
			}
			catch
			{
			}
			return 랳.랾(A_0.blockType);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000A200C File Offset: 0x000A020C
		private static string 랾(World.BlockType A_0)
		{
			try
			{
				string blockTypeName = TextManager.GetBlockTypeName(A_0);
				if (!string.IsNullOrWhiteSpace(blockTypeName))
				{
					return blockTypeName;
				}
			}
			catch
			{
			}
			return A_0.ToString();
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000AE9E0 File Offset: 0x000ACBE0
		private static bool 럎(World.BlockType A_0)
		{
			bool result;
			try
			{
				result = (global::랾.럓.랾 != null && !global::랾.럓.랾.HasUnlockedRecipe(A_0));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000A2458 File Offset: 0x000A0658
		private static void 랾(string A_0, float A_1, float A_2, Color A_3)
		{
			Color color;
			color..ctor(0f, 0f, 0f, 1f);
			global::랾.럈.랾(A_0, A_1 - 1f, A_2, color, 0);
			global::랾.럈.랾(A_0, A_1 + 1f, A_2, color, 0);
			global::랾.럈.랾(A_0, A_1, A_2 - 1f, color, 0);
			global::랾.럈.랾(A_0, A_1, A_2 + 1f, color, 0);
			global::랾.럈.랾(A_0, A_1, A_2, A_3, 0);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000AEA20 File Offset: 0x000ACC20
		public static void 럴()
		{
			WorldController worldController = ControllerHelper.worldController;
			World world = (worldController != null) ? worldController.world : null;
			if (world == null || global::랾.럓.랾 == null)
			{
				return;
			}
			if (world.worldName != "MINEWORLD")
			{
				return;
			}
			랳.럎(world);
			for (int i = 0; i < 랳.랾.Count; i++)
			{
				Vector2i vector2i = 랳.랾[i];
				랳.랾(ControllerHelper.worldController.ConvertMapPointToWorldPoint(vector2i.x, vector2i.y), 랳.럐(), 1f, 0.25f);
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000AEAB4 File Offset: 0x000ACCB4
		private static void 럎(World A_0)
		{
			if (Time.realtimeSinceStartup < 랳.럐)
			{
				return;
			}
			랳.럐 = Time.realtimeSinceStartup + 0.2f;
			랳.랾.Clear();
			try
			{
				for (int i = 0; i < A_0.worldSizeY; i++)
				{
					for (int j = 0; j < A_0.worldSizeX; j++)
					{
						World.BlockType blockType = A_0.GetBlockType(j, i);
						if (Array.IndexOf<World.BlockType>(랳.랾, blockType) >= 0)
						{
							랳.랾.Add(new Vector2i(j, i));
						}
					}
				}
			}
			catch
			{
				랳.랾.Clear();
				랳.럐 = 0f;
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000AEB5C File Offset: 0x000ACD5C
		private static void 럲()
		{
			WorldController worldController = ControllerHelper.worldController;
			World world = (worldController != null) ? worldController.world : null;
			if (world == null || worldController == null)
			{
				랳.럩();
				return;
			}
			bool flag = 랳.랾 != world;
			bool flag2 = 랳.랾 != ConfigFile.giftBoxESPUntakenOnly;
			if (!flag && !flag2 && Time.realtimeSinceStartup < 랳.람)
			{
				return;
			}
			랳.랾 = world;
			랳.랾 = ConfigFile.giftBoxESPUntakenOnly;
			랳.람 = Time.realtimeSinceStartup + 0.25f;
			랳.랾.Clear();
			랳.럎.Clear();
			랳.람.Clear();
			랳.럒.Clear();
			랳.럼.Clear();
			if (world.worldSizeX <= 0 || world.worldSizeY <= 0 || world.worldSizeX > 20000 || world.worldSizeY > 20000)
			{
				랳.럩();
				return;
			}
			try
			{
				for (int i = 0; i < world.worldSizeY; i++)
				{
					for (int j = 0; j < world.worldSizeX; j++)
					{
						World.BlockType blockType = world.GetBlockType(j, i);
						if (Array.IndexOf<World.BlockType>(랳.럎, blockType) >= 0)
						{
							Vector3 vector = worldController.ConvertMapPointToWorldPoint(j, i);
							랳.랾.Add(new 랳.랾(vector, 랳.럎(world, j, i)));
						}
						if (Array.IndexOf<World.BlockType>(랳.람, blockType) >= 0 && 랳.랾(world, j, i))
						{
							Vector3 vector = worldController.ConvertMapPointToWorldPoint(j, i);
							랳.럎.Add(new 랳.랾(vector, 랳.랉()));
						}
						if (Array.IndexOf<World.BlockType>(랳.럒, blockType) >= 0)
						{
							Vector3 vector = worldController.ConvertMapPointToWorldPoint(j, i);
							랳.람.Add(new 랳.랾(vector, 랳.럍()));
						}
						if (blockType == 2274)
						{
							Vector3 vector = worldController.ConvertMapPointToWorldPoint(j, i);
							랳.럒.Add(new 랳.랾(vector, 랳.랬()));
						}
						if (Array.IndexOf<World.BlockType>(랳.럼, blockType) >= 0)
						{
							Vector3 vector = worldController.ConvertMapPointToWorldPoint(j, i);
							랳.럼.Add(new 랳.랾(vector, 랳.럭()));
						}
					}
				}
			}
			catch
			{
				랳.럩();
				return;
			}
			랳.랾 = 랳.랾.ToArray();
			랳.럎 = 랳.럎.ToArray();
			랳.람 = 랳.람.ToArray();
			랳.럒 = 랳.럒.ToArray();
			랳.럼 = 랳.럼.ToArray();
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000AEDF4 File Offset: 0x000ACFF4
		private static void 럩()
		{
			랳.랾 = null;
			랳.랾 = ConfigFile.giftBoxESPUntakenOnly;
			랳.람 = 0f;
			랳.랾.Clear();
			랳.럎.Clear();
			랳.람.Clear();
			랳.럒.Clear();
			랳.럼.Clear();
			랳.랾 = Array.Empty<랳.랾>();
			랳.럎 = Array.Empty<랳.랾>();
			랳.람 = Array.Empty<랳.랾>();
			랳.럒 = Array.Empty<랳.랾>();
			랳.럼 = Array.Empty<랳.랾>();
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000AEE8C File Offset: 0x000AD08C
		private static bool 랾(World A_0, int A_1, int A_2)
		{
			if (!ConfigFile.giftBoxESPUntakenOnly)
			{
				return true;
			}
			WorldItemBase worldItemData = A_0.GetWorldItemData(A_1, A_2);
			return worldItemData != null && 랳.랾(worldItemData) && !랳.랾(worldItemData.itemId);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000AEEC8 File Offset: 0x000AD0C8
		private static bool 랾(WorldItemBase A_0)
		{
			bool result;
			try
			{
				BSONObject asBSON = A_0.GetAsBSON();
				if (asBSON == null)
				{
					result = false;
				}
				else
				{
					int num = 0;
					string text = string.Empty;
					try
					{
						if (asBSON.ContainsKey("itemAmount"))
						{
							num = asBSON["itemAmount"].int32Value;
						}
					}
					catch
					{
						num = 0;
					}
					try
					{
						if (asBSON.ContainsKey("blockType"))
						{
							text = (asBSON["blockType"].stringValue ?? string.Empty);
						}
					}
					catch
					{
						text = string.Empty;
					}
					result = (num > 0 && !string.IsNullOrWhiteSpace(text) && !string.Equals(text, "0", StringComparison.OrdinalIgnoreCase) && !string.Equals(text, "None", StringComparison.OrdinalIgnoreCase));
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000AEFAC File Offset: 0x000AD1AC
		private static bool 랾(int A_0)
		{
			if (A_0 <= 0)
			{
				return false;
			}
			try
			{
				PlayerData playerData = global::랾.럓.랾;
				if (playerData == null || playerData.giftBoxesAccessed == null || playerData.giftBoxesAccessed.Count <= 0)
				{
					return false;
				}
				for (int i = 0; i < playerData.giftBoxesAccessed.Count; i++)
				{
					if (playerData.giftBoxesAccessed[i] == A_0)
					{
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000AF024 File Offset: 0x000AD224
		private static Color 럎(World A_0, int A_1, int A_2)
		{
			WorldItemBase worldItemData = A_0.GetWorldItemData(A_1, A_2);
			if (worldItemData == null)
			{
				return 랳.랓();
			}
			Color result;
			try
			{
				result = (worldItemData.GetAsBSON()["isLocked"].boolValue ? 랳.럯() : 랳.랓());
			}
			catch
			{
				result = 랳.랓();
			}
			return result;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00041323 File Offset: 0x0003F523
		public static void 랦()
		{
			랳.랾(랳.랾, 1.5f, 0.25f);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0004133B File Offset: 0x0003F53B
		public static void 럔()
		{
			랳.랾(랳.럎, 1.5f, 0.25f);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00041353 File Offset: 0x0003F553
		public static void 랞()
		{
			랳.랾(랳.람, 1.5f, 0.25f);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0004136B File Offset: 0x0003F56B
		public static void 럚()
		{
			랳.랾(랳.럒, 1.5f, 0.25f);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00041383 File Offset: 0x0003F583
		public static void 럳()
		{
			랳.랾(랳.럼, 1.5f, 0.25f);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0004139B File Offset: 0x0003F59B
		public static void 랢()
		{
			PlayerPool playerPool = ControllerHelper.playerPool;
			랳.랾((playerPool != null) ? playerPool.superHeroBlueParticle : null, 랳.랱());
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000413B8 File Offset: 0x0003F5B8
		public static void 럻()
		{
			PlayerPool playerPool = ControllerHelper.playerPool;
			랳.랾((playerPool != null) ? playerPool.easterEventEgg : null, 랳.랱());
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000413D5 File Offset: 0x0003F5D5
		public static void 랖()
		{
			PlayerPool playerPool = ControllerHelper.playerPool;
			랳.랾((playerPool != null) ? playerPool.valentinesDayFloatingHeart : null, 랳.랱());
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000413F2 File Offset: 0x0003F5F2
		private static void 랾(MonoBehaviour A_0, Color A_1)
		{
			if (!A_0 || !A_0.isActiveAndEnabled)
			{
				return;
			}
			랳.랾(A_0.transform.position, A_1, 1.5f, 0.1f);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000AF084 File Offset: 0x000AD284
		public static void 럝()
		{
			if (!랳.랾())
			{
				랳.럽();
				return;
			}
			Action action;
			if ((action = 랳.럒.랾) == null)
			{
				action = (랳.럒.랾 = new Action(랳.럧));
			}
			Action action2;
			if ((action2 = 랳.럒.럎) == null)
			{
				action2 = (랳.럒.럎 = new Action(랳.럓));
			}
			랳.랾(action, action2);
			Action action3;
			if ((action3 = 랳.럒.람) == null)
			{
				action3 = (랳.럒.람 = new Action(랳.럘));
			}
			Action action4;
			if ((action4 = 랳.럒.럒) == null)
			{
				action4 = (랳.럒.럒 = new Action(랳.랟));
			}
			랳.랾(action3, action4);
			Action action5;
			if ((action5 = 랳.럒.럼) == null)
			{
				action5 = (랳.럒.럼 = new Action(랳.럫));
			}
			Action action6;
			if ((action6 = 랳.럒.랋) == null)
			{
				action6 = (랳.럒.랋 = new Action(랳.랛));
			}
			랳.랾(action5, action6);
			Action action7;
			if ((action7 = 랳.럒.랉) == null)
			{
				action7 = (랳.럒.랉 = new Action(랳.럲));
			}
			Action action8;
			if ((action8 = 랳.럒.럐) == null)
			{
				action8 = (랳.럒.럐 = new Action(랳.럩));
			}
			랳.랾(action7, action8);
			Action action9;
			if ((action9 = 랳.럒.랓) == null)
			{
				action9 = (랳.럒.랓 = new Action(랳.럷));
			}
			Action action10;
			if ((action10 = 랳.럒.럯) == null)
			{
				action10 = (랳.럒.럯 = new Action(랳.럣));
			}
			랳.랾(action9, action10);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00041420 File Offset: 0x0003F620
		public static void 럽()
		{
			랳.럓();
			랳.랟();
			랳.랛();
			랳.럩();
			랳.럣();
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0004143B File Offset: 0x0003F63B
		public static IReadOnlyList<AIEnemyMonoBehaviourBase> 럜()
		{
			return 랳.랾;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00041444 File Offset: 0x0003F644
		private static IReadOnlyList<NetherBossWraithMonoBehaviour> 럕()
		{
			return 랳.랾;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000AF1C8 File Offset: 0x000AD3C8
		private static void 럘()
		{
			if (Time.realtimeSinceStartup < 랳.럯)
			{
				return;
			}
			랳.럯 = Time.realtimeSinceStartup + 0.15f;
			랳.랾.Clear();
			NetherBossWraithMonoBehaviour[] array;
			try
			{
				array = Object.FindObjectsOfType<NetherBossWraithMonoBehaviour>();
			}
			catch
			{
				랳.랟();
				return;
			}
			if (array == null)
			{
				return;
			}
			foreach (NetherBossWraithMonoBehaviour netherBossWraithMonoBehaviour in array)
			{
				if (netherBossWraithMonoBehaviour)
				{
					랳.랾.Add(netherBossWraithMonoBehaviour);
				}
			}
			랳.랾 = 랳.랾.ToArray();
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0004144D File Offset: 0x0003F64D
		private static void 랟()
		{
			랳.럯 = 0f;
			랳.랾.Clear();
			랳.랾 = Array.Empty<NetherBossWraithMonoBehaviour>();
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000AF260 File Offset: 0x000AD460
		public static void 랺()
		{
			IReadOnlyList<NetherBossWraithMonoBehaviour> readOnlyList = 랳.럕();
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				NetherBossWraithMonoBehaviour netherBossWraithMonoBehaviour = readOnlyList[i];
				if (netherBossWraithMonoBehaviour && netherBossWraithMonoBehaviour.isActiveAndEnabled)
				{
					랳.랾(netherBossWraithMonoBehaviour.transform.position, 랳.럙(), 1.5f, 0.25f);
				}
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000AF2BC File Offset: 0x000AD4BC
		public static void 럈()
		{
			IReadOnlyList<NetherBossWraithMonoBehaviour> readOnlyList = 랳.럕();
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				NetherBossWraithMonoBehaviour netherBossWraithMonoBehaviour = readOnlyList[i];
				if (netherBossWraithMonoBehaviour)
				{
					float value = (float)AIEnemyConfigData.GetMaxHitPoints(46);
					Rect rect = new Rect((float)Screen.width - 580f, 100f, 1000f, 180f);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
					defaultInterpolatedStringHandler.AppendLiteral("NetherBoss Detected: X: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(netherBossWraithMonoBehaviour.aiBase.mapPointX);
					defaultInterpolatedStringHandler.AppendLiteral(" Y: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(netherBossWraithMonoBehaviour.aiBase.mapPointY);
					GUI.Label(rect, defaultInterpolatedStringHandler.ToStringAndClear());
					Rect rect2 = new Rect((float)Screen.width - 580f, 125f, 1000f, 180f);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Health: ");
					defaultInterpolatedStringHandler2.AppendFormatted<float>(value);
					GUI.Label(rect2, defaultInterpolatedStringHandler2.ToStringAndClear());
				}
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000AF3C0 File Offset: 0x000AD5C0
		private static void 럧()
		{
			if (Time.realtimeSinceStartup < 랳.랱)
			{
				return;
			}
			랳.랱 = Time.realtimeSinceStartup + 0.15f;
			랳.랾.Clear();
			AIEnemyMonoBehaviourBase[] array;
			try
			{
				array = Object.FindObjectsOfType<AIEnemyMonoBehaviourBase>();
			}
			catch
			{
				랳.럓();
				return;
			}
			if (array == null)
			{
				return;
			}
			foreach (AIEnemyMonoBehaviourBase aienemyMonoBehaviourBase in array)
			{
				if (aienemyMonoBehaviourBase)
				{
					AIEnemyType enemyType;
					try
					{
						enemyType = aienemyMonoBehaviourBase.aiBase.GetEnemyType();
					}
					catch
					{
						goto IL_7F;
					}
					if (Array.IndexOf<AIEnemyType>(랳.랾, enemyType) < 0)
					{
						랳.랾.Add(aienemyMonoBehaviourBase);
					}
				}
				IL_7F:;
			}
			랳.랾 = 랳.랾.ToArray();
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0004146F File Offset: 0x0003F66F
		private static void 럓()
		{
			랳.랱 = 0f;
			랳.랾.Clear();
			랳.랾 = Array.Empty<AIEnemyMonoBehaviourBase>();
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000AF484 File Offset: 0x000AD684
		public static void 랊()
		{
			IReadOnlyList<AIEnemyMonoBehaviourBase> readOnlyList = 랳.럜();
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				AIEnemyMonoBehaviourBase aienemyMonoBehaviourBase = readOnlyList[i];
				if (aienemyMonoBehaviourBase && aienemyMonoBehaviourBase.isActiveAndEnabled)
				{
					Vector3 position = aienemyMonoBehaviourBase.transform.position;
					Color color = 랳.럒();
					Vector3 vector;
					Vector3 vector2;
					if (ConfigFile.enemyESPBox && 랳.랾(position, out vector, out vector2, 0.1f, 0.2f))
					{
						랳.랾(vector, vector2, color, 1.5f);
					}
					if (ConfigFile.enemyESPTracer)
					{
						랳.랾(position, color, 2f, 0.1f);
					}
				}
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00041491 File Offset: 0x0003F691
		public static void 럟()
		{
			if (global::랾.럓.랾 == null)
			{
				return;
			}
			if (ConfigFile.collectableESPTracer || ConfigFile.collectableESPBox)
			{
				랳.럦();
			}
			if (ConfigFile.playerESPBox || ConfigFile.playerESPTracer || ConfigFile.modESPBox || ConfigFile.modESPTracers)
			{
				랳.랅();
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000AF520 File Offset: 0x000AD720
		private static void 럦()
		{
			Vector2i[] array = 랳.랾;
			if (array.Length == 0)
			{
				return;
			}
			Color color = 랳.랋();
			for (int i = 0; i < array.Length; i++)
			{
				Vector3 vector = global::랾.럽.랾(array[i]);
				if (ConfigFile.collectableESPTracer)
				{
					랳.랾(vector, color, 1.25f, 0.15f);
				}
				Vector3 vector2;
				if (ConfigFile.collectableESPBox && 랳.랾(vector, out vector2))
				{
					랳.랾(vector2, 10f, color, 1.25f);
				}
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000AF59C File Offset: 0x000AD79C
		public static void 랪()
		{
			Vector2i[] array = 랳.럎;
			for (int i = 0; i < array.Length; i++)
			{
				랳.랾(global::랾.럽.랾(array[i]), 랳.랫(), 1.75f, 0.15f);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000AF5E4 File Offset: 0x000AD7E4
		private static void 럷()
		{
			World world = global::랾.럓.랾;
			if (world == null)
			{
				랳.럣();
				return;
			}
			CollectableData[] array = 랳.랾(world);
			if (array == null)
			{
				랳.럣();
				return;
			}
			int num = array.Length;
			bool flag = 랳.럎 != world;
			bool flag2 = num != 랳.럎;
			if (!flag && !flag2 && Time.realtimeSinceStartup < 랳.랫)
			{
				return;
			}
			랳.럎 = world;
			랳.럎 = num;
			랳.랫 = Time.realtimeSinceStartup + 0.12f;
			랳.럎.Clear();
			랳.람.Clear();
			HashSet<long> hashSet = new HashSet<long>();
			foreach (CollectableData collectableData in array)
			{
				if (collectableData != null)
				{
					Vector2i mapPoint = collectableData.mapPoint;
					long item = (long)mapPoint.x << 32 | (long)((ulong)mapPoint.y);
					if (hashSet.Add(item))
					{
						랳.럎.Add(mapPoint);
						if (collectableData.blockType == 1420)
						{
							랳.람.Add(mapPoint);
						}
					}
				}
			}
			랳.랾 = 랳.럎.ToArray();
			랳.럎 = 랳.람.ToArray();
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000AF704 File Offset: 0x000AD904
		private static void 럣()
		{
			랳.럎 = null;
			랳.랫 = 0f;
			랳.럎 = -1;
			랳.럎.Clear();
			랳.람.Clear();
			랳.랾 = Array.Empty<Vector2i>();
			랳.럎 = Array.Empty<Vector2i>();
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000AF754 File Offset: 0x000AD954
		private static void 랅()
		{
			NetworkPlayer[] array = 랳.랠();
			if (array == null)
			{
				return;
			}
			foreach (NetworkPlayer networkPlayer in array)
			{
				if (networkPlayer != null && networkPlayer.playerScript && networkPlayer.playerScript.isActiveAndEnabled)
				{
					Vector3 position = networkPlayer.playerScript.transform.position;
					Color color = 랳.람();
					Vector3 vector;
					Vector3 vector2;
					if (ConfigFile.playerESPBox && 랳.랾(position, out vector, out vector2, 0.1f, 0.2f))
					{
						랳.랾(vector, vector2, color, 1.5f);
					}
					if (ConfigFile.playerESPTracer)
					{
						랳.랾(position, color, 1.5f, 0.1f);
					}
					if ((ConfigFile.modESPBox || ConfigFile.modESPTracers) && global::랾.럽.럼(networkPlayer.clientId))
					{
						Color color2 = ConfigFile.uiEspStaffRainbow ? global::랾.럽.럯() : 랳.럼();
						Vector3 vector3;
						Vector3 vector4;
						if (ConfigFile.modESPBox && 랳.랾(position, out vector3, out vector4, 0.1f, 0.2f))
						{
							랳.랾(vector3, vector4, color2, 2.5f);
						}
						if (ConfigFile.modESPTracers)
						{
							랳.랾(position, color2, 2.5f, 0.1f);
						}
					}
				}
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000AF880 File Offset: 0x000ADA80
		public static void 랁()
		{
			Player player = global::랾.럓.랾;
			if (!player)
			{
				return;
			}
			Transform transform = (player != null) ? player.transform : null;
			if (!랳.럎(global::랾.럧.랾.x) || !랳.럎(global::랾.럧.랾.y))
			{
				ConfigFile.fakeLagToggle = false;
				return;
			}
			Vector3 vector;
			vector..ctor(global::랾.럧.랾.x, global::랾.럧.랾.y, transform.position.z);
			Vector3 vector2;
			if (!랳.랾(vector, out vector2))
			{
				return;
			}
			Vector2 vector3 = 랳.랾(vector2);
			float num = 60f;
			float num2 = 100f;
			new Color(0.8f, 0.8f, 0.8f, 0.4f);
			global::랾.럈.랾(vector3.x - num / 2f, vector3.y - num2, num, num2, Color.white, 4f);
			GUI.color = new Color(1f, 1f, 1f, 0.7f);
			GUI.Label(new Rect(vector3.x - 40f, vector3.y - num2 - 18f, 100f, 20f), "Server Position");
			GUI.color = Color.white;
			Vector2 vector4;
			Vector2 vector5;
			if (랳.랾(vector, out vector4, out vector5, 0.25f, 0f) && Vector2.Distance(vector4, vector5) > 5f)
			{
				global::랾.럈.랾(vector4, vector5, new Color(1f, 1f, 1f, 0.3f), 3f);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000AFA0C File Offset: 0x000ADC0C
		public static void 랽()
		{
			bool flag = global::랾.랅.랾(308);
			bool flag2 = global::랾.럧.랺 && 랳.랡();
			bool alwaysShowTeleportPath = ConfigFile.alwaysShowTeleportPath;
			IReadOnlyList<랛.랾> readOnlyList;
			IReadOnlyList<랛.랾> readOnlyList2;
			IReadOnlyList<랛.랾> readOnlyList3;
			try
			{
				readOnlyList = global::랾.럧.랾.ToArray();
				readOnlyList2 = global::랾.럧.람.ToArray();
				readOnlyList3 = global::랾.럧.럎.ToArray();
			}
			catch
			{
				return;
			}
			bool flag3 = global::랾.럧.랺 && (readOnlyList2.Count > 1 || readOnlyList.Count > 1);
			if ((!flag && !flag3 && !flag2 && !alwaysShowTeleportPath) || !global::랾.럓.랾 || global::랾.럓.랾 == null)
			{
				return;
			}
			Vector2i currentPlayerMapPoint = global::랾.럓.랾.currentPlayerMapPoint;
			if (flag && !global::랾.럧.럯 && readOnlyList3.Count > 1)
			{
				랳.랾(readOnlyList3, 랳.랯(), 2.1f, -1, 0);
			}
			if (readOnlyList2.Count > 1)
			{
				int num = global::랾.랛.럎((List<랛.랾>)readOnlyList2, currentPlayerMapPoint);
				랳.랾(readOnlyList2, 랳.량(), 1.85f, -1, 0);
				if (num > 1)
				{
					랳.랾(readOnlyList2, 랳.럑(), 2.35f, num, 0);
				}
			}
			if (readOnlyList.Count > 1)
			{
				int num2 = global::랾.럧.럯 ? Math.Clamp(global::랾.럧.럒, 0, readOnlyList.Count - 1) : 0;
				랳.랾(readOnlyList, 랳.러(), 2.6f, readOnlyList.Count, num2);
			}
			if (flag2)
			{
				랳.랃();
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000AFB7C File Offset: 0x000ADD7C
		private static void 랾(IReadOnlyList<랛.랾> A_0, Color A_1, float A_2, int A_3 = -1, int A_4 = 0)
		{
			if (A_0 == null || A_0.Count < 2 || A_4 >= A_0.Count - 1)
			{
				return;
			}
			WorldController worldController = ControllerHelper.worldController;
			if (worldController == null)
			{
				return;
			}
			int num = Math.Min((A_3 < 0) ? A_0.Count : Math.Min(A_3, A_0.Count), A_4 + 96 + 1);
			float num2 = 랳.랾(A_2);
			List<Vector2> list = new List<Vector2>(num - A_4);
			bool flag = false;
			for (int i = Math.Max(0, A_4); i < num; i++)
			{
				Vector2 item;
				if (랳.랾(랳.랾(worldController, A_0[i]), out item))
				{
					if (flag)
					{
						if (list.Count >= 2)
						{
							랳.랾(list, A_1, num2);
						}
						list = new List<Vector2>();
						flag = false;
					}
					list.Add(item);
				}
				else
				{
					flag = true;
				}
			}
			if (list.Count >= 2)
			{
				랳.랾(list, A_1, num2);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000AFC58 File Offset: 0x000ADE58
		private static void 랾(List<Vector2> A_0, Color A_1, float A_2)
		{
			switch (Math.Clamp(ConfigFile.uiPathLineStyle, 0, 5))
			{
			case 1:
				랳.럎(A_0, A_1, A_2);
				return;
			case 2:
				랳.람(A_0, A_1, A_2);
				return;
			case 3:
				랳.랾(랳.랾(A_0, 1), new Color(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.92f)), Mathf.Max(0.75f, A_2 * 0.92f), Mathf.Clamp(ConfigFile.uiPathDashLength, 8f, 28f), Mathf.Clamp(ConfigFile.uiPathGapLength, 4f, 18f));
				return;
			case 4:
				랳.럒(A_0, A_1, A_2);
				return;
			case 5:
				랳.럼(A_0, A_1, A_2);
				return;
			default:
				랳.랾(A_0, A_1, A_2);
				return;
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000AFD30 File Offset: 0x000ADF30
		private static void 럎(List<Vector2> A_0, Color A_1, float A_2)
		{
			List<Vector2> list = 랳.랾(A_0, 1);
			Color color;
			color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.14f));
			Color color2;
			color2..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.96f));
			랳.랾(list, color, A_2 * 1.85f);
			랳.랾(list, color2, Mathf.Max(0.75f, A_2 * 0.95f));
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000AFDC0 File Offset: 0x000ADFC0
		private static void 람(List<Vector2> A_0, Color A_1, float A_2)
		{
			List<Vector2> list = 랳.랾(A_0, (A_0.Count > 5) ? 2 : 1);
			Color color;
			color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.08f));
			Color color2;
			color2..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.2f));
			Color color3;
			color3..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.98f));
			랳.랾(list, color, A_2 * 2.9f);
			랳.랾(list, color2, A_2 * 1.8f);
			랳.랾(list, color3, A_2);
			랳.럎(list, A_1, A_2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000AFE8C File Offset: 0x000AE08C
		private static void 럒(List<Vector2> A_0, Color A_1, float A_2)
		{
			List<Vector2> list = 랳.랾(A_0, (A_0.Count > 6) ? 2 : 1);
			Color color;
			color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.1f));
			Color color2;
			color2..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.24f));
			Color color3;
			color3..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.95f));
			랳.랾(list, color, A_2 * 2.5f);
			랳.랾(list, color2, A_2 * 1.55f);
			랳.랾(list, color3, Mathf.Max(0.75f, A_2 * 0.92f));
			랳.랾(list, A_1, A_2, 105f, 3, 6, 0.17f, 0.36f);
			랳.럎(list, A_1, A_2, 0.18f, 0.98f);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000AFF88 File Offset: 0x000AE188
		private static void 럼(List<Vector2> A_0, Color A_1, float A_2)
		{
			List<Vector2> list = 랳.랾(A_0, (A_0.Count > 5) ? 2 : 1);
			Color color;
			color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.05f));
			Color color2;
			color2..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.14f));
			Color color3;
			color3..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.74f));
			랳.랾(list, color, A_2 * 3.8f);
			랳.랾(list, color2, A_2 * 2.3f);
			랳.랾(list, color3, Mathf.Max(0.7f, A_2 * 0.84f));
			랳.람(list, A_1, A_2);
			랳.럎(list, A_1, A_2 * 1.05f, 0.24f, 1f);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000B007C File Offset: 0x000AE27C
		private static void 랾(IReadOnlyList<Vector2> A_0, Color A_1, float A_2)
		{
			if (A_0 == null || A_0.Count < 2)
			{
				return;
			}
			for (int i = 0; i < A_0.Count - 1; i++)
			{
				global::랾.럈.랾(A_0[i], A_0[i + 1], A_1, A_2);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000B00C0 File Offset: 0x000AE2C0
		private static void 랾(IReadOnlyList<Vector2> A_0, Color A_1, float A_2, float A_3, float A_4)
		{
			if (A_0 == null || A_0.Count < 2)
			{
				return;
			}
			float num = Mathf.Max(1f, A_3 + A_4);
			float num2 = 0f;
			for (int i = 0; i < A_0.Count - 1; i++)
			{
				Vector2 vector = A_0[i];
				Vector2 vector2 = A_0[i + 1] - vector;
				float magnitude = vector2.magnitude;
				if (magnitude > 0.001f)
				{
					Vector2 vector3 = vector2 / magnitude;
					float num5;
					for (float num3 = 0f; num3 < magnitude; num3 += num5)
					{
						float num4 = (num2 + num3) % num;
						bool flag = num4 < A_3;
						num5 = Mathf.Min(flag ? (A_3 - num4) : (num - num4), magnitude - num3);
						if (flag && num5 > 0.001f)
						{
							Vector2 vector4 = vector + vector3 * num3;
							Vector2 vector5 = vector + vector3 * (num3 + num5);
							global::랾.럈.랾(vector4, vector5, A_1, A_2);
						}
					}
					num2 = (num2 + magnitude) % num;
				}
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000B01BC File Offset: 0x000AE3BC
		private static List<Vector2> 랾(IReadOnlyList<Vector2> A_0, int A_1)
		{
			List<Vector2> list = new List<Vector2>(A_0);
			A_1 = Mathf.Clamp(A_1, 1, 3);
			int num = 0;
			while (num < A_1 && list.Count >= 3)
			{
				List<Vector2> list2 = new List<Vector2>(list.Count * 2);
				list2.Add(list[0]);
				for (int i = 0; i < list.Count - 1; i++)
				{
					Vector2 vector = list[i];
					Vector2 vector2 = list[i + 1];
					list2.Add(Vector2.Lerp(vector, vector2, 0.25f));
					list2.Add(Vector2.Lerp(vector, vector2, 0.75f));
				}
				list2.Add(list[list.Count - 1]);
				list = list2;
				num++;
			}
			return list;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000B0278 File Offset: 0x000AE478
		private static void 럎(IReadOnlyList<Vector2> A_0, Color A_1, float A_2)
		{
			float num = 랳.랾(A_0);
			if (num < 24f)
			{
				return;
			}
			float num2 = 145f;
			float num3 = Time.realtimeSinceStartup * num2;
			int num4 = Mathf.Clamp(Mathf.RoundToInt(num / 115f), 2, 5);
			float num5 = num / (float)num4;
			for (int i = 0; i < num4; i++)
			{
				float num6 = Mathf.Repeat(num3 + (float)i * num5, num);
				Vector2 vector = 랳.랾(A_0, num6);
				float num7 = 1f - (float)i / (float)(num4 + 1) * 0.2f;
				float num8 = Mathf.Max(1.6f, A_2 * (1.1f - (float)i * 0.05f));
				Color color;
				color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * 0.13f * num7));
				Color color2 = Color.Lerp(A_1, Color.white, 0.3f);
				color2.a = Mathf.Clamp01(A_1.a * 0.92f * num7);
				global::랾.럈.랾(vector, num8 * 2.8f, color);
				global::랾.럈.랾(vector, num8 * 1.45f, new Color(color2.r, color2.g, color2.b, color2.a * 0.28f));
				global::랾.럈.랾(vector, num8, color2);
			}
			랳.럎(A_0, A_1, A_2, 0.18f, 1f);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000B03D8 File Offset: 0x000AE5D8
		private static void 랾(IReadOnlyList<Vector2> A_0, Color A_1, float A_2, float A_3, int A_4, int A_5, float A_6, float A_7)
		{
			float num = 랳.랾(A_0);
			if (num < 22f)
			{
				return;
			}
			float num2 = Time.realtimeSinceStartup * A_3;
			int num3 = Mathf.Clamp(Mathf.RoundToInt(num / 135f), A_4, A_5);
			float num4 = num / (float)num3;
			for (int i = 0; i < num3; i++)
			{
				float num5 = Mathf.Repeat(num2 + (float)i * num4, num);
				Vector2 vector = 랳.랾(A_0, num5);
				float num6 = 0.55f + 0.45f * Mathf.Sin(Time.realtimeSinceStartup * 4.5f + (float)i * 0.9f);
				float num7 = 0.92f - (float)i / (float)(num3 + 2) * 0.14f;
				float num8 = Mathf.Max(1.6f, A_2 * (1.05f + num6 * 0.75f));
				Color color;
				color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * A_6 * num7));
				Color color2 = Color.Lerp(A_1, Color.white, A_7);
				color2.a = Mathf.Clamp01(A_1.a * 0.92f * num7);
				global::랾.럈.랾(vector, num8 * 2.8f, color);
				global::랾.럈.랾(vector, num8 * 1.35f, new Color(color2.r, color2.g, color2.b, color2.a * 0.28f));
				global::랾.럈.랾(vector, num8 * 0.88f, color2);
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000B0548 File Offset: 0x000AE748
		private static void 람(IReadOnlyList<Vector2> A_0, Color A_1, float A_2)
		{
			float num = 랳.랾(A_0);
			if (num < 28f)
			{
				return;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num2 = realtimeSinceStartup * 96f;
			int num3 = Mathf.Clamp(Mathf.RoundToInt(num / 46f), 6, 18);
			for (int i = 0; i < num3; i++)
			{
				float num4 = (float)i / (float)num3;
				float num5 = Mathf.Repeat(num2 + num4 * num, num);
				Vector2 vector = 랳.랾(A_0, num5);
				float num6 = 0.5f + 0.5f * Mathf.Sin(realtimeSinceStartup * 3.8f + num4 * 6.28318f);
				float num7 = Mathf.Max(1.8f, A_2 * (1.2f + num6 * 1.05f));
				Color color;
				color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * (0.05f + num6 * 0.06f)));
				Color color2 = Color.Lerp(A_1, Color.white, 0.22f);
				color2.a = Mathf.Clamp01(A_1.a * (0.12f + num6 * 0.08f));
				global::랾.럈.랾(vector, num7 * 2.7f, color);
				global::랾.럈.랾(vector, num7 * 1.55f, new Color(color2.r, color2.g, color2.b, color2.a * 0.55f));
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000B06A8 File Offset: 0x000AE8A8
		private static void 럎(IReadOnlyList<Vector2> A_0, Color A_1, float A_2, float A_3, float A_4)
		{
			if (A_0 == null || A_0.Count == 0)
			{
				return;
			}
			Vector2 vector = A_0[A_0.Count - 1];
			Color color;
			color..ctor(A_1.r, A_1.g, A_1.b, Mathf.Clamp01(A_1.a * A_3));
			Color color2 = Color.Lerp(A_1, Color.white, 0.18f);
			color2.a = Mathf.Clamp01(A_1.a * A_4);
			global::랾.럈.랾(vector, A_2 * 2.6f, color);
			global::랾.럈.랾(vector, A_2 * 1.1f, color2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000B0738 File Offset: 0x000AE938
		private static float 랾(IReadOnlyList<Vector2> A_0)
		{
			if (A_0 == null || A_0.Count < 2)
			{
				return 0f;
			}
			float num = 0f;
			for (int i = 0; i < A_0.Count - 1; i++)
			{
				num += Vector2.Distance(A_0[i], A_0[i + 1]);
			}
			return num;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000B078C File Offset: 0x000AE98C
		private static Vector2 랾(IReadOnlyList<Vector2> A_0, float A_1)
		{
			if (A_0 == null || A_0.Count == 0)
			{
				return default(Vector2);
			}
			if (A_0.Count == 1 || A_1 <= 0f)
			{
				return A_0[0];
			}
			float num = A_1;
			for (int i = 0; i < A_0.Count - 1; i++)
			{
				Vector2 vector = A_0[i];
				Vector2 vector2 = A_0[i + 1];
				float num2 = Vector2.Distance(vector, vector2);
				if (num2 > 0.001f)
				{
					if (num <= num2)
					{
						return Vector2.Lerp(vector, vector2, num / num2);
					}
					num -= num2;
				}
			}
			return A_0[A_0.Count - 1];
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000B0828 File Offset: 0x000AEA28
		private static bool 랡()
		{
			Vector2i vector2i = global::랾.럧.람;
			return global::랾.럓.랾 != null && global::랾.럓.랾.IsMapPointInWorld(vector2i) && ConfigData.DoesBlockHaveCollider(global::랾.럓.랾.GetBlockType(vector2i));
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000B0864 File Offset: 0x000AEA64
		private static void 랃()
		{
			Camera main = Camera.main;
			Rect rect;
			if (main == null || !랳.랾(main, global::랾.럧.람, out rect))
			{
				return;
			}
			Color color = 랳.럊();
			Color color2;
			color2..ctor(color.r * 0.56f, color.g * 0.24f, color.b * 0.56f, 0.24f);
			string text = "BREAKING";
			global::랾.럈.랾(rect.x, rect.y, rect.width, rect.height, color2);
			global::랾.럈.랾(rect.x, rect.y, rect.width, rect.height, color, 2.5f);
			Vector2 vector = global::랾.럈.랾(text, 0);
			float num = rect.x + (rect.width - vector.x) * 0.5f;
			float num2 = rect.y - vector.y - 6f;
			global::랾.럈.랾(num - 4f, num2 - 2f, vector.x + 8f, vector.y + 4f, new Color(0f, 0f, 0f, 0.6f));
			랳.랾(text, num, num2, color);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000B09A8 File Offset: 0x000AEBA8
		private static bool 랾(Camera A_0, Vector2i A_1, out Rect A_2)
		{
			A_2 = default(Rect);
			WorldController worldController = ControllerHelper.worldController;
			if (worldController == null || global::랾.럓.랾 == null || !global::랾.럓.랾.IsMapPointInWorld(A_1))
			{
				return false;
			}
			Vector2 vector = worldController.ConvertMapPointToWorldPoint(A_1);
			float num = ConfigData.tileSizeX * 0.5f;
			Vector3 vector2;
			vector2..ctor(vector.x - num, vector.y - ConfigData.tileSizeY * 0.5f, 0f);
			Vector3 vector3;
			vector3..ctor(vector.x + num, vector.y + ConfigData.tileSizeY * 0.5f, 0f);
			Vector3 vector4 = A_0.WorldToScreenPoint(vector2);
			Vector3 vector5 = A_0.WorldToScreenPoint(vector3);
			if (vector4.z <= 0.1f || vector5.z <= 0.1f || !랳.럎(vector4.x) || !랳.럎(vector4.y) || !랳.럎(vector5.x) || !랳.럎(vector5.y))
			{
				return false;
			}
			float num2 = Mathf.Min(vector4.x, vector5.x);
			float num3 = Mathf.Max(vector4.x, vector5.x);
			float num4 = (float)Screen.height - Mathf.Max(vector4.y, vector5.y);
			float num5 = (float)Screen.height - Mathf.Min(vector4.y, vector5.y);
			if (num3 - num2 < 1f || num5 - num4 < 1f)
			{
				return false;
			}
			A_2 = new Rect(num2, num4, num3 - num2, num5 - num4);
			return true;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000B0B48 File Offset: 0x000AED48
		private static Vector3 랾(WorldController A_0, 랛.랾 A_1)
		{
			Vector3 result = A_0.ConvertMapPointToWorldPoint(new Vector2i(A_1.랾, A_1.럎));
			result.x += ConfigData.tileSizeX * 0.5f;
			result.y += ConfigData.tileSizeY * 0.5f;
			return result;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000414CF File Offset: 0x0003F6CF
		private static void 랛()
		{
			랳.럎 = ConfigFile.crossBreedSeedEspNewRecipesOnly;
			랳.럼 = 0f;
			랳.랾.Clear();
			랳.랾 = Array.Empty<랳.럎>();
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000B0B9C File Offset: 0x000AED9C
		// Note: this type is marked as 'beforefieldinit'.
		static 랳()
		{
			World.BlockType[] array = new World.BlockType[5];
			RuntimeHelpers.InitializeArray(array, fieldof(럖.랾).FieldHandle);
			랳.랾 = array;
			랳.랾 = new List<Vector2i>();
			랳.럐 = 0f;
			World.BlockType[] array2 = new World.BlockType[7];
			RuntimeHelpers.InitializeArray(array2, fieldof(럖.랾).FieldHandle);
			랳.럎 = array2;
			World.BlockType[] array3 = new World.BlockType[3];
			RuntimeHelpers.InitializeArray(array3, fieldof(럖.랾).FieldHandle);
			랳.람 = array3;
			랳.럒 = new World.BlockType[]
			{
				1419,
				1502
			};
			World.BlockType[] array4 = new World.BlockType[4];
			RuntimeHelpers.InitializeArray(array4, fieldof(럖.럼럥).FieldHandle);
			랳.럼 = array4;
			랳.랾 = new List<NetherBossWraithMonoBehaviour>();
			랳.럯 = 0f;
			랳.랾 = Array.Empty<AIEnemyMonoBehaviourBase>();
			랳.랾 = Array.Empty<NetherBossWraithMonoBehaviour>();
			랳.랾 = Array.Empty<랳.랾>();
			랳.럎 = Array.Empty<랳.랾>();
			랳.람 = Array.Empty<랳.랾>();
			랳.럒 = Array.Empty<랳.랾>();
			랳.럼 = Array.Empty<랳.랾>();
			랳.랾 = Array.Empty<랳.럎>();
			랳.랾 = Array.Empty<Vector2i>();
			랳.럎 = Array.Empty<Vector2i>();
			랳.랾 = new List<AIEnemyMonoBehaviourBase>();
			랳.랱 = 0f;
			AIEnemyType[] array5 = new AIEnemyType[23];
			RuntimeHelpers.InitializeArray(array5, fieldof(럖.랾).FieldHandle);
			랳.랾 = array5;
			랳.럎 = new List<Vector2i>();
			랳.람 = new List<Vector2i>();
			랳.랫 = 0f;
			랳.럎 = -1;
		}

		// Token: 0x0400068F RID: 1679
		private const float 랾 = 12f;

		// Token: 0x04000690 RID: 1680
		private const float 럎 = 64f;

		// Token: 0x04000691 RID: 1681
		private const int 랾 = 96;

		// Token: 0x04000692 RID: 1682
		private static readonly List<랳.랾> 랾 = new List<랳.랾>();

		// Token: 0x04000693 RID: 1683
		private static readonly List<랳.랾> 럎 = new List<랳.랾>();

		// Token: 0x04000694 RID: 1684
		private static readonly List<랳.랾> 람 = new List<랳.랾>();

		// Token: 0x04000695 RID: 1685
		private static readonly List<랳.랾> 럒 = new List<랳.랾>();

		// Token: 0x04000696 RID: 1686
		private static readonly List<랳.랾> 럼 = new List<랳.랾>();

		// Token: 0x04000697 RID: 1687
		private static World 랾;

		// Token: 0x04000698 RID: 1688
		private static bool 랾;

		// Token: 0x04000699 RID: 1689
		private static float 람 = 0f;

		// Token: 0x0400069A RID: 1690
		private const float 럒 = 0.25f;

		// Token: 0x0400069B RID: 1691
		private static readonly List<랳.럎> 랾 = new List<랳.럎>();

		// Token: 0x0400069C RID: 1692
		private static bool 럎;

		// Token: 0x0400069D RID: 1693
		private static float 럼 = 0f;

		// Token: 0x0400069E RID: 1694
		private const float 랋 = 0.35f;

		// Token: 0x0400069F RID: 1695
		private const float 랉 = 32f;

		// Token: 0x040006A0 RID: 1696
		private static readonly World.BlockType[] 랾;

		// Token: 0x040006A1 RID: 1697
		private static readonly List<Vector2i> 랾;

		// Token: 0x040006A2 RID: 1698
		private static float 럐;

		// Token: 0x040006A3 RID: 1699
		private const float 랓 = 0.2f;

		// Token: 0x040006A4 RID: 1700
		private static readonly World.BlockType[] 럎;

		// Token: 0x040006A5 RID: 1701
		private static readonly World.BlockType[] 람;

		// Token: 0x040006A6 RID: 1702
		private static readonly World.BlockType[] 럒;

		// Token: 0x040006A7 RID: 1703
		private static readonly World.BlockType[] 럼;

		// Token: 0x040006A8 RID: 1704
		private static readonly List<NetherBossWraithMonoBehaviour> 랾;

		// Token: 0x040006A9 RID: 1705
		private static float 럯;

		// Token: 0x040006AA RID: 1706
		private const float 럭 = 0.15f;

		// Token: 0x040006AB RID: 1707
		private static volatile AIEnemyMonoBehaviourBase[] 랾;

		// Token: 0x040006AC RID: 1708
		private static volatile NetherBossWraithMonoBehaviour[] 랾;

		// Token: 0x040006AD RID: 1709
		private static volatile 랳.랾[] 랾;

		// Token: 0x040006AE RID: 1710
		private static volatile 랳.랾[] 럎;

		// Token: 0x040006AF RID: 1711
		private static volatile 랳.랾[] 람;

		// Token: 0x040006B0 RID: 1712
		private static volatile 랳.랾[] 럒;

		// Token: 0x040006B1 RID: 1713
		private static volatile 랳.랾[] 럼;

		// Token: 0x040006B2 RID: 1714
		private static volatile 랳.럎[] 랾;

		// Token: 0x040006B3 RID: 1715
		private static volatile Vector2i[] 랾;

		// Token: 0x040006B4 RID: 1716
		private static volatile Vector2i[] 럎;

		// Token: 0x040006B5 RID: 1717
		private static readonly List<AIEnemyMonoBehaviourBase> 랾;

		// Token: 0x040006B6 RID: 1718
		private static float 랱;

		// Token: 0x040006B7 RID: 1719
		private const float 럙 = 0.15f;

		// Token: 0x040006B8 RID: 1720
		public static readonly AIEnemyType[] 랾;

		// Token: 0x040006B9 RID: 1721
		private static readonly List<Vector2i> 럎;

		// Token: 0x040006BA RID: 1722
		private static readonly List<Vector2i> 람;

		// Token: 0x040006BB RID: 1723
		private static World 럎;

		// Token: 0x040006BC RID: 1724
		private static float 랫;

		// Token: 0x040006BD RID: 1725
		private static int 럎;

		// Token: 0x040006BE RID: 1726
		private const float 럍 = 0.12f;

		// Token: 0x0200011E RID: 286
		private readonly struct 랾
		{
			// Token: 0x06000959 RID: 2393 RVA: 0x000414FB File Offset: 0x0003F6FB
			public 랾(Vector3 A_1, Color A_2)
			{
				this.랾 = A_1;
				this.랾 = A_2;
			}

			// Token: 0x0600095A RID: 2394 RVA: 0x0004150B File Offset: 0x0003F70B
			[CompilerGenerated]
			public Vector3 랾()
			{
				return this.랾;
			}

			// Token: 0x0600095B RID: 2395 RVA: 0x00041513 File Offset: 0x0003F713
			[CompilerGenerated]
			public Color 럎()
			{
				return this.랾;
			}

			// Token: 0x040006BF RID: 1727
			[CompilerGenerated]
			private readonly Vector3 랾;

			// Token: 0x040006C0 RID: 1728
			[CompilerGenerated]
			private readonly Color 랾;
		}

		// Token: 0x0200011F RID: 287
		private sealed class 럎
		{
			// Token: 0x040006C1 RID: 1729
			public Vector2i 랾;

			// Token: 0x040006C2 RID: 1730
			public string 랾;

			// Token: 0x040006C3 RID: 1731
			public string 럎;

			// Token: 0x040006C4 RID: 1732
			public int 랾;

			// Token: 0x040006C5 RID: 1733
			public bool 랾;
		}

		// Token: 0x02000120 RID: 288
		private readonly struct 람
		{
			// Token: 0x0600095D RID: 2397 RVA: 0x0004151B File Offset: 0x0003F71B
			public 람(World.BlockType A_1, short A_2, string A_3)
			{
				this.랾 = A_1;
				this.랾 = A_2;
				this.랾 = A_3;
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x00041532 File Offset: 0x0003F732
			[CompilerGenerated]
			public World.BlockType 랾()
			{
				return this.랾;
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x0004153A File Offset: 0x0003F73A
			[CompilerGenerated]
			public short 럎()
			{
				return this.랾;
			}

			// Token: 0x06000960 RID: 2400 RVA: 0x00041542 File Offset: 0x0003F742
			[CompilerGenerated]
			public string 람()
			{
				return this.랾;
			}

			// Token: 0x040006C6 RID: 1734
			[CompilerGenerated]
			private readonly World.BlockType 랾;

			// Token: 0x040006C7 RID: 1735
			[CompilerGenerated]
			private readonly short 랾;

			// Token: 0x040006C8 RID: 1736
			[CompilerGenerated]
			private readonly string 랾;
		}

		// Token: 0x02000121 RID: 289
		[CompilerGenerated]
		private static class 럒
		{
			// Token: 0x040006C9 RID: 1737
			public static Action 랾;

			// Token: 0x040006CA RID: 1738
			public static Action 럎;

			// Token: 0x040006CB RID: 1739
			public static Action 람;

			// Token: 0x040006CC RID: 1740
			public static Action 럒;

			// Token: 0x040006CD RID: 1741
			public static Action 럼;

			// Token: 0x040006CE RID: 1742
			public static Action 랋;

			// Token: 0x040006CF RID: 1743
			public static Action 랉;

			// Token: 0x040006D0 RID: 1744
			public static Action 럐;

			// Token: 0x040006D1 RID: 1745
			public static Action 랓;

			// Token: 0x040006D2 RID: 1746
			public static Action 럯;
		}

		// Token: 0x02000122 RID: 290
		[CompilerGenerated]
		[Serializable]
		private sealed class 럼
		{
			// Token: 0x06000963 RID: 2403 RVA: 0x000B0D5C File Offset: 0x000AEF5C
			internal int 랾(랳.람 A_1, 랳.람 A_2)
			{
				int num = A_2.럎().CompareTo(A_1.럎());
				if (num == 0)
				{
					return string.Compare(A_1.람(), A_2.람(), StringComparison.OrdinalIgnoreCase);
				}
				return num;
			}

			// Token: 0x040006D3 RID: 1747
			public static readonly 랳.럼 랾 = new 랳.럼();

			// Token: 0x040006D4 RID: 1748
			public static Comparison<랳.람> 랾;
		}

		// Token: 0x02000123 RID: 291
		[CompilerGenerated]
		private static class 랋
		{
			// Token: 0x040006D5 RID: 1749
			public static CallSite<Func<CallSite, DateTime, object, object>> 랾;

			// Token: 0x040006D6 RID: 1750
			public static CallSite<Func<CallSite, object, bool>> 랾;

			// Token: 0x040006D7 RID: 1751
			public static CallSite<Func<CallSite, DateTime, object, object>> 럎;

			// Token: 0x040006D8 RID: 1752
			public static CallSite<Func<CallSite, object, bool>> 럎;
		}
	}
}
