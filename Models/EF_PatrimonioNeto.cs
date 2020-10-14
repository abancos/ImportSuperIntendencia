using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImportSuperIntendencia.Models
{
    public class EF_PatrimonioNeto
    {

        [Key]
        public DateTime Fecha { get; set; }
        public decimal CapitalPagado { get; set; }
        public decimal ReservaLegalBancaria { get; set; }
        public decimal CapitalAdicionalPagado { get; set; }
        public decimal OtrasReservasPatrimoniales { get; set; }
        public decimal SuperavitporRevaluacion { get; set; }
        public decimal GanaciasNoRealizadas { get; set; }
        public decimal ResultadosAcumuladosEjerciciosAnt { get; set; }
        public decimal ResultadoDelEjercicio { get; set; }
        public decimal TotalPatrimonioNeto { get; set; }

        //Patrimonio Neto
        //Capital pagado
        //Reserva legal bancaria
        //Capital adicional pagado
        //Otras reservas patrimoniales
        //Superávit por revaluación
        //Ganancias(pérdidas) no realizadas en inversiones disponibles para la venta
        //Resultados acumulados de ejercicios anteriores
        //Resultados del ejercicio
        //TOTAL PATRIMONIO NETO

    }
}
