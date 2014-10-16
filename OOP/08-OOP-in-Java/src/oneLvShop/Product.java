package oneLvShop;

import java.math.BigDecimal;

public abstract class Product implements Buyable {
	private String name;
	private BigDecimal price;
	private int quantity;
	private AgeRestriction ageRestriction;

	public Product(String name, BigDecimal price, int quantity,
			AgeRestriction ageRestriction) {
		super();
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.setAgeRestriction(ageRestriction);
	}

	public String getName() {
		return name;
	}

	private void setName(String name) {
		if (name.isEmpty() || name == null) {
			throw new IllegalArgumentException("Name cannot be null or empty.");
		}
		this.name = name;
	}

	public BigDecimal getPrice() {
		return price;
	}

	private void setPrice(BigDecimal price) {
		if (price.compareTo(new BigDecimal(0.0)) == -1) {
			throw new IllegalArgumentException("Price cannot be negative.");
		}

		this.price = price;
	}

	public int getQuantity() {
		return quantity;
	}

	private void setQuantity(int quantity) {
		if (quantity < 0) {
			throw new IllegalArgumentException("Quantity cannot be negative.");
		}

		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}

	private void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}

}
