using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCovid.Models
{
    internal class Patient
    {
        public int idpers { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String adresse { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public int age { get; set; }
        public String role { get; set; }
    }
}
