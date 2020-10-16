using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_OtrosIngresos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal OtrosIngresos { get; set; }
        public decimal OtrosGastos { get; set; }
        public decimal Subtotal { get; set; }
        //Otros ingresos(gastos)
        //Otros ingresos
        //Otros gastos
        //Subtotal

    }
}
