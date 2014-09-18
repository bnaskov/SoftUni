import java.util.Locale;
import java.util.Scanner;

public class _9_PointsInsideTheHouse {
	
	// To determine the position of a point against a line we can use this formula: (b.x - a.x)*(p.y - a.y) - (b.y - a.y)*(p.x - a.x),
	// where a = line point 1; b = line point 2; p = point to check against.
	// Depending on the sign of the the result, the point p is either to the right, to the left or lies on the line (if the result is 0) 
	
	// This method checks if the point is above the horizontal line of the triangle
	public static Boolean isAbove(double pX, double pY) {
		return ((22.5 - 12.5)*(pY - 8.5) - (8.5 - 8.5)*(pX - 12.5)) <= 0;
	}
	// This method checks if the point is to the right of the left side of the triangle
	public static Boolean isRight(double pX, double pY) {
		return ((17.5 - 12.5)*(pY - 8.5) - (3.5 - 8.5)*(pX - 12.5)) >= 0;
	}
	// This method checks if the point is to the left of the right side of the triangle
	public static Boolean isLeft(double pX, double pY) {
		return ((17.5 - 22.5)*(pY - 8.5) - (3.5 - 8.5)*(pX - 22.5)) <= 0;
	}

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner in = new Scanner(System.in);
		System.out.print("Enter the coordinates (x and y) of a point (p): ");
		double pX = in.nextDouble();
		double pY = in.nextDouble();
		
		if (isAbove(pX, pY) && isRight(pX, pY) && isLeft(pX, pY)) {
			System.out.println("Inside");
		} else if (pX >= 12.5 && pX <= 17.5 && pY >= 8.5 && pY <= 13.5) {
			System.out.println("Inside");
		} else if (pX >= 20 && pX <= 22.5 && pY >= 8.5 && pY <= 13.5) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}		
	}
}
