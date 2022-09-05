package com.api.covid.apicovid.controller;

import com.api.covid.apicovid.entite.Personne;
import com.api.covid.apicovid.entite.Rv;
import com.api.covid.apicovid.pojo.RvRequest;
import com.api.covid.apicovid.services.PersonneService;
import com.api.covid.apicovid.services.RvService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
@RequestMapping("/api/covid19/")
public class RvController {
    @Autowired
    private RvService rvService;

    // Ajouter un nouveau Rv
    @PostMapping("addRv")
    public Rv addRv(@RequestBody RvRequest rvRequest ) {
        return rvService.addRv(rvRequest);
    }
}
