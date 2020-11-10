using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class CC_CarteraCreditoBancosMultiples
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal CreditosComercialesMayoresDeudoresMN { get; set; }
        public decimal CreditosComercialesMedianosDeudoresMN { get; set; }
        public decimal CreditosComercialesMenoresDeudoresMN { get; set; }
        public decimal CreditosComercialesMicrocreditoMN { get; set; }
        public decimal CreditosAtravesTarjetasCreditosPersonalesMN { get; set; }
        public decimal CreditosConsumoMN { get; set; }
        public decimal CreditosHipotecariosMN { get; set; }
        public decimal CreditosComercialesMayoresDeudoresEXT { get; set; }
        public decimal CreditosComercialesMedianosDeudoresEXT { get; set; }
        public decimal CreditosComercialesMenoresDeudoresEXT { get; set; }
        public decimal CreditosComercialesMicrocreditoEXT { get; set; }
        public decimal CreditosAtravesTarjetasCreditosPersonalesEXT { get; set; }
        public decimal CreditosConsumoEXT { get; set; }
        public decimal CreditosHipotecariosEXT { get; set; }
        public decimal GrandTotal { get; set; }

    }
}
