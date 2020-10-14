using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_BienesRecuperacionCreditos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public Decimal BienesRecuperacion { get; set; }
        public Decimal ProvisionRecuperacion { get; set; }
        public decimal Subtotal { get; set; }
        //Bienes Recibidos en Recuperación de Créditos
        //Bienes recibidos en recuperación de crédito
        //Provisión por bienes recibidos en recuperación de créditos
        //Subtotal

    }
}
