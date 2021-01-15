using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_ResultadoOperacional
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal ResultadoOperacional { get; set; }
        public decimal OtrosIngresosGastos { get; set; }
        public decimal OtrosIngresos { get; set; }
        public decimal OtrosGastos { get; set; }
        public decimal Subtotal { get; set; }
    }
}
