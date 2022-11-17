using System;
using System.Collections.Generic;
using System.Text;

namespace EstandaresdeCalidad_Hotel.models
{
    class Habitaciones
    {
        public int Id { get; set; }
        public int NumeroHabitacion { get; set; }//numero de habitacion
        public string TipoHabitacion { get; set; }//tipo de habitacion
        public double Precio { get; set; }//precio del cuarto
        public string Status { get; set; }//disponibilidad del cuarto
    }
}
