using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainigBoxingApp.Migrations
{
    public partial class NewMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 11, 11, 40, 0, 385, DateTimeKind.Local).AddTicks(4686));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 11, 11, 29, 18, 807, DateTimeKind.Local).AddTicks(794));
        }
    }
}
