package com.benagoub.services;

import java.util.List;

import com.benagoub.entities.Game;

public interface GameService {

	List<Game> getGames();
	List<Game> getGamesByPublisher(String publisher);
	Game getGameById();
	
	
}
