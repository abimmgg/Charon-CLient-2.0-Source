using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace 랾
{
	// Token: 0x0200001B RID: 27
	internal static class 럇
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00071A00 File Offset: 0x0006FC00
		public static IEnumerable<란> 랾(bool A_0 = false)
		{
			럇.랾 랾 = new 럇.랾();
			랾.랾 = A_0;
			return 럇.랾.Where(new Func<란, bool>(랾.랾));
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00071A30 File Offset: 0x0006FC30
		public static 란 랾(string A_0, bool A_1 = false)
		{
			럇.럎 럎 = new 럇.럎();
			럎.랾 = A_0;
			if (string.IsNullOrWhiteSpace(럎.랾))
			{
				return null;
			}
			if (!럎.랾.StartsWith("/"))
			{
				럎.랾 = "/" + 럎.랾;
			}
			return 럇.랾(A_1).FirstOrDefault(new Func<란, bool>(럎.랾));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00071A98 File Offset: 0x0006FC98
		public static bool 랾(string A_0, out 랬 A_1)
		{
			A_1 = 랬.랾;
			if (string.IsNullOrWhiteSpace(A_0))
			{
				return false;
			}
			string text = A_0.ToLowerInvariant();
			if (text != null)
			{
				switch (text.Length)
				{
				case 2:
					if (text == "ui")
					{
						A_1 = 랬.랓;
						return true;
					}
					break;
				case 3:
				{
					char c = text[0];
					if (c != 'd')
					{
						if (c == 'p')
						{
							if (text == "pet")
							{
								A_1 = 랬.럭;
								return true;
							}
						}
					}
					else if (text == "dev")
					{
						A_1 = 랬.럙;
						return true;
					}
					break;
				}
				case 4:
				{
					char c = text[0];
					if (c != 'd')
					{
						if (c != 'i')
						{
							if (c == 'm')
							{
								if (text == "misc")
								{
									A_1 = 랬.랱;
									return true;
								}
							}
						}
						else if (text == "info")
						{
							A_1 = 랬.랾;
							return true;
						}
					}
					else if (text == "drop")
					{
						A_1 = 랬.랋;
						return true;
					}
					break;
				}
				case 5:
				{
					char c = text[0];
					if (c != 'd')
					{
						if (c != 'i')
						{
							if (c == 't')
							{
								if (text == "trash")
								{
									A_1 = 랬.랉;
									return true;
								}
							}
						}
						else if (text == "items")
						{
							A_1 = 랬.럼;
							return true;
						}
					}
					else if (text == "death")
					{
						A_1 = 랬.럯;
						return true;
					}
					break;
				}
				case 6:
					if (text == "player")
					{
						A_1 = 랬.람;
						return true;
					}
					break;
				case 8:
					if (text == "currency")
					{
						A_1 = 랬.럒;
						return true;
					}
					break;
				case 10:
				{
					char c = text[0];
					if (c != 'n')
					{
						if (c == 'w')
						{
							if (text == "worldadmin")
							{
								A_1 = 랬.럐;
								return true;
							}
						}
					}
					else if (text == "navigation")
					{
						A_1 = 랬.럎;
						return true;
					}
					break;
				}
				}
			}
			return false;
		}

		// Token: 0x04000061 RID: 97
		public static readonly List<란> 랾 = new List<란>
		{
			new 란("/help", "Show help, categories, or command usage", 랬.랾, true, false),
			new 란("/serverinfo", "Shows server address and IP", 랬.랾, false, false),
			new 란("/worldid", "Shows the current world ID", 랬.랾, false, false),
			new 란("/ownerid", "Shows the current world owner's ID", 랬.랾, false, false),
			new 란("/decay", "Shows the world's decay date", 랬.랾, false, false),
			new 란("/accesslist", "Shows who has access to the current lock", 랬.랾, false, false),
			new 란("/warp", "Warp to a world: /warp <name> [portalID]", 랬.럎, true, false),
			new 란("/w", "Shortcut for /warp", 랬.럎, true, false),
			new 란("/home", "Warp to your saved home world", 랬.럎, false, false),
			new 란("/sethome", "Set home world: /sethome <name>", 랬.럎, true, false),
			new 란("/rw", "Reload current world", 랬.럎, false, false),
			new 란("/rg", "Reload game", 랬.럎, false, false),
			new 란("/sit", "Sit animation", 랬.람, false, false),
			new 란("/sleep", "Toggle sleep animation", 랬.람, false, false),
			new 란("/hide", "Invisible animation", 랬.람, false, false),
			new 란("/eyeless", "Remove eyes", 랬.람, false, false),
			new 란("/eyebrowless", "Info on removing eyebrows", 랬.람, false, false),
			new 란("/headless1", "Remove head", 랬.람, false, false),
			new 란("/legless", "Remove legs", 랬.람, false, false),
			new 란("/bodyless", "Remove body", 랬.람, false, false),
			new 란("/getgems", "Calculate total world gems", 랬.럒, false, false),
			new 란("/tradegems", "Calculate total gems in a trade from the player you're trading", 랬.럒, false, false),
			new 란("/getstoredgems", "Calculate gems stored in safes", 랬.럒, false, false),
			new 란("/add", "Add item: /add <ID> [quantity]", 랬.럼, true, false),
			new 란("/search", "Search for a block by name: /search <term>", 랬.럼, true, false),
			new 란("/pullsword", "Attempt to pull the sword in stone", 랬.럼, false, false),
			new 란("/dropall", "Drop entire inventory (confirm twice)", 랬.랋, false, false),
			new 란("/dropwearables", "Drop all wearables (confirm twice)", 랬.랋, false, false),
			new 란("/dropweapons", "Drop all weapons (confirm twice)", 랬.랋, false, false),
			new 란("/dropblocks", "Drop all blocks (confirm twice)", 랬.랋, false, false),
			new 란("/dropbg", "Drop all backgrounds (confirm twice)", 랬.랋, false, false),
			new 란("/dropseeds", "Drop all seeds (confirm twice)", 랬.랋, false, false),
			new 란("/trashall", "Trash entire inventory (confirm twice)", 랬.랉, false, false),
			new 란("/trashblocks", "Trash all blocks (confirm twice)", 랬.랉, false, false),
			new 란("/trashbackgrounds", "Trash all backgrounds (confirm twice)", 랬.랉, false, false),
			new 란("/trashwearables", "Trash all wearables (confirm twice)", 랬.랉, false, false),
			new 란("/trashweapons", "Trash all weapons (confirm twice)", 랬.랉, false, false),
			new 란("/trashseeds", "Trash all seeds (confirm twice)", 랬.랉, false, false),
			new 란("/kick", "Kick player: /kick <name>", 랬.럐, true, false),
			new 란("/ban", "Ban player: /ban <name>", 랬.럐, true, false),
			new 란("/summon", "Summon player: /summon <name>", 랬.럐, true, false),
			new 란("/kickall", "Kick all players (requires access)", 랬.럐, false, false),
			new 란("/banall", "Ban all players (requires access)", 랬.럐, false, false),
			new 란("/summonall", "Summon all players (requires access)", 랬.럐, false, false),
			new 란("/breakdono", "Break a donation box", 랬.럐, false, false),
			new 란("/pwe", "Spawn PWE terminal", 랬.랓, false, false),
			new 란("/bank", "Spawn bank bot", 랬.랓, false, false),
			new 란("/dquest", "Open daily quest UI", 랬.랓, false, false),
			new 란("/fgemui", "Open fishing gem recycler UI", 랬.랓, false, false),
			new 란("/mgemui", "Open mining gem recycler UI", 랬.랓, false, false),
			new 란("/mwheel", "Open mining wheel of fortune UI", 랬.랓, false, false),
			new 란("/ctotem", "Open clan totem UI", 랬.랓, false, false),
			new 란("/favholo", "Spawn favourite world hologram", 랬.랓, false, false),
			new 란("/frostdeath", "Die by frost trap", 랬.럯, false, false),
			new 란("/firedeath", "Die by fire trap", 랬.럯, false, false),
			new 란("/chairdeath", "Die by electric chair", 랬.럯, false, false),
			new 란("/electricdeath", "Die by tesla sphere", 랬.럯, false, false),
			new 란("/love", "Pet love action", 랬.럭, false, false),
			new 란("/kiss", "Pet kiss action", 랬.럭, false, false),
			new 란("/follow", "Pet follow action", 랬.럭, false, false),
			new 란("/train", "Pet train action", 랬.럭, false, false),
			new 란("/setblock", "Set block relative to you: /setblock below|above|left|right blockID, e.g. /setblock below 1", 랬.랱, true, false),
			new 란("/hidemsg", "Send unreportable message: /hidemsg text", 랬.랱, true, false),
			new 란("/collectabledata", "Dump world collectable data to file", 랬.랱, false, false),
			new 란("/cmsg", "Send a client relay chat message: /cmsg message", 랬.랱, true, false),
			new 란("/queryplayer", "Query player info: /queryplayer name", 랬.랱, true, false),
			new 란("/modtools", "Open mod tools UI", 랬.럙, false, true),
			new 란("/looppets", "Toggle pet looping", 랬.럙, false, true),
			new 란("/reportall", "Report all players", 랬.럙, false, true)
		};

		// Token: 0x0200001C RID: 28
		[CompilerGenerated]
		private sealed class 랾
		{
			// Token: 0x0600009F RID: 159 RVA: 0x0003CE8C File Offset: 0x0003B08C
			internal bool 랾(란 A_1)
			{
				return this.랾 || !A_1.럼();
			}

			// Token: 0x04000062 RID: 98
			public bool 랾;
		}

		// Token: 0x0200001D RID: 29
		[CompilerGenerated]
		private sealed class 럎
		{
			// Token: 0x060000A1 RID: 161 RVA: 0x0003CEA1 File Offset: 0x0003B0A1
			internal bool 랾(란 A_1)
			{
				return string.Equals(A_1.랾(), this.랾, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000063 RID: 99
			public string 랾;
		}
	}
}
