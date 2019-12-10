using Practica_8.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8.Models.DAL
{
    public class SeedDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpleadoContext>
    {
        protected override void Seed(EmpleadoContext context)
        {
            var departamentos = new List<Departamento>
            {
                new Departamento {Descripcion = "Programacion"},
                new Departamento {Descripcion = "Recursos Humanos"},
                new Departamento {Descripcion = "Mercadeo"}
            };
            departamentos.ForEach(d => context.Departamentos.Add(d));
            context.SaveChanges();

            var empleados = new List<Empleado>
            {
                new Empleado{Nombres = "Juan Carlos", Apellidos = "Reyes Jimenez", Fecha_Ingreso = DateTime.Parse("2001-09-01")},
                new Empleado{Nombres = "Belkis", Apellidos = "Sandoval Polanco", Fecha_Ingreso = DateTime.Parse("2002-10-25")},
                new Empleado{Nombres = "Jean Carlos", Apellidos = "Reyes Sandoval", Fecha_Ingreso = DateTime.Parse("2003-01-16")},
                new Empleado{Nombres = "Josue", Apellidos = "Reyes Jimenez", Fecha_Ingreso = DateTime.Parse("2003-09-15")},
            };
            empleados.ForEach(e => context.Empleados.Add(e));
            context.SaveChanges();

            var registros = new List<Registro>
            {
                new Registro {EmpleadoId = 1, DepartamentoId = 1, Sueldo = Convert.ToDecimal(100000.00)},
                new Registro {EmpleadoId = 2, DepartamentoId = 1, Sueldo = Convert.ToDecimal(25000.00)},
                new Registro {EmpleadoId = 3, DepartamentoId = 2, Sueldo = Convert.ToDecimal(15400.00)},
                new Registro {EmpleadoId = 4, DepartamentoId = 2, Sueldo = Convert.ToDecimal(12500.00)}
            };
            registros.ForEach(r => context.Registros.Add(r));
            context.SaveChanges();
        }
    }
}
