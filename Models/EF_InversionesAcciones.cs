using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    class EF_InversionesAcciones
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal InversionesAcciones { get; set; }
        public decimal ProvisionInversionesAcciones { get; set; }
        public decimal Subtotal { get; set; }

        /* Inversiones en Acciones
        Inversiones en acciones
        Provisión por inversiones en acciones
        Subtotal
        */
    }
}
