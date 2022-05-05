using Microsoft.EntityFrameworkCore.Migrations;

namespace InterestsApi.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Website_Interests_InterestId",
                table: "Website");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Website",
                table: "Website");

            migrationBuilder.RenameTable(
                name: "Website",
                newName: "Websites");

            migrationBuilder.RenameIndex(
                name: "IX_Website_InterestId",
                table: "Websites",
                newName: "IX_Websites_InterestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Websites",
                table: "Websites",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_Interests_InterestId",
                table: "Websites",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Interests_InterestId",
                table: "Websites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Websites",
                table: "Websites");

            migrationBuilder.RenameTable(
                name: "Websites",
                newName: "Website");

            migrationBuilder.RenameIndex(
                name: "IX_Websites_InterestId",
                table: "Website",
                newName: "IX_Website_InterestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Website",
                table: "Website",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Website_Interests_InterestId",
                table: "Website",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
