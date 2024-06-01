using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateSeed13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "DiscountValue", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "GE343430034435", 45m, new DateTime(2025, 7, 16, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4872) },
                    { 2L, "GE343453134435", 467m, new DateTime(2024, 8, 15, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4976) },
                    { 3L, "GE343435834435", 457m, new DateTime(2025, 1, 12, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4979) },
                    { 4L, "GE343451234435", 48m, new DateTime(2025, 7, 28, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4982) },
                    { 5L, "GE343444234435", 45m, new DateTime(2025, 9, 10, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4985) },
                    { 6L, "GE343442934435", 25m, new DateTime(2025, 9, 8, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4988) },
                    { 7L, "GE34345934435", 15m, new DateTime(2025, 4, 25, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4991) },
                    { 8L, "GE343435534435", 78m, new DateTime(2025, 1, 27, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4994) }
                });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Buy", "LogTime", "Sell" },
                values: new object[] { 2.7m, new DateTime(2024, 6, 2, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4449), 2.8m });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Buy", "LogTime", "Sell" },
                values: new object[] { 2.9m, new DateTime(2024, 6, 2, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4472), 2.85m });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[] { 3L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4474), 2.85m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Buy", "LogTime", "Sell" },
                values: new object[] { 1.0m, new DateTime(2024, 6, 2, 1, 31, 42, 465, DateTimeKind.Local).AddTicks(9998), 1.0m });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Buy", "LogTime", "Sell" },
                values: new object[] { 0.85m, new DateTime(2024, 6, 2, 1, 31, 42, 466, DateTimeKind.Local).AddTicks(10), 0.85m });
        }
    }
}
