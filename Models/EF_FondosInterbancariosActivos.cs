using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_FondosInterbancariosActivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal FondosBancarios {get;set;}
        [Column(TypeName = "decimal(16,4)")]
        public decimal RendimientosporCobrar { get; set; }
        public decimal Subtotal { get; set; }

    }
}
