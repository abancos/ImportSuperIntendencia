using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_ObligacionesRecompraTitulos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal RecompraTitulos { get; set; }

        //Obligaciones por Pactos de Recompra de Títulos
    }
}
