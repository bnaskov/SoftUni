import java.util.Scanner;

/* Write a program to generate and print all 3-letter words consisting
 *  of given set of characters. For example if we have the characters 'a' and 'b', 
 *  all possible words will be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb". 
 *  The input characters are given as string at the first line of the input. 
 *  Input characters are unique (there are no repeating characters). */

public class Pr2_Generate3LetterWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		char[] arr = in.next().toCharArray();

		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr.length; j++) {
				for (int k = 0; k < arr.length; k++) {
					System.out.printf("%c%c%c ", arr[i], arr[j], arr[k]);
				}
			}
		}
	}
}
