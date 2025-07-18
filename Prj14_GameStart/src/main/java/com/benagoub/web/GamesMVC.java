package com.benagoub.web;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import com.benagoub.entities.Game;
import com.benagoub.services.GameService;

@Controller   //lo fa diventare un controller mvc
public class GamesMVC {
	
	@Autowired
	private GameService service;
	
	@GetMapping("games") //cliccando in sito games ti porta qui
	public String giochi(Model m) {
		
		List<Game> games = service.getGames();
		m.addAttribute("games", games); //lista di giochi che vengono passati alla pagina html
		return "giochi"; //questo è il nome di un file html dentro templates
	}
	
}
