import java.util.Locale;
import java.util.Scanner;

/* Write a method to convert from degrees to radians. 
 * Write a method to convert from radians to degrees. 
 * You are given a number n and n queries for conversion. 
 * Each conversion query will consist of a number + space + measure. 
 * Measures are "deg" and "rad". Convert all radians to degrees and all degrees to radians. 
 * Print the results as n lines, each holding a number + space + measure. 
 * Format all numbers with 6 digit after the decimal point. */

public class Pr5_AngleUnitConverter {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner in = new Scanner(System.in);
		int n = Integer.parseInt(in.nextLine());
		double[] numbers = new double[n];
		String[] units = new String[n];

		for (int i = 0; i < n; i++) {
			numbers[i] = in.nextDouble();
			units[i] = in.next();
			in.nextLine();
			convertor(numbers[i], units[i]);
		}

	}

	private static void convertor(double num, String str) {
		if (str.equals("rad")) {
			num *= 57.2957795;
			System.out.printf("%.6f deg%n", num);
		}

		if (str.equals("deg")) {
			num *= 0.0174532925;
			System.out.printf("%.6f rad%n", num);
		}
	}

}
