import java.util.Scanner;
public class _5_DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter a positive integer: ");
		int number = input.nextInt();
		String hex = Integer.toHexString(number);
		System.out.println(hex.toUpperCase());
	}
}
