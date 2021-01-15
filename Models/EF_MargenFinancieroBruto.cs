using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_MargenFinancieroBruto
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal MargenFinancieroBruto { get; set; }
        public decimal ProvisionesCarteraCreditos { get; set; }
        public decimal ProvisionInversiones { get; set; }
        public decimal Subtotal { get; set; }
    }
}
