using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSystem.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardType",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "SeatNum",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "PassengerNum",
                table: "Flights",
                newName: "PassengerCapacity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassengerCapacity",
                table: "Flights",
                newName: "PassengerNum");

            migrationBuilder.AddColumn<bool>(
                name: "CardType",
                table: "Payment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "SeatNum",
                table: "Flights",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
