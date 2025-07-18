package view;

import model.Product;

public class ProductView {
	
	public String productCard(Product p) {
		String output = "";
		
		output += "<div>\n";
		output += p.getName() + "\n";
		output += "</div>\n";
		
		return output;
	}
	
}
