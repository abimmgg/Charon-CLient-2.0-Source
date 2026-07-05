using System;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using BasicTypes;
using CharonClient.Configuration;
using Il2CppSystem;
using UnityEngine;

namespace 랾
{
	// Token: 0x02000137 RID: 311
	internal class 랮
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x000B7A70 File Offset: 0x000B5C70
		public static void 랾()
		{
			int num = 랮.랾.Next(1, 16);
			PlayerData.Gender gender = 랮.랾.Next(1, 3);
			short num2 = (short)랮.랾.Next(0, 1000);
			OutgoingMessages.PlayerInfoUpdated(gender, num2, num, 랮.랾.Next(1, 16));
			럓.랾.ChangeSkinColor(num);
			럓.랾.gender = gender;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000B7AD8 File Offset: 0x000B5CD8
		public static void 럎()
		{
			럧.럭 += Time.deltaTime;
			if (럧.럭 < 0.25f)
			{
				return;
			}
			string value = 럧.랺.ToLower();
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (!(((networkPlayer != null) ? networkPlayer.playerScript : null) == null) && networkPlayer.name.ToLower().Contains(value))
				{
					랮.랾(networkPlayer.playerScript.currentPlayerMapPoint);
				}
			}
			럧.럭 = 0f;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000B7B68 File Offset: 0x000B5D68
		public static void 람()
		{
			럧.랱 += Time.deltaTime;
			if (럧.랱 < 0.1f)
			{
				return;
			}
			Vector2i vector2i = 럽.랾(Camera.main.ScreenToWorldPoint(랅.람()));
			ConfigFile.fastRespawnToggle = false;
			DateTime dateTime = KukouriTime.Get();
			DateTime dateTime2 = dateTime.AddTicks(-1000L);
			OutgoingMessages.ForceKillPlayerByBlockHit(959, vector2i, dateTime2);
			ControllerHelper.particleManager.DoExplosionParticleSystem(vector2i);
			OutgoingMessages.SendResurrect(dateTime, 럓.랾.respawnMapPoint);
			럧.랱 = 0f;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000B7BF8 File Offset: 0x000B5DF8
		private static void 랾(Vector2i A_0)
		{
			DateTime dateTime = KukouriTime.Get();
			DateTime dateTime2 = dateTime.AddTicks(-1000L);
			OutgoingMessages.ForceKillPlayerByBlockHit(959, A_0, dateTime2);
			ControllerHelper.particleManager.DoExplosionParticleSystem(A_0);
			OutgoingMessages.SendResurrect(dateTime, 럓.랾.respawnMapPoint);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000B7C40 File Offset: 0x000B5E40
		public static void 럒()
		{
			if (!랮.랾(ref 럧.러, 0.2f))
			{
				return;
			}
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (networkPlayer != null)
				{
					OutgoingMessages.AskTrade(networkPlayer.clientId);
				}
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000B7C88 File Offset: 0x000B5E88
		public static void 럼()
		{
			if (!랮.랾(ref 럧.러, 0.2f))
			{
				return;
			}
			string value = 럧.랺.ToLower();
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				if (networkPlayer != null && networkPlayer.name.ToLower().Contains(value))
				{
					OutgoingMessages.AskTrade(networkPlayer.clientId);
				}
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00041B1F File Offset: 0x0003FD1F
		public static void 랋()
		{
			if (!랮.랾(ref 럧.랠, 2f))
			{
				return;
			}
			OutgoingMessages.SendPlayerPoisonStart(3153);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000B7CEC File Offset: 0x000B5EEC
		public static void 랉()
		{
			Vector2i currentPlayerMapPoint = 럓.랾.currentPlayerMapPoint;
			if (!럓.랾.ContainsBlock(968) && 럓.랾.currentPlayerPositionBlockType != 110)
			{
				ControllerHelper.worldController.SetBlock(968, currentPlayerMapPoint.x, currentPlayerMapPoint.y);
				럓.랾.SetBlock(968, currentPlayerMapPoint, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), false);
				럽.랾("Finish Line Placed!", false);
			}
			if (럓.랾.hasStartedRaceLocally)
			{
				OutgoingMessages.SendFinishLine(Vector2i.tempAddition);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00041B3D File Offset: 0x0003FD3D
		private static bool 랾(ref float A_0, float A_1)
		{
			A_0 += Time.deltaTime;
			if (A_0 < A_1)
			{
				return false;
			}
			A_0 = 0f;
			return true;
		}

		// Token: 0x04000730 RID: 1840
		private static readonly Random 랾 = new Random();
	}
}
