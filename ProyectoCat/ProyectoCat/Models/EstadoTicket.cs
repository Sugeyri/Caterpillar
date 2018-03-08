using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCat.Models
{
    public class EstadoTicket
    {
            public int ID { get; set; }

            [Required]
            public string Nombre { get; set; }
        }
}
