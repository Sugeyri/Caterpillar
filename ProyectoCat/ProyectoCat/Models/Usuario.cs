using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace ProyectoCat.Models
{
    public class Usuario
        {
            public int ID { get; set; }

            [Required]
            public string Nombre { get; set; }

            [Required]
            public string Correo { get; set; }

            [Required]
            public bool Administrador { get; set; }

            [Required]
            public string NombreUsuario { get; set; }

            [Required]
            public string Contrasenna { get; set; }
        
            public string Ccontrasenna { get; set; }
        }
    }

