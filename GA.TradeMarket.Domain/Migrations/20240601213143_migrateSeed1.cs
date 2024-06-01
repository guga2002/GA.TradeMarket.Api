using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateSeed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 2, 1, 31, 42, 465, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LogTime",
                value: new DateTime(2024, 6, 2, 1, 31, 42, 466, DateTimeKind.Local).AddTicks(10));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 2, 1, 29, 49, 845, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LogTime",
                value: new DateTime(2024, 6, 2, 1, 29, 49, 845, DateTimeKind.Local).AddTicks(3922));
        }
    }
}
