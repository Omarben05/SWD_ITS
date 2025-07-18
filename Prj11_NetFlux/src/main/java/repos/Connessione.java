package repos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Connessione {
	
	//parametri per la connessione
	private final String HOST = "jdbc:mysql://localhost:3306/esercitazioni";
	private final String USER = "root";
	private final String PASS = "benagoub";
	
	private Connection conn = null; 
	
	public Connection getConn() {
		
		if (conn==null) connetti(); 
		
		return this.conn;
	}
	
	private void connetti() {
		
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			this.conn = DriverManager.getConnection(HOST, USER, PASS);
			System.out.println("Sei connesso al database.");
		
		} catch (SQLException e) {
			System.err.println("Non sei connesso al database.");
			System.err.println(e.getMessage());
		} catch (ClassNotFoundException e) {
			System.out.println("Non ho trovato la classe che hai detto di caricare");
			System.out.println(e.getMessage()); 
		}
	}
	
	public static void main(String[] args) {
		Connessione c = new Connessione();
		c.connetti(); 
	}
}
