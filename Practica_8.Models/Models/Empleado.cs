using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8.Models.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Fecha_Ingreso { get; set; }
        public virtual  ICollection<Registro> Registros { get; set; }
    }
}
