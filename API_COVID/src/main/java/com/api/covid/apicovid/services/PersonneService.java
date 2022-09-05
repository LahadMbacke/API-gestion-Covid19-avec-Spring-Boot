package com.api.covid.apicovid.services;

import com.api.covid.apicovid.entite.Personne;
import com.api.covid.apicovid.repository.PersonneRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class PersonneService {
    @Autowired
    private PersonneRepository personneRepository;

    //    Ajouter un nouveau Perssone
    public void addPersonne(Personne personne ) {
        personneRepository.save(personne);
    }


    //    Afficher les Prsonne
    public List<Personne> getAllPersonne() {
        return personneRepository.findAll();
    }


    // Modifier un Personne
    public void updatePersonne(Personne personne) {
        personneRepository.save(personne);

    }

    public void suppPersonne(int id) {
        personneRepository.deleteById(id);
    }
}
