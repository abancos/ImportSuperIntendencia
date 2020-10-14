using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_DeudoresAceptacion
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal DeudoresAceptacion { get; set; }
    }
}
