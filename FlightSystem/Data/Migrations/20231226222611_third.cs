using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSystem.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessClass",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "EconomyClass",
                table: "Flights");

            migrationBuilder.AddColumn<string>(
                name: "TicketType",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessClassPrice",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EconomyClassPrice",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketType",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "BusinessClassPrice",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "EconomyClassPrice",
                table: "Flights");

            migrationBuilder.AddColumn<double>(
                name: "BusinessClass",
                table: "Flights",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EconomyClass",
                table: "Flights",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
