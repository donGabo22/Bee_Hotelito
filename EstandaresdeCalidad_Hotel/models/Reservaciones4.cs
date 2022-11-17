using System;
using System.Collections.Generic;
using System.Text;

namespace EstandaresdeCalidad_Hotel.models
{
    class Reservaciones4
    {
        public int Id { get; set; }
        public string Nombre { get; set; }//nombre de cliente
        public string Apellido { get; set; }//apellido del cliente
        public string Telefono { get; set; }//telefono del cliente

        public string TipoHabitacion { get; set; }//tipo de habitacion
        public string NumeroHabitacion { get; set; }//numero de habitacion
        public double Precio { get; set; }//precio del cuarto
        public string Status { get; set; }//disponibilidad del cuarto
        public DateTime FechaEntrada { get; set; } //fecha entrada
        public DateTime FechaSalida { get; set; } //fecha salida
        public double MontoFinal { get; set; } //Monto final
    }
}
