using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using CharonClient.Configuration;
using HarmonyLib;
using Kernys.Bson;
using 랾;

namespace CharonAndFriends
{
	// Token: 0x02000073 RID: 115
	[HarmonyPatch(typeof(OutgoingMessages), "AddOneMessageToList")]
	public static class OutgoingMessages_AddOneMessageToList
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00082744 File Offset: 0x00080944
		public static bool Prefix(ref BSONObject toAdd)
		{
			if (toAdd == null)
			{
				return false;
			}
			if (랪.럎(toAdd, "Client"))
			{
				return false;
			}
			string text = 럘.랾(toAdd);
			if (OutgoingMessages_AddOneMessageToList.랾.Contains(text) || 랟.람(text))
			{
				return true;
			}
			랟.랾(toAdd, "Client");
			OutgoingMessages_AddOneMessageToList.HandleHitBlock(toAdd, text);
			OutgoingMessages_AddOneMessageToList.HandleGetWorldContent(toAdd, text);
			랟.랾(toAdd, text, "Client");
			OutgoingMessages_AddOneMessageToList.HandleAddGearItem(ref toAdd, text);
			OutgoingMessages_AddOneMessageToList.HandleNestedObjectLogging(toAdd, text, "RIi", "dI");
			OutgoingMessages_AddOneMessageToList.HandleNestedObjectLogging(toAdd, text, "Di", "dI");
			OutgoingMessages_AddOneMessageToList.HandleWorldItemUpdate(ref toAdd, text);
			return true;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000827E8 File Offset: 0x000809E8
		private static void HandleHitBlock(BSONObject toAdd, string packetId)
		{
			if (packetId != "HB")
			{
				return;
			}
			int num;
			int num2;
			if (!럘.랾(toAdd, "x", out num) || !럘.랾(toAdd, "y", out num2))
			{
				return;
			}
			string value = 럓.랾.GetBlockType(num, num2).ToString();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Hit Block [");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("] at (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0003E987 File Offset: 0x0003CB87
		private static void HandleGetWorldContent(BSONObject toAdd, string packetId)
		{
			if (packetId != "GWC")
			{
				return;
			}
			럴.AssertRuntimeKeyValid("HandleGetWorldContent");
			Console.WriteLine("GWC found & processed!");
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0008289C File Offset: 0x00080A9C
		private static void HandleAddGearItem(ref BSONObject toAdd, string packetId)
		{
			if (packetId != "AGI")
			{
				return;
			}
			BSONObject bsonobject;
			if (!럘.랾(toAdd, "WiB", out bsonobject))
			{
				return;
			}
			럽.럼(bsonobject, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			랟.랾(bsonobject, "Client");
			BSONObject bsonobject2;
			if (!럘.랾(bsonobject, "inventoryData", out bsonobject2))
			{
				return;
			}
			럽.럼(bsonobject2, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			OutgoingMessages_AddOneMessageToList.ApplyInventoryOverrides(bsonobject2);
			bsonobject["inventoryData"] = bsonobject2;
			toAdd["WiB"] = bsonobject;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00082918 File Offset: 0x00080B18
		private static void HandleNestedObjectLogging(BSONObject packet, string packetId, string expectedPacketId, string nestedKey)
		{
			if (packetId != expectedPacketId)
			{
				return;
			}
			BSONObject bsonobject;
			if (!럘.랾(packet, nestedKey, out bsonobject))
			{
				return;
			}
			럽.럼(bsonobject, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			랟.랾(bsonobject, "Client");
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00082954 File Offset: 0x00080B54
		private static void HandleWorldItemUpdate(ref BSONObject toAdd, string packetId)
		{
			if (packetId != "WIU")
			{
				return;
			}
			BSONObject bsonobject;
			if (!럘.랾(toAdd, "WiB", out bsonobject))
			{
				return;
			}
			럴.AssertRuntimeKeyValid("HandleWorldItemUpdate");
			럽.럼(bsonobject, E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮());
			랟.랾(bsonobject, "Client");
			if (럧.럔)
			{
				bsonobject["trapFrequencyType"] = 10;
			}
			toAdd["WiB"] = bsonobject;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000829C8 File Offset: 0x00080BC8
		private static void ApplyInventoryOverrides(BSONObject inventoryData)
		{
			if (inventoryData == null)
			{
				return;
			}
			if (ConfigFile.durabilityChangerToggle)
			{
				inventoryData["durability"] = 럧.랠;
			}
			if (ConfigFile.petDataToggle)
			{
				if (럧.럑)
				{
					inventoryData["isNameChanged"] = false;
				}
				OutgoingMessages_AddOneMessageToList.TrySetDateTicks(inventoryData, "dateOfBirthTicks", 럧.랱, 럧.럭, 럧.럯);
				inventoryData["name"] = 럧.럩;
				inventoryData["level"] = 럧.랓;
			}
			if (ConfigFile.bottleDataToggle)
			{
				OutgoingMessages_AddOneMessageToList.TrySetDateTicks(inventoryData, "creationTicks", 럧.란, 럧.랬, 럧.럍);
				inventoryData["sendername"] = 럧.럔;
				inventoryData["worldname"] = 럧.랦;
				inventoryData["topic"] = 럧.랞;
				inventoryData["message"] = 럧.럚;
			}
			if (ConfigFile.trophyDataToggle)
			{
				OutgoingMessages_AddOneMessageToList.TrySetDateTicks(inventoryData, "awardedticks", 럧.러, 럧.랯, 럧.럇);
				inventoryData["winnername"] = 럧.럳;
				inventoryData["worldname"] = 럧.랢;
			}
			if (ConfigFile.fishTrophyDataToggle)
			{
				OutgoingMessages_AddOneMessageToList.TrySetDateTicks(inventoryData, "caughtTimeTicks", 럧.럊, 럧.럑, 럧.량);
				inventoryData["playerName"] = 럧.럻;
				inventoryData["fishWeight"] = (double)럧.럙;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00082B6C File Offset: 0x00080D6C
		private static void TrySetDateTicks(BSONObject target, string key, int year, int month, int day)
		{
			try
			{
				target[key] = new DateTime(year, month, day).Ticks;
			}
			catch (Exception ex)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 5);
				defaultInterpolatedStringHandler.AppendLiteral("Invalid date for ");
				defaultInterpolatedStringHandler.AppendFormatted(key);
				defaultInterpolatedStringHandler.AppendLiteral(": ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(year);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(month);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(day);
				defaultInterpolatedStringHandler.AppendLiteral(" (");
				defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				랃.럒(defaultInterpolatedStringHandler.ToStringAndClear(), E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮(), 4f);
			}
		}

		// Token: 0x04000306 RID: 774
		private static readonly HashSet<string> 랾 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"GGBI",
			"PiU",
			"SB",
			"HitCnYL"
		};
	}
}
