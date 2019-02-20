using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTrackingSystem.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CertificationEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertificationStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CertificationType",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LicenseNumber",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CertificationEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CertificationStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CertificationType",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LicenseNumber",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Email");
        }
    }
}
