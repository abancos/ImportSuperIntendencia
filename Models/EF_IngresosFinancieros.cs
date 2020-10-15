using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
  public  class EF_IngresosFinancieros
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal InteresesComisionesCredito { get; set; }
        public decimal InteresesInversiones { get; set; }
        public decimal GananciasInversiones { get; set; }
        public decimal Subtotal { get; set; }

        //        Ingresos financieros
        //Intereses y comisiones por crédito
        //Intereses por inversiones
        //Ganancia por inversiones
        //Subtotal

    }
}
