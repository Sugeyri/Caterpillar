using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ProyectoCat.Models
{
    public class Sector
    {
        
        public int ID{ get; set; }

        [Required]
        public string Nombre { get; set; }

    }
}
