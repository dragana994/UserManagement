using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UserManagement.Infrastructure.Presistance.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Created", "Description", "LastModified" },
                values: new object[,]
                {
                    { 1, "V125", new DateTime(2022, 9, 6, 18, 58, 38, 152, DateTimeKind.Local).AddTicks(7106), "View", null },
                    { 2, "C125", new DateTime(2022, 9, 6, 18, 58, 38, 154, DateTimeKind.Local).AddTicks(6049), "Create", null },
                    { 3, "D125", new DateTime(2022, 9, 6, 18, 58, 38, 154, DateTimeKind.Local).AddTicks(6075), "Delete", null },
                    { 4, "E525", new DateTime(2022, 9, 6, 18, 58, 38, 154, DateTimeKind.Local).AddTicks(6079), "Edit", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
