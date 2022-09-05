using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCovid.Models
{
    internal class RV
    {
        public DateTime dateRV { get; set; }
        public string typeRV { get; set; }
        public int code_patient { get; set; }
        public int code_structure { get; set; }
    }
}
