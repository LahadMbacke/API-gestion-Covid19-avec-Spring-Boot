package com.api.covid.apicovid.services;

import com.api.covid.apicovid.entite.Hopital;
import com.api.covid.apicovid.repository.HopitalRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class HopitalService {
    @Autowired
    private HopitalRepository hopitalRepository;

    //    Ajouter un nouveau Hopital
    public void addHopital(Hopital hopital ) {
        hopitalRepository.save(hopital);
    }


    //    Afficher les Hopitaux
    public List<Hopital> getAllHopital() {
        return hopitalRepository.findAll();
    }

    //    Afficher un Hopital
    public List<Hopital> getHopital(String nom) {
       return hopitalRepository.findByNom(nom);
    }





    // Modifier un Hopital
    public void updateHopital(Hopital hopital) {
        hopitalRepository.save(hopital);

    }

    public void suppHopital(int id) {
        hopitalRepository.deleteById(id);
    }
}
