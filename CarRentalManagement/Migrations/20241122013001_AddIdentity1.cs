using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(7706), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8048), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 11, 19, 12, 50, 46, 924, DateTimeKind.Local).AddTicks(8163) });
        }
    }
}
