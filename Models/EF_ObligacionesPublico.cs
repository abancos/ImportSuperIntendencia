using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_ObligacionesPublico
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal ALaVista { get; set; }
        public decimal Ahorro { get; set; }
        public decimal Plazo { get; set; }
        public decimal InteresesPorPagar { get; set; }
        public decimal Subtotal { get; set; }

        /*
         * 81-85
         Obligaciones con el Público
        A la vista
        De ahorro
        A plazo
        Intereses por pagar
        Subtotal
         */
    }
}
