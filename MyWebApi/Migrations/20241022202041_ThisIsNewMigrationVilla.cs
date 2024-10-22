using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ThisIsNewMigrationVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 20, 40, 648, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 20, 40, 663, DateTimeKind.Local).AddTicks(5270), "Fusce 111 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 20, 40, 663, DateTimeKind.Local).AddTicks(5290), "Fusce 112 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 20, 40, 663, DateTimeKind.Local).AddTicks(5290), "Fusce 114 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 20, 40, 663, DateTimeKind.Local).AddTicks(5290), "Fusce 113 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 13, 8, 303, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8040), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8050), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8050), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8060), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });
        }
    }
}
