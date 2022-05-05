using Microsoft.EntityFrameworkCore.Migrations;

namespace InterestsApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[] { 1, "Erik Filipsson", "070-3272032" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[] { 2, "Erik Filipsson", "070-3272032" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[] { 3, "Erik Filipsson", "070-3272032" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[] { 1, "Fiske", "www.edgeflyfishing.com", 1 });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[] { 2, "Höjdhopp", "www.hojdhopp.se", 2 });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[] { 3, "Utveckling", "www.stackoverflow.com", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
