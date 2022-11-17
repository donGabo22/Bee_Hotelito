using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstandaresdeCalidad_Hotel.models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EstandaresCalidadHotel; Integrated Security=true")
                .EnableSensitiveDataLogging(true);
        }
        public DbSet<Registros> Registros { get; set; }
        public DbSet<Habitaciones> Habitacion { get; set; }

        public DbSet<Reservaciones> Reservacion { get; set; }
        public DbSet<Reservaciones2> Reservacion2 { get; set; }
        public DbSet<Reservaciones3> Reservacion3 { get; set; }
        public DbSet<Reservaciones4> Reservacion4 { get; set; }

    }

}
