import java.util.ArrayList;
import java.util.Scanner;

public class _4_4_CrossingSequences {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		// input
		int firstNum = in.nextInt();
		int secondNum = in.nextInt();
		int thirdNum = in.nextInt();
		int initialNum = in.nextInt();
		int step = in.nextInt();

		int tempStep = step;
		int tribNum = 0;
		int lastNumber = initialNum;
		boolean crossSeq = true;

		// create lists
		ArrayList<Integer> tribList = new ArrayList<Integer>();
		tribList.add(firstNum);
		tribList.add(secondNum);
		tribList.add(thirdNum);

		ArrayList<Integer> spiralList = new ArrayList<Integer>();
		spiralList.add(initialNum);

		// fill lists
		while (tribNum <= 1000000) {
			tribNum = firstNum + secondNum + thirdNum;
			tribList.add(tribNum);
			firstNum = secondNum;
			secondNum = thirdNum;
			thirdNum = tribNum;
		}
		while (lastNumber <= 1000000) {

			for (int i = 0; i < 2; i++) {
				lastNumber += tempStep;
				spiralList.add(lastNumber);
			}
			tempStep += step;
		}
		// check if spiralList contains a number from tribList
		for (int i = 0; i < tribList.size(); i++) {
			if (spiralList.contains(tribList.get(i))
					&& tribList.get(i) <= 1000000) {
				System.out.println(tribList.get(i));
				crossSeq = false;
				break;
			}
		}
		if (crossSeq) {
			System.out.println("No");
		}
	}
}