using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e48ad21e-8e6a-461a-bf4c-ee79bc3f428a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIktvaRTpsvflDEZAVjYf/Enxg4FbwXQgQdpg2EUolxinCKqhvmIzSKOAv5TqT2lcA==", null, false, "6076e41e-9711-462b-a923-a4955cba57ee", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }
    }
}
