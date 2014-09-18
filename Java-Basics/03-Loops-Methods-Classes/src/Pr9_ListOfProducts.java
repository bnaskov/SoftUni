import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Locale;
import java.util.Scanner;

/* Create a class Product to hold products, which have name (string) and price (decimal number). 
 * Read from a text file named "Input.txt" a list of products. 
 * Each product will be in format name + space + price. 
 * You should hold the products in objects of class Product. 
 * Sort the products by price and write them in format price + space + name in a file named "Output.txt". 
 * Ensure you close correctly all used resources. */

public class Pr9_ListOfProducts {

	public static void main(String[] args) throws Exception {
		Locale.setDefault(Locale.ROOT);
		ArrayList<Product> products = new ArrayList<Product>();
		try (Scanner input = new Scanner(new FileReader("ProductsInput.txt"))) {
			while (input.hasNextLine()) {
				products.add(new Product(input.next(), input.nextDouble()));
			}
		}
		Collections.sort(products);
		try (BufferedWriter output = new BufferedWriter(new FileWriter(
				"ProductsOutput.txt"))) {
			for (Product product : products) {
				output.write(String.format("%.2f %s%n", product.getPrice(),
						product.getName()));
			}
		}
	}
}
