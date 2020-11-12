using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_Liquidez
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal TotalCaptacionesObligConCosto { get; set; }
        public decimal TotalCaptaciones { get; set; }
        public decimal TotalDepositos { get; set; }
        public decimal TotalActivos { get; set; }
        public decimal ActivosProductivos { get; set; }
    }
}
