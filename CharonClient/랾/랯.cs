using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};

namespace 랾
{
	// Token: 0x0200001E RID: 30
	internal static class 랯
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00072358 File Offset: 0x00070558
		public static void 랾(string A_0, string A_1, PlayerData.InventoryKey[] A_2, PlayerData.InventoryItemType? A_3, bool A_4)
		{
			if (!럧.량)
			{
				럽.럎("Type " + A_0 + " again to confirm", false);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("THIS WILL ");
				defaultInterpolatedStringHandler.AppendFormatted(A_4 ? "TRASH" : "DROP");
				defaultInterpolatedStringHandler.AppendLiteral(" UP TO ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(4);
				defaultInterpolatedStringHandler.AppendLiteral(" OF YOUR ");
				defaultInterpolatedStringHandler.AppendFormatted(A_1.ToUpperInvariant());
				럽.람(defaultInterpolatedStringHandler.ToStringAndClear(), false);
				럽.럎("Dropping or trashing more than 4 items at once may disconnect you.", false);
				럧.량 = true;
				return;
			}
			Player player = ControllerHelper.worldController.player;
			int num = 0;
			int num2 = 0;
			while (num2 < A_2.Length && num < 4)
			{
				PlayerData.InventoryKey inventoryKey = A_2[num2];
				if ((A_3 == null || inventoryKey.itemType == A_3.Value) && !ConfigData.IsBlockLock(inventoryKey.blockType) && !ConfigData.IsBlockUntradeable(inventoryKey.blockType))
				{
					short count = player.myPlayerData.GetCount(inventoryKey);
					if (count > 0)
					{
						if (A_4)
						{
							player.TrashItems(inventoryKey, count);
						}
						else
						{
							player.DropItems(inventoryKey, count);
						}
						num++;
					}
				}
				num2++;
			}
			if (num == 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("No ");
				defaultInterpolatedStringHandler2.AppendFormatted(A_1);
				defaultInterpolatedStringHandler2.AppendLiteral(" found to ");
				defaultInterpolatedStringHandler2.AppendFormatted(A_4 ? "trash" : "drop");
				defaultInterpolatedStringHandler2.AppendLiteral(".");
				럽.럎(defaultInterpolatedStringHandler2.ToStringAndClear(), false);
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 4);
				defaultInterpolatedStringHandler3.AppendFormatted(A_4 ? "Trashed" : "Dropped");
				defaultInterpolatedStringHandler3.AppendLiteral(" ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler3.AppendLiteral(" ");
				defaultInterpolatedStringHandler3.AppendFormatted(A_1);
				defaultInterpolatedStringHandler3.AppendLiteral(" item");
				defaultInterpolatedStringHandler3.AppendFormatted((num == 1) ? E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮() : "s");
				defaultInterpolatedStringHandler3.AppendLiteral(".");
				럽.랾(defaultInterpolatedStringHandler3.ToStringAndClear(), false);
				if (num >= 4)
				{
					럽.럎("Only 4 items were processed. Dropping or trashing more at once may disconnect you.", false);
				}
			}
			럧.량 = false;
		}
	}
}
