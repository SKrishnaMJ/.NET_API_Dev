using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTablewithchangesyup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 13, 8, 315, DateTimeKind.Local).AddTicks(8060));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 4, 57, 208, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 4, 57, 222, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 4, 57, 222, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 4, 57, 222, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 15, 4, 57, 222, DateTimeKind.Local).AddTicks(9540));
        }
    }
}
