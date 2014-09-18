import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		System.out.print("Enter a positive integer: ");
		Scanner input = new Scanner(System.in);
		int numOfWords = input.nextInt();
		String[] words = new String[numOfWords];
		for (int n = 0; n < numOfWords; n++) {
			System.out.print("Enter a word: ");			
			words[n] = input.next();
		}
		Arrays.sort(words);
		for (int i = 0; i < numOfWords; i++) {
			System.out.println(words[i]);	
		}

	}

}
