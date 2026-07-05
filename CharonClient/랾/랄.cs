using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using <PrivateImplementationDetails>{78F5D6B8-4575-4D3C-A48B-F0E351150BF8};
using CharonClient.Configuration;
using UnityEngine;

namespace 랾
{
	// Token: 0x0200011C RID: 284
	internal class 랄
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x000AD7D8 File Offset: 0x000AB9D8
		public static void 랾()
		{
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				Object @object;
				if (networkPlayer == null)
				{
					@object = null;
				}
				else
				{
					Player playerScript = networkPlayer.playerScript;
					@object = ((playerScript != null) ? playerScript.playerNameTextMeshPro : null);
				}
				if (!(@object == null) && !networkPlayer.playerScript.playerNameTextMeshPro.text.Contains("CHEATER"))
				{
					string nameWithId = NetworkPlayers.GetNameWithId(networkPlayer.clientId, false);
					랄.랾(networkPlayer, nameWithId);
					랄.람(networkPlayer, nameWithId);
				}
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000AD854 File Offset: 0x000ABA54
		private static void 랾(NetworkPlayer A_0, string A_1)
		{
			foreach (ChatMessage chatMessage in 럓.랾.chatClient.incomingChatMessages)
			{
				if (!(chatMessage.userID != A_0.clientId) && Regex.Replace(chatMessage.message, "<.*?>", string.Empty).Length > 128)
				{
					랄.랾(A_0, A_1, "BYPASSED TEXT LIMIT");
					return;
				}
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000AD8C8 File Offset: 0x000ABAC8
		private static void 럎(NetworkPlayer A_0, string A_1)
		{
			if (!A_0.name.Contains(""))
			{
				return;
			}
			A_0.playerScript.playerNameTextMeshPro.text = A_0.playerScript.playerNameTextMeshPro.text;
			랄.랾(A_0, A_1, "DUPLICATED ACCOUNT NAME");
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000AD914 File Offset: 0x000ABB14
		private static void 람(NetworkPlayer A_0, string A_1)
		{
			InventoryIFamiliar familiarData = A_0.playerScript.myPlayerData.GetFamiliarData(A_0.playerScript.myPlayerData.GetPlayerFamiliar());
			if (familiarData == null)
			{
				return;
			}
			string name = familiarData.GetName();
			bool isNameChanged = familiarData.GetIsNameChanged();
			int level = familiarData.GetLevel();
			long dateOfBirthTicks = familiarData.GetDateOfBirthTicks();
			if (name == E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮() && isNameChanged)
			{
				랄.랾(A_0, A_1, "FAKE UNNAMED PET");
				return;
			}
			if (name != E854A64B-0BBE-41D4-B2FE-C03C4AF7BF67.럎럮() && !isNameChanged)
			{
				랄.랾(A_0, A_1, "NAMED BUT UNMARKED PET");
				return;
			}
			if (level > 5 || level < 0)
			{
				랄.랾(A_0, A_1, "ABNORMAL PET LEVEL");
				return;
			}
			if (dateOfBirthTicks > DateTime.Now.Ticks)
			{
				랄.랾(A_0, A_1, "ABNORMAL PET AGE");
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000AD9D0 File Offset: 0x000ABBD0
		private static void 랾(NetworkPlayer A_0, string A_1, string A_2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Cheater Detected: Player: ");
			defaultInterpolatedStringHandler.AppendFormatted(A_1);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(A_2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			럽.랾(defaultInterpolatedStringHandler.ToStringAndClear(), false);
			A_0.playerScript.playerNameTextMeshPro.text = A_0.playerScript.playerNameTextMeshPro.text + " <color=red>[CHEATER]";
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000ADA54 File Offset: 0x000ABC54
		public static void 럎()
		{
			foreach (string text in 럧.랋)
			{
				if (럽.랾(text))
				{
					럧.럇 += Time.deltaTime;
					if (럧.럇 > 15f)
					{
						string nameWithId = NetworkPlayers.GetNameWithId(text, false);
						string str = 럧.랾.ContainsKey(text) ? 럧.랾[text] : "Unknown";
						럽.람("[MOD DETECTED]: " + nameWithId + " is an undercover mod! Real Name: " + str, !ConfigFile.modAndAdminNotifications);
						럧.럇 = 0f;
					}
					랄.람();
				}
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000ADAFC File Offset: 0x000ABCFC
		private static void 람()
		{
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				Object @object;
				if (networkPlayer == null)
				{
					@object = null;
				}
				else
				{
					Player playerScript = networkPlayer.playerScript;
					@object = ((playerScript != null) ? playerScript.playerNameTextMeshPro : null);
				}
				if (!(@object == null) && 럧.랾.ContainsKey(networkPlayer.clientId))
				{
					string nameWithId = NetworkPlayers.GetNameWithId(networkPlayer.clientId, false);
					if (!networkPlayer.playerScript.playerNameTextMeshPro.text.Contains("[MOD]"))
					{
						networkPlayer.playerScript.playerNameTextMeshPro.text = "<color=red>[MOD]<color=white>" + nameWithId;
					}
				}
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000ADBA0 File Offset: 0x000ABDA0
		public static void 럒()
		{
			string[] array = new string[]
			{
				"EXAMPLE1",
				"EXAMPLE2",
				"EXAMPLE3",
				"EXAMPLE4"
			};
			foreach (NetworkPlayer networkPlayer in 럽.럒())
			{
				bool flag;
				if (networkPlayer == null)
				{
					flag = (null != null);
				}
				else
				{
					Player playerScript = networkPlayer.playerScript;
					flag = (((playerScript != null) ? playerScript.myPlayerData : null) != null);
				}
				if (flag && !(networkPlayer.playerScript.playerNameTextMeshPro == null) && array.Contains(networkPlayer.playerScript.myPlayerData.playerId))
				{
					럧.랯 += Time.deltaTime;
					string nameWithId = NetworkPlayers.GetNameWithId(networkPlayer.playerScript.myPlayerData.playerId, false);
					if (!networkPlayer.playerScript.playerNameTextMeshPro.text.Contains("[NON IN-GAME MOD]"))
					{
						networkPlayer.playerScript.playerNameTextMeshPro.text = "<color=red>[NON IN-GAME MOD]<color=white>" + nameWithId;
					}
					if (럧.랯 > 15f)
					{
						럽.람("[NON IN-GAME MOD]: " + nameWithId, !ConfigFile.modAndAdminNotifications);
						럧.랯 = 0f;
					}
				}
			}
		}
	}
}
