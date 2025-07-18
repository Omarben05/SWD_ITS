package com.benagoub.services;

import java.util.List;

import com.benagoub.entities.Automobile;
import com.benagoub.entities.Moto;

public interface AutosaloneService {

	//CRUD
	//CREATE
	Automobile addAutomobile(Automobile a);
	//READ
	List<Automobile> getAutomobili();
	//UPDATE
	
	//DELETE
	
	List<Moto> getMoto();
	Moto addMoto(Moto m);
	
	
}
