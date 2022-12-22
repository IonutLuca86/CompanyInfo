using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyInfo.Data.Migrations
{
    public partial class FirstCreateAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrganisationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MainOffice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartamentsNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentsNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentNameID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departaments_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Departaments_DepartamentsNames_DepartamentNameID",
                        column: x => x.DepartamentNameID,
                        principalTable: "DepartamentsNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnionMember = table.Column<bool>(type: "bit", nullable: true),
                    DepartamentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departaments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => new { x.EmployeeId, x.JobId });
                    table.ForeignKey(
                        name: "FK_Positions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName", "MainOffice", "OrganisationNumber" },
                values: new object[,]
                {
                    { 1, "Company1", "Stockholm", "08-123456" },
                    { 2, "Company2", "Oslo", "01-123456" },
                    { 3, "Company3", "Helsinki", "12-456789" },
                    { 4, "Company4", "Köpenhamn", "31-123456" }
                });

            migrationBuilder.InsertData(
                table: "DepartamentsNames",
                columns: new[] { "Id", "DepartamentName" },
                values: new object[,]
                {
                    { 1, "Administration" },
                    { 2, "Marketing" },
                    { 3, "HR" },
                    { 4, "Accounting" },
                    { 5, "IT" },
                    { 6, "Legal" },
                    { 7, "Production" },
                    { 8, "Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "JobDescription", "JobName" },
                values: new object[,]
                {
                    { 1, "Money Handler", "Accountant" },
                    { 2, "I love Humans", "HR Manager" },
                    { 3, "Company geek", "C# Developer" },
                    { 4, "Can sell anything", "Sales Representative" },
                    { 5, "the little boss", "Product manager" },
                    { 6, "Keeps trouble away", "Lawyer" },
                    { 7, "Everything needs to be clean", "Maintenance personnel" },
                    { 8, "http", "Network Engeneer" },
                    { 9, "TechSupport", "IT Specialist" },
                    { 10, "work in progress", "Intership Personnel" },
                    { 11, "the high chief", "CEO" },
                    { 12, "Another geek", "Product Engeneer" }
                });

            migrationBuilder.InsertData(
                table: "Departaments",
                columns: new[] { "Id", "CompanyID", "DepartamentNameID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 2, 1 },
                    { 10, 2, 2 },
                    { 11, 2, 3 },
                    { 12, 2, 4 },
                    { 13, 2, 5 },
                    { 14, 2, 6 },
                    { 15, 2, 7 },
                    { 16, 2, 8 },
                    { 17, 3, 1 },
                    { 18, 3, 2 },
                    { 19, 3, 3 },
                    { 20, 3, 4 },
                    { 21, 3, 5 },
                    { 22, 3, 6 },
                    { 23, 3, 7 },
                    { 24, 3, 8 },
                    { 25, 4, 1 },
                    { 26, 4, 2 },
                    { 27, 4, 3 },
                    { 28, 4, 4 },
                    { 29, 4, 5 },
                    { 30, 4, 6 },
                    { 31, 4, 7 },
                    { 32, 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartamentId", "FirstName", "LastName", "Salary", "UnionMember" },
                values: new object[,]
                {
                    { 1, 1, "FName1", "LName1", 95000m, false },
                    { 2, 2, "FName2", "LName2", 40000m, true },
                    { 3, 3, "FName3", "LName3", 50000m, true },
                    { 4, 4, "FName4", "LName4", 50000m, true },
                    { 5, 6, "FName5", "LName5", 70000m, false },
                    { 6, 7, "FName6", "LName6", 70000m, false },
                    { 7, 7, "FName7", "LName7", 45000m, false },
                    { 8, 8, "FName8", "LName8", 44000m, true },
                    { 9, 1, "FName9", "LName9", 25000m, true },
                    { 10, 5, "FName10", "LName10", 45000m, false },
                    { 11, 5, "FName11", "LName11", 35000m, true },
                    { 12, 2, "FName12", "LName12", 35000m, false },
                    { 13, 2, "FName13", "LName13", 30000m, true },
                    { 14, 5, "FName14", "LName14", 0m, false },
                    { 15, 21, "FName15", "LName15", 35000m, false },
                    { 16, 13, "FName16", "LName16", 45000m, true },
                    { 17, 9, "FName17", "LName17", 45000m, false },
                    { 18, 11, "FName18", "LName18", 35000m, false },
                    { 19, 10, "FName19", "LName19", 35000m, true },
                    { 20, 13, "FName20", "LName20", 45000m, true },
                    { 21, 14, "FName21", "LName21", 35000m, false },
                    { 22, 17, "FName22", "LName22", 25000m, true },
                    { 23, 25, "FName23", "LName23", 25000m, false }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "EmployeeId", "JobId" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 2, 4 },
                    { 3, 2 },
                    { 4, 1 },
                    { 5, 6 },
                    { 6, 12 },
                    { 7, 9 },
                    { 8, 12 },
                    { 9, 8 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 4 },
                    { 13, 10 },
                    { 14, 10 },
                    { 15, 9 },
                    { 16, 9 },
                    { 17, 11 },
                    { 18, 2 },
                    { 19, 4 },
                    { 20, 3 },
                    { 21, 6 },
                    { 22, 7 },
                    { 23, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departaments_CompanyID",
                table: "Departaments",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Departaments_DepartamentNameID",
                table: "Departaments",
                column: "DepartamentNameID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartamentId",
                table: "Employees",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_JobId",
                table: "Positions",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Departaments");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "DepartamentsNames");
        }
    }
}
