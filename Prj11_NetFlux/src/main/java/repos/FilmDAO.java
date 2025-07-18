package repos;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import java.util.Collection;
import java.util.HashMap;
import java.util.Map;

import entities.Film;

public class FilmDAO {//la map tabella dei film,inserisci, modifica, elimana, get

	private Map<Integer, Film> films; //integer=id tabella, Film=tutto il record
	
	private Connessione connessione = new Connessione();
	
	private Statement statement; //un contenitore per istruzioni sql ho fatto import pure
	
	private ResultSet rs; //un contenitore per risultati ho fatto import pure
	
	public FilmDAO() { 
		this.films=new HashMap<>();
		inizializzaMappaFilm();
	}
	
	private void inizializzaMappaFilm() {
		try {
			//1 uso la connessione per creare uno statement
			statement = connessione.getConn().createStatement();
			//2 preparo la query 
			String query = "SELECT * FROM IMDB_top_top250";
			//3 eseguo la query e memorizzo i risultati
			rs = statement.executeQuery(query);
			//4 faccio un ciclo while per usare i risultati della query
			while(rs.next()) {
				Film f = new Film(); //inizializzo l'oggetto Film f
				f.setId(rs.getInt("id"));
				f.setTitle(rs.getString("title"));
				f.setRating(rs.getDouble("rating"));
				f.setYear(rs.getInt("year"));
				
				films.put(f.getId(), f);
			}
			
			
		} catch (SQLException e) {
			System.err.println("C'è un errore nella query: " + e.getMessage());
		}
		
	}
	
	public void addFilm(Film f) { //aggiungi il film
		films.put(f.getId(),f);
	}
	
	public Film getFilmById(int id) { //get dei film
		return this.films.get(id);
	}
	
	public Collection<Film> getFilms(){ //get tutti i film
		
		
		Film f=new Film();
		f.setId(1);
		f.setTitle("Il padrino");
		f.setRating(9.5);
		f.setYear(1974);
		
		addFilm(f);
		return this.films.values();
		}
	}
