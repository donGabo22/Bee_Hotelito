using System;
using System.Collections.Generic;
using System.Text;

namespace EstandaresdeCalidad_Hotel.models
{
    class Reservaciones2
    {
        public int Id { get; set; }
        public string Nombre { get; set; }//nombre de cliente
        public string Apellido { get; set; }//apellido del cliente
        public int Telefono { get; set; }//telefono del cliente



        public DateTime FechaEntrada { get; set; } //fecha entrada
        public DateTime FechaSalida { get; set; } //fecha salida
        public double MontoFinal { get; set; } //Monto final
    }
}
