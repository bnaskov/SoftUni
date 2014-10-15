package geometry;

public class ThreeDimVertex extends Vertex {
	private final double z;

	public ThreeDimVertex(double x, double y, final double z) {
		super(x, y);
		this.z = z;
	}

	public double getZ() {
		return z;
	}
}
