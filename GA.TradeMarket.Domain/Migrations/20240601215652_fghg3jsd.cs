using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fghg3jsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439034435", new DateTime(2025, 5, 14, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343433634435", new DateTime(2024, 7, 27, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343411434435", new DateTime(2024, 8, 28, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34343234435", new DateTime(2024, 8, 15, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343423434435", new DateTime(2025, 4, 5, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34343034435", new DateTime(2024, 6, 12, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpiryDate",
                value: new DateTime(2025, 1, 31, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343424634435", new DateTime(2025, 3, 14, 1, 56, 51, 633, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 1L, 2.7m, "USD", new DateTime(2024, 6, 2, 1, 56, 51, 632, DateTimeKind.Local).AddTicks(9848), 2.8m },
                    { 2L, 2.9m, "EUR", new DateTime(2024, 6, 2, 1, 56, 51, 632, DateTimeKind.Local).AddTicks(9861), 2.85m },
                    { 3L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 56, 51, 632, DateTimeKind.Local).AddTicks(9862), 2.85m }
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

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343427734435", new DateTime(2025, 3, 7, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343417134435", new DateTime(2025, 8, 16, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34342734435", new DateTime(2025, 1, 3, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34344234435", new DateTime(2025, 2, 25, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343419334435", new DateTime(2024, 8, 15, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343452134435", new DateTime(2025, 7, 7, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpiryDate",
                value: new DateTime(2025, 4, 20, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343410934435", new DateTime(2024, 10, 13, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5890) });
        }
    }
}
