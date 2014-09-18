import java.util.Scanner;
import org.joda.time.DateTime;
import org.joda.time.Days;
import org.joda.time.LocalDate;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

/* Write a program to calculate the difference between two dates in number of days. 
 * The dates are entered at two consecutive lines in format day-month-year. 
 * Days are in range [1…31]. Months are in range [1…12]. Years are in range [1900…2100].*/

public class Pr7_Days_BetweenTwoDates {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out
				.print("Enter two dates in the format day-month-year on separate lines:");
		String firstDate = in.nextLine();
		String secondDate = in.nextLine();

		DateTimeFormatter dateStringFormat = DateTimeFormat
				.forPattern("dd-MM-yyyy");
		DateTime firstTime = dateStringFormat.parseDateTime(firstDate);
		DateTime secondTime = dateStringFormat.parseDateTime(secondDate);
		int days = Days.daysBetween(new LocalDate(firstTime),
				new LocalDate(secondTime)).getDays();
		System.out.println("Days between the two dates " + days);
	}
}
