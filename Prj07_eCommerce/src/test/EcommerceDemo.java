package test;

import model.Product;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

import controller.StorageCtrl;
import view.ProductView;

public class EcommerceDemo {

	public static void main(String[] args) throws FileNotFoundException {
		
		Product p1 = new Product(1, "Red T-shirt", "Clothing", 15.54, 10);
		Product p2 = new Product(1, "Blue T-shirt", "Clothing", 15.54, 10);
		Product p3 = new Product(1, "Green T-shirt", "Clothing", 15.54, 10);
		
		StorageCtrl storage = new StorageCtrl("Firenze's storage");
		
		storage.addProduct(p1);
		storage.addProduct(p2);
		storage.addProduct(p3);
		
		ProductView pView = new ProductView();
		
		for(Product p : storage.getProducts()) {
			System.out.println(p.getName());
		}
		
		for(Product p : storage.getProducts()) {
			System.out.println(pView.productCard(p));
		}
		
		File f = new File("products.html");
		File source = new File("products.csv");
		
		PrintWriter printer = new PrintWriter(f);
		
		Scanner scanner = new Scanner(source);
		
		while(scanner.hasNextLine()) {
			String line = scanner.nextLine();
			String[] elements = line.split(",");
			int id = Integer.parseInt(elements[0]);
			String name = elements[1];
			String category = elements[2];
			Double price = Double.parseDouble(elements[3]);
			int stock = Integer.parseInt(elements[4]);
			
			storage.addProduct(new Product(id, name, category, price, stock));
		}
		
		for(Product p : storage.getProducts()) {
			printer.println(pView.productCard(p));
		}
		
		printer.close();
		scanner.close();
		
		System.out.println("File successfully modified");
		
	}

}
