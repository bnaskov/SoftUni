import java.util.Scanner;

public class _1_4_NineDigitMagicNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int sum = in.nextInt();
		int diff = in.nextInt();
		boolean output = true;

		for (int i = 111; i <= 777; i++) {
			int def = i + diff;
			int ghi = def + diff;
			if (digitCheck(i) && digitCheck(def) && digitCheck(ghi)
					&& (sumDigits(i) + sumDigits(def) + sumDigits(ghi)) == sum) {
				output = false;
				System.out.println(i + "" + def + "" + ghi);
			}
		}
		if (output) {
			System.out.println("No");
		}
	}

	public static boolean digitCheck(int number) {
		int firstDigit = number / 100;
		int secondDigit = (number / 10) % 10;
		int thirdDigit = number % 10;
		boolean digCheck = false;
		if (firstDigit > 0 && firstDigit <= 7 && secondDigit > 0
				&& secondDigit <= 7 && thirdDigit > 0 && thirdDigit <= 7) {
			digCheck = true;
		}
		return digCheck;
	}

	public static int sumDigits(int number) {
		int firstDigit = number / 100;
		int secondDigit = (number / 10) % 10;
		int thirdDigit = number % 10;
		int sum = firstDigit + secondDigit + thirdDigit;
		return sum;
	}

}
