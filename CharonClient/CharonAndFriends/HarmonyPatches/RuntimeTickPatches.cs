using System;
using HarmonyLib;
using 랾;

namespace CharonAndFriends.HarmonyPatches
{
	// Token: 0x020000E1 RID: 225
	internal static class RuntimeTickPatches
	{
		// Token: 0x020000E2 RID: 226
		[HarmonyPatch(typeof(WorldController), "Update")]
		private static class Patch_WorldController_Update
		{
			// Token: 0x060006D1 RID: 1745 RVA: 0x0003FCC8 File Offset: 0x0003DEC8
			private static void Postfix()
			{
				럓.럎("World");
			}
		}

		// Token: 0x020000E3 RID: 227
		[HarmonyPatch(typeof(ChatUI), "Update")]
		private static class Patch_ChatUI_Update
		{
			// Token: 0x060006D2 RID: 1746 RVA: 0x0003FCD4 File Offset: 0x0003DED4
			private static void Postfix()
			{
				럓.럎("Chat");
			}
		}

		// Token: 0x020000E4 RID: 228
		[HarmonyPatch(typeof(TitleScreenLogic), "Update")]
		private static class Patch_TitleScreenLogic_Update
		{
			// Token: 0x060006D3 RID: 1747 RVA: 0x0003FCE0 File Offset: 0x0003DEE0
			private static void Postfix()
			{
				럓.럎("Title");
			}
		}

		// Token: 0x020000E5 RID: 229
		[HarmonyPatch(typeof(MainMenuLogic), "Update")]
		private static class Patch_MainMenuLogic_Update
		{
			// Token: 0x060006D4 RID: 1748 RVA: 0x0003FCEC File Offset: 0x0003DEEC
			private static void Postfix()
			{
				럓.럎("Main Menu");
			}
		}

		// Token: 0x020000E6 RID: 230
		[HarmonyPatch(typeof(OptionsMenuUI), "Update")]
		private static class Patch_OptionsMenuUI_Update
		{
			// Token: 0x060006D5 RID: 1749 RVA: 0x0003FCF8 File Offset: 0x0003DEF8
			private static void Postfix()
			{
				럓.럎("Options");
			}
		}

		// Token: 0x020000E7 RID: 231
		[HarmonyPatch(typeof(AuctionHouseUI), "Update")]
		private static class Patch_AuctionHouseUI_Update
		{
			// Token: 0x060006D6 RID: 1750 RVA: 0x0003FD04 File Offset: 0x0003DF04
			private static void Postfix()
			{
				럓.럎("Auction");
			}
		}

		// Token: 0x020000E8 RID: 232
		[HarmonyPatch(typeof(BaseMenuUI), "Update")]
		private static class Patch_BaseMenuUI_Update
		{
			// Token: 0x060006D7 RID: 1751 RVA: 0x0003FD10 File Offset: 0x0003DF10
			private static void Postfix()
			{
				럓.럎("Base Menu");
			}
		}
	}
}
