using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_OtrosIngresosOperacionales
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal ComisionesporServicios { get; set; }
        public decimal ComisionesporCambio { get; set; }
        public decimal IngresosDiversos { get; set; }
        public decimal Subtotal { get; set; }

        //Otros ingresos operacionales
        //Comisiones por servicios
        //Comisiones por cambio
        //Ingresos diversos
        //Subtotal

    }
}
