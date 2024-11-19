using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(8910), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(8924), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9146), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9149), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9232), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9235), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9235), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9237), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 11, 19, 12, 19, 24, 984, DateTimeKind.Local).AddTicks(9239), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 11, 19, 12, 12, 30, 80, DateTimeKind.Local).AddTicks(1047) });
        }
    }
}
