using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class IF_Volumen
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal TotalActivosNetos { get; set; }
        public decimal TotalPasivos { get; set; }
        public decimal TotalPatrimonioNeto { get; set; }
    }
}
