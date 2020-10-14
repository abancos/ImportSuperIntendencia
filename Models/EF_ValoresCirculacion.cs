using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_ValoresCirculacion
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal TitulosyValores { get; set; }
        public decimal InteresesporPagar { get; set; }
        public decimal Subtotal { get; set; }

        //Valores en Circulación
        //Títulos y valores
        //Intereses por pagar
        //Subtotal

    }
}
