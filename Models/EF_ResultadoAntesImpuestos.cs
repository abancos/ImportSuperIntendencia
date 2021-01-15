using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_ResultadoAntesImpuestos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal ResultadoAntesImpuestos { get; set; }
        public decimal ImpuestosSobreLaRenta { get; set; }
        public decimal ResultadoEjercicio { get; set; }
    }
}
