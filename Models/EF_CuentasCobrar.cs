using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_CuentasCobrar
    {
        [Key]
        public DateTime Fecha { get; set; }
        public Decimal CuentasCobrar { get; set; }
        public Decimal RendimientosCobrar { get; set; }
        public decimal Subtotal { get; set; }
    }
}
