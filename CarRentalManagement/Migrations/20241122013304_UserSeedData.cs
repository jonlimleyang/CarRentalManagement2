using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class UserSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7642), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 11, 22, 9, 33, 4, 224, DateTimeKind.Local).AddTicks(8126) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
