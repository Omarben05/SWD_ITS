package com.benagoub.api;

import java.util.List;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.benagoub.entities.Game;
import com.benagoub.services.GameService;

@RestController
@RequestMapping("api")
public class GamesREST {

	private GameService service;
	
	@GetMapping("games")
	public List<Game> games(){
		return service.getGames();
				
	}
}
