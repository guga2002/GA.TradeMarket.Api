using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fghg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343448734435", new DateTime(2025, 5, 19, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343421234435", new DateTime(2025, 9, 13, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439934435", new DateTime(2024, 10, 19, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343436134435", new DateTime(2025, 5, 30, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34342234435", new DateTime(2024, 9, 4, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343442434435", new DateTime(2024, 12, 12, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34344234435", new DateTime(2024, 8, 20, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439234435", new DateTime(2025, 8, 18, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 5L, 2.7m, "USD", new DateTime(2024, 6, 2, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5274), 2.8m },
                    { 6L, 2.9m, "EUR", new DateTime(2024, 6, 2, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5287), 2.85m },
                    { 7L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5288), 2.85m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343430034435", new DateTime(2025, 7, 16, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343453134435", new DateTime(2024, 8, 15, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343435834435", new DateTime(2025, 1, 12, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343451234435", new DateTime(2025, 7, 28, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343444234435", new DateTime(2025, 9, 10, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343442934435", new DateTime(2025, 9, 8, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34345934435", new DateTime(2025, 4, 25, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343435534435", new DateTime(2025, 1, 27, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 1L, 2.7m, "USD", new DateTime(2024, 6, 2, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4449), 2.8m },
                    { 2L, 2.9m, "EUR", new DateTime(2024, 6, 2, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4472), 2.85m },
                    { 3L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 40, 49, 778, DateTimeKind.Local).AddTicks(4474), 2.85m }
                });
        }
    }
}
