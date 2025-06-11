using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCheck_Employees_EmployeeId",
                table: "HealthCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_Employees_EmployeeId",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_SickLeave_Employees_EmployeeId",
                table: "SickLeave");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacation_Employees_EmployeeId",
                table: "Vacation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacation",
                table: "Vacation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SickLeave",
                table: "SickLeave");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loan",
                table: "Loan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitle",
                table: "JobTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthCheck",
                table: "HealthCheck");

            migrationBuilder.RenameTable(
                name: "Vacation",
                newName: "Vacations");

            migrationBuilder.RenameTable(
                name: "SickLeave",
                newName: "SickLeaves");

            migrationBuilder.RenameTable(
                name: "Loan",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "JobTitle",
                newName: "JobTitles");

            migrationBuilder.RenameTable(
                name: "HealthCheck",
                newName: "HealthChecks");

            migrationBuilder.RenameIndex(
                name: "IX_Vacation_EmployeeId",
                table: "Vacations",
                newName: "IX_Vacations_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SickLeave_EmployeeId",
                table: "SickLeaves",
                newName: "IX_SickLeaves_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Loan_EmployeeId",
                table: "Loans",
                newName: "IX_Loans_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthCheck_EmployeeId",
                table: "HealthChecks",
                newName: "IX_HealthChecks_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Loans",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacations",
                table: "Vacations",
                column: "VacationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SickLeaves",
                table: "SickLeaves",
                column: "SickLeaveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loans",
                table: "Loans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthChecks",
                table: "HealthChecks",
                column: "HealthCheckId");

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_EquipmentId",
                table: "Loans",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthChecks_Employees_EmployeeId",
                table: "HealthChecks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Employees_EmployeeId",
                table: "Loans",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Equipment_EquipmentId",
                table: "Loans",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SickLeaves_Employees_EmployeeId",
                table: "SickLeaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employees_EmployeeId",
                table: "Vacations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthChecks_Employees_EmployeeId",
                table: "HealthChecks");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Employees_EmployeeId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Equipment_EquipmentId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_SickLeaves_Employees_EmployeeId",
                table: "SickLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employees_EmployeeId",
                table: "Vacations");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacations",
                table: "Vacations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SickLeaves",
                table: "SickLeaves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loans",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_EquipmentId",
                table: "Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthChecks",
                table: "HealthChecks");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Loans");

            migrationBuilder.RenameTable(
                name: "Vacations",
                newName: "Vacation");

            migrationBuilder.RenameTable(
                name: "SickLeaves",
                newName: "SickLeave");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loan");

            migrationBuilder.RenameTable(
                name: "JobTitles",
                newName: "JobTitle");

            migrationBuilder.RenameTable(
                name: "HealthChecks",
                newName: "HealthCheck");

            migrationBuilder.RenameIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacation",
                newName: "IX_Vacation_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SickLeaves_EmployeeId",
                table: "SickLeave",
                newName: "IX_SickLeave_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_EmployeeId",
                table: "Loan",
                newName: "IX_Loan_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthChecks_EmployeeId",
                table: "HealthCheck",
                newName: "IX_HealthCheck_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacation",
                table: "Vacation",
                column: "VacationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SickLeave",
                table: "SickLeave",
                column: "SickLeaveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loan",
                table: "Loan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitle",
                table: "JobTitle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthCheck",
                table: "HealthCheck",
                column: "HealthCheckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCheck_Employees_EmployeeId",
                table: "HealthCheck",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_Employees_EmployeeId",
                table: "Loan",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SickLeave_Employees_EmployeeId",
                table: "SickLeave",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacation_Employees_EmployeeId",
                table: "Vacation",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
