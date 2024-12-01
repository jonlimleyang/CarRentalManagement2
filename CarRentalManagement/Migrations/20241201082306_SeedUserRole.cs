using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 219, DateTimeKind.Local).AddTicks(7623), new DateTime(2024, 12, 1, 16, 23, 2, 221, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 221, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 12, 1, 16, 23, 2, 221, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 222, DateTimeKind.Local).AddTicks(9351), new DateTime(2024, 12, 1, 16, 23, 2, 222, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 222, DateTimeKind.Local).AddTicks(9359), new DateTime(2024, 12, 1, 16, 23, 2, 222, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3185), new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3188), new DateTime(2024, 12, 1, 16, 23, 2, 223, DateTimeKind.Local).AddTicks(3189) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
