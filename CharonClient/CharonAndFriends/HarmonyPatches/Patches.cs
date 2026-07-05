using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BasicTypes;
using CharonClient.Configuration;
using HarmonyLib;
using Kernys.Bson;
using Prime31;
using 랾;

namespace CharonAndFriends.HarmonyPatches
{
	// Token: 0x020000B4 RID: 180
	internal class Patches
	{
		// Token: 0x020000B5 RID: 181
		[HarmonyPatch(typeof(AsynchronousClient), "SendMessages")]
		public static class Patch_SendMessages
		{
			// Token: 0x060006A3 RID: 1699 RVA: 0x000A06B0 File Offset: 0x0009E8B0
			public static bool Prefix()
			{
				if (!럽.랾())
				{
					return true;
				}
				bool fakeLagToggle = ConfigFile.fakeLagToggle;
				if (fakeLagToggle && !ConfigFile.fakeLagToggle && 럧.럑)
				{
					럧.랾 = 럓.랾.transform.position;
					ConfigFile.fakeLagToggle = true;
				}
				else if (!fakeLagToggle)
				{
					ConfigFile.fakeLagToggle = false;
				}
				return !fakeLagToggle;
			}
		}

		// Token: 0x020000B6 RID: 182
		[HarmonyPatch(typeof(Player), "DeathByColliderInCollider")]
		public static class Patch_DeathByColliderInCollider
		{
			// Token: 0x060006A4 RID: 1700 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
			public static bool Prefix(Vector2i mapPoint)
			{
				return !ConfigFile.antiBlockKillToggle;
			}
		}

		// Token: 0x020000B7 RID: 183
		[HarmonyPatch(typeof(Player), "HitPlayerFromBlock", new Type[]
		{
			typeof(World.BlockType),
			typeof(Vector2i),
			typeof(bool)
		})]
		public static class Patch_HitPlayerFromBlock1
		{
			// Token: 0x060006A5 RID: 1701 RVA: 0x0003FB02 File Offset: 0x0003DD02
			public static bool Prefix(ref bool __result, World.BlockType blocktype, Vector2i blockMapPoint, bool shouldEndDamageFromTrap = false)
			{
				if (!ConfigFile.godModeToggle)
				{
					return true;
				}
				__result = true;
				return false;
			}
		}

		// Token: 0x020000B8 RID: 184
		[HarmonyPatch(typeof(Player), "HitPlayerFromBlock", new Type[]
		{
			typeof(int),
			typeof(World.BlockType),
			typeof(Vector2i)
		})]
		public static class Patch_HitPlayerFromBlock2
		{
			// Token: 0x060006A6 RID: 1702 RVA: 0x0003FB02 File Offset: 0x0003DD02
			public static bool Prefix(ref bool __result, int hitForce, World.BlockType hitFromBlockBlockType, Vector2i blockMapPoint)
			{
				if (!ConfigFile.godModeToggle)
				{
					return true;
				}
				__result = true;
				return false;
			}
		}

		// Token: 0x020000B9 RID: 185
		[HarmonyPatch(typeof(Player), "HitPlayerFromAIEnemy", new Type[]
		{
			typeof(AIBase),
			typeof(AIDamageModelType)
		})]
		public static class Patch_HitPlayerFromAIEnemy
		{
			// Token: 0x060006A7 RID: 1703 RVA: 0x0003FB11 File Offset: 0x0003DD11
			public static bool Prefix()
			{
				return !ConfigFile.godModeToggle;
			}
		}

		// Token: 0x020000BA RID: 186
		[HarmonyPatch(typeof(ConfigData), "IsBlockShooterTrap")]
		public static class Patch_IsBlockShooterTrap
		{
			// Token: 0x060006A8 RID: 1704 RVA: 0x0003FB11 File Offset: 0x0003DD11
			public static bool Prefix()
			{
				return !ConfigFile.godModeToggle;
			}
		}

		// Token: 0x020000BB RID: 187
		[HarmonyPatch(typeof(ConfigData), "CanSitDownToBlock")]
		public static class Patch_CanSitDownToBlock
		{
			// Token: 0x060006A9 RID: 1705 RVA: 0x0003FB11 File Offset: 0x0003DD11
			public static bool Prefix()
			{
				return !ConfigFile.godModeToggle;
			}
		}

		// Token: 0x020000BC RID: 188
		[HarmonyPatch(typeof(ConfigData), "GetHidePlayerBlock")]
		public static class Patch_GetHidePlayerBlock
		{
			// Token: 0x060006AA RID: 1706 RVA: 0x0003FB11 File Offset: 0x0003DD11
			public static bool Prefix()
			{
				return !ConfigFile.godModeToggle;
			}
		}

		// Token: 0x020000BD RID: 189
		[HarmonyPatch(typeof(Player), "CausePoisoned", new Type[]
		{
			typeof(AIEnemyType)
		})]
		public static class Patch_CausePoisonedFromEnemy
		{
			// Token: 0x060006AB RID: 1707 RVA: 0x0003FB1B File Offset: 0x0003DD1B
			public static bool Prefix()
			{
				return !ConfigFile.antiPoisonToggle;
			}
		}

		// Token: 0x020000BE RID: 190
		[HarmonyPatch(typeof(Player), "CausePoisoned", new Type[]
		{
			typeof(World.BlockType)
		})]
		public static class Patch_CausePoisonedFromBlock
		{
			// Token: 0x060006AC RID: 1708 RVA: 0x0003FB1B File Offset: 0x0003DD1B
			public static bool Prefix()
			{
				return !ConfigFile.antiPoisonToggle;
			}
		}

		// Token: 0x020000BF RID: 191
		[HarmonyPatch(typeof(Player), "CausePoisoned", new Type[]
		{
			typeof(float)
		})]
		public static class Patch_CausePoisonedFromDuration
		{
			// Token: 0x060006AD RID: 1709 RVA: 0x0003FB1B File Offset: 0x0003DD1B
			public static bool Prefix()
			{
				return !ConfigFile.antiPoisonToggle;
			}
		}

		// Token: 0x020000C0 RID: 192
		[HarmonyPatch(typeof(WorldController), "BlockColliderAndLayerHelper")]
		public static class Patch_BlockColliderAndLayerHelper
		{
			// Token: 0x060006AE RID: 1710 RVA: 0x0003FB25 File Offset: 0x0003DD25
			public static void Prefix(ref World.BlockType blockType)
			{
				if (ConfigData.IsBlockInstakill(blockType) && !럧.럯 && ConfigFile.godModeToggle)
				{
					blockType = 1;
				}
			}
		}

		// Token: 0x020000C1 RID: 193
		[HarmonyPatch(typeof(Player), "TakeHitFromOtherPlayer")]
		public static class Patch_TakeHitFromOtherPlayer
		{
			// Token: 0x060006AF RID: 1711 RVA: 0x0003FB41 File Offset: 0x0003DD41
			public static bool Prefix(string strikerUserID, bool doVelocityChange, bool doTakeHitEffect, World.BlockType topArmBlockType, int battleDamage, float healthBarValue)
			{
				return !ConfigFile.antiKnockbackToggle;
			}
		}

		// Token: 0x020000C2 RID: 194
		[HarmonyPatch(typeof(ConfigData), "IsBlockHot")]
		public static class Patch_IsBlockHot
		{
			// Token: 0x060006B0 RID: 1712 RVA: 0x0003FB4B File Offset: 0x0003DD4B
			public static bool Prefix(ref World.BlockType blockType)
			{
				return !ConfigFile.antiBounceToggle;
			}
		}

		// Token: 0x020000C3 RID: 195
		[HarmonyPatch(typeof(ConfigData), "IsBlockSpring")]
		public static class Patch_IsBlockSpring
		{
			// Token: 0x060006B1 RID: 1713 RVA: 0x0003FB4B File Offset: 0x0003DD4B
			public static bool Prefix()
			{
				return !ConfigFile.antiBounceToggle;
			}
		}

		// Token: 0x020000C4 RID: 196
		[HarmonyPatch(typeof(ConfigData), "IsBlockElastic")]
		public static class Patch_IsBlockElastic
		{
			// Token: 0x060006B2 RID: 1714 RVA: 0x0003FB4B File Offset: 0x0003DD4B
			public static bool Prefix()
			{
				return !ConfigFile.antiBounceToggle;
			}
		}

		// Token: 0x020000C5 RID: 197
		[HarmonyPatch(typeof(ConfigData), "IsBlockWind")]
		public static class Patch_IsBlockWind
		{
			// Token: 0x060006B3 RID: 1715 RVA: 0x0003FB55 File Offset: 0x0003DD55
			public static bool Prefix()
			{
				return !ConfigFile.antiFanToggle;
			}
		}

		// Token: 0x020000C6 RID: 198
		[HarmonyPatch(typeof(ConfigData), "IsBlockElevator")]
		public static class Patch_IsBlockElevator
		{
			// Token: 0x060006B4 RID: 1716 RVA: 0x0003FB5F File Offset: 0x0003DD5F
			public static bool Prefix()
			{
				return !ConfigFile.antiElevatorToggle;
			}
		}

		// Token: 0x020000C7 RID: 199
		[HarmonyPatch(typeof(ConfigData), "IsBlockTrap")]
		public static class Patch_IsBlockTrap
		{
			// Token: 0x060006B5 RID: 1717 RVA: 0x0003FB69 File Offset: 0x0003DD69
			public static bool Prefix(World.BlockType blockType)
			{
				return !ConfigFile.antiTrapCrash;
			}
		}

		// Token: 0x020000C8 RID: 200
		[HarmonyPatch(typeof(ConfigData), "GetDeflectorMaxForce")]
		public static class Patch_GetDeflectorMaxForce
		{
			// Token: 0x060006B6 RID: 1718 RVA: 0x0003FB73 File Offset: 0x0003DD73
			public static bool Prefix(World.BlockType blockType)
			{
				return !ConfigFile.antiPortalToggle;
			}
		}

		// Token: 0x020000C9 RID: 201
		[HarmonyPatch(typeof(ConfigData), "GetBlockRunSpeed")]
		public static class Patch_GetBlockRunSpeed
		{
			// Token: 0x060006B7 RID: 1719 RVA: 0x0003FB7D File Offset: 0x0003DD7D
			public static bool Prefix(World.BlockType blockType, ref float __result)
			{
				__result = 럧.랓;
				return !ConfigFile.increasedRunSpeedToggle;
			}
		}

		// Token: 0x020000CA RID: 202
		[HarmonyPatch(typeof(ConfigData), "GetCooldownToUseFist")]
		public static class Patch_GetCooldownToUseFist
		{
			// Token: 0x060006B8 RID: 1720 RVA: 0x0003FB8E File Offset: 0x0003DD8E
			public static bool Prefix(float multiplier, ref float __result)
			{
				__result = 럧.럯;
				return !ConfigFile.increasedHitSpeedToggle;
			}
		}

		// Token: 0x020000CB RID: 203
		[HarmonyPatch(typeof(Player), "CheckPortals")]
		public static class Patch_CheckPortals
		{
			// Token: 0x060006B9 RID: 1721 RVA: 0x0003FB73 File Offset: 0x0003DD73
			public static bool Prefix()
			{
				return !ConfigFile.antiPortalToggle;
			}
		}

		// Token: 0x020000CC RID: 204
		[HarmonyPatch(typeof(Player), "CheckCheckPoints")]
		public static class Patch_CheckCheckPoints
		{
			// Token: 0x060006BA RID: 1722 RVA: 0x0003FB9F File Offset: 0x0003DD9F
			public static bool Prefix()
			{
				return !ConfigFile.antiCheckPointToggle;
			}
		}

		// Token: 0x020000CD RID: 205
		[HarmonyPatch(typeof(Player), "CheckPressurePad")]
		public static class Patch_CheckPressurePad
		{
			// Token: 0x060006BB RID: 1723 RVA: 0x0003FBA9 File Offset: 0x0003DDA9
			public static bool Prefix()
			{
				return !ConfigFile.antiTriggerWiringToggle;
			}
		}

		// Token: 0x020000CE RID: 206
		[HarmonyPatch(typeof(Player), "CheckProximitySensor")]
		public static class Patch_CheckProximitySensor
		{
			// Token: 0x060006BC RID: 1724 RVA: 0x0003FBA9 File Offset: 0x0003DDA9
			public static bool Prefix()
			{
				return !ConfigFile.antiTriggerWiringToggle;
			}
		}

		// Token: 0x020000CF RID: 207
		[HarmonyPatch(typeof(Player), "IsPlayerInMapPoint")]
		public static class Patch_IsPlayerInMapPoint
		{
			// Token: 0x060006BD RID: 1725 RVA: 0x0003FBB3 File Offset: 0x0003DDB3
			public static bool Prefix()
			{
				return !ConfigFile.placeBlocksOnPlayersToggle;
			}
		}

		// Token: 0x020000D0 RID: 208
		[HarmonyPatch(typeof(WorldController), "InstantiateFogOfWar")]
		public static class Patch_InstantiateFogOfWar
		{
			// Token: 0x060006BE RID: 1726 RVA: 0x0003FBBD File Offset: 0x0003DDBD
			public static bool Prefix()
			{
				return !ConfigFile.antiDarknessToggle;
			}
		}

		// Token: 0x020000D1 RID: 209
		[HarmonyPatch(typeof(ConfigData), "CanPlayerPickCollectableFromBlock")]
		public static class Patch_CanPlayerPickCollectable
		{
			// Token: 0x060006BF RID: 1727 RVA: 0x0003FBC7 File Offset: 0x0003DDC7
			public static bool Prefix()
			{
				return !럧.럲;
			}
		}

		// Token: 0x020000D2 RID: 210
		[HarmonyPatch(typeof(SignWorldMessages), "Populate")]
		public static class Patch_SignPopulate
		{
			// Token: 0x060006C0 RID: 1728 RVA: 0x000A070C File Offset: 0x0009E90C
			public static bool Prefix()
			{
				foreach (SignWorldMessages.SignMessage signMessage in SignWorldMessages.messages)
				{
					if (signMessage != null && (signMessage.bubbleText.text.Contains("<size=-") || signMessage.signBubble.textBubbleText.text.Contains("<size=-")))
					{
						return !ConfigFile.antiTextCrash;
					}
				}
				return true;
			}
		}

		// Token: 0x020000D3 RID: 211
		[HarmonyPatch(typeof(ProfanityFilter), "Censor")]
		public static class Patch_Censor
		{
			// Token: 0x060006C1 RID: 1729 RVA: 0x0003FBD1 File Offset: 0x0003DDD1
			public static bool Prefix(ref string __result, ref string str)
			{
				__result = str;
				return !ConfigFile.antiCensorToggle;
			}
		}

		// Token: 0x020000D4 RID: 212
		[HarmonyPatch(typeof(ChatMessage), "StripTags")]
		public static class Patch_StripTags
		{
			// Token: 0x060006C2 RID: 1730 RVA: 0x0003FBDF File Offset: 0x0003DDDF
			public static bool Prefix(ref string msg, ref bool __result)
			{
				if (럧.럑 || msg.Contains("<color="))
				{
					__result = true;
					return false;
				}
				return true;
			}
		}

		// Token: 0x020000D5 RID: 213
		[HarmonyPatch(typeof(ChatUI), "NewMessage")]
		public static class Patch_NewMessage
		{
			// Token: 0x060006C3 RID: 1731 RVA: 0x000A0798 File Offset: 0x0009E998
			public static void Prefix(ChatMessage msg)
			{
				if (msg.channelType == 1 && ConfigFile.showGMWorldToggle)
				{
					Patches.Patch_NewMessage.AppendChannelTag(msg, "#FFFF00");
				}
				if (msg.channelType == 2 && !럽.랾(msg.userID))
				{
					string userID = msg.userID;
					PlayerData 랾 = 럓.랾;
					if (userID != ((랾 != null) ? 랾.playerId : null) && ConfigFile.showGMWorldToggle)
					{
						Patches.Patch_NewMessage.AppendChannelTag(msg, "#0091ff");
					}
				}
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x000A0808 File Offset: 0x0009EA08
			private static void AppendChannelTag(ChatMessage msg, string hexColor)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=");
				defaultInterpolatedStringHandler.AppendFormatted(hexColor);
				defaultInterpolatedStringHandler.AppendLiteral(">[");
				defaultInterpolatedStringHandler.AppendFormatted(msg.channel);
				defaultInterpolatedStringHandler.AppendLiteral("]</color>");
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				if (!msg.message.Contains(text))
				{
					msg.message = msg.message + " " + text;
				}
			}
		}

		// Token: 0x020000D6 RID: 214
		[HarmonyPatch(typeof(NetworkClient), "HandleModDeletedFRQMessagesByPlayer")]
		public static class Patch_HandleModDeletedFRQ
		{
			// Token: 0x060006C5 RID: 1733 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			public static bool Prefix(BSONObject currentMessage)
			{
				return false;
			}
		}

		// Token: 0x020000D7 RID: 215
		[HarmonyPatch(typeof(NetworkClient), "HandleModDeletedGlobalMessagesByPlayer")]
		public static class Patch_HandleModDeletedGlobal
		{
			// Token: 0x060006C6 RID: 1734 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			public static bool Prefix(BSONObject currentMessage)
			{
				return false;
			}
		}

		// Token: 0x020000D8 RID: 216
		[HarmonyPatch(typeof(NetworkClient), "HandleWarpPlayerMessage")]
		public static class Patch_HandleWarpPlayer
		{
			// Token: 0x060006C7 RID: 1735 RVA: 0x0003FBFF File Offset: 0x0003DDFF
			public static bool Prefix(BSONObject currentMessage)
			{
				if (!ConfigFile.antiSummonToggle)
				{
					return true;
				}
				럽.럎("Summon Blocked, Expect A Disconnect Within 10 Seconds.", false);
				럽.랉(currentMessage, "");
				return false;
			}
		}

		// Token: 0x020000D9 RID: 217
		[HarmonyPatch(typeof(ConfigData), "CanPlaceSeedTopOf")]
		public static class Patch_CanPlaceSeedTopOf
		{
			// Token: 0x060006C8 RID: 1736 RVA: 0x0003FC21 File Offset: 0x0003DE21
			public static bool Prefix(World.BlockType blockType, ref bool __result)
			{
				if (!ConfigFile.placeSeedsAnywhereToggle)
				{
					return true;
				}
				__result = true;
				return false;
			}
		}

		// Token: 0x020000DA RID: 218
		[HarmonyPatch(typeof(OutgoingMessages), "LeaveWorld")]
		public static class Patch_LeaveWorld
		{
			// Token: 0x060006C9 RID: 1737 RVA: 0x0003FC30 File Offset: 0x0003DE30
			public static bool Prefix()
			{
				럽.람("You've Been Kicked/Banned From The World, Leaving Within 5 Seconds!", false);
				return !ConfigFile.pausedLeaveToggle;
			}
		}

		// Token: 0x020000DB RID: 219
		[HarmonyPatch(typeof(OptionsMenuUI), "ExitWorldButtonClicked")]
		public static class Patch_ExitWorldButtonClicked
		{
			// Token: 0x060006CA RID: 1738 RVA: 0x0003FC45 File Offset: 0x0003DE45
			public static void Prefix()
			{
				ConfigFile.pausedLeaveToggle = false;
			}
		}

		// Token: 0x020000DC RID: 220
		[HarmonyPatch(typeof(SceneLoader), "GoFromWorldToMainMenu")]
		public static class Patch_GoFromWorldToMainMenu
		{
			// Token: 0x060006CB RID: 1739 RVA: 0x0003FC4D File Offset: 0x0003DE4D
			public static bool Prefix()
			{
				return !ConfigFile.pausedLeaveToggle;
			}
		}

		// Token: 0x020000DD RID: 221
		[HarmonyPatch(typeof(TitleScreenLogic), "ShowRandomLoadingScreenTip")]
		public static class Patch_ShowRandomLoadingScreenTip
		{
			// Token: 0x060006CC RID: 1740 RVA: 0x0003FC57 File Offset: 0x0003DE57
			public static bool Prefix(TitleScreenLogic __instance)
			{
				__instance.tipsText.text = Patches.Patch_ShowRandomLoadingScreenTip.tips[new Random().Next(0, Patches.Patch_ShowRandomLoadingScreenTip.tips.Count)];
				return false;
			}

			// Token: 0x04000595 RID: 1429
			private static readonly List<string> tips = new List<string>
			{
				"All the pretty stars shine for you, my love",
				"Drunk off power and I was pourin' up",
				"Te doy hasta mi último, último"
			};
		}

		// Token: 0x020000DE RID: 222
		[HarmonyPatch(typeof(NetworkPlayers), "GetNetworkPlayerData")]
		public static class Patch_GetNetworkPlayerData
		{
			// Token: 0x060006CE RID: 1742 RVA: 0x0003FCB1 File Offset: 0x0003DEB1
			public static bool Prefix(string userID)
			{
				럧.랾 = 0f;
				return true;
			}
		}

		// Token: 0x020000DF RID: 223
		[HarmonyPatch(typeof(AsynchronousClient), "StartClient")]
		public static class Patch_StartClient
		{
			// Token: 0x060006CF RID: 1743 RVA: 0x000A0888 File Offset: 0x0009EA88
			public static void Prefix()
			{
				string serverAddress = AsynchronousClient.serverAddress;
				int port = AsynchronousClient.port;
				Console.WriteLine("[Charon] Server Address: " + AsynchronousClient.serverAddress);
				Console.WriteLine("[Charon] Reconnect Address: " + AsynchronousClient.serverReconnectAddress);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[Charon] Connection check target: ");
				defaultInterpolatedStringHandler.AppendFormatted(serverAddress);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<int>(port);
				Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
				럴.AssertRuntimeKeyValid("Prefix");
				럍.랾(럙.람(), 80);
			}
		}

		// Token: 0x020000E0 RID: 224
		[HarmonyPatch(typeof(CharacterController2D), "move")]
		public static class Patch_CharacterController2D_Move_WorldCleanerFreeze
		{
			// Token: 0x060006D0 RID: 1744 RVA: 0x0003FCBE File Offset: 0x0003DEBE
			public static bool Prefix()
			{
				return !럧.럸;
			}
		}
	}
}
