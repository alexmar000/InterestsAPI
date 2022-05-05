using Microsoft.EntityFrameworkCore.Migrations;

namespace InterestsApi.Migrations
{
    public partial class websites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Website",
                columns: new[] { "Id", "InterestId", "Title", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Edge Flyfishing Forum", "www.edgeflyfishing.com" },
                    { 2, 1, "Nedre Ljungan", "www.flugfiskenedreljungan.com" },
                    { 3, 2, "Höjdhopparna", "www.hojdhopp.se" },
                    { 4, 3, "Utvecklarforum", "www.stackoverflow.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Website",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Website",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Website",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Website",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
