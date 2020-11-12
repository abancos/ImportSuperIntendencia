using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_EstructuraPasivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal TotalPasivos { get; set; }
        public decimal CarteraCreditosBruta { get; set; }
        public decimal TotalCaptaciones { get; set; }
        public decimal ValoresCirculacionPublico { get; set; }
        public decimal TotalDepositos { get; set; }
        public decimal DepositosALaVista { get; set; }
        public decimal DepositosAhorro { get; set; }
        public decimal DepositosPlazo { get; set; }
    }
}
