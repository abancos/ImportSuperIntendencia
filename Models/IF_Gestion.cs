using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_Gestion
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal TotalGastosGeneralesAdministrativosTotalCaptaciones { get; set; }
        public decimal GastosExplotacionMargenOperacionalBruto { get; set; }
        public decimal GastosFinancierosCaptacionesCaptacionesCosto { get; set; }
        public decimal GastosFinancierosTotalCaptacionesObligCosto        { get; set; }
        public decimal GastosFinancierosCaptacionesCostosObligacionesCosto { get; set; }
        public decimal TotalGastosGeneralesAdministTotalCaptacionesObligCosto { get; set; }
        public decimal GastosFinancierosActivosProductivosCE { get; set; }
        public decimal GastosFinancierosActivosFinancierosCF { get; set; }
        public decimal GastosFinancierosIngresosFinancieros { get; set; }
        public decimal GastosOperacionalesIngresosOperacionalesBrutos { get; set; }
        public decimal TotalGastosGeneralesAdministrativosActivosTotales { get; set; }
        public decimal GastosExplotacionActivosProductivos { get; set; }
        public decimal GastoPersonalGastosExplotacion { get; set; }
    }
}
