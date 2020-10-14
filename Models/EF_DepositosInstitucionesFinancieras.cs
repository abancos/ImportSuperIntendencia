using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    class EF_DepositosInstitucionesFinancieras
    {

        [Key]
        public DateTime Fecha { get; set; }
        public decimal InstitucionesPais { get; set; }
        public decimal InstitucionesExterior { get; set; }
        public decimal InteresesPorPagar { get; set; }
        public decimal Subtotal { get; set; }

        //Depósitos de Instituciones Financieras del País y del Exterior
        //De instituciones financieras del país
        //De instituciones financieras del exterior
        //Intereses por pagar
        //Subtotal
        //93-96

    }
}
