using Microsoft.EntityFrameworkCore.Migrations;

namespace EstandaresdeCalidad_Hotel.Migrations
{
    public partial class M7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroHabitacion",
                table: "Reservacion");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Reservacion");

            migrationBuilder.DropColumn(
                name: "TipoHabitacion",
                table: "Reservacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroHabitacion",
                table: "Reservacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "Reservacion",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TipoHabitacion",
                table: "Reservacion",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
