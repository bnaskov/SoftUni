import java.util.Scanner;
public class _7_CountOfBitsOne {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.print("Enter a number: ");
		int number = in.nextInt();
		String binaryNumber = Integer.toBinaryString(number);
		int counter = 0;
		
		for (int i = 0; i < binaryNumber.length(); i++) {
			if (binaryNumber.charAt(i) == '1') {
				counter ++;
			}
		}
		System.out.println(counter);
	}
}
