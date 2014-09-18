import java.util.Scanner;


public class _2_3_Eclipse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();

		PrintLine(' ', '*', 2 * n - 2);
		PrintSpace(' ', n - 1);
		PrintLine(' ', '*', 2 * n - 2);
		System.out.println();

		//print body
		for (int i = 0; i < n - 2; i++) {
			if (i != n / 2 - 1) {
				PrintLine('*', '/', 2 * n - 2);
				PrintSpace(' ', n - 1);

				//print body-right
				PrintLine('*', '/', 2 * n - 2);
				System.out.println();

			}
			else {
				//print middleLine-left
				PrintLine('*', '/', 2 * n - 2);
				//print middleLine-middle
				PrintSpace('-', n - 1);

				//print middleLine-right
				PrintLine('*', '/', 2 * n - 2);
				System.out.println();
			}
		}

		//print bottom-left
		PrintLine(' ', '*', 2 * n - 2);

		//print bottom-middle
		PrintSpace(' ', n - 1);
		//print bottom-right
		PrintLine(' ', '*', 2 * n - 2);
	}
	public static void PrintLine(char aside, char middle, int num) {
		System.out.print(aside);
		for (int i = 0; i < num; i++) {
			System.out.print(middle);
		}
		System.out.print(aside);

	}

	public static void PrintSpace(char ch, int num) {
		for (int i = 0; i < num; i++) {
			System.out.print(ch);
		}
	}
}