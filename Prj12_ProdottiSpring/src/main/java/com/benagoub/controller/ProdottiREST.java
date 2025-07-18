package com.benagoub.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.benagoub.entities.Prodotto;
import com.benagoub.services.ProdottoService;

@RestController
@RequestMapping("api")
public class ProdottiREST {
	
	@Autowired
	private ProdottoService service;
	
	@GetMapping("prodotti")
	public List<Prodotto> getProdotti() {
		return service.getProdotti();
	}

}
