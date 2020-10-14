using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
   public class EF_OtrosActivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal CargosDiferidos { get; set; }
        public decimal Intangibles { get; set; }
        public decimal ActivosDiversos { get; set; }
        public decimal AmortizacionAcumulada { get; set; }
        public decimal Subtotal { get; set; }
      /*  Otros Activos
            Cargos diferidos
            Intangibles
            Activos diversos
            Amortización acumulada
            Subtotal
      */

    }
}
