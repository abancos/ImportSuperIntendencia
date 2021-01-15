using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_MargenFinancieroNeto
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal MargenFinacieroNeto { get; set; }
        public decimal IngresosPorDiferenciaCambio { get; set; }
    }
}
