using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "12d22088-fd47-4066-8228-1bd6c91843c3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENMb9l3GBkzt63HrZhB/QQBBB72xAuKxz07qAYKQjXaqKumz4B0qdJm9Tb+FmZ0tkg==", null, false, "87b3db66-ed28-46c0-87be-21e5ce13b08c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2484), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 11, 22, 9, 38, 56, 22, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
