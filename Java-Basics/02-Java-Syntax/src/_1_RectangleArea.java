import java.util.Scanner;

public class _1_RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter two numbers a and b: ");
		int a = input.nextInt();
		int b = input.nextInt();
		System.out.println("The rectangle area is: " + a * b);
	}
}
