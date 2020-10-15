using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_TotaldePasivosPatrimonio
    {

        [Key]
        public DateTime Fecha { get; set; }
        public decimal TotalPasivosPatrimonio { get; set; }
        public decimal CuentasContingentes { get; set; }
        public decimal CuentasOrden { get; set; }

        //TOTAL DE PASIVOS Y PATRIMONIO
        //Cuentas Contingentes
        //Cuentas de Orden

    }
}
