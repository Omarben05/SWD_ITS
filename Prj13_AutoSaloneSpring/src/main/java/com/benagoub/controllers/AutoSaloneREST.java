package com.benagoub.controllers;


//il rest controller parla in json
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.benagoub.entities.Automobile;
import com.benagoub.entities.Moto;
import com.benagoub.services.AutosaloneService;

@RestController
@RequestMapping("api")
public class AutoSaloneREST {
	
	
	@Autowired
	private AutosaloneService service;
	
	@GetMapping("automobili")
	public List<Automobile> getAuto(){
		return service.getAutomobili();
	}
	
	@GetMapping("moto")
	public List<Moto> getMoto() {
		return service.getMoto();
	}

	@PostMapping("automobili")
	public Automobile addAuto(@RequestBody Automobile a) {
		return service.addAutomobile(a);
	}
	
	@PostMapping("moto")
	public Moto addMoto(@RequestBody Moto m) {
		return service.addMoto(m);
	}
	
	@PostMapping("tantemoto")
	public List<Moto> addTanteMoto(@RequestBody List<Moto> lista) {
		for (Moto moto : lista) {
			service.addMoto(moto);
		}
		return service.getMoto();
	}
}
