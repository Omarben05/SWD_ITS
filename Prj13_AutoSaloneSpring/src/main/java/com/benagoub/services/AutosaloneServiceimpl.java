package com.benagoub.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.benagoub.entities.Automobile;
import com.benagoub.entities.Moto;
import com.benagoub.repos.AutomobileRepo;
import com.benagoub.repos.MotoRepo;


@Service
public class AutosaloneServiceimpl implements AutosaloneService{

	@Autowired //fa la creazione oggetto e automaticamente lo collega
	private AutomobileRepo repo;
	
	@Autowired
	private MotoRepo repoMoto;
	
	@Override
	public List<Automobile> getAutomobili() {
		// TODO Auto-generated method stub
		
		return repo.findAll();
	}

	@Override
	public List<Moto> getMoto() {
		// TODO Auto-generated method stub
		return repoMoto.findAll();
	}

	@Override
	public Automobile addAutomobile(Automobile a) {
		// TODO Auto-generated method stub
		return repo.save(a);  //salva le entita dei dati
	}

	@Override
	public Moto addMoto(Moto m) {
		return repoMoto.save(m);
	}
}
