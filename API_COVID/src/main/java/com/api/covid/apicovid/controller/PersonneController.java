package com.api.covid.apicovid.controller;

import com.api.covid.apicovid.entite.Hopital;
import com.api.covid.apicovid.entite.Personne;
import com.api.covid.apicovid.services.HopitalService;
import com.api.covid.apicovid.services.PersonneService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/covid19/")
public class PersonneController {
    @Autowired
    private PersonneService personneService;

    // Ajouter un nouveau hopital
    @PostMapping("addPersonne")
    public void addPersonne(@RequestBody Personne personne ) {
        personneService.addPersonne(personne);
    }
}
