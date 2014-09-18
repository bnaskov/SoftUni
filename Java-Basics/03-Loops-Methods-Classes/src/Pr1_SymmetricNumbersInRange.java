import java.util.Scanner;

// Write a program to generate and print all symmetric numbers in given range [start…end]. 
// A number is symmetric if its digits are symmetric toward its middle. 
// For example, the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997 are not symmetric. 

public class Pr1_SymmetricNumbersInRange {

	public static void main(String[] args) {

		Scanner in = new Scanner(System.in);
		int start = in.nextInt();
		int end = in.nextInt();

		String firstHalf = "";
		String secondHalf = "";
		String currentNum = "";

		for (int i = start; i <= end; i++) {

			currentNum = Integer.toString(i);

			firstHalf = currentNum.substring(0, currentNum.length() / 2);
			secondHalf = new StringBuilder(currentNum.substring(
					currentNum.length() / 2 + currentNum.length() % 2,
					currentNum.length())).reverse().toString();

			if (firstHalf.equals(secondHalf)) {
				System.out.println(currentNum);
			}
		}
	}
}
