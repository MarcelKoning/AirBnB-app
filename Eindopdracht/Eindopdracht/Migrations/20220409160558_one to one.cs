using Microsoft.EntityFrameworkCore.Migrations;

namespace Eindopdracht.Migrations
{
    public partial class onetoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReservationId",
                table: "Customers",
                column: "ReservationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ReservationId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
