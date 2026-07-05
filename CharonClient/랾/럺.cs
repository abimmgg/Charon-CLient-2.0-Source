using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BasicTypes;
using CharonClient.Configuration;
using Kernys.Bson;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000135 RID: 309
	internal class 럺
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x000B4EE8 File Offset: 0x000B30E8
		public static void 랾()
		{
			럧.럼 += Time.deltaTime;
			ConfigFile.TeleportSpeed = 럺.랾(럧.랾.Count, 럧.랺);
			if (!럽.랾())
			{
				럺.럼();
				return;
			}
			if (럧.럸 && 럓.랾 != null)
			{
				럺.럎();
			}
			if (럧.럯)
			{
				랴.랾(false);
				럺.람();
			}
			럺.랋();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000B4F5C File Offset: 0x000B315C
		private static void 럎()
		{
			럓.랾.deltaMovement = Vector3.zero;
			럓.랾.velocity = Vector3.zero;
			럓.랾.lastFrameVelocityY = 0f;
			if (럓.랾.playerCharacterController2D != null)
			{
				럓.랾.playerCharacterController2D.velocity = Vector3.zero;
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000B4FBC File Offset: 0x000B31BC
		public static bool 랾(IEnumerable<랛.랾> A_0, bool A_1 = false)
		{
			if (A_0 == null)
			{
				return false;
			}
			List<랛.랾> list = (A_0 as List<랛.랾>) ?? A_0.ToList<랛.랾>();
			list = 럺.랾(list);
			if (list.Count <= 1)
			{
				return false;
			}
			if (럧.럯 && !A_1)
			{
				return false;
			}
			럺.랓();
			럧.랾 = new List<랛.랾>(list);
			럧.럒 = 0;
			럧.럼 = -1;
			럧.럼 = 0f;
			럧.럯 = true;
			럧.랾 = DateTime.UtcNow;
			return true;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000B5034 File Offset: 0x000B3234
		private static void 람()
		{
			if (럧.럼 < ConfigFile.TeleportSpeed)
			{
				return;
			}
			try
			{
				if (럧.럒 >= 럧.랾.Count)
				{
					럺.럼();
				}
				else
				{
					랛.랾 랾 = 럧.랾[럧.럒];
					Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
					if (!랛.랾(랾.랾, 랾.럎, currentPlayerMapPoint, false, false))
					{
						럽.럎("Platform blocked teleport", false);
						럺.럼();
					}
					else
					{
						럧.럼 = 0f;
						if (럧.럒 > 0)
						{
							럺.랾(럧.랾[럧.럒 - 1], 랾);
						}
						럺.람(랾);
						bool flag = 럧.럒 >= 럧.랾.Count - 1;
						int num = 럺.럎(럧.랾.Count, 럧.랺);
						if ((num > 1 && 럺.랾(랾)) || 럧.랾.Count < 30 || flag || 럧.럒 - 럧.럼 >= num)
						{
							bool flag2 = flag || 럺.랾(럧.럒, num);
							럺.랾(랾, flag2);
							럧.럼 = 럧.럒;
						}
						if (flag)
						{
							럺.럼();
						}
						else
						{
							럧.럒++;
						}
					}
				}
			}
			catch (Exception value)
			{
				럽.럎("Teleport failed!", false);
				Console.WriteLine(value);
				럺.럼();
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000B51AC File Offset: 0x000B33AC
		private static bool 랾(랛.랾 A_0)
		{
			for (int i = -1; i <= 1; i++)
			{
				for (int j = -1; j <= 1; j++)
				{
					if (랛.랾(랛.럎(A_0.랾 + i, A_0.럎 + j)))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000B51F0 File Offset: 0x000B33F0
		private static void 랾(랛.랾 A_0, bool A_1)
		{
			Vector2i vector2i;
			vector2i..ctor(A_0.랾, A_0.럎);
			Vector3 vector = (ControllerHelper.worldController != null) ? ControllerHelper.worldController.ConvertPlayerMapPointToWorldPoint(vector2i) : 럽.랾(vector2i);
			float num = 럺.럎(A_0) ? 0.02f : 0.18f;
			Vector3 position;
			position..ctor(vector.x, vector.y + num, vector.z);
			if (럓.랾.myTransform != null)
			{
				럓.랾.myTransform.position = position;
			}
			럓.랾.transform.position = position;
			럺.랾(vector);
			랴.랾(럺.럎(A_1));
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000419FD File Offset: 0x0003FBFD
		private static List<랛.랾> 랾(List<랛.랾> A_0)
		{
			if (A_0 == null || A_0.Count == 0)
			{
				return new List<랛.랾>();
			}
			return new List<랛.랾>(A_0);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000B52AC File Offset: 0x000B34AC
		private static bool 럎(랛.랾 A_0)
		{
			if (A_0 == null || 럓.랾 == null)
			{
				return true;
			}
			Vector2i vector2i;
			vector2i..ctor(A_0.랾, A_0.럎);
			return !럓.랾.IsMapPointInWorld(vector2i) || 럺.랾(럓.랾.GetBlockType(vector2i)) || 럺.랾(new Vector2i(vector2i.x - 1, vector2i.y)) || 럺.랾(new Vector2i(vector2i.x + 1, vector2i.y)) || 럺.랾(new Vector2i(vector2i.x, vector2i.y + 1));
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000B534C File Offset: 0x000B354C
		private static bool 랾(Vector2i A_0)
		{
			if (럓.랾 == null || !럓.랾.IsMapPointInWorld(A_0))
			{
				return true;
			}
			World.BlockType blockType = 럓.랾.GetBlockType(A_0);
			return 럺.랾(blockType) || (blockType != 4103 && blockType != 3966 && blockType != 3965 && blockType != 110 && blockType != 1420 && blockType != 4286 && blockType != 4366 && blockType != 4372 && (!ConfigData.IsAnyDoor(blockType) || !ControllerHelper.worldController.DoesPlayerHaveRightToGoDoorForCollider(A_0)) && ((!ConfigData.IsBlockDisappearingBlock(blockType) && !ConfigData.IsBlockBattleBarrier(blockType)) || !럺.럎(A_0)) && ConfigData.DoesBlockHaveCollider(blockType));
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000B53FC File Offset: 0x000B35FC
		private static bool 럎(Vector2i A_0)
		{
			bool result;
			try
			{
				WorldItemBase worldItemData = 럓.랾.GetWorldItemData(A_0);
				if (worldItemData == null)
				{
					result = false;
				}
				else
				{
					BSONObject asBSON = worldItemData.GetAsBSON();
					result = (asBSON != null && asBSON.ContainsKey("isOpen") && asBSON["isOpen"].boolValue);
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000B5468 File Offset: 0x000B3668
		private static bool 랾(World.BlockType A_0)
		{
			return ConfigData.IsBlockPlatform(A_0) || A_0 == 16 || A_0 == 1975 || A_0 == 1384 || A_0 == 1373 || A_0 == 656 || A_0 == 3648 || A_0 == 956;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000B54B4 File Offset: 0x000B36B4
		private static void 랾(Vector3 A_0)
		{
			if (럓.랾 == null)
			{
				return;
			}
			try
			{
				럓.랾.currentPlayerPosition = A_0;
				럓.랾.SetCurrentPlayerPositions();
				OutgoingMessages.SendPlayerPosition(럓.랾.GetMovementAsBSON(true));
			}
			catch
			{
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00041A16 File Offset: 0x0003FC16
		public static void 럒()
		{
			럺.럼();
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00041A1D File Offset: 0x0003FC1D
		private static void 럼()
		{
			럧.랾.Clear();
			럧.럒 = 0;
			럧.럼 = -1;
			럧.럼 = 0f;
			럧.럯 = false;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000B550C File Offset: 0x000B370C
		private static void 랋()
		{
			if (!랅.랾(308))
			{
				럺.럐();
				return;
			}
			럺.랾(false);
			if (랅.럎(1) && 럧.럯)
			{
				int value = 럧.랾.Count - 럧.럒;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Already Teleporting! ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral(" Nodes Left!");
				럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				return;
			}
			if (랅.럎(324) && !럧.럯)
			{
				럴.AssertRuntimeKeyValid("HandleTeleportInput");
				럺.랉();
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000B55AC File Offset: 0x000B37AC
		private static void 랉()
		{
			럴.AssertRuntimeKeyValid("StartTeleportToMouse");
			Vector2i vector2i;
			Vector2i vector2i2;
			if (!럺.랾(out vector2i, out vector2i2))
			{
				럽.럎("Invalid teleport target", false);
				return;
			}
			if (vector2i == vector2i2)
			{
				return;
			}
			if (!랛.랾(vector2i2.x, vector2i2.y, vector2i, false, false))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Tile at (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i2.x);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(vector2i2.y);
				defaultInterpolatedStringHandler.AppendLiteral(") is not walkable");
				럽.럎(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				return;
			}
			럺.랾(true);
			if (!럺.랾(럧.럎, false))
			{
				럽.럎("No path found!", false);
				return;
			}
			float num = 럺.랾(럧.랾.Count, 럧.랺);
			ConfigFile.TeleportSpeed = num;
			string value = 럺.랾(럧.랾.Count, num, 럺.럎(럧.랾.Count, 럧.랺));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(24, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("Teleporting | ");
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			defaultInterpolatedStringHandler2.AppendLiteral(" | ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(럧.랾.Count);
			defaultInterpolatedStringHandler2.AppendLiteral(" Blocks");
			럽.럒(defaultInterpolatedStringHandler2.ToStringAndClear(), !ConfigFile.showTeleportNotifications);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000B570C File Offset: 0x000B390C
		private static void 랾(bool A_0 = false)
		{
			Vector2i vector2i;
			Vector2i vector2i2;
			if (!럺.랾(out vector2i, out vector2i2))
			{
				럺.럐();
				return;
			}
			bool flag = vector2i2.x != 럺.럎.x || vector2i2.y != 럺.럎.y;
			bool flag2 = vector2i.x != 럺.랾.x || vector2i.y != 럺.랾.y;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (!A_0 && !flag && !flag2 && realtimeSinceStartup < 럺.럒)
			{
				return;
			}
			럺.랾 = vector2i;
			럺.럎 = vector2i2;
			if (!랛.랾(vector2i2.x, vector2i2.y, vector2i, false, false))
			{
				럧.럎.Clear();
				럺.럒 = realtimeSinceStartup + 0.5f;
				return;
			}
			럧.럎 = 럺.랾(랛.랾(vector2i, vector2i2, 랛.럎()));
			럺.럒 = realtimeSinceStartup + ((럧.럎.Count > 1) ? 0.1f : 0.5f);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000B580C File Offset: 0x000B3A0C
		private static bool 랾(out Vector2i A_0, out Vector2i A_1)
		{
			A_0 = default(Vector2i);
			A_1 = default(Vector2i);
			if (럓.랾 == null || 럓.랾 == null)
			{
				return false;
			}
			Camera main = Camera.main;
			if (main == null)
			{
				return false;
			}
			A_0 = 럓.랾.currentPlayerMapPoint;
			A_1 = 럽.랾(main.ScreenToWorldPoint(랅.람()));
			return 럓.랾.IsMapPointInWorld(A_1);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00041A45 File Offset: 0x0003FC45
		private static void 럐()
		{
			럧.럎.Clear();
			럺.럒 = 0f;
			럺.랾 = new Vector2i(int.MinValue, int.MinValue);
			럺.럎 = new Vector2i(int.MinValue, int.MinValue);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000B588C File Offset: 0x000B3A8C
		public static float 랾(int A_0, bool A_1)
		{
			float num = A_1 ? ConfigFile.AutoMiningTeleportSpeedThreshold : ConfigFile.DefaultTeleportSpeedThreshold;
			float num2;
			if (A_0 <= 95)
			{
				if (A_0 <= 75)
				{
					if (A_0 > 55)
					{
						if (A_0 > 65)
						{
							num2 = 0.045f;
						}
						else
						{
							num2 = 0.035f;
						}
					}
					else
					{
						num2 = 0.01f;
					}
				}
				else if (A_0 > 85)
				{
					num2 = 0.07f;
				}
				else
				{
					num2 = 0.055f;
				}
			}
			else if (A_0 <= 115)
			{
				if (A_0 > 105)
				{
					num2 = 0.095f;
				}
				else
				{
					num2 = 0.085f;
				}
			}
			else if (A_0 > 125)
			{
				num2 = 0.115f;
			}
			else
			{
				num2 = 0.105f;
			}
			float num3 = num2;
			return (num + num3) * 1.15f;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000B5928 File Offset: 0x000B3B28
		public static int 럎(int A_0, bool A_1)
		{
			int num = Math.Max(1, ConfigFile.teleportChunkAmount);
			if (!A_1)
			{
				return num;
			}
			if (A_0 >= 24)
			{
				num = Math.Max(num, 2);
			}
			if (A_0 >= 60)
			{
				num = Math.Max(num, 3);
			}
			return num;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000B5964 File Offset: 0x000B3B64
		private static bool 랾(int A_0, int A_1)
		{
			int num = (A_1 <= 1) ? A_0 : (A_0 / A_1);
			int num2 = 럧.랺 ? 3 : 2;
			return num % num2 == 0;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000B598C File Offset: 0x000B3B8C
		private static bool 럎(bool A_0)
		{
			if (!A_0)
			{
				return false;
			}
			if (!럧.랺)
			{
				return true;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (realtimeSinceStartup - 럺.럼 < 0.35f)
			{
				return false;
			}
			럺.럼 = realtimeSinceStartup;
			return true;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00041A83 File Offset: 0x0003FC83
		public static void 랓()
		{
			if (럺.랋 >= 128)
			{
				OutgoingMessages.recentMapPoints.Clear();
				럺.랋 = 0;
			}
			if (럓.랾 == null)
			{
				return;
			}
			럺.람(럓.랾.currentPlayerMapPoint);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00041ABE File Offset: 0x0003FCBE
		private static void 람(랛.랾 A_0)
		{
			럺.람(new Vector2i(A_0.랾, A_0.럎));
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000B59C4 File Offset: 0x000B3BC4
		private static void 랾(랛.랾 A_0, 랛.랾 A_1)
		{
			if (A_0 == null || A_1 == null || 럓.랾 == null)
			{
				return;
			}
			if (A_0.랾 != A_1.랾 || A_1.럎 - A_0.럎 != 2)
			{
				return;
			}
			Vector2i vector2i;
			vector2i..ctor(A_0.랾, A_0.럎 + 1);
			if (럓.랾.IsMapPointInWorld(vector2i) && 럺.랾(럓.랾.GetBlockType(vector2i)))
			{
				럺.람(vector2i);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000B5A38 File Offset: 0x000B3C38
		private static void 람(Vector2i A_0)
		{
			OutgoingMessages.AddMapPointIfNotLastAlready(A_0);
			럺.랋++;
			int num = 럧.랺 ? 24 : 64;
			int num2 = OutgoingMessages.recentMapPoints.Count - num;
			if (num2 > 0)
			{
				OutgoingMessages.recentMapPoints.RemoveRange(0, num2);
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000B5A84 File Offset: 0x000B3C84
		private static string 랾(int A_0, float A_1, int A_2)
		{
			if (A_0 <= 0)
			{
				return "Instant";
			}
			float num = (float)((A_2 > 0) ? (A_0 / A_2) : A_0) * A_1;
			if (!ConfigFile.instantTeleportToggle)
			{
				num *= 2f;
			}
			if (num < 1f)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>((int)(num * 1000f));
				defaultInterpolatedStringHandler.AppendLiteral("ms");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (num < 60f)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler2.AppendFormatted<float>(num, "F1");
				defaultInterpolatedStringHandler2.AppendLiteral("s");
				return defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler3.AppendFormatted<int>((int)(num / 60f));
			defaultInterpolatedStringHandler3.AppendLiteral("m ");
			defaultInterpolatedStringHandler3.AppendFormatted<int>((int)(num % 60f));
			defaultInterpolatedStringHandler3.AppendLiteral("s");
			return defaultInterpolatedStringHandler3.ToStringAndClear();
		}

		// Token: 0x04000721 RID: 1825
		private const float 랾 = 0.1f;

		// Token: 0x04000722 RID: 1826
		private const float 럎 = 0.5f;

		// Token: 0x04000723 RID: 1827
		private const int 랾 = 3;

		// Token: 0x04000724 RID: 1828
		private const int 럎 = 2;

		// Token: 0x04000725 RID: 1829
		private const float 람 = 0.35f;

		// Token: 0x04000726 RID: 1830
		private const int 람 = 24;

		// Token: 0x04000727 RID: 1831
		private const int 럒 = 64;

		// Token: 0x04000728 RID: 1832
		private const int 럼 = 128;

		// Token: 0x04000729 RID: 1833
		private static int 랋 = 0;

		// Token: 0x0400072A RID: 1834
		private static float 럒;

		// Token: 0x0400072B RID: 1835
		private static float 럼;

		// Token: 0x0400072C RID: 1836
		private static Vector2i 랾 = new Vector2i(int.MinValue, int.MinValue);

		// Token: 0x0400072D RID: 1837
		private static Vector2i 럎 = new Vector2i(int.MinValue, int.MinValue);
	}
}
