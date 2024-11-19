using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1045), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1047), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
