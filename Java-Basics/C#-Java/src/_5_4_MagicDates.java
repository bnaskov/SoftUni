import java.time.LocalDate;
import java.time.Month;
import java.util.Scanner;

public class _5_4_MagicDates {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int startYear = input.nextInt();
		int endYear = input.nextInt();
		int magicWeight = input.nextInt();
		LocalDate startDate = LocalDate.of(startYear, Month.JANUARY, 1);
		LocalDate endDate = LocalDate.of(endYear, Month.DECEMBER, 31);
		boolean noMagicDates = true;
		LocalDate currentDate = startDate;

		while (currentDate.isBefore(endDate) || currentDate.isEqual(endDate)) {
			int d1 = currentDate.getDayOfMonth() / 10;
			int d2 = currentDate.getDayOfMonth() % 10;
			int d3 = currentDate.getMonthValue() / 10;
			int d4 = currentDate.getMonthValue() % 10;
			int d5 = (currentDate.getYear() / 1000) % 10;
			int d6 = (currentDate.getYear() / 100) % 10;
			int d7 = (currentDate.getYear() / 10) % 10;
			int d8 = (currentDate.getYear() / 1) % 10;
			int[] digits = { d1, d2, d3, d4, d5, d6, d7, d8 };
			int weight = 0;

			for (int i = 0; i < digits.length; i++) {

				for (int j = (i + 1); j < digits.length; j++) {
					weight += digits[i] * digits[j];
				}
			}
			if (weight == magicWeight) {
				System.out.printf("%1$td-%1$tm-%1tY%n", currentDate);
				noMagicDates = false;
			}

			currentDate = currentDate.plusDays(1);
		}
		if (noMagicDates) {
			System.out.println("No");
		}
	}
}