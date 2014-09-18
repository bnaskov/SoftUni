import java.util.Scanner;

public class _1_3_Sunglasses {

	public static void main(String args[]) {
		Scanner scanner = new Scanner(System.in);
		int n = scanner.nextInt();

		for (int i = 0; i < 5 * n; i++) {
			if (i >= 2 * n && i < 3 * n) {
				System.out.print(' ');
			} else {
				System.out.print('*');
			}
		}
		System.out.println();

		for (int i = 2; i < n; i++) {
			if (i == n / 2 + 1) {
				System.out.print('*');
				for (int j = 0; j < n * 2 - 2; j++) {
					System.out.print('/');
				}
				System.out.print('*');

				for (int j = 0; j < n; j++) {
					System.out.print('|');
				}

				System.out.print('*');
				for (int j = 0; j < n * 2 - 2; j++) {
					System.out.print('/');
				}
				System.out.print('*');
				System.out.println();
			} else {
				System.out.print('*');
				for (int j = 0; j < n * 2 - 2; j++) {
					System.out.print('/');
				}
				System.out.print('*');

				for (int j = 0; j < n; j++) {
					System.out.print(' ');
				}

				System.out.print('*');
				for (int j = 0; j < n * 2 - 2; j++) {
					System.out.print('/');
				}
				System.out.print('*');
				System.out.println();
			}
		}

		for (int i = 0; i < 5 * n; i++) {
			if (i >= 2 * n && i < 3 * n) {
				System.out.print(' ');
			} else {
				System.out.print('*');
			}
		}
	}
}