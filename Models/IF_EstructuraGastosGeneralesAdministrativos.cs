using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_EstructuraGastosGeneralesAdministrativos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal SueldosCompensacionesPersonal { get; set; }
        public decimal OtrosGastosGenerales { get; set; }
        public decimal TotalGastosGeneralesAdministrativos { get; set; }
    }
}
