package com.api.covid.apicovid.repository;

import com.api.covid.apicovid.entite.Hopital;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface HopitalRepository extends JpaRepository<Hopital,Integer> {
   Hopital findById(int id);

   List<Hopital>  findByNom(String nom);
}
