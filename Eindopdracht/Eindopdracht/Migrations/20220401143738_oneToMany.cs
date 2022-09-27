using Microsoft.EntityFrameworkCore.Migrations;

namespace Eindopdracht.Migrations
{
    public partial class oneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Landlords_LandlordId",
                table: "Houses");

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "LandlordId",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Marcel", "Koning" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Christian", "Koning" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "LandlordId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Landlords_LandlordId",
                table: "Houses",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Landlords_LandlordId",
                table: "Houses");

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "LandlordId",
                table: "Houses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "LandlordId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Marcel", "Koning" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Christian", "Koning" });

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Landlords_LandlordId",
                table: "Houses",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
