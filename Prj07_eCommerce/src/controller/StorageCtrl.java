package controller;

import java.util.ArrayList;
import java.util.List;
import model.Product;

public class StorageCtrl {

	private String name;
	private List<Product> products;
	
	public StorageCtrl(String name) {
		super();
		this.name = name;
		this.products = new ArrayList<Product>();
	}
	
	public void addProduct(Product newProduct) {
		products.add(newProduct);
	}
	
	public List<Product> getProducts() {
		return products;
	}
	
}
