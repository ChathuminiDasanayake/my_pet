using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPet.DataAccess.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 4, 13, 52, 20, 822, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Catogery", "Color", "Date", "Name", "Status" },
                values: new object[] { 2, "Dog", "Brown", new DateTime(2024, 7, 4, 13, 52, 20, 827, DateTimeKind.Local).AddTicks(5238), "Chooty", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 4, 13, 33, 23, 989, DateTimeKind.Local).AddTicks(5674));
        }
    }
}
