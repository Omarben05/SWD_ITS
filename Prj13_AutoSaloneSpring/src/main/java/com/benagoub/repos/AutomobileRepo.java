package com.benagoub.repos;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.benagoub.entities.Automobile;

@Repository
public interface AutomobileRepo extends JpaRepository<Automobile, Integer>{


}
