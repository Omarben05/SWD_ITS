package com.benagoub.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.benagoub.entities.Game;
import com.benagoub.repos.GameRepo;

@Service
public class GameServiceImpl implements GameService {

	//bisogna collegare service e repo
	//crea oggetti e te lo da in automatico e toglie quando non ha piu bisogno
	@Autowired
	private GameRepo repo;
	
	
	@Override
	public List<Game> getGames() {
		// TODO Auto-generated method stub
		return repo.findAll();  //questo fa tutti i set
	}

	@Override
	public List<Game> getGamesByPublisher(String publisher) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Game getGameById() {
		// TODO Auto-generated method stub
		return null;
	}

}
