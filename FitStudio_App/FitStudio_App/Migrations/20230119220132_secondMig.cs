using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitStudio_App.Migrations
{
    public partial class secondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Employees_EmployeeId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_EmployeeId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_EmployeeId",
                table: "Classes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Employees_EmployeeId",
                table: "Classes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
