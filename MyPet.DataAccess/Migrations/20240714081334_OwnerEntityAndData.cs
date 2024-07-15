using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPet.DataAccess.Migrations
{
    public partial class OwnerEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Chathumini Dasanayake", "0712400284" },
                    { 2, "Nadeesh Fernando", "0774964200" },
                    { 3, "Chandrakeerthi Dasanayake", "0718070325" },
                    { 4, "Nilanthi Adikari", "0718195376" },
                    { 5, "Anjana Dasanayake", "0713620646" }
                });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 13, 33, 390, DateTimeKind.Local).AddTicks(2058), 1 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8419), 2 });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Catogery", "Color", "Date", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { 3, "Dog", "Brown and White", new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8467), "Kelly", 3, 0 },
                    { 4, "Dog", "Black", new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8475), "Kikki", 4, 0 },
                    { 5, "Cat", "Ash", new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8481), "Kitty", 5, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Owners_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Owners_OwnerId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Pets");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 4, 13, 52, 20, 822, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 4, 13, 52, 20, 827, DateTimeKind.Local).AddTicks(5238));
        }
    }
}
