import java.util.Scanner;

public class _1_2_HalfSum {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int firstHalf = 0;
		int secondHalf = 0;

		for (int i = 0; i < n; i++) {
			firstHalf += in.nextInt();
		}
		for (int i = n; i < n * 2; i++) {
			secondHalf += in.nextInt();
		}

		if (secondHalf == firstHalf) {
			System.out.println("Yes, sum=" + firstHalf);
		} else {
			System.out
					.println("No, diff=" + (Math.abs(firstHalf - secondHalf)));
		}
	}
}
