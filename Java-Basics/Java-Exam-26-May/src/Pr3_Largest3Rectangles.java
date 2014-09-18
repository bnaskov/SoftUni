import java.util.Scanner;

public class Pr3_Largest3Rectangles {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] strNumbers = in.nextLine().split("\\D+");
		// the first element in strNumbers is empty
		int[] nums = new int[strNumbers.length - 1];
		int[] areaRectangles = new int[nums.length / 2];

		for (int i = 1; i < strNumbers.length; i++) {
			nums[i - 1] = Integer.parseInt(strNumbers[i]);
		}

		for (int i = 0; i < nums.length; i += 2) {
			areaRectangles[i / 2] = nums[i] * nums[i + 1];
		}

		long maxArea = 0;
		for (int i = 0; i < areaRectangles.length - 2; i++) {
			if (areaRectangles[i] + areaRectangles[i + 1]
					+ areaRectangles[i + 2] > maxArea) {
				maxArea = areaRectangles[i] + areaRectangles[i + 1]
						+ areaRectangles[i + 2];
			}
		}

		System.out.println(maxArea);
	}
}
