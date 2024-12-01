using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e48ad21e-8e6a-461a-bf4c-ee79bc3f428a", "AQAAAAIAAYagAAAAEIktvaRTpsvflDEZAVjYf/Enxg4FbwXQgQdpg2EUolxinCKqhvmIzSKOAv5TqT2lcA==", "6076e41e-9711-462b-a923-a4955cba57ee" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 79, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 11, 29, 12, 13, 19, 79, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 79, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 11, 29, 12, 13, 19, 79, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(870), new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 11, 29, 12, 13, 19, 80, DateTimeKind.Local).AddTicks(876) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bf7922d-e17e-47f6-a1a7-6f68e54a761b", "AQAAAAIAAYagAAAAEDzkv4lFdKW696fq000HrTD5y2McQf8gbAb6qu+RcQfyt1Hi2Og8oSwd4W4S7kA/OA==", "0eb56775-f390-4498-93aa-64f474e75505" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7743), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7945), new DateTime(2024, 11, 29, 12, 11, 32, 847, DateTimeKind.Local).AddTicks(7945) });
        }
    }
}
