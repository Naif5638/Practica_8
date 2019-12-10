using Practica_8.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8.Models.DAL
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext()
            : base("EmpleadoContext")
        {
        }
        
        //Se agregan las referencias a las tablas con la utilizacion del DbSet<>
        //haciendo referencia que cada tabla representa una clase o viceversa
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}
