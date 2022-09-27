using Microsoft.EntityFrameworkCore.Migrations;

namespace Eindopdracht.Migrations
{
    public partial class Seedingdataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Marcel", "Koning" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Christian", "Koning" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
                values: new object[] { 1, 1, 2, 2, "Almere", "Netherlands", "Test omschrijving", "Test", "12", 0, 1, 1, "1234AB", 90f, false, "teststraat" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 2, 1, 1, 1, "Tokyo", "Japan", "Test omschrijving", "Test2", "69B", 1, 2, 2, "1234JP", 120f, false, "Akihabara" });
            
            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 3, 12, 25, 16, "Berlin", "Germany", "Test omschrijving", "Test3", "1", 2, 1, 1, "1234GE", 6000f, false, "Bergstraße" });
            
            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 4, 2, 5, 4, "London", "UK", "Test omschrijving", "Test4", "7", 3, 2, 1, "1234UK", 110f, true, "Birdcage Walk" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 5, 1, 1, 1, "New York", "USA", "Test omschrijving", "Test5", "255A", 4, 1, 1, "1234NY", 250f, false, "Madison Ave" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
               table: "Landlords",
               columns: new[] { "Id", "FirstName", "LastName" },
               values: new object[] { 1, "Marcel", "Koning" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Christian", "Koning" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 1, 1, 2, 2, "Almere", "Netherlands", "Test omschrijving", "Test", "12", 0, 1, 1, "1234AB", 90f, false, "teststraat" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 2, 1, 1, 1, "Tokyo", "Japan", "Test omschrijving", "Test2", "69B", 1, 2, 2, "1234JP", 120f, false, "Akihabara" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 3, 12, 25, 16, "Berlin", "Germany", "Test omschrijving", "Test", "1", 2, 1, 1, "1234GE", 6000f, false, "Bergstraße" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 4, 2, 5, 4, "London", "UK", "Test omschrijving", "Test", "7", 3, 2, 1, "1234UK", 110f, true, "Birdcage Walk" });

            migrationBuilder.InsertData(
               table: "Houses",
               columns: new[] { "Id", "BathroomTotal", "BedTotal", "BedroomTotal", "City", "Country", "HouseDescription", "HouseName", "HouseNumber", "HouseType", "LandlordId", "MaxPerson", "PostalCode", "Price", "SmokingAllowed", "Streetname" },
               values: new object[] { 5, 1, 1, 1, "New York", "USA", "Test omschrijving", "Test", "255A", 4, 1, 1, "1234NY", 250f, false, "Madison Ave" });
        }
    }
}
