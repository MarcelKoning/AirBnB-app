using Microsoft.EntityFrameworkCore.Migrations;

namespace Eindopdracht.Migrations
{
    public partial class @enum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HouseType",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HouseName", "HouseType" },
                values: new object[] { "Test2", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HouseType",
                table: "Houses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HouseName", "HouseType" },
                values: new object[] { "Test", 2 });
        }
    }
}
