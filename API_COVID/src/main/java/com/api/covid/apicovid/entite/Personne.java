package com.api.covid.apicovid.entite;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.Collection;
import java.util.Objects;
import java.util.Set;

@Entity

@Data @NoArgsConstructor @AllArgsConstructor
@Table(name="Personne")

public class Personne {
  @Id
  @Column(name = "idPers")
  @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idPers;
  @Column(nullable = false)
   private  String nom ;
    @Column(nullable = false)
    private  String prenom;
    @Column(nullable = false)
    private  String password;
    @Column(nullable = false)
    private  String email;

    @JsonIgnore
  @OneToMany(mappedBy = "personne",fetch = FetchType.LAZY)
  private Collection<Rv> rvs;


}
