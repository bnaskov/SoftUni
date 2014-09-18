import java.util.Scanner;

public class Pr2_PythagoreanNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int[] numbers = new int[n];
		boolean hasResult = true;

		for (int i = 0; i < n; i++) {
			numbers[i] = in.nextInt();
		}
		// System.out.println(Arrays.toString(numbers));
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				for (int k = 0; k < n; k++) {
					if (numbers[i] * numbers[i] + numbers[j] * numbers[j] == numbers[k]
							* numbers[k]
							&& numbers[i] <= numbers[j]) {
						System.out.println(numbers[i] + "*" + numbers[i]
								+ " + " + numbers[j] + "*" + numbers[j] + " = "
								+ numbers[k] + "*" + numbers[k]);
						hasResult = false;
					}
				}
			}
		}

		if (hasResult) {
			System.out.println("No");
		}
	}
}
