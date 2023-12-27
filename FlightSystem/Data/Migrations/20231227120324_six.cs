using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSystem.Data.Migrations
{
    public partial class six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PassengerId",
                table: "Payment",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Passengers_PassengerId",
                table: "Payment",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Passengers_PassengerId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_PassengerId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Payment");
        }
    }
}
