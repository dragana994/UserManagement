using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Infrastructure.Persistence.Migrations
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
                    { 1, "V125", new DateTime(2022, 9, 7, 19, 19, 56, 641, DateTimeKind.Local).AddTicks(5807), "View", null },
                    { 2, "C125", new DateTime(2022, 9, 7, 19, 19, 56, 644, DateTimeKind.Local).AddTicks(4333), "Create", null },
                    { 3, "D125", new DateTime(2022, 9, 7, 19, 19, 56, 644, DateTimeKind.Local).AddTicks(4372), "Delete", null },
                    { 4, "E525", new DateTime(2022, 9, 7, 19, 19, 56, 644, DateTimeKind.Local).AddTicks(4378), "Edit", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Created", "Email", "FirstName", "LastModified", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 110, false, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1513), "lmegroffa@dell.com", "Lulu", null, "Megroff", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "lmegroffa" },
                    { 109, false, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1508), "estreetfield9@typepad.com", "Edeline", null, "Streetfield", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "estreetfield9" },
                    { 108, false, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1503), "lmaunders8@histats.com", "Luis", null, "Maunders", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "lmaunders8" },
                    { 107, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1497), "kturnbull7@buzzfeed.com", "Kinnie", null, "Turnbull", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "kturnbull7" },
                    { 106, false, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1492), "rcreeghan6@mashable.com", "Reba", null, "Creeghan", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "rcreeghan6" },
                    { 104, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1481), "tfellibrand4@csmonitor.com", "Thornie", null, "Fellibrand", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "tfellibrand4" },
                    { 111, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1578), "cjopeb@walmart.com", "Carlotta", null, "Jope", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "cjopeb" },
                    { 103, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1476), "kboutwell3@squarespace.com", "Kacy", null, "Boutwell", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "kboutwell3" },
                    { 102, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1470), "mobispo2@etsy.com", "Mill", null, "Obispo", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "mobispo2" },
                    { 101, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1465), "tsnedker1@ucsd.edu", "Thatch", null, "Snedker", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "tsnedker1" },
                    { 100, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1415), "zdunlap0@comsenz.com", "Zsa zsa", null, "Dunlap", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "zdunlap0" },
                    { 105, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1486), "hpodd5@freewebs.com", "Hy", null, "Podd", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "hpodd5" },
                    { 112, true, new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1585), "ljosephyc@mapquest.com", "Lyndsey", null, "Josephy", "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=", "ljosephyc" }
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112);
        }
    }
}
