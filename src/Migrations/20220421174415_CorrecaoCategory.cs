using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWantApp.Migrations
{
    public partial class CorrecaoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EditenOn",
                table: "Products",
                newName: "EditeOn");

            migrationBuilder.RenameColumn(
                name: "CreateddBy",
                table: "Products",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "EditenOn",
                table: "Categories",
                newName: "EditeOn");

            migrationBuilder.RenameColumn(
                name: "CreateddBy",
                table: "Categories",
                newName: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EditeOn",
                table: "Products",
                newName: "EditenOn");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Products",
                newName: "CreateddBy");

            migrationBuilder.RenameColumn(
                name: "EditeOn",
                table: "Categories",
                newName: "EditenOn");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Categories",
                newName: "CreateddBy");
        }
    }
}
