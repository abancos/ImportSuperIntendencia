using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_FondosInterbancariosPasivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal FondosBancarios { get; set; }
        public decimal InteresesPorPagar { get; set; }
        public decimal Subtotal { get; set; }

        //Fondos Interbancarios
        //Fondos interbancarios
        //Intereses por pagar
        //Subtotal

    }
}
