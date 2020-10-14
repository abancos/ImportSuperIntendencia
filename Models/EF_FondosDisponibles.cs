using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_FondosDisponibles
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal Caja { get; set; }
        public decimal BancoCentral { get; set; }
        public decimal BancosPais { get; set; }
        public decimal BancosExtranjeros { get; set; }
        public decimal Otras { get; set; }
        public decimal RendimientosCobrar { get; set; }
        public decimal Subtotal { get; set; }
    }
}
