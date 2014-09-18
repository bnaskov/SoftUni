import java.util.Locale;
import java.util.Scanner;
public class _3_PointsInsideFigure {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner input = new Scanner(System.in);
		System.out.print("Enter the coordinates (x and y) of a point: ");
		float x = input.nextFloat();
		float y = input.nextFloat();
		if (x < 12.5 || x > 22.5) {
			System.out.println("Outside");
		} else if (y > 13.5 || y < 6) {
			System.out.println("Outside");
		} else if ((x > 17.5 && x < 20) && y > 8.5) {
			System.out.println("Outside");
		} else {
			System.out.println("Inside");
		}
	}
}
