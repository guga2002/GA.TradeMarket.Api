using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 1L, 1.0m, "USD", new DateTime(2024, 6, 2, 1, 29, 49, 845, DateTimeKind.Local).AddTicks(3910), 1.0m },
                    { 2L, 0.85m, "EUR", new DateTime(2024, 6, 2, 1, 29, 49, 845, DateTimeKind.Local).AddTicks(3922), 0.85m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
