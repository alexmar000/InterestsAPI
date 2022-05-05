using Microsoft.EntityFrameworkCore.Migrations;

namespace InterestsApi.Migrations
{
    public partial class seedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "070-6224012");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "070-7823122");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "070-3272032");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "070-3272032");
        }
    }
}
