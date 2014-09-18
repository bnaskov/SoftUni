import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

/* Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards. */

public class Pr6_RandomHandsOf5Cards {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();

		String[] face = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K", "A" };
		String[] suit = { "♣", "♦", "♥", "♠" };
		String allCards = "";

		for (int j = 0; j < 13; j++) {
			for (int k = 0; k < 4; k++) {
				allCards += face[j] + suit[k] + " ";
			}
		}
		String[] cards = allCards.split(" ");

		for (int i = 0; i < n; i++) {
			Collections.shuffle(Arrays.asList(cards));
			System.out.printf("%s %s %s %s %s%n", cards[0], cards[1], cards[2],
					cards[3], cards[4]);
		}
	}
}
