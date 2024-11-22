using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1246), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1572), new DateTime(2024, 11, 22, 9, 32, 13, 191, DateTimeKind.Local).AddTicks(1573) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 609, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 11, 22, 9, 30, 0, 609, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 609, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 11, 22, 9, 30, 0, 609, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(142), new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(198), new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 11, 22, 9, 30, 0, 610, DateTimeKind.Local).AddTicks(202) });
        }
    }
}
