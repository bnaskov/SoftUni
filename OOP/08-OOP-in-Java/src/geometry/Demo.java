package geometry;

public class Demo {

	public static void main(String[] args) {
		Vertex a = new TwoDimVertex(5, 6);
		Vertex b = new TwoDimVertex(4, 2);
		System.out.println(CalculateDistanceBetween2dVertices.calculate(a, b));
	}

}
