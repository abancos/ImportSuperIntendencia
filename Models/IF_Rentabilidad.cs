using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_Rentabilidad
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal ROA { get; set; }
        public decimal REA { get; set; }
        public decimal IngresosFinancieros { get; set; }
        public decimal MargenFinancieroBruto { get; set; }
        public decimal ActivosProductivos { get; set; }
        public decimal MargenFinancieroBrutoMIN { get; set; }
    }
}
