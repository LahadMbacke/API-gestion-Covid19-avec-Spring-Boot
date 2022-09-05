package com.api.covid.apicovid.entite;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.Collection;
import java.util.Set;

@Entity
@Data @NoArgsConstructor @AllArgsConstructor
@Table(name = "Hopital")
public class Hopital {
    @Id
    @Column(name = "idHopital")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idHopital ;
    private String nom ;
    private String ville;
    private double lati;
    private double longi;
    private String adresse;
    private String contact;
    private String nbrTest ;
    @JsonIgnore
    @OneToMany(mappedBy = "hopital",fetch = FetchType.LAZY)
    private Collection<Rv> rvs;


}
