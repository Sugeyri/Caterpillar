using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProyectoCat.Models;

public class Cliente
        {
        public int ID { get; set; }
        
        [Required]
        public string Nombre { get; set; }


        [Required]
        [DisplayName("Cédula Jurídica")]
        public string CédulaJurídica { get; set; }


        [DisplayName("Página Web")]
        [Required]
        public string PáginaWeb { get; set; }


        [DisplayName("Dirección Física")]
        [Required]
        public string DirecciónFísica { get; set; }


        [Required]
        [DisplayName("Sector")]
        public int IdSector { get; set; }
        public Sector Sector { get; set; }
        
}
