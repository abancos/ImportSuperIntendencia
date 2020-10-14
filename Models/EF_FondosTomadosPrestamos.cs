using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_FondosTomadosPrestamos
    {

        [Key]
        public DateTime Fecha { get; set; }
        public decimal BancoCentral { get; set; }
        public decimal InstitucionesPais { get; set; }
        public decimal InstitucionesExterior { get; set; }
        public decimal Otros { get; set; }
        public decimal InteresesPagar { get; set; }
        public decimal Subtotal { get; set; }

        //Fondos Tomados a Préstamo
        //Del Banco Central
        //De instituciones financieras del país
        //De instituciones financieras del exterior
        //Otros
        //Intereses por pagar
        //Subtotal

    }
}
