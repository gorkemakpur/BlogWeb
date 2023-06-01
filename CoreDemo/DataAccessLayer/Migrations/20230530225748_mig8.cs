using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Writers_CityID",
                table: "Writers",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cities_CityID",
                table: "Writers",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cities_CityID",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_CityID",
                table: "Writers");
        }
    }
}
