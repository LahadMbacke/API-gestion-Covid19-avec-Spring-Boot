package com.api.covid.apicovid.controller;


import com.api.covid.apicovid.entite.Hopital;
import com.api.covid.apicovid.services.HopitalService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/covid19/")
public class HopitalController {
    @Autowired
    private HopitalService hopitalService;

    // Ajouter un nouveau hopital
    @PostMapping("addHopital")
    public void addHopital(@RequestBody Hopital hopital ) {
        hopitalService.addHopital(hopital);
    }

    //Afficher les hopitals
    @GetMapping("/hopitals")
    public List<Hopital> getAllHopital() {
        return hopitalService.getAllHopital();
    }

    //Afficher un hopital
   @GetMapping("/hopital/{nom}")
    public List<Hopital> getHopital(@PathVariable String nom ) {
        return hopitalService.getHopital(nom);
    }

    /*
    //Afficher un hopital
   @GetMapping("/hopital/nom")
    public ResponseEntity<List<Hopital>>  getHopital(@RequestParam String nom ) {
        return hopitalService.getHopital(nom);*/
}
