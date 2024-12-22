using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class NewF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeCity",
                table: "Employees",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeCity",
                table: "Employees");
        }
    }
}
