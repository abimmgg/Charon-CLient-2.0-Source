using System;
using CharonClient.Configuration;
using ImGuiNET;

namespace 랾
{
	// Token: 0x02000024 RID: 36
	public static class 러
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x0003D041 File Offset: 0x0003B241
		private static void 랾(bool A_0)
		{
			if (A_0)
			{
				global::랾.럴.AssertRuntimeKeyValid("Guard");
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0003D050 File Offset: 0x0003B250
		public static bool 랾(string A_0, ref bool A_1)
		{
			return ImGui.Checkbox(A_0, ref A_1);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0003D059 File Offset: 0x0003B259
		public static bool 랾()
		{
			return ConfigFile.godModeToggle;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0003D060 File Offset: 0x0003B260
		public static void 럎(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.godModeToggle = A_0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0003D06E File Offset: 0x0003B26E
		public static bool 럎()
		{
			return ConfigFile.antiBlockKillToggle;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0003D075 File Offset: 0x0003B275
		public static void 람(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.antiBlockKillToggle = A_0;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0003D083 File Offset: 0x0003B283
		public static bool 람()
		{
			return ConfigFile.antiKnockbackToggle;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0003D08A File Offset: 0x0003B28A
		public static void 럒(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.antiKnockbackToggle = A_0;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0003D098 File Offset: 0x0003B298
		public static bool 럒()
		{
			return ConfigFile.antiPoisonToggle;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0003D09F File Offset: 0x0003B29F
		public static void 럼(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.antiPoisonToggle = A_0;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0003D0AD File Offset: 0x0003B2AD
		public static bool 럼()
		{
			return ConfigFile.aimbotToggle;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		public static void 랋(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.aimbotToggle = A_0;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0003D0C2 File Offset: 0x0003B2C2
		public static bool 랋()
		{
			return ConfigFile.aimbotPVEToggle;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0003D0C9 File Offset: 0x0003B2C9
		public static void 랉(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.aimbotPVEToggle = A_0;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0003D0D7 File Offset: 0x0003B2D7
		public static bool 랉()
		{
			return ConfigFile.flyToggle;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0003D0DE File Offset: 0x0003B2DE
		public static void 럐(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.flyToggle = A_0;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0003D0EC File Offset: 0x0003B2EC
		public static bool 럐()
		{
			return ConfigFile.teleportToggle;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0003D0F3 File Offset: 0x0003B2F3
		public static void 랓(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.teleportToggle = A_0;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0003D101 File Offset: 0x0003B301
		public static bool 랓()
		{
			return ConfigFile.instantTeleportToggle;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0003D108 File Offset: 0x0003B308
		public static void 럯(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.instantTeleportToggle = A_0;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0003D116 File Offset: 0x0003B316
		public static bool 럯()
		{
			return ConfigFile.ghostTeleportToggle;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0003D11D File Offset: 0x0003B31D
		public static void 럭(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.ghostTeleportToggle = A_0;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0003D12B File Offset: 0x0003B32B
		public static bool 럭()
		{
			return ConfigFile.increasedRunSpeedToggle;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0003D132 File Offset: 0x0003B332
		public static void 랱(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.increasedRunSpeedToggle = A_0;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0003D140 File Offset: 0x0003B340
		public static bool 랱()
		{
			return ConfigFile.increasedHitSpeedToggle;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0003D147 File Offset: 0x0003B347
		public static void 럙(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.increasedHitSpeedToggle = A_0;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0003D155 File Offset: 0x0003B355
		public static bool 럙()
		{
			return ConfigFile.infiniteJumps;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0003D15C File Offset: 0x0003B35C
		public static void 랫(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.infiniteJumps = A_0;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0003D16A File Offset: 0x0003B36A
		public static bool 랫()
		{
			return ConfigFile.infiniteJetpackFuel;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0003D171 File Offset: 0x0003B371
		public static void 럍(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.infiniteJetpackFuel = A_0;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0003D17F File Offset: 0x0003B37F
		public static bool 럍()
		{
			return ConfigFile.airResistanceToggle;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0003D186 File Offset: 0x0003B386
		public static void 랬(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.airResistanceToggle = A_0;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0003D194 File Offset: 0x0003B394
		public static bool 랬()
		{
			return ConfigFile.unlimitedOxygenToggle;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0003D19B File Offset: 0x0003B39B
		public static void 란(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.unlimitedOxygenToggle = A_0;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0003D1A9 File Offset: 0x0003B3A9
		public static bool 란()
		{
			return ConfigFile.freeCamToggle;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0003D1B0 File Offset: 0x0003B3B0
		public static void 럇(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.freeCamToggle = A_0;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0003D1BE File Offset: 0x0003B3BE
		public static bool 럇()
		{
			return ConfigFile.fakeLagToggle;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0003D1C5 File Offset: 0x0003B3C5
		public static void 랯(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.fakeLagToggle = A_0;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0003D1D3 File Offset: 0x0003B3D3
		public static bool 랯()
		{
			return ConfigFile.extendedGhostTPToggle;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0003D1DA File Offset: 0x0003B3DA
		public static void 러(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.extendedGhostTPToggle = A_0;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		public static bool 러()
		{
			return ConfigFile.clickToBan;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0003D1EF File Offset: 0x0003B3EF
		public static void 량(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.clickToBan = A_0;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0003D1FD File Offset: 0x0003B3FD
		public static bool 량()
		{
			return ConfigFile.clickToKick;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0003D204 File Offset: 0x0003B404
		public static void 럑(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.clickToKick = A_0;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0003D212 File Offset: 0x0003B412
		public static bool 럑()
		{
			return ConfigFile.clickToSummon;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0003D219 File Offset: 0x0003B419
		public static void 럊(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.clickToSummon = A_0;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0003D227 File Offset: 0x0003B427
		public static bool 럊()
		{
			return ConfigFile.autoBanToggle;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0003D22E File Offset: 0x0003B42E
		public static void 랠(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.autoBanToggle = A_0;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0003D23C File Offset: 0x0003B43C
		public static bool 랠()
		{
			return ConfigFile.autoKickToggle;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0003D243 File Offset: 0x0003B443
		public static void 럏(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.autoKickToggle = A_0;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0003D251 File Offset: 0x0003B451
		public static bool 럏()
		{
			return ConfigFile.fullAccessToggle;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0003D258 File Offset: 0x0003B458
		public static void 럫(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.fullAccessToggle = A_0;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0003D266 File Offset: 0x0003B466
		public static bool 럫()
		{
			return ConfigFile.placeBlocksOnPlayersToggle;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0003D26D File Offset: 0x0003B46D
		public static void 럴(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.placeBlocksOnPlayersToggle = A_0;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0003D27B File Offset: 0x0003B47B
		public static bool 럴()
		{
			return ConfigFile.placeSeedsAnywhereToggle;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0003D282 File Offset: 0x0003B482
		public static void 럲(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.placeSeedsAnywhereToggle = A_0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0003D290 File Offset: 0x0003B490
		public static bool 럲()
		{
			return ConfigFile.openPouchSpam;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0003D297 File Offset: 0x0003B497
		public static void 럩(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.openPouchSpam = A_0;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0003D2A5 File Offset: 0x0003B4A5
		public static bool 럩()
		{
			return ConfigFile.playerESPTracer;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0003D2AC File Offset: 0x0003B4AC
		public static void 랦(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.playerESPTracer = A_0;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0003D2BA File Offset: 0x0003B4BA
		public static bool 랦()
		{
			return ConfigFile.playerESPBox;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0003D2C1 File Offset: 0x0003B4C1
		public static void 럔(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.playerESPBox = A_0;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0003D2CF File Offset: 0x0003B4CF
		public static bool 럔()
		{
			return ConfigFile.enemyESPTracer;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0003D2D6 File Offset: 0x0003B4D6
		public static void 랞(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.enemyESPTracer = A_0;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0003D2E4 File Offset: 0x0003B4E4
		public static bool 랞()
		{
			return ConfigFile.enemyESPBox;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0003D2EB File Offset: 0x0003B4EB
		public static void 럚(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.enemyESPBox = A_0;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0003D2F9 File Offset: 0x0003B4F9
		public static bool 럚()
		{
			return ConfigFile.modESPTracers;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0003D300 File Offset: 0x0003B500
		public static void 럳(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.modESPTracers = A_0;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0003D30E File Offset: 0x0003B50E
		public static bool 럳()
		{
			return ConfigFile.modESPBox;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0003D315 File Offset: 0x0003B515
		public static void 랢(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.modESPBox = A_0;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0003D323 File Offset: 0x0003B523
		public static bool 랢()
		{
			return ConfigFile.collectableESPTracer;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0003D32A File Offset: 0x0003B52A
		public static void 럻(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.collectableESPTracer = A_0;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0003D338 File Offset: 0x0003B538
		public static bool 럻()
		{
			return ConfigFile.collectableESPBox;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0003D33F File Offset: 0x0003B53F
		public static void 랖(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.collectableESPBox = A_0;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0003D34D File Offset: 0x0003B54D
		public static bool 랖()
		{
			return ConfigFile.giftBoxESPToggle;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0003D354 File Offset: 0x0003B554
		public static void 럝(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.giftBoxESPToggle = A_0;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0003D362 File Offset: 0x0003B562
		public static bool 럝()
		{
			return ConfigFile.netherBossESPToggle;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0003D369 File Offset: 0x0003B569
		public static void 럽(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.netherBossESPToggle = A_0;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0003D377 File Offset: 0x0003B577
		public static bool 럽()
		{
			return ConfigFile.netherKeyESPToggle;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0003D37E File Offset: 0x0003B57E
		public static void 럜(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.netherKeyESPToggle = A_0;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0003D38C File Offset: 0x0003B58C
		public static bool 럜()
		{
			return ConfigFile.netherExitESPToggle;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0003D393 File Offset: 0x0003B593
		public static void 럕(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.netherExitESPToggle = A_0;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0003D3A1 File Offset: 0x0003B5A1
		public static bool 럕()
		{
			return ConfigFile.portalESPToggle;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
		public static void 럘(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.portalESPToggle = A_0;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0003D3B6 File Offset: 0x0003B5B6
		public static bool 럘()
		{
			return ConfigFile.oreESPToggle;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0003D3BD File Offset: 0x0003B5BD
		public static void 랟(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.oreESPToggle = A_0;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0003D3CB File Offset: 0x0003B5CB
		public static bool 랟()
		{
			return ConfigFile.autoGiftBoxPickupToggle;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0003D3D2 File Offset: 0x0003B5D2
		public static void 랺(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.autoGiftBoxPickupToggle = A_0;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0003D3E0 File Offset: 0x0003B5E0
		public static bool 랺()
		{
			return ConfigFile.autoHarvestGrownSeedsToggle;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0003D3E7 File Offset: 0x0003B5E7
		public static void 럈(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.autoHarvestGrownSeedsToggle = A_0;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0003D3F5 File Offset: 0x0003B5F5
		public static bool 럈()
		{
			return ConfigFile.autoPlantSeedsToggle;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0003D3FC File Offset: 0x0003B5FC
		public static void 럧(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.autoPlantSeedsToggle = A_0;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0003D40A File Offset: 0x0003B60A
		public static bool 럧()
		{
			return ConfigFile.extendedPickUpToggle;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0003D411 File Offset: 0x0003B611
		public static void 럓(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.extendedPickUpToggle = A_0;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0003D41F File Offset: 0x0003B61F
		public static bool 럓()
		{
			return ConfigFile.fastRespawnToggle;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0003D426 File Offset: 0x0003B626
		public static void 랊(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.fastRespawnToggle = A_0;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0003D434 File Offset: 0x0003B634
		public static bool 랊()
		{
			return ConfigFile.zoomHackToggle;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0003D43B File Offset: 0x0003B63B
		public static void 럟(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.zoomHackToggle = A_0;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0003D449 File Offset: 0x0003B649
		public static bool 럟()
		{
			return ConfigFile.removeFrequencyCooldownToggle;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0003D450 File Offset: 0x0003B650
		public static void 럦(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.removeFrequencyCooldownToggle = A_0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0003D45E File Offset: 0x0003B65E
		public static bool 럦()
		{
			return ConfigFile.durabilityChangerToggle;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0003D465 File Offset: 0x0003B665
		public static void 랪(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.durabilityChangerToggle = A_0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0003D473 File Offset: 0x0003B673
		public static bool 랪()
		{
			return ConfigFile.unCappedTextToggle;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0003D47A File Offset: 0x0003B67A
		public static void 럷(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.unCappedTextToggle = A_0;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0003D488 File Offset: 0x0003B688
		public static bool 럷()
		{
			return ConfigFile.loginByTokenToggle;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0003D48F File Offset: 0x0003B68F
		public static void 럣(bool A_0)
		{
			global::랾.러.랾(A_0);
			ConfigFile.loginByTokenToggle = A_0;
		}
	}
}
