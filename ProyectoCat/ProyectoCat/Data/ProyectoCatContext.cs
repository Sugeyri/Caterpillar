using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoCat.Models;

namespace ProyectoCat.Models
{
    public class ProyectoCatContext : DbContext
    {
        public ProyectoCatContext (DbContextOptions<ProyectoCatContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoCat.Models.Sector> Sector { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<ProyectoCat.Models.EstadoTicket> EstadoTicket { get; set; }

        public DbSet<ProyectoCat.Models.Tickets> Tickets { get; set; }

        public DbSet<ProyectoCat.Models.Usuario> Usuario { get; set; }

        public DbSet<ProyectoCat.Models.Reunion> Reunion { get; set; }

        public DbSet<ProyectoCat.Models.Contactos> Contactos { get; set; }
    }
}
