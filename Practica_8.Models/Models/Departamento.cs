using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8.Models.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
