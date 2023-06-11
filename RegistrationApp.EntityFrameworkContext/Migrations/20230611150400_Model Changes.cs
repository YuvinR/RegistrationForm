using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationApp.EntityFrameworkContext.Migrations
{
    /// <inheritdoc />
    public partial class ModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Registration",
                newName: "Remark");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Registration",
                newName: "Password");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Registration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Registration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "Registration",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Registration");

            migrationBuilder.RenameColumn(
                name: "Remark",
                table: "Registration",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Registration",
                newName: "FName");
        }
    }
}
