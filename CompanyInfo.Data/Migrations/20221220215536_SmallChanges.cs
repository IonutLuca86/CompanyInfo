using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyInfo.Data.Migrations
{
    public partial class SmallChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departaments_DepartamentsNames_DepartamentNameID",
                table: "Departaments");

            migrationBuilder.DropIndex(
                name: "IX_Departaments_DepartamentNameID",
                table: "Departaments");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentsNameId",
                table: "Departaments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EmployeeId",
                table: "Positions",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobId",
                table: "Employees",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Departaments_DepartamentsNameId",
                table: "Departaments",
                column: "DepartamentsNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departaments_DepartamentsNames_DepartamentsNameId",
                table: "Departaments",
                column: "DepartamentsNameId",
                principalTable: "DepartamentsNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_JobId",
                table: "Employees",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departaments_DepartamentsNames_DepartamentsNameId",
                table: "Departaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_JobId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Positions_EmployeeId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departaments_DepartamentsNameId",
                table: "Departaments");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartamentsNameId",
                table: "Departaments");

            migrationBuilder.CreateIndex(
                name: "IX_Departaments_DepartamentNameID",
                table: "Departaments",
                column: "DepartamentNameID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departaments_DepartamentsNames_DepartamentNameID",
                table: "Departaments",
                column: "DepartamentNameID",
                principalTable: "DepartamentsNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
