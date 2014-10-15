package geometry;

public abstract class Vertex {
	private final double x;
	private final double y;

	public Vertex(final double x, final double y) {
		super();
		this.x = x;
		this.y = y;
	}

	public double getX() {
		return x;
	}

	public double getY() {
		return y;
	}
}
