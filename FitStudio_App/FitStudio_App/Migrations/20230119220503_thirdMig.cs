using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitStudio_App.Migrations
{
    public partial class thirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_ClassId",
                table: "Employees",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Classes_ClassId",
                table: "Employees",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Classes_ClassId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ClassId",
                table: "Employees");
        }
    }
}
