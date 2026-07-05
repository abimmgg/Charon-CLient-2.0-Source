using System;
using HarmonyLib;

namespace CharonAndFriends.HarmonyPatches
{
	// Token: 0x020000E9 RID: 233
	internal static class TrackingPatches
	{
		// Token: 0x020000EA RID: 234
		[HarmonyPatch(typeof(AnalyticsManager), "Initialize")]
		private static class Patch_AnalyticsManager_Initialize
		{
			// Token: 0x060006D8 RID: 1752 RVA: 0x0003FD1C File Offset: 0x0003DF1C
			private static bool Prefix(ref bool __result)
			{
				__result = false;
				return false;
			}
		}

		// Token: 0x020000EB RID: 235
		[HarmonyPatch(typeof(AnalyticsManager), "GetTrackingConsent")]
		private static class Patch_AnalyticsManager_GetTrackingConsent
		{
			// Token: 0x060006D9 RID: 1753 RVA: 0x0003FD1C File Offset: 0x0003DF1C
			private static bool Prefix(ref bool __result)
			{
				__result = false;
				return false;
			}
		}

		// Token: 0x020000EC RID: 236
		[HarmonyPatch(typeof(AnalyticsManager), "GetTrackingConsentSeen")]
		private static class Patch_AnalyticsManager_GetTrackingConsentSeen
		{
			// Token: 0x060006DA RID: 1754 RVA: 0x0003FD1C File Offset: 0x0003DF1C
			private static bool Prefix(ref bool __result)
			{
				__result = false;
				return false;
			}
		}

		// Token: 0x020000ED RID: 237
		[HarmonyPatch(typeof(AnalyticsManager), "HasPlayerGivenConsent")]
		private static class Patch_AnalyticsManager_HasPlayerGivenConsent
		{
			// Token: 0x060006DB RID: 1755 RVA: 0x0003FD1C File Offset: 0x0003DF1C
			private static bool Prefix(ref bool __result)
			{
				__result = false;
				return false;
			}
		}

		// Token: 0x020000EE RID: 238
		[HarmonyPatch(typeof(AnalyticsManager), "SetHasPlayerGivenConsent")]
		private static class Patch_AnalyticsManager_SetHasPlayerGivenConsent
		{
			// Token: 0x060006DC RID: 1756 RVA: 0x0003FD22 File Offset: 0x0003DF22
			private static bool Prefix()
			{
				AnalyticsManager.hasPlayerGivenConsent = false;
				return false;
			}
		}

		// Token: 0x020000EF RID: 239
		[HarmonyPatch(typeof(AnalyticsManager), "SendAnalyticsEvent")]
		private static class Patch_AnalyticsManager_SendAnalyticsEvent
		{
			// Token: 0x060006DD RID: 1757 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F0 RID: 240
		[HarmonyPatch(typeof(AnalyticsManager), "RouteAnalyticsEvent")]
		private static class Patch_AnalyticsManager_RouteAnalyticsEvent
		{
			// Token: 0x060006DE RID: 1758 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F1 RID: 241
		[HarmonyPatch(typeof(AnalyticsManager), "SendDevtodevEvent")]
		private static class Patch_AnalyticsManager_SendDevtodevEvent
		{
			// Token: 0x060006DF RID: 1759 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F2 RID: 242
		[HarmonyPatch(typeof(AnalyticsManager), "SendFirebaseEvent")]
		private static class Patch_AnalyticsManager_SendFirebaseEvent
		{
			// Token: 0x060006E0 RID: 1760 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F3 RID: 243
		[HarmonyPatch(typeof(AnalyticsManager), "SendSingularEvent")]
		private static class Patch_AnalyticsManager_SendSingularEvent
		{
			// Token: 0x060006E1 RID: 1761 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F4 RID: 244
		[HarmonyPatch(typeof(AnalyticsManager), "SendUnityAnalyticsEvent")]
		private static class Patch_AnalyticsManager_SendUnityAnalyticsEvent
		{
			// Token: 0x060006E2 RID: 1762 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F5 RID: 245
		[HarmonyPatch(typeof(FirebaseManager), "InitializeFirebaseAndStart")]
		private static class Patch_FirebaseManager_InitializeFirebaseAndStart
		{
			// Token: 0x060006E3 RID: 1763 RVA: 0x0003FD2B File Offset: 0x0003DF2B
			private static bool Prefix()
			{
				FirebaseManager.firebaseInitialized = false;
				return false;
			}
		}

		// Token: 0x020000F6 RID: 246
		[HarmonyPatch(typeof(FirebaseManager), "IsInitialized")]
		private static class Patch_FirebaseManager_IsInitialized
		{
			// Token: 0x060006E4 RID: 1764 RVA: 0x0003FD1C File Offset: 0x0003DF1C
			private static bool Prefix(ref bool __result)
			{
				__result = false;
				return false;
			}
		}

		// Token: 0x020000F7 RID: 247
		[HarmonyPatch(typeof(FirebaseManager), "AddEventToQueue")]
		private static class Patch_FirebaseManager_AddEventToQueue
		{
			// Token: 0x060006E5 RID: 1765 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F8 RID: 248
		[HarmonyPatch(typeof(FirebaseManager), "SendEvent")]
		private static class Patch_FirebaseManager_SendEvent
		{
			// Token: 0x060006E6 RID: 1766 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000F9 RID: 249
		[HarmonyPatch(typeof(FirebaseManager), "TrackCreateFirstWorld")]
		private static class Patch_FirebaseManager_TrackCreateFirstWorld
		{
			// Token: 0x060006E7 RID: 1767 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000FA RID: 250
		[HarmonyPatch(typeof(FirebaseManager), "TrackFinished5DailyQuests")]
		private static class Patch_FirebaseManager_TrackFinished5DailyQuests
		{
			// Token: 0x060006E8 RID: 1768 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000FB RID: 251
		[HarmonyPatch(typeof(FirebaseManager), "TrackFirstPerkSet")]
		private static class Patch_FirebaseManager_TrackFirstPerkSet
		{
			// Token: 0x060006E9 RID: 1769 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000FC RID: 252
		[HarmonyPatch(typeof(FirebaseManager), "TrackFirstRecipeFound")]
		private static class Patch_FirebaseManager_TrackFirstRecipeFound
		{
			// Token: 0x060006EA RID: 1770 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000FD RID: 253
		[HarmonyPatch(typeof(FirebaseManager), "TrackPlayerAccountCreationConfirmed")]
		private static class Patch_FirebaseManager_TrackPlayerAccountCreationConfirmed
		{
			// Token: 0x060006EB RID: 1771 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000FE RID: 254
		[HarmonyPatch(typeof(SingularManager), "Initialize")]
		private static class Patch_SingularManager_Initialize
		{
			// Token: 0x060006EC RID: 1772 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x020000FF RID: 255
		[HarmonyPatch(typeof(SingularManager), "SendEvent")]
		private static class Patch_SingularManager_SendEvent
		{
			// Token: 0x060006ED RID: 1773 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x02000100 RID: 256
		[HarmonyPatch(typeof(SingularManager), "UpdatePlayerConsent")]
		private static class Patch_SingularManager_UpdatePlayerConsent
		{
			// Token: 0x060006EE RID: 1774 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x02000101 RID: 257
		[HarmonyPatch(typeof(DevtodevManager), "Initialize")]
		private static class Patch_DevtodevManager_Initialize
		{
			// Token: 0x060006EF RID: 1775 RVA: 0x0003FD34 File Offset: 0x0003DF34
			private static bool Prefix()
			{
				DevtodevManager.isInitialized = false;
				return false;
			}
		}

		// Token: 0x02000102 RID: 258
		[HarmonyPatch(typeof(DevtodevManager), "IsInitialized")]
		private static class Patch_DevtodevManager_IsInitialized
		{
			// Token: 0x060006F0 RID: 1776 RVA: 0x0003FD1C File Offset: 0x0003DF1C
			private static bool Prefix(ref bool __result)
			{
				__result = false;
				return false;
			}
		}

		// Token: 0x02000103 RID: 259
		[HarmonyPatch(typeof(DevtodevManager), "SendLevelUpEvent")]
		private static class Patch_DevtodevManager_SendLevelUpEvent
		{
			// Token: 0x060006F1 RID: 1777 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x02000104 RID: 260
		[HarmonyPatch(typeof(DevtodevManager), "SendPurchaseEvent")]
		private static class Patch_DevtodevManager_SendPurchaseEvent
		{
			// Token: 0x060006F2 RID: 1778 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x02000105 RID: 261
		[HarmonyPatch(typeof(DevtodevManager), "SentTutorialEvent")]
		private static class Patch_DevtodevManager_SentTutorialEvent
		{
			// Token: 0x060006F3 RID: 1779 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}

		// Token: 0x02000106 RID: 262
		[HarmonyPatch(typeof(OutgoingMessages), "SendListOfUsedPlayerNames", new Type[]
		{
			typeof(string)
		})]
		private static class Patch_OutgoingMessages_SendListOfUsedPlayerNames
		{
			// Token: 0x060006F4 RID: 1780 RVA: 0x0003FBFC File Offset: 0x0003DDFC
			private static bool Prefix()
			{
				return false;
			}
		}
	}
}
