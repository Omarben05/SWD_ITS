package repos;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Map;

import entities.Film;

public class SerieDAO {

private Map<Integer, Serie> series; //integer=id tabella, Film=tutto il record
	
	private Connessione connessione = new Connessione();
	
	private Statement statement; //un contenitore per istruzioni sql ho fatto import pure
	
	private PreparedStatement ps; //un contenitore per istruzioni sql
	
	private ResultSet rs; //un contenitore per risultati ho fatto import pure
	
	public void addSerie(Serie s) {
		String query = "INSERT INTO serietv (title, rating, year) values (?,?,?)";
		
		try {
			ps = connessione.getConn().prepareStatement(query);
			ps.setString(1, s.getTitle());
			ps.setString(1, s.getTitle());
			ps.setString(1, s.getTitle());
			ps.setString(1, s.getTitle());
			
		}
		
		
		
	}
	
}
