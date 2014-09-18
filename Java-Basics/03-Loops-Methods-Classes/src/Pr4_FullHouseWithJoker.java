/* In most Poker games, the "full house" hand is defined as three cards 
 * of the same face + two cards of the same face, other than the first, 
 * regardless of the card's suits. The cards faces are 
 * "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" and "A". 
 * The card suits are "♣", "♦", "♥" and "♠". A special card "Joker" (denoted as "*") 
 * is used as wildcard and can replace any other card. Jokers do not have a suite. 
 * Jokes can be used several times in a hand. Write a program to generate and print all 
 * full houses and print their number. */

public class Pr4_FullHouseWithJoker {

	public static void main(String[] args) {

		String[] cards = new String[52];
		String[] cardType = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
				"J", "Q", "K", "A" };
		char[] cardSuit = { '♣', '♦', '♥', '♠' };
		int counterFH = 0;

		for (int i = 0, indx = 0; i < 13; i++) {
			for (int j = 0; j < 4; j++, indx++) {
				cards[indx] = cardType[i] + cardSuit[j];
			}
		}

		for (int n = 0; n < 13; n++) {
			for (int a = n * 4; a < (n * 4 + 4); a++) {
				for (int b = a + 1; b < (n * 4 + 4); b++) {
					for (int c = b + 1; c < (n * 4 + 4); c++) {
						for (int m = 0; m < 13; m++) {
							if (n != m) {
								for (int d = m * 4; d < (m * 4 + 4); d++) {
									for (int e = d + 1; e < (m * 4 + 4); e++) {
										System.out.printf("%s %s %s %s %s%n",
												cards[a], cards[b], cards[c],
												cards[d], cards[e]);
										counterFH++;

										for (int j = 1; j < 32; j++) {

											for (int moveJ = 0; moveJ < 5; moveJ++) {
												if (((j >> moveJ) & 1) == 0) {
													switch (moveJ) {
													case 0:
														System.out
																.printf("%s ",
																		cards[a]);
														break;
													case 1:
														System.out
																.printf("%s ",
																		cards[b]);
														break;
													case 2:
														System.out
																.printf("%s ",
																		cards[c]);
														break;
													case 3:
														System.out
																.printf("%s ",
																		cards[d]);
														break;
													case 4:
														System.out
																.printf("%s ",
																		cards[e]);
														break;
													}
												} else if (((j >> moveJ) & 1) != 0) {
													System.out.print("* ");
												}
											}
											System.out.println();
											counterFH++;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.println(counterFH);
	}
}
