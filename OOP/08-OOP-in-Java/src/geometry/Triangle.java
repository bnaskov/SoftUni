package geometry;

public class Triangle extends PlaneShape {
	public Triangle(TwoDimVertex[] twoDimVertices) {
		super(twoDimVertices);

	}

	@Override
	public double getPerimeter() {
		double sideA = CalculateDistanceBetween2dVertices.calculate(
				this.getTwoDimVertices()[0], this.getTwoDimVertices()[1]);
		double sideB = CalculateDistanceBetween2dVertices.calculate(
				this.getTwoDimVertices()[1], this.getTwoDimVertices()[2]);
		double sideC = CalculateDistanceBetween2dVertices.calculate(
				this.getTwoDimVertices()[2], this.getTwoDimVertices()[0]);
		double perimeter = sideA + sideB + sideC;
		return perimeter;
	}

	@Override
	public double getArea() {
		double aX = this.getTwoDimVertices()[0].getX();
		double aY = this.getTwoDimVertices()[0].getY();
		double bX = this.getTwoDimVertices()[1].getX();
		double bY = this.getTwoDimVertices()[1].getY();
		double cX = this.getTwoDimVertices()[2].getX();
		double cY = this.getTwoDimVertices()[2].getY();

		double area = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX
				* (aY - bY)) / 2);
		return area;
	}
}
