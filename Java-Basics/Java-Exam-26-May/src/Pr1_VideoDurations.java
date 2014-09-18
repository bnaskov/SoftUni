import java.util.Scanner;

public class Pr1_VideoDurations {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		boolean isEnd = true;
		int sumHours = 0;
		int sumMinutes = 0;

		while (isEnd) {
			String[] strings = in.nextLine().split(":");
			if (strings[0].equals("End")) {
				isEnd = false;
			} else {
				sumHours += Integer.parseInt(strings[0]);
				sumMinutes += Integer.parseInt(strings[1]);
			}
		}

		long totalHours = sumHours + sumMinutes / 60;
		long totalMinutes = sumMinutes % 60;

		if (totalMinutes < 10) {
			System.out.println(totalHours + ":0" + totalMinutes);
		} else {
			System.out.println(totalHours + ":" + totalMinutes);
		}

	}
}
