using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCat.Models
{
    public class Reunion
    {

        public int ID { get; set; }

        [Required]
        public string Título { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Día y hora")]
        public DateTime DíaYHora { get; set; }


        [Required]
        [DisplayName("Usuario Asignado")]
        public int UsuarioId { get; set; }
        public Usuario UsuarioAsignado { get; set; }


        [Required]
        public bool Virtual { get; set; }


        [Required]
        [DisplayName("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
