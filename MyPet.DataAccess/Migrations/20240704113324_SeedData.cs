using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPet.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Catogery", "Color", "Date", "Name", "Status" },
                values: new object[] { 1, "Dog(DB)", "Black & White", new DateTime(2024, 7, 4, 13, 33, 23, 989, DateTimeKind.Local).AddTicks(5674), "Blacky", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
