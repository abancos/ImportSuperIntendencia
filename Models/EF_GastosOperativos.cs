using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_GastosOperativos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal SueldosCompensacionesPersonal { get; set; }
        public decimal ServiciosATerceros { get; set; }
        public decimal DepreciacionAmortizaciones { get; set; }
        public decimal OtrasProvisiones { get; set; }
        public decimal OtrosGastos { get; set; }
        public decimal Subtotal { get; set; }

        //Gastos operativos
        //Sueldos y compensaciones al personal
        //Servicios a terceros
        //Depreciación y Amortizaciones
        //Otras provisiones
        //Otros gastos
        //Subtotal

    }
}
