package com.api.covid.apicovid.repository;

import com.api.covid.apicovid.entite.Personne;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface PersonneRepository extends JpaRepository<Personne,Integer> {
     Personne findById(int id);
     Personne findByEmailAndPassword(String email, String password);
}
