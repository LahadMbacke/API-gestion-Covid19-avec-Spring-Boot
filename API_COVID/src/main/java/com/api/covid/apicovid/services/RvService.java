package com.api.covid.apicovid.services;

import com.api.covid.apicovid.entite.Hopital;
import com.api.covid.apicovid.entite.Personne;
import com.api.covid.apicovid.entite.Rv;
import com.api.covid.apicovid.pojo.RvRequest;
import com.api.covid.apicovid.repository.HopitalRepository;
import com.api.covid.apicovid.repository.PersonneRepository;
import com.api.covid.apicovid.repository.RvRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;


@Service
public class RvService {
    @Autowired
    private RvRepository rvRepository;
    @Autowired
    private PersonneRepository personneRepository;
    @Autowired
    private HopitalRepository hopitalRepository;
    //    Ajouter un nouveau Rv
    public Rv addRv(RvRequest rvRequest ) {
        Personne personne = personneRepository.findById(rvRequest.id_pers);
        Hopital hopital = hopitalRepository.findById(rvRequest.id_hopital);
        Rv rv = new Rv();
        rv.setTypeRV(rvRequest.typeRV);
        rv.setDate(rvRequest.date);
        rv.setPersonne(personne);
        rv.setHopital(hopital);
        return rvRepository.save(rv);
    }


    //    Afficher les Rv
    public List<Rv> getAllRv() {
        return rvRepository.findAll();
    }


    // Modifier un Rv
    public void updateRv(Rv rv) {
        rvRepository.save(rv);

    }

    public void suppRv(int id) {
        rvRepository.deleteById(id);
    }
}
