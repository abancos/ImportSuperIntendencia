using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_Inversiones
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal Negociables { get; set; }
        public decimal DisponiblesVenta { get; set; }
        public decimal MantenidasVencimiento { get; set; }
        public decimal InversionesInstDeudas { get; set; }
        public decimal InversionesDepositosValores { get; set; }
        public decimal RendimientoPorCobrar { get; set; }
        public decimal ProvisionInversiones { get; set; }
        public decimal Subtotal { get; set; }

    }
}
