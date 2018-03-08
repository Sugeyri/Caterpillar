using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProyectoCat.Models
{
    public static class Session
    {
        public static bool Activo { get; set; }
        public static bool Administrador { get; set; }
    }
}

