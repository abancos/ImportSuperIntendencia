using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    class EF_PropiedadMueblesEquipos
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal PropiedadMueblesEquipos { get; set; }
        public decimal DepreciacionAcumulada { get; set; }
        public decimal Subtotal { get; set; }
        /*
        Propiedad, Muebles y Equipos
        Propiedad, muebles y equipos
        Depreciación acumulada
        Subtotal
        */
    }
}
