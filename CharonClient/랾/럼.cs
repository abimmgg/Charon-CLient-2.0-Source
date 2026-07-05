using System;
using System.Collections.Generic;
using System.Numerics;
using ImGuiNET;

namespace 랾
{
	// Token: 0x02000006 RID: 6
	internal static class 럼
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00063238 File Offset: 0x00061438
		public static void 랾(PlayerData.InventoryItemType A_0, string A_1)
		{
			if (A_0 == 5)
			{
				ImGui.TextColored(new Vector4(1f, 0f, 0f, 1f), A_1);
				return;
			}
			if (A_0 == 4)
			{
				ImGui.TextColored(new Vector4(0.6f, 0f, 0.6f, 1f), A_1);
				return;
			}
			if (A_0 == null)
			{
				ImGui.TextColored(new Vector4(0.68f, 0.85f, 0.9f, 1f), A_1);
				return;
			}
			if (A_0 == 3)
			{
				ImGui.TextColored(new Vector4(0.68f, 0.85f, 0.9f, 1f), A_1);
				return;
			}
			if (A_0 == 12)
			{
				ImGui.TextColored(new Vector4(0.68f, 0.85f, 0.9f, 1f), A_1);
				return;
			}
			if (A_0 == 1)
			{
				ImGui.TextColored(new Vector4(0f, 0f, 1f, 1f), A_1);
				return;
			}
			if (A_0 == 2)
			{
				ImGui.TextColored(new Vector4(0.56f, 0.93f, 0.56f, 1f), A_1);
				return;
			}
			if (A_0 == 7)
			{
				ImGui.TextColored(new Vector4(1f, 0.75f, 0.8f, 1f), A_1);
				return;
			}
			if (A_0 == 9)
			{
				ImGui.TextColored(new Vector4(0.25f, 0.41f, 0.88f, 1f), A_1);
				return;
			}
			if (A_0 == 8)
			{
				ImGui.TextColored(new Vector4(1f, 1f, 0f, 1f), A_1);
				return;
			}
			if (A_0 == 6)
			{
				ImGui.TextColored(new Vector4(1f, 0.75f, 0.8f, 1f), A_1);
				return;
			}
			if (A_0 == 10)
			{
				ImGui.TextColored(new Vector4(0.7647f, 0.1412f, 0.9686f, 1f), A_1);
				return;
			}
			if (A_0 == 11)
			{
				ImGui.TextColored(new Vector4(1f, 0.75f, 0.8f, 1f), A_1);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0006341C File Offset: 0x0006161C
		public static uint 랾(string A_0)
		{
			Vector4 vector;
			if (럼.랾.TryGetValue(A_0.ToLower(), out vector))
			{
				return ImGui.ColorConvertFloat4ToU32(vector);
			}
			throw new ArgumentException("or" + A_0 + "t");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0006345C File Offset: 0x0006165C
		public static uint 랾(float[] A_0)
		{
			int num = (int)(A_0[0] * 255f);
			int num2 = (int)(A_0[1] * 255f);
			int num3 = (int)(A_0[2] * 255f);
			return (uint)((int)(A_0[3] * 255f) << 24 | num3 << 16 | num2 << 8 | num);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000634A4 File Offset: 0x000616A4
		public static float[] 랾(int A_0)
		{
			if (A_0 <= 3779)
			{
				if (A_0 <= 2276)
				{
					if (A_0 <= 1424)
					{
						if (A_0 <= 1236)
						{
							if (A_0 <= 1223)
							{
								switch (A_0)
								{
								case 1:
									return new float[]
									{
										0.714f,
										0.416f,
										0.145f,
										1f
									};
								case 2:
									return new float[]
									{
										0.227f,
										0.157f,
										0.071f,
										1f
									};
								case 3:
									return new float[]
									{
										0.337f,
										0.298f,
										0.259f,
										1f
									};
								case 4:
									return new float[]
									{
										0.271f,
										0.271f,
										0.286f,
										1f
									};
								case 5:
									return new float[]
									{
										0.824f,
										0.608f,
										0.369f,
										1f
									};
								case 6:
									return new float[]
									{
										0.906f,
										0.714f,
										0.427f,
										1f
									};
								case 7:
									return new float[]
									{
										0.451f,
										0.106f,
										0.012f,
										1f
									};
								case 8:
									return new float[]
									{
										0.749f,
										0.725f,
										0.706f,
										1f
									};
								case 9:
									return new float[]
									{
										0.263f,
										0.161f,
										0.227f,
										1f
									};
								case 10:
									return new float[]
									{
										0.075f,
										0.314f,
										0f,
										1f
									};
								case 11:
									return new float[]
									{
										0.216f,
										0.404f,
										0.153f,
										0f
									};
								case 12:
									return new float[]
									{
										0.067f,
										0.6f,
										0.027f,
										0f
									};
								case 13:
									return new float[]
									{
										0.337f,
										0.596f,
										0.035f,
										1f
									};
								case 14:
									return new float[]
									{
										0.255f,
										0.353f,
										0.612f,
										1f
									};
								case 15:
									return new float[]
									{
										0.522f,
										0.6f,
										0.733f,
										1f
									};
								case 16:
									return new float[]
									{
										0.745f,
										0.404f,
										0.216f,
										1f
									};
								case 17:
									return new float[]
									{
										0.565f,
										0.702f,
										0.784f,
										1f
									};
								case 18:
									return new float[]
									{
										0.153f,
										0.792f,
										1f,
										0.694f
									};
								case 19:
									return new float[]
									{
										0.482f,
										0.427f,
										0.369f,
										1f
									};
								case 20:
									return new float[]
									{
										0.522f,
										0.114f,
										0.063f,
										1f
									};
								case 21:
									return new float[]
									{
										0.682f,
										0.455f,
										0.059f,
										1f
									};
								case 22:
									return new float[]
									{
										0.702f,
										0.694f,
										0.69f,
										1f
									};
								case 23:
									return new float[]
									{
										0.118f,
										0.106f,
										0.098f,
										1f
									};
								case 24:
									return new float[]
									{
										0.749f,
										0.412f,
										0.196f,
										1f
									};
								case 25:
									return new float[]
									{
										0.749f,
										0.412f,
										0.196f,
										1f
									};
								case 26:
									return new float[]
									{
										0.341f,
										0.188f,
										0.09f,
										1f
									};
								case 27:
									return new float[]
									{
										0.169f,
										0.647f,
										0.031f,
										1f
									};
								case 28:
									return new float[]
									{
										0.761f,
										0.804f,
										0.855f,
										0f
									};
								case 29:
									return new float[]
									{
										0.941f,
										0.918f,
										0.831f,
										1f
									};
								case 30:
								{
									float[] array = new float[4];
									array[0] = 0.329f;
									array[1] = 0.18f;
									return array;
								}
								case 31:
									return new float[]
									{
										0.302f,
										0.282f,
										0.243f,
										1f
									};
								case 32:
									return new float[]
									{
										0.361f,
										0.369f,
										0.373f,
										1f
									};
								case 33:
									return new float[]
									{
										0.012f,
										0.945f,
										0.012f,
										1f
									};
								case 34:
									return new float[]
									{
										0.973f,
										0.933f,
										0f,
										1f
									};
								case 35:
									return new float[]
									{
										0.012f,
										0.471f,
										0.941f,
										1f
									};
								case 36:
									return new float[]
									{
										0.949f,
										0.196f,
										0.008f,
										1f
									};
								case 37:
									return new float[]
									{
										0.341f,
										0.165f,
										0.012f,
										1f
									};
								case 38:
								case 39:
								case 40:
								case 41:
								case 42:
								case 43:
								case 44:
								case 45:
								case 46:
								case 47:
								case 48:
								case 49:
								case 50:
								case 51:
								case 52:
								case 53:
								case 54:
								case 55:
								case 56:
								case 57:
								case 58:
								case 98:
								case 112:
								case 119:
								case 151:
								case 158:
								case 159:
								case 160:
								case 161:
								case 162:
								case 163:
								case 164:
								case 165:
								case 166:
								case 167:
								case 168:
								case 169:
								case 170:
								case 171:
								case 172:
								case 173:
								case 174:
								case 175:
								case 176:
								case 177:
								case 178:
								case 179:
								case 180:
								case 181:
								case 182:
								case 183:
								case 184:
								case 185:
								case 186:
								case 187:
								case 188:
								case 189:
								case 190:
								case 191:
								case 192:
								case 193:
								case 194:
								case 195:
								case 196:
								case 197:
								case 198:
								case 199:
								case 200:
								case 201:
								case 202:
								case 203:
								case 204:
								case 205:
								case 206:
								case 207:
								case 208:
								case 209:
								case 210:
								case 211:
								case 212:
								case 213:
								case 214:
								case 215:
								case 216:
								case 217:
								case 218:
								case 219:
								case 220:
								case 258:
								case 262:
								case 297:
								case 322:
								case 326:
								case 345:
								case 346:
								case 347:
								case 348:
								case 349:
								case 350:
								case 351:
								case 352:
								case 353:
								case 354:
								case 355:
								case 356:
								case 357:
								case 358:
								case 359:
								case 360:
								case 361:
								case 362:
								case 363:
								case 364:
								case 365:
								case 366:
								case 367:
								case 368:
								case 369:
								case 370:
								case 371:
								case 372:
								case 373:
								case 374:
								case 375:
								case 376:
								case 377:
								case 378:
								case 379:
								case 380:
								case 381:
								case 382:
								case 383:
								case 384:
								case 385:
								case 386:
								case 387:
								case 388:
								case 389:
								case 390:
								case 391:
								case 392:
								case 393:
								case 394:
								case 395:
								case 396:
								case 397:
								case 398:
								case 399:
								case 400:
								case 401:
								case 402:
								case 403:
								case 404:
								case 405:
								case 406:
								case 407:
								case 408:
								case 409:
								case 417:
								case 418:
								case 424:
								case 427:
								case 428:
								case 429:
								case 430:
								case 431:
								case 432:
								case 433:
								case 434:
								case 435:
								case 436:
								case 437:
								case 438:
								case 439:
								case 440:
								case 441:
								case 442:
								case 443:
								case 444:
								case 445:
								case 446:
								case 447:
								case 448:
								case 449:
								case 450:
								case 451:
								case 494:
								case 515:
								case 517:
								case 525:
								case 526:
								case 527:
								case 528:
								case 540:
								case 541:
								case 542:
								case 543:
								case 544:
								case 545:
								case 546:
								case 547:
								case 548:
								case 549:
								case 550:
								case 551:
								case 552:
								case 553:
								case 554:
								case 555:
								case 556:
								case 557:
								case 558:
								case 559:
								case 560:
								case 561:
								case 562:
								case 563:
								case 564:
								case 565:
								case 566:
								case 567:
								case 571:
								case 572:
								case 573:
								case 574:
								case 575:
								case 576:
								case 577:
								case 578:
								case 579:
								case 580:
								case 581:
								case 582:
								case 583:
								case 584:
								case 585:
								case 586:
								case 591:
								case 592:
								case 593:
								case 594:
								case 595:
								case 596:
								case 597:
								case 598:
								case 599:
								case 606:
								case 607:
								case 608:
								case 609:
								case 610:
								case 614:
								case 615:
								case 616:
								case 617:
								case 618:
								case 619:
								case 620:
								case 621:
								case 622:
								case 623:
								case 624:
								case 635:
								case 636:
								case 637:
								case 638:
								case 641:
								case 642:
								case 643:
								case 644:
								case 646:
								case 647:
								case 657:
								case 658:
								case 659:
								case 660:
								case 661:
								case 662:
								case 663:
								case 664:
								case 665:
								case 666:
								case 667:
								case 684:
								case 685:
								case 686:
								case 687:
								case 688:
								case 689:
								case 690:
								case 691:
								case 692:
								case 693:
								case 694:
								case 695:
								case 696:
								case 697:
								case 698:
								case 699:
								case 700:
								case 701:
								case 702:
								case 703:
								case 704:
								case 711:
								case 712:
								case 714:
								case 715:
								case 716:
								case 717:
								case 718:
								case 719:
								case 720:
								case 721:
								case 722:
								case 723:
								case 724:
								case 725:
								case 726:
								case 727:
								case 728:
								case 729:
								case 730:
								case 731:
								case 732:
								case 733:
								case 734:
								case 735:
								case 736:
								case 737:
								case 738:
								case 739:
								case 740:
								case 741:
								case 742:
								case 749:
								case 764:
								case 765:
								case 766:
								case 767:
								case 768:
								case 769:
								case 770:
								case 771:
								case 772:
								case 773:
								case 774:
								case 775:
								case 776:
								case 777:
								case 778:
								case 779:
								case 780:
								case 781:
								case 782:
								case 784:
								case 785:
								case 788:
								case 790:
								case 791:
								case 792:
								case 793:
								case 794:
								case 795:
								case 797:
								case 798:
								case 799:
								case 800:
								case 809:
								case 810:
								case 811:
								case 814:
								case 819:
								case 820:
								case 821:
								case 822:
								case 848:
								case 849:
								case 850:
								case 851:
								case 852:
								case 853:
								case 854:
								case 855:
								case 856:
								case 857:
								case 858:
								case 859:
								case 860:
								case 861:
								case 862:
								case 863:
								case 864:
								case 865:
								case 866:
								case 867:
								case 868:
								case 869:
								case 870:
								case 871:
								case 872:
								case 873:
								case 874:
								case 875:
								case 876:
								case 877:
								case 878:
								case 879:
								case 880:
								case 881:
								case 882:
								case 883:
								case 884:
								case 885:
								case 886:
								case 887:
								case 888:
								case 889:
								case 890:
								case 891:
								case 892:
								case 893:
								case 894:
								case 895:
								case 896:
								case 897:
								case 898:
								case 899:
								case 900:
								case 901:
								case 902:
								case 903:
								case 904:
								case 905:
								case 906:
								case 907:
								case 908:
								case 909:
								case 910:
								case 911:
								case 912:
								case 913:
								case 914:
								case 915:
								case 916:
								case 917:
								case 918:
								case 919:
								case 920:
								case 921:
								case 922:
								case 923:
								case 924:
								case 925:
								case 926:
								case 927:
								case 928:
								case 929:
								case 930:
								case 931:
								case 932:
								case 933:
								case 934:
								case 935:
								case 936:
								case 937:
								case 938:
								case 939:
								case 940:
								case 941:
								case 942:
								case 943:
								case 944:
								case 945:
								case 946:
								case 947:
								case 948:
								case 949:
								case 950:
								case 951:
								case 952:
								case 955:
								case 956:
								case 960:
								case 963:
								case 971:
								case 972:
								case 973:
									break;
								case 59:
									return new float[]
									{
										0.298f,
										0.176f,
										0.027f,
										1f
									};
								case 60:
									return new float[]
									{
										0.333f,
										0.412f,
										0.38f,
										1f
									};
								case 61:
									return new float[]
									{
										0.659f,
										0.706f,
										0.706f,
										1f
									};
								case 62:
									return new float[]
									{
										0.137f,
										0.169f,
										0.169f,
										1f
									};
								case 63:
									return new float[]
									{
										0.686f,
										0.235f,
										0.078f,
										1f
									};
								case 64:
									return new float[]
									{
										0.278f,
										0.278f,
										0.278f,
										1f
									};
								case 65:
									return new float[]
									{
										0.216f,
										0.078f,
										0.102f,
										1f
									};
								case 66:
									return new float[]
									{
										0.38f,
										0.996f,
										1f,
										1f
									};
								case 67:
									return new float[]
									{
										0.824f,
										0.608f,
										0.369f,
										1f
									};
								case 68:
									return new float[]
									{
										0.635f,
										0.22f,
										0.157f,
										1f
									};
								case 69:
									return new float[]
									{
										0.957f,
										0.271f,
										0.098f,
										1f
									};
								case 70:
									return new float[]
									{
										0.961f,
										0.784f,
										0.027f,
										1f
									};
								case 71:
									return new float[]
									{
										0.18f,
										0.518f,
										0.812f,
										1f
									};
								case 72:
									return new float[]
									{
										0.871f,
										0.871f,
										0.871f,
										1f
									};
								case 73:
									return new float[]
									{
										0.161f,
										0.161f,
										0.161f,
										1f
									};
								case 74:
									return new float[]
									{
										0.922f,
										0.667f,
										0.318f,
										1f
									};
								case 75:
									return new float[]
									{
										0.686f,
										0.537f,
										0.294f,
										1f
									};
								case 76:
									return new float[]
									{
										0.627f,
										0.459f,
										0.278f,
										0.918f
									};
								case 77:
									return new float[]
									{
										0.086f,
										0.075f,
										0.071f,
										1f
									};
								case 78:
									return new float[]
									{
										0.749f,
										0.412f,
										0.196f,
										1f
									};
								case 79:
									return new float[]
									{
										0.306f,
										0.212f,
										0.439f,
										1f
									};
								case 80:
									return new float[]
									{
										0.498f,
										0.498f,
										0.498f,
										1f
									};
								case 81:
									return new float[]
									{
										0.224f,
										0.812f,
										0.18f,
										1f
									};
								case 82:
									return new float[]
									{
										0.49f,
										0.18f,
										0.812f,
										1f
									};
								case 83:
									return new float[]
									{
										0.996f,
										0.545f,
										0f,
										1f
									};
								case 84:
									return new float[]
									{
										0.29f,
										0.761f,
										0.925f,
										1f
									};
								case 85:
									return new float[]
									{
										0.659f,
										0.659f,
										0.659f,
										1f
									};
								case 86:
									return new float[]
									{
										0.835f,
										0.294f,
										0.773f,
										1f
									};
								case 87:
									return new float[]
									{
										0.863f,
										0.471f,
										0.475f,
										1f
									};
								case 88:
									return new float[]
									{
										0.404f,
										0.294f,
										0.192f,
										0f
									};
								case 89:
									return new float[]
									{
										0.89f,
										0.776f,
										0.102f,
										1f
									};
								case 90:
									return new float[]
									{
										0.333f,
										0.561f,
										0.075f,
										1f
									};
								case 91:
									return new float[]
									{
										0.91f,
										0.91f,
										0.91f,
										1f
									};
								case 92:
									return new float[]
									{
										1f,
										0.894f,
										0.588f,
										1f
									};
								case 93:
									return new float[]
									{
										1f,
										0.894f,
										0.267f,
										1f
									};
								case 94:
									return new float[]
									{
										0.49f,
										0.576f,
										0.722f,
										1f
									};
								case 95:
									return new float[]
									{
										0.871f,
										0.914f,
										0.949f,
										1f
									};
								case 96:
									return new float[]
									{
										0.337f,
										0.267f,
										0.004f,
										1f
									};
								case 97:
									return new float[]
									{
										0.686f,
										0.396f,
										0.243f,
										1f
									};
								case 99:
									return new float[]
									{
										0.776f,
										0.776f,
										0.776f,
										1f
									};
								case 100:
									return new float[]
									{
										0.651f,
										0.651f,
										0.651f,
										1f
									};
								case 101:
									return new float[]
									{
										0.541f,
										0.541f,
										0.541f,
										1f
									};
								case 102:
									return new float[]
									{
										0.678f,
										0.341f,
										0.098f,
										1f
									};
								case 103:
									return new float[]
									{
										0.145f,
										0.58f,
										0.247f,
										1f
									};
								case 104:
									return new float[]
									{
										0.318f,
										0.176f,
										0.145f,
										1f
									};
								case 105:
									return new float[]
									{
										0.757f,
										0.549f,
										0.396f,
										1f
									};
								case 106:
									return new float[]
									{
										0.455f,
										0.455f,
										0.455f,
										1f
									};
								case 107:
									return new float[]
									{
										0.471f,
										0.22f,
										0f,
										1f
									};
								case 108:
									return new float[]
									{
										0.675f,
										0.71f,
										0.408f,
										1f
									};
								case 109:
									return new float[]
									{
										0.369f,
										0.082f,
										0.082f,
										1f
									};
								case 110:
									return new float[]
									{
										0.561f,
										0.561f,
										0.561f,
										1f
									};
								case 111:
									return new float[]
									{
										0.275f,
										0.275f,
										0.275f,
										1f
									};
								case 113:
									return new float[]
									{
										0.204f,
										0.208f,
										0.161f,
										1f
									};
								case 114:
									return new float[]
									{
										0.439f,
										0.286f,
										0.18f,
										1f
									};
								case 115:
									return new float[]
									{
										0.302f,
										0.067f,
										0.035f,
										1f
									};
								case 116:
									return new float[]
									{
										0.278f,
										0.157f,
										0.055f,
										1f
									};
								case 117:
									return new float[]
									{
										0.427f,
										0.318f,
										0.016f,
										1f
									};
								case 118:
									return new float[]
									{
										0.882f,
										0.78f,
										0.604f,
										1f
									};
								case 120:
									return new float[]
									{
										0.722f,
										0.722f,
										0.722f,
										0f
									};
								case 121:
									return new float[]
									{
										0.114f,
										0.482f,
										0.086f,
										1f
									};
								case 122:
									return new float[]
									{
										0.69f,
										0f,
										0.078f,
										1f
									};
								case 123:
									return new float[]
									{
										0.463f,
										0.082f,
										0.055f,
										1f
									};
								case 124:
									return new float[]
									{
										0.188f,
										0.188f,
										0.188f,
										1f
									};
								case 125:
									return new float[]
									{
										0.702f,
										0.396f,
										0.271f,
										1f
									};
								case 126:
									return new float[]
									{
										0.42f,
										0.42f,
										0.42f,
										1f
									};
								case 127:
									return new float[]
									{
										0.753f,
										0.094f,
										0.184f,
										1f
									};
								case 128:
									return new float[]
									{
										0.616f,
										0.592f,
										0.439f,
										1f
									};
								case 129:
									return new float[]
									{
										0.859f,
										0.851f,
										0.765f,
										1f
									};
								case 130:
									return new float[]
									{
										0.757f,
										0.969f,
										1f,
										1f
									};
								case 131:
									return new float[]
									{
										0.906f,
										0.906f,
										0.906f,
										1f
									};
								case 132:
									return new float[]
									{
										0.361f,
										0.361f,
										0.361f,
										1f
									};
								case 133:
									return new float[]
									{
										0.306f,
										0.306f,
										0.306f,
										1f
									};
								case 134:
									return new float[]
									{
										0.655f,
										0.314f,
										0.165f,
										1f
									};
								case 135:
									return new float[]
									{
										0.608f,
										0.655f,
										0.694f,
										1f
									};
								case 136:
									return new float[]
									{
										0.49f,
										0.49f,
										0.451f,
										1f
									};
								case 137:
									return new float[]
									{
										0.082f,
										0.4f,
										0.427f,
										1f
									};
								case 138:
									return new float[]
									{
										0.404f,
										0.443f,
										0.463f,
										1f
									};
								case 139:
									return new float[]
									{
										0.388f,
										0.392f,
										0.412f,
										1f
									};
								case 140:
									return new float[]
									{
										1f,
										0.941f,
										0.063f,
										1f
									};
								case 141:
									return new float[]
									{
										0.941f,
										0.929f,
										0.922f,
										1f
									};
								case 142:
									return new float[]
									{
										1f,
										0.773f,
										0f,
										1f
									};
								case 143:
									return new float[]
									{
										0.2f,
										0.2f,
										0.2f,
										1f
									};
								case 144:
									return new float[]
									{
										0.933f,
										0.325f,
										0.153f,
										1f
									};
								case 145:
									return new float[]
									{
										0.42f,
										0.639f,
										0.824f,
										1f
									};
								case 146:
									return new float[]
									{
										0.737f,
										0.588f,
										0.431f,
										1f
									};
								case 147:
									return new float[]
									{
										0.478f,
										0.325f,
										0.055f,
										1f
									};
								case 148:
									return new float[]
									{
										0.71f,
										0.639f,
										0.396f,
										1f
									};
								case 149:
									return new float[]
									{
										0.235f,
										0.173f,
										0.059f,
										1f
									};
								case 150:
									return new float[]
									{
										0.714f,
										0.714f,
										0.714f,
										0f
									};
								case 152:
									return new float[]
									{
										0.741f,
										0.659f,
										0.463f,
										1f
									};
								case 153:
									return new float[]
									{
										0.941f,
										0.38f,
										0.102f,
										1f
									};
								case 154:
									return new float[]
									{
										0.604f,
										0.322f,
										0.22f,
										1f
									};
								case 155:
									return new float[]
									{
										0.745f,
										0.184f,
										0.016f,
										1f
									};
								case 156:
									return new float[]
									{
										0.922f,
										0.922f,
										0.922f,
										0f
									};
								case 157:
									return new float[]
									{
										0.973f,
										0.831f,
										0.02f,
										1f
									};
								case 221:
									return new float[]
									{
										0.365f,
										0.396f,
										0.471f,
										1f
									};
								case 222:
									return new float[]
									{
										0.365f,
										0.396f,
										0.471f,
										1f
									};
								case 223:
									return new float[]
									{
										0.38f,
										0.376f,
										0.412f,
										1f
									};
								case 224:
									return new float[]
									{
										0.125f,
										0.165f,
										0.208f,
										1f
									};
								case 225:
									return new float[]
									{
										0.082f,
										0.11f,
										0.141f,
										1f
									};
								case 226:
									return new float[]
									{
										0.98f,
										0.988f,
										1f,
										1f
									};
								case 227:
									return new float[]
									{
										0.561f,
										0.561f,
										0.561f,
										0f
									};
								case 228:
									return new float[]
									{
										0.537f,
										0.522f,
										0.514f,
										1f
									};
								case 229:
									return new float[]
									{
										0.392f,
										0.388f,
										0.404f,
										1f
									};
								case 230:
									return new float[]
									{
										0.557f,
										0.518f,
										0.482f,
										1f
									};
								case 231:
									return new float[]
									{
										0.2f,
										0.2f,
										0.2f,
										1f
									};
								case 232:
									return new float[]
									{
										0.325f,
										0.325f,
										0.325f,
										0f
									};
								case 233:
									return new float[]
									{
										0.49f,
										0.49f,
										0.49f,
										1f
									};
								case 234:
									return new float[]
									{
										0.239f,
										0.239f,
										0.239f,
										1f
									};
								case 235:
									return new float[]
									{
										0.188f,
										0.196f,
										0.208f,
										1f
									};
								case 236:
									return new float[]
									{
										0.541f,
										0.541f,
										0.541f,
										1f
									};
								case 237:
									return new float[]
									{
										0.553f,
										0.553f,
										0.553f,
										0f
									};
								case 238:
									return new float[]
									{
										0.573f,
										0.329f,
										0.188f,
										1f
									};
								case 239:
									return new float[]
									{
										0.271f,
										0.271f,
										0.224f,
										1f
									};
								case 240:
									return new float[]
									{
										0.243f,
										0.106f,
										0.059f,
										1f
									};
								case 241:
									return new float[]
									{
										0.192f,
										0.192f,
										0.192f,
										1f
									};
								case 242:
									return new float[]
									{
										0.161f,
										0.086f,
										0.055f,
										1f
									};
								case 243:
									return new float[]
									{
										0.149f,
										0.145f,
										0.141f,
										1f
									};
								case 244:
									return new float[]
									{
										0.251f,
										0.18f,
										0.18f,
										1f
									};
								case 245:
									return new float[]
									{
										0.467f,
										0.376f,
										0.306f,
										1f
									};
								case 246:
									return new float[]
									{
										0.459f,
										0.106f,
										0.106f,
										1f
									};
								case 247:
									return new float[]
									{
										0.588f,
										0.471f,
										0.38f,
										1f
									};
								case 248:
									return new float[]
									{
										0.459f,
										0.42f,
										0.357f,
										1f
									};
								case 249:
									return new float[]
									{
										0.227f,
										0.196f,
										0.161f,
										1f
									};
								case 250:
									return new float[]
									{
										0.208f,
										0.173f,
										0.161f,
										1f
									};
								case 251:
									return new float[]
									{
										0.282f,
										0.251f,
										0.2f,
										1f
									};
								case 252:
									return new float[]
									{
										0.71f,
										0.796f,
										0.075f,
										1f
									};
								case 253:
									return new float[]
									{
										0.165f,
										0.424f,
										0.384f,
										1f
									};
								case 254:
									return new float[]
									{
										0.165f,
										0.11f,
										0.09f,
										1f
									};
								case 255:
									return new float[]
									{
										1f,
										0.757f,
										0.914f,
										1f
									};
								case 256:
									return new float[]
									{
										0.263f,
										0.263f,
										0.263f,
										1f
									};
								case 257:
									return new float[]
									{
										0.447f,
										0.388f,
										0.282f,
										1f
									};
								case 259:
									return new float[]
									{
										0.624f,
										0f,
										0.976f,
										1f
									};
								case 260:
									return new float[]
									{
										0.831f,
										0.788f,
										0.694f,
										1f
									};
								case 261:
									return new float[]
									{
										0.024f,
										0.188f,
										0.424f,
										1f
									};
								case 263:
									return new float[]
									{
										0.302f,
										0.518f,
										0.667f,
										1f
									};
								case 264:
									return new float[]
									{
										0.749f,
										0.494f,
										0.286f,
										1f
									};
								case 265:
									return new float[]
									{
										0.216f,
										0.216f,
										0.216f,
										1f
									};
								case 266:
									return new float[]
									{
										0.788f,
										0.784f,
										0.761f,
										1f
									};
								case 267:
									return new float[]
									{
										0.38f,
										0.212f,
										0.063f,
										1f
									};
								case 268:
									return new float[]
									{
										0.173f,
										0.188f,
										0.192f,
										1f
									};
								case 269:
									return new float[]
									{
										0.749f,
										0.682f,
										0.553f,
										1f
									};
								case 270:
									return new float[]
									{
										0.49f,
										0.337f,
										0.208f,
										1f
									};
								case 271:
									return new float[]
									{
										0.588f,
										0.467f,
										0.333f,
										1f
									};
								case 272:
									return new float[]
									{
										0.298f,
										0.298f,
										0.298f,
										1f
									};
								case 273:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 274:
									return new float[]
									{
										0.533f,
										0.4f,
										0.173f,
										0f
									};
								case 275:
									return new float[]
									{
										0.651f,
										0.643f,
										0.627f,
										1f
									};
								case 276:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 277:
									return new float[]
									{
										0.882f,
										0.227f,
										0.227f,
										1f
									};
								case 278:
									return new float[]
									{
										0.71f,
										0.761f,
										0.365f,
										1f
									};
								case 279:
									return new float[]
									{
										0.957f,
										0.494f,
										0f,
										1f
									};
								case 280:
									return new float[]
									{
										0.8f,
										0.161f,
										0.169f,
										1f
									};
								case 281:
									return new float[]
									{
										0.824f,
										0.718f,
										0.996f,
										1f
									};
								case 282:
									return new float[]
									{
										0.933f,
										0.718f,
										0.996f,
										1f
									};
								case 283:
									return new float[]
									{
										0.996f,
										0.769f,
										0.949f,
										1f
									};
								case 284:
									return new float[]
									{
										0.996f,
										0.773f,
										0.718f,
										1f
									};
								case 285:
									return new float[]
									{
										0.996f,
										0.827f,
										0.718f,
										1f
									};
								case 286:
									return new float[]
									{
										0.961f,
										0.871f,
										0.753f,
										1f
									};
								case 287:
									return new float[]
									{
										0.996f,
										0.976f,
										0.718f,
										1f
									};
								case 288:
									return new float[]
									{
										0.945f,
										0.984f,
										0.733f,
										1f
									};
								case 289:
									return new float[]
									{
										0.839f,
										0.961f,
										0.757f,
										1f
									};
								case 290:
									return new float[]
									{
										0.718f,
										1f,
										0.925f,
										1f
									};
								case 291:
									return new float[]
									{
										0.718f,
										1f,
										0.992f,
										1f
									};
								case 292:
									return new float[]
									{
										0.718f,
										0.886f,
										1f,
										1f
									};
								case 293:
									return new float[]
									{
										0.075f,
										0.216f,
										0.827f,
										1f
									};
								case 294:
									return new float[]
									{
										0.514f,
										0.514f,
										0.576f,
										1f
									};
								case 295:
									return new float[]
									{
										0.659f,
										0f,
										1f,
										1f
									};
								case 296:
									return new float[]
									{
										0.827f,
										0.91f,
										0.937f,
										0.757f
									};
								case 298:
									return new float[]
									{
										0.094f,
										0.094f,
										0.094f,
										1f
									};
								case 299:
									return new float[]
									{
										0.302f,
										0.518f,
										0.667f,
										1f
									};
								case 300:
									return new float[]
									{
										0.42f,
										0.42f,
										0.42f,
										1f
									};
								case 301:
									return new float[]
									{
										0.329f,
										0.424f,
										0.114f,
										1f
									};
								case 302:
									return new float[]
									{
										0.094f,
										0.486f,
										0.094f,
										1f
									};
								case 303:
									return new float[]
									{
										0.667f,
										0.667f,
										0.667f,
										1f
									};
								case 304:
									return new float[]
									{
										0.318f,
										0.439f,
										0.557f,
										1f
									};
								case 305:
									return new float[]
									{
										0.714f,
										0.38f,
										0.125f,
										0f
									};
								case 306:
									return new float[]
									{
										0.51f,
										0.51f,
										0.51f,
										1f
									};
								case 307:
								{
									float[] array2 = new float[4];
									array2[0] = 0.714f;
									array2[1] = 0.639f;
									return array2;
								}
								case 308:
								{
									float[] array3 = new float[4];
									array3[1] = 0.49f;
									array3[2] = 0.663f;
									return array3;
								}
								case 309:
								{
									float[] array4 = new float[4];
									array4[0] = 0.682f;
									return array4;
								}
								case 310:
								{
									float[] array5 = new float[4];
									array5[0] = 0.694f;
									array5[2] = 0.663f;
									return array5;
								}
								case 311:
								{
									float[] array6 = new float[4];
									array6[1] = 0.651f;
									return array6;
								}
								case 312:
									return new float[]
									{
										0.153f,
										0.153f,
										0.153f,
										1f
									};
								case 313:
									return new float[]
									{
										0.639f,
										0.431f,
										0.22f,
										1f
									};
								case 314:
									return new float[]
									{
										0.761f,
										0.761f,
										0.761f,
										1f
									};
								case 315:
									return new float[]
									{
										0.91f,
										0f,
										0f,
										1f
									};
								case 316:
									return new float[]
									{
										0.749f,
										0.243f,
										0.106f,
										0.325f
									};
								case 317:
									return new float[]
									{
										0.31f,
										0.314f,
										0.314f,
										1f
									};
								case 318:
									return new float[]
									{
										0.169f,
										0.169f,
										0.169f,
										1f
									};
								case 319:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 320:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 321:
									return new float[]
									{
										0.302f,
										0.447f,
										0.627f,
										1f
									};
								case 323:
									return new float[]
									{
										0.855f,
										0.855f,
										0.855f,
										0f
									};
								case 324:
									return new float[]
									{
										0.529f,
										0.078f,
										0.008f,
										1f
									};
								case 325:
									return new float[]
									{
										0.875f,
										0.435f,
										0.804f,
										1f
									};
								case 327:
									return new float[]
									{
										0.357f,
										0.388f,
										0.416f,
										1f
									};
								case 328:
									return new float[]
									{
										0.875f,
										0.875f,
										0.875f,
										1f
									};
								case 329:
									return new float[]
									{
										0.659f,
										0f,
										1f,
										1f
									};
								case 330:
									return new float[]
									{
										0.8f,
										0.788f,
										0.741f,
										1f
									};
								case 331:
									return new float[]
									{
										0.776f,
										0.647f,
										0.482f,
										1f
									};
								case 332:
									return new float[]
									{
										0.384f,
										0.553f,
										1f,
										1f
									};
								case 333:
									return new float[]
									{
										0.863f,
										0.867f,
										0.847f,
										1f
									};
								case 334:
									return new float[]
									{
										0.376f,
										0.235f,
										0.067f,
										1f
									};
								case 335:
									return new float[]
									{
										0.855f,
										0.929f,
										0.984f,
										1f
									};
								case 336:
									return new float[]
									{
										0.949f,
										0.933f,
										0.937f,
										1f
									};
								case 337:
									return new float[]
									{
										0.455f,
										0.533f,
										0.541f,
										1f
									};
								case 338:
									return new float[]
									{
										0.702f,
										0.702f,
										0.702f,
										1f
									};
								case 339:
									return new float[]
									{
										0.804f,
										0.8f,
										0.776f,
										1f
									};
								case 340:
									return new float[]
									{
										0.941f,
										0.941f,
										0.941f,
										1f
									};
								case 341:
									return new float[]
									{
										0.29f,
										0.243f,
										0.2f,
										1f
									};
								case 342:
									return new float[]
									{
										0.525f,
										0.337f,
										0.114f,
										0f
									};
								case 343:
									return new float[]
									{
										0.51f,
										0.345f,
										0.259f,
										1f
									};
								case 344:
									return new float[]
									{
										0.757f,
										0.263f,
										0f,
										1f
									};
								case 410:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 411:
									return new float[]
									{
										0.788f,
										0.494f,
										0.047f,
										1f
									};
								case 412:
									return new float[]
									{
										0.714f,
										0.196f,
										0.125f,
										1f
									};
								case 413:
									return new float[]
									{
										0.965f,
										0.725f,
										0f,
										1f
									};
								case 414:
									return new float[]
									{
										0.965f,
										0.725f,
										0f,
										1f
									};
								case 415:
									return new float[]
									{
										0.663f,
										0.902f,
										1f,
										1f
									};
								case 416:
									return new float[]
									{
										0.282f,
										0.282f,
										0.282f,
										1f
									};
								case 419:
									return new float[]
									{
										0.224f,
										0.341f,
										0.443f,
										1f
									};
								case 420:
									return new float[]
									{
										0f,
										0.867f,
										0f,
										1f
									};
								case 421:
									return new float[]
									{
										0.337f,
										0.659f,
										1f,
										1f
									};
								case 422:
									return new float[]
									{
										0.914f,
										0.663f,
										0f,
										1f
									};
								case 423:
									return new float[]
									{
										0.996f,
										0.675f,
										0.306f,
										1f
									};
								case 425:
									return new float[]
									{
										0.949f,
										0.976f,
										0.988f,
										1f
									};
								case 426:
									return new float[]
									{
										0.565f,
										0.702f,
										0.784f,
										1f
									};
								case 452:
									return new float[]
									{
										0.071f,
										0.071f,
										0.071f,
										1f
									};
								case 453:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 454:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 455:
									return new float[]
									{
										0.141f,
										0.141f,
										0.141f,
										1f
									};
								case 456:
									return new float[]
									{
										0.098f,
										0.098f,
										0.098f,
										1f
									};
								case 457:
									return new float[]
									{
										0.09f,
										0.09f,
										0.09f,
										1f
									};
								case 458:
									return new float[]
									{
										0.996f,
										0.675f,
										0.306f,
										1f
									};
								case 459:
									return new float[]
									{
										0.996f,
										0.675f,
										0.306f,
										1f
									};
								case 460:
									return new float[]
									{
										0.196f,
										0.196f,
										0.196f,
										1f
									};
								case 461:
									return new float[]
									{
										0.294f,
										0.294f,
										0.294f,
										1f
									};
								case 462:
									return new float[]
									{
										0.439f,
										0f,
										0.514f,
										1f
									};
								case 463:
									return new float[]
									{
										0.439f,
										0f,
										0.514f,
										1f
									};
								case 464:
									return new float[]
									{
										0.098f,
										0.098f,
										0.098f,
										1f
									};
								case 465:
									return new float[]
									{
										0.459f,
										0.282f,
										0f,
										1f
									};
								case 466:
									return new float[]
									{
										0.278f,
										0f,
										0.059f,
										1f
									};
								case 467:
									return new float[]
									{
										0.278f,
										0f,
										0.059f,
										1f
									};
								case 468:
									return new float[]
									{
										0.122f,
										0.486f,
										0.553f,
										1f
									};
								case 469:
									return new float[]
									{
										0.004f,
										0.012f,
										0.039f,
										1f
									};
								case 470:
									return new float[]
									{
										0.196f,
										0.196f,
										0.196f,
										1f
									};
								case 471:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 472:
									return new float[]
									{
										0.4f,
										0.4f,
										0.4f,
										1f
									};
								case 473:
									return new float[]
									{
										0.4f,
										0.4f,
										0.4f,
										1f
									};
								case 474:
									return new float[]
									{
										0.4f,
										0.4f,
										0.4f,
										1f
									};
								case 475:
									return new float[]
									{
										0.4f,
										0.4f,
										0.4f,
										1f
									};
								case 476:
									return new float[]
									{
										0.4f,
										0.4f,
										0.4f,
										1f
									};
								case 477:
								{
									float[] array7 = new float[4];
									array7[0] = 0.459f;
									array7[1] = 0.282f;
									return array7;
								}
								case 478:
									return new float[]
									{
										0.545f,
										0.09f,
										0.102f,
										1f
									};
								case 479:
									return new float[]
									{
										0.545f,
										0.09f,
										0.102f,
										1f
									};
								case 480:
									return new float[]
									{
										0.478f,
										0.478f,
										0.478f,
										1f
									};
								case 481:
									return new float[]
									{
										0.867f,
										0.388f,
										0.839f,
										1f
									};
								case 482:
									return new float[]
									{
										0.004f,
										0.043f,
										0.047f,
										1f
									};
								case 483:
									return new float[]
									{
										0.282f,
										0f,
										0.282f,
										1f
									};
								case 484:
									return new float[]
									{
										0.09f,
										0.298f,
										0.545f,
										1f
									};
								case 485:
									return new float[]
									{
										0.09f,
										0.298f,
										0.545f,
										1f
									};
								case 486:
									return new float[]
									{
										0.427f,
										0.09f,
										0.545f,
										1f
									};
								case 487:
									return new float[]
									{
										0.427f,
										0.09f,
										0.545f,
										1f
									};
								case 488:
									return new float[]
									{
										0.565f,
										0.22f,
										0f,
										1f
									};
								case 489:
									return new float[]
									{
										0.565f,
										0.22f,
										0f,
										1f
									};
								case 490:
									return new float[]
									{
										0f,
										0.843f,
										0.871f,
										1f
									};
								case 491:
									return new float[]
									{
										0.835f,
										0.09f,
										0.867f,
										1f
									};
								case 492:
									return new float[]
									{
										0.239f,
										0.239f,
										0.239f,
										0f
									};
								case 493:
									return new float[]
									{
										0.953f,
										0.953f,
										0.953f,
										1f
									};
								case 495:
									return new float[]
									{
										0.929f,
										0.298f,
										0.251f,
										1f
									};
								case 496:
									return new float[]
									{
										0.929f,
										0.529f,
										0.286f,
										1f
									};
								case 497:
									return new float[]
									{
										0.929f,
										0.851f,
										0.471f,
										1f
									};
								case 498:
									return new float[]
									{
										0.902f,
										0.439f,
										0.808f,
										1f
									};
								case 499:
									return new float[]
									{
										0.243f,
										0.667f,
										0.855f,
										1f
									};
								case 500:
									return new float[]
									{
										0.357f,
										0.804f,
										0.384f,
										1f
									};
								case 501:
									return new float[]
									{
										0.725f,
										0.749f,
										0.788f,
										0.427f
									};
								case 502:
									return new float[]
									{
										0.412f,
										0.298f,
										0.094f,
										1f
									};
								case 503:
									return new float[]
									{
										0f,
										0.2f,
										0.4f,
										1f
									};
								case 504:
									return new float[]
									{
										1f,
										0.996f,
										1f,
										1f
									};
								case 505:
									return new float[]
									{
										0f,
										0.329f,
										0.635f,
										1f
									};
								case 506:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 507:
									return new float[]
									{
										0.867f,
										0f,
										0f,
										1f
									};
								case 508:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 509:
									return new float[]
									{
										0.051f,
										0.325f,
										0.604f,
										1f
									};
								case 510:
									return new float[]
									{
										0f,
										0.451f,
										0.808f,
										1f
									};
								case 511:
									return new float[]
									{
										0.698f,
										0.42f,
										0.18f,
										1f
									};
								case 512:
									return new float[]
									{
										0.996f,
										0.796f,
										0f,
										1f
									};
								case 513:
									return new float[]
									{
										0.812f,
										0.078f,
										0.169f,
										1f
									};
								case 514:
									return new float[]
									{
										0.937f,
										0.933f,
										0.925f,
										1f
									};
								case 516:
									return new float[]
									{
										0.188f,
										0.196f,
										0.208f,
										1f
									};
								case 518:
									return new float[]
									{
										0.706f,
										0.49f,
										0.196f,
										1f
									};
								case 519:
									return new float[]
									{
										0.494f,
										0.384f,
										0.094f,
										1f
									};
								case 520:
									return new float[]
									{
										0.263f,
										0.494f,
										0.094f,
										1f
									};
								case 521:
									return new float[]
									{
										0.439f,
										0.725f,
										0.792f,
										1f
									};
								case 522:
									return new float[]
									{
										0.094f,
										0.227f,
										0.494f,
										1f
									};
								case 523:
									return new float[]
									{
										0.478f,
										0.094f,
										0.494f,
										1f
									};
								case 524:
									return new float[]
									{
										0.294f,
										0.294f,
										0.294f,
										1f
									};
								case 529:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 530:
									return new float[]
									{
										0.82f,
										0.918f,
										1f,
										1f
									};
								case 531:
									return new float[]
									{
										0.82f,
										0.918f,
										1f,
										1f
									};
								case 532:
									return new float[]
									{
										0.82f,
										0.918f,
										1f,
										1f
									};
								case 533:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 534:
									return new float[]
									{
										0.996f,
										1f,
										1f,
										1f
									};
								case 535:
									return new float[]
									{
										0.82f,
										0.918f,
										1f,
										1f
									};
								case 536:
									return new float[]
									{
										0.122f,
										0.486f,
										0.553f,
										1f
									};
								case 537:
									return new float[]
									{
										0.141f,
										0.525f,
										0.584f,
										1f
									};
								case 538:
									return new float[]
									{
										0.02f,
										0.196f,
										0.267f,
										1f
									};
								case 539:
									return new float[]
									{
										0.867f,
										0.682f,
										0.388f,
										1f
									};
								case 568:
									return new float[]
									{
										0.984f,
										0.251f,
										0.969f,
										1f
									};
								case 569:
									return new float[]
									{
										0.012f,
										0.831f,
										0.957f,
										1f
									};
								case 570:
									return new float[]
									{
										0.149f,
										0.729f,
										0.478f,
										1f
									};
								case 587:
									return new float[]
									{
										0.376f,
										0.376f,
										0.376f,
										1f
									};
								case 588:
									return new float[]
									{
										0.255f,
										0.255f,
										0.255f,
										1f
									};
								case 589:
									return new float[]
									{
										0.2f,
										0.2f,
										0.2f,
										1f
									};
								case 590:
									return new float[]
									{
										0.329f,
										0.329f,
										0.329f,
										1f
									};
								case 600:
									return new float[]
									{
										0.502f,
										0.333f,
										0f,
										1f
									};
								case 601:
									return new float[]
									{
										0.098f,
										0.227f,
										0.137f,
										1f
									};
								case 602:
									return new float[]
									{
										0.647f,
										0.286f,
										0.063f,
										1f
									};
								case 603:
									return new float[]
									{
										0.114f,
										0.137f,
										0.106f,
										1f
									};
								case 604:
									return new float[]
									{
										0.471f,
										0f,
										0.043f,
										1f
									};
								case 605:
									return new float[]
									{
										0.757f,
										0.843f,
										0.863f,
										1f
									};
								case 611:
									return new float[]
									{
										0.737f,
										0.094f,
										0.086f,
										1f
									};
								case 612:
									return new float[]
									{
										1f,
										0.6f,
										0f,
										1f
									};
								case 613:
									return new float[]
									{
										0.929f,
										0.945f,
										0.553f,
										1f
									};
								case 625:
									return new float[]
									{
										0.937f,
										0.933f,
										0.918f,
										1f
									};
								case 626:
									return new float[]
									{
										0.745f,
										0.455f,
										0.02f,
										1f
									};
								case 627:
								{
									float[] array8 = new float[4];
									array8[0] = 0.714f;
									array8[2] = 0.004f;
									return array8;
								}
								case 628:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 629:
									return new float[]
									{
										0.102f,
										0.553f,
										0.243f,
										0f
									};
								case 630:
								{
									float[] array9 = new float[4];
									array9[0] = 0.824f;
									return array9;
								}
								case 631:
									return new float[]
									{
										0.369f,
										0.247f,
										0.133f,
										1f
									};
								case 632:
									return new float[]
									{
										0.667f,
										0.098f,
										0.149f,
										1f
									};
								case 633:
									return new float[]
									{
										0.824f,
										0.012f,
										0.012f,
										1f
									};
								case 634:
									return new float[]
									{
										0f,
										0.349f,
										0.988f,
										1f
									};
								case 639:
									return new float[4];
								case 640:
									return new float[]
									{
										0.114f,
										0.71f,
										1f,
										0.753f
									};
								case 645:
									return new float[]
									{
										0.765f,
										0.922f,
										0.937f,
										1f
									};
								case 648:
									return new float[]
									{
										0.353f,
										0.212f,
										0.094f,
										0f
									};
								case 649:
									return new float[]
									{
										0.29f,
										0.318f,
										0.353f,
										0f
									};
								case 650:
									return new float[]
									{
										0.396f,
										0.298f,
										0.008f,
										1f
									};
								case 651:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 652:
									return new float[]
									{
										0.718f,
										0.314f,
										0.314f,
										1f
									};
								case 653:
									return new float[]
									{
										0.482f,
										0.557f,
										0.208f,
										1f
									};
								case 654:
									return new float[]
									{
										0.094f,
										0.122f,
										0.118f,
										1f
									};
								case 655:
									return new float[]
									{
										0.11f,
										0.294f,
										0f,
										1f
									};
								case 656:
									return new float[]
									{
										0.855f,
										0.875f,
										0.875f,
										0.471f
									};
								case 668:
									return new float[]
									{
										0.325f,
										0.776f,
										0.318f,
										1f
									};
								case 669:
									return new float[]
									{
										0.804f,
										0.314f,
										0.314f,
										1f
									};
								case 670:
									return new float[]
									{
										0.855f,
										0.588f,
										0.733f,
										1f
									};
								case 671:
									return new float[]
									{
										0.588f,
										0.733f,
										0.847f,
										1f
									};
								case 672:
									return new float[]
									{
										0.318f,
										0.765f,
										0.769f,
										1f
									};
								case 673:
									return new float[]
									{
										0.788f,
										0.78f,
										0.467f,
										1f
									};
								case 674:
									return new float[]
									{
										0.988f,
										0.718f,
										0.729f,
										1f
									};
								case 675:
									return new float[]
									{
										1f,
										0.839f,
										0.839f,
										1f
									};
								case 676:
									return new float[]
									{
										0.529f,
										0.306f,
										0.231f,
										1f
									};
								case 677:
									return new float[]
									{
										0.298f,
										0.161f,
										0.129f,
										1f
									};
								case 678:
									return new float[]
									{
										0.353f,
										0.855f,
										0.729f,
										1f
									};
								case 679:
									return new float[]
									{
										0.282f,
										0.133f,
										0.031f,
										1f
									};
								case 680:
									return new float[]
									{
										0.988f,
										0.98f,
										0.831f,
										1f
									};
								case 681:
									return new float[]
									{
										0.184f,
										0.153f,
										0.169f,
										1f
									};
								case 682:
									return new float[]
									{
										0.922f,
										0.694f,
										0.965f,
										1f
									};
								case 683:
									return new float[]
									{
										0.298f,
										0.161f,
										0.129f,
										1f
									};
								case 705:
									return new float[]
									{
										0.882f,
										0f,
										0.757f,
										1f
									};
								case 706:
									return new float[]
									{
										0.741f,
										0.349f,
										0f,
										1f
									};
								case 707:
									return new float[]
									{
										0.184f,
										0.655f,
										0f,
										1f
									};
								case 708:
									return new float[]
									{
										0.655f,
										0.086f,
										0f,
										1f
									};
								case 709:
									return new float[]
									{
										0.761f,
										0.439f,
										0.808f,
										1f
									};
								case 710:
									return new float[]
									{
										1f,
										0.973f,
										0.973f,
										1f
									};
								case 713:
									return new float[]
									{
										1f,
										0.714f,
										0.98f,
										1f
									};
								case 743:
									return new float[]
									{
										0.624f,
										0.22f,
										0.153f,
										1f
									};
								case 744:
									return new float[]
									{
										0.71f,
										0.761f,
										0.792f,
										1f
									};
								case 745:
									return new float[]
									{
										0.894f,
										0.565f,
										0.153f,
										1f
									};
								case 746:
									return new float[]
									{
										0.439f,
										0.235f,
										0.204f,
										1f
									};
								case 747:
									return new float[]
									{
										0.337f,
										0.337f,
										0.337f,
										1f
									};
								case 748:
									return new float[]
									{
										0.529f,
										0.251f,
										0.145f,
										1f
									};
								case 750:
									return new float[]
									{
										0.471f,
										0.835f,
										0.243f,
										0.659f
									};
								case 751:
									return new float[]
									{
										0.278f,
										0.753f,
										0.278f,
										1f
									};
								case 752:
									return new float[]
									{
										0.663f,
										0.757f,
										0.675f,
										1f
									};
								case 753:
									return new float[]
									{
										0.78f,
										0.529f,
										0.086f,
										1f
									};
								case 754:
									return new float[]
									{
										0f,
										0.388f,
										0.047f,
										1f
									};
								case 755:
									return new float[]
									{
										0.098f,
										0.388f,
										0f,
										1f
									};
								case 756:
									return new float[]
									{
										0.196f,
										0.404f,
										0.035f,
										0f
									};
								case 757:
									return new float[]
									{
										0.686f,
										0.537f,
										0.294f,
										1f
									};
								case 758:
									return new float[]
									{
										1f,
										1f,
										0f,
										1f
									};
								case 759:
									return new float[]
									{
										0.718f,
										0.349f,
										0.231f,
										1f
									};
								case 760:
									return new float[]
									{
										1f,
										0.882f,
										0.404f,
										0f
									};
								case 761:
									return new float[]
									{
										0.78f,
										0.529f,
										0.086f,
										1f
									};
								case 762:
									return new float[]
									{
										0.533f,
										0.533f,
										0.533f,
										1f
									};
								case 763:
									return new float[]
									{
										0.98f,
										0.588f,
										0f,
										1f
									};
								case 783:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 786:
									return new float[]
									{
										0.039f,
										0.518f,
										0.078f,
										1f
									};
								case 787:
									return new float[]
									{
										0.518f,
										0.518f,
										0.518f,
										1f
									};
								case 789:
									return new float[]
									{
										0.392f,
										0.165f,
										0.016f,
										0f
									};
								case 796:
									return new float[]
									{
										0.812f,
										0.824f,
										0.851f,
										1f
									};
								case 801:
									return new float[]
									{
										0.549f,
										0.886f,
										0.875f,
										1f
									};
								case 802:
									return new float[]
									{
										0.584f,
										0.929f,
										0.745f,
										1f
									};
								case 803:
									return new float[]
									{
										0.812f,
										0.796f,
										0.894f,
										1f
									};
								case 804:
									return new float[]
									{
										0.953f,
										0.824f,
										0.824f,
										1f
									};
								case 805:
									return new float[]
									{
										0.953f,
										0.937f,
										0.663f,
										1f
									};
								case 806:
									return new float[]
									{
										0.812f,
										0.796f,
										0.894f,
										1f
									};
								case 807:
									return new float[]
									{
										0.953f,
										0.678f,
										0.886f,
										1f
									};
								case 808:
									return new float[]
									{
										0.863f,
										0.851f,
										0.922f,
										1f
									};
								case 812:
									return new float[]
									{
										0.278f,
										0.702f,
										1f,
										1f
									};
								case 813:
									return new float[]
									{
										0.988f,
										0.824f,
										0.898f,
										1f
									};
								case 815:
									return new float[]
									{
										1f,
										0.851f,
										0.969f,
										1f
									};
								case 816:
									return new float[]
									{
										0.839f,
										0.725f,
										0f,
										1f
									};
								case 817:
									return new float[]
									{
										0.58f,
										0.925f,
										0.812f,
										0f
									};
								case 818:
									return new float[]
									{
										0.58f,
										0.925f,
										0.812f,
										0f
									};
								case 823:
									return new float[]
									{
										0.196f,
										1f,
										0.298f,
										1f
									};
								case 824:
									return new float[]
									{
										1f,
										0.271f,
										0.196f,
										1f
									};
								case 825:
									return new float[]
									{
										0.196f,
										0.655f,
										1f,
										1f
									};
								case 826:
									return new float[]
									{
										0.961f,
										1f,
										0.196f,
										1f
									};
								case 827:
									return new float[]
									{
										1f,
										0.671f,
										0.196f,
										1f
									};
								case 828:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 829:
									return new float[]
									{
										1f,
										0f,
										1f,
										1f
									};
								case 830:
									return new float[]
									{
										0.498f,
										0.498f,
										0.498f,
										1f
									};
								case 831:
									return new float[]
									{
										0f,
										1f,
										1f,
										1f
									};
								case 832:
									return new float[]
									{
										1f,
										0.322f,
										0.145f,
										1f
									};
								case 833:
									return new float[]
									{
										0f,
										0.561f,
										1f,
										1f
									};
								case 834:
									return new float[]
									{
										0f,
										0.886f,
										0f,
										1f
									};
								case 835:
									return new float[]
									{
										0.945f,
										0.322f,
										0.933f,
										1f
									};
								case 836:
									return new float[]
									{
										0.322f,
										0.737f,
										0.945f,
										1f
									};
								case 837:
									return new float[]
									{
										0.4f,
										0.4f,
										0.4f,
										1f
									};
								case 838:
									return new float[]
									{
										0.443f,
										0.051f,
										0.043f,
										1f
									};
								case 839:
									return new float[]
									{
										1f,
										0.616f,
										0.204f,
										1f
									};
								case 840:
									return new float[]
									{
										1f,
										0.973f,
										0.898f,
										1f
									};
								case 841:
									return new float[]
									{
										0.486f,
										1f,
										0.569f,
										1f
									};
								case 842:
									return new float[]
									{
										0.804f,
										0.655f,
										0.976f,
										1f
									};
								case 843:
									return new float[]
									{
										0.655f,
										0.976f,
										0.906f,
										1f
									};
								case 844:
									return new float[]
									{
										0.965f,
										0.969f,
										0.11f,
										1f
									};
								case 845:
									return new float[]
									{
										0.184f,
										0.224f,
										0.675f,
										1f
									};
								case 846:
									return new float[]
									{
										0.925f,
										0f,
										0f,
										1f
									};
								case 847:
									return new float[]
									{
										0.447f,
										0.824f,
										1f,
										1f
									};
								case 953:
									return new float[]
									{
										0.486f,
										0.486f,
										0.486f,
										1f
									};
								case 954:
									return new float[]
									{
										0.729f,
										0.604f,
										0.502f,
										1f
									};
								case 957:
									return new float[]
									{
										0.078f,
										0.169f,
										0f,
										1f
									};
								case 958:
									return new float[]
									{
										0.506f,
										0.584f,
										0.62f,
										1f
									};
								case 959:
									return new float[]
									{
										0.325f,
										0.325f,
										0.325f,
										0f
									};
								case 961:
									return new float[]
									{
										0.698f,
										0.773f,
										0.839f,
										1f
									};
								case 962:
									return new float[]
									{
										0.494f,
										0.188f,
										0f,
										1f
									};
								case 964:
									return new float[]
									{
										1f,
										1f,
										1f,
										0f
									};
								case 965:
									return new float[]
									{
										0.141f,
										0.533f,
										0f,
										1f
									};
								case 966:
									return new float[]
									{
										0.208f,
										0.176f,
										0.035f,
										1f
									};
								case 967:
									return new float[]
									{
										0f,
										0.557f,
										0.91f,
										1f
									};
								case 968:
									return new float[]
									{
										0.322f,
										0.322f,
										0.322f,
										1f
									};
								case 969:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 970:
									return new float[]
									{
										1f,
										0.173f,
										0.173f,
										1f
									};
								case 974:
									return new float[]
									{
										0.769f,
										0.6f,
										0.349f,
										1f
									};
								case 975:
									return new float[]
									{
										0.698f,
										0.192f,
										0.129f,
										0f
									};
								case 976:
									return new float[]
									{
										0.71f,
										0.408f,
										0.114f,
										1f
									};
								case 977:
									return new float[]
									{
										1f,
										0.122f,
										0.122f,
										1f
									};
								case 978:
									return new float[]
									{
										0.145f,
										0.141f,
										0.18f,
										1f
									};
								case 979:
									return new float[]
									{
										0.349f,
										0.086f,
										0.098f,
										1f
									};
								case 980:
									return new float[]
									{
										0.157f,
										0.176f,
										0.153f,
										1f
									};
								case 981:
									return new float[]
									{
										0.322f,
										0.322f,
										0.322f,
										0f
									};
								case 982:
									return new float[]
									{
										0.333f,
										0.204f,
										0.114f,
										0f
									};
								case 983:
									return new float[]
									{
										0.588f,
										0.549f,
										0.4f,
										1f
									};
								case 984:
									return new float[]
									{
										0.667f,
										0.561f,
										0.341f,
										1f
									};
								default:
									switch (A_0)
									{
									case 1039:
										return new float[]
										{
											0.776f,
											0.588f,
											0.306f,
											0f
										};
									case 1040:
										return new float[]
										{
											0.776f,
											0.588f,
											0.306f,
											1f
										};
									case 1041:
										return new float[]
										{
											0.706f,
											0.514f,
											0.255f,
											1f
										};
									case 1042:
										return new float[]
										{
											0.647f,
											0.82f,
											0.941f,
											1f
										};
									case 1043:
										return new float[]
										{
											0.69f,
											0f,
											0.145f,
											1f
										};
									case 1063:
										return new float[]
										{
											0.047f,
											0.62f,
											0.004f,
											1f
										};
									case 1064:
										return new float[]
										{
											0f,
											0.443f,
											0.737f,
											1f
										};
									case 1065:
										return new float[]
										{
											0.749f,
											0.639f,
											0.055f,
											1f
										};
									case 1068:
										return new float[]
										{
											1f,
											0.843f,
											0.047f,
											1f
										};
									case 1070:
										return new float[]
										{
											0.271f,
											0.302f,
											0.337f,
											1f
										};
									case 1072:
										return new float[]
										{
											0.157f,
											0.659f,
											0f,
											1f
										};
									case 1073:
										return new float[]
										{
											1f,
											0f,
											0.69f,
											1f
										};
									case 1074:
										return new float[]
										{
											0f,
											0.729f,
											1f,
											1f
										};
									case 1076:
										return new float[]
										{
											0.706f,
											0.522f,
											0.286f,
											1f
										};
									case 1078:
										return new float[]
										{
											0.898f,
											0.973f,
											0.953f,
											1f
										};
									case 1082:
										return new float[]
										{
											0.475f,
											0.278f,
											0.737f,
											1f
										};
									case 1104:
										return new float[]
										{
											0.922f,
											0.153f,
											0.169f,
											1f
										};
									case 1105:
										return new float[]
										{
											0.153f,
											0.678f,
											0.922f,
											1f
										};
									case 1106:
										return new float[]
										{
											0.906f,
											0.153f,
											0.922f,
											1f
										};
									case 1107:
										return new float[]
										{
											0.153f,
											0.922f,
											0.2f,
											1f
										};
									case 1108:
										return new float[]
										{
											1f,
											0.922f,
											0.075f,
											1f
										};
									case 1109:
										return new float[]
										{
											0.922f,
											0.22f,
											0.247f,
											1f
										};
									case 1110:
										return new float[]
										{
											0.22f,
											0.686f,
											0.922f,
											1f
										};
									case 1111:
										return new float[]
										{
											0.718f,
											0.22f,
											0.922f,
											1f
										};
									case 1112:
										return new float[]
										{
											0.478f,
											0.922f,
											0.22f,
											1f
										};
									case 1113:
										return new float[]
										{
											1f,
											0.769f,
											0.251f,
											1f
										};
									case 1114:
										return new float[]
										{
											0.882f,
											0.314f,
											0.251f,
											1f
										};
									case 1115:
										return new float[]
										{
											0.251f,
											0.486f,
											0.882f,
											1f
										};
									case 1116:
										return new float[]
										{
											0.804f,
											0.251f,
											0.882f,
											1f
										};
									case 1117:
										return new float[]
										{
											0.38f,
											0.882f,
											0.251f,
											1f
										};
									case 1118:
										return new float[]
										{
											1f,
											0.953f,
											0.196f,
											1f
										};
									case 1119:
										return new float[]
										{
											0.776f,
											0.541f,
											0.09f,
											1f
										};
									case 1120:
										return new float[]
										{
											0.776f,
											0.541f,
											0.09f,
											1f
										};
									case 1121:
										return new float[]
										{
											0.776f,
											0.541f,
											0.09f,
											1f
										};
									case 1122:
										return new float[]
										{
											0.776f,
											0.541f,
											0.09f,
											1f
										};
									case 1123:
										return new float[]
										{
											0.776f,
											0.541f,
											0.09f,
											1f
										};
									case 1124:
										return new float[]
										{
											0.161f,
											0.157f,
											0.169f,
											1f
										};
									case 1129:
										return new float[]
										{
											0.675f,
											0.706f,
											0.733f,
											1f
										};
									case 1130:
										return new float[]
										{
											0.714f,
											0.416f,
											0.145f,
											1f
										};
									case 1131:
										return new float[]
										{
											0.337f,
											0.145f,
											0.031f,
											1f
										};
									case 1132:
										return new float[]
										{
											0.227f,
											0.263f,
											0.286f,
											1f
										};
									case 1133:
										return new float[]
										{
											0.706f,
											0.043f,
											0f,
											1f
										};
									case 1134:
										return new float[]
										{
											0.91f,
											0.157f,
											0f,
											1f
										};
									case 1136:
										return new float[]
										{
											0.855f,
											0.745f,
											0.451f,
											1f
										};
									case 1138:
										return new float[]
										{
											0.349f,
											0.298f,
											0.196f,
											1f
										};
									case 1139:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											0f
										};
									case 1140:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											1f
										};
									case 1141:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											1f
										};
									case 1142:
										return new float[]
										{
											0.42f,
											0.353f,
											0.204f,
											1f
										};
									case 1143:
										return new float[]
										{
											0.875f,
											0.816f,
											0.529f,
											1f
										};
									case 1144:
										return new float[]
										{
											0.529f,
											0.451f,
											0.275f,
											1f
										};
									case 1145:
										return new float[]
										{
											0.875f,
											0.816f,
											0.529f,
											1f
										};
									case 1146:
										return new float[]
										{
											0.42f,
											0.353f,
											0.204f,
											0f
										};
									case 1147:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											1f
										};
									case 1148:
										return new float[]
										{
											0.529f,
											0.451f,
											0.275f,
											0f
										};
									case 1149:
										return new float[]
										{
											0.875f,
											0.816f,
											0.529f,
											0f
										};
									case 1150:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											0f
										};
									case 1151:
										return new float[]
										{
											0.875f,
											0.816f,
											0.529f,
											1f
										};
									case 1152:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											1f
										};
									case 1153:
										return new float[]
										{
											0.702f,
											0.604f,
											0.388f,
											0f
										};
									case 1154:
										return new float[]
										{
											0.875f,
											0.816f,
											0.529f,
											0f
										};
									case 1155:
										return new float[]
										{
											0.89f,
											0.659f,
											0.31f,
											1f
										};
									case 1156:
										return new float[]
										{
											0.596f,
											0.596f,
											0.596f,
											1f
										};
									case 1157:
										return new float[]
										{
											0.698f,
											0.698f,
											0.698f,
											1f
										};
									case 1158:
										return new float[]
										{
											0.698f,
											0.698f,
											0.698f,
											1f
										};
									case 1159:
										return new float[]
										{
											0.914f,
											0.957f,
											1f,
											1f
										};
									case 1160:
										return new float[]
										{
											0.914f,
											1f,
											0.914f,
											1f
										};
									case 1161:
										return new float[]
										{
											1f,
											0.914f,
											0.914f,
											1f
										};
									case 1162:
										return new float[]
										{
											1f,
											0.914f,
											0.914f,
											1f
										};
									case 1163:
										return new float[]
										{
											0.129f,
											0.129f,
											0.129f,
											1f
										};
									case 1164:
										return new float[]
										{
											0.573f,
											0.643f,
											0.761f,
											1f
										};
									case 1165:
										return new float[]
										{
											0.141f,
											0.149f,
											0.165f,
											1f
										};
									case 1166:
										return new float[]
										{
											0.106f,
											0.118f,
											0.11f,
											1f
										};
									case 1167:
										return new float[]
										{
											0.184f,
											0.224f,
											0.196f,
											1f
										};
									case 1168:
										return new float[]
										{
											0.212f,
											0.196f,
											0.208f,
											1f
										};
									case 1169:
										return new float[]
										{
											0.353f,
											0.259f,
											0.161f,
											1f
										};
									case 1170:
										return new float[]
										{
											0.38f,
											0.38f,
											0.38f,
											1f
										};
									case 1171:
										return new float[]
										{
											0.114f,
											0.114f,
											0.114f,
											1f
										};
									case 1172:
										return new float[]
										{
											0.22f,
											0.024f,
											0.024f,
											1f
										};
									case 1173:
										return new float[]
										{
											0.31f,
											0.31f,
											0.31f,
											1f
										};
									case 1174:
										return new float[]
										{
											0.243f,
											0.039f,
											0.008f,
											1f
										};
									case 1175:
										return new float[]
										{
											0.157f,
											0.2f,
											0.235f,
											1f
										};
									case 1176:
										return new float[]
										{
											0.11f,
											0.153f,
											0.18f,
											1f
										};
									case 1177:
										return new float[]
										{
											0.145f,
											0.188f,
											0.224f,
											1f
										};
									case 1178:
										return new float[]
										{
											0.2f,
											0.376f,
											0.667f,
											1f
										};
									case 1179:
										return new float[]
										{
											0.314f,
											0.314f,
											0.314f,
											1f
										};
									case 1180:
										return new float[]
										{
											0.055f,
											0.055f,
											0.055f,
											1f
										};
									case 1181:
										return new float[]
										{
											0.584f,
											0.584f,
											0.584f,
											1f
										};
									case 1182:
										return new float[]
										{
											0.796f,
											0.612f,
											0.314f,
											0f
										};
									case 1183:
										return new float[]
										{
											0.251f,
											0.451f,
											0.063f,
											1f
										};
									case 1184:
										return new float[]
										{
											0.463f,
											0.412f,
											0.263f,
											1f
										};
									case 1185:
										return new float[]
										{
											0.118f,
											0.451f,
											0.039f,
											1f
										};
									case 1186:
										return new float[]
										{
											0.957f,
											0.957f,
											0.957f,
											1f
										};
									case 1198:
										return new float[]
										{
											0.282f,
											0.071f,
											0.451f,
											1f
										};
									case 1199:
										return new float[]
										{
											0f,
											1f,
											0f,
											1f
										};
									case 1223:
										return new float[4];
									}
									break;
								}
							}
							else
							{
								if (A_0 == 1234)
								{
									return new float[]
									{
										0.298f,
										0.318f,
										0.322f,
										1f
									};
								}
								if (A_0 == 1236)
								{
									return new float[]
									{
										0.471f,
										0.533f,
										0.051f,
										1f
									};
								}
							}
						}
						else if (A_0 <= 1407)
						{
							switch (A_0)
							{
							case 1241:
								return new float[]
								{
									0.063f,
									0.102f,
									0.153f,
									1f
								};
							case 1242:
							case 1246:
							case 1247:
							case 1249:
							case 1250:
							case 1252:
							case 1253:
							case 1254:
							case 1255:
							case 1256:
							case 1257:
							case 1258:
							case 1259:
							case 1260:
							case 1261:
							case 1262:
							case 1263:
							case 1264:
							case 1265:
							case 1266:
							case 1267:
							case 1268:
							case 1287:
							case 1288:
							case 1289:
							case 1290:
							case 1292:
							case 1293:
							case 1294:
							case 1295:
							case 1296:
							case 1297:
							case 1298:
							case 1299:
							case 1300:
							case 1301:
							case 1302:
							case 1303:
							case 1304:
							case 1305:
							case 1306:
							case 1307:
							case 1308:
							case 1309:
							case 1310:
							case 1311:
							case 1312:
							case 1313:
							case 1314:
							case 1315:
							case 1316:
							case 1317:
							case 1318:
							case 1319:
							case 1320:
							case 1321:
							case 1322:
							case 1323:
							case 1324:
							case 1325:
							case 1326:
							case 1327:
							case 1328:
							case 1329:
							case 1330:
							case 1331:
							case 1332:
							case 1333:
							case 1349:
							case 1350:
							case 1351:
							case 1360:
							case 1361:
							case 1362:
							case 1370:
							case 1371:
							case 1396:
							case 1397:
							case 1399:
								break;
							case 1243:
								return new float[]
								{
									0.208f,
									0.208f,
									0.208f,
									1f
								};
							case 1244:
								return new float[]
								{
									0.376f,
									0.188f,
									0.024f,
									0f
								};
							case 1245:
								return new float[]
								{
									0.396f,
									0.016f,
									0.016f,
									1f
								};
							case 1248:
								return new float[]
								{
									0.498f,
									0.271f,
									0.086f,
									1f
								};
							case 1251:
								return new float[]
								{
									0.675f,
									0.675f,
									0.675f,
									0f
								};
							case 1269:
								return new float[]
								{
									0.404f,
									0.263f,
									0.18f,
									1f
								};
							case 1270:
								return new float[]
								{
									0.216f,
									0.231f,
									0.259f,
									1f
								};
							case 1271:
								return new float[]
								{
									0.208f,
									0.129f,
									0.141f,
									1f
								};
							case 1272:
								return new float[]
								{
									0.149f,
									0.161f,
									0.188f,
									1f
								};
							case 1273:
								return new float[]
								{
									0.173f,
									0.184f,
									0.212f,
									1f
								};
							case 1274:
								return new float[]
								{
									0.51f,
									0.361f,
									0.259f,
									1f
								};
							case 1275:
								return new float[]
								{
									0.443f,
									0.286f,
									0.2f,
									1f
								};
							case 1276:
								return new float[]
								{
									0.286f,
									0.169f,
									0.114f,
									1f
								};
							case 1277:
								return new float[]
								{
									0.443f,
									0.286f,
									0.2f,
									1f
								};
							case 1278:
								return new float[]
								{
									0.153f,
									0.153f,
									0.153f,
									1f
								};
							case 1279:
								return new float[]
								{
									0.216f,
									0.216f,
									0.216f,
									1f
								};
							case 1280:
								return new float[]
								{
									0.216f,
									0.216f,
									0.216f,
									1f
								};
							case 1281:
								return new float[]
								{
									0.216f,
									0.216f,
									0.216f,
									1f
								};
							case 1282:
								return new float[]
								{
									0.494f,
									0.31f,
									0.11f,
									0f
								};
							case 1283:
								return new float[]
								{
									0.459f,
									0.459f,
									0.459f,
									0f
								};
							case 1284:
								return new float[]
								{
									0.133f,
									0.133f,
									0.133f,
									1f
								};
							case 1285:
								return new float[]
								{
									0.576f,
									0.576f,
									0.576f,
									1f
								};
							case 1286:
								return new float[]
								{
									0.286f,
									0.173f,
									0.118f,
									0f
								};
							case 1291:
								return new float[]
								{
									0.004f,
									0.302f,
									0.333f,
									1f
								};
							case 1334:
								return new float[]
								{
									0.196f,
									0.173f,
									0.176f,
									1f
								};
							case 1335:
								return new float[]
								{
									1f,
									0.604f,
									0f,
									1f
								};
							case 1336:
								return new float[]
								{
									0.094f,
									0.122f,
									0.118f,
									1f
								};
							case 1337:
								return new float[]
								{
									0.231f,
									0.231f,
									0.231f,
									1f
								};
							case 1338:
								return new float[]
								{
									0.835f,
									0.596f,
									0.384f,
									1f
								};
							case 1339:
								return new float[]
								{
									0.31f,
									0.22f,
									0.09f,
									1f
								};
							case 1340:
								return new float[]
								{
									0.859f,
									0.945f,
									0.988f,
									0f
								};
							case 1341:
								return new float[]
								{
									0.561f,
									0.447f,
									0.157f,
									1f
								};
							case 1342:
								return new float[]
								{
									1f,
									1f,
									1f,
									0f
								};
							case 1343:
								return new float[]
								{
									0.549f,
									0.02f,
									0.02f,
									0.902f
								};
							case 1344:
								return new float[]
								{
									0.031f,
									0.651f,
									0.024f,
									0.902f
								};
							case 1345:
								return new float[]
								{
									0.216f,
									0.31f,
									0.18f,
									1f
								};
							case 1346:
								return new float[]
								{
									0.29f,
									0.286f,
									0.314f,
									1f
								};
							case 1347:
								return new float[]
								{
									0.38f,
									0.212f,
									0.063f,
									1f
								};
							case 1348:
								return new float[]
								{
									0.804f,
									0.761f,
									0.678f,
									1f
								};
							case 1352:
								return new float[]
								{
									0.867f,
									0.973f,
									1f,
									0.925f
								};
							case 1353:
								return new float[]
								{
									0.184f,
									0.18f,
									0.133f,
									0f
								};
							case 1354:
								return new float[]
								{
									0.851f,
									0.851f,
									0.851f,
									0.573f
								};
							case 1355:
								return new float[]
								{
									0.737f,
									0.729f,
									0.675f,
									1f
								};
							case 1356:
								return new float[]
								{
									0f,
									0f,
									0f,
									1f
								};
							case 1357:
								return new float[]
								{
									0.212f,
									0.129f,
									0.271f,
									1f
								};
							case 1358:
								return new float[]
								{
									0.176f,
									0.294f,
									0.537f,
									1f
								};
							case 1359:
								return new float[]
								{
									0.325f,
									0.345f,
									0.357f,
									1f
								};
							case 1363:
								return new float[]
								{
									0.333f,
									0.325f,
									0.365f,
									1f
								};
							case 1364:
								return new float[]
								{
									0.259f,
									0.259f,
									0.267f,
									1f
								};
							case 1365:
								return new float[]
								{
									0.424f,
									0.424f,
									0.424f,
									1f
								};
							case 1366:
								return new float[]
								{
									0.337f,
									0.643f,
									0.016f,
									1f
								};
							case 1367:
								return new float[]
								{
									0.373f,
									0.675f,
									0.039f,
									1f
								};
							case 1368:
								return new float[]
								{
									0.706f,
									0.973f,
									0.596f,
									1f
								};
							case 1369:
								return new float[]
								{
									0.196f,
									0.412f,
									0f,
									1f
								};
							case 1372:
								return new float[]
								{
									0.612f,
									0.216f,
									0.004f,
									1f
								};
							case 1373:
								return new float[]
								{
									0.455f,
									0.29f,
									0.208f,
									1f
								};
							case 1374:
								return new float[]
								{
									0.075f,
									0.016f,
									0.016f,
									1f
								};
							case 1375:
								return new float[]
								{
									0.333f,
									0.294f,
									0.294f,
									1f
								};
							case 1376:
								return new float[]
								{
									0.094f,
									0.039f,
									0.055f,
									1f
								};
							case 1377:
								return new float[]
								{
									1f,
									0.663f,
									0.035f,
									1f
								};
							case 1378:
								return new float[]
								{
									0.333f,
									0.525f,
									0.506f,
									0f
								};
							case 1379:
								return new float[]
								{
									0.325f,
									0.216f,
									0.153f,
									0f
								};
							case 1380:
								return new float[]
								{
									0.204f,
									0.118f,
									0.129f,
									1f
								};
							case 1381:
								return new float[]
								{
									0.173f,
									0.094f,
									0.102f,
									1f
								};
							case 1382:
								return new float[]
								{
									0.855f,
									0f,
									0.91f,
									1f
								};
							case 1383:
								return new float[]
								{
									0.18f,
									0.157f,
									0.157f,
									1f
								};
							case 1384:
								return new float[]
								{
									0.282f,
									0.153f,
									0.09f,
									0f
								};
							case 1385:
								return new float[]
								{
									0.392f,
									0.145f,
									0.106f,
									1f
								};
							case 1386:
								return new float[]
								{
									0.392f,
									0.145f,
									0.106f,
									1f
								};
							case 1387:
								return new float[]
								{
									0.514f,
									0.188f,
									0.165f,
									1f
								};
							case 1388:
								return new float[]
								{
									0.259f,
									0.035f,
									0.035f,
									0f
								};
							case 1389:
								return new float[]
								{
									0.22f,
									0.129f,
									0.067f,
									1f
								};
							case 1390:
								return new float[]
								{
									0.153f,
									0.122f,
									0.122f,
									1f
								};
							case 1391:
								return new float[]
								{
									0.153f,
									0.122f,
									0.122f,
									1f
								};
							case 1392:
								return new float[]
								{
									0.208f,
									0.176f,
									0.035f,
									1f
								};
							case 1393:
								return new float[]
								{
									0.031f,
									0.671f,
									0f,
									1f
								};
							case 1394:
								return new float[]
								{
									0.494f,
									0.098f,
									0.094f,
									1f
								};
							case 1395:
								return new float[]
								{
									0.094f,
									0.094f,
									0.094f,
									1f
								};
							case 1398:
								return new float[]
								{
									0.827f,
									0.612f,
									0.004f,
									1f
								};
							case 1400:
								return new float[]
								{
									0.745f,
									0.745f,
									0.745f,
									1f
								};
							default:
								if (A_0 == 1407)
								{
									return new float[]
									{
										0.945f,
										0.714f,
										0.098f,
										1f
									};
								}
								break;
							}
						}
						else
						{
							if (A_0 == 1411)
							{
								return new float[]
								{
									0.635f,
									0.612f,
									0.596f,
									1f
								};
							}
							switch (A_0)
							{
							case 1419:
								return new float[]
								{
									0.204f,
									0.204f,
									0.204f,
									1f
								};
							case 1420:
								return new float[]
								{
									0.925f,
									0.459f,
									0f,
									1f
								};
							case 1421:
							{
								float[] array10 = new float[4];
								array10[0] = 0.616f;
								array10[2] = 0.878f;
								return array10;
							}
							case 1424:
								return new float[]
								{
									0f,
									0.518f,
									0.961f,
									1f
								};
							}
						}
					}
					else if (A_0 <= 2136)
					{
						if (A_0 <= 1688)
						{
							switch (A_0)
							{
							case 1439:
								return new float[]
								{
									0.2f,
									0.58f,
									0.667f,
									1f
								};
							case 1440:
							case 1441:
							case 1442:
							case 1443:
							case 1444:
							case 1445:
							case 1446:
							case 1447:
							case 1449:
							case 1450:
							case 1455:
							case 1456:
							case 1457:
							case 1458:
							case 1459:
							case 1460:
							case 1461:
							case 1462:
							case 1463:
							case 1464:
							case 1465:
							case 1466:
							case 1467:
							case 1482:
							case 1494:
							case 1495:
							case 1496:
							case 1497:
							case 1498:
							case 1499:
							case 1501:
							case 1502:
							case 1505:
							case 1507:
							case 1508:
							case 1509:
							case 1520:
							case 1521:
							case 1522:
							case 1523:
							case 1524:
							case 1525:
							case 1526:
							case 1527:
							case 1528:
							case 1529:
							case 1530:
							case 1531:
							case 1532:
							case 1533:
							case 1534:
								break;
							case 1448:
								return new float[]
								{
									0.094f,
									0.396f,
									0.047f,
									1f
								};
							case 1451:
								return new float[]
								{
									0.745f,
									0.455f,
									0.02f,
									1f
								};
							case 1452:
								return new float[]
								{
									0.506f,
									0.302f,
									0f,
									1f
								};
							case 1453:
								return new float[]
								{
									0.796f,
									0.612f,
									0.314f,
									0f
								};
							case 1454:
								return new float[]
								{
									0.682f,
									0.827f,
									0.898f,
									1f
								};
							case 1468:
								return new float[]
								{
									0.067f,
									0.039f,
									0.024f,
									1f
								};
							case 1469:
								return new float[]
								{
									0.337f,
									0.294f,
									0.259f,
									1f
								};
							case 1470:
								return new float[]
								{
									0.004f,
									0f,
									0f,
									1f
								};
							case 1471:
								return new float[]
								{
									0.122f,
									0.075f,
									0.047f,
									1f
								};
							case 1472:
								return new float[]
								{
									0.067f,
									0.039f,
									0.024f,
									1f
								};
							case 1473:
								return new float[]
								{
									0.718f,
									0.702f,
									0.612f,
									1f
								};
							case 1474:
								return new float[]
								{
									0.192f,
									0.118f,
									0.075f,
									1f
								};
							case 1475:
								return new float[]
								{
									0.122f,
									0.075f,
									0.047f,
									1f
								};
							case 1476:
								return new float[]
								{
									0.467f,
									0.467f,
									0.467f,
									1f
								};
							case 1477:
								return new float[]
								{
									0.176f,
									0.102f,
									0.063f,
									1f
								};
							case 1478:
								return new float[]
								{
									0.157f,
									0.086f,
									0.055f,
									1f
								};
							case 1479:
								return new float[]
								{
									0.122f,
									0.075f,
									0.047f,
									1f
								};
							case 1480:
								return new float[]
								{
									1f,
									0.647f,
									0.918f,
									1f
								};
							case 1481:
								return new float[]
								{
									0.659f,
									0f,
									1f,
									1f
								};
							case 1483:
								return new float[]
								{
									0.082f,
									0.051f,
									0.051f,
									1f
								};
							case 1484:
								return new float[]
								{
									0.133f,
									0.098f,
									0.098f,
									1f
								};
							case 1485:
								return new float[]
								{
									0.153f,
									0.122f,
									0.122f,
									1f
								};
							case 1486:
								return new float[]
								{
									0.082f,
									0.051f,
									0.051f,
									1f
								};
							case 1487:
								return new float[]
								{
									0.169f,
									0.133f,
									0.133f,
									1f
								};
							case 1488:
								return new float[]
								{
									0.463f,
									0.129f,
									0.004f,
									1f
								};
							case 1489:
								return new float[]
								{
									0.31f,
									0.275f,
									0.275f,
									1f
								};
							case 1490:
								return new float[]
								{
									0.353f,
									0.314f,
									0.314f,
									1f
								};
							case 1491:
								return new float[]
								{
									0.333f,
									0.294f,
									0.294f,
									1f
								};
							case 1492:
								return new float[]
								{
									0.275f,
									0.208f,
									0.157f,
									1f
								};
							case 1493:
								return new float[]
								{
									0.153f,
									0.122f,
									0.122f,
									1f
								};
							case 1500:
								return new float[]
								{
									0.933f,
									0.655f,
									0.976f,
									1f
								};
							case 1503:
								return new float[]
								{
									0.541f,
									0.137f,
									0.784f,
									0.976f
								};
							case 1504:
								return new float[]
								{
									0.235f,
									0.235f,
									0.235f,
									1f
								};
							case 1506:
								return new float[]
								{
									0.263f,
									0.235f,
									0.235f,
									1f
								};
							case 1510:
								return new float[]
								{
									0.027f,
									0.125f,
									0.047f,
									1f
								};
							case 1511:
								return new float[]
								{
									0.024f,
									0.18f,
									0.031f,
									1f
								};
							case 1512:
								return new float[]
								{
									0.024f,
									0.18f,
									0.031f,
									1f
								};
							case 1513:
								return new float[]
								{
									0.047f,
									0.306f,
									0.047f,
									1f
								};
							case 1514:
							{
								float[] array11 = new float[4];
								array11[0] = 0.086f;
								array11[1] = 0.196f;
								return array11;
							}
							case 1515:
								return new float[]
								{
									0.506f,
									0.506f,
									0.424f,
									1f
								};
							case 1516:
								return new float[]
								{
									0.31f,
									0.31f,
									0.275f,
									1f
								};
							case 1517:
								return new float[]
								{
									0.341f,
									0.165f,
									0.012f,
									1f
								};
							case 1518:
								return new float[]
								{
									0.145f,
									0.325f,
									0.027f,
									1f
								};
							case 1519:
								return new float[]
								{
									0.529f,
									0.239f,
									0.067f,
									1f
								};
							case 1535:
								return new float[4];
							case 1536:
								return new float[]
								{
									0.063f,
									0.09f,
									0.118f,
									1f
								};
							case 1537:
								return new float[]
								{
									0.125f,
									0.165f,
									0.208f,
									1f
								};
							case 1538:
								return new float[]
								{
									0.808f,
									0.808f,
									0.808f,
									1f
								};
							case 1539:
								return new float[]
								{
									0.055f,
									0.055f,
									0.055f,
									1f
								};
							case 1540:
								return new float[]
								{
									0.161f,
									0.161f,
									0.161f,
									1f
								};
							case 1541:
								return new float[]
								{
									1f,
									0.635f,
									0f,
									1f
								};
							case 1542:
								return new float[]
								{
									0.686f,
									0.686f,
									0.686f,
									1f
								};
							case 1543:
								return new float[]
								{
									0.659f,
									0.835f,
									1f,
									1f
								};
							case 1544:
								return new float[]
								{
									0.22f,
									0.22f,
									0.22f,
									1f
								};
							default:
								switch (A_0)
								{
								case 1566:
									return new float[]
									{
										0.129f,
										0.58f,
										0.792f,
										1f
									};
								case 1593:
									return new float[]
									{
										0.537f,
										0.314f,
										0.075f,
										1f
									};
								case 1594:
									return new float[]
									{
										0.106f,
										0.38f,
										0.094f,
										0f
									};
								case 1595:
									return new float[]
									{
										0.973f,
										0.463f,
										0f,
										1f
									};
								case 1597:
									return new float[]
									{
										0.682f,
										0.902f,
										1f,
										1f
									};
								case 1599:
									return new float[]
									{
										0.776f,
										0f,
										0f,
										0.078f
									};
								case 1600:
									return new float[]
									{
										0.365f,
										0.937f,
										0.984f,
										1f
									};
								case 1604:
									return new float[]
									{
										1f,
										1f,
										1f,
										0.459f
									};
								case 1605:
									return new float[]
									{
										0.596f,
										0.718f,
										0.914f,
										1f
									};
								case 1610:
									return new float[]
									{
										0.463f,
										0.788f,
										0.824f,
										0f
									};
								case 1611:
									return new float[]
									{
										0.165f,
										0.588f,
										0f,
										1f
									};
								case 1612:
									return new float[]
									{
										1f,
										0.314f,
										0.396f,
										1f
									};
								case 1613:
									return new float[]
									{
										0.494f,
										0.471f,
										0.455f,
										1f
									};
								case 1615:
									return new float[]
									{
										0.098f,
										0.373f,
										0.098f,
										0f
									};
								case 1619:
									return new float[]
									{
										0.173f,
										0.584f,
										0.153f,
										1f
									};
								case 1630:
									return new float[]
									{
										0f,
										0f,
										0f,
										0.439f
									};
								case 1633:
									return new float[]
									{
										0.294f,
										0.235f,
										0.176f,
										1f
									};
								case 1634:
									return new float[]
									{
										0.192f,
										0.294f,
										0.176f,
										1f
									};
								case 1635:
									return new float[]
									{
										0.176f,
										0.235f,
										0.294f,
										1f
									};
								case 1636:
									return new float[]
									{
										0.278f,
										0.176f,
										0.294f,
										1f
									};
								case 1637:
									return new float[]
									{
										0.133f,
										0.161f,
										0.204f,
										1f
									};
								case 1638:
									return new float[]
									{
										0.169f,
										0.169f,
										0.169f,
										1f
									};
								case 1639:
									return new float[]
									{
										0.204f,
										0.169f,
										0.133f,
										1f
									};
								case 1640:
									return new float[]
									{
										0.259f,
										0.075f,
										0.114f,
										1f
									};
								case 1641:
									return new float[]
									{
										0.161f,
										0.204f,
										0.133f,
										1f
									};
								case 1642:
									return new float[]
									{
										0.259f,
										0.247f,
										0.239f,
										1f
									};
								case 1643:
									return new float[]
									{
										0.129f,
										0.169f,
										0.184f,
										1f
									};
								case 1645:
									return new float[]
									{
										0.255f,
										0.122f,
										0f,
										1f
									};
								case 1646:
									return new float[]
									{
										0.122f,
										0.102f,
										0.09f,
										1f
									};
								case 1647:
									return new float[]
									{
										0.184f,
										0.157f,
										0.137f,
										1f
									};
								case 1648:
									return new float[]
									{
										0.122f,
										0.102f,
										0.09f,
										1f
									};
								case 1649:
									return new float[]
									{
										0.314f,
										0.314f,
										0.314f,
										1f
									};
								case 1650:
									return new float[]
									{
										0f,
										0.106f,
										0.176f,
										1f
									};
								case 1651:
									return new float[]
									{
										0.165f,
										0.012f,
										0.012f,
										1f
									};
								case 1652:
									return new float[]
									{
										0.082f,
										0.082f,
										0.082f,
										1f
									};
								case 1653:
									return new float[]
									{
										0.012f,
										0.165f,
										0.051f,
										1f
									};
								case 1654:
									return new float[]
									{
										0.651f,
										0.651f,
										0.651f,
										1f
									};
								case 1655:
									return new float[]
									{
										0.18f,
										0.027f,
										0.027f,
										0f
									};
								case 1656:
									return new float[]
									{
										0.231f,
										0.031f,
										0.031f,
										0f
									};
								case 1657:
									return new float[]
									{
										0.18f,
										0.027f,
										0.027f,
										0f
									};
								case 1658:
									return new float[]
									{
										1f,
										0.722f,
										0.376f,
										1f
									};
								case 1659:
									return new float[]
									{
										0.945f,
										0.459f,
										0.149f,
										0f
									};
								case 1660:
									return new float[]
									{
										0.224f,
										0.149f,
										0.086f,
										1f
									};
								case 1661:
									return new float[]
									{
										0.788f,
										0.737f,
										0.671f,
										1f
									};
								case 1662:
									return new float[]
									{
										0.431f,
										0.353f,
										0.22f,
										1f
									};
								case 1663:
									return new float[]
									{
										0.694f,
										0.588f,
										0.518f,
										1f
									};
								case 1664:
									return new float[]
									{
										0.514f,
										0.431f,
										0.337f,
										1f
									};
								case 1665:
									return new float[]
									{
										0.753f,
										0.667f,
										0.557f,
										0f
									};
								case 1666:
									return new float[]
									{
										0.275f,
										0.275f,
										0.275f,
										1f
									};
								case 1667:
									return new float[]
									{
										0.933f,
										0.933f,
										0.933f,
										1f
									};
								case 1668:
									return new float[]
									{
										0.216f,
										0.133f,
										0.082f,
										1f
									};
								case 1669:
									return new float[]
									{
										0.631f,
										0.404f,
										0.216f,
										1f
									};
								case 1670:
									return new float[]
									{
										0.325f,
										0.447f,
										0.478f,
										1f
									};
								case 1671:
									return new float[]
									{
										0.098f,
										0.098f,
										0.098f,
										1f
									};
								case 1672:
									return new float[]
									{
										0.522f,
										0.6f,
										0.733f,
										1f
									};
								case 1673:
									return new float[]
									{
										0.839f,
										0.016f,
										0.012f,
										1f
									};
								case 1674:
									return new float[]
									{
										0.416f,
										0.365f,
										0.282f,
										1f
									};
								case 1675:
									return new float[]
									{
										0.384f,
										0.341f,
										0.263f,
										1f
									};
								case 1676:
									return new float[]
									{
										0.384f,
										0.341f,
										0.263f,
										1f
									};
								case 1677:
									return new float[]
									{
										0.384f,
										0.341f,
										0.263f,
										1f
									};
								case 1678:
									return new float[]
									{
										0.384f,
										0.341f,
										0.263f,
										1f
									};
								case 1679:
									return new float[]
									{
										0.384f,
										0.341f,
										0.263f,
										1f
									};
								case 1681:
									return new float[]
									{
										0.875f,
										0.816f,
										0.529f,
										1f
									};
								case 1682:
									return new float[]
									{
										0.875f,
										0.816f,
										0.529f,
										1f
									};
								case 1683:
									return new float[]
									{
										0.702f,
										0.604f,
										0.388f,
										1f
									};
								case 1684:
									return new float[]
									{
										0.796f,
										0.694f,
										0.471f,
										0f
									};
								case 1685:
									return new float[]
									{
										0.576f,
										0.482f,
										0.184f,
										1f
									};
								case 1686:
									return new float[]
									{
										1f,
										0.737f,
										0f,
										1f
									};
								case 1687:
									return new float[]
									{
										0.686f,
										0.471f,
										0f,
										1f
									};
								case 1688:
									return new float[]
									{
										1f,
										0.761f,
										0f,
										1f
									};
								}
								break;
							}
						}
						else
						{
							switch (A_0)
							{
							case 1758:
								return new float[]
								{
									0.937f,
									0.663f,
									0.757f,
									1f
								};
							case 1759:
								return new float[]
								{
									0.11f,
									0.122f,
									0.11f,
									0f
								};
							case 1760:
							case 1761:
							case 1762:
							case 1763:
							case 1764:
							case 1765:
							case 1768:
							case 1769:
							case 1770:
							case 1771:
							case 1772:
							case 1773:
							case 1774:
							case 1775:
							case 1776:
							case 1777:
							case 1778:
							case 1779:
							case 1780:
							case 1781:
							case 1786:
							case 1787:
							case 1788:
							case 1789:
							case 1790:
							case 1791:
							case 1792:
							case 1793:
							case 1794:
							case 1795:
							case 1796:
							case 1797:
							case 1798:
							case 1799:
							case 1801:
							case 1802:
							case 1803:
							case 1804:
							case 1805:
							case 1806:
							case 1808:
							case 1809:
							case 1817:
							case 1818:
							case 1819:
							case 1820:
							case 1821:
							case 1822:
							case 1823:
							case 1825:
							case 1827:
							case 1828:
							case 1831:
							case 1832:
							case 1833:
							case 1834:
							case 1835:
							case 1836:
							case 1837:
							case 1838:
							case 1839:
							case 1840:
							case 1841:
							case 1845:
							case 1846:
							case 1847:
							case 1848:
							case 1849:
							case 1850:
							case 1857:
							case 1858:
							case 1859:
							case 1860:
							case 1861:
							case 1862:
							case 1863:
							case 1864:
							case 1865:
							case 1866:
							case 1867:
							case 1868:
							case 1869:
							case 1870:
							case 1871:
							case 1872:
							case 1873:
							case 1874:
							case 1875:
							case 1876:
							case 1877:
							case 1878:
							case 1879:
							case 1880:
							case 1886:
							case 1887:
							case 1888:
							case 1889:
							case 1890:
							case 1891:
							case 1901:
							case 1902:
							case 1903:
							case 1904:
							case 1911:
							case 1912:
							case 1913:
							case 1922:
							case 1924:
							case 1925:
							case 1926:
							case 1927:
							case 1931:
							case 1932:
							case 1933:
							case 1934:
							case 1935:
							case 1936:
							case 1937:
							case 1938:
							case 1940:
							case 1954:
							case 1989:
							case 1990:
							case 1991:
							case 1992:
							case 1993:
							case 1994:
							case 1995:
							case 1996:
							case 1997:
							case 1998:
							case 1999:
							case 2000:
							case 2002:
							case 2004:
							case 2007:
							case 2019:
							case 2029:
							case 2031:
							case 2032:
							case 2033:
							case 2034:
							case 2035:
							case 2038:
							case 2040:
							case 2041:
							case 2042:
							case 2044:
							case 2045:
							case 2055:
							case 2056:
							case 2057:
							case 2058:
							case 2059:
							case 2060:
							case 2061:
							case 2062:
							case 2067:
							case 2068:
							case 2078:
							case 2079:
							case 2082:
							case 2083:
							case 2084:
							case 2085:
							case 2086:
							case 2088:
							case 2089:
							case 2090:
							case 2091:
							case 2092:
							case 2093:
							case 2094:
							case 2095:
							case 2096:
							case 2106:
							case 2107:
							case 2108:
							case 2109:
							case 2111:
							case 2112:
							case 2118:
								break;
							case 1766:
								return new float[]
								{
									0.282f,
									0.082f,
									0.024f,
									1f
								};
							case 1767:
								return new float[]
								{
									0.094f,
									0.471f,
									0.094f,
									1f
								};
							case 1782:
								return new float[]
								{
									1f,
									0.651f,
									0.784f,
									1f
								};
							case 1783:
								return new float[]
								{
									0.318f,
									0.459f,
									0.047f,
									0f
								};
							case 1784:
								return new float[]
								{
									0.682f,
									0.031f,
									0.031f,
									1f
								};
							case 1785:
								return new float[]
								{
									0.957f,
									0.949f,
									0.945f,
									1f
								};
							case 1800:
								return new float[]
								{
									0.384f,
									0.302f,
									0.255f,
									1f
								};
							case 1807:
								return new float[]
								{
									0.576f,
									0.133f,
									0.627f,
									1f
								};
							case 1810:
								return new float[]
								{
									0.118f,
									0.094f,
									0f,
									1f
								};
							case 1811:
								return new float[]
								{
									0.141f,
									0.137f,
									0.149f,
									1f
								};
							case 1812:
								return new float[]
								{
									0.122f,
									0.122f,
									0.125f,
									0f
								};
							case 1813:
								return new float[]
								{
									0.749f,
									0.749f,
									0.749f,
									0f
								};
							case 1814:
								return new float[]
								{
									0f,
									0f,
									0f,
									1f
								};
							case 1815:
								return new float[]
								{
									0.176f,
									0.275f,
									0.333f,
									0f
								};
							case 1816:
								return new float[]
								{
									0.078f,
									0.078f,
									0.078f,
									0f
								};
							case 1824:
								return new float[]
								{
									0.176f,
									0.173f,
									0.188f,
									1f
								};
							case 1826:
								return new float[]
								{
									0.173f,
									0.404f,
									0.643f,
									1f
								};
							case 1829:
								return new float[]
								{
									0.714f,
									0.714f,
									0.714f,
									1f
								};
							case 1830:
								return new float[]
								{
									0.714f,
									0.714f,
									0.714f,
									1f
								};
							case 1842:
								return new float[]
								{
									0.612f,
									0.58f,
									0.541f,
									1f
								};
							case 1843:
								return new float[]
								{
									0.788f,
									0.694f,
									0.561f,
									1f
								};
							case 1844:
								return new float[]
								{
									0.788f,
									0.694f,
									0.561f,
									1f
								};
							case 1851:
								return new float[]
								{
									0.235f,
									0.22f,
									0.184f,
									1f
								};
							case 1852:
								return new float[]
								{
									0.506f,
									0.486f,
									0.443f,
									1f
								};
							case 1853:
								return new float[]
								{
									0.459f,
									0.51f,
									0.529f,
									1f
								};
							case 1854:
								return new float[]
								{
									0.682f,
									0.31f,
									0.322f,
									1f
								};
							case 1855:
								return new float[]
								{
									0.651f,
									0.612f,
									0.576f,
									1f
								};
							case 1856:
								return new float[]
								{
									0.247f,
									0.263f,
									0.216f,
									1f
								};
							case 1881:
								return new float[]
								{
									0.192f,
									0.149f,
									0.114f,
									1f
								};
							case 1882:
								return new float[]
								{
									0f,
									0.588f,
									0.91f,
									1f
								};
							case 1883:
								return new float[]
								{
									0.357f,
									0.275f,
									0.275f,
									1f
								};
							case 1884:
								return new float[]
								{
									0.357f,
									0.275f,
									0.275f,
									1f
								};
							case 1885:
								return new float[]
								{
									0.325f,
									0.243f,
									0.224f,
									1f
								};
							case 1892:
								return new float[]
								{
									0.761f,
									0.761f,
									0.761f,
									1f
								};
							case 1893:
							{
								float[] array12 = new float[4];
								array12[0] = 0.106f;
								array12[1] = 0.761f;
								return array12;
							}
							case 1894:
								return new float[]
								{
									0.216f,
									0.2f,
									0.216f,
									1f
								};
							case 1895:
								return new float[]
								{
									0.306f,
									0.306f,
									0.306f,
									1f
								};
							case 1896:
								return new float[]
								{
									0.384f,
									0.341f,
									0.263f,
									1f
								};
							case 1897:
								return new float[]
								{
									0.439f,
									0.325f,
									0.231f,
									1f
								};
							case 1898:
								return new float[]
								{
									0.357f,
									0.757f,
									0.294f,
									1f
								};
							case 1899:
								return new float[]
								{
									0.631f,
									0.514f,
									0.514f,
									1f
								};
							case 1900:
								return new float[]
								{
									0.549f,
									0.424f,
									0.424f,
									1f
								};
							case 1905:
								return new float[]
								{
									0.369f,
									0.325f,
									0.263f,
									1f
								};
							case 1906:
								return new float[]
								{
									0.133f,
									0.141f,
									0.141f,
									1f
								};
							case 1907:
								return new float[]
								{
									0.392f,
									0.322f,
									0.278f,
									1f
								};
							case 1908:
								return new float[]
								{
									0f,
									0f,
									0f,
									1f
								};
							case 1909:
								return new float[]
								{
									0f,
									0f,
									0f,
									1f
								};
							case 1910:
								return new float[]
								{
									0.969f,
									0.569f,
									0.09f,
									1f
								};
							case 1914:
								return new float[]
								{
									0.82f,
									0.333f,
									0.098f,
									0f
								};
							case 1915:
								return new float[]
								{
									0.404f,
									0.459f,
									0.49f,
									0f
								};
							case 1916:
								return new float[]
								{
									0.059f,
									0.122f,
									0.247f,
									1f
								};
							case 1917:
								return new float[]
								{
									0.486f,
									0.486f,
									0.486f,
									0f
								};
							case 1918:
								return new float[]
								{
									0.239f,
									0.239f,
									0.239f,
									1f
								};
							case 1919:
								return new float[]
								{
									0.914f,
									0.933f,
									0.945f,
									1f
								};
							case 1920:
								return new float[]
								{
									0.753f,
									0.745f,
									0.725f,
									1f
								};
							case 1921:
								return new float[]
								{
									0.353f,
									0.584f,
									0.745f,
									1f
								};
							case 1923:
								return new float[]
								{
									1f,
									0.62f,
									0.306f,
									1f
								};
							case 1928:
								return new float[]
								{
									0.22f,
									0.698f,
									0f,
									1f
								};
							case 1929:
								return new float[]
								{
									0.106f,
									0.102f,
									0.118f,
									0f
								};
							case 1930:
								return new float[]
								{
									0.075f,
									0.075f,
									0.075f,
									0f
								};
							case 1939:
								return new float[]
								{
									0.341f,
									0.196f,
									0.012f,
									1f
								};
							case 1941:
								return new float[]
								{
									0.086f,
									0.169f,
									0.173f,
									1f
								};
							case 1942:
								return new float[]
								{
									0.086f,
									0.169f,
									0.173f,
									1f
								};
							case 1943:
								return new float[]
								{
									0.086f,
									0.169f,
									0.173f,
									1f
								};
							case 1944:
								return new float[]
								{
									0.086f,
									0.169f,
									0.173f,
									1f
								};
							case 1945:
								return new float[]
								{
									0.086f,
									0.169f,
									0.173f,
									1f
								};
							case 1946:
								return new float[]
								{
									0.137f,
									0.251f,
									0.282f,
									1f
								};
							case 1947:
								return new float[]
								{
									0.086f,
									0.169f,
									0.173f,
									1f
								};
							case 1948:
								return new float[]
								{
									0.137f,
									0.251f,
									0.282f,
									1f
								};
							case 1949:
								return new float[]
								{
									0.231f,
									0.267f,
									0.345f,
									0f
								};
							case 1950:
								return new float[]
								{
									0.188f,
									0.243f,
									0.345f,
									1f
								};
							case 1951:
								return new float[]
								{
									0.196f,
									0.251f,
									0.357f,
									1f
								};
							case 1952:
								return new float[]
								{
									0.18f,
									0.373f,
									0.314f,
									1f
								};
							case 1953:
								return new float[]
								{
									0.18f,
									0.373f,
									0.314f,
									1f
								};
							case 1955:
								return new float[]
								{
									0.451f,
									0.522f,
									0.675f,
									1f
								};
							case 1956:
								return new float[]
								{
									0.451f,
									0.522f,
									0.675f,
									1f
								};
							case 1957:
								return new float[]
								{
									0f,
									0.059f,
									0.169f,
									1f
								};
							case 1958:
								return new float[]
								{
									0.078f,
									0.078f,
									0.078f,
									1f
								};
							case 1959:
								return new float[]
								{
									0.157f,
									0.055f,
									0.039f,
									1f
								};
							case 1960:
								return new float[]
								{
									0.561f,
									0.6f,
									0.714f,
									1f
								};
							case 1961:
								return new float[]
								{
									0.514f,
									0.553f,
									0.655f,
									0f
								};
							case 1962:
								return new float[]
								{
									0.612f,
									0.655f,
									0.776f,
									0f
								};
							case 1963:
								return new float[]
								{
									0.114f,
									0.753f,
									0.2f,
									1f
								};
							case 1964:
								return new float[]
								{
									0.114f,
									0.753f,
									0.2f,
									1f
								};
							case 1965:
								return new float[]
								{
									0.133f,
									0.173f,
									0.227f,
									1f
								};
							case 1966:
								return new float[]
								{
									0.027f,
									0.035f,
									0.039f,
									0f
								};
							case 1967:
								return new float[]
								{
									0.082f,
									0.098f,
									0.122f,
									0f
								};
							case 1968:
								return new float[]
								{
									0.031f,
									0.031f,
									0.031f,
									1f
								};
							case 1969:
								return new float[]
								{
									0.118f,
									0.118f,
									0.118f,
									0f
								};
							case 1970:
								return new float[]
								{
									0.357f,
									0.357f,
									0.357f,
									1f
								};
							case 1971:
								return new float[]
								{
									0.592f,
									1f,
									1f,
									1f
								};
							case 1972:
								return new float[]
								{
									0.522f,
									0.439f,
									0.439f,
									1f
								};
							case 1973:
								return new float[]
								{
									0.902f,
									0.902f,
									0.902f,
									1f
								};
							case 1974:
								return new float[]
								{
									0.773f,
									0.827f,
									0.98f,
									1f
								};
							case 1975:
								return new float[]
								{
									0.184f,
									0.176f,
									0.129f,
									1f
								};
							case 1976:
								return new float[]
								{
									0.416f,
									0.416f,
									0.416f,
									1f
								};
							case 1977:
								return new float[]
								{
									0.776f,
									0.776f,
									0.776f,
									1f
								};
							case 1978:
								return new float[]
								{
									0.325f,
									0.392f,
									0.42f,
									1f
								};
							case 1979:
								return new float[]
								{
									0.325f,
									0.392f,
									0.42f,
									1f
								};
							case 1980:
								return new float[]
								{
									0.09f,
									0.106f,
									0.114f,
									1f
								};
							case 1981:
								return new float[]
								{
									0.388f,
									0.451f,
									0.58f,
									1f
								};
							case 1982:
								return new float[]
								{
									0.18f,
									0.235f,
									0.286f,
									1f
								};
							case 1983:
								return new float[]
								{
									0.031f,
									0.42f,
									0.722f,
									1f
								};
							case 1984:
								return new float[]
								{
									0.047f,
									0.106f,
									0.137f,
									1f
								};
							case 1985:
								return new float[]
								{
									0.047f,
									0.106f,
									0.137f,
									1f
								};
							case 1986:
								return new float[]
								{
									0.078f,
									0.345f,
									0.341f,
									1f
								};
							case 1987:
								return new float[]
								{
									0.078f,
									0.341f,
									0.337f,
									1f
								};
							case 1988:
								return new float[]
								{
									1f,
									0.463f,
									0f,
									1f
								};
							case 2001:
								return new float[]
								{
									0f,
									0.004f,
									0.004f,
									1f
								};
							case 2003:
								return new float[]
								{
									0.486f,
									0.486f,
									0.486f,
									1f
								};
							case 2005:
								return new float[]
								{
									1f,
									1f,
									1f,
									1f
								};
							case 2006:
								return new float[]
								{
									0.557f,
									1f,
									0.6f,
									1f
								};
							case 2008:
								return new float[]
								{
									0.208f,
									0.588f,
									0.267f,
									1f
								};
							case 2009:
								return new float[]
								{
									0.067f,
									0.431f,
									0.773f,
									1f
								};
							case 2010:
								return new float[]
								{
									0.392f,
									0.392f,
									0.392f,
									0f
								};
							case 2011:
								return new float[]
								{
									0.29f,
									0.29f,
									0.29f,
									1f
								};
							case 2012:
								return new float[]
								{
									0.392f,
									0.392f,
									0.392f,
									0f
								};
							case 2013:
								return new float[]
								{
									0.463f,
									0.09f,
									0.471f,
									1f
								};
							case 2014:
								return new float[]
								{
									0.345f,
									0.09f,
									0.357f,
									1f
								};
							case 2015:
								return new float[]
								{
									0.008f,
									0.4f,
									0.055f,
									1f
								};
							case 2016:
							{
								float[] array13 = new float[4];
								array13[1] = 0.31f;
								array13[2] = 0.039f;
								return array13;
							}
							case 2017:
								return new float[]
								{
									0.482f,
									0.043f,
									0.063f,
									1f
								};
							case 2018:
							{
								float[] array14 = new float[4];
								array14[0] = 0.31f;
								array14[2] = 0.012f;
								return array14;
							}
							case 2020:
								return new float[]
								{
									0.004f,
									0.11f,
									0.306f,
									0f
								};
							case 2021:
								return new float[]
								{
									0.325f,
									0.325f,
									0.325f,
									0f
								};
							case 2022:
								return new float[]
								{
									0.722f,
									0.722f,
									0.722f,
									1f
								};
							case 2023:
								return new float[]
								{
									0.235f,
									0.09f,
									0.235f,
									0f
								};
							case 2024:
								return new float[]
								{
									0.098f,
									0.098f,
									0.098f,
									0f
								};
							case 2025:
								return new float[]
								{
									0.18f,
									0.306f,
									0.58f,
									0f
								};
							case 2026:
								return new float[]
								{
									0f,
									0f,
									0f,
									0.302f
								};
							case 2027:
								return new float[]
								{
									0.176f,
									0.043f,
									0.176f,
									1f
								};
							case 2028:
								return new float[]
								{
									0.8f,
									0.847f,
									0.89f,
									1f
								};
							case 2030:
								return new float[]
								{
									0.125f,
									0.125f,
									0.125f,
									0f
								};
							case 2036:
								return new float[]
								{
									0.286f,
									0.286f,
									0.286f,
									1f
								};
							case 2037:
								return new float[]
								{
									0.89f,
									0.118f,
									0.118f,
									1f
								};
							case 2039:
								return new float[]
								{
									0.886f,
									0.627f,
									0.008f,
									0f
								};
							case 2043:
								return new float[]
								{
									0.204f,
									0.204f,
									0.204f,
									0f
								};
							case 2046:
								return new float[]
								{
									0.055f,
									0.11f,
									0.114f,
									1f
								};
							case 2047:
								return new float[]
								{
									0.055f,
									0.11f,
									0.114f,
									1f
								};
							case 2048:
								return new float[]
								{
									0.055f,
									0.11f,
									0.114f,
									1f
								};
							case 2049:
								return new float[]
								{
									0.055f,
									0.11f,
									0.114f,
									1f
								};
							case 2050:
								return new float[]
								{
									0.106f,
									0.18f,
									0.184f,
									1f
								};
							case 2051:
								return new float[]
								{
									0.043f,
									0.082f,
									0.086f,
									1f
								};
							case 2052:
								return new float[]
								{
									0.043f,
									0.082f,
									0.086f,
									1f
								};
							case 2053:
								return new float[]
								{
									0.059f,
									0.137f,
									0.165f,
									1f
								};
							case 2054:
								return new float[]
								{
									0.031f,
									0.067f,
									0.039f,
									1f
								};
							case 2063:
								return new float[]
								{
									0f,
									1f,
									0.024f,
									0.349f
								};
							case 2064:
								return new float[]
								{
									1f,
									0.616f,
									0.616f,
									1f
								};
							case 2065:
								return new float[]
								{
									0.408f,
									0.345f,
									0.094f,
									0f
								};
							case 2066:
								return new float[]
								{
									0.22f,
									0.259f,
									0.286f,
									1f
								};
							case 2069:
								return new float[]
								{
									0.376f,
									0.376f,
									0.38f,
									1f
								};
							case 2070:
								return new float[]
								{
									1f,
									1f,
									1f,
									0.459f
								};
							case 2071:
								return new float[]
								{
									0.043f,
									0.043f,
									0.282f,
									1f
								};
							case 2072:
								return new float[]
								{
									0.102f,
									0.102f,
									0.102f,
									1f
								};
							case 2073:
								return new float[]
								{
									0.02f,
									0.188f,
									0.02f,
									1f
								};
							case 2074:
								return new float[]
								{
									0.227f,
									0.008f,
									0.02f,
									1f
								};
							case 2075:
								return new float[]
								{
									0.176f,
									0.008f,
									0.176f,
									1f
								};
							case 2076:
								return new float[]
								{
									0.224f,
									0.216f,
									0.094f,
									1f
								};
							case 2077:
								return new float[]
								{
									0f,
									0f,
									0f,
									1f
								};
							case 2080:
								return new float[]
								{
									0.573f,
									0.333f,
									0.118f,
									1f
								};
							case 2081:
								return new float[]
								{
									0.141f,
									0.082f,
									0.027f,
									1f
								};
							case 2087:
								return new float[]
								{
									0f,
									0.263f,
									0.533f,
									1f
								};
							case 2097:
								return new float[]
								{
									0.224f,
									0.224f,
									0.224f,
									1f
								};
							case 2098:
								return new float[]
								{
									0.8f,
									0.8f,
									0.8f,
									1f
								};
							case 2099:
								return new float[4];
							case 2100:
								return new float[]
								{
									0.114f,
									0.031f,
									0.286f,
									0.753f
								};
							case 2101:
								return new float[]
								{
									0.753f,
									0.753f,
									0.753f,
									1f
								};
							case 2102:
								return new float[]
								{
									0f,
									0f,
									0f,
									0.439f
								};
							case 2103:
								return new float[]
								{
									0.004f,
									0.388f,
									0.502f,
									1f
								};
							case 2104:
								return new float[4];
							case 2105:
								return new float[]
								{
									0.545f,
									0.231f,
									0f,
									1f
								};
							case 2110:
								return new float[]
								{
									0.49f,
									0.459f,
									0.533f,
									1f
								};
							case 2113:
								return new float[]
								{
									0.765f,
									0.976f,
									0.976f,
									1f
								};
							case 2114:
								return new float[]
								{
									0.82f,
									0.545f,
									0.063f,
									1f
								};
							case 2115:
								return new float[]
								{
									0.675f,
									0.125f,
									0.125f,
									1f
								};
							case 2116:
								return new float[]
								{
									0.671f,
									0.506f,
									0.263f,
									1f
								};
							case 2117:
								return new float[]
								{
									0.714f,
									0.122f,
									0.275f,
									1f
								};
							case 2119:
								return new float[]
								{
									0.859f,
									0.729f,
									0.447f,
									1f
								};
							case 2120:
								return new float[]
								{
									0.584f,
									0.58f,
									0.812f,
									0f
								};
							case 2121:
								return new float[]
								{
									0.514f,
									0.086f,
									0.004f,
									1f
								};
							case 2122:
								return new float[]
								{
									0.929f,
									0.804f,
									0.396f,
									1f
								};
							case 2123:
								return new float[]
								{
									0.427f,
									0.306f,
									0.22f,
									1f
								};
							case 2124:
								return new float[]
								{
									0.024f,
									0.247f,
									0.561f,
									1f
								};
							case 2125:
								return new float[]
								{
									0.408f,
									0.714f,
									0.984f,
									1f
								};
							default:
								if (A_0 == 2136)
								{
									return new float[]
									{
										0.757f,
										0.557f,
										0.239f,
										1f
									};
								}
								break;
							}
						}
					}
					else if (A_0 <= 2153)
					{
						if (A_0 == 2137)
						{
							return new float[]
							{
								0.239f,
								0.388f,
								0.153f,
								1f
							};
						}
						switch (A_0)
						{
						case 2145:
							return new float[]
							{
								0.976f,
								0.882f,
								0.129f,
								1f
							};
						case 2146:
							return new float[]
							{
								0.486f,
								0.612f,
								0.698f,
								1f
							};
						case 2147:
							return new float[]
							{
								0.122f,
								0.118f,
								0.133f,
								1f
							};
						case 2148:
							return new float[]
							{
								0.439f,
								0.416f,
								0.404f,
								1f
							};
						case 2153:
							return new float[]
							{
								0.275f,
								0.275f,
								0.275f,
								0f
							};
						}
					}
					else
					{
						switch (A_0)
						{
						case 2160:
							return new float[]
							{
								0.839f,
								0.839f,
								0.839f,
								1f
							};
						case 2161:
							return new float[]
							{
								0.525f,
								0.094f,
								0.094f,
								0f
							};
						case 2162:
						case 2163:
						case 2164:
						case 2165:
						case 2166:
						case 2167:
						case 2168:
						case 2169:
						case 2170:
						case 2171:
						case 2173:
						case 2174:
						case 2175:
						case 2176:
						case 2177:
						case 2178:
						case 2179:
						case 2180:
						case 2181:
						case 2182:
						case 2183:
						case 2184:
						case 2185:
						case 2186:
						case 2187:
						case 2188:
						case 2189:
						case 2190:
						case 2191:
						case 2192:
						case 2193:
						case 2194:
						case 2195:
						case 2196:
						case 2197:
						case 2198:
						case 2199:
						case 2200:
						case 2201:
						case 2202:
						case 2203:
						case 2205:
						case 2206:
						case 2209:
						case 2210:
						case 2211:
						case 2212:
						case 2218:
							break;
						case 2172:
							return new float[]
							{
								0.427f,
								0.212f,
								0.094f,
								0f
							};
						case 2204:
							return new float[]
							{
								0.133f,
								0.475f,
								0.365f,
								1f
							};
						case 2207:
							return new float[]
							{
								0.09f,
								0.337f,
								0.259f,
								0f
							};
						case 2208:
							return new float[]
							{
								0.235f,
								0.235f,
								0.235f,
								0f
							};
						case 2213:
							return new float[]
							{
								0.737f,
								0.773f,
								0.808f,
								1f
							};
						case 2214:
							return new float[]
							{
								0.133f,
								0.235f,
								0.02f,
								1f
							};
						case 2215:
							return new float[]
							{
								0.145f,
								0.188f,
								0.31f,
								1f
							};
						case 2216:
							return new float[]
							{
								0.239f,
								0.31f,
								0.467f,
								1f
							};
						case 2217:
							return new float[]
							{
								0.239f,
								0.31f,
								0.467f,
								1f
							};
						case 2219:
							return new float[]
							{
								0.365f,
								0.435f,
								0.576f,
								1f
							};
						case 2220:
							return new float[]
							{
								0.306f,
								0.384f,
								0.557f,
								1f
							};
						case 2221:
							return new float[]
							{
								0.514f,
								0.573f,
								0.647f,
								1f
							};
						case 2222:
							return new float[]
							{
								0.541f,
								0.588f,
								0.655f,
								1f
							};
						case 2223:
							return new float[]
							{
								0.333f,
								0.396f,
								0.525f,
								0.8f
							};
						case 2224:
							return new float[]
							{
								0.333f,
								0.396f,
								0.525f,
								0.8f
							};
						case 2225:
							return new float[]
							{
								0.333f,
								0.396f,
								0.525f,
								0.8f
							};
						case 2226:
							return new float[]
							{
								0.333f,
								0.396f,
								0.525f,
								0.8f
							};
						case 2227:
							return new float[]
							{
								0.306f,
								0.337f,
								0.353f,
								1f
							};
						case 2228:
							return new float[]
							{
								0.361f,
								0.259f,
								0.443f,
								1f
							};
						case 2229:
							return new float[]
							{
								0.157f,
								0.11f,
								0.2f,
								1f
							};
						case 2230:
							return new float[]
							{
								0.247f,
								0.18f,
								0.306f,
								1f
							};
						case 2231:
							return new float[]
							{
								0.247f,
								0.18f,
								0.306f,
								1f
							};
						case 2232:
							return new float[]
							{
								0.361f,
								0.259f,
								0.443f,
								1f
							};
						case 2233:
							return new float[]
							{
								0.29f,
								0.227f,
								0.337f,
								1f
							};
						case 2234:
							return new float[]
							{
								0.329f,
								0.247f,
								0.369f,
								1f
							};
						case 2235:
							return new float[]
							{
								0.094f,
								0.094f,
								0.094f,
								1f
							};
						case 2236:
							return new float[]
							{
								0.094f,
								0.094f,
								0.094f,
								1f
							};
						case 2237:
							return new float[]
							{
								0.137f,
								0.2f,
								0.251f,
								1f
							};
						case 2238:
							return new float[]
							{
								0.086f,
								0.086f,
								0.086f,
								1f
							};
						case 2239:
							return new float[]
							{
								0.086f,
								0.086f,
								0.086f,
								1f
							};
						case 2240:
							return new float[]
							{
								0.835f,
								0.835f,
								0.827f,
								1f
							};
						case 2241:
							return new float[]
							{
								0.835f,
								0.835f,
								0.827f,
								1f
							};
						case 2242:
							return new float[]
							{
								0.957f,
								0.949f,
								0.918f,
								1f
							};
						case 2243:
							return new float[]
							{
								0.894f,
								0.882f,
								0.851f,
								1f
							};
						case 2244:
							return new float[]
							{
								0.333f,
								0.294f,
								0.294f,
								1f
							};
						case 2245:
							return new float[]
							{
								0.145f,
								0.278f,
								0.412f,
								1f
							};
						case 2246:
							return new float[]
							{
								0.349f,
								0.247f,
								0.192f,
								1f
							};
						case 2247:
							return new float[]
							{
								0.361f,
								0.231f,
								0.161f,
								1f
							};
						case 2248:
							return new float[]
							{
								0.376f,
								0.024f,
								0f,
								1f
							};
						case 2249:
							return new float[]
							{
								0.278f,
								0.188f,
								0.141f,
								1f
							};
						case 2250:
							return new float[]
							{
								0.278f,
								0.188f,
								0.141f,
								1f
							};
						case 2251:
							return new float[]
							{
								0.4f,
								0.259f,
								0.184f,
								1f
							};
						case 2252:
							return new float[]
							{
								0.263f,
								0.169f,
								0.125f,
								1f
							};
						case 2253:
							return new float[]
							{
								1f,
								1f,
								0f,
								1f
							};
						case 2254:
							return new float[]
							{
								0.894f,
								0.886f,
								0.886f,
								0f
							};
						case 2255:
							return new float[]
							{
								0.89f,
								0.867f,
								0.824f,
								1f
							};
						case 2256:
							return new float[]
							{
								0.604f,
								0.51f,
								0.412f,
								1f
							};
						case 2257:
							return new float[]
							{
								0.49f,
								0.353f,
								0.247f,
								1f
							};
						case 2258:
							return new float[]
							{
								0.541f,
								0.498f,
								0.463f,
								1f
							};
						default:
							switch (A_0)
							{
							case 2273:
								return new float[]
								{
									0.71f,
									0.737f,
									0.765f,
									1f
								};
							case 2274:
								return new float[]
								{
									0.447f,
									0.478f,
									0.478f,
									1f
								};
							case 2275:
								return new float[]
								{
									0.631f,
									0.631f,
									0.631f,
									1f
								};
							case 2276:
								return new float[]
								{
									0.482f,
									0.482f,
									0.482f,
									0.247f
								};
							}
							break;
						}
					}
				}
				else if (A_0 <= 2771)
				{
					if (A_0 <= 2591)
					{
						if (A_0 <= 2405)
						{
							switch (A_0)
							{
							case 2298:
								return new float[]
								{
									1f,
									0.502f,
									0f,
									1f
								};
							case 2299:
								return new float[]
								{
									0.31f,
									0.31f,
									0.31f,
									1f
								};
							case 2300:
							case 2310:
							case 2311:
							case 2312:
							case 2313:
							case 2314:
							case 2315:
							case 2316:
							case 2328:
							case 2329:
							case 2330:
							case 2333:
							case 2334:
							case 2335:
							case 2340:
							case 2341:
							case 2344:
								break;
							case 2301:
								return new float[]
								{
									0.616f,
									0.655f,
									0.718f,
									1f
								};
							case 2302:
								return new float[]
								{
									0.278f,
									0.345f,
									0.475f,
									0.8f
								};
							case 2303:
								return new float[]
								{
									0.494f,
									0.643f,
									0.698f,
									1f
								};
							case 2304:
								return new float[]
								{
									0.063f,
									0.333f,
									0.902f,
									1f
								};
							case 2305:
								return new float[]
								{
									0.769f,
									0f,
									0.765f,
									1f
								};
							case 2306:
								return new float[]
								{
									0.231f,
									0.835f,
									0.231f,
									1f
								};
							case 2307:
								return new float[]
								{
									0.949f,
									0.016f,
									0.655f,
									1f
								};
							case 2308:
								return new float[]
								{
									0.949f,
									0.729f,
									0.016f,
									1f
								};
							case 2309:
								return new float[]
								{
									0f,
									0.424f,
									0.839f,
									1f
								};
							case 2317:
								return new float[]
								{
									0.569f,
									0.388f,
									0.235f,
									1f
								};
							case 2318:
								return new float[]
								{
									0.345f,
									0.482f,
									0.518f,
									1f
								};
							case 2319:
								return new float[]
								{
									0.204f,
									0.145f,
									0.051f,
									1f
								};
							case 2320:
								return new float[]
								{
									0.075f,
									0.188f,
									0.192f,
									1f
								};
							case 2321:
								return new float[]
								{
									0.494f,
									0.639f,
									0.663f,
									1f
								};
							case 2322:
								return new float[]
								{
									0.318f,
									0.039f,
									0.118f,
									1f
								};
							case 2323:
								return new float[]
								{
									0.863f,
									0.847f,
									0.749f,
									0f
								};
							case 2324:
							{
								float[] array15 = new float[4];
								array15[0] = 0.314f;
								array15[1] = 0.502f;
								return array15;
							}
							case 2325:
								return new float[]
								{
									0.22f,
									0.388f,
									0f,
									1f
								};
							case 2326:
								return new float[]
								{
									0.298f,
									0.486f,
									0.557f,
									1f
								};
							case 2327:
								return new float[]
								{
									1f,
									1f,
									1f,
									1f
								};
							case 2331:
								return new float[]
								{
									0.631f,
									0.631f,
									0.631f,
									1f
								};
							case 2332:
								return new float[]
								{
									0.749f,
									0.812f,
									0.902f,
									1f
								};
							case 2336:
								return new float[]
								{
									0.51f,
									0f,
									0f,
									1f
								};
							case 2337:
								return new float[]
								{
									0.604f,
									0.4f,
									0.075f,
									1f
								};
							case 2338:
								return new float[]
								{
									0.82f,
									0.831f,
									0.929f,
									1f
								};
							case 2339:
								return new float[]
								{
									0.769f,
									1f,
									1f,
									1f
								};
							case 2342:
								return new float[]
								{
									0.063f,
									0.733f,
									0.506f,
									1f
								};
							case 2343:
								return new float[4];
							case 2345:
								return new float[]
								{
									0.369f,
									0.082f,
									0.082f,
									1f
								};
							case 2346:
								return new float[]
								{
									0.129f,
									0.137f,
									0.149f,
									1f
								};
							case 2347:
								return new float[]
								{
									0.216f,
									0.169f,
									0.157f,
									1f
								};
							default:
								switch (A_0)
								{
								case 2378:
									return new float[]
									{
										0.059f,
										0.11f,
										0.184f,
										0.89f
									};
								case 2379:
									return new float[]
									{
										0f,
										0f,
										0f,
										0.612f
									};
								case 2380:
									return new float[]
									{
										0.459f,
										0.459f,
										0.459f,
										1f
									};
								case 2381:
									return new float[]
									{
										1f,
										0.384f,
										0f,
										1f
									};
								case 2382:
									return new float[]
									{
										0.082f,
										0.082f,
										0.082f,
										1f
									};
								case 2389:
									return new float[]
									{
										0.161f,
										0.247f,
										0.345f,
										1f
									};
								case 2390:
									return new float[]
									{
										0.973f,
										0.945f,
										0.89f,
										1f
									};
								case 2391:
									return new float[]
									{
										0.184f,
										0.18f,
										0.133f,
										0f
									};
								case 2392:
									return new float[]
									{
										0.169f,
										0.094f,
										0.055f,
										0f
									};
								case 2393:
									return new float[]
									{
										0.357f,
										0.165f,
										0.141f,
										1f
									};
								case 2394:
									return new float[]
									{
										0.561f,
										0.153f,
										0.584f,
										1f
									};
								case 2399:
									return new float[]
									{
										1f,
										0.918f,
										0.416f,
										1f
									};
								case 2400:
									return new float[]
									{
										0.596f,
										0.482f,
										0.58f,
										1f
									};
								case 2401:
									return new float[]
									{
										0.271f,
										0.263f,
										0.306f,
										1f
									};
								case 2402:
									return new float[]
									{
										0.722f,
										0.722f,
										0.722f,
										0f
									};
								case 2403:
									return new float[]
									{
										0.765f,
										0.38f,
										0f,
										1f
									};
								case 2404:
									return new float[]
									{
										0.373f,
										0.278f,
										0.161f,
										1f
									};
								case 2405:
									return new float[]
									{
										0.216f,
										0.208f,
										0.196f,
										1f
									};
								}
								break;
							}
						}
						else
						{
							switch (A_0)
							{
							case 2462:
								return new float[]
								{
									0.722f,
									0.435f,
									0.518f,
									0f
								};
							case 2463:
								return new float[]
								{
									0.769f,
									0.659f,
									0.404f,
									0f
								};
							case 2464:
								return new float[]
								{
									0.365f,
									0.11f,
									0f,
									1f
								};
							case 2465:
								return new float[]
								{
									0.6f,
									0f,
									0.275f,
									1f
								};
							case 2466:
								return new float[]
								{
									0.086f,
									0.086f,
									0.086f,
									1f
								};
							case 2467:
								return new float[]
								{
									0.475f,
									0.024f,
									0.024f,
									1f
								};
							case 2468:
								return new float[]
								{
									0.686f,
									0.459f,
									0.098f,
									1f
								};
							case 2469:
								return new float[]
								{
									0.671f,
									0.106f,
									0.106f,
									1f
								};
							case 2470:
								return new float[]
								{
									0.671f,
									0.106f,
									0.106f,
									1f
								};
							case 2471:
								return new float[]
								{
									0.643f,
									0.439f,
									0.941f,
									1f
								};
							case 2472:
								return new float[]
								{
									0.604f,
									0.914f,
									0.322f,
									1f
								};
							case 2473:
								return new float[]
								{
									0.545f,
									0.545f,
									0.545f,
									0f
								};
							case 2474:
								return new float[]
								{
									0.545f,
									0.545f,
									0.545f,
									0f
								};
							case 2475:
								return new float[]
								{
									0.647f,
									0.286f,
									0.09f,
									0f
								};
							case 2476:
								return new float[]
								{
									0.467f,
									0.125f,
									0.078f,
									0f
								};
							case 2477:
							case 2478:
							case 2487:
							case 2503:
							case 2505:
							case 2506:
							case 2507:
							case 2508:
							case 2509:
							case 2510:
							case 2511:
							case 2512:
								break;
							case 2479:
								return new float[]
								{
									0.486f,
									0.541f,
									0.494f,
									0f
								};
							case 2480:
							{
								float[] array16 = new float[4];
								array16[0] = 0.886f;
								array16[1] = 0.686f;
								return array16;
							}
							case 2481:
								return new float[]
								{
									0.365f,
									1f,
									0.38f,
									1f
								};
							case 2482:
								return new float[]
								{
									1f,
									0.365f,
									0.435f,
									1f
								};
							case 2483:
								return new float[]
								{
									0.8f,
									0.839f,
									0.863f,
									0.459f
								};
							case 2484:
								return new float[]
								{
									0.349f,
									0.525f,
									0.247f,
									1f
								};
							case 2485:
								return new float[]
								{
									0.224f,
									0.224f,
									0.224f,
									1f
								};
							case 2486:
								return new float[]
								{
									0.141f,
									0.129f,
									0.118f,
									1f
								};
							case 2488:
								return new float[]
								{
									0.133f,
									0.133f,
									0.133f,
									1f
								};
							case 2489:
								return new float[]
								{
									0.145f,
									0.145f,
									0.145f,
									0f
								};
							case 2490:
								return new float[]
								{
									0.941f,
									0.867f,
									0.941f,
									1f
								};
							case 2491:
								return new float[]
								{
									1f,
									0.804f,
									0.424f,
									0f
								};
							case 2492:
								return new float[]
								{
									0.867f,
									0.867f,
									0.867f,
									1f
								};
							case 2493:
								return new float[]
								{
									1f,
									1f,
									0.796f,
									1f
								};
							case 2494:
								return new float[]
								{
									0.941f,
									0.835f,
									0.647f,
									1f
								};
							case 2495:
								return new float[]
								{
									1f,
									0.447f,
									0f,
									1f
								};
							case 2496:
								return new float[]
								{
									0.792f,
									0.741f,
									0.373f,
									1f
								};
							case 2497:
								return new float[]
								{
									0.463f,
									0.396f,
									0.294f,
									1f
								};
							case 2498:
								return new float[]
								{
									0.851f,
									0.322f,
									0.565f,
									1f
								};
							case 2499:
								return new float[]
								{
									0.173f,
									0.514f,
									0.506f,
									1f
								};
							case 2500:
								return new float[]
								{
									0.773f,
									0.529f,
									0.004f,
									1f
								};
							case 2501:
								return new float[]
								{
									0.408f,
									0.408f,
									0.408f,
									1f
								};
							case 2502:
								return new float[]
								{
									0.573f,
									0.396f,
									0.071f,
									1f
								};
							case 2504:
								return new float[]
								{
									0.616f,
									0.42f,
									0.235f,
									1f
								};
							case 2513:
								return new float[]
								{
									0.051f,
									0.114f,
									0.145f,
									0.6f
								};
							default:
								if (A_0 == 2591)
								{
									return new float[]
									{
										0.871f,
										0.882f,
										0.855f,
										1f
									};
								}
								break;
							}
						}
					}
					else if (A_0 <= 2703)
					{
						switch (A_0)
						{
						case 2611:
							return new float[]
							{
								0.878f,
								0f,
								0f,
								1f
							};
						case 2612:
							return new float[]
							{
								0.957f,
								1f,
								1f,
								1f
							};
						case 2613:
						case 2615:
							break;
						case 2614:
							return new float[]
							{
								0.533f,
								0.533f,
								0.533f,
								0f
							};
						case 2616:
							return new float[]
							{
								0.773f,
								0.529f,
								0.004f,
								1f
							};
						case 2617:
							return new float[]
							{
								0.408f,
								0.408f,
								0.408f,
								1f
							};
						case 2618:
							return new float[]
							{
								0.573f,
								0.396f,
								0.071f,
								1f
							};
						case 2619:
							return new float[]
							{
								0.773f,
								0.529f,
								0.004f,
								0f
							};
						case 2620:
							return new float[]
							{
								0.408f,
								0.408f,
								0.408f,
								0f
							};
						case 2621:
							return new float[]
							{
								0.573f,
								0.396f,
								0.071f,
								0f
							};
						case 2622:
							return new float[]
							{
								0.161f,
								0.161f,
								0.161f,
								1f
							};
						default:
							switch (A_0)
							{
							case 2680:
								return new float[]
								{
									0.898f,
									0.325f,
									0.89f,
									1f
								};
							case 2681:
								return new float[]
								{
									0.929f,
									0.698f,
									0.925f,
									1f
								};
							case 2682:
								return new float[]
								{
									0.282f,
									0.059f,
									0.102f,
									1f
								};
							case 2683:
								return new float[]
								{
									0.949f,
									0.525f,
									0.525f,
									0f
								};
							case 2693:
								return new float[]
								{
									0.722f,
									0f,
									0f,
									1f
								};
							case 2694:
								return new float[]
								{
									0.678f,
									0.31f,
									0.596f,
									0f
								};
							case 2697:
								return new float[]
								{
									0.529f,
									0.451f,
									0.275f,
									1f
								};
							case 2698:
								return new float[]
								{
									0.875f,
									0.816f,
									0.529f,
									0f
								};
							case 2699:
								return new float[]
								{
									0.529f,
									0.451f,
									0.275f,
									0f
								};
							case 2700:
								return new float[]
								{
									0.875f,
									0.816f,
									0.529f,
									1f
								};
							case 2701:
								return new float[]
								{
									0.529f,
									0.451f,
									0.275f,
									0f
								};
							case 2702:
								return new float[]
								{
									0.702f,
									0.604f,
									0.388f,
									0f
								};
							case 2703:
								return new float[]
								{
									0.875f,
									0.816f,
									0.529f,
									1f
								};
							}
							break;
						}
					}
					else
					{
						switch (A_0)
						{
						case 2735:
							return new float[]
							{
								0.714f,
								0.416f,
								0.145f,
								1f
							};
						case 2736:
							return new float[]
							{
								1f,
								0.659f,
								0f,
								1f
							};
						case 2737:
						{
							float[] array17 = new float[4];
							array17[0] = 1f;
							array17[1] = 0.965f;
							return array17;
						}
						default:
							switch (A_0)
							{
							case 2765:
								return new float[]
								{
									0.133f,
									0.173f,
									0.227f,
									1f
								};
							case 2766:
								return new float[]
								{
									0.059f,
									0.647f,
									0.118f,
									0f
								};
							case 2767:
								return new float[]
								{
									0.239f,
									0.322f,
									0.325f,
									1f
								};
							case 2768:
								return new float[]
								{
									0.176f,
									0.243f,
									0.29f,
									1f
								};
							case 2769:
								return new float[]
								{
									0.094f,
									0.129f,
									0.153f,
									1f
								};
							case 2770:
								return new float[]
								{
									0.176f,
									0.243f,
									0.29f,
									1f
								};
							case 2771:
								return new float[]
								{
									0.176f,
									0.243f,
									0.29f,
									1f
								};
							}
							break;
						}
					}
				}
				else if (A_0 <= 3532)
				{
					if (A_0 <= 3503)
					{
						switch (A_0)
						{
						case 2983:
							return new float[]
							{
								1f,
								1f,
								1f,
								1f
							};
						case 2984:
							return new float[]
							{
								0.749f,
								1f,
								1f,
								1f
							};
						case 2985:
							return new float[]
							{
								0.176f,
								0.29f,
								0.106f,
								1f
							};
						case 2986:
						case 2987:
						case 3002:
						case 3003:
						case 3004:
						case 3045:
						case 3052:
						case 3053:
						case 3054:
						case 3055:
						case 3056:
						case 3057:
						case 3058:
						case 3059:
						case 3060:
						case 3061:
						case 3062:
						case 3063:
						case 3064:
						case 3065:
						case 3066:
						case 3067:
						case 3068:
						case 3069:
						case 3070:
						case 3071:
						case 3072:
						case 3073:
						case 3074:
						case 3075:
						case 3076:
						case 3077:
						case 3078:
						case 3079:
						case 3080:
						case 3081:
						case 3082:
						case 3084:
						case 3085:
						case 3086:
						case 3087:
						case 3088:
						case 3089:
						case 3090:
						case 3091:
						case 3092:
						case 3094:
						case 3095:
						case 3096:
						case 3097:
						case 3098:
						case 3100:
						case 3101:
						case 3102:
						case 3103:
						case 3104:
						case 3105:
						case 3106:
						case 3107:
						case 3108:
						case 3109:
						case 3111:
						case 3113:
						case 3114:
						case 3115:
						case 3116:
						case 3117:
						case 3118:
						case 3120:
						case 3121:
						case 3122:
						case 3123:
						case 3124:
						case 3126:
						case 3129:
						case 3130:
						case 3131:
						case 3132:
						case 3133:
						case 3134:
						case 3135:
						case 3136:
						case 3137:
						case 3138:
						case 3140:
						case 3143:
						case 3144:
						case 3145:
						case 3146:
						case 3147:
						case 3148:
						case 3149:
						case 3150:
						case 3151:
						case 3152:
						case 3153:
						case 3155:
						case 3159:
						case 3160:
						case 3161:
						case 3162:
						case 3163:
						case 3164:
						case 3165:
						case 3166:
						case 3167:
						case 3170:
						case 3171:
						case 3172:
						case 3173:
						case 3174:
						case 3175:
						case 3176:
						case 3201:
						case 3233:
						case 3234:
						case 3236:
						case 3246:
						case 3247:
						case 3248:
						case 3249:
						case 3250:
						case 3251:
						case 3252:
						case 3253:
						case 3254:
						case 3255:
						case 3256:
						case 3257:
						case 3258:
						case 3259:
						case 3260:
						case 3261:
						case 3262:
						case 3263:
						case 3264:
						case 3265:
						case 3266:
						case 3267:
						case 3268:
						case 3269:
						case 3270:
						case 3271:
						case 3272:
						case 3273:
						case 3274:
						case 3275:
						case 3276:
						case 3277:
						case 3278:
						case 3279:
						case 3280:
						case 3281:
						case 3282:
						case 3283:
						case 3285:
						case 3286:
						case 3287:
						case 3288:
						case 3289:
						case 3290:
						case 3291:
						case 3292:
						case 3293:
						case 3294:
						case 3295:
						case 3296:
						case 3297:
						case 3298:
						case 3299:
						case 3300:
						case 3301:
						case 3302:
						case 3303:
						case 3308:
						case 3333:
						case 3334:
						case 3335:
						case 3336:
						case 3337:
						case 3339:
						case 3340:
						case 3341:
						case 3342:
						case 3343:
						case 3344:
						case 3345:
						case 3346:
						case 3347:
						case 3348:
						case 3349:
						case 3350:
						case 3351:
						case 3352:
						case 3354:
						case 3355:
						case 3356:
						case 3357:
						case 3358:
						case 3361:
						case 3362:
						case 3363:
						case 3364:
						case 3365:
						case 3366:
						case 3367:
						case 3368:
						case 3369:
						case 3370:
						case 3371:
						case 3372:
						case 3439:
						case 3440:
						case 3442:
						case 3443:
						case 3444:
						case 3445:
						case 3446:
						case 3447:
						case 3448:
						case 3449:
						case 3450:
						case 3451:
						case 3452:
						case 3454:
						case 3455:
						case 3456:
						case 3457:
						case 3458:
						case 3459:
						case 3460:
						case 3461:
						case 3462:
						case 3463:
						case 3464:
						case 3465:
							break;
						case 2988:
							return new float[]
							{
								0.569f,
								0.31f,
								0.204f,
								0f
							};
						case 2989:
							return new float[]
							{
								0.439f,
								0.396f,
								0.38f,
								0f
							};
						case 2990:
							return new float[]
							{
								0.557f,
								0.29f,
								0.192f,
								0f
							};
						case 2991:
							return new float[]
							{
								0.427f,
								0.384f,
								0.369f,
								0f
							};
						case 2992:
							return new float[]
							{
								1f,
								1f,
								1f,
								1f
							};
						case 2993:
							return new float[]
							{
								0.071f,
								0.329f,
								0.31f,
								1f
							};
						case 2994:
							return new float[]
							{
								0.62f,
								0.098f,
								0.086f,
								1f
							};
						case 2995:
							return new float[]
							{
								0f,
								0.396f,
								0f,
								1f
							};
						case 2996:
							return new float[]
							{
								0.2f,
								0.584f,
								0.745f,
								0f
							};
						case 2997:
							return new float[]
							{
								0.514f,
								0.122f,
								0.631f,
								1f
							};
						case 2998:
							return new float[]
							{
								0.765f,
								0.808f,
								0.98f,
								1f
							};
						case 2999:
							return new float[]
							{
								0.239f,
								0.455f,
								0f,
								1f
							};
						case 3000:
							return new float[]
							{
								0.212f,
								0.004f,
								0.243f,
								1f
							};
						case 3001:
							return new float[]
							{
								0.149f,
								0.212f,
								0.349f,
								1f
							};
						case 3005:
							return new float[]
							{
								0.278f,
								0.635f,
								0.714f,
								1f
							};
						case 3006:
							return new float[]
							{
								0.565f,
								0.165f,
								0.286f,
								1f
							};
						case 3007:
							return new float[]
							{
								0.776f,
								0.482f,
								0.706f,
								1f
							};
						case 3008:
							return new float[]
							{
								0.333f,
								0.718f,
								0.706f,
								1f
							};
						case 3009:
							return new float[]
							{
								0.102f,
								0.376f,
								0.408f,
								1f
							};
						case 3010:
							return new float[]
							{
								0.047f,
								0.075f,
								0.082f,
								1f
							};
						case 3011:
							return new float[]
							{
								0.047f,
								0.075f,
								0.082f,
								1f
							};
						case 3012:
							return new float[]
							{
								0.047f,
								0.075f,
								0.082f,
								1f
							};
						case 3013:
							return new float[]
							{
								0.047f,
								0.075f,
								0.082f,
								1f
							};
						case 3014:
							return new float[]
							{
								0.047f,
								0.075f,
								0.082f,
								1f
							};
						case 3015:
							return new float[]
							{
								0.047f,
								0.075f,
								0.082f,
								1f
							};
						case 3016:
							return new float[]
							{
								0.09f,
								0.039f,
								0.078f,
								1f
							};
						case 3017:
							return new float[]
							{
								0.09f,
								0.039f,
								0.078f,
								1f
							};
						case 3018:
							return new float[]
							{
								0.09f,
								0.039f,
								0.078f,
								1f
							};
						case 3019:
							return new float[]
							{
								0.09f,
								0.039f,
								0.078f,
								1f
							};
						case 3020:
							return new float[]
							{
								0.09f,
								0.039f,
								0.078f,
								1f
							};
						case 3021:
							return new float[]
							{
								0.09f,
								0.039f,
								0.078f,
								1f
							};
						case 3022:
							return new float[]
							{
								0.114f,
								0.38f,
								0.42f,
								1f
							};
						case 3023:
							return new float[]
							{
								0.114f,
								0.38f,
								0.42f,
								1f
							};
						case 3024:
							return new float[]
							{
								0.114f,
								0.38f,
								0.42f,
								1f
							};
						case 3025:
							return new float[]
							{
								0.114f,
								0.38f,
								0.42f,
								1f
							};
						case 3026:
							return new float[]
							{
								0.059f,
								0.141f,
								0.176f,
								1f
							};
						case 3027:
							return new float[]
							{
								0.09f,
								0.208f,
								0.255f,
								1f
							};
						case 3028:
							return new float[]
							{
								0.031f,
								0.078f,
								0.071f,
								1f
							};
						case 3029:
							return new float[]
							{
								0.059f,
								0.141f,
								0.176f,
								1f
							};
						case 3030:
							return new float[]
							{
								0.314f,
								0.525f,
								0.584f,
								1f
							};
						case 3031:
							return new float[]
							{
								0.349f,
								0.533f,
								0.624f,
								1f
							};
						case 3032:
							return new float[]
							{
								0.231f,
								0f,
								0.235f,
								1f
							};
						case 3033:
							return new float[]
							{
								0.224f,
								0.075f,
								0.498f,
								1f
							};
						case 3034:
							return new float[]
							{
								0f,
								0f,
								0f,
								0.475f
							};
						case 3035:
							return new float[]
							{
								0f,
								0f,
								0f,
								0.475f
							};
						case 3036:
							return new float[]
							{
								0.161f,
								0.569f,
								0.549f,
								0f
							};
						case 3037:
							return new float[]
							{
								0.318f,
								0.639f,
								0.255f,
								1f
							};
						case 3038:
							return new float[]
							{
								0.541f,
								0.09f,
								0.541f,
								1f
							};
						case 3039:
							return new float[]
							{
								0.114f,
								0.431f,
								0.467f,
								1f
							};
						case 3040:
							return new float[]
							{
								0.408f,
								0.235f,
								0.518f,
								1f
							};
						case 3041:
							return new float[]
							{
								0.055f,
								0.09f,
								0.102f,
								1f
							};
						case 3042:
							return new float[]
							{
								0.42f,
								0.518f,
								0.627f,
								0f
							};
						case 3043:
							return new float[]
							{
								0.129f,
								0.278f,
								0.31f,
								1f
							};
						case 3044:
							return new float[]
							{
								0.29f,
								0.278f,
								0.424f,
								0f
							};
						case 3046:
							return new float[]
							{
								0.204f,
								0.329f,
								0.369f,
								1f
							};
						case 3047:
							return new float[]
							{
								0.176f,
								0.302f,
								0.247f,
								1f
							};
						case 3048:
							return new float[]
							{
								0.271f,
								0.251f,
								0.373f,
								1f
							};
						case 3049:
							return new float[]
							{
								0f,
								0.224f,
								0.016f,
								1f
							};
						case 3050:
							return new float[]
							{
								0.467f,
								0.2f,
								0.443f,
								1f
							};
						case 3051:
							return new float[]
							{
								0.055f,
								0.067f,
								0.129f,
								1f
							};
						case 3083:
							return new float[]
							{
								0.396f,
								0.169f,
								0.259f,
								1f
							};
						case 3093:
							return new float[]
							{
								0.663f,
								0.306f,
								1f,
								1f
							};
						case 3099:
							return new float[]
							{
								0.18f,
								0.176f,
								0.169f,
								1f
							};
						case 3110:
							return new float[]
							{
								0.486f,
								0.486f,
								0.486f,
								1f
							};
						case 3112:
							return new float[]
							{
								0.29f,
								0.29f,
								0.29f,
								1f
							};
						case 3119:
							return new float[]
							{
								1f,
								0.722f,
								0.361f,
								1f
							};
						case 3125:
							return new float[]
							{
								0.341f,
								0.243f,
								0.667f,
								1f
							};
						case 3127:
							return new float[]
							{
								0.463f,
								0.604f,
								0.365f,
								1f
							};
						case 3128:
							return new float[]
							{
								0.733f,
								0.09f,
								0.145f,
								1f
							};
						case 3139:
							return new float[]
							{
								0.314f,
								0.314f,
								0.314f,
								1f
							};
						case 3141:
							return new float[]
							{
								0.298f,
								0.373f,
								0.565f,
								1f
							};
						case 3142:
							return new float[]
							{
								1f,
								0.922f,
								0.71f,
								1f
							};
						case 3154:
							return new float[]
							{
								0.251f,
								0.933f,
								0.282f,
								1f
							};
						case 3156:
							return new float[]
							{
								0.188f,
								0.235f,
								0.255f,
								0f
							};
						case 3157:
							return new float[]
							{
								0.18f,
								0.18f,
								0.18f,
								1f
							};
						case 3158:
							return new float[]
							{
								0.588f,
								0.345f,
								0.063f,
								1f
							};
						case 3168:
							return new float[]
							{
								0.18f,
								0.176f,
								0.169f,
								1f
							};
						case 3169:
							return new float[]
							{
								0.753f,
								0.753f,
								0.753f,
								1f
							};
						case 3177:
							return new float[]
							{
								0.204f,
								0.224f,
								0.259f,
								0f
							};
						case 3178:
							return new float[]
							{
								0.702f,
								0.651f,
								0.576f,
								0f
							};
						case 3179:
							return new float[]
							{
								0.851f,
								0.757f,
								0.604f,
								1f
							};
						case 3180:
							return new float[]
							{
								0.839f,
								0.745f,
								0.596f,
								1f
							};
						case 3181:
							return new float[]
							{
								0.373f,
								0.271f,
								0.184f,
								1f
							};
						case 3182:
							return new float[]
							{
								0.239f,
								0.239f,
								0.239f,
								1f
							};
						case 3183:
							return new float[]
							{
								0.31f,
								0.188f,
								0.094f,
								1f
							};
						case 3184:
							return new float[]
							{
								0.494f,
								0.467f,
								0.412f,
								1f
							};
						case 3185:
							return new float[]
							{
								0.494f,
								0.467f,
								0.412f,
								1f
							};
						case 3186:
							return new float[]
							{
								0.494f,
								0.467f,
								0.412f,
								1f
							};
						case 3187:
							return new float[]
							{
								0.212f,
								0.204f,
								0.18f,
								1f
							};
						case 3188:
							return new float[]
							{
								0.494f,
								0.467f,
								0.412f,
								1f
							};
						case 3189:
							return new float[]
							{
								0.494f,
								0.467f,
								0.412f,
								1f
							};
						case 3190:
							return new float[]
							{
								0.231f,
								0.224f,
								0.2f,
								1f
							};
						case 3191:
							return new float[]
							{
								0.494f,
								0.467f,
								0.412f,
								1f
							};
						case 3192:
							return new float[]
							{
								0.353f,
								0.251f,
								0.169f,
								1f
							};
						case 3193:
							return new float[]
							{
								0.353f,
								0.251f,
								0.169f,
								1f
							};
						case 3194:
							return new float[]
							{
								0.314f,
								0.192f,
								0.094f,
								1f
							};
						case 3195:
							return new float[]
							{
								0.478f,
								0.278f,
								0.11f,
								1f
							};
						case 3196:
							return new float[]
							{
								0.475f,
								0.267f,
								0.106f,
								1f
							};
						case 3197:
							return new float[]
							{
								0.561f,
								0.325f,
								0.129f,
								1f
							};
						case 3198:
							return new float[]
							{
								0.475f,
								0.267f,
								0.106f,
								1f
							};
						case 3199:
							return new float[]
							{
								0.561f,
								0.325f,
								0.129f,
								1f
							};
						case 3200:
							return new float[]
							{
								0.302f,
								0.302f,
								0.302f,
								1f
							};
						case 3202:
							return new float[]
							{
								0.224f,
								0.224f,
								0.224f,
								0f
							};
						case 3203:
							return new float[]
							{
								0.129f,
								0.129f,
								0.129f,
								1f
							};
						case 3204:
							return new float[]
							{
								0.184f,
								0.184f,
								0.184f,
								1f
							};
						case 3205:
							return new float[]
							{
								0.635f,
								0.486f,
								0.278f,
								0f
							};
						case 3206:
							return new float[]
							{
								0.761f,
								0.706f,
								0.624f,
								1f
							};
						case 3207:
							return new float[]
							{
								0.212f,
								0.11f,
								0.047f,
								0f
							};
						case 3208:
							return new float[]
							{
								0.267f,
								0.196f,
								0.11f,
								1f
							};
						case 3209:
							return new float[]
							{
								0.275f,
								0.161f,
								0.11f,
								1f
							};
						case 3210:
							return new float[]
							{
								0.518f,
								0.267f,
								0.012f,
								1f
							};
						case 3211:
							return new float[]
							{
								0.204f,
								0.192f,
								0.188f,
								1f
							};
						case 3212:
							return new float[]
							{
								0.169f,
								0.169f,
								0.169f,
								0f
							};
						case 3213:
							return new float[]
							{
								0.451f,
								0.373f,
								0.212f,
								0f
							};
						case 3214:
							return new float[]
							{
								0.353f,
								0.243f,
								0.137f,
								0f
							};
						case 3215:
							return new float[]
							{
								0.267f,
								0.149f,
								0.118f,
								1f
							};
						case 3216:
							return new float[]
							{
								0.302f,
								0.18f,
								0.09f,
								1f
							};
						case 3217:
							return new float[]
							{
								0.345f,
								0.212f,
								0.133f,
								1f
							};
						case 3218:
							return new float[]
							{
								0.235f,
								0.137f,
								0.051f,
								0f
							};
						case 3219:
							return new float[]
							{
								0.427f,
								0.365f,
								0.278f,
								1f
							};
						case 3220:
							return new float[]
							{
								0.42f,
								0.243f,
								0.031f,
								1f
							};
						case 3221:
							return new float[]
							{
								0.341f,
								0.196f,
								0.078f,
								0f
							};
						case 3222:
							return new float[]
							{
								0.286f,
								0.224f,
								0.106f,
								1f
							};
						case 3223:
							return new float[]
							{
								0.678f,
								0.639f,
								0.533f,
								0f
							};
						case 3224:
							return new float[]
							{
								0.271f,
								0.157f,
								0.067f,
								1f
							};
						case 3225:
							return new float[]
							{
								0.251f,
								0.118f,
								0.043f,
								1f
							};
						case 3226:
							return new float[]
							{
								0.475f,
								0.267f,
								0.106f,
								1f
							};
						case 3227:
							return new float[]
							{
								0.267f,
								0.133f,
								0.059f,
								1f
							};
						case 3228:
							return new float[]
							{
								0.4f,
								0.333f,
								0.263f,
								1f
							};
						case 3229:
							return new float[]
							{
								0.816f,
								0.173f,
								0.063f,
								1f
							};
						case 3230:
							return new float[]
							{
								0.333f,
								0.251f,
								0.914f,
								1f
							};
						case 3231:
							return new float[]
							{
								0.482f,
								0.188f,
								0.463f,
								1f
							};
						case 3232:
							return new float[]
							{
								0.302f,
								0.224f,
								0f,
								1f
							};
						case 3235:
							return new float[]
							{
								0.941f,
								0.812f,
								0.173f,
								0f
							};
						case 3237:
							return new float[]
							{
								0.784f,
								0.18f,
								0f,
								1f
							};
						case 3238:
							return new float[]
							{
								0.753f,
								0.416f,
								0.035f,
								1f
							};
						case 3239:
							return new float[]
							{
								0.357f,
								0.424f,
								0.125f,
								1f
							};
						case 3240:
							return new float[]
							{
								0.306f,
								0.306f,
								0.306f,
								0f
							};
						case 3241:
							return new float[]
							{
								0.451f,
								0.361f,
								0.361f,
								1f
							};
						case 3242:
							return new float[]
							{
								0.169f,
								0.804f,
								1f,
								0.812f
							};
						case 3243:
							return new float[]
							{
								0.549f,
								0.02f,
								0.02f,
								0.812f
							};
						case 3244:
							return new float[]
							{
								0.063f,
								0.647f,
								0.027f,
								0.812f
							};
						case 3245:
							return new float[]
							{
								0.22f,
								0.267f,
								0.329f,
								0.812f
							};
						case 3284:
							return new float[]
							{
								0.494f,
								0.412f,
								0.306f,
								1f
							};
						case 3304:
							return new float[]
							{
								1f,
								1f,
								1f,
								1f
							};
						case 3305:
							return new float[]
							{
								0.91f,
								0.91f,
								0.91f,
								1f
							};
						case 3306:
							return new float[]
							{
								0.796f,
								0.659f,
								0.243f,
								1f
							};
						case 3307:
							return new float[]
							{
								1f,
								1f,
								1f,
								0.467f
							};
						case 3309:
							return new float[]
							{
								0.663f,
								0.792f,
								0.965f,
								1f
							};
						case 3310:
							return new float[]
							{
								0.965f,
								0.71f,
								0.663f,
								1f
							};
						case 3311:
							return new float[]
							{
								0.725f,
								0.906f,
								0.722f,
								1f
							};
						case 3312:
							return new float[]
							{
								0.565f,
								0.553f,
								0.525f,
								1f
							};
						case 3313:
							return new float[]
							{
								0.898f,
								0.902f,
								0.839f,
								1f
							};
						case 3314:
							return new float[]
							{
								0.024f,
								0.024f,
								0.024f,
								0.961f
							};
						case 3315:
							return new float[]
							{
								0.22f,
								0.212f,
								0.224f,
								1f
							};
						case 3316:
							return new float[]
							{
								0.455f,
								0.42f,
								0.4f,
								1f
							};
						case 3317:
							return new float[]
							{
								0.58f,
								0.392f,
								0.192f,
								1f
							};
						case 3318:
							return new float[]
							{
								0.329f,
								0.176f,
								0.153f,
								1f
							};
						case 3319:
							return new float[]
							{
								0.443f,
								0.443f,
								0.443f,
								1f
							};
						case 3320:
							return new float[]
							{
								0.471f,
								0.216f,
								0.753f,
								1f
							};
						case 3321:
							return new float[]
							{
								1f,
								0.267f,
								0.267f,
								0.502f
							};
						case 3322:
							return new float[]
							{
								1f,
								0.957f,
								0.522f,
								0.502f
							};
						case 3323:
							return new float[]
							{
								0.522f,
								1f,
								0.549f,
								0.502f
							};
						case 3324:
							return new float[]
							{
								0.522f,
								0.82f,
								1f,
								0.502f
							};
						case 3325:
							return new float[]
							{
								0.757f,
								0.522f,
								1f,
								0.502f
							};
						case 3326:
							return new float[]
							{
								0f,
								0f,
								0f,
								0.502f
							};
						case 3327:
							return new float[]
							{
								0.518f,
								0.298f,
								0.137f,
								1f
							};
						case 3328:
							return new float[]
							{
								0.208f,
								0.149f,
								0.114f,
								1f
							};
						case 3329:
							return new float[]
							{
								0.62f,
								0.325f,
								0.188f,
								0f
							};
						case 3330:
							return new float[]
							{
								0.51f,
								0.337f,
								0.192f,
								1f
							};
						case 3331:
							return new float[]
							{
								0.337f,
								0.694f,
								0.812f,
								0.451f
							};
						case 3332:
							return new float[]
							{
								0.357f,
								0.702f,
								0.808f,
								0.498f
							};
						case 3338:
							return new float[]
							{
								0.714f,
								0.741f,
								0.792f,
								1f
							};
						case 3353:
							return new float[]
							{
								0.839f,
								0.871f,
								0.827f,
								1f
							};
						case 3359:
							return new float[]
							{
								0.443f,
								0.945f,
								0.267f,
								1f
							};
						case 3360:
							return new float[]
							{
								0.698f,
								0.604f,
								0.435f,
								1f
							};
						case 3373:
							return new float[]
							{
								0.11f,
								0f,
								0.082f,
								1f
							};
						case 3374:
							return new float[]
							{
								0.231f,
								0.035f,
								0.137f,
								1f
							};
						case 3375:
							return new float[]
							{
								0.38f,
								0.118f,
								0.184f,
								1f
							};
						case 3376:
							return new float[]
							{
								0.569f,
								0.247f,
								0.255f,
								1f
							};
						case 3377:
							return new float[]
							{
								0.729f,
								0.388f,
								0.31f,
								1f
							};
						case 3378:
							return new float[]
							{
								0.863f,
								0.596f,
								0.384f,
								1f
							};
						case 3379:
							return new float[]
							{
								0.859f,
								0.824f,
								0.745f,
								1f
							};
						case 3380:
							return new float[]
							{
								0.702f,
								0.843f,
								0.282f,
								1f
							};
						case 3381:
							return new float[]
							{
								0.345f,
								0.627f,
								0.196f,
								1f
							};
						case 3382:
							return new float[]
							{
								0.039f,
								0.392f,
								0.192f,
								1f
							};
						case 3383:
							return new float[]
							{
								0.043f,
								0.235f,
								0.263f,
								1f
							};
						case 3384:
							return new float[]
							{
								0.059f,
								0.059f,
								0.059f,
								1f
							};
						case 3385:
							return new float[]
							{
								0.208f,
								0.192f,
								0.239f,
								1f
							};
						case 3386:
							return new float[]
							{
								0.384f,
								0.349f,
								0.412f,
								1f
							};
						case 3387:
							return new float[]
							{
								0.565f,
								0.529f,
								0.6f,
								1f
							};
						case 3388:
							return new float[]
							{
								0.816f,
								0.784f,
								0.867f,
								1f
							};
						case 3389:
							return new float[]
							{
								0.894f,
								0.894f,
								0.894f,
								1f
							};
						case 3390:
							return new float[]
							{
								0.576f,
								0.843f,
								0.894f,
								1f
							};
						case 3391:
							return new float[]
							{
								0.086f,
								0.769f,
								0.894f,
								1f
							};
						case 3392:
							return new float[]
							{
								0.012f,
								0.392f,
								0.733f,
								1f
							};
						case 3393:
							return new float[]
							{
								0f,
								0.149f,
								0.455f,
								1f
							};
						case 3394:
							return new float[]
							{
								0.027f,
								0.016f,
								0.18f,
								1f
							};
						case 3395:
							return new float[]
							{
								0.18f,
								0.102f,
								0.322f,
								1f
							};
						case 3396:
							return new float[]
							{
								0.447f,
								0.145f,
								0.561f,
								1f
							};
						case 3397:
							return new float[]
							{
								0.776f,
								0.275f,
								0.612f,
								1f
							};
						case 3398:
							return new float[]
							{
								0.843f,
								0.678f,
								0.835f,
								1f
							};
						case 3399:
							return new float[]
							{
								0.859f,
								0.682f,
								0.208f,
								1f
							};
						case 3400:
							return new float[]
							{
								0.843f,
								0.416f,
								0.129f,
								1f
							};
						case 3401:
							return new float[]
							{
								0.843f,
								0.145f,
								0.102f,
								1f
							};
						case 3402:
							return new float[]
							{
								0.612f,
								0.075f,
								0.118f,
								1f
							};
						case 3403:
							return new float[]
							{
								0.384f,
								0.349f,
								0.62f,
								1f
							};
						case 3404:
							return new float[]
							{
								0.129f,
								0.2f,
								0.38f,
								1f
							};
						case 3405:
							return new float[]
							{
								0.122f,
								0f,
								0.09f,
								1f
							};
						case 3406:
							return new float[]
							{
								0.259f,
								0.039f,
								0.153f,
								1f
							};
						case 3407:
							return new float[]
							{
								0.424f,
								0.129f,
								0.208f,
								1f
							};
						case 3408:
							return new float[]
							{
								0.635f,
								0.275f,
								0.286f,
								1f
							};
						case 3409:
							return new float[]
							{
								0.816f,
								0.435f,
								0.345f,
								1f
							};
						case 3410:
							return new float[]
							{
								0.965f,
								0.667f,
								0.431f,
								1f
							};
						case 3411:
							return new float[]
							{
								0.961f,
								0.922f,
								0.831f,
								1f
							};
						case 3412:
							return new float[]
							{
								0.784f,
								0.945f,
								0.318f,
								1f
							};
						case 3413:
							return new float[]
							{
								0.384f,
								0.702f,
								0.22f,
								1f
							};
						case 3414:
							return new float[]
							{
								0.043f,
								0.439f,
								0.216f,
								1f
							};
						case 3415:
							return new float[]
							{
								0.047f,
								0.263f,
								0.294f,
								1f
							};
						case 3416:
							return new float[]
							{
								0.02f,
								0.02f,
								0.02f,
								1f
							};
						case 3417:
							return new float[]
							{
								0.231f,
								0.216f,
								0.267f,
								1f
							};
						case 3418:
							return new float[]
							{
								0.431f,
								0.392f,
								0.459f,
								1f
							};
						case 3419:
							return new float[]
							{
								0.631f,
								0.592f,
								0.671f,
								1f
							};
						case 3420:
							return new float[]
							{
								0.914f,
								0.878f,
								0.969f,
								1f
							};
						case 3421:
							return new float[]
							{
								1f,
								1f,
								1f,
								1f
							};
						case 3422:
							return new float[]
							{
								0.643f,
								0.945f,
								1f,
								1f
							};
						case 3423:
							return new float[]
							{
								0.098f,
								0.859f,
								1f,
								1f
							};
						case 3424:
							return new float[]
							{
								0.012f,
								0.439f,
								0.82f,
								1f
							};
						case 3425:
							return new float[]
							{
								0f,
								0.165f,
								0.51f,
								1f
							};
						case 3426:
							return new float[]
							{
								0.031f,
								0.02f,
								0.2f,
								1f
							};
						case 3427:
							return new float[]
							{
								0.2f,
								0.114f,
								0.361f,
								1f
							};
						case 3428:
							return new float[]
							{
								0.502f,
								0.161f,
								0.627f,
								1f
							};
						case 3429:
							return new float[]
							{
								0.871f,
								0.306f,
								0.682f,
								1f
							};
						case 3430:
							return new float[]
							{
								0.941f,
								0.757f,
								0.933f,
								1f
							};
						case 3431:
							return new float[]
							{
								0.961f,
								0.765f,
								0.231f,
								1f
							};
						case 3432:
							return new float[]
							{
								0.945f,
								0.463f,
								0.145f,
								1f
							};
						case 3433:
							return new float[]
							{
								0.941f,
								0.161f,
								0.114f,
								1f
							};
						case 3434:
							return new float[]
							{
								0.682f,
								0.082f,
								0.133f,
								1f
							};
						case 3435:
							return new float[]
							{
								0.431f,
								0.392f,
								0.694f,
								1f
							};
						case 3436:
							return new float[]
							{
								0.145f,
								0.224f,
								0.424f,
								1f
							};
						case 3437:
							return new float[]
							{
								0.141f,
								0.141f,
								0.145f,
								1f
							};
						case 3438:
							return new float[]
							{
								0.659f,
								0f,
								1f,
								1f
							};
						case 3441:
							return new float[]
							{
								0.067f,
								0.067f,
								0.118f,
								0.961f
							};
						case 3453:
							return new float[]
							{
								0.855f,
								0.388f,
								0f,
								1f
							};
						case 3466:
							return new float[]
							{
								0.098f,
								0.129f,
								0.157f,
								1f
							};
						default:
							if (A_0 == 3503)
							{
								return new float[]
								{
									0.373f,
									0.196f,
									0.086f,
									1f
								};
							}
							break;
						}
					}
					else
					{
						if (A_0 == 3526)
						{
							return new float[]
							{
								1f,
								0.765f,
								0.012f,
								1f
							};
						}
						if (A_0 == 3532)
						{
							return new float[]
							{
								0.792f,
								0.863f,
								1f,
								1f
							};
						}
					}
				}
				else if (A_0 <= 3756)
				{
					if (A_0 == 3533)
					{
						return new float[]
						{
							0.176f,
							0.188f,
							0.235f,
							1f
						};
					}
					switch (A_0)
					{
					case 3595:
						return new float[]
						{
							0.204f,
							0.855f,
							1f,
							1f
						};
					case 3596:
						return new float[]
						{
							0.227f,
							0.263f,
							0.286f,
							1f
						};
					case 3600:
						return new float[]
						{
							0.659f,
							0f,
							1f,
							1f
						};
					case 3601:
						return new float[]
						{
							0.659f,
							0f,
							1f,
							1f
						};
					case 3604:
						return new float[]
						{
							0.071f,
							0.071f,
							0.071f,
							1f
						};
					case 3605:
						return new float[]
						{
							0.42f,
							0.212f,
							0.086f,
							1f
						};
					case 3606:
						return new float[]
						{
							0.337f,
							0.145f,
							0.031f,
							1f
						};
					case 3609:
						return new float[]
						{
							1f,
							1f,
							1f,
							1f
						};
					case 3611:
						return new float[]
						{
							0.969f,
							0.737f,
							0.424f,
							1f
						};
					case 3612:
						return new float[]
						{
							0.69f,
							0.294f,
							0f,
							1f
						};
					case 3624:
						return new float[]
						{
							0.925f,
							0.545f,
							0.094f,
							1f
						};
					case 3635:
						return new float[]
						{
							0.035f,
							0.322f,
							0.584f,
							1f
						};
					case 3636:
						return new float[]
						{
							0.404f,
							0.404f,
							0.404f,
							1f
						};
					case 3637:
						return new float[]
						{
							0f,
							0.325f,
							0.855f,
							1f
						};
					case 3638:
						return new float[]
						{
							0.11f,
							0f,
							0.004f,
							1f
						};
					case 3639:
						return new float[]
						{
							0.165f,
							0.016f,
							0.035f,
							1f
						};
					case 3645:
						return new float[]
						{
							0.78f,
							0.357f,
							0.063f,
							1f
						};
					case 3647:
						return new float[]
						{
							0.596f,
							0.008f,
							0.008f,
							1f
						};
					case 3648:
						return new float[]
						{
							1f,
							0.667f,
							0.906f,
							0.878f
						};
					case 3651:
						return new float[]
						{
							1f,
							0f,
							0f,
							1f
						};
					case 3652:
						return new float[]
						{
							1f,
							0.835f,
							0.835f,
							1f
						};
					case 3686:
						return new float[]
						{
							0.431f,
							0.561f,
							0.596f,
							1f
						};
					case 3692:
						return new float[]
						{
							0.129f,
							0.118f,
							0.149f,
							1f
						};
					case 3693:
						return new float[]
						{
							0.878f,
							0.4f,
							0.373f,
							1f
						};
					case 3694:
						return new float[]
						{
							0.659f,
							0f,
							1f,
							1f
						};
					case 3695:
						return new float[]
						{
							0.4f,
							0.196f,
							0.031f,
							1f
						};
					case 3696:
						return new float[]
						{
							0.392f,
							0.051f,
							0.078f,
							1f
						};
					case 3697:
						return new float[]
						{
							0.161f,
							0.545f,
							0.894f,
							1f
						};
					case 3698:
						return new float[]
						{
							0f,
							0.29f,
							0.549f,
							1f
						};
					case 3699:
						return new float[]
						{
							0.149f,
							0.549f,
							0.141f,
							1f
						};
					case 3700:
						return new float[]
						{
							0.012f,
							0.435f,
							0f,
							1f
						};
					case 3701:
						return new float[]
						{
							0.529f,
							0.259f,
							0.043f,
							1f
						};
					case 3702:
						return new float[]
						{
							0.659f,
							0.373f,
							0.145f,
							1f
						};
					case 3703:
						return new float[]
						{
							0.145f,
							0.133f,
							0.165f,
							1f
						};
					case 3704:
						return new float[]
						{
							0.98f,
							0.447f,
							0.416f,
							1f
						};
					case 3705:
						return new float[]
						{
							0.337f,
							0.165f,
							0.027f,
							1f
						};
					case 3706:
						return new float[]
						{
							0.447f,
							0.22f,
							0.035f,
							1f
						};
					case 3707:
						return new float[]
						{
							0.439f,
							0.055f,
							0.086f,
							1f
						};
					case 3708:
						return new float[]
						{
							0.18f,
							0.608f,
							1f,
							1f
						};
					case 3709:
						return new float[]
						{
							0f,
							0.325f,
							0.616f,
							1f
						};
					case 3710:
						return new float[]
						{
							0.169f,
							0.616f,
							0.157f,
							1f
						};
					case 3711:
						return new float[]
						{
							0.012f,
							0.486f,
							0f,
							1f
						};
					case 3712:
						return new float[]
						{
							0.592f,
							0.29f,
							0.047f,
							1f
						};
					case 3713:
						return new float[]
						{
							0.737f,
							0.416f,
							0.161f,
							1f
						};
					case 3714:
						return new float[]
						{
							0.11f,
							0f,
							0.082f,
							1f
						};
					case 3715:
						return new float[]
						{
							0.231f,
							0.035f,
							0.137f,
							1f
						};
					case 3716:
						return new float[]
						{
							0.38f,
							0.118f,
							0.184f,
							1f
						};
					case 3717:
						return new float[]
						{
							0.569f,
							0.247f,
							0.255f,
							1f
						};
					case 3718:
						return new float[]
						{
							0.729f,
							0.388f,
							0.31f,
							1f
						};
					case 3719:
						return new float[]
						{
							0.863f,
							0.596f,
							0.384f,
							1f
						};
					case 3720:
						return new float[]
						{
							0.859f,
							0.824f,
							0.745f,
							1f
						};
					case 3721:
						return new float[]
						{
							0.702f,
							0.843f,
							0.282f,
							1f
						};
					case 3722:
						return new float[]
						{
							0.345f,
							0.627f,
							0.196f,
							1f
						};
					case 3723:
						return new float[]
						{
							0.039f,
							0.392f,
							0.192f,
							1f
						};
					case 3724:
						return new float[]
						{
							0.043f,
							0.235f,
							0.263f,
							1f
						};
					case 3725:
						return new float[]
						{
							0.059f,
							0.059f,
							0.059f,
							1f
						};
					case 3726:
						return new float[]
						{
							0.208f,
							0.192f,
							0.239f,
							1f
						};
					case 3727:
						return new float[]
						{
							0.384f,
							0.349f,
							0.412f,
							1f
						};
					case 3728:
						return new float[]
						{
							0.565f,
							0.529f,
							0.6f,
							1f
						};
					case 3729:
						return new float[]
						{
							0.816f,
							0.784f,
							0.867f,
							1f
						};
					case 3730:
						return new float[]
						{
							0.894f,
							0.894f,
							0.894f,
							1f
						};
					case 3731:
						return new float[]
						{
							0.576f,
							0.843f,
							0.894f,
							1f
						};
					case 3732:
						return new float[]
						{
							0.086f,
							0.769f,
							0.894f,
							1f
						};
					case 3733:
						return new float[]
						{
							0.012f,
							0.392f,
							0.733f,
							1f
						};
					case 3734:
						return new float[]
						{
							0f,
							0.149f,
							0.455f,
							1f
						};
					case 3735:
						return new float[]
						{
							0.027f,
							0.016f,
							0.18f,
							1f
						};
					case 3736:
						return new float[]
						{
							0.18f,
							0.102f,
							0.322f,
							1f
						};
					case 3737:
						return new float[]
						{
							0.447f,
							0.145f,
							0.561f,
							1f
						};
					case 3738:
						return new float[]
						{
							0.776f,
							0.275f,
							0.612f,
							1f
						};
					case 3739:
						return new float[]
						{
							0.843f,
							0.678f,
							0.835f,
							1f
						};
					case 3740:
						return new float[]
						{
							0.859f,
							0.682f,
							0.208f,
							1f
						};
					case 3741:
						return new float[]
						{
							0.843f,
							0.416f,
							0.129f,
							1f
						};
					case 3742:
						return new float[]
						{
							0.843f,
							0.145f,
							0.102f,
							1f
						};
					case 3743:
						return new float[]
						{
							0.612f,
							0.075f,
							0.118f,
							1f
						};
					case 3744:
						return new float[]
						{
							0.384f,
							0.349f,
							0.62f,
							1f
						};
					case 3745:
						return new float[]
						{
							0.129f,
							0.2f,
							0.38f,
							1f
						};
					case 3746:
						return new float[]
						{
							0.129f,
							0.118f,
							0.149f,
							1f
						};
					case 3747:
						return new float[]
						{
							0.878f,
							0.4f,
							0.373f,
							1f
						};
					case 3748:
						return new float[]
						{
							0.302f,
							0.149f,
							0.024f,
							1f
						};
					case 3749:
						return new float[]
						{
							0.4f,
							0.196f,
							0.031f,
							1f
						};
					case 3750:
						return new float[]
						{
							0.392f,
							0.051f,
							0.078f,
							1f
						};
					case 3751:
						return new float[]
						{
							0.161f,
							0.545f,
							0.894f,
							1f
						};
					case 3752:
						return new float[]
						{
							0f,
							0.29f,
							0.549f,
							1f
						};
					case 3753:
						return new float[]
						{
							0.149f,
							0.549f,
							0.141f,
							1f
						};
					case 3754:
						return new float[]
						{
							0.012f,
							0.435f,
							0f,
							1f
						};
					case 3755:
						return new float[]
						{
							0.529f,
							0.259f,
							0.043f,
							1f
						};
					case 3756:
						return new float[]
						{
							0.659f,
							0.373f,
							0.145f,
							1f
						};
					}
				}
				else
				{
					if (A_0 == 3774)
					{
						return new float[]
						{
							0.953f,
							0.808f,
							0.494f,
							1f
						};
					}
					if (A_0 == 3779)
					{
						return new float[]
						{
							0.435f,
							0f,
							0.149f,
							1f
						};
					}
				}
			}
			else if (A_0 <= 4419)
			{
				if (A_0 <= 4281)
				{
					if (A_0 <= 4051)
					{
						if (A_0 <= 3817)
						{
							if (A_0 == 3804)
							{
								return new float[]
								{
									0.592f,
									0.592f,
									0.592f,
									1f
								};
							}
							if (A_0 == 3817)
							{
								return new float[]
								{
									0.545f,
									0.337f,
									0.043f,
									0f
								};
							}
						}
						else
						{
							switch (A_0)
							{
							case 3822:
								return new float[]
								{
									0.416f,
									0.518f,
									0.467f,
									1f
								};
							case 3823:
								return new float[]
								{
									0.416f,
									0.518f,
									0.467f,
									1f
								};
							case 3824:
								return new float[]
								{
									0.157f,
									0.224f,
									0.2f,
									1f
								};
							default:
								switch (A_0)
								{
								case 3855:
									return new float[]
									{
										0.6f,
										0.545f,
										0.553f,
										1f
									};
								case 3856:
									return new float[]
									{
										0.561f,
										0.212f,
										0f,
										1f
									};
								case 3857:
									return new float[]
									{
										0.588f,
										0.588f,
										0.588f,
										1f
									};
								case 3858:
									return new float[]
									{
										0.871f,
										0.157f,
										0.537f,
										1f
									};
								case 3859:
									return new float[]
									{
										0.427f,
										0.796f,
										1f,
										0f
									};
								case 3860:
									return new float[]
									{
										0.773f,
										0.62f,
										0.941f,
										1f
									};
								case 3861:
									return new float[]
									{
										1f,
										0.196f,
										0.235f,
										0f
									};
								case 3862:
									return new float[]
									{
										0.486f,
										0.859f,
										0.812f,
										1f
									};
								case 3863:
									return new float[]
									{
										1f,
										1f,
										1f,
										0f
									};
								case 3864:
									return new float[]
									{
										1f,
										1f,
										1f,
										0f
									};
								case 3865:
									return new float[]
									{
										1f,
										1f,
										1f,
										0f
									};
								case 3889:
									return new float[]
									{
										0.682f,
										0.902f,
										1f,
										1f
									};
								case 3923:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3924:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3925:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3926:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3927:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3928:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3929:
									return new float[]
									{
										0.294f,
										0.141f,
										0.137f,
										1f
									};
								case 3930:
									return new float[]
									{
										0.118f,
										0.039f,
										0.039f,
										1f
									};
								case 3931:
									return new float[]
									{
										0.192f,
										0.078f,
										0.075f,
										1f
									};
								case 3932:
									return new float[]
									{
										0.192f,
										0.078f,
										0.075f,
										1f
									};
								case 3933:
									return new float[]
									{
										0.231f,
										0.098f,
										0.094f,
										1f
									};
								case 3934:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3935:
									return new float[]
									{
										0.231f,
										0.098f,
										0.094f,
										1f
									};
								case 3936:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3937:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3938:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3939:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3940:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3941:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3942:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3943:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3944:
									return new float[]
									{
										0.275f,
										0.125f,
										0.122f,
										1f
									};
								case 3945:
									return new float[]
									{
										0.298f,
										0.161f,
										0.161f,
										1f
									};
								case 3946:
									return new float[]
									{
										0.129f,
										0.082f,
										0.059f,
										1f
									};
								case 3948:
									return new float[]
									{
										0.129f,
										0.082f,
										0.059f,
										1f
									};
								case 3949:
									return new float[]
									{
										0.976f,
										0.89f,
										0.675f,
										1f
									};
								case 3950:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3951:
									return new float[]
									{
										0.18f,
										0.071f,
										0.02f,
										0f
									};
								case 3952:
									return new float[]
									{
										0.604f,
										0.42f,
										0.294f,
										0f
									};
								case 3953:
									return new float[]
									{
										0.808f,
										0.541f,
										0.349f,
										1f
									};
								case 3954:
									return new float[]
									{
										0.878f,
										0.6f,
										0.392f,
										1f
									};
								case 3955:
									return new float[]
									{
										0.392f,
										0.22f,
										0.125f,
										1f
									};
								case 3956:
									return new float[]
									{
										0.933f,
										0.678f,
										0.478f,
										1f
									};
								case 3957:
									return new float[]
									{
										0.22f,
										0.22f,
										0.22f,
										0f
									};
								case 3958:
									return new float[]
									{
										0.906f,
										0.639f,
										0.388f,
										1f
									};
								case 3959:
									return new float[]
									{
										0.745f,
										0.525f,
										0.318f,
										1f
									};
								case 3960:
									return new float[]
									{
										0.031f,
										0.318f,
										0.031f,
										1f
									};
								case 3961:
									return new float[]
									{
										0.463f,
										0.431f,
										0.416f,
										1f
									};
								case 3962:
									return new float[]
									{
										1f,
										0.565f,
										0f,
										1f
									};
								case 3963:
									return new float[]
									{
										1f,
										1f,
										1f,
										1f
									};
								case 3968:
									return new float[]
									{
										0.631f,
										0.663f,
										0.682f,
										1f
									};
								case 3980:
									return new float[]
									{
										0.486f,
										0.188f,
										0.075f,
										1f
									};
								case 3981:
									return new float[]
									{
										0.486f,
										0.188f,
										0.075f,
										1f
									};
								case 3982:
									return new float[]
									{
										0.486f,
										0.188f,
										0.075f,
										1f
									};
								case 3983:
									return new float[]
									{
										0.486f,
										0.188f,
										0.075f,
										1f
									};
								case 3984:
									return new float[]
									{
										0.486f,
										0.188f,
										0.075f,
										1f
									};
								case 3985:
									return new float[]
									{
										0.584f,
										0.506f,
										0.467f,
										1f
									};
								case 3986:
									return new float[]
									{
										0.451f,
										0.388f,
										0.357f,
										1f
									};
								case 3988:
									return new float[]
									{
										0.231f,
										0.2f,
										0.184f,
										1f
									};
								case 3989:
									return new float[]
									{
										0.459f,
										0.278f,
										0.161f,
										1f
									};
								case 3990:
									return new float[]
									{
										0.035f,
										0.027f,
										0.024f,
										1f
									};
								case 3992:
									return new float[]
									{
										0.514f,
										0.431f,
										0.388f,
										1f
									};
								case 3993:
									return new float[]
									{
										0.282f,
										0.243f,
										0.227f,
										1f
									};
								case 3994:
									return new float[]
									{
										0.506f,
										0.224f,
										0.094f,
										1f
									};
								case 4004:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4005:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4006:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4007:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4008:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4009:
									return new float[]
									{
										0f,
										0f,
										0f,
										1f
									};
								case 4010:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4011:
									return new float[]
									{
										0f,
										0.043f,
										0.114f,
										1f
									};
								case 4012:
									return new float[]
									{
										0.404f,
										0.871f,
										1f,
										1f
									};
								case 4013:
									return new float[]
									{
										0.51f,
										1f,
										1f,
										1f
									};
								case 4014:
									return new float[]
									{
										0.51f,
										1f,
										1f,
										1f
									};
								case 4015:
									return new float[]
									{
										0.51f,
										1f,
										1f,
										1f
									};
								case 4016:
									return new float[]
									{
										0.51f,
										1f,
										1f,
										1f
									};
								case 4017:
									return new float[]
									{
										0.047f,
										0.71f,
										0.408f,
										1f
									};
								case 4018:
									return new float[]
									{
										0.239f,
										0.824f,
										0.557f,
										1f
									};
								case 4019:
									return new float[]
									{
										0.239f,
										0.824f,
										0.557f,
										1f
									};
								case 4020:
									return new float[]
									{
										0.239f,
										0.824f,
										0.557f,
										1f
									};
								case 4021:
									return new float[]
									{
										0.239f,
										0.824f,
										0.557f,
										1f
									};
								case 4032:
									return new float[]
									{
										0.741f,
										0f,
										0f,
										1f
									};
								case 4033:
									return new float[]
									{
										0.741f,
										0f,
										0f,
										1f
									};
								case 4034:
									return new float[]
									{
										0.741f,
										0f,
										0f,
										1f
									};
								case 4035:
									return new float[]
									{
										0.741f,
										0f,
										0f,
										1f
									};
								case 4036:
									return new float[]
									{
										0.741f,
										0f,
										0f,
										1f
									};
								case 4037:
									return new float[]
									{
										0f,
										0.333f,
										0.996f,
										1f
									};
								case 4038:
									return new float[]
									{
										0.102f,
										0.4f,
										0.996f,
										1f
									};
								case 4039:
									return new float[]
									{
										0.102f,
										0.4f,
										0.996f,
										1f
									};
								case 4040:
									return new float[]
									{
										0.102f,
										0.4f,
										0.996f,
										1f
									};
								case 4041:
									return new float[]
									{
										0.102f,
										0.4f,
										0.996f,
										1f
									};
								case 4047:
									return new float[]
									{
										1f,
										0.643f,
										0.349f,
										1f
									};
								case 4048:
									return new float[]
									{
										1f,
										0.643f,
										0.349f,
										1f
									};
								case 4049:
									return new float[]
									{
										1f,
										0.643f,
										0.349f,
										1f
									};
								case 4050:
									return new float[]
									{
										1f,
										0.643f,
										0.349f,
										1f
									};
								case 4051:
									return new float[]
									{
										1f,
										0.643f,
										0.349f,
										1f
									};
								}
								break;
							}
						}
					}
					else if (A_0 <= 4169)
					{
						if (A_0 == 4085)
						{
							return new float[]
							{
								0.431f,
								0.463f,
								0.6f,
								1f
							};
						}
						switch (A_0)
						{
						case 4130:
							return new float[]
							{
								0.243f,
								0.176f,
								0.129f,
								1f
							};
						case 4131:
							return new float[]
							{
								0.412f,
								0.325f,
								0.286f,
								1f
							};
						case 4132:
							return new float[]
							{
								0.349f,
								0.294f,
								0.263f,
								0f
							};
						case 4133:
							return new float[]
							{
								0.475f,
								0.333f,
								0.196f,
								1f
							};
						case 4134:
							return new float[]
							{
								0.627f,
								0.541f,
								0.392f,
								1f
							};
						case 4135:
							return new float[]
							{
								0.702f,
								0.094f,
								0.051f,
								1f
							};
						case 4136:
							return new float[]
							{
								0.725f,
								0.686f,
								0.663f,
								1f
							};
						case 4137:
							return new float[]
							{
								0.898f,
								0.729f,
								0.282f,
								1f
							};
						case 4138:
							return new float[]
							{
								0.604f,
								0.643f,
								0.659f,
								1f
							};
						case 4139:
							return new float[]
							{
								0.788f,
								0.776f,
								0.569f,
								1f
							};
						case 4145:
							return new float[]
							{
								0.565f,
								0.424f,
								0.361f,
								1f
							};
						case 4146:
							return new float[]
							{
								0.333f,
								0.275f,
								0.247f,
								1f
							};
						case 4147:
							return new float[]
							{
								0.247f,
								0.161f,
								0.11f,
								1f
							};
						case 4148:
							return new float[]
							{
								0.373f,
								0.267f,
								0.231f,
								1f
							};
						case 4149:
							return new float[]
							{
								0.361f,
								0.22f,
								0.129f,
								1f
							};
						case 4150:
							return new float[]
							{
								0.212f,
								0.125f,
								0.078f,
								1f
							};
						case 4154:
							return new float[]
							{
								0.694f,
								0.38f,
								0.137f,
								1f
							};
						case 4155:
							return new float[]
							{
								0.643f,
								0.643f,
								0.643f,
								1f
							};
						case 4156:
							return new float[]
							{
								1f,
								0.745f,
								0f,
								1f
							};
						case 4157:
							return new float[]
							{
								0.686f,
								0.792f,
								0.863f,
								1f
							};
						case 4162:
							return new float[]
							{
								0.302f,
								0f,
								0.835f,
								1f
							};
						case 4169:
							return new float[]
							{
								0.808f,
								0f,
								0f,
								1f
							};
						}
					}
					else
					{
						switch (A_0)
						{
						case 4249:
							return new float[]
							{
								0.227f,
								0.227f,
								0.357f,
								1f
							};
						case 4250:
						case 4251:
						case 4252:
						case 4255:
						case 4258:
						case 4259:
							break;
						case 4253:
							return new float[4];
						case 4254:
							return new float[]
							{
								0.282f,
								0.325f,
								0.471f,
								1f
							};
						case 4256:
							return new float[]
							{
								0.231f,
								0.188f,
								0.4f,
								1f
							};
						case 4257:
							return new float[]
							{
								0.522f,
								0.678f,
								0.808f,
								1f
							};
						case 4260:
							return new float[]
							{
								0.157f,
								0.204f,
								0.286f,
								1f
							};
						case 4261:
							return new float[]
							{
								0.38f,
								0.792f,
								1f,
								0.329f
							};
						case 4262:
							return new float[]
							{
								0.082f,
								0.082f,
								0.082f,
								1f
							};
						default:
							switch (A_0)
							{
							case 4275:
								return new float[]
								{
									0.965f,
									0.933f,
									0.878f,
									0f
								};
							case 4277:
								return new float[]
								{
									0.663f,
									0.6f,
									0.545f,
									1f
								};
							case 4278:
								return new float[]
								{
									0.741f,
									0.427f,
									1f,
									1f
								};
							case 4281:
								return new float[]
								{
									0.255f,
									0.063f,
									0.184f,
									1f
								};
							}
							break;
						}
					}
				}
				else if (A_0 <= 4378)
				{
					if (A_0 <= 4368)
					{
						switch (A_0)
						{
						case 4285:
							return new float[]
							{
								0.2f,
								0.231f,
								0.259f,
								1f
							};
						case 4286:
							return new float[]
							{
								1f,
								1f,
								1f,
								1f
							};
						case 4287:
							break;
						case 4288:
							return new float[]
							{
								0.2f,
								0.345f,
								0.463f,
								0f
							};
						default:
							switch (A_0)
							{
							case 4366:
								return new float[]
								{
									0.149f,
									0.478f,
									0.847f,
									0.898f
								};
							case 4367:
								return new float[]
								{
									0.176f,
									0.294f,
									0.537f,
									1f
								};
							case 4368:
								return new float[]
								{
									0.439f,
									0.714f,
									0.973f,
									1f
								};
							}
							break;
						}
					}
					else
					{
						if (A_0 == 4373)
						{
							return new float[]
							{
								1f,
								0.749f,
								1f,
								1f
							};
						}
						if (A_0 == 4378)
						{
							return new float[]
							{
								0.278f,
								0.576f,
								0.843f,
								1f
							};
						}
					}
				}
				else if (A_0 <= 4399)
				{
					if (A_0 == 4392)
					{
						return new float[]
						{
							1f,
							1f,
							1f,
							1f
						};
					}
					if (A_0 == 4399)
					{
						return new float[]
						{
							1f,
							1f,
							1f,
							1f
						};
					}
				}
				else
				{
					if (A_0 == 4417)
					{
						return new float[]
						{
							0f,
							0.494f,
							1f,
							0.804f
						};
					}
					if (A_0 == 4419)
					{
						return new float[]
						{
							0.937f,
							0.122f,
							0.122f,
							1f
						};
					}
				}
			}
			else if (A_0 <= 4585)
			{
				if (A_0 <= 4563)
				{
					if (A_0 <= 4491)
					{
						if (A_0 == 4423)
						{
							return new float[]
							{
								0.059f,
								0.306f,
								0.337f,
								1f
							};
						}
						switch (A_0)
						{
						case 4459:
							return new float[]
							{
								0.855f,
								0.91f,
								0.933f,
								1f
							};
						case 4460:
							return new float[]
							{
								0.451f,
								0.573f,
								0.588f,
								1f
							};
						case 4461:
							return new float[]
							{
								0.843f,
								0.914f,
								0.953f,
								1f
							};
						case 4462:
							return new float[]
							{
								0.31f,
								0.31f,
								0.275f,
								1f
							};
						case 4463:
							return new float[]
							{
								0.969f,
								0.969f,
								0.969f,
								1f
							};
						case 4464:
							return new float[]
							{
								0.859f,
								0.945f,
								0.988f,
								0f
							};
						case 4465:
							return new float[]
							{
								0.325f,
								0.475f,
								0.518f,
								1f
							};
						case 4466:
							return new float[]
							{
								0.224f,
								0.31f,
								0.549f,
								1f
							};
						case 4467:
							return new float[]
							{
								0.224f,
								0.349f,
								0.565f,
								1f
							};
						case 4468:
							return new float[]
							{
								0.224f,
								0.349f,
								0.565f,
								1f
							};
						case 4469:
							return new float[]
							{
								0.361f,
								0.361f,
								0.506f,
								1f
							};
						case 4470:
							return new float[]
							{
								0.757f,
								0.969f,
								1f,
								1f
							};
						case 4474:
							return new float[]
							{
								0.161f,
								0.161f,
								0.161f,
								1f
							};
						case 4486:
							return new float[]
							{
								0.039f,
								0f,
								0.035f,
								1f
							};
						case 4487:
							return new float[]
							{
								0.882f,
								0.063f,
								0.765f,
								0.392f
							};
						case 4488:
							return new float[]
							{
								0.063f,
								0.09f,
								0.118f,
								1f
							};
						case 4491:
							return new float[]
							{
								0f,
								0f,
								0f,
								1f
							};
						}
					}
					else
					{
						switch (A_0)
						{
						case 4503:
							return new float[]
							{
								0.259f,
								0.259f,
								0.259f,
								1f
							};
						case 4504:
						case 4505:
						case 4506:
						case 4507:
						case 4508:
						case 4509:
						case 4510:
						case 4511:
						case 4512:
						case 4513:
						case 4514:
						case 4515:
						case 4516:
						case 4517:
						case 4518:
						case 4519:
						case 4520:
						case 4521:
						case 4522:
						case 4523:
						case 4524:
						case 4539:
						case 4545:
						case 4551:
							break;
						case 4525:
							return new float[]
							{
								0.373f,
								0.373f,
								0.373f,
								1f
							};
						case 4526:
							return new float[]
							{
								0.039f,
								0.545f,
								0.898f,
								1f
							};
						case 4527:
							return new float[]
							{
								0f,
								0.906f,
								1f,
								1f
							};
						case 4528:
							return new float[]
							{
								0.812f,
								0.933f,
								0f,
								1f
							};
						case 4529:
							return new float[]
							{
								1f,
								0.698f,
								0.318f,
								1f
							};
						case 4530:
							return new float[]
							{
								0.957f,
								0.329f,
								0.318f,
								1f
							};
						case 4531:
							return new float[]
							{
								0.471f,
								0.847f,
								0.749f,
								1f
							};
						case 4532:
							return new float[]
							{
								0.82f,
								0.2f,
								0.957f,
								1f
							};
						case 4533:
							return new float[]
							{
								0.933f,
								0.957f,
								0.973f,
								1f
							};
						case 4534:
							return new float[]
							{
								0.957f,
								0.863f,
								0.318f,
								1f
							};
						case 4535:
							return new float[]
							{
								0.255f,
								0.788f,
								0.651f,
								1f
							};
						case 4536:
							return new float[]
							{
								0.239f,
								1f,
								0.651f,
								1f
							};
						case 4537:
							return new float[]
							{
								1f,
								0.8f,
								0.251f,
								1f
							};
						case 4538:
							return new float[]
							{
								0.886f,
								0.345f,
								0.996f,
								1f
							};
						case 4540:
						{
							float[] array18 = new float[4];
							array18[0] = 0.18f;
							array18[1] = 0.537f;
							return array18;
						}
						case 4541:
							return new float[]
							{
								0.059f,
								0.322f,
								0.012f,
								1f
							};
						case 4542:
							return new float[]
							{
								0.725f,
								0.725f,
								0.725f,
								1f
							};
						case 4543:
							return new float[]
							{
								1f,
								0.796f,
								0.212f,
								1f
							};
						case 4544:
							return new float[]
							{
								1f,
								0f,
								0f,
								0.463f
							};
						case 4546:
							return new float[]
							{
								0.698f,
								0f,
								0f,
								1f
							};
						case 4547:
							return new float[]
							{
								0.855f,
								0.824f,
								0.8f,
								1f
							};
						case 4548:
							return new float[]
							{
								0.714f,
								0.42f,
								0.227f,
								1f
							};
						case 4549:
							return new float[]
							{
								0.624f,
								0.624f,
								0.624f,
								1f
							};
						case 4550:
							return new float[]
							{
								0.831f,
								0.816f,
								0.835f,
								1f
							};
						case 4552:
							return new float[]
							{
								0.725f,
								0.502f,
								0.855f,
								1f
							};
						default:
							switch (A_0)
							{
							case 4561:
								return new float[]
								{
									0.776f,
									0.776f,
									0.776f,
									1f
								};
							case 4562:
								return new float[]
								{
									0.055f,
									0.047f,
									0.039f,
									1f
								};
							case 4563:
								return new float[]
								{
									0.278f,
									0.31f,
									0.392f,
									1f
								};
							}
							break;
						}
					}
				}
				else if (A_0 <= 4574)
				{
					if (A_0 == 4573)
					{
						return new float[]
						{
							0f,
							0.82f,
							0f,
							1f
						};
					}
					if (A_0 == 4574)
					{
						return new float[]
						{
							0.902f,
							0f,
							0.631f,
							1f
						};
					}
				}
				else
				{
					if (A_0 == 4584)
					{
						return new float[]
						{
							0.925f,
							0.651f,
							0.302f,
							1f
						};
					}
					if (A_0 == 4585)
					{
						return new float[]
						{
							0.878f,
							0.576f,
							0.459f,
							1f
						};
					}
				}
			}
			else if (A_0 <= 4705)
			{
				if (A_0 <= 4593)
				{
					if (A_0 == 4592)
					{
						return new float[]
						{
							1f,
							0.616f,
							0f,
							1f
						};
					}
					if (A_0 == 4593)
					{
						return new float[]
						{
							0.129f,
							0.169f,
							0.2f,
							1f
						};
					}
				}
				else
				{
					switch (A_0)
					{
					case 4614:
						return new float[]
						{
							0.667f,
							0.314f,
							0.157f,
							1f
						};
					case 4615:
						return new float[]
						{
							0.192f,
							0.192f,
							0.192f,
							1f
						};
					case 4616:
						return new float[]
						{
							1f,
							0.91f,
							0f,
							1f
						};
					case 4617:
					case 4618:
					case 4621:
						break;
					case 4619:
						return new float[]
						{
							0.718f,
							0.725f,
							0.757f,
							1f
						};
					case 4620:
						return new float[]
						{
							0.804f,
							0.855f,
							0.882f,
							0.796f
						};
					case 4622:
						return new float[]
						{
							0.486f,
							0.298f,
							0.051f,
							0f
						};
					case 4623:
						return new float[]
						{
							0.125f,
							0.102f,
							0.027f,
							0.906f
						};
					case 4624:
						return new float[]
						{
							0.239f,
							0.2f,
							0.051f,
							0.906f
						};
					case 4625:
						return new float[]
						{
							0.675f,
							0.663f,
							0.651f,
							1f
						};
					case 4626:
						return new float[]
						{
							0.631f,
							0.541f,
							0.506f,
							1f
						};
					case 4627:
						return new float[]
						{
							0.882f,
							0.882f,
							0.882f,
							0.58f
						};
					default:
						switch (A_0)
						{
						case 4703:
							return new float[]
							{
								1f,
								1f,
								1f,
								1f
							};
						case 4704:
							return new float[]
							{
								0.549f,
								0.898f,
								0.275f,
								1f
							};
						case 4705:
							return new float[]
							{
								0.549f,
								0.898f,
								0.275f,
								1f
							};
						}
						break;
					}
				}
			}
			else if (A_0 <= 4740)
			{
				switch (A_0)
				{
				case 4720:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4721:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4722:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4723:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4724:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4725:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4726:
					return new float[]
					{
						1f,
						1f,
						1f,
						1f
					};
				case 4727:
					return new float[]
					{
						0.302f,
						0.122f,
						0.416f,
						1f
					};
				case 4728:
					return new float[]
					{
						0.824f,
						0.396f,
						0.965f,
						1f
					};
				default:
					if (A_0 == 4740)
					{
						return new float[]
						{
							0.106f,
							0.867f,
							1f,
							1f
						};
					}
					break;
				}
			}
			else
			{
				if (A_0 == 4741)
				{
					return new float[]
					{
						1f,
						0.737f,
						0.204f,
						1f
					};
				}
				switch (A_0)
				{
				case 4747:
					return new float[]
					{
						1f,
						0.898f,
						0f,
						1f
					};
				case 4748:
				case 4749:
				case 4750:
					break;
				case 4751:
					return new float[]
					{
						0.055f,
						0.055f,
						0.055f,
						1f
					};
				case 4752:
					return new float[]
					{
						0.706f,
						0.416f,
						0f,
						1f
					};
				case 4753:
					return new float[]
					{
						0.502f,
						0.502f,
						0.502f,
						1f
					};
				case 4754:
					return new float[]
					{
						0.62f,
						0.306f,
						0.133f,
						1f
					};
				default:
					if (A_0 == 4761)
					{
						return new float[]
						{
							0.047f,
							0.047f,
							0.047f,
							1f
						};
					}
					break;
				}
			}
			return new float[]
			{
				0.1647f,
				0.1647f,
				0.1647f,
				1f
			};
		}

		// Token: 0x04000004 RID: 4
		private static readonly Dictionary<string, Vector4> 랾 = new Dictionary<string, Vector4>
		{
			{
				" ",
				new Vector4(109f, 170f, 59f, 0.8f)
			},
			{
				"r ",
				new Vector4(1f, 0f, 0f, 1f)
			},
			{
				" ",
				new Vector4(0f, 1f, 0f, 1f)
			},
			{
				"blue",
				new Vector4(0f, 0f, 1f, 1f)
			},
			{
				" not",
				new Vector4(0f, 0f, 0f, 1f)
			},
			{
				"white",
				new Vector4(1f, 1f, 1f, 1f)
			},
			{
				"rose",
				new Vector4(1f, 0f, 0.498f, 1f)
			},
			{
				"cyan",
				new Vector4(0f, 1f, 1f, 1f)
			},
			{
				"magenta",
				new Vector4(1f, 0f, 1f, 1f)
			},
			{
				"yellow",
				new Vector4(1f, 1f, 0f, 1f)
			},
			{
				"gray",
				new Vector4(0.5f, 0.5f, 0.5f, 1f)
			},
			{
				"lightgray",
				new Vector4(0.8f, 0.8f, 0.8f, 1f)
			},
			{
				"darkgray",
				new Vector4(0.3f, 0.3f, 0.3f, 1f)
			},
			{
				"silver",
				new Vector4(0.75f, 0.75f, 0.75f, 1f)
			},
			{
				"pink",
				new Vector4(1f, 0.75f, 0.8f, 1f)
			},
			{
				"lightblue",
				new Vector4(0.68f, 0.85f, 0.9f, 1f)
			},
			{
				"lightgreen",
				new Vector4(0.56f, 0.93f, 0.56f, 1f)
			},
			{
				"lightpink",
				new Vector4(1f, 0.71f, 0.76f, 1f)
			},
			{
				"lightyellow",
				new Vector4(1f, 1f, 0.88f, 1f)
			},
			{
				"lightcoral",
				new Vector4(0.94f, 0.5f, 0.5f, 1f)
			},
			{
				"darkblue",
				new Vector4(0f, 0f, 0.55f, 1f)
			},
			{
				"darkgreen",
				new Vector4(0f, 0.39f, 0f, 1f)
			},
			{
				"darkred",
				new Vector4(0.55f, 0f, 0f, 1f)
			},
			{
				"darkcyan",
				new Vector4(0f, 0.55f, 0.55f, 1f)
			},
			{
				"darkmagenta",
				new Vector4(0.55f, 0f, 0.55f, 1f)
			},
			{
				"soilbrown",
				new Vector4(0.69f, 0.376f, 0.137f, 1f)
			},
			{
				"darkbrown",
				new Vector4(0.396f, 0.263f, 0.129f, 1f)
			},
			{
				"brown",
				new Vector4(0.76f, 0.6f, 0.42f, 1f)
			},
			{
				"beige",
				new Vector4(0.96f, 0.96f, 0.86f, 1f)
			},
			{
				"ivory",
				new Vector4(1f, 1f, 0.94f, 1f)
			},
			{
				"tan",
				new Vector4(0.82f, 0.71f, 0.55f, 1f)
			},
			{
				"khaki",
				new Vector4(0.94f, 0.9f, 0.55f, 1f)
			},
			{
				"ancient",
				new Vector4(0.624f, 0.561f, 0.475f, 1f)
			},
			{
				"orange",
				new Vector4(1f, 0.65f, 0f, 1f)
			},
			{
				"darkorange",
				new Vector4(1f, 0.55f, 0f, 1f)
			},
			{
				"salmon",
				new Vector4(0.98f, 0.5f, 0.45f, 1f)
			},
			{
				"coral",
				new Vector4(1f, 0.5f, 0.31f, 1f)
			},
			{
				"skyblue",
				new Vector4(0.53f, 0.81f, 0.92f, 1f)
			},
			{
				"dodgerblue",
				new Vector4(0.12f, 0.56f, 1f, 1f)
			},
			{
				"steelblue",
				new Vector4(0.27f, 0.51f, 0.71f, 1f)
			},
			{
				"royalblue",
				new Vector4(0.25f, 0.41f, 0.88f, 1f)
			},
			{
				"lime",
				new Vector4(0f, 1f, 0f, 1f)
			},
			{
				"forestgreen",
				new Vector4(0.13f, 0.55f, 0.13f, 1f)
			},
			{
				"mediumseagreen",
				new Vector4(0.24f, 0.7f, 0.44f, 1f)
			},
			{
				"olive",
				new Vector4(0.5f, 0.5f, 0f, 1f)
			},
			{
				"purple",
				new Vector4(0.5f, 0f, 0.5f, 1f)
			},
			{
				"indigo",
				new Vector4(0.29f, 0f, 0.51f, 1f)
			},
			{
				"violet",
				new Vector4(0.93f, 0.51f, 0.93f, 1f)
			},
			{
				"plum",
				new Vector4(0.87f, 0.63f, 0.87f, 1f)
			},
			{
				"firebrick",
				new Vector4(0.7f, 0.13f, 0.13f, 1f)
			},
			{
				"crimson",
				new Vector4(0.86f, 0.08f, 0.23f, 1f)
			},
			{
				"tomato",
				new Vector4(1f, 0.39f, 0.28f, 1f)
			},
			{
				"orangered",
				new Vector4(1f, 0.27f, 0f, 1f)
			},
			{
				"gold",
				new Vector4(1f, 0.84f, 0f, 1f)
			},
			{
				"goldenrod",
				new Vector4(0.85f, 0.65f, 0.13f, 1f)
			},
			{
				"lemonchiffon",
				new Vector4(1f, 0.98f, 0.8f, 1f)
			},
			{
				"lightgoldenrodyellow",
				new Vector4(0.98f, 0.98f, 0.82f, 1f)
			},
			{
				"slategray",
				new Vector4(0.44f, 0.5f, 0.56f, 1f)
			},
			{
				"dimgray",
				new Vector4(0.41f, 0.41f, 0.41f, 1f)
			},
			{
				"darkslategray",
				new Vector4(0.18f, 0.31f, 0.31f, 1f)
			},
			{
				"lightslategrey",
				new Vector4(0.47f, 0.53f, 0.6f, 1f)
			}
		};
	}
}
