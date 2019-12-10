using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8.Models.Models
{
    public class Registro
    {
        [Key]
        public int RegistroId { get; set; }
        public Nullable<decimal> Sueldo { get; set; }
        public int DepartamentoId { get; set; }
        public int EmpleadoId { get; set; }

        public virtual Departamento Departamento { get; set; }
        public  virtual Empleado Empleado { get; set; }
    }
}
