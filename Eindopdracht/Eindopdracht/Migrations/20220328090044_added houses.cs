using Microsoft.EntityFrameworkCore.Migrations;

namespace Eindopdracht.Migrations
{
    public partial class addedhouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandlordId = table.Column<int>(type: "int", nullable: true),
                    HouseType = table.Column<string>(type: "int", nullable: true),
                    MaxPerson = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    BedroomTotal = table.Column<int>(type: "int", nullable: false),
                    BedTotal = table.Column<int>(type: "int", nullable: false),
                    BathroomTotal = table.Column<int>(type: "int", nullable: false),
                    SmokingAllowed = table.Column<bool>(type: "bit", nullable: false),
                    Streetname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Landlords_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_LandlordId",
                table: "Houses",
                column: "LandlordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
