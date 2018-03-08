using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCat.Models
{
    public class Contactos
    {
        public int ID { get; set; }



        [Required]
        [DisplayName("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }


        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        [DisplayName("Correo Electrónico")]
        public string CorreoElectrónico { get; set; }

        [Required]
        public string Teléfono { get; set; }

        [Required]
        public string Puesto { get; set; }
    }
}
