using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    class EF_CarteraCreditos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public Decimal Vigente { get; set; }
        public Decimal Reestructurada { get; set; }
        public Decimal Vencida { get; set; }
        public Decimal CobranzaJudicial { get; set; }
        public Decimal RendimientosCobrar { get; set; }
        public Decimal ProvisionesCredito { get; set; }
        public decimal Subtotal { get; set; }

    }
}
