using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsWorkApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddUserCredentialsToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employees",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "CarePackages",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FeeTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: (short)1);
        }
    }
}
