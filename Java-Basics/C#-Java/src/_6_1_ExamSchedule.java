import java.time.LocalDateTime;
import java.util.Scanner;

public class _6_1_ExamSchedule {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		int startingHour = Integer.parseInt(input.nextLine());
		int startingMinutes = Integer.parseInt(input.nextLine());
		String dayHalfString = input.nextLine();

		int hoursLenght = Integer.parseInt(input.nextLine());
		int minutesLenght = Integer.parseInt(input.nextLine());

		startingHour %= 12;
		if (dayHalfString.equals("PM")) {
			startingHour += 12;
		}

		LocalDateTime now = LocalDateTime.of(0, 1, 1, startingHour,
				startingMinutes);

		LocalDateTime endTime = now.plusMinutes(minutesLenght).plusHours(
				hoursLenght);

		System.out.printf("%1$tI:%1$tM:%1$Tp", endTime);
	}

}
