using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    class EF_ObligacionesSubordinadas
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal DeudasSubordinadas { get; set; }
        public decimal InteresesporPagar { get; set; }
        public decimal Subtotal { get; set; }
        //Obigaciones Subordinadas
        //Deudas subordinadas
        //Intereses por pagar
        //Subtotal

    }
}
