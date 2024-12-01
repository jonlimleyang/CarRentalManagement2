using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 535, DateTimeKind.Local).AddTicks(3362), new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(8165), new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(8171), new DateTime(2024, 12, 1, 16, 13, 12, 537, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1235), new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 12, 1, 16, 13, 12, 538, DateTimeKind.Local).AddTicks(1238) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 56, DateTimeKind.Local).AddTicks(5743), new DateTime(2024, 12, 1, 16, 5, 51, 58, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 58, DateTimeKind.Local).AddTicks(2736), new DateTime(2024, 12, 1, 16, 5, 51, 58, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3148), new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 12, 1, 16, 5, 51, 59, DateTimeKind.Local).AddTicks(3159) });
        }
    }
}
