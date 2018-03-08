using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProyectoCat.Models;

namespace ProyectoCat.Models
{
    public class Tickets
    {

        [Required]
        
        public int ID { get; set; }

            [Required]
            public string Título { get; set; }

            [Required]
            public string Detalle { get; set; }

            [Required]
            public string Reporta { get; set; }

            [Required]
        [DisplayName("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }



            [Required]
        [DisplayName("Estado")]
        public int EstadoId { get; set; }
        public EstadoTicket Estado { get; set; }
    }
}
