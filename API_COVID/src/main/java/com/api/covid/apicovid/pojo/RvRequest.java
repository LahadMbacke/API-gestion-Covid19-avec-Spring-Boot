package com.api.covid.apicovid.pojo;

import com.api.covid.apicovid.entite.Hopital;
import com.api.covid.apicovid.entite.Personne;

import javax.persistence.*;
import java.util.Date;

public class RvRequest {

    public int idRV;
    public Date date ;
    public String typeRV ;
    public int id_pers;
    public int id_hopital;
}
