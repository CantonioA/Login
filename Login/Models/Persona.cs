using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models
{
    public class Persona
    {
        [Key]
        public string DNIPER { get; set; }
        public string NOMPER { get; set; }
        public string APEPER { get; set; }
        public string USUPER { get; set; }
        public string CONPER { get; set; }
        public int NIVPER { get; set; }
    }
}
