import java.util.Scanner;

public class _5_2_Pairs {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] numbers = in.nextLine().split(" ");

		int firstNum = Integer.parseInt(numbers[0]);
		int secondNum = Integer.parseInt(numbers[1]);
		int prevSum = firstNum + secondNum;
		int currentSum = 0;
		int maxdiff = 0;

		for (int i = 2; i < numbers.length - 1; i += 2) {
			firstNum = Integer.parseInt(numbers[i]);
			secondNum = Integer.parseInt(numbers[i + 1]);
			currentSum = firstNum + secondNum;
			int diff = Math.abs(prevSum - currentSum);
			prevSum = currentSum;
			maxdiff = Math.max(maxdiff, diff);
		}

		if (maxdiff == 0) {
			System.out.println("Yes, value=" + prevSum);
		} else {
			System.out.println("No, maxdiff=" + maxdiff);
		}

	}
}
