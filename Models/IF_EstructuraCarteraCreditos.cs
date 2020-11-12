using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_EstructuraCarteraCreditos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal CarteraCreditosVencida { get; set; }
        public decimal CarteraCreditosVigente { get; set; }
        public decimal TotalCarteraVencida { get; set; }
        public decimal TotalCarteraCreditoBruta { get; set; }
    }
}
