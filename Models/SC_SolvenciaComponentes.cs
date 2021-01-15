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
        public double PatrimonioTecnicoAjustado { get; set; }
        public double ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio { get; set; }
        public double CapitalRequeridoRiesgoMercado { get; set; }
        public double ActivosContingentesPonderadosRiesgosCreditíciosMercado { get; set; }
        public double IndiceSolvencia { get; set; }

    }
}
