using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_AceptacionesCirculacion
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal AceptacionesCirculacion { get; set; }

        //Aceptaciones en Circulación
    }
}
