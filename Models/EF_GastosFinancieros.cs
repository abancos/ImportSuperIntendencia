using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_GastosFinancieros
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal InteresesporCaptaciones{ get; set; }
        public decimal PerdidasporInversiones { get; set; }
        public decimal InteresesComisionesFinanciamiento { get; set; }
        public decimal Subtotal { get; set; }

        //Gastos financieros
        //Intereses por captaciones
        //Pérdidas por inversiones
        //Intereses y comisiones por financiamientos
        //Subtotal

    }
}
