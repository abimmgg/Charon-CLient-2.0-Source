using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000132 RID: 306
	internal class 랴
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x00041853 File Offset: 0x0003FA53
		public static void 랾()
		{
			랴.랾(true);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000B3EE8 File Offset: 0x000B20E8
		public static void 랾(bool A_0)
		{
			if (럓.랾 == null)
			{
				return;
			}
			if (A_0)
			{
				KukouriCamera kukouriCamera = ControllerHelper.kukouriCamera;
				if (kukouriCamera != null)
				{
					kukouriCamera.ForceUpdatePosition(true);
				}
				if (ControllerHelper.freeSpaceController != null && ControllerHelper.worldController != null)
				{
					ControllerHelper.freeSpaceController.SetPlayerInitMapPoint(ControllerHelper.worldController.ConvertWorldPointToMapPoint(럓.랾.myTransform.position), FreeSpaceController.cooldownToStopIsPlayerMovedOutFromInitMapPointCheckShort);
				}
				럓.랾.PlayMainAnimation(2, 0f, 0f, 0f);
				럓.랾.ResetAnimationsToIdle();
			}
			럓.랾.deltaMovement = Vector3.zero;
			럓.랾.velocity = Vector3.zero;
			if (럓.랾.playerCharacterController2D != null)
			{
				럓.랾.playerCharacterController2D.velocity = 럓.랾.velocity;
			}
			럓.랾.lastFrameVelocityY = 0f;
			럓.랾.leftButton = false;
			럓.랾.leftButtonDown = false;
			럓.랾.leftButtonUp = false;
			럓.랾.rightButton = false;
			럓.랾.rightButtonDown = false;
			럓.랾.rightButtonUp = false;
			럓.랾.jumpButton = false;
			럓.랾.jumpButtonDown = false;
			럓.랾.jumpButtonUp = false;
			럓.랾.useButton = false;
			럓.랾.useButtonDown = false;
			럓.랾.useButtonUp = false;
			럓.랾.isJumpLanding = false;
			럓.랾.isDoubleJumpFirstJumpDone = false;
			럓.랾.isSwimming = false;
			럓.랾.deathByColliderInColliderTimeCounter = 0f;
			PlayerComplexDustAnimation playerDust = 럓.랾.playerDust;
			if (playerDust != null)
			{
				playerDust.Deactivate();
			}
			Vector3 velocity = 럓.랾.velocity;
			velocity.y = -럓.랾.gravity * Time.deltaTime;
			럓.랾.gravity = 0f;
			럓.랾.velocity = velocity;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000B40E0 File Offset: 0x000B22E0
		public static void 럎()
		{
			World.BattleState currentBattleState = StaticPlayer.GetCurrentBattleState();
			if (랴.랾 || (currentBattleState != 1 && currentBattleState != 2))
			{
				return;
			}
			랴.랾 = true;
			랴.랾 += Time.deltaTime;
			float num = Mathf.Clamp(ConfigFile.pvpAimbotInterval, 0.01f, 1f);
			if (랴.랾 >= num)
			{
				Player player = 랴.람();
				if (player != null && !player.isDead && !player.isWaitingDeath && !player.IsWaitingRespawn())
				{
					OutgoingMessages.SendHitOtherPlayerMessage(player.currentPlayerMapPoint, player.myPlayerData.playerId, -1);
					랴.럎 = 0f;
					랴.람 = 0f;
					랴.랾 = 0f;
				}
			}
			랴.랾 = false;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000B4198 File Offset: 0x000B2398
		private static Player 람()
		{
			Player result = null;
			float num = (float)(럓.랾.GetIsPerkActive(11) ? 4 : 3);
			float num2 = num;
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (networkPlayer != null && !(networkPlayer.playerScript == null) && NetworkPlayers.CanLocalPlayerHitOtherPlayer(networkPlayer.clientId) && !networkPlayer.playerScript.isDead)
				{
					float num3 = Vector2.Distance(networkPlayer.playerScript.currentPlayerPosition, 럓.랾.currentPlayerPosition);
					if (num3 < num && num3 < num2)
					{
						num2 = num3;
						result = networkPlayer.playerScript;
					}
				}
			}
			return result;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0004185B File Offset: 0x0003FA5B
		private static void 럒()
		{
			랴.럒 += Time.deltaTime;
			if (랴.럒 < 0.15f)
			{
				return;
			}
			랴.랾 = Object.FindObjectsOfType<AIEnemyMonoBehaviourBase>();
			랴.럒 = 0f;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000B4250 File Offset: 0x000B2450
		public static void 럼()
		{
			if (럓.랾 == null || 럓.랾 == null)
			{
				return;
			}
			if (럧.럯 || 럓.랾.isPortalAnimationActive)
			{
				return;
			}
			string worldName = 럓.랾.worldName;
			if (worldName != "SECRETBASE" && worldName != "NETHERWORLD" && worldName != "DEEPNETHER")
			{
				return;
			}
			랴.럒();
			랴.럎 += Time.deltaTime;
			float num = Mathf.Clamp(ConfigFile.pveAimbotInterval, 0.01f, 1f);
			if (랴.럎 < num)
			{
				return;
			}
			AIEnemyMonoBehaviourBase aienemyMonoBehaviourBase = 랴.랾(럓.랾.GetIsPerkActive(11) ? 4f : 3f);
			if (aienemyMonoBehaviourBase != null && aienemyMonoBehaviourBase.aiBase.health > -1)
			{
				OutgoingMessages.SendHitAIEnemyMessage(aienemyMonoBehaviourBase.aiBase.GetRoundedMapPoint(), aienemyMonoBehaviourBase.aiBase.id, -1);
				랴.랾 = 0f;
				랴.람 = 0f;
				랴.럎 = 0f;
				럧.럎 = DateTime.UtcNow;
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000B4368 File Offset: 0x000B2568
		private static AIEnemyMonoBehaviourBase 랾(float A_0)
		{
			AIEnemyMonoBehaviourBase result = null;
			float num = A_0 * A_0;
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			foreach (AIEnemyMonoBehaviourBase aienemyMonoBehaviourBase in 랴.랾)
			{
				if (aienemyMonoBehaviourBase && aienemyMonoBehaviourBase.aiBase != null && aienemyMonoBehaviourBase.aiBase.health > -1 && AIEnemyConfigData.GetMaxHitPoints(aienemyMonoBehaviourBase.aiBase.enemyType) != 50)
				{
					Vector2i roundedMapPoint = aienemyMonoBehaviourBase.aiBase.GetRoundedMapPoint();
					float num2 = (float)(roundedMapPoint.x - currentPlayerMapPoint.x);
					float num3 = (float)(roundedMapPoint.y - currentPlayerMapPoint.y);
					float num4 = num2 * num2 + num3 * num3;
					if (num4 < num)
					{
						num = num4;
						result = aienemyMonoBehaviourBase;
					}
				}
			}
			return result;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000B4424 File Offset: 0x000B2624
		public static void 랋()
		{
			if (럓.랾 == null || 럓.랾 == null)
			{
				return;
			}
			if (럧.럯 || 럓.랾.isPortalAnimationActive)
			{
				return;
			}
			if (!랴.랾.Contains(럓.랾.worldName))
			{
				return;
			}
			랴.람 += Time.deltaTime;
			if (랴.람 < 0.25f)
			{
				return;
			}
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			int num = 럓.랾.GetIsPerkActive(11) ? 4 : 3;
			float num2 = (float)num;
			float num3 = num2 * num2;
			Vector2i vector2i = default(Vector2i);
			bool flag = false;
			float num4 = float.MaxValue;
			int num5 = Math.Max(0, currentPlayerMapPoint.x - 5);
			int num6 = Math.Min(럓.랾.worldSizeX - 1, currentPlayerMapPoint.x + 5);
			int num7 = Math.Max(0, currentPlayerMapPoint.y - 5);
			int num8 = Math.Min(럓.랾.worldSizeY - 1, currentPlayerMapPoint.y + 5);
			for (int i = num5; i <= num6; i++)
			{
				for (int j = num7; j <= num8; j++)
				{
					if (럓.랾.GetBlockType(i, j) == 1400)
					{
						int num9 = i - currentPlayerMapPoint.x;
						int num10 = j - currentPlayerMapPoint.y;
						if (Math.Max(Math.Abs(num9), Math.Abs(num10)) <= num)
						{
							float num11 = (float)(num9 * num9 + num10 * num10);
							if (num11 <= num3 && num11 < num4)
							{
								num4 = num11;
								vector2i..ctor(i, j);
								flag = true;
							}
						}
					}
				}
			}
			if (flag)
			{
				OutgoingMessages.SendHitBlockMessage(vector2i, DateTime.Now, false);
				랴.럎 = 0f;
				랴.랾 = 0f;
				랴.람 = 0f;
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000B45E0 File Offset: 0x000B27E0
		public static void 랉()
		{
			if (럓.랾 == null)
			{
				return;
			}
			if (럓.랾 == null)
			{
				return;
			}
			if (ControllerHelper.playerNamesManager == null)
			{
				return;
			}
			if (ControllerHelper.playerNamesManager.GetPlayerStatusIconType(럓.랾.playerId) == 2)
			{
				return;
			}
			if (ConfigFile.alternativeFlyHotkeysToggle)
			{
				랴.랾(273, 274, 276, 275, false);
				return;
			}
			랴.랾(119, 115, 97, 100, true);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000B4654 File Offset: 0x000B2854
		private static void 랾(KeyCode A_0, KeyCode A_1, KeyCode A_2, KeyCode A_3, bool A_4)
		{
			if (A_4 && !랅.랾(304))
			{
				return;
			}
			if (!A_4 && !ConfigFile.flyToggle)
			{
				ConfigFile.flyToggle = true;
			}
			float num = Mathf.Clamp(ConfigFile.flySpeed, 0.1f, 25f);
			Vector3 zero = Vector3.zero;
			if (랅.랾(A_0))
			{
				zero.y += num;
			}
			if (랅.랾(A_1))
			{
				zero.y -= num;
			}
			if (랅.랾(A_2))
			{
				zero.x -= num;
			}
			if (랅.랾(A_3))
			{
				zero.x += num;
			}
			if (zero != Vector3.zero)
			{
				럓.랾.SetVelocity(zero);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00041893 File Offset: 0x0003FA93
		private static Vector2i 럐()
		{
			return 럽.랾(Camera.main.ScreenToWorldPoint(랅.람()));
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000418AE File Offset: 0x0003FAAE
		public static void 랓()
		{
			랴.랾(랴.럐(), new Action<string, string>(랴.랾.랾.랾));
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000418D9 File Offset: 0x0003FAD9
		public static void 럯()
		{
			랴.랾(랴.럐(), new Action<string, string>(랴.랾.랾.럎));
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00041904 File Offset: 0x0003FB04
		public static void 럭()
		{
			랴.랾(랴.럐(), new Action<string, string>(랴.랾.랾.람));
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000B4708 File Offset: 0x000B2908
		private static void 랾(Vector2i A_0, Action<string, string> A_1)
		{
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (networkPlayer != null && NetworkPlayers.GetOtherPlayerMapPoint(networkPlayer.clientId) == A_0)
				{
					A_1(networkPlayer.clientId, networkPlayer.name);
					return;
				}
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000B4758 File Offset: 0x000B2958
		public static void 랱()
		{
			foreach (InventoryControl inventoryControl in Object.FindObjectsOfType<InventoryControl>())
			{
				PlayerData.InventoryKey currentSelection = inventoryControl.GetCurrentSelection();
				short num = (short)inventoryControl.GetAmountTextForInventoryKey(currentSelection);
				럓.랾.DropItems(currentSelection, num);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000B47B8 File Offset: 0x000B29B8
		public static void 랾(string A_0)
		{
			if (!럧.랆 || string.IsNullOrWhiteSpace(A_0))
			{
				return;
			}
			Match match = Regex.Match(A_0.Trim().ToLowerInvariant().Replace("plus", "+").Replace("minus", "-").Replace("times", "*").Replace("x", "*").Replace("×", "*").Replace("divided by", "/").Replace("÷", "/"), "[\\d+\\-*/().\\s]+");
			string text = match.Success ? match.Value.Trim() : E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮();
			text = Regex.Replace(text, "\\s+", " ").Trim();
			if (string.IsNullOrWhiteSpace(text) || text.Length < 3)
			{
				return;
			}
			if (!Regex.IsMatch(text, "[+\\-*/]"))
			{
				return;
			}
			try
			{
				object obj = new DataTable().Compute(text, null);
				if (obj != null)
				{
					string text2 = obj.ToString().Trim();
					double value;
					if (double.TryParse(text2, out value) && text2 != text)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Question: ");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral(" → Answer: ");
						defaultInterpolatedStringHandler.AppendFormatted<double>(value);
						럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
						럓.랾.Submit(value.ToString());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000B4944 File Offset: 0x000B2B44
		public static void 럙()
		{
			if (ControllerHelper.worldController.world == null)
			{
				return;
			}
			if (럓.랾.lockWorldDataHelper.GetPlayerWhoOwnsLockId() == 럓.랾.playerId)
			{
				return;
			}
			foreach (ILockSmall lockSmall in 럓.랾.lockSmallDataHelper)
			{
				lockSmall.SetPlayerWhoOwnsLockId(럓.랾.playerId);
			}
			럓.랾.lockWorldDataHelper.SetPlayerWhoOwnsLockId(럓.랾.playerId);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0004192F File Offset: 0x0003FB2F
		public static void 랫()
		{
			랴.랾(97, ref 럧.럐, ref 럧.럎, -1.25f);
			랴.랾(100, ref 럧.랓, ref 럧.람, 1.25f);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000B49C8 File Offset: 0x000B2BC8
		private static void 랾(KeyCode A_0, ref bool A_1, ref float A_2, float A_3)
		{
			A_2 -= Time.deltaTime;
			if ((랅.럎(A_0) & A_1) && A_2 >= 0f)
			{
				럓.랾.ActivateForcedDirectionBounceByAIEnemy(A_3, 0.01f, 1f);
				ControllerHelper.particleManager.DoChangeLightingEffect(럓.랾.transform);
				A_2 = 0f;
				A_1 = false;
			}
			else if (랅.럎(A_0) && !A_1)
			{
				A_2 = 0.25f;
				A_1 = true;
			}
			if (A_2 < 0f)
			{
				A_1 = false;
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000B4A4C File Offset: 0x000B2C4C
		public static void 럍()
		{
			if (ConfigFile.freeCamToggle)
			{
				if (!랴.럎)
				{
					랴.랾 = new Vector3?(Camera.main.transform.position);
					랴.럎 = true;
				}
				랴.랬();
				return;
			}
			if (랴.럎)
			{
				랴.란();
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000B4A98 File Offset: 0x000B2C98
		private static void 랬()
		{
			Vector3 vector = Vector3.zero;
			Transform transform = Camera.main.transform;
			if (랅.랾(119))
			{
				vector += transform.up;
			}
			if (랅.랾(115))
			{
				vector -= transform.up;
			}
			if (랅.랾(97))
			{
				vector -= transform.right;
			}
			if (랅.랾(100))
			{
				vector += transform.right;
			}
			transform.position += vector.normalized * ConfigFile.freeCamSpeed;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000B4B30 File Offset: 0x000B2D30
		private static void 란()
		{
			if (랴.랾 != null)
			{
				Camera.main.transform.position = 랴.랾.Value;
				랴.랾 = null;
			}
			ControllerHelper.kukouriCamera.ForceUpdatePosition(true);
			랴.럎 = false;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000B4B80 File Offset: 0x000B2D80
		public static void 럇()
		{
			if (럽.랾() && 럓.랾.isPortalAnimationActive)
			{
				return;
			}
			럧.럆 += Time.deltaTime;
			if (럧.럆 < 2.5f)
			{
				return;
			}
			Vector2i[] source = new Vector2i[]
			{
				럓.랾.currentPlayerMapPoint,
				럓.랾.currentPlayerLeftMapPoint,
				럓.랾.currentPlayerRightMapPoint,
				럓.랾.currentPlayerAboveMapPoint
			};
			List<CollectableData>.Enumerator enumerator = 럓.랾.collectables.GetEnumerator();
			while (enumerator.MoveNext())
			{
				랴.럎 럎 = new 랴.럎();
				럎.랾 = enumerator.Current;
				if (!ConfigData.IsCollectableBlockedByColliderBlock(럓.랾, 럎.랾.mapPoint))
				{
					PickUpResult pickUpResult = 럓.랾.CanPlayerPick(럎.랾, false);
					if ((pickUpResult == 3 || pickUpResult == 2) && source.Any(new Func<Vector2i, bool>(럎.랾)))
					{
						OutgoingMessages.SendCollectCollectableMessage(럎.랾.id);
					}
				}
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000B4C8C File Offset: 0x000B2E8C
		public static void 랯()
		{
			GameObject gameObject = GameObject.Find("InputField");
			if (gameObject == null)
			{
				return;
			}
			TMP_InputField component = gameObject.GetComponent<TMP_InputField>();
			if (!component.isFocused)
			{
				return;
			}
			PlayerNamesManager.StatusIconType playerStatusIconType = ControllerHelper.playerNamesManager.GetPlayerStatusIconType(럓.랾.playerId);
			string text = component.text;
			PlayerNamesManager.StatusIconType statusIconType;
			if (text.StartsWith("/w") || text.StartsWith("/r"))
			{
				statusIconType = 1;
			}
			else if (text.StartsWith("/"))
			{
				statusIconType = 0;
			}
			else
			{
				statusIconType = 2;
			}
			if (playerStatusIconType != statusIconType)
			{
				OutgoingMessages.SetStatusIcon(statusIconType);
				ControllerHelper.playerNamesManager.UpdateMyStatusIcon(statusIconType);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0004195D File Offset: 0x0003FB5D
		public static void 러()
		{
			if (!LoadingScreenController.instance.isActiveAndEnabled)
			{
				ControllerHelper.kukouriCamera.maxZoom = -9999999;
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0004197A File Offset: 0x0003FB7A
		public static void 럎(bool A_0)
		{
			if (럧.럫 == A_0)
			{
				return;
			}
			럧.럫 = A_0;
			if (!A_0)
			{
				랴.럑();
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000B4D20 File Offset: 0x000B2F20
		public static void 량()
		{
			if (!럧.럫)
			{
				랴.럑();
				return;
			}
			Camera main = Camera.main;
			if (main == null)
			{
				return;
			}
			if (!랴.람)
			{
				랴.럎 = new Vector3?(main.transform.position);
				랴.람 = true;
			}
			NetworkPlayer[] array = 럽.럒();
			if (array.Length == 0)
			{
				럧.럴 = "None";
				return;
			}
			if (럧.럐 < 0)
			{
				럧.럐 = 0;
			}
			if (럧.럐 >= array.Length)
			{
				럧.럐 = 0;
			}
			NetworkPlayer networkPlayer = array[럧.럐];
			if (networkPlayer == null || networkPlayer.playerScript == null)
			{
				럧.럴 = "None";
				return;
			}
			럧.럴 = (networkPlayer.name ?? "Unknown");
			Vector3 position = networkPlayer.playerScript.transform.position;
			main.transform.position = new Vector3(position.x, position.y, main.transform.position.z);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000B4E14 File Offset: 0x000B3014
		private static void 럑()
		{
			if (!랴.람)
			{
				return;
			}
			Camera main = Camera.main;
			if (main != null && 랴.럎 != null)
			{
				main.transform.position = 랴.럎.Value;
			}
			if (!ConfigFile.freeCamToggle)
			{
				KukouriCamera kukouriCamera = ControllerHelper.kukouriCamera;
				if (kukouriCamera != null)
				{
					kukouriCamera.ForceUpdatePosition(true);
				}
			}
			랴.럎 = null;
			랴.람 = false;
			럧.럴 = "None";
		}

		// Token: 0x04000711 RID: 1809
		private static bool 랾 = false;

		// Token: 0x04000712 RID: 1810
		private static float 랾;

		// Token: 0x04000713 RID: 1811
		private static float 럎;

		// Token: 0x04000714 RID: 1812
		private static float 람;

		// Token: 0x04000715 RID: 1813
		private static AIEnemyMonoBehaviourBase[] 랾 = Array.Empty<AIEnemyMonoBehaviourBase>();

		// Token: 0x04000716 RID: 1814
		private static float 럒;

		// Token: 0x04000717 RID: 1815
		private static readonly string[] 랾 = new string[]
		{
			"NETHERWORLD",
			"DEEPNETHER"
		};

		// Token: 0x04000718 RID: 1816
		private static Vector3? 랾 = null;

		// Token: 0x04000719 RID: 1817
		private static bool 럎 = false;

		// Token: 0x0400071A RID: 1818
		private static Vector3? 럎 = null;

		// Token: 0x0400071B RID: 1819
		private static bool 람 = false;

		// Token: 0x02000133 RID: 307
		[CompilerGenerated]
		[Serializable]
		private sealed class 랾
		{
			// Token: 0x060009DC RID: 2524 RVA: 0x0004199F File Offset: 0x0003FB9F
			internal void 랾(string A_1, string A_2)
			{
				럽.랾(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩랝() + A_2, false);
				OutgoingMessages.KickPlayer(A_1);
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x000419B8 File Offset: 0x0003FBB8
			internal void 럎(string A_1, string A_2)
			{
				럽.랾(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩럾() + A_2, false);
				OutgoingMessages.BanAndKickPlayer(A_1);
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x000419D1 File Offset: 0x0003FBD1
			internal void 람(string A_1, string A_2)
			{
				럽.랾(E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럩럀() + A_2, false);
				OutgoingMessages.SummonPlayerToLocation(A_1);
			}

			// Token: 0x0400071C RID: 1820
			public static readonly 랴.랾 랾 = new 랴.랾();

			// Token: 0x0400071D RID: 1821
			public static Action<string, string> 랾;

			// Token: 0x0400071E RID: 1822
			public static Action<string, string> 럎;

			// Token: 0x0400071F RID: 1823
			public static Action<string, string> 람;
		}

		// Token: 0x02000134 RID: 308
		[CompilerGenerated]
		private sealed class 럎
		{
			// Token: 0x060009E0 RID: 2528 RVA: 0x000419EA File Offset: 0x0003FBEA
			internal bool 랾(Vector2i A_1)
			{
				return A_1 == this.랾.mapPoint;
			}

			// Token: 0x04000720 RID: 1824
			public CollectableData 랾;
		}
	}
}
