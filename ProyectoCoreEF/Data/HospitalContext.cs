using Microsoft.EntityFrameworkCore;
using ProyectoCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCoreEF.Data
{
    public class HospitalContext: DbContext
    {
        //NECESITAMOS UN CONSTRUCTOR OBLIGATORIO PARA PODER RECIBIR LA CADENA DE CONEXION POSTERIORMENTE
        public HospitalContext(DbContextOptions options) : base(options) { }

        //DEBEMOS MAPEAR CADA CLASE QUE TENGAMOS CON LA BBDD
        //DICHAS CLASES SON COLECCIONES DE TIPO DbSet
        //TANTAS TABLAS COMO TENGAMOS, TANTAS CLASES CON DbSet
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
