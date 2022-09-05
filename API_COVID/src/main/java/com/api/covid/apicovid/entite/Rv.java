package com.api.covid.apicovid.entite;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.Date;
@Entity
@Data @NoArgsConstructor @AllArgsConstructor
@Table(name = "Rv")

public class Rv {
     @Id
     @Column(name = "idRv")
     @GeneratedValue(strategy = GenerationType.IDENTITY)
     @JsonIgnore
    private String idRV;

    @ManyToOne
    @JoinColumn(name = "idPers")
    Personne personne;

    @ManyToOne
    @JoinColumn(name = "idHopital")
    Hopital hopital;

    private Date date ;
    private String typeRV ;

}

