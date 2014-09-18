import java.util.Scanner;
public class _2_TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter the coordinates of point a: ");
		int aX = input.nextInt();
		int aY = input.nextInt();		
		System.out.print("Enter the coordinates of point b: ");
		int bX = input.nextInt();
		int bY = input.nextInt();
		System.out.print("Enter the coordinates of point c: ");
		int cX = input.nextInt();
		int cY = input.nextInt();
		int area = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2);
		System.out.println("The triangle area is: " + area);
	}
}
