using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCovid.Models
{
    internal class Structure
    {
        public int id { get; set; }
        public String nom { get; set; }
        public String adresse { get; set; }
        public String type { get; set; }
        public int capacite { get; set; }
        public int disponible { get; set; }
        public String description { get; set; }
        public String contact { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
