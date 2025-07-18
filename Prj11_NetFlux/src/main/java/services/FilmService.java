package services;

import java.util.ArrayList;
import java.util.List;

import entities.Film;
import repos.FilmDAO;
import repos.SerieDAO;

public class FilmService { //service accede alle azioni del DAO
	
	private FilmDAO dao;
	
	public FilmService() {
		this.dao =new FilmDAO();
		this.serieDAO = new SerieDAO();
		
	}
	public void addSerie(String title, double rating, int year) {
		Serie s = new Serie();
		s.setTitle(title);
		s.setRating(rating);
		s.setYear(year);
		serieDAO.addSerie(s);
	}
	public List<Film> getFilms(){
		return new ArrayList<>(dao.getFilms());
	}
	
	public void addFilm(Film f) {
		dao.addFilm(f);
	}
	
	
}
