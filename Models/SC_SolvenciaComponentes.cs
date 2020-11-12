using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    class SC_SolvenciaComponentes
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal PatrimonioTecnicoAjustado { get; set; }
        public decimal ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio { get; set; }
        public decimal CapitalRequeridoRiesgoMercado { get; set; }
        public decimal ActivosContingentesPonderadosRiesgosCreditíciosMercado { get; set; }
        public decimal IndiceSolvencia { get; set; }

    }
}
