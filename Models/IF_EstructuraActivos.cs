using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_EstructuraActivos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal DisponibilidadNeta { get; set; }
        public decimal DisponibilidadExterior { get; set; }
        public decimal TotalCarteraCreditosNeta { get; set; }
        public decimal TotalInversionesNeta { get; set; }
        public decimal ActivosFijosNetos { get; set; }
        public decimal BienesRecibidosRecuperacionCreditosNetos { get; set; }
        public decimal OtrosActivosNetos { get; set; }
    }
}
