import java.util.Scanner;

public class _4_2_Illuminati {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		char[] text = in.nextLine().toUpperCase().toCharArray();
		long sumVowel = 0;
		int counter = 0;

		for (int i = 0; i < text.length; i++) {
			if (text[i] == 'A' || text[i] == 'E' || text[i] == 'I'
					|| text[i] == 'O' || text[i] == 'U') {
				sumVowel += (int) text[i];
				counter++;
			}
		}
		System.out.println(counter);
		System.out.println(sumVowel);
	}
}