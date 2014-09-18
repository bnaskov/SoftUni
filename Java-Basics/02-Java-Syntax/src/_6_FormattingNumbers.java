import java.util.Locale;
import java.util.Scanner;
public class _6_FormattingNumbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner input = new Scanner(System.in);
		System.out.print("Enter 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c : ");
		int num1 = input.nextInt();
		float num2 = input.nextFloat();
		float num3 = input.nextFloat();
		System.out.printf("|%-10X|%010d|%10.2f|%-10.3f|%n", num1, Integer.parseInt(Integer.toBinaryString(num1)), num2, num3);
	}
}