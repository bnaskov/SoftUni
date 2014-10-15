package geometry;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable,
		AreaMeasurable {
	private TwoDimVertex[] twoDimVertices;

	public PlaneShape(TwoDimVertex[] twoDimVertices) {
		this.twoDimVertices = twoDimVertices;
	}

	public TwoDimVertex[] getTwoDimVertices() {
		return this.twoDimVertices;
	}
}
