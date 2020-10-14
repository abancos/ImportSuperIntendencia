using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_TotalActivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal TotalActivos { get; set; }
        public decimal CuentasContingentes { get; set; }
        public decimal CuentasOrden { get; set; }


        //Cuentas Contingentes
        //Cuentas de Orden

    }
}
