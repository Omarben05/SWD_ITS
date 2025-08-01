package com.benagoub.services;

import java.util.List;


import org.springframework.stereotype.Service;

import com.benagoub.entities.Prodotto;

@Service
public interface ProdottoService {

	List<Prodotto> getProdotti();
	List<Prodotto> getProdottiByCategoria(String categoria);
	Prodotto getProdottoById(int id);
	
	Prodotto addProdotto(Prodotto p);
	Prodotto updateProdotto(Prodotto p);
	void deleteProdotto(int id);
	
}
