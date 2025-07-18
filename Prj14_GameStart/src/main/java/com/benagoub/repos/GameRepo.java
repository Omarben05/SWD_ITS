package com.benagoub.repos;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.benagoub.entities.Game;
//Il repo tira fuori i dati dal db , li manda al service che li impacchetta 
//bisogna dargli la tabella anche con i parametri es Game.java

@Repository
public interface GameRepo extends JpaRepository<Game, Integer>{ // game, il valore primario in questo caso prende l'id cheabbiamo messo come PK

}
