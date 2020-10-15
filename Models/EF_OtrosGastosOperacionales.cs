using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_OtrosGastosOperacionales
    {

        [Key]
        public DateTime Fecha { get; set; }
        public decimal ComisionesporServicios { get; set; }
        public decimal GastosDiversos { get; set; }
        public decimal Subtotal { get; set; }

        //Otros gastos operacionales
        //Comisiones por servicios
        //Gastos diversos
        //Subtotal

    }
}
