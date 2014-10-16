package oneLvShop;

import java.math.BigDecimal;
import java.util.Date;

public class FoodProduct extends Product implements Expirable {

	public FoodProduct(String name, BigDecimal price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction);
		// TODO Auto-generated constructor stub
	}

	@Override
	public Date getExpirationDate() {
		// TODO Auto-generated method stub
		return null;
	}

}
