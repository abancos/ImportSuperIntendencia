using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class IF_Capital
    {
        [Key]
        public DateTime Fecha { get; set; }
        public decimal IndiceSolvencia { get; set; }
        public decimal Endeudamiento { get; set; }
        public decimal ActivosNeto { get; set; }
        public decimal CarteraCreditoVencida  { get; set; }
        public decimal CarteraCreditoBruta { get; set; }
        public decimal ActivosImproductivos { get; set; }
        public decimal OtrosActivos { get; set; }
        public decimal PatrimonioNetoActivosNetos { get; set; }
        public decimal PatrimonioNetoTotalPasivos { get; set; }
        public decimal PatrimonioNetoTotalCaptaciones { get; set; }
        public decimal PatrimonioNetoActivosNetosExcluyendoDisponibilidades { get; set; }
    }
}
