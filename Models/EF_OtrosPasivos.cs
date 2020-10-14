using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_OtrosPasivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal OtrosPasivos { get; set; }
        public decimal InteresesyComisiones { get; set; }
        public decimal Subtotal { get; set; }
        // Otros Pasivos
        // Intereses y comisiones devengados no cobrados(hasta mayo 2006)
        // subtotal


    }
}
