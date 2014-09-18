import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/* Write a program to find the most frequent word in a text and print it, 
 * as well as how many times it appears in format "word -> count". 
 * Consider any non-letter character as a word separator. Ignore the character casing. 
 * If several words have the same maximal frequency, print all of them in alphabetical order.*/

public class Pr11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] words = in.nextLine().toLowerCase().split("\\W+");
		TreeMap<String, Integer> wordsCount = new TreeMap<>();
		int maxCount = 0;

		for (String word : words) {
			Integer count = wordsCount.get(word);
			if (count == null) {
				count = 0;
			}
			if (count + 1 > maxCount) {
				maxCount = count + 1;
			}
			wordsCount.put(word, count + 1);
		}

		for (Map.Entry<String, Integer> entry : wordsCount.entrySet()) {
			if (entry.getValue() == maxCount) {
				System.out.println(entry.getKey() + " -> " + maxCount
						+ " times");
			}
		}
	}
}
