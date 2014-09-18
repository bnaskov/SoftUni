import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;
public class _4_TheSmallestOf3Numbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner input = new Scanner(System.in);
		System.out.print("Enter three numbers: ");
		double num1 = input.nextDouble();
		double num2 = input.nextDouble();
		double num3 = input.nextDouble();
		double[] numbers = {num1 , num2, num3};
		Arrays.sort(numbers);
		System.out.println(numbers[0]);
	}
}
