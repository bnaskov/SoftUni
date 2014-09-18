import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Pr4_CouplesFrequency {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] numbers = in.nextLine().split(" ");
		LinkedHashMap<String, Integer> couplesMap = new LinkedHashMap<String, Integer>();

		for (int i = 0; i < numbers.length - 1; i++) {
			String couple = numbers[i] + " " + numbers[i + 1];

			if (!couplesMap.containsKey(couple)) {
				couplesMap.put(couple, 1);
			} else {
				couplesMap.put(couple, couplesMap.get(couple) + 1);
			}
		}

		for (Map.Entry<String, Integer> entry : couplesMap.entrySet()) {
			double precentage = (double) entry.getValue() * 100
					/ (numbers.length - 1);
			System.out.printf("%s -> %.2f%%\n", entry.getKey(), precentage);
		}
	}
}
